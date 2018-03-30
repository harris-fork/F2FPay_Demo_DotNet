using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.open.servicemarket.order.item.confirm
    /// 服务商代商家确认完成
    /// </summary>
    public class AlipayOpenServicemarketOrderItemConfirmRequest : BizAopRequest<AlipayOpenServicemarketOrderItemConfirmResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.open.servicemarket.order.item.confirm";
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
