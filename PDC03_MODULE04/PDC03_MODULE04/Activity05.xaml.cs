using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MODULE04
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Activity05 : ContentPage
	{
		List<Contacts> contacts;
		public Activity05 ()
		{
			InitializeComponent ();
            SetupData();
            ListView.ItemsSource= contacts;
		}
        async void onItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (ListView.SelectedItem != null)
            {
                var detailPage = new DetailPage();
                detailPage.BindingContext = e.SelectedItem as Contacts;
                ListView.SelectedItem = null;
                await Navigation.PushModalAsync(detailPage);
            }
        }
        void SetupData()
		{
			contacts = new List<Contacts>();

			contacts.Add(new Contacts
			{
				Name = "Bobby Marcko Cruz",
				Age = 19,
				Occupation = "Student",
				Country = "Philippines"
			});

            contacts.Add(new Contacts
            {
                Name = "Jello Mangune",
                Age = 21,
                Occupation = "Student",
                Country = "Philippines"
            });

            contacts.Add(new Contacts
            {
                Name = "Calvin Kent Pamandanan",
                Age = 21,
                Occupation = "Student",
                Country = "Philippines"
            });

            contacts.Add(new Contacts
            {
                Name = "Ron Russelle Bangsil",
                Age = 21,
                Occupation = "Student",
                Country = "Philippines"
            });

            contacts.Add(new Contacts
            {
                Name = "David Aaron Echon",
                Age = 21,
                Occupation = "Student",
                Country = "Philippines"
            });
        }
        
	}
}