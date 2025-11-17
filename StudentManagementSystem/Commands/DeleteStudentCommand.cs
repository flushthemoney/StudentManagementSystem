using MediatR;

namespace StudentManagementSystem.Commands;

public class DeleteStudentCommand : IRequest<bool>
{
    public int Id { get; set; }
}
