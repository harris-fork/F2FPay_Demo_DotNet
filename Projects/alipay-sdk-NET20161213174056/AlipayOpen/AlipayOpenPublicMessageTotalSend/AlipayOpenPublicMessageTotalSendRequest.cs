using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.public.message.total.send
    /// </summary>
    public class AlipayOpenPublicMessageTotalSendRequest : IAopRequest<AlipayOpenPublicMessageTotalSendResponse>
    {
        /// <summary>
        /// alipay.open.public. message.total.send（群发消息）
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.open.public.message.total.send";
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
