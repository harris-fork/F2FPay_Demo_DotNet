using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ecapiprod.credit.get
    /// </summary>
    public class AlipayEcapiprodCreditGetRequest : IAopRequest<AlipayEcapiprodCreditGetResponse>
    {
        /// <summary>
        /// 授信编号
        /// </summary>
        public string CreditNo { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        public string EntityCode { get; set; }

        /// <summary>
        /// 客户的姓名
        /// </summary>
        public string EntityName { get; set; }

        /// <summary>
        /// 每一个对接融资平台的系统提供商都有一个机构号
        /// </summary>
        public string IsvCode { get; set; }

        /// <summary>
        /// 融资平台分配给小贷公司的机构编码
        /// </summary>
        public string OrgCode { get; set; }

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
            return "alipay.ecapiprod.credit.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("credit_no", this.CreditNo);
            parameters.Add("entity_code", this.EntityCode);
            parameters.Add("entity_name", this.EntityName);
            parameters.Add("isv_code", this.IsvCode);
            parameters.Add("org_code", this.OrgCode);
            return parameters;
        }

        #endregion
    }
}
