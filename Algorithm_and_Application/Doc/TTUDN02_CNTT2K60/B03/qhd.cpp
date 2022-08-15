#include<bits/stdc++.h>
using namespace std;
int main()
{
	int n,a[100],C[10000]={},M,inf=1e9;
	cin>>n;
	for(int i=1;i<=n;i++) cin>>a[i];
	cin>>M;
	for(int j=1;j<=M;j++) C[j]=inf;
	for(int i=1;i<=n;i++)
	for(int j=a[i];j<=M;j++) C[j]=min(C[j],1+C[j-a[i]]);
	cout<<C[M];
}


