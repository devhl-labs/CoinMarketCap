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
    /// Object containing rate limit and daily/monthly credit limit details for your API Key.
    /// </summary>
    [DataContract(Name = "plan")]
    public partial class Plan : IEquatable<Plan>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Plan" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Plan() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Plan" /> class.
        /// </summary>
        /// <param name="creditLimitDaily">The number of API credits that can be used each daily period before receiving a HTTP 429 rate limit error. This limit is based on the API plan tier. (required).</param>
        /// <param name="creditLimitDailyReset">A human readable countdown of when the API key daily credit limit will reset back to 0. (required).</param>
        /// <param name="creditLimitDailyResetTimestamp">Timestamp (ISO 8601) of when the daily credit limit will reset. This is based on your billing plan activation date for premium subscription based keys or UTC midnight for free Basic plan keys. (required).</param>
        /// <param name="creditLimitMonthly">The number of API credits that can be used each monthly period before receiving a HTTP 429 rate limit error. This limit is based on the API plan tier. (required).</param>
        /// <param name="creditLimitMonthlyReset">A human readable countdown of when the API key monthly credit limit will reset back to 0. (required).</param>
        /// <param name="creditLimitMonthlyResetTimestamp">Timestamp (ISO 8601) of when the monthly credit limit will reset. This is based on your billing plan activation date for premium subscription based keys or calendar month UTC midnight for free Basic plan keys. (required).</param>
        /// <param name="rateLimitMinute">The number of API calls that can be made within the same UTC minute before receiving a HTTP 429 rate limit error. This limit is based on the API plan tier. (required).</param>
        public Plan(decimal creditLimitDaily = default(decimal), string creditLimitDailyReset = default(string), DateTime creditLimitDailyResetTimestamp = default(DateTime), decimal creditLimitMonthly = default(decimal), string creditLimitMonthlyReset = default(string), DateTime creditLimitMonthlyResetTimestamp = default(DateTime), decimal rateLimitMinute = default(decimal))
        {
            this.CreditLimitDaily = creditLimitDaily;
            this.CreditLimitDailyReset = creditLimitDailyReset;
            this.CreditLimitDailyResetTimestamp = creditLimitDailyResetTimestamp;
            this.CreditLimitMonthly = creditLimitMonthly;
            this.CreditLimitMonthlyReset = creditLimitMonthlyReset;
            this.CreditLimitMonthlyResetTimestamp = creditLimitMonthlyResetTimestamp;
            this.RateLimitMinute = rateLimitMinute;
        }

        /// <summary>
        /// The number of API credits that can be used each daily period before receiving a HTTP 429 rate limit error. This limit is based on the API plan tier.
        /// </summary>
        /// <value>The number of API credits that can be used each daily period before receiving a HTTP 429 rate limit error. This limit is based on the API plan tier.</value>
        [DataMember(Name = "credit_limit_daily", IsRequired = true, EmitDefaultValue = false)]
        public decimal CreditLimitDaily { get; set; }

        /// <summary>
        /// A human readable countdown of when the API key daily credit limit will reset back to 0.
        /// </summary>
        /// <value>A human readable countdown of when the API key daily credit limit will reset back to 0.</value>
        [DataMember(Name = "credit_limit_daily_reset", IsRequired = true, EmitDefaultValue = false)]
        public string CreditLimitDailyReset { get; set; }

        /// <summary>
        /// Timestamp (ISO 8601) of when the daily credit limit will reset. This is based on your billing plan activation date for premium subscription based keys or UTC midnight for free Basic plan keys.
        /// </summary>
        /// <value>Timestamp (ISO 8601) of when the daily credit limit will reset. This is based on your billing plan activation date for premium subscription based keys or UTC midnight for free Basic plan keys.</value>
        [DataMember(Name = "credit_limit_daily_reset_timestamp", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime CreditLimitDailyResetTimestamp { get; set; }

        /// <summary>
        /// The number of API credits that can be used each monthly period before receiving a HTTP 429 rate limit error. This limit is based on the API plan tier.
        /// </summary>
        /// <value>The number of API credits that can be used each monthly period before receiving a HTTP 429 rate limit error. This limit is based on the API plan tier.</value>
        [DataMember(Name = "credit_limit_monthly", IsRequired = true, EmitDefaultValue = false)]
        public decimal CreditLimitMonthly { get; set; }

        /// <summary>
        /// A human readable countdown of when the API key monthly credit limit will reset back to 0.
        /// </summary>
        /// <value>A human readable countdown of when the API key monthly credit limit will reset back to 0.</value>
        [DataMember(Name = "credit_limit_monthly_reset", IsRequired = true, EmitDefaultValue = false)]
        public string CreditLimitMonthlyReset { get; set; }

        /// <summary>
        /// Timestamp (ISO 8601) of when the monthly credit limit will reset. This is based on your billing plan activation date for premium subscription based keys or calendar month UTC midnight for free Basic plan keys.
        /// </summary>
        /// <value>Timestamp (ISO 8601) of when the monthly credit limit will reset. This is based on your billing plan activation date for premium subscription based keys or calendar month UTC midnight for free Basic plan keys.</value>
        [DataMember(Name = "credit_limit_monthly_reset_timestamp", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime CreditLimitMonthlyResetTimestamp { get; set; }

        /// <summary>
        /// The number of API calls that can be made within the same UTC minute before receiving a HTTP 429 rate limit error. This limit is based on the API plan tier.
        /// </summary>
        /// <value>The number of API calls that can be made within the same UTC minute before receiving a HTTP 429 rate limit error. This limit is based on the API plan tier.</value>
        [DataMember(Name = "rate_limit_minute", IsRequired = true, EmitDefaultValue = false)]
        public decimal RateLimitMinute { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Plan {\n");
            sb.Append("  CreditLimitDaily: ").Append(CreditLimitDaily).Append("\n");
            sb.Append("  CreditLimitDailyReset: ").Append(CreditLimitDailyReset).Append("\n");
            sb.Append("  CreditLimitDailyResetTimestamp: ").Append(CreditLimitDailyResetTimestamp).Append("\n");
            sb.Append("  CreditLimitMonthly: ").Append(CreditLimitMonthly).Append("\n");
            sb.Append("  CreditLimitMonthlyReset: ").Append(CreditLimitMonthlyReset).Append("\n");
            sb.Append("  CreditLimitMonthlyResetTimestamp: ").Append(CreditLimitMonthlyResetTimestamp).Append("\n");
            sb.Append("  RateLimitMinute: ").Append(RateLimitMinute).Append("\n");
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
            return this.Equals(input as Plan);
        }

        /// <summary>
        /// Returns true if Plan instances are equal
        /// </summary>
        /// <param name="input">Instance of Plan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Plan input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CreditLimitDaily == input.CreditLimitDaily ||
                    this.CreditLimitDaily.Equals(input.CreditLimitDaily)
                ) && 
                (
                    this.CreditLimitDailyReset == input.CreditLimitDailyReset ||
                    (this.CreditLimitDailyReset != null &&
                    this.CreditLimitDailyReset.Equals(input.CreditLimitDailyReset))
                ) && 
                (
                    this.CreditLimitDailyResetTimestamp == input.CreditLimitDailyResetTimestamp ||
                    (this.CreditLimitDailyResetTimestamp != null &&
                    this.CreditLimitDailyResetTimestamp.Equals(input.CreditLimitDailyResetTimestamp))
                ) && 
                (
                    this.CreditLimitMonthly == input.CreditLimitMonthly ||
                    this.CreditLimitMonthly.Equals(input.CreditLimitMonthly)
                ) && 
                (
                    this.CreditLimitMonthlyReset == input.CreditLimitMonthlyReset ||
                    (this.CreditLimitMonthlyReset != null &&
                    this.CreditLimitMonthlyReset.Equals(input.CreditLimitMonthlyReset))
                ) && 
                (
                    this.CreditLimitMonthlyResetTimestamp == input.CreditLimitMonthlyResetTimestamp ||
                    (this.CreditLimitMonthlyResetTimestamp != null &&
                    this.CreditLimitMonthlyResetTimestamp.Equals(input.CreditLimitMonthlyResetTimestamp))
                ) && 
                (
                    this.RateLimitMinute == input.RateLimitMinute ||
                    this.RateLimitMinute.Equals(input.RateLimitMinute)
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
                hashCode = (hashCode * 59) + this.CreditLimitDaily.GetHashCode();
                if (this.CreditLimitDailyReset != null)
                {
                    hashCode = (hashCode * 59) + this.CreditLimitDailyReset.GetHashCode();
                }
                if (this.CreditLimitDailyResetTimestamp != null)
                {
                    hashCode = (hashCode * 59) + this.CreditLimitDailyResetTimestamp.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreditLimitMonthly.GetHashCode();
                if (this.CreditLimitMonthlyReset != null)
                {
                    hashCode = (hashCode * 59) + this.CreditLimitMonthlyReset.GetHashCode();
                }
                if (this.CreditLimitMonthlyResetTimestamp != null)
                {
                    hashCode = (hashCode * 59) + this.CreditLimitMonthlyResetTimestamp.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RateLimitMinute.GetHashCode();
                return hashCode;
            }
        }

    }

}
