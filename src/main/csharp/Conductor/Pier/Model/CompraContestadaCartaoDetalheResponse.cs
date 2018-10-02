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
    /// {{{compra_contestada_cartao_detalhe_response_description}}}
    /// </summary>
    [DataContract]
    public partial class CompraContestadaCartaoDetalheResponse :  IEquatable<CompraContestadaCartaoDetalheResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CompraContestadaCartaoDetalheResponse" /> class.
        /// Initializes a new instance of the <see cref="CompraContestadaCartaoDetalheResponse" />class.
        /// </summary>
        /// <param name="NumeroCartao">{{{compra_contestada_cartao_detalhe_response_numero_cartao_value}}}.</param>
        /// <param name="Portador">{{{compra_contestada_cartao_detalhe_response_portador_value}}}.</param>
        /// <param name="IdConta">{{{compra_contestada_cartao_detalhe_response_id_conta_value}}}.</param>
        /// <param name="NomePlastico">{{{compra_contestada_cartao_detalhe_response_nome_plastico_value}}}.</param>
        /// <param name="DataValidade">{{{compra_contestada_cartao_detalhe_response_data_validade_value}}}.</param>
        /// <param name="StatusCartao">{{{compra_contestada_cartao_detalhe_response_status_cartao_value}}}.</param>
        /// <param name="StatusCartaoDescricao">{{{compra_contestada_cartao_detalhe_response_status_cartao_descricao_value}}}.</param>

        public CompraContestadaCartaoDetalheResponse(string NumeroCartao = null, string Portador = null, long? IdConta = null, string NomePlastico = null, DateTime? DataValidade = null, string StatusCartao = null, string StatusCartaoDescricao = null)
        {
            this.NumeroCartao = NumeroCartao;
            this.Portador = Portador;
            this.IdConta = IdConta;
            this.NomePlastico = NomePlastico;
            this.DataValidade = DataValidade;
            this.StatusCartao = StatusCartao;
            this.StatusCartaoDescricao = StatusCartaoDescricao;
            
        }
        
    
        /// <summary>
        /// {{{compra_contestada_cartao_detalhe_response_numero_cartao_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_cartao_detalhe_response_numero_cartao_value}}}</value>
        [DataMember(Name="numeroCartao", EmitDefaultValue=false)]
        public string NumeroCartao { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_cartao_detalhe_response_portador_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_cartao_detalhe_response_portador_value}}}</value>
        [DataMember(Name="portador", EmitDefaultValue=false)]
        public string Portador { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_cartao_detalhe_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_cartao_detalhe_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_cartao_detalhe_response_nome_plastico_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_cartao_detalhe_response_nome_plastico_value}}}</value>
        [DataMember(Name="nomePlastico", EmitDefaultValue=false)]
        public string NomePlastico { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_cartao_detalhe_response_data_validade_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_cartao_detalhe_response_data_validade_value}}}</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public DateTime? DataValidade { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_cartao_detalhe_response_status_cartao_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_cartao_detalhe_response_status_cartao_value}}}</value>
        [DataMember(Name="statusCartao", EmitDefaultValue=false)]
        public string StatusCartao { get; set; }
    
        /// <summary>
        /// {{{compra_contestada_cartao_detalhe_response_status_cartao_descricao_value}}}
        /// </summary>
        /// <value>{{{compra_contestada_cartao_detalhe_response_status_cartao_descricao_value}}}</value>
        [DataMember(Name="statusCartaoDescricao", EmitDefaultValue=false)]
        public string StatusCartaoDescricao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompraContestadaCartaoDetalheResponse {\n");
            sb.Append("  NumeroCartao: ").Append(NumeroCartao).Append("\n");
            sb.Append("  Portador: ").Append(Portador).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  NomePlastico: ").Append(NomePlastico).Append("\n");
            sb.Append("  DataValidade: ").Append(DataValidade).Append("\n");
            sb.Append("  StatusCartao: ").Append(StatusCartao).Append("\n");
            sb.Append("  StatusCartaoDescricao: ").Append(StatusCartaoDescricao).Append("\n");
            
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
            return this.Equals(obj as CompraContestadaCartaoDetalheResponse);
        }

        /// <summary>
        /// Returns true if CompraContestadaCartaoDetalheResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CompraContestadaCartaoDetalheResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompraContestadaCartaoDetalheResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NumeroCartao == other.NumeroCartao ||
                    this.NumeroCartao != null &&
                    this.NumeroCartao.Equals(other.NumeroCartao)
                ) && 
                (
                    this.Portador == other.Portador ||
                    this.Portador != null &&
                    this.Portador.Equals(other.Portador)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.NomePlastico == other.NomePlastico ||
                    this.NomePlastico != null &&
                    this.NomePlastico.Equals(other.NomePlastico)
                ) && 
                (
                    this.DataValidade == other.DataValidade ||
                    this.DataValidade != null &&
                    this.DataValidade.Equals(other.DataValidade)
                ) && 
                (
                    this.StatusCartao == other.StatusCartao ||
                    this.StatusCartao != null &&
                    this.StatusCartao.Equals(other.StatusCartao)
                ) && 
                (
                    this.StatusCartaoDescricao == other.StatusCartaoDescricao ||
                    this.StatusCartaoDescricao != null &&
                    this.StatusCartaoDescricao.Equals(other.StatusCartaoDescricao)
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
                
                if (this.NumeroCartao != null)
                    hash = hash * 59 + this.NumeroCartao.GetHashCode();
                
                if (this.Portador != null)
                    hash = hash * 59 + this.Portador.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.NomePlastico != null)
                    hash = hash * 59 + this.NomePlastico.GetHashCode();
                
                if (this.DataValidade != null)
                    hash = hash * 59 + this.DataValidade.GetHashCode();
                
                if (this.StatusCartao != null)
                    hash = hash * 59 + this.StatusCartao.GetHashCode();
                
                if (this.StatusCartaoDescricao != null)
                    hash = hash * 59 + this.StatusCartaoDescricao.GetHashCode();
                
                return hash;
            }
        }

    }
}
