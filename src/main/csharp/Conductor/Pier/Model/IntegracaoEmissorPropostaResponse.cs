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
    /// {{{integracao_emissor_proposta_resposta_descricao}}}
    /// </summary>
    [DataContract]
    public partial class IntegracaoEmissorPropostaResponse :  IEquatable<IntegracaoEmissorPropostaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegracaoEmissorPropostaResponse" /> class.
        /// Initializes a new instance of the <see cref="IntegracaoEmissorPropostaResponse" />class.
        /// </summary>
        /// <param name="Id">{{{integracao_emissor_proposta_resposta_id}}}.</param>
        /// <param name="IdConta">{{{integracao_emissor_proposta_resposta_id_conta}}}.</param>
        /// <param name="Status">{{{integracao_emissor_proposta_resposta_status}}}.</param>
        /// <param name="Observacao">{{{integracao_emissor_proposta_resposta_observacao}}}.</param>
        /// <param name="FlagSelecionado">{{{integracao_emissor_proposta_resposta_flag_selecionado}}}.</param>
        /// <param name="IdPropostaExterna">{{{integracao_emissor_proposta_resposta_id_proposta_externa}}}.</param>
        /// <param name="DataEvento">{{{integracao_emissor_proposta_resposta_data_evento}}}.</param>

        public IntegracaoEmissorPropostaResponse(long? Id = null, long? IdConta = null, int? Status = null, string Observacao = null, bool? FlagSelecionado = null, long? IdPropostaExterna = null, string DataEvento = null)
        {
            this.Id = Id;
            this.IdConta = IdConta;
            this.Status = Status;
            this.Observacao = Observacao;
            this.FlagSelecionado = FlagSelecionado;
            this.IdPropostaExterna = IdPropostaExterna;
            this.DataEvento = DataEvento;
            
        }
        
    
        /// <summary>
        /// {{{integracao_emissor_proposta_resposta_id}}}
        /// </summary>
        /// <value>{{{integracao_emissor_proposta_resposta_id}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{integracao_emissor_proposta_resposta_id_conta}}}
        /// </summary>
        /// <value>{{{integracao_emissor_proposta_resposta_id_conta}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{integracao_emissor_proposta_resposta_status}}}
        /// </summary>
        /// <value>{{{integracao_emissor_proposta_resposta_status}}}</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
    
        /// <summary>
        /// {{{integracao_emissor_proposta_resposta_observacao}}}
        /// </summary>
        /// <value>{{{integracao_emissor_proposta_resposta_observacao}}}</value>
        [DataMember(Name="observacao", EmitDefaultValue=false)]
        public string Observacao { get; set; }
    
        /// <summary>
        /// {{{integracao_emissor_proposta_resposta_flag_selecionado}}}
        /// </summary>
        /// <value>{{{integracao_emissor_proposta_resposta_flag_selecionado}}}</value>
        [DataMember(Name="flagSelecionado", EmitDefaultValue=false)]
        public bool? FlagSelecionado { get; set; }
    
        /// <summary>
        /// {{{integracao_emissor_proposta_resposta_id_proposta_externa}}}
        /// </summary>
        /// <value>{{{integracao_emissor_proposta_resposta_id_proposta_externa}}}</value>
        [DataMember(Name="idPropostaExterna", EmitDefaultValue=false)]
        public long? IdPropostaExterna { get; set; }
    
        /// <summary>
        /// {{{integracao_emissor_proposta_resposta_data_evento}}}
        /// </summary>
        /// <value>{{{integracao_emissor_proposta_resposta_data_evento}}}</value>
        [DataMember(Name="dataEvento", EmitDefaultValue=false)]
        public string DataEvento { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntegracaoEmissorPropostaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Observacao: ").Append(Observacao).Append("\n");
            sb.Append("  FlagSelecionado: ").Append(FlagSelecionado).Append("\n");
            sb.Append("  IdPropostaExterna: ").Append(IdPropostaExterna).Append("\n");
            sb.Append("  DataEvento: ").Append(DataEvento).Append("\n");
            
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
            return this.Equals(obj as IntegracaoEmissorPropostaResponse);
        }

        /// <summary>
        /// Returns true if IntegracaoEmissorPropostaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of IntegracaoEmissorPropostaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegracaoEmissorPropostaResponse other)
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
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Observacao == other.Observacao ||
                    this.Observacao != null &&
                    this.Observacao.Equals(other.Observacao)
                ) && 
                (
                    this.FlagSelecionado == other.FlagSelecionado ||
                    this.FlagSelecionado != null &&
                    this.FlagSelecionado.Equals(other.FlagSelecionado)
                ) && 
                (
                    this.IdPropostaExterna == other.IdPropostaExterna ||
                    this.IdPropostaExterna != null &&
                    this.IdPropostaExterna.Equals(other.IdPropostaExterna)
                ) && 
                (
                    this.DataEvento == other.DataEvento ||
                    this.DataEvento != null &&
                    this.DataEvento.Equals(other.DataEvento)
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
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Observacao != null)
                    hash = hash * 59 + this.Observacao.GetHashCode();
                
                if (this.FlagSelecionado != null)
                    hash = hash * 59 + this.FlagSelecionado.GetHashCode();
                
                if (this.IdPropostaExterna != null)
                    hash = hash * 59 + this.IdPropostaExterna.GetHashCode();
                
                if (this.DataEvento != null)
                    hash = hash * 59 + this.DataEvento.GetHashCode();
                
                return hash;
            }
        }

    }
}
