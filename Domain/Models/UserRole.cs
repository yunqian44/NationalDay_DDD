using NationalDay_DDD.Core.Models;
using NationalDay_DDD.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Domain.Models
{
    public class UserRole : AggregateRoot<UserRole>
    {
        public Guid UserId { get; set; }

        public Guid RoleId { get; set; }

        public static UserRole CreateUserRole(User user, Role role)
        {
            return new UserRole() { UserId = user.Id, RoleId = role.Id };
        }
    }
}
