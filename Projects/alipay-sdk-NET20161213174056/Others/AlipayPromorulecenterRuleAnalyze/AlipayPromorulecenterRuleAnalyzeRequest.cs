using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.promorulecenter.rule.analyze
    /// </summary>
    public class AlipayPromorulecenterRuleAnalyzeRequest : IAopRequest<AlipayPromorulecenterRuleAnalyzeResponse>
    {
        /// <summary>
        /// 业务id
        /// </summary>
        public string BizId { get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        public string RuleUuid { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        public string UserId { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.promorulecenter.rule.analyze";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("biz_id", this.BizId);
            parameters.Add("rule_uuid", this.RuleUuid);
            parameters.Add("user_id", this.UserId);
            return parameters;
        }

        #endregion
    }
}
