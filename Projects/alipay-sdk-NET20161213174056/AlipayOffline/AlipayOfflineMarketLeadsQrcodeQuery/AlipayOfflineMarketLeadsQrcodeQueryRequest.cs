using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.offline.market.leads.qrcode.query
    /// 地推小二认领了Leads后申请创建开店二维码，提供给商户扫描开店。
    /// </summary>
    public class AlipayOfflineMarketLeadsQrcodeQueryRequest : BizAopRequest<AlipayOfflineMarketLeadsQrcodeQueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.market.leads.qrcode.query";
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
