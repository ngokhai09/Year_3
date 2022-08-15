#include<bits/stdc++.h>
using namespace std;
struct ss
{
	bool operator()(int a,int b)
	{
		if(a%3==b%3) return a>b;
		return a%3>b%3;
	}
};
int main()
{
	priority_queue<int,vector<int>,ss> Q;
	int n,x;
	cin>>n;
	while(n--) {cin>>x; Q.push(x);}
	while(Q.size()) {cout<<Q.top()<<" "; Q.pop();}
}


