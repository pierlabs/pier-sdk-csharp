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
    /// Objeto Cart\u00C3\u00A3o para Impresso
    /// </summary>
    [DataContract]
    public partial class CartaoImpressao :  IEquatable<CartaoImpressao>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoImpressao" /> class.
        /// Initializes a new instance of the <see cref="CartaoImpressao" />class.
        /// </summary>
        /// <param name="CentroCustoConta">CentroCustoConta.</param>
        /// <param name="Cpf">Cpf.</param>
        /// <param name="Cvv2">Cvv2.</param>
        /// <param name="DataGeracao">DataGeracao.</param>
        /// <param name="DataValidade">DataValidade.</param>
        /// <param name="IdBandeira">IdBandeira.</param>
        /// <param name="IdCartao">IdCartao.</param>
        /// <param name="IdConta">IdConta.</param>
        /// <param name="IdPessoa">IdPessoa.</param>
        /// <param name="IdTipoCartao">IdTipoCartao.</param>
        /// <param name="NomeEmpregador">NomeEmpregador.</param>
        /// <param name="NomeEmpresa">NomeEmpresa.</param>
        /// <param name="NomeEmpresaBeneficio">NomeEmpresaBeneficio.</param>
        /// <param name="NomeOrigemComercial">NomeOrigemComercial.</param>
        /// <param name="NomePlastico">NomePlastico.</param>
        /// <param name="NumeroAgencia">NumeroAgencia.</param>
        /// <param name="NumeroCartao">NumeroCartao.</param>
        /// <param name="NumeroContaCorente">NumeroContaCorente.</param>
        /// <param name="TipoPortador">TipoPortador.</param>
        /// <param name="Trilha1">Trilha1.</param>
        /// <param name="Trilha2">Trilha2.</param>
        /// <param name="TrilhaCVV1">TrilhaCVV1.</param>
        /// <param name="TrilhaCVV2">TrilhaCVV2.</param>

        public CartaoImpressao(string CentroCustoConta = null, string Cpf = null, string Cvv2 = null, DateTime? DataGeracao = null, DateTime? DataValidade = null, long? IdBandeira = null, long? IdCartao = null, long? IdConta = null, long? IdPessoa = null, long? IdTipoCartao = null, string NomeEmpregador = null, string NomeEmpresa = null, string NomeEmpresaBeneficio = null, string NomeOrigemComercial = null, string NomePlastico = null, int? NumeroAgencia = null, string NumeroCartao = null, string NumeroContaCorente = null, string TipoPortador = null, string Trilha1 = null, string Trilha2 = null, string TrilhaCVV1 = null, string TrilhaCVV2 = null)
        {
            this.CentroCustoConta = CentroCustoConta;
            this.Cpf = Cpf;
            this.Cvv2 = Cvv2;
            this.DataGeracao = DataGeracao;
            this.DataValidade = DataValidade;
            this.IdBandeira = IdBandeira;
            this.IdCartao = IdCartao;
            this.IdConta = IdConta;
            this.IdPessoa = IdPessoa;
            this.IdTipoCartao = IdTipoCartao;
            this.NomeEmpregador = NomeEmpregador;
            this.NomeEmpresa = NomeEmpresa;
            this.NomeEmpresaBeneficio = NomeEmpresaBeneficio;
            this.NomeOrigemComercial = NomeOrigemComercial;
            this.NomePlastico = NomePlastico;
            this.NumeroAgencia = NumeroAgencia;
            this.NumeroCartao = NumeroCartao;
            this.NumeroContaCorente = NumeroContaCorente;
            this.TipoPortador = TipoPortador;
            this.Trilha1 = Trilha1;
            this.Trilha2 = Trilha2;
            this.TrilhaCVV1 = TrilhaCVV1;
            this.TrilhaCVV2 = TrilhaCVV2;
            
        }
        
    
        /// <summary>
        /// Gets or Sets CentroCustoConta
        /// </summary>
        [DataMember(Name="centroCustoConta", EmitDefaultValue=false)]
        public string CentroCustoConta { get; set; }
    
        /// <summary>
        /// Gets or Sets Cpf
        /// </summary>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// Gets or Sets Cvv2
        /// </summary>
        [DataMember(Name="cvv2", EmitDefaultValue=false)]
        public string Cvv2 { get; set; }
    
        /// <summary>
        /// Gets or Sets DataGeracao
        /// </summary>
        [DataMember(Name="dataGeracao", EmitDefaultValue=false)]
        public DateTime? DataGeracao { get; set; }
    
        /// <summary>
        /// Gets or Sets DataValidade
        /// </summary>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public DateTime? DataValidade { get; set; }
    
        /// <summary>
        /// Gets or Sets IdBandeira
        /// </summary>
        [DataMember(Name="idBandeira", EmitDefaultValue=false)]
        public long? IdBandeira { get; set; }
    
        /// <summary>
        /// Gets or Sets IdCartao
        /// </summary>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// Gets or Sets IdConta
        /// </summary>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Gets or Sets IdPessoa
        /// </summary>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// Gets or Sets IdTipoCartao
        /// </summary>
        [DataMember(Name="idTipoCartao", EmitDefaultValue=false)]
        public long? IdTipoCartao { get; set; }
    
        /// <summary>
        /// Gets or Sets NomeEmpregador
        /// </summary>
        [DataMember(Name="nomeEmpregador", EmitDefaultValue=false)]
        public string NomeEmpregador { get; set; }
    
        /// <summary>
        /// Gets or Sets NomeEmpresa
        /// </summary>
        [DataMember(Name="nomeEmpresa", EmitDefaultValue=false)]
        public string NomeEmpresa { get; set; }
    
        /// <summary>
        /// Gets or Sets NomeEmpresaBeneficio
        /// </summary>
        [DataMember(Name="nomeEmpresaBeneficio", EmitDefaultValue=false)]
        public string NomeEmpresaBeneficio { get; set; }
    
        /// <summary>
        /// Gets or Sets NomeOrigemComercial
        /// </summary>
        [DataMember(Name="nomeOrigemComercial", EmitDefaultValue=false)]
        public string NomeOrigemComercial { get; set; }
    
        /// <summary>
        /// Gets or Sets NomePlastico
        /// </summary>
        [DataMember(Name="nomePlastico", EmitDefaultValue=false)]
        public string NomePlastico { get; set; }
    
        /// <summary>
        /// Gets or Sets NumeroAgencia
        /// </summary>
        [DataMember(Name="numeroAgencia", EmitDefaultValue=false)]
        public int? NumeroAgencia { get; set; }
    
        /// <summary>
        /// Gets or Sets NumeroCartao
        /// </summary>
        [DataMember(Name="numeroCartao", EmitDefaultValue=false)]
        public string NumeroCartao { get; set; }
    
        /// <summary>
        /// Gets or Sets NumeroContaCorente
        /// </summary>
        [DataMember(Name="numeroContaCorente", EmitDefaultValue=false)]
        public string NumeroContaCorente { get; set; }
    
        /// <summary>
        /// Gets or Sets TipoPortador
        /// </summary>
        [DataMember(Name="tipoPortador", EmitDefaultValue=false)]
        public string TipoPortador { get; set; }
    
        /// <summary>
        /// Gets or Sets Trilha1
        /// </summary>
        [DataMember(Name="trilha1", EmitDefaultValue=false)]
        public string Trilha1 { get; set; }
    
        /// <summary>
        /// Gets or Sets Trilha2
        /// </summary>
        [DataMember(Name="trilha2", EmitDefaultValue=false)]
        public string Trilha2 { get; set; }
    
        /// <summary>
        /// Gets or Sets TrilhaCVV1
        /// </summary>
        [DataMember(Name="trilhaCVV1", EmitDefaultValue=false)]
        public string TrilhaCVV1 { get; set; }
    
        /// <summary>
        /// Gets or Sets TrilhaCVV2
        /// </summary>
        [DataMember(Name="trilhaCVV2", EmitDefaultValue=false)]
        public string TrilhaCVV2 { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartaoImpressao {\n");
            sb.Append("  CentroCustoConta: ").Append(CentroCustoConta).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  Cvv2: ").Append(Cvv2).Append("\n");
            sb.Append("  DataGeracao: ").Append(DataGeracao).Append("\n");
            sb.Append("  DataValidade: ").Append(DataValidade).Append("\n");
            sb.Append("  IdBandeira: ").Append(IdBandeira).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  IdTipoCartao: ").Append(IdTipoCartao).Append("\n");
            sb.Append("  NomeEmpregador: ").Append(NomeEmpregador).Append("\n");
            sb.Append("  NomeEmpresa: ").Append(NomeEmpresa).Append("\n");
            sb.Append("  NomeEmpresaBeneficio: ").Append(NomeEmpresaBeneficio).Append("\n");
            sb.Append("  NomeOrigemComercial: ").Append(NomeOrigemComercial).Append("\n");
            sb.Append("  NomePlastico: ").Append(NomePlastico).Append("\n");
            sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
            sb.Append("  NumeroCartao: ").Append(NumeroCartao).Append("\n");
            sb.Append("  NumeroContaCorente: ").Append(NumeroContaCorente).Append("\n");
            sb.Append("  TipoPortador: ").Append(TipoPortador).Append("\n");
            sb.Append("  Trilha1: ").Append(Trilha1).Append("\n");
            sb.Append("  Trilha2: ").Append(Trilha2).Append("\n");
            sb.Append("  TrilhaCVV1: ").Append(TrilhaCVV1).Append("\n");
            sb.Append("  TrilhaCVV2: ").Append(TrilhaCVV2).Append("\n");
            
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
            return this.Equals(obj as CartaoImpressao);
        }

        /// <summary>
        /// Returns true if CartaoImpressao instances are equal
        /// </summary>
        /// <param name="other">Instance of CartaoImpressao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartaoImpressao other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CentroCustoConta == other.CentroCustoConta ||
                    this.CentroCustoConta != null &&
                    this.CentroCustoConta.Equals(other.CentroCustoConta)
                ) && 
                (
                    this.Cpf == other.Cpf ||
                    this.Cpf != null &&
                    this.Cpf.Equals(other.Cpf)
                ) && 
                (
                    this.Cvv2 == other.Cvv2 ||
                    this.Cvv2 != null &&
                    this.Cvv2.Equals(other.Cvv2)
                ) && 
                (
                    this.DataGeracao == other.DataGeracao ||
                    this.DataGeracao != null &&
                    this.DataGeracao.Equals(other.DataGeracao)
                ) && 
                (
                    this.DataValidade == other.DataValidade ||
                    this.DataValidade != null &&
                    this.DataValidade.Equals(other.DataValidade)
                ) && 
                (
                    this.IdBandeira == other.IdBandeira ||
                    this.IdBandeira != null &&
                    this.IdBandeira.Equals(other.IdBandeira)
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
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.IdTipoCartao == other.IdTipoCartao ||
                    this.IdTipoCartao != null &&
                    this.IdTipoCartao.Equals(other.IdTipoCartao)
                ) && 
                (
                    this.NomeEmpregador == other.NomeEmpregador ||
                    this.NomeEmpregador != null &&
                    this.NomeEmpregador.Equals(other.NomeEmpregador)
                ) && 
                (
                    this.NomeEmpresa == other.NomeEmpresa ||
                    this.NomeEmpresa != null &&
                    this.NomeEmpresa.Equals(other.NomeEmpresa)
                ) && 
                (
                    this.NomeEmpresaBeneficio == other.NomeEmpresaBeneficio ||
                    this.NomeEmpresaBeneficio != null &&
                    this.NomeEmpresaBeneficio.Equals(other.NomeEmpresaBeneficio)
                ) && 
                (
                    this.NomeOrigemComercial == other.NomeOrigemComercial ||
                    this.NomeOrigemComercial != null &&
                    this.NomeOrigemComercial.Equals(other.NomeOrigemComercial)
                ) && 
                (
                    this.NomePlastico == other.NomePlastico ||
                    this.NomePlastico != null &&
                    this.NomePlastico.Equals(other.NomePlastico)
                ) && 
                (
                    this.NumeroAgencia == other.NumeroAgencia ||
                    this.NumeroAgencia != null &&
                    this.NumeroAgencia.Equals(other.NumeroAgencia)
                ) && 
                (
                    this.NumeroCartao == other.NumeroCartao ||
                    this.NumeroCartao != null &&
                    this.NumeroCartao.Equals(other.NumeroCartao)
                ) && 
                (
                    this.NumeroContaCorente == other.NumeroContaCorente ||
                    this.NumeroContaCorente != null &&
                    this.NumeroContaCorente.Equals(other.NumeroContaCorente)
                ) && 
                (
                    this.TipoPortador == other.TipoPortador ||
                    this.TipoPortador != null &&
                    this.TipoPortador.Equals(other.TipoPortador)
                ) && 
                (
                    this.Trilha1 == other.Trilha1 ||
                    this.Trilha1 != null &&
                    this.Trilha1.Equals(other.Trilha1)
                ) && 
                (
                    this.Trilha2 == other.Trilha2 ||
                    this.Trilha2 != null &&
                    this.Trilha2.Equals(other.Trilha2)
                ) && 
                (
                    this.TrilhaCVV1 == other.TrilhaCVV1 ||
                    this.TrilhaCVV1 != null &&
                    this.TrilhaCVV1.Equals(other.TrilhaCVV1)
                ) && 
                (
                    this.TrilhaCVV2 == other.TrilhaCVV2 ||
                    this.TrilhaCVV2 != null &&
                    this.TrilhaCVV2.Equals(other.TrilhaCVV2)
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
                
                if (this.CentroCustoConta != null)
                    hash = hash * 59 + this.CentroCustoConta.GetHashCode();
                
                if (this.Cpf != null)
                    hash = hash * 59 + this.Cpf.GetHashCode();
                
                if (this.Cvv2 != null)
                    hash = hash * 59 + this.Cvv2.GetHashCode();
                
                if (this.DataGeracao != null)
                    hash = hash * 59 + this.DataGeracao.GetHashCode();
                
                if (this.DataValidade != null)
                    hash = hash * 59 + this.DataValidade.GetHashCode();
                
                if (this.IdBandeira != null)
                    hash = hash * 59 + this.IdBandeira.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.IdTipoCartao != null)
                    hash = hash * 59 + this.IdTipoCartao.GetHashCode();
                
                if (this.NomeEmpregador != null)
                    hash = hash * 59 + this.NomeEmpregador.GetHashCode();
                
                if (this.NomeEmpresa != null)
                    hash = hash * 59 + this.NomeEmpresa.GetHashCode();
                
                if (this.NomeEmpresaBeneficio != null)
                    hash = hash * 59 + this.NomeEmpresaBeneficio.GetHashCode();
                
                if (this.NomeOrigemComercial != null)
                    hash = hash * 59 + this.NomeOrigemComercial.GetHashCode();
                
                if (this.NomePlastico != null)
                    hash = hash * 59 + this.NomePlastico.GetHashCode();
                
                if (this.NumeroAgencia != null)
                    hash = hash * 59 + this.NumeroAgencia.GetHashCode();
                
                if (this.NumeroCartao != null)
                    hash = hash * 59 + this.NumeroCartao.GetHashCode();
                
                if (this.NumeroContaCorente != null)
                    hash = hash * 59 + this.NumeroContaCorente.GetHashCode();
                
                if (this.TipoPortador != null)
                    hash = hash * 59 + this.TipoPortador.GetHashCode();
                
                if (this.Trilha1 != null)
                    hash = hash * 59 + this.Trilha1.GetHashCode();
                
                if (this.Trilha2 != null)
                    hash = hash * 59 + this.Trilha2.GetHashCode();
                
                if (this.TrilhaCVV1 != null)
                    hash = hash * 59 + this.TrilhaCVV1.GetHashCode();
                
                if (this.TrilhaCVV2 != null)
                    hash = hash * 59 + this.TrilhaCVV2.GetHashCode();
                
                return hash;
            }
        }

    }
}
