//hinh chu nhat co tong lon nhat
#include<bits/stdc++.h>
using namespace std;
int a[1005][1005],n,c[1005][1005];
int main()
{
	int res=-INT_MAX;
	cin>>n;
	for(int i=1;i<=n;i++)
	for(int j=1;j<=n;j++) cin>>a[i][j];
	
	for(int i=1;i<=n;i++)
	for(int j=1;j<=n;j++) c[i][j]=c[i-1][j]+c[i][j-1]-c[i-1][j-1]+a[i][j];
	
	for(int i=1;i<=n;i++)
	for(int j=1;j<=n;j++)
	{
		for(int u=0;u<=i;u++)
		for(int v=0;v<=j;v++)
		{
			int k=c[i][j]-c[i][v]-c[u][j]+c[u][v];
			if(k>res) res=k;
		}
	}
	cout<<res;
}


