using Calculations.Dtos;
using Calculations.Models;
using Calculations.Services;

EshopDbContext eshopDbContext = new EshopDbContext();

IStudentService service = new StudentService(eshopDbContext);

StudentDto student = new StudentDto
{
 
    Name = "Test", Email= "an@fiat.it"
};

await service.CreateStudentAsync(student);

var students = await service.GetStudentsAsync(1, 3);

students.ForEach(student => 
Console.WriteLine($"student name = {student.Name} student id = {student.Id}"));


