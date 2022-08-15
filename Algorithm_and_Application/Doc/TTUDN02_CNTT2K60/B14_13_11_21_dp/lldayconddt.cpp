#include<bits/stdc++.h>
using namespace std;
int main()
{
	int a[100005],c[100005],n,k=0;
	cin>>n; for(int i=1;i<=n;i++) cin>>a[i];
	for(int i=1;i<=n;i++)
	{
		if(k==0 || a[i]>c[k]) c[++k]=a[i];
		else
		{
			int *p=lower_bound(c+1,c+k+1,a[i]);
			*p=a[i];
		}
	}
	cout<<k;
}


