﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace ReactiveUI
{
    /// <summary>
    /// Implement this interface for ViewModels that can be navigated to.
    /// </summary>
    public interface IRoutableViewModel : IReactiveObject
    {
        /// <summary>
        /// A string token representing the current ViewModel, such as 'login' or 'user'.
        /// </summary>
        string UrlPathSegment { get; }

        /// <summary>
        /// The IScreen that this ViewModel is currently being shown in. This
        /// is usually passed into the ViewModel in the Constructor and saved
        /// as a ReadOnly Property.
        /// </summary>
        IScreen HostScreen { get; }
    }
}
