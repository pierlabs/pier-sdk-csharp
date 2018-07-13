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
    /// {{{atendimento_cliente_response_description}}}
    /// </summary>
    [DataContract]
    public partial class AtendimentoClienteResponse :  IEquatable<AtendimentoClienteResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AtendimentoClienteResponse" /> class.
        /// Initializes a new instance of the <see cref="AtendimentoClienteResponse" />class.
        /// </summary>
        /// <param name="IdAtendimento">{{{atendimento_cliente_response_id_atendimento_value}}}.</param>
        /// <param name="IdConta">{{{atendimento_cliente_response_id_conta_value}}}.</param>
        /// <param name="IdTipoAtendimento">{{{atendimento_cliente_response_id_tipo_atendimento_value}}}.</param>
        /// <param name="DescricaoTipoAtendimento">{{{atendimento_cliente_response_descricao_tipo_atendimento_value}}}.</param>
        /// <param name="ConteudoAtendimento">{{{atendimento_cliente_response_conteudo_atendimento_value}}}.</param>
        /// <param name="DetalhesAtendimento">{{{atendimento_cliente_response_detalhes_atendimento_value}}}.</param>
        /// <param name="NomeAtendente">{{{atendimento_cliente_response_nome_atendente_value}}}.</param>
        /// <param name="NomeSistema">{{{atendimento_cliente_response_nome_sistema_value}}}.</param>
        /// <param name="DataHoraInicioAtendimento">{{{atendimento_cliente_response_data_hora_inicio_atendimento_value}}}.</param>
        /// <param name="DataHoraFimAtendimento">{{{atendimento_cliente_response_data_hora_fim_atendimento_value}}}.</param>
        /// <param name="DataAtendimento">{{{atendimento_cliente_response_data_atendimento_value}}}.</param>
        /// <param name="DataAgendamento">{{{atendimento_cliente_response_data_agendamento_value}}}.</param>
        /// <param name="DataProcessamento">{{{atendimento_cliente_response_data_processamento_value}}}.</param>
        /// <param name="FlagProcessamento">{{{atendimento_cliente_response_flag_processamento_value}}}.</param>

        public AtendimentoClienteResponse(long? IdAtendimento = null, long? IdConta = null, long? IdTipoAtendimento = null, string DescricaoTipoAtendimento = null, string ConteudoAtendimento = null, string DetalhesAtendimento = null, string NomeAtendente = null, string NomeSistema = null, string DataHoraInicioAtendimento = null, string DataHoraFimAtendimento = null, string DataAtendimento = null, string DataAgendamento = null, string DataProcessamento = null, int? FlagProcessamento = null)
        {
            this.IdAtendimento = IdAtendimento;
            this.IdConta = IdConta;
            this.IdTipoAtendimento = IdTipoAtendimento;
            this.DescricaoTipoAtendimento = DescricaoTipoAtendimento;
            this.ConteudoAtendimento = ConteudoAtendimento;
            this.DetalhesAtendimento = DetalhesAtendimento;
            this.NomeAtendente = NomeAtendente;
            this.NomeSistema = NomeSistema;
            this.DataHoraInicioAtendimento = DataHoraInicioAtendimento;
            this.DataHoraFimAtendimento = DataHoraFimAtendimento;
            this.DataAtendimento = DataAtendimento;
            this.DataAgendamento = DataAgendamento;
            this.DataProcessamento = DataProcessamento;
            this.FlagProcessamento = FlagProcessamento;
            
        }
        
    
        /// <summary>
        /// {{{atendimento_cliente_response_id_atendimento_value}}}
        /// </summary>
        /// <value>{{{atendimento_cliente_response_id_atendimento_value}}}</value>
        [DataMember(Name="idAtendimento", EmitDefaultValue=false)]
        public long? IdAtendimento { get; set; }
    
        /// <summary>
        /// {{{atendimento_cliente_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{atendimento_cliente_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{atendimento_cliente_response_id_tipo_atendimento_value}}}
        /// </summary>
        /// <value>{{{atendimento_cliente_response_id_tipo_atendimento_value}}}</value>
        [DataMember(Name="idTipoAtendimento", EmitDefaultValue=false)]
        public long? IdTipoAtendimento { get; set; }
    
        /// <summary>
        /// {{{atendimento_cliente_response_descricao_tipo_atendimento_value}}}
        /// </summary>
        /// <value>{{{atendimento_cliente_response_descricao_tipo_atendimento_value}}}</value>
        [DataMember(Name="descricaoTipoAtendimento", EmitDefaultValue=false)]
        public string DescricaoTipoAtendimento { get; set; }
    
        /// <summary>
        /// {{{atendimento_cliente_response_conteudo_atendimento_value}}}
        /// </summary>
        /// <value>{{{atendimento_cliente_response_conteudo_atendimento_value}}}</value>
        [DataMember(Name="conteudoAtendimento", EmitDefaultValue=false)]
        public string ConteudoAtendimento { get; set; }
    
        /// <summary>
        /// {{{atendimento_cliente_response_detalhes_atendimento_value}}}
        /// </summary>
        /// <value>{{{atendimento_cliente_response_detalhes_atendimento_value}}}</value>
        [DataMember(Name="detalhesAtendimento", EmitDefaultValue=false)]
        public string DetalhesAtendimento { get; set; }
    
        /// <summary>
        /// {{{atendimento_cliente_response_nome_atendente_value}}}
        /// </summary>
        /// <value>{{{atendimento_cliente_response_nome_atendente_value}}}</value>
        [DataMember(Name="nomeAtendente", EmitDefaultValue=false)]
        public string NomeAtendente { get; set; }
    
        /// <summary>
        /// {{{atendimento_cliente_response_nome_sistema_value}}}
        /// </summary>
        /// <value>{{{atendimento_cliente_response_nome_sistema_value}}}</value>
        [DataMember(Name="nomeSistema", EmitDefaultValue=false)]
        public string NomeSistema { get; set; }
    
        /// <summary>
        /// {{{atendimento_cliente_response_data_hora_inicio_atendimento_value}}}
        /// </summary>
        /// <value>{{{atendimento_cliente_response_data_hora_inicio_atendimento_value}}}</value>
        [DataMember(Name="dataHoraInicioAtendimento", EmitDefaultValue=false)]
        public string DataHoraInicioAtendimento { get; set; }
    
        /// <summary>
        /// {{{atendimento_cliente_response_data_hora_fim_atendimento_value}}}
        /// </summary>
        /// <value>{{{atendimento_cliente_response_data_hora_fim_atendimento_value}}}</value>
        [DataMember(Name="dataHoraFimAtendimento", EmitDefaultValue=false)]
        public string DataHoraFimAtendimento { get; set; }
    
        /// <summary>
        /// {{{atendimento_cliente_response_data_atendimento_value}}}
        /// </summary>
        /// <value>{{{atendimento_cliente_response_data_atendimento_value}}}</value>
        [DataMember(Name="dataAtendimento", EmitDefaultValue=false)]
        public string DataAtendimento { get; set; }
    
        /// <summary>
        /// {{{atendimento_cliente_response_data_agendamento_value}}}
        /// </summary>
        /// <value>{{{atendimento_cliente_response_data_agendamento_value}}}</value>
        [DataMember(Name="dataAgendamento", EmitDefaultValue=false)]
        public string DataAgendamento { get; set; }
    
        /// <summary>
        /// {{{atendimento_cliente_response_data_processamento_value}}}
        /// </summary>
        /// <value>{{{atendimento_cliente_response_data_processamento_value}}}</value>
        [DataMember(Name="dataProcessamento", EmitDefaultValue=false)]
        public string DataProcessamento { get; set; }
    
        /// <summary>
        /// {{{atendimento_cliente_response_flag_processamento_value}}}
        /// </summary>
        /// <value>{{{atendimento_cliente_response_flag_processamento_value}}}</value>
        [DataMember(Name="flagProcessamento", EmitDefaultValue=false)]
        public int? FlagProcessamento { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AtendimentoClienteResponse {\n");
            sb.Append("  IdAtendimento: ").Append(IdAtendimento).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdTipoAtendimento: ").Append(IdTipoAtendimento).Append("\n");
            sb.Append("  DescricaoTipoAtendimento: ").Append(DescricaoTipoAtendimento).Append("\n");
            sb.Append("  ConteudoAtendimento: ").Append(ConteudoAtendimento).Append("\n");
            sb.Append("  DetalhesAtendimento: ").Append(DetalhesAtendimento).Append("\n");
            sb.Append("  NomeAtendente: ").Append(NomeAtendente).Append("\n");
            sb.Append("  NomeSistema: ").Append(NomeSistema).Append("\n");
            sb.Append("  DataHoraInicioAtendimento: ").Append(DataHoraInicioAtendimento).Append("\n");
            sb.Append("  DataHoraFimAtendimento: ").Append(DataHoraFimAtendimento).Append("\n");
            sb.Append("  DataAtendimento: ").Append(DataAtendimento).Append("\n");
            sb.Append("  DataAgendamento: ").Append(DataAgendamento).Append("\n");
            sb.Append("  DataProcessamento: ").Append(DataProcessamento).Append("\n");
            sb.Append("  FlagProcessamento: ").Append(FlagProcessamento).Append("\n");
            
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
            return this.Equals(obj as AtendimentoClienteResponse);
        }

        /// <summary>
        /// Returns true if AtendimentoClienteResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AtendimentoClienteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AtendimentoClienteResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdAtendimento == other.IdAtendimento ||
                    this.IdAtendimento != null &&
                    this.IdAtendimento.Equals(other.IdAtendimento)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdTipoAtendimento == other.IdTipoAtendimento ||
                    this.IdTipoAtendimento != null &&
                    this.IdTipoAtendimento.Equals(other.IdTipoAtendimento)
                ) && 
                (
                    this.DescricaoTipoAtendimento == other.DescricaoTipoAtendimento ||
                    this.DescricaoTipoAtendimento != null &&
                    this.DescricaoTipoAtendimento.Equals(other.DescricaoTipoAtendimento)
                ) && 
                (
                    this.ConteudoAtendimento == other.ConteudoAtendimento ||
                    this.ConteudoAtendimento != null &&
                    this.ConteudoAtendimento.Equals(other.ConteudoAtendimento)
                ) && 
                (
                    this.DetalhesAtendimento == other.DetalhesAtendimento ||
                    this.DetalhesAtendimento != null &&
                    this.DetalhesAtendimento.Equals(other.DetalhesAtendimento)
                ) && 
                (
                    this.NomeAtendente == other.NomeAtendente ||
                    this.NomeAtendente != null &&
                    this.NomeAtendente.Equals(other.NomeAtendente)
                ) && 
                (
                    this.NomeSistema == other.NomeSistema ||
                    this.NomeSistema != null &&
                    this.NomeSistema.Equals(other.NomeSistema)
                ) && 
                (
                    this.DataHoraInicioAtendimento == other.DataHoraInicioAtendimento ||
                    this.DataHoraInicioAtendimento != null &&
                    this.DataHoraInicioAtendimento.Equals(other.DataHoraInicioAtendimento)
                ) && 
                (
                    this.DataHoraFimAtendimento == other.DataHoraFimAtendimento ||
                    this.DataHoraFimAtendimento != null &&
                    this.DataHoraFimAtendimento.Equals(other.DataHoraFimAtendimento)
                ) && 
                (
                    this.DataAtendimento == other.DataAtendimento ||
                    this.DataAtendimento != null &&
                    this.DataAtendimento.Equals(other.DataAtendimento)
                ) && 
                (
                    this.DataAgendamento == other.DataAgendamento ||
                    this.DataAgendamento != null &&
                    this.DataAgendamento.Equals(other.DataAgendamento)
                ) && 
                (
                    this.DataProcessamento == other.DataProcessamento ||
                    this.DataProcessamento != null &&
                    this.DataProcessamento.Equals(other.DataProcessamento)
                ) && 
                (
                    this.FlagProcessamento == other.FlagProcessamento ||
                    this.FlagProcessamento != null &&
                    this.FlagProcessamento.Equals(other.FlagProcessamento)
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
                
                if (this.IdAtendimento != null)
                    hash = hash * 59 + this.IdAtendimento.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdTipoAtendimento != null)
                    hash = hash * 59 + this.IdTipoAtendimento.GetHashCode();
                
                if (this.DescricaoTipoAtendimento != null)
                    hash = hash * 59 + this.DescricaoTipoAtendimento.GetHashCode();
                
                if (this.ConteudoAtendimento != null)
                    hash = hash * 59 + this.ConteudoAtendimento.GetHashCode();
                
                if (this.DetalhesAtendimento != null)
                    hash = hash * 59 + this.DetalhesAtendimento.GetHashCode();
                
                if (this.NomeAtendente != null)
                    hash = hash * 59 + this.NomeAtendente.GetHashCode();
                
                if (this.NomeSistema != null)
                    hash = hash * 59 + this.NomeSistema.GetHashCode();
                
                if (this.DataHoraInicioAtendimento != null)
                    hash = hash * 59 + this.DataHoraInicioAtendimento.GetHashCode();
                
                if (this.DataHoraFimAtendimento != null)
                    hash = hash * 59 + this.DataHoraFimAtendimento.GetHashCode();
                
                if (this.DataAtendimento != null)
                    hash = hash * 59 + this.DataAtendimento.GetHashCode();
                
                if (this.DataAgendamento != null)
                    hash = hash * 59 + this.DataAgendamento.GetHashCode();
                
                if (this.DataProcessamento != null)
                    hash = hash * 59 + this.DataProcessamento.GetHashCode();
                
                if (this.FlagProcessamento != null)
                    hash = hash * 59 + this.FlagProcessamento.GetHashCode();
                
                return hash;
            }
        }

    }
}
