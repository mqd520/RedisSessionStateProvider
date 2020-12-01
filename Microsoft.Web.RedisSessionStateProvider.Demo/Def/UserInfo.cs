using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Microsoft.Web.RedisSessionStateProvider.Demo.Def
{
    [Serializable]
    public class UserInfo
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// User Name
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Nick Name
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// Login Ip
        /// </summary>
        public string LoginIp { get; set; }

        /// <summary>
        /// Login Time
        /// </summary>
        public DateTime LoginTime { get; set; }

        /// <summary>
        /// Expire Time
        /// </summary>
        public DateTime ExpireTime { get; set; }

        /// <summary>
        /// Register Time
        /// </summary>
        public DateTime RegisterTime { get; set; }

        /// <summary>
        /// Register Ip
        /// </summary>
        public string RegisterIp { get; set; }
    }
}