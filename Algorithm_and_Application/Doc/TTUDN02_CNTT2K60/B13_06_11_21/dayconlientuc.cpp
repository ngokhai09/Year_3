#include<bits/stdc++.h>
using namespace std;
int main()
{
	int a,c=-1,n,res=-INT_MAX;
	cin>>n;
	for(int i=1;i<=n;i++) 
	{cin>>a; c=max(0,c) + a; res=max(res,c);}
	cout<<res;
}


