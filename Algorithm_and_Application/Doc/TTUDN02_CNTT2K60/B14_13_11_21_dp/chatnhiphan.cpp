#include<bits/stdc++.h>
using namespace std;
int main()
{
	int a[]={4,5,6,7,8,8,8,8,13,14},n=sizeof(a)/sizeof(int);
//	int *p=lower_bound(a,a+n,10); //tim ra phan tu dau tien >=
	int *p=upper_bound(a,a+n,8); //tim ra phan tu dau tien >
	cout<<"vi tri "<<p-a;


}


