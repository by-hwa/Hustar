# -*- coding: utf-8 -*-
"""
Created on Wed Jun 29 13:26:08 2022

@author: byeonghwa
"""

for t in range(int(input())):
    n,m = map(int,input().split())
    
    near_list = [[] for x in range(n)]
    
    for it in range(m):
        u,v = map(int,input().split())
        near_list[u].append(v)
        near_list[v].append(u)
        
    for i in near_list:
        print(*sorted(i))