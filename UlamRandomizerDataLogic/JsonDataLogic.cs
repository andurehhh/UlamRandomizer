using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using UlamCommon;

namespace UlamRandomizerDataLogic
{
    public class JsonDataLogic : IURDataLogic
    {
        List<Ulam> ulamList = new List<Ulam>();
        string JsonFilePath = "ulams.json";

        public JsonDataLogic()
        {
            ImportFromJson();
        }

        private void ImportFromJson()
        {
            string jsonText = File.ReadAllText(JsonFilePath);
            ulamList = JsonSerializer.Deserialize<List<Ulam>>(jsonText, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        private void ExportToJson()
        {
            string jsontext = JsonSerializer.Serialize<List<Ulam>>(ulamList, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            File.WriteAllText(JsonFilePath, jsontext);
        }
        public void CreateUlam(Ulam ulam)
        {
            ulamList.Add(ulam);
            ExportToJson();
        }
        public int FindUlamIndex(Ulam UlamToFind)
        {
            for (int i = 0; i < ulamList.Count; i++)
            {
                if (ulamList[i].UlamName == UlamToFind.UlamName)
                {
                    return i;
                }
            }
            return -1;
        }
        public List<Ulam> GetUlams()
        {
            autoNumber(ulamList);
            return ulamList;
        }

        public void RemoveUlam(Ulam ulam)
        {
            int index = FindUlamIndex(ulam);
            ulamList.RemoveAt(index);
            ExportToJson();
        }

        public void UpdateUlam(Ulam ulamEdit)
        {
            int index = FindUlamIndex(ulamEdit);
            ulamList[index].MainIngredient1 = ulamEdit.MainIngredient1;
            ulamList[index].MainIngredient2 = ulamEdit.MainIngredient2;

            if (ulamEdit.ulamDescription != "")
            {
                ulamList[index].ulamDescription = ulamEdit.ulamDescription;
            }
        }

        public Ulam GetUlamByID(int UlamID)
        {
            int index = -1;
            for (int i = 0; i < ulamList.Count; i++)
            {
                if (ulamList[i].Id == UlamID)
                {
                    return ulamList[i];
                }

            }
            return null;

        }
        private void autoNumber(List<Ulam> list)
        {
            int index = 0;
            foreach (Ulam ulam in list)
            {
               if (ulam.Type.Equals("Custom"))
                {
                    ulam.Id = index;
                    index++;
                }
            }
        }
    }
}
