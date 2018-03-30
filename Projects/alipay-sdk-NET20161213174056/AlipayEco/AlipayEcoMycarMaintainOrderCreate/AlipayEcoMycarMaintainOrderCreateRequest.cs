using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.eco.mycar.maintain.order.create
    /// </summary>
    public class AlipayEcoMycarMaintainOrderCreateRequest : IAopRequest<AlipayEcoMycarMaintainOrderCreateResponse>
    {
        /// <summary>
        /// 门店产品通知接口
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

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