using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.fund.auth.operation.cancel
    /// </summary>
    public class AlipayFundAuthOperationCancelRequest : IAopRequest<AlipayFundAuthOperationCancelResponse>
    {
        /// <summary>
        /// 资金预授权明细撤销接口
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.fund.auth.operation.cancel";
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
