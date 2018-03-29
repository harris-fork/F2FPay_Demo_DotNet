using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ecapiprod.data.put
    /// </summary>
    public class AlipayEcapiprodDataPutRequest : IAopRequest<AlipayEcapiprodDataPutResponse>
    {
        /// <summary>
        /// 数据类型
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// 数据字符编码，默认UTF-8
        /// </summary>
        public string CharSet { get; set; }

        /// <summary>
        /// 数据采集平台生成的采集任务编号
        /// </summary>
        public string CollectingTaskId { get; set; }

        /// <summary>
        /// 身份证，工商注册号等
        /// </summary>
        public string EntityCode { get; set; }

        /// <summary>
        /// 姓名或公司名等，name和code不能同时为空
        /// </summary>
        public string EntityName { get; set; }

        /// <summary>
        /// 人或公司等
        /// </summary>
        public string EntityType { get; set; }

        /// <summary>
        /// 渠道商
        /// </summary>
        public string IsvCode { get; set; }

        /// <summary>
        /// 数据主体,以json格式传输的数据
        /// </summary>
        public string JsonData { get; set; }

        /// <summary>
        /// 数据合作方
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
            return "alipay.ecapiprod.data.put";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("category", this.Category);
            parameters.Add("char_set", this.CharSet);
            parameters.Add("collecting_task_id", this.CollectingTaskId);
            parameters.Add("entity_code", this.EntityCode);
            parameters.Add("entity_name", this.EntityName);
            parameters.Add("entity_type", this.EntityType);
            parameters.Add("isv_code", this.IsvCode);
            parameters.Add("json_data", this.JsonData);
            parameters.Add("org_code", this.OrgCode);
            return parameters;
        }

        #endregion
    }
}