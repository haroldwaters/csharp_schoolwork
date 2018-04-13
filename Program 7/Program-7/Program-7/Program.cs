using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Program_7
{
    class Program
    {
        static int reqCount = 0;
        static void Main(string[] args)
        {
            DirectoryInfo di;
            FileInfo fi;
            FileAttributes fa;
            
            Console.Title = "Program-7";
            requirementText();
            Console.WriteLine("This is Program-7");

            requirementText();
            string dirName = "./newDir";
            try
            {
                di = Directory.CreateDirectory(dirName);
                Console.WriteLine($"Directory {di.Name} created at {di.Parent}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                if (Directory.Exists(dirName) 
                    && Directory.GetFiles(dirName).Length == 0 
                    && Directory.GetDirectories(dirName).Length == 0)
                {
                    Directory.Delete(dirName);
                }
                Console.WriteLine($"{dirName} deleted.");
            }

            requirementText();
            Console.Write("How many directories to create: ");
            int dirNum = int.Parse(Console.ReadLine());

            requirementText();
            for (int i = 0; i < dirNum; ++i)
            {
                Console.WriteLine("Checking if directory exists...");
                if (!Directory.Exists($"./{i}"))
                {
                    Console.WriteLine($"Creating dir ./{i}");
                    di = Directory.CreateDirectory($"./{i}");
                    Console.WriteLine($"Directory {di.Name} created at {di.Parent}");
                }
                else
                {
                    Console.WriteLine($"Directory ./{i} already exists");
                }
            }
            for (int i = 0; i < dirNum; ++i)
            {
                Directory.Delete($"./{i}");
            }

            requirementText();
            Console.Write("How many files to create: ");
            int fileNum = int.Parse(Console.ReadLine());

            requirementText();
            requirementText();

            for(int i = 0; i < fileNum; ++i)
            {
                Console.WriteLine("Checking if file exists...");
                if (!File.Exists($"./{i}"))
                {
                    Console.WriteLine($"Creating file ./{i}");

                    using (FileStream fs = File.Create($"./{i}"))
                    {
                        Console.Write("Enter text to insert into file:");
                        string text = Console.ReadLine();
                        Byte[] byteText = new UTF8Encoding(true).GetBytes(text);
                        fs.Write(byteText, 0, byteText.Length);
                    }


                    fi = new FileInfo($"./{i}");
                    Console.WriteLine($"File {fi.Name} created at {fi.Directory.Parent}");
                }
                else
                {
                    Console.WriteLine($"File ./{i} already exists");
                }
            }

            requirementText();
            for(int i = 0; i < fileNum; ++i)
            {
                Console.WriteLine($"Reading from file ./{i}");
                Console.WriteLine(System.IO.File.ReadAllText($"./{i}"));
            }

            requirementText();
            for(int i = 0; i < fileNum; ++i)
            {
                fa= File.GetAttributes($"./{i}");

                if((fa & FileAttributes.Archive) == FileAttributes.Archive)
                {
                    Console.WriteLine("File is an archive");
                }
                else
                {
                    Console.WriteLine("File is not an archive");
                }

                if((fa & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                {
                    Console.WriteLine("File is read only");
                }
                else
                {
                    Console.WriteLine("File is not read only");
                }
            }


            for(int i = 0; i < fileNum; ++i)
            {
                File.Delete($"./{i}");
            }


            requirementText();
            Console.WriteLine("Thank you for running Program-7");

            Console.ReadKey(true);

        }

        static void requirementText()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Requirement " + (++reqCount));
            Console.ResetColor();
        }
    }
}