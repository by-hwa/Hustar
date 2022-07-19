# -*- coding: utf-8 -*-
"""
Created on Mon Jun 27 13:23:27 2022

@author: byeonghwa
"""

for i in range(int(input())):
    get_list = list(map(int,input().split()))
    
    min_num = get_list[0]
    max_num = get_list[0]
    
    for num in get_list:
        if num > max_num: max_num = num
        if num < min_num: min_num = num
        
    print(max_num-min_num)