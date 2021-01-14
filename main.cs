using System;

class MainClass {
  public static void Main (string[] args) {

    Airport BOH = new Airport();
    Airport LPL = new Airport();

		//Instantiate mainMenu as a class of Menu
		Menu mainMenu = new Menu();
		//Display menu and get the user's option
		mainMenu.DisplayMenu();

    //BOH.ReadDetailsFromFile();
		//LPL.ReadDetailsFromFile();
    Console.ReadLine();
  }

}