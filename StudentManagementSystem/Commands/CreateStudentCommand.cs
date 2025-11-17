using MediatR;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Commands;

public class CreateStudentCommand : IRequest<Student>
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public string Major { get; set; } = string.Empty;
}