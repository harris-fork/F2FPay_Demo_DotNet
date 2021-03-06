using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ecapiprod.drawndn.lendingrecord.query
    /// </summary>
    public class AlipayEcapiprodDrawndnLendingrecordQueryRequest : IAopRequest<AlipayEcapiprodDrawndnLendingrecordQueryResponse>
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

        /// <summary>
        /// 还款记录的起始时间（距离当前时间不能大于183天，只能在【0-183】之间）
        /// </summary>
        public string Start { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.ecapiprod.drawndn.lendingrecord.query";
        }

        public override IDictionary<string, string> GetParameters()
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
