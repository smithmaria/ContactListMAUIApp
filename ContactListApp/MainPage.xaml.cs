namespace ContactListApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var contacts = new List<Contact>
            {
                new Contact { ProfileImage = "pic2.png", Name = "Audrey" },
                new Contact { ProfileImage = "pic1.png", Name = "Connor" },
                new Contact { ProfileImage = "pic3.png", Name = "Alex" },
                new Contact { ProfileImage = "pic4.png", Name = "Tatiana" },
                new Contact { ProfileImage = "pic2.png", Name = "Renee" },
                new Contact { ProfileImage = "pic1.png", Name = "Parker" },
                new Contact { ProfileImage = "pic3.png", Name = "George" },
                new Contact { ProfileImage = "pic2.png", Name = "Olivia" },
                new Contact { ProfileImage = "pic1.png", Name = "Tommy" },
                new Contact { ProfileImage = "pic4.png", Name = "Taylor" },
                new Contact { ProfileImage = "pic2.png", Name = "Caroline" },
                new Contact { ProfileImage = "pic3.png", Name = "Trevor" },
                new Contact { ProfileImage = "pic4.png", Name = "Elaine" },
                new Contact { ProfileImage = "pic2.png", Name = "Lauren" },
                new Contact { ProfileImage = "pic4.png", Name = "Ashley" }
            };

            contactsCltnView.ItemsSource = contacts;
        }

        private void contactsCltnView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Console.WriteLine("New contact selected");
        }
    }
}
