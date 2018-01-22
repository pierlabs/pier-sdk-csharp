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
    /// Objeto Cart\u00C3\u00A3o
    /// </summary>
    [DataContract]
    public partial class CartaoResponse :  IEquatable<CartaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoResponse" /> class.
        /// Initializes a new instance of the <see cref="CartaoResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o..</param>
        /// <param name="FlagTitular">Apresenta o tipo do Portador do cart\u00C3\u00A3o, sendo: (1: Titular, 0: Adicional)..</param>
        /// <param name="IdPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence.</param>
        /// <param name="SequencialCartao">N\u00C3\u00BAmero sequencial do cart\u00C3\u00A3o.</param>
        /// <param name="IdConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence..</param>
        /// <param name="IdStatus">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o..</param>
        /// <param name="DataStatus">Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver..</param>
        /// <param name="IdEstagio">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o..</param>
        /// <param name="DataEstagio">Apresenta a data em que o idEstagio atual do cart\u00C3\u00A3o fora aplicado, quando houver..</param>
        /// <param name="NumeroBin">N\u00C3\u00BAmero do bin do cart\u00C3\u00A3o..</param>
        /// <param name="NumeroCartao">Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o..</param>
        /// <param name="NumeroCartaoHash">N\u00C3\u00BAmero do cart\u00C3\u00A3o hash..</param>
        /// <param name="NumeroCartaoCriptografado">N\u00C3\u00BAmero do cart\u00C3\u00A3o criptografado..</param>
        /// <param name="DataEmissao">Apresenta a data de emiss\u00C3\u00A3o do cart\u00C3\u00A3o..</param>
        /// <param name="DataValidade">Apresenta a data de validade do cart\u00C3\u00A3o em formato yyyy-MM, quando houver..</param>
        /// <param name="CartaoVirtual">Apresenta o status que informa se o cart\u00C3\u00A3o \u00C3\u00A9 virtual. Sendo: (1: True, 0: False)..</param>
        /// <param name="ImpressaoAvulsa">Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial..</param>
        /// <param name="DataImpressao">Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica..</param>
        /// <param name="NomeArquivoImpressao">Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver..</param>
        /// <param name="IdProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence..</param>
        /// <param name="NomeImpresso">Apresenta o nome impresso no cart\u00C3\u00A3o..</param>
        /// <param name="CodigoDesbloqueio">Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade..</param>

        public CartaoResponse(long? Id = null, int? FlagTitular = null, long? IdPessoa = null, int? SequencialCartao = null, long? IdConta = null, long? IdStatus = null, string DataStatus = null, long? IdEstagio = null, string DataEstagio = null, long? NumeroBin = null, string NumeroCartao = null, long? NumeroCartaoHash = null, string NumeroCartaoCriptografado = null, string DataEmissao = null, string DataValidade = null, int? CartaoVirtual = null, int? ImpressaoAvulsa = null, string DataImpressao = null, string NomeArquivoImpressao = null, long? IdProduto = null, string NomeImpresso = null, string CodigoDesbloqueio = null)
        {
            this.Id = Id;
            this.FlagTitular = FlagTitular;
            this.IdPessoa = IdPessoa;
            this.SequencialCartao = SequencialCartao;
            this.IdConta = IdConta;
            this.IdStatus = IdStatus;
            this.DataStatus = DataStatus;
            this.IdEstagio = IdEstagio;
            this.DataEstagio = DataEstagio;
            this.NumeroBin = NumeroBin;
            this.NumeroCartao = NumeroCartao;
            this.NumeroCartaoHash = NumeroCartaoHash;
            this.NumeroCartaoCriptografado = NumeroCartaoCriptografado;
            this.DataEmissao = DataEmissao;
            this.DataValidade = DataValidade;
            this.CartaoVirtual = CartaoVirtual;
            this.ImpressaoAvulsa = ImpressaoAvulsa;
            this.DataImpressao = DataImpressao;
            this.NomeArquivoImpressao = NomeArquivoImpressao;
            this.IdProduto = IdProduto;
            this.NomeImpresso = NomeImpresso;
            this.CodigoDesbloqueio = CodigoDesbloqueio;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Apresenta o tipo do Portador do cart\u00C3\u00A3o, sendo: (1: Titular, 0: Adicional).
        /// </summary>
        /// <value>Apresenta o tipo do Portador do cart\u00C3\u00A3o, sendo: (1: Titular, 0: Adicional).</value>
        [DataMember(Name="flagTitular", EmitDefaultValue=false)]
        public int? FlagTitular { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o cart\u00C3\u00A3o pertence</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero sequencial do cart\u00C3\u00A3o
        /// </summary>
        /// <value>N\u00C3\u00BAmero sequencial do cart\u00C3\u00A3o</value>
        [DataMember(Name="sequencialCartao", EmitDefaultValue=false)]
        public int? SequencialCartao { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta a qual o cart\u00C3\u00A3o pertence.</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Status do Cart\u00C3\u00A3o.</value>
        [DataMember(Name="idStatus", EmitDefaultValue=false)]
        public long? IdStatus { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver.
        /// </summary>
        /// <value>Apresenta a data em que o idStatusCartao atual do cart\u00C3\u00A3o fora aplicado, quando houver.</value>
        [DataMember(Name="dataStatus", EmitDefaultValue=false)]
        public string DataStatus { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Est\u00C3\u00A1gio de Impress\u00C3\u00A3o do Cart\u00C3\u00A3o.</value>
        [DataMember(Name="idEstagio", EmitDefaultValue=false)]
        public long? IdEstagio { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o idEstagio atual do cart\u00C3\u00A3o fora aplicado, quando houver.
        /// </summary>
        /// <value>Apresenta a data em que o idEstagio atual do cart\u00C3\u00A3o fora aplicado, quando houver.</value>
        [DataMember(Name="dataEstagio", EmitDefaultValue=false)]
        public string DataEstagio { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero do bin do cart\u00C3\u00A3o.
        /// </summary>
        /// <value>N\u00C3\u00BAmero do bin do cart\u00C3\u00A3o.</value>
        [DataMember(Name="numeroBin", EmitDefaultValue=false)]
        public long? NumeroBin { get; set; }
    
        /// <summary>
        /// Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o.
        /// </summary>
        /// <value>Apresenta o n\u00C3\u00BAmero do cart\u00C3\u00A3o.</value>
        [DataMember(Name="numeroCartao", EmitDefaultValue=false)]
        public string NumeroCartao { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero do cart\u00C3\u00A3o hash.
        /// </summary>
        /// <value>N\u00C3\u00BAmero do cart\u00C3\u00A3o hash.</value>
        [DataMember(Name="numeroCartaoHash", EmitDefaultValue=false)]
        public long? NumeroCartaoHash { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero do cart\u00C3\u00A3o criptografado.
        /// </summary>
        /// <value>N\u00C3\u00BAmero do cart\u00C3\u00A3o criptografado.</value>
        [DataMember(Name="numeroCartaoCriptografado", EmitDefaultValue=false)]
        public string NumeroCartaoCriptografado { get; set; }
    
        /// <summary>
        /// Apresenta a data de emiss\u00C3\u00A3o do cart\u00C3\u00A3o.
        /// </summary>
        /// <value>Apresenta a data de emiss\u00C3\u00A3o do cart\u00C3\u00A3o.</value>
        [DataMember(Name="dataEmissao", EmitDefaultValue=false)]
        public string DataEmissao { get; set; }
    
        /// <summary>
        /// Apresenta a data de validade do cart\u00C3\u00A3o em formato yyyy-MM, quando houver.
        /// </summary>
        /// <value>Apresenta a data de validade do cart\u00C3\u00A3o em formato yyyy-MM, quando houver.</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
    
        /// <summary>
        /// Apresenta o status que informa se o cart\u00C3\u00A3o \u00C3\u00A9 virtual. Sendo: (1: True, 0: False).
        /// </summary>
        /// <value>Apresenta o status que informa se o cart\u00C3\u00A3o \u00C3\u00A9 virtual. Sendo: (1: True, 0: False).</value>
        [DataMember(Name="cartaoVirtual", EmitDefaultValue=false)]
        public int? CartaoVirtual { get; set; }
    
        /// <summary>
        /// Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial.
        /// </summary>
        /// <value>Quando ativa, indica que o cart\u00C3\u00A3o fora impresso na Origem Comercial.</value>
        [DataMember(Name="impressaoAvulsa", EmitDefaultValue=false)]
        public int? ImpressaoAvulsa { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica.
        /// </summary>
        /// <value>Apresenta a data em que o cart\u00C3\u00A3o fora impresso, caso impress\u00C3\u00A3o em loja, ou a data em que ele fora inclu\u00C3\u00ADdo no arquivo para impress\u00C3\u00A3o via gr\u00C3\u00A1fica.</value>
        [DataMember(Name="dataImpressao", EmitDefaultValue=false)]
        public string DataImpressao { get; set; }
    
        /// <summary>
        /// Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver.
        /// </summary>
        /// <value>Apresenta o nome do arquivo onde o cart\u00C3\u00A3o fora inclu\u00C3\u00ADdo para impress\u00C3\u00A3o por uma gr\u00C3\u00A1fica, quando houver.</value>
        [DataMember(Name="nomeArquivoImpressao", EmitDefaultValue=false)]
        public string NomeArquivoImpressao { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence.</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// Apresenta o nome impresso no cart\u00C3\u00A3o.
        /// </summary>
        /// <value>Apresenta o nome impresso no cart\u00C3\u00A3o.</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
        /// <summary>
        /// Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade.
        /// </summary>
        /// <value>Apresenta um c\u00C3\u00B3digo espec\u00C3\u00ADfico para ser utilizado como vari\u00C3\u00A1vel no processo de desbloqueio do cart\u00C3\u00A3o para emissores que querem usar esta funcionalidade.</value>
        [DataMember(Name="codigoDesbloqueio", EmitDefaultValue=false)]
        public string CodigoDesbloqueio { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartaoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FlagTitular: ").Append(FlagTitular).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  SequencialCartao: ").Append(SequencialCartao).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdStatus: ").Append(IdStatus).Append("\n");
            sb.Append("  DataStatus: ").Append(DataStatus).Append("\n");
            sb.Append("  IdEstagio: ").Append(IdEstagio).Append("\n");
            sb.Append("  DataEstagio: ").Append(DataEstagio).Append("\n");
            sb.Append("  NumeroBin: ").Append(NumeroBin).Append("\n");
            sb.Append("  NumeroCartao: ").Append(NumeroCartao).Append("\n");
            sb.Append("  NumeroCartaoHash: ").Append(NumeroCartaoHash).Append("\n");
            sb.Append("  NumeroCartaoCriptografado: ").Append(NumeroCartaoCriptografado).Append("\n");
            sb.Append("  DataEmissao: ").Append(DataEmissao).Append("\n");
            sb.Append("  DataValidade: ").Append(DataValidade).Append("\n");
            sb.Append("  CartaoVirtual: ").Append(CartaoVirtual).Append("\n");
            sb.Append("  ImpressaoAvulsa: ").Append(ImpressaoAvulsa).Append("\n");
            sb.Append("  DataImpressao: ").Append(DataImpressao).Append("\n");
            sb.Append("  NomeArquivoImpressao: ").Append(NomeArquivoImpressao).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  NomeImpresso: ").Append(NomeImpresso).Append("\n");
            sb.Append("  CodigoDesbloqueio: ").Append(CodigoDesbloqueio).Append("\n");
            
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
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.FlagTitular == other.FlagTitular ||
                    this.FlagTitular != null &&
                    this.FlagTitular.Equals(other.FlagTitular)
                ) && 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.SequencialCartao == other.SequencialCartao ||
                    this.SequencialCartao != null &&
                    this.SequencialCartao.Equals(other.SequencialCartao)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdStatus == other.IdStatus ||
                    this.IdStatus != null &&
                    this.IdStatus.Equals(other.IdStatus)
                ) && 
                (
                    this.DataStatus == other.DataStatus ||
                    this.DataStatus != null &&
                    this.DataStatus.Equals(other.DataStatus)
                ) && 
                (
                    this.IdEstagio == other.IdEstagio ||
                    this.IdEstagio != null &&
                    this.IdEstagio.Equals(other.IdEstagio)
                ) && 
                (
                    this.DataEstagio == other.DataEstagio ||
                    this.DataEstagio != null &&
                    this.DataEstagio.Equals(other.DataEstagio)
                ) && 
                (
                    this.NumeroBin == other.NumeroBin ||
                    this.NumeroBin != null &&
                    this.NumeroBin.Equals(other.NumeroBin)
                ) && 
                (
                    this.NumeroCartao == other.NumeroCartao ||
                    this.NumeroCartao != null &&
                    this.NumeroCartao.Equals(other.NumeroCartao)
                ) && 
                (
                    this.NumeroCartaoHash == other.NumeroCartaoHash ||
                    this.NumeroCartaoHash != null &&
                    this.NumeroCartaoHash.Equals(other.NumeroCartaoHash)
                ) && 
                (
                    this.NumeroCartaoCriptografado == other.NumeroCartaoCriptografado ||
                    this.NumeroCartaoCriptografado != null &&
                    this.NumeroCartaoCriptografado.Equals(other.NumeroCartaoCriptografado)
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
                    this.CartaoVirtual == other.CartaoVirtual ||
                    this.CartaoVirtual != null &&
                    this.CartaoVirtual.Equals(other.CartaoVirtual)
                ) && 
                (
                    this.ImpressaoAvulsa == other.ImpressaoAvulsa ||
                    this.ImpressaoAvulsa != null &&
                    this.ImpressaoAvulsa.Equals(other.ImpressaoAvulsa)
                ) && 
                (
                    this.DataImpressao == other.DataImpressao ||
                    this.DataImpressao != null &&
                    this.DataImpressao.Equals(other.DataImpressao)
                ) && 
                (
                    this.NomeArquivoImpressao == other.NomeArquivoImpressao ||
                    this.NomeArquivoImpressao != null &&
                    this.NomeArquivoImpressao.Equals(other.NomeArquivoImpressao)
                ) && 
                (
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.NomeImpresso == other.NomeImpresso ||
                    this.NomeImpresso != null &&
                    this.NomeImpresso.Equals(other.NomeImpresso)
                ) && 
                (
                    this.CodigoDesbloqueio == other.CodigoDesbloqueio ||
                    this.CodigoDesbloqueio != null &&
                    this.CodigoDesbloqueio.Equals(other.CodigoDesbloqueio)
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
                
                if (this.FlagTitular != null)
                    hash = hash * 59 + this.FlagTitular.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.SequencialCartao != null)
                    hash = hash * 59 + this.SequencialCartao.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdStatus != null)
                    hash = hash * 59 + this.IdStatus.GetHashCode();
                
                if (this.DataStatus != null)
                    hash = hash * 59 + this.DataStatus.GetHashCode();
                
                if (this.IdEstagio != null)
                    hash = hash * 59 + this.IdEstagio.GetHashCode();
                
                if (this.DataEstagio != null)
                    hash = hash * 59 + this.DataEstagio.GetHashCode();
                
                if (this.NumeroBin != null)
                    hash = hash * 59 + this.NumeroBin.GetHashCode();
                
                if (this.NumeroCartao != null)
                    hash = hash * 59 + this.NumeroCartao.GetHashCode();
                
                if (this.NumeroCartaoHash != null)
                    hash = hash * 59 + this.NumeroCartaoHash.GetHashCode();
                
                if (this.NumeroCartaoCriptografado != null)
                    hash = hash * 59 + this.NumeroCartaoCriptografado.GetHashCode();
                
                if (this.DataEmissao != null)
                    hash = hash * 59 + this.DataEmissao.GetHashCode();
                
                if (this.DataValidade != null)
                    hash = hash * 59 + this.DataValidade.GetHashCode();
                
                if (this.CartaoVirtual != null)
                    hash = hash * 59 + this.CartaoVirtual.GetHashCode();
                
                if (this.ImpressaoAvulsa != null)
                    hash = hash * 59 + this.ImpressaoAvulsa.GetHashCode();
                
                if (this.DataImpressao != null)
                    hash = hash * 59 + this.DataImpressao.GetHashCode();
                
                if (this.NomeArquivoImpressao != null)
                    hash = hash * 59 + this.NomeArquivoImpressao.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.NomeImpresso != null)
                    hash = hash * 59 + this.NomeImpresso.GetHashCode();
                
                if (this.CodigoDesbloqueio != null)
                    hash = hash * 59 + this.CodigoDesbloqueio.GetHashCode();
                
                return hash;
            }
        }

    }
}
