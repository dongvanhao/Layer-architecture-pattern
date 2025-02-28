using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private static List<Student> students = new List<Student>();

        public List<Student> GetAllStudents() => students;

        public Student GetStudentbyId(int id) => students.FirstOrDefault(s => s.Id == id);

        public void AddStudent(Student student) => students.Add(student);

        
    }
}
