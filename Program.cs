using Addressbook.Models;
using Addressbook.Services;

var contact = new Contact
{
    FirstName = "Jojje",
    LastName = "Lundgren",
    Phone = 0729783326,
    Email = "jojje@live.com",
    Address = "Bollbrogatan 6"
};

var contactService = new ContactService();
contactService.AddContactToList(contact);
