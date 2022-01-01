using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Builder_Pattern.Faceted_Builder
{
    public class Person
    {
        //Address
        public string StreetAddress, PostCode, City;

        //Employment
        public string CompanyName, Position;
        public int AnnualIncome;

        public override string ToString()
        {
            string returnValue = $"{nameof(StreetAddress)}: {StreetAddress},";
            returnValue += $"{nameof(PostCode)}: {PostCode},";
            returnValue += $"{nameof(CompanyName)}: {CompanyName},";
            returnValue += $"{nameof(Position)}: {Position},";
            returnValue += $"{nameof(AnnualIncome)}: {AnnualIncome},";

            return returnValue;
        }
    }
}
