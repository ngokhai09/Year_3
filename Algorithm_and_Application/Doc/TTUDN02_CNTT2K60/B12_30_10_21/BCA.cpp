#include<bits/stdc++.h>
using namespace std;
class BCA
{
	int m,n,X[35][35]={},z[35],dem=0,A[11][35]={},Min=32;
	public:void sol()
	{
		int k,u,v,x;
		cin>>m>>n;
		for(int i=1;i<=m;i++)
		{
			cin>>k;
			while(k--)
			{
				cin>>x;
				A[i][x]=1;
			}
		}
		cin>>k;
		while(k--)
		{
			cin>>u>>v;
			X[u][v]=X[v][u]=1;
		}
		TRY(1);
		if(Min==32) Min=-1;
		cout<<Min;
	}
	void TRY(int k)
	{
		if(k>n) 
		{
			//for(int i=1;i<k;i++) cout<<z[i]<<" ";
			//cout<<"\n";
			int kq=0;
			for(int i=1;i<=m;i++)
			{
				int tt=0;
				for(int j=1;j<=n;j++) tt+=z[j]==i;
				if(tt>kq) kq=tt;
			}
			if(Min>kq) Min=kq;
			return;
		}
		for(int t=1;t<=m;t++)
		if(A[t][k]==1)
		{
			int ok=1;
			for(int j=1;j<k;j++)
			if(z[j]==t && X[j][k]==1) {ok=0;break;}
			if(ok)
			{
				z[k]=t;
				TRY(k+1);
			}
		}
	}
	
};
int main()
{
	BCA B;
	B.sol();

}


