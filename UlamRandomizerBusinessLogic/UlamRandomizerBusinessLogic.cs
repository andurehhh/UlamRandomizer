using UlamRandomizerDataLogic;
using UlamCommon;
namespace UlamRandomizerBusinessLogic
{
    public class BusinessLogic
    {
        
        public static Ulam SearchUlamList(string UlamToFind)
        {
            foreach (Ulam ulam in DataLogic.GetUlamList())
            {
                if (GetUlamName(ulam) == UlamToFind)
                {
                    return ulam;
                }
            }
            return null;
        }
        public static int RandomizeUlam()
        {
            Random rndUlam = new Random();
            int rndUlamIndex = rndUlam.Next(DataLogic.ulamList.Count);
            return rndUlamIndex;
        }

        //helper methods
        public static Ulam CreateUlamObj(string name, string MainIngredient)
        {
            return DataLogic.CreateUlamObj(name, MainIngredient);
        }
        public static bool RemoveUlam(Ulam ulamInput)
        {
            return DataLogic.RemoveUlam(ulamInput);
        }
        public static bool AddUlam(Ulam ulamInput)
        {
            return DataLogic.AddUlam(ulamInput);
        }
        public static List<Ulam> GetUlamList()
        {
            return DataLogic.GetUlamList();
        }  
        public static string GetUlamName(Ulam UlamNameToPrint)
        {
            return DataLogic.GetUlamName(UlamNameToPrint);
        }
        public static string GetUlamMainIng(Ulam UlamMainIngToPrint)
        {
            return DataLogic.GetUlamMainIng(UlamMainIngToPrint);
        }
        public static void CreateDummyUlam()
        {
            DataLogic.CreateDummyUlam();
        }
    }

}
