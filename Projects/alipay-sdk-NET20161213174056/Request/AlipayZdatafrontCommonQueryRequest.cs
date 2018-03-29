using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.zdatafront.common.query
    /// </summary>
    public class AlipayZdatafrontCommonQueryRequest : IAopRequest<AlipayZdatafrontCommonQueryResponse>
    {
        /// <summary>
        /// 如果cacheInterval<=0,就直接从外部获取数据；  如果cacheInterval>0,就先判断cache中的数据是否过期，如果没有过期就返回cache中的数据，如果过期再从外部获取数据并刷新cache，然后返回数据。  单位：秒
        /// </summary>
        public Nullable<long> CacheInterval { get; set; }

        /// <summary>
        /// 通用查询的入参
        /// </summary>
        public string QueryConditions { get; set; }

        /// <summary>
        /// 服务名称请与相关开发负责人联系
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// 访问该服务的业务
        /// </summary>
        public string VisitBiz { get; set; }

        /// <summary>
        /// 访问该服务的业务线
        /// </summary>
        public string VisitBizLine { get; set; }

        /// <summary>
        /// 访问该服务的部门名称
        /// </summary>
        public string VisitDomain { get; set; }

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
            return "alipay.zdatafront.common.query";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("cache_interval", this.CacheInterval);
            parameters.Add("query_conditions", this.QueryConditions);
            parameters.Add("service_name", this.ServiceName);
            parameters.Add("visit_biz", this.VisitBiz);
            parameters.Add("visit_biz_line", this.VisitBizLine);
            parameters.Add("visit_domain", this.VisitDomain);
            return parameters;
        }

        #endregion
    }
}
