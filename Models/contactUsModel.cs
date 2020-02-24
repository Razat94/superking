using System;
using System.Collections.Generic; // Used for List type
using Newtonsoft.Json; // Newtonsoft JSON package.
using System.IO; // Used to input/output file contents

namespace contactUs.Models
{
  public class contactUsModel {
      public string fullName { get; set; }
      public string email { get; set; }
      public string phone { get; set; }
      public string subject { get; set; }
      public string message { get; set; }

      public contactUsModel() {
        fullName = "blank";
        email = "blankkkk";
        phone = "";
        subject = "";
        message = "";
      }
  }
}