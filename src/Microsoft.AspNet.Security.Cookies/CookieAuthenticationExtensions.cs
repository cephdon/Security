// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNet.Security.Cookies;
using Microsoft.AspNet.Security.Infrastructure;
using System;

namespace Microsoft.AspNet.Builder
{
    /// <summary>
    /// Extension methods provided by the cookies authentication middleware
    /// </summary>
    public static class CookieAuthenticationExtensions
    {
        ///// <summary>
        ///// Adds a cookie-based authentication middleware to your web application pipeline.
        ///// </summary>
        ///// <param name="app">The IApplicationBuilder passed to your configuration method</param>
        ///// <param name="options">An options class that controls the middleware behavior</param>
        ///// <returns>The original app parameter</returns>
        //public static IApplicationBuilder UseCookieAuthentication([NotNull] this IApplicationBuilder app, [NotNull] CookieAuthenticationOptions options)
        //{
        //    return app.UseMiddleware<CookieAuthenticationMiddleware>(options);
        //}

        /// <summary>
        /// Adds a cookie-based authentication middleware to your web application pipeline.
        /// </summary>
        /// <param name="app">The IApplicationBuilder passed to your configuration method</param>
        /// <param name="optionsName">The name of the options class that controls the middleware behavior, null will use the default options</param>
        /// <returns>The original app parameter</returns>
        public static IApplicationBuilder UseCookieAuthentication([NotNull] this IApplicationBuilder app, Action<CookieAuthenticationOptions> configureOptions = null, string optionsName = "")
        {
            return app.UseMiddleware<CookieAuthenticationMiddleware>(new OptionsConfiguration<CookieAuthenticationOptions>
            {
                Name = optionsName,
                ConfigureOptions = configureOptions
            });
        }
    }
}