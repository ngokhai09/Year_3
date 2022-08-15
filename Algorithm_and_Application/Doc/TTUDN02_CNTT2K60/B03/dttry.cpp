//tham lam
#include<bits/stdc++.h>
using namespace std;
class money
{
	int n,*a=NULL,M,res=INT_MAX;
	public:
	void read(string fname)
	{
		ifstream fin(fname);
		fin>>n;
		a=new int[n+5];
		for(int i=1;i<=n;i++) fin>>a[i];
		fin.close();
	}
	void TRY(int k,int t,int T)
	{
		if(k==n)
		{
			if((M-T)%a[n]==0 && res>t+(M-T)/a[n]) res=t+(M-T)/a[n];
		}
		else for(int x=0;x*a[k]+T<=M && x+t<res; x++) TRY(k+1,t+x,T+a[k]*x);
	}
	void sol()
	{
		cin>>M; if(M==0) return;
		res=M+1;
		TRY(1,0,0);
		if(res==M+1) cout<<"\nKhong doi duoc\n";
		else cout<<"\nSo to it nhat "<<res<<endl;
		return sol();
	}
	~money() {if(a) delete []a;}
};
int main()
{
	money M; M.read("tien.txt"); M.sol();
}


