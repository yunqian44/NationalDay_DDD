﻿using AutoMapper;
using NationalDay_DDD.Application.ViewModel;
using NationalDay_DDD.Domain.Commands;
using NationalDay_DDD.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile:Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            //手动进行配置
            CreateMap<UserViewModel, User>()
             .ForPath(d => d.Address.Province, o => o.MapFrom(s => s.Province))
             .ForPath(d => d.Address.City, o => o.MapFrom(s => s.City))
             .ForPath(d => d.Address.County, o => o.MapFrom(s => s.County))
             .ForPath(d => d.Address.Street, o => o.MapFrom(s => s.Street))
             ;

            ////这里以后会写领域命令，所以不能和DomainToViewModelMappingProfile写在一起。
            ////学生视图模型 -> 添加新学生命令模型
            CreateMap<UserViewModel, RegisterUserCommand>()
                .ConstructUsing(c => new RegisterUserCommand(c.Name, c.Email, c.BirthDate, c.Phone, c.Province, c.City,
            c.County, c.Street));

            ////学生视图模型 -> 更新学生信息命令模型
            //CreateMap<StudentViewModel, UpdateStudentCommand>()
            //    .ConstructUsing(c => new UpdateStudentCommand(c.Id, c.Name, c.Email, c.BirthDate, c.Phone, c.Province, c.City,
            //c.County, c.Street));
        }
    }
}
