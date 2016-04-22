using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Conductor.CaaS.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class ConsultarSaldoLimitesResponse :  IEquatable<ConsultarSaldoLimitesResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsultarSaldoLimitesResponse" /> class.
        /// </summary>
        public ConsultarSaldoLimitesResponse()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets CodigoRetorno
        /// </summary>
        [DataMember(Name="codigoRetorno", EmitDefaultValue=false)]
        public int? CodigoRetorno { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DataVencimento
        /// </summary>
        [DataMember(Name="dataVencimento", EmitDefaultValue=false)]
        public string DataVencimento { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DescricaoRetorno
        /// </summary>
        [DataMember(Name="descricaoRetorno", EmitDefaultValue=false)]
        public string DescricaoRetorno { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DisponibCompraNac
        /// </summary>
        [DataMember(Name="disponibCompraNac", EmitDefaultValue=false)]
        public double? DisponibCompraNac { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DisponibGlobalCredito
        /// </summary>
        [DataMember(Name="disponibGlobalCredito", EmitDefaultValue=false)]
        public double? DisponibGlobalCredito { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DisponibParceladoNac
        /// </summary>
        [DataMember(Name="disponibParceladoNac", EmitDefaultValue=false)]
        public double? DisponibParceladoNac { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DisponibParcelasNac
        /// </summary>
        [DataMember(Name="disponibParcelasNac", EmitDefaultValue=false)]
        public double? DisponibParcelasNac { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DisponibSaqueNacGlobal
        /// </summary>
        [DataMember(Name="disponibSaqueNacGlobal", EmitDefaultValue=false)]
        public double? DisponibSaqueNacGlobal { get; set; }
  
        
        /// <summary>
        /// Gets or Sets LimiteCompraNac
        /// </summary>
        [DataMember(Name="limiteCompraNac", EmitDefaultValue=false)]
        public double? LimiteCompraNac { get; set; }
  
        
        /// <summary>
        /// Gets or Sets LimiteGlobalCredito
        /// </summary>
        [DataMember(Name="limiteGlobalCredito", EmitDefaultValue=false)]
        public double? LimiteGlobalCredito { get; set; }
  
        
        /// <summary>
        /// Gets or Sets LimiteParceladoNac
        /// </summary>
        [DataMember(Name="limiteParceladoNac", EmitDefaultValue=false)]
        public double? LimiteParceladoNac { get; set; }
  
        
        /// <summary>
        /// Gets or Sets LimiteParcelasNac
        /// </summary>
        [DataMember(Name="limiteParcelasNac", EmitDefaultValue=false)]
        public double? LimiteParcelasNac { get; set; }
  
        
        /// <summary>
        /// Gets or Sets LimiteSaqueNacGlobal
        /// </summary>
        [DataMember(Name="limiteSaqueNacGlobal", EmitDefaultValue=false)]
        public double? LimiteSaqueNacGlobal { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SaldoAtualFinal
        /// </summary>
        [DataMember(Name="saldoAtualFinal", EmitDefaultValue=false)]
        public double? SaldoAtualFinal { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SaldoDevedor
        /// </summary>
        [DataMember(Name="saldoDevedor", EmitDefaultValue=false)]
        public double? SaldoDevedor { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SaldoFuturo
        /// </summary>
        [DataMember(Name="saldoFuturo", EmitDefaultValue=false)]
        public double? SaldoFuturo { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsultarSaldoLimitesResponse {\n");
            sb.Append("  CodigoRetorno: ").Append(CodigoRetorno).Append("\n");
            sb.Append("  DataVencimento: ").Append(DataVencimento).Append("\n");
            sb.Append("  DescricaoRetorno: ").Append(DescricaoRetorno).Append("\n");
            sb.Append("  DisponibCompraNac: ").Append(DisponibCompraNac).Append("\n");
            sb.Append("  DisponibGlobalCredito: ").Append(DisponibGlobalCredito).Append("\n");
            sb.Append("  DisponibParceladoNac: ").Append(DisponibParceladoNac).Append("\n");
            sb.Append("  DisponibParcelasNac: ").Append(DisponibParcelasNac).Append("\n");
            sb.Append("  DisponibSaqueNacGlobal: ").Append(DisponibSaqueNacGlobal).Append("\n");
            sb.Append("  LimiteCompraNac: ").Append(LimiteCompraNac).Append("\n");
            sb.Append("  LimiteGlobalCredito: ").Append(LimiteGlobalCredito).Append("\n");
            sb.Append("  LimiteParceladoNac: ").Append(LimiteParceladoNac).Append("\n");
            sb.Append("  LimiteParcelasNac: ").Append(LimiteParcelasNac).Append("\n");
            sb.Append("  LimiteSaqueNacGlobal: ").Append(LimiteSaqueNacGlobal).Append("\n");
            sb.Append("  SaldoAtualFinal: ").Append(SaldoAtualFinal).Append("\n");
            sb.Append("  SaldoDevedor: ").Append(SaldoDevedor).Append("\n");
            sb.Append("  SaldoFuturo: ").Append(SaldoFuturo).Append("\n");
            
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
            return this.Equals(obj as ConsultarSaldoLimitesResponse);
        }

        /// <summary>
        /// Returns true if ConsultarSaldoLimitesResponse instances are equal
        /// </summary>
        /// <param name="obj">Instance of ConsultarSaldoLimitesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsultarSaldoLimitesResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CodigoRetorno == other.CodigoRetorno ||
                    this.CodigoRetorno != null &&
                    this.CodigoRetorno.Equals(other.CodigoRetorno)
                ) && 
                (
                    this.DataVencimento == other.DataVencimento ||
                    this.DataVencimento != null &&
                    this.DataVencimento.Equals(other.DataVencimento)
                ) && 
                (
                    this.DescricaoRetorno == other.DescricaoRetorno ||
                    this.DescricaoRetorno != null &&
                    this.DescricaoRetorno.Equals(other.DescricaoRetorno)
                ) && 
                (
                    this.DisponibCompraNac == other.DisponibCompraNac ||
                    this.DisponibCompraNac != null &&
                    this.DisponibCompraNac.Equals(other.DisponibCompraNac)
                ) && 
                (
                    this.DisponibGlobalCredito == other.DisponibGlobalCredito ||
                    this.DisponibGlobalCredito != null &&
                    this.DisponibGlobalCredito.Equals(other.DisponibGlobalCredito)
                ) && 
                (
                    this.DisponibParceladoNac == other.DisponibParceladoNac ||
                    this.DisponibParceladoNac != null &&
                    this.DisponibParceladoNac.Equals(other.DisponibParceladoNac)
                ) && 
                (
                    this.DisponibParcelasNac == other.DisponibParcelasNac ||
                    this.DisponibParcelasNac != null &&
                    this.DisponibParcelasNac.Equals(other.DisponibParcelasNac)
                ) && 
                (
                    this.DisponibSaqueNacGlobal == other.DisponibSaqueNacGlobal ||
                    this.DisponibSaqueNacGlobal != null &&
                    this.DisponibSaqueNacGlobal.Equals(other.DisponibSaqueNacGlobal)
                ) && 
                (
                    this.LimiteCompraNac == other.LimiteCompraNac ||
                    this.LimiteCompraNac != null &&
                    this.LimiteCompraNac.Equals(other.LimiteCompraNac)
                ) && 
                (
                    this.LimiteGlobalCredito == other.LimiteGlobalCredito ||
                    this.LimiteGlobalCredito != null &&
                    this.LimiteGlobalCredito.Equals(other.LimiteGlobalCredito)
                ) && 
                (
                    this.LimiteParceladoNac == other.LimiteParceladoNac ||
                    this.LimiteParceladoNac != null &&
                    this.LimiteParceladoNac.Equals(other.LimiteParceladoNac)
                ) && 
                (
                    this.LimiteParcelasNac == other.LimiteParcelasNac ||
                    this.LimiteParcelasNac != null &&
                    this.LimiteParcelasNac.Equals(other.LimiteParcelasNac)
                ) && 
                (
                    this.LimiteSaqueNacGlobal == other.LimiteSaqueNacGlobal ||
                    this.LimiteSaqueNacGlobal != null &&
                    this.LimiteSaqueNacGlobal.Equals(other.LimiteSaqueNacGlobal)
                ) && 
                (
                    this.SaldoAtualFinal == other.SaldoAtualFinal ||
                    this.SaldoAtualFinal != null &&
                    this.SaldoAtualFinal.Equals(other.SaldoAtualFinal)
                ) && 
                (
                    this.SaldoDevedor == other.SaldoDevedor ||
                    this.SaldoDevedor != null &&
                    this.SaldoDevedor.Equals(other.SaldoDevedor)
                ) && 
                (
                    this.SaldoFuturo == other.SaldoFuturo ||
                    this.SaldoFuturo != null &&
                    this.SaldoFuturo.Equals(other.SaldoFuturo)
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
                
                if (this.CodigoRetorno != null)
                    hash = hash * 57 + this.CodigoRetorno.GetHashCode();
                
                if (this.DataVencimento != null)
                    hash = hash * 57 + this.DataVencimento.GetHashCode();
                
                if (this.DescricaoRetorno != null)
                    hash = hash * 57 + this.DescricaoRetorno.GetHashCode();
                
                if (this.DisponibCompraNac != null)
                    hash = hash * 57 + this.DisponibCompraNac.GetHashCode();
                
                if (this.DisponibGlobalCredito != null)
                    hash = hash * 57 + this.DisponibGlobalCredito.GetHashCode();
                
                if (this.DisponibParceladoNac != null)
                    hash = hash * 57 + this.DisponibParceladoNac.GetHashCode();
                
                if (this.DisponibParcelasNac != null)
                    hash = hash * 57 + this.DisponibParcelasNac.GetHashCode();
                
                if (this.DisponibSaqueNacGlobal != null)
                    hash = hash * 57 + this.DisponibSaqueNacGlobal.GetHashCode();
                
                if (this.LimiteCompraNac != null)
                    hash = hash * 57 + this.LimiteCompraNac.GetHashCode();
                
                if (this.LimiteGlobalCredito != null)
                    hash = hash * 57 + this.LimiteGlobalCredito.GetHashCode();
                
                if (this.LimiteParceladoNac != null)
                    hash = hash * 57 + this.LimiteParceladoNac.GetHashCode();
                
                if (this.LimiteParcelasNac != null)
                    hash = hash * 57 + this.LimiteParcelasNac.GetHashCode();
                
                if (this.LimiteSaqueNacGlobal != null)
                    hash = hash * 57 + this.LimiteSaqueNacGlobal.GetHashCode();
                
                if (this.SaldoAtualFinal != null)
                    hash = hash * 57 + this.SaldoAtualFinal.GetHashCode();
                
                if (this.SaldoDevedor != null)
                    hash = hash * 57 + this.SaldoDevedor.GetHashCode();
                
                if (this.SaldoFuturo != null)
                    hash = hash * 57 + this.SaldoFuturo.GetHashCode();
                
                return hash;
            }
        }

    }
}
