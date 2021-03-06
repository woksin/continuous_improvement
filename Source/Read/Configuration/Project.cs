/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using Concepts;

namespace Read.Configuration
{
    /// <summary>
    /// Represents a project
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Gets or sets the <see cref="ProjectId"/>
        /// </summary>
        public ProjectId Id { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="ProjectName"/>
        /// </summary>
        public ProjectName Name { get; set; }

        /// <summary>
        /// Gets or sets the secret key that is used to verify that the trigger is legitimate
        /// </summary>
        public string SecretKey { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Uri"/> for the repository to use
        /// </summary>
        public Uri Repository { get; set; }

        /// <summary>
        /// Gets or sets the builds to perform for the project
        /// </summary>
        public IEnumerable<Build> Builds { get; set; } = new Build[0];

        /// <summary>
        /// Gets or sets the <see cref="ProjectCascade">projects</see> to cascade to
        /// </summary>
        public IEnumerable<ProjectCascade> Cascades { get; set; } = new ProjectCascade[0];

        /// <summary>
        /// Gets or sets the <see cref="NotificationChannels">notification channels</see> to perform at the end
        /// </summary>
        public IEnumerable<NotificationChannel> NotificationChannels { get; set; } = new NotificationChannel[0];

        /// <summary>
        ///  Gets or sets the <see cref="PackageSource">package sourceas</see> to publish any packages to
        /// </summary>
        public IEnumerable<PackageSource> PackageSources { get; set; } = new PackageSource[0];

        /// <summary>
        /// Gets or sets the <see cref="ContainerRegistry">container regisitries</see> to publish any container images to
        /// </summary>
        public IEnumerable<ContainerRegistry> ContainerRegistries { get; set; } = new ContainerRegistry[0];
    }
}