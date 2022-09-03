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
        [Range(1, double.MaxValue - 1, ErrorMessage = "Positive Numbers Only!")]
        public double EndCalculation
        {
            get { return endCalculation; }
            set { endCalculation = value; }
        }

        [Range(1, double.MaxValue - 1, ErrorMessage = "Positive Numbers Only!")]
        public double FloraMicro
        {
            get { return floraMicro; }
            set { floraMicro = value; }
        }

        [Range(1, double.MaxValue - 1, ErrorMessage = "Positive Numbers Only!")]
        public double FloraBloom
        {
            get { return floraBloom; }
            set { floraBloom = value;}
        }

        [Range(1, double.MaxValue - 1, ErrorMessage = "Positive Numbers Only!")]
        public double FloraGro
        {
            get { return floraGro; }
            set { floraGro = value; }
        }

        //Base class and Overloaders class constructors
        public SingleCalcualtion() { }

        public SingleCalcualtion(double gallons, double endCalculation, double floraMicro, double floraBloom, double floraGro)
        {
            Gallons = gallons;
            EndCalculation = endCalculation;
            FloraMicro = floraMicro;
            FloraBloom = floraBloom;
            FloraGro = floraGro;
        }

        private void Calc()
        {

        }
    }
}
