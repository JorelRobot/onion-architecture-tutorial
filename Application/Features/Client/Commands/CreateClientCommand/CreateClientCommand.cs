﻿using Application.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Client.Commands.CreateClientCommand
{
    public class CreateClientCommand : IRequest<Response<int>>
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }

    public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, Response<int>>
    {
        public Task<Response<int>> Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
