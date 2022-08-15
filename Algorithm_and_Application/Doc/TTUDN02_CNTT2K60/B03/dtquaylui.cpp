//tham lam
#include<bits/stdc++.h>
using namespace std;
class money
{
	int n,*a=NULL,M,res=INT_MAX,pa[10000];
	public:
	void read(string fname)
	{
		ifstream fin(fname);
		fin>>n;
		a=new int[n+5];
		for(int i=1;i<=n;i++) fin>>a[i];
		
		fin.close();
	}
	void TRY(int *x,int k,int t,int T)
	{
		if(k==n)
		{
			if((M-T)%a[n]==0) 
			{
				if(res>t+(M-T)/a[n])
				{
					for(int i=1;i<n;i++) pa[i]=x[i]; pa[n]=(M-T)/a[n];
					res=t+(M-T)/a[n];
				}
			}	
			return;
		}
		for(x[k]=0;x[k]*a[k]+T<=M && x[k]+t<res; x[k]++)
			TRY(x,k+1,t+x[k],T+a[k]*x[k]);
	}
	void sol()
	{
		cin>>M; if(M==0) return;
		res=M+1;
		int x[n+5];
		TRY(x,1,0,0);
		if(res==M+1) cout<<"\nKhong doi duoc\n";
		else 
		{
			cout<<"\nSo to it nhat "<<res<<endl;
			for(int i=1;i<=n;i++) cout<<pa[i]<<" ";
			cout<<"\n";
		}
	}
	~money() {if(a) delete []a;}
};
int main()
{
	money M; M.read("tien.txt"); M.sol();
}


