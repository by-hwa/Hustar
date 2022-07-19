# -*- coding: utf-8 -*-
"""
Created on Mon Jun 27 13:23:27 2022

@author: byeonghwa
"""

import collections

for i in range(int(input())):
    que = collections.deque([])

    for j in range(int(input())):
        num = int(input())
        if num>=0:que.append(num)
        elif num==-1:print(que.popleft())