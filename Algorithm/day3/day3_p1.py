# -*- coding: utf-8 -*-
"""
Created on Thu Jun 30 13:11:29 2022

@author: byeonghwa
"""

import heapq

for test_case in range(int(input())):
    N,M  = map(int,input().split())
    
    near_list = [[] for x in range(N)]
    dist = [-1] * N
    visit = [False]*N
    
    hq = []
    heapq.heappush(hq,(0,0))
    
    for node in range(M):
        u,v,c = map(int,input().split())
        if v not in near_list[u]:
            near_list[u].append((c,v))
        
    for i in range(N):
        near_list[i].sort()
        
    while hq:
        # print(hq)
        # print(dist)
        cost, node = heapq.heappop(hq)
        
        if not visit[node]:
            visit[node] = True
            dist[node] = cost
            for node_c, node_v in near_list[node]:
                heapq.heappush(hq,(node_c+dist[node],node_v))
    
    print(dist[-1])