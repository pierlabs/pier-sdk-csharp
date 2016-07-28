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
    /// 
    /// </summary>
    [DataContract]
    public partial class CartaoResponse :  IEquatable<CartaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoResponse" /> class.
        /// Initializes a new instance of the <see cref="CartaoResponse" />class.
        /// </summary>
        /// <param name="Bin">Bin.</param>
        /// <param name="CodRetorno">CodRetorno.</param>
        /// <param name="CodigoDesbloqueio">CodigoDesbloqueio.</param>
        /// <param name="CriptografiaHSM">CriptografiaHSM.</param>
        /// <param name="DataEmissao">DataEmissao.</param>
        /// <param name="DataValidade">DataValidade.</param>
        /// <param name="DataVencimentoPadrao">DataVencimentoPadrao.</param>
        /// <param name="DescricaoRetorno">DescricaoRetorno.</param>
        /// <param name="EstagioCartao">EstagioCartao.</param>
        /// <param name="EstagioData">EstagioData.</param>
        /// <param name="FlagReversao">FlagReversao.</param>
        /// <param name="FlagSenha">FlagSenha.</param>
        /// <param name="IdCartao">IdCartao.</param>
        /// <param name="IdConta">IdConta.</param>
        /// <param name="IdEmissor">IdEmissor.</param>
        /// <param name="IdLog">IdLog.</param>
        /// <param name="IdPessoaFisica">IdPessoaFisica.</param>
        /// <param name="IdProduto">IdProduto.</param>
        /// <param name="NomePlastico">NomePlastico.</param>
        /// <param name="NumeroCartao">NumeroCartao.</param>
        /// <param name="NumeroCartaoReal">NumeroCartaoReal.</param>
        /// <param name="StatusCartao">StatusCartao.</param>
        /// <param name="StatusData">StatusData.</param>

        public CartaoResponse(int? Bin = null, int? CodRetorno = null, string CodigoDesbloqueio = null, string CriptografiaHSM = null, DateTime? DataEmissao = null, DateTime? DataValidade = null, string DataVencimentoPadrao = null, string DescricaoRetorno = null, int? EstagioCartao = null, DateTime? EstagioData = null, bool? FlagReversao = null, bool? FlagSenha = null, int? IdCartao = null, int? IdConta = null, int? IdEmissor = null, string IdLog = null, int? IdPessoaFisica = null, int? IdProduto = null, string NomePlastico = null, string NumeroCartao = null, string NumeroCartaoReal = null, int? StatusCartao = null, DateTime? StatusData = null)
        {
            this.Bin = Bin;
            this.CodRetorno = CodRetorno;
            this.CodigoDesbloqueio = CodigoDesbloqueio;
            this.CriptografiaHSM = CriptografiaHSM;
            this.DataEmissao = DataEmissao;
            this.DataValidade = DataValidade;
            this.DataVencimentoPadrao = DataVencimentoPadrao;
            this.DescricaoRetorno = DescricaoRetorno;
            this.EstagioCartao = EstagioCartao;
            this.EstagioData = EstagioData;
            this.FlagReversao = FlagReversao;
            this.FlagSenha = FlagSenha;
            this.IdCartao = IdCartao;
            this.IdConta = IdConta;
            this.IdEmissor = IdEmissor;
            this.IdLog = IdLog;
            this.IdPessoaFisica = IdPessoaFisica;
            this.IdProduto = IdProduto;
            this.NomePlastico = NomePlastico;
            this.NumeroCartao = NumeroCartao;
            this.NumeroCartaoReal = NumeroCartaoReal;
            this.StatusCartao = StatusCartao;
            this.StatusData = StatusData;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Bin
        /// </summary>
        [DataMember(Name="bin", EmitDefaultValue=false)]
        public int? Bin { get; set; }
    
        /// <summary>
        /// Gets or Sets CodRetorno
        /// </summary>
        [DataMember(Name="codRetorno", EmitDefaultValue=false)]
        public int? CodRetorno { get; set; }
    
        /// <summary>
        /// Gets or Sets CodigoDesbloqueio
        /// </summary>
        [DataMember(Name="codigoDesbloqueio", EmitDefaultValue=false)]
        public string CodigoDesbloqueio { get; set; }
    
        /// <summary>
        /// Gets or Sets CriptografiaHSM
        /// </summary>
        [DataMember(Name="criptografiaHSM", EmitDefaultValue=false)]
        public string CriptografiaHSM { get; set; }
    
        /// <summary>
        /// Gets or Sets DataEmissao
        /// </summary>
        [DataMember(Name="dataEmissao", EmitDefaultValue=false)]
        public DateTime? DataEmissao { get; set; }
    
        /// <summary>
        /// Gets or Sets DataValidade
        /// </summary>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public DateTime? DataValidade { get; set; }
    
        /// <summary>
        /// Gets or Sets DataVencimentoPadrao
        /// </summary>
        [DataMember(Name="dataVencimentoPadrao", EmitDefaultValue=false)]
        public string DataVencimentoPadrao { get; set; }
    
        /// <summary>
        /// Gets or Sets DescricaoRetorno
        /// </summary>
        [DataMember(Name="descricaoRetorno", EmitDefaultValue=false)]
        public string DescricaoRetorno { get; set; }
    
        /// <summary>
        /// Gets or Sets EstagioCartao
        /// </summary>
        [DataMember(Name="estagioCartao", EmitDefaultValue=false)]
        public int? EstagioCartao { get; set; }
    
        /// <summary>
        /// Gets or Sets EstagioData
        /// </summary>
        [DataMember(Name="estagioData", EmitDefaultValue=false)]
        public DateTime? EstagioData { get; set; }
    
        /// <summary>
        /// Gets or Sets FlagReversao
        /// </summary>
        [DataMember(Name="flagReversao", EmitDefaultValue=false)]
        public bool? FlagReversao { get; set; }
    
        /// <summary>
        /// Gets or Sets FlagSenha
        /// </summary>
        [DataMember(Name="flagSenha", EmitDefaultValue=false)]
        public bool? FlagSenha { get; set; }
    
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
        /// Gets or Sets IdEmissor
        /// </summary>
        [DataMember(Name="idEmissor", EmitDefaultValue=false)]
        public int? IdEmissor { get; set; }
    
        /// <summary>
        /// Gets or Sets IdLog
        /// </summary>
        [DataMember(Name="idLog", EmitDefaultValue=false)]
        public string IdLog { get; set; }
    
        /// <summary>
        /// Gets or Sets IdPessoaFisica
        /// </summary>
        [DataMember(Name="idPessoaFisica", EmitDefaultValue=false)]
        public int? IdPessoaFisica { get; set; }
    
        /// <summary>
        /// Gets or Sets IdProduto
        /// </summary>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public int? IdProduto { get; set; }
    
        /// <summary>
        /// Gets or Sets NomePlastico
        /// </summary>
        [DataMember(Name="nomePlastico", EmitDefaultValue=false)]
        public string NomePlastico { get; set; }
    
        /// <summary>
        /// Gets or Sets NumeroCartao
        /// </summary>
        [DataMember(Name="numeroCartao", EmitDefaultValue=false)]
        public string NumeroCartao { get; set; }
    
        /// <summary>
        /// Gets or Sets NumeroCartaoReal
        /// </summary>
        [DataMember(Name="numeroCartaoReal", EmitDefaultValue=false)]
        public string NumeroCartaoReal { get; set; }
    
        /// <summary>
        /// Gets or Sets StatusCartao
        /// </summary>
        [DataMember(Name="statusCartao", EmitDefaultValue=false)]
        public int? StatusCartao { get; set; }
    
        /// <summary>
        /// Gets or Sets StatusData
        /// </summary>
        [DataMember(Name="statusData", EmitDefaultValue=false)]
        public DateTime? StatusData { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartaoResponse {\n");
            sb.Append("  Bin: ").Append(Bin).Append("\n");
            sb.Append("  CodRetorno: ").Append(CodRetorno).Append("\n");
            sb.Append("  CodigoDesbloqueio: ").Append(CodigoDesbloqueio).Append("\n");
            sb.Append("  CriptografiaHSM: ").Append(CriptografiaHSM).Append("\n");
            sb.Append("  DataEmissao: ").Append(DataEmissao).Append("\n");
            sb.Append("  DataValidade: ").Append(DataValidade).Append("\n");
            sb.Append("  DataVencimentoPadrao: ").Append(DataVencimentoPadrao).Append("\n");
            sb.Append("  DescricaoRetorno: ").Append(DescricaoRetorno).Append("\n");
            sb.Append("  EstagioCartao: ").Append(EstagioCartao).Append("\n");
            sb.Append("  EstagioData: ").Append(EstagioData).Append("\n");
            sb.Append("  FlagReversao: ").Append(FlagReversao).Append("\n");
            sb.Append("  FlagSenha: ").Append(FlagSenha).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdEmissor: ").Append(IdEmissor).Append("\n");
            sb.Append("  IdLog: ").Append(IdLog).Append("\n");
            sb.Append("  IdPessoaFisica: ").Append(IdPessoaFisica).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  NomePlastico: ").Append(NomePlastico).Append("\n");
            sb.Append("  NumeroCartao: ").Append(NumeroCartao).Append("\n");
            sb.Append("  NumeroCartaoReal: ").Append(NumeroCartaoReal).Append("\n");
            sb.Append("  StatusCartao: ").Append(StatusCartao).Append("\n");
            sb.Append("  StatusData: ").Append(StatusData).Append("\n");
            
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
            return this.Equals(obj as CartaoResponse);
        }

        /// <summary>
        /// Returns true if CartaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CartaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartaoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Bin == other.Bin ||
                    this.Bin != null &&
                    this.Bin.Equals(other.Bin)
                ) && 
                (
                    this.CodRetorno == other.CodRetorno ||
                    this.CodRetorno != null &&
                    this.CodRetorno.Equals(other.CodRetorno)
                ) && 
                (
                    this.CodigoDesbloqueio == other.CodigoDesbloqueio ||
                    this.CodigoDesbloqueio != null &&
                    this.CodigoDesbloqueio.Equals(other.CodigoDesbloqueio)
                ) && 
                (
                    this.CriptografiaHSM == other.CriptografiaHSM ||
                    this.CriptografiaHSM != null &&
                    this.CriptografiaHSM.Equals(other.CriptografiaHSM)
                ) && 
                (
                    this.DataEmissao == other.DataEmissao ||
                    this.DataEmissao != null &&
                    this.DataEmissao.Equals(other.DataEmissao)
                ) && 
                (
                    this.DataValidade == other.DataValidade ||
                    this.DataValidade != null &&
                    this.DataValidade.Equals(other.DataValidade)
                ) && 
                (
                    this.DataVencimentoPadrao == other.DataVencimentoPadrao ||
                    this.DataVencimentoPadrao != null &&
                    this.DataVencimentoPadrao.Equals(other.DataVencimentoPadrao)
                ) && 
                (
                    this.DescricaoRetorno == other.DescricaoRetorno ||
                    this.DescricaoRetorno != null &&
                    this.DescricaoRetorno.Equals(other.DescricaoRetorno)
                ) && 
                (
                    this.EstagioCartao == other.EstagioCartao ||
                    this.EstagioCartao != null &&
                    this.EstagioCartao.Equals(other.EstagioCartao)
                ) && 
                (
                    this.EstagioData == other.EstagioData ||
                    this.EstagioData != null &&
                    this.EstagioData.Equals(other.EstagioData)
                ) && 
                (
                    this.FlagReversao == other.FlagReversao ||
                    this.FlagReversao != null &&
                    this.FlagReversao.Equals(other.FlagReversao)
                ) && 
                (
                    this.FlagSenha == other.FlagSenha ||
                    this.FlagSenha != null &&
                    this.FlagSenha.Equals(other.FlagSenha)
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
                    this.IdEmissor == other.IdEmissor ||
                    this.IdEmissor != null &&
                    this.IdEmissor.Equals(other.IdEmissor)
                ) && 
                (
                    this.IdLog == other.IdLog ||
                    this.IdLog != null &&
                    this.IdLog.Equals(other.IdLog)
                ) && 
                (
                    this.IdPessoaFisica == other.IdPessoaFisica ||
                    this.IdPessoaFisica != null &&
                    this.IdPessoaFisica.Equals(other.IdPessoaFisica)
                ) && 
                (
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.NomePlastico == other.NomePlastico ||
                    this.NomePlastico != null &&
                    this.NomePlastico.Equals(other.NomePlastico)
                ) && 
                (
                    this.NumeroCartao == other.NumeroCartao ||
                    this.NumeroCartao != null &&
                    this.NumeroCartao.Equals(other.NumeroCartao)
                ) && 
                (
                    this.NumeroCartaoReal == other.NumeroCartaoReal ||
                    this.NumeroCartaoReal != null &&
                    this.NumeroCartaoReal.Equals(other.NumeroCartaoReal)
                ) && 
                (
                    this.StatusCartao == other.StatusCartao ||
                    this.StatusCartao != null &&
                    this.StatusCartao.Equals(other.StatusCartao)
                ) && 
                (
                    this.StatusData == other.StatusData ||
                    this.StatusData != null &&
                    this.StatusData.Equals(other.StatusData)
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
                
                if (this.Bin != null)
                    hash = hash * 59 + this.Bin.GetHashCode();
                
                if (this.CodRetorno != null)
                    hash = hash * 59 + this.CodRetorno.GetHashCode();
                
                if (this.CodigoDesbloqueio != null)
                    hash = hash * 59 + this.CodigoDesbloqueio.GetHashCode();
                
                if (this.CriptografiaHSM != null)
                    hash = hash * 59 + this.CriptografiaHSM.GetHashCode();
                
                if (this.DataEmissao != null)
                    hash = hash * 59 + this.DataEmissao.GetHashCode();
                
                if (this.DataValidade != null)
                    hash = hash * 59 + this.DataValidade.GetHashCode();
                
                if (this.DataVencimentoPadrao != null)
                    hash = hash * 59 + this.DataVencimentoPadrao.GetHashCode();
                
                if (this.DescricaoRetorno != null)
                    hash = hash * 59 + this.DescricaoRetorno.GetHashCode();
                
                if (this.EstagioCartao != null)
                    hash = hash * 59 + this.EstagioCartao.GetHashCode();
                
                if (this.EstagioData != null)
                    hash = hash * 59 + this.EstagioData.GetHashCode();
                
                if (this.FlagReversao != null)
                    hash = hash * 59 + this.FlagReversao.GetHashCode();
                
                if (this.FlagSenha != null)
                    hash = hash * 59 + this.FlagSenha.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdEmissor != null)
                    hash = hash * 59 + this.IdEmissor.GetHashCode();
                
                if (this.IdLog != null)
                    hash = hash * 59 + this.IdLog.GetHashCode();
                
                if (this.IdPessoaFisica != null)
                    hash = hash * 59 + this.IdPessoaFisica.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.NomePlastico != null)
                    hash = hash * 59 + this.NomePlastico.GetHashCode();
                
                if (this.NumeroCartao != null)
                    hash = hash * 59 + this.NumeroCartao.GetHashCode();
                
                if (this.NumeroCartaoReal != null)
                    hash = hash * 59 + this.NumeroCartaoReal.GetHashCode();
                
                if (this.StatusCartao != null)
                    hash = hash * 59 + this.StatusCartao.GetHashCode();
                
                if (this.StatusData != null)
                    hash = hash * 59 + this.StatusData.GetHashCode();
                
                return hash;
            }
        }

    }
}
