#include<bits/stdc++.h>
using namespace std;

void TRY(string x,int n)
{
	if(x.size()==n) {cout<<x<<"\n"; return;}
	x.push_back('0'); TRY(x,n); x.pop_back();
	x.push_back('1'); TRY(x,n); x.pop_back();
}

int main()
{
	int n;
	string x;
	cin>>n;
	TRY(x,n);
}


