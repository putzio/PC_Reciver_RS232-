uint32_t hight,initTime;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  while(!Serial.available());
  initTime = millis();
}

void loop() {
  // put your main code here, to run repeatedly:
  uint32_t t = millis() - initTime;
  hight = -t*t/10000 + t/10;
  String output = "#t:"+ String(t/10) ;
  output += "&h:";
  output += String(hight) + "$";
  Serial.println(output); 
  if(t>5000)
  {
    Serial.println("END");
    while(1);
  }
  delay(200);
}
