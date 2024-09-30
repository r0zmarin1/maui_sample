using System.ComponentModel;

namespace project_otchislenie;

public partial class StudentPage : ContentPage
{
    public List<Student> Students { get; set; }
    private DB DB;

    public StudentPage()
	{
        InitializeComponent();
        Students = new List<Student>();
        Students.Add(new Student
        {
            FirstName = "Мария",
            LastName = "Розина",
            Age = 18
        });
        BindingContext = this;
	}

    private async void AddStudent(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddStudentPage());
    }

    private async void EditStudent(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EditStudentPage());
    }

    private async void DeleteStudent(object sender, EventArgs e)
    {

    }
}