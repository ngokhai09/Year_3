#include<bits/stdc++.h>
using namespace std;
map<int,bool> M;
void TRY(int *x,int k, int n) //gia su da di duoc k-1
{
	if(k>n) 
	{
		for(int i=1;i<=n;i++) cout<<x[i]<<"->"<<n+x[i]<<" ";
		cout<<"\n";
		return;
	}
	for(int t=1;t<=n;t++)
	if(!M[t])
	{
		M[t]=1;
		x[k]=t;
		TRY(x,k+1,n);
		M[t]=0;
	}	
}
int main()
{
	int x[1000],n;
	cin>>n;
	TRY(x,1,n);
}


