#include<bits/stdc++.h>
using namespace std;

int fun(int a,int b) {return max(a,b);}
int main()
{
	//Hàm cong cuon chieu
	int a[]={4,7,2,8,1,6,9,3,5,0,2},n=sizeof(a)/sizeof(int);
	int b[n];
	partial_sum(a,a+n,b,[](int a,int b){return a*b;});
	for(int x:b)cout<<x<<" ";

}


