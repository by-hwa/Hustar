import RPi.GPIO as GPIO
from  time import sleep

def main(mode):
    LED_1 = 4
    LED_2 = 5
    LED_3 = 15
    LED_4 = 14

    GPIO.setmode(GPIO.BCM)
    GPIO.setwarnings(False)
    GPIO.setup(LED_1, GPIO.OUT, initial=False)
    GPIO.setup(LED_2, GPIO.OUT, initial=False)
    GPIO.setup(LED_3, GPIO.OUT, initial=False)
    GPIO.setup(LED_4, GPIO.OUT, initial=False)

    if mode == 1:
        print("main() program running... good..")

        try:
            while True:
		GPIO.output(LED_1, GPIO.HIGH)
                sleep(0.5)
                GPIO.output(LED_2, GPIO.HIGH)
                sleep(0.5)
                GPIO.output(LED_3, GPIO.HIGH)
                sleep(0.5)
                GPIO.output(LED_4, GPIO.HIGH)
                sleep(0.5)
                GPIO.output(LED_1, GPIO.LOW)
                sleep(0.5)
                GPIO.output(LED_2, GPIO.LOW)
                sleep(0.5)
                GPIO.output(LED_3, GPIO.LOW)
                sleep(0.5)
                GPIO.output(LED_4, GPIO.LOW)
                sleep(0.5)

        except KeyboardInterrupt:
            GPIO.cleanup()

    elif mode == 2:
        try:
            while True:
                led_number = "LED_" + input("LED NUMBER : ")
                if led_number == "LED_1": led_number = LED_1
                elif led_number == "LED_2": led_number = LED_2
                elif led_number == "LED_3": led_number = LED_3
                elif led_number == "LED_4": led_number = LED_4
                else: print("invalid input")

                led_set = input("LED SET : ")
                if led_set == "ON":led_set=1
                elif led_set == "OFF":led_set=0
                else:print("Error!!!!!")
                GPIO.output(led_number, led_set)

        except KeyboardInterrupt:
            GPIO.cleanup()
            
    else:
        print("error key")
        return -1

if __name__ == '__main__':
    mode = int(input("mode (1,2): "))
    
    main(mode)