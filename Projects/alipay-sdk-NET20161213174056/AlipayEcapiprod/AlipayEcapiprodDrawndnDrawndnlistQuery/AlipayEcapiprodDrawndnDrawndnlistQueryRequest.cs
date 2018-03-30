using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ecapiprod.drawndn.drawndnlist.query
    /// </summary>
    public class AlipayEcapiprodDrawndnDrawndnlistQueryRequest : IAopRequest<AlipayEcapiprodDrawndnDrawndnlistQueryResponse>
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
        /// 融资平台分配给ISV的编码
        /// </summary>
        public string IsvCode { get; set; }

        /// <summary>
        /// 融资平台分配给小贷公司的机构编码
        /// </summary>
        public string OrgCode { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.ecapiprod.drawndn.drawndnlist.query";
        }

        public override IDictionary<string, string> GetParameters()
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
