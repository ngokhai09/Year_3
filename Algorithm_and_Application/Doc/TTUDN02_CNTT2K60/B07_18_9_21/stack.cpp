#include<bits/stdc++.h>
using namespace std;
int main()
{
//	stack<int> S;   //LIFO
	queue<int> S;   //FIFO
	for(int x:{4,7,2,8}) S.push(x);
	S.front()=3;
	S.back() =1;
	while(S.size()) {cout<<S.front()<<" "; S.pop();}

}


