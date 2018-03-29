using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mdata.tag.get
    /// </summary>
    public class AlipayMdataTagGetRequest : IAopRequest<AlipayMdataTagGetResponse>
    {
        /// <summary>
        /// 所需标签列表.
        /// </summary>
        public List<string> RequiredTags { get; set; }

        /// <summary>
        /// 用户的支付宝Id
        /// </summary>
        public string UserId { get; set; }

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
            return "alipay.mdata.tag.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("required_tags", this.RequiredTags);
            parameters.Add("user_id", this.UserId);
            return parameters;
        }

        #endregion
    }
}
