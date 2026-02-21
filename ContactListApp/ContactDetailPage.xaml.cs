using System.Threading.Tasks;

namespace ContactListApp;

public partial class ContactDetailPage : ContentPage
{
	public ContactDetailPage(Contact contact)
	{
		InitializeComponent();

		imgContact.Source = contact.ProfileImage;
		lblName.Text = contact.Name;
		lblEmail.Text = contact.Email;
		lblPhone.Text = contact.Phone;
		lblDescription.Text = contact.Description;
	}

    private async void btnReturn_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}