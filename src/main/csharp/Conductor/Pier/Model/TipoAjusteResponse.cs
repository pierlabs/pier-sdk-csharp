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
    /// Type of adjustment
    /// </summary>
    [DataContract]
    public partial class TipoAjusteResponse :  IEquatable<TipoAjusteResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoAjusteResponse" /> class.
        /// Initializes a new instance of the <see cref="TipoAjusteResponse" />class.
        /// </summary>
        /// <param name="Id">Identifier Code of the adjustment type.</param>
        /// <param name="Descricao">Description of the adjustment type.</param>
        /// <param name="FlagPagamentoLojista">Identifies whether the payment was made in an establishment.</param>
        /// <param name="Transacoes">Transactions by adjusts type.</param>

        public TipoAjusteResponse(long? Id = null, string Descricao = null, bool? FlagPagamentoLojista = null, List<TipoTransacaoAjusteResponse> Transacoes = null)
        {
            this.Id = Id;
            this.Descricao = Descricao;
            this.FlagPagamentoLojista = FlagPagamentoLojista;
            this.Transacoes = Transacoes;
            
        }
        
    
        /// <summary>
        /// Identifier Code of the adjustment type
        /// </summary>
        /// <value>Identifier Code of the adjustment type</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Description of the adjustment type
        /// </summary>
        /// <value>Description of the adjustment type</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Identifies whether the payment was made in an establishment
        /// </summary>
        /// <value>Identifies whether the payment was made in an establishment</value>
        [DataMember(Name="flagPagamentoLojista", EmitDefaultValue=false)]
        public bool? FlagPagamentoLojista { get; set; }
    
        /// <summary>
        /// Transactions by adjusts type
        /// </summary>
        /// <value>Transactions by adjusts type</value>
        [DataMember(Name="transacoes", EmitDefaultValue=false)]
        public List<TipoTransacaoAjusteResponse> Transacoes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoAjusteResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  FlagPagamentoLojista: ").Append(FlagPagamentoLojista).Append("\n");
            sb.Append("  Transacoes: ").Append(Transacoes).Append("\n");
            
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
            return this.Equals(obj as TipoAjusteResponse);
        }

        /// <summary>
        /// Returns true if TipoAjusteResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoAjusteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoAjusteResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.FlagPagamentoLojista == other.FlagPagamentoLojista ||
                    this.FlagPagamentoLojista != null &&
                    this.FlagPagamentoLojista.Equals(other.FlagPagamentoLojista)
                ) && 
                (
                    this.Transacoes == other.Transacoes ||
                    this.Transacoes != null &&
                    this.Transacoes.SequenceEqual(other.Transacoes)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.FlagPagamentoLojista != null)
                    hash = hash * 59 + this.FlagPagamentoLojista.GetHashCode();
                
                if (this.Transacoes != null)
                    hash = hash * 59 + this.Transacoes.GetHashCode();
                
                return hash;
            }
        }

    }
}
