#include<bits/stdc++.h>
#define x first
#define y second
using namespace std;


int main()
{	
	int n, m, F[10001], d[10001];
	vector<int> a[10001];
	queue<int> q;
	int u, v;
	cin >> n >> m;
	fill(d, d + n + 1, -1);	
	for(int i = 0; i < m; i++){
		cin >> u >> v;
		a[u].push_back(v);
		a[v].push_back(u);
	}
	cin >> F[0];
	for(int i = 0; i < F[0]; i++){
		cin >> u;
		q.push(u);
		d[u] = 0;
	}
	while(!q.empty()){
		int x = q.front(); q.pop();
		for(auto i : a[x]){
			if(d[i] == -1){
				d[i] = d[x] + 1;
				F[d[i]]++;
				q.push(i);
			}
		}
	}	
	for(int i = 0; F[i]; i++){
		cout << "F" << i << ": " << F[i] << endl;
	}
}


