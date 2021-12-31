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
    /// Quote (secondary) currency details object for this market pair
    /// </summary>
    [DataContract(Name = "Exchange Market Pairs Latest - Pair Base Currency Info object 1")]
    public partial class ExchangeMarketPairsLatestPairBaseCurrencyInfoObject1 : IEquatable<ExchangeMarketPairsLatestPairBaseCurrencyInfoObject1>
    {
        /// <summary>
        /// The currency type for the quote (secondary) currency in this market pair.
        /// </summary>
        /// <value>The currency type for the quote (secondary) currency in this market pair.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CurrencyTypeEnum
        {
            /// <summary>
            /// Enum Cryptocurrency for value: cryptocurrency
            /// </summary>
            [EnumMember(Value = "cryptocurrency")]
            Cryptocurrency = 1,

            /// <summary>
            /// Enum Fiat for value: fiat
            /// </summary>
            [EnumMember(Value = "fiat")]
            Fiat = 2

        }


        /// <summary>
        /// The currency type for the quote (secondary) currency in this market pair.
        /// </summary>
        /// <value>The currency type for the quote (secondary) currency in this market pair.</value>
        [DataMember(Name = "currency_type", IsRequired = true, EmitDefaultValue = false)]
        public CurrencyTypeEnum CurrencyType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeMarketPairsLatestPairBaseCurrencyInfoObject1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExchangeMarketPairsLatestPairBaseCurrencyInfoObject1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeMarketPairsLatestPairBaseCurrencyInfoObject1" /> class.
        /// </summary>
        /// <param name="currencyId">The CoinMarketCap ID for the quote (secondary) currency in this market pair. (required).</param>
        /// <param name="currencyName">The name of this cryptocurrency. *This field is only returned if requested through the &#x60;aux&#x60; request parameter.*.</param>
        /// <param name="currencySymbol">The symbol for the quote (secondary) currency in this market pair. (required).</param>
        /// <param name="exchangeSymbol">The exchange reported symbol for the quote (secondary) currency in this market pair. In most cases this is identical to CoinMarketCap&#39;s symbol but it may differ if the exchange uses an outdated or contentious symbol that contrasts with the majority of other markets. (required).</param>
        /// <param name="currencySlug">The web URL friendly shorthand version of this cryptocurrency name. *This field is only returned if requested through the &#x60;aux&#x60; request parameter.*.</param>
        /// <param name="currencyType">The currency type for the quote (secondary) currency in this market pair. (required).</param>
        public ExchangeMarketPairsLatestPairBaseCurrencyInfoObject1(int currencyId = default(int), string currencyName = default(string), string currencySymbol = default(string), string exchangeSymbol = default(string), string currencySlug = default(string), CurrencyTypeEnum currencyType = default(CurrencyTypeEnum))
        {
            this.CurrencyId = currencyId;
            this.CurrencySymbol = currencySymbol;
            this.ExchangeSymbol = exchangeSymbol;
            this.CurrencyType = currencyType;
            this.CurrencyName = currencyName;
            this.CurrencySlug = currencySlug;
        }

        /// <summary>
        /// The CoinMarketCap ID for the quote (secondary) currency in this market pair.
        /// </summary>
        /// <value>The CoinMarketCap ID for the quote (secondary) currency in this market pair.</value>
        [DataMember(Name = "currency_id", IsRequired = true, EmitDefaultValue = false)]
        public int CurrencyId { get; set; }

        /// <summary>
        /// The name of this cryptocurrency. *This field is only returned if requested through the &#x60;aux&#x60; request parameter.*
        /// </summary>
        /// <value>The name of this cryptocurrency. *This field is only returned if requested through the &#x60;aux&#x60; request parameter.*</value>
        [DataMember(Name = "currency_name", EmitDefaultValue = false)]
        public string CurrencyName { get; set; }

        /// <summary>
        /// The symbol for the quote (secondary) currency in this market pair.
        /// </summary>
        /// <value>The symbol for the quote (secondary) currency in this market pair.</value>
        [DataMember(Name = "currency_symbol", IsRequired = true, EmitDefaultValue = false)]
        public string CurrencySymbol { get; set; }

        /// <summary>
        /// The exchange reported symbol for the quote (secondary) currency in this market pair. In most cases this is identical to CoinMarketCap&#39;s symbol but it may differ if the exchange uses an outdated or contentious symbol that contrasts with the majority of other markets.
        /// </summary>
        /// <value>The exchange reported symbol for the quote (secondary) currency in this market pair. In most cases this is identical to CoinMarketCap&#39;s symbol but it may differ if the exchange uses an outdated or contentious symbol that contrasts with the majority of other markets.</value>
        [DataMember(Name = "exchange_symbol", IsRequired = true, EmitDefaultValue = false)]
        public string ExchangeSymbol { get; set; }

        /// <summary>
        /// The web URL friendly shorthand version of this cryptocurrency name. *This field is only returned if requested through the &#x60;aux&#x60; request parameter.*
        /// </summary>
        /// <value>The web URL friendly shorthand version of this cryptocurrency name. *This field is only returned if requested through the &#x60;aux&#x60; request parameter.*</value>
        [DataMember(Name = "currency_slug", EmitDefaultValue = false)]
        public string CurrencySlug { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExchangeMarketPairsLatestPairBaseCurrencyInfoObject1 {\n");
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append("\n");
            sb.Append("  CurrencyName: ").Append(CurrencyName).Append("\n");
            sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
            sb.Append("  ExchangeSymbol: ").Append(ExchangeSymbol).Append("\n");
            sb.Append("  CurrencySlug: ").Append(CurrencySlug).Append("\n");
            sb.Append("  CurrencyType: ").Append(CurrencyType).Append("\n");
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
            return this.Equals(input as ExchangeMarketPairsLatestPairBaseCurrencyInfoObject1);
        }

        /// <summary>
        /// Returns true if ExchangeMarketPairsLatestPairBaseCurrencyInfoObject1 instances are equal
        /// </summary>
        /// <param name="input">Instance of ExchangeMarketPairsLatestPairBaseCurrencyInfoObject1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExchangeMarketPairsLatestPairBaseCurrencyInfoObject1 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrencyId == input.CurrencyId ||
                    this.CurrencyId.Equals(input.CurrencyId)
                ) && 
                (
                    this.CurrencyName == input.CurrencyName ||
                    (this.CurrencyName != null &&
                    this.CurrencyName.Equals(input.CurrencyName))
                ) && 
                (
                    this.CurrencySymbol == input.CurrencySymbol ||
                    (this.CurrencySymbol != null &&
                    this.CurrencySymbol.Equals(input.CurrencySymbol))
                ) && 
                (
                    this.ExchangeSymbol == input.ExchangeSymbol ||
                    (this.ExchangeSymbol != null &&
                    this.ExchangeSymbol.Equals(input.ExchangeSymbol))
                ) && 
                (
                    this.CurrencySlug == input.CurrencySlug ||
                    (this.CurrencySlug != null &&
                    this.CurrencySlug.Equals(input.CurrencySlug))
                ) && 
                (
                    this.CurrencyType == input.CurrencyType ||
                    this.CurrencyType.Equals(input.CurrencyType)
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
                hashCode = hashCode * 59 + this.CurrencyId.GetHashCode();
                if (this.CurrencyName != null)
                    hashCode = hashCode * 59 + this.CurrencyName.GetHashCode();
                if (this.CurrencySymbol != null)
                    hashCode = hashCode * 59 + this.CurrencySymbol.GetHashCode();
                if (this.ExchangeSymbol != null)
                    hashCode = hashCode * 59 + this.ExchangeSymbol.GetHashCode();
                if (this.CurrencySlug != null)
                    hashCode = hashCode * 59 + this.CurrencySlug.GetHashCode();
                hashCode = hashCode * 59 + this.CurrencyType.GetHashCode();
                return hashCode;
            }
        }

    }

}
