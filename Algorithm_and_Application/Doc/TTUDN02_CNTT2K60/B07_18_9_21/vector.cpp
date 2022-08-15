//cau truc du lieu tuyen tinh co bo lap
#include<bits/stdc++.h>
using namespace std;
int main()
{
	vector<int> V(7);
	vector<char> C(5,'a');
	for(auto x:C) cout<<x<<" ";
	V.resize(9);
	for(vector<int>::iterator it=V.begin();it!=V.end();it++) cout<<*it;
	srand(time(0)); //khoi tao cho ham rand
	for_each(V.begin(),V.end(),[&](int &t){t=rand();});
	cout<<"\nV : "; for(int x:V) cout<<x<<" ";
	cout<<"\nDuyet nguoc V: ";
	for(vector<int>::reverse_iterator it=V.rbegin();it!=V.rend();it++)cout<<*it<<" ";
	sort(V.begin(),V.end(),[](int a,int b) {return (a-b)%2?a%2<b%2:a<b;});
	cout<<"\nV sau khi sx : "; for(auto x:V) cout<<x<<" ";
}

