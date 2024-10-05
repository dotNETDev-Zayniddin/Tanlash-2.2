/*1. Vaqt kalkulyatori:
Kirish sifatida daqiqalar sonini oladigan va uni soat:daqiqa formatida chiqaradigan dastur yozing. 
Misol uchun, agar foydalanuvchi 135 daqiqani kiritsa, dastur "2:15" chiqishi kerak.
Hisoblash uchun arifmetik amallardan foydalaning.
*/

using System;
namespace Tanlash
{   
    class Program
    {
        static void Main(){
            System.Console.Write("Daqiqalar sonini kiriting: ");
            int minute = Convert.ToInt32(Console.ReadLine());
            int hour =  (int) minute / 60;
            if(hour < 24)
            {
                   System.Console.WriteLine($"Natija: {hour}:{(minute % 60):D2}");
            }
            else{
                System.Console.WriteLine("24 soatdan oshib ketdi. Kunni ham qo'shib hisoblashni xohlaysizmi (Ha/Yo'q)?");
                string continueAction = Console.ReadLine().ToLower();
                if(continueAction == "yoq" || continueAction == "yuq"){
                   System.Console.WriteLine("Dastur yakunlandi"); 
                }
                else if(continueAction == "ha" || continueAction == "albatta" ){
                    int day = (int) hour / 24;
                    System.Console.WriteLine($"Natija: {day} kun {hour%24} soat {(minute % 60 ):D2} daqiqa");
                }
            }

         
            
        }
    }
}