﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    public class InvestigationGroup
    {

        public string Announcement { get; set; }
        public string Year { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string CreationDate { get; set; }
        public string Municipality { get; set; }
        public string Department { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string DaneID { get; set; }
        public string OcdeID { get; set; }
        public string OcdeArea { get; set; }
        public string OcdeLargeArea { get; set; }
        public string Clasification { get; set; }
        public int OrderClass { get; set; }
        public int Age { get; set; }

        //*****************
        //deberia tener un try catch
        //*******************
        public InvestigationGroup(String[] info)
        {
            Announcement = info[0];
            Year = info[1];
            Code = info[2];
            Name = info[3];
            CreationDate = info[4];
            Municipality = info[5];
            Department = info[6];
            Country = info[7];
            Region = info[8];
            DaneID = info[9];
            OcdeID = info[10];
            OcdeArea = info[11];
            OcdeLargeArea = info[12];
            Clasification = info[13];
            OrderClass = int.Parse(info[14]);
            Age = int.Parse(info[15]);
        }


        public override string ToString()
        {
            return Name;
        }

        public String All_Data()
        {

            String a = "";
            a += Announcement+";";
            a += Year + ";";
            a += Code + ";";
            a += Name + ";";
            a += CreationDate + ";";
            a += Municipality + ";";
            a += Department + ";";
            a += Country + ";";
            a += Region + ";";
            a += DaneID + ";";
            a += OcdeID + ";";
            a += OcdeArea + ";";
            a += OcdeLargeArea + ";";
            a += Clasification + ";";
            a += OrderClass + ";";
            a += Age;

            return a;
        }
    }
}
