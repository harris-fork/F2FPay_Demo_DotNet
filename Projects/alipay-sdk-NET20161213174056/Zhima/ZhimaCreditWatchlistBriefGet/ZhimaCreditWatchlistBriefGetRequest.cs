using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// zhima.credit.watchlist.brief.get
    /// 行业关注名单普惠版
    /// </summary>
    public class ZhimaCreditWatchlistBriefGetRequest : BizAopRequest<ZhimaCreditWatchlistBriefGetResponse>
    {
        

        #region BizAopRequest Members

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
