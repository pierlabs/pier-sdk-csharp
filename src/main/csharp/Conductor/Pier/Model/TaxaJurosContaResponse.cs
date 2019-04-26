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
    /// Representa\u00E7\u00E3o da resposta da taxa de juros
    /// </summary>
    [DataContract]
    public partial class TaxaJurosContaResponse :  IEquatable<TaxaJurosContaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxaJurosContaResponse" /> class.
        /// Initializes a new instance of the <see cref="TaxaJurosContaResponse" />class.
        /// </summary>
        /// <param name="IdConta">id_conta.</param>
        /// <param name="IdTabelaJuros">C\u00F3digo de identifica\u00E7\u00E3o da tabela de juros.</param>
        /// <param name="TaxasJuros">Listagem da taxas de juros.</param>

        public TaxaJurosContaResponse(long? IdConta = null, long? IdTabelaJuros = null, List<TaxaJurosContaListaResponse> TaxasJuros = null)
        {
            this.IdConta = IdConta;
            this.IdTabelaJuros = IdTabelaJuros;
            this.TaxasJuros = TaxasJuros;
            
        }
        
    
        /// <summary>
        /// id_conta
        /// </summary>
        /// <value>id_conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da tabela de juros
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da tabela de juros</value>
        [DataMember(Name="idTabelaJuros", EmitDefaultValue=false)]
        public long? IdTabelaJuros { get; set; }
    
        /// <summary>
        /// Listagem da taxas de juros
        /// </summary>
        /// <value>Listagem da taxas de juros</value>
        [DataMember(Name="taxasJuros", EmitDefaultValue=false)]
        public List<TaxaJurosContaListaResponse> TaxasJuros { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxaJurosContaResponse {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdTabelaJuros: ").Append(IdTabelaJuros).Append("\n");
            sb.Append("  TaxasJuros: ").Append(TaxasJuros).Append("\n");
            
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
            return this.Equals(obj as TaxaJurosContaResponse);
        }

        /// <summary>
        /// Returns true if TaxaJurosContaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TaxaJurosContaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxaJurosContaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdTabelaJuros == other.IdTabelaJuros ||
                    this.IdTabelaJuros != null &&
                    this.IdTabelaJuros.Equals(other.IdTabelaJuros)
                ) && 
                (
                    this.TaxasJuros == other.TaxasJuros ||
                    this.TaxasJuros != null &&
                    this.TaxasJuros.SequenceEqual(other.TaxasJuros)
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
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdTabelaJuros != null)
                    hash = hash * 59 + this.IdTabelaJuros.GetHashCode();
                
                if (this.TaxasJuros != null)
                    hash = hash * 59 + this.TaxasJuros.GetHashCode();
                
                return hash;
            }
        }

    }
}
