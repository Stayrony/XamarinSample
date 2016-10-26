// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MasterPageItem.cs" company="">
//   
// </copyright>
// <summary>
//   The master page item.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace XamarinSample.Models
{
    using System;

    /// <summary>
    /// The master page item.
    /// </summary>
    public class MasterPageItem
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the icon source.
        /// </summary>
        public string IconSource { get; set; }

        /// <summary>
        /// Gets or sets the target type.
        /// </summary>
        public Type TargetType { get; set; }
    }
}