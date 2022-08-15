#include<bits/stdc++.h>
#define x first
#define y second
using namespace std;
int n, start;
int a[15][15], visit[15];
priority_queue<int, vector<int>, greater<int>> Q;
void Try(int city, int cnt, int res){
	if(cnt == n){
		if(city == 0){
			Q.push(res);
		}
			
		return;
	}
	for(int i = 0; i < n; i++){
		if(!visit[i] and city != i){
			visit[i] = 1;
			Try(i, cnt + 1, res + a[city][i]);
			visit[i] = 0;
		}
	}
}
int main()
{
	cin >> n;
	for(int i = 0; i < n; i++){
		for(int j = 0; j < n; j++){
			cin >> a[i][j];
		}
	}
	for(int i = 1; i < n; i++){
		start = i;
		visit[i] = 1;
		Try(i, 1, a[0][i]);
		visit[i] = 0;
	}
	cout << Q.top();
}


