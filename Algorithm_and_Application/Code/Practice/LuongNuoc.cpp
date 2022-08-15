#include<bits/stdc++.h>
#define x first
#define y second

using namespace std;

int main()
{
	long long n, a[1000001], l[1000001] = {}, r[1000001] = {}, res = 0;
	cin >> n;
	for(long long i = 0; i < n; i++){
		cin >> a[i];
	}
	for(long long i = n - 1; i >= 0; i--){
		r[i] = max(r[i + 1], a[i]);
	}
	for(long long i = 0; i < n; i++){
		l[i] = max(l[i - 1], a[i]);
		res += min(r[i], l[i]) < a[i] ? 0: min(r[i], l[i]) - a[i];
	}
	cout << res;
}


