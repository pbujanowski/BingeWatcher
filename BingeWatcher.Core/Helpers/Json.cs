﻿using System;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace BingeWatcher.Core.Helpers
{
    public static class Json
    {
        public static async Task<T> ToObjectAsync<T>(string value)
        {
            return await Task.Run(() => JsonConvert.DeserializeObject<T>(value)).ConfigureAwait(false);
        }

        public static async Task<string> StringifyAsync(object value)
        {
            return await Task.Run(() => JsonConvert.SerializeObject(value)).ConfigureAwait(false);
        }
    }
}
