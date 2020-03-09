using System.Collections.Generic;
using System.Linq;

namespace TryCatch {
  public class AddressBook {
    public Dictionary<string, Contact> Contacts = new Dictionary<string, Contact> ();

    public void AddContact (Contact contact) {
      Contacts.Add (contact.Email, contact);
    }

    public Contact GetByEmail (string email) {
      var foundContact = Contacts.FirstOrDefault (contact => contact.Key == email);
      return foundContact.Value;
    }
  }
}