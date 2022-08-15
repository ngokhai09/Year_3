#include<bits/stdc++.h>
using namespace std;
class TSP
{
	int n,a[25][25],d[20]={},res=1e9,cmin=1e9;
	public:void sol()
	{
		cin>>n;
		for(int i=1;i<=n;i++) 
		for(int j=1;j<=n;j++) {cin>>a[i][j];if(a[i][j]>0 && cmin>a[i][j]) cmin=a[i][j];}
		TRY(1,1,0);
		cout<<res;
	}
	void TRY(int x,int k,int T) //1->....->x da di k dinh
	{
		if(k==n) res=min(res,T+a[x][1]);
		else 
		{
			for(int t=2;t<=n;t++)
			if(d[t]==0)
			{
				d[t]=1;
				if(T+a[x][t] + cmin*(n-k)<res) TRY(t,k+1,T+a[x][t]);
				d[t]=0;
			}
		}
	} 
};
int main()
{
	freopen("a5.in","r",stdin);
	freopen("a5.out","w",stdout);
	TSP Z; Z.sol();
}


