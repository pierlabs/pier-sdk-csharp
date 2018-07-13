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
    /// {{{compra_contestada_cartao_response_description}}}
    /// </summary>
    [DataContract]
    public partial class CompraContestadaCartaoResponse :  IEquatable<CompraContestadaCartaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CompraContestadaCartaoResponse" /> class.
        /// Initializes a new instance of the <see cref="CompraContestadaCartaoResponse" />class.
        /// </summary>
        /// <param name="IdCartao">{{{compra_contestada_cartao_response_id_cartao_value}}}.</param>
        /// <param name="AgingContestacao">{{{compra_contestada_cartao_response_aging_contestacao_value}}}.</param>
        /// <param name="Cartao">{{{compra_contestada_cartao_response_cartao_value}}}.</param>
        /// <param name="Nome">{{{compra_contestada_cartao_response_nome_value}}}.</param>
        /// <param name="Bandeira">{{{compra_contestada_cartao_response_bandeira_value}}}.</param>

        public CompraContestadaCartaoResponse(long? IdCartao = null, long? AgingContestacao = null, string Cartao = null, string Nome = null, string Bandeira = null)
        {
            this.IdCartao = IdCartao;
            this.AgingContestacao = AgingContestacao;
            this.Cartao = Cartao;
            this.Nome = Nome;
            this.Bandeira = Bandeira;
            
        }
        
    
        /// <summary>
        /// {{{compra_contestada_cartao_response_id_cartao_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_cartao_response_id_cartao_value}}}</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_cartao_response_aging_contestacao_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_cartao_response_aging_contestacao_value}}}</value>
        [DataMember(Name="agingContestacao", EmitDefaultValue=false)]
        public long? AgingContestacao { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_cartao_response_cartao_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_cartao_response_cartao_value}}}</value>
        [DataMember(Name="cartao", EmitDefaultValue=false)]
        public string Cartao { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_cartao_response_nome_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_cartao_response_nome_value}}}</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_cartao_response_bandeira_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_cartao_response_bandeira_value}}}</value>
        [DataMember(Name="bandeira", EmitDefaultValue=false)]
        public string Bandeira { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompraContestadaCartaoResponse {\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  AgingContestacao: ").Append(AgingContestacao).Append("\n");
            sb.Append("  Cartao: ").Append(Cartao).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Bandeira: ").Append(Bandeira).Append("\n");
            
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
            return this.Equals(obj as CompraContestadaCartaoResponse);
        }

        /// <summary>
        /// Returns true if CompraContestadaCartaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CompraContestadaCartaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompraContestadaCartaoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.AgingContestacao == other.AgingContestacao ||
                    this.AgingContestacao != null &&
                    this.AgingContestacao.Equals(other.AgingContestacao)
                ) && 
                (
                    this.Cartao == other.Cartao ||
                    this.Cartao != null &&
                    this.Cartao.Equals(other.Cartao)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.Bandeira == other.Bandeira ||
                    this.Bandeira != null &&
                    this.Bandeira.Equals(other.Bandeira)
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
                
                if (this.AgingContestacao != null)
                    hash = hash * 59 + this.AgingContestacao.GetHashCode();
                
                if (this.Cartao != null)
                    hash = hash * 59 + this.Cartao.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.Bandeira != null)
                    hash = hash * 59 + this.Bandeira.GetHashCode();
                
                return hash;
            }
        }

    }
}
