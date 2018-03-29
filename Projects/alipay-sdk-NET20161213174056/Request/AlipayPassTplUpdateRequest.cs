using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.pass.tpl.update
    /// </summary>
    public class AlipayPassTplUpdateRequest : IAopRequest<AlipayPassTplUpdateResponse>
    {
        /// <summary>
        /// 模版内容
        /// </summary>
        public string TplContent { get; set; }

        /// <summary>
        /// 模版ID
        /// </summary>
        public string TplId { get; set; }

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
            return "alipay.pass.tpl.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("tpl_content", this.TplContent);
            parameters.Add("tpl_id", this.TplId);
            return parameters;
        }

        #endregion
    }
}
