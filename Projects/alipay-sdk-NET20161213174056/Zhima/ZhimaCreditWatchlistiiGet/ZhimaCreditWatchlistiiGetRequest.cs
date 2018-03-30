using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// zhima.credit.watchlistii.get
    /// 行业关注名单
    /// </summary>
    public class ZhimaCreditWatchlistiiGetRequest : BizAopRequest<ZhimaCreditWatchlistiiGetResponse>
    {
        

        #region BizAopRequest Members

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
