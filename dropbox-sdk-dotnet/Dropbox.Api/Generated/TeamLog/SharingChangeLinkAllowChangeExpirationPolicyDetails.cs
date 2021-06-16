// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Changed the password requirement for the links shared outside of the team.</para>
    /// </summary>
    public class SharingChangeLinkAllowChangeExpirationPolicyDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharingChangeLinkAllowChangeExpirationPolicyDetails> Encoder = new SharingChangeLinkAllowChangeExpirationPolicyDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharingChangeLinkAllowChangeExpirationPolicyDetails> Decoder = new SharingChangeLinkAllowChangeExpirationPolicyDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SharingChangeLinkAllowChangeExpirationPolicyDetails" /> class.</para>
        /// </summary>
        /// <param name="newValue">To.</param>
        /// <param name="previousValue">From.</param>
        public SharingChangeLinkAllowChangeExpirationPolicyDetails(EnforceLinkPasswordPolicy newValue,
                                                                   EnforceLinkPasswordPolicy previousValue = null)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SharingChangeLinkAllowChangeExpirationPolicyDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SharingChangeLinkAllowChangeExpirationPolicyDetails()
        {
        }

        /// <summary>
        /// <para>To.</para>
        /// </summary>
        public EnforceLinkPasswordPolicy NewValue { get; protected set; }

        /// <summary>
        /// <para>From.</para>
        /// </summary>
        public EnforceLinkPasswordPolicy PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharingChangeLinkAllowChangeExpirationPolicyDetails"
        /// />.</para>
        /// </summary>
        private class SharingChangeLinkAllowChangeExpirationPolicyDetailsEncoder : enc.StructEncoder<SharingChangeLinkAllowChangeExpirationPolicyDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharingChangeLinkAllowChangeExpirationPolicyDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.EnforceLinkPasswordPolicy.Encoder);
                if (value.PreviousValue != null)
                {
                    WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.EnforceLinkPasswordPolicy.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharingChangeLinkAllowChangeExpirationPolicyDetails"
        /// />.</para>
        /// </summary>
        private class SharingChangeLinkAllowChangeExpirationPolicyDetailsDecoder : enc.StructDecoder<SharingChangeLinkAllowChangeExpirationPolicyDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="SharingChangeLinkAllowChangeExpirationPolicyDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharingChangeLinkAllowChangeExpirationPolicyDetails Create()
            {
                return new SharingChangeLinkAllowChangeExpirationPolicyDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharingChangeLinkAllowChangeExpirationPolicyDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.EnforceLinkPasswordPolicy.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.EnforceLinkPasswordPolicy.Decoder.Decode(reader);
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
