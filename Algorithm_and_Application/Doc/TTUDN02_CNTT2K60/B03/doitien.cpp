//tham lam
#include<bits/stdc++.h>
using namespace std;
class money
{
	int n,*a=NULL,M;
	public:
	void read(string fname)
	{
		ifstream fin(fname);
		fin>>n;
		a=new int[n];
		for(int i=0;i<n;i++) fin>>a[i];
		fin.close();
		sort(a,a+n,greater<int>());
	}
	void greedy()
	{
		cin>>M; if(M==0) return;
		int res=0;  
		for(int i=0;i<n;i++)
		{
			res+=M/a[i];
			M%=a[i];
		}
		if(M) cout<<"\nKhong doi duoc van con du tien\n";
		else cout<<"\nSo to it nhat la "<<res<<endl;
		return greedy();
	}
	~money() {if(a) delete []a;}
};
int main()
{
	money M; M.read("tien.txt"); M.greedy();
}


