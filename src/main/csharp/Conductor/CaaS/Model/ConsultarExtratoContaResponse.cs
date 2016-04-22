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
    public class ConsultarExtratoContaResponse :  IEquatable<ConsultarExtratoContaResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsultarExtratoContaResponse" /> class.
        /// </summary>
        public ConsultarExtratoContaResponse()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets CodigoRetorno
        /// </summary>
        [DataMember(Name="codigoRetorno", EmitDefaultValue=false)]
        public int? CodigoRetorno { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ComprasNacionais
        /// </summary>
        [DataMember(Name="comprasNacionais", EmitDefaultValue=false)]
        public double? ComprasNacionais { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Cpf
        /// </summary>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
  
        
        /// <summary>
        /// Gets or Sets CreditosNacionais
        /// </summary>
        [DataMember(Name="creditosNacionais", EmitDefaultValue=false)]
        public double? CreditosNacionais { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DataVencimento
        /// </summary>
        [DataMember(Name="dataVencimento", EmitDefaultValue=false)]
        public string DataVencimento { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DebitosNacionais
        /// </summary>
        [DataMember(Name="debitosNacionais", EmitDefaultValue=false)]
        public double? DebitosNacionais { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DescricaoRetorno
        /// </summary>
        [DataMember(Name="descricaoRetorno", EmitDefaultValue=false)]
        public string DescricaoRetorno { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Extrato
        /// </summary>
        [DataMember(Name="extrato", EmitDefaultValue=false)]
        public List<ExtratoResponse> Extrato { get; set; }
  
        
        /// <summary>
        /// Gets or Sets IdCartao
        /// </summary>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public int? IdCartao { get; set; }
  
        
        /// <summary>
        /// Gets or Sets IdConta
        /// </summary>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public int? IdConta { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Multa
        /// </summary>
        [DataMember(Name="multa", EmitDefaultValue=false)]
        public double? Multa { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Pagamentos
        /// </summary>
        [DataMember(Name="pagamentos", EmitDefaultValue=false)]
        public double? Pagamentos { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SaldoAtualFinal
        /// </summary>
        [DataMember(Name="saldoAtualFinal", EmitDefaultValue=false)]
        public double? SaldoAtualFinal { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SaldoExtratoAnterior
        /// </summary>
        [DataMember(Name="saldoExtratoAnterior", EmitDefaultValue=false)]
        public double? SaldoExtratoAnterior { get; set; }
  
        
        /// <summary>
        /// Gets or Sets TarifasNacionais
        /// </summary>
        [DataMember(Name="tarifasNacionais", EmitDefaultValue=false)]
        public double? TarifasNacionais { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ValorMinimoExtrato
        /// </summary>
        [DataMember(Name="valorMinimoExtrato", EmitDefaultValue=false)]
        public double? ValorMinimoExtrato { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsultarExtratoContaResponse {\n");
            sb.Append("  CodigoRetorno: ").Append(CodigoRetorno).Append("\n");
            sb.Append("  ComprasNacionais: ").Append(ComprasNacionais).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  CreditosNacionais: ").Append(CreditosNacionais).Append("\n");
            sb.Append("  DataVencimento: ").Append(DataVencimento).Append("\n");
            sb.Append("  DebitosNacionais: ").Append(DebitosNacionais).Append("\n");
            sb.Append("  DescricaoRetorno: ").Append(DescricaoRetorno).Append("\n");
            sb.Append("  Extrato: ").Append(Extrato).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  Multa: ").Append(Multa).Append("\n");
            sb.Append("  Pagamentos: ").Append(Pagamentos).Append("\n");
            sb.Append("  SaldoAtualFinal: ").Append(SaldoAtualFinal).Append("\n");
            sb.Append("  SaldoExtratoAnterior: ").Append(SaldoExtratoAnterior).Append("\n");
            sb.Append("  TarifasNacionais: ").Append(TarifasNacionais).Append("\n");
            sb.Append("  ValorMinimoExtrato: ").Append(ValorMinimoExtrato).Append("\n");
            
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
            return this.Equals(obj as ConsultarExtratoContaResponse);
        }

        /// <summary>
        /// Returns true if ConsultarExtratoContaResponse instances are equal
        /// </summary>
        /// <param name="obj">Instance of ConsultarExtratoContaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsultarExtratoContaResponse other)
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
                    this.ComprasNacionais == other.ComprasNacionais ||
                    this.ComprasNacionais != null &&
                    this.ComprasNacionais.Equals(other.ComprasNacionais)
                ) && 
                (
                    this.Cpf == other.Cpf ||
                    this.Cpf != null &&
                    this.Cpf.Equals(other.Cpf)
                ) && 
                (
                    this.CreditosNacionais == other.CreditosNacionais ||
                    this.CreditosNacionais != null &&
                    this.CreditosNacionais.Equals(other.CreditosNacionais)
                ) && 
                (
                    this.DataVencimento == other.DataVencimento ||
                    this.DataVencimento != null &&
                    this.DataVencimento.Equals(other.DataVencimento)
                ) && 
                (
                    this.DebitosNacionais == other.DebitosNacionais ||
                    this.DebitosNacionais != null &&
                    this.DebitosNacionais.Equals(other.DebitosNacionais)
                ) && 
                (
                    this.DescricaoRetorno == other.DescricaoRetorno ||
                    this.DescricaoRetorno != null &&
                    this.DescricaoRetorno.Equals(other.DescricaoRetorno)
                ) && 
                (
                    this.Extrato == other.Extrato ||
                    this.Extrato != null &&
                    this.Extrato.SequenceEqual(other.Extrato)
                ) && 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.Multa == other.Multa ||
                    this.Multa != null &&
                    this.Multa.Equals(other.Multa)
                ) && 
                (
                    this.Pagamentos == other.Pagamentos ||
                    this.Pagamentos != null &&
                    this.Pagamentos.Equals(other.Pagamentos)
                ) && 
                (
                    this.SaldoAtualFinal == other.SaldoAtualFinal ||
                    this.SaldoAtualFinal != null &&
                    this.SaldoAtualFinal.Equals(other.SaldoAtualFinal)
                ) && 
                (
                    this.SaldoExtratoAnterior == other.SaldoExtratoAnterior ||
                    this.SaldoExtratoAnterior != null &&
                    this.SaldoExtratoAnterior.Equals(other.SaldoExtratoAnterior)
                ) && 
                (
                    this.TarifasNacionais == other.TarifasNacionais ||
                    this.TarifasNacionais != null &&
                    this.TarifasNacionais.Equals(other.TarifasNacionais)
                ) && 
                (
                    this.ValorMinimoExtrato == other.ValorMinimoExtrato ||
                    this.ValorMinimoExtrato != null &&
                    this.ValorMinimoExtrato.Equals(other.ValorMinimoExtrato)
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
                
                if (this.ComprasNacionais != null)
                    hash = hash * 57 + this.ComprasNacionais.GetHashCode();
                
                if (this.Cpf != null)
                    hash = hash * 57 + this.Cpf.GetHashCode();
                
                if (this.CreditosNacionais != null)
                    hash = hash * 57 + this.CreditosNacionais.GetHashCode();
                
                if (this.DataVencimento != null)
                    hash = hash * 57 + this.DataVencimento.GetHashCode();
                
                if (this.DebitosNacionais != null)
                    hash = hash * 57 + this.DebitosNacionais.GetHashCode();
                
                if (this.DescricaoRetorno != null)
                    hash = hash * 57 + this.DescricaoRetorno.GetHashCode();
                
                if (this.Extrato != null)
                    hash = hash * 57 + this.Extrato.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 57 + this.IdCartao.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 57 + this.IdConta.GetHashCode();
                
                if (this.Multa != null)
                    hash = hash * 57 + this.Multa.GetHashCode();
                
                if (this.Pagamentos != null)
                    hash = hash * 57 + this.Pagamentos.GetHashCode();
                
                if (this.SaldoAtualFinal != null)
                    hash = hash * 57 + this.SaldoAtualFinal.GetHashCode();
                
                if (this.SaldoExtratoAnterior != null)
                    hash = hash * 57 + this.SaldoExtratoAnterior.GetHashCode();
                
                if (this.TarifasNacionais != null)
                    hash = hash * 57 + this.TarifasNacionais.GetHashCode();
                
                if (this.ValorMinimoExtrato != null)
                    hash = hash * 57 + this.ValorMinimoExtrato.GetHashCode();
                
                return hash;
            }
        }

    }
}
