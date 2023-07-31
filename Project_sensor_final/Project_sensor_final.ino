#include <PZEM004Tv30.h>

String inputString= "";
boolean stringComplete = false;
String commandString = "";

PZEM004Tv30 pzem(&Serial2); // connect to serial 2 Arduino Mega

const int relay0 = 2;
const int relay1 = 3;

boolean isConnected = false;

// reset arduino
void (* saya_reset) (void) = 0; 

void setup() {
  
  Serial.begin(115200);
  pinMode(relay0,OUTPUT);
  pinMode(relay1,OUTPUT);
  mati(relay0);
  mati(relay1);
}

void loop() 
{  
        //Activating sensor 
         float voltage = pzem.voltage();
         float current = pzem.current();
         float power = pzem.power();
         float energy = pzem.energy();
         float frequency = pzem.frequency();
         float pf = pzem.pf();
         
         if(voltage != NAN && current != NAN )
         {
             Serial.print("@");
             Serial.print(",");
             Serial.print(voltage);
             Serial.print(",");
             Serial.print(current);
             Serial.print(",");
             Serial.print(power);
             Serial.print(",");
             Serial.print(energy,3);
             Serial.print(",");
             Serial.print(frequency, 1);
             Serial.print(",");
             Serial.print(pf);
             Serial.print(",");
             Serial.print("$");
             Serial.print("\n");
          }
          delay(5000);
          while (Serial.available()==1) {
          // get the new byte:
          char inChar = (char)Serial.read();
          // add it to the inputString:
          inputString += inChar;
          // if the incoming character is a newline, set a flag so the main loop can
          // do something about it:
          if (inChar == '\n') {
            stringComplete = true; 
          }
          if(stringComplete)
        {
          stringComplete = false;
          getCommand();
      
          if(commandString.equals("reset"))
          {
            saya_reset();
          }
          if(commandString.equals("load1"))
          {
            boolean relayState = getRelayState();
            if(relayState == true)
            {
              nyala(relay0);
            }
            else
            {
              mati(relay0);
            }
          }
          if (commandString.equals("load2"))
          {
            boolean relayState = getRelayState();
            if(relayState == true)
            {
              nyala(relay1);
            }
            else
            {
              mati(relay1);
            }
          }
          inputString = "";
        }
        }
}

//getting relay state
boolean getRelayState()
{
  boolean state = false;
  if(inputString.substring(6,8).equals("ON"))
  {
    state = true;
  }
  else
  {
    state = false;
  }
  return state;
}

//getting request from user
void getCommand()
{
  if(inputString.length()>0)
  {
    commandString = inputString.substring(1,6);
  }
}

//turn on relay
void nyala(int pin)
{
  digitalWrite(pin,HIGH);
}

//turn off relay
void mati(int pin)
{
        digitalWrite(pin, LOW);
}
