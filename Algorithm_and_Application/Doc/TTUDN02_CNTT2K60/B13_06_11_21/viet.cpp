//Viet
#include<bits/stdc++.h>
using namespace std;
int main()
{
	int t;
	cin>>t;
	while(t--)
	{
		long long n,b,c,M=1e9+7; 
		cin>>b>>c>>n;
		long long S[n+5]={2,-b};
		for(int i=2;i<=n;i++) S[i]=(-b*S[i-1]%
		-c*S[i-2]%M)%M;
		cout<<(S[n]+M)%M<<"\n";
	}
}


