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
    /// Object Card for printing
    /// </summary>
    [DataContract]
    public partial class CartaoImpressaoResponse :  IEquatable<CartaoImpressaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoImpressaoResponse" /> class.
        /// Initializes a new instance of the <see cref="CartaoImpressaoResponse" />class.
        /// </summary>
        /// <param name="IdConta">Show the Identification Code of the Account (id) which the created card belongs.</param>
        /// <param name="IdPessoa">Show the Identification Code of the Person (id) cardholder of the card created.</param>
        /// <param name="IdCartao">Show the Identification Code of the Card (id) that was created.</param>
        /// <param name="IdBandeira">Show the Identification Code of the Flag (id) which the Card belongs, when it is flagged.</param>
        /// <param name="IdTipoCartao">Show the Identification Code of the Type of Card (id) attributed to the card.</param>
        /// <param name="NumeroCartao">Show the card number.</param>
        /// <param name="NomePlastico">Show the name of the Cardholder.</param>
        /// <param name="Cvv2">Show the number of the CVV to be printed on the Card.</param>
        /// <param name="DataGeracao">Show the issue date of the card.</param>
        /// <param name="DataValidade">Show the Expiration date of the Card.</param>
        /// <param name="NomeOrigemComercial">Show the name of the Commercial Origin that created the register of the holder of the Account which the card belongs.</param>
        /// <param name="NomeEmpresa">Show the company name (Legal Person) holder of the card, when it is applicable.</param>
        /// <param name="NumeroAgencia">Show the number of the Agency to be printed on the Card, when it is applicable.</param>
        /// <param name="NumeroContaCorente">Show the Current Account Number to be printed on the Card, whe it is applicable.</param>
        /// <param name="NomeEmpresaBeneficio">Show the name of the Physical or Legal Person that hired services of benefit for the cardholder, when it is applicable.</param>
        /// <param name="Cpf">Show the CPF of the Cardholder.</param>
        /// <param name="TipoPortador">Show the Cardholder type of the card, being: (&#39;H&#39;: Holder, &#39;A&#39;: Additional).</param>
        /// <param name="NomeEmpregador">Show the name of the Legal or Physical Person to be printed on the card, when it is applicable.</param>
        /// <param name="Trilha1">Show the dates of the Trail1, following the rules of the issuer trail.</param>
        /// <param name="Trilha2">Show the dates of the Trail2, following the rules of the issuer trail.</param>
        /// <param name="TrilhaCVV1">Show the dates of TrailCVV01, following the rules of the issuer trail.</param>
        /// <param name="TrilhaCVV2">Show the dates of TrailCVV02, following the rules of the issuer trail.</param>
        /// <param name="FlagVirtual">Show the status that informs if the card is virtual.</param>
        /// <param name="NumeroCartaoHash">Show the hash number of the card.</param>

        public CartaoImpressaoResponse(long? IdConta = null, long? IdPessoa = null, long? IdCartao = null, long? IdBandeira = null, long? IdTipoCartao = null, string NumeroCartao = null, string NomePlastico = null, string Cvv2 = null, string DataGeracao = null, string DataValidade = null, string NomeOrigemComercial = null, string NomeEmpresa = null, int? NumeroAgencia = null, string NumeroContaCorente = null, string NomeEmpresaBeneficio = null, string Cpf = null, string TipoPortador = null, string NomeEmpregador = null, string Trilha1 = null, string Trilha2 = null, string TrilhaCVV1 = null, string TrilhaCVV2 = null, int? FlagVirtual = null, long? NumeroCartaoHash = null)
        {
            this.IdConta = IdConta;
            this.IdPessoa = IdPessoa;
            this.IdCartao = IdCartao;
            this.IdBandeira = IdBandeira;
            this.IdTipoCartao = IdTipoCartao;
            this.NumeroCartao = NumeroCartao;
            this.NomePlastico = NomePlastico;
            this.Cvv2 = Cvv2;
            this.DataGeracao = DataGeracao;
            this.DataValidade = DataValidade;
            this.NomeOrigemComercial = NomeOrigemComercial;
            this.NomeEmpresa = NomeEmpresa;
            this.NumeroAgencia = NumeroAgencia;
            this.NumeroContaCorente = NumeroContaCorente;
            this.NomeEmpresaBeneficio = NomeEmpresaBeneficio;
            this.Cpf = Cpf;
            this.TipoPortador = TipoPortador;
            this.NomeEmpregador = NomeEmpregador;
            this.Trilha1 = Trilha1;
            this.Trilha2 = Trilha2;
            this.TrilhaCVV1 = TrilhaCVV1;
            this.TrilhaCVV2 = TrilhaCVV2;
            this.FlagVirtual = FlagVirtual;
            this.NumeroCartaoHash = NumeroCartaoHash;
            
        }
        
    
        /// <summary>
        /// Show the Identification Code of the Account (id) which the created card belongs
        /// </summary>
        /// <value>Show the Identification Code of the Account (id) which the created card belongs</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Show the Identification Code of the Person (id) cardholder of the card created
        /// </summary>
        /// <value>Show the Identification Code of the Person (id) cardholder of the card created</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// Show the Identification Code of the Card (id) that was created
        /// </summary>
        /// <value>Show the Identification Code of the Card (id) that was created</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// Show the Identification Code of the Flag (id) which the Card belongs, when it is flagged
        /// </summary>
        /// <value>Show the Identification Code of the Flag (id) which the Card belongs, when it is flagged</value>
        [DataMember(Name="idBandeira", EmitDefaultValue=false)]
        public long? IdBandeira { get; set; }
    
        /// <summary>
        /// Show the Identification Code of the Type of Card (id) attributed to the card
        /// </summary>
        /// <value>Show the Identification Code of the Type of Card (id) attributed to the card</value>
        [DataMember(Name="idTipoCartao", EmitDefaultValue=false)]
        public long? IdTipoCartao { get; set; }
    
        /// <summary>
        /// Show the card number
        /// </summary>
        /// <value>Show the card number</value>
        [DataMember(Name="numeroCartao", EmitDefaultValue=false)]
        public string NumeroCartao { get; set; }
    
        /// <summary>
        /// Show the name of the Cardholder
        /// </summary>
        /// <value>Show the name of the Cardholder</value>
        [DataMember(Name="nomePlastico", EmitDefaultValue=false)]
        public string NomePlastico { get; set; }
    
        /// <summary>
        /// Show the number of the CVV to be printed on the Card
        /// </summary>
        /// <value>Show the number of the CVV to be printed on the Card</value>
        [DataMember(Name="cvv2", EmitDefaultValue=false)]
        public string Cvv2 { get; set; }
    
        /// <summary>
        /// Show the issue date of the card
        /// </summary>
        /// <value>Show the issue date of the card</value>
        [DataMember(Name="dataGeracao", EmitDefaultValue=false)]
        public string DataGeracao { get; set; }
    
        /// <summary>
        /// Show the Expiration date of the Card
        /// </summary>
        /// <value>Show the Expiration date of the Card</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
    
        /// <summary>
        /// Show the name of the Commercial Origin that created the register of the holder of the Account which the card belongs
        /// </summary>
        /// <value>Show the name of the Commercial Origin that created the register of the holder of the Account which the card belongs</value>
        [DataMember(Name="nomeOrigemComercial", EmitDefaultValue=false)]
        public string NomeOrigemComercial { get; set; }
    
        /// <summary>
        /// Show the company name (Legal Person) holder of the card, when it is applicable
        /// </summary>
        /// <value>Show the company name (Legal Person) holder of the card, when it is applicable</value>
        [DataMember(Name="nomeEmpresa", EmitDefaultValue=false)]
        public string NomeEmpresa { get; set; }
    
        /// <summary>
        /// Show the number of the Agency to be printed on the Card, when it is applicable
        /// </summary>
        /// <value>Show the number of the Agency to be printed on the Card, when it is applicable</value>
        [DataMember(Name="numeroAgencia", EmitDefaultValue=false)]
        public int? NumeroAgencia { get; set; }
    
        /// <summary>
        /// Show the Current Account Number to be printed on the Card, whe it is applicable
        /// </summary>
        /// <value>Show the Current Account Number to be printed on the Card, whe it is applicable</value>
        [DataMember(Name="numeroContaCorente", EmitDefaultValue=false)]
        public string NumeroContaCorente { get; set; }
    
        /// <summary>
        /// Show the name of the Physical or Legal Person that hired services of benefit for the cardholder, when it is applicable
        /// </summary>
        /// <value>Show the name of the Physical or Legal Person that hired services of benefit for the cardholder, when it is applicable</value>
        [DataMember(Name="nomeEmpresaBeneficio", EmitDefaultValue=false)]
        public string NomeEmpresaBeneficio { get; set; }
    
        /// <summary>
        /// Show the CPF of the Cardholder
        /// </summary>
        /// <value>Show the CPF of the Cardholder</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// Show the Cardholder type of the card, being: (&#39;H&#39;: Holder, &#39;A&#39;: Additional)
        /// </summary>
        /// <value>Show the Cardholder type of the card, being: (&#39;H&#39;: Holder, &#39;A&#39;: Additional)</value>
        [DataMember(Name="tipoPortador", EmitDefaultValue=false)]
        public string TipoPortador { get; set; }
    
        /// <summary>
        /// Show the name of the Legal or Physical Person to be printed on the card, when it is applicable
        /// </summary>
        /// <value>Show the name of the Legal or Physical Person to be printed on the card, when it is applicable</value>
        [DataMember(Name="nomeEmpregador", EmitDefaultValue=false)]
        public string NomeEmpregador { get; set; }
    
        /// <summary>
        /// Show the dates of the Trail1, following the rules of the issuer trail
        /// </summary>
        /// <value>Show the dates of the Trail1, following the rules of the issuer trail</value>
        [DataMember(Name="trilha1", EmitDefaultValue=false)]
        public string Trilha1 { get; set; }
    
        /// <summary>
        /// Show the dates of the Trail2, following the rules of the issuer trail
        /// </summary>
        /// <value>Show the dates of the Trail2, following the rules of the issuer trail</value>
        [DataMember(Name="trilha2", EmitDefaultValue=false)]
        public string Trilha2 { get; set; }
    
        /// <summary>
        /// Show the dates of TrailCVV01, following the rules of the issuer trail
        /// </summary>
        /// <value>Show the dates of TrailCVV01, following the rules of the issuer trail</value>
        [DataMember(Name="trilhaCVV1", EmitDefaultValue=false)]
        public string TrilhaCVV1 { get; set; }
    
        /// <summary>
        /// Show the dates of TrailCVV02, following the rules of the issuer trail
        /// </summary>
        /// <value>Show the dates of TrailCVV02, following the rules of the issuer trail</value>
        [DataMember(Name="trilhaCVV2", EmitDefaultValue=false)]
        public string TrilhaCVV2 { get; set; }
    
        /// <summary>
        /// Show the status that informs if the card is virtual
        /// </summary>
        /// <value>Show the status that informs if the card is virtual</value>
        [DataMember(Name="flagVirtual", EmitDefaultValue=false)]
        public int? FlagVirtual { get; set; }
    
        /// <summary>
        /// Show the hash number of the card
        /// </summary>
        /// <value>Show the hash number of the card</value>
        [DataMember(Name="numeroCartaoHash", EmitDefaultValue=false)]
        public long? NumeroCartaoHash { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartaoImpressaoResponse {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  IdBandeira: ").Append(IdBandeira).Append("\n");
            sb.Append("  IdTipoCartao: ").Append(IdTipoCartao).Append("\n");
            sb.Append("  NumeroCartao: ").Append(NumeroCartao).Append("\n");
            sb.Append("  NomePlastico: ").Append(NomePlastico).Append("\n");
            sb.Append("  Cvv2: ").Append(Cvv2).Append("\n");
            sb.Append("  DataGeracao: ").Append(DataGeracao).Append("\n");
            sb.Append("  DataValidade: ").Append(DataValidade).Append("\n");
            sb.Append("  NomeOrigemComercial: ").Append(NomeOrigemComercial).Append("\n");
            sb.Append("  NomeEmpresa: ").Append(NomeEmpresa).Append("\n");
            sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
            sb.Append("  NumeroContaCorente: ").Append(NumeroContaCorente).Append("\n");
            sb.Append("  NomeEmpresaBeneficio: ").Append(NomeEmpresaBeneficio).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  TipoPortador: ").Append(TipoPortador).Append("\n");
            sb.Append("  NomeEmpregador: ").Append(NomeEmpregador).Append("\n");
            sb.Append("  Trilha1: ").Append(Trilha1).Append("\n");
            sb.Append("  Trilha2: ").Append(Trilha2).Append("\n");
            sb.Append("  TrilhaCVV1: ").Append(TrilhaCVV1).Append("\n");
            sb.Append("  TrilhaCVV2: ").Append(TrilhaCVV2).Append("\n");
            sb.Append("  FlagVirtual: ").Append(FlagVirtual).Append("\n");
            sb.Append("  NumeroCartaoHash: ").Append(NumeroCartaoHash).Append("\n");
            
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
            return this.Equals(obj as CartaoImpressaoResponse);
        }

        /// <summary>
        /// Returns true if CartaoImpressaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CartaoImpressaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartaoImpressaoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.IdBandeira == other.IdBandeira ||
                    this.IdBandeira != null &&
                    this.IdBandeira.Equals(other.IdBandeira)
                ) && 
                (
                    this.IdTipoCartao == other.IdTipoCartao ||
                    this.IdTipoCartao != null &&
                    this.IdTipoCartao.Equals(other.IdTipoCartao)
                ) && 
                (
                    this.NumeroCartao == other.NumeroCartao ||
                    this.NumeroCartao != null &&
                    this.NumeroCartao.Equals(other.NumeroCartao)
                ) && 
                (
                    this.NomePlastico == other.NomePlastico ||
                    this.NomePlastico != null &&
                    this.NomePlastico.Equals(other.NomePlastico)
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
                    this.NomeOrigemComercial == other.NomeOrigemComercial ||
                    this.NomeOrigemComercial != null &&
                    this.NomeOrigemComercial.Equals(other.NomeOrigemComercial)
                ) && 
                (
                    this.NomeEmpresa == other.NomeEmpresa ||
                    this.NomeEmpresa != null &&
                    this.NomeEmpresa.Equals(other.NomeEmpresa)
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
                    this.NomeEmpresaBeneficio == other.NomeEmpresaBeneficio ||
                    this.NomeEmpresaBeneficio != null &&
                    this.NomeEmpresaBeneficio.Equals(other.NomeEmpresaBeneficio)
                ) && 
                (
                    this.Cpf == other.Cpf ||
                    this.Cpf != null &&
                    this.Cpf.Equals(other.Cpf)
                ) && 
                (
                    this.TipoPortador == other.TipoPortador ||
                    this.TipoPortador != null &&
                    this.TipoPortador.Equals(other.TipoPortador)
                ) && 
                (
                    this.NomeEmpregador == other.NomeEmpregador ||
                    this.NomeEmpregador != null &&
                    this.NomeEmpregador.Equals(other.NomeEmpregador)
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
                ) && 
                (
                    this.FlagVirtual == other.FlagVirtual ||
                    this.FlagVirtual != null &&
                    this.FlagVirtual.Equals(other.FlagVirtual)
                ) && 
                (
                    this.NumeroCartaoHash == other.NumeroCartaoHash ||
                    this.NumeroCartaoHash != null &&
                    this.NumeroCartaoHash.Equals(other.NumeroCartaoHash)
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
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.IdBandeira != null)
                    hash = hash * 59 + this.IdBandeira.GetHashCode();
                
                if (this.IdTipoCartao != null)
                    hash = hash * 59 + this.IdTipoCartao.GetHashCode();
                
                if (this.NumeroCartao != null)
                    hash = hash * 59 + this.NumeroCartao.GetHashCode();
                
                if (this.NomePlastico != null)
                    hash = hash * 59 + this.NomePlastico.GetHashCode();
                
                if (this.Cvv2 != null)
                    hash = hash * 59 + this.Cvv2.GetHashCode();
                
                if (this.DataGeracao != null)
                    hash = hash * 59 + this.DataGeracao.GetHashCode();
                
                if (this.DataValidade != null)
                    hash = hash * 59 + this.DataValidade.GetHashCode();
                
                if (this.NomeOrigemComercial != null)
                    hash = hash * 59 + this.NomeOrigemComercial.GetHashCode();
                
                if (this.NomeEmpresa != null)
                    hash = hash * 59 + this.NomeEmpresa.GetHashCode();
                
                if (this.NumeroAgencia != null)
                    hash = hash * 59 + this.NumeroAgencia.GetHashCode();
                
                if (this.NumeroContaCorente != null)
                    hash = hash * 59 + this.NumeroContaCorente.GetHashCode();
                
                if (this.NomeEmpresaBeneficio != null)
                    hash = hash * 59 + this.NomeEmpresaBeneficio.GetHashCode();
                
                if (this.Cpf != null)
                    hash = hash * 59 + this.Cpf.GetHashCode();
                
                if (this.TipoPortador != null)
                    hash = hash * 59 + this.TipoPortador.GetHashCode();
                
                if (this.NomeEmpregador != null)
                    hash = hash * 59 + this.NomeEmpregador.GetHashCode();
                
                if (this.Trilha1 != null)
                    hash = hash * 59 + this.Trilha1.GetHashCode();
                
                if (this.Trilha2 != null)
                    hash = hash * 59 + this.Trilha2.GetHashCode();
                
                if (this.TrilhaCVV1 != null)
                    hash = hash * 59 + this.TrilhaCVV1.GetHashCode();
                
                if (this.TrilhaCVV2 != null)
                    hash = hash * 59 + this.TrilhaCVV2.GetHashCode();
                
                if (this.FlagVirtual != null)
                    hash = hash * 59 + this.FlagVirtual.GetHashCode();
                
                if (this.NumeroCartaoHash != null)
                    hash = hash * 59 + this.NumeroCartaoHash.GetHashCode();
                
                return hash;
            }
        }

    }
}
