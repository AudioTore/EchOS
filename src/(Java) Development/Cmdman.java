//====================================================================================================
//The Free Edition of C# to Java Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-csharp-to-java.html
//====================================================================================================


import java.util.*;

//C# TO JAVA CONVERTER TODO TASK: C# to Java Converter could not confirm whether this is a namespace alias or a type alias:
//using Sys = Cosmos.System;
// All the functions to commands.


public class Cmdman
{

	public static int num1;
	public static int num2;

	

	public static void Help()
	{
		System.out.println("NOTE: Every command ends with a ';' ");

		System.out.println("================================================================================");
		System.out.println("Command List: ");
		System.out.println("System_Shutdown, System_Reboot, Clear_Src, BackgroundColor_Change");
		System.out.println("Calculator, About");
		System.out.println("================================================================================");
	}




	// Reboot and shutdown commands.
	public static void Shutdown()
	{
		// Cosmos.System.Power.Shutdown();
	}


	public static void Reboot()
	{
		// Cosmos.System.Power.Reboot();
	}

	/* Sadly These reboot and shutdown commands
	 * don't work for every virtual machine platform like Vbox 
	 * (Virtualbox) Which is why you should always use vmware */




	public static void Calculator()
	{
		double num1 = 0;
		double num2 = 0;
		double result = 0;

		while (true)
		{
			System.out.println("You are about to open Calculator. Continue?");
			System.out.print("[YES/NO]: ");
			String cal_open = new Scanner(System.in).nextLine();
			if (cal_open.equals("YES"))
			{
				System.out.println("***WARNING: Strings will not work. and will give you an error and shutdown***");
				System.out.print("Enter a number: ");
				num1 = Double.parseDouble(new Scanner(System.in).nextLine());

				System.out.print("Enter another number: ");
				num2 = Double.parseDouble(new Scanner(System.in).nextLine());

				System.out.println("Operands: + - / *");
				String operands = new Scanner(System.in).nextLine();
				if (operands.equals("+"))
				{
					result = num1 + num2;
					System.out.println("answer" + result);
					break;
				}
				else if (operands.equals("-"))
				{
					result = num1 - num2;
					System.out.println("answer" + result);
					break;
				}
				else if (operands.equals("/"))
				{
					result = num1 / num2;
					System.out.println("answer" + result);
					break;
				}
				else if (operands.equals("*"))
				{
					result = num1 * num2;
					System.out.println("answer" + result);
					break;
				}
				else
				{
					System.out.println("'" + cal_open + "' Not a vaild option. Choose '+', '-', '/', '*'");
				}
			}
			else if (cal_open.equals("NO"))
			{
				break; // Break and do nothing but return back to the 'run' function of the kernel.
			}
			else
			{
				System.out.println("'" + cal_open + "' Not a vaild option. Choose 'YES', 'NO'");
			}

		}

	}

	public static void About()
	{
		System.out.println("System OS: EchOS");
		System.out.println("Version: 3.0");
		System.out.println("Release date: [Unknown]");
		System.out.println("Language written in: C# and Java.");
	}



	public static void Clear_Src()
	{
		// Console.Clear();
		System.out.println("==========================================");
		System.out.println("|########################################|");
		System.out.println("|               EchOS 3.0                |");
		System.out.println("|########################################|");
		System.out.println("==========================================");
		System.out.println("Type 'Help();' to get a list of commands.");
	}






	public static void BackgroundColor_Change()
	{
			System.out.println("Are you sure you want to change your terminal Color?");
			System.out.println("[You can always change it to black.]");
			System.out.println("Yes: will change the color of terminal to blue.");
			System.out.println("NO: Will keep the current terminal color.");
			System.out.println("BLACK: Will change the terminal color back to black.");
			System.out.println(" "); // Spaces
			System.out.println(" "); // Spaces

			System.out.println("NOTE: Color resets to default once the System OS reboots, shutdowns.");
			
	}
	
}
