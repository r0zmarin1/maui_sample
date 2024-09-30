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
        BindingContext = this;
    }

    private async void SaveStudent(object sender, EventArgs e)
    {
        //await Task.Delay(1000);
        await DB.AddStudent(Student);
    }
}
