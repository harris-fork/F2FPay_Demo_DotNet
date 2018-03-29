using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mpointprod.benefit.detail.get
    /// </summary>
    public class AlipayMpointprodBenefitDetailGetRequest : IAopRequest<AlipayMpointprodBenefitDetailGetResponse>
    {
        /// <summary>
        /// 消息体内容，JSON格式，不含换行、空格  参数:  userId: 支付用户ID, 可以直接传递openId  benefitType: 权益类型,支持(MemberGrade:会员等级)  benefitStatus: 状态只支持(VALID:生效、WAIT:待生效、INVALID:失效), 默认:全部
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
            return "alipay.mpointprod.benefit.detail.get";
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
