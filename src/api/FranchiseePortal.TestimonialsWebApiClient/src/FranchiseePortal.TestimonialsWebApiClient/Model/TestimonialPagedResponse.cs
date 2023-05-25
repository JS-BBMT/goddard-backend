/*
 * Goddard.FMS.SchoolTestimonials
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = FranchiseePortal.TestimonialsWebApiClient.Client.OpenAPIDateConverter;

namespace FranchiseePortal.TestimonialsWebApiClient.Model
{
    /// <summary>
    /// TestimonialPagedResponse
    /// </summary>
    [DataContract(Name = "TestimonialPagedResponse")]
    public partial class TestimonialPagedResponse : IEquatable<TestimonialPagedResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestimonialPagedResponse" /> class.
        /// </summary>
        /// <param name="pageNumber">pageNumber.</param>
        /// <param name="pageSize">pageSize.</param>
        /// <param name="total">total.</param>
        /// <param name="items">items.</param>
        public TestimonialPagedResponse(int pageNumber = default(int), int pageSize = default(int), int total = default(int), List<Testimonial> items = default(List<Testimonial>))
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.Total = total;
            this.Items = items;
        }

        /// <summary>
        /// Gets or Sets PageNumber
        /// </summary>
        [DataMember(Name = "pageNumber", EmitDefaultValue = false)]
        public int PageNumber { get; set; }

        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name = "pageSize", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public int Total { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = true)]
        public List<Testimonial> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestimonialPagedResponse {\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as TestimonialPagedResponse);
        }

        /// <summary>
        /// Returns true if TestimonialPagedResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TestimonialPagedResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestimonialPagedResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PageNumber == input.PageNumber ||
                    this.PageNumber.Equals(input.PageNumber)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                hashCode = hashCode * 59 + this.PageNumber.GetHashCode();
                hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
