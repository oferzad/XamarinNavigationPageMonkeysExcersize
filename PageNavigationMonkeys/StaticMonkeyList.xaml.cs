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

    public class MonkeyContext
    {
        public Monkey M1 { get; set; }
        public Monkey M2 { get; set; }
        public Monkey M3 { get; set; }
    }

    public partial class StaticMonkeyList : ContentPage
    {
        public StaticMonkeyList()
        {
            Monkeys monkeys = new Monkeys();
            MonkeyContext context = new MonkeyContext
            {
                M1 = monkeys.MonkeyList[0],
                M2 = monkeys.MonkeyList[1],
                M3 = monkeys.MonkeyList[2]
            };
            this.BindingContext = context;
            this.Title = "Static Monkeys";
            InitializeComponent();
        }

        private void img1_Clicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            Page p = new ShowMonkeyPage();
            p.Title = ((MonkeyContext)BindingContext).M1.Name;
            p.BindingContext = ((MonkeyContext)BindingContext).M1;
            App.Current.MainPage.Navigation.PushAsync(p);

        }

        private void img2_Clicked(object sender, EventArgs e)
        {
            Page p = new ShowMonkeyPage();
            p.Title = ((MonkeyContext)BindingContext).M2.Name;
            p.BindingContext = ((MonkeyContext)BindingContext).M2;
            App.Current.MainPage.Navigation.PushAsync(p);
        }

        private void img3_Clicked(object sender, EventArgs e)
        {
            Page p = new ShowMonkeyPage();
            p.Title = ((MonkeyContext)BindingContext).M3.Name;
            p.BindingContext = ((MonkeyContext)BindingContext).M3;
            App.Current.MainPage.Navigation.PushAsync(p);
        }
    }
}