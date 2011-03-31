using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Maxi
{
    public class Country
    {
        //country vars
        private string name;
        private double GDP;
        private double tourism;
        private double correlation;

        //instantiators
        public Country(string countryName, double countryGDP, double countryTourism, double countryCorrelation)
        {
            name = countryName;
            GDP = countryGDP;
            tourism = countryTourism;
            correlation = countryCorrelation;
            return;
        }
        public Country(string countryName, double countryGDP, double countryTourism)
        {
            name = countryName;
            GDP = countryGDP;
            tourism = countryTourism;
            correlation = 0;
            return;
        }

        //getters
        public string getName()
        {
            return name;
        }
        public double getGDP()
        {
            return GDP;
        }
        public double getTourism()
        {
            return tourism;
        }
        public double getCorrelation()
        {
            return correlation;
        }

        //setters
        public void setName(string n)
        {
            name = n;
        }
        public void setGDP(double g)
        {
            GDP = g;
        }
        public void setTourism(double t)
        {
            tourism = t;
        }
        public void setCorrelation(double c)
        {
            correlation = c;
        }

        //Utilities & Methods
    }
}
