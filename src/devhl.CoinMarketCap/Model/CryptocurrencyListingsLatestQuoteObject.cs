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
    /// A market quote in the currency conversion option.
    /// </summary>
    [DataContract(Name = "Cryptocurrency Listings Latest - Quote object")]
    public partial class CryptocurrencyListingsLatestQuoteObject : IEquatable<CryptocurrencyListingsLatestQuoteObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CryptocurrencyListingsLatestQuoteObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CryptocurrencyListingsLatestQuoteObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CryptocurrencyListingsLatestQuoteObject" /> class.
        /// </summary>
        /// <param name="price">Price in the specified currency at the end of the requested UTC day. (required).</param>
        /// <param name="volume24h">24 hour adjusted volume in the specified currency at the end of the requested UTC day. (required).</param>
        /// <param name="marketCap">Market cap in the specified currency at the end of the requested UTC day. (required).</param>
        /// <param name="percentChange1h">1 hour change in the specified currency at the end of the requested UTC day. (required).</param>
        /// <param name="percentChange24h">24 hour change in the specified currency at the end of the requested UTC day. (required).</param>
        /// <param name="percentChange7d">7 day change in the specified currency at the end of the requested UTC day. (required).</param>
        /// <param name="lastUpdated">Timestamp (ISO 8601) of when the conversion currency&#39;s current value was referenced. (required).</param>
        public CryptocurrencyListingsLatestQuoteObject(decimal price = default(decimal), decimal volume24h = default(decimal), decimal marketCap = default(decimal), decimal percentChange1h = default(decimal), decimal percentChange24h = default(decimal), decimal percentChange7d = default(decimal), DateTime lastUpdated = default(DateTime))
        {
            this.Price = price;
            this.Volume24h = volume24h;
            this.MarketCap = marketCap;
            this.PercentChange1h = percentChange1h;
            this.PercentChange24h = percentChange24h;
            this.PercentChange7d = percentChange7d;
            this.LastUpdated = lastUpdated;
        }

        /// <summary>
        /// Price in the specified currency at the end of the requested UTC day.
        /// </summary>
        /// <value>Price in the specified currency at the end of the requested UTC day.</value>
        [DataMember(Name = "price", IsRequired = true, EmitDefaultValue = false)]
        public decimal Price { get; set; }

        /// <summary>
        /// 24 hour adjusted volume in the specified currency at the end of the requested UTC day.
        /// </summary>
        /// <value>24 hour adjusted volume in the specified currency at the end of the requested UTC day.</value>
        [DataMember(Name = "volume_24h", IsRequired = true, EmitDefaultValue = false)]
        public decimal Volume24h { get; set; }

        /// <summary>
        /// Market cap in the specified currency at the end of the requested UTC day.
        /// </summary>
        /// <value>Market cap in the specified currency at the end of the requested UTC day.</value>
        [DataMember(Name = "market_cap", IsRequired = true, EmitDefaultValue = false)]
        public decimal MarketCap { get; set; }

        /// <summary>
        /// 1 hour change in the specified currency at the end of the requested UTC day.
        /// </summary>
        /// <value>1 hour change in the specified currency at the end of the requested UTC day.</value>
        [DataMember(Name = "percent_change_1h", IsRequired = true, EmitDefaultValue = false)]
        public decimal PercentChange1h { get; set; }

        /// <summary>
        /// 24 hour change in the specified currency at the end of the requested UTC day.
        /// </summary>
        /// <value>24 hour change in the specified currency at the end of the requested UTC day.</value>
        [DataMember(Name = "percent_change_24h", IsRequired = true, EmitDefaultValue = false)]
        public decimal PercentChange24h { get; set; }

        /// <summary>
        /// 7 day change in the specified currency at the end of the requested UTC day.
        /// </summary>
        /// <value>7 day change in the specified currency at the end of the requested UTC day.</value>
        [DataMember(Name = "percent_change_7d", IsRequired = true, EmitDefaultValue = false)]
        public decimal PercentChange7d { get; set; }

        /// <summary>
        /// Timestamp (ISO 8601) of when the conversion currency&#39;s current value was referenced.
        /// </summary>
        /// <value>Timestamp (ISO 8601) of when the conversion currency&#39;s current value was referenced.</value>
        [DataMember(Name = "last_updated", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CryptocurrencyListingsLatestQuoteObject {\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Volume24h: ").Append(Volume24h).Append("\n");
            sb.Append("  MarketCap: ").Append(MarketCap).Append("\n");
            sb.Append("  PercentChange1h: ").Append(PercentChange1h).Append("\n");
            sb.Append("  PercentChange24h: ").Append(PercentChange24h).Append("\n");
            sb.Append("  PercentChange7d: ").Append(PercentChange7d).Append("\n");
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
            return this.Equals(input as CryptocurrencyListingsLatestQuoteObject);
        }

        /// <summary>
        /// Returns true if CryptocurrencyListingsLatestQuoteObject instances are equal
        /// </summary>
        /// <param name="input">Instance of CryptocurrencyListingsLatestQuoteObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CryptocurrencyListingsLatestQuoteObject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.Volume24h == input.Volume24h ||
                    this.Volume24h.Equals(input.Volume24h)
                ) && 
                (
                    this.MarketCap == input.MarketCap ||
                    this.MarketCap.Equals(input.MarketCap)
                ) && 
                (
                    this.PercentChange1h == input.PercentChange1h ||
                    this.PercentChange1h.Equals(input.PercentChange1h)
                ) && 
                (
                    this.PercentChange24h == input.PercentChange24h ||
                    this.PercentChange24h.Equals(input.PercentChange24h)
                ) && 
                (
                    this.PercentChange7d == input.PercentChange7d ||
                    this.PercentChange7d.Equals(input.PercentChange7d)
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
                hashCode = (hashCode * 59) + this.Price.GetHashCode();
                hashCode = (hashCode * 59) + this.Volume24h.GetHashCode();
                hashCode = (hashCode * 59) + this.MarketCap.GetHashCode();
                hashCode = (hashCode * 59) + this.PercentChange1h.GetHashCode();
                hashCode = (hashCode * 59) + this.PercentChange24h.GetHashCode();
                hashCode = (hashCode * 59) + this.PercentChange7d.GetHashCode();
                if (this.LastUpdated != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdated.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
