import RPi.GPIO as GPIO
from time import sleep
from flask import Flask

ON = 1
OFF = 0

FAN_PIN1 = 18
FAN_PIN2 = 27

def onFan():
    GPIO.output(FAN_PIN1, GPIO.HIGH)
    GPIO.output(FAN_PIN2, GPIO.LOW)

def offFan():
    GPIO.output(FAN_PIN1, GPIO.LOW)
    GPIO.output(FAN_PIN2, GPIO.LOW)

app = Flask(__name__)

@app.route('/fan/<sec>')
def fancontrol(sec):
    onFan()
    sleep(int(sec))
    offFan()
    return sec+"초 작동 끝~"




if __name__ == "__main__":
    GPIO.setmode(GPIO.BCM)
    GPIO.setwarnings(False)
    GPIO.setup(FAN_PIN1, GPIO.OUT, initial=False)
    GPIO.setup(FAN_PIN2, GPIO.OUT, initial=False)
    app.run(host = '192.168.0.6', port=5000, debug=True)