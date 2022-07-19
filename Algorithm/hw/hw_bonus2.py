# -*- coding: utf-8 -*-
"""
Created on Fri Jul  1 21:08:49 2022

@author: byeonghwa
"""

for test_case in range(int(input())):
    n = int(input())
    time_table = []
    
    for i in range(n):
        time_table.append(tuple(map(int,input().split())))
    time_table.sort(key=lambda x : x[0],reverse=True)

    cnt = 0
    
    while time_table:
        a, b = time_table[0]
        cnt +=1
        for now in range(a,b+1):
            for i,(start, end) in enumerate(time_table):
                if now>=start and now<=end:
                    del time_table[i]
    print(cnt)