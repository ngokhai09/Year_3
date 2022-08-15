#include<bits/stdc++.h>
#include<set>
using namespace std;
int main()
{
	set<int,greater<int>> T,Z; 
	for(int x:{43,47,12,48,60,79,23,48,25,55,62,235,34,48,111,25,252,52,35}) T.insert(x);
	for(set<int>::iterator it=T.begin();it!=T.end();it++) cout<<*it<<" ";
	T.erase(55);
	cout<<"\n";
	for(auto c:T) cout<<c<<" ";
	Z.insert(56);
	Z.insert(55);
	Z.insert(34);
	Z.insert(72);
	cout<<"\n";
	for(auto c:Z) cout<<c<<" ";
}


