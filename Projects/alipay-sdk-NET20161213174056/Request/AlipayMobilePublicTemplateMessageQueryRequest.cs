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
        public bool NeedEncrypt { get; set; }
        public string ApiVersion { get; set; } = "1.0";
        public string TerminalType { get; set; }
        public string TerminalInfo { get; set; }
        public string ProdCode { get; set; }
        public string NotifyUrl { get; set; }
        public AopObject BizModel { get; set; }

        

        

        

        public string GetApiName()
        {
            return "alipay.mobile.public.template.message.query";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("template", this.Template);
            parameters.Add("template_id", this.TemplateId);
            return parameters;
        }

        #endregion
    }
}
