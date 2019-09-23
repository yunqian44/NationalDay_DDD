﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Domain.Model
{
    public partial class User
    {
        protected User()
        {

        }

        public User(int id,string name)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public int Id { get;private set; }

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
        public string Address { get;private set; }

    }
}
