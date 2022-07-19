# -*- coding: utf-8 -*-
"""
Created on Mon Jun 27 15:01:17 2022

@author: byeonghwa
"""

def isproper(bracket):
    stack = []
    b_dict = {']':'[','}':'{',')':'('}
    for b in bracket:
        if b in b_dict.values():
            stack.append(b)
        else:
            if stack and stack[-1] == b_dict[b]:stack.pop()
            else:return 'NO'
    if not stack:return 'YES'
    else:return 'NO'

for i in range(int(input())):
    bracket = input()
    print(isproper(bracket))