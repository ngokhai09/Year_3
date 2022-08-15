#include<bits/stdc++.h>
using namespace std;
int main()
{
	string x;
	cin>>x;
	sort(x.begin(),x.end());
	do cout<<x<<"\n";
	while(next_permutation(x.begin(),x.end()));
}


