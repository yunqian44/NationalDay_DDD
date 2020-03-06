using NationalDay_DDD.Core.Models;
using NationalDay_DDD.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Domain.Model
{
    public partial class User: AggregateRoot<User>
    {
        public User()
        {

        }

        public User(string name,string email,string phone,DateTime birthday,Address contactAddress, Address deliveryAddress)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Birthday = birthday;
            ContactAddress = contactAddress;
            DeliveryAddress = deliveryAddress;
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


        //用户的联系地址
        public Address ContactAddress { get; private set; }

        //用户的发货地址
        public Address DeliveryAddress { get; set; }

    }
}
