using System.Collections;
using System.Net.Http.Headers;

namespace Dictionaries_Mills_Justyce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> topGames = new Dictionary<int, string>();//dictionary that takes an int as the key and a string as the value, called topGames
            topGames.Add(1, "Warframe");
            topGames.Add(2, "Elsword");
            topGames.Add(3, "BorderLands 2");
            topGames.Add(4, "Undertale");
            topGames.Add(5, "Titanfall 2");
            topGames.Add(6, "Battlefield 1");
            topGames.Add(7, "Call of Duty: Black Ops 2");
            topGames.Add(8, "Need for Speed: Most Wanted");
            topGames.Add(9, "Colin McRae: Dirt");
            topGames.Add(10, "Skate 3");

            foreach (KeyValuePair<int, string> kvp in topGames)//Loops through the topGames dictionary and print out each Key/Value pair on a new line
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            if (topGames.ContainsKey(1))//check if topGames contains key 1, if it does, print to console "My favorite game is: <topGames[1]>"
            {
                Console.WriteLine($"My favorite game is: {topGames[1]}, and {topGames[2]}");
            }

            string result = "";//an empty string called result

            topGames.TryGetValue(11, out result);//Implements TryGetValue method on topGames for key 11, sets output to result string

            if (result != "")//If it outputs something to result then print the result to console
            {
                Console.WriteLine(result);
            }
            else// else print, "There is no game in the eleventh position."
            {
                Console.WriteLine("There is no game in the eleventh position.");
            }

            if (topGames.ContainsKey(5))//check if topGames contains the key 4
            {
                topGames[4] = "Deltarune";//Switch the dictionary entry object at key 4 with a new game
            }

            Console.WriteLine(topGames[4]);//print new value at key 4

            Hashtable hashtable = new Hashtable(topGames);//new Hashtable and set it equal to topGames

            string favGame = (string)hashtable[1];//new string called favGame, Set favGame to the value of key 1 in the hashtable

            Console.WriteLine($"Favorate Game: {favGame}");//Print favGame to console

            Hashtable capitals = new Hashtable() //new hashtable using collection-initializer syntax, called capitals
            {
                { "Oklahoma", "Oklahoma City" },
                { "New York", "Abany" },
                { "Kansas", "City of Topeka" }
            };

            foreach (DictionaryEntry kvp in capitals)//Loop through the capitals hashtable and print out the DictionaryEntry objects key and value on a new line
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            capitals.Clear();//Clear all elements in the capitals hashtable
        }
    }
}