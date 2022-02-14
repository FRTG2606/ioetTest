using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeSchedules
{
    class Program
    {
        Validations vld = new Validations();
        
        static void Main(string[] args)
        {
            
            string fileHours;
            Console.Write("Enter file path to calculate:");
            fileHours = Console.ReadLine();
            if (fileHours.Length > 0)
            {
                //string resp = 
                    validateFile(fileHours);
            }
            else
            {
                Console.Write("Please enter a valid file!!");
                Console.ReadKey();
                //Console.ReadLine();
            }
            Console.ReadKey();
        }
        public static void  validateFile(string fileHours)
        {
            try {
                string curFile = fileHours;
                Validations v = new Validations();
                Console.WriteLine(File.Exists(curFile) ? "Validating ..." : "File does not exist.");
                if (System.IO.Path.GetExtension(curFile).ToLower() == ".txt")
                {
                    v.validateLines(curFile);
                }
                else
                {
                    Console.WriteLine("The file is not .txt");
                    Console.WriteLine("Please upload a text file!!");
                }
                //return "";

            }
            catch (Exception ex)
            {
                Console.WriteLine("Please check:"+ ex.Message.ToString());
                //return "";
            }
        }

    }
}
