﻿using BuberDinner.Application.Common.Errors;
using BuberDinner.Contracts.Authentication;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Application.Services.Authentication;

public interface IAuthenticationService
{
    AuthenticationResult Login(string email , string password);

    Result<AuthenticationResult> Register(string firsName,
    string lastName,
    string email,
    string password);
}
