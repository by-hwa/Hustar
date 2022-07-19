# -*- coding: utf-8 -*-
"""
Created on Tue Jun 28 14:26:23 2022

@author: byeonghwa
"""

def find_max(li):
    len_list = len(li)
    center = len_list//2
    
    if len_list == 1:
        return li[0]
    
    left = find_max(li[:center])
    right = find_max(li[center:])
    
    lsum = 0
    lmax = li[center-1]
    rsum = 0
    rmax = li[center]
    
    for i in range(center):
        lsum += li[center-i-1]
        lmax = max(lsum,lmax)
    
    for i in range(center,len_list):
        rsum += li[i]
        rmax = max(rsum,rmax)
    
    mmax = lmax + rmax
        
    return max(left,right, mmax)
        

for i in range(int(input())):
    li = list(map(int,input().split()))
    print(find_max(li))