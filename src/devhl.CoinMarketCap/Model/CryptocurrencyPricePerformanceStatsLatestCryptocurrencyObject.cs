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
    /// A cryptocurrency object for each requested.
    /// </summary>
    [DataContract(Name = "Cryptocurrency Price Performance Stats Latest - Cryptocurrency object")]
    public partial class CryptocurrencyPricePerformanceStatsLatestCryptocurrencyObject : IEquatable<CryptocurrencyPricePerformanceStatsLatestCryptocurrencyObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CryptocurrencyPricePerformanceStatsLatestCryptocurrencyObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CryptocurrencyPricePerformanceStatsLatestCryptocurrencyObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CryptocurrencyPricePerformanceStatsLatestCryptocurrencyObject" /> class.
        /// </summary>
        /// <param name="id">The unique CoinMarketCap ID for this cryptocurrency. (required).</param>
        /// <param name="name">The name of this cryptocurrency. (required).</param>
        /// <param name="symbol">The ticker symbol for this cryptocurrency. (required).</param>
        /// <param name="slug">The web URL friendly shorthand version of this cryptocurrency name. (required).</param>
        /// <param name="lastUpdated">Timestamp (ISO 8601) of the last time this cryptocurrency&#39;s market data was updated. (required).</param>
        /// <param name="periods">periods (required).</param>
        public CryptocurrencyPricePerformanceStatsLatestCryptocurrencyObject(int id = default(int), string name = default(string), string symbol = default(string), string slug = default(string), DateTime lastUpdated = default(DateTime), CryptocurrencyPricePerformanceStatsLatestPeriodObjectMap periods = default(CryptocurrencyPricePerformanceStatsLatestPeriodObjectMap))
        {
            this.Id = id;
            this.Name = name;
            this.Symbol = symbol;
            this.Slug = slug;
            this.LastUpdated = lastUpdated;
            // to ensure "periods" is required (not null)
            if (periods == null) {
                throw new ArgumentNullException("periods is a required property for CryptocurrencyPricePerformanceStatsLatestCryptocurrencyObject and cannot be null");
            }
            this.Periods = periods;
        }

        /// <summary>
        /// The unique CoinMarketCap ID for this cryptocurrency.
        /// </summary>
        /// <value>The unique CoinMarketCap ID for this cryptocurrency.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The name of this cryptocurrency.
        /// </summary>
        /// <value>The name of this cryptocurrency.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The ticker symbol for this cryptocurrency.
        /// </summary>
        /// <value>The ticker symbol for this cryptocurrency.</value>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = false)]
        public string Symbol { get; set; }

        /// <summary>
        /// The web URL friendly shorthand version of this cryptocurrency name.
        /// </summary>
        /// <value>The web URL friendly shorthand version of this cryptocurrency name.</value>
        [DataMember(Name = "slug", IsRequired = true, EmitDefaultValue = false)]
        public string Slug { get; set; }

        /// <summary>
        /// Timestamp (ISO 8601) of the last time this cryptocurrency&#39;s market data was updated.
        /// </summary>
        /// <value>Timestamp (ISO 8601) of the last time this cryptocurrency&#39;s market data was updated.</value>
        [DataMember(Name = "last_updated", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Gets or Sets Periods
        /// </summary>
        [DataMember(Name = "periods", IsRequired = true, EmitDefaultValue = false)]
        public CryptocurrencyPricePerformanceStatsLatestPeriodObjectMap Periods { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CryptocurrencyPricePerformanceStatsLatestCryptocurrencyObject {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  Periods: ").Append(Periods).Append("\n");
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
            return this.Equals(input as CryptocurrencyPricePerformanceStatsLatestCryptocurrencyObject);
        }

        /// <summary>
        /// Returns true if CryptocurrencyPricePerformanceStatsLatestCryptocurrencyObject instances are equal
        /// </summary>
        /// <param name="input">Instance of CryptocurrencyPricePerformanceStatsLatestCryptocurrencyObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CryptocurrencyPricePerformanceStatsLatestCryptocurrencyObject input)
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
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
                ) && 
                (
                    this.Periods == input.Periods ||
                    (this.Periods != null &&
                    this.Periods.Equals(input.Periods))
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
                if (this.Slug != null)
                {
                    hashCode = (hashCode * 59) + this.Slug.GetHashCode();
                }
                if (this.LastUpdated != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdated.GetHashCode();
                }
                if (this.Periods != null)
                {
                    hashCode = (hashCode * 59) + this.Periods.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
