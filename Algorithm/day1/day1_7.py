# -*- coding: utf-8 -*-
"""
Created on Mon Jun 27 13:23:27 2022

@author: byeonghwa
"""

import heapq

for i in range(int(input())):
    hq = []
    for j in range(int(input())):
        num = int(input())
        if num>=0:heapq.heappush(hq,num)
        elif num==-1:print(heapq.heappop(hq))