//list
#include<bits/stdc++.h>
using namespace std;

struct tong
{
	int S{0};
	void operator()(int x){S+=x;}
};
int main()
{
	list<int> L(3,5);
	L.resize(7);
	L.push_front(9);
	L.push_back(8);
	for(auto x:L) cout<<x<<" ";
	list<int>::iterator it;
	for(it=L.begin();it!=L.end();it++) (*it)++;
	cout<<"\nL : ";
	for(auto x:L) cout<<x<<" ";
	L.pop_back();
	cout<<"\nL : ";
	auto xuat = [](int x) {cout<<x<<" ";};
	for_each(L.begin(),L.end(),xuat);
	tong t=for_each(L.begin(),L.end(),tong());
	cout<<"\nTong = "<<t.S;
}


