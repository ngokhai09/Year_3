//tinh tuan tu cac buoc
//Sang eratothens sang cac so nguyen to
#include<bits/stdc++.h>
using namespace std;
void sang(int n,vector<int>&P)
{
	bool s[n+5]={};
	for(int i=2;i<=n;i++)
	if(!s[i])
	{
		//cout<<i<<" "; 
		P.push_back(i);
		for(int j=i*i;j<=n;j+=i) s[j]=1;
	}
}
int main()
{
	vector<int> P;
	sang(10000,P);
	for(auto x:P) cout<<x<<" ";
}


