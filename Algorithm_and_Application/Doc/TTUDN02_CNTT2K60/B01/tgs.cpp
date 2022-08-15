#include<bits/stdc++.h>
using namespace std;
int main()
{
	char x[1000]={};
	int n; 
	scanf("%d",&n);
	fill(x,x+n,'*');
	char *p=x+n-1;
	while(p>=x) printf("%s\n",p--);
}


