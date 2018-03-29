using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.pass.tpl.add
    /// </summary>
    public class AlipayPassTplAddRequest : IAopRequest<AlipayPassTplAddResponse>
    {
        /// <summary>
        /// 支付宝pass模版内容【JSON格式】  具体格式可参考https://alipass.alipay.com中文档中心-格式说明
        /// </summary>
        public string TplContent { get; set; }

        /// <summary>
        /// 模版外部唯一标识：商户用于控制模版的唯一性。
        /// </summary>
        public string UniqueId { get; set; }

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
            return "alipay.pass.tpl.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("tpl_content", this.TplContent);
            parameters.Add("unique_id", this.UniqueId);
            return parameters;
        }

        #endregion
    }
}
