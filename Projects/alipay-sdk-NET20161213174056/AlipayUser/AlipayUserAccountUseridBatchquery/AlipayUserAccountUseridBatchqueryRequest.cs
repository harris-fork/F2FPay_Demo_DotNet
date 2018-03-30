using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.user.account.userid.batchquery
    /// </summary>
    public class AlipayUserAccountUseridBatchqueryRequest : IAopRequest<AlipayUserAccountUseridBatchqueryResponse>
    {
        /// <summary>
        /// 业务统一入参，目前会传入用户的手机号作为查询参数
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

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
