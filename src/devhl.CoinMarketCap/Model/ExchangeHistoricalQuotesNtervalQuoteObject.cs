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
    /// An object containing details for the current interval quote.
    /// </summary>
    [DataContract(Name = "Exchange Historical Quotes - nterval Quote object")]
    public partial class ExchangeHistoricalQuotesNtervalQuoteObject : IEquatable<ExchangeHistoricalQuotesNtervalQuoteObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeHistoricalQuotesNtervalQuoteObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExchangeHistoricalQuotesNtervalQuoteObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeHistoricalQuotesNtervalQuoteObject" /> class.
        /// </summary>
        /// <param name="timestamp">Timestamp (ISO 8601) of when this historical quote was recorded. (required).</param>
        /// <param name="numMarketPairs">Number of market pairs available at the current historical interval. (required).</param>
        /// <param name="quote">quote (required).</param>
        public ExchangeHistoricalQuotesNtervalQuoteObject(DateTime timestamp = default(DateTime), decimal numMarketPairs = default(decimal), ExchangeHistoricalQuotesQuoteCurrencyMap quote = default(ExchangeHistoricalQuotesQuoteCurrencyMap))
        {
            this.Timestamp = timestamp;
            this.NumMarketPairs = numMarketPairs;
            // to ensure "quote" is required (not null)
            if (quote == null) {
                throw new ArgumentNullException("quote is a required property for ExchangeHistoricalQuotesNtervalQuoteObject and cannot be null");
            }
            this.Quote = quote;
        }

        /// <summary>
        /// Timestamp (ISO 8601) of when this historical quote was recorded.
        /// </summary>
        /// <value>Timestamp (ISO 8601) of when this historical quote was recorded.</value>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Number of market pairs available at the current historical interval.
        /// </summary>
        /// <value>Number of market pairs available at the current historical interval.</value>
        [DataMember(Name = "num_market_pairs", IsRequired = true, EmitDefaultValue = false)]
        public decimal NumMarketPairs { get; set; }

        /// <summary>
        /// Gets or Sets Quote
        /// </summary>
        [DataMember(Name = "quote", IsRequired = true, EmitDefaultValue = false)]
        public ExchangeHistoricalQuotesQuoteCurrencyMap Quote { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExchangeHistoricalQuotesNtervalQuoteObject {\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  NumMarketPairs: ").Append(NumMarketPairs).Append("\n");
            sb.Append("  Quote: ").Append(Quote).Append("\n");
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
            return this.Equals(input as ExchangeHistoricalQuotesNtervalQuoteObject);
        }

        /// <summary>
        /// Returns true if ExchangeHistoricalQuotesNtervalQuoteObject instances are equal
        /// </summary>
        /// <param name="input">Instance of ExchangeHistoricalQuotesNtervalQuoteObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExchangeHistoricalQuotesNtervalQuoteObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.NumMarketPairs == input.NumMarketPairs ||
                    this.NumMarketPairs.Equals(input.NumMarketPairs)
                ) && 
                (
                    this.Quote == input.Quote ||
                    (this.Quote != null &&
                    this.Quote.Equals(input.Quote))
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
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                hashCode = hashCode * 59 + this.NumMarketPairs.GetHashCode();
                if (this.Quote != null)
                    hashCode = hashCode * 59 + this.Quote.GetHashCode();
                return hashCode;
            }
        }

    }

}
