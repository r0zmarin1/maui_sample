
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace project_otchislenie
{
    public class DB
    {
        public List<ResignationLetter> ResignationLetter { get; set; }
        public List<Student> Students { get; set; }
        public Student Student { get; set; }

        private int LastStudentId;
        private int LastResignationLetterId;

        public DB()
        {
            Students = new List<Student>();
            Students.Add(new Student
            {
                Id = LastStudentId++,
                FirstName = "Мария",
                LastName = "Розина",
                Age = 18
            });
            ResignationLetter = new List<ResignationLetter>();
            ResignationLetter.Add(new ResignationLetter
            {
                Id = LastResignationLetterId++,
                ReasonId = 1,
                Date = new DateTime(2024, 9, 30, 17, 40, 20),
                Debts = 0,
                StudentId = 1
            });
        }

        public async Task<List<ResignationLetter>> GetListResignationLetter()
        {
            await Task.Delay(100);
            return new List<ResignationLetter>(ResignationLetter);
        }

        public async Task<List<Student>> GetListStudent()
        {
            await Task.Delay(100);
            return new List<Student>(Students);
        }

        public async Task GetResignationLetterById(int id)
        {
            await Task.Delay(100);
            var letter = ResignationLetter.FirstOrDefault(s => s.Id == id);
            ResignationLetter getResignationLetter = new ResignationLetter()
            {
                Id = letter.Id,
                ReasonId = letter.ReasonId,
                Date = letter.Date,
                Debts = letter.Debts
            };

        }

        public async Task<Student> GetStudentById(int id)
        {

            var student = Students.FirstOrDefault(s => s.Id == id);
            await Task.Delay(100);
            if (student == null)
            {
                return null;
            }
            Student getStudent = new Student()
            {
                Id = student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                Age = student.Age
            };


            return getStudent;
        }

        public async Task AddResignationLetter(ResignationLetter resignationLetter)
        {
            await Task.Delay(100);
            ResignationLetter newResignationLetter = new ResignationLetter()
            {
                Id = LastResignationLetterId++,
                ReasonId = resignationLetter.ReasonId,
                Date = resignationLetter.Date,
                Debts = resignationLetter.Debts,

            };
            ResignationLetter.Add(newResignationLetter);
        }

        public async Task AddStudent(Student student)
        {
            await Task.Delay(100);
            Student getStudent = new Student()
            {
                Id = LastStudentId++,
                FirstName = student.FirstName,
                LastName = student.LastName,
                Age = student.Age
            };
            Students.Add(getStudent);
        }

        public async Task EditResignationLetter(ResignationLetter resignationLetter, int id)
        {
            await Task.Delay(100);
            GetResignationLetterById(id);
        }

        public async Task EditStudent(Student student)
        {
            await Task.Delay(100);
            var stu = Students.FirstOrDefault(s => s.Id == student.Id);
            stu.Id = student.Id;
            stu.FirstName = student.FirstName;
            stu.LastName = student.LastName;
            stu.Age = student.Age;
        }

        public async Task DeleteResignationLetterById(ResignationLetter resignationLetter, int id)
        {
            await Task.Delay(100);
            GetResignationLetterById(id);
            ResignationLetter.Remove(resignationLetter);

        }

        public async Task DeleteStudent(Student student)
        {
            await Task.Delay(100);
            var stu = Students.FirstOrDefault(s => s.Id == student.Id);
            if (student.Id == stu.Id)
            {
                Students.Remove(student);
            }
        }

    }
}

