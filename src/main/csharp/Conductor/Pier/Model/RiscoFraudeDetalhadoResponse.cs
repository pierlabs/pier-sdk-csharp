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
    /// Object of response of Detailed Fraud Risk
    /// </summary>
    [DataContract]
    public partial class RiscoFraudeDetalhadoResponse :  IEquatable<RiscoFraudeDetalhadoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RiscoFraudeDetalhadoResponse" /> class.
        /// Initializes a new instance of the <see cref="RiscoFraudeDetalhadoResponse" />class.
        /// </summary>
        /// <param name="Id">Identification Code of risk of fraud.</param>
        /// <param name="IdTipoResolucao">Identification code of the type of resolution attributed to the register.</param>
        /// <param name="DescricaoTipoResolucao">Description of the type of resolution attributed to the resgister.</param>
        /// <param name="FlagAltoRisco">Indicate that a transaction has a great risk of fraud and all the following transactions will be denied until all the transactions ranked as a risk of fraud be analyzed.</param>
        /// <param name="IdConta">Code of identification of the account.</param>
        /// <param name="IdCartao">Identification code of the card.</param>
        /// <param name="IdProduto">Code of identification of the product.</param>
        /// <param name="IdTransacao">Identification Code of the transaction.</param>
        /// <param name="DataTransacao">Date that the transaction ranked as a risk of fraude was made.</param>
        /// <param name="ValorTransacao">Value of the transaction ranked as a risk of fraud.</param>
        /// <param name="CodigoMoedaOrigem">Code of the origin currency used for the transaction.</param>
        /// <param name="ValorOrigem">Value of the transactions in the origin currency.</param>
        /// <param name="CodigoMoedaDestino">Code of the destination currency used for the transaction.</param>
        /// <param name="ValorDestino">Value of the transaction of the intended currency of the transaction of the destination currency.</param>
        /// <param name="NomeEstabelecimento">Name of the establishment where the transaction with risk of fraud was made.</param>
        /// <param name="IdPais">Identification code of the Country.</param>
        /// <param name="CodigoRespostaAutorizador">Response code of the authorizer for the transaction.</param>
        /// <param name="DescricaoRespostaAutorizador">Description of the response of the authorizer for the transaction.</param>
        /// <param name="CodigoRespostaFraude">Response code of the tool of fraund prevention for the transaction.</param>
        /// <param name="DescricaoRespostaFraude">Description of the response of the Prevention tool to the fraud for the transaction.</param>
        /// <param name="OrigemTransacao">Type of Terminal that caused the Transaction (POS, ATM, TEF, etc).</param>
        /// <param name="CodigoModoEntradaTerminal">Code of identification of the origin mode of the transaction capture.</param>
        /// <param name="DescricaoModoEntradaTerminal">Description of the origin mode of the transaction capture.</param>
        /// <param name="Cpf">Number of CPF of the Person carrdholder, when it is the Physical type.</param>
        /// <param name="Cnpj">CNPJ number of the Per?son cardholder, when it is the Legal type.</param>
        /// <param name="Email">Email Address of the Cardholder.</param>
        /// <param name="Telefones">List of associated telephones to the cardholder.</param>

        public RiscoFraudeDetalhadoResponse(long? Id = null, long? IdTipoResolucao = null, string DescricaoTipoResolucao = null, bool? FlagAltoRisco = null, long? IdConta = null, long? IdCartao = null, long? IdProduto = null, long? IdTransacao = null, string DataTransacao = null, double? ValorTransacao = null, string CodigoMoedaOrigem = null, double? ValorOrigem = null, string CodigoMoedaDestino = null, double? ValorDestino = null, string NomeEstabelecimento = null, string IdPais = null, string CodigoRespostaAutorizador = null, string DescricaoRespostaAutorizador = null, string CodigoRespostaFraude = null, string DescricaoRespostaFraude = null, string OrigemTransacao = null, string CodigoModoEntradaTerminal = null, string DescricaoModoEntradaTerminal = null, string Cpf = null, string Cnpj = null, string Email = null, List<TelefoneResponse> Telefones = null)
        {
            this.Id = Id;
            this.IdTipoResolucao = IdTipoResolucao;
            this.DescricaoTipoResolucao = DescricaoTipoResolucao;
            this.FlagAltoRisco = FlagAltoRisco;
            this.IdConta = IdConta;
            this.IdCartao = IdCartao;
            this.IdProduto = IdProduto;
            this.IdTransacao = IdTransacao;
            this.DataTransacao = DataTransacao;
            this.ValorTransacao = ValorTransacao;
            this.CodigoMoedaOrigem = CodigoMoedaOrigem;
            this.ValorOrigem = ValorOrigem;
            this.CodigoMoedaDestino = CodigoMoedaDestino;
            this.ValorDestino = ValorDestino;
            this.NomeEstabelecimento = NomeEstabelecimento;
            this.IdPais = IdPais;
            this.CodigoRespostaAutorizador = CodigoRespostaAutorizador;
            this.DescricaoRespostaAutorizador = DescricaoRespostaAutorizador;
            this.CodigoRespostaFraude = CodigoRespostaFraude;
            this.DescricaoRespostaFraude = DescricaoRespostaFraude;
            this.OrigemTransacao = OrigemTransacao;
            this.CodigoModoEntradaTerminal = CodigoModoEntradaTerminal;
            this.DescricaoModoEntradaTerminal = DescricaoModoEntradaTerminal;
            this.Cpf = Cpf;
            this.Cnpj = Cnpj;
            this.Email = Email;
            this.Telefones = Telefones;
            
        }
        
    
        /// <summary>
        /// Identification Code of risk of fraud
        /// </summary>
        /// <value>Identification Code of risk of fraud</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Identification code of the type of resolution attributed to the register
        /// </summary>
        /// <value>Identification code of the type of resolution attributed to the register</value>
        [DataMember(Name="idTipoResolucao", EmitDefaultValue=false)]
        public long? IdTipoResolucao { get; set; }
    
        /// <summary>
        /// Description of the type of resolution attributed to the resgister
        /// </summary>
        /// <value>Description of the type of resolution attributed to the resgister</value>
        [DataMember(Name="descricaoTipoResolucao", EmitDefaultValue=false)]
        public string DescricaoTipoResolucao { get; set; }
    
        /// <summary>
        /// Indicate that a transaction has a great risk of fraud and all the following transactions will be denied until all the transactions ranked as a risk of fraud be analyzed
        /// </summary>
        /// <value>Indicate that a transaction has a great risk of fraud and all the following transactions will be denied until all the transactions ranked as a risk of fraud be analyzed</value>
        [DataMember(Name="flagAltoRisco", EmitDefaultValue=false)]
        public bool? FlagAltoRisco { get; set; }
    
        /// <summary>
        /// Code of identification of the account
        /// </summary>
        /// <value>Code of identification of the account</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Identification code of the card
        /// </summary>
        /// <value>Identification code of the card</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// Code of identification of the product
        /// </summary>
        /// <value>Code of identification of the product</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// Identification Code of the transaction
        /// </summary>
        /// <value>Identification Code of the transaction</value>
        [DataMember(Name="idTransacao", EmitDefaultValue=false)]
        public long? IdTransacao { get; set; }
    
        /// <summary>
        /// Date that the transaction ranked as a risk of fraude was made
        /// </summary>
        /// <value>Date that the transaction ranked as a risk of fraude was made</value>
        [DataMember(Name="dataTransacao", EmitDefaultValue=false)]
        public string DataTransacao { get; set; }
    
        /// <summary>
        /// Value of the transaction ranked as a risk of fraud
        /// </summary>
        /// <value>Value of the transaction ranked as a risk of fraud</value>
        [DataMember(Name="valorTransacao", EmitDefaultValue=false)]
        public double? ValorTransacao { get; set; }
    
        /// <summary>
        /// Code of the origin currency used for the transaction
        /// </summary>
        /// <value>Code of the origin currency used for the transaction</value>
        [DataMember(Name="codigoMoedaOrigem", EmitDefaultValue=false)]
        public string CodigoMoedaOrigem { get; set; }
    
        /// <summary>
        /// Value of the transactions in the origin currency
        /// </summary>
        /// <value>Value of the transactions in the origin currency</value>
        [DataMember(Name="valorOrigem", EmitDefaultValue=false)]
        public double? ValorOrigem { get; set; }
    
        /// <summary>
        /// Code of the destination currency used for the transaction
        /// </summary>
        /// <value>Code of the destination currency used for the transaction</value>
        [DataMember(Name="codigoMoedaDestino", EmitDefaultValue=false)]
        public string CodigoMoedaDestino { get; set; }
    
        /// <summary>
        /// Value of the transaction of the intended currency of the transaction of the destination currency
        /// </summary>
        /// <value>Value of the transaction of the intended currency of the transaction of the destination currency</value>
        [DataMember(Name="valorDestino", EmitDefaultValue=false)]
        public double? ValorDestino { get; set; }
    
        /// <summary>
        /// Name of the establishment where the transaction with risk of fraud was made
        /// </summary>
        /// <value>Name of the establishment where the transaction with risk of fraud was made</value>
        [DataMember(Name="nomeEstabelecimento", EmitDefaultValue=false)]
        public string NomeEstabelecimento { get; set; }
    
        /// <summary>
        /// Identification code of the Country
        /// </summary>
        /// <value>Identification code of the Country</value>
        [DataMember(Name="idPais", EmitDefaultValue=false)]
        public string IdPais { get; set; }
    
        /// <summary>
        /// Response code of the authorizer for the transaction
        /// </summary>
        /// <value>Response code of the authorizer for the transaction</value>
        [DataMember(Name="codigoRespostaAutorizador", EmitDefaultValue=false)]
        public string CodigoRespostaAutorizador { get; set; }
    
        /// <summary>
        /// Description of the response of the authorizer for the transaction
        /// </summary>
        /// <value>Description of the response of the authorizer for the transaction</value>
        [DataMember(Name="descricaoRespostaAutorizador", EmitDefaultValue=false)]
        public string DescricaoRespostaAutorizador { get; set; }
    
        /// <summary>
        /// Response code of the tool of fraund prevention for the transaction
        /// </summary>
        /// <value>Response code of the tool of fraund prevention for the transaction</value>
        [DataMember(Name="codigoRespostaFraude", EmitDefaultValue=false)]
        public string CodigoRespostaFraude { get; set; }
    
        /// <summary>
        /// Description of the response of the Prevention tool to the fraud for the transaction
        /// </summary>
        /// <value>Description of the response of the Prevention tool to the fraud for the transaction</value>
        [DataMember(Name="descricaoRespostaFraude", EmitDefaultValue=false)]
        public string DescricaoRespostaFraude { get; set; }
    
        /// <summary>
        /// Type of Terminal that caused the Transaction (POS, ATM, TEF, etc)
        /// </summary>
        /// <value>Type of Terminal that caused the Transaction (POS, ATM, TEF, etc)</value>
        [DataMember(Name="origemTransacao", EmitDefaultValue=false)]
        public string OrigemTransacao { get; set; }
    
        /// <summary>
        /// Code of identification of the origin mode of the transaction capture
        /// </summary>
        /// <value>Code of identification of the origin mode of the transaction capture</value>
        [DataMember(Name="codigoModoEntradaTerminal", EmitDefaultValue=false)]
        public string CodigoModoEntradaTerminal { get; set; }
    
        /// <summary>
        /// Description of the origin mode of the transaction capture
        /// </summary>
        /// <value>Description of the origin mode of the transaction capture</value>
        [DataMember(Name="descricaoModoEntradaTerminal", EmitDefaultValue=false)]
        public string DescricaoModoEntradaTerminal { get; set; }
    
        /// <summary>
        /// Number of CPF of the Person carrdholder, when it is the Physical type
        /// </summary>
        /// <value>Number of CPF of the Person carrdholder, when it is the Physical type</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// CNPJ number of the Per?son cardholder, when it is the Legal type
        /// </summary>
        /// <value>CNPJ number of the Per?son cardholder, when it is the Legal type</value>
        [DataMember(Name="cnpj", EmitDefaultValue=false)]
        public string Cnpj { get; set; }
    
        /// <summary>
        /// Email Address of the Cardholder
        /// </summary>
        /// <value>Email Address of the Cardholder</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// List of associated telephones to the cardholder
        /// </summary>
        /// <value>List of associated telephones to the cardholder</value>
        [DataMember(Name="telefones", EmitDefaultValue=false)]
        public List<TelefoneResponse> Telefones { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RiscoFraudeDetalhadoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdTipoResolucao: ").Append(IdTipoResolucao).Append("\n");
            sb.Append("  DescricaoTipoResolucao: ").Append(DescricaoTipoResolucao).Append("\n");
            sb.Append("  FlagAltoRisco: ").Append(FlagAltoRisco).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  IdTransacao: ").Append(IdTransacao).Append("\n");
            sb.Append("  DataTransacao: ").Append(DataTransacao).Append("\n");
            sb.Append("  ValorTransacao: ").Append(ValorTransacao).Append("\n");
            sb.Append("  CodigoMoedaOrigem: ").Append(CodigoMoedaOrigem).Append("\n");
            sb.Append("  ValorOrigem: ").Append(ValorOrigem).Append("\n");
            sb.Append("  CodigoMoedaDestino: ").Append(CodigoMoedaDestino).Append("\n");
            sb.Append("  ValorDestino: ").Append(ValorDestino).Append("\n");
            sb.Append("  NomeEstabelecimento: ").Append(NomeEstabelecimento).Append("\n");
            sb.Append("  IdPais: ").Append(IdPais).Append("\n");
            sb.Append("  CodigoRespostaAutorizador: ").Append(CodigoRespostaAutorizador).Append("\n");
            sb.Append("  DescricaoRespostaAutorizador: ").Append(DescricaoRespostaAutorizador).Append("\n");
            sb.Append("  CodigoRespostaFraude: ").Append(CodigoRespostaFraude).Append("\n");
            sb.Append("  DescricaoRespostaFraude: ").Append(DescricaoRespostaFraude).Append("\n");
            sb.Append("  OrigemTransacao: ").Append(OrigemTransacao).Append("\n");
            sb.Append("  CodigoModoEntradaTerminal: ").Append(CodigoModoEntradaTerminal).Append("\n");
            sb.Append("  DescricaoModoEntradaTerminal: ").Append(DescricaoModoEntradaTerminal).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  Cnpj: ").Append(Cnpj).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Telefones: ").Append(Telefones).Append("\n");
            
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
            return this.Equals(obj as RiscoFraudeDetalhadoResponse);
        }

        /// <summary>
        /// Returns true if RiscoFraudeDetalhadoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of RiscoFraudeDetalhadoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RiscoFraudeDetalhadoResponse other)
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
                    this.IdTipoResolucao == other.IdTipoResolucao ||
                    this.IdTipoResolucao != null &&
                    this.IdTipoResolucao.Equals(other.IdTipoResolucao)
                ) && 
                (
                    this.DescricaoTipoResolucao == other.DescricaoTipoResolucao ||
                    this.DescricaoTipoResolucao != null &&
                    this.DescricaoTipoResolucao.Equals(other.DescricaoTipoResolucao)
                ) && 
                (
                    this.FlagAltoRisco == other.FlagAltoRisco ||
                    this.FlagAltoRisco != null &&
                    this.FlagAltoRisco.Equals(other.FlagAltoRisco)
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
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.IdTransacao == other.IdTransacao ||
                    this.IdTransacao != null &&
                    this.IdTransacao.Equals(other.IdTransacao)
                ) && 
                (
                    this.DataTransacao == other.DataTransacao ||
                    this.DataTransacao != null &&
                    this.DataTransacao.Equals(other.DataTransacao)
                ) && 
                (
                    this.ValorTransacao == other.ValorTransacao ||
                    this.ValorTransacao != null &&
                    this.ValorTransacao.Equals(other.ValorTransacao)
                ) && 
                (
                    this.CodigoMoedaOrigem == other.CodigoMoedaOrigem ||
                    this.CodigoMoedaOrigem != null &&
                    this.CodigoMoedaOrigem.Equals(other.CodigoMoedaOrigem)
                ) && 
                (
                    this.ValorOrigem == other.ValorOrigem ||
                    this.ValorOrigem != null &&
                    this.ValorOrigem.Equals(other.ValorOrigem)
                ) && 
                (
                    this.CodigoMoedaDestino == other.CodigoMoedaDestino ||
                    this.CodigoMoedaDestino != null &&
                    this.CodigoMoedaDestino.Equals(other.CodigoMoedaDestino)
                ) && 
                (
                    this.ValorDestino == other.ValorDestino ||
                    this.ValorDestino != null &&
                    this.ValorDestino.Equals(other.ValorDestino)
                ) && 
                (
                    this.NomeEstabelecimento == other.NomeEstabelecimento ||
                    this.NomeEstabelecimento != null &&
                    this.NomeEstabelecimento.Equals(other.NomeEstabelecimento)
                ) && 
                (
                    this.IdPais == other.IdPais ||
                    this.IdPais != null &&
                    this.IdPais.Equals(other.IdPais)
                ) && 
                (
                    this.CodigoRespostaAutorizador == other.CodigoRespostaAutorizador ||
                    this.CodigoRespostaAutorizador != null &&
                    this.CodigoRespostaAutorizador.Equals(other.CodigoRespostaAutorizador)
                ) && 
                (
                    this.DescricaoRespostaAutorizador == other.DescricaoRespostaAutorizador ||
                    this.DescricaoRespostaAutorizador != null &&
                    this.DescricaoRespostaAutorizador.Equals(other.DescricaoRespostaAutorizador)
                ) && 
                (
                    this.CodigoRespostaFraude == other.CodigoRespostaFraude ||
                    this.CodigoRespostaFraude != null &&
                    this.CodigoRespostaFraude.Equals(other.CodigoRespostaFraude)
                ) && 
                (
                    this.DescricaoRespostaFraude == other.DescricaoRespostaFraude ||
                    this.DescricaoRespostaFraude != null &&
                    this.DescricaoRespostaFraude.Equals(other.DescricaoRespostaFraude)
                ) && 
                (
                    this.OrigemTransacao == other.OrigemTransacao ||
                    this.OrigemTransacao != null &&
                    this.OrigemTransacao.Equals(other.OrigemTransacao)
                ) && 
                (
                    this.CodigoModoEntradaTerminal == other.CodigoModoEntradaTerminal ||
                    this.CodigoModoEntradaTerminal != null &&
                    this.CodigoModoEntradaTerminal.Equals(other.CodigoModoEntradaTerminal)
                ) && 
                (
                    this.DescricaoModoEntradaTerminal == other.DescricaoModoEntradaTerminal ||
                    this.DescricaoModoEntradaTerminal != null &&
                    this.DescricaoModoEntradaTerminal.Equals(other.DescricaoModoEntradaTerminal)
                ) && 
                (
                    this.Cpf == other.Cpf ||
                    this.Cpf != null &&
                    this.Cpf.Equals(other.Cpf)
                ) && 
                (
                    this.Cnpj == other.Cnpj ||
                    this.Cnpj != null &&
                    this.Cnpj.Equals(other.Cnpj)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Telefones == other.Telefones ||
                    this.Telefones != null &&
                    this.Telefones.SequenceEqual(other.Telefones)
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
                
                if (this.IdTipoResolucao != null)
                    hash = hash * 59 + this.IdTipoResolucao.GetHashCode();
                
                if (this.DescricaoTipoResolucao != null)
                    hash = hash * 59 + this.DescricaoTipoResolucao.GetHashCode();
                
                if (this.FlagAltoRisco != null)
                    hash = hash * 59 + this.FlagAltoRisco.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.IdTransacao != null)
                    hash = hash * 59 + this.IdTransacao.GetHashCode();
                
                if (this.DataTransacao != null)
                    hash = hash * 59 + this.DataTransacao.GetHashCode();
                
                if (this.ValorTransacao != null)
                    hash = hash * 59 + this.ValorTransacao.GetHashCode();
                
                if (this.CodigoMoedaOrigem != null)
                    hash = hash * 59 + this.CodigoMoedaOrigem.GetHashCode();
                
                if (this.ValorOrigem != null)
                    hash = hash * 59 + this.ValorOrigem.GetHashCode();
                
                if (this.CodigoMoedaDestino != null)
                    hash = hash * 59 + this.CodigoMoedaDestino.GetHashCode();
                
                if (this.ValorDestino != null)
                    hash = hash * 59 + this.ValorDestino.GetHashCode();
                
                if (this.NomeEstabelecimento != null)
                    hash = hash * 59 + this.NomeEstabelecimento.GetHashCode();
                
                if (this.IdPais != null)
                    hash = hash * 59 + this.IdPais.GetHashCode();
                
                if (this.CodigoRespostaAutorizador != null)
                    hash = hash * 59 + this.CodigoRespostaAutorizador.GetHashCode();
                
                if (this.DescricaoRespostaAutorizador != null)
                    hash = hash * 59 + this.DescricaoRespostaAutorizador.GetHashCode();
                
                if (this.CodigoRespostaFraude != null)
                    hash = hash * 59 + this.CodigoRespostaFraude.GetHashCode();
                
                if (this.DescricaoRespostaFraude != null)
                    hash = hash * 59 + this.DescricaoRespostaFraude.GetHashCode();
                
                if (this.OrigemTransacao != null)
                    hash = hash * 59 + this.OrigemTransacao.GetHashCode();
                
                if (this.CodigoModoEntradaTerminal != null)
                    hash = hash * 59 + this.CodigoModoEntradaTerminal.GetHashCode();
                
                if (this.DescricaoModoEntradaTerminal != null)
                    hash = hash * 59 + this.DescricaoModoEntradaTerminal.GetHashCode();
                
                if (this.Cpf != null)
                    hash = hash * 59 + this.Cpf.GetHashCode();
                
                if (this.Cnpj != null)
                    hash = hash * 59 + this.Cnpj.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.Telefones != null)
                    hash = hash * 59 + this.Telefones.GetHashCode();
                
                return hash;
            }
        }

    }
}
