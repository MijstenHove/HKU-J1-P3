 #include <Servo.h>

//Threshold for servo motor control with muscle sensor. 
//You can set a threshold according to the maximum and minimum values of the muscle sensor.
#define THRESHOLD 250

//Pin number where the sensor is connected. (Analog 0)
#define EMG_PIN 0
#define SERVO_PIN 3

int BUTTONstate = 0;
const int BUTTON = 4;

//Define Servo motor
Servo SERVO_1;
 
/*-------------------------------- void setup ------------------------------------------------*/

void setup()
{

  pinMode(50,OUTPUT);
  pinMode(BUTTON,INPUT);
  
  Serial.begin(115200);
  
  //Set servo motor to digital pin 3
  SERVO_1.attach(SERVO_PIN);
  SERVO_1.write(0);
  delay(200);
  SERVO_1.write(180);
  delay(200);
  SERVO_1.write(0);
  pinMode(A0, INPUT);
}
void loop() 
{                                  
  BUTTONstate = digitalRead(BUTTON);
  Serial.println(BUTTONstate);
    if (BUTTONstate == 0)  // Condition to check button input
    {
      SERVO_1.write(180); 
    }
    else
    {
      SERVO_1.write(0);    
    }

  
  /*SERVO_1.write(60);                                  //move servo to 60 deg
  delay(500);                                           //wait for 500ms   
  
  SERVO_1.write(120);                                 //move servo to 120 deg
  delay(500);                                           //wait for 500ms  
  
  SERVO_1.write(180);                                 //move servo to 180 deg
  delay(500);                                           //wait for 500ms  
  
 SERVO_1.write(120);                                 //move servo to 120 deg
  delay(500);                                           //wait for 500ms  
  
  SERVO_1.write(60);                                  //move servo to 60 deg
  delay(500);                                           //wait for 500ms      
  
  SERVO_1.write(0);                                   //move servo to 0 deg
  delay(500);                                         //wait for 500ms    */    
}
