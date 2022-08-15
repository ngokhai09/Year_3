#include<bits/stdc++.h>
using namespace std;
#define v first
#define w second
class balo
{
	int n,res=0,M,test,t[105]={};
	pair<int,int> A[105];
	public:void sol()
	{
		int k=0;
		cin>>n;
		for(int i=1;i<=n;i++) 
		{
			cin>>A[i].w>>A[i].v;
			if(A[i].w<=10000) {k++; A[k]=A[i];}
		}
		n=k;
		sort(A+1,A+n+1,greater<pair<int,int>>());
		for(int i=n;i>=1;i--) t[i]=t[i+1]+A[i].v;
		cin>>test;
		while(test--)
		{
			cin>>M; res=0;
			TRY(0,0,0);
			cout<<res<<"\n";
		}
	}
	void TRY(int k,int W,int V)
	{
		if(k==n) res=max(res,V);
		else
		{
			if(W+A[k+1].w<=M && V+A[k+1].v+t[k+2]>res) TRY(k+1,W+A[k+1].w,V+A[k+1].v); //co chon 
			TRY(k+1,W,V);  //khong chon vat thu k+1
		}
	}
};
int main()
{
	balo B; B.sol();

}


