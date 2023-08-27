using System;
using System.Runtime.CompilerServices;

namespace operatörler

{
    class Program
    {
       static void Main(string[] args)
       {
        
        Console.WriteLine("*****atama ve işlemli atama operatörleri*****");
       
        // Atama ve işlemli atama
        int x = 3;
        int y = 3;
        y += 2; 
        Console.WriteLine(y);
        y += 2;
        Console.WriteLine(y);
        y /= 1;
        Console.WriteLine(y);
        x *= 2;
        Console.WriteLine(x);

        Console.WriteLine("*****Mantiksal Operatörler*****");  
        
        // Mantıksal operatörler
        // ||, &&,  !

        bool isSuccess = true;
        bool isCompleted = false;

        if(isSuccess && isCompleted)
            Console.WriteLine("Perpect!");
        if(isSuccess || isCompleted)
            Console.WriteLine("Great!");
        if(isSuccess && !isCompleted)
            Console.WriteLine("Fine!");
        

        Console.WriteLine("*****İlişkisel operatörler *****");
        // İlişkisel Operatörler
        // <, >, <=, >=, ==, !=

        int a = 3;
        int b = 4;
        bool sonuc = a<b;
        Console.WriteLine(sonuc);
        sonuc = a>b;
        Console.WriteLine(sonuc);
        sonuc = a>=b;
        Console.WriteLine(sonuc);
        sonuc = a<=b;
        Console.WriteLine(sonuc);
        sonuc = a==b;
        Console.WriteLine(sonuc);
        sonuc = a!=b;
        Console.WriteLine(sonuc);
     
        Console.WriteLine("*****Aritmetik operatörler *****");
        // Aritmetik Operatörler
        // /, *, +, -,

        int sayi1 = 10;
        int sayi2 = 5;
        int sonuc1 = sayi1/sayi2;
        Console.WriteLine(sonuc1);
        sonuc1= sayi1*sayi2;
        Console.WriteLine(sonuc1);
        sonuc1= sayi1+sayi2;
        Console.WriteLine(sonuc1);
        sonuc1= sayi1++;
        Console.WriteLine(sonuc1);

        // % : mod alır

        int sonuc2 = 20%3;
        Console.WriteLine(sonuc2);
        
          


            




       }
    }
}       

        

        


