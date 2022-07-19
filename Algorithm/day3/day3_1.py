# -*- coding: utf-8 -*-
"""
Created on Wed Jun 29 13:26:08 2022

@author: byeonghwa
"""

for t in range(int(input())):
    n,m = map(int,input().split())
    
    matrix = [[0 for x in range(n)] for y in range(n)]
    
    for it in range(m):
        i,j,c = map(int,input().split())
        matrix[i][j] = c
        
    for i in matrix:
        print(*i)