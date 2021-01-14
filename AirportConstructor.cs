using System;
using System.IO;

class AirportConstructor
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
       
			 for (int i = 0; i < 5; i++)
			 {
				 var splitDetails = airports[i].Split(',');
				 //Put the 3 letter code into i,0
				 airportsDetails[i,0] = splitDetails[0];
				 Console.WriteLine(airportsDetails[i,0]);
			 }
    }
  }

}