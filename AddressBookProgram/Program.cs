using AddressBookProgram;
Console.WriteLine("Welcome to Address Book Program");
Contact contact = new Contact(){
    FirstName = "Pramod",
    LastName = "Shendage",
    Address = "Kalamboli",
    City = "Navi Mumbai",
    State = "Maharastra",
    Zip = 410218,
    PhoneNumber = "9892033294",
    Email = "shendagepramod@gmail.com"
};
Console.WriteLine("FirstName: " + contact.FirstName + "\n" + "LastName: " + contact.LastName + "\n" + "Address: " + contact.Address + "\n" + "City: " + contact.City + "\n" + "State: " + contact.State + "\n" + "Zip: " + contact.Zip + "\n" + "PhoneNumber: " + contact.PhoneNumber + "\n" + "Email: " + contact.Email);