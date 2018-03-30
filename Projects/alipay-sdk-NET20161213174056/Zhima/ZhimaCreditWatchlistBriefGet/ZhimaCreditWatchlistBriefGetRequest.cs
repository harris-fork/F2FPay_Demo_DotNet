using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: zhima.credit.watchlist.brief.get
    /// </summary>
    public class ZhimaCreditWatchlistBriefGetRequest : IAopRequest<ZhimaCreditWatchlistBriefGetResponse>
    {
        /// <summary>
        /// 行业关注名单普惠版
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "zhima.credit.watchlist.brief.get";
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
