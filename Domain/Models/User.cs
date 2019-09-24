using NationalDay_DDD.Core.Models;
using NationalDay_DDD.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Domain.Model
{
    public partial class User: AggregateRoot<User>
    {
        protected User()
        {

        }

        public User(int id,string name,string email,string phone,DateTime birthday,Address address)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
            Birthday = birthday;
            Address = address;
        }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get;private set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get;private set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; private set; }

        /// <summary>
        /// 生日
        /// </summary>
        public DateTime Birthday { get;private set; }

        /// <summary>
        /// 住址
        /// </summary>
        public Address Address { get;private set; }

    }
}
