using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.user.account.userid.batchquery
    /// 业务统一入参，目前会传入用户的手机号作为查询参数
    /// </summary>
    public class AlipayUserAccountUseridBatchqueryRequest : BizAopRequest<AlipayUserAccountUseridBatchqueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.user.account.userid.batchquery";
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
