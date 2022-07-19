# -*- coding: utf-8 -*-
"""
Created on Mon Jun 27 13:23:27 2022

@author: byeonghwa
"""

stack = []
for i in range(int(input())):
    for j in range(int(input())):
        num = int(input())
        if num>=0:stack.append(num)
        elif num==-1:print(stack.pop())