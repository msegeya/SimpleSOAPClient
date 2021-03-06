#region License
// The MIT License (MIT)
// 
// Copyright (c) 2016 Jo�o Sim�es
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
#endregion
namespace SimpleSOAPClient.Handlers
{
    using System;
    using Models;
    using Models.V1Dot1;

    /// <summary>
    /// The SOAP Handler arguments for <see cref="ISoapHandler.OnSoapEnvelopeV1Dot1Request"/> method.
    /// </summary>
    public sealed class OnSoapEnvelopeV1Dot1RequestArguments : SoapHandlerArguments
    {
        private SoapEnvelope _envelope;

        /// <summary>
        /// Creates a new instance
        /// </summary>
        /// <param name="envelope">The SOAP envelope version 1.1</param>
        /// <param name="url">The SOAP service url</param>
        /// <param name="action">The SOAP action</param>
        /// <param name="trackingId">An optional tracking id</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public OnSoapEnvelopeV1Dot1RequestArguments(SoapEnvelope envelope, string url, string action, Guid? trackingId = null)
            : base(url, action, trackingId)
        {
            if (envelope == null) throw new ArgumentNullException(nameof(envelope));

            _envelope = envelope;
        }

        /// <summary>
        /// The SOAP Envelope to be serialized
        /// </summary>
        public SoapEnvelope Envelope
        {
            get { return _envelope; }
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
                _envelope = value;
            }
        }
    }
}