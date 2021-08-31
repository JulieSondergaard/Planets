using System;
using System.Collections.Generic;
using System.Linq;

namespace Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating all the planets and putting in all the data of each planet
            Planet mercury = new Planet("Merkur", 0.330, 4879, 5427, 3.7, 1417.6, 4222.6, 57.9, 88.0, 47.4, 167, 0, false);
            Planet venus = new Planet("Venus", 4.87, 12104, 5243, 8.9, -5832.5, 2802.2, 108.2, 224.7, 35.0, 464, 0, false);
            Planet earth = new Planet("Jorden", 5.97, 12756, 5514, 9.8, 23.9, 24.0, 149.6, 356.2, 29.8, 15, 1, false);
            Planet mars = new Planet("Mars", 0.642, 6792, 3933, 3.7, 24.6, 24.7, 227.9, 687.0, 24.1, -65, 2, false);
            Planet jupiter = new Planet("Jupiter", 1898, 142984, 1326, 23.1, 9.9, 9.9, 778.6, 4331, 13.1, -110, 67, true);
            Planet saturn = new Planet("Saturn", 568, 120536, 687, 9.0, 10.7, 10.7, 1433.5, 10747, 9.7, -140, 62, true);
            Planet uranus = new Planet("Uranus", 86.6, 51118, 1271, 8.7, -17.2, 17.2, 2872.5, 30589, 6.8, -195, 27, true);
            Planet neptune = new Planet("Neptun", 102, 49523, 1638, 11.0, 16.1, 16.1, 4495.1, 59800, 5.4, -200, 14, true);
            Planet pluto = new Planet("Pluto", 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 905600, 4.7, -225, 5, false);

            // Making a new list called planets
            List<Planet> planets = new List<Planet>();

            //Adding all the planets to list
            planets.Add(mercury);
            planets.Add(earth);
            planets.Add(mars);
            planets.Add(jupiter);
            planets.Add(saturn);
            planets.Add(uranus);
            planets.Add(neptune);
            planets.Add(pluto);

            //Showing the list in the console
            Console.WriteLine("Liste over alle planeter på listen:");
            foreach (var planet in planets){
                Console.WriteLine(planet.Name);
            }

            //Inserts venus on the second place in the list, therefor it is inserted in index 1 and the rest of the planet coming after is pushed to one index higher than it had before
            planets.Insert(1, venus);

            Console.WriteLine();

            //Shows the new list including venus in the console
            Console.WriteLine("Liste over alle planeter på listen, nu inklusiv Venus:");
            foreach(var planet in planets)
            {
                Console.WriteLine(planet.Name);
            }

            Console.WriteLine();

            //Removes pluto from the list and shows the new list without pluto in it
            planets.Remove(pluto);
            Console.WriteLine("Liste over alle planeter på listen, efter Pluto er blevet fjernet fordi det ikke er en rigtig planet, men kun en dværgplanet:");
            foreach (var planet in planets)
            {
                Console.WriteLine(planet.Name); 
            }

            Console.WriteLine();

            //Inserts pluto again, on index 8, which also is the last index of the list. Could also just have just planets.Add(pluto); since pluto is the last of the planets in the list
            planets.Insert(8, pluto);

            //Shows the new list with pluto back in it
            Console.WriteLine("Ej ok, vi vil gerne have Pluto på vores liste alligevel, dværgplanet eller ej:");
            foreach (var planet in planets)
            {
                Console.WriteLine(planet.Name);
            }

            Console.WriteLine();

            //Counts how many planets there are in the list and writes it out in the console
            Console.WriteLine("Antal af planeter på vores liste:");
            Console.WriteLine(planets.Count());

            Console.WriteLine();

            //Makes a new list called planetsLowMeanTemperature
            List<Planet> planetsLowMeanTemperature = new List<Planet>();

            //Adds all the planets with a mean temperature below 0 to the new list
            foreach (var planet in planets)
            {
                if (planet.MeanTemperature < 0)
                {
                    planetsLowMeanTemperature.Add(planet);
                }
            }

            //And writes out the new list of planets to the console
            Console.WriteLine("Liste over planeter med en middeltemperatur på under 0:");
            foreach (var planet in planetsLowMeanTemperature)
            {
                Console.WriteLine(planet.Name);
            }

            Console.WriteLine();

            //Makes a new list called planetsDiameter
            List<Planet> planetsDiameter = new List<Planet>();

            //Adds all the planets with a diameter bigger than 10,000 and smaller than 50,000 to the new list
            foreach (var planet in planets)
            {
                if (planet.Diameter > 10000 && planet.Diameter < 50000)
                {
                    planetsDiameter.Add(planet);
                }
            }

            //Shows the new list in the console
            Console.WriteLine("Liste over planeter med en diameter på mere end 10.000 km men mindre end 50.000 km");
            foreach (var planet in planetsDiameter)
            {
                Console.WriteLine(planet.Name);
            }


            //Clears all the planet from the first list
            planets.Clear();
            
        }
        
    }
}
