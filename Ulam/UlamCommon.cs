using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlamCommon;

public class Ulam
{
    public string UlamName { get; set; }
    public string MainIngredient1 { get; set; }
    public string MainIngredient2 { get; set; }
    public string ulamDescription { get; set; }
    
    public Ulam()
    {
    }
    public Ulam(string UlamName, string MainIngredient1, string MainIngredient2, string ulamDescription)
    {
        this.UlamName = UlamName;
        this.MainIngredient1 = MainIngredient1;
        this.MainIngredient2 = MainIngredient2;
        this.ulamDescription = ulamDescription;
    }

}
