using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.eco.welfare.code.sync
    /// 福利平台用户订单外部核销接口
    /// </summary>
    public class AlipayEcoWelfareCodeSyncRequest : BizAopRequest<AlipayEcoWelfareCodeSyncResponse>
    {
        

        #region BizAopRequest Members

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
