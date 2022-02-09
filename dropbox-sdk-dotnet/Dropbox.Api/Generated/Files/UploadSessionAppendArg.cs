// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The upload session append arg object</para>
    /// </summary>
    public class UploadSessionAppendArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UploadSessionAppendArg> Encoder = new UploadSessionAppendArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UploadSessionAppendArg> Decoder = new UploadSessionAppendArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UploadSessionAppendArg" />
        /// class.</para>
        /// </summary>
        /// <param name="cursor">Contains the upload session ID and the offset.</param>
        /// <param name="close">If true, the current session will be closed, at which point you
        /// won't be able to call <see
        /// cref="Dropbox.Api.Files.Routes.FilesUserRoutes.UploadSessionAppendV2Async" />
        /// anymore with the current session.</param>
        /// <param name="contentHash">NOT YET SUPPORTED. A hash of the file content uploaded in
        /// this call. If provided and the uploaded content does not match this hash, an error
        /// will be returned. For more information see our <a
        /// href="https://www.dropbox.com/developers/reference/content-hash">Content hash</a>
        /// page.</param>
        public UploadSessionAppendArg(UploadSessionCursor cursor,
                                      bool close = false,
                                      string contentHash = null)
        {
            if (cursor == null)
            {
                throw new sys.ArgumentNullException("cursor");
            }

            if (contentHash != null)
            {
                if (contentHash.Length < 64)
                {
                    throw new sys.ArgumentOutOfRangeException("contentHash", "Length should be at least 64");
                }
                if (contentHash.Length > 64)
                {
                    throw new sys.ArgumentOutOfRangeException("contentHash", "Length should be at most 64");
                }
            }

            this.Cursor = cursor;
            this.Close = close;
            this.ContentHash = contentHash;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UploadSessionAppendArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public UploadSessionAppendArg()
        {
            this.Close = false;
        }

        /// <summary>
        /// <para>Contains the upload session ID and the offset.</para>
        /// </summary>
        public UploadSessionCursor Cursor { get; protected set; }

        /// <summary>
        /// <para>If true, the current session will be closed, at which point you won't be able
        /// to call <see
        /// cref="Dropbox.Api.Files.Routes.FilesUserRoutes.UploadSessionAppendV2Async" />
        /// anymore with the current session.</para>
        /// </summary>
        public bool Close { get; protected set; }

        /// <summary>
        /// <para>NOT YET SUPPORTED. A hash of the file content uploaded in this call. If
        /// provided and the uploaded content does not match this hash, an error will be
        /// returned. For more information see our <a
        /// href="https://www.dropbox.com/developers/reference/content-hash">Content hash</a>
        /// page.</para>
        /// </summary>
        public string ContentHash { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="UploadSessionAppendArg" />.</para>
        /// </summary>
        private class UploadSessionAppendArgEncoder : enc.StructEncoder<UploadSessionAppendArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UploadSessionAppendArg value, enc.IJsonWriter writer)
            {
                WriteProperty("cursor", value.Cursor, writer, global::Dropbox.Api.Files.UploadSessionCursor.Encoder);
                WriteProperty("close", value.Close, writer, enc.BooleanEncoder.Instance);
                if (value.ContentHash != null)
                {
                    WriteProperty("content_hash", value.ContentHash, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="UploadSessionAppendArg" />.</para>
        /// </summary>
        private class UploadSessionAppendArgDecoder : enc.StructDecoder<UploadSessionAppendArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UploadSessionAppendArg"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UploadSessionAppendArg Create()
            {
                return new UploadSessionAppendArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(UploadSessionAppendArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "cursor":
                        value.Cursor = global::Dropbox.Api.Files.UploadSessionCursor.Decoder.Decode(reader);
                        break;
                    case "close":
                        value.Close = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "content_hash":
                        value.ContentHash = enc.StringDecoder.Instance.Decode(reader);
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
