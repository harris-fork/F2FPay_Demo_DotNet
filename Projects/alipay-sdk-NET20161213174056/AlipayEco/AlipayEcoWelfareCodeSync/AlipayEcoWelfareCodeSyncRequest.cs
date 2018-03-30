using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.eco.welfare.code.sync
    /// </summary>
    public class AlipayEcoWelfareCodeSyncRequest : IAopRequest<AlipayEcoWelfareCodeSyncResponse>
    {
        /// <summary>
        /// 福利平台用户订单外部核销接口
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.eco.welfare.code.sync";
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
