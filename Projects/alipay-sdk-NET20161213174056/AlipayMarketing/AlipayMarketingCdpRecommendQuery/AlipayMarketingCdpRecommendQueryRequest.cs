using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.marketing.cdp.recommend.query
    /// </summary>
    public class AlipayMarketingCdpRecommendQueryRequest : IAopRequest<AlipayMarketingCdpRecommendQueryResponse>
    {
        /// <summary>
        /// 外部应用根据用户当前地理位置查询附近商家信息
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

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
