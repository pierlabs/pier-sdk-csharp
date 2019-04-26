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
    /// ParcelaAgendamentoResponse
    /// </summary>
    [DataContract]
    public partial class ClasseParcelaAgendamentoResponse :  IEquatable<ClasseParcelaAgendamentoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ClasseParcelaAgendamentoResponse" /> class.
        /// Initializes a new instance of the <see cref="ClasseParcelaAgendamentoResponse" />class.
        /// </summary>
        /// <param name="IdParcela">ID da Parcela agendada.</param>
        /// <param name="IdAgendamento">ID do Agendamento que a parcela pertence.</param>
        /// <param name="DataAgendada">Data que ser\u00E1 realizada a recarga.</param>
        /// <param name="DataEfetivacao">Data que foi realizada a recarga.</param>
        /// <param name="Status">Status da parcela .</param>
        /// <param name="Observacao">Observacoes caso ocorra alteracao do status.</param>

        public ClasseParcelaAgendamentoResponse(long? IdParcela = null, int? IdAgendamento = null, string DataAgendada = null, string DataEfetivacao = null, int? Status = null, string Observacao = null)
        {
            this.IdParcela = IdParcela;
            this.IdAgendamento = IdAgendamento;
            this.DataAgendada = DataAgendada;
            this.DataEfetivacao = DataEfetivacao;
            this.Status = Status;
            this.Observacao = Observacao;
            
        }
        
    
        /// <summary>
        /// ID da Parcela agendada
        /// </summary>
        /// <value>ID da Parcela agendada</value>
        [DataMember(Name="idParcela", EmitDefaultValue=false)]
        public long? IdParcela { get; set; }
    
        /// <summary>
        /// ID do Agendamento que a parcela pertence
        /// </summary>
        /// <value>ID do Agendamento que a parcela pertence</value>
        [DataMember(Name="idAgendamento", EmitDefaultValue=false)]
        public int? IdAgendamento { get; set; }
    
        /// <summary>
        /// Data que ser\u00E1 realizada a recarga
        /// </summary>
        /// <value>Data que ser\u00E1 realizada a recarga</value>
        [DataMember(Name="dataAgendada", EmitDefaultValue=false)]
        public string DataAgendada { get; set; }
    
        /// <summary>
        /// Data que foi realizada a recarga
        /// </summary>
        /// <value>Data que foi realizada a recarga</value>
        [DataMember(Name="dataEfetivacao", EmitDefaultValue=false)]
        public string DataEfetivacao { get; set; }
    
        /// <summary>
        /// Status da parcela 
        /// </summary>
        /// <value>Status da parcela </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
    
        /// <summary>
        /// Observacoes caso ocorra alteracao do status
        /// </summary>
        /// <value>Observacoes caso ocorra alteracao do status</value>
        [DataMember(Name="observacao", EmitDefaultValue=false)]
        public string Observacao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClasseParcelaAgendamentoResponse {\n");
            sb.Append("  IdParcela: ").Append(IdParcela).Append("\n");
            sb.Append("  IdAgendamento: ").Append(IdAgendamento).Append("\n");
            sb.Append("  DataAgendada: ").Append(DataAgendada).Append("\n");
            sb.Append("  DataEfetivacao: ").Append(DataEfetivacao).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Observacao: ").Append(Observacao).Append("\n");
            
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
            return this.Equals(obj as ClasseParcelaAgendamentoResponse);
        }

        /// <summary>
        /// Returns true if ClasseParcelaAgendamentoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ClasseParcelaAgendamentoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClasseParcelaAgendamentoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdParcela == other.IdParcela ||
                    this.IdParcela != null &&
                    this.IdParcela.Equals(other.IdParcela)
                ) && 
                (
                    this.IdAgendamento == other.IdAgendamento ||
                    this.IdAgendamento != null &&
                    this.IdAgendamento.Equals(other.IdAgendamento)
                ) && 
                (
                    this.DataAgendada == other.DataAgendada ||
                    this.DataAgendada != null &&
                    this.DataAgendada.Equals(other.DataAgendada)
                ) && 
                (
                    this.DataEfetivacao == other.DataEfetivacao ||
                    this.DataEfetivacao != null &&
                    this.DataEfetivacao.Equals(other.DataEfetivacao)
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
                
                if (this.IdParcela != null)
                    hash = hash * 59 + this.IdParcela.GetHashCode();
                
                if (this.IdAgendamento != null)
                    hash = hash * 59 + this.IdAgendamento.GetHashCode();
                
                if (this.DataAgendada != null)
                    hash = hash * 59 + this.DataAgendada.GetHashCode();
                
                if (this.DataEfetivacao != null)
                    hash = hash * 59 + this.DataEfetivacao.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Observacao != null)
                    hash = hash * 59 + this.Observacao.GetHashCode();
                
                return hash;
            }
        }

    }
}
