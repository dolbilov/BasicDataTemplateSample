using System.Collections.Generic;
using BasicDataTemplateSample.Models;

namespace BasicDataTemplateSample.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public List<Person> People { get; } = new()
    {
        new Teacher
        {
            FirstName = "Mr.",
            LastName = "X",
            Age = 55,
            Sex = Sex.Diverse,
            Subject = "Math"
        },
        new Student
        {
            FirstName = "Natasha",
            LastName = "Romanoff",
            Age = 40,
            Sex = Sex.Female,
            Grade = 8
        },
        new Student
        {
            FirstName = "Tony",
            LastName = "Stark",
            Age = 53,
            Sex = Sex.Male,
            Grade = 10
        }
    };
}