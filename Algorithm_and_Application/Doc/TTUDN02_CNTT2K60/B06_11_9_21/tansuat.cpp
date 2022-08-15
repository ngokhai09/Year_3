//tan suat
#include<bits/stdc++.h>
using namespace std;
int main()
{
	map<int,int> M;  //first - so; second - tan suat
	int n,x;
	cin>>n;
	while(n--) {cin>>x; M[x]++;}
	for(auto z:M) cout<<z.first<<" "<<z.second<<"\n";
}


