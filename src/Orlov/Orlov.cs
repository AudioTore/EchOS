// Source code owned by: audiotore341
// 2022 License: GNU GENERAL PUBLIC LICENSE v2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EchOS
{

    public class Orlov
    {

        public static void start()
        {

            Cmdman.Clear_Src();

            string read = File.ReadAllText(@"0:\" + Kernel.orlovread);

            StreamReader sr = new StreamReader(@"0:\" + Kernel.orlovread);
            string str;

            while ((str = sr.ReadLine()) != null)
            {

                if (read.Contains("mov ah, "))
                {

                    string toremove = str.Remove(0, 8);
                    string remove = toremove.Replace("\"", ""); // Replace the quotes with nothing.
                    Console.WriteLine(remove);

                }

                else
                {
                    Console.WriteLine("Compliation error: INVAILD Syntax.");
                }

            }

         


        }

    }

}
