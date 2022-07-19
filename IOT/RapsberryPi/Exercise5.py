import board
import digitalio
import adafruit_dht
import adafruit_character_lcd.character_lcd as character_lcd
from  time import sleep

password = '1234'

lcd_rs = digitalio.DigitalInOut(board.D22)
lcd_en = digitalio.DigitalInOut(board.D24)
lcd_d7 = digitalio.DigitalInOut(board.D21)
lcd_d6 = digitalio.DigitalInOut(board.D26)
lcd_d5 = digitalio.DigitalInOut(board.D20)
lcd_d4 = digitalio.DigitalInOut(board.D19)

lcd_columns = 16
lcd_rows = 2

dhtDevice = adafruit_dht.DHT11(board.D17)

lcd = character_lcd.Character_LCD_Mono(lcd_rs, lcd_en, lcd_d4, lcd_d5, lcd_d6, lcd_d7, lcd_columns, lcd_rows)

def initTextlcd():
    lcd.clear()
    lcd.home()
    lcd.cursor_position(0,0)
    sleep(1.0)

def displayText(text = '', col=0,row=0):
    lcd.cursor_position(col,row)
    lcd.message = text

def clearTextlcd():
    lcd.clear()
    lcd.message = 'clear LCD\nGoodbye!'
    sleep(2.0)
    lcd.clear()

def main():
    initTextlcd()
    print("start textlcd program...")
    
    try:
        line = input("input password : ")
        lcd.clear()
        displayText(line,0,0)

        if line == password:
            displayText("CORRECT", 0, 1)
            sleep(2.0)
            while True:
                temperature_c = dhtDevice.temperature
                humidity = dhtDevice.humidity
                displayText("Temp. " + str(temperature_c) + " C",0,0)
                displayText("Humidity. " + str(humidity) + " %",0,1)
                sleep(2.0)
        else:
            displayText("FAIL", 0, 1)

    except KeyboardInterrupt:
        clearTextlcd()

if __name__ == '__main__':
    main()