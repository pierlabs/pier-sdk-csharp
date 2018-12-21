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
    /// Request Parameters of a Merchant
    /// </summary>
    [DataContract]
    public partial class EstabelecimentoUpdate :  IEquatable<EstabelecimentoUpdate>
    { 
    
        /// <summary>
        /// Regime type of the merchant payment
        /// </summary>
        /// <value>Regime type of the merchant payment</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TipoPagamentoEnum {
            
            [EnumMember(Value = "CENTRALIZADO")]
            Centralizado,
            
            [EnumMember(Value = "PV")]
            Pv
        }

    
        /// <summary>
        /// Regime type of the merchant payment
        /// </summary>
        /// <value>Regime type of the merchant payment</value>
        [DataMember(Name="tipoPagamento", EmitDefaultValue=false)]
        public TipoPagamentoEnum? TipoPagamento { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EstabelecimentoUpdate" /> class.
        /// Initializes a new instance of the <see cref="EstabelecimentoUpdate" />class.
        /// </summary>
        /// <param name="FlagMatriz">Indicate if it is headquarters or Branch.</param>
        /// <param name="Nome">Merchant Name.</param>
        /// <param name="Descricao">Merchant Social Reason.</param>
        /// <param name="NomeFantasia">Commercial Title of the Merchant.</param>
        /// <param name="Cep">Merchant CEP.</param>
        /// <param name="NomeLogradouro">Name of the street.</param>
        /// <param name="NumeroEndereco">Address Number.</param>
        /// <param name="Bairro">Neighborhood address.</param>
        /// <param name="Cidade">Address City Name.</param>
        /// <param name="Complemento">Complementary descriptions referring to the address.</param>
        /// <param name="Uf">Acronym of the Federal Unity Identification of the address.</param>
        /// <param name="Cep2">Merchant CEP.</param>
        /// <param name="NomeLogradouro2">Street Name.</param>
        /// <param name="NumeroEndereco2">Address Number.</param>
        /// <param name="Bairro2">Neighborhood address.</param>
        /// <param name="Cidade2">Address City Name.</param>
        /// <param name="Complemento2">Complementary Descriptions refering to the address.</param>
        /// <param name="Uf2">Acronym of the Federal Unity Address identification.</param>
        /// <param name="Obs">Specific Details to the merchant register.</param>
        /// <param name="Contato">Name of the person to contact with the Merchant.</param>
        /// <param name="Email">E-mail of the person to contact with the Merchant.</param>
        /// <param name="FlagArquivoSecrFazenda">Indicate if the merchant will be included in the register file for the State Treasury Secretary.</param>
        /// <param name="FlagCartaoDigitado">Indicate if the merchant can originate transactions without the reading of the magnetic stripe or the card chip.</param>
        /// <param name="Inativo">Indicate if the merchant is inactive.</param>
        /// <param name="IdMoeda">Identifier Code of the Currency.</param>
        /// <param name="IdPais">Identifier of the country.</param>
        /// <param name="AssociadoSPCBrasil">Number of the associated to the SPCBrasil.</param>
        /// <param name="Mcc">Merchant Category Code.</param>
        /// <param name="IdTipoEstabelecimento">Identification Code of the Merchant Type.</param>
        /// <param name="Correspondencia">Indicator which address the mails are sent, where 1 is ORIGIN and 2 MAIL ADDRESS.</param>
        /// <param name="CargoContato">Occupation of the Merchant Contact.</param>
        /// <param name="TipoPagamento">Regime type of the merchant payment.</param>
        /// <param name="Consulta">Retrieve the register number one.</param>
        /// <param name="Consulta2">Retrieve the register number two.</param>
        /// <param name="Consulta3">Retrieve the register number three.</param>

        public EstabelecimentoUpdate(int? FlagMatriz = null, string Nome = null, string Descricao = null, string NomeFantasia = null, string Cep = null, string NomeLogradouro = null, int? NumeroEndereco = null, string Bairro = null, string Cidade = null, string Complemento = null, string Uf = null, string Cep2 = null, string NomeLogradouro2 = null, int? NumeroEndereco2 = null, string Bairro2 = null, string Cidade2 = null, string Complemento2 = null, string Uf2 = null, string Obs = null, string Contato = null, string Email = null, int? FlagArquivoSecrFazenda = null, int? FlagCartaoDigitado = null, int? Inativo = null, long? IdMoeda = null, long? IdPais = null, int? AssociadoSPCBrasil = null, long? Mcc = null, long? IdTipoEstabelecimento = null, int? Correspondencia = null, string CargoContato = null, TipoPagamentoEnum? TipoPagamento = null, ConsultaCadastroEstabelecimentoDTO Consulta = null, ConsultaCadastroEstabelecimentoDTO Consulta2 = null, ConsultaCadastroEstabelecimentoDTO Consulta3 = null)
        {
            this.FlagMatriz = FlagMatriz;
            this.Nome = Nome;
            this.Descricao = Descricao;
            this.NomeFantasia = NomeFantasia;
            this.Cep = Cep;
            this.NomeLogradouro = NomeLogradouro;
            this.NumeroEndereco = NumeroEndereco;
            this.Bairro = Bairro;
            this.Cidade = Cidade;
            this.Complemento = Complemento;
            this.Uf = Uf;
            this.Cep2 = Cep2;
            this.NomeLogradouro2 = NomeLogradouro2;
            this.NumeroEndereco2 = NumeroEndereco2;
            this.Bairro2 = Bairro2;
            this.Cidade2 = Cidade2;
            this.Complemento2 = Complemento2;
            this.Uf2 = Uf2;
            this.Obs = Obs;
            this.Contato = Contato;
            this.Email = Email;
            this.FlagArquivoSecrFazenda = FlagArquivoSecrFazenda;
            this.FlagCartaoDigitado = FlagCartaoDigitado;
            this.Inativo = Inativo;
            this.IdMoeda = IdMoeda;
            this.IdPais = IdPais;
            this.AssociadoSPCBrasil = AssociadoSPCBrasil;
            this.Mcc = Mcc;
            this.IdTipoEstabelecimento = IdTipoEstabelecimento;
            this.Correspondencia = Correspondencia;
            this.CargoContato = CargoContato;
            this.TipoPagamento = TipoPagamento;
            this.Consulta = Consulta;
            this.Consulta2 = Consulta2;
            this.Consulta3 = Consulta3;
            
        }
        
    
        /// <summary>
        /// Indicate if it is headquarters or Branch
        /// </summary>
        /// <value>Indicate if it is headquarters or Branch</value>
        [DataMember(Name="flagMatriz", EmitDefaultValue=false)]
        public int? FlagMatriz { get; set; }
    
        /// <summary>
        /// Merchant Name
        /// </summary>
        /// <value>Merchant Name</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Merchant Social Reason
        /// </summary>
        /// <value>Merchant Social Reason</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Commercial Title of the Merchant
        /// </summary>
        /// <value>Commercial Title of the Merchant</value>
        [DataMember(Name="nomeFantasia", EmitDefaultValue=false)]
        public string NomeFantasia { get; set; }
    
        /// <summary>
        /// Merchant CEP
        /// </summary>
        /// <value>Merchant CEP</value>
        [DataMember(Name="cep", EmitDefaultValue=false)]
        public string Cep { get; set; }
    
        /// <summary>
        /// Name of the street
        /// </summary>
        /// <value>Name of the street</value>
        [DataMember(Name="nomeLogradouro", EmitDefaultValue=false)]
        public string NomeLogradouro { get; set; }
    
        /// <summary>
        /// Address Number
        /// </summary>
        /// <value>Address Number</value>
        [DataMember(Name="numeroEndereco", EmitDefaultValue=false)]
        public int? NumeroEndereco { get; set; }
    
        /// <summary>
        /// Neighborhood address
        /// </summary>
        /// <value>Neighborhood address</value>
        [DataMember(Name="bairro", EmitDefaultValue=false)]
        public string Bairro { get; set; }
    
        /// <summary>
        /// Address City Name
        /// </summary>
        /// <value>Address City Name</value>
        [DataMember(Name="cidade", EmitDefaultValue=false)]
        public string Cidade { get; set; }
    
        /// <summary>
        /// Complementary descriptions referring to the address
        /// </summary>
        /// <value>Complementary descriptions referring to the address</value>
        [DataMember(Name="complemento", EmitDefaultValue=false)]
        public string Complemento { get; set; }
    
        /// <summary>
        /// Acronym of the Federal Unity Identification of the address
        /// </summary>
        /// <value>Acronym of the Federal Unity Identification of the address</value>
        [DataMember(Name="uf", EmitDefaultValue=false)]
        public string Uf { get; set; }
    
        /// <summary>
        /// Merchant CEP
        /// </summary>
        /// <value>Merchant CEP</value>
        [DataMember(Name="cep2", EmitDefaultValue=false)]
        public string Cep2 { get; set; }
    
        /// <summary>
        /// Street Name
        /// </summary>
        /// <value>Street Name</value>
        [DataMember(Name="nomeLogradouro2", EmitDefaultValue=false)]
        public string NomeLogradouro2 { get; set; }
    
        /// <summary>
        /// Address Number
        /// </summary>
        /// <value>Address Number</value>
        [DataMember(Name="numeroEndereco2", EmitDefaultValue=false)]
        public int? NumeroEndereco2 { get; set; }
    
        /// <summary>
        /// Neighborhood address
        /// </summary>
        /// <value>Neighborhood address</value>
        [DataMember(Name="bairro2", EmitDefaultValue=false)]
        public string Bairro2 { get; set; }
    
        /// <summary>
        /// Address City Name
        /// </summary>
        /// <value>Address City Name</value>
        [DataMember(Name="cidade2", EmitDefaultValue=false)]
        public string Cidade2 { get; set; }
    
        /// <summary>
        /// Complementary Descriptions refering to the address
        /// </summary>
        /// <value>Complementary Descriptions refering to the address</value>
        [DataMember(Name="complemento2", EmitDefaultValue=false)]
        public string Complemento2 { get; set; }
    
        /// <summary>
        /// Acronym of the Federal Unity Address identification
        /// </summary>
        /// <value>Acronym of the Federal Unity Address identification</value>
        [DataMember(Name="uf2", EmitDefaultValue=false)]
        public string Uf2 { get; set; }
    
        /// <summary>
        /// Specific Details to the merchant register
        /// </summary>
        /// <value>Specific Details to the merchant register</value>
        [DataMember(Name="obs", EmitDefaultValue=false)]
        public string Obs { get; set; }
    
        /// <summary>
        /// Name of the person to contact with the Merchant
        /// </summary>
        /// <value>Name of the person to contact with the Merchant</value>
        [DataMember(Name="contato", EmitDefaultValue=false)]
        public string Contato { get; set; }
    
        /// <summary>
        /// E-mail of the person to contact with the Merchant
        /// </summary>
        /// <value>E-mail of the person to contact with the Merchant</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Indicate if the merchant will be included in the register file for the State Treasury Secretary
        /// </summary>
        /// <value>Indicate if the merchant will be included in the register file for the State Treasury Secretary</value>
        [DataMember(Name="flagArquivoSecrFazenda", EmitDefaultValue=false)]
        public int? FlagArquivoSecrFazenda { get; set; }
    
        /// <summary>
        /// Indicate if the merchant can originate transactions without the reading of the magnetic stripe or the card chip
        /// </summary>
        /// <value>Indicate if the merchant can originate transactions without the reading of the magnetic stripe or the card chip</value>
        [DataMember(Name="flagCartaoDigitado", EmitDefaultValue=false)]
        public int? FlagCartaoDigitado { get; set; }
    
        /// <summary>
        /// Indicate if the merchant is inactive
        /// </summary>
        /// <value>Indicate if the merchant is inactive</value>
        [DataMember(Name="inativo", EmitDefaultValue=false)]
        public int? Inativo { get; set; }
    
        /// <summary>
        /// Identifier Code of the Currency
        /// </summary>
        /// <value>Identifier Code of the Currency</value>
        [DataMember(Name="idMoeda", EmitDefaultValue=false)]
        public long? IdMoeda { get; set; }
    
        /// <summary>
        /// Identifier of the country
        /// </summary>
        /// <value>Identifier of the country</value>
        [DataMember(Name="idPais", EmitDefaultValue=false)]
        public long? IdPais { get; set; }
    
        /// <summary>
        /// Number of the associated to the SPCBrasil
        /// </summary>
        /// <value>Number of the associated to the SPCBrasil</value>
        [DataMember(Name="associadoSPCBrasil", EmitDefaultValue=false)]
        public int? AssociadoSPCBrasil { get; set; }
    
        /// <summary>
        /// Merchant Category Code
        /// </summary>
        /// <value>Merchant Category Code</value>
        [DataMember(Name="mcc", EmitDefaultValue=false)]
        public long? Mcc { get; set; }
    
        /// <summary>
        /// Identification Code of the Merchant Type
        /// </summary>
        /// <value>Identification Code of the Merchant Type</value>
        [DataMember(Name="idTipoEstabelecimento", EmitDefaultValue=false)]
        public long? IdTipoEstabelecimento { get; set; }
    
        /// <summary>
        /// Indicator which address the mails are sent, where 1 is ORIGIN and 2 MAIL ADDRESS
        /// </summary>
        /// <value>Indicator which address the mails are sent, where 1 is ORIGIN and 2 MAIL ADDRESS</value>
        [DataMember(Name="correspondencia", EmitDefaultValue=false)]
        public int? Correspondencia { get; set; }
    
        /// <summary>
        /// Occupation of the Merchant Contact
        /// </summary>
        /// <value>Occupation of the Merchant Contact</value>
        [DataMember(Name="cargoContato", EmitDefaultValue=false)]
        public string CargoContato { get; set; }
    
        /// <summary>
        /// Retrieve the register number one
        /// </summary>
        /// <value>Retrieve the register number one</value>
        [DataMember(Name="consulta", EmitDefaultValue=false)]
        public ConsultaCadastroEstabelecimentoDTO Consulta { get; set; }
    
        /// <summary>
        /// Retrieve the register number two
        /// </summary>
        /// <value>Retrieve the register number two</value>
        [DataMember(Name="consulta2", EmitDefaultValue=false)]
        public ConsultaCadastroEstabelecimentoDTO Consulta2 { get; set; }
    
        /// <summary>
        /// Retrieve the register number three
        /// </summary>
        /// <value>Retrieve the register number three</value>
        [DataMember(Name="consulta3", EmitDefaultValue=false)]
        public ConsultaCadastroEstabelecimentoDTO Consulta3 { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EstabelecimentoUpdate {\n");
            sb.Append("  FlagMatriz: ").Append(FlagMatriz).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  NomeFantasia: ").Append(NomeFantasia).Append("\n");
            sb.Append("  Cep: ").Append(Cep).Append("\n");
            sb.Append("  NomeLogradouro: ").Append(NomeLogradouro).Append("\n");
            sb.Append("  NumeroEndereco: ").Append(NumeroEndereco).Append("\n");
            sb.Append("  Bairro: ").Append(Bairro).Append("\n");
            sb.Append("  Cidade: ").Append(Cidade).Append("\n");
            sb.Append("  Complemento: ").Append(Complemento).Append("\n");
            sb.Append("  Uf: ").Append(Uf).Append("\n");
            sb.Append("  Cep2: ").Append(Cep2).Append("\n");
            sb.Append("  NomeLogradouro2: ").Append(NomeLogradouro2).Append("\n");
            sb.Append("  NumeroEndereco2: ").Append(NumeroEndereco2).Append("\n");
            sb.Append("  Bairro2: ").Append(Bairro2).Append("\n");
            sb.Append("  Cidade2: ").Append(Cidade2).Append("\n");
            sb.Append("  Complemento2: ").Append(Complemento2).Append("\n");
            sb.Append("  Uf2: ").Append(Uf2).Append("\n");
            sb.Append("  Obs: ").Append(Obs).Append("\n");
            sb.Append("  Contato: ").Append(Contato).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FlagArquivoSecrFazenda: ").Append(FlagArquivoSecrFazenda).Append("\n");
            sb.Append("  FlagCartaoDigitado: ").Append(FlagCartaoDigitado).Append("\n");
            sb.Append("  Inativo: ").Append(Inativo).Append("\n");
            sb.Append("  IdMoeda: ").Append(IdMoeda).Append("\n");
            sb.Append("  IdPais: ").Append(IdPais).Append("\n");
            sb.Append("  AssociadoSPCBrasil: ").Append(AssociadoSPCBrasil).Append("\n");
            sb.Append("  Mcc: ").Append(Mcc).Append("\n");
            sb.Append("  IdTipoEstabelecimento: ").Append(IdTipoEstabelecimento).Append("\n");
            sb.Append("  Correspondencia: ").Append(Correspondencia).Append("\n");
            sb.Append("  CargoContato: ").Append(CargoContato).Append("\n");
            sb.Append("  TipoPagamento: ").Append(TipoPagamento).Append("\n");
            sb.Append("  Consulta: ").Append(Consulta).Append("\n");
            sb.Append("  Consulta2: ").Append(Consulta2).Append("\n");
            sb.Append("  Consulta3: ").Append(Consulta3).Append("\n");
            
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
            return this.Equals(obj as EstabelecimentoUpdate);
        }

        /// <summary>
        /// Returns true if EstabelecimentoUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of EstabelecimentoUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EstabelecimentoUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FlagMatriz == other.FlagMatriz ||
                    this.FlagMatriz != null &&
                    this.FlagMatriz.Equals(other.FlagMatriz)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.NomeFantasia == other.NomeFantasia ||
                    this.NomeFantasia != null &&
                    this.NomeFantasia.Equals(other.NomeFantasia)
                ) && 
                (
                    this.Cep == other.Cep ||
                    this.Cep != null &&
                    this.Cep.Equals(other.Cep)
                ) && 
                (
                    this.NomeLogradouro == other.NomeLogradouro ||
                    this.NomeLogradouro != null &&
                    this.NomeLogradouro.Equals(other.NomeLogradouro)
                ) && 
                (
                    this.NumeroEndereco == other.NumeroEndereco ||
                    this.NumeroEndereco != null &&
                    this.NumeroEndereco.Equals(other.NumeroEndereco)
                ) && 
                (
                    this.Bairro == other.Bairro ||
                    this.Bairro != null &&
                    this.Bairro.Equals(other.Bairro)
                ) && 
                (
                    this.Cidade == other.Cidade ||
                    this.Cidade != null &&
                    this.Cidade.Equals(other.Cidade)
                ) && 
                (
                    this.Complemento == other.Complemento ||
                    this.Complemento != null &&
                    this.Complemento.Equals(other.Complemento)
                ) && 
                (
                    this.Uf == other.Uf ||
                    this.Uf != null &&
                    this.Uf.Equals(other.Uf)
                ) && 
                (
                    this.Cep2 == other.Cep2 ||
                    this.Cep2 != null &&
                    this.Cep2.Equals(other.Cep2)
                ) && 
                (
                    this.NomeLogradouro2 == other.NomeLogradouro2 ||
                    this.NomeLogradouro2 != null &&
                    this.NomeLogradouro2.Equals(other.NomeLogradouro2)
                ) && 
                (
                    this.NumeroEndereco2 == other.NumeroEndereco2 ||
                    this.NumeroEndereco2 != null &&
                    this.NumeroEndereco2.Equals(other.NumeroEndereco2)
                ) && 
                (
                    this.Bairro2 == other.Bairro2 ||
                    this.Bairro2 != null &&
                    this.Bairro2.Equals(other.Bairro2)
                ) && 
                (
                    this.Cidade2 == other.Cidade2 ||
                    this.Cidade2 != null &&
                    this.Cidade2.Equals(other.Cidade2)
                ) && 
                (
                    this.Complemento2 == other.Complemento2 ||
                    this.Complemento2 != null &&
                    this.Complemento2.Equals(other.Complemento2)
                ) && 
                (
                    this.Uf2 == other.Uf2 ||
                    this.Uf2 != null &&
                    this.Uf2.Equals(other.Uf2)
                ) && 
                (
                    this.Obs == other.Obs ||
                    this.Obs != null &&
                    this.Obs.Equals(other.Obs)
                ) && 
                (
                    this.Contato == other.Contato ||
                    this.Contato != null &&
                    this.Contato.Equals(other.Contato)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.FlagArquivoSecrFazenda == other.FlagArquivoSecrFazenda ||
                    this.FlagArquivoSecrFazenda != null &&
                    this.FlagArquivoSecrFazenda.Equals(other.FlagArquivoSecrFazenda)
                ) && 
                (
                    this.FlagCartaoDigitado == other.FlagCartaoDigitado ||
                    this.FlagCartaoDigitado != null &&
                    this.FlagCartaoDigitado.Equals(other.FlagCartaoDigitado)
                ) && 
                (
                    this.Inativo == other.Inativo ||
                    this.Inativo != null &&
                    this.Inativo.Equals(other.Inativo)
                ) && 
                (
                    this.IdMoeda == other.IdMoeda ||
                    this.IdMoeda != null &&
                    this.IdMoeda.Equals(other.IdMoeda)
                ) && 
                (
                    this.IdPais == other.IdPais ||
                    this.IdPais != null &&
                    this.IdPais.Equals(other.IdPais)
                ) && 
                (
                    this.AssociadoSPCBrasil == other.AssociadoSPCBrasil ||
                    this.AssociadoSPCBrasil != null &&
                    this.AssociadoSPCBrasil.Equals(other.AssociadoSPCBrasil)
                ) && 
                (
                    this.Mcc == other.Mcc ||
                    this.Mcc != null &&
                    this.Mcc.Equals(other.Mcc)
                ) && 
                (
                    this.IdTipoEstabelecimento == other.IdTipoEstabelecimento ||
                    this.IdTipoEstabelecimento != null &&
                    this.IdTipoEstabelecimento.Equals(other.IdTipoEstabelecimento)
                ) && 
                (
                    this.Correspondencia == other.Correspondencia ||
                    this.Correspondencia != null &&
                    this.Correspondencia.Equals(other.Correspondencia)
                ) && 
                (
                    this.CargoContato == other.CargoContato ||
                    this.CargoContato != null &&
                    this.CargoContato.Equals(other.CargoContato)
                ) && 
                (
                    this.TipoPagamento == other.TipoPagamento ||
                    this.TipoPagamento != null &&
                    this.TipoPagamento.Equals(other.TipoPagamento)
                ) && 
                (
                    this.Consulta == other.Consulta ||
                    this.Consulta != null &&
                    this.Consulta.Equals(other.Consulta)
                ) && 
                (
                    this.Consulta2 == other.Consulta2 ||
                    this.Consulta2 != null &&
                    this.Consulta2.Equals(other.Consulta2)
                ) && 
                (
                    this.Consulta3 == other.Consulta3 ||
                    this.Consulta3 != null &&
                    this.Consulta3.Equals(other.Consulta3)
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
                
                if (this.FlagMatriz != null)
                    hash = hash * 59 + this.FlagMatriz.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.NomeFantasia != null)
                    hash = hash * 59 + this.NomeFantasia.GetHashCode();
                
                if (this.Cep != null)
                    hash = hash * 59 + this.Cep.GetHashCode();
                
                if (this.NomeLogradouro != null)
                    hash = hash * 59 + this.NomeLogradouro.GetHashCode();
                
                if (this.NumeroEndereco != null)
                    hash = hash * 59 + this.NumeroEndereco.GetHashCode();
                
                if (this.Bairro != null)
                    hash = hash * 59 + this.Bairro.GetHashCode();
                
                if (this.Cidade != null)
                    hash = hash * 59 + this.Cidade.GetHashCode();
                
                if (this.Complemento != null)
                    hash = hash * 59 + this.Complemento.GetHashCode();
                
                if (this.Uf != null)
                    hash = hash * 59 + this.Uf.GetHashCode();
                
                if (this.Cep2 != null)
                    hash = hash * 59 + this.Cep2.GetHashCode();
                
                if (this.NomeLogradouro2 != null)
                    hash = hash * 59 + this.NomeLogradouro2.GetHashCode();
                
                if (this.NumeroEndereco2 != null)
                    hash = hash * 59 + this.NumeroEndereco2.GetHashCode();
                
                if (this.Bairro2 != null)
                    hash = hash * 59 + this.Bairro2.GetHashCode();
                
                if (this.Cidade2 != null)
                    hash = hash * 59 + this.Cidade2.GetHashCode();
                
                if (this.Complemento2 != null)
                    hash = hash * 59 + this.Complemento2.GetHashCode();
                
                if (this.Uf2 != null)
                    hash = hash * 59 + this.Uf2.GetHashCode();
                
                if (this.Obs != null)
                    hash = hash * 59 + this.Obs.GetHashCode();
                
                if (this.Contato != null)
                    hash = hash * 59 + this.Contato.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.FlagArquivoSecrFazenda != null)
                    hash = hash * 59 + this.FlagArquivoSecrFazenda.GetHashCode();
                
                if (this.FlagCartaoDigitado != null)
                    hash = hash * 59 + this.FlagCartaoDigitado.GetHashCode();
                
                if (this.Inativo != null)
                    hash = hash * 59 + this.Inativo.GetHashCode();
                
                if (this.IdMoeda != null)
                    hash = hash * 59 + this.IdMoeda.GetHashCode();
                
                if (this.IdPais != null)
                    hash = hash * 59 + this.IdPais.GetHashCode();
                
                if (this.AssociadoSPCBrasil != null)
                    hash = hash * 59 + this.AssociadoSPCBrasil.GetHashCode();
                
                if (this.Mcc != null)
                    hash = hash * 59 + this.Mcc.GetHashCode();
                
                if (this.IdTipoEstabelecimento != null)
                    hash = hash * 59 + this.IdTipoEstabelecimento.GetHashCode();
                
                if (this.Correspondencia != null)
                    hash = hash * 59 + this.Correspondencia.GetHashCode();
                
                if (this.CargoContato != null)
                    hash = hash * 59 + this.CargoContato.GetHashCode();
                
                if (this.TipoPagamento != null)
                    hash = hash * 59 + this.TipoPagamento.GetHashCode();
                
                if (this.Consulta != null)
                    hash = hash * 59 + this.Consulta.GetHashCode();
                
                if (this.Consulta2 != null)
                    hash = hash * 59 + this.Consulta2.GetHashCode();
                
                if (this.Consulta3 != null)
                    hash = hash * 59 + this.Consulta3.GetHashCode();
                
                return hash;
            }
        }

    }
}
