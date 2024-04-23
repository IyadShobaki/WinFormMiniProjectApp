namespace DemoLibrary
{
   // Tim created this so we don't have to be tie to PersonEntry class/Form
   // and we can use the method for any class/Form needs an address
   // For example we can use this interface with Company Entry which needs address entry as well
   // Common functionality example
   public interface ISaveAddress
   {

      void SaveAddress(AddressModel address);
   }
}
