package EchOS;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.FilenameFilter;
import java.io.BufferedReader;
import java.io.FileReader;

public class FileSystem {
	public static void filecreate() throws IOException {
		File file = new File(Kernel.file);
		
		if (file.createNewFile()) {
			System.out.println("File created.. (Check your current directory.)");
		}
		
	}
	
	public static void filedelete() {
		File file = new File(Kernel.filedelete);
		
		if (file.exists()) {
			if (file.isFile()) { // Make sure its a directory.
				file.delete();
			}
			else {
				System.out.println("[Disk]: This is not a file..");
			}
		}
		else {
			System.out.println("[Disk]: file doesn't exist..");
		}
	}
	
	public static void listdir() throws IOException {
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
		
		
		
	}
	
	public static void directorycreate() {
		File file = new File(Kernel.directorycreate);
		

		if (file.mkdir()) {
				System.out.println("Directory created..");
		}
		
		
	}
	
	public static void directorydelete() {
		File file = new File(Kernel.directorydelete);
		
		if (file.isDirectory()) {
			file.delete();
			System.out.println("Directory successfully deleted!");
		}
		else {
			System.out.println("[Disk]: That is not a directory.. or doesn't exist..");
		}
	}
	
	public static void fileread() throws FileNotFoundException {
		File file = new File(Kernel.fileread);
		BufferedReader in = new BufferedReader(new FileReader(Kernel.fileread));
		
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
	
}