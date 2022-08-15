#include<bits/stdc++.h>
#define x first
#define y second

using namespace std;

int main()
{
	int n, k;
	cin >> n >> k;
	int a[100001];
	deque<int> D;
	for(int i = 1; i <= n; i++){
		cin >> a[i];
		while(!D.empty() and a[D.back()] <= a[i]) D.pop_back();
		D.push_back(i);
		while(i - D.front() + 1 > k) D.pop_front();
		if(i >= k) cout << a[D.front()] << " ";
	}
}


