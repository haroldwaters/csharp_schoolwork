namespace Program4
{
    internal class Restaurant
    {
            private string city;
            private string chef;
            private string cuisineType;
            private string aAADiamondRating;

            public Restaurant()
            {
                city = "Austin";
                chef = "Guy Fierri";
                cuisineType = "Fried Food";
                aAADiamondRating = "-1";
            }

            public Restaurant(string paramCity, string paramChef,
                              string paramCuisineType, string paramAAADiamondRating)
            {
                city = paramCity;
                chef = paramChef;
                cuisineType = paramCuisineType;
                aAADiamondRating = paramAAADiamondRating;
            }

            public override string ToString()
            {
                return city + ", " + chef + ", " + cuisineType + ", " + aAADiamondRating;
            }
            public string City
            {
                get
                {
                    return city;
                }
                set
                {
                    city = value;
                }
            }

            public string Chef
            {
                get
                {
                    return chef;
                }
                set
                {
                    chef = value;
                }
            }

            public string CuisineType
            {
                get
                {
                    return cuisineType;
                }
                set
                {
                    CuisineType = value;
                }
            }

            public string AAADiamondRating
            {
                get
                {
                    return aAADiamondRating;
                }
                set
                {
                    aAADiamondRating = value;
                }
            }
        }
    }