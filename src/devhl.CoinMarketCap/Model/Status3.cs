/*
 * CoinMarketCap Cryptocurrency API Documentation
 *
 * # Introduction The CoinMarketCap API is a suite of high-performance RESTful JSON endpoints that are specifically designed to meet the mission-critical demands of application developers, data scientists, and enterprise business platforms.  This API reference includes all technical documentation developers need to integrate third-party applications and platforms. Additional answers to common questions can be found in the [CoinMarketCap API FAQ](https://coinmarketcap.com/api/faq).  # Quick Start Guide  For developers eager to hit the ground running with the CoinMarketCap API here are a few quick steps to make your first call with the API.  1. **Sign up for a free Developer Portal account.** You can sign up at [pro.coinmarketcap.com](https://pro.coinmarketcap.com) - This is our live production environment with the latest market data. Select the free `Basic` plan if it meets your needs or upgrade to a paid tier. 2. **Copy your API Key.** Once you sign up you'll land on your Developer Portal account dashboard. Copy your API from the `API Key` box in the top left panel. 3. **Make a test call using your key.** You may use the code examples provided below to make a test call with your programming language of choice. This example [fetches all active cryptocurrencies by market cap and return market values in USD](https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest?start=1&limit=5000&convert=USD).     *Be sure to replace the API Key in sample code with your own and use API domain `pro-api.coinmarketcap.com` or use the test API Key `b54bcf4d-1bca-4e8e-9a24-22ff2c3d462c` for `sandbox-api.coinmarketcap.com` testing with our sandbox.coinmarketcap.com environment. Please note that our sandbox api has mock data and should not be used in your application.*
 *
 * The version of the OpenAPI document: 1.26.0
 * Contact: api@coinmarketcap.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = devhl.CoinMarketCap.Client.OpenAPIDateConverter;

namespace devhl.CoinMarketCap.Model
{
    /// <summary>
    /// Status3
    /// </summary>
    [DataContract(Name = "status 3")]
    public partial class Status3 : IEquatable<Status3>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Status3" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Status3() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Status3" /> class.
        /// </summary>
        /// <param name="timestamp">Current ISO 8601 timestamp on the server. (required).</param>
        /// <param name="errorCode">An internal error code string for the current error. If a unique platform error code is not available the HTTP status code is returned. (required).</param>
        /// <param name="errorMessage">An error message to go along with the error code. (required).</param>
        /// <param name="elapsed">Number of milliseconds taken to generate this response (required).</param>
        /// <param name="creditCount">Number of API call credits required for this call. Always 0 for errors. (required).</param>
        public Status3(DateTime timestamp = default(DateTime), int errorCode = default(int), string errorMessage = default(string), int elapsed = default(int), int creditCount = default(int))
        {
            this.Timestamp = timestamp;
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage;
            this.Elapsed = elapsed;
            this.CreditCount = creditCount;
        }

        /// <summary>
        /// Current ISO 8601 timestamp on the server.
        /// </summary>
        /// <value>Current ISO 8601 timestamp on the server.</value>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// An internal error code string for the current error. If a unique platform error code is not available the HTTP status code is returned.
        /// </summary>
        /// <value>An internal error code string for the current error. If a unique platform error code is not available the HTTP status code is returned.</value>
        [DataMember(Name = "error_code", IsRequired = true, EmitDefaultValue = false)]
        public int ErrorCode { get; set; }

        /// <summary>
        /// An error message to go along with the error code.
        /// </summary>
        /// <value>An error message to go along with the error code.</value>
        [DataMember(Name = "error_message", IsRequired = true, EmitDefaultValue = false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Number of milliseconds taken to generate this response
        /// </summary>
        /// <value>Number of milliseconds taken to generate this response</value>
        [DataMember(Name = "elapsed", IsRequired = true, EmitDefaultValue = false)]
        public int Elapsed { get; set; }

        /// <summary>
        /// Number of API call credits required for this call. Always 0 for errors.
        /// </summary>
        /// <value>Number of API call credits required for this call. Always 0 for errors.</value>
        [DataMember(Name = "credit_count", IsRequired = true, EmitDefaultValue = false)]
        public int CreditCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Status3 {\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  Elapsed: ").Append(Elapsed).Append("\n");
            sb.Append("  CreditCount: ").Append(CreditCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Status3);
        }

        /// <summary>
        /// Returns true if Status3 instances are equal
        /// </summary>
        /// <param name="input">Instance of Status3 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Status3 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    this.ErrorCode.Equals(input.ErrorCode)
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.Elapsed == input.Elapsed ||
                    this.Elapsed.Equals(input.Elapsed)
                ) && 
                (
                    this.CreditCount == input.CreditCount ||
                    this.CreditCount.Equals(input.CreditCount)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ErrorCode.GetHashCode();
                if (this.ErrorMessage != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorMessage.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Elapsed.GetHashCode();
                hashCode = (hashCode * 59) + this.CreditCount.GetHashCode();
                return hashCode;
            }
        }

    }

}
