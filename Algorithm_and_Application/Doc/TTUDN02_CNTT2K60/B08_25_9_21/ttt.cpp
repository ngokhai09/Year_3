#include<bits/stdc++.h>
using namespace std;
struct test
{
	int a;
	test(int x=0) {a=x;}
	test operator++(int){test k=a;a=a+1; return k;}
};
int main()
{
	test T(7),Z;
	Z=T++;
	cout<<T.a;
	cout<<" "<<Z.a;

}


