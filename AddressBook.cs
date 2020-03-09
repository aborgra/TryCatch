using System.Collections.Generic;

namespace TryCatch {
  public class AddressBook {
    public Dictionary<string, Contact> Contacts { get; set; }

    public void AddContact (Contact name) {
      Contacts.Add (name.Email, name);
    }
  }
}