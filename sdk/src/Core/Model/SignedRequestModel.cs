using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Core.Model
{
    /// <summary>
    /// the sign result
    /// </summary>
    public class SignedRequestModel
    {
        /// <summary>
        /// sign nonce id
        /// </summary>
        public string RequestNonceId { get; set; }

        /// <summary>
        /// the after sign all request head
        /// </summary>
        public Dictionary<string, string> RequestHead { get; set; } = new Dictionary<string, string>();


        /// <summary>
        /// the request body content sha 256 string
        /// </summary>
        public string ContentSHA256 { get; set; }


        /// <summary>
        /// the canonical request string
        /// </summary>
        public string CanonicalRequest { get; set; }

        /// <summary>
        /// the last string which need sign
        /// </summary>
        public string StringToSign { get; set; }

        /// <summary>
        /// string signature
        /// </summary>
        public string StringSignature { get; set; }

        /// <summary>
        /// the header need to signed
        /// </summary>
        public string SignedHeaders { get; set; }
    }
}
