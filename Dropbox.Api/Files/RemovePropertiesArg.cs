// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The remove properties arg object</para>
    /// </summary>
    public class RemovePropertiesArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<RemovePropertiesArg> Encoder = new RemovePropertiesArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<RemovePropertiesArg> Decoder = new RemovePropertiesArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RemovePropertiesArg" />
        /// class.</para>
        /// </summary>
        /// <param name="path">A unique identifier for the file.</param>
        /// <param name="propertyTemplateIds">A list of identifiers for a property template
        /// created by route properties/template/add.</param>
        public RemovePropertiesArg(string path,
                                   col.IEnumerable<string> propertyTemplateIds)
        {
            if (path == null)
            {
                throw new sys.ArgumentNullException("path");
            }
            if (!re.Regex.IsMatch(path, @"\A(?:(/|id:).*)\z"))
            {
                throw new sys.ArgumentOutOfRangeException("path", @"Value should match pattern '\A(?:(/|id:).*)\z'");
            }

            var propertyTemplateIdsList = enc.Util.ToList(propertyTemplateIds);

            if (propertyTemplateIds == null)
            {
                throw new sys.ArgumentNullException("propertyTemplateIds");
            }

            this.Path = path;
            this.PropertyTemplateIds = propertyTemplateIdsList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RemovePropertiesArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public RemovePropertiesArg()
        {
        }

        /// <summary>
        /// <para>A unique identifier for the file.</para>
        /// </summary>
        public string Path { get; protected set; }

        /// <summary>
        /// <para>A list of identifiers for a property template created by route
        /// properties/template/add.</para>
        /// </summary>
        public col.IList<string> PropertyTemplateIds { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="RemovePropertiesArg" />.</para>
        /// </summary>
        private class RemovePropertiesArgEncoder : enc.StructEncoder<RemovePropertiesArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(RemovePropertiesArg value, enc.IJsonWriter writer)
            {
                WriteProperty("path", value.Path, writer, enc.StringEncoder.Instance);
                WriteListProperty("property_template_ids", value.PropertyTemplateIds, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="RemovePropertiesArg" />.</para>
        /// </summary>
        private class RemovePropertiesArgDecoder : enc.StructDecoder<RemovePropertiesArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="RemovePropertiesArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override RemovePropertiesArg Create()
            {
                return new RemovePropertiesArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(RemovePropertiesArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "path":
                        value.Path = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "property_template_ids":
                        value.PropertyTemplateIds = ReadList<string>(reader, enc.StringDecoder.Instance);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
