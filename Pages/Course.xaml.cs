namespace finaldeneme.Pages;

public partial class Course : ContentPage
{
	public Course()
	{
		InitializeComponent();
        Course_List_View.ItemsSource= App.DBTrans.GetAllCourseClasses();

    }

    private void Add_crs_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.Add_Crs(new Models.CourseClass
        {
            Course_Name=Course_name.Text,
            Course_Code=Course_code.Text,

        });

    }

    private void Show_crs_Clicked(object sender, EventArgs e)
    {
        Course_List_View.ItemsSource = App.DBTrans.GetAllCourseClasses();


    }

    private void Delete_crs_Clicked(object sender, EventArgs e)
    {
        Button button= (Button)sender;
        App.DBTrans.Delete_Crs((int)button.BindingContext);
        Course_List_View.ItemsSource = App.DBTrans.GetAllCourseClasses();


    }
}