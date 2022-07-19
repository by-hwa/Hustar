# -*- coding: utf-8 -*-
"""
Created on Mon Jun 27 15:16:03 2022

@author: byeonghwa
"""

import collections

def ischange(rank):
    que = collections.deque([])
    for car_num in rank:
        if car_num not in que:
            que.append(car_num)
        else:
            if que.popleft() != car_num:
                return 'YES'
    if que:return 'YES'
    else:return 'NO'
            
for i in range(int(input())):
    rank = list(map(int,input().split()))
    print(ischange(rank))