# -*- coding: utf-8 -*-
"""
Created on Tue Jun 28 15:34:06 2022

@author: byeonghwa
"""

import bisect

def binary_search(li,find_num):
    i = bisect.bisect_left(li,find_num)
    if i == len(li):
        return li[i-1]
    elif li[i] != find_num:
        if abs(li[i]-find_num) < abs(li[i-1]-find_num):
            return li[i]
        else:
            return li[i-1]
    else:
        return li[i]


for i in range(int(input())):
    li = list(map(int,input().split()))
    case = list(map(int,input().split()))
    tmp = []
    
    for n in case:
        tmp.append(binary_search(li,n))
    print(*tmp)