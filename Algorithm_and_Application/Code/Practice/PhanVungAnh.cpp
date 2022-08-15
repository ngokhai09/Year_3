#include<bits/stdc++.h>
#define x first
#define y second
using namespace std;
int n, m;
int a[100][100];
int d[] = { -1,0,1 };
vector<int> V;
bool check(pair<int, int> a) {
	if (a.x >= 0 and a.x < n and a.y >= 0 and a.y < m)
		return true;
	return false;
}
void sol() {
	queue<pair<int, int>> Q;
	for (int i = 0; i < n; i++) {
		for (int j = 0; j < m; j++) {
			if (a[i][j] == 0) {
				a[i][j] = 1;
				int cnt = 1;				
				Q.push({ i,j });
				while (!Q.empty()) {
					int u = Q.front().x;
					int v = Q.front().y;
					Q.pop();
					for (int dx = 0; dx < 3; dx++) {
						for (int dy = 0; dy < 3; dy++) {
							pair<int, int> z = { u + d[dx], v + d[dy] };
							if (check(z) and a[z.x][z.y] == 0) {
								a[z.x][z.y] = 1;
								cnt++;
								Q.push(z);
							}
						}
					}
				}
				V.push_back(cnt);
			}
		}
	}
}

int main()
{
	cin >> n >> m;
	for (int i = 0; i < n; i++) {
		for (int j = 0; j < m; j++) {
			cin >> a[i][j];
		}
	}
	sol();
	sort(V.begin(), V.end());
	cout << V.size() << endl;
	for (auto i : V) {
		cout << i << " ";
	}
}
