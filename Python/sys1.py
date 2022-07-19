import sys

print(sys.argv)

fr = open('new.txt','r')
rw = open('new1.txt','w')

for i in fr:
    fw.write(i)

fr.close()
fw.close()