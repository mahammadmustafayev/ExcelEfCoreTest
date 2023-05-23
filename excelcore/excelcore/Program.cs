using excelcore.DAL;
using excelcore.Models;
using Ganss.Excel;

namespace excelcore;

internal class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\Users\acer\Desktop\ExcelEfCoreTest\excelcore\excelcore\Files\student.xlsx";
        var studentInfos = new ExcelMapper(path).Fetch<Student>();
        AppDbContext context = new AppDbContext();
        foreach (var student in studentInfos)
        {
            context.Add(student);
            context.SaveChanges();
        }
        
    }
}