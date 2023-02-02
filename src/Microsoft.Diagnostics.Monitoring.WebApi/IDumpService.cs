﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Diagnostics.Monitoring.WebApi
{
    internal interface IDumpService
    {
        Task<Stream> DumpAsync(IEndpointInfo endpointInfo, Models.DumpType mode, CancellationToken token);
    }
}
