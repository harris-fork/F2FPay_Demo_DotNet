using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.commerce.cityfacilitator.function.query
    /// 基于设备和城市查询当前支持的功能
    /// </summary>
    public class AlipayCommerceCityfacilitatorFunctionQueryRequest : BizAopRequest<AlipayCommerceCityfacilitatorFunctionQueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.commerce.cityfacilitator.function.query";
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
