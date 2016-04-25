// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The modify shared link settings args object</para>
    /// </summary>
    public class ModifySharedLinkSettingsArgs
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ModifySharedLinkSettingsArgs> Encoder = new ModifySharedLinkSettingsArgsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ModifySharedLinkSettingsArgs> Decoder = new ModifySharedLinkSettingsArgsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ModifySharedLinkSettingsArgs" />
        /// class.</para>
        /// </summary>
        /// <param name="url">URL of the shared link to change its settings</param>
        /// <param name="settings">Set of settings for the shared link.</param>
        /// <param name="removeExpiration">If set to true, removes the expiration of the shared
        /// link.</param>
        public ModifySharedLinkSettingsArgs(string url,
                                            SharedLinkSettings settings,
                                            bool removeExpiration = false)
        {
            if (url == null)
            {
                throw new sys.ArgumentNullException("url");
            }

            if (settings == null)
            {
                throw new sys.ArgumentNullException("settings");
            }

            this.Url = url;
            this.Settings = settings;
            this.RemoveExpiration = removeExpiration;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ModifySharedLinkSettingsArgs" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public ModifySharedLinkSettingsArgs()
        {
            this.RemoveExpiration = false;
        }

        /// <summary>
        /// <para>URL of the shared link to change its settings</para>
        /// </summary>
        public string Url { get; protected set; }

        /// <summary>
        /// <para>Set of settings for the shared link.</para>
        /// </summary>
        public SharedLinkSettings Settings { get; protected set; }

        /// <summary>
        /// <para>If set to true, removes the expiration of the shared link.</para>
        /// </summary>
        public bool RemoveExpiration { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ModifySharedLinkSettingsArgs" />.</para>
        /// </summary>
        private class ModifySharedLinkSettingsArgsEncoder : enc.StructEncoder<ModifySharedLinkSettingsArgs>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ModifySharedLinkSettingsArgs value, enc.IJsonWriter writer)
            {
                WriteProperty("url", value.Url, writer, enc.StringEncoder.Instance);
                WriteProperty("settings", value.Settings, writer, Dropbox.Api.Sharing.SharedLinkSettings.Encoder);
                WriteProperty("remove_expiration", value.RemoveExpiration, writer, enc.BooleanEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ModifySharedLinkSettingsArgs" />.</para>
        /// </summary>
        private class ModifySharedLinkSettingsArgsDecoder : enc.StructDecoder<ModifySharedLinkSettingsArgs>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ModifySharedLinkSettingsArgs"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ModifySharedLinkSettingsArgs Create()
            {
                return new ModifySharedLinkSettingsArgs();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ModifySharedLinkSettingsArgs value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "url":
                        value.Url = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "settings":
                        value.Settings = Dropbox.Api.Sharing.SharedLinkSettings.Decoder.Decode(reader);
                        break;
                    case "remove_expiration":
                        value.RemoveExpiration = enc.BooleanDecoder.Instance.Decode(reader);
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
