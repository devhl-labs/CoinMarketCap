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
    /// An exchange object for every exchange that matched list options.
    /// </summary>
    [DataContract(Name = "Exchange Listings Latest - Exchange object")]
    public partial class ExchangeListingsLatestExchangeObject : IEquatable<ExchangeListingsLatestExchangeObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeListingsLatestExchangeObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExchangeListingsLatestExchangeObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeListingsLatestExchangeObject" /> class.
        /// </summary>
        /// <param name="id">The unique CoinMarketCap ID for this exchange. (required).</param>
        /// <param name="name">The name of this exchange. (required).</param>
        /// <param name="slug">The web URL friendly shorthand version of this exchange name. (required).</param>
        /// <param name="numMarketPairs">The number of trading pairs actively tracked on this exchange..</param>
        /// <param name="dateLaunched">Timestamp (ISO 8601) of the date this exchange launched. *This field is only returned if requested through the &#x60;aux&#x60; request parameter.*.</param>
        /// <param name="exchangeScore">The exchange score..</param>
        /// <param name="liquidityScore">The liquidity score..</param>
        /// <param name="rank">The exchange rank..</param>
        /// <param name="trafficScore">The traffic score..</param>
        /// <param name="lastUpdated">Timestamp (ISO 8601) of the last time this record was upated. (required).</param>
        /// <param name="quote">quote (required).</param>
        public ExchangeListingsLatestExchangeObject(int id = default(int), string name = default(string), string slug = default(string), string numMarketPairs = default(string), DateTime dateLaunched = default(DateTime), decimal exchangeScore = default(decimal), decimal liquidityScore = default(decimal), int rank = default(int), decimal trafficScore = default(decimal), DateTime lastUpdated = default(DateTime), ExchangeListingsLatestQuoteMap quote = default(ExchangeListingsLatestQuoteMap))
        {
            this.Id = id;
            this.Name = name;
            this.Slug = slug;
            this.LastUpdated = lastUpdated;
            // to ensure "quote" is required (not null)
            if (quote == null) {
                throw new ArgumentNullException("quote is a required property for ExchangeListingsLatestExchangeObject and cannot be null");
            }
            this.Quote = quote;
            this.NumMarketPairs = numMarketPairs;
            this.DateLaunched = dateLaunched;
            this.ExchangeScore = exchangeScore;
            this.LiquidityScore = liquidityScore;
            this.Rank = rank;
            this.TrafficScore = trafficScore;
        }

        /// <summary>
        /// The unique CoinMarketCap ID for this exchange.
        /// </summary>
        /// <value>The unique CoinMarketCap ID for this exchange.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The name of this exchange.
        /// </summary>
        /// <value>The name of this exchange.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The web URL friendly shorthand version of this exchange name.
        /// </summary>
        /// <value>The web URL friendly shorthand version of this exchange name.</value>
        [DataMember(Name = "slug", IsRequired = true, EmitDefaultValue = false)]
        public string Slug { get; set; }

        /// <summary>
        /// The number of trading pairs actively tracked on this exchange.
        /// </summary>
        /// <value>The number of trading pairs actively tracked on this exchange.</value>
        [DataMember(Name = "num_market_pairs", EmitDefaultValue = false)]
        public string NumMarketPairs { get; set; }

        /// <summary>
        /// Timestamp (ISO 8601) of the date this exchange launched. *This field is only returned if requested through the &#x60;aux&#x60; request parameter.*
        /// </summary>
        /// <value>Timestamp (ISO 8601) of the date this exchange launched. *This field is only returned if requested through the &#x60;aux&#x60; request parameter.*</value>
        [DataMember(Name = "date_launched", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime DateLaunched { get; set; }

        /// <summary>
        /// The exchange score.
        /// </summary>
        /// <value>The exchange score.</value>
        [DataMember(Name = "exchange_score", EmitDefaultValue = false)]
        public decimal ExchangeScore { get; set; }

        /// <summary>
        /// The liquidity score.
        /// </summary>
        /// <value>The liquidity score.</value>
        [DataMember(Name = "liquidity_score", EmitDefaultValue = false)]
        public decimal LiquidityScore { get; set; }

        /// <summary>
        /// The exchange rank.
        /// </summary>
        /// <value>The exchange rank.</value>
        [DataMember(Name = "rank", EmitDefaultValue = false)]
        public int Rank { get; set; }

        /// <summary>
        /// The traffic score.
        /// </summary>
        /// <value>The traffic score.</value>
        [DataMember(Name = "traffic_score", EmitDefaultValue = false)]
        public decimal TrafficScore { get; set; }

        /// <summary>
        /// Timestamp (ISO 8601) of the last time this record was upated.
        /// </summary>
        /// <value>Timestamp (ISO 8601) of the last time this record was upated.</value>
        [DataMember(Name = "last_updated", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Gets or Sets Quote
        /// </summary>
        [DataMember(Name = "quote", IsRequired = true, EmitDefaultValue = false)]
        public ExchangeListingsLatestQuoteMap Quote { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExchangeListingsLatestExchangeObject {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  NumMarketPairs: ").Append(NumMarketPairs).Append("\n");
            sb.Append("  DateLaunched: ").Append(DateLaunched).Append("\n");
            sb.Append("  ExchangeScore: ").Append(ExchangeScore).Append("\n");
            sb.Append("  LiquidityScore: ").Append(LiquidityScore).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  TrafficScore: ").Append(TrafficScore).Append("\n");
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
            return this.Equals(input as ExchangeListingsLatestExchangeObject);
        }

        /// <summary>
        /// Returns true if ExchangeListingsLatestExchangeObject instances are equal
        /// </summary>
        /// <param name="input">Instance of ExchangeListingsLatestExchangeObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExchangeListingsLatestExchangeObject input)
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
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) && 
                (
                    this.NumMarketPairs == input.NumMarketPairs ||
                    (this.NumMarketPairs != null &&
                    this.NumMarketPairs.Equals(input.NumMarketPairs))
                ) && 
                (
                    this.DateLaunched == input.DateLaunched ||
                    (this.DateLaunched != null &&
                    this.DateLaunched.Equals(input.DateLaunched))
                ) && 
                (
                    this.ExchangeScore == input.ExchangeScore ||
                    this.ExchangeScore.Equals(input.ExchangeScore)
                ) && 
                (
                    this.LiquidityScore == input.LiquidityScore ||
                    this.LiquidityScore.Equals(input.LiquidityScore)
                ) && 
                (
                    this.Rank == input.Rank ||
                    this.Rank.Equals(input.Rank)
                ) && 
                (
                    this.TrafficScore == input.TrafficScore ||
                    this.TrafficScore.Equals(input.TrafficScore)
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
                if (this.Slug != null)
                {
                    hashCode = (hashCode * 59) + this.Slug.GetHashCode();
                }
                if (this.NumMarketPairs != null)
                {
                    hashCode = (hashCode * 59) + this.NumMarketPairs.GetHashCode();
                }
                if (this.DateLaunched != null)
                {
                    hashCode = (hashCode * 59) + this.DateLaunched.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExchangeScore.GetHashCode();
                hashCode = (hashCode * 59) + this.LiquidityScore.GetHashCode();
                hashCode = (hashCode * 59) + this.Rank.GetHashCode();
                hashCode = (hashCode * 59) + this.TrafficScore.GetHashCode();
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
