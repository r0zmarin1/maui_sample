using System.ComponentModel;

namespace project_otchislenie;

public partial class StudentPage : ContentPage
{
    private StudentDB selectedStudent;
    public event PropertyChangedEventHandler? PropertyChanged;

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

    private void AddStudent(object sender, EventArgs e)
    {

    }

    private void EditStudent(object sender, EventArgs e)
    {

    }

    private void DeleteStudent(object sender, EventArgs e)
    {

    }
}