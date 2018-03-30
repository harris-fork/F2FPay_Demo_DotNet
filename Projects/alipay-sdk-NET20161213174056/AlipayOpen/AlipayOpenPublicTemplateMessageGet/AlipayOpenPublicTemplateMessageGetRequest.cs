using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.public.template.message.get
    /// </summary>
    public class AlipayOpenPublicTemplateMessageGetRequest : IAopRequest<AlipayOpenPublicTemplateMessageGetResponse>
    {
        /// <summary>
        /// 模板消息领取接口
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.open.public.template.message.get";
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
