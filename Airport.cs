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
       
			 for (int i = 0; i < 5; i++)
			 {
				 var splitDetails = airports[i].Split(',');
				 
				 //Put the 3 letter code into i,0
				 airportsDetails[i,0] = splitDetails[0];
				 
				 //Put the name into i,1
				 airportsDetails[i,1] = splitDetails[1];
				 
				 //Put the distance from LPL into i,2
				 airportsDetails[i,2] = splitDetails[2];

				 //Put the distance from BOH into i,3
				 airportsDetails[i,3] = splitDetails[3];

				 Console.WriteLine(airportsDetails[i,0]);
				 Console.WriteLine(airportsDetails[i,1]);
				 Console.WriteLine(airportsDetails[i,2]);
				 Console.WriteLine(airportsDetails[i,3]);
			 }
    }
  }

}