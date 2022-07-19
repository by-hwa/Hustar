# -*- coding: utf-8 -*-
"""
Created on Fri Jul  1 22:31:14 2022

@author: byeonghwa
"""

def find_max_sum(sequence):
    dp = [0]*len(sequence)
    dp[0:2] = sequence[0:2]
    
    for i in range(2,len(sequence)):
        dp[i] = max(dp[i-1]+sequence[i],sequence[i])
    return max(dp[1:])
for test_case in range(int(input())):
    sequence = [0] + list(map(int,input().split()))
    print(find_max_sum(sequence))