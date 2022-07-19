# -*- coding: utf-8 -*-
"""
Created on Mon Jun 27 13:23:27 2022

@author: byeonghwa
"""

def Sum(lis):
    s = 0
    for i in lis:
        s += i
    return s

for i in range(int(input())):
    get_list = list(map(int,input().split()))
    print(Sum(get_list))