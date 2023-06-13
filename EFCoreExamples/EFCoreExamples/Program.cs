// See https://aka.ms/new-console-template for more information

using EFCoreExamples.Database;
using EFCoreExamples.EntityModels;

Category aCategory = new Category()
{
    Name = "Electronics",
    Description ="This is a Electronics category"
};

ApplicationDbContext db = new ApplicationDbContext();

db.Categories.Add(aCategory);

int successCount = db.SaveChanges();

if (successCount > 0)
{
    Console.WriteLine("Successful operation!");

}




