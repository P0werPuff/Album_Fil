using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Album_Fil
{
    public partial class MainPage : CarouselPage
    {
        Button btn1, btn2, btn3, btn4;
        Label Angrytoys, X2, Introduction, ARTHOES;
     
        public MainPage()
        {
            btn1 = new Button
            {
                ImageSource = "OLD_BLOOD.jpg"
            };
            btn1.Clicked += Btn1_Clicked1;
            Angrytoys = new Label
            {
                IsVisible = false,
                Padding = 20,
                Text = "«Этот трек — дань уважения моему уфимскому кругу граффити-художников. У нас на районе в свое время было две команды — Never Been Crew и Kamuna Angry Toys, — и мы вместе рисовали. Это пацаны, с которыми мы вместе взрослели, и я с ними общаюсь до сих пор». ",
                FontSize = 12
            };
            btn2 = new Button
            {
                ImageSource = "OLD_BLOOD.jpg"
            };
            btn2.Clicked += Btn2_Clicked; ;
            X2 = new Label
            {
                IsVisible = false,
                Padding = 20,
                Text = "«Этот трек о том, что я сижу и работаю, и количество работы прямо пропорционально влияет на мои успехи. У меня не бывает такого, что альбом сдал и сижу, ничего не делаю. Я, например, вчера на студии был и только в 6 утра с нее вернулся»."
            };
            btn3 = new Button
            {
                ImageSource = "OLD_BLOOD.jpg"
            };
            btn3.Clicked += Btn3_Clicked;
            Introduction = new Label
            {
                IsVisible = false,
                Padding = 20,
                Text = "«Я очень хотел себе интро в духе старых рэперских альбомов. Искал-искал, и оно мне в руки само упало. Этот фрагмент взят из интервью Ксении Анатольевны Собчак с Алсу, где Собчак ставит Алсу мой трек. Так сказать, цитаты великих людей»."
            };
            btn4 = new Button
            {
                ImageSource = "OLD_BLOOD.jpg"
            };
            btn4.Clicked += Btn4_Clicked;
            ARTHOES = new Label
            {
                IsVisible = false,
                Padding = 20,
                Text = "«Самый первый трек, который я сделал для этого альбома. Записал его в Берлине, когда мы снимали там клип на „DRUГ“. Этот трек и задал стилистический вектор альбома: такой приятный инструментальный хип-хоп. Как классика золотой эры, но сделанная по новым правилам, с новыми ударными. Трек основан на семпле из пьесы Эрика Сати. Мне нравится Сати, мне вообще многое нравится. Я иногда слушаю хор села Большебыково»."
            };
            






            InitializeComponent();
            var start = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {

                        new Label
                        {
                            Text = "Стартовая страница\nВиды темперамента",
                            TextColor = Color.White,
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalTextAlignment = TextAlignment.Center,
                            BackgroundColor=Color.DarkGray
                        },
                        new Image {Source = "start.webp"},
                        btn5

                    }
                }
            };
            var Angrytoys = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {

                            Text = "Холерик",
                            TextColor = Color.White,
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalTextAlignment = TextAlignment.Center,
                            BackgroundColor=Color.Black,
                            Padding = 20

                        },
                        btn1,
                        Angrytoys

                    }
                }
            };
            var X2 = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Сангвиник",
                            TextColor = Color.White,
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalTextAlignment = TextAlignment.Center,
                            BackgroundColor=Color.Black,
                            Padding = 20

                        },
                        btn2,
                        X2


                    }
                }
            };
            var Introduction = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Флегматик",
                            TextColor = Color.White,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                            HorizontalTextAlignment = TextAlignment.Center,
                            BackgroundColor=Color.Black,
                            Padding = 20
                        },
                        btn3,
                        Introduction

                    }
                }
            };
            var ARTHOES = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Меланхолик",
                            TextColor = Color.White,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                            HorizontalTextAlignment = TextAlignment.Center,
                            BackgroundColor=Color.Black,
                            Padding = 20
                        },
                        btn4,
                        ARTHOES

                    }
                }
            };

            Children.Add(start);
            Children.Add(Angrytoys);
            Children.Add(X2);
            Children.Add(Introduction);
            Children.Add(ARTHOES);
        }

        

        private void Btn4_Clicked(object sender, EventArgs e)
        {
            ARTHOES.IsVisible = true;
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            X2.IsVisible = true;
        }

        private void Btn3_Clicked(object sender, EventArgs e)
        {
            Introduction.IsVisible = true;
        }

        private void Btn1_Clicked1(object sender, EventArgs e)
        {
            Angrytoys.IsVisible = true;
        }
    }
}
