#include<bits/stdc++.h>
using namespace std;

void TRY(char *x,int k,int n)
{
	if(k==n) printf("%s\n",x);
	else for(x[k]='0';x[k]<='1';x[k]++) TRY(x,k+1,n);
}
int main()
{
	char x[100]={};
	int n;
	scanf("%d",&n);
	TRY(x,0,n);
}


