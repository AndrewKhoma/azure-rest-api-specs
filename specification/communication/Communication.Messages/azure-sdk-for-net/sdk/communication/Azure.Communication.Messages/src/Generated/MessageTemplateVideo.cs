// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication.Messages
{
    /// <summary> The message template's video value information. </summary>
    public partial class MessageTemplateVideo : MessageTemplateValue
    {
        /// <summary> Initializes a new instance of <see cref="MessageTemplateVideo"/>. </summary>
        /// <param name="name"> Name of the Template value. </param>
        /// <param name="url"> The (public) URL of the media. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="url"/> is null. </exception>
        public MessageTemplateVideo(string name, Uri url) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(url, nameof(url));

            Kind = "video";
            Url = url;
        }

        /// <summary> Initializes a new instance of <see cref="MessageTemplateVideo"/>. </summary>
        /// <param name="kind"> Discriminator. </param>
        /// <param name="name"> Name of the Template value. </param>
        /// <param name="url"> The (public) URL of the media. </param>
        /// <param name="caption"> The [optional] caption of the media object. </param>
        /// <param name="fileName"> The [optional] filename of the media file. </param>
        internal MessageTemplateVideo(string kind, string name, Uri url, string caption, string fileName) : base(kind, name)
        {
            Url = url;
            Caption = caption;
            FileName = fileName;
        }

        /// <summary> The (public) URL of the media. </summary>
        public Uri Url { get; }
        /// <summary> The [optional] caption of the media object. </summary>
        public string Caption { get; set; }
        /// <summary> The [optional] filename of the media file. </summary>
        public string FileName { get; set; }
    }
}