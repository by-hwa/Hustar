# -*- coding: utf-8 -*-
"""
Created on Wed Jun 29 13:26:08 2022

@author: byeonghwa
"""
import sys
sys.setrecursionlimit(1000000)

def DFS(start_node,visit,result):
    # print(start_node,near_list[start_node],visit[start_node])
    if not visit[start_node]:
        result.append(start_node)
        visit[start_node] = True
        for node in near_list[start_node]:
            DFS(node,visit,result)
    else:
        return


for test_case in range(int(input())):
    n,m = map(int,input().split())
    
    near_list = [[] for x in range(n)]
    visit = [False for x in range(n)]
    result = []
    
    for it in range(m):
        u,v = map(int,input().split())
        if v not in near_list[u]:near_list[u].append(v)
        if u not in near_list[v]:near_list[v].append(u)
    
    for i in range(n):
        near_list[i].sort()
        
    DFS(0,visit,result)

    print(*result)