﻿using System.Xml.Linq;
using JetBrains.Annotations;

namespace AD.OpenXml.Structures
{
    // TODO: document DocumentRelsInfo file.
    /// <summary>
    ///
    /// </summary>
    [PublicAPI]
    public static class DocumentRelsInfo
    {
        /// <summary>
        ///
        /// </summary>
        [NotNull] public const string Path = "word/_rels/document.xml.rels";

        /// <summary>
        ///
        /// </summary>
        [NotNull] public static readonly XNamespace Namespace = "http://schemas.openxmlformats.org/package/2006/relationships";

        /// <summary>
        ///
        /// </summary>
        [NotNull] public static readonly XName Root = "Relationships";

        /// <summary>
        ///
        /// </summary>
        [PublicAPI]
        public static class Attributes
        {
            /// <summary>
            ///
            /// </summary>
            [NotNull] public static readonly XName Id = "Id";

            /// <summary>
            ///
            /// </summary>
            [NotNull] public static readonly XName Type = "Type";

            /// <summary>
            ///
            /// </summary>
            [NotNull] public static readonly XName Target = "Target";
        }

        /// <summary>
        ///
        /// </summary>
        [PublicAPI]
        public static class Elements
        {
            /// <summary>
            ///
            /// </summary>
            [NotNull] public static readonly XName Relationship = Namespace + "Relationship";
        }
    }
}