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
    /// Transa\u00E7\u00F5es pelo tipo de terminal
    /// </summary>
    [DataContract]
    public partial class TipoTerminalTransacoesResponse :  IEquatable<TipoTerminalTransacoesResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoTerminalTransacoesResponse" /> class.
        /// Initializes a new instance of the <see cref="TipoTerminalTransacoesResponse" />class.
        /// </summary>
        /// <param name="CodigoProcessamento">C\u00F3digo de processamento.</param>
        /// <param name="Conta">Conta.</param>
        /// <param name="Cpf">CPF.</param>
        /// <param name="DataTransacao">Data da transa\u00E7\u00E3o.</param>
        /// <param name="IdConta">Identificador da conta.</param>
        /// <param name="IdCartao">Identificador do cart\u00E3o.</param>
        /// <param name="NomePortador">Nome do portador do cart\u00E3o.</param>
        /// <param name="NsuEmissor">NSU Emissor.</param>
        /// <param name="NsuOrigem">NSU Origem.</param>
        /// <param name="StatusConta">Status da conta.</param>
        /// <param name="ValorTransacao">Valor da transa\u00E7\u00E3o.</param>

        public TipoTerminalTransacoesResponse(string CodigoProcessamento = null, long? Conta = null, string Cpf = null, string DataTransacao = null, long? IdConta = null, long? IdCartao = null, string NomePortador = null, int? NsuEmissor = null, int? NsuOrigem = null, int? StatusConta = null, double? ValorTransacao = null)
        {
            this.CodigoProcessamento = CodigoProcessamento;
            this.Conta = Conta;
            this.Cpf = Cpf;
            this.DataTransacao = DataTransacao;
            this.IdConta = IdConta;
            this.IdCartao = IdCartao;
            this.NomePortador = NomePortador;
            this.NsuEmissor = NsuEmissor;
            this.NsuOrigem = NsuOrigem;
            this.StatusConta = StatusConta;
            this.ValorTransacao = ValorTransacao;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de processamento
        /// </summary>
        /// <value>C\u00F3digo de processamento</value>
        [DataMember(Name="codigoProcessamento", EmitDefaultValue=false)]
        public string CodigoProcessamento { get; set; }
    
        /// <summary>
        /// Conta
        /// </summary>
        /// <value>Conta</value>
        [DataMember(Name="conta", EmitDefaultValue=false)]
        public long? Conta { get; set; }
    
        /// <summary>
        /// CPF
        /// </summary>
        /// <value>CPF</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// Data da transa\u00E7\u00E3o
        /// </summary>
        /// <value>Data da transa\u00E7\u00E3o</value>
        [DataMember(Name="dataTransacao", EmitDefaultValue=false)]
        public string DataTransacao { get; set; }
    
        /// <summary>
        /// Identificador da conta
        /// </summary>
        /// <value>Identificador da conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Identificador do cart\u00E3o
        /// </summary>
        /// <value>Identificador do cart\u00E3o</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// Nome do portador do cart\u00E3o
        /// </summary>
        /// <value>Nome do portador do cart\u00E3o</value>
        [DataMember(Name="nomePortador", EmitDefaultValue=false)]
        public string NomePortador { get; set; }
    
        /// <summary>
        /// NSU Emissor
        /// </summary>
        /// <value>NSU Emissor</value>
        [DataMember(Name="nsuEmissor", EmitDefaultValue=false)]
        public int? NsuEmissor { get; set; }
    
        /// <summary>
        /// NSU Origem
        /// </summary>
        /// <value>NSU Origem</value>
        [DataMember(Name="nsuOrigem", EmitDefaultValue=false)]
        public int? NsuOrigem { get; set; }
    
        /// <summary>
        /// Status da conta
        /// </summary>
        /// <value>Status da conta</value>
        [DataMember(Name="statusConta", EmitDefaultValue=false)]
        public int? StatusConta { get; set; }
    
        /// <summary>
        /// Valor da transa\u00E7\u00E3o
        /// </summary>
        /// <value>Valor da transa\u00E7\u00E3o</value>
        [DataMember(Name="valorTransacao", EmitDefaultValue=false)]
        public double? ValorTransacao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoTerminalTransacoesResponse {\n");
            sb.Append("  CodigoProcessamento: ").Append(CodigoProcessamento).Append("\n");
            sb.Append("  Conta: ").Append(Conta).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  DataTransacao: ").Append(DataTransacao).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  NomePortador: ").Append(NomePortador).Append("\n");
            sb.Append("  NsuEmissor: ").Append(NsuEmissor).Append("\n");
            sb.Append("  NsuOrigem: ").Append(NsuOrigem).Append("\n");
            sb.Append("  StatusConta: ").Append(StatusConta).Append("\n");
            sb.Append("  ValorTransacao: ").Append(ValorTransacao).Append("\n");
            
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
            return this.Equals(obj as TipoTerminalTransacoesResponse);
        }

        /// <summary>
        /// Returns true if TipoTerminalTransacoesResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoTerminalTransacoesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoTerminalTransacoesResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CodigoProcessamento == other.CodigoProcessamento ||
                    this.CodigoProcessamento != null &&
                    this.CodigoProcessamento.Equals(other.CodigoProcessamento)
                ) && 
                (
                    this.Conta == other.Conta ||
                    this.Conta != null &&
                    this.Conta.Equals(other.Conta)
                ) && 
                (
                    this.Cpf == other.Cpf ||
                    this.Cpf != null &&
                    this.Cpf.Equals(other.Cpf)
                ) && 
                (
                    this.DataTransacao == other.DataTransacao ||
                    this.DataTransacao != null &&
                    this.DataTransacao.Equals(other.DataTransacao)
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
                    this.NomePortador == other.NomePortador ||
                    this.NomePortador != null &&
                    this.NomePortador.Equals(other.NomePortador)
                ) && 
                (
                    this.NsuEmissor == other.NsuEmissor ||
                    this.NsuEmissor != null &&
                    this.NsuEmissor.Equals(other.NsuEmissor)
                ) && 
                (
                    this.NsuOrigem == other.NsuOrigem ||
                    this.NsuOrigem != null &&
                    this.NsuOrigem.Equals(other.NsuOrigem)
                ) && 
                (
                    this.StatusConta == other.StatusConta ||
                    this.StatusConta != null &&
                    this.StatusConta.Equals(other.StatusConta)
                ) && 
                (
                    this.ValorTransacao == other.ValorTransacao ||
                    this.ValorTransacao != null &&
                    this.ValorTransacao.Equals(other.ValorTransacao)
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
                
                if (this.CodigoProcessamento != null)
                    hash = hash * 59 + this.CodigoProcessamento.GetHashCode();
                
                if (this.Conta != null)
                    hash = hash * 59 + this.Conta.GetHashCode();
                
                if (this.Cpf != null)
                    hash = hash * 59 + this.Cpf.GetHashCode();
                
                if (this.DataTransacao != null)
                    hash = hash * 59 + this.DataTransacao.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.NomePortador != null)
                    hash = hash * 59 + this.NomePortador.GetHashCode();
                
                if (this.NsuEmissor != null)
                    hash = hash * 59 + this.NsuEmissor.GetHashCode();
                
                if (this.NsuOrigem != null)
                    hash = hash * 59 + this.NsuOrigem.GetHashCode();
                
                if (this.StatusConta != null)
                    hash = hash * 59 + this.StatusConta.GetHashCode();
                
                if (this.ValorTransacao != null)
                    hash = hash * 59 + this.ValorTransacao.GetHashCode();
                
                return hash;
            }
        }

    }
}
