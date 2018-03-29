using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.user.account.freeze.get
    /// </summary>
    public class AlipayUserAccountFreezeGetRequest : IAopRequest<AlipayUserAccountFreezeGetResponse>
    {
        /// <summary>
        /// 冻结类型，多个用,分隔。不传返回所有类型的冻结金额。 DEPOSIT_FREEZE,充值冻结 WITHDRAW_FREEZE,提现冻结 PAYMENT_FREEZE,支付冻结 BAIL_FREEZE,保证金冻结 CHARGE_FREEZE,收费冻结 PRE_DEPOSIT_FREEZE,预存款冻结 LOAN_FREEZE,贷款冻结 OTHER_FREEZE,其它
        /// </summary>
        public string FreezeType { get; set; }

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
            return "alipay.user.account.freeze.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("freeze_type", this.FreezeType);
            return parameters;
        }

        #endregion
    }
}
