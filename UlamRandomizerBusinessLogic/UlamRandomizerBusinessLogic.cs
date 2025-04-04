namespace UlamRandomizerBusinessLogic
{
    public class BusinessDataLogic 
    {
        public static List<Ulam> ulamList = new List<Ulam>();
        public static bool AddUlam(Ulam ulamInput)
        {
            if (!IsInList(ulamInput.UlamName))
            {
                ulamList.Add(ulamInput);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool RemoveUlam(Ulam ulamInput)
        {
            if (IsInList(ulamInput.UlamName))
            {
                ulamList.Remove(ulamInput);
                return true;
            }
            else
            {
                return false;
            }
        }

        

        public static Ulam CreateUlamObj(string name, string MainIngredient)
        {
            Ulam CreatedUlam = new Ulam(name,MainIngredient);
            return CreatedUlam;
        }

        public static bool IsInList(string UlamInput)
        {
            foreach (Ulam ulam in ulamList)
            {
                if(GetUlamName(ulam).ToLower() == UlamInput.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public static Ulam SearchUlamList(string UlamToFind)
        {
            foreach (Ulam ulam in ulamList)
            {
                if (GetUlamName(ulam) == UlamToFind)
                {
                    return ulam;
                    //return ulamList.IndexOf(ulam);
                }
            }
            return null;
            //return -1;
        }

        public static string GetUlamName(Ulam UlamNameToPrint)
        {
            string UlamName = UlamNameToPrint.UlamName;
            return UlamName;
        }

        public static string GetUlamMainIng(Ulam UlamIngredientToPrint)
        {
            string UlamIngredient = UlamIngredientToPrint.MainIngredient;
            return UlamIngredient;
        }

        public static int RandomizeUlam(/*List<Ulam> ulamList*/)
        {
            Random rndUlam = new Random();
            int rndUlamIndex = rndUlam.Next(ulamList.Count);
            return rndUlamIndex;
        }

        



    }
    
}// Add the 
//- addition of yes or no
//- categories
//- Main Ingredient
