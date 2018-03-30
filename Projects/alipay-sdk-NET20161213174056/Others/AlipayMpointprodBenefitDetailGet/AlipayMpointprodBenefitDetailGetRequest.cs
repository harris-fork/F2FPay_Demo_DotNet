using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.mpointprod.benefit.detail.get
    /// 消息体内容，JSON格式，不含换行、空格  参数:  userId: 支付用户ID, 可以直接传递openId  benefitType: 权益类型,支持(MemberGrade:会员等级)  benefitStatus: 状态只支持(VALID:生效、WAIT:待生效、INVALID:失效), 默认:全部
    /// </summary>
    public class AlipayMpointprodBenefitDetailGetRequest : BizAopRequest<AlipayMpointprodBenefitDetailGetResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mpointprod.benefit.detail.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("biz_content", this.BizContent);
            return parameters;
        }

        #endregion
    }
}
