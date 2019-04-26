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
    /// Realiza a atribui\u00E7\u00E3o de um cart\u00E3o pr\u00E9-pago a uma conta.
    /// </summary>
    [DataContract]
    public partial class ContaAtribuirCartaoPrePagoRequest :  IEquatable<ContaAtribuirCartaoPrePagoRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaAtribuirCartaoPrePagoRequest" /> class.
        /// Initializes a new instance of the <see cref="ContaAtribuirCartaoPrePagoRequest" />class.
        /// </summary>
        /// <param name="IdCartao">C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id). (required).</param>

        public ContaAtribuirCartaoPrePagoRequest(long? IdCartao = null)
        {
            // to ensure "IdCartao" is required (not null)
            if (IdCartao == null)
            {
                throw new InvalidDataException("IdCartao is a required property for ContaAtribuirCartaoPrePagoRequest and cannot be null");
            }
            else
            {
                this.IdCartao = IdCartao;
            }
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id).
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do Cart\u00E3o (id).</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContaAtribuirCartaoPrePagoRequest {\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            
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
            return this.Equals(obj as ContaAtribuirCartaoPrePagoRequest);
        }

        /// <summary>
        /// Returns true if ContaAtribuirCartaoPrePagoRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ContaAtribuirCartaoPrePagoRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContaAtribuirCartaoPrePagoRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
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
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                return hash;
            }
        }

    }
}
