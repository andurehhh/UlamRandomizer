using UlamRandomizerDataLogic;
using UlamCommon;
using Microsoft.IdentityModel.Tokens;
using HtmlAgilityPack;
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

        public static void EditUlam(Ulam newUlam)
        {
            DL.UpdateUlam(newUlam);
        }
        public static Ulam CreateUlamObj(string name, string MainIngredient1, string MainIngredient2, string Description)
        {
            Ulam Newulam = new Ulam(name, MainIngredient1, MainIngredient2, Description);
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
        public static List<Ulam> GetUlams()
        {
            return DL.GetUlams();
        }
        public static int RandomizeUlam()
        {
            Random rndUlam = new Random();
            int rndUlamIndex = rndUlam.Next(DL.GetUlams().Count);
            return rndUlamIndex;
        }

        public static Ulam GetRandomUlam()
        {
            int random = RandomizeUlam();
            Ulam randomUlam = GetUlams()[random];
            return randomUlam;
        }

        public static string StripHtmlTags(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            var doc = new HtmlDocument();
            doc.LoadHtml(input);
            return doc.DocumentNode.InnerText;
        }
        //public static void CreateDummyUlam()
        //{
        //    DataLogic.CreateDummyUlam();
        //}
        public Ulam GetUlambyID(int ulamID)
        {
            DBDataLogic DLS = new DBDataLogic();
            return DLS.GetSpecificUlam(ulamID);
        }
    }

}
