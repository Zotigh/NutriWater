/******************************************************
*Programmer: Lance Zotigh(lzotigh1 @cnm.edu)
*Purpose: A simple program that calculates the amount of chemicals you need to add to a bucket of water (4 Hydroponics)
*******************************************************/

using System.ComponentModel.DataAnnotations;

namespace NutriWater.Models
{
    public class SingleCalcualtion
    {
        //Fields
        private double gallons = 0;
        private double endCalculation = 0;
        private double floraMicro = 0;
        private double floraBloom = 0;
        private double floraGro = 0;

        [Range(1, double.MaxValue - 1, ErrorMessage = "Positive Numbers Only!")]
        public double Gallons
        {
            get { return gallons; }
            set { gallons = value; }
        }

        
    }
}
