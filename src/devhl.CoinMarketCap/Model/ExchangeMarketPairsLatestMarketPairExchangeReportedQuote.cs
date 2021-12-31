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
    /// A default exchange reported quote containing raw exchange reported values.
    /// </summary>
    [DataContract(Name = "Exchange Market Pairs Latest - Market Pair Exchange Reported Quote")]
    public partial class ExchangeMarketPairsLatestMarketPairExchangeReportedQuote : IEquatable<ExchangeMarketPairsLatestMarketPairExchangeReportedQuote>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeMarketPairsLatestMarketPairExchangeReportedQuote" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExchangeMarketPairsLatestMarketPairExchangeReportedQuote() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeMarketPairsLatestMarketPairExchangeReportedQuote" /> class.
        /// </summary>
        /// <param name="price">The last exchange reported price for this market pair in quote currency units. (required).</param>
        /// <param name="volume24hBase">The last exchange reported 24 hour volume for this market pair in base cryptocurrency units. (required).</param>
        /// <param name="volume24hQuote">The last exchange reported 24 hour volume for this market pair in quote cryptocurrency units. (required).</param>
        /// <param name="volumePercentage">Percentage of total exchange volume_24h (required).</param>
        /// <param name="lastUpdated">Timestamp (ISO 8601) of the last time this market data was updated. (required).</param>
        public ExchangeMarketPairsLatestMarketPairExchangeReportedQuote(decimal price = default(decimal), decimal volume24hBase = default(decimal), decimal volume24hQuote = default(decimal), decimal volumePercentage = default(decimal), DateTime lastUpdated = default(DateTime))
        {
            this.Price = price;
            this.Volume24hBase = volume24hBase;
            this.Volume24hQuote = volume24hQuote;
            this.VolumePercentage = volumePercentage;
            this.LastUpdated = lastUpdated;
        }

        /// <summary>
        /// The last exchange reported price for this market pair in quote currency units.
        /// </summary>
        /// <value>The last exchange reported price for this market pair in quote currency units.</value>
        [DataMember(Name = "price", IsRequired = true, EmitDefaultValue = false)]
        public decimal Price { get; set; }

        /// <summary>
        /// The last exchange reported 24 hour volume for this market pair in base cryptocurrency units.
        /// </summary>
        /// <value>The last exchange reported 24 hour volume for this market pair in base cryptocurrency units.</value>
        [DataMember(Name = "volume_24h_base", IsRequired = true, EmitDefaultValue = false)]
        public decimal Volume24hBase { get; set; }

        /// <summary>
        /// The last exchange reported 24 hour volume for this market pair in quote cryptocurrency units.
        /// </summary>
        /// <value>The last exchange reported 24 hour volume for this market pair in quote cryptocurrency units.</value>
        [DataMember(Name = "volume_24h_quote", IsRequired = true, EmitDefaultValue = false)]
        public decimal Volume24hQuote { get; set; }

        /// <summary>
        /// Percentage of total exchange volume_24h
        /// </summary>
        /// <value>Percentage of total exchange volume_24h</value>
        [DataMember(Name = "volume_percentage", IsRequired = true, EmitDefaultValue = false)]
        public decimal VolumePercentage { get; set; }

        /// <summary>
        /// Timestamp (ISO 8601) of the last time this market data was updated.
        /// </summary>
        /// <value>Timestamp (ISO 8601) of the last time this market data was updated.</value>
        [DataMember(Name = "last_updated", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExchangeMarketPairsLatestMarketPairExchangeReportedQuote {\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Volume24hBase: ").Append(Volume24hBase).Append("\n");
            sb.Append("  Volume24hQuote: ").Append(Volume24hQuote).Append("\n");
            sb.Append("  VolumePercentage: ").Append(VolumePercentage).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
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
            return this.Equals(input as ExchangeMarketPairsLatestMarketPairExchangeReportedQuote);
        }

        /// <summary>
        /// Returns true if ExchangeMarketPairsLatestMarketPairExchangeReportedQuote instances are equal
        /// </summary>
        /// <param name="input">Instance of ExchangeMarketPairsLatestMarketPairExchangeReportedQuote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExchangeMarketPairsLatestMarketPairExchangeReportedQuote input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.Volume24hBase == input.Volume24hBase ||
                    this.Volume24hBase.Equals(input.Volume24hBase)
                ) && 
                (
                    this.Volume24hQuote == input.Volume24hQuote ||
                    this.Volume24hQuote.Equals(input.Volume24hQuote)
                ) && 
                (
                    this.VolumePercentage == input.VolumePercentage ||
                    this.VolumePercentage.Equals(input.VolumePercentage)
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
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
                hashCode = hashCode * 59 + this.Price.GetHashCode();
                hashCode = hashCode * 59 + this.Volume24hBase.GetHashCode();
                hashCode = hashCode * 59 + this.Volume24hQuote.GetHashCode();
                hashCode = hashCode * 59 + this.VolumePercentage.GetHashCode();
                if (this.LastUpdated != null)
                    hashCode = hashCode * 59 + this.LastUpdated.GetHashCode();
                return hashCode;
            }
        }

    }

}
