#define STX               '>'
#define ETX               '<'

#include <EEPROM.h>
#define SERIAL_BAUD_RATE 115200

int eepromkayit, kaydedilece_veri;
int okunanadres, okunan_veri;

int giris_pin=10;
int okunan_giris=0;
int a=EEPROM.read(30);


String inputString = "";
String strCommand = "";
String comingMessage = "";
boolean stringComplete = false;

int eeAddr = 0;
byte eeVal = 0;

void setup() {
  Serial.begin(SERIAL_BAUD_RATE);
  Serial.println(">RE<");
  pinMode(giris_pin,INPUT_PULLUP);
  pinMode(EEPROM.read(30), OUTPUT);
}

void loop() {


  eepromkayit = 10;
  okunan_veri = EEPROM.read(okunanadres);
  okunan_giris=EEPROM.read(30);
  if (stringComplete)
  {

    //Serial.println("String complete");
    strCommand = "";

    strCommand = parseCommandString(inputString);

    //Serial.print(inputString);
    if (strCommand == "BE")
    {
      Serial.print(">BETUL<");

      delay(25);
    }

     if (strCommand  )
    {
      Serial.print(strCommand);

      delay(25);
    }

    if ( strCommand == "AA")
    {
      Serial.print(">AA<");
    }
    
    if (strCommand == "II")
    {
     parseParameter(inputString);
     okunan_giris = digitalRead(giris_pin);
     Serial.println(giris_pin); 
         delay(25);
    }

   if (strCommand == "OO")
   {
      parseParameter(inputString);
      okunan_giris= digitalRead(a);
      Serial.println(a);
      
    }
    if (strCommand == "EC")

    {
      for (int i = 0; i < EEPROM.length(); i++)
      {
        EEPROM.update(i, 0);
      }
      Serial.print(inputString);
    }
    if (strCommand == "ER")
    {

      parseParameter(inputString);
      eeVal = EEPROM.read(eeAddr);
      Serial.print("EE addr: "); Serial.print(eeAddr); Serial.print(" , EE val: "); Serial.println(eeVal);

    }
    if (strCommand == "EW")
    {
      parseParameter(inputString);

      eeVal = (byte)eeVal;
      EEPROM.write(eeAddr, eeVal);
      delay(10);
      eeVal = EEPROM.read(eeAddr);
      //        Serial.print("Eeprom adres:");
      //        Serial.println(eeAddr);
      //        Serial.print("Eeprom deger:");
      //        Serial.println(eeVal);


      Serial.print("EE addr: "); Serial.print(eeAddr); Serial.print(" , EE val: "); Serial.println(eeVal);
    }

    if (strCommand == "RE")
    {
      asm ( "jmp 0");
    }

     inputString = "";
    stringComplete = false;
  }

  //Serial.print("loop");
}

void serialEvent() {

  while (Serial.available()) {
    char inChar = (char)Serial.read(); // get the new byte:
    if (inChar == STX)
    {
      // add it to the inputString:
      inputString = STX;

    } //if end
    else
    {
      inputString += inChar;

    }
    if (inChar == ETX)
    { // if the incoming character is a newline, set a flag so the main loop can do something about it:
      stringComplete = true;
    }
  }
}

String parseCommandString(String comingMessage)
{
  // Remove STX
  comingMessage.remove(0, 1);

  // Remove ETX
  int indexOfETX = comingMessage.lastIndexOf("<");
  comingMessage.remove(indexOfETX, 1);

  // Return command(two chars in this case)
  return (comingMessage.substring(0, 2));
}

void parseParameter(String comingMessage)
{

  if (comingMessage.indexOf(",") > 0)
  {
    // cift parametreli
    // Remove STX
    comingMessage.remove(0, 1);

    // Remove ETX
    int indexOfETX = comingMessage.lastIndexOf("<");
    comingMessage.remove(indexOfETX, 1);

    // Remove command
    comingMessage.remove(0, 2);

    eeAddr = (comingMessage.substring(0, 4)).toInt();

    // Remove addr and get val
    comingMessage.remove(0, 5);
    eeVal = (byte)(comingMessage.toInt());


  }

  else
  {
    // tek parametreli
    // cift parametreli
    // Remove STX
    comingMessage.remove(0, 1);

    // Remove ETX
    int indexOfETX = comingMessage.lastIndexOf("<");
    comingMessage.remove(indexOfETX, 1);

    // Remove command
    comingMessage.remove(0, 2);

    eeAddr = (comingMessage.substring(0, 4)).toInt();

    eeVal = 0;
  }


}
