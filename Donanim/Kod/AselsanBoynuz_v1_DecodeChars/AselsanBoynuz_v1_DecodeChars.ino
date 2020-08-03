
//1 Digitteki Segmentler - ABCDEFGHIJKLMNOPQ - ref.Aselsan Bakım Klavuzu 330

//Bu arrayde harfleri oluşturmak için gerekli olan segmentler 1 ile diğerleri sıfır ile gösterilmiştir.
const String segmentFont[] = {
  "00000000000000000",//WhiteSpace
  "00001100110001000",//K
  "01101110000001000",//N
  "11111100100100000",//0
  "01100000000000000",//1
  "11011000011000000",//2
  "11110000001000000",//3
  "01100100011000000",//4
  "10110100011000000",//5
  "10111100011000000",//6
  "11100000000000000",//7
  "11111100011000000",//8
  "11110100011000000"//9


};

const char segmentIndex = "ABCDEFGHIJKLMNOPQ";
const char index[] = " KN0123456789";
bool debug = false;
#include <Wire.h>
#define AselsanDisplayReceiveAddr 0x38

void setup()
{
  Serial.begin(115200);
  Wire.begin(AselsanDisplayReceiveAddr);
  Wire.setClock(10000);
  Wire.onReceive(LCDDataReceivedHandler);
}

void loop() {}

void LCDDataReceivedHandler(int receivedByteCount)
{
  if (receivedByteCount > 5)
  {
    byte receivedBytes[32];
    for (int i = 0; i < receivedByteCount; i++)
    {
      receivedBytes[i] = Wire.read();
      if (debug)
      {
        Serial.print(receivedBytes[i], HEX);
        Serial.print(" ");
      }
    }
    ExtractBitsFromReceivedI2CData(receivedBytes);

  }
}


String GetPaddedBinStr(byte data)
{
  String binStr = String(data, BIN);
  if (binStr.length() != 8)
  {
    while (binStr.length() < 8)
      binStr = "0" + binStr;
  }
  //return "0010000000000011111010000000111000010110000000000000000000000011001001100100001000110010011001000110000000000000000000000000000000000000000000000000000000000001";
  return binStr;
}


void ExtractBitsFromReceivedI2CData(byte *data)
{
  String binaryResult = "";
  String charResult = "";
  String orderedSegmentResult = "";
  for (int i = 3; i < 23; i++)
  {
    binaryResult += GetPaddedBinStr(data[i]);
  }
  if (false)
  {
    Serial.print("Binary Result : ");
    Serial.print(binaryResult);
    Serial.println();
  }
  int startIndex = 0;
  for (byte k = 0; k < 6; k++)
  {
    charResult = binaryResult.substring(startIndex, startIndex + 24);
    if (false)
    {
      Serial.print("SubStrResult : ");
      Serial.print(charResult);
      Serial.println();
    }

    orderedSegmentResult += charResult[6];
    orderedSegmentResult += charResult[10];
    orderedSegmentResult += charResult[9];
    orderedSegmentResult += charResult[3];
    orderedSegmentResult += charResult[17];
    orderedSegmentResult += charResult[18];
    orderedSegmentResult += charResult[0];
    orderedSegmentResult += charResult[5];
    orderedSegmentResult += charResult[14];
    orderedSegmentResult += charResult[2];
    orderedSegmentResult += charResult[13];
    orderedSegmentResult += charResult[1];//L
    orderedSegmentResult += charResult[7];
    orderedSegmentResult += charResult[15];
    orderedSegmentResult += charResult[19];
    orderedSegmentResult += charResult[4];
    orderedSegmentResult += charResult[12];
    if (false)
    {
      Serial.print("Ordered Segment Result : ");
      Serial.print(orderedSegmentResult);
      Serial.println();
    }
    byte charPos = 0;
    for (byte index = 0; index <= 13; index++)
    {
      if (segmentFont[index] == orderedSegmentResult)
      {
        charPos = index;
        break;
      }
    }
    Serial.print(index[charPos]);
    startIndex = startIndex + 20;
    orderedSegmentResult = "";
  }
  Serial.println();
}
