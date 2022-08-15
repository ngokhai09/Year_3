#include<bits/stdc++.h>
using namespace std;
long long C(int k,int n)
{
	if(k<=0 || k>=n) return 1ll;
	return C(k-1,n-1)+C(k,n-1);
}
int main()
{
	cout<<C(14,40);
}


