using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konwolucje
{
    public static class Filters
    {
        public static List<List<List<double>>> LoadFirstPackOfFilters()
        {
            List<List<List<double>>> listOfFilters = new List<List<List<double>>>()
            {
                //filtry dla wiatru i ognia
                new List<List<double>>() {
                    new List<double>(){0,1,0},
                    new List<double>(){1,1,1},
                    new List<double>(){1,0,1},
                },
                new List<List<double>>() {
                    new List<double>(){1,0,1},
                    new List<double>(){1,1,1},
                    new List<double>(){0,1,0},
                },

                //filtry dla wszystkiego
                new List<List<double>>() {
                    new List<double>(){1,0,0},
                    new List<double>(){0,1,0},
                    new List<double>(){0,0,1},
                },
                new List<List<double>>() {
                    new List<double>(){0,0,1},
                    new List<double>(){0,1,0},
                    new List<double>(){1,0,0},
                },
                new List<List<double>>() {
                    new List<double>(){0,1,0},
                    new List<double>(){0,1,0},
                    new List<double>(){0,1,0},
                },
                new List<List<double>>() {
                    new List<double>(){0,0,0},
                    new List<double>(){1,1,1},
                    new List<double>(){0,0,0},
                },

                //filtry dla ziemii
                new List<List<double>>() {
                    new List<double>(){0,1,0},
                    new List<double>(){0,1,1},
                    new List<double>(){0,1,0},
                },
                new List<List<double>>() {
                    new List<double>(){0,1,0},
                    new List<double>(){1,1,1},
                    new List<double>(){0,0,0},
                },
                

                //filtry dla ognia
                new List<List<double>>() {
                    new List<double>(){0,0,1},
                    new List<double>(){0,1,1},
                    new List<double>(){1,1,1},
                },
                new List<List<double>>() {
                    new List<double>(){0,1,0},
                    new List<double>(){1,0,1},
                    new List<double>(){1,1,0},
                },

                //filtry dla wody
                new List<List<double>>() {
                    new List<double>(){0,1,0},
                    new List<double>(){0,1,1},
                    new List<double>(){0,0,0},
                },
                new List<List<double>>() {
                    new List<double>(){0,1,0},
                    new List<double>(){1,1,0},
                    new List<double>(){0,0,0},
                },
            };
            return listOfFilters;
        }
        public static List<List<List<double>>> LoadFirstPackOfFilters2()
        {
            List<List<List<double>>> listOfFilters = new List<List<List<double>>>()
            {
                //spec
                new List<List<double>>() {
                    new List<double>(){0,-1,0},
                    new List<double>(){-1,5,-1},
                    new List<double>(){0,-1,0},
                },
                //filtry dla wiatru i ognia
                new List<List<double>>() {
                    new List<double>(){-1,1,-1},
                    new List<double>(){1,1,1},
                    new List<double>(){1, -1, 1},
                },
                new List<List<double>>() {
                    new List<double>(){1, -1, 1},
                    new List<double>(){1,1,1},
                    new List<double>(){ -1, 1,-1},
                },

                //filtry dla wszystkiego
                new List<List<double>>() {
                    new List<double>(){1, -1, -1},
                    new List<double>(){ -1, 1,-1},
                    new List<double>(){ -1, -1, 1},
                },
                new List<List<double>>() {
                    new List<double>(){ -1, -1, 1},
                    new List<double>(){ -1, 1,-1},
                    new List<double>(){1, -1, -1},
                },
                new List<List<double>>() {
                    new List<double>(){ -1, 1,-1},
                    new List<double>(){ -1, 1,-1},
                    new List<double>(){ -1, 1,-1},
                },
                new List<List<double>>() {
                    new List<double>(){ -1, -1, -1},
                    new List<double>(){1,1,1},
                    new List<double>(){ -1, -1, -1},
                },

                //filtry dla ziemii
                new List<List<double>>() {
                    new List<double>(){ -1, 1,-1},
                    new List<double>(){ -1, 1,1},
                    new List<double>(){ -1, 1,-1},
                },
                new List<List<double>>() {
                    new List<double>(){ -1, 1,-1},
                    new List<double>(){1,1,1},
                    new List<double>(){ -1, -1, -1},
                },
                

                //filtry dla ognia
                new List<List<double>>() {
                    new List<double>(){ -1, -1, 1},
                    new List<double>(){ -1, 1,1},
                    new List<double>(){1,1,1},
                },
                new List<List<double>>() {
                    new List<double>(){ -1, 1,0},
                    new List<double>(){1, -1, 1},
                    new List<double>(){1,1,-1},
                },

                //filtry dla wody
                new List<List<double>>() {
                    new List<double>(){ -1, 1,-1},
                    new List<double>(){ -1, 1,1},
                    new List<double>(){ -1, -1, -1},
                },
                new List<List<double>>() {
                    new List<double>(){ -1, 1,-1},
                    new List<double>(){1,1,-1},
                    new List<double>(){-1, -1, -1},
                },
            };
            return listOfFilters;
        }
        public static List<List<List<double>>> LoadFirstPackOfFilters3()
        {
            List<List<List<double>>> listOfFilters = new List<List<List<double>>>()
            {
                //wykrywanie krawędzi
                new List<List<double>>() {
                    new List<double>(){-1,-1,-1},
                    new List<double>(){2,2,2},
                    new List<double>(){-1,-1,-1},
                },
                new List<List<double>>() {
                    new List<double>(){-1,2,-1},
                    new List<double>(){-1,2,-1},
                    new List<double>(){-1,2,-1},
                },
                new List<List<double>>() {
                    new List<double>(){2,-1,-1},
                    new List<double>(){-1,2,-1},
                    new List<double>(){-1,-1,2},
                },
                new List<List<double>>() {
                    new List<double>(){-1,-1,2},
                    new List<double>(){-1,2,-1},
                    new List<double>(){2,-1,-1},
                },
                new List<List<double>>() {
                    new List<double>(){-1,-1,-1},
                    new List<double>(){-1,8,-1},
                    new List<double>(){-1,-1,-1},
                },

            };
            return listOfFilters;
        }
        public static List<List<List<double>>> LoadFirstPackOfFilters4()
        {
            //wykrywanie krawędzi 9 sztuk
            List<List<List<double>>> listOfFilters = new List<List<List<double>>>()
            {
                new List<List<double>>() {
                    new List<double>(){-1,-1,-1},
                    new List<double>(){2,2,2},
                    new List<double>(){-1,-1,-1},
                },
                new List<List<double>>() {
                    new List<double>(){-1,2,-1},
                    new List<double>(){-1,2,-1},
                    new List<double>(){-1,2,-1},
                },
                new List<List<double>>() {
                    new List<double>(){2,-1,-1},
                    new List<double>(){-1,2,-1},
                    new List<double>(){-1,-1,2},
                },
                new List<List<double>>() {
                    new List<double>(){-1,-1,2},
                    new List<double>(){-1,2,-1},
                    new List<double>(){2,-1,-1},
                },
                new List<List<double>>() {
                    new List<double>(){-1,-1,-1},
                    new List<double>(){-1,8,-1},
                    new List<double>(){-1,-1,-1},
                },
                new List<List<double>>() {
                    new List<double>(){1,1,1},
                    new List<double>(){1,-8,1},
                    new List<double>(){1,1,1},
                },
                new List<List<double>>() {
                    new List<double>(){0,-1,0},
                    new List<double>(){-1,4,-1},
                    new List<double>(){0,-1,0},
                },
                new List<List<double>>() {
                    new List<double>(){0,1,0},
                    new List<double>(){1,-4,1},
                    new List<double>(){0,1,0},
                },
                new List<List<double>>() {
                    new List<double>(){-1,-1,0},
                    new List<double>(){-1,0,1},
                    new List<double>(){0,1,1},
                },
                 new List<List<double>>() {
                    new List<double>(){1,1,0},
                    new List<double>(){1,0,-1},
                    new List<double>(){0,-1,-1},
                },
                new List<List<double>>() {
                    new List<double>(){0,-1,-1},
                    new List<double>(){1,0,-1},
                    new List<double>(){1,1,0},
                },
                new List<List<double>>() {
                    new List<double>(){0,1,1},
                    new List<double>(){-1,0,1},
                    new List<double>(){-1,-1,0},
                },
            };
            return listOfFilters;
        }
    }
}
