# -*- coding: utf-8 -*-
"""
Created on Tue Jun 28 13:04:31 2022

@author: byeonghwa
"""

def Power(n,k,m):
    if k == 0:return 1
    elif k == 1:return n%m
    elif k%2==0:
        return Power(n,k//2,m)**2%m
    else:
        return Power(n,k//2,m)**2*n%m
    
for i in range(int(input())):
    n,k,m = map(int,input().split())
    print(Power(n,k,m))