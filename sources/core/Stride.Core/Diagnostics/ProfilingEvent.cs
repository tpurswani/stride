// Copyright (c) .NET Foundation and Contributors (https://dotnetfoundation.org/ & https://stride3d.net) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.

using System.Collections.Generic;

namespace Stride.Core.Diagnostics
{
    /// <summary>
    /// A profiling event generated by <see cref="Profiler"/>.
    /// </summary>
    public struct ProfilingEvent
    {
        /// <summary>
        /// The unique identifier.
        /// </summary>
        public readonly int Id;

        /// <summary>
        /// The profile key.
        /// </summary>
        public readonly ProfilingKey Key;

        /// <summary>
        /// The type of the profile.
        /// </summary>
        public readonly ProfilingMessageType Type;

        /// <summary>
        /// The timestamp.
        /// </summary>
        public readonly long TimeStamp;

        /// <summary>
        /// The elapsed time since Begin event.
        /// </summary>
        public readonly long ElapsedTime;

        /// <summary>
        /// The text.
        /// </summary>
        public readonly string Text;

        /// <summary>
        /// The attributes
        /// </summary>
        public readonly Dictionary<object, object> Attributes;

        public readonly ProfilingCustomValue? Custom0;
        public readonly ProfilingCustomValue? Custom1;
        public readonly ProfilingCustomValue? Custom2;
        public readonly ProfilingCustomValue? Custom3;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilingEvent" /> struct.
        /// </summary>
        /// <param name="profileId">The profile identifier.</param>
        /// <param name="profilingKey">The profiling key.</param>
        /// <param name="profilingType">Type of the profiling.</param>
        /// <param name="timeStamp"></param>
        /// <param name="elapsedTime">The elapsed time.</param>
        /// <param name="text">The text.</param>
        /// <param name="attributes">The attributes.</param>
        /// <param name="value0"></param>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <param name="value3"></param>
        public ProfilingEvent(
            int profileId, 
            ProfilingKey profilingKey, 
            ProfilingMessageType profilingType, 
            long timeStamp, 
            long elapsedTime, 
            string text, 
            Dictionary<object, object> attributes,
            ProfilingCustomValue? value0 = null,
            ProfilingCustomValue? value1 = null,
            ProfilingCustomValue? value2 = null,
            ProfilingCustomValue? value3 = null)
        {
            Id = profileId;
            Key = profilingKey;
            Type = profilingType;
            TimeStamp = timeStamp;
            ElapsedTime = elapsedTime;
            Text = text;
            Attributes = attributes;
            Custom0 = value0;
            Custom1 = value1;
            Custom2 = value2;
            Custom3 = value3;
        }
    }
}
