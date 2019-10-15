using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using NationalDay_DDD.Application.Interface;
using NationalDay_DDD.Application.ViewModel;
using NationalDay_DDD.Core.Notifications;
using NationalDay_DDD.Domain.Commands;
using System.Collections.Generic;

namespace NationalDay_DDD.WebApp.Controllers
{
    public class UserController : Controller
    {
        //
        private readonly IUserService _userService;

        private IMemoryCache _cache;

          // 将领域通知处理程序注入Controller
        private readonly DomainNotificationHandler _notifications;

        public UserController(IUserService userService,
            IMemoryCache cache, 
            INotificationHandler<DomainNotification> notifications)
        {
            _userService = userService;
            _cache = cache;
            // 强类型转换
            _notifications = (DomainNotificationHandler)notifications;
        }

        // GET: User
        public ActionResult Index()
        {
            return View(_userService.GetAll());
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserViewModel userViewModel)
        {
            try
            {
                // TODO: Add insert logic here
                //_cache.Remove("ErrorData");
                //ViewBag.ErrorData = null;
                // 视图模型验证
                if (!ModelState.IsValid)
                    return View(userViewModel);

                #region 删除命令领域模型
                ////添加命令验证，采用构造函数方法实例
                //var registerStudentCommand = new RegisterUserCommand(userViewModel.Name, userViewModel.Email, userViewModel.BirthDate, userViewModel.Phone);

                ////如果命令无效，证明有错误
                //if (!registerStudentCommand.IsValid())
                //{
                //    List<string> errorInfo = new List<string>();
                //    //获取到错误，请思考这个Result从哪里来的 
                //    foreach (var error in registerStudentCommand.ValidationResult.Errors)
                //    {
                //        errorInfo.Add(error.ErrorMessage);
                //    }
                //    //对错误进行记录，还需要抛给前台
                //    ViewBag.ErrorData = errorInfo;
                //    return View(userViewModel);
                //} 
                #endregion



                // 执行添加方法
                _userService.Register(userViewModel);

                #region 缓存用法
                //var errorData = _cache.Get("ErrorData");
                //if (errorData == null) 
                #endregion

                // 是否存在消息通知
                if (!_notifications.HasNotifications())
                    ViewBag.Sucesso = "用户注册成功！";

                //ViewBag.Sucesso = "用户注册成功!";
                return View(userViewModel);
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}