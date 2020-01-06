﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utf8Json.Resolvers;
using Utf8Json;

namespace Gamebook.Helpers
{
    public static class SessionExtensions
    {
        public static void Set<T>(this ISession session, string key, T value)
        {
            JsonSerializer.SetDefaultResolver(StandardResolver.AllowPrivateCamelCase);
            session.SetString(key, JsonSerializer.ToJsonString(value));
        }

        public static T Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            if (value == null)
                return default;
            else
                return JsonSerializer.Deserialize<T>(value);
        }
    }
}
