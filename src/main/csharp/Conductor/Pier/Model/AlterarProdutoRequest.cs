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
    /// Request Representation of the device resource
    /// </summary>
    [DataContract]
    public partial class AlterarProdutoRequest :  IEquatable<AlterarProdutoRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AlterarProdutoRequest" /> class.
        /// Initializes a new instance of the <see cref="AlterarProdutoRequest" />class.
        /// </summary>
        /// <param name="IdProduto">Identifier Code of the product (required).</param>
        /// <param name="IdOrigemComercial">Identifier Code of the commercial origin.</param>
        /// <param name="IdEstabelecimento">It must be filled out with the idEstablishment where the Grade was made. When it is not informed, it is recorded with the idEstablishment associated to the Commercial Origin that captured the initial register of the account.</param>
        /// <param name="IdPromotor">It must be filled out with the idCode of the Prosecutor where the Grade was made. When it is not informed, it is recorded a standard identification code.</param>

        public AlterarProdutoRequest(long? IdProduto = null, long? IdOrigemComercial = null, long? IdEstabelecimento = null, long? IdPromotor = null)
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
            this.IdEstabelecimento = IdEstabelecimento;
            this.IdPromotor = IdPromotor;
            
        }
        
    
        /// <summary>
        /// Identifier Code of the product
        /// </summary>
        /// <value>Identifier Code of the product</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// Identifier Code of the commercial origin
        /// </summary>
        /// <value>Identifier Code of the commercial origin</value>
        [DataMember(Name="idOrigemComercial", EmitDefaultValue=false)]
        public long? IdOrigemComercial { get; set; }
    
        /// <summary>
        /// It must be filled out with the idEstablishment where the Grade was made. When it is not informed, it is recorded with the idEstablishment associated to the Commercial Origin that captured the initial register of the account
        /// </summary>
        /// <value>It must be filled out with the idEstablishment where the Grade was made. When it is not informed, it is recorded with the idEstablishment associated to the Commercial Origin that captured the initial register of the account</value>
        [DataMember(Name="idEstabelecimento", EmitDefaultValue=false)]
        public long? IdEstabelecimento { get; set; }
    
        /// <summary>
        /// It must be filled out with the idCode of the Prosecutor where the Grade was made. When it is not informed, it is recorded a standard identification code
        /// </summary>
        /// <value>It must be filled out with the idCode of the Prosecutor where the Grade was made. When it is not informed, it is recorded a standard identification code</value>
        [DataMember(Name="idPromotor", EmitDefaultValue=false)]
        public long? IdPromotor { get; set; }
    
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
            sb.Append("  IdEstabelecimento: ").Append(IdEstabelecimento).Append("\n");
            sb.Append("  IdPromotor: ").Append(IdPromotor).Append("\n");
            
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
                    this.IdEstabelecimento == other.IdEstabelecimento ||
                    this.IdEstabelecimento != null &&
                    this.IdEstabelecimento.Equals(other.IdEstabelecimento)
                ) && 
                (
                    this.IdPromotor == other.IdPromotor ||
                    this.IdPromotor != null &&
                    this.IdPromotor.Equals(other.IdPromotor)
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
                
                if (this.IdEstabelecimento != null)
                    hash = hash * 59 + this.IdEstabelecimento.GetHashCode();
                
                if (this.IdPromotor != null)
                    hash = hash * 59 + this.IdPromotor.GetHashCode();
                
                return hash;
            }
        }

    }
}
