using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlamRandomizerBusinessLogic
{
    public class Ulam
    {
        public string UlamName;
        public string MainIngredient;
        public bool isMarked;
        public Ulam(string UlamName,string MainIngredient)
        {
            this.UlamName = UlamName;
            this.MainIngredient = MainIngredient;
            isMarked = false;
        }

        public void set(string UlamName, string MainIngredient)
        {
            this.UlamName = UlamName;
            this.MainIngredient= MainIngredient;
        }
        public void get(string UlamName, string MainIngredient)
        {
            this.UlamName = UlamName;
            this.MainIngredient = MainIngredient;
        }
    }
}
