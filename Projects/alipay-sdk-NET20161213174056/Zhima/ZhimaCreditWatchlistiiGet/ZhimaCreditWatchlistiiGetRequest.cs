using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: zhima.credit.watchlistii.get
    /// </summary>
    public class ZhimaCreditWatchlistiiGetRequest : IAopRequest<ZhimaCreditWatchlistiiGetResponse>
    {
        /// <summary>
        /// 行业关注名单
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "zhima.credit.watchlistii.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("biz_content", this.BizContent);
            return parameters;
        }

        #endregion
    }
}
