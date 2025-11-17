using MediatR;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Queries;

public class GetStudentByIdQuery : IRequest<Student?>
{
    public int Id { get; set; }
}
