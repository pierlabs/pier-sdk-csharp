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
    /// Objeto de requisi\u00E7\u00E3o de atribui\u00E7\u00E3o de um cart\u00E3o a uma conta
    /// </summary>
    [DataContract]
    public partial class AtribuirCartaoPessoaRequest :  IEquatable<AtribuirCartaoPessoaRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AtribuirCartaoPessoaRequest" /> class.
        /// Initializes a new instance of the <see cref="AtribuirCartaoPessoaRequest" />class.
        /// </summary>
        /// <param name="IdPessoa">Identificador da pessoa.</param>

        public AtribuirCartaoPessoaRequest(long? IdPessoa = null)
        {
            this.IdPessoa = IdPessoa;
            
        }
        
    
        /// <summary>
        /// Identificador da pessoa
        /// </summary>
        /// <value>Identificador da pessoa</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AtribuirCartaoPessoaRequest {\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            
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
            return this.Equals(obj as AtribuirCartaoPessoaRequest);
        }

        /// <summary>
        /// Returns true if AtribuirCartaoPessoaRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AtribuirCartaoPessoaRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AtribuirCartaoPessoaRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
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
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                return hash;
            }
        }

    }
}
