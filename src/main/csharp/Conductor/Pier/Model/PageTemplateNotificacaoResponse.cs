using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Conductor.Pier.Model
{
    /// <summary>
    /// Lista de Notifica\u00C3\u00A7\u00C3\u00B5es (layouts) de E-mail
    /// </summary>
    [DataContract]
    public partial class PageTemplateNotificacaoResponse :  IEquatable<PageTemplateNotificacaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PageTemplateNotificacaoResponse" /> class.
        /// Initializes a new instance of the <see cref="PageTemplateNotificacaoResponse" />class.
        /// </summary>
        /// <param name="Content">Content.</param>
        /// <param name="First">First.</param>
        /// <param name="FirstPage">FirstPage.</param>
        /// <param name="HasContent">HasContent.</param>
        /// <param name="HasNextPage">HasNextPage.</param>
        /// <param name="HasPreviousPage">HasPreviousPage.</param>
        /// <param name="Last">Last.</param>
        /// <param name="NextPage">NextPage.</param>
        /// <param name="Number">Number.</param>
        /// <param name="NumberOfElements">NumberOfElements.</param>
        /// <param name="PreviousPage">PreviousPage.</param>
        /// <param name="Size">Size.</param>
        /// <param name="TotalElements">TotalElements.</param>
        /// <param name="TotalPages">TotalPages.</param>

        public PageTemplateNotificacaoResponse(List<TemplateNotificacaoResponse> Content = null, bool? First = null, bool? FirstPage = null, bool? HasContent = null, bool? HasNextPage = null, bool? HasPreviousPage = null, bool? Last = null, int? NextPage = null, int? Number = null, int? NumberOfElements = null, int? PreviousPage = null, int? Size = null, long? TotalElements = null, int? TotalPages = null)
        {
            this.Content = Content;
            this.First = First;
            this.FirstPage = FirstPage;
            this.HasContent = HasContent;
            this.HasNextPage = HasNextPage;
            this.HasPreviousPage = HasPreviousPage;
            this.Last = Last;
            this.NextPage = NextPage;
            this.Number = Number;
            this.NumberOfElements = NumberOfElements;
            this.PreviousPage = PreviousPage;
            this.Size = Size;
            this.TotalElements = TotalElements;
            this.TotalPages = TotalPages;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public List<TemplateNotificacaoResponse> Content { get; set; }
    
        /// <summary>
        /// Gets or Sets First
        /// </summary>
        [DataMember(Name="first", EmitDefaultValue=false)]
        public bool? First { get; set; }
    
        /// <summary>
        /// Gets or Sets FirstPage
        /// </summary>
        [DataMember(Name="firstPage", EmitDefaultValue=false)]
        public bool? FirstPage { get; set; }
    
        /// <summary>
        /// Gets or Sets HasContent
        /// </summary>
        [DataMember(Name="hasContent", EmitDefaultValue=false)]
        public bool? HasContent { get; set; }
    
        /// <summary>
        /// Gets or Sets HasNextPage
        /// </summary>
        [DataMember(Name="hasNextPage", EmitDefaultValue=false)]
        public bool? HasNextPage { get; set; }
    
        /// <summary>
        /// Gets or Sets HasPreviousPage
        /// </summary>
        [DataMember(Name="hasPreviousPage", EmitDefaultValue=false)]
        public bool? HasPreviousPage { get; set; }
    
        /// <summary>
        /// Gets or Sets Last
        /// </summary>
        [DataMember(Name="last", EmitDefaultValue=false)]
        public bool? Last { get; set; }
    
        /// <summary>
        /// Gets or Sets NextPage
        /// </summary>
        [DataMember(Name="nextPage", EmitDefaultValue=false)]
        public int? NextPage { get; set; }
    
        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public int? Number { get; set; }
    
        /// <summary>
        /// Gets or Sets NumberOfElements
        /// </summary>
        [DataMember(Name="numberOfElements", EmitDefaultValue=false)]
        public int? NumberOfElements { get; set; }
    
        /// <summary>
        /// Gets or Sets PreviousPage
        /// </summary>
        [DataMember(Name="previousPage", EmitDefaultValue=false)]
        public int? PreviousPage { get; set; }
    
        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalElements
        /// </summary>
        [DataMember(Name="totalElements", EmitDefaultValue=false)]
        public long? TotalElements { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalPages
        /// </summary>
        [DataMember(Name="totalPages", EmitDefaultValue=false)]
        public int? TotalPages { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageTemplateNotificacaoResponse {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  FirstPage: ").Append(FirstPage).Append("\n");
            sb.Append("  HasContent: ").Append(HasContent).Append("\n");
            sb.Append("  HasNextPage: ").Append(HasNextPage).Append("\n");
            sb.Append("  HasPreviousPage: ").Append(HasPreviousPage).Append("\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  NumberOfElements: ").Append(NumberOfElements).Append("\n");
            sb.Append("  PreviousPage: ").Append(PreviousPage).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  TotalElements: ").Append(TotalElements).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as PageTemplateNotificacaoResponse);
        }

        /// <summary>
        /// Returns true if PageTemplateNotificacaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PageTemplateNotificacaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PageTemplateNotificacaoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.SequenceEqual(other.Content)
                ) && 
                (
                    this.First == other.First ||
                    this.First != null &&
                    this.First.Equals(other.First)
                ) && 
                (
                    this.FirstPage == other.FirstPage ||
                    this.FirstPage != null &&
                    this.FirstPage.Equals(other.FirstPage)
                ) && 
                (
                    this.HasContent == other.HasContent ||
                    this.HasContent != null &&
                    this.HasContent.Equals(other.HasContent)
                ) && 
                (
                    this.HasNextPage == other.HasNextPage ||
                    this.HasNextPage != null &&
                    this.HasNextPage.Equals(other.HasNextPage)
                ) && 
                (
                    this.HasPreviousPage == other.HasPreviousPage ||
                    this.HasPreviousPage != null &&
                    this.HasPreviousPage.Equals(other.HasPreviousPage)
                ) && 
                (
                    this.Last == other.Last ||
                    this.Last != null &&
                    this.Last.Equals(other.Last)
                ) && 
                (
                    this.NextPage == other.NextPage ||
                    this.NextPage != null &&
                    this.NextPage.Equals(other.NextPage)
                ) && 
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) && 
                (
                    this.NumberOfElements == other.NumberOfElements ||
                    this.NumberOfElements != null &&
                    this.NumberOfElements.Equals(other.NumberOfElements)
                ) && 
                (
                    this.PreviousPage == other.PreviousPage ||
                    this.PreviousPage != null &&
                    this.PreviousPage.Equals(other.PreviousPage)
                ) && 
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
                ) && 
                (
                    this.TotalElements == other.TotalElements ||
                    this.TotalElements != null &&
                    this.TotalElements.Equals(other.TotalElements)
                ) && 
                (
                    this.TotalPages == other.TotalPages ||
                    this.TotalPages != null &&
                    this.TotalPages.Equals(other.TotalPages)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();
                
                if (this.First != null)
                    hash = hash * 59 + this.First.GetHashCode();
                
                if (this.FirstPage != null)
                    hash = hash * 59 + this.FirstPage.GetHashCode();
                
                if (this.HasContent != null)
                    hash = hash * 59 + this.HasContent.GetHashCode();
                
                if (this.HasNextPage != null)
                    hash = hash * 59 + this.HasNextPage.GetHashCode();
                
                if (this.HasPreviousPage != null)
                    hash = hash * 59 + this.HasPreviousPage.GetHashCode();
                
                if (this.Last != null)
                    hash = hash * 59 + this.Last.GetHashCode();
                
                if (this.NextPage != null)
                    hash = hash * 59 + this.NextPage.GetHashCode();
                
                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
                
                if (this.NumberOfElements != null)
                    hash = hash * 59 + this.NumberOfElements.GetHashCode();
                
                if (this.PreviousPage != null)
                    hash = hash * 59 + this.PreviousPage.GetHashCode();
                
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                
                if (this.TotalElements != null)
                    hash = hash * 59 + this.TotalElements.GetHashCode();
                
                if (this.TotalPages != null)
                    hash = hash * 59 + this.TotalPages.GetHashCode();
                
                return hash;
            }
        }

    }
}
