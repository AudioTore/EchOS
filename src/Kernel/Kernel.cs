using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using System.Threading;
using Cosmos.HAL;

/* EchOS 2022 This is the base of the operating system
 * and where most of the Operating system spends its time.
 * Note that you can do anything with this system. Republish it with or without credit,
 * modify it, Make it goofy ahh, Go crazy bro!
 * 
 * Also if you are planning to modify the code MAKE SURE that you DO have Cosmos AND Vmware Installed. Otherwise there will be build errors when compiling this.
 */

namespace EchOS_Dev
{
    public class Kernel : Sys.Kernel
    {
        Cmdman cmd = new Cmdman(); // Command manager.

        public bool flag;
        protected override void BeforeRun()
        {
            flag = false;
            Console.Clear(); // Clear all the 'pre' boot messages.
                             // Animation frames for the 3D cube.
           
            
            Console.WriteLine(@"                    #
                     ######
                 ####   #  ##
              ####      #   ##
           ####         #     ##
        ###             #      ##
      ##                #       ###
      ###               #         ##
      # ##              #           ##
      #   ##            #          ###
      #    ##           #       ###  #
      #      ##         #    ###     #
      #       ##        #####        #
      #         ##    ###            #
      #          #####  #            #
      #            #    #            #
      #            #    #            #
      #            #    #            #
      #            #    #            #
      #            #    #            #
      #            #    #            #
      #            #  #####          #
      #            ###    ##         #
      #        #####        ##       #
      #     ###    #         ##      #
      #  ###       #           ##    #
      ###          #            ##   #
      ##           #              ## #
        ##         #               ###
         ###       #                ##
           ##      #             ###
            ##     #         ####
              ##   #      ####
               ##  #   ####
                 ######
                   #");
            Console.Clear();
            Console.WriteLine(@"  #
              ######
            ## #    ###
           ##  #       ###
         ##    #          ####
        ##     #              ####
      ##       #                 ##
     ##        #                ###
    #          #               ## #
   ##          #             ##   #
   # ####      #            ##    #
   #     ####  #           #      #
   #        ####         ##       #
   #           #####   ##         #
   #           #    ####          #
   #           #      #           #
   #           #      #           #
   #           #      #           #
   #           #      #           #
   #           #      #           #
   #           #      #           #
   #          ####    #           #
   #         ##   #####           #
   #       ##         ####        #
   #      #           #  ####     #
   #    ##            #      #### #
   #   ##             #          ##
   # ##               #          #
   ###                #        ##
   ##                 #       ##
    ####              #     ##
        ####          #    ##
            ###       #  ##
               ###    # ##
                  ######
                      #");
            Console.Clear();
            Console.WriteLine(@"
              ######
            ## #    ###
           ##  #       ###
         ##    #          ####
        ##     #              ####
      ##       #                 ##
     ##        #                ###
    #          #               ## #
   ##          #             ##   #
   # ####      #            ##    #
   #     ####  #           #      #
   #        ####         ##       #
   #           #####   ##         #
   #           #    ####          #
   #           #      #           #
   #           #      #           #
   #           #      #           #
   #           #      #           #
   #           #      #           #
   #           #      #           #
   #          ####    #           #
   #         ##   #####           #
   #       ##         ####        #
   #      #           #  ####     #
   #    ##            #      #### #
   #   ##             #          ##
   # ##               #          #
   ###                #        ##
   ##                 #       ##
    ####              #     ##
        ####          #    ##
            ###       #  ##
               ###    # ##
                  ######
                      #");
            Console.Clear();
            Console.Write(@"    #
          ##############
          #             ##########
         ##                     ##
         ##                     ##
        ###                    ###
        # #                    # #
        # #                    # #
       ## #                   ## #
       #  #                   #  #
      ##  #                   #  #
      ##############         #   #
      #   #         ##########   #
      #   #                  #   #
      #   #                  #   #
      #   #                  #   #
      #   #                  #   #
      #   #                  #   #
      #   #                  #   #
      #   #                  #   #
      #   #                  #   #
      #   ##########         #   #
      #   #         ##############
      #  #                   #  ##
      #  #                   #  #
      # ##                   # ##
      # #                    # #
      # #                    # #
      ###                    ###
      ##                     ##
      ##                     ##
      ##########             #
                ##############
                             #");

            // Give the OS A little more time to boot. (Resson for the Thread Sleeps.)
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("EchOS");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Booting.");
            Thread.Sleep(1000);
            Console.WriteLine("Booting..");
            Thread.Sleep(1000);
            Console.WriteLine("Booting...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("EchOS Has successfully booted!");
            Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("Welcome!");
            Console.WriteLine("#########################################");
            Console.WriteLine("               EchOS 2.0");
            Console.WriteLine("#########################################");
            Console.WriteLine("Type 'Help;' to get a list of commands.");
        }

        protected override void Run() // While loop by default.
        {
            Console.Write("[0]: ");
            string input_cmd = Console.ReadLine();

            switch (input_cmd)
            {
                    case "Help;":
                        Cmdman.help();
                        break;

                    case "System_Shutdown;":
                        Cmdman.Shutdown();
                        break;

                    case "System_Reboot;":
                        Cmdman.Reboot();
                        break;

                    case "Clear_Src;":
                        Cmdman.Clear_Src();
                        break;

                    case "BackgroundColor_Change;":
                        Cmdman.BackgroundColor_Change();
                        break;

                    case "Calculator;":
                        Cmdman.Calculator();
                        break;

                    case "About;":
                        Cmdman.About();
                        break;


                    default:
                        Console.WriteLine("'" + input_cmd + "' Is not a vaild command.");
                        Console.WriteLine("NOTE: Every command has a semicolumn at the end and a capital at the beginning.");
                        break;


                }
                if (String.IsNullOrEmpty(input_cmd))
                {
                    Console.WriteLine("Command cannot be empty.");
                }
            }
        }

   
}

