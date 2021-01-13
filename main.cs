using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    Airport BOH = new Airport();
    Airport LPL = new Airport();

    BOH.ReadDetailsFromFile();
		//LPL.ReadDetailsFromFile();
    Console.ReadLine();
  }

}