using ChckNorrisJokesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SecondChuckNorrisApp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Category : ContentPage
    {
        public Category()
        {
            InitializeComponent();
        }

        public string[] Categories {get;set;}

       
        private async void GetCategory_Clicked(object sender, EventArgs e)
        {
          //  var catGenerator = new JokeGenerator();
          //  string[] joke = await catGenerator.GetCategories();
           // string emptyCat = "";
           // for (int i = 0; i < joke.Length; i++)
           // {
              //  emptyCat = joke[i];
           //     CartLabel.Text = emptyCat;
           // }

        }

        private async void CategoriesListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var catGenerator = new JokeGenerator();
            string joke = await catGenerator.GetRandomCatJ(e.Item.ToString());

            DisplayAlert(e.Item.ToString(), joke, "done");

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            var catGenerator = new JokeGenerator();
             string[] joke = await catGenerator.GetCategories();
            Categories = joke;

            BindingContext = this;

        }
    }
}