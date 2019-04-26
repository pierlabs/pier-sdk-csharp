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
    /// Classe AgendamentoResponse
    /// </summary>
    [DataContract]
    public partial class AgendamentoResponse :  IEquatable<AgendamentoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AgendamentoResponse" /> class.
        /// Initializes a new instance of the <see cref="AgendamentoResponse" />class.
        /// </summary>
        /// <param name="IdAgendamento">ID do Agendamento criado.</param>
        /// <param name="DataCriacao">Data de Cria\u00E7\u00E3o do Agendamento.</param>
        /// <param name="IdConta">ID da Conta do Portador.</param>
        /// <param name="TipoOperacao">ID da Conta do Portador.</param>
        /// <param name="TipoRecorrencia">Tipo de Recorrencia da Recarga (Mensal, Diaria, etc).</param>
        /// <param name="QuantidadeAgendamento">Quantidade que este agendamento ser\u00E1 repetido.</param>
        /// <param name="DiaRecorrencia">Dia de recorrencia deste agendamento.</param>
        /// <param name="Valor">Valor do agendamento.</param>
        /// <param name="Status">Status atual do Agendamento.</param>

        public AgendamentoResponse(long? IdAgendamento = null, string DataCriacao = null, int? IdConta = null, int? TipoOperacao = null, int? TipoRecorrencia = null, int? QuantidadeAgendamento = null, int? DiaRecorrencia = null, double? Valor = null, int? Status = null)
        {
            this.IdAgendamento = IdAgendamento;
            this.DataCriacao = DataCriacao;
            this.IdConta = IdConta;
            this.TipoOperacao = TipoOperacao;
            this.TipoRecorrencia = TipoRecorrencia;
            this.QuantidadeAgendamento = QuantidadeAgendamento;
            this.DiaRecorrencia = DiaRecorrencia;
            this.Valor = Valor;
            this.Status = Status;
            
        }
        
    
        /// <summary>
        /// ID do Agendamento criado
        /// </summary>
        /// <value>ID do Agendamento criado</value>
        [DataMember(Name="idAgendamento", EmitDefaultValue=false)]
        public long? IdAgendamento { get; set; }
    
        /// <summary>
        /// Data de Cria\u00E7\u00E3o do Agendamento
        /// </summary>
        /// <value>Data de Cria\u00E7\u00E3o do Agendamento</value>
        [DataMember(Name="dataCriacao", EmitDefaultValue=false)]
        public string DataCriacao { get; set; }
    
        /// <summary>
        /// ID da Conta do Portador
        /// </summary>
        /// <value>ID da Conta do Portador</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public int? IdConta { get; set; }
    
        /// <summary>
        /// ID da Conta do Portador
        /// </summary>
        /// <value>ID da Conta do Portador</value>
        [DataMember(Name="tipoOperacao", EmitDefaultValue=false)]
        public int? TipoOperacao { get; set; }
    
        /// <summary>
        /// Tipo de Recorrencia da Recarga (Mensal, Diaria, etc)
        /// </summary>
        /// <value>Tipo de Recorrencia da Recarga (Mensal, Diaria, etc)</value>
        [DataMember(Name="tipoRecorrencia", EmitDefaultValue=false)]
        public int? TipoRecorrencia { get; set; }
    
        /// <summary>
        /// Quantidade que este agendamento ser\u00E1 repetido
        /// </summary>
        /// <value>Quantidade que este agendamento ser\u00E1 repetido</value>
        [DataMember(Name="quantidadeAgendamento", EmitDefaultValue=false)]
        public int? QuantidadeAgendamento { get; set; }
    
        /// <summary>
        /// Dia de recorrencia deste agendamento
        /// </summary>
        /// <value>Dia de recorrencia deste agendamento</value>
        [DataMember(Name="diaRecorrencia", EmitDefaultValue=false)]
        public int? DiaRecorrencia { get; set; }
    
        /// <summary>
        /// Valor do agendamento
        /// </summary>
        /// <value>Valor do agendamento</value>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }
    
        /// <summary>
        /// Status atual do Agendamento
        /// </summary>
        /// <value>Status atual do Agendamento</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgendamentoResponse {\n");
            sb.Append("  IdAgendamento: ").Append(IdAgendamento).Append("\n");
            sb.Append("  DataCriacao: ").Append(DataCriacao).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  TipoOperacao: ").Append(TipoOperacao).Append("\n");
            sb.Append("  TipoRecorrencia: ").Append(TipoRecorrencia).Append("\n");
            sb.Append("  QuantidadeAgendamento: ").Append(QuantidadeAgendamento).Append("\n");
            sb.Append("  DiaRecorrencia: ").Append(DiaRecorrencia).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            
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
            return this.Equals(obj as AgendamentoResponse);
        }

        /// <summary>
        /// Returns true if AgendamentoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AgendamentoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgendamentoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdAgendamento == other.IdAgendamento ||
                    this.IdAgendamento != null &&
                    this.IdAgendamento.Equals(other.IdAgendamento)
                ) && 
                (
                    this.DataCriacao == other.DataCriacao ||
                    this.DataCriacao != null &&
                    this.DataCriacao.Equals(other.DataCriacao)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.TipoOperacao == other.TipoOperacao ||
                    this.TipoOperacao != null &&
                    this.TipoOperacao.Equals(other.TipoOperacao)
                ) && 
                (
                    this.TipoRecorrencia == other.TipoRecorrencia ||
                    this.TipoRecorrencia != null &&
                    this.TipoRecorrencia.Equals(other.TipoRecorrencia)
                ) && 
                (
                    this.QuantidadeAgendamento == other.QuantidadeAgendamento ||
                    this.QuantidadeAgendamento != null &&
                    this.QuantidadeAgendamento.Equals(other.QuantidadeAgendamento)
                ) && 
                (
                    this.DiaRecorrencia == other.DiaRecorrencia ||
                    this.DiaRecorrencia != null &&
                    this.DiaRecorrencia.Equals(other.DiaRecorrencia)
                ) && 
                (
                    this.Valor == other.Valor ||
                    this.Valor != null &&
                    this.Valor.Equals(other.Valor)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                
                if (this.IdAgendamento != null)
                    hash = hash * 59 + this.IdAgendamento.GetHashCode();
                
                if (this.DataCriacao != null)
                    hash = hash * 59 + this.DataCriacao.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.TipoOperacao != null)
                    hash = hash * 59 + this.TipoOperacao.GetHashCode();
                
                if (this.TipoRecorrencia != null)
                    hash = hash * 59 + this.TipoRecorrencia.GetHashCode();
                
                if (this.QuantidadeAgendamento != null)
                    hash = hash * 59 + this.QuantidadeAgendamento.GetHashCode();
                
                if (this.DiaRecorrencia != null)
                    hash = hash * 59 + this.DiaRecorrencia.GetHashCode();
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }
}
