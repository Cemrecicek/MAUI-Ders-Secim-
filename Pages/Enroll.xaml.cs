using finaldeneme.Models;
namespace finaldeneme.Pages;

public partial class Enroll : ContentPage
{
	public Enroll()
	{
		InitializeComponent();
        StudentId_List_View.ItemsSource = App.DBTrans.GetAllStudentClasses();
        CourseId_List_View.ItemsSource=App.DBTrans.GetAllCourseClasses();
        Enroll_List_View.ItemsSource=App.DBTrans.GetAllEnrollClasses();

    }



    private void Add_en_Clicked(object sender, EventArgs e)
    {
        var student = StudentId_List_View.SelectedItem as StudentClass;
        var course = CourseId_List_View.SelectedItem as CourseClass;

        if(student != null && course != null )
        {
            var enroll = new EnrollClass
            {
                StudentID=student.ID,
                CourseCode=course.Course_Code,
            };
            App.DBTrans.Add_En(enroll);
            
            
        }
        else
        {
            DisplayAlert("Error","select both","ok");
        }

        StudentId_List_View.SelectedItem = null;
        CourseId_List_View.SelectedItem = null;

    }

    private void Show_en_Clicked(object sender, EventArgs e)
    {
        StudentId_List_View.ItemsSource = App.DBTrans.GetAllStudentClasses();
        CourseId_List_View.ItemsSource = App.DBTrans.GetAllCourseClasses();
        Enroll_List_View.ItemsSource = App.DBTrans.GetAllEnrollClasses();

    }

    private void Delete_en_Clicked(object sender, EventArgs e)
    {
        Button button= (Button)sender;
        App.DBTrans.Delete_En((int)button.BindingContext);
        Enroll_List_View.ItemsSource=App.DBTrans.GetAllEnrollClasses();
    }
}