﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Application.Interface
{
    public interface IApplicationService<T> where T:class,new()
    {
        /// <summary>
        /// 获取全部数据
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// 获取单个数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(int id);

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="StudentViewModel"></param>
        void Update(T StudentViewModel);

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="id"></param>
        void Remove(int id);

        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IEnumerable<T> GetAllHistory(int id);
    }
}
