/******************************************************
*Programmer: Lance Zotigh(lzotigh1 @cnm.edu)
*Purpose: A simple program that calculates the amount of chemicals you need to add to a bucket of water (4 Hydroponics)
*******************************************************/

using System.ComponentModel.DataAnnotations;

namespace NutriWater.Models
{
    public class SingleCalcualtion
    {
        //TODO I am unsure of where to put the calc method as of yet???

        //Fields
        private DateTime dateAddedToInventory;
        private DateTime dateRemovedFromInventory;
        private double gallons = 0;
        private double finalCalc = 0;
        private double floraMicro = 0;
        private double floraBloom = 0;
        private double floraGro = 0;
        private int final = 0;
        private int position = 0;
        private string title = "";

        [Required(ErrorMessage = "Please be sure to include a Date Added!")]
        public DateTime DateAddedToInventory
        {
            get { return dateAddedToInventory; }
            set { dateAddedToInventory = value; Calc(); }
        }
        [Required(ErrorMessage = "Please be sure to include a Date Removed!")]
        public DateTime DateRemovedFromInventory
        {
            get { return dateRemovedFromInventory; }
            set { dateRemovedFromInventory = value; }
        }
        [Range(1, double.MaxValue - 1, ErrorMessage = "Positive Numbers Only!")]
        public double Gallons
        {
            get { return gallons; }
            set { gallons = value; Calc(); }
        }
        [Range(1, double.MaxValue - 1, ErrorMessage = "Positive Numbers Only!")]
        public double FinalCalc
        {
            get { return finalCalc; }
            //set { finalCalc = value; }
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
        [Required(ErrorMessage = "Please be sure to include a title!")]
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        [Required]
        [Range(1, int.MaxValue - 1, ErrorMessage = "Positive Numbers Only!")]
        public int Position
        {
            get { return position; }
            set { position = value; }
        }

        //Base class and Overloaders class constructors
        public SingleCalcualtion() { }

        public SingleCalcualtion(double gallons, double endCalculation, double floraMicro, double floraBloom, double floraGro, string title, DateTime dateAddedToInventory, DateTime dateRemovedFromInventory)
        {
            Gallons = gallons;
            FloraMicro = floraMicro;
            FloraBloom = floraBloom;
            Title = title;
            FloraGro = floraGro;
            DateAddedToInventory = dateAddedToInventory;
            DateRemovedFromInventory = dateRemovedFromInventory;

        }
        
        private void Calc()
        {
            //TODO use the conversion chart to output the correct data
            //Need to find values may need to make more instances to handle the final calculations. 
            //This may need me to return multiple results.

            // endCalculation = ;
        }
    }
}
