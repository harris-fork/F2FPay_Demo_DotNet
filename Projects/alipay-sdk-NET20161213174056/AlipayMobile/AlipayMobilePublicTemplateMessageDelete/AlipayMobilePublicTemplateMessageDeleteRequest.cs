using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.public.template.message.delete
    /// </summary>
    public class AlipayMobilePublicTemplateMessageDeleteRequest : IAopRequest<AlipayMobilePublicTemplateMessageDeleteResponse>
    {
        /// <summary>
        /// 模板id
        /// </summary>
        public string TemplateId { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.public.template.message.delete";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("template_id", this.TemplateId);
            return parameters;
        }

        #endregion
    }
}
