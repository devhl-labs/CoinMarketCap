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
    /// Results of your query returned as an object map.
    /// </summary>
    [DataContract(Name = "Exchanges Info - Results map")]
    public partial class ExchangesInfoResultsMap : IEquatable<ExchangesInfoResultsMap>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangesInfoResultsMap" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExchangesInfoResultsMap() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangesInfoResultsMap" /> class.
        /// </summary>
        /// <param name="key">key (required).</param>
        public ExchangesInfoResultsMap(ExchangesInfoExchangeInfoObject key = default(ExchangesInfoExchangeInfoObject))
        {
            // to ensure "key" is required (not null)
            if (key == null) {
                throw new ArgumentNullException("key is a required property for ExchangesInfoResultsMap and cannot be null");
            }
            this.Key = key;
        }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "$key", IsRequired = true, EmitDefaultValue = false)]
        public ExchangesInfoExchangeInfoObject Key { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExchangesInfoResultsMap {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
            return this.Equals(input as ExchangesInfoResultsMap);
        }

        /// <summary>
        /// Returns true if ExchangesInfoResultsMap instances are equal
        /// </summary>
        /// <param name="input">Instance of ExchangesInfoResultsMap to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExchangesInfoResultsMap input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                return hashCode;
            }
        }

    }

}
