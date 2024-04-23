namespace DemoLibrary
{
   public class AddressModel
   {
      public string StreetAddress { get; set; }
      public string City { get; set; }
      public string State { get; set; }
      public string ZipCode { get; set; }

      // We can use lamda expression instead of full property
      public string AddressDisplayValue => $"{StreetAddress}, {City}, {State}  {ZipCode}";

      //public string AddressDisplayValue
      //{
      //   get { return $"{StreetAddress}, {City}, {State}  {ZipCode}"; }

      //}

   }
}
