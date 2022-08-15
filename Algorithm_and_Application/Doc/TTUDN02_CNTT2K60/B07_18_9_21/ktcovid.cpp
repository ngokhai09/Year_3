#include<bits/stdc++.h>
using namespace std;
int main()
{
	int n,m,u,v,F[100005]={},d[100005];
	cin>>n>>m;
	vector<int> A[100005];
	fill(d,d+n+1,-1);
	for(int i=1;i<=m;i++) {cin>>u>>v; A[u].push_back(v); A[v].push_back(u);}
	queue<int> Q;
	cin>>F[0];
	for(int i=0;i<F[0];i++) {int x; cin>>x; Q.push(x); d[x]=0;}
	while(Q.size())
	{
		int u=Q.front(); Q.pop();
		for(int v:A[u]) 
		if(d[v]==-1){d[v]=d[u]+1; F[d[v]]++;Q.push(v);}
	}
	for(int i=0;F[i];i++) cout<<"F"<<i<<": "<<F[i]<<"\n";
}


