// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Framework.Logging
{
    /// <summary>
    /// Used to create logger instances of the given name.
    /// </summary>
    public interface ILoggerFactory
    {
        /// <summary>
        /// The minimum level of log messages sent to registered loggers.
        /// </summary>
        LogLevel MinimumLevel { get; set; }

        /// <summary>
        /// Creates a new ILogger instance of the given name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        ILogger Create(string name);

        void AddProvider(ILoggerProvider provider);
    }
}