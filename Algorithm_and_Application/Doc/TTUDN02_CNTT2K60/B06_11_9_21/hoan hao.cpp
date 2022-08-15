#include"stdio.h"
bool hoanhao(long long x)
{ 
   long long i,s=0;
   for(i=1;i*i<x;i++)
   if(x%i==0)  s+=i+x/i;
   if(i*i==x) s+=i;   
   return s==2*x;
}
int main ()
{
	long long n=1e14,i;
	for(i=1;i<n;i++)
	if(hoanhao(i)) printf("%lld ",i);
}
