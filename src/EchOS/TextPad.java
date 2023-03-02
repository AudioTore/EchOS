package EchOS;

import java.io.*;
import java.util.Scanner;

public class TextPad {
	
	static Scanner scan = new Scanner(System.in);
	static String file_towrite;
	
	public static void start() throws IOException{
		while (true) {
			System.out.println("TextPad 1.6");
			System.out.println("[1]. Create and edit file.");
			System.out.println("[2]. View file.");
			System.out.println("[3]. Exit");
			System.out.print(""); // Spaces..
			System.out.print(">>>: ");
			String textpad = scan.nextLine();
			
			if (textpad.equals("1")) {
				System.out.print("Type in a filename: ");
				String filecreate = scan.nextLine();
				if (filecreate.contains("();")) {
					System.out.println("Nice try! You can't create files with \"();\"");
				}
				else {
					File file = new File(filecreate);
					file_towrite = filecreate;
					write();
				}
			}
			
			else if (textpad.equals("2")) {
				String currentPath = System.getProperty("user.dir"); // Grabs the current directory.
				
				File folder = new File(currentPath);
				File[] listOfFiles = folder.listFiles();
			
				// List files.
				for (int i = 0; i < listOfFiles.length; i++) {
					if (listOfFiles[i].isFile()) {
						System.out.println("[File]: " + listOfFiles[i].getName());
					}
				}
				
				
				// List directorys.
				String[] directories = folder.list(new FilenameFilter() {
					public boolean accept(File dir, String name) {
						return new File(dir, name).isDirectory();
					}
				});
				
				for (int i = 0; i < directories.length; i++) {
					System.out.println("[Directory]: " + directories[i]);
				}
				
				System.out.print("Type a file you want to read: ");
				String input = scan.nextLine();
				
				File file = new File(input);
				BufferedReader in = new BufferedReader(new FileReader(file));
				
				if (file.exists()) {
					String line;
					try {
						while ((line = in.readLine()) != null) {
							System.out.println(line);
						}
					} catch (IOException e) {
						System.out.println("[Disk]: ERROR");
					}
				}
				
				else {
					System.out.println("[Disk]: File doesn't exist..");
				}
			}
			
			else if (textpad.equals("3")) {
				Cmdman.clear();
				break;
			}
			else {
				System.out.println("Invaild command..");
			}
		}
	}
	
	public static void write() throws IOException {
		System.out.print("\033[H\033[2J");  // "\033[H\033[2J" Clears the screen.
		System.out.flush();  
		
		int index;
		index = 1;
		while (true) {
			System.out.println("Write something! Type \"EXIT_NOW900100\" Once done.");
			System.out.print(index + ": ");
			String write_newline = scan.nextLine();
			index++;
			
			if (write_newline.equals("EXIT_NOW900100")) {
				System.out.println("Returning back..");
				break;
			}
			
			try {
				FileOutputStream fop=new FileOutputStream(file_towrite, true);
				if(write_newline!=null) {
					// for (final String s : write_newline.split(" ")) {
						fop.write(write_newline.getBytes());
						fop.write(System.getProperty("line.separator").getBytes());
					
				}
				
				fop.flush();
				fop.close();
				
			} catch (FileNotFoundException e) {
				System.out.println("Something went very wrong!");
				System.out.println("Returning back to the kernel..");
				try {
					Thread.sleep(1000);
					Kernel.main(null);
					break;
				}
				catch (Exception err) {
					
				}
			}				
		}
	}
}