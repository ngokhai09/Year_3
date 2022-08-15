//phuong trinh nghiem nguyen
#include<bits/stdc++.h>
using namespace std;

int d=0;
void TRY(int *x,int k,int T,int n,int M)
{
	if(k==n) 
	{	
		x[n]=M-T;
		cout<<"\n"<<++d<<" : "; 
		for(int i=1;i<=n; i++) cout<<x[i]<<" "; 
		return;
	}
	for(x[k]=0; T+x[k]<=M; x[k]++) TRY(x,k+1,T+x[k],n,M);
}
int main()
{
	int x[100],n,M;
	cin>>n>>M;
	TRY(x,1,0,n,M);
	cout<<"\nCo "<<d<<" nghiem ";
}


