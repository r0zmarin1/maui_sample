
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_otchislenie
{
    public class DB
    {
        private List<ResignationLetter> resignationLetter {  get; set; }
        private List<Student> Students { get; set; }

        public async Task<List<ResignationLetter>> GetListResignationLetter()
        {
            await Task.Delay(100);
            return new List<ResignationLetter>(resignationLetter);
        }

        public async Task<List<Student>> GetListStudent()
        {
            await Task.Delay(100);
            return new List<Student>(Students);
        }

        public void GetResignationLetterById()
        {

        }
        public void GetStudentById()
        {
          
        }

        public void AddResignationLetter() { }

        public async Task AddStudent(Student student)
        {        
            await Task.Delay(100);
            Students.Add(student);
        }

        public void EditResignationLetter() { }

        public void EditStudent() { }

        public void DeleteResignationLetterById() { }

        public void DeleteStudent() { }

    }
}
