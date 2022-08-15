#include<bits/stdc++.h>
using namespace std;
int sol()
{
	long long n,M=1e9+7,m,k;
	cin>>n;
	m=n+1;
	k=n+2;
	if(n%3==0) n/=3;
	if(m%3==0) m/=3;
	if(k%3==0) k/=3;
	if(n%2==0) n/=2; else m/=2; 
	n%=M; m%=M; k%=M;
	n=(n*m)%M;
	n=(n*k)%M;
	cout<<n<<"\n";
}
int main()
{
	int t;
	cin>>t;
	while(t--) sol();
}


