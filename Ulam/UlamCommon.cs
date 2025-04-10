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
    public Ulam(string UlamName, string MainIngredient)
    {
        this.UlamName = UlamName;
        this.MainIngredient = MainIngredient;
        isMarked = false;
    }

}
