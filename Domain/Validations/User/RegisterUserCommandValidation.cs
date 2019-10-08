using NationalDay_DDD.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Domain.Validations.User
{
    /// <summary>
    /// 添加用户命令模型验证
    /// 继承 UserValidation 基类
    /// </summary>
    public class RegisterUserCommandValidation : UserValidation<RegisterUserCommand>
    {
        public RegisterUserCommandValidation()
        {
            ValidateName();//验证姓名
            ValidateBirthDate();//验证年龄
            ValidateEmail();//验证邮箱
            ValidatePhone();//验证手机号
            //可以自定义增加新的验证
        }
    }
}
