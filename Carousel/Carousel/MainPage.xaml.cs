using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Carousel
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            Button btn = new Button
            {
                Text="Открыть Gmail"
            };
            Button btn1 = new Button
            {
                Text="Открыть Google Maps"
            };
            Button btn2 = new Button
            {
                Text="Открыть Google Drive"
            };
            Button btn3 = new Button
            {
                Text="Открыть YouTube"
            };
            Button btn4 = new Button
            {
                Text="Открыть Google"
            };
            Button btn5 = new Button
            {
                Text="Открыть Google Translate"
            };

            btn.Clicked += Btn_Clicked;
            btn1.Clicked += Btn1_Clicked;
            btn2.Clicked += Btn2_Clicked;
            btn3.Clicked += Btn3_Clicked;
            btn4.Clicked += Btn4_Clicked;
            btn5.Clicked += Btn5_Clicked;

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
                        VerticalOptions=LayoutOptions.CenterAndExpand
                    },
                    btn }

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
                        VerticalOptions=LayoutOptions.CenterAndExpand
                    },
                    
                    btn1 }

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
                        VerticalOptions=LayoutOptions.CenterAndExpand },
                   btn2 }

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
                        VerticalOptions=LayoutOptions.CenterAndExpand },
                    btn3}

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
                        VerticalOptions=LayoutOptions.CenterAndExpand },
                    btn4}
                    
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
                        VerticalOptions=LayoutOptions.CenterAndExpand },
                    btn5}

                }
            };
            Children.Add(google);
            Children.Add(gmail);
            Children.Add(maps);
            Children.Add(drive);
            Children.Add(youtube);
            Children.Add(translate);
            }

        private async void Btn5_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://translate.google.com/?hl=ru");
            await Browser.OpenAsync(uri);
        }

        private async void Btn4_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.google.ru/");
            await Browser.OpenAsync(uri);
        }

        private async void Btn3_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.youtube.com/");
            await Browser.OpenAsync(uri);
        }

        private async void Btn2_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://drive.google.com/drive/u/0/my-drive");
            await Browser.OpenAsync(uri);
        }

        private async void Btn1_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.google.ru/maps/@59.408384,24.7037952,12z");
            await Browser.OpenAsync(uri);
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://mail.google.com/mail/u/0/?tab=wm&ogbl#inbox");
            await Browser.OpenAsync(uri);
        }
    }
            };
