using ApiProject.Models;
using MediatR;

namespace ApiProject.PersonFeatures.Queries
{
    public class GetAllPersonQueryModel  : IRequest<List<Person>>
    {
    public string Name { get; set; }
    public string Family { get; set; }
    public string NationalCode { get; set; }
    public string MobileNumber { get; set; }
    public string Email { get; set; }
}
    
}
