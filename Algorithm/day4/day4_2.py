# -*- coding: utf-8 -*-
"""
Created on Thu Jun 30 13:17:04 2022

@author: byeonghwa
"""

for test_case in range(int(input())):
    
    n,C = map(int,input().split())
    
    solution = []
    max_m = 0
    
    for i in range(n):
        W,V = map(int,input().split())
        solution.append((V,W/V))
        
    solution.sort(key=lambda x : x[1])
    
    while C>0:
        V, d = solution.pop()
        if C<V:
            max_m += C*d
            C = 0
        else:
            C -= V
            max_m += V*d
            
    print(int(max_m))