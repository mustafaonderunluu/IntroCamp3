
using Intro_Camp.Business;
using Intro_Camp.Entity;

Course course1= new Course();
course1.Name = "C# ";
course1.Description = ".Net 8";
course1.Id = 1;
course1.Price = 122.1;

Course course2 = new Course();
course2.Name = "Java ";
course2.Description = "  ";
course2.Id = 2;
course2.Price = 128.1;

Course course3 = new Course();
course3.Name = "php ";
course3.Description = " ";
course3.Id = 3;
course3.Price = 130.1;

//course[] courses = { course1, course2, course3 };
//for (int i = 0; i < courses.length; i++)
//{
//    console.writeline(courses[i].name + "/ " + courses[i].price);
//}


//coursemanager coursemanager = new coursemanager();
//course[] courses2 = coursemanager.getall();
//for (int i = 0; i < courses2.length; i++)
//{

//    console.writeline(courses2[i].ıd);

//}
IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "15616161";
customer1.FirstName = "Önder";
customer1.LastName = "ünlü";
customer1.CustomerNumber =" 123456";


IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "156";
customer2.FirstName = "Özgür";
customer2.LastName = "atılgan";
customer2.CustomerNumber = " 1234567";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.TaxNumber = "123456789";
customer3.Name = "kodlamaio";
customer3.CustomerNumber = " 123";


CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.TaxNumber = "97884984984";
customer4.Name = "udemy";
customer4.CustomerNumber = " 5478";

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

//polymorphism

foreach (BaseCustomer customer in customers) {
    


    Console.WriteLine(customer.CustomerNumber);
} 