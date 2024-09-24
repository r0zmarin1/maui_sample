using System.ComponentModel;

namespace project_otchislenie;

public partial class StudentPage : ContentPage
{
    private StudentDB selectedStudent;
    public event PropertyChangedEventHandler? PropertyChanged;

    public Student Student { get; set; }

    public List<StudentDB> students { get; set; }
    public StudentDB SelectedStudent
    {
        get => selectedStudent;
        set
        {
            selectedStudent = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(selectedStudent)));
        }
    }

    public StudentPage()
	{
		InitializeComponent();
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