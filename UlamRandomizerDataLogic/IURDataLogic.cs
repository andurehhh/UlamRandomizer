using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlamCommon;

namespace UlamRandomizerDataLogic
{
    public interface IURDataLogic
    {
        public List<Ulam> GetUlams();
        public void CreateUlam(Ulam ulam);
        public void UpdateUlam(Ulam ulam);
        public void RemoveUlam(Ulam ulam);
        public Ulam GetUlamByID(int UlamID);
    }
}
