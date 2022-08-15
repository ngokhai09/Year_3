#include<bits/stdc++.h>
using namespace std;
//C[k][n]=n!/k!/(n-k)!
int main()
{
	long long C=1,k,n;				//3+1
	cin>>k>>n;
	for(int i=k+1;i<=n;i++) C*=i;   //1+1+1 + (n-k)4 + 1
	for(int i=2;i<=n-k;i++) C/=i;   //2+   (n-k-1)5 +1
	cout<<C;						//1
}
//K(n)= 16*3+2*4 = 56 byte -> 56*8 bit
//T(n) = 4 + 4 + 4(n-k)+ 3+ 5(n-k-1)+1 ->7+9n-9k -> O(n)


