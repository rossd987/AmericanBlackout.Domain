using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ServiceStack.Redis;
using ServiceStack.Redis.Generic;

namespace AmericanBlackout.Domain.Redis
{
    public interface IABRedisClient
    {
        IRedisClient Create();
        IRedisTypedClient<T> As<T>(IRedisClient client);
    }
}
