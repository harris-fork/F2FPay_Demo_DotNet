using Aop.Api.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aop.Api
{
    public abstract class BizAopRequest<T> : IAopRequest<T> where T : AopResponse
    {
    }
}
