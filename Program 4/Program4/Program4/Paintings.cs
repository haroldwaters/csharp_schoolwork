using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class Painting
    {
        public string artist { get; set; }
        public string genre { get; set; }
        public string country { get; set; }
        public int year { get; set; }
        public double wholesalecost { get; set; }

        private double commission = 2000;
        private double tax = 4.95;
        private double duty = 3000;

        public Painting()
        {
            artist = "Van Gogh";
            genre = "Post-Impressionist";
            country = "Netherlands";
            year = 1885;
            wholesalecost = 150000;

        }
        
        public Painting(string paramArtist, string paramGenre, string paramCountry,
                        int paramYear, double paramWholesalecost)
        {
            artist = paramArtist;
            genre = paramGenre;
            country = paramCountry;
            year = paramYear;
            wholesalecost = paramWholesalecost;
             
        }
        
        public double retailPrice()
        {
            return wholesalecost + commission + tax + duty;
        }

        public override string ToString()
        {
            return "Painting Attributes ============" + Environment.NewLine +
                   "\tArtist: " + artist + Environment.NewLine +
                   "\tGenre: " + genre + Environment.NewLine +
                   "\tCountry: " + country + Environment.NewLine +
                   "\tYear: " + year + Environment.NewLine +
                   "\tWholesale Price: " + wholesalecost + Environment.NewLine +
                   "\tRetail Price: " + this.retailPrice();
        }
    }
}
