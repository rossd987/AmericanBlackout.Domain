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

        IList<T> GetAll<T>();

        T Get<T>(long id);

        void Create<T>(T item) where T : RedisItem;

        void Store<T>(T item) where T : RedisItem;

        void Delete<T>(T item) where T : RedisItem;
    }
}
