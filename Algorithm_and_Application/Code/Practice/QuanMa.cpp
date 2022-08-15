#include<bits/stdc++.h>
#define x first
#define y second
using namespace std;
int n, a[15][15], s, f;
int d[] {-2, -1, 2, 1};
bool xuat(){
	for(int i = 2; i < n + 2; i++){
		for(int j = 2; j < n + 2; j++){
			cout  << setw(3) << a[i][j];
		}
		cout << endl;
	}
	return true;
}
bool Try(int u, int v, int k){
	if(k > n * n) {
		return xuat();
	}
	for(auto i: d){
		for(auto j: {-3 + abs(i), 3 - abs(i)}){
			if(!a[u + i][v + j]){
				a[u + i][v + j] = k;
				if(Try(u + i, v + j, k + 1)) return true;
				a[u + i][v + j] = 0;
			}
		}
	}
	return false;	
}

int main()
{
	cin >> n;
	for(int i = 0; i <= n + 3; i++){
		a[0][i] = a[i][0] = a[n + 2][i] = a[i][n + 2] = a[i][1] = a[1][i] = a[i][n + 3] = a[n + 3][i] = -1;
	}
	cin >> s >> f;
	s++;f++;
	a[s][f] = 1;
	if(!Try(s,f,2)) cout << "Khong co duong di";
}


