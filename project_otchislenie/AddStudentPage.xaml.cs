using System.Collections.ObjectModel;
using System.ComponentModel;

namespace project_otchislenie;

public partial class AddStudentPage : ContentPage
{
    private Student Students;
    private DB DB;

    //public event PropertyChangedEventHandler? PropertyChanged;

    //public Student SelectedStudents
    //{
    //    get => selectedStudents;
    //    set
    //    {
    //        selectedStudents = value;
    //        //PropertyChanged?.Invoke(this,
    //        //    new PropertyChangedEventArgs(nameof(SelectedStudents)));
    //    }
    //}
    public AddStudentPage()
	{
		InitializeComponent();
        BindingContext = this;
    }

    public async Task Save(Student student)
    {
       await Task.Delay(1000);
       DB.AddStudent(student);
        //PropertyChanged?.Invoke(this,
        //        new PropertyChangedEventArgs(nameof(SelectedStudents)));
    }
}
