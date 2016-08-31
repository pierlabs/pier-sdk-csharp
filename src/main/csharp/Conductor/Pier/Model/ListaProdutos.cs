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
    /// Lista de Produtos
    /// </summary>
    [DataContract]
    public partial class ListaProdutos :  IEquatable<ListaProdutos>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ListaProdutos" /> class.
        /// Initializes a new instance of the <see cref="ListaProdutos" />class.
        /// </summary>
        /// <param name="Produtos">Lista de produtos.</param>

        public ListaProdutos(List<Produto> Produtos = null)
        {
            this.Produtos = Produtos;
            
        }
        
    
        /// <summary>
        /// Lista de produtos
        /// </summary>
        /// <value>Lista de produtos</value>
        [DataMember(Name="produtos", EmitDefaultValue=false)]
        public List<Produto> Produtos { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListaProdutos {\n");
            sb.Append("  Produtos: ").Append(Produtos).Append("\n");
            
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
            return this.Equals(obj as ListaProdutos);
        }

        /// <summary>
        /// Returns true if ListaProdutos instances are equal
        /// </summary>
        /// <param name="other">Instance of ListaProdutos to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListaProdutos other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Produtos == other.Produtos ||
                    this.Produtos != null &&
                    this.Produtos.SequenceEqual(other.Produtos)
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
                
                if (this.Produtos != null)
                    hash = hash * 59 + this.Produtos.GetHashCode();
                
                return hash;
            }
        }

    }
}
