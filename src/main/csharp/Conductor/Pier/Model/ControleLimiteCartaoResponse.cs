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
    /// Representa\u00E7\u00E3o de resposta do recurso de controle de limites
    /// </summary>
    [DataContract]
    public partial class ControleLimiteCartaoResponse :  IEquatable<ControleLimiteCartaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ControleLimiteCartaoResponse" /> class.
        /// Initializes a new instance of the <see cref="ControleLimiteCartaoResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo de identifica\u00E7\u00E3o do controle de limites (id).</param>
        /// <param name="IdCartao">Id do cart\u00E3o.</param>
        /// <param name="LimiteMensal">Valor do limite mensal.</param>
        /// <param name="SaldoDisponivelMensal">Valor dispon\u00EDvel que o cart\u00E3o ainda pode gastar no m\u00EAs.</param>
        /// <param name="LimiteSemanal">Valor do limite semanal.</param>
        /// <param name="SaldoDisponivelSemanal">Valor dispon\u00EDvel que o cart\u00E3o ainda pode gastar na semana.</param>
        /// <param name="LimiteDiario">Valor do limite di\u00E1rio.</param>
        /// <param name="SaldoDisponivelDiario">Valor dispon\u00EDvel que o cart\u00E3o ainda pode gastar no dia.</param>
        /// <param name="DataHoraUltimaCompra">Data e hora da \u00FAltima compra realizada pelo cart\u00E3o.</param>
        /// <param name="Ativo">Flag que mostra se a configura\u00E7\u00E3o est\u00E1 ativa.</param>

        public ControleLimiteCartaoResponse(long? Id = null, long? IdCartao = null, double? LimiteMensal = null, double? SaldoDisponivelMensal = null, double? LimiteSemanal = null, double? SaldoDisponivelSemanal = null, double? LimiteDiario = null, double? SaldoDisponivelDiario = null, string DataHoraUltimaCompra = null, bool? Ativo = null)
        {
            this.Id = Id;
            this.IdCartao = IdCartao;
            this.LimiteMensal = LimiteMensal;
            this.SaldoDisponivelMensal = SaldoDisponivelMensal;
            this.LimiteSemanal = LimiteSemanal;
            this.SaldoDisponivelSemanal = SaldoDisponivelSemanal;
            this.LimiteDiario = LimiteDiario;
            this.SaldoDisponivelDiario = SaldoDisponivelDiario;
            this.DataHoraUltimaCompra = DataHoraUltimaCompra;
            this.Ativo = Ativo;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do controle de limites (id)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do controle de limites (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Id do cart\u00E3o
        /// </summary>
        /// <value>Id do cart\u00E3o</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// Valor do limite mensal
        /// </summary>
        /// <value>Valor do limite mensal</value>
        [DataMember(Name="limiteMensal", EmitDefaultValue=false)]
        public double? LimiteMensal { get; set; }
    
        /// <summary>
        /// Valor dispon\u00EDvel que o cart\u00E3o ainda pode gastar no m\u00EAs
        /// </summary>
        /// <value>Valor dispon\u00EDvel que o cart\u00E3o ainda pode gastar no m\u00EAs</value>
        [DataMember(Name="saldoDisponivelMensal", EmitDefaultValue=false)]
        public double? SaldoDisponivelMensal { get; set; }
    
        /// <summary>
        /// Valor do limite semanal
        /// </summary>
        /// <value>Valor do limite semanal</value>
        [DataMember(Name="limiteSemanal", EmitDefaultValue=false)]
        public double? LimiteSemanal { get; set; }
    
        /// <summary>
        /// Valor dispon\u00EDvel que o cart\u00E3o ainda pode gastar na semana
        /// </summary>
        /// <value>Valor dispon\u00EDvel que o cart\u00E3o ainda pode gastar na semana</value>
        [DataMember(Name="saldoDisponivelSemanal", EmitDefaultValue=false)]
        public double? SaldoDisponivelSemanal { get; set; }
    
        /// <summary>
        /// Valor do limite di\u00E1rio
        /// </summary>
        /// <value>Valor do limite di\u00E1rio</value>
        [DataMember(Name="limiteDiario", EmitDefaultValue=false)]
        public double? LimiteDiario { get; set; }
    
        /// <summary>
        /// Valor dispon\u00EDvel que o cart\u00E3o ainda pode gastar no dia
        /// </summary>
        /// <value>Valor dispon\u00EDvel que o cart\u00E3o ainda pode gastar no dia</value>
        [DataMember(Name="saldoDisponivelDiario", EmitDefaultValue=false)]
        public double? SaldoDisponivelDiario { get; set; }
    
        /// <summary>
        /// Data e hora da \u00FAltima compra realizada pelo cart\u00E3o
        /// </summary>
        /// <value>Data e hora da \u00FAltima compra realizada pelo cart\u00E3o</value>
        [DataMember(Name="dataHoraUltimaCompra", EmitDefaultValue=false)]
        public string DataHoraUltimaCompra { get; set; }
    
        /// <summary>
        /// Flag que mostra se a configura\u00E7\u00E3o est\u00E1 ativa
        /// </summary>
        /// <value>Flag que mostra se a configura\u00E7\u00E3o est\u00E1 ativa</value>
        [DataMember(Name="ativo", EmitDefaultValue=false)]
        public bool? Ativo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ControleLimiteCartaoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  LimiteMensal: ").Append(LimiteMensal).Append("\n");
            sb.Append("  SaldoDisponivelMensal: ").Append(SaldoDisponivelMensal).Append("\n");
            sb.Append("  LimiteSemanal: ").Append(LimiteSemanal).Append("\n");
            sb.Append("  SaldoDisponivelSemanal: ").Append(SaldoDisponivelSemanal).Append("\n");
            sb.Append("  LimiteDiario: ").Append(LimiteDiario).Append("\n");
            sb.Append("  SaldoDisponivelDiario: ").Append(SaldoDisponivelDiario).Append("\n");
            sb.Append("  DataHoraUltimaCompra: ").Append(DataHoraUltimaCompra).Append("\n");
            sb.Append("  Ativo: ").Append(Ativo).Append("\n");
            
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
            return this.Equals(obj as ControleLimiteCartaoResponse);
        }

        /// <summary>
        /// Returns true if ControleLimiteCartaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ControleLimiteCartaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ControleLimiteCartaoResponse other)
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
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.LimiteMensal == other.LimiteMensal ||
                    this.LimiteMensal != null &&
                    this.LimiteMensal.Equals(other.LimiteMensal)
                ) && 
                (
                    this.SaldoDisponivelMensal == other.SaldoDisponivelMensal ||
                    this.SaldoDisponivelMensal != null &&
                    this.SaldoDisponivelMensal.Equals(other.SaldoDisponivelMensal)
                ) && 
                (
                    this.LimiteSemanal == other.LimiteSemanal ||
                    this.LimiteSemanal != null &&
                    this.LimiteSemanal.Equals(other.LimiteSemanal)
                ) && 
                (
                    this.SaldoDisponivelSemanal == other.SaldoDisponivelSemanal ||
                    this.SaldoDisponivelSemanal != null &&
                    this.SaldoDisponivelSemanal.Equals(other.SaldoDisponivelSemanal)
                ) && 
                (
                    this.LimiteDiario == other.LimiteDiario ||
                    this.LimiteDiario != null &&
                    this.LimiteDiario.Equals(other.LimiteDiario)
                ) && 
                (
                    this.SaldoDisponivelDiario == other.SaldoDisponivelDiario ||
                    this.SaldoDisponivelDiario != null &&
                    this.SaldoDisponivelDiario.Equals(other.SaldoDisponivelDiario)
                ) && 
                (
                    this.DataHoraUltimaCompra == other.DataHoraUltimaCompra ||
                    this.DataHoraUltimaCompra != null &&
                    this.DataHoraUltimaCompra.Equals(other.DataHoraUltimaCompra)
                ) && 
                (
                    this.Ativo == other.Ativo ||
                    this.Ativo != null &&
                    this.Ativo.Equals(other.Ativo)
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
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.LimiteMensal != null)
                    hash = hash * 59 + this.LimiteMensal.GetHashCode();
                
                if (this.SaldoDisponivelMensal != null)
                    hash = hash * 59 + this.SaldoDisponivelMensal.GetHashCode();
                
                if (this.LimiteSemanal != null)
                    hash = hash * 59 + this.LimiteSemanal.GetHashCode();
                
                if (this.SaldoDisponivelSemanal != null)
                    hash = hash * 59 + this.SaldoDisponivelSemanal.GetHashCode();
                
                if (this.LimiteDiario != null)
                    hash = hash * 59 + this.LimiteDiario.GetHashCode();
                
                if (this.SaldoDisponivelDiario != null)
                    hash = hash * 59 + this.SaldoDisponivelDiario.GetHashCode();
                
                if (this.DataHoraUltimaCompra != null)
                    hash = hash * 59 + this.DataHoraUltimaCompra.GetHashCode();
                
                if (this.Ativo != null)
                    hash = hash * 59 + this.Ativo.GetHashCode();
                
                return hash;
            }
        }

    }
}
