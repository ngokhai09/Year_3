#include<bits/stdc++.h>
using namespace std;
struct ps
{
	int t,m;
};

struct pps
{
	ps *p;
	ps operator*(){return *p;}
};
int main()
{
	ps a; a.t=5;a.m=7;
	pps p; p.p=&a;
	cout<<(*p).t<<"/"<<(*p).m;

}


