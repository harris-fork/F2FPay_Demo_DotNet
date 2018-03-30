using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.eco.mycar.maintain.orderstatus.update
    /// 保养订单状态更新
    /// </summary>
    public class AlipayEcoMycarMaintainOrderstatusUpdateRequest : BizAopRequest<AlipayEcoMycarMaintainOrderstatusUpdateResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.eco.mycar.maintain.orderstatus.update";
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
