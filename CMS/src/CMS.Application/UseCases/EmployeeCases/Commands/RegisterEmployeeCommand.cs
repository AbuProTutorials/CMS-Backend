﻿using CMS.Domain.Entities.Enums;
using CMS.Domain.Entities;
using CMS.Domain.Entities.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Application.UseCases.EmployeeCases.Commands
{
    public class RegisterEmployeeCommand:IRequest<ResponseModel>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public CustomeDate BirthDate { get; set; }
        public Location Location { get; set; }
        public Gender Gender { get; set; }
        public IFormFile Photo { get; set; }
        public IFormFile PDF { get; set; }
    }
}
