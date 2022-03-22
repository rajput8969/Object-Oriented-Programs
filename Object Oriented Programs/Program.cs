using System;
using System.IO;
using InventoryManagement;

namespace Object_Oriented_Programs
{   
    /// <summary>
    /// this program the Entry Point program for OOPS Project
    /// </summary>
   public class Program
    {
        /// <summary>
        /// main () which is the 1st () to be invoked by the CLR
        /// </summary>
        /// <param name="args">this in never used</param>
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 for InventoryManagement\n" );
                
            int number = int.Parse(Console.ReadLine());
           
            ////using switch case to select the required class
            switch (number)
            {
                case 0:
                    new Test();
                    break;
                case 1: InventoryManagement.DiverMethod();
                    break;
                default: Console.WriteLine("Invalid Entry");
                    break;
            }
        }
    }
}
