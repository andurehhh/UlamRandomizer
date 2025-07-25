﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlamCommon;

namespace UlamRandomizerDataLogic
{
    public class InMemoryDataLogic : IURDataLogic
    {
        static List<Ulam> ulamList = new List<Ulam>();
        public InMemoryDataLogic()
        {
            CreateDummyUlam();
        }
        private static void CreateDummyUlam()
        {
            Ulam Ulam1 = new Ulam("Pork Sinigang", "Pork","Vegetables", "A classic Filipino sour and savory soup, featuring tender cuts of pork simmered with various vegetables in a tamarind-based broth.");
            ulamList.Add(Ulam1);

            Ulam Ulam2 = new Ulam("Chicken Adobo", "Chicken","", "The unofficial national dish of the Philippines, consisting of chicken braised in a flavorful mixture of soy sauce, vinegar, garlic, peppercorns, and bay leaves.");
            ulamList.Add(Ulam2);

            Ulam Ulam3 = new Ulam("Ginisang Sitaw", "Vegetables","", "A simple Filipino stir-fried dish highlighting yard-long beans (sitaw) often sautéed with garlic, onions, and sometimes ground pork or shrimp.");
            ulamList.Add(Ulam3);

            Ulam Ulam4 = new Ulam("Cordon Bleu", "Chicken", "Cheese", "A gourmet dish typically made with a pounded chicken or veal cutlet, wrapped around a slice of ham and cheese, then breaded and pan-fried or baked until golden.");
            ulamList.Add(Ulam4);

            Ulam Ulam5 = new Ulam("Ratatouille", "Vegetables", "", "A vibrant and rustic French Provençal stewed vegetable dish, featuring a medley of eggplant, zucchini, bell peppers, onions, and tomatoes, often seasoned with herbs.");
            ulamList.Add(Ulam5);

            ulamList.Add(new Ulam("Steak", "Beef", "", "A thick cut of meat, usually beef, cooked by grilling, pan-frying, or broiling to a desired doneness, often seasoned simply to highlight its natural flavor."));
            ulamList.Add(new Ulam("Scrambled Eggs", "Egg", "", "A popular and versatile breakfast dish made by whisking eggs and cooking them in a pan, stirring frequently until softly set curds form."));
            ulamList.Add(new Ulam("Chopsuey", "Vegetables", "", "A Chinese-American dish consisting of stir-fried meat (chicken, pork, or beef) and various vegetables like bean sprouts, cabbage, and celery, typically served over rice or noodles."));
            ulamList.Add(new Ulam("Gambas", "Shrimp", "", "A Spanish tapa featuring shrimp (gambas) quickly cooked in olive oil with garlic, chili, and sometimes a splash of white wine or brandy."));
            ulamList.Add(new Ulam("Beef Stroganoff", "Beef", "", "A creamy Russian dish made with sautéed pieces of beef, often served in a sauce with sour cream, onions, and mushrooms, typically over egg noodles or rice."));

            foreach (Ulam ulam in ulamList)
            {
                ulam.Type = "Custom";
            }
        }

        public void CreateUlam(Ulam ulam)
        {
            ulamList.Add(ulam);
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

        public List<Ulam> GetUlams()
        {
            autoNumber(ulamList);
            return ulamList;
        }

        public void RemoveUlam(Ulam ulam)
        {
            //for (int i = 0; i < ulamList.Count; i++)
            //{
            //    if (ulamList[i].UlamName.Equals(ulam.UlamName,StringComparison.OrdinalIgnoreCase))
            //    {
            //        ulamList.Remove(ulam);
            //    }
            //}
            ulamList.Remove(ulam);
        }

        public void UpdateUlam(Ulam ulamEdit)
        {
            int index = -1;
            for (int i = 0; i < ulamList.Count; i++)
            {
                if (ulamList[i].UlamName.Equals(ulamEdit.UlamName, StringComparison.OrdinalIgnoreCase))
                {
                    Ulam ulamToChange = ulamList[i];
                    ulamToChange.MainIngredient1 = ulamEdit.MainIngredient1;
                    ulamToChange.MainIngredient2 = ulamEdit.MainIngredient2;

                    if (ulamToChange.ulamDescription != "")
                    {
                        ulamList[i].ulamDescription = ulamToChange.ulamDescription;
                    }
                }
            }

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

