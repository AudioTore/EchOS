// Source code owned by: audiotore341
// 2022 License: GNU GENERAL PUBLIC LICENSE v2

using System;


namespace EchOS
{

    public class Titlebar
    {


        public static void DrawBar()
        {

            // X and y cords.
            int XCord = Console.CursorLeft;
            int YCord = Console.CursorTop;

            // Top right of the screen.
            Console.SetCursorPosition(0, 0);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;

            var hour = Cosmos.HAL.RTC.Hour;
            var minute = Cosmos.HAL.RTC.Minute;
            var strhour = hour.ToString();
            var strmin = minute.ToString();

            Console.WriteLine("EchOS 1.5                        Build-12/25/2020                          " + strhour + ":" + strmin);

            if (Colorhandle.color == "Black")
            {

                Console.BackgroundColor = ConsoleColor.Black;

            }

            else if (Colorhandle.color == "Blue")
            {

                Console.BackgroundColor = ConsoleColor.Black;

            }

            else if (Colorhandle.color == "Yellow")
            {

                Console.BackgroundColor = ConsoleColor.Yellow;

            }

            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }



            // Now reset cursor positon.

            Console.SetCursorPosition(XCord, YCord);
            Console.ForegroundColor = ConsoleColor.White;

        }

    }

}
