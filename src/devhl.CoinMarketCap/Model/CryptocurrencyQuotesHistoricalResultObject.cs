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
    /// A results object for each cryptocurrency requested. The map key being the id/symbol used in the request.
    /// </summary>
    [DataContract(Name = "Cryptocurrency Quotes Historical - Result object")]
    public partial class CryptocurrencyQuotesHistoricalResultObject : IEquatable<CryptocurrencyQuotesHistoricalResultObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CryptocurrencyQuotesHistoricalResultObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CryptocurrencyQuotesHistoricalResultObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CryptocurrencyQuotesHistoricalResultObject" /> class.
        /// </summary>
        /// <param name="id">The CoinMarketCap cryptocurrency ID. (required).</param>
        /// <param name="name">The cryptocurrency name. (required).</param>
        /// <param name="symbol">The cryptocurrency symbol. (required).</param>
        /// <param name="isActive">1 if this cryptocurrency has at least 1 active market currently being tracked by the platform, otherwise 0. A value of 1 is analogous with &#x60;listing_status&#x3D;active&#x60;..</param>
        /// <param name="isFiat">1 if this is a fiat.</param>
        /// <param name="quotes">An array of quotes for each interval for this cryptocurrency. (required).</param>
        public CryptocurrencyQuotesHistoricalResultObject(int id = default(int), string name = default(string), string symbol = default(string), int isActive = default(int), int isFiat = default(int), List<CryptocurrencyQuotesHistoricalIntervalQuoteObject> quotes = default(List<CryptocurrencyQuotesHistoricalIntervalQuoteObject>))
        {
            this.Id = id;
            this.Name = name;
            this.Symbol = symbol;
            // to ensure "quotes" is required (not null)
            if (quotes == null) {
                throw new ArgumentNullException("quotes is a required property for CryptocurrencyQuotesHistoricalResultObject and cannot be null");
            }
            this.Quotes = quotes;
            this.IsActive = isActive;
            this.IsFiat = isFiat;
        }

        /// <summary>
        /// The CoinMarketCap cryptocurrency ID.
        /// </summary>
        /// <value>The CoinMarketCap cryptocurrency ID.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The cryptocurrency name.
        /// </summary>
        /// <value>The cryptocurrency name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The cryptocurrency symbol.
        /// </summary>
        /// <value>The cryptocurrency symbol.</value>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = false)]
        public string Symbol { get; set; }

        /// <summary>
        /// 1 if this cryptocurrency has at least 1 active market currently being tracked by the platform, otherwise 0. A value of 1 is analogous with &#x60;listing_status&#x3D;active&#x60;.
        /// </summary>
        /// <value>1 if this cryptocurrency has at least 1 active market currently being tracked by the platform, otherwise 0. A value of 1 is analogous with &#x60;listing_status&#x3D;active&#x60;.</value>
        [DataMember(Name = "is_active", EmitDefaultValue = false)]
        public int IsActive { get; set; }

        /// <summary>
        /// 1 if this is a fiat
        /// </summary>
        /// <value>1 if this is a fiat</value>
        [DataMember(Name = "is_fiat", EmitDefaultValue = false)]
        public int IsFiat { get; set; }

        /// <summary>
        /// An array of quotes for each interval for this cryptocurrency.
        /// </summary>
        /// <value>An array of quotes for each interval for this cryptocurrency.</value>
        [DataMember(Name = "quotes", IsRequired = true, EmitDefaultValue = false)]
        public List<CryptocurrencyQuotesHistoricalIntervalQuoteObject> Quotes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CryptocurrencyQuotesHistoricalResultObject {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsFiat: ").Append(IsFiat).Append("\n");
            sb.Append("  Quotes: ").Append(Quotes).Append("\n");
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
            return this.Equals(input as CryptocurrencyQuotesHistoricalResultObject);
        }

        /// <summary>
        /// Returns true if CryptocurrencyQuotesHistoricalResultObject instances are equal
        /// </summary>
        /// <param name="input">Instance of CryptocurrencyQuotesHistoricalResultObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CryptocurrencyQuotesHistoricalResultObject input)
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
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
                ) && 
                (
                    this.IsFiat == input.IsFiat ||
                    this.IsFiat.Equals(input.IsFiat)
                ) && 
                (
                    this.Quotes == input.Quotes ||
                    this.Quotes != null &&
                    input.Quotes != null &&
                    this.Quotes.SequenceEqual(input.Quotes)
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
                hashCode = (hashCode * 59) + this.IsActive.GetHashCode();
                hashCode = (hashCode * 59) + this.IsFiat.GetHashCode();
                if (this.Quotes != null)
                {
                    hashCode = (hashCode * 59) + this.Quotes.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
