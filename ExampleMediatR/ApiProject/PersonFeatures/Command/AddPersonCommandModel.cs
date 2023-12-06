using MediatR;

namespace ApiProject.PersonFeatures.Command
{
    public class AddPersonCommandModel :IRequest<Guid>
    {
     public string Name { get; set; }
    public string Family { get; set; }
    public string NationalCode { get; set; }
    public string MobileNumber { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string RepeatPassword { get; set; }
}
    
}
