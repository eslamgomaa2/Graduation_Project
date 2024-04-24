﻿using Microsoft.AspNetCore.Identity;
using OA.Domain.Enum;

public static class DefaultRoles
{
    public static List<IdentityRole> MyRole { get;  } = new()
    {
        new () {
            Id = "1",
            Name = Roles.Admin.ToString(),
            NormalizedName = Roles.Admin.ToString().ToUpper()
        },
        new ()
        {
            Id ="2",
            Name = Roles.Patient.ToString(),
            NormalizedName = Roles.Patient.ToString().ToUpper()
        },
        new ()
        {
            Id = "3",
            Name = Roles.Doctor.ToString(),
            NormalizedName = Roles.Doctor.ToString().ToUpper()
        }

    };
  
}
