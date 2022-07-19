# -*- coding: utf-8 -*-
"""
Created on Tue Jun 28 15:10:18 2022

@author: byeonghwa
"""

def merge(left,right):
    l_l = len(left)
    r_l = len(right)
    l_point = 0
    r_point = 0
    merge_list = []
    
    for i in range(l_l+r_l):
        if l_point >= l_l or r_point >= r_l:
            merge_list = merge_list + [1]*(l_l-l_point) + [2]*(r_l-r_point)
            return merge_list
        
        if left[l_point] > right[r_point]:
            r_point += 1
            merge_list.append(2)
        elif left[l_point] <= right[r_point]:
            l_point += 1
            merge_list.append(1)

for i in range(int(input())):
    left = list(map(int,input().split()))
    right = list(map(int,input().split()))
    print(*merge(left,right))