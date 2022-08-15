//lan son
#include<bits/stdc++.h>
using namespace std;
int main()
{
	ios_base::sync_with_stdio(false);
    cin.tie(NULL);
	int n,m,k,l,r,res=0;
	cin>>n>>m>>k;
	int a[m+1]={};
	while(n--)
	{
		cin>>l>>r;
		a[l]++;
		a[r]--;
	}
	partial_sum(a,a+m+1,a);
	for(int i=0;i<=m;i++) res+=a[i]>=k;
	cout<<res;
}


