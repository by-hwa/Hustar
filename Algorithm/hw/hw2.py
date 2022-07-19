# -*- coding: utf-8 -*-
"""
Created on Fri Jul  1 15:50:53 2022

@author: byeonghwa
"""

def get_max_score(n_list,max_score,n):
    i = 1
    while i<=n:
        if i == 1:
            max_score[i] = n_list[i]
        elif max_score[i-1]>max_score[i-2]:
            max_score[i] = n_list[i]+max_score[i-1]
        elif max_score[i-2]>=max_score[i-1]:
            max_score[i] = n_list[i]+max_score[i-2]
            
        if i%3==0 and i//3<=n//3:
            max_score[i] = max(max_score[i], max_score[i//3]+n_list[i])

        i+=1
    return max_score[-1]
        

for test_case in range(int(input())):
    n = int(input())
    
    n_list = [0] + list(map(int,input().split()))
    max_score = [0]+[0]*n
    
    print(get_max_score(n_list,max_score,n))