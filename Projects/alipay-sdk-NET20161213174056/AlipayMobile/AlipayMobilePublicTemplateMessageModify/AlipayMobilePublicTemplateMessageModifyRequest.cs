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

        public override string GetApiName()
        {
            return "alipay.mobile.public.template.message.modify";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("template_id", this.TemplateId);
            parameters.Add("trade_setting", this.TradeSetting);
            return parameters;
        }

        #endregion
    }
}
