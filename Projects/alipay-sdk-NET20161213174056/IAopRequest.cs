using System.Collections.Generic;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP请求接口。
    /// </summary>
    public abstract class IAopRequest<T> where T : AopResponse
    {
        /// <summary>
        /// AOP的异步通知地址
        /// </summary>
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 请求是否需要加密
        /// </summary>
        public bool NeedEncrypt { get; set; }

        /// <summary>
        /// 终端类型
        /// </summary>
        public string TerminalType { get; set; }

        /// <summary>
        /// 终端信息
        /// </summary>
        public string TerminalInfo { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        public string ProdCode { get; set; }

        /// <summary>
        /// 接口版本
        /// </summary>
        public string ApiVersion { get; set; } = "1.0";

        /// <summary>
        /// 获取BizModel
        /// </summary>
        /// <returns></returns>
        public AopObject BizModel { get; set; }

        /// <summary>
        /// 获取AOP的API名称。
        /// </summary>
        /// <returns>API名称</returns>
        public abstract string GetApiName();

        /// <summary>
        /// 获取所有的Key-Value形式的文本请求参数字典。其中：
        /// Key: 请求参数名
        /// Value: 请求参数文本值
        /// </summary>
        /// <returns>文本请求参数字典</returns>
        public abstract IDictionary<string, string> GetParameters();

    }
}
