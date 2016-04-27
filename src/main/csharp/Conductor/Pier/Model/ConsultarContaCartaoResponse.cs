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
    /// 
    /// </summary>
    [DataContract]
    public partial class ConsultarContaCartaoResponse :  IEquatable<ConsultarContaCartaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsultarContaCartaoResponse" /> class.
        /// Initializes a new instance of the <see cref="ConsultarContaCartaoResponse" />class.
        /// </summary>
        /// <param name="DataValidade">DataValidade.</param>
        /// <param name="DescricaoEstagio">DescricaoEstagio.</param>
        /// <param name="DescricaoStatus">DescricaoStatus.</param>
        /// <param name="Estagio">Estagio.</param>
        /// <param name="FlagCancelamento">FlagCancelamento.</param>
        /// <param name="IdCartao">IdCartao.</param>
        /// <param name="NumeroCartao">NumeroCartao.</param>
        /// <param name="Portador">Portador.</param>
        /// <param name="PortadorId">PortadorId.</param>
        /// <param name="Status">Status.</param>
        /// <param name="StatusData">StatusData.</param>

        public ConsultarContaCartaoResponse(string DataValidade = null, string DescricaoEstagio = null, string DescricaoStatus = null, int? Estagio = null, bool? FlagCancelamento = null, int? IdCartao = null, string NumeroCartao = null, string Portador = null, int? PortadorId = null, int? Status = null, DateTime? StatusData = null)
        {
            this.DataValidade = DataValidade;
            this.DescricaoEstagio = DescricaoEstagio;
            this.DescricaoStatus = DescricaoStatus;
            this.Estagio = Estagio;
            this.FlagCancelamento = FlagCancelamento;
            this.IdCartao = IdCartao;
            this.NumeroCartao = NumeroCartao;
            this.Portador = Portador;
            this.PortadorId = PortadorId;
            this.Status = Status;
            this.StatusData = StatusData;
            
        }
        
    
        /// <summary>
        /// Gets or Sets DataValidade
        /// </summary>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
    
        /// <summary>
        /// Gets or Sets DescricaoEstagio
        /// </summary>
        [DataMember(Name="descricaoEstagio", EmitDefaultValue=false)]
        public string DescricaoEstagio { get; set; }
    
        /// <summary>
        /// Gets or Sets DescricaoStatus
        /// </summary>
        [DataMember(Name="descricaoStatus", EmitDefaultValue=false)]
        public string DescricaoStatus { get; set; }
    
        /// <summary>
        /// Gets or Sets Estagio
        /// </summary>
        [DataMember(Name="estagio", EmitDefaultValue=false)]
        public int? Estagio { get; set; }
    
        /// <summary>
        /// Gets or Sets FlagCancelamento
        /// </summary>
        [DataMember(Name="flagCancelamento", EmitDefaultValue=false)]
        public bool? FlagCancelamento { get; set; }
    
        /// <summary>
        /// Gets or Sets IdCartao
        /// </summary>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public int? IdCartao { get; set; }
    
        /// <summary>
        /// Gets or Sets NumeroCartao
        /// </summary>
        [DataMember(Name="numeroCartao", EmitDefaultValue=false)]
        public string NumeroCartao { get; set; }
    
        /// <summary>
        /// Gets or Sets Portador
        /// </summary>
        [DataMember(Name="portador", EmitDefaultValue=false)]
        public string Portador { get; set; }
    
        /// <summary>
        /// Gets or Sets PortadorId
        /// </summary>
        [DataMember(Name="portadorId", EmitDefaultValue=false)]
        public int? PortadorId { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
    
        /// <summary>
        /// Gets or Sets StatusData
        /// </summary>
        [DataMember(Name="statusData", EmitDefaultValue=false)]
        public DateTime? StatusData { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsultarContaCartaoResponse {\n");
            sb.Append("  DataValidade: ").Append(DataValidade).Append("\n");
            sb.Append("  DescricaoEstagio: ").Append(DescricaoEstagio).Append("\n");
            sb.Append("  DescricaoStatus: ").Append(DescricaoStatus).Append("\n");
            sb.Append("  Estagio: ").Append(Estagio).Append("\n");
            sb.Append("  FlagCancelamento: ").Append(FlagCancelamento).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  NumeroCartao: ").Append(NumeroCartao).Append("\n");
            sb.Append("  Portador: ").Append(Portador).Append("\n");
            sb.Append("  PortadorId: ").Append(PortadorId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusData: ").Append(StatusData).Append("\n");
            
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
            return this.Equals(obj as ConsultarContaCartaoResponse);
        }

        /// <summary>
        /// Returns true if ConsultarContaCartaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ConsultarContaCartaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsultarContaCartaoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DataValidade == other.DataValidade ||
                    this.DataValidade != null &&
                    this.DataValidade.Equals(other.DataValidade)
                ) && 
                (
                    this.DescricaoEstagio == other.DescricaoEstagio ||
                    this.DescricaoEstagio != null &&
                    this.DescricaoEstagio.Equals(other.DescricaoEstagio)
                ) && 
                (
                    this.DescricaoStatus == other.DescricaoStatus ||
                    this.DescricaoStatus != null &&
                    this.DescricaoStatus.Equals(other.DescricaoStatus)
                ) && 
                (
                    this.Estagio == other.Estagio ||
                    this.Estagio != null &&
                    this.Estagio.Equals(other.Estagio)
                ) && 
                (
                    this.FlagCancelamento == other.FlagCancelamento ||
                    this.FlagCancelamento != null &&
                    this.FlagCancelamento.Equals(other.FlagCancelamento)
                ) && 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
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
                    this.PortadorId == other.PortadorId ||
                    this.PortadorId != null &&
                    this.PortadorId.Equals(other.PortadorId)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.StatusData == other.StatusData ||
                    this.StatusData != null &&
                    this.StatusData.Equals(other.StatusData)
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
                
                if (this.DataValidade != null)
                    hash = hash * 59 + this.DataValidade.GetHashCode();
                
                if (this.DescricaoEstagio != null)
                    hash = hash * 59 + this.DescricaoEstagio.GetHashCode();
                
                if (this.DescricaoStatus != null)
                    hash = hash * 59 + this.DescricaoStatus.GetHashCode();
                
                if (this.Estagio != null)
                    hash = hash * 59 + this.Estagio.GetHashCode();
                
                if (this.FlagCancelamento != null)
                    hash = hash * 59 + this.FlagCancelamento.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.NumeroCartao != null)
                    hash = hash * 59 + this.NumeroCartao.GetHashCode();
                
                if (this.Portador != null)
                    hash = hash * 59 + this.Portador.GetHashCode();
                
                if (this.PortadorId != null)
                    hash = hash * 59 + this.PortadorId.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.StatusData != null)
                    hash = hash * 59 + this.StatusData.GetHashCode();
                
                return hash;
            }
        }

    }
}
