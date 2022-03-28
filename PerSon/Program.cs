using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {  
            Start:
            try
            {
              Employee e = new Employee();
              Student st = new Student();
              Console.WriteLine("Enter a name of the employee:");
              e.name = Convert.ToString(Console.ReadLine());
              Console.WriteLine("Enter the last name of the employee :");
              e.surname = Convert.ToString(Console.ReadLine());
              Console.WriteLine("Enter the age of the employee :");
              e.age = Convert.ToInt32( Console.ReadLine());
              Console.WriteLine("Enter the hourly wage of the employee :");
              e.SalaryOfHour = Convert.ToDouble(Console.ReadLine());
              Console.WriteLine("Enter the number of hours worked within 30 days of the employee :");
              e.WorkingHour = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Worker: " + e.name+" "+ e.surname);
              Console.WriteLine("Your monthly salary" + e.CalculateSalary()); 

              Console.WriteLine("----------------------------------");

              Console.WriteLine("Enter a name of the student:");
              st.name= Convert.ToString(Console.ReadLine());
              Console.WriteLine("Enter the last name of the student:");
              st.surname = Convert.ToString(Console.ReadLine());
              Console.WriteLine("Enter the age of the student:");
                st.age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Determine how many points the student has scored on the IQ test over 100 points :");
              st.IQRank = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Determine how many points the student has scored on the LanguageRank test over 100 points :");
              st.LanguageRank = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Student: " + st.name + " " + st.surname);
              Console.WriteLine("Your result: " + st.ExamResult());
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Enter the value :");
                goto Start;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Oopss...there is an error");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            finally
            {
                Console.WriteLine("THE END");
            }
        }
    }
}
