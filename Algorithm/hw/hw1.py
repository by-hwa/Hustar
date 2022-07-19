# -*- coding: utf-8 -*-
"""
Created on Fri Jul  1 15:11:30 2022

@author: byeonghwa
"""
import sys
sys.setrecursionlimit(1000000)

def dfs(near_list,visit,start_node):
    if not visit[start_node]:
        visit[start_node] = True
        for node in near_list[start_node]:
            dfs(near_list,visit,node)

for test_case in range(int(input())):
    
    N, M, K = map(int, input().split())
    near_list = [[] for x in range(N)]
    visit = [False] * N
    
    for i in range(M):
        a, b = map(int,input().split())
        if b not in near_list[a]:near_list[a].append(b)
        if a not in near_list[b]:near_list[b].append(a)
    
    dfs(near_list,visit,K)
    
    print(visit.count(False))