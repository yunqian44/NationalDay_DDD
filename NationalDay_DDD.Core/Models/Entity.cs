using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Core.Models
{
    /// <summary>
    /// 定义领域实体基类
    /// </summary>
    public class Entity:IEntity
    {
        public int Id { get ;private set; }
    }
}
