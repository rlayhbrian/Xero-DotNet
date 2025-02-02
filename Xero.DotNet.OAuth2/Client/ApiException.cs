/* 
 * Xero Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;

namespace Xero.DotNet.OAuth2.Client
{
    /// <summary>
    /// API Exception
    /// </summary>
    public class ApiException : Exception
    {
        /// <summary>
        /// Gets or sets the error code (HTTP status code)
        /// </summary>
        /// <value>The error code (HTTP status code).</value>
        public int ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets the error content (body json object)
        /// </summary>
        /// <value>The error content (Http response body).</value>
        public dynamic ErrorContent { get; private set; }

        /// <summary>
        /// Gets or sets retry after value
        /// </summary>
        /// <value>
        /// The number of seconds the client should wait before retrying the request.
        /// Set from the value of the Retry-After header returned by the server.
        /// </value>
        public int? RetryAfter { get; private set; }

        /// <summary>
        /// Gets or sets the limit type value
        /// </summary>
        /// <value>The type of the rate limit hit, such as minute or daily.</value>
        public string LimitType { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        public ApiException() {}

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        /// <param name="errorCode">HTTP status code.</param>
        /// <param name="message">Error message.</param>
        public ApiException(int errorCode, string message) : base(message)
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        /// <param name="errorCode">HTTP status code.</param>
        /// <param name="message">Error message.</param>
        /// <param name="errorContent">Error content.</param>
        public ApiException(int errorCode, string message, dynamic errorContent = null) : base(message)
        {
            this.ErrorCode = errorCode;
            this.ErrorContent = errorContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class for the case when a rate limit is hit.
        /// </summary>
        /// <param name="errorCode">HTTP status code.</param>
        /// <param name="message">Error message.</param>
        /// <param name="errorContent">Error content.</param>
        /// <param name="limitType">The type of limit hit.</param>
        /// <param name="retryAfter">Number of seconds to wait before retrying.</param>
        public ApiException(int errorCode, string message, dynamic errorContent, int retryAfter, string limitType) : base(message)
        {
            this.ErrorCode = errorCode;
            this.ErrorContent = errorContent;
            this.LimitType = limitType;
            this.RetryAfter = retryAfter;
        }
    }

}
