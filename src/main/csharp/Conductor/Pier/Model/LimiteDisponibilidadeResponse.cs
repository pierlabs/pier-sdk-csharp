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
    /// {{{limite_disponibilidade_response_description}}}
    /// </summary>
    [DataContract]
    public partial class LimiteDisponibilidadeResponse :  IEquatable<LimiteDisponibilidadeResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LimiteDisponibilidadeResponse" /> class.
        /// Initializes a new instance of the <see cref="LimiteDisponibilidadeResponse" />class.
        /// </summary>
        /// <param name="Id">{{{limite_disponibilidade_response_id_value}}}.</param>
        /// <param name="LimiteGlobal">{{{limite_disponibilidade_response_limite_global_value}}}.</param>
        /// <param name="LimiteCompra">{{{limite_disponibilidade_response_limite_compra_value}}}.</param>
        /// <param name="LimiteParcelado">{{{limite_disponibilidade_response_limite_parcelado_value}}}.</param>
        /// <param name="LimiteParcelas">{{{limite_disponibilidade_response_limite_parcelas_value}}}.</param>
        /// <param name="LimiteSaqueGlobal">{{{limite_disponibilidade_response_limite_saque_global_value}}}.</param>
        /// <param name="LimiteSaquePeriodo">{{{limite_disponibilidade_response_limite_saque_periodo_value}}}.</param>
        /// <param name="LimiteConsignado">{{{limite_disponibilidade_response_limite_consignado_value}}}.</param>
        /// <param name="LimiteInternacionalCompra">{{{limite_disponibilidade_response_limite_internacional_compra_value}}}.</param>
        /// <param name="LimiteInternacionalParcelado">{{{limite_disponibilidade_response_limite_internacional_parcelado_value}}}.</param>
        /// <param name="LimiteInternacionalParcelas">{{{limite_disponibilidade_response_limite_internacional_parcelas_value}}}.</param>
        /// <param name="LimiteInternacionalSaqueGlobal">{{{limite_disponibilidade_response_limite_internacional_saque_global_value}}}.</param>
        /// <param name="LimiteInternacionalSaquePeriodo">{{{limite_disponibilidade_response_limite_internacional_saque_periodo_value}}}.</param>
        /// <param name="LimiteMaximo">{{{limite_disponibilidade_response_limite_maximo_value}}}.</param>
        /// <param name="SaldoDisponivelGlobal">{{{limite_disponibilidade_response_saldo_disponivel_global_value}}}.</param>
        /// <param name="SaldoDisponivelCompra">{{{limite_disponibilidade_response_saldo_disponivel_compra_value}}}.</param>
        /// <param name="SaldoDisponivelParcelado">{{{limite_disponibilidade_response_saldo_disponivel_parcelado_value}}}.</param>
        /// <param name="SaldoDisponivelParcelas">{{{limite_disponibilidade_response_saldo_disponivel_parcelas_value}}}.</param>
        /// <param name="SaldoDisponivelSaque">{{{limite_disponibilidade_response_saldo_disponivel_saque_value}}}.</param>
        /// <param name="SaldoPontosFidelidade">{{{limite_disponibilidade_response_saldo_pontos_fidelidade_value}}}.</param>
        /// <param name="SaldoDisponivelCompraInternacional">{{{limite_disponibilidade_response_saldo_disponivel_compra_internacional_value}}}.</param>
        /// <param name="SaldoDisponivelSaqueInternacional">{{{limite_disponibilidade_response_saldo_disponivel_saque_internacional_value}}}.</param>

        public LimiteDisponibilidadeResponse(long? Id = null, double? LimiteGlobal = null, double? LimiteCompra = null, double? LimiteParcelado = null, double? LimiteParcelas = null, double? LimiteSaqueGlobal = null, double? LimiteSaquePeriodo = null, double? LimiteConsignado = null, double? LimiteInternacionalCompra = null, double? LimiteInternacionalParcelado = null, double? LimiteInternacionalParcelas = null, double? LimiteInternacionalSaqueGlobal = null, double? LimiteInternacionalSaquePeriodo = null, double? LimiteMaximo = null, double? SaldoDisponivelGlobal = null, double? SaldoDisponivelCompra = null, double? SaldoDisponivelParcelado = null, double? SaldoDisponivelParcelas = null, double? SaldoDisponivelSaque = null, double? SaldoPontosFidelidade = null, double? SaldoDisponivelCompraInternacional = null, double? SaldoDisponivelSaqueInternacional = null)
        {
            this.Id = Id;
            this.LimiteGlobal = LimiteGlobal;
            this.LimiteCompra = LimiteCompra;
            this.LimiteParcelado = LimiteParcelado;
            this.LimiteParcelas = LimiteParcelas;
            this.LimiteSaqueGlobal = LimiteSaqueGlobal;
            this.LimiteSaquePeriodo = LimiteSaquePeriodo;
            this.LimiteConsignado = LimiteConsignado;
            this.LimiteInternacionalCompra = LimiteInternacionalCompra;
            this.LimiteInternacionalParcelado = LimiteInternacionalParcelado;
            this.LimiteInternacionalParcelas = LimiteInternacionalParcelas;
            this.LimiteInternacionalSaqueGlobal = LimiteInternacionalSaqueGlobal;
            this.LimiteInternacionalSaquePeriodo = LimiteInternacionalSaquePeriodo;
            this.LimiteMaximo = LimiteMaximo;
            this.SaldoDisponivelGlobal = SaldoDisponivelGlobal;
            this.SaldoDisponivelCompra = SaldoDisponivelCompra;
            this.SaldoDisponivelParcelado = SaldoDisponivelParcelado;
            this.SaldoDisponivelParcelas = SaldoDisponivelParcelas;
            this.SaldoDisponivelSaque = SaldoDisponivelSaque;
            this.SaldoPontosFidelidade = SaldoPontosFidelidade;
            this.SaldoDisponivelCompraInternacional = SaldoDisponivelCompraInternacional;
            this.SaldoDisponivelSaqueInternacional = SaldoDisponivelSaqueInternacional;
            
        }
        
    
        /// <summary>
        /// {{{limite_disponibilidade_response_id_value}}}
        /// </summary>
        /// <value>{{{limite_disponibilidade_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{limite_disponibilidade_response_limite_global_value}}}
        /// </summary>
        /// <value>{{{limite_disponibilidade_response_limite_global_value}}}</value>
        [DataMember(Name="limiteGlobal", EmitDefaultValue=false)]
        public double? LimiteGlobal { get; set; }
    
        /// <summary>
        /// {{{limite_disponibilidade_response_limite_compra_value}}}
        /// </summary>
        /// <value>{{{limite_disponibilidade_response_limite_compra_value}}}</value>
        [DataMember(Name="limiteCompra", EmitDefaultValue=false)]
        public double? LimiteCompra { get; set; }
    
        /// <summary>
        /// {{{limite_disponibilidade_response_limite_parcelado_value}}}
        /// </summary>
        /// <value>{{{limite_disponibilidade_response_limite_parcelado_value}}}</value>
        [DataMember(Name="limiteParcelado", EmitDefaultValue=false)]
        public double? LimiteParcelado { get; set; }
    
        /// <summary>
        /// {{{limite_disponibilidade_response_limite_parcelas_value}}}
        /// </summary>
        /// <value>{{{limite_disponibilidade_response_limite_parcelas_value}}}</value>
        [DataMember(Name="limiteParcelas", EmitDefaultValue=false)]
        public double? LimiteParcelas { get; set; }
    
        /// <summary>
        /// {{{limite_disponibilidade_response_limite_saque_global_value}}}
        /// </summary>
        /// <value>{{{limite_disponibilidade_response_limite_saque_global_value}}}</value>
        [DataMember(Name="limiteSaqueGlobal", EmitDefaultValue=false)]
        public double? LimiteSaqueGlobal { get; set; }
    
        /// <summary>
        /// {{{limite_disponibilidade_response_limite_saque_periodo_value}}}
        /// </summary>
        /// <value>{{{limite_disponibilidade_response_limite_saque_periodo_value}}}</value>
        [DataMember(Name="limiteSaquePeriodo", EmitDefaultValue=false)]
        public double? LimiteSaquePeriodo { get; set; }
    
        /// <summary>
        /// {{{limite_disponibilidade_response_limite_consignado_value}}}
        /// </summary>
        /// <value>{{{limite_disponibilidade_response_limite_consignado_value}}}</value>
        [DataMember(Name="limiteConsignado", EmitDefaultValue=false)]
        public double? LimiteConsignado { get; set; }
    
        /// <summary>
        /// {{{limite_disponibilidade_response_limite_internacional_compra_value}}}
        /// </summary>
        /// <value>{{{limite_disponibilidade_response_limite_internacional_compra_value}}}</value>
        [DataMember(Name="limiteInternacionalCompra", EmitDefaultValue=false)]
        public double? LimiteInternacionalCompra { get; set; }
    
        /// <summary>
        /// {{{limite_disponibilidade_response_limite_internacional_parcelado_value}}}
        /// </summary>
        /// <value>{{{limite_disponibilidade_response_limite_internacional_parcelado_value}}}</value>
        [DataMember(Name="limiteInternacionalParcelado", EmitDefaultValue=false)]
        public double? LimiteInternacionalParcelado { get; set; }
    
        /// <summary>
        /// {{{limite_disponibilidade_response_limite_internacional_parcelas_value}}}
        /// </summary>
        /// <value>{{{limite_disponibilidade_response_limite_internacional_parcelas_value}}}</value>
        [DataMember(Name="limiteInternacionalParcelas", EmitDefaultValue=false)]
        public double? LimiteInternacionalParcelas { get; set; }
    
        /// <summary>
        /// {{{limite_disponibilidade_response_limite_internacional_saque_global_value}}}
        /// </summary>
        /// <value>{{{limite_disponibilidade_response_limite_internacional_saque_global_value}}}</value>
        [DataMember(Name="limiteInternacionalSaqueGlobal", EmitDefaultValue=false)]
        public double? LimiteInternacionalSaqueGlobal { get; set; }
    
        /// <summary>
        /// {{{limite_disponibilidade_response_limite_internacional_saque_periodo_value}}}
        /// </summary>
        /// <value>{{{limite_disponibilidade_response_limite_internacional_saque_periodo_value}}}</value>
        [DataMember(Name="limiteInternacionalSaquePeriodo", EmitDefaultValue=false)]
        public double? LimiteInternacionalSaquePeriodo { get; set; }
    
        /// <summary>
        /// {{{limite_disponibilidade_response_limite_maximo_value}}}
        /// </summary>
        /// <value>{{{limite_disponibilidade_response_limite_maximo_value}}}</value>
        [DataMember(Name="limiteMaximo", EmitDefaultValue=false)]
        public double? LimiteMaximo { get; set; }
    
        /// <summary>
        /// {{{limite_disponibilidade_response_saldo_disponivel_global_value}}}
        /// </summary>
        /// <value>{{{limite_disponibilidade_response_saldo_disponivel_global_value}}}</value>
        [DataMember(Name="saldoDisponivelGlobal", EmitDefaultValue=false)]
        public double? SaldoDisponivelGlobal { get; set; }
    
        /// <summary>
        /// {{{limite_disponibilidade_response_saldo_disponivel_compra_value}}}
        /// </summary>
        /// <value>{{{limite_disponibilidade_response_saldo_disponivel_compra_value}}}</value>
        [DataMember(Name="saldoDisponivelCompra", EmitDefaultValue=false)]
        public double? SaldoDisponivelCompra { get; set; }
    
        /// <summary>
        /// {{{limite_disponibilidade_response_saldo_disponivel_parcelado_value}}}
        /// </summary>
        /// <value>{{{limite_disponibilidade_response_saldo_disponivel_parcelado_value}}}</value>
        [DataMember(Name="saldoDisponivelParcelado", EmitDefaultValue=false)]
        public double? SaldoDisponivelParcelado { get; set; }
    
        /// <summary>
        /// {{{limite_disponibilidade_response_saldo_disponivel_parcelas_value}}}
        /// </summary>
        /// <value>{{{limite_disponibilidade_response_saldo_disponivel_parcelas_value}}}</value>
        [DataMember(Name="saldoDisponivelParcelas", EmitDefaultValue=false)]
        public double? SaldoDisponivelParcelas { get; set; }
    
        /// <summary>
        /// {{{limite_disponibilidade_response_saldo_disponivel_saque_value}}}
        /// </summary>
        /// <value>{{{limite_disponibilidade_response_saldo_disponivel_saque_value}}}</value>
        [DataMember(Name="saldoDisponivelSaque", EmitDefaultValue=false)]
        public double? SaldoDisponivelSaque { get; set; }
    
        /// <summary>
        /// {{{limite_disponibilidade_response_saldo_pontos_fidelidade_value}}}
        /// </summary>
        /// <value>{{{limite_disponibilidade_response_saldo_pontos_fidelidade_value}}}</value>
        [DataMember(Name="saldoPontosFidelidade", EmitDefaultValue=false)]
        public double? SaldoPontosFidelidade { get; set; }
    
        /// <summary>
        /// {{{limite_disponibilidade_response_saldo_disponivel_compra_internacional_value}}}
        /// </summary>
        /// <value>{{{limite_disponibilidade_response_saldo_disponivel_compra_internacional_value}}}</value>
        [DataMember(Name="saldoDisponivelCompraInternacional", EmitDefaultValue=false)]
        public double? SaldoDisponivelCompraInternacional { get; set; }
    
        /// <summary>
        /// {{{limite_disponibilidade_response_saldo_disponivel_saque_internacional_value}}}
        /// </summary>
        /// <value>{{{limite_disponibilidade_response_saldo_disponivel_saque_internacional_value}}}</value>
        [DataMember(Name="saldoDisponivelSaqueInternacional", EmitDefaultValue=false)]
        public double? SaldoDisponivelSaqueInternacional { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LimiteDisponibilidadeResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LimiteGlobal: ").Append(LimiteGlobal).Append("\n");
            sb.Append("  LimiteCompra: ").Append(LimiteCompra).Append("\n");
            sb.Append("  LimiteParcelado: ").Append(LimiteParcelado).Append("\n");
            sb.Append("  LimiteParcelas: ").Append(LimiteParcelas).Append("\n");
            sb.Append("  LimiteSaqueGlobal: ").Append(LimiteSaqueGlobal).Append("\n");
            sb.Append("  LimiteSaquePeriodo: ").Append(LimiteSaquePeriodo).Append("\n");
            sb.Append("  LimiteConsignado: ").Append(LimiteConsignado).Append("\n");
            sb.Append("  LimiteInternacionalCompra: ").Append(LimiteInternacionalCompra).Append("\n");
            sb.Append("  LimiteInternacionalParcelado: ").Append(LimiteInternacionalParcelado).Append("\n");
            sb.Append("  LimiteInternacionalParcelas: ").Append(LimiteInternacionalParcelas).Append("\n");
            sb.Append("  LimiteInternacionalSaqueGlobal: ").Append(LimiteInternacionalSaqueGlobal).Append("\n");
            sb.Append("  LimiteInternacionalSaquePeriodo: ").Append(LimiteInternacionalSaquePeriodo).Append("\n");
            sb.Append("  LimiteMaximo: ").Append(LimiteMaximo).Append("\n");
            sb.Append("  SaldoDisponivelGlobal: ").Append(SaldoDisponivelGlobal).Append("\n");
            sb.Append("  SaldoDisponivelCompra: ").Append(SaldoDisponivelCompra).Append("\n");
            sb.Append("  SaldoDisponivelParcelado: ").Append(SaldoDisponivelParcelado).Append("\n");
            sb.Append("  SaldoDisponivelParcelas: ").Append(SaldoDisponivelParcelas).Append("\n");
            sb.Append("  SaldoDisponivelSaque: ").Append(SaldoDisponivelSaque).Append("\n");
            sb.Append("  SaldoPontosFidelidade: ").Append(SaldoPontosFidelidade).Append("\n");
            sb.Append("  SaldoDisponivelCompraInternacional: ").Append(SaldoDisponivelCompraInternacional).Append("\n");
            sb.Append("  SaldoDisponivelSaqueInternacional: ").Append(SaldoDisponivelSaqueInternacional).Append("\n");
            
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
            return this.Equals(obj as LimiteDisponibilidadeResponse);
        }

        /// <summary>
        /// Returns true if LimiteDisponibilidadeResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of LimiteDisponibilidadeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LimiteDisponibilidadeResponse other)
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
                    this.LimiteGlobal == other.LimiteGlobal ||
                    this.LimiteGlobal != null &&
                    this.LimiteGlobal.Equals(other.LimiteGlobal)
                ) && 
                (
                    this.LimiteCompra == other.LimiteCompra ||
                    this.LimiteCompra != null &&
                    this.LimiteCompra.Equals(other.LimiteCompra)
                ) && 
                (
                    this.LimiteParcelado == other.LimiteParcelado ||
                    this.LimiteParcelado != null &&
                    this.LimiteParcelado.Equals(other.LimiteParcelado)
                ) && 
                (
                    this.LimiteParcelas == other.LimiteParcelas ||
                    this.LimiteParcelas != null &&
                    this.LimiteParcelas.Equals(other.LimiteParcelas)
                ) && 
                (
                    this.LimiteSaqueGlobal == other.LimiteSaqueGlobal ||
                    this.LimiteSaqueGlobal != null &&
                    this.LimiteSaqueGlobal.Equals(other.LimiteSaqueGlobal)
                ) && 
                (
                    this.LimiteSaquePeriodo == other.LimiteSaquePeriodo ||
                    this.LimiteSaquePeriodo != null &&
                    this.LimiteSaquePeriodo.Equals(other.LimiteSaquePeriodo)
                ) && 
                (
                    this.LimiteConsignado == other.LimiteConsignado ||
                    this.LimiteConsignado != null &&
                    this.LimiteConsignado.Equals(other.LimiteConsignado)
                ) && 
                (
                    this.LimiteInternacionalCompra == other.LimiteInternacionalCompra ||
                    this.LimiteInternacionalCompra != null &&
                    this.LimiteInternacionalCompra.Equals(other.LimiteInternacionalCompra)
                ) && 
                (
                    this.LimiteInternacionalParcelado == other.LimiteInternacionalParcelado ||
                    this.LimiteInternacionalParcelado != null &&
                    this.LimiteInternacionalParcelado.Equals(other.LimiteInternacionalParcelado)
                ) && 
                (
                    this.LimiteInternacionalParcelas == other.LimiteInternacionalParcelas ||
                    this.LimiteInternacionalParcelas != null &&
                    this.LimiteInternacionalParcelas.Equals(other.LimiteInternacionalParcelas)
                ) && 
                (
                    this.LimiteInternacionalSaqueGlobal == other.LimiteInternacionalSaqueGlobal ||
                    this.LimiteInternacionalSaqueGlobal != null &&
                    this.LimiteInternacionalSaqueGlobal.Equals(other.LimiteInternacionalSaqueGlobal)
                ) && 
                (
                    this.LimiteInternacionalSaquePeriodo == other.LimiteInternacionalSaquePeriodo ||
                    this.LimiteInternacionalSaquePeriodo != null &&
                    this.LimiteInternacionalSaquePeriodo.Equals(other.LimiteInternacionalSaquePeriodo)
                ) && 
                (
                    this.LimiteMaximo == other.LimiteMaximo ||
                    this.LimiteMaximo != null &&
                    this.LimiteMaximo.Equals(other.LimiteMaximo)
                ) && 
                (
                    this.SaldoDisponivelGlobal == other.SaldoDisponivelGlobal ||
                    this.SaldoDisponivelGlobal != null &&
                    this.SaldoDisponivelGlobal.Equals(other.SaldoDisponivelGlobal)
                ) && 
                (
                    this.SaldoDisponivelCompra == other.SaldoDisponivelCompra ||
                    this.SaldoDisponivelCompra != null &&
                    this.SaldoDisponivelCompra.Equals(other.SaldoDisponivelCompra)
                ) && 
                (
                    this.SaldoDisponivelParcelado == other.SaldoDisponivelParcelado ||
                    this.SaldoDisponivelParcelado != null &&
                    this.SaldoDisponivelParcelado.Equals(other.SaldoDisponivelParcelado)
                ) && 
                (
                    this.SaldoDisponivelParcelas == other.SaldoDisponivelParcelas ||
                    this.SaldoDisponivelParcelas != null &&
                    this.SaldoDisponivelParcelas.Equals(other.SaldoDisponivelParcelas)
                ) && 
                (
                    this.SaldoDisponivelSaque == other.SaldoDisponivelSaque ||
                    this.SaldoDisponivelSaque != null &&
                    this.SaldoDisponivelSaque.Equals(other.SaldoDisponivelSaque)
                ) && 
                (
                    this.SaldoPontosFidelidade == other.SaldoPontosFidelidade ||
                    this.SaldoPontosFidelidade != null &&
                    this.SaldoPontosFidelidade.Equals(other.SaldoPontosFidelidade)
                ) && 
                (
                    this.SaldoDisponivelCompraInternacional == other.SaldoDisponivelCompraInternacional ||
                    this.SaldoDisponivelCompraInternacional != null &&
                    this.SaldoDisponivelCompraInternacional.Equals(other.SaldoDisponivelCompraInternacional)
                ) && 
                (
                    this.SaldoDisponivelSaqueInternacional == other.SaldoDisponivelSaqueInternacional ||
                    this.SaldoDisponivelSaqueInternacional != null &&
                    this.SaldoDisponivelSaqueInternacional.Equals(other.SaldoDisponivelSaqueInternacional)
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
                
                if (this.LimiteGlobal != null)
                    hash = hash * 59 + this.LimiteGlobal.GetHashCode();
                
                if (this.LimiteCompra != null)
                    hash = hash * 59 + this.LimiteCompra.GetHashCode();
                
                if (this.LimiteParcelado != null)
                    hash = hash * 59 + this.LimiteParcelado.GetHashCode();
                
                if (this.LimiteParcelas != null)
                    hash = hash * 59 + this.LimiteParcelas.GetHashCode();
                
                if (this.LimiteSaqueGlobal != null)
                    hash = hash * 59 + this.LimiteSaqueGlobal.GetHashCode();
                
                if (this.LimiteSaquePeriodo != null)
                    hash = hash * 59 + this.LimiteSaquePeriodo.GetHashCode();
                
                if (this.LimiteConsignado != null)
                    hash = hash * 59 + this.LimiteConsignado.GetHashCode();
                
                if (this.LimiteInternacionalCompra != null)
                    hash = hash * 59 + this.LimiteInternacionalCompra.GetHashCode();
                
                if (this.LimiteInternacionalParcelado != null)
                    hash = hash * 59 + this.LimiteInternacionalParcelado.GetHashCode();
                
                if (this.LimiteInternacionalParcelas != null)
                    hash = hash * 59 + this.LimiteInternacionalParcelas.GetHashCode();
                
                if (this.LimiteInternacionalSaqueGlobal != null)
                    hash = hash * 59 + this.LimiteInternacionalSaqueGlobal.GetHashCode();
                
                if (this.LimiteInternacionalSaquePeriodo != null)
                    hash = hash * 59 + this.LimiteInternacionalSaquePeriodo.GetHashCode();
                
                if (this.LimiteMaximo != null)
                    hash = hash * 59 + this.LimiteMaximo.GetHashCode();
                
                if (this.SaldoDisponivelGlobal != null)
                    hash = hash * 59 + this.SaldoDisponivelGlobal.GetHashCode();
                
                if (this.SaldoDisponivelCompra != null)
                    hash = hash * 59 + this.SaldoDisponivelCompra.GetHashCode();
                
                if (this.SaldoDisponivelParcelado != null)
                    hash = hash * 59 + this.SaldoDisponivelParcelado.GetHashCode();
                
                if (this.SaldoDisponivelParcelas != null)
                    hash = hash * 59 + this.SaldoDisponivelParcelas.GetHashCode();
                
                if (this.SaldoDisponivelSaque != null)
                    hash = hash * 59 + this.SaldoDisponivelSaque.GetHashCode();
                
                if (this.SaldoPontosFidelidade != null)
                    hash = hash * 59 + this.SaldoPontosFidelidade.GetHashCode();
                
                if (this.SaldoDisponivelCompraInternacional != null)
                    hash = hash * 59 + this.SaldoDisponivelCompraInternacional.GetHashCode();
                
                if (this.SaldoDisponivelSaqueInternacional != null)
                    hash = hash * 59 + this.SaldoDisponivelSaqueInternacional.GetHashCode();
                
                return hash;
            }
        }

    }
}
