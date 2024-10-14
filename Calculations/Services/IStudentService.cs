using Calculations.Dtos;
using Calculations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Services;

public interface IStudentService
{
    Task<Student> CreateStudentAsync(StudentDto student);
    Task<Student> UpdateStudentAsync(Student student);
    Task<bool> DeleteStudentAsync(Student student);
    Task<Student> GetStudentAsync(int id);
    Task<List<Student>> GetStudentsAsync();

    Task<List<Student>> GetStudentsAsync(int page, int pageSize);
    Task<List<Student>> GetStudentsAsync(string startingNameWith);
}
