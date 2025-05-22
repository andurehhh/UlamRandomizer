using UlamRandomizerDataLogic;
using UlamCommon;
namespace UlamRandomizerBusinessLogic
{
    public class BusinessLogic
    {
        static URDataLogic DL = new URDataLogic();
        
        public static Ulam SearchUlamList(string UlamToFind)
        {
            foreach (Ulam ulam in DL.GetUlams())
            {
                if (ulam.UlamName.Equals(UlamToFind, StringComparison.OrdinalIgnoreCase))
                {
                    return ulam;
                }
            }
            return null;
        }

        public static bool IsInList(Ulam UlamToFind)
        {
            if (DL.GetUlams().Contains(UlamToFind))
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }
        public static int RandomizeUlam()
        {
            Random rndUlam = new Random();
            int rndUlamIndex = rndUlam.Next(DL.GetUlams().Count);
            return rndUlamIndex;
        }

        //helper methods
        public static Ulam CreateUlamObj(string name, string MainIngredient, string Description)
        {
            Ulam Newulam = new Ulam(name, MainIngredient, Description);
            if (!IsInList(Newulam))
            {
                DL.CreateUlam(Newulam);
                return Newulam;

            }
            else
            {
                return null;
            }
            
        }
        public static void RemoveUlam(Ulam ulamInput)
        {
            if (IsInList(ulamInput))
            {
                DL.RemoveUlam(ulamInput);
            }
        }
        //public static bool AddUlam(Ulam ulamInput)
        //{
        //    return DataLogic.AddUlam(ulamInput);
        //}
        public static List<Ulam> GetUlams()
        {
            return DL.GetUlams();
        }  
        public static string GetUlamName(Ulam UlamNameToPrint)
        {
            return UlamNameToPrint.UlamName;
        }
        public static string GetUlamMainIng(Ulam UlamMainIngToPrint)
        {
            return UlamMainIngToPrint.MainIngredient;
        }
        //public static void CreateDummyUlam()
        //{
        //    DataLogic.CreateDummyUlam();
        //}
    }

}
