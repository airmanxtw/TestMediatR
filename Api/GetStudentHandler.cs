using MediatR;
using TestMediatR.Models;

namespace TestMediatR.Api;
public class GetStudentHandler : IRequestHandler<QueryStudent, List<StudentModel>>
{
    public Task<List<StudentModel>> Handle(QueryStudent request, CancellationToken cancellationToken)
    {
        var students = new List<StudentModel>
        {
            new("1", "John Doe", 20, 90),
            new("2", "Jane Doe", 21, 95),
            new("3", "John Smith", 22, 85),
            new("4", "Jane Smith", 23, 80),
        };
        return Task.FromResult(students);
    }
}