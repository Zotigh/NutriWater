/******************************************************
*Programmer: Lance Zotigh(lzotigh1 @cnm.edu)
*Purpose: A simple program that calculates the amount of chemicals you need to add to a bucket of water (4 Hydroponics)
*******************************************************/

using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

namespace NutriWater.Models
{
    public class Calculations
    {
        //initillizer
        private List<SingleCalcualtion> calculations = new List<SingleCalcualtion>();

        //Getter and Setter
        public virtual List<SingleCalcualtion> Calcualtions
        {
            get { return calculations; }
            set { calculations = value; }
        }
    }
}
