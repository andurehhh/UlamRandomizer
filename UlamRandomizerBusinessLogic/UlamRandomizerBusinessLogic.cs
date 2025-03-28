namespace UlamRandomizerBusinessLogic
{
    public class BusinessDataLogic
    {
        public static List<string> ulamList = new List<string>();
        //public string ulamInput;
        public static bool AddUlam(string UlamtoAdd)
        {
            if (!ulamList.Contains(UlamtoAdd))
            {
                ulamList.Add(UlamtoAdd);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool RemoveUlam(string ulamInput)
        {
            if (ulamList.Contains(ulamInput))
            {
                ulamList.Remove(ulamInput);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int RandomizeUlam(List<string> ulamList)
        {
            Random rndUlam = new Random();
            int rndUlamIndex = rndUlam.Next(ulamList.Count);
            return rndUlamIndex;
        }

    }
}
