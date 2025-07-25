﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlamCommon;

namespace UlamRandomizerDataLogic
{
    public class URDataLogic
    {
        IURDataLogic ulamRandomizerDataLogic;

        public URDataLogic()
        {

            //ulamRandomizerDataLogic = new FileDataLogic();
            //ulamRandomizerDataLogic = new InMemoryDataLogic();
            //ulamRandomizerDataLogic = new JsonDataLogic();
            ulamRandomizerDataLogic = new DBDataLogic();
        }
        public List<Ulam> GetUlams()
        {
            return ulamRandomizerDataLogic.GetUlams();
        }
        public void CreateUlam(Ulam ulam)
        {
            ulamRandomizerDataLogic.CreateUlam(ulam);
        }
        public void RemoveUlam(Ulam ulam)
        {
            ulamRandomizerDataLogic.RemoveUlam(ulam);
        }
        public void UpdateUlam(Ulam ulam)
        {
            ulamRandomizerDataLogic.UpdateUlam(ulam);
        }
        public Ulam GetUlambyID(int ulamID)
        {
            return ulamRandomizerDataLogic.GetUlamByID(ulamID);
        }

    }
}
