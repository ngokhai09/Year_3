# Keo xanh keo do
#  t = int(input())
# for i in range(t):
#     a, b, d = map(int, input().split())
#     a, b = min(a,b), max(a,b)
#     print("YES" if (a *(d+1) >= b) else "NO")

#pt bac 2
# from math import sqrt as can
# if __name__ == '__main__':
#     a, b, c = map(float, input().split())
#     d = b * b - 4 * a * c
#     if a == b == c == 0: print("vo so nghiem")
#     elif a == b == 0 or d < 0: print("vo nghiem")
#     elif a == 0: print("%0.3f"%(-c/b))
#     elif d == 0: print("%0.3f"%(-b / 2 / a))
#     else:
#         x1 = (-b - can(d))/2/a
#         x2 = -b/a-x1
#         if x1 > x2: x1, x2 = x2, x1
#         print("%0.3f\n%0.3f"%(x1,x2))

import bisect
import sys
if __name__ == '__main__':
    n, *a = list(map(int, sys.stdin.read().split()))
    c = [-1]
    for x in a:
        if x > c[-1]: c.append(x)
        else:
            c[bisect.bisect_left(c, x)] = x
    print(len(c) - 1)