using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Album_Fil
{
    public partial class MainPage : CarouselPage
    {
        Button btn1, btn2, btn3, btn4, btn5;
        Label Introduction, Angrytoys, OLDBLOOD, X2, Blocking;

        public MainPage()
        {
            //Button - 1
            btn1 = new Button
            {
                ImageSource = "oldblood.jpg"
            };
            btn1.Clicked += Btn1_Clicked1;
            Introduction = new Label
            {
                IsVisible = false,
                Padding = 20,
                Text = "«Я очень хотел себе интро в духе старых рэперских альбомов. Искал-искал, и оно мне в руки само упало." +
                " Этот фрагмент взят из интервью Ксении Анатольевны Собчак с Алсу, где Собчак ставит Алсу мой трек. Так сказать, цитаты великих людей». ",
                FontSize = 12
            };

            //Button - 2
            btn2 = new Button
            {
                ImageSource = "oldblood.jpg"
            };
            btn2.Clicked += Btn2_Clicked; ;
            Angrytoys = new Label
            {
                IsVisible = false,
                Padding = 20,
                Text = "«Этот трек — дань уважения моему уфимскому кругу граффити-художников." +
                " У нас на районе в свое время было две команды — Never Been Crew и Kamuna Angry Toys, — и мы вместе рисовали. " +
                "Это пацаны, с которыми мы вместе взрослели, и я с ними общаюсь до сих пор». "
            };

            //Button - 3
            btn3 = new Button
            {
                ImageSource = "oldblood.jpg"
            };
            btn3.Clicked += Btn3_Clicked;
            OLDBLOOD = new Label
            {
                IsVisible = false,
                Padding = 20,
                Text = "«Этот трек о том, что я сижу и работаю, и количество работы прямо пропорционально влияет на мои успехи." +
                " У меня не бывает такого, что альбом сдал и сижу, ничего не делаю. Я, например, вчера на студии был и только в 6 утра с нее вернулся»."
            };

            //Button - 4
            btn4 = new Button
            {
                ImageSource = "oldblood.jpg"
            };
            btn4.Clicked += Btn4_Clicked;
            X2 = new Label
            {
                IsVisible = false,
                Padding = 20,
                Text = "«Для меня лично — это самый важный трек. Он об отношении к творчеству и вообще к жизни. " +
                "Дальше я бы не стал объяснять то, что не надо объяснять. Магия пропадет»."
                
            };

            btn5 = new Button
            {
                ImageSource = "tayke.jpg"
            };
            btn5.Clicked += Btn5_Clicked;
            Blocking = new Label
            {
                IsVisible = false,
                Padding = 20,
                Text = "«Данная работа написано случайно у LIL TAYKE дома»."

            };

            InitializeComponent();
            var Введение = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {

                            Text = "Boulevard Depo - Введение\nProd.Blacksurfer",
                            TextColor = Color.White,
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalTextAlignment = TextAlignment.Center,
                            BackgroundColor=Color.Red,
                            Padding = 20 

                        },
                        btn1,
                        Introduction

                    }
                }
            };
            var Angrytoyss = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Boulevard Depo - Angry toy$\nProd.Ray Qwa",
                            TextColor = Color.White,
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalTextAlignment = TextAlignment.Center,
                            BackgroundColor=Color.Red,
                            Padding = 20

                        },
                        btn2,
                        Angrytoys


                    }
                }
            };
            var OLDBLOODD = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Boulevard Depo - OLD BLOOD\nProd.Chivaz",
                            TextColor = Color.White,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                            HorizontalTextAlignment = TextAlignment.Center,
                            BackgroundColor=Color.Red,
                            Padding = 20
                        },
                        btn3,
                        OLDBLOOD

                    }
                }
            };
            var X22 = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Boulevard Depo - X2\nProd.Gredy",
                            TextColor = Color.White,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                            HorizontalTextAlignment = TextAlignment.Center,
                            BackgroundColor=Color.Red,
                            Padding = 20
                        },
                        btn4,
                        X2

                    }
                }
            };
            var Block = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Lil TAYKE & LIL ENOT -\nHidin on Da Block\nProd.fresh.Derneyx",
                            TextColor = Color.White,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                            HorizontalTextAlignment = TextAlignment.Center,
                            BackgroundColor=Color.Red,
                            Padding = 20
                        },
                        btn5,
                        Blocking

                    }
                }
            };
            var start = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {

                        new Label
                        {
                            Text = "Пятый студийный альбом российского хип-хоп-исполнителя Boulevard Depo, выпущенный 29 мая 2020 года на лейбле Warner Music Russia.",
                            TextColor = Color.White,
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalTextAlignment = TextAlignment.Center,
                            BackgroundColor=Color.Red
                        },
                        new Image {Source = "oldblood.jpg"},


                    }
                }
            };

            Children.Add(start);
            Children.Add(Введение);
            Children.Add(Angrytoyss);
            Children.Add(OLDBLOODD);
            Children.Add(X22);
            Children.Add(Block);
        }



        private void Btn5_Clicked(object sender, EventArgs e)
        {
            Blocking.IsVisible = true;
        }
        private void Btn4_Clicked(object sender, EventArgs e)
        {
            X2.IsVisible = true;
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            Angrytoys.IsVisible = true;
        }

        private void Btn3_Clicked(object sender, EventArgs e)
        {
            OLDBLOOD.IsVisible = true;
        }

        private void Btn1_Clicked1(object sender, EventArgs e)
        {
            Introduction.IsVisible = true;
        }
    }

}
