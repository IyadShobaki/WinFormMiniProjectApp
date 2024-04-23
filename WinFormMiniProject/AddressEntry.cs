using DemoLibrary;
using System.Windows.Forms;

namespace WinFormMiniProject
{
   public partial class AddressEntry : Form
   {
      ISaveAddress _parent; // long term variable
                            // that lasts the length of the class instance
      public AddressEntry(ISaveAddress parent)
      {
         InitializeComponent();

         _parent = parent;
      }

      private void saveAddressButton_Click(object sender, System.EventArgs e)
      {
         AddressModel address = new AddressModel
         {
            StreetAddress = streetAddressText.Text,
            City = cityText.Text,
            State = stateText.Text,
            ZipCode = zipCodeText.Text
         };

         _parent.SaveAddress(address);

         this.Close();
      }
   }
}
