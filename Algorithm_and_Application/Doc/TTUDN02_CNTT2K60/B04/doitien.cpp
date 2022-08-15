#include<bits/stdc++.h>
using namespace std;
typedef pair<int,int> pii;
int main()
{
	priority_queue<pii, vector<pii>, greater<pii> > Q;
	int n,M;
	cin>>n>>M;
	int a[n];
	for(auto &x: a) cin>>x;  sort(a,a+n,greater<int>());
	map<int,int> D;
	Q.push({0,0});// first - so to; second so tien
	while(Q.size())
	{
		pii u=Q.top();  //u.first, u.second
		Q.pop();
		for(int t:a)
		if(u.second+t<=M && D.find(u.second+t)==D.end())
		{
			D[u.second+t]=u.first+1;
			Q.push({u.first+1,u.second+t});
		}
		if(D.find(M)!=D.end()) {cout<<D[M]; return 0;}
	}
	cout<<"\nKhogndoi duoc"; 
}


