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
    /// Market Pair info object.
    /// </summary>
    [DataContract(Name = "Cryptocurrency Market Pairs Latest - Market Pair Info object")]
    public partial class CryptocurrencyMarketPairsLatestMarketPairInfoObject : IEquatable<CryptocurrencyMarketPairsLatestMarketPairInfoObject>
    {
        /// <summary>
        /// The category of trading this market falls under. Spot markets are the most common but options include derivatives and OTC.
        /// </summary>
        /// <value>The category of trading this market falls under. Spot markets are the most common but options include derivatives and OTC.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoryEnum
        {
            /// <summary>
            /// Enum Spot for value: spot
            /// </summary>
            [EnumMember(Value = "spot")]
            Spot = 1,

            /// <summary>
            /// Enum Derivatives for value: derivatives
            /// </summary>
            [EnumMember(Value = "derivatives")]
            Derivatives = 2,

            /// <summary>
            /// Enum Otc for value: otc
            /// </summary>
            [EnumMember(Value = "otc")]
            Otc = 3

        }


        /// <summary>
        /// The category of trading this market falls under. Spot markets are the most common but options include derivatives and OTC.
        /// </summary>
        /// <value>The category of trading this market falls under. Spot markets are the most common but options include derivatives and OTC.</value>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public CategoryEnum? Category { get; set; }
        /// <summary>
        /// The fee type the exchange enforces for this market.
        /// </summary>
        /// <value>The fee type the exchange enforces for this market.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FeeTypeEnum
        {
            /// <summary>
            /// Enum Percentage for value: percentage
            /// </summary>
            [EnumMember(Value = "percentage")]
            Percentage = 1,

            /// <summary>
            /// Enum NoFees for value: no-fees
            /// </summary>
            [EnumMember(Value = "no-fees")]
            NoFees = 2,

            /// <summary>
            /// Enum TransactionalMining for value: transactional-mining
            /// </summary>
            [EnumMember(Value = "transactional-mining")]
            TransactionalMining = 3,

            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 4

        }


        /// <summary>
        /// The fee type the exchange enforces for this market.
        /// </summary>
        /// <value>The fee type the exchange enforces for this market.</value>
        [DataMember(Name = "fee_type", EmitDefaultValue = false)]
        public FeeTypeEnum? FeeType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CryptocurrencyMarketPairsLatestMarketPairInfoObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CryptocurrencyMarketPairsLatestMarketPairInfoObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CryptocurrencyMarketPairsLatestMarketPairInfoObject" /> class.
        /// </summary>
        /// <param name="exchange">exchange (required).</param>
        /// <param name="marketId">The CoinMarketCap ID for this market pair. This ID can reliably be used to identify this unique market as the ID never changes..</param>
        /// <param name="marketPair">The name of this market pair.  Example: \&quot;BTC/USD\&quot;.</param>
        /// <param name="category">The category of trading this market falls under. Spot markets are the most common but options include derivatives and OTC..</param>
        /// <param name="feeType">The fee type the exchange enforces for this market..</param>
        /// <param name="marketUrl">The URL to this market&#39;s trading page on the exchange if available. If not available the exchange&#39;s homepage URL is returned. *This field is only returned if requested through the &#x60;aux&#x60; request parameter.*.</param>
        /// <param name="markPairBase">markPairBase (required).</param>
        /// <param name="markPairQuote">markPairQuote (required).</param>
        /// <param name="quote">quote (required).</param>
        public CryptocurrencyMarketPairsLatestMarketPairInfoObject(CryptocurrencyMarketPairsLatestExchangeInfoObject exchange = default(CryptocurrencyMarketPairsLatestExchangeInfoObject), int marketId = default(int), string marketPair = default(string), CategoryEnum? category = default(CategoryEnum?), FeeTypeEnum? feeType = default(FeeTypeEnum?), string marketUrl = default(string), CryptocurrencyMarketPairsLatestPairBaseCurrencyInfoObject markPairBase = default(CryptocurrencyMarketPairsLatestPairBaseCurrencyInfoObject), CryptocurrencyMarketPairsLatestPairBaseCurrencyInfoObject1 markPairQuote = default(CryptocurrencyMarketPairsLatestPairBaseCurrencyInfoObject1), CryptocurrencyMarketPairsLatestMarketPairQuoteObject quote = default(CryptocurrencyMarketPairsLatestMarketPairQuoteObject))
        {
            // to ensure "exchange" is required (not null)
            if (exchange == null) {
                throw new ArgumentNullException("exchange is a required property for CryptocurrencyMarketPairsLatestMarketPairInfoObject and cannot be null");
            }
            this.Exchange = exchange;
            // to ensure "markPairBase" is required (not null)
            if (markPairBase == null) {
                throw new ArgumentNullException("markPairBase is a required property for CryptocurrencyMarketPairsLatestMarketPairInfoObject and cannot be null");
            }
            this.MarkPairBase = markPairBase;
            // to ensure "markPairQuote" is required (not null)
            if (markPairQuote == null) {
                throw new ArgumentNullException("markPairQuote is a required property for CryptocurrencyMarketPairsLatestMarketPairInfoObject and cannot be null");
            }
            this.MarkPairQuote = markPairQuote;
            // to ensure "quote" is required (not null)
            if (quote == null) {
                throw new ArgumentNullException("quote is a required property for CryptocurrencyMarketPairsLatestMarketPairInfoObject and cannot be null");
            }
            this.Quote = quote;
            this.MarketId = marketId;
            this.MarketPair = marketPair;
            this.Category = category;
            this.FeeType = feeType;
            this.MarketUrl = marketUrl;
        }

        /// <summary>
        /// Gets or Sets Exchange
        /// </summary>
        [DataMember(Name = "exchange", IsRequired = true, EmitDefaultValue = false)]
        public CryptocurrencyMarketPairsLatestExchangeInfoObject Exchange { get; set; }

        /// <summary>
        /// The CoinMarketCap ID for this market pair. This ID can reliably be used to identify this unique market as the ID never changes.
        /// </summary>
        /// <value>The CoinMarketCap ID for this market pair. This ID can reliably be used to identify this unique market as the ID never changes.</value>
        [DataMember(Name = "market_id", EmitDefaultValue = false)]
        public int MarketId { get; set; }

        /// <summary>
        /// The name of this market pair.  Example: \&quot;BTC/USD\&quot;
        /// </summary>
        /// <value>The name of this market pair.  Example: \&quot;BTC/USD\&quot;</value>
        [DataMember(Name = "market_pair", EmitDefaultValue = false)]
        public string MarketPair { get; set; }

        /// <summary>
        /// The URL to this market&#39;s trading page on the exchange if available. If not available the exchange&#39;s homepage URL is returned. *This field is only returned if requested through the &#x60;aux&#x60; request parameter.*
        /// </summary>
        /// <value>The URL to this market&#39;s trading page on the exchange if available. If not available the exchange&#39;s homepage URL is returned. *This field is only returned if requested through the &#x60;aux&#x60; request parameter.*</value>
        [DataMember(Name = "market_url", EmitDefaultValue = false)]
        public string MarketUrl { get; set; }

        /// <summary>
        /// Gets or Sets MarkPairBase
        /// </summary>
        [DataMember(Name = "mark_pair_base", IsRequired = true, EmitDefaultValue = false)]
        public CryptocurrencyMarketPairsLatestPairBaseCurrencyInfoObject MarkPairBase { get; set; }

        /// <summary>
        /// Gets or Sets MarkPairQuote
        /// </summary>
        [DataMember(Name = "mark_pair_quote", IsRequired = true, EmitDefaultValue = false)]
        public CryptocurrencyMarketPairsLatestPairBaseCurrencyInfoObject1 MarkPairQuote { get; set; }

        /// <summary>
        /// Gets or Sets Quote
        /// </summary>
        [DataMember(Name = "quote", IsRequired = true, EmitDefaultValue = false)]
        public CryptocurrencyMarketPairsLatestMarketPairQuoteObject Quote { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CryptocurrencyMarketPairsLatestMarketPairInfoObject {\n");
            sb.Append("  Exchange: ").Append(Exchange).Append("\n");
            sb.Append("  MarketId: ").Append(MarketId).Append("\n");
            sb.Append("  MarketPair: ").Append(MarketPair).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  FeeType: ").Append(FeeType).Append("\n");
            sb.Append("  MarketUrl: ").Append(MarketUrl).Append("\n");
            sb.Append("  MarkPairBase: ").Append(MarkPairBase).Append("\n");
            sb.Append("  MarkPairQuote: ").Append(MarkPairQuote).Append("\n");
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
            return this.Equals(input as CryptocurrencyMarketPairsLatestMarketPairInfoObject);
        }

        /// <summary>
        /// Returns true if CryptocurrencyMarketPairsLatestMarketPairInfoObject instances are equal
        /// </summary>
        /// <param name="input">Instance of CryptocurrencyMarketPairsLatestMarketPairInfoObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CryptocurrencyMarketPairsLatestMarketPairInfoObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Exchange == input.Exchange ||
                    (this.Exchange != null &&
                    this.Exchange.Equals(input.Exchange))
                ) && 
                (
                    this.MarketId == input.MarketId ||
                    this.MarketId.Equals(input.MarketId)
                ) && 
                (
                    this.MarketPair == input.MarketPair ||
                    (this.MarketPair != null &&
                    this.MarketPair.Equals(input.MarketPair))
                ) && 
                (
                    this.Category == input.Category ||
                    this.Category.Equals(input.Category)
                ) && 
                (
                    this.FeeType == input.FeeType ||
                    this.FeeType.Equals(input.FeeType)
                ) && 
                (
                    this.MarketUrl == input.MarketUrl ||
                    (this.MarketUrl != null &&
                    this.MarketUrl.Equals(input.MarketUrl))
                ) && 
                (
                    this.MarkPairBase == input.MarkPairBase ||
                    (this.MarkPairBase != null &&
                    this.MarkPairBase.Equals(input.MarkPairBase))
                ) && 
                (
                    this.MarkPairQuote == input.MarkPairQuote ||
                    (this.MarkPairQuote != null &&
                    this.MarkPairQuote.Equals(input.MarkPairQuote))
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
                if (this.Exchange != null)
                    hashCode = hashCode * 59 + this.Exchange.GetHashCode();
                hashCode = hashCode * 59 + this.MarketId.GetHashCode();
                if (this.MarketPair != null)
                    hashCode = hashCode * 59 + this.MarketPair.GetHashCode();
                hashCode = hashCode * 59 + this.Category.GetHashCode();
                hashCode = hashCode * 59 + this.FeeType.GetHashCode();
                if (this.MarketUrl != null)
                    hashCode = hashCode * 59 + this.MarketUrl.GetHashCode();
                if (this.MarkPairBase != null)
                    hashCode = hashCode * 59 + this.MarkPairBase.GetHashCode();
                if (this.MarkPairQuote != null)
                    hashCode = hashCode * 59 + this.MarkPairQuote.GetHashCode();
                if (this.Quote != null)
                    hashCode = hashCode * 59 + this.Quote.GetHashCode();
                return hashCode;
            }
        }

    }

}
