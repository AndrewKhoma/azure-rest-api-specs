// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication.Messages
{
    /// <summary> Receipt of the sending one message. </summary>
    public partial class MessageReceipt
    {
        /// <summary> Initializes a new instance of <see cref="MessageReceipt"/>. </summary>
        /// <param name="messageId"> The message id. </param>
        /// <param name="to"> The native external platform user identifier of the recipient. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="messageId"/> or <paramref name="to"/> is null. </exception>
        internal MessageReceipt(string messageId, string to)
        {
            Argument.AssertNotNull(messageId, nameof(messageId));
            Argument.AssertNotNull(to, nameof(to));

            MessageId = messageId;
            To = to;
        }

        /// <summary> The message id. </summary>
        public string MessageId { get; }
        /// <summary> The native external platform user identifier of the recipient. </summary>
        public string To { get; }
    }
}