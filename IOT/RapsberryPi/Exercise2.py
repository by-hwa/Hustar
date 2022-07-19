import RPi.GPIO as GPIO
from  time import sleep
import GPIO_EX

ROW0_PIN = 0
ROW1_PIN = 1
ROW2_PIN = 2
ROW3_PIN = 3
COL0_PIN = 4
COL1_PIN = 5
COL2_PIN = 6

COL_NUM = 3
ROW_NUM = 4

g_preData = 0

colTable = [COL0_PIN, COL1_PIN, COL2_PIN]
rowTable = [ROW0_PIN, ROW1_PIN, ROW2_PIN, ROW3_PIN]

LED_1 = 4
LED_2 = 5
LED_3 = 15
LED_4 = 14

LED_1_status = True
LED_2_status = True
LED_3_status = True
LED_4_status = True

def initKeypad():
    for i in range(0, COL_NUM):
        GPIO_EX.setup(colTable[i], GPIO_EX.IN)
    for i in range(0, ROW_NUM):
        GPIO_EX.setup(rowTable[i], GPIO_EX.OUT)

def selectRow(rowNum):
    for i in range(0, ROW_NUM):
        if rowNum == (i + 1):
            GPIO_EX.output(rowTable[i], GPIO_EX.HIGH)
            sleep(0.001)
        else:
            GPIO_EX.output(rowTable[i], GPIO_EX.LOW)
            sleep(0.001)
    return rowNum

def readCol():
    keypadstate = -1
    for i in range(0, COL_NUM):
        inputKey = GPIO_EX.input(colTable[i])
        if inputKey:
            keypadstate = keypadstate + (i+2)
            sleep(0.5)
    return keypadstate

def readKeypad():
    global g_preData
    keyData = -1
    
    runningStep = selectRow(1)
    row1Data = readCol()
    selectRow(0)
    sleep(0.001)

    if (row1Data != -1):
        keyData = row1Data
    
    if runningStep == 1:
        if keyData == -1:
            runningStep = selectRow(2)
            row2Data = readCol()
            selectRow(0)
            sleep(0.001)
            if (row2Data != -1):
                keyData = row2Data + 3

    if runningStep == 2:
        if keyData == -1:
            runningStep = selectRow(3)
            row3Data = readCol()
            selectRow(0)
            sleep(0.001)
            if (row3Data != -1):
                keyData = row3Data +6

    if runningStep == 3:
        if keyData == -1:
            runningStep = selectRow(4)
            row4Data = readCol()
            selectRow(0)
            sleep(0.001)
            if (row4Data != -1):
                if row4Data == 1:
                    keyData = "*"
                elif row4Data == 2:
                    keyData = 0
                else:
                    keyData = "#"

    if keyData == -1:
        return -1

    if g_preData == keyData:
        g_preData = -1
        return -1
    g_preData = keyData

    print("\r\nKeypad Data : {}".format(keyData))

    return keyData

def LED_Initial():
    global LED_1_status, LED_2_status, LED_3_status, LED_4_status

    GPIO.setmode(GPIO.BCM)
    GPIO.setwarnings(False)
    GPIO.setup(LED_1, GPIO.OUT, initial=LED_1_status)
    GPIO.setup(LED_2, GPIO.OUT, initial=LED_2_status)
    GPIO.setup(LED_3, GPIO.OUT, initial=LED_3_status)
    GPIO.setup(LED_4, GPIO.OUT, initial=LED_4_status)

def LED_Conrtrol(LED_Num):
    global LED_1_status, LED_2_status, LED_3_status, LED_4_status

    if LED_Num == 1:
        if LED_1_status:
            GPIO.output(LED_1, GPIO.LOW)
        else:
            GPIO.output(LED_1, GPIO.HIGH)
        LED_1_status = not LED_1_status
    elif LED_Num == 2:
        if LED_2_status:
            GPIO.output(LED_2, GPIO.LOW)
        else:
            GPIO.output(LED_2, GPIO.HIGH)
        LED_2_status = not LED_2_status
    elif LED_Num == 3:
        if LED_3_status:
            GPIO.output(LED_3, GPIO.LOW)
        else:
            GPIO.output(LED_3, GPIO.HIGH)
        LED_3_status = not LED_3_status
    elif LED_Num == 4:
        if LED_4_status:
            GPIO.output(LED_4, GPIO.LOW)
        else:
            GPIO.output(LED_4, GPIO.HIGH)
        LED_4_status = not LED_4_status
    else:
        GPIO.output(LED_1, GPIO.LOW)
        GPIO.output(LED_2, GPIO.LOW)
        GPIO.output(LED_3, GPIO.LOW)
        GPIO.output(LED_4, GPIO.LOW)
        LED_1_status = False
        LED_2_status = False
        LED_3_status = False
        LED_4_status = False

def main():
    GPIO.setwarnings(False)
    GPIO.setmode(GPIO.BCM)

    initKeypad()
    LED_Initial()
    print("setup keypad pin")

    try:
        while True:
            keyData = readKeypad()
            if keyData != -1:
                LED_Conrtrol(keyData)

    except KeyboardInterrupt:
        GPIO.cleanup()


if __name__ == '__main__':

    main()