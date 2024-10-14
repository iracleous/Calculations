using Calculations.Dtos;
using Calculations.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Services;

public class StudentService : IStudentService
{
    private readonly EshopDbContext _context;

    public StudentService(EshopDbContext context)
    {
        _context = context;
    }


    //Create Read Update Delete
    //Insert Select Update Delete
    public async Task<Student> CreateStudentAsync(StudentDto student)
    {
        if (student == null)
            throw new ArgumentNullException(nameof(student));

        Student studentForDb = new Student
        {
            Id = 0,
            Name = student.Name,
            Email = student.Email,
            Created = DateTime.Now
        };
        _context.Students.Add(studentForDb);
        await _context.SaveChangesAsync();
        return studentForDb;
    }

    public Task<bool> DeleteStudentAsync(Student student)
    {
        throw new NotImplementedException();
    }

    public Task<Student> GetStudentAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Student>> GetStudentsAsync()
    {
       return  await _context
            .Students
            .ToListAsync();
    }

    public async Task<List<Student>> GetStudentsAsync(int page, int pageSize)
    {
        return await _context
            .Students
            .Skip((page-1)*pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<List<Student>> GetStudentsAsync(string startingNameWith)
    {
        return await _context
            .Students
            .Where(student => student.Name.StartsWith (startingNameWith))
            .ToListAsync();
    }


    public Task<Student> UpdateStudentAsync(Student student)
    {
        throw new NotImplementedException();
    }
}
