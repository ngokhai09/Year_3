#include<bits/stdc++.h>
using namespace std;
bool ktnt(long long n)  //T(n)=Omega(1), T(n)=O(sqrt(n))
{
	if(n==2) return 1;
	if(n<2 || n%2 == 0) return 0;
	for(int i=3;i*i<=n;i+=2) if(n%i==0) return 0;
	return 1;
}
int main()
{
	int n;
	cin>> n;
	for(int i=2;i<=n;i++)
		if(ktnt(i)) cout<<i<<" ";
}
//T(n) = O(n*sqrt(n))


