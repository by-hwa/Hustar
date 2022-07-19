# -*- coding: utf-8 -*-
"""
Created on Thu Jun 30 13:17:04 2022

@author: byeonghwa
"""

for test_case in range(int(input())):
    tex = int(input())
    
    coin_sum = 0
    
    coin_50000 = tex//50000
    coin_10000 = tex%50000//10000
    coin_5000 = tex%10000//5000
    coin_1000 = tex%5000//1000
    coin_500 = tex%1000//500
    coin_100 = tex%500//100
    
    print(sum([coin_50000,coin_10000,coin_5000,coin_1000,coin_500,coin_100]))