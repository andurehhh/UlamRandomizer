using UlamCommon;
namespace UlamRandomizerDataLogic
{
    public class DataLogic
    {
        public static List<Ulam> ulamList = new List<Ulam>();

        public DataLogic()
        {
            CreateDummyUlam();
        }

        public static void CreateDummyUlam()
        {
            Ulam Ulam1 = new Ulam("Pork Sinigang","Sinigang");
            ulamList.Add(Ulam1);

            Ulam Ulam2 = new Ulam("Chicken Adobo", "Chicken");
            ulamList.Add(Ulam2);

            Ulam Ulam3 = new Ulam("Ginisang Sitaw", "Vegetables");
            ulamList.Add(Ulam3);

            Ulam Ulam4 = new Ulam("Cordon Bleu", "Chicken");
            ulamList.Add(Ulam4);

            Ulam Ulam5 = new Ulam("Ratatouille", "Vegetables");
            ulamList.Add(Ulam5);

            ulamList.Add(new Ulam("Steak", "Beef"));
            ulamList.Add(new Ulam("Scrambled Eggs", "Egg"));
            ulamList.Add(new Ulam("Chopsuey", "Vegetables"));
            ulamList.Add(new Ulam("Gambas", "Shrimp"));
            ulamList.Add(new Ulam("Beef Stroganoff", "Beef"));

        }

        //Creation and adding into the list of ulam
        public static Ulam CreateUlamObj(string name, string MainIngredient)
        {
            Ulam CreatedUlam = new Ulam(name, MainIngredient);
            return CreatedUlam;
        }
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

        //Validation and simple attribute retrieval
        public static bool IsInList(string UlamInput)
        {
            foreach (Ulam ulam in ulamList)
            {
                if (GetUlamName(ulam).ToLower() == UlamInput.ToLower())
                {
                    return true;
                }
            }
            return false;
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
        public static List<Ulam> GetUlamList()
        {
            return ulamList;
        }
    }
}
