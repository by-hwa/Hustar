# -*- coding: utf-8 -*-
"""
Created on Tue Jun 28 13:27:43 2022

@author: byeonghwa
"""

def binary_search(li,find_num,start,end):
    mid = (start + end)//2
    if start>end:
        return -1
    if li[mid] == find_num:
        return mid
    elif li[mid] > find_num:
        return binary_search(li,find_num,start,mid-1)
    elif li[mid] < find_num:
        return binary_search(li,find_num,mid+1,end)
    

for i in range(int(input())):
    li = list(map(int,input().split()))
    find_l = list(map(int,input().split()))
    tmp = []

    for n in find_l:
        tmp.append(binary_search(li,n,0,len(li)-1))
        
    print(*tmp)