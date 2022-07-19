# -*- coding: utf-8 -*-
"""
Created on Mon Jun 27 13:23:27 2022

@author: byeonghwa
"""

for i in range(int(input())):
    pos_list = []
    s = []
    for n in range(int(input())):
        pos_list.append(tuple(map(int,input().split())))
    
    pos_list.sort(key=lambda x : x[0])
    pos_list = sorted(pos_list,key=lambda x : x[1]/x[0],reverse=True)
    
    print(pos_list)