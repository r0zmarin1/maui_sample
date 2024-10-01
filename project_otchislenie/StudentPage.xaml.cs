using System.ComponentModel;

namespace project_otchislenie;

public partial class StudentPage : ContentPage, INotifyPropertyChanged
{
    public List<Student> Students { get; set; }
    private DB DB;
    bool loaded = false;

    public event PropertyChangedEventHandler? PropertyChanged;

    public StudentPage()
	{
        InitializeComponent();
        DB = new DB();
        GetData();
        BindingContext = this; 
        
	}

    protected override void OnAppearing()
    {
        if (loaded == false)
        {
            GetData();
            loaded = true;
        }
        
    }

    private async void GetData()
    {
        Students = await DB.GetListStudent();
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Students)));
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