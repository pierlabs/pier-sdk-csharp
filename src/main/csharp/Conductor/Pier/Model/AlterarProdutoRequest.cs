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
    /// Representa\u00C3\u00A7\u00C3\u00A3o da requisi\u00C3\u00A7\u00C3\u00A3o do  recurso Dispositivo
    /// </summary>
    [DataContract]
    public partial class AlterarProdutoRequest :  IEquatable<AlterarProdutoRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AlterarProdutoRequest" /> class.
        /// Initializes a new instance of the <see cref="AlterarProdutoRequest" />class.
        /// </summary>
        /// <param name="IdProduto">C\u00C3\u00B3digo identificador do produto. (required).</param>
        /// <param name="IdOrigemComercial">C\u00C3\u00B3digo identificador da origem comercial..</param>
        /// <param name="LimiteGlobal">Valor do novo limite Global..</param>

        public AlterarProdutoRequest(long? IdProduto = null, long? IdOrigemComercial = null, double? LimiteGlobal = null)
        {
            // to ensure "IdProduto" is required (not null)
            if (IdProduto == null)
            {
                throw new InvalidDataException("IdProduto is a required property for AlterarProdutoRequest and cannot be null");
            }
            else
            {
                this.IdProduto = IdProduto;
            }
            this.IdOrigemComercial = IdOrigemComercial;
            this.LimiteGlobal = LimiteGlobal;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador do produto.
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador do produto.</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador da origem comercial.
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador da origem comercial.</value>
        [DataMember(Name="idOrigemComercial", EmitDefaultValue=false)]
        public long? IdOrigemComercial { get; set; }
    
        /// <summary>
        /// Valor do novo limite Global.
        /// </summary>
        /// <value>Valor do novo limite Global.</value>
        [DataMember(Name="limiteGlobal", EmitDefaultValue=false)]
        public double? LimiteGlobal { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlterarProdutoRequest {\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  IdOrigemComercial: ").Append(IdOrigemComercial).Append("\n");
            sb.Append("  LimiteGlobal: ").Append(LimiteGlobal).Append("\n");
            
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
            return this.Equals(obj as AlterarProdutoRequest);
        }

        /// <summary>
        /// Returns true if AlterarProdutoRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AlterarProdutoRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlterarProdutoRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.IdOrigemComercial == other.IdOrigemComercial ||
                    this.IdOrigemComercial != null &&
                    this.IdOrigemComercial.Equals(other.IdOrigemComercial)
                ) && 
                (
                    this.LimiteGlobal == other.LimiteGlobal ||
                    this.LimiteGlobal != null &&
                    this.LimiteGlobal.Equals(other.LimiteGlobal)
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
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.IdOrigemComercial != null)
                    hash = hash * 59 + this.IdOrigemComercial.GetHashCode();
                
                if (this.LimiteGlobal != null)
                    hash = hash * 59 + this.LimiteGlobal.GetHashCode();
                
                return hash;
            }
        }

    }
}
