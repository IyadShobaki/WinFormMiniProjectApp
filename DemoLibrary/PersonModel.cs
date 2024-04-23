﻿using System.Collections.Generic;

namespace DemoLibrary
{
   public class PersonModel
   {
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public bool IsActive { get; set; }

      public List<AddressModel> Addresses { get; set; }
   }
}
