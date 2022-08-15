import bisect
import sys

F = [0, 1]


# def fibo(n, k):
#     if n == 1: return 'A'
#     if n == 2: return 'B'
#     if k <= F[n - 2]: return fibo(n - 2, k)
#     return fibo(n - 1, k - F[n - 2])
#
#
# if __name__ == '__main__':
#     for i in range(100):
#         F.append(F[-2] + F[-1])
#     t = int(input())
#     for i in range(t):
#         n, k = map(int, input().split())
#         print(fibo(n, k))
#

import bisect
import sys
if __name__ == '__main__':
    n, *a = list(map(int, input().split()))
    c = [-1]
    for x in a:
        if x > c[-1]: c.append(x)
        else:
            k = bisect.bisect_left(c, x)
            c[k] = x
    print(c)

