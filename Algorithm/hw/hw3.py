# -*- coding: utf-8 -*-
"""
Created on Fri Jul  1 16:22:00 2022

@author: byeonghwa
"""
import bisect

def search_index(li,n):
    i = bisect.bisect_left(li,n)

    if i == len(li):
        return i
    elif li[i] == n:
        return i+1
    else:
        return i


for test_case in range(int(input())):
    li = list(map(int,input().split()))
    li.sort()
    query = list(map(int,input().split()))
    
    answer_list = []
    for q in query:
        answer_list.append(len(li)-search_index(li,q))
        
    print(*answer_list)