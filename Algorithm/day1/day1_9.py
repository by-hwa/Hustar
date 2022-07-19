# -*- coding: utf-8 -*-
"""
Created on Mon Jun 27 13:23:27 2022

@author: byeonghwa
"""

for i in range(int(input())):
    town = list(map(int,input().split()))

    town_l = list(map(lambda x : abs(x-town[len(town)//2]),town))
    print(sum(town_l))