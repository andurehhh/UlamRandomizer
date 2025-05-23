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
        string JsonFilePath = "ulam.json";

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
            ulamList[index].MainIngredient = ulamEdit.MainIngredient;
            if (ulamEdit.ulamDescription != "")
            {
                ulamList[index].ulamDescription = ulamEdit.ulamDescription;
            }
        }
    }
}
