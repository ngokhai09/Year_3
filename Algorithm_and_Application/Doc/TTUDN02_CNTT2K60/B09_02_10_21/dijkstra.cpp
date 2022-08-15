//dijkstra
#include<bits/stdc++.h>
using namespace std;
map<int,int> P;
void path(int s,int f)
{
	if(s==f) cout<<s;
	else {path(s,P[f]); cout<<"->"<<f;}
}
int main()
{
	int n,m,s;
	cin>>n>>m>>s;
	vector<pair<int,int>> A[n+5]; //A[1]=<(16,2),(14,4)>
	priority_queue<pair<int,int>,vector<pair<int,int>>,greater<pair<int,int>>> Q;
	//second-dinh, first-do dai ngan nhat tu xuat phat den second
	int L[n+5];  //L[i] can tim do dai dd ngan nhat tu s den i
	for(int i=1;i<=m;i++)
	{
		int u,v,w;
		cin>>u>>v>>w; 
		A[u].push_back({w,v});
		L[i]=1e9;
	}
	Q.push({0,s}); L[s]=0;
	while(Q.size())
	{
		pair<int,int> u=Q.top(); Q.pop();
		if(u.first>L[u.second]) continue;   //bo qua truong hop khong can xet
		for(auto v:A[u.second])
		if(L[v.second]>u.first+v.first)
		{
			L[v.second]=u.first+v.first;
			Q.push({u.first+v.first,v.second});
			P[v.second]=u.second;
		}
	}
	for(int i=1;i<=n;i++)
	if(L[i]==1e9) cout<<"\nKhong co duong di "<<s<<" den "<<i;
	else 
	{
		cout<<"\n"<<s<<" - > "<<i<<" : "<<L[i]<<" : ";
		path(s,i);
	}
}


