//zero
//dFS
#include<bits/stdc++.h>
using namespace std;
int main()
{
	int n;
	map<int,bool> M;
	cin>>n;
	stack<int> Q; 
	Q.push(n);
	M[n]=true;
	while(Q.size())
	{
		int u=Q.top(); Q.pop();
		for(int a=1;a*a<=u;a++) 
		if(u%a==0)
		{
			int v=(a-1)*(u/a+1);
			if(M.find(v)==M.end()) {Q.push(v);M[v]=true;} //not M[v]
		}
	}
	for(auto x:M) cout<<x.first<<" ";
}


