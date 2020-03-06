﻿namespace Cloudtoid
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    [SuppressMessage("BannedApiAnalyzer", "RS0030", Justification = "Instead of the banned API Guid.NewGuid, everyone should be using this class.")]
    internal sealed class GuidProvider : IGuidProvider
    {
        public Guid NewGuid() => Guid.NewGuid();
    }
}
