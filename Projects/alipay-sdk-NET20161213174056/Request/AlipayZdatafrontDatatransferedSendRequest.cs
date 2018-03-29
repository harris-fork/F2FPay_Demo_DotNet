using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.zdatafront.datatransfered.send
    /// </summary>
    public class AlipayZdatafrontDatatransferedSendRequest : IAopRequest<AlipayZdatafrontDatatransferedSendResponse>
    {
        /// <summary>
        /// 数据字段，identity对应的其他数据字段。使用json格式组织，且仅支持字符串类型，其他类型请转为字符串。
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// 合作伙伴的主键数据，同一合作伙伴要保证该字段唯一，若出现重复，后入数据会覆盖先入数据。使用json格式组织，且仅支持字符串类型，其他类型请转为字符串。
        /// </summary>
        public string Identity { get; set; }

        /// <summary>
        /// 合作伙伴标识字段，用来区分数据来源。建议使用公司域名或公司名。
        /// </summary>
        public string TypeId { get; set; }

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
            return "alipay.zdatafront.datatransfered.send";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("data", this.Data);
            parameters.Add("identity", this.Identity);
            parameters.Add("type_id", this.TypeId);
            return parameters;
        }

        #endregion
    }
}
