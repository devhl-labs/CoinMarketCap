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
    /// A results object for each cryptocurrency found in the category.
    /// </summary>
    [DataContract(Name = "Category - Cryptocurrency object")]
    public partial class CategoryCryptocurrencyObject : IEquatable<CategoryCryptocurrencyObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryCryptocurrencyObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CategoryCryptocurrencyObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryCryptocurrencyObject" /> class.
        /// </summary>
        /// <param name="id">The unique ID of the category (required).</param>
        /// <param name="name">The name of the category.</param>
        /// <param name="title">The title of the category.</param>
        /// <param name="description">The description of the category.</param>
        /// <param name="numTokens">numTokens.</param>
        /// <param name="avgPriceChange">Average price change of coins within this categry (required).</param>
        /// <param name="marketCap">Market cap of coins within this categry (required).</param>
        /// <param name="marketCapChange">Market cap change of coins within this categry (required).</param>
        /// <param name="volume">Volume of coins within this categry (required).</param>
        /// <param name="volumeChange">Volume change of coins within this categry (required).</param>
        /// <param name="coins">Array of cryptocurrency objects matching the list options. (required).</param>
        /// <param name="lastUpdated">Timestamp (ISO 8601) of when this was last updated. (required).</param>
        public CategoryCryptocurrencyObject(int id = default(int), string name = default(string), string title = default(string), string description = default(string), int numTokens = default(int), decimal avgPriceChange = default(decimal), decimal marketCap = default(decimal), decimal marketCapChange = default(decimal), decimal volume = default(decimal), decimal volumeChange = default(decimal), List<CryptocurrencyCryptocurrencyObject> coins = default(List<CryptocurrencyCryptocurrencyObject>), DateTime lastUpdated = default(DateTime))
        {
            this.Id = id;
            this.AvgPriceChange = avgPriceChange;
            this.MarketCap = marketCap;
            this.MarketCapChange = marketCapChange;
            this.Volume = volume;
            this.VolumeChange = volumeChange;
            // to ensure "coins" is required (not null)
            if (coins == null) {
                throw new ArgumentNullException("coins is a required property for CategoryCryptocurrencyObject and cannot be null");
            }
            this.Coins = coins;
            this.LastUpdated = lastUpdated;
            this.Name = name;
            this.Title = title;
            this.Description = description;
            this.NumTokens = numTokens;
        }

        /// <summary>
        /// The unique ID of the category
        /// </summary>
        /// <value>The unique ID of the category</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The name of the category
        /// </summary>
        /// <value>The name of the category</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The title of the category
        /// </summary>
        /// <value>The title of the category</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// The description of the category
        /// </summary>
        /// <value>The description of the category</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets NumTokens
        /// </summary>
        [DataMember(Name = "num_tokens", EmitDefaultValue = false)]
        public int NumTokens { get; set; }

        /// <summary>
        /// Average price change of coins within this categry
        /// </summary>
        /// <value>Average price change of coins within this categry</value>
        [DataMember(Name = "avg_price_change", IsRequired = true, EmitDefaultValue = false)]
        public decimal AvgPriceChange { get; set; }

        /// <summary>
        /// Market cap of coins within this categry
        /// </summary>
        /// <value>Market cap of coins within this categry</value>
        [DataMember(Name = "market_cap", IsRequired = true, EmitDefaultValue = false)]
        public decimal MarketCap { get; set; }

        /// <summary>
        /// Market cap change of coins within this categry
        /// </summary>
        /// <value>Market cap change of coins within this categry</value>
        [DataMember(Name = "market_cap_change", IsRequired = true, EmitDefaultValue = false)]
        public decimal MarketCapChange { get; set; }

        /// <summary>
        /// Volume of coins within this categry
        /// </summary>
        /// <value>Volume of coins within this categry</value>
        [DataMember(Name = "volume", IsRequired = true, EmitDefaultValue = false)]
        public decimal Volume { get; set; }

        /// <summary>
        /// Volume change of coins within this categry
        /// </summary>
        /// <value>Volume change of coins within this categry</value>
        [DataMember(Name = "volume_change", IsRequired = true, EmitDefaultValue = false)]
        public decimal VolumeChange { get; set; }

        /// <summary>
        /// Array of cryptocurrency objects matching the list options.
        /// </summary>
        /// <value>Array of cryptocurrency objects matching the list options.</value>
        [DataMember(Name = "coins", IsRequired = true, EmitDefaultValue = false)]
        public List<CryptocurrencyCryptocurrencyObject> Coins { get; set; }

        /// <summary>
        /// Timestamp (ISO 8601) of when this was last updated.
        /// </summary>
        /// <value>Timestamp (ISO 8601) of when this was last updated.</value>
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
            sb.Append("class CategoryCryptocurrencyObject {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  NumTokens: ").Append(NumTokens).Append("\n");
            sb.Append("  AvgPriceChange: ").Append(AvgPriceChange).Append("\n");
            sb.Append("  MarketCap: ").Append(MarketCap).Append("\n");
            sb.Append("  MarketCapChange: ").Append(MarketCapChange).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  VolumeChange: ").Append(VolumeChange).Append("\n");
            sb.Append("  Coins: ").Append(Coins).Append("\n");
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
            return this.Equals(input as CategoryCryptocurrencyObject);
        }

        /// <summary>
        /// Returns true if CategoryCryptocurrencyObject instances are equal
        /// </summary>
        /// <param name="input">Instance of CategoryCryptocurrencyObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CategoryCryptocurrencyObject input)
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
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.NumTokens == input.NumTokens ||
                    this.NumTokens.Equals(input.NumTokens)
                ) && 
                (
                    this.AvgPriceChange == input.AvgPriceChange ||
                    this.AvgPriceChange.Equals(input.AvgPriceChange)
                ) && 
                (
                    this.MarketCap == input.MarketCap ||
                    this.MarketCap.Equals(input.MarketCap)
                ) && 
                (
                    this.MarketCapChange == input.MarketCapChange ||
                    this.MarketCapChange.Equals(input.MarketCapChange)
                ) && 
                (
                    this.Volume == input.Volume ||
                    this.Volume.Equals(input.Volume)
                ) && 
                (
                    this.VolumeChange == input.VolumeChange ||
                    this.VolumeChange.Equals(input.VolumeChange)
                ) && 
                (
                    this.Coins == input.Coins ||
                    this.Coins != null &&
                    input.Coins != null &&
                    this.Coins.SequenceEqual(input.Coins)
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.NumTokens.GetHashCode();
                hashCode = hashCode * 59 + this.AvgPriceChange.GetHashCode();
                hashCode = hashCode * 59 + this.MarketCap.GetHashCode();
                hashCode = hashCode * 59 + this.MarketCapChange.GetHashCode();
                hashCode = hashCode * 59 + this.Volume.GetHashCode();
                hashCode = hashCode * 59 + this.VolumeChange.GetHashCode();
                if (this.Coins != null)
                    hashCode = hashCode * 59 + this.Coins.GetHashCode();
                if (this.LastUpdated != null)
                    hashCode = hashCode * 59 + this.LastUpdated.GetHashCode();
                return hashCode;
            }
        }

    }

}