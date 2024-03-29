﻿using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Dinner.ValueObjects;
using BuberDinner.Domain.Menu.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Domain.Guest.ValueObjects;

public sealed class UserId : ValueObject
{
    public Guid Value { get; }

    private UserId(Guid value)
    {
        Value = value;
    }

    public static UserId CreateUnique() => new UserId(Guid.NewGuid());
    public static UserId Create(Guid value)
    {
        return new UserId(value);
    }
    public override IEnumerable<object> GetEqualityComponent()
    {
        yield return Value;
    }

#pragma warning disable CS8618
    private UserId()
    {

    }
#pragma warning restore CS8618
}