//tan suat chuoi
#include<bits/stdc++.h>
using namespace std;
int main()
{
	map<string,int> M;
	int n,m;
	string x;
	cin>>n; 
	while(n--) {cin>>x; M[x]++;}
	cin>>m;
	while(m--) {cin>>x; cout<<M[x]<<"\n";}
}


