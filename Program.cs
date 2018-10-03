using System;
using System.Collections.Generic;

namespace spaceships {
    class Program {
        static void Main (string[] args) {
            List<string> planetList = new List<string> () { "Mercury", "Mars" };
            // Add() function
            planetList.Add ("Jupiter");
            planetList.Add ("Saturn");

            Console.WriteLine ("OPM till it's over");
            Console.WriteLine ("WSGT$");

            List<string> lastTwo = new List<string> () { "Neptune", "Pluto" };
            // AddRange() function
            planetList.AddRange (lastTwo);
            // Insert() function
            planetList.Insert (1, "Venus");
            planetList.Insert (2, "Earth");
            
            // New List
            List<string> rockyPlanets = planetList.GetRange (0, 7);
            // Remove() function
            rockyPlanets.Remove ("pluto");

            // rockyPlanets.ForEach (planet => Console.WriteLine (planet));



            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>> ();
            Dictionary<string, string> Mercury = new Dictionary<string, string>();
            probes.Add(Mercury);
            probes[0]["Mercury"] = "MESSENGER";
            probes[1]["Venus"] = "Galileo";
            probes[2]["Mars"] = "Viking";
            probes[3]["Jupiter"] = "Pioneer 10";
            probes[4]["Saturn"] = "Cassini";
            probes[5]["Uranus"] = "Voyager 2";
            probes[6]["Neptune"] = "Voyager 2";
            probes[7]["Pluto"] = "New Horizons";

            probes.AddRange(probes);

            foreach(var planet in planetList)
            {
                 List<string> matchingProbes = new List<string>();

                 foreach(var p in probes){
                     foreach(var mp in p){

                     matchingProbes.Add(mp.Value);
                     Console.WriteLine(matchingProbes);
                     }
                 }
                 

            }

            

        }
    }
}