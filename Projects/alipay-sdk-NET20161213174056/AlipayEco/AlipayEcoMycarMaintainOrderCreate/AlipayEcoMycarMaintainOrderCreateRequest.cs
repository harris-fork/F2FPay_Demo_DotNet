using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.eco.mycar.maintain.order.create
    /// 门店产品通知接口
    /// </summary>
    public class AlipayEcoMycarMaintainOrderCreateRequest : BizAopRequest<AlipayEcoMycarMaintainOrderCreateResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.eco.mycar.maintain.order.create";
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
