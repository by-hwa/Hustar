# -*- coding: utf-8 -*-
"""
Created on Mon Jun 27 13:23:27 2022

@author: byeonghwa
"""

import collections

def ischange(rank):
    que = collections.deque([])
    
    for car_num in rank:
        if car_num not in que:
            que.append(car_num)
        else:
            if car_num != que.popleft():
                return 'YES'
            else:
                que.append(car_num)
        print(que)
    return 'NO'

for t in range(int(input())):
    int(input())
    rank = list(map(int, input().split()))
    print(ischange(rank))