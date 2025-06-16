using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlamCommon;

namespace UlamRandomizerDataLogic
{
    public class FileDataLogic : IURDataLogic
    {
        List<Ulam> ulamList = new List<Ulam>();
        string filepath = "ulams.txt";
        public FileDataLogic()
        {
            ImportFromFile();
        }

        private void ImportFromFile()
        {
            var ulamLine = File.ReadAllLines(filepath);
            foreach (var line in ulamLine)
            {
                var parts = line.Split('|');

                ulamList.Add(new Ulam
                    (parts[0], parts[1], parts[2], parts[3])
                    );
            }
        }

        private void ExportToFile()
        {
            var UlamLines = new string[ulamList.Count];

            for (int i = 0; i < ulamList.Count; i++)
            {
                UlamLines[i] = $"{ulamList[i].UlamName}|{ulamList[i].MainIngredient1}|{ulamList[i].MainIngredient2}";
            }

            File.WriteAllLines(filepath, UlamLines);
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
        public void CreateUlam(Ulam ulam)
        {
            var newLine = $"{ulam.UlamName}|{ulam.MainIngredient1}|{ulam.MainIngredient2}|{ulam.ulamDescription}";
            File.AppendAllText(filepath, newLine);

        }

        public List<Ulam> GetUlams()
        {
            return ulamList;
        }

        public void RemoveUlam(Ulam ulam)
        {
            int index = FindUlamIndex(ulam);
            ulamList.RemoveAt(index);
            ExportToFile();
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
    }
}
