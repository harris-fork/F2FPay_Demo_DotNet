using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: koubei.marketing.data.activity.bill.download
    /// </summary>
    public class KoubeiMarketingDataActivityBillDownloadRequest : IAopRequest<KoubeiMarketingDataActivityBillDownloadResponse>
    {
        /// <summary>
        /// 营销报表下载
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "koubei.marketing.data.activity.bill.download";
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
