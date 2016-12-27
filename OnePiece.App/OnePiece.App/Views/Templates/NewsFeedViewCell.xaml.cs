﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnePiece.App.Models;
using Xamarin.Forms;

namespace OnePiece.App.Views.Templates
{
    public partial class NewsFeedViewCell : ViewCell
    {
        public NewsFeedViewCell()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var context = BindingContext as NewsFeed;
            if (context != null)
            {
                var gifPanelHeight = 0;
                foreach (var gif in context.Gifs)
                {
                    var gifHeight = GifPanel.Width * gif.Height / gif.Width;
                    gifPanelHeight = gifPanelHeight + (int)gifHeight + 5;
                }
                GifPanel.HeightRequest = gifPanelHeight - 5;
            }
        }
    }
}
