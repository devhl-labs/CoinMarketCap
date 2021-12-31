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
    /// Results of your query returned as an object.
    /// </summary>
    [DataContract(Name = "Cryptocurrency Market Pairs Latest - Results object")]
    public partial class CryptocurrencyMarketPairsLatestResultsObject : IEquatable<CryptocurrencyMarketPairsLatestResultsObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CryptocurrencyMarketPairsLatestResultsObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CryptocurrencyMarketPairsLatestResultsObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CryptocurrencyMarketPairsLatestResultsObject" /> class.
        /// </summary>
        /// <param name="id">The CoinMarketCap ID for this cryptocurrency. (required).</param>
        /// <param name="name">The name of this cryptocurrency. (required).</param>
        /// <param name="symbol">The symbol for this cryptocurrency. (required).</param>
        /// <param name="numMarketPairs">The number of active market pairs listed for this cryptocurrency. This number is filtered down to only matching markets if a &#x60;matched&#x60; parameter is used..</param>
        /// <param name="marketPairs">Array of all market pairs for this cryptocurrency. (required).</param>
        public CryptocurrencyMarketPairsLatestResultsObject(int id = default(int), string name = default(string), string symbol = default(string), int numMarketPairs = default(int), List<CryptocurrencyMarketPairsLatestMarketPairInfoObject> marketPairs = default(List<CryptocurrencyMarketPairsLatestMarketPairInfoObject>))
        {
            this.Id = id;
            this.Name = name;
            this.Symbol = symbol;
            // to ensure "marketPairs" is required (not null)
            if (marketPairs == null) {
                throw new ArgumentNullException("marketPairs is a required property for CryptocurrencyMarketPairsLatestResultsObject and cannot be null");
            }
            this.MarketPairs = marketPairs;
            this.NumMarketPairs = numMarketPairs;
        }

        /// <summary>
        /// The CoinMarketCap ID for this cryptocurrency.
        /// </summary>
        /// <value>The CoinMarketCap ID for this cryptocurrency.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The name of this cryptocurrency.
        /// </summary>
        /// <value>The name of this cryptocurrency.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The symbol for this cryptocurrency.
        /// </summary>
        /// <value>The symbol for this cryptocurrency.</value>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = false)]
        public string Symbol { get; set; }

        /// <summary>
        /// The number of active market pairs listed for this cryptocurrency. This number is filtered down to only matching markets if a &#x60;matched&#x60; parameter is used.
        /// </summary>
        /// <value>The number of active market pairs listed for this cryptocurrency. This number is filtered down to only matching markets if a &#x60;matched&#x60; parameter is used.</value>
        [DataMember(Name = "num_market_pairs", EmitDefaultValue = false)]
        public int NumMarketPairs { get; set; }

        /// <summary>
        /// Array of all market pairs for this cryptocurrency.
        /// </summary>
        /// <value>Array of all market pairs for this cryptocurrency.</value>
        [DataMember(Name = "market_pairs", IsRequired = true, EmitDefaultValue = false)]
        public List<CryptocurrencyMarketPairsLatestMarketPairInfoObject> MarketPairs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CryptocurrencyMarketPairsLatestResultsObject {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  NumMarketPairs: ").Append(NumMarketPairs).Append("\n");
            sb.Append("  MarketPairs: ").Append(MarketPairs).Append("\n");
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
            return this.Equals(input as CryptocurrencyMarketPairsLatestResultsObject);
        }

        /// <summary>
        /// Returns true if CryptocurrencyMarketPairsLatestResultsObject instances are equal
        /// </summary>
        /// <param name="input">Instance of CryptocurrencyMarketPairsLatestResultsObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CryptocurrencyMarketPairsLatestResultsObject input)
        {
            if (input == null)
                return false;

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
                    this.NumMarketPairs == input.NumMarketPairs ||
                    this.NumMarketPairs.Equals(input.NumMarketPairs)
                ) && 
                (
                    this.MarketPairs == input.MarketPairs ||
                    this.MarketPairs != null &&
                    input.MarketPairs != null &&
                    this.MarketPairs.SequenceEqual(input.MarketPairs)
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                hashCode = hashCode * 59 + this.NumMarketPairs.GetHashCode();
                if (this.MarketPairs != null)
                    hashCode = hashCode * 59 + this.MarketPairs.GetHashCode();
                return hashCode;
            }
        }

    }

}