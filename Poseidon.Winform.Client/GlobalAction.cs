﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Winform.Client
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Caller.Facade;
    using Poseidon.Core.DL;
    using Poseidon.Core.Utility;
    using Poseidon.Common;

    /// <summary>
    /// 全局操作类
    /// </summary>
    public static class GlobalAction
    {
        #region Field
        /// <summary>
        /// 当前登录用户
        /// </summary>
        public static LoginUser CurrentUser = null;
        #endregion //Field

        #region Constructor

        #endregion //Constructor

        #region Method
        /// <summary>
        /// 全局初始化
        /// </summary>
        public static void Initialize()
        {
            // 设置连接字符串
            string source = AppConfig.GetAppSetting("ConnectionSource");
            if (string.IsNullOrEmpty(source))
                throw new PoseidonException(ErrorCode.DatabaseConnectionNotFound);

            string connection = "";
            if (source == "dbconfig")
            {
                string name = AppConfig.GetAppSetting("DbConnection");
                connection = ConfigUtility.GetConnectionString(name);
            }
            else if (source == "appconfig")
            {
                connection = AppConfig.GetConnectionString();
            }

            if (string.IsNullOrEmpty(connection))
                throw new PoseidonException(ErrorCode.DatabaseConnectionNotFound);

            Cache.Instance.Add("ConnectionString", connection);

            // 设置数据库类型
            string dalPrefix = AppConfig.GetAppSetting("DALPrefix");
            Cache.Instance.Add("DALPrefix", dalPrefix);
        }

        /// <summary>
        /// 设置登录用户
        /// </summary>
        /// <param name="user">用户信息</param>
        public static LoginUser ConvertToLoginUser(User user)
        {
            LoginUser lu = new LoginUser
            {
                Id = user.Id,
                UserName = user.UserName,
                Name = user.Name,
                LastLoginTime = user.LastLoginTime,
                CurrentLoginTime = user.CurrentLoginTime,
                Remark = user.Remark,
                Status = user.Status
            };

            lu.IsRoot = CallerFactory<IUserService>.Instance.IsRoot(user.Id);

            return lu;
        }

        /// <summary>
        /// 获取插件路径
        /// </summary>
        /// <returns></returns>
        public static string GetPluginPath()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + AppConfig.GetAppSetting("PluginPath") + "\\";
            return path;
        }
        #endregion //Method

        #region Property

        #endregion //Property
    }
}
