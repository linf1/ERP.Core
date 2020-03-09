﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Autofac.Extras.DynamicProxy;
using ERP.Core.Base.IRepository;
using ERP.Core.Base.Model;
using ERP.Core.Framework.Common.MvcFilter;
using ERP.Core.Framework.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ERP.Core.Controllers
{
    /// <summary>
    /// 模块名：天气管理
    /// 创建人：zhuwm
    /// 日  期：2020年2月3日
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        ISysUserRepository sysUserRepository;

        public WeatherForecastController(ISysUserRepository SysUserRepository)
        {
            this.sysUserRepository = SysUserRepository;
        }

        /// <summary>
        /// 世界你好！
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string Get()
        {
            return sysUserRepository.hello();
        }

        [HttpGet]
        [Route("test")]
        public virtual void test()
        {
            List<SysUser> list = new List<SysUser>();
            for (int i = 0; i < 1000000; i++)
            {
                SysUser user = new SysUser
                {
                    LoginName = "user" + (i + 1),
                    Pwd = "000000",
                    IsStop = false
                };
                list.Add(user);
            }
            sysUserRepository.Add1(list);
        }
    }
}
