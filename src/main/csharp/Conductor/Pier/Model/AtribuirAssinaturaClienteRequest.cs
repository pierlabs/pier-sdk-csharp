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
    /// Objeto que representa a atribui\u00C3\u00A7\u00C3\u00A3o da assinatura do cliente
    /// </summary>
    [DataContract]
    public partial class AtribuirAssinaturaClienteRequest :  IEquatable<AtribuirAssinaturaClienteRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AtribuirAssinaturaClienteRequest" /> class.
        /// Initializes a new instance of the <see cref="AtribuirAssinaturaClienteRequest" />class.
        /// </summary>
        /// <param name="IdImagem">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da imagem.</param>

        public AtribuirAssinaturaClienteRequest(long? IdImagem = null)
        {
            this.IdImagem = IdImagem;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da imagem
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da imagem</value>
        [DataMember(Name="idImagem", EmitDefaultValue=false)]
        public long? IdImagem { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AtribuirAssinaturaClienteRequest {\n");
            sb.Append("  IdImagem: ").Append(IdImagem).Append("\n");
            
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
            return this.Equals(obj as AtribuirAssinaturaClienteRequest);
        }

        /// <summary>
        /// Returns true if AtribuirAssinaturaClienteRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AtribuirAssinaturaClienteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AtribuirAssinaturaClienteRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdImagem == other.IdImagem ||
                    this.IdImagem != null &&
                    this.IdImagem.Equals(other.IdImagem)
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
                
                if (this.IdImagem != null)
                    hash = hash * 59 + this.IdImagem.GetHashCode();
                
                return hash;
            }
        }

    }
}
