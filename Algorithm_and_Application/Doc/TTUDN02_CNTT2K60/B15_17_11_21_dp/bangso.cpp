//bang so
#include<bits/stdc++.h>
using namespace std;
int n,m,a[1006][1006]={};

void trace(int u,int v)
{
	if(u==0 ||v==0) return;
	if(u==1 or a[u-1][v]<a[u][v-1]) trace(u,v-1);
	else trace(u-1,v);
	cout<<"("<<u<<","<<v<<") ";
}
int main()
{
	cin>>n>>m;
	for(int i=1;i<=n;i++) 
	for(int j=1;j<=m;j++) cin>>a[i][j];
	for(int i=1;i<=n;i++)
	for(int j=1;j<=m;j++)
	if(i==1) a[i][j]+=a[i][j-1];
	else if(j==1) a[i][j]+=a[i-1][j];
	else a[i][j]+= max(a[i-1][j],a[i][j-1]);
	cout<<a[n][m]<<"\n";
	trace(n,m);
}


