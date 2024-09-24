using System.Collections.Specialized;
using System.ComponentModel;

namespace project_otchislenie
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        private StudentDB selectedStudent;
        public event PropertyChangedEventHandler? PropertyChanged;

        public List <StudentDB> students {  get; set; }
        public StudentDB SelectedStudent
        {
            get => selectedStudent;
            set
            {
                selectedStudent = value;    
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(selectedStudent)));
            }
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OpenListStudent(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StudentPage());
        }
    }

}
