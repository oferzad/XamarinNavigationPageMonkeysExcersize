using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PageNavigationMonkeys
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DynamicMonkeyList : ContentPage
    {
        public DynamicMonkeyList()
        {
            InitializeComponent();
            BuildList();
            this.Title = "Dynamic Monkeys";
        }

        private void BuildList()
        {
            Monkeys monkeys = new Monkeys();
            foreach(Monkey m in monkeys.MonkeyList)
            {
                //Create the image button
                ImageButton img = new ImageButton();
                img.Source = m.ImageUrl;
                img.BindingContext = m; //Attach the monkey object to the image button!
                img.Clicked += Img_Clicked;

                //Create the box view to display line
                BoxView box = new BoxView();
                box.WidthRequest = 400;
                box.HeightRequest = 10;
                box.Color = Color.Blue;

                //Add the imgae button and box view to the layout
                stck.Children.Add(img);
                stck.Children.Add(box);
            }
        }

        private async void Img_Clicked(object sender, EventArgs e)
        {
            if (sender is ImageButton)
            {
                ImageButton img = (ImageButton)sender;
                Page p = new ShowMonkeyPage();
                p.BindingContext = img.BindingContext;
                Monkey m = (Monkey)img.BindingContext;
                p.Title = m.Name;
                await Navigation.PushAsync(p);
            }

        }
    }
}