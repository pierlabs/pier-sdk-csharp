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
    /// Objeto Dados Cart\u00C3\u00A3o
    /// </summary>
    [DataContract]
    public partial class DadosCarto :  IEquatable<DadosCarto>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DadosCarto" /> class.
        /// Initializes a new instance of the <see cref="DadosCarto" />class.
        /// </summary>
        /// <param name="NumeroCartao">N\u00C3\u00BAmero do cart\u00C3\u00A3o..</param>
        /// <param name="DataValidade">Data de validade..</param>
        /// <param name="Cvv2">CVV2 do cart\u00C3\u00A3o..</param>
        /// <param name="NomePlastico">Nome do portador..</param>
        /// <param name="IdConta">Identificador da conta do portador..</param>
        /// <param name="IdCartao">Identificador da cart\u00C3\u00A3o do portador..</param>
        /// <param name="Status">Status da conta do portador..</param>
        /// <param name="StatusDescricao">Descri\u00C3\u00A7\u00C3\u00A3o do status da conta do portador..</param>
        /// <param name="FlagProvisorio">Flag de verifica\u00C3\u00A7\u00C3\u00A3o se o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio..</param>

        public DadosCarto(string NumeroCartao = null, DateTime? DataValidade = null, string Cvv2 = null, string NomePlastico = null, long? IdConta = null, long? IdCartao = null, long? Status = null, string StatusDescricao = null, int? FlagProvisorio = null)
        {
            this.NumeroCartao = NumeroCartao;
            this.DataValidade = DataValidade;
            this.Cvv2 = Cvv2;
            this.NomePlastico = NomePlastico;
            this.IdConta = IdConta;
            this.IdCartao = IdCartao;
            this.Status = Status;
            this.StatusDescricao = StatusDescricao;
            this.FlagProvisorio = FlagProvisorio;
            
        }
        
    
        /// <summary>
        /// N\u00C3\u00BAmero do cart\u00C3\u00A3o.
        /// </summary>
        /// <value>N\u00C3\u00BAmero do cart\u00C3\u00A3o.</value>
        [DataMember(Name="numeroCartao", EmitDefaultValue=false)]
        public string NumeroCartao { get; set; }
    
        /// <summary>
        /// Data de validade.
        /// </summary>
        /// <value>Data de validade.</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public DateTime? DataValidade { get; set; }
    
        /// <summary>
        /// CVV2 do cart\u00C3\u00A3o.
        /// </summary>
        /// <value>CVV2 do cart\u00C3\u00A3o.</value>
        [DataMember(Name="cvv2", EmitDefaultValue=false)]
        public string Cvv2 { get; set; }
    
        /// <summary>
        /// Nome do portador.
        /// </summary>
        /// <value>Nome do portador.</value>
        [DataMember(Name="nomePlastico", EmitDefaultValue=false)]
        public string NomePlastico { get; set; }
    
        /// <summary>
        /// Identificador da conta do portador.
        /// </summary>
        /// <value>Identificador da conta do portador.</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Identificador da cart\u00C3\u00A3o do portador.
        /// </summary>
        /// <value>Identificador da cart\u00C3\u00A3o do portador.</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// Status da conta do portador.
        /// </summary>
        /// <value>Status da conta do portador.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public long? Status { get; set; }
    
        /// <summary>
        /// Descri\u00C3\u00A7\u00C3\u00A3o do status da conta do portador.
        /// </summary>
        /// <value>Descri\u00C3\u00A7\u00C3\u00A3o do status da conta do portador.</value>
        [DataMember(Name="statusDescricao", EmitDefaultValue=false)]
        public string StatusDescricao { get; set; }
    
        /// <summary>
        /// Flag de verifica\u00C3\u00A7\u00C3\u00A3o se o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio.
        /// </summary>
        /// <value>Flag de verifica\u00C3\u00A7\u00C3\u00A3o se o cart\u00C3\u00A3o \u00C3\u00A9 provis\u00C3\u00B3rio.</value>
        [DataMember(Name="flagProvisorio", EmitDefaultValue=false)]
        public int? FlagProvisorio { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DadosCarto {\n");
            sb.Append("  NumeroCartao: ").Append(NumeroCartao).Append("\n");
            sb.Append("  DataValidade: ").Append(DataValidade).Append("\n");
            sb.Append("  Cvv2: ").Append(Cvv2).Append("\n");
            sb.Append("  NomePlastico: ").Append(NomePlastico).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDescricao: ").Append(StatusDescricao).Append("\n");
            sb.Append("  FlagProvisorio: ").Append(FlagProvisorio).Append("\n");
            
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
            return this.Equals(obj as DadosCarto);
        }

        /// <summary>
        /// Returns true if DadosCarto instances are equal
        /// </summary>
        /// <param name="other">Instance of DadosCarto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DadosCarto other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NumeroCartao == other.NumeroCartao ||
                    this.NumeroCartao != null &&
                    this.NumeroCartao.Equals(other.NumeroCartao)
                ) && 
                (
                    this.DataValidade == other.DataValidade ||
                    this.DataValidade != null &&
                    this.DataValidade.Equals(other.DataValidade)
                ) && 
                (
                    this.Cvv2 == other.Cvv2 ||
                    this.Cvv2 != null &&
                    this.Cvv2.Equals(other.Cvv2)
                ) && 
                (
                    this.NomePlastico == other.NomePlastico ||
                    this.NomePlastico != null &&
                    this.NomePlastico.Equals(other.NomePlastico)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.StatusDescricao == other.StatusDescricao ||
                    this.StatusDescricao != null &&
                    this.StatusDescricao.Equals(other.StatusDescricao)
                ) && 
                (
                    this.FlagProvisorio == other.FlagProvisorio ||
                    this.FlagProvisorio != null &&
                    this.FlagProvisorio.Equals(other.FlagProvisorio)
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
                
                if (this.NumeroCartao != null)
                    hash = hash * 59 + this.NumeroCartao.GetHashCode();
                
                if (this.DataValidade != null)
                    hash = hash * 59 + this.DataValidade.GetHashCode();
                
                if (this.Cvv2 != null)
                    hash = hash * 59 + this.Cvv2.GetHashCode();
                
                if (this.NomePlastico != null)
                    hash = hash * 59 + this.NomePlastico.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.StatusDescricao != null)
                    hash = hash * 59 + this.StatusDescricao.GetHashCode();
                
                if (this.FlagProvisorio != null)
                    hash = hash * 59 + this.FlagProvisorio.GetHashCode();
                
                return hash;
            }
        }

    }
}
