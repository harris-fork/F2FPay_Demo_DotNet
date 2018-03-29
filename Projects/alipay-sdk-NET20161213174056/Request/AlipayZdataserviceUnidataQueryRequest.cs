using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.zdataservice.unidata.query
    /// </summary>
    public class AlipayZdataserviceUnidataQueryRequest : IAopRequest<AlipayZdataserviceUnidataQueryResponse>
    {
        /// <summary>
        /// 通用的查询入参
        /// </summary>
        public string QueryCondition { get; set; }

        /// <summary>
        /// 返回数据的类型，内部业务系统分配
        /// </summary>
        public string UniqKey { get; set; }

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
            return "alipay.zdataservice.unidata.query";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("query_condition", this.QueryCondition);
            parameters.Add("uniq_key", this.UniqKey);
            return parameters;
        }

        #endregion
    }
}
