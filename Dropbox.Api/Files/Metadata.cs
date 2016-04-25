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
    /// <para>Metadata for a file or folder.</para>
    /// </summary>
    /// <seealso cref="DeletedMetadata" />
    /// <seealso cref="FileMetadata" />
    /// <seealso cref="FolderMetadata" />
    /// <seealso cref="GetCopyReferenceResult" />
    /// <seealso cref="SaveCopyReferenceResult" />
    /// <seealso cref="SearchMatch" />
    public class Metadata
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<Metadata> Encoder = new MetadataEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<Metadata> Decoder = new MetadataDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="Metadata" /> class.</para>
        /// </summary>
        /// <param name="name">The last component of the path (including extension). This never
        /// contains a slash.</param>
        /// <param name="pathLower">The lowercased full path in the user's Dropbox. This always
        /// starts with a slash.</param>
        /// <param name="pathDisplay">The cased path to be used for display purposes only. In
        /// rare instances the casing will not correctly match the user's filesystem, but this
        /// behavior will match the path provided in the Core API v1. Changes to the casing of
        /// paths won't be returned by <see
        /// cref="Dropbox.Api.Files.Routes.FilesRoutes.ListFolderContinueAsync" /></param>
        /// <param name="parentSharedFolderId">Deprecated. Please use <see
        /// cref="Dropbox.Api.Files.FileSharingInfo.ParentSharedFolderId" /> or <see
        /// cref="Dropbox.Api.Files.FolderSharingInfo.ParentSharedFolderId" /> instead.</param>
        protected Metadata(string name,
                           string pathLower,
                           string pathDisplay,
                           string parentSharedFolderId = null)
        {
            if (name == null)
            {
                throw new sys.ArgumentNullException("name");
            }

            if (pathLower == null)
            {
                throw new sys.ArgumentNullException("pathLower");
            }

            if (pathDisplay == null)
            {
                throw new sys.ArgumentNullException("pathDisplay");
            }

            if (parentSharedFolderId != null)
            {
                if (!re.Regex.IsMatch(parentSharedFolderId, @"\A(?:[-_0-9a-zA-Z:]+)\z"))
                {
                    throw new sys.ArgumentOutOfRangeException("parentSharedFolderId", @"Value should match pattern '\A(?:[-_0-9a-zA-Z:]+)\z'");
                }
            }

            this.Name = name;
            this.PathLower = pathLower;
            this.PathDisplay = pathDisplay;
            this.ParentSharedFolderId = parentSharedFolderId;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="Metadata" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public Metadata()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is File</para>
        /// </summary>
        public bool IsFile
        {
            get
            {
                return this is FileMetadata;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a <see cref="FileMetadata" />, or <c>null</c>.</para>
        /// </summary>
        public FileMetadata AsFile
        {
            get
            {
                return this as FileMetadata;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Folder</para>
        /// </summary>
        public bool IsFolder
        {
            get
            {
                return this is FolderMetadata;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a <see cref="FolderMetadata" />, or <c>null</c>.</para>
        /// </summary>
        public FolderMetadata AsFolder
        {
            get
            {
                return this as FolderMetadata;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Deleted</para>
        /// </summary>
        public bool IsDeleted
        {
            get
            {
                return this is DeletedMetadata;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a <see cref="DeletedMetadata" />, or
        /// <c>null</c>.</para>
        /// </summary>
        public DeletedMetadata AsDeleted
        {
            get
            {
                return this as DeletedMetadata;
            }
        }

        /// <summary>
        /// <para>The last component of the path (including extension). This never contains a
        /// slash.</para>
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// <para>The lowercased full path in the user's Dropbox. This always starts with a
        /// slash.</para>
        /// </summary>
        public string PathLower { get; protected set; }

        /// <summary>
        /// <para>The cased path to be used for display purposes only. In rare instances the
        /// casing will not correctly match the user's filesystem, but this behavior will match
        /// the path provided in the Core API v1. Changes to the casing of paths won't be
        /// returned by <see
        /// cref="Dropbox.Api.Files.Routes.FilesRoutes.ListFolderContinueAsync" /></para>
        /// </summary>
        public string PathDisplay { get; protected set; }

        /// <summary>
        /// <para>Deprecated. Please use <see
        /// cref="Dropbox.Api.Files.FileSharingInfo.ParentSharedFolderId" /> or <see
        /// cref="Dropbox.Api.Files.FolderSharingInfo.ParentSharedFolderId" /> instead.</para>
        /// </summary>
        public string ParentSharedFolderId { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="Metadata" />.</para>
        /// </summary>
        private class MetadataEncoder : enc.StructEncoder<Metadata>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(Metadata value, enc.IJsonWriter writer)
            {
                if (value is FileMetadata)
                {
                    WriteProperty(".tag", "file", writer, enc.StringEncoder.Instance);
                    FileMetadata.Encoder.EncodeFields((FileMetadata)value, writer);
                    return;
                }
                if (value is FolderMetadata)
                {
                    WriteProperty(".tag", "folder", writer, enc.StringEncoder.Instance);
                    FolderMetadata.Encoder.EncodeFields((FolderMetadata)value, writer);
                    return;
                }
                if (value is DeletedMetadata)
                {
                    WriteProperty(".tag", "deleted", writer, enc.StringEncoder.Instance);
                    DeletedMetadata.Encoder.EncodeFields((DeletedMetadata)value, writer);
                    return;
                }
                WriteProperty("name", value.Name, writer, enc.StringEncoder.Instance);
                WriteProperty("path_lower", value.PathLower, writer, enc.StringEncoder.Instance);
                WriteProperty("path_display", value.PathDisplay, writer, enc.StringEncoder.Instance);
                if (value.ParentSharedFolderId != null)
                {
                    WriteProperty("parent_shared_folder_id", value.ParentSharedFolderId, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="Metadata" />.</para>
        /// </summary>
        private class MetadataDecoder : enc.UnionDecoder<Metadata>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="Metadata" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override Metadata Create()
            {
                return new Metadata();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override Metadata Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "file":
                        return FileMetadata.Decoder.DecodeFields(reader);
                    case "folder":
                        return FolderMetadata.Decoder.DecodeFields(reader);
                    case "deleted":
                        return DeletedMetadata.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(Metadata value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "name":
                        value.Name = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "path_lower":
                        value.PathLower = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "path_display":
                        value.PathDisplay = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "parent_shared_folder_id":
                        value.ParentSharedFolderId = enc.StringDecoder.Instance.Decode(reader);
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
