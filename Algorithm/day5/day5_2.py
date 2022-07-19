# -*- coding: utf-8 -*-
"""
Created on Fri Jul  1 13:30:01 2022

@author: byeonghwa
"""

def get_delivery_fee_list(delivery_fee_table):
    for row in range(1,len(delivery_fee_table)):
        for col in range(len(delivery_fee_table[0])):
            if row == 1:
                if col >= wi[row]:
                    delivery_fee_table[row][col] = vi[1]
            elif wi[row]>col:
                delivery_fee_table[row][col] = delivery_fee_table[row-1][col]
            elif wi[row]<=col:
                delivery_fee_table[row][col] = max(delivery_fee_table[row-1][col],delivery_fee_table[row-1][col-wi[row]]+vi[row])

for test_case in range(int(input())):
    
    n, C = map(int,input().split())
    
    wi = [0] + list(map(int,input().split()))
    vi = [0] + list(map(int,input().split()))
    
    delivery_fee_table = [[0 for col in range(C+1)] for row in range(n+1)]
    
    get_delivery_fee_list(delivery_fee_table)
    
    max_value = 0
    
    for row in delivery_fee_table:
        max_value = max(max(row),max_value)
        
    print(max_value)