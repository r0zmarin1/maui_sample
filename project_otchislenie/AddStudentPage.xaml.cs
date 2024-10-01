using System.Collections.ObjectModel;
using System.ComponentModel;

namespace project_otchislenie;

public partial class AddStudentPage : ContentPage
{
    public Student Student { get; set; }

    private DB DB;


    public AddStudentPage()
	{
		InitializeComponent();
        DB = new DB();
        Student = new Student();
        BindingContext = this;
        
        //.ValueChanged += AgeChanged;
    }

    private async void SaveStudent(object sender, EventArgs e)
    {
        await DB.AddStudent(Student);
        OnPropertyChanged(nameof(Student));
    }

    private void AgeChanged(object sender, ValueChangedEventArgs e)
    {
        OnPropertyChanged(nameof(Student));
    }
}
