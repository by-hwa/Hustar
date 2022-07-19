# -*- coding: utf-8 -*-
"""
Created on Fri Jul  1 13:46:51 2022

@author: byeonghwa
"""

def get_score_matrix(matrix,score_matrix):
    for row in range(rows):
        for col in range(cols):
            if col == 0 and row == 0:
                score_matrix[row][col] = matrix[row][col]
            elif col == 0 and row > 0:
                score_matrix[row][col] = score_matrix[row-1][col] + matrix[row][col]
            elif col > 0 and row == 0:
                score_matrix[row][col] = score_matrix[row][col-1] + matrix[row][col]
            elif col > 0 and row > 0:
                score_matrix[row][col] = min(score_matrix[row-1][col],score_matrix[row][col-1],score_matrix[row-1][col-1]) + matrix[row][col]

for test_case in range(int(input())):
    rows, cols = map(int,input().split())
    
    matrix = []
    score_matrix = [[0 for col in range(cols)] for row in range(rows)]
    first_col = []
    
    for row in range(rows):
        matrix.append(list(map(int,input().split())))
        first_col.append(matrix[row][0])
    
    # 초기 값 설정    
    
    # for col in range(cols):
    #     score_matrix[0][col] = sum(matrix[0][:col+1])
    # for row in range(rows):
    #     score_matrix[row][0] = sum(first_col[:row+1])
    
    get_score_matrix(matrix,score_matrix)
    print(get_score_matrix[rows-1][cols-1])