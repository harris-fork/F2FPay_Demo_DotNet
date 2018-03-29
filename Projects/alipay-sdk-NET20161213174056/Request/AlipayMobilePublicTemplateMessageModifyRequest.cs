using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.public.template.message.modify
    /// </summary>
    public class AlipayMobilePublicTemplateMessageModifyRequest : IAopRequest<AlipayMobilePublicTemplateMessageModifyResponse>
    {
        /// <summary>
        /// 模板id
        /// </summary>
        public string TemplateId { get; set; }

        /// <summary>
        /// 行业设置
        /// </summary>
        public string TradeSetting { get; set; }

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
            return "alipay.mobile.public.template.message.modify";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("template_id", this.TemplateId);
            parameters.Add("trade_setting", this.TradeSetting);
            return parameters;
        }

        #endregion
    }
}
