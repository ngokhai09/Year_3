//sap xep co dieu kien
#include<bits/stdc++.h>
using namespace std;
struct cmp
{
	int operator()(int a,int b)
	{
		if(a%3==b%3) return a>b;
		return a%3>b%3;
	}
};
int main()
{
//	cmp p;
//	int a=5,b=7;
//	if(p(a,b)) cout<<"a > b"; else cout<<"a <= b";
	priority_queue<int,vector<int>,cmp> Q;
	int n,x;
	cin>>n;
	while(n--) {cin>>x; Q.push(x);}
	while(Q.size()) {cout<<Q.top()<<" "; Q.pop();}
}


