using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace projektDT071G
{
    //Projekt DT071G av Alice Fagerberg
    public class SavedGames
    {
        //filen savedgames
        private string filename = @"savedgames.json"; 

        private List<LangGame> langgames = new List<LangGame>();//lista

        public SavedGames()
        {
            if (File.Exists(@"savedgames.json") == true)
            { // Kontrollera om filen existrerar - då läsa in
                string jsonString = File.ReadAllText(filename);
                langgames = JsonSerializer.Deserialize<List<LangGame>>(jsonString);
            }
        }

        //metod- lägga till ett spel
        public LangGame addGame(LangGame langgame)
        {
            langgames.Add(langgame);
            marshaling();
            return langgame;
        }

        //metod - radera ett spel
        public int deleteGame(int index)
        {
            langgames.RemoveAt(index);
            marshaling();
            return index;
        }

        //metod - rensar alla spel
        public List<LangGame> deleteAllGames()
        {
            langgames.Clear();
            marshaling();
            return langgames;
        }

        //metod -Hämta alla utförda spel
        public List<LangGame> getGames()
        {
            return langgames;
        }

        // Skapar väg till fil
        private void marshaling()
        {
            // Serialisera alla objekt och spara till filen
            var jsonString = JsonSerializer.Serialize(langgames);
            File.WriteAllText(filename, jsonString);


        }
    }
}
