﻿namespace Orange.Shared;

public class EntityBase : IEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
}