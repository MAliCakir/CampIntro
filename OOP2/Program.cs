using OOP2;

class Program
{
    private static void Main(string[] args)
    {
        IndividiualCustomer customer1 = new IndividiualCustomer();
        customer1.CustomerNumber = "1";
        customer1.CustomerId = 1;
        customer1.Name = "Mehmet Ali";
        customer1.Surname = "Cakir";
        customer1.IdendityNumber = "1234567890";

        CoorporateCustomer customer2 = new CoorporateCustomer();
        customer2.CustomerNumber = "2";
        customer2.CustomerId = 2;
        customer2.CompanyName = "CakirTech";
        customer2.TaxNumber = "1234567890";

        Customer customer3 = new IndividiualCustomer();
        Customer customer4 = new CoorporateCustomer();

        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(customer1);
        customerManager.Add(customer2);
        customerManager.Add(customer3);
        customerManager.Add(customer4);

        //Customer class keeping other customer ( Coorporaate and 
        //Individiual ) References



    }
}