//cho xâu ky tu chu thuong sap xep xep cac ky tu tang tang theo bang chu cai
//anhban -> aabhnn
#include<bits/stdc++.h>
using namespace std;
int main()
{
	char x[10000];
	scanf("%s",x);
	int d[150]={};  //d[97]=2,d[98]=1....
	for(char *p=x;*p!='\0';p++) d[*p]++;
	char *p=x;
	for(int c='a';c<='z';c++)  //26  -> O(26n) = O(n)
	{
		while(d[c]--) *p++=c; 
	}
	printf("%s",x);
}


