using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.marketing.cdp.advertise.report.query
    /// </summary>
    public class AlipayMarketingCdpAdvertiseReportQueryRequest : IAopRequest<AlipayMarketingCdpAdvertiseReportQueryResponse>
    {
        /// <summary>
        /// 广告效果分析接口
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.marketing.cdp.advertise.report.query";
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
