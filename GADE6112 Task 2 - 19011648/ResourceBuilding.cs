﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Task_2___19011648
{
    public class ResourceBuilding : Building
    {
        private string resourceType;
        private int numResource;
        private int numResourcePR;
        private int pool;
        public bool IsDead { get; set; }
        public int PosX
        {
            get { return bPosX; }
            set { bPosX = value; }
        }
        public int PosY
        {
            get { return bPosY; }
            set { bPosY = value; }
        }
        public int Health
        {
            get { return bHealth; }
            set { bHealth = value; }
        }
        public int MaxHealth
        {
            get { return bHealthMax; }
        }
        public int Faction
        {
            get { return bFaction; }
        }
        public string Symbol
        {
            get { return bSym; }
            set { bSym = value; }
        }

        public ResourceBuilding(int x, int y, string rt, int h, int rpr, int p, int f)
        {
            PosX = x;
            PosY = y;
            resourceType = rt;
            numResource = 0;
            Health = h;
            bHealthMax = h;
            numResourcePR = rpr;
            pool = p;
            bFaction = f;
            Symbol = numResource.ToString();
        }


        public override void DieDie()
        {
            Symbol = "XX";
            IsDead = true;
        }
        public override string ToString()
        {
            string temp = "";
            temp += "Resource: ";
            temp += "+" + numResourcePR + resourceType + "[" + numResource + "]\n";
            temp += "{" + Symbol + "}\n";
            temp += "(" + PosX + "," + PosY + ")\n";
            temp += Health + ", " + pool + "\n";
            temp += IsDead ? " DESTROYED!" : " FUNCTIONING!";
            return temp;
        }
        public void Generator()
        {
            if (IsDead == false && pool > 0)
            {
                numResource += numResourcePR;
                pool -= numResourcePR;
                Symbol = numResource.ToString();
            }
        }
    }
}
