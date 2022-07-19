# -*- coding: utf-8 -*-
"""
Created on Fri Jul  1 13:10:22 2022

@author: byeonghwa
"""

def get_case(stone_bridge, n):
    
    for i in range(3,n+1):
        stone_bridge[i] = (stone_bridge[i-1]+stone_bridge[i-2]+stone_bridge[i-3]) % 1904101441
    return stone_bridge[n]%1904101441

for test_case in range(int(input())):
    n = int(input())
    
    stone_bridge = [0] * (n+1)
    
    stone_bridge[:4] = [1,1,2,4]
    
    print(get_case(stone_bridge, n))