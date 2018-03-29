using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.user.financeinfo.share
    /// </summary>
    public class AlipayUserFinanceinfoShareRequest : IAopRequest<AlipayUserFinanceinfoShareResponse>
    {
        /// <summary>
        /// 背景：户帐分离项目可能导致会员基本信息和资金类信息将不再紧耦合，且考虑到与本类似的接口（alipay.user.userinfo.share）已十分臃肿，再加入新的功能将降低接口可用性，因此新增本接口给商户查询支付宝会员资金类信息。第一版将支持信用卡卡号（已脱敏）及发卡行信息查询。  外部商户通过授权，调用该接口获取支付宝域会员资金类相关信息。
        /// </summary>
        public string BizContent { get; set; }

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
            return "alipay.user.financeinfo.share";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("biz_content", this.BizContent);
            return parameters;
        }

        #endregion
    }
}
