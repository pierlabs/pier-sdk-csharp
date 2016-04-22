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
    public class ConsultarCartaoResponse :  IEquatable<ConsultarCartaoResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsultarCartaoResponse" /> class.
        /// </summary>
        public ConsultarCartaoResponse()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets CodigoRetorno
        /// </summary>
        [DataMember(Name="codigoRetorno", EmitDefaultValue=false)]
        public int? CodigoRetorno { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Cvv2
        /// </summary>
        [DataMember(Name="cvv2", EmitDefaultValue=false)]
        public string Cvv2 { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DataValidade
        /// </summary>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DescricaoRetorno
        /// </summary>
        [DataMember(Name="descricaoRetorno", EmitDefaultValue=false)]
        public string DescricaoRetorno { get; set; }
  
        
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
        /// Gets or Sets NomePortador
        /// </summary>
        [DataMember(Name="nomePortador", EmitDefaultValue=false)]
        public string NomePortador { get; set; }
  
        
        /// <summary>
        /// Gets or Sets NumCartao
        /// </summary>
        [DataMember(Name="numCartao", EmitDefaultValue=false)]
        public string NumCartao { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SaldoDisponivel
        /// </summary>
        [DataMember(Name="saldoDisponivel", EmitDefaultValue=false)]
        public double? SaldoDisponivel { get; set; }
  
        
        /// <summary>
        /// Gets or Sets StatusCartao
        /// </summary>
        [DataMember(Name="statusCartao", EmitDefaultValue=false)]
        public int? StatusCartao { get; set; }
  
        
        /// <summary>
        /// Gets or Sets StatusConta
        /// </summary>
        [DataMember(Name="statusConta", EmitDefaultValue=false)]
        public int? StatusConta { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsultarCartaoResponse {\n");
            sb.Append("  CodigoRetorno: ").Append(CodigoRetorno).Append("\n");
            sb.Append("  Cvv2: ").Append(Cvv2).Append("\n");
            sb.Append("  DataValidade: ").Append(DataValidade).Append("\n");
            sb.Append("  DescricaoRetorno: ").Append(DescricaoRetorno).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  NomePortador: ").Append(NomePortador).Append("\n");
            sb.Append("  NumCartao: ").Append(NumCartao).Append("\n");
            sb.Append("  SaldoDisponivel: ").Append(SaldoDisponivel).Append("\n");
            sb.Append("  StatusCartao: ").Append(StatusCartao).Append("\n");
            sb.Append("  StatusConta: ").Append(StatusConta).Append("\n");
            
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
            return this.Equals(obj as ConsultarCartaoResponse);
        }

        /// <summary>
        /// Returns true if ConsultarCartaoResponse instances are equal
        /// </summary>
        /// <param name="obj">Instance of ConsultarCartaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsultarCartaoResponse other)
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
                    this.Cvv2 == other.Cvv2 ||
                    this.Cvv2 != null &&
                    this.Cvv2.Equals(other.Cvv2)
                ) && 
                (
                    this.DataValidade == other.DataValidade ||
                    this.DataValidade != null &&
                    this.DataValidade.Equals(other.DataValidade)
                ) && 
                (
                    this.DescricaoRetorno == other.DescricaoRetorno ||
                    this.DescricaoRetorno != null &&
                    this.DescricaoRetorno.Equals(other.DescricaoRetorno)
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
                    this.NomePortador == other.NomePortador ||
                    this.NomePortador != null &&
                    this.NomePortador.Equals(other.NomePortador)
                ) && 
                (
                    this.NumCartao == other.NumCartao ||
                    this.NumCartao != null &&
                    this.NumCartao.Equals(other.NumCartao)
                ) && 
                (
                    this.SaldoDisponivel == other.SaldoDisponivel ||
                    this.SaldoDisponivel != null &&
                    this.SaldoDisponivel.Equals(other.SaldoDisponivel)
                ) && 
                (
                    this.StatusCartao == other.StatusCartao ||
                    this.StatusCartao != null &&
                    this.StatusCartao.Equals(other.StatusCartao)
                ) && 
                (
                    this.StatusConta == other.StatusConta ||
                    this.StatusConta != null &&
                    this.StatusConta.Equals(other.StatusConta)
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
                
                if (this.Cvv2 != null)
                    hash = hash * 57 + this.Cvv2.GetHashCode();
                
                if (this.DataValidade != null)
                    hash = hash * 57 + this.DataValidade.GetHashCode();
                
                if (this.DescricaoRetorno != null)
                    hash = hash * 57 + this.DescricaoRetorno.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 57 + this.IdCartao.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 57 + this.IdConta.GetHashCode();
                
                if (this.NomePortador != null)
                    hash = hash * 57 + this.NomePortador.GetHashCode();
                
                if (this.NumCartao != null)
                    hash = hash * 57 + this.NumCartao.GetHashCode();
                
                if (this.SaldoDisponivel != null)
                    hash = hash * 57 + this.SaldoDisponivel.GetHashCode();
                
                if (this.StatusCartao != null)
                    hash = hash * 57 + this.StatusCartao.GetHashCode();
                
                if (this.StatusConta != null)
                    hash = hash * 57 + this.StatusConta.GetHashCode();
                
                return hash;
            }
        }

    }
}
