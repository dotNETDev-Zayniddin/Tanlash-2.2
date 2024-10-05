/*
2. Yosh toifasini aniqlash:
Foydalanuvchining yoshini so'ragan va uning yosh toifasini aniqlaydigan dastur yarating:
 "bola" (0-12 yosh), "o'smir" (13-19 yosh), "kattalar" (20-59 yosh) yoki " katta” (60 yosh) va undan katta). 
 Bu vazifa uchun if-else iboralaridan foydalaning. 

*/
using System;
namespace Tanlash
{
    class Program
    {
        static void Main(){
            System.Console.Write("Yoshingizni kiriting: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age >=0 && age <= 12){
                Console.WriteLine("bola");
            }
            else if(age>=13 && age <= 19){
                System.Console.WriteLine("o'smir");
            }
            else if(age>=20 && age <= 59){
                System.Console.WriteLine("kattalar");
            }
            else if( age >=60 && age <= 140){
                System.Console.WriteLine("katta");
            }
            else{
                Console.WriteLine("Yosh xato kiritilgan.\nDastur yakunlandi.\nDasturni qayta ishga tushuring.");
            }
        }
    }
}