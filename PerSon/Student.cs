using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
    class Student : Person
    {
        public int IQRank { get; set; } /*IQ imtahanının nəticəsi 100 bal üzərindən*/
        public int LanguageRank { get; set; } /*Dil imtahanının nəticəsi (100 bal üzərindən)*/
        

        public Student(int IQRank , int LanguageRank):base()
        {
            this.IQRank = IQRank;
            this.LanguageRank = LanguageRank;
        }

        public Student(): base()
        {
        }

        

        //Şagirdin iki imtahanının nəticəsi 120dən azdırsa, o zaman sinifdə qaldığı mənasını bildirən methoddur.
        public string ExamResult()
        {
            if (age < 6 || age > 20) return "your age is not appropriate for the student."; /*yaşınız şagird üçün uyğun deyil*/
            int Great = IQRank + LanguageRank;
           string text =  $"You scored {Great} points on the exam."; /*Siz imtahanda ... bal topladınız.*/
            if (Great >= 120)
                text += "\nCONGRATULATIONS!YOU HAVE SUCCESSFULLY PASSED THE EXAM."; /*TƏBRİKLƏR!SİZ İMTAHANI UĞURLA KEÇDİNİZ*/
            else
                 text += "\nYou could not score a passing score. Unfortunately, you stayed in class. "; /*Siz keçid balı ala bilmədiniz.Təəssüf ki, siz sinifdə qaldınız.*/

            return text;
        }
    }
}
