using DemoLibrary;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;


namespace WinFormMiniProject
{
   public partial class PersonEntry : Form, ISaveAddress
   {

      BindingList<AddressModel> addresses = new BindingList<AddressModel>();

      public PersonEntry()
      {
         InitializeComponent();

         //addresses.Add(new AddressModel
         //{
         //   StreetAddress = "123 State Street",
         //   City = "Scranton",
         //   State = "PA",
         //   ZipCode = "18841"
         //});

         addressListBox.DataSource = addresses;
         addressListBox.DisplayMember = nameof(AddressModel.AddressDisplayValue);
      }

      private void addNewAddressButton_Click(object sender, System.EventArgs e)
      {
         // Open the Address Entry Form
         AddressEntry entry = new AddressEntry(this);
         entry.Show();

      }

      public void SaveAddress(AddressModel address)
      {
         addresses.Add(address);
      }

      private void saveRecordButton_Click(object sender, System.EventArgs e)
      {
         PersonModel person = new PersonModel
         {
            FirstName = firstNameText.Text,
            LastName = lastNameText.Text,
            IsActive = isActiveChBox.Checked,
            Addresses = addresses.ToList()
         };

      }
   }
}
