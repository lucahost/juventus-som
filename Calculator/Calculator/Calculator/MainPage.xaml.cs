﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        enum Operations
        {
            Plus,
            Minus,
            Divide,
            Multiply
        }

        public MainPage()
        {
            InitializeComponent();
        }

        public void PlusButton_Clicked(object sender, EventArgs e)
        {

        }

        public void MinusButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}
