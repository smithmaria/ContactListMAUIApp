namespace ContactListApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var contacts = new List<Contact>
            {
new Contact { ProfileImage = "pic2.png", Name = "Audrey Bennett", Email = "audrey@email.com", Phone = "555-201-3456", Description = "Childhood friend" },
new Contact { ProfileImage = "pic1.png", Name = "Connor Walsh", Email = "connor@email.com", Phone = "555-302-4567", Description = "Work colleague" },
new Contact { ProfileImage = "pic3.png", Name = "Alex Rivera", Email = "alex@email.com", Phone = "555-403-5678", Description = "Gym buddy" },
new Contact { ProfileImage = "pic4.png", Name = "Tatiana Volkov", Email = "tatiana@email.com", Phone = "555-504-6789", Description = "Neighbor" },
new Contact { ProfileImage = "pic2.png", Name = "Renee Fontaine", Email = "renee@email.com", Phone = "555-605-7890", Description = "College roommate" },
new Contact { ProfileImage = "pic1.png", Name = "Parker Holloway", Email = "parker@email.com", Phone = "555-706-8901", Description = "Family friend" },
new Contact { ProfileImage = "pic3.png", Name = "George Malone", Email = "george@email.com", Phone = "555-807-9012", Description = "Book club member" },
new Contact { ProfileImage = "pic2.png", Name = "Olivia Chen", Email = "olivia@email.com", Phone = "555-908-0123", Description = "Coworker" },
new Contact { ProfileImage = "pic1.png", Name = "Tommy Briggs", Email = "tommy@email.com", Phone = "555-109-1234", Description = "High school friend" },
new Contact { ProfileImage = "pic4.png", Name = "Taylor Sinclair", Email = "taylor@email.com", Phone = "555-210-2345", Description = "Yoga classmate" },
new Contact { ProfileImage = "pic2.png", Name = "Caroline Moore", Email = "caroline@email.com", Phone = "555-311-3456", Description = "Sister" },
new Contact { ProfileImage = "pic3.png", Name = "Trevor Nash", Email = "trevor@email.com", Phone = "555-412-4567", Description = "Tennis partner" },
new Contact { ProfileImage = "pic4.png", Name = "Elaine Marsh", Email = "elaine@email.com", Phone = "555-513-5678", Description = "Mentor" },
new Contact { ProfileImage = "pic2.png", Name = "Lauren Calloway", Email = "lauren@email.com", Phone = "555-614-6789", Description = "Cousin" },
new Contact { ProfileImage = "pic4.png", Name = "Ashley Tran", Email = "ashley@email.com", Phone = "555-715-7890", Description = "Best friend" }
            };

            contactsCltnView.ItemsSource = contacts;
        }

        private async void contactsCltnView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = e.CurrentSelection.FirstOrDefault() as Contact;
            if (selected == null) return;

            contactsCltnView.SelectedItem = null;

            await Navigation.PushAsync(new ContactDetailPage(selected));
        }
    }
}
