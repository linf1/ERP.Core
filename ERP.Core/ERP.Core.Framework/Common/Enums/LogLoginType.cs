﻿using System.ComponentModel; 

namespace ERP.Framework.Common.Enums
{
    /// <summary>
    /// 系统日志登录端类型
    /// </summary>
    public enum LogLoginType
    {
        /// <summary>
        /// PC端
        /// </summary>
        [Description("PC端")]
        Pc,
        /// <summary>
        /// 移动端
        /// </summary>
        [Description("移动端")]
        Mobile,
    }
}
