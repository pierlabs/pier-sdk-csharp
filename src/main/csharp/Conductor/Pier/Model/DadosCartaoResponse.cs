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
    /// {{{dados_cartao_response_description}}}
    /// </summary>
    [DataContract]
    public partial class DadosCartaoResponse :  IEquatable<DadosCartaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DadosCartaoResponse" /> class.
        /// Initializes a new instance of the <see cref="DadosCartaoResponse" />class.
        /// </summary>
        /// <param name="FlagVirtual">FlagVirtual.</param>
        /// <param name="NumeroCartao">{{{dados_cartao_response_numero_cartao_value}}}.</param>
        /// <param name="DataValidade">{{{dados_cartao_response_data_validade_value}}}.</param>
        /// <param name="Cvv2">{{{dados_cartao_response_cvv2_value}}}.</param>
        /// <param name="NomePlastico">{{{dados_cartao_response_nome_plastico_value}}}.</param>
        /// <param name="IdConta">{{{dados_cartao_response_id_conta_value}}}.</param>
        /// <param name="IdCartao">{{{dados_cartao_response_id_cartao_value}}}.</param>
        /// <param name="NumeroAgencia">{{{dados_cartao_response_numero_agencia_value}}}.</param>
        /// <param name="NumeroContaCorente">{{{dados_cartao_response_numero_conta_corente_value}}}.</param>
        /// <param name="IdStatusConta">{{{dados_cartao_response_id_status_conta_value}}}.</param>
        /// <param name="StatusConta">{{{dados_cartao_response_status_conta_value}}}.</param>
        /// <param name="IdStatusCartao">{{{dados_cartao_response_id_status_cartao_value}}}.</param>
        /// <param name="StatusCartao">{{{dados_cartao_response_status_cartao_value}}}.</param>

        public DadosCartaoResponse(int? FlagVirtual = null, string NumeroCartao = null, string DataValidade = null, string Cvv2 = null, string NomePlastico = null, long? IdConta = null, long? IdCartao = null, int? NumeroAgencia = null, string NumeroContaCorente = null, long? IdStatusConta = null, string StatusConta = null, long? IdStatusCartao = null, string StatusCartao = null)
        {
            this.FlagVirtual = FlagVirtual;
            this.NumeroCartao = NumeroCartao;
            this.DataValidade = DataValidade;
            this.Cvv2 = Cvv2;
            this.NomePlastico = NomePlastico;
            this.IdConta = IdConta;
            this.IdCartao = IdCartao;
            this.NumeroAgencia = NumeroAgencia;
            this.NumeroContaCorente = NumeroContaCorente;
            this.IdStatusConta = IdStatusConta;
            this.StatusConta = StatusConta;
            this.IdStatusCartao = IdStatusCartao;
            this.StatusCartao = StatusCartao;
            
        }
        
    
        /// <summary>
        /// Gets or Sets FlagVirtual
        /// </summary>
        [DataMember(Name="flagVirtual", EmitDefaultValue=false)]
        public int? FlagVirtual { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_response_numero_cartao_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_response_numero_cartao_value}}}</value>
        [DataMember(Name="numeroCartao", EmitDefaultValue=false)]
        public string NumeroCartao { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_response_data_validade_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_response_data_validade_value}}}</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_response_cvv2_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_response_cvv2_value}}}</value>
        [DataMember(Name="cvv2", EmitDefaultValue=false)]
        public string Cvv2 { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_response_nome_plastico_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_response_nome_plastico_value}}}</value>
        [DataMember(Name="nomePlastico", EmitDefaultValue=false)]
        public string NomePlastico { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_response_id_cartao_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_response_id_cartao_value}}}</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_response_numero_agencia_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_response_numero_agencia_value}}}</value>
        [DataMember(Name="numeroAgencia", EmitDefaultValue=false)]
        public int? NumeroAgencia { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_response_numero_conta_corente_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_response_numero_conta_corente_value}}}</value>
        [DataMember(Name="numeroContaCorente", EmitDefaultValue=false)]
        public string NumeroContaCorente { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_response_id_status_conta_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_response_id_status_conta_value}}}</value>
        [DataMember(Name="idStatusConta", EmitDefaultValue=false)]
        public long? IdStatusConta { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_response_status_conta_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_response_status_conta_value}}}</value>
        [DataMember(Name="statusConta", EmitDefaultValue=false)]
        public string StatusConta { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_response_id_status_cartao_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_response_id_status_cartao_value}}}</value>
        [DataMember(Name="idStatusCartao", EmitDefaultValue=false)]
        public long? IdStatusCartao { get; set; }
    
        /// <summary>
        /// {{{dados_cartao_response_status_cartao_value}}}
        /// </summary>
        /// <value>{{{dados_cartao_response_status_cartao_value}}}</value>
        [DataMember(Name="statusCartao", EmitDefaultValue=false)]
        public string StatusCartao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DadosCartaoResponse {\n");
            sb.Append("  FlagVirtual: ").Append(FlagVirtual).Append("\n");
            sb.Append("  NumeroCartao: ").Append(NumeroCartao).Append("\n");
            sb.Append("  DataValidade: ").Append(DataValidade).Append("\n");
            sb.Append("  Cvv2: ").Append(Cvv2).Append("\n");
            sb.Append("  NomePlastico: ").Append(NomePlastico).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
            sb.Append("  NumeroContaCorente: ").Append(NumeroContaCorente).Append("\n");
            sb.Append("  IdStatusConta: ").Append(IdStatusConta).Append("\n");
            sb.Append("  StatusConta: ").Append(StatusConta).Append("\n");
            sb.Append("  IdStatusCartao: ").Append(IdStatusCartao).Append("\n");
            sb.Append("  StatusCartao: ").Append(StatusCartao).Append("\n");
            
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
            return this.Equals(obj as DadosCartaoResponse);
        }

        /// <summary>
        /// Returns true if DadosCartaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DadosCartaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DadosCartaoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FlagVirtual == other.FlagVirtual ||
                    this.FlagVirtual != null &&
                    this.FlagVirtual.Equals(other.FlagVirtual)
                ) && 
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
                    this.NumeroAgencia == other.NumeroAgencia ||
                    this.NumeroAgencia != null &&
                    this.NumeroAgencia.Equals(other.NumeroAgencia)
                ) && 
                (
                    this.NumeroContaCorente == other.NumeroContaCorente ||
                    this.NumeroContaCorente != null &&
                    this.NumeroContaCorente.Equals(other.NumeroContaCorente)
                ) && 
                (
                    this.IdStatusConta == other.IdStatusConta ||
                    this.IdStatusConta != null &&
                    this.IdStatusConta.Equals(other.IdStatusConta)
                ) && 
                (
                    this.StatusConta == other.StatusConta ||
                    this.StatusConta != null &&
                    this.StatusConta.Equals(other.StatusConta)
                ) && 
                (
                    this.IdStatusCartao == other.IdStatusCartao ||
                    this.IdStatusCartao != null &&
                    this.IdStatusCartao.Equals(other.IdStatusCartao)
                ) && 
                (
                    this.StatusCartao == other.StatusCartao ||
                    this.StatusCartao != null &&
                    this.StatusCartao.Equals(other.StatusCartao)
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
                
                if (this.FlagVirtual != null)
                    hash = hash * 59 + this.FlagVirtual.GetHashCode();
                
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
                
                if (this.NumeroAgencia != null)
                    hash = hash * 59 + this.NumeroAgencia.GetHashCode();
                
                if (this.NumeroContaCorente != null)
                    hash = hash * 59 + this.NumeroContaCorente.GetHashCode();
                
                if (this.IdStatusConta != null)
                    hash = hash * 59 + this.IdStatusConta.GetHashCode();
                
                if (this.StatusConta != null)
                    hash = hash * 59 + this.StatusConta.GetHashCode();
                
                if (this.IdStatusCartao != null)
                    hash = hash * 59 + this.IdStatusCartao.GetHashCode();
                
                if (this.StatusCartao != null)
                    hash = hash * 59 + this.StatusCartao.GetHashCode();
                
                return hash;
            }
        }

    }
}
