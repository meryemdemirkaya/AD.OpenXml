﻿using System.IO;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using AD.OpenXml.Visitors;
using AD.Xml;
using JetBrains.Annotations;

namespace AD.OpenXml.Visits
{
    /// <inheritdoc />
    /// <summary>
    /// </summary>
    [PublicAPI]
    public sealed class NumberingVisit : IOpenXmlVisit
    {
        [NotNull] private static readonly XNamespace T = XNamespaces.OpenXmlPackageContentTypes;
        [NotNull] private static readonly XNamespace P = XNamespaces.OpenXmlPackageRelationships;
        [NotNull] private static readonly XNamespace W = XNamespaces.OpenXmlWordprocessingmlMain;
        [NotNull] private static readonly XElement Numbering;

        /// <inheritdoc />
        public IOpenXmlVisitor Result { get; }

        /// <summary>
        ///
        /// </summary>
        static NumberingVisit()
        {
            Assembly assembly = typeof(NumberingVisit).GetTypeInfo().Assembly;

            using (StreamReader reader = new StreamReader(assembly.GetManifestResourceStream("AD.OpenXml.Styles.Numbering.xml"), Encoding.UTF8))
            {
                Numbering = XElement.Parse(reader.ReadToEnd());
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="subject"></param>
        public NumberingVisit(IOpenXmlVisitor subject)
        {
            XElement numbering = Numbering.Clone();

            Result =
                new OpenXmlVisitor(
                    subject.ContentTypes,
                    subject.Document,
                    subject.DocumentRelations,
                    subject.Footnotes,
                    subject.FootnoteRelations,
                    subject.Styles,
                    numbering,
                    subject.Theme1,
                    subject.Charts);
        }
    }
}