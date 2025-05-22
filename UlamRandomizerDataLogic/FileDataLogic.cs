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
            GetUlams();
        }

        private void ImportFromFile()
        {
            var ulamLine = File.ReadAllLines(filepath);
            foreach (var line in ulamLine)
            {
                var parts = line.Split('|');

                ulamList.Add(new Ulam
                    (parts[0], parts[1], parts[2])
                    );
            }
        }

        private void ExportToFile()
        {
            var UlamLines = new string[ulamList.Count];

            for (int i = 0; i < ulamList.Count; i++)
            {
                UlamLines[i] = $"{ulamList[i].UlamName}|{ulamList[i].MainIngredient}";
            }

            File.WriteAllLines(filepath, UlamLines);
        }
        
        public int FindUlamIndex(Ulam UlamToFind)
        {
            for (int i = 0; i < ulamList.Count; i++)
            {
                if(ulamList[i].UlamName == UlamToFind.UlamName)
                {
                    return i;
                }
            }
            return -1;
        }
        public void CreateUlam(Ulam ulam)
        {
            var newLine = $"{ulam.UlamName}|{ulam.MainIngredient}|{ulam.ulamDesciption}";
            File.AppendAllText(filepath, newLine);

            }

        public List<Ulam> GetUlams()
        {
            return ulamList;
        }

        public void RemoveUlam(Ulam ulam)
        {
            int index = -1;
            for (int i = 0; i < ulamList.Count; i++)
            {
                if (ulamList[i].UlamName.Equals(ulam.UlamName, StringComparison.OrdinalIgnoreCase))
                {
                    index = i;   
                }
            }
            ulamList.RemoveAt(index);
        }

        public void UpdateUlam(Ulam ulamEdit)
        {
            int index = -1;
            for (int i = 0; i < ulamList.Count; i++)
            {
                if (ulamList[i].UlamName.Equals(ulamEdit.UlamName, StringComparison.OrdinalIgnoreCase))
                {
                    Ulam ulamToChange = ulamList[i];
                    ulamToChange.MainIngredient = ulamEdit.MainIngredient;
                    ulamToChange.ulamDesciption = ulamEdit.ulamDesciption;

                }
            }
            ;
        }
    }
}
