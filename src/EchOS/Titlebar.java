package EchOS;

public class Titlebar {
	
	public static final String ANSI_BLUE = "\u001B[34m"; // Blue color.
	public static final String ANSI_WHITE = "\u001B[37m";
	public static final String ANSI_BLUE_BACKGROUND = "\u001B[44m";
	public static final String ANSI_RESET = "\u001B[0m";
	
	public static void DrawBar() {
		
		char escCode = 0x1B;
		int row = 0;
		int column = 0;
		
		
		// Top right of the screen.
		System.out.print(String.format("%c[%d;%df",escCode,row,column));
		
		System.out.println(ANSI_BLUE_BACKGROUND + "                        Welcome! [EchOS 1.6] Kernel: 1.6                          " + ANSI_RESET);
		
		
		
	}
}