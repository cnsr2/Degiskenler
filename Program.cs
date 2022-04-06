using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args) 
        {
            //  byte b =5;      // 1 byte
            //  sbyte c =5;     // 1 byte
            //  short s =5;      //2byte
            //  ushort us =5 ;   //2byte

            //  Int16 i16 =2;    //2byte 
            //  int i =2;        //4 byte
            //  int32 i32 =2;     //4byte
            //  Int64 i64 =2;    //8byte
            //  uint ui =2;      //4byte
            //  long l =4;       //8byte


            //  //Reel Sayılar
            //  float f =5;      //4byte
            //  double d =5;     //8byte
            //  decimal de = 5;  //16byte


            //  char ch ='2';       //2byte
            //  string str ="Emre"; //Sınırsız
            
            //  bool b1 = true;
            //  bool b2 = false;


            //  DateTime dt =DateTime.Now;
            //  Console.Write(dt);
             
            //  object o1 = "x";
            //  object o2 = 'y';
            //  object o3 = 4;
            //  object o4 = 4.3;

            //  //string ifadeler

            //  string str1 = string.Empty;
            //  str1 = "Emre Sarı";
              string ad = "Emre Can";
              string soyad = "Sarı";
              string tamIsim = ad + " " + soyad;
                Console.WriteLine (tamIsim);
            //  //integer tanuımlama şekilleri

            //  int integer1 = 5;
            //  int integer2 = 3;
            //  int integer3 = integer1 * integer2;

            //  //boolean

            //  bool bool1 = 10>2;

             //degisken dönüsümleri

             //string str21= "20";
             //int int21 = 20;
             //string yeniDeger1 = str21 + int21.ToString();
             //Console.WriteLine(yeniDeger1);// cıktısı 2020

             //int int22 = int21 + Convert.ToInt32(str21);
             //Console.WriteLine(int22); // çıktısı 40
             //int int23 = int21 + int.Parse(str21);  
             //Console.WriteLine(int23); // çıktısı 40

             
             
             //int str20 =20;
             //double f20 =20.5;
             
             //double yeniDeger = str20 + f20;
             //Console.WriteLine(yeniDeger);

             //string str15 = "bugünki";
             //string str25 = "dersim";
             //string str30 = "bitti";
             
             //string son = str15 + " " + str25 + " " + str30;
             //Console.WriteLine(son);


             //bool isActive = false;
             //if(isActive){
             // Console.WriteLine("aktifmiş");
             //}else{
             //    Console.WriteLine("pasifmiş");
             //} 

             //datetime

             //string datetime = DateTime.Now.ToString("dd.MM.yyyy");
             //Console.WriteLine(datetime);
             string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
             Console.WriteLine(datetime2);
             
             //saat
             string hour = DateTime.Now.ToString("HH:mm");
             Console.WriteLine(hour);
             

            


            

        }
    }
}