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
    /// {{{contestar_compra_request_description}}}
    /// </summary>
    [DataContract]
    public partial class ContestarCompraRequest :  IEquatable<ContestarCompraRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContestarCompraRequest" /> class.
        /// Initializes a new instance of the <see cref="ContestarCompraRequest" />class.
        /// </summary>
        /// <param name="CodigoChargebackId">CodigoChargebackId.</param>
        /// <param name="Compras">Compras.</param>
        /// <param name="EnviarDocumentos">EnviarDocumentos.</param>
        /// <param name="Mensagem">Mensagem.</param>
        /// <param name="MensagemCSLight">MensagemCSLight.</param>
        /// <param name="MensagemChargeback">MensagemChargeback.</param>
        /// <param name="StatusId">StatusId.</param>
        /// <param name="TipoContestacaoId">TipoContestacaoId.</param>

        public ContestarCompraRequest(long? CodigoChargebackId = null, List<long?> Compras = null, bool? EnviarDocumentos = null, string Mensagem = null, string MensagemCSLight = null, string MensagemChargeback = null, long? StatusId = null, long? TipoContestacaoId = null)
        {
            this.CodigoChargebackId = CodigoChargebackId;
            this.Compras = Compras;
            this.EnviarDocumentos = EnviarDocumentos;
            this.Mensagem = Mensagem;
            this.MensagemCSLight = MensagemCSLight;
            this.MensagemChargeback = MensagemChargeback;
            this.StatusId = StatusId;
            this.TipoContestacaoId = TipoContestacaoId;
            
        }
        
    
        /// <summary>
        /// Gets or Sets CodigoChargebackId
        /// </summary>
        [DataMember(Name="codigoChargebackId", EmitDefaultValue=false)]
        public long? CodigoChargebackId { get; set; }
    
        /// <summary>
        /// Gets or Sets Compras
        /// </summary>
        [DataMember(Name="compras", EmitDefaultValue=false)]
        public List<long?> Compras { get; set; }
    
        /// <summary>
        /// Gets or Sets EnviarDocumentos
        /// </summary>
        [DataMember(Name="enviarDocumentos", EmitDefaultValue=false)]
        public bool? EnviarDocumentos { get; set; }
    
        /// <summary>
        /// Gets or Sets Mensagem
        /// </summary>
        [DataMember(Name="mensagem", EmitDefaultValue=false)]
        public string Mensagem { get; set; }
    
        /// <summary>
        /// Gets or Sets MensagemCSLight
        /// </summary>
        [DataMember(Name="mensagemCSLight", EmitDefaultValue=false)]
        public string MensagemCSLight { get; set; }
    
        /// <summary>
        /// Gets or Sets MensagemChargeback
        /// </summary>
        [DataMember(Name="mensagemChargeback", EmitDefaultValue=false)]
        public string MensagemChargeback { get; set; }
    
        /// <summary>
        /// Gets or Sets StatusId
        /// </summary>
        [DataMember(Name="statusId", EmitDefaultValue=false)]
        public long? StatusId { get; set; }
    
        /// <summary>
        /// Gets or Sets TipoContestacaoId
        /// </summary>
        [DataMember(Name="tipoContestacaoId", EmitDefaultValue=false)]
        public long? TipoContestacaoId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContestarCompraRequest {\n");
            sb.Append("  CodigoChargebackId: ").Append(CodigoChargebackId).Append("\n");
            sb.Append("  Compras: ").Append(Compras).Append("\n");
            sb.Append("  EnviarDocumentos: ").Append(EnviarDocumentos).Append("\n");
            sb.Append("  Mensagem: ").Append(Mensagem).Append("\n");
            sb.Append("  MensagemCSLight: ").Append(MensagemCSLight).Append("\n");
            sb.Append("  MensagemChargeback: ").Append(MensagemChargeback).Append("\n");
            sb.Append("  StatusId: ").Append(StatusId).Append("\n");
            sb.Append("  TipoContestacaoId: ").Append(TipoContestacaoId).Append("\n");
            
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
            return this.Equals(obj as ContestarCompraRequest);
        }

        /// <summary>
        /// Returns true if ContestarCompraRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ContestarCompraRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContestarCompraRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CodigoChargebackId == other.CodigoChargebackId ||
                    this.CodigoChargebackId != null &&
                    this.CodigoChargebackId.Equals(other.CodigoChargebackId)
                ) && 
                (
                    this.Compras == other.Compras ||
                    this.Compras != null &&
                    this.Compras.SequenceEqual(other.Compras)
                ) && 
                (
                    this.EnviarDocumentos == other.EnviarDocumentos ||
                    this.EnviarDocumentos != null &&
                    this.EnviarDocumentos.Equals(other.EnviarDocumentos)
                ) && 
                (
                    this.Mensagem == other.Mensagem ||
                    this.Mensagem != null &&
                    this.Mensagem.Equals(other.Mensagem)
                ) && 
                (
                    this.MensagemCSLight == other.MensagemCSLight ||
                    this.MensagemCSLight != null &&
                    this.MensagemCSLight.Equals(other.MensagemCSLight)
                ) && 
                (
                    this.MensagemChargeback == other.MensagemChargeback ||
                    this.MensagemChargeback != null &&
                    this.MensagemChargeback.Equals(other.MensagemChargeback)
                ) && 
                (
                    this.StatusId == other.StatusId ||
                    this.StatusId != null &&
                    this.StatusId.Equals(other.StatusId)
                ) && 
                (
                    this.TipoContestacaoId == other.TipoContestacaoId ||
                    this.TipoContestacaoId != null &&
                    this.TipoContestacaoId.Equals(other.TipoContestacaoId)
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
                
                if (this.CodigoChargebackId != null)
                    hash = hash * 59 + this.CodigoChargebackId.GetHashCode();
                
                if (this.Compras != null)
                    hash = hash * 59 + this.Compras.GetHashCode();
                
                if (this.EnviarDocumentos != null)
                    hash = hash * 59 + this.EnviarDocumentos.GetHashCode();
                
                if (this.Mensagem != null)
                    hash = hash * 59 + this.Mensagem.GetHashCode();
                
                if (this.MensagemCSLight != null)
                    hash = hash * 59 + this.MensagemCSLight.GetHashCode();
                
                if (this.MensagemChargeback != null)
                    hash = hash * 59 + this.MensagemChargeback.GetHashCode();
                
                if (this.StatusId != null)
                    hash = hash * 59 + this.StatusId.GetHashCode();
                
                if (this.TipoContestacaoId != null)
                    hash = hash * 59 + this.TipoContestacaoId.GetHashCode();
                
                return hash;
            }
        }

    }
}
