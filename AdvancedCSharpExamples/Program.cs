// See https://aka.ms/new-console-template for more information

using InheritanceExamples;
using System.Dynamic;

int number = 0;

var name = "Text";

var person = new Person()
{
    FirstName = "Mr. A",
    MiddleName = "Middle Name",
    LastName = "Last Name"

};


Person[] personList = new Person[]
{
    person,
    new Person(){FirstName ="Mr. Akram", LastName="Hossain"}
};


//Anonymous Type
var products =  new[]{

    new {Name = "Hp Laptop", ProductNo = "HP92398",  Price = 23832 },
     new {Name = "Hp Monitor", ProductNo = "HP92398",  Price = 23832 }

};


//dynamic

dynamic productObj = products;

 

string productInfo = GetProductInfo(productObj);
//string productInfo = $"Product No{product.ProductNo} Name: {product.Name} Price: {product.Price}";

Console.WriteLine(productInfo);

static string GetProductInfo(IEnumerable<dynamic> products)
{
    string productInfo = "";
    foreach (var product in products)
    {
        productInfo +=  $"Product No{product.ProductNo} Name: {product.Name} Price: {product.Price}" + Environment.NewLine;
    }
    
    return productInfo; 
}


dynamic expandableObject = new ExpandoObject();

expandableObject.Manufacturer = "Toyota";





