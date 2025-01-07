using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Unity.Services.Core;
using Unity.Services.Wire.Internal;
using UnityEngine.Scripting;

namespace Unity.Services.Wire.Protocol.Internal
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    class SubscribeRequest
    {
        public string channel;
        public string token;

        // NYI, recover/history related features
        //
        public bool recover;
        public ulong offset;
        public string epoch;

        [Preserve]
        public SubscribeRequest() {}

        public static async Task<Dictionary<string, SubscribeRequest>> getRequestFromRepo(ISubscriptionRepository repository)
        {
            var subscriptionRequests = new Dictionary<string, SubscribeRequest>();
            foreach (var subIterator in repository.GetAll())
            {
                string subscriptionToken;
                try
                {
                    subscriptionToken = await subIterator.Value.RetrieveTokenAsync();
                }
                catch (Exception e)
                {
                    subIterator.Value.OnError($"Failed to retrieve token: {e.Message}");
                    continue;
                }
                subscriptionRequests.Add(subIterator.Key, new SubscribeRequest
                {
                    recover = repository.IsRecovering(subIterator.Value),
                    token = subscriptionToken
                });
            }

            return subscriptionRequests;
        }
    }
}
