import RPi.GPIO as GPIO
from time import sleep
from flask import Flask

app = Flask(__name__)

@app.route('/')
def hello():
    return "hello world"

@app.route('/led/<onoff>')
def ledonoff(onoff):
    if onoff == "on":
        print("Led Turn on")
        GPIO.output(4,1)
        GPIO.output(5,1)
        GPIO.output(14,1)
        GPIO.output(15,1)
        return "LED on"

    elif onoff == "off":
        print("LED Turn off")
        GPIO.output(4,0)
        GPIO.output(5,0)
        GPIO.output(14,0)
        GPIO.output(15,0)
        return "LED off"

    elif onoff == '1on':
        GPIO.output(4,1)
    elif onoff == '1off':
        GPIO.output(4,0)
    elif onoff == '2on':
        GPIO.output(5,1)
    elif onoff == '2off':
        GPIO.output(5,0)
    elif onoff == '3on':
        GPIO.output(15,1)
    elif onoff == '3off':
        GPIO.output(15,0)
    elif onoff == '4on':
        GPIO.output(14,1)
    elif onoff == '4off':
        GPIO.output(14,0)
    
    return "LED " + onoff

@app.route('/led/on/<isparty>')
def partymode(isparty):
    print("Partymode on")
    if isparty == "partymode":
        for i in range(5):
            GPIO.output(4,0)
            GPIO.output(5,0)
            GPIO.output(14,0)
            GPIO.output(15,0)
            sleep(0.5)
            GPIO.output(4,1)
            GPIO.output(5,1)
            GPIO.output(14,1)
            GPIO.output(15,1)
            sleep(0.5)
    return "파티끝~"
    
if __name__ == "__main__":
    GPIO.setmode(GPIO.BCM)
    GPIO.setup(4,GPIO.OUT, initial=GPIO.LOW)
    GPIO.setup(5,GPIO.OUT, initial=GPIO.LOW)
    GPIO.setup(14,GPIO.OUT, initial=GPIO.LOW)
    GPIO.setup(15,GPIO.OUT, initial=GPIO.LOW)
    app.run(host = '192.168.0.6', port=5000, debug=True)