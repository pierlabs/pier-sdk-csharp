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
    /// Billing Object
    /// </summary>
    [DataContract]
    public partial class TipoFaturamentoPorContaResponse :  IEquatable<TipoFaturamentoPorContaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoFaturamentoPorContaResponse" /> class.
        /// Initializes a new instance of the <see cref="TipoFaturamentoPorContaResponse" />class.
        /// </summary>
        /// <param name="Id">Identification Code of the billing type per account (id).</param>
        /// <param name="IdConta">Identification Code of the related account to the billing type.</param>
        /// <param name="Ativo">Status of the configuration that represents if the billing type per account is active or canceled.</param>
        /// <param name="IdTipoFaturamento">Identification Code of the referenced billing type.</param>
        /// <param name="DataHoraInclusao">Inclusion date of the configuration of the billing type per account.</param>
        /// <param name="DataHoraCancelamento">Cancellation date of the configuration type of billing per account.</param>
        /// <param name="ModificadoPor">Description of the responsable for the last update of the configuration.</param>

        public TipoFaturamentoPorContaResponse(long? Id = null, long? IdConta = null, bool? Ativo = null, long? IdTipoFaturamento = null, string DataHoraInclusao = null, string DataHoraCancelamento = null, string ModificadoPor = null)
        {
            this.Id = Id;
            this.IdConta = IdConta;
            this.Ativo = Ativo;
            this.IdTipoFaturamento = IdTipoFaturamento;
            this.DataHoraInclusao = DataHoraInclusao;
            this.DataHoraCancelamento = DataHoraCancelamento;
            this.ModificadoPor = ModificadoPor;
            
        }
        
    
        /// <summary>
        /// Identification Code of the billing type per account (id)
        /// </summary>
        /// <value>Identification Code of the billing type per account (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Identification Code of the related account to the billing type
        /// </summary>
        /// <value>Identification Code of the related account to the billing type</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Status of the configuration that represents if the billing type per account is active or canceled
        /// </summary>
        /// <value>Status of the configuration that represents if the billing type per account is active or canceled</value>
        [DataMember(Name="ativo", EmitDefaultValue=false)]
        public bool? Ativo { get; set; }
    
        /// <summary>
        /// Identification Code of the referenced billing type
        /// </summary>
        /// <value>Identification Code of the referenced billing type</value>
        [DataMember(Name="idTipoFaturamento", EmitDefaultValue=false)]
        public long? IdTipoFaturamento { get; set; }
    
        /// <summary>
        /// Inclusion date of the configuration of the billing type per account
        /// </summary>
        /// <value>Inclusion date of the configuration of the billing type per account</value>
        [DataMember(Name="dataHoraInclusao", EmitDefaultValue=false)]
        public string DataHoraInclusao { get; set; }
    
        /// <summary>
        /// Cancellation date of the configuration type of billing per account
        /// </summary>
        /// <value>Cancellation date of the configuration type of billing per account</value>
        [DataMember(Name="dataHoraCancelamento", EmitDefaultValue=false)]
        public string DataHoraCancelamento { get; set; }
    
        /// <summary>
        /// Description of the responsable for the last update of the configuration
        /// </summary>
        /// <value>Description of the responsable for the last update of the configuration</value>
        [DataMember(Name="modificadoPor", EmitDefaultValue=false)]
        public string ModificadoPor { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoFaturamentoPorContaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  Ativo: ").Append(Ativo).Append("\n");
            sb.Append("  IdTipoFaturamento: ").Append(IdTipoFaturamento).Append("\n");
            sb.Append("  DataHoraInclusao: ").Append(DataHoraInclusao).Append("\n");
            sb.Append("  DataHoraCancelamento: ").Append(DataHoraCancelamento).Append("\n");
            sb.Append("  ModificadoPor: ").Append(ModificadoPor).Append("\n");
            
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
            return this.Equals(obj as TipoFaturamentoPorContaResponse);
        }

        /// <summary>
        /// Returns true if TipoFaturamentoPorContaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoFaturamentoPorContaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoFaturamentoPorContaResponse other)
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
                    this.Ativo == other.Ativo ||
                    this.Ativo != null &&
                    this.Ativo.Equals(other.Ativo)
                ) && 
                (
                    this.IdTipoFaturamento == other.IdTipoFaturamento ||
                    this.IdTipoFaturamento != null &&
                    this.IdTipoFaturamento.Equals(other.IdTipoFaturamento)
                ) && 
                (
                    this.DataHoraInclusao == other.DataHoraInclusao ||
                    this.DataHoraInclusao != null &&
                    this.DataHoraInclusao.Equals(other.DataHoraInclusao)
                ) && 
                (
                    this.DataHoraCancelamento == other.DataHoraCancelamento ||
                    this.DataHoraCancelamento != null &&
                    this.DataHoraCancelamento.Equals(other.DataHoraCancelamento)
                ) && 
                (
                    this.ModificadoPor == other.ModificadoPor ||
                    this.ModificadoPor != null &&
                    this.ModificadoPor.Equals(other.ModificadoPor)
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
                
                if (this.Ativo != null)
                    hash = hash * 59 + this.Ativo.GetHashCode();
                
                if (this.IdTipoFaturamento != null)
                    hash = hash * 59 + this.IdTipoFaturamento.GetHashCode();
                
                if (this.DataHoraInclusao != null)
                    hash = hash * 59 + this.DataHoraInclusao.GetHashCode();
                
                if (this.DataHoraCancelamento != null)
                    hash = hash * 59 + this.DataHoraCancelamento.GetHashCode();
                
                if (this.ModificadoPor != null)
                    hash = hash * 59 + this.ModificadoPor.GetHashCode();
                
                return hash;
            }
        }

    }
}
