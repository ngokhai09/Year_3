#include <bits/stdc++.h>
#define N 101
using namespace std;

class LCS{
    char x[N],y[N];
    int n,m;
    set <string> S;
    int dp[N][N];
    char res[N]={};
    public:
        void lcs(){
            n=strlen(x);m=strlen(y);
            for (int i=0;i<=n;i++){
                for (int j=0;j<=m;j++){
                    if (i==0 || j==0){
                        dp[i][j]=0;
                    }
                    else if (x[i-1]==y[j-1]){
                        dp[i][j]=dp[i-1][j-1]+1;
                    }
                    else{
                        dp[i][j]=max(dp[i-1][j],dp[i][j-1]);
                    }
                }
            }
//            for (int i=1;i<=n;i++){
//                for (int j=1;j<=m;j++){
//                    cout<<dp[i][j]<<" ";
//                }
//                cout<<endl;
//            }
        }
        void trace(int n1,int m1,char *s){
            if (dp[n1][m1]==0){
                S.insert(res);
                return;
            }
            if (dp[n1][m1]==dp[n1][m1-1]){
                trace(n1,m1-1,s);
            }
            if (dp[n1-1][m1]==dp[n1][m1]){
                trace(n1-1,m1,s);
            }
            if (dp[n1][m1]>dp[n1-1][m1] && dp[n1][m1]>dp[n1][m1-1]){
                *s=x[n1-1];
                trace(n1-1,m1-1,s-1);
            }
        }
        void solve(){
            cin>>x>>y;
            lcs();
            if (dp[n][m]==0){
                printf("khong co xau con chung");
                return;
            }
            trace(n,m,res+dp[n][m]-1);
            for (auto str:S){
                cout<<str<<endl;
            }
        }
};
int main(){
    LCS a; a.solve();
}
