using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.eco.mycar.promo.ticket.push
    /// 车主营销平台券核销结果通知
    /// </summary>
    public class AlipayEcoMycarPromoTicketPushRequest : BizAopRequest<AlipayEcoMycarPromoTicketPushResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.eco.mycar.promo.ticket.push";
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
