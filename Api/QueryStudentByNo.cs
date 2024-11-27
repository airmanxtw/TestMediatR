using MediatR;
using TestMediatR.Models;

namespace TestMediatR.Api;

public class QueryStudentByNo(string StudNo) : IRequest<StudentModel>
{
    public string GetStudNo()
    {
        return StudNo;
    }
}