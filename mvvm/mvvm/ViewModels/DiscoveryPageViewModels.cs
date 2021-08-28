using System;
using System.Collections.Generic;
using System.Text;
using mvvm.Model;


namespace mvvm.ViewModels
{
    public class DiscoveryPageViewModels
    {
        public DiscoveryInfo BarAndHotelsDiscoveryInfo { get; set; } = new DiscoveryInfo();
        public DiscoveryInfo FineDining { get; set; } = new DiscoveryInfo();
        public DiscoveryInfo Cafes { get; set; } = new DiscoveryInfo();
        public DiscoveryInfo Nearby { get; set; } = new DiscoveryInfo();
        public DiscoveryInfo FastFoods { get; set; } = new DiscoveryInfo();
        public DiscoveryInfo FeaturedFoods { get; set; } = new DiscoveryInfo();

        public DiscoveryPageViewModels()
        {

            BarAndHotelsDiscoveryInfo.Title = "Bar and Hotels";
            BarAndHotelsDiscoveryInfo.NumberOfPlaces = "42 Places";
            BarAndHotelsDiscoveryInfo.Image = "BarsAndHotels.png";

            FineDining.Title = "Fine Dining";
            FineDining.NumberOfPlaces = "15 Places";
            FineDining.Image = "FineDining.png";

            Cafes.Title = "Cafes";
            Cafes.NumberOfPlaces = "28 Places";
            Cafes.Image = "Cafes.png";

            Nearby.Title = "Nearby";
            Nearby.NumberOfPlaces = "34 Places";
            Nearby.Image = "Nearby.png";

            FastFoods.Title = "Fast Foods";
            FastFoods.NumberOfPlaces = "29 Places";
            FastFoods.Image = "FastFoods";

            FeaturedFoods.Title = "Featured Foods";
            FeaturedFoods.NumberOfPlaces = "21 Places";
            FeaturedFoods.Image = "FeaturedFoods.png";

            //BarAndHotelsDiscoveryInfo = new DiscoveryInfo() { Title = "Bar And Hotels", NumberOfPlaces = "42 Places", Image = "BarsAndHotels.png" };
            //FineDining = new DiscoveryInfo() { Title = "Fine Dining", NumberOfPlaces = "15 Places", Image = "FineDining.png" };
            //Cafes = new DiscoveryInfo() { Title = "Cafes", NumberOfPlaces = "28 Places", Image = "Cafes.png" };
            //Nearby = new DiscoveryInfo() { Title = "Nearby", NumberOfPlaces = "34 Places", Image = "Nearby.png" };
            //FastFoods = new DiscoveryInfo() { Title = "Fast Foods", NumberOfPlaces = "29 Places", Image = "FastFoods.png" };
            //FeaturedFoods = new DiscoveryInfo() { Title = "Featured Foods", NumberOfPlaces = "21 Places", Image = "FeaturedFoods.png" };
        }
    }

    
}
