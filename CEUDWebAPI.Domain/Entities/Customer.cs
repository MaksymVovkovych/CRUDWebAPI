﻿namespace CEUDWebAPI.Domain.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
    }
}
