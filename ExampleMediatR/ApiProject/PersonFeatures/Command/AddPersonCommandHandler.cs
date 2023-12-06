﻿using ApiProject.Models;
using ExampleMediatR.Context;
using MediatR;

namespace ApiProject.PersonFeatures.Command
{
    public class AddPersonCommandHandler : IRequestHandler<AddPersonCommandModel, Guid>
    {
        private readonly IApplicationContext _context;
        public AddPersonCommandHandler(IApplicationContext context)
        {
            _context = context;
        }
        public async Task<Guid> Handle(AddPersonCommandModel request, CancellationToken cancellationToken)
        {
            var person = new Person
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Email = request.Email,
                Family = request.Family,
                MobileNumber = request.MobileNumber,
                NationalCode = request.NationalCode,
                Password = request.Password
            };
           _context.Persons.Add(person);
            await _context.SaveChangesAsync();
            return person.Id;
        }
    }
   
}
