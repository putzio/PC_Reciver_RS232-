uint32_t hight,initTime;
#define ARRAY_SIZE(a) sizeof(a)/sizeof(a[0])
void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  while(!Serial.available());
  initTime = millis();
  
}
int parameters [] = {1,2,5,10,20};
uint8_t cnt = 0;
void loop() {
  // put your main code here, to run repeatedly:
  String recivedData = Serial.readString();
  if(recivedData != "-1" && recivedData != "")
  {
    Serial.println(recivedData);
    if(recivedData.substring(0,3) =="#P:")
    {
      //Change Preassure
      String preassure =  recivedData.substring(3,recivedData.indexOf("&"));
      Serial.print("Preassure: ");
      Serial.println(preassure);
      
    }
    if(recivedData.substring(0,3) =="###")
    {
      //Clear Flash
      Serial.println("Erase chip");
    }
    delay(100);
  }
  uint32_t t = millis() - initTime;
  hight = t/parameters[cnt];
  String output = "#t:"+ String(t/10) ;
  output += "&h:";
  output += String(hight) + "$";
  Serial.println(output); 
  if(t>5000)
  {
    cnt++;
    delay(100);
    if(cnt>=ARRAY_SIZE(parameters))
    {
      output = "END";
      Serial.println(output);
      while(1){
          String recivedData = Serial.readString();
          if(recivedData != "-1" && recivedData != "")
          {
            Serial.println(recivedData);
            if(recivedData.substring(0,3) =="#P:")
            {
              //Change Preassure
              String preassure =  recivedData.substring(3,recivedData.indexOf("&"));
              Serial.print("Preassure: ");
              Serial.println(preassure);
              
            }
            if(recivedData.substring(0,3) =="###")
            {
              //Clear Flash
              Serial.println("Erase chip");
            }
            delay(1000);
          }
      }
    }      
    output = "end";
    Serial.println(output);
    initTime = millis();
  }
  delay(100);
}
