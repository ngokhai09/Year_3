//Noi thanh kim loai
#include<bits/stdc++.h>
using namespace std;
int main()
{
	priority_queue<int,vector<int>,greater<int> > Q;
	int n,x;
	cin>>n; 
	for(int i=1;i<=n;i++) {cin>>x; Q.push(x);}
	long long res=0;
	while(Q.size()>1)
	{
		int u=Q.top(); Q.pop();
		u+=Q.top(); Q.pop();
		res+=u;
		Q.push(u);
	}
	cout<<res;
}


