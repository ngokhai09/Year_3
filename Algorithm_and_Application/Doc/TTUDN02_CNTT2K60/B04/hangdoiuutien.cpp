#include<bits/stdc++.h>
using namespace std;
int main()
{
	//stack<int> Q;
	//	priority_queue<int> Q;							//lon uu tien hon
	priority_queue<int,vector<int>,greater<int> > Q;  //Be uu tien hon
	for(int x:{4,7,2,8,5,3}) Q.push(x);
	while(not Q.empty())
	{
		//cout<<Q.front()<<" ";
		cout<<Q.top()<<" ";
		Q.pop();
	}

}


