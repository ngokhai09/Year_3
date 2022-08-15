#include<bits/stdc++.h>
using namespace std;

struct anh
{
	int a[100][100],n,m;
	multiset<int> Res;
	void nhap()
	{
		cin>>n>>m;
		for(int i=1;i<=n;i++)
		for(int j=1;j<=m;j++) cin>>a[i][j];
		for(int i=0;i<=n+1;i++) a[i][0]=a[i][m+1]=2;
		for(int j=0;j<=m+1;j++) a[0][j]=a[n+1][j]=2;
	}
	void dfs(int x,int y)
	{
		stack<pair<int,int>> S;
		int d=1;
		S.push({x,y}); a[x][y]=3;
		while(S.size())
		{
			pair<int,int> u=S.top(); S.pop();
			for(int i=-1;i<=1;i++)
				for(int j=-1;j<=1;j++)
				if(a[u.first+i][u.second+j]==0)
				{
					a[u.first+i][u.second+j]=3;
					S.push({u.first+i,u.second+j});
					d++;
				}
		}
		Res.insert(d);
	}
	void bfs(int x,int y)
	{
		queue<pair<int,int>> S;
		int d=1;
		S.push({x,y}); a[x][y]=3;
		while(S.size())
		{
			pair<int,int> u=S.front(); S.pop();
			for(int i=-1;i<=1;i++)
				for(int j=-1;j<=1;j++)
				if(a[u.first+i][u.second+j]==0)
				{
					a[u.first+i][u.second+j]=3;
					S.push({u.first+i,u.second+j});
					d++;
				}
		}
		Res.insert(d);
	}
	void sol()
	{
		nhap();
		for(int i=1;i<=n;i++)
		for(int j=1;j<=m;j++) if(a[i][j]==0) bfs(i,j);
		cout<<Res.size()<<"\n";
		for(auto r:Res) cout<<r<<" ";
	}
};

int main()
{
	anh A; A.sol();
}


