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

        public T Get<T>(long id)
        {
            using (var redis = Create())
            {
                return redis.As<T>().GetById(id);
            }
        }

        public IList<T> GetAll<T>()
        {
            using (var redis = Create())
            {
                return redis.As<T>().GetAll();
            }
        }

        public void Create<T>(T item) where T : RedisItem
        {
            using (var redis = Create())
            {
                var client = redis.As<T>();
                item.Id = client.GetNextSequence();
                client.Store(item);
            }
        }

        public void Store<T>(T item) where T : RedisItem
        {
            using (var redis = Create())
            {
                var client = redis.As<T>();
                client.Store(item);
            }
        }

        public void Delete<T>(T item) where T : RedisItem
        {
            using (var redis = Create())
            {
                var client = redis.As<T>();
                client.Delete(item);
            }
        }
    }
}
