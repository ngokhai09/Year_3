#include<bits/stdc++.h>
using namespace std;
class xcc
{
	string x,y;
	int n,m,c[100][100]={};
	void dp() //dynamic programming
	{
		for(int i=1;i<=n;i++)
		for(int j=1;j<=m;j++)
		c[i][j]=x[i]==y[j]?1+c[i-1][j-1]:max(c[i-1][j],c[i][j-1]);
	}
	void trace(int u,int v,set<string> &B)
	{
		set<string> C;
		if(c[u][v]==0) return;
		if(c[u][v]==c[u-1][v]) trace(u-1,v,B);
		if(c[u][v]==c[u][v-1]) trace(u,v-1,C);
		for(auto z:C) B.insert(z);
	//	if(c[u][v]>c[u-1][v]&&c[u][v]>c[u][v-1] || x[]) 
		if(x[u]==y[v])
		{
			C.clear();
			trace(u-1,v-1,C);
			B.clear();
			if(C.size()) for(auto z:C) {z.push_back(x[u]); B.insert(z);}
			else B.insert(string(1,x[u]));
		}
	 
	}
	public: void sol()
	{
		cin>>x>>y; n=x.length(); m=y.length();
		x="$"+x; y="$"+y;
		dp();
		cout<<"\nDo dai xccdn "<<c[n][m]<<"\n";
		set<string> A;
		trace(n,m,A);
		for(auto z:A) cout<<z<<"\n";
	}
};
int main(){xcc X; X.sol();}


