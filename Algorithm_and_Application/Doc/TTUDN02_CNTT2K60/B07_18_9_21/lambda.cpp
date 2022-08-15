#include<bits/stdc++.h>
using namespace std;
int main()
{
	int a[]={4,7,2,8,1,6,5},n=sizeof(a)/sizeof(int);
	vector<int> V(a,a+3);
	
	auto bp = [](int &x) {x=x*x;};   		//toan tu lambda C++11;
	auto xuat = [](int x) {cout<<x<<" ";};   //toan tu lambda C++11;
	
	V.pop_back();
	V.push_back(45);
	V.push_back(54);
	for_each(V.begin(),V.end(),bp);
	V.resize(n,100);
	for_each(V.begin(),V.end(),xuat);
	
//	auto sqr = [&](int x) {return x*x;};   //lambda
//	
//	int t=sqr(5);
//	xuat(t);

}


