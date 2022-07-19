import sys

try:
    f_name = sys.argv[1]
except:
    f_name = 'students.txt'

f = open(f_name,'r')

def get_avg_grade(mid,fin):
    int(mid); int(fin)
    avg = (mid+fin)/2
    grade = ''
    if avg >= 90:
        grade = 'A'
    elif avg >= 80:
        grade = 'B'
    elif avg >= 70:
        grade = 'C'
    elif avg >= 60:
        grade = 'D'
    else:
        grade = 'F'
    return avg, grade

def refresh_list(slist):
# 평균점수 등급 추가
    for i in slist:
        avg, grade = get_avg_grade(int(i[2]),int(i[3]))
        if len(i)<=4:
            i.append(avg)
            i.append(grade)
        else:
            i[4] = avg; i[5] = grade
# 평균 점수 순으로 정렬
    slist.sort(key = lambda x : x[4], reverse = True)
    
def show(lis):
    global head
    print(head)
    for i in lis:
        print('{:>}\t{:>12}\t{:>5}\t{:>5}\t{:>6}\t{:>3}'.format(i[0],i[1],i[2],i[3],i[4],i[5]))
    return

def search(S_id):
    global score_list
    for i in score_list:
        if S_id in i[0]:
            print(head)
            print('{:>}\t{:>12}\t{:>5}\t{:>5}\t{:>6}\t{:>3}'.format(i[0],i[1],i[2],i[3],i[4],i[5]))
            return
    print('NO SUCH PERSON.')
    return

def changescore(S_id):
    global score_list
    for i in score_list:
        if S_id in i[0]:
            state = input('Mid/Final: ')
            if state == 'mid' or state == 'final':
                new_score = input('Input new score: ')
                if int(new_score)>=0 and int(new_score)<=100:
                    print(head)
                    print('{:>}\t{:>12}\t{:>5}\t{:>5}\t{:>6}\t{:>3}'.format(i[0],i[1],i[2],i[3],i[4],i[5]))
                    if state == 'mid':
                        i[2] = new_score
                    else:
                        i[3] = new_score
                    print('Score changed.')
                    refresh_list(score_list)
                    print('{:>}\t{:>12}\t{:>5}\t{:>5}\t{:>6}\t{:>3}'.format(i[0],i[1],i[2],i[3],i[4],i[5]))
                    return
                else:
                    return
            else:
                return
    print('NO SUCH PERSON.')
    return

def searchgrade(gra):
    global score_list
    grade_list = []
    for i in score_list:
        grade_list.append(i[5])
    if gra in ['A','B','C','D','F']:
        if gra in grade_list:
            print(head)
            for i in score_list:
                if i[5] == gra:
                    print('{:>}\t{:>12}\t{:>5}\t{:>5}\t{:>6}\t{:>3}'.format(i[0],i[1],i[2],i[3],i[4],i[5]))
        else:
            print('NO RESULTS')
            return
    else:
        return
                
    return

def add(S_id):
    global score_list
    for i in score_list:
        if S_id in i[0]:
            print('ALREADY EXISIT.')
            return

    name = input('Name: ')
    mid = input('Midterm Score: ')
    fin = input('Final Score: ')
    score_list.append([S_id,name,mid,fin])
    print('Student added')
    refresh_list(score_list)
    return

def remove():
    global score_list
    if score_list == []:
        print('List is empty.')
        return
    else:
        s_id = input('Student ID: ')
        for i in range(len(score_list)):
            if s_id in score_list[i][0]:
                del score_list[i]
                print('Student removed.')
                return
        print('NO SUCH PERSON.')
        return
    return

def quit(msg):
    global score_list
    if msg == 'yes':
        fname = input('File name: ')
        
        with open(fname, 'w') as fw:
            fw.write(head)
            for i in score_list:
                fw.write('\n{:>}\t{:>12}\t{:>5}\t{:>5}\t{:>6}\t{:>3}'.format(i[0],i[1],i[2],i[3],i[4],i[5]))
            return
         
    else:
        return
    return


    
score_list = []

# 목록 가져오기
for i in f:
    score_list.append(i.rstrip('\n').split('\t'))
    
#print(score_list)

head = 'Student\t\t\tName\tMidterm\tFinal\tAverage\tGrade\n'+'-'*(63)


# 학생리스트 최신화
refresh_list(score_list)
# 프로그램 실행시 학생정보 출력
show(score_list)
#search('20180002')

# 명령 입력부

while True:
    command = input('# ').lower()
    if command == 'show':
        show(score_list)
    elif command == 'search':
        search(input('Student ID: '))
    elif command == 'changescore':
        changescore(input('Student ID: '))   
    elif command == 'searchgrade':
        searchgrade(input('Grade to search: '))
    elif command == 'add':
        add(input('Student ID: '))
    elif command == 'remove':
        remove()
    elif command == 'quit':
        quit(input('Save data?[yes/no]'))
        break
    else:
        continue

f.close()
