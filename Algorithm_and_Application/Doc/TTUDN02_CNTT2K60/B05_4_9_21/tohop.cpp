//de quy co nho bang tu dien
#include<bits/stdc++.h>
using namespace std;
map<pair<int,int>, long long> Dic;
long long C(int k,int n)
{
	if(Dic.find({k,n})!=Dic.end()) return Dic[{k,n}];
	if(k<=0 || k>=n) return Dic[{k,n}]=1LL;
	return Dic[{k,n}]=C(k-1,n-1)+C(k,n-1);
}
int main()
{
	cout<<C(17,30);
}


