using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Core.Models
{
    /// <summary>
    /// 定义领域实体基类接口
    /// </summary>
    public interface IEntity
    {
        Guid Id { get;}
    }
}
