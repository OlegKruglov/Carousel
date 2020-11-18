using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Carousel
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            var gmail = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {
                        Text="Gmail",
                        FontSize = Device.GetNamedSize(NamedSize.Medium,typeof(Label)),
                        HorizontalOptions=LayoutOptions.Center },
                    new Image
                    {
                        Source="gmail.png",
                        WidthRequest=200,
                        HeightRequest=200,
                        HorizontalOptions=LayoutOptions.Center,
                        VerticalOptions=LayoutOptions.CenterAndExpand }
                    }

                }
            };
            var maps = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {
                        Text="Google Maps",
                        FontSize = Device.GetNamedSize(NamedSize.Medium,typeof(Label)),
                        HorizontalOptions=LayoutOptions.Center },
                    new Image
                    {
                        Source="maps.png",
                        WidthRequest=200,
                        HeightRequest=200,
                        HorizontalOptions=LayoutOptions.Center,
                        VerticalOptions=LayoutOptions.CenterAndExpand }
                    }

                }
            };
            var drive = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {
                        Text="Google Drive",
                        FontSize = Device.GetNamedSize(NamedSize.Medium,typeof(Label)),
                        HorizontalOptions=LayoutOptions.Center },
                    new Image
                    {
                        Source="drive.png",
                        WidthRequest=200,
                        HeightRequest=200,
                        HorizontalOptions=LayoutOptions.Center,
                        VerticalOptions=LayoutOptions.CenterAndExpand }
                    }

                }
            };
            var youtube = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {
                        Text="Youtube",
                        FontSize = Device.GetNamedSize(NamedSize.Medium,typeof(Label)),
                        HorizontalOptions=LayoutOptions.Center },
                    new Image
                    {
                        Source="youtube.png",
                        WidthRequest=200,
                        HeightRequest=200,
                        HorizontalOptions=LayoutOptions.Center,
                        VerticalOptions=LayoutOptions.CenterAndExpand }
                    }

                }
            };
            var google = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {
                        Text="Google",
                        FontSize = Device.GetNamedSize(NamedSize.Medium,typeof(Label)),
                        HorizontalOptions=LayoutOptions.Center },
                    new Image
                    {
                        Source="google.png",
                        WidthRequest=200,
                        HeightRequest=200,
                        HorizontalOptions=LayoutOptions.Center,
                        VerticalOptions=LayoutOptions.CenterAndExpand }
                    }

                }
            };
            var translate = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {
                        Text="Google Translate",
                        FontSize = Device.GetNamedSize(NamedSize.Medium,typeof(Label)),
                        HorizontalOptions=LayoutOptions.Center },
                    new Image
                    {
                        Source="translate.png",
                        WidthRequest=200,
                        HeightRequest=200,
                        HorizontalOptions=LayoutOptions.Center,
                        VerticalOptions=LayoutOptions.CenterAndExpand }
                    }

                }
            };
            Children.Add(google);
            Children.Add(gmail);
            Children.Add(maps);
            Children.Add(drive);
            Children.Add(youtube);
            Children.Add(translate);
            }
    }
            };
