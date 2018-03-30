using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.marketing.cdp.recommend.query
    /// 外部应用根据用户当前地理位置查询附近商家信息
    /// </summary>
    public class AlipayMarketingCdpRecommendQueryRequest : BizAopRequest<AlipayMarketingCdpRecommendQueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.marketing.cdp.recommend.query";
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
