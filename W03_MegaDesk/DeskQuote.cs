using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace W03_MegaDesk {
    class DeskQuote {

        public DateTime currentDate;
        public string customerName;
        public Desk desk;

        public decimal getQuote() {

            //Desk base price
            decimal price = 200;

            //If surface area is over 1000, charge for every inch over 1000
            if (desk.SurfaceArea > 1000) {
                price += (desk.SurfaceArea - 1000);
            }

            //$50 for each drawer
            price += (desk.NumberOfDrawers * 50);

            //Check the surface material choice and 
            //add the correct amount to the price
            switch (desk.SurfaceMaterial) {
                case SurfaceMaterial.Laminate: { price += 100; break; }
                case SurfaceMaterial.Oak:      { price += 200; break; }
                case SurfaceMaterial.Pine:     { price += 50;  break; }
                case SurfaceMaterial.Rosewood: { price += 300; break; }
                case SurfaceMaterial.Veneer:   { price += 125; break; }
            }


            //Check rush order options and add to price
            price += calcRushPrice(desk.RushOption);


            return price;
        }


        /*********************************************************
         * Calculates the rush price based on the enum value 
         * and surface area. Returns rush price.
         *********************************************************/
        private decimal calcRushPrice(RushOption option) {
            
            decimal rushPrice = 0;

            switch (option) {

                case RushOption.none: {
                    break;
                }

                case RushOption.day_3: {
                    if (desk.SurfaceArea < 1000) {
                        rushPrice = 60;
                    } else if (desk.SurfaceArea >= 1000 && desk.SurfaceArea <= 2000) {
                        rushPrice = 70;
                    } else if (desk.SurfaceArea > 2000) {
                        rushPrice = 80;
                    }
                    break;
                }

                case RushOption.day_5: {
                    if (desk.SurfaceArea < 1000) {
                        rushPrice = 40;
                    } else if (desk.SurfaceArea >= 1000 && desk.SurfaceArea <= 2000) {
                        rushPrice = 50;
                    } else if (desk.SurfaceArea > 2000) {
                        rushPrice = 60;
                    }
                    break;
                }

                case RushOption.day_7: {
                    if (desk.SurfaceArea < 1000) {
                        rushPrice = 30;
                    } else if (desk.SurfaceArea >= 1000 && desk.SurfaceArea <= 2000) {
                        rushPrice = 35;
                    } else if (desk.SurfaceArea > 2000) {
                        rushPrice = 40;
                    }
                    break;
                }
            }

            return rushPrice;
        }
    }
}
