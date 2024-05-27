
namespace finaldeneme.Pages;

public partial class Student : ContentPage
{
	public Student()
	{
		InitializeComponent();
        Student_List_View.ItemsSource = App.DBTrans.GetAllStudentClasses();

    }

    private void Add_st_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.Add_St(new Models.StudentClass
        {
            Name=Name.Text,
            Department=Dept.Text,
        });


    }

    private void Show_st_Clicked(object sender, EventArgs e)
    {
        Student_List_View.ItemsSource = App.DBTrans.GetAllStudentClasses();


    }

    private void Delete_st_Clicked(object sender, EventArgs e)
    {
        Button button=(Button)sender;
        App.DBTrans.Delete_St((int)button.BindingContext);
        Student_List_View.ItemsSource=App.DBTrans.GetAllStudentClasses();
    }
}