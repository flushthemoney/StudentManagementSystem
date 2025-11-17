using MediatR;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Queries;

public class GetAllStudentsQuery : IRequest<IEnumerable<Student>>
{
}
