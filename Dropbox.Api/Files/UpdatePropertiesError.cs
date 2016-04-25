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
    /// <para>The update properties error object</para>
    /// </summary>
    public class UpdatePropertiesError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UpdatePropertiesError> Encoder = new UpdatePropertiesErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UpdatePropertiesError> Decoder = new UpdatePropertiesErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UpdatePropertiesError" />
        /// class.</para>
        /// </summary>
        public UpdatePropertiesError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is PropertyGroupLookup</para>
        /// </summary>
        public bool IsPropertyGroupLookup
        {
            get
            {
                return this is PropertyGroupLookup;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a PropertyGroupLookup, or <c>null</c>.</para>
        /// </summary>
        public PropertyGroupLookup AsPropertyGroupLookup
        {
            get
            {
                return this as PropertyGroupLookup;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is PropertyFieldTooLarge</para>
        /// </summary>
        public bool IsPropertyFieldTooLarge
        {
            get
            {
                return this is PropertyFieldTooLarge;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a PropertyFieldTooLarge, or <c>null</c>.</para>
        /// </summary>
        public PropertyFieldTooLarge AsPropertyFieldTooLarge
        {
            get
            {
                return this as PropertyFieldTooLarge;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is DoesNotFitTemplate</para>
        /// </summary>
        public bool IsDoesNotFitTemplate
        {
            get
            {
                return this is DoesNotFitTemplate;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a DoesNotFitTemplate, or <c>null</c>.</para>
        /// </summary>
        public DoesNotFitTemplate AsDoesNotFitTemplate
        {
            get
            {
                return this as DoesNotFitTemplate;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="UpdatePropertiesError" />.</para>
        /// </summary>
        private class UpdatePropertiesErrorEncoder : enc.StructEncoder<UpdatePropertiesError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UpdatePropertiesError value, enc.IJsonWriter writer)
            {
                if (value is PropertyGroupLookup)
                {
                    WriteProperty(".tag", "property_group_lookup", writer, enc.StringEncoder.Instance);
                    PropertyGroupLookup.Encoder.EncodeFields((PropertyGroupLookup)value, writer);
                    return;
                }
                if (value is PropertyFieldTooLarge)
                {
                    WriteProperty(".tag", "property_field_too_large", writer, enc.StringEncoder.Instance);
                    PropertyFieldTooLarge.Encoder.EncodeFields((PropertyFieldTooLarge)value, writer);
                    return;
                }
                if (value is DoesNotFitTemplate)
                {
                    WriteProperty(".tag", "does_not_fit_template", writer, enc.StringEncoder.Instance);
                    DoesNotFitTemplate.Encoder.EncodeFields((DoesNotFitTemplate)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="UpdatePropertiesError" />.</para>
        /// </summary>
        private class UpdatePropertiesErrorDecoder : enc.UnionDecoder<UpdatePropertiesError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UpdatePropertiesError"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UpdatePropertiesError Create()
            {
                return new UpdatePropertiesError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override UpdatePropertiesError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "property_group_lookup":
                        return PropertyGroupLookup.Decoder.DecodeFields(reader);
                    case "property_field_too_large":
                        return PropertyFieldTooLarge.Decoder.DecodeFields(reader);
                    case "does_not_fit_template":
                        return DoesNotFitTemplate.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The property group lookup object</para>
        /// </summary>
        public sealed class PropertyGroupLookup : UpdatePropertiesError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<PropertyGroupLookup> Encoder = new PropertyGroupLookupEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<PropertyGroupLookup> Decoder = new PropertyGroupLookupDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="PropertyGroupLookup" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public PropertyGroupLookup(LookUpPropertiesError value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="PropertyGroupLookup" />
            /// class.</para>
            /// </summary>
            private PropertyGroupLookup()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public LookUpPropertiesError Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="PropertyGroupLookup" />.</para>
            /// </summary>
            private class PropertyGroupLookupEncoder : enc.StructEncoder<PropertyGroupLookup>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(PropertyGroupLookup value, enc.IJsonWriter writer)
                {
                    Dropbox.Api.Files.LookUpPropertiesError.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="PropertyGroupLookup" />.</para>
            /// </summary>
            private class PropertyGroupLookupDecoder : enc.StructDecoder<PropertyGroupLookup>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="PropertyGroupLookup"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override PropertyGroupLookup Create()
                {
                    return new PropertyGroupLookup();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(PropertyGroupLookup value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "property_group_lookup":
                            value.Value = Dropbox.Api.Files.LookUpPropertiesError.Decoder.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>A field value in this property group is too large.</para>
        /// </summary>
        public sealed class PropertyFieldTooLarge : UpdatePropertiesError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<PropertyFieldTooLarge> Encoder = new PropertyFieldTooLargeEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<PropertyFieldTooLarge> Decoder = new PropertyFieldTooLargeDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="PropertyFieldTooLarge" />
            /// class.</para>
            /// </summary>
            private PropertyFieldTooLarge()
            {
            }

            /// <summary>
            /// <para>A singleton instance of PropertyFieldTooLarge</para>
            /// </summary>
            public static readonly PropertyFieldTooLarge Instance = new PropertyFieldTooLarge();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="PropertyFieldTooLarge" />.</para>
            /// </summary>
            private class PropertyFieldTooLargeEncoder : enc.StructEncoder<PropertyFieldTooLarge>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(PropertyFieldTooLarge value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="PropertyFieldTooLarge" />.</para>
            /// </summary>
            private class PropertyFieldTooLargeDecoder : enc.StructDecoder<PropertyFieldTooLarge>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="PropertyFieldTooLarge"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override PropertyFieldTooLarge Create()
                {
                    return new PropertyFieldTooLarge();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override PropertyFieldTooLarge DecodeFields(enc.IJsonReader reader)
                {
                    return PropertyFieldTooLarge.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The property group specified does not conform to the property
        /// template.</para>
        /// </summary>
        public sealed class DoesNotFitTemplate : UpdatePropertiesError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<DoesNotFitTemplate> Encoder = new DoesNotFitTemplateEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<DoesNotFitTemplate> Decoder = new DoesNotFitTemplateDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="DoesNotFitTemplate" />
            /// class.</para>
            /// </summary>
            private DoesNotFitTemplate()
            {
            }

            /// <summary>
            /// <para>A singleton instance of DoesNotFitTemplate</para>
            /// </summary>
            public static readonly DoesNotFitTemplate Instance = new DoesNotFitTemplate();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="DoesNotFitTemplate" />.</para>
            /// </summary>
            private class DoesNotFitTemplateEncoder : enc.StructEncoder<DoesNotFitTemplate>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(DoesNotFitTemplate value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="DoesNotFitTemplate" />.</para>
            /// </summary>
            private class DoesNotFitTemplateDecoder : enc.StructDecoder<DoesNotFitTemplate>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="DoesNotFitTemplate"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override DoesNotFitTemplate Create()
                {
                    return new DoesNotFitTemplate();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override DoesNotFitTemplate DecodeFields(enc.IJsonReader reader)
                {
                    return DoesNotFitTemplate.Instance;
                }
            }

            #endregion
        }
    }
}
