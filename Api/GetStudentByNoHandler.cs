using MediatR;
using TestMediatR.Models;

namespace TestMediatR.Api
{
    public class GetStudentByNoHandler : IRequestHandler<QueryStudentByNo, StudentModel>
    {
        public Task<StudentModel> Handle(QueryStudentByNo request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new StudentModel(request.GetStudNo(), "小明", 18, 100));
        }
    }
}