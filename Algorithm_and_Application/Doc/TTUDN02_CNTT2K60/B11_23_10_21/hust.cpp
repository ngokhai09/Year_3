//ITC-K62+HUST=N
#include<bits/stdc++.h>
using namespace std;

//I,T,C,K,H,U,S,
int d[100]={};
int dem=0;
void TRY(int *x,int k,int N)
{
	if(k==7) 
	{
		if(x[1]*100+x[2]*10+x[3]-x[4]*100-62+x[5]*1000+x[6]*100+x[7]*10+x[2]==N){ 
		cout<<x[1]<<x[2]<<x[3]<<"-"<<x[4]<<"62+"<<x[5]<<x[6]<<x[7]<<x[2]<<"="<<N<<"\n";
		dem++;}
	}
	else 
	{
		for(int t=1;t<=9;t++) 
		if(d[t]==0)
		{
			d[t]=1;
			x[k+1]=t;
			TRY(x,k+1,N);
			d[t]=0;
		}
	}
}
int main()
{
	int N,x[10];
	cin>>N;
	TRY(x,0,N);
	cout<<"\n kq:"<<dem;
}


