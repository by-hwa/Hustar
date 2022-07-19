# -*- coding: utf-8 -*-
"""
Created on Mon Jun 27 13:23:27 2022

@author: byeonghwa
"""

def fibo(n):
    if n == 0:return 0
    elif n == 1:return 1
    return fibo(n-1) + fibo(n-2)

for i in range(int(input())):
    print(fibo(int(input())))