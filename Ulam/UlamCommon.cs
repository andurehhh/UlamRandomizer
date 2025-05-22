using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlamCommon;

public class Ulam
{
    public string UlamName { get; set; }
    public string MainIngredient { get; set; }
    public bool isMarked { get; set; }
    public string ulamDesciption { get; set; }
    public Ulam(string UlamName, string MainIngredient, string ulamDescription)
    {
        this.UlamName = UlamName;
        this.MainIngredient = MainIngredient;
        this.ulamDesciption = ulamDescription;
        isMarked = false;
    }

}
