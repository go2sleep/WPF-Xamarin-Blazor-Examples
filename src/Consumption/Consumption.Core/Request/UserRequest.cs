﻿/*
*
* 文件名    ：UserLoginRequest                             
* 程序说明  : 用户请求
* 更新时间  : 2020-05-30 20：40
* 联系作者  : QQ:779149549 
* 开发者群  : QQ群:874752819
* 邮件联系  : zhouhaogg789@outlook.com
* 视频教程  : https://space.bilibili.com/32497462
* 博客地址  : https://www.cnblogs.com/zh7791/
* 项目地址  : https://github.com/HenJigg/WPF-Xamarin-Blazor-Examples
* 项目说明  : 以上所有代码均属开源免费使用,禁止个人行为出售本项目源代码
*/

namespace Consumption.Core.Request
{
    using Consumption.Core.Entity;
    using Consumption.Core.Query;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// 用户登录请求
    /// </summary>
    public class UserLoginRequest : BaseRequest
    {
        public override string route { get => ServerAddress + "api/User/Login"; }

        /// <summary>
        /// 账户
        /// </summary>
        public string account { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string passWord { get; set; }
    }

    /// <summary>
    /// 用户查询请求
    /// </summary>
    public class UserQueryRequest : BaseRequest
    {
        public override string route { get => ServerAddress + "api/User/GetUsers"; }

        public UserParameters parameters { get; set; }
    }

    /// <summary>
    /// 用户ID查询请求
    /// </summary>
    public class UserQueryByIdRequest : BaseRequest
    {
        public override string route { get => ServerAddress + "api/User/GetUser"; }

        public int id { get; set; }
    }

    /// <summary>
    /// 用户权限请求
    /// </summary>
    public class UserPermRequest : BaseRequest
    {
        public override string route { get => ServerAddress + "api/User/Perm"; }

        public string account { get; set; }
    }

    /// <summary>
    /// 更新/添加用户
    /// </summary>
    public class UserSaveRequest : BaseRequest
    {
        public override string route { get => ServerAddress + "api/User/SaveUser"; }

        public User user { get; set; }
    }

    /// <summary>
    /// 删除
    /// </summary>
    public class UserDeleteRequest : BaseRequest
    {
        public override string route { get => ServerAddress + "api/User/DeleteUser"; }

        public int id { get; set; }
    }
}
