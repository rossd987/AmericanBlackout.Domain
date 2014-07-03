using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ServiceStack.Redis;
using ServiceStack.Redis.Generic;


namespace AmericanBlackout.Domain.Redis
{
    public class ABRedisClient : IABRedisClient
    {
        public IRedisClient Create()
        {
            return new RedisClient("nyu");
        }

        public IRedisTypedClient<T> As<T>(IRedisClient client)
        {
            return client.As<T>();
        }
    }
}
