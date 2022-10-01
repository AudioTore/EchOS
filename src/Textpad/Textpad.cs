using Cosmos.System.FileSystem.VFS;
using System;
using System.IO;
using Sys = Cosmos.System;
public class Textpad
{

	Sys.FileSystem.CosmosVFS fs = new Sys.FileSystem.CosmosVFS();

	public static void textpad()
	{

		Sys.FileSystem.CosmosVFS fs = new Sys.FileSystem.CosmosVFS();

		bool bflag = true;


		do
		{

			Console.WriteLine("You are about to open up Textpad?");
			Console.WriteLine("[1] Create a file.");
			Console.WriteLine("[2] Show contents of text files.");
			Console.WriteLine("[3] Exit.");
			Console.Write(">>>: ");
			string input = Console.ReadLine();

			switch (input)
			{

				case "1":
					Console.Clear();
					textpad2();
					break;

				case "2":
					Console.Clear();
					textpad3();
					break;

				case "3":
					Cmdman.Clear_Src();
					bflag = false;
					break; // Return to the kernel.

				default:
					Console.WriteLine("Invaild command..");
					break;

			}

		} while (bflag);


		// Help break out of the program.
		do
		{

			break;

		} while (!bflag);

	}

	public static void textpad2()
	{

		Sys.FileSystem.CosmosVFS fs = new Sys.FileSystem.CosmosVFS();

		bool boflag = true;

		while (boflag)
		{

			Console.WriteLine("Type a filename. (It should be ending in a .txt)");
			Console.WriteLine("Text files with numbers in them aren't supported.");
			Console.WriteLine("Type 'exit' to exit out of textpad.");
			Console.Write(">>>: ");

			// [
			try
			{

				string input = Console.ReadLine();

				var createfile = File.Create(@"0:\" + input);

				// Pad supports only 2000 lines of text.
				for (int index = 0; index < 2000; index += 1)
				{

					Console.WriteLine("Type something into the text file.");
					Console.WriteLine(">>>: ");

					
					string type_text = Console.ReadLine();

					if (type_text == "exit")
					{

						boflag = false;
						break;

					}

					else
					{


						

						File.AppendAllText(@"0:\" + input, type_text.ToString() + Environment.NewLine);



					}

				}
					

			

			}

			catch (Exception e)
			{

				Console.WriteLine(e.Message);

			}
			// ]

		}

	}

	public static void textpad3()
	{

		do
		{

			Console.WriteLine("Type in the filename you want to view AND type it in with the file extension like '.txt'");
			Console.WriteLine("Type \"exit\" to exit out of Textpad.");
			Console.Write("Input the filename you want to view: ");

			// [
			try
			{

				string filename = Console.ReadLine();

				if (filename == "exit")
				{

					Cmdman.Clear_Src();
					break;

				}

				else
				{

					Console.Clear();
					Console.WriteLine(File.ReadAllText(@"0:\" + filename));

				}
				
			}

			catch (Exception e)
			{

				Console.Beep();
				Console.Clear();
				Console.WriteLine(e.ToString());

			}
			// ]


		} while (true);

	}

}
