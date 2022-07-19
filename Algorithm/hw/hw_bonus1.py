# -*- coding: utf-8 -*-
"""
Created on Fri Jul  1 20:18:04 2022

@author: byeonghwa
"""

def get_sequence(n):
    a = [0]*(n+1)
    a[:2] = [1,1]
    
    for i in range(2,n+1):
        if i % 2:
            a[i] = a[i-1]%20211209 + 2 * a[i-2]%20211209
        else:
            a[i] = 2 * a[i-1]%20211209 + a[i-2]%20211209
            
    return a[n]%20211209


for test_case in range(int(input())):
    n = int(input())
    print(get_sequence(n))