//dtqhd
#include<bits/stdc++.h>
using namespace std;
class money
{
	int n,a[100],C[100][100]={},M,inf=1e9;
	void buocthuan()
	{
		for(int j=1;j<=M;j++) C[0][j]=inf;
		for(int i=1;i<=n;i++)
		for(int j=0;j<=M;j++)
		if(j<a[i]) C[i][j]=C[i-1][j];
		else C[i][j]=min(C[i-1][j],1+C[i][j-a[i]]);
	}
	string trace(int n,int M)
	{
		if(C[n][M]==0) return "";
		while(C[n][M]==C[n-1][M]) n--;
		return trace(n,M-a[n])+"+"+to_string(a[n]);
	}
	public: void sol()
	{
		cin>>n;
		for(int i=1;i<=n;i++) cin>>a[i];
		cin>>M;
		buocthuan();
		if(C[n][M]==inf) cout<<"\nKhog doi duoc";
		else 
		{
			cout<<"\nSo to it nhat "<<C[n][M]<<"\n\b";
			cout<<trace(n,M).substr(1);
		}
	}
};
int main()
{
 	money M; M.sol();
}


