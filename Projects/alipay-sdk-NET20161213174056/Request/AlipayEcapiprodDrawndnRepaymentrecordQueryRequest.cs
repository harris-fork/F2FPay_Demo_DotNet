using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ecapiprod.drawndn.repaymentrecord.query
    /// </summary>
    public class AlipayEcapiprodDrawndnRepaymentrecordQueryRequest : IAopRequest<AlipayEcapiprodDrawndnRepaymentrecordQueryResponse>
    {
        /// <summary>
        /// 支用编号
        /// </summary>
        public string DrawndnNo { get; set; }

        /// <summary>
        /// 还款记录的终止时间，终止时间与起始时间的范围不能超过31天
        /// </summary>
        public string End { get; set; }

        /// <summary>
        /// 客户身份证号码，为18位，最后X必须为大写
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

        /// <summary>
        /// 还款记录的起始时间（距离当前时间不能大于183天，只能在【0-183】之间）
        /// </summary>
        public string Start { get; set; }

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
            return "alipay.ecapiprod.drawndn.repaymentrecord.query";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("drawndn_no", this.DrawndnNo);
            parameters.Add("end", this.End);
            parameters.Add("entity_code", this.EntityCode);
            parameters.Add("entity_name", this.EntityName);
            parameters.Add("isv_code", this.IsvCode);
            parameters.Add("org_code", this.OrgCode);
            parameters.Add("start", this.Start);
            return parameters;
        }

        #endregion
    }
}
