using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
    class Employee : Person
    {
        //- SalaryOfHour (saatbaşı qazandığı maaş)
        //- WorkingHour(30 gün ərzində neçə saat işlədiyi)
        //- CalculateSalary() - Ümumi maaşı hesablayan method.
        //memberləri olur.

        
        public double SalaryOfHour { get; set; }
        
        public int WorkingHour { get; set; }
        

        
        
        public Employee(double SalaryOfHour, int WorkingHour):base()
        {
            this.SalaryOfHour = SalaryOfHour;
            this.WorkingHour = WorkingHour;
        }

        public Employee()  {}

        public string CalculateSalary()

        {
            try
            {

              if (age < 18) return "You have no right to work!"; /*Sizin ishleme huququnuz yoxdur!*/
              double TotalSalary = SalaryOfHour * WorkingHour;

           

              string text = $"Calculated monthly salary: {TotalSalary} azn."; /*Hesablanan ayliq maash*/
              if (TotalSalary < 250) text += "\nThe monthly salary should not be less than 250 azn."; /*Ayliq maash 250 azn - den ashagi olmamalidir*/

               if (WorkingHour / 22 > 8)
               {
                text = "The average monthly working hours should not exceed 8 hours !!!"; /*Orta aylıq iş saatı 8 saatdan çox olmamalıdır!!!*/
               }

              return text;
            }
            catch (NullReferenceException)
            {

                throw new Exception("sadsdfhg") ;
            }
        }
    }
}
