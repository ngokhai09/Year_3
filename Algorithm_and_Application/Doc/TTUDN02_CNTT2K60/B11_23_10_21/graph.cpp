#include<bits/stdc++.h>
using namespace std;
class graph
{
	int n,m,x[1000],d[10000];
	map<int,set<int>> A;  //A[1]={}
	void nhap(string fn)
	{
		ifstream fin(fn);
		fin>>n>>m;
		for(int i=1;i<=m;i++)
		{
			int u,v;
			fin>>u>>v; A[u].insert(v);
		}
		fin.close();
	}
	void TRY(int k,int f)
	{
		if(x[k]==f) {for(int i=1;i<=k;i++) cout<<x[i]<<(i==k?"\n":"->"); return;}
		for(auto t:A[x[k]])
		if(d[t]==0)
		{
			d[t]=1;
			x[k+1]=t;
			TRY(k+1,f);
			d[t]=0;
		}
	}
	public: void sol()
	{
		nhap("g.txt");
		do
		{
			int f;
			cout<<"s = "; cin>>x[1];
			cout<<"f = "; cin>>f;
			if(x[1]==0 || f==0) break;
			fill(d,d+n+1,0); d[x[1]]=1;
			TRY(1,f);
		}while(1);
	}
};
int main()
{
	graph G; 
	G.sol();
}


