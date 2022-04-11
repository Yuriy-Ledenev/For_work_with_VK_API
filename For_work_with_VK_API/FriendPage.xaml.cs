﻿using MobileClient;
using Xamarin.Forms;

namespace HelloApp
{
    public partial class FriendPage : ContentPage
    {
        public Friend Model { get; private set; }
        public ApplicationViewModel ViewModel { get; private set; }
        public FriendPage(Friend model, ApplicationViewModel viewModel)
        {
            InitializeComponent();
            Model = model;
            ViewModel = viewModel;
            this.BindingContext = this;
        }
    }
}