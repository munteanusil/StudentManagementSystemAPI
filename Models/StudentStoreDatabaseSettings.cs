
namespace StudentManagement.Models
{
    public class StudentStoreDatabaseSettings : IStudentStoreDatabaseSettings
    {
        string StudentCoursesCollectionName { get; set; } = String.Empty;
        string IStudentStoreDatabaseSettings.StudentCoursesCollectionName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string ConnectionString { get; set; } = String.Empty;
        string IStudentStoreDatabaseSettings.ConnectionString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string DatabaseName { get; set; } = String.Empty;
        string IStudentStoreDatabaseSettings.DatabaseName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
