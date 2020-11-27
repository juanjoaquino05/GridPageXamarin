using LoginAndValidation.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginAndValidation.ViewModels
{
    public class DiscoveryViewModel : BaseViewModel
    {
        public MenuOption BarAndHotelsMenuOption { get; set; } = new MenuOption();
        public MenuOption FineDinningMenuOption { get; set; } = new MenuOption();
        public MenuOption CafesMenuOption { get; set; } = new MenuOption();
        public MenuOption NearbyMenuOption { get; set; } = new MenuOption();
        public MenuOption FastFoodsMenuOption { get; set; } = new MenuOption();
        public MenuOption FeaturedFoodsMenuOption { get; set; } = new MenuOption();
        public DiscoveryViewModel()
        {
            Title = "Discovery";
            BarAndHotelsMenuOption.Title = "Bar and Hotels";
            BarAndHotelsMenuOption.Image = "home";
            BarAndHotelsMenuOption.PlaceText = "42 Place";

            FineDinningMenuOption.Title = "Fine Dinning";
            FineDinningMenuOption.Image = "home";
            FineDinningMenuOption.PlaceText = "15 Place";

            CafesMenuOption.Title = "Cafes";
            CafesMenuOption.Image = "home";
            CafesMenuOption.PlaceText = "28 Place";

            NearbyMenuOption.Title = "Nearby";
            NearbyMenuOption.Image = "home";
            NearbyMenuOption.PlaceText = "34 Place";

            FastFoodsMenuOption.Title = "Fast Foods";
            FastFoodsMenuOption.Image = "home";
            FastFoodsMenuOption.PlaceText = "29 Place";

            FeaturedFoodsMenuOption.Title = "Featured Foods";
            FeaturedFoodsMenuOption.Image = "home";
            FeaturedFoodsMenuOption.PlaceText = "21 Place";
            // OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }
    }
}
