using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using System.Threading;

// All the functions to commands.
namespace EchOS_Dev
{
	public class Cmdman
	{
		public static void help()
		{
			Console.WriteLine("NOTE: Every command ends with a ';' ");
			Console.WriteLine("================================================================================");
			Console.WriteLine("Command List: ");
			Console.WriteLine("System_Shutdown, System_Reboot, Clear_Src");
			Console.WriteLine("Calculator, About");
			Console.WriteLine("================================================================================");
		}

		public static void Shutdown()
		{
			Cosmos.System.Power.Shutdown();
		}

		public static void Reboot()
		{
			Cosmos.System.Power.Reboot();
		}

		public static void Calculator()
		{
			while (true)
            {
				
			}			
		}
		public static void About()
		{
			Console.WriteLine("EchOS 1.0");
		}

		public static void Clear_Src()
		{
			Console.Clear();
			Console.WriteLine("#########################################");
			Console.WriteLine("               EchOS 1.0");
			Console.WriteLine("#########################################");
			Console.WriteLine("Type 'help' to get a list of commands.");
		}
	}

}

