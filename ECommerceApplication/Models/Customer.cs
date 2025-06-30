namespace ECommerceApplication.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public DateTime DOB { get; set; }

        public Customer()
        {
            CustomerId = 0;
            Name = "";
            PhoneNo = "";
            Email = "";
            Password = "";
            City = "";
            DOB = new DateTime();
        }

        public Customer(int id, string n, string phno, string e, string pass, string city, DateTime date)
        {
            CustomerId = id;
            Name = n;
            PhoneNo = phno;
            Email = e;
            Password = pass;
            City = city;
            DOB = date;
        }
    }
    
}