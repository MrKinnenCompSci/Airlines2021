using System;
using System.IO;

class Airport
{
  private string _airportCode, _airportName;
  private int _distanceLPL, _distanceBOH;
	private string[] airports = new string[5];
	private string[,] airportsDetails = new string[5, 4];

  public void ReadDetailsFromFile()
  {
		
    using (var sr = new StreamReader("Airports.txt"))
    {
 		  for (int i = 0; i < 5 && !sr.EndOfStream; i++)
			 {
					airports[i] = sr.ReadLine();
					Console.WriteLine(airports[i]);
			 }
        
    }
  }

}