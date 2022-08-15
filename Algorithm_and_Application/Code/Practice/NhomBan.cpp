#include<bits/stdc++.h>
#define x first
#define y second
using namespace std;
int n,  m, visit[100001];
vector<int> V[1000001];
priority_queue<int> Res;
queue<int> q;
void sol(){	
	for(int i = 1; i <= n; i++){
		int cnt = 0;
		if(!visit[i]){
			q.push(i);
			visit[i] = 1;
			cnt = 1;
		}		
		while(!q.empty()){
			int index = q.front();
			q.pop();
			for(auto j: V[index]){
				if(!visit[j]){
					visit[j] = 1;
					q.push(j);
					cnt++;
				}
			}
		}
		if(cnt)
			Res.push(cnt);
	}
}
int main()
{
	cin >> n >> m;
	int u, v;
	for(int i = 0; i < m; i++){
		cin >> u >> v;
		V[u].push_back(v);
		V[v].push_back(u);
	}
	sol();
	cout << Res.size() << endl;
	cout << Res.top();
}


