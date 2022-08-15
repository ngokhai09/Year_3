#include<bits/stdc++.h>
using namespace std;
class Abc
{
	int a[100];
	public:
		int &operator[](int u)
		{
			return a[u];
		}
};
int main()
{
	Abc Z;
	Z[3]=7;

}


