#include<bits/stdc++.h>
using namespace std;
int main()
{
	int a[100005],c[100005],n;
	cin>>n; for(int i=1;i<=n;i++) cin>>a[i];
	for(int i=1;i<=n;i++)
	{
		int k=0;
		for(int j=1;j<i;j++) if(a[j]<a[i] && c[j]>k) k=c[j];
		c[i]=k+1; 
	}
	cout<<*max_element(c+1,c+n+1);
}


