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
    /// Results object for your API call.
    /// </summary>
    [DataContract(Name = "Tools Price Conversion - Results Object")]
    public partial class ToolsPriceConversionResultsObject : IEquatable<ToolsPriceConversionResultsObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsPriceConversionResultsObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ToolsPriceConversionResultsObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsPriceConversionResultsObject" /> class.
        /// </summary>
        /// <param name="id">The unique CoinMarketCap ID for your base currency. (required).</param>
        /// <param name="name">The name of your base currency. (required).</param>
        /// <param name="symbol">The symbol for your base currency. (required).</param>
        /// <param name="amount">Amount of base currency to convert from. (required).</param>
        /// <param name="lastUpdated">Timestamp (ISO 8601) of when the referenced market value of the base currency was recorded. (required).</param>
        /// <param name="quote">quote (required).</param>
        public ToolsPriceConversionResultsObject(int id = default(int), string name = default(string), string symbol = default(string), decimal amount = default(decimal), DateTime lastUpdated = default(DateTime), ToolsPriceConversionQuotesMap quote = default(ToolsPriceConversionQuotesMap))
        {
            this.Id = id;
            this.Name = name;
            this.Symbol = symbol;
            this.Amount = amount;
            this.LastUpdated = lastUpdated;
            // to ensure "quote" is required (not null)
            if (quote == null) {
                throw new ArgumentNullException("quote is a required property for ToolsPriceConversionResultsObject and cannot be null");
            }
            this.Quote = quote;
        }

        /// <summary>
        /// The unique CoinMarketCap ID for your base currency.
        /// </summary>
        /// <value>The unique CoinMarketCap ID for your base currency.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The name of your base currency.
        /// </summary>
        /// <value>The name of your base currency.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The symbol for your base currency.
        /// </summary>
        /// <value>The symbol for your base currency.</value>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = false)]
        public string Symbol { get; set; }

        /// <summary>
        /// Amount of base currency to convert from.
        /// </summary>
        /// <value>Amount of base currency to convert from.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = false)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Timestamp (ISO 8601) of when the referenced market value of the base currency was recorded.
        /// </summary>
        /// <value>Timestamp (ISO 8601) of when the referenced market value of the base currency was recorded.</value>
        [DataMember(Name = "last_updated", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Gets or Sets Quote
        /// </summary>
        [DataMember(Name = "quote", IsRequired = true, EmitDefaultValue = false)]
        public ToolsPriceConversionQuotesMap Quote { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ToolsPriceConversionResultsObject {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
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
            return this.Equals(input as ToolsPriceConversionResultsObject);
        }

        /// <summary>
        /// Returns true if ToolsPriceConversionResultsObject instances are equal
        /// </summary>
        /// <param name="input">Instance of ToolsPriceConversionResultsObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ToolsPriceConversionResultsObject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Symbol != null)
                {
                    hashCode = (hashCode * 59) + this.Symbol.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.LastUpdated != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdated.GetHashCode();
                }
                if (this.Quote != null)
                {
                    hashCode = (hashCode * 59) + this.Quote.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
