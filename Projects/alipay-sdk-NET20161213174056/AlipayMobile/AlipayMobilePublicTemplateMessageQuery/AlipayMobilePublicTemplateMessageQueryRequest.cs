using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.public.template.message.query
    /// </summary>
    public class AlipayMobilePublicTemplateMessageQueryRequest : IAopRequest<AlipayMobilePublicTemplateMessageQueryResponse>
    {
        /// <summary>
        /// 模板
        /// </summary>
        public string Template { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        public string TemplateId { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.public.template.message.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("template", this.Template);
            parameters.Add("template_id", this.TemplateId);
            return parameters;
        }

        #endregion
    }
}
