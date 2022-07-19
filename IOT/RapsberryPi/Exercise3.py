import RPi.GPIO as GPIO
from  time import sleep
import spidev

spi = spidev.SpiDev()
CDS_CHANNEL = 0

LED_1 = 4
LED_2 = 5
LED_3 = 15
LED_4 = 14

LED_1_status = True
LED_2_status = True
LED_3_status = True
LED_4_status = True

def initMcp3208():
    spi.open(0, 0)
    spi.max_speed_hz = 1000000
    spi.mode = 3

def buildReadCommand(channel):
    startBit = 0x04
    singleEnded = 0x08

    configBit = [startBit | ((singleEnded | (channel & 0x07)) >>2), (channel & 0x07) << 6, 0x00]
    return configBit

def processAdcValue(result):
    byte2 = (result[1] & 0x0F)
    return (byte2 << 8 ) | result[2]

def analogRead(channel):
    if (channel > 7) or (channel < 0):
        return -1

    r = spi.xfer2(buildReadCommand(channel))
    adc_out = processAdcValue(r)
    return adc_out

def controlMcp3208(channel):
    analogVal = analogRead(channel)
    return analogVal

def readSensor(channel):
    return controlMcp3208(channel)

def LED_Initial():
    global LED_1_status, LED_2_status, LED_3_status, LED_4_status

    GPIO.setmode(GPIO.BCM)
    GPIO.setwarnings(False)
    GPIO.setup(LED_1, GPIO.OUT, initial=LED_1_status)
    GPIO.setup(LED_2, GPIO.OUT, initial=LED_2_status)
    GPIO.setup(LED_3, GPIO.OUT, initial=LED_3_status)
    GPIO.setup(LED_4, GPIO.OUT, initial=LED_4_status)

def main():
    LED_Initial()
    GPIO.setmode(GPIO.BCM)
    initMcp3208()
    print("Setup pin as outputs")

    try:
        while True:
            readVal = readSensor(CDS_CHANNEL)

            voltage = readVal * 4.096 / 4096
            print("CDS Val = %d\tVoltage=%f"%(readVal, voltage))
            # 0~820 / 820~1640 / 1640~2460 / 2460~3280 / 3280~
            if 3280 <= readVal:
                GPIO.output(LED_1,GPIO.LOW)
                GPIO.output(LED_2,GPIO.LOW)
                GPIO.output(LED_3,GPIO.LOW)
                GPIO.output(LED_4,GPIO.LOW)
            elif 2460 <= readVal:
                GPIO.output(LED_1,GPIO.HIGH)
                GPIO.output(LED_2,GPIO.LOW)
                GPIO.output(LED_3,GPIO.LOW)
                GPIO.output(LED_4,GPIO.LOW)
            elif 1640 <= readVal:
                GPIO.output(LED_1,GPIO.HIGH)
                GPIO.output(LED_2,GPIO.LOW)
                GPIO.output(LED_3,GPIO.HIGH)
                GPIO.output(LED_4,GPIO.LOW)
            elif 820 <= readVal:
                GPIO.output(LED_1,GPIO.LOW)
                GPIO.output(LED_2,GPIO.HIGH)
                GPIO.output(LED_3,GPIO.HIGH)
                GPIO.output(LED_4,GPIO.HIGH)
            else:
                GPIO.output(LED_1,GPIO.HIGH)
                GPIO.output(LED_2,GPIO.HIGH)
                GPIO.output(LED_3,GPIO.HIGH)
                GPIO.output(LED_4,GPIO.HIGH)
            sleep(0.5)

    except KeyboardInterrupt:
        GPIO.cleanup()
        spi.close()

if __name__ == '__main__':
    main()