# -*- coding: utf-8 -*-
"""
Created on Wed Jun 29 13:26:08 2022

@author: byeonghwa
"""

import collections

for test_case in range(int(input())):
    n,m = map(int,input().split())
    
    near_list = [[] for x in range(n)]
    # bfs = [collections.deque([]) for x in range(n)]
    bfs = collections.deque([])
    visit = [False for x in range(n)]
    result = []
    
    for it in range(m):
        u,v = map(int,input().split())
        if v not in near_list[u]:near_list[u].append(v)
    
    for i in range(n):
        near_list[i].sort()

    bfs.append(0)
    
    # for bfs_ind, node_len in enumerate(bfs):
    #     while node_len:
    #         node = node_len.popleft()
            
    #         if bfs_ind < len(bfs)-1:
    #             bfs[bfs_ind+1] += collections.deque(near_list[node])
            
    #         # print(bfs)
            
    #         if not visit[node]:
    #             visit[node] = True
    #             result.append(node)
    
    while bfs:
        node = bfs.popleft()
        
        if not visit[node]:
                visit[node] = True
                bfs += collections.deque(near_list[node])
                result.append(node)
    print(*result)