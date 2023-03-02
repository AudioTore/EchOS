package EchOS;

import java.io.IOException;
import java.util.Scanner;

import EchOS.Orlov.Lexer;

public class Kernel {
	
	// System objects.
	static Scanner scan = new Scanner(System.in); // Our kernel input.
	public static String file;
	public static String filedelete;
	public static String directorycreate;
	public static String directorydelete;
	public static String fileread;
	public static String Orlov;
	public static String cdinto;
	
	public static void main(String[] args) {
		try {
			System.out.print("\033[H\033[2J");  // "\033[H\033[2J" Clears the screen.
			System.out.flush();
			System.out.println("Kernel loaded.."); // By default our JVM should load our kernel into memory.
			Thread.sleep(1000);
			System.out.print("\033[H\033[2J");  // "\033[H\033[2J" Clears the screen.
			System.out.flush();
			
			for (int index = 0; index < 2; index += 1)
			{
				System.out.print("\033[H\033[2J");  // "\033[H\033[2J" Clears the screen.
				System.out.flush();  
				System.out.println("Booting.");
				Thread.sleep(1000);
				System.out.println("Booting..");
				Thread.sleep(1000);
				System.out.println("Booting...");
				Thread.sleep(1000);
			}
			
			System.out.println("EchOS has successfully booted!");
			Thread.sleep(2000);
			System.out.print("\033[H\033[2J");  // "\033[H\033[2J" Clears the screen
			System.out.flush();  
				
				System.out.println("===============================================================================");
				System.out.println("||###########################################################################||");
				System.out.println("||                                 EchOS 1.7                                 ||");
				System.out.println("||###########################################################################||");
				System.out.println("===============================================================================");
				System.out.println("Type \"Help();\" to get a list of commands.");
				System.out.println("Or type \"Open.Tour();\" to take a tour to learn how to use EchOS.");
				System.out.println(""); // Space.
				
				Run();
			
			
		}
		catch (Exception err) {
			// Do nothing...
		}
	}
	
	public static void Run() throws InterruptedException, IOException { // While loop by default.
		while (true) {
			System.out.print("[0:\\]: ");
			String input = scan.nextLine();
			
			if (input.equals("System.Shutdown();")) {
				Cmdman.Shutdown();
			}
			
			else if (input.equals("System.Reboot();")) {
				Cmdman.Reboot();
			}
			
			else if (input.equals("Open.TextPad();")) {
				try {
					TextPad.start();
				}
				catch (Exception err) {
					System.out.println("TextPad failed!");
				}
			}
			
			else if (input.equals("File.delete EchOS.jar();")) { // The jar is pretty much the OS's boot file.
				System.out.println("Can't delete that!! That's a reserved file ya touching..");
			}
			
			else if (input.equals("Directory.delete bin();")) { // The bin file contains a file for shutdown commands.
				System.out.println("Can't delete that!! That's a reserved file ya touching..");
			}
			
			else if (input.equals("Directory.create bin();")) {
				System.out.println("You can't replace bin!");
			}
			
			else if (input.equals("File.create EchOS.jar();")) {
				System.out.println("You can't replace that!");
			}
			
			else if (input.equals("Execute.Ticktacktoe();")) {
				while (true) {
					Ticktacktoe.start();
				}
			}
			
			else if (input.equals("CMD.Clear();")) {
				Cmdman.clear();
			}
			
			else if (input.equals("System.About();")) {
				Cmdman.About();
			}
			
			else if (input.equals("Help();")) {
				Cmdman.help();
			}
			
			else if (input.equals("Disk.ListDir();")) {
				System.out.println("Files and directorys: ");
				try {
					FileSystem.listdir();
				} catch (IOException e) {
					System.out.println("[Disk]: " + e);
				}
			}
			
			else if (input.equals("Open.Calculator();")) {
				Cmdman.Calculate();
			}
			
			else if (input.equals("Open.Tour();")) {
				Tour.starttour();
			}
			
			else if (input.startsWith("File.read")) {
				if (input.endsWith("();")) {
					String toremove = input.replace("File.read ", "");
					String toremove1 = toremove.replace("();", "");
					fileread = toremove1;
					System.out.println("Reading file...");
					
					try {
						FileSystem.fileread();
					}
					catch (Exception err) {
						System.out.println("[Disk]: Problem while reading file!");
					}
				}
				else {
					System.out.println("ERROR: Missing a \"();\" at the end...");
				}
			}
			
			
			else if (input.startsWith("Orlov")) {
				if (input.endsWith("();")) {
					String toremove = input.replace("Orlov ", "");
					String toremove1 = toremove.replace("();", "");
					Orlov = toremove1;
					try {
						System.out.println("Not implemented yet! Coming soon..");
					}
					catch (Exception err) {
						System.out.println(err);
					}
				}
				else {
					System.out.println("ERROR: Missing a \"();\" at the end...");
				}
			}
			
			else if (input.startsWith("File.create")) { // File.create test.txt();
				if (input.endsWith("();")) {
					String toremove = input.replace("File.create ", "");		
					String toremove1 = toremove.replace("();", "");
					file = toremove1;
					System.out.println("Creating file...");
					
					try {
						FileSystem.filecreate();
					}
					catch (Exception err) {
						System.out.println("[Disk]: " + "Problem while making file!");
					}
				}
				else {
					System.out.println("ERROR: Missing a \"();\" at the end...");
				}
			}
			
			else if (input.startsWith("File.delete")) {
				if (input.endsWith("();")) {
					String toremove = input.replace("File.delete ", "");
					String toremove1 = toremove.replace("();", "");
					filedelete = toremove1;
					System.out.println("Deleting file...");
					
					try {
						FileSystem.filedelete();
					}
					catch (Exception err) {
						System.out.println("[Disk]: " + "Problem while making file!");
					}
				}
				else {
					System.out.println("ERROR: Missing a \"();\" at the end...");
				}
			}
			
			else if (input.startsWith("Directory.create")) {
				if (input.endsWith("();")) {
					String toremove = input.replace("Directory.create ", "");
					String toremove1 = toremove.replace("();", "");
					System.out.println("Creating Directory...");
					directorycreate = toremove1;
					
					try {
						FileSystem.directorycreate();
					}
					catch (Exception err) {
						System.out.println("[Disk]: " + "Problem while making directory!");
					}
				} 
				else {
					System.out.println("ERROR: Missing a \"();\" at the end...");
				}
			}
			
			else if (input.startsWith("Directory.delete")) {
				if (input.endsWith("();")) {
					String toremove = input.replace("Directory.delete ", "");
					String toremove1 = toremove.replace("();", "");
					System.out.println("Deleting Directory...");
					directorydelete = toremove1;
					
					try {
						FileSystem.directorydelete();
					}
					catch (Exception err) {
						System.out.println("[Disk]: " + "Problem while deleting directory!");
					}
					
				}
				else {
					System.out.println("ERROR: Missing a \"();\" at the end...");
				}
			}
			
			else if (input.startsWith("echo")) {
				if (input.endsWith("();")) {
					String toremove = input.replace("echo ", "");
					String toremove1 = toremove.replace("();", "");
					System.out.println(toremove1);
				}
				else {
					System.out.println("ERROR: Missing a \"();\" at the end...");
				}
			}
				
			else if (input.equals("0010111101")) { // Secret code to return back to the debian shell.
				System.exit(0);
			}
			
			
			else {
				System.out.println("'" + input + "' Is not a vaild command.");
				System.out.println("NOTE: Every command has a capital at the beginning and a '();' at the end.");
			}
		}
	}
}
