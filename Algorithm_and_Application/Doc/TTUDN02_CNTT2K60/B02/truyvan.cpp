//truy van tong max
#include<bits/stdc++.h>
using namespace std;
int main()
{
	long long n,q,L,R;
	scanf("%lld%lld",&n,&q);
	long long a[n+5]={};
	for(int i=1;i<=n;i++)
	{
		scanf("%lld",&a[i]); 
		a[i]+=a[i-1];
	}
	while(q--)
	{
		scanf("%lld%lld",&L,&R); printf("%lld\n",a[R]-a[L-1]);
	}
}


