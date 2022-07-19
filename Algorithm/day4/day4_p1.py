# -*- coding: utf-8 -*-
"""
Created on Thu Jun 30 13:51:08 2022

@author: byeonghwa
"""

import bisect

def search_index(li,n):
    ind = bisect.bisect_left(li,n)
    if li[ind] == n:return ind
    else:return ind-1

for test_case in range(int(input())):
    G, L = map(int,input().split())
    
    gas_station = list(map(int,input().split()))
    
    now = 0
    cnt = 0
    
    while now < L:
        if now + G >= L:
            break
        
        if  len(gas_station)-1 > search_index(gas_station,now+G) and  gas_station[search_index(gas_station,now+G)+1]-gas_station[search_index(gas_station,now+G)] > G:
            cnt = -1
            break
        
        else:
            now = gas_station[search_index(gas_station,now+G)]
        cnt += 1
        
    print(cnt)