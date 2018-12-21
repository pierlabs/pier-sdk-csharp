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
    /// Response of the additional detail register resource
    /// </summary>
    [DataContract]
    public partial class AdicionalDetalheResponse :  IEquatable<AdicionalDetalheResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdicionalDetalheResponse" /> class.
        /// Initializes a new instance of the <see cref="AdicionalDetalheResponse" />class.
        /// </summary>
        /// <param name="IdConta">Identification Code of the account for the register of the additional.</param>
        /// <param name="IdPessoa">Identification Code of the Additional Person.</param>
        /// <param name="Nome">Additional Full name.</param>
        /// <param name="NomeImpresso">Name of the Additional that will be recorded on the card.</param>
        /// <param name="NumeroReceitaFederal">Number of CPF or CNPJ of the Additional.</param>
        /// <param name="DataNascimento">Birth date of the Additional.</param>
        /// <param name="Sexo">Identification Code of the person sex, when PP, being: (&#39;M&#39;: Male), (&#39;F&#39;: Female), (&#39;O&#39;: Other), (&#39;N&#39;: Not specified).</param>
        /// <param name="NumeroIdentidade">Number of the Identity Document of the Additional.</param>
        /// <param name="OrgaoExpedidorIdentidade">Name of the Consignor Organ of the Identity of the Additional.</param>
        /// <param name="UnidadeFederativaIdentidade">Acronym of the Federal Unity where the Identity document of the Additional was issued.</param>
        /// <param name="DataEmissaoIdentidade">Date of issue of the Identity document of the Additional.</param>
        /// <param name="IdEstadoCivil">Identification Code of Marital Status of the Additional.</param>
        /// <param name="IdProfissao">Identification Code of the Occupation of Additional.</param>
        /// <param name="IdNacionalidade">Identification Code of the Additional Nationality.</param>
        /// <param name="IdParentesco">Identification Code of parantage of the Additional with the holder.</param>
        /// <param name="Email">Identification Code of Kinship of the Additional with the holder.</param>
        /// <param name="FlagAtivo">Indicate if the additional is active =1 or inactive =0.</param>
        /// <param name="DataCadastroPortador">Indicate the date of the additional register.</param>
        /// <param name="DataCancelamentoPortador">Indicate the date of cancellation of the additional.</param>
        /// <param name="Telefones">List of the additional telephones.</param>

        public AdicionalDetalheResponse(long? IdConta = null, long? IdPessoa = null, string Nome = null, string NomeImpresso = null, string NumeroReceitaFederal = null, string DataNascimento = null, string Sexo = null, string NumeroIdentidade = null, string OrgaoExpedidorIdentidade = null, string UnidadeFederativaIdentidade = null, string DataEmissaoIdentidade = null, long? IdEstadoCivil = null, long? IdProfissao = null, long? IdNacionalidade = null, long? IdParentesco = null, string Email = null, int? FlagAtivo = null, string DataCadastroPortador = null, string DataCancelamentoPortador = null, List<TelefoneResponse> Telefones = null)
        {
            this.IdConta = IdConta;
            this.IdPessoa = IdPessoa;
            this.Nome = Nome;
            this.NomeImpresso = NomeImpresso;
            this.NumeroReceitaFederal = NumeroReceitaFederal;
            this.DataNascimento = DataNascimento;
            this.Sexo = Sexo;
            this.NumeroIdentidade = NumeroIdentidade;
            this.OrgaoExpedidorIdentidade = OrgaoExpedidorIdentidade;
            this.UnidadeFederativaIdentidade = UnidadeFederativaIdentidade;
            this.DataEmissaoIdentidade = DataEmissaoIdentidade;
            this.IdEstadoCivil = IdEstadoCivil;
            this.IdProfissao = IdProfissao;
            this.IdNacionalidade = IdNacionalidade;
            this.IdParentesco = IdParentesco;
            this.Email = Email;
            this.FlagAtivo = FlagAtivo;
            this.DataCadastroPortador = DataCadastroPortador;
            this.DataCancelamentoPortador = DataCancelamentoPortador;
            this.Telefones = Telefones;
            
        }
        
    
        /// <summary>
        /// Identification Code of the account for the register of the additional
        /// </summary>
        /// <value>Identification Code of the account for the register of the additional</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Identification Code of the Additional Person
        /// </summary>
        /// <value>Identification Code of the Additional Person</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// Additional Full name
        /// </summary>
        /// <value>Additional Full name</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Name of the Additional that will be recorded on the card
        /// </summary>
        /// <value>Name of the Additional that will be recorded on the card</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
        /// <summary>
        /// Number of CPF or CNPJ of the Additional
        /// </summary>
        /// <value>Number of CPF or CNPJ of the Additional</value>
        [DataMember(Name="numeroReceitaFederal", EmitDefaultValue=false)]
        public string NumeroReceitaFederal { get; set; }
    
        /// <summary>
        /// Birth date of the Additional
        /// </summary>
        /// <value>Birth date of the Additional</value>
        [DataMember(Name="dataNascimento", EmitDefaultValue=false)]
        public string DataNascimento { get; set; }
    
        /// <summary>
        /// Identification Code of the person sex, when PP, being: (&#39;M&#39;: Male), (&#39;F&#39;: Female), (&#39;O&#39;: Other), (&#39;N&#39;: Not specified)
        /// </summary>
        /// <value>Identification Code of the person sex, when PP, being: (&#39;M&#39;: Male), (&#39;F&#39;: Female), (&#39;O&#39;: Other), (&#39;N&#39;: Not specified)</value>
        [DataMember(Name="sexo", EmitDefaultValue=false)]
        public string Sexo { get; set; }
    
        /// <summary>
        /// Number of the Identity Document of the Additional
        /// </summary>
        /// <value>Number of the Identity Document of the Additional</value>
        [DataMember(Name="numeroIdentidade", EmitDefaultValue=false)]
        public string NumeroIdentidade { get; set; }
    
        /// <summary>
        /// Name of the Consignor Organ of the Identity of the Additional
        /// </summary>
        /// <value>Name of the Consignor Organ of the Identity of the Additional</value>
        [DataMember(Name="orgaoExpedidorIdentidade", EmitDefaultValue=false)]
        public string OrgaoExpedidorIdentidade { get; set; }
    
        /// <summary>
        /// Acronym of the Federal Unity where the Identity document of the Additional was issued
        /// </summary>
        /// <value>Acronym of the Federal Unity where the Identity document of the Additional was issued</value>
        [DataMember(Name="unidadeFederativaIdentidade", EmitDefaultValue=false)]
        public string UnidadeFederativaIdentidade { get; set; }
    
        /// <summary>
        /// Date of issue of the Identity document of the Additional
        /// </summary>
        /// <value>Date of issue of the Identity document of the Additional</value>
        [DataMember(Name="dataEmissaoIdentidade", EmitDefaultValue=false)]
        public string DataEmissaoIdentidade { get; set; }
    
        /// <summary>
        /// Identification Code of Marital Status of the Additional
        /// </summary>
        /// <value>Identification Code of Marital Status of the Additional</value>
        [DataMember(Name="idEstadoCivil", EmitDefaultValue=false)]
        public long? IdEstadoCivil { get; set; }
    
        /// <summary>
        /// Identification Code of the Occupation of Additional
        /// </summary>
        /// <value>Identification Code of the Occupation of Additional</value>
        [DataMember(Name="idProfissao", EmitDefaultValue=false)]
        public long? IdProfissao { get; set; }
    
        /// <summary>
        /// Identification Code of the Additional Nationality
        /// </summary>
        /// <value>Identification Code of the Additional Nationality</value>
        [DataMember(Name="idNacionalidade", EmitDefaultValue=false)]
        public long? IdNacionalidade { get; set; }
    
        /// <summary>
        /// Identification Code of parantage of the Additional with the holder
        /// </summary>
        /// <value>Identification Code of parantage of the Additional with the holder</value>
        [DataMember(Name="idParentesco", EmitDefaultValue=false)]
        public long? IdParentesco { get; set; }
    
        /// <summary>
        /// Identification Code of Kinship of the Additional with the holder
        /// </summary>
        /// <value>Identification Code of Kinship of the Additional with the holder</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Indicate if the additional is active =1 or inactive =0
        /// </summary>
        /// <value>Indicate if the additional is active =1 or inactive =0</value>
        [DataMember(Name="flagAtivo", EmitDefaultValue=false)]
        public int? FlagAtivo { get; set; }
    
        /// <summary>
        /// Indicate the date of the additional register
        /// </summary>
        /// <value>Indicate the date of the additional register</value>
        [DataMember(Name="dataCadastroPortador", EmitDefaultValue=false)]
        public string DataCadastroPortador { get; set; }
    
        /// <summary>
        /// Indicate the date of cancellation of the additional
        /// </summary>
        /// <value>Indicate the date of cancellation of the additional</value>
        [DataMember(Name="dataCancelamentoPortador", EmitDefaultValue=false)]
        public string DataCancelamentoPortador { get; set; }
    
        /// <summary>
        /// List of the additional telephones
        /// </summary>
        /// <value>List of the additional telephones</value>
        [DataMember(Name="telefones", EmitDefaultValue=false)]
        public List<TelefoneResponse> Telefones { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdicionalDetalheResponse {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  NomeImpresso: ").Append(NomeImpresso).Append("\n");
            sb.Append("  NumeroReceitaFederal: ").Append(NumeroReceitaFederal).Append("\n");
            sb.Append("  DataNascimento: ").Append(DataNascimento).Append("\n");
            sb.Append("  Sexo: ").Append(Sexo).Append("\n");
            sb.Append("  NumeroIdentidade: ").Append(NumeroIdentidade).Append("\n");
            sb.Append("  OrgaoExpedidorIdentidade: ").Append(OrgaoExpedidorIdentidade).Append("\n");
            sb.Append("  UnidadeFederativaIdentidade: ").Append(UnidadeFederativaIdentidade).Append("\n");
            sb.Append("  DataEmissaoIdentidade: ").Append(DataEmissaoIdentidade).Append("\n");
            sb.Append("  IdEstadoCivil: ").Append(IdEstadoCivil).Append("\n");
            sb.Append("  IdProfissao: ").Append(IdProfissao).Append("\n");
            sb.Append("  IdNacionalidade: ").Append(IdNacionalidade).Append("\n");
            sb.Append("  IdParentesco: ").Append(IdParentesco).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FlagAtivo: ").Append(FlagAtivo).Append("\n");
            sb.Append("  DataCadastroPortador: ").Append(DataCadastroPortador).Append("\n");
            sb.Append("  DataCancelamentoPortador: ").Append(DataCancelamentoPortador).Append("\n");
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
            return this.Equals(obj as AdicionalDetalheResponse);
        }

        /// <summary>
        /// Returns true if AdicionalDetalheResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AdicionalDetalheResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdicionalDetalheResponse other)
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
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.NomeImpresso == other.NomeImpresso ||
                    this.NomeImpresso != null &&
                    this.NomeImpresso.Equals(other.NomeImpresso)
                ) && 
                (
                    this.NumeroReceitaFederal == other.NumeroReceitaFederal ||
                    this.NumeroReceitaFederal != null &&
                    this.NumeroReceitaFederal.Equals(other.NumeroReceitaFederal)
                ) && 
                (
                    this.DataNascimento == other.DataNascimento ||
                    this.DataNascimento != null &&
                    this.DataNascimento.Equals(other.DataNascimento)
                ) && 
                (
                    this.Sexo == other.Sexo ||
                    this.Sexo != null &&
                    this.Sexo.Equals(other.Sexo)
                ) && 
                (
                    this.NumeroIdentidade == other.NumeroIdentidade ||
                    this.NumeroIdentidade != null &&
                    this.NumeroIdentidade.Equals(other.NumeroIdentidade)
                ) && 
                (
                    this.OrgaoExpedidorIdentidade == other.OrgaoExpedidorIdentidade ||
                    this.OrgaoExpedidorIdentidade != null &&
                    this.OrgaoExpedidorIdentidade.Equals(other.OrgaoExpedidorIdentidade)
                ) && 
                (
                    this.UnidadeFederativaIdentidade == other.UnidadeFederativaIdentidade ||
                    this.UnidadeFederativaIdentidade != null &&
                    this.UnidadeFederativaIdentidade.Equals(other.UnidadeFederativaIdentidade)
                ) && 
                (
                    this.DataEmissaoIdentidade == other.DataEmissaoIdentidade ||
                    this.DataEmissaoIdentidade != null &&
                    this.DataEmissaoIdentidade.Equals(other.DataEmissaoIdentidade)
                ) && 
                (
                    this.IdEstadoCivil == other.IdEstadoCivil ||
                    this.IdEstadoCivil != null &&
                    this.IdEstadoCivil.Equals(other.IdEstadoCivil)
                ) && 
                (
                    this.IdProfissao == other.IdProfissao ||
                    this.IdProfissao != null &&
                    this.IdProfissao.Equals(other.IdProfissao)
                ) && 
                (
                    this.IdNacionalidade == other.IdNacionalidade ||
                    this.IdNacionalidade != null &&
                    this.IdNacionalidade.Equals(other.IdNacionalidade)
                ) && 
                (
                    this.IdParentesco == other.IdParentesco ||
                    this.IdParentesco != null &&
                    this.IdParentesco.Equals(other.IdParentesco)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.FlagAtivo == other.FlagAtivo ||
                    this.FlagAtivo != null &&
                    this.FlagAtivo.Equals(other.FlagAtivo)
                ) && 
                (
                    this.DataCadastroPortador == other.DataCadastroPortador ||
                    this.DataCadastroPortador != null &&
                    this.DataCadastroPortador.Equals(other.DataCadastroPortador)
                ) && 
                (
                    this.DataCancelamentoPortador == other.DataCancelamentoPortador ||
                    this.DataCancelamentoPortador != null &&
                    this.DataCancelamentoPortador.Equals(other.DataCancelamentoPortador)
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
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.NomeImpresso != null)
                    hash = hash * 59 + this.NomeImpresso.GetHashCode();
                
                if (this.NumeroReceitaFederal != null)
                    hash = hash * 59 + this.NumeroReceitaFederal.GetHashCode();
                
                if (this.DataNascimento != null)
                    hash = hash * 59 + this.DataNascimento.GetHashCode();
                
                if (this.Sexo != null)
                    hash = hash * 59 + this.Sexo.GetHashCode();
                
                if (this.NumeroIdentidade != null)
                    hash = hash * 59 + this.NumeroIdentidade.GetHashCode();
                
                if (this.OrgaoExpedidorIdentidade != null)
                    hash = hash * 59 + this.OrgaoExpedidorIdentidade.GetHashCode();
                
                if (this.UnidadeFederativaIdentidade != null)
                    hash = hash * 59 + this.UnidadeFederativaIdentidade.GetHashCode();
                
                if (this.DataEmissaoIdentidade != null)
                    hash = hash * 59 + this.DataEmissaoIdentidade.GetHashCode();
                
                if (this.IdEstadoCivil != null)
                    hash = hash * 59 + this.IdEstadoCivil.GetHashCode();
                
                if (this.IdProfissao != null)
                    hash = hash * 59 + this.IdProfissao.GetHashCode();
                
                if (this.IdNacionalidade != null)
                    hash = hash * 59 + this.IdNacionalidade.GetHashCode();
                
                if (this.IdParentesco != null)
                    hash = hash * 59 + this.IdParentesco.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.FlagAtivo != null)
                    hash = hash * 59 + this.FlagAtivo.GetHashCode();
                
                if (this.DataCadastroPortador != null)
                    hash = hash * 59 + this.DataCadastroPortador.GetHashCode();
                
                if (this.DataCancelamentoPortador != null)
                    hash = hash * 59 + this.DataCancelamentoPortador.GetHashCode();
                
                if (this.Telefones != null)
                    hash = hash * 59 + this.Telefones.GetHashCode();
                
                return hash;
            }
        }

    }
}
