using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class StudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public List<Student> GetAllStudents() => _studentRepository.GetAllStudents();
        public Student GetStudentbyId(int id) => _studentRepository.GetStudentbyId(id);
        public void AddStudent(Student student) => _studentRepository.AddStudent(student);

    }
}
