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

        public override string GetApiName()
        {
            return "alipay.mdata.tag.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("required_tags", this.RequiredTags);
            parameters.Add("user_id", this.UserId);
            return parameters;
        }

        #endregion
    }
}
