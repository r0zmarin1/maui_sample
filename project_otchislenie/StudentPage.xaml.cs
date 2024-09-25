using System.ComponentModel;

namespace project_otchislenie;

public partial class StudentPage : ContentPage
{
    private Student selectedStudents;
    public event PropertyChangedEventHandler? PropertyChanged;

    public List<Student> Students { get; set; }

    public Student SelectedStudents
    {
        get => selectedStudents;
        set
        {
            selectedStudents = value;
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(nameof(SelectedStudents)));
        }
    }

    public StudentPage()
	{
		InitializeComponent();
        BindingContext = this;
        //SelectedStudents = selectedStudents;
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