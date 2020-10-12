using System.Collections.Generic;

namespace CollapsedMultiRowHeaders
{
    public static class Consts
    {
        public static readonly Dictionary<string, string[]> companiesAndProducts = new Dictionary<string, string[]>()
        {
            {"Audi", new string[] {"A1", "A3", "A4", "A5", "A6", "A7", "A8", "Q3", "Q5", "Q7", "TT", "R8", "RS"}},
            {"Ford", new string[] {"Fiesta", "Focus", "Mondeo", "Ecosport", "Kuga", "Explorer"}},
            {"Mazda", new string[] {"Mazda3", "Mazda6", "Mazda CX-5"}},
            {"Opel", new string[] {"Antara", "Astra", "Insignia", "Meriva", "Mokka", "Zafira"}},
            {"Renault", new string[] {"Clio", "Duster", "Fluence", "Kangoo", "Koleos", "Logan", "Master", "Megane", "Sandero"}},
            {"Volkswagen", new string[] {"Beetle", "Golf", "Jetta", "Passat", "Phaeton", "Polo", "Tiguan", "Touareg"}}
        };

        public static readonly string[] countries = new string[]
        {
            "Argentina", 
            "Austria", 
            "Belgium", 
            "Brazil", 
            "Canada", 
            "Denmark",
            "Finland", 
            "France", 
            "Germany", 
            "Ireland", 
            "Italy", 
            "Mexico", 
            "Norway", 
            "Poland", 
            "Portugal", 
            "Spain", 
            "Sweden", 
            "Switzerland", 
            "UK", 
            "USA", 
            "Venezuela"
        };
    }
}
