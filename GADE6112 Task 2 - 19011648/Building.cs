﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Task_2___19011648
{
    public abstract class Building
    {
        protected int bPosX;
        protected int bPosY;
        protected int bHealth;
        protected int bHealthMax;
        protected int bFaction;
        protected string bSym;

        public abstract void DieDie();
        public abstract override string ToString();
    }
}
