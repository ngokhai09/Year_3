#include<bits/stdc++.h>
using namespace std;
class Knight
{
	int a[15][15]={},n,s,f;
	bool xuat()
	{
		for(int i=2;i<=n+1;i++)
		{
			cout<<"\n";
			for(int j=2;j<=n+1;j++) cout<<setw(3)<<a[i][j];
		}
		return true;
	}
	bool TRY(int u,int v,int k)
	{
		if(k>n*n) return xuat();
		for(int i:{-2,-1,2,1})
		for(int j:{-3+abs(i),3-abs(i)})
		if(a[u+i][v+j]==0)
		{
			a[u+i][v+j]=k;
			if(TRY(u+i,v+j,k+1)) return true;
			a[u+i][v+j]=0;
		}
		return false;
	}
	public:void sol()
	{
		cin>>n;
		for(int i=0;i<=n+3;i++) 
		a[i][0]=a[0][i]=a[i][1]=a[1][i]=a[i][n+2]=a[n+2][i]=a[i][n+3]=a[n+3][i]=-1;
		cin>>s>>f; 
		s++;f++;
		a[s][f]=1;
		TRY(s,f,2);
	}
};
int main()
{
	Knight Ma; Ma.sol();
}


