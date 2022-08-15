//nhung bong hoa
#include<bits/stdc++.h>
using namespace std;
typedef pair<int,int> pii;
#define vitri second
#define giatri first

//bool ss(pii u,pii v){return u.giatri!=v.giatri?u.giatri<v.giatri:u.vitri<v.vitri;}
//struct cmp
//{
//	bool operator()(pii u,pii v)
//	{
//		return u.giatri!=v.giatri?u.giatri<v.giatri:u.vitri<v.vitri;
//	}
//};
int main()
{
	int n;
	cin>>n;
	pii A[n+5];
	bool d[n+5]={};
	int res=0;
	for(int i=1;i<=n;i++) {A[i].vitri=i; cin>>A[i].giatri;}
	sort(A+1,A+n+1);
	for(int i=1;i<=n;i++)
	if(d[A[i].vitri]==0)
	{
		d[A[i].vitri-1]=d[A[i].vitri]=d[A[i].vitri+1]=1;
		res++;
	}
	cout<<res;
}


