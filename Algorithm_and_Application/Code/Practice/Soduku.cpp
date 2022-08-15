#include<bits/stdc++.h>
#define x first
#define y second
#define n 9
using namespace std;
int a[n][n];
bool check(int u, int v,int t){
	for(int i = 0; i < n; i++) {
		if(a[i][v] == t or a[u][i] == t){
			return false;
		}
	}
	for(int i = u / 3 * 3; i < u / 3 * 3 + 3; i++){
		for(int j = v / 3 * 3; j < v / 3 * 3 + 3; j++){
			if(a[i][j] == t){
				return false;
			}
		}		
	}
	return true;
}
void input(){
	for(int i = 0; i < n; i++){
		for(int j = 0; j < n; j++){
			cin >> a[i][j];
		}
	}
}
void ouput(){
		for(int i = 0; i < n; i++){
			for(int j = 0; j < n; j++){
				cout << a[i][j] << " ";
		}
		cout << endl;
	}
}
void sol(int u, int v){
	if(u > 8){
		ouput();
		return;
	}
	if(a[u][v] != 0) sol(u + v / 8, (v + 1)%9);
	else{
		for(int i = 1 ; i <= n ; i++){
			if(check(u, v, i)){
				a[u][v] = i;
				sol(u + v / 8, (v + 1)%9);
				a[u][v] = 0;
			}
		}
	}
}
int main()
{
	input();
	sol(0, 0);	
}


