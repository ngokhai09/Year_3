#include<bits/stdc++.h>
using namespace std;
int main()
{
	priority_queue< int > Q;
	for(int x:{4,7,2,8}) Q.push(x);
	while(Q.size()) {cout<<Q.top()<<" "; Q.pop();}
}


