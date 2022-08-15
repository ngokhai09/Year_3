//Tu dien
#include<bits/stdc++.h>
using namespace std;
int main()
{
	map<long long,bool> M={{6,1},{28,1},{496,1},{8128,1},{25435}};
	int n;
	long long a;
	scanf("%d\n",&n);
	while(n--)	
	{ 
	   scanf("%lld",&a) ;
	   printf(M[a]?"%lld eh perfeito\n":"%lld nao eh perfeito\n",a);
	}
}


