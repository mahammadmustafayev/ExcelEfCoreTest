

using Ganss.Excel;

namespace excelcore.Models;

internal class Student
{
    [Column("Id",MappingDirections.ExcelToObject)]
    public int Id { get; set; }
    [Column("FirstName",MappingDirections.ExcelToObject)]
    public string Name { get; set; }
    [Column("LastName",MappingDirections.ExcelToObject)]
    public string Surname { get; set; }
}
