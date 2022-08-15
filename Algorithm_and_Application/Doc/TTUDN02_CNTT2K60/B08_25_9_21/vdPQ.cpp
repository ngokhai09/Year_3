#include<bits/stdc++.h>
#include"mypq.cpp"
using namespace std;

int main()
{
	pq<int,less <int> > Q;
	for(int x:{4,7,2,8,1,6,4,5,2,0,4}) Q.push(x);
	while(Q.size())
	{
		cout<<Q.top()<<" ";
		Q.pop();
	}
}


