﻿using LoginAndValidation.Models;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace LoginAndValidation.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {

        public HomeViewModel()
        {
            Title = "About";
            // OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        // public ICommand OpenWebCommand { get; }
    }
}