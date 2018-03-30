using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.zmscore.zrank.get
    /// </summary>
    public class AlipayZmscoreZrankGetRequest : IAopRequest<AlipayZmscoreZrankGetResponse>
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserId { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.zmscore.zrank.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("user_id", this.UserId);
            return parameters;
        }

        #endregion
    }
}
