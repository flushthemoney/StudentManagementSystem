using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Commands;
using StudentManagementSystem.Queries;

namespace StudentManagementSystem.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
    private readonly IMediator _mediator;

    public StudentsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    /// <summary>
    /// Get all students
    /// </summary>
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var students = await _mediator.Send(new GetAllStudentsQuery());
        return Ok(students);
    }

    /// <summary>
    /// Get a student by ID
    /// </summary>
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var student = await _mediator.Send(new GetStudentByIdQuery { Id = id });
        
        if (student == null)
        {
            return NotFound(new { message = $"Student with ID {id} not found" });
        }

        return Ok(student);
    }

    /// <summary>
    /// Create a new student
    /// </summary>
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateStudentCommand command)
    {
        var student = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetById), new { id = student.Id }, student);
    }

    /// <summary>
    /// Update an existing student
    /// </summary>
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] UpdateStudentCommand command)
    {
        if (id != command.Id)
        {
            return BadRequest(new { message = "ID in URL does not match ID in body" });
        }

        var student = await _mediator.Send(command);
        
        if (student == null)
        {
            return NotFound(new { message = $"Student with ID {id} not found" });
        }

        return Ok(student);
    }

    /// <summary>
    /// Delete a student
    /// </summary>
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new DeleteStudentCommand { Id = id });
        
        if (!result)
        {
            return NotFound(new { message = $"Student with ID {id} not found" });
        }

        return NoContent();
    }
}
