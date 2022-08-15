#include<bits/stdc++.h>
using namespace std;
int n,m,a[1005][1005],c[1005][1005];
int sol(int x)
{
	int res = 0; 
	for(int i=1;i<=n;i++)
	for(int j=1;j<=m;j++)
	{
		if(a[i][j]!=x) c[i][j]=0;
		else if(i==1||j==1) c[i][j]=1;
		else 
		{
			int k=min(c[i-1][j],c[i][j-1]);
			c[i][j]=k+(a[i-k][j-k]==x);
		}
		if(res<c[i][j]) res=c[i][j];
	}
	return res;
}
int main()
{
	cin>>n>>m;
	for(int i=1;i<=n;i++)
	for(int j=1;j<=m;j++) cin>>a[i][j];
	cout<<max(sol(0),sol(1));
}


