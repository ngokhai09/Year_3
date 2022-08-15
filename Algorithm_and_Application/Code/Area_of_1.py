import queue


def check(i, j, n, m):
    if i < 0 or i >= n or j < 0 or j >= m:
        return False
    return True


d = [[-1, -1], [-1, 0], [0, -1], [1, -1], [-1, 1], [0, 1], [1, 0], [1, 1]]


def sol(a, n, m):
    res = 0
    q = queue.Queue(maxsize=m * n)
    for i in range(n):
        for j in range(m):
            if a[i][j] == 1:
                a[i][j] = 0
                cnt = 1
                q.put((i, j))
                while (False == q.empty()):
                    u, v = q.get()
                    for k in range(0, 8):
                        x, y = d[k]
                        z = (u + x, v + y)
                        if check(u + x, v + y, n, m) and a[u + x][v + y] == 1:
                            a[u + x][v + y] = 0
                            cnt += 1
                            q.put((u + x, v + y))
                res = max(res, cnt)
    return res


if __name__ == '__main__':
    n, m = map(int, input().split())
    a = []
    for i in range(0, n):
        a.append([])
        x = list(input().split())
        for j in range(0, m):
            a[i].append(int(x[j]))
    print(sol(a, n, m))
