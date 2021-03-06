﻿using System;
using System.Collections.Generic;
using System.Xml.Linq;

using uSync8.Core.Models;
using uSync8.Core.Serialization;

namespace uSync8.Core.Tracking
{
    public interface ISyncTrackerBase { }

    public interface ISyncTracker<TObject> : ISyncTrackerBase
    {
        [Obsolete("Track with options")]
        IEnumerable<uSyncChange> GetChanges(XElement node);
    }

    public interface ISyncOptionsTracker<TObject> : ISyncTracker<TObject>
    {
        IEnumerable<uSyncChange> GetChanges(XElement node, SyncSerializerOptions options);
    }

    public interface ISyncNodeTracker<TObject> : ISyncTracker<TObject>
    {
        IEnumerable<uSyncChange> GetChanges(XElement node, XElement current, SyncSerializerOptions options);
    }
}
