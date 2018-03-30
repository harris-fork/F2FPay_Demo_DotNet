using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.eco.mycar.promo.ticket.sync
    /// ISV有新的卡券信息同步到车主服务平台
    /// </summary>
    public class AlipayEcoMycarPromoTicketSyncRequest : BizAopRequest<AlipayEcoMycarPromoTicketSyncResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.eco.mycar.promo.ticket.sync";
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
