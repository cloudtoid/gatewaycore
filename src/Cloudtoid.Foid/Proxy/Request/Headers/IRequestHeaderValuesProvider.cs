﻿namespace Cloudtoid.Foid.Proxy
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// By implementing this interface, one can have some control over the outbound upstream request headers. Please consider the following extensibility points:
    /// 1. Inherit from <see cref="RequestHeaderValuesProvider"/>, override its methods, and register it with DI; or
    /// 2. Implement <see cref="IRequestHeaderValuesProvider"/> and register it with DI; or
    /// 3. Inherit from <see cref="RequestHeaderSetter"/>, override its methods, and register it with DI; or
    /// 4. Implement <see cref="IRequestHeaderSetter"/> and register it with DI.
    ///
    /// Dependency Injection registrations:
    /// 1. <c>TryAddSingleton<IRequestHeaderValuesProvider, MyRequestHeaderValuesProvider>()</c>
    /// 2. <c>TryAddSingleton<IRequestHeaderSetter, MyRequestHeaderSetter>()</c>
    /// </summary>
    public interface IRequestHeaderValuesProvider
    {
        /// <summary>
        /// By implementing this method, one can change the values of a given request header.
        /// This interface is only used for request headers. See <see cref="IRequestContentHeaderValuesProvider"/> for content headers.
        /// Return <c>false</c> if the header should be omitted.
        /// </summary>
        bool TryGetHeaderValues(
            HttpContext context,
            string name,
            IList<string> downstreamValues,
            out IList<string> upstreamValues);
    }
}
