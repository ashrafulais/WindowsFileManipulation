using System;
using System.IO;
using System.Threading;

namespace FilesManipulator
{
    public class Program
    {
        static void Main(string[] args)
        {

            ProgressBar progressBar = new ProgressBar();
            StringSanitizer stringSanitizer = new StringSanitizer();

            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Files");//Assuming Test is your Folder

            try
            {
                FileInfo[] Files = d.GetFiles("*.pdf"); //Getting Text files
                string str = "", srcFile = "", destFile = "";
                int counter = 1, totalfiles = Files.Length;

                Console.WriteLine("Renaming files..");

                foreach (FileInfo file in Files)
                {
                    Thread.Sleep(50);
                    str = file.Name;

                    //removing extras
                    str = stringSanitizer.GetFirstAlphabetIndex(str, str.Length);

                    srcFile = d + "\\" + file.Name;
                    destFile = d + "\\" + counter.ToString() + "." + str;

                    System.IO.File.Move(srcFile, destFile);
                    //Console.WriteLine(str);
                    //Console.Clear();

                    progressBar.DrawProgressBar(counter, totalfiles);
                    counter++;

                }

                Console.WriteLine("File renaming succesful");

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: "+e.Message);
            }
        }
    }
}
