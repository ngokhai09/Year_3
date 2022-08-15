//Tinh n giai thua so lon
#include<bits/stdc++.h>
using namespace std;
int main()
{
	int n,d=0;
	list<int> L(1,1);
	cin>>n;
	while(n>1)
	{
		int nho=0;
		for(auto &x:L)
		{
			nho+=x*n;
			x=nho%10;
			nho/=10;
		}
		while(nho) {L.push_back(nho%10); nho/=10;}
		while(L.front()==0) {d++;L.pop_front();}
		n--;
	}
	for(auto it=L.rbegin(); it!=L.rend();it++) cout<<*it;
	cout<<string(d,'0');
}


