using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using NationalDay_DDD.Application.Implements;
using NationalDay_DDD.Application.Interface;
using NationalDay_DDD.Core.Bus;
using NationalDay_DDD.Domain.CommandHandlers;
using NationalDay_DDD.Domain.Commands;
using NationalDay_DDD.Domain.Interface;
using NationalDay_DDD.Infrastruct.Bus;
using NationalDay_DDD.Infrastruct.Data.Context;
using NationalDay_DDD.Infrastruct.UoW;
using NationalDay_DDD.Repository.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NationalDay_DDD.WebApp.Extensions
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {

            // ASP.NET HttpContext dependency
            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            // ASP.NET Authorization Polices
            //services.AddSingleton<IAuthorizationHandler, ClaimsRequirementHandler>();

            // 注入 应用层Application
            services.AddScoped<IUserService, UserService>();



            // 命令总线Domain Bus (Mediator)
            services.AddScoped<IMediatorHandler, InMemoryBus>();


            // Domain - Events
            // 将事件模型和事件处理程序匹配注入

            // 领域通知
            //services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();
            // 领域事件
            //services.AddScoped<INotificationHandler<StudentRegisteredEvent>, StudentEventHandler>();
            //services.AddScoped<INotificationHandler<StudentUpdatedEvent>, StudentEventHandler>();
            //services.AddScoped<INotificationHandler<StudentRemovedEvent>, StudentEventHandler>();


            // 领域层 - 领域命令
            // 将命令模型和命令处理程序匹配
            services.AddScoped<IRequestHandler<RegisterUserCommand, Unit>, UserCommandHandler>();
            //services.AddScoped<IRequestHandler<UpdateStudentCommand, Unit>, StudentCommandHandler>();
            //services.AddScoped<IRequestHandler<RemoveStudentCommand, Unit>, StudentCommandHandler>();

            // 领域层 - Memory
            services.AddSingleton<IMemoryCache>(factory =>
            {
                var cache = new MemoryCache(new MemoryCacheOptions());
                return cache;
            });



            // 注入 基础设施层 - 数据层
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<UserContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();


            // 注入 基础设施层 - 事件溯源
            //services.AddScoped<IEventStoreRepository, EventStoreSQLRepository>();
            //services.AddScoped<IEventStoreService, SqlEventStoreService>();
            //services.AddScoped<EventStoreSQLContext>();

            // 注入 基础设施层 - Identity Services
            //services.AddTransient<IEmailSender, AuthEmailMessageSender>();
            //services.AddTransient<ISmsSender, AuthSMSMessageSender>();

            // 注入 基础设施层 - Identity
            //services.AddScoped<IUser, AspNetUser>();
        }
    }
}
