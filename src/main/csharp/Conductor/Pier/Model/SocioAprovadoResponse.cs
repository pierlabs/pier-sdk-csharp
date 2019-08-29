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
    /// PessoaPersist
    /// </summary>
    [DataContract]
    public partial class SocioAprovadoResponse :  IEquatable<SocioAprovadoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SocioAprovadoResponse" /> class.
        /// Initializes a new instance of the <see cref="SocioAprovadoResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo de Identifica\u00E7\u00E3o do S\u00F3cio.</param>
        /// <param name="Nome">Nome do Socio.</param>
        /// <param name="Cpf">CPF do s\u00F3cio.</param>
        /// <param name="DataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ..</param>
        /// <param name="Sexo">C\u00F3digo de identifica\u00E7\u00E3o do sexo da pessoa, quando for PF, sendo: (&#39;M&#39;: Masculino), (&#39;F&#39;: F\u00EAmea), (&#39;O&#39;: Outros), (&#39;N&#39;: N\u00E3o Especificado).</param>
        /// <param name="NumeroIdentidade">N\u00FAmero da Identidade.</param>
        /// <param name="OrgaoExpedidorIdentidade">Org\u00E3o expedidor do RG.</param>
        /// <param name="UnidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade.</param>
        /// <param name="DataEmissaoIdentidade">Data emiss\u00E3o da Identidade.</param>
        /// <param name="EstadoCivil">Estado civil do s\u00F3cio.</param>
        /// <param name="Profissao">Profiss\u00E3o do s\u00F3cio.</param>
        /// <param name="Nacionalidade">Nacionalidade do s\u00F3cio.</param>
        /// <param name="Email">Email do s\u00F3cio.</param>
        /// <param name="FlagDeficienteVisual">Flag que identifica uma pessoa como deficiente visual.</param>
        /// <param name="Telefones">Telefones do s\u00F3cio.</param>

        public SocioAprovadoResponse(long? Id = null, string Nome = null, string Cpf = null, string DataNascimento = null, string Sexo = null, string NumeroIdentidade = null, string OrgaoExpedidorIdentidade = null, string UnidadeFederativaIdentidade = null, string DataEmissaoIdentidade = null, string EstadoCivil = null, string Profissao = null, string Nacionalidade = null, string Email = null, bool? FlagDeficienteVisual = null, List<TelefonePessoaAprovadaResponse> Telefones = null)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.DataNascimento = DataNascimento;
            this.Sexo = Sexo;
            this.NumeroIdentidade = NumeroIdentidade;
            this.OrgaoExpedidorIdentidade = OrgaoExpedidorIdentidade;
            this.UnidadeFederativaIdentidade = UnidadeFederativaIdentidade;
            this.DataEmissaoIdentidade = DataEmissaoIdentidade;
            this.EstadoCivil = EstadoCivil;
            this.Profissao = Profissao;
            this.Nacionalidade = Nacionalidade;
            this.Email = Email;
            this.FlagDeficienteVisual = FlagDeficienteVisual;
            this.Telefones = Telefones;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do S\u00F3cio
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do S\u00F3cio</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Nome do Socio
        /// </summary>
        /// <value>Nome do Socio</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// CPF do s\u00F3cio
        /// </summary>
        /// <value>CPF do s\u00F3cio</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ.
        /// </summary>
        /// <value>Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ.</value>
        [DataMember(Name="dataNascimento", EmitDefaultValue=false)]
        public string DataNascimento { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do sexo da pessoa, quando for PF, sendo: (&#39;M&#39;: Masculino), (&#39;F&#39;: F\u00EAmea), (&#39;O&#39;: Outros), (&#39;N&#39;: N\u00E3o Especificado)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do sexo da pessoa, quando for PF, sendo: (&#39;M&#39;: Masculino), (&#39;F&#39;: F\u00EAmea), (&#39;O&#39;: Outros), (&#39;N&#39;: N\u00E3o Especificado)</value>
        [DataMember(Name="sexo", EmitDefaultValue=false)]
        public string Sexo { get; set; }
    
        /// <summary>
        /// N\u00FAmero da Identidade
        /// </summary>
        /// <value>N\u00FAmero da Identidade</value>
        [DataMember(Name="numeroIdentidade", EmitDefaultValue=false)]
        public string NumeroIdentidade { get; set; }
    
        /// <summary>
        /// Org\u00E3o expedidor do RG
        /// </summary>
        /// <value>Org\u00E3o expedidor do RG</value>
        [DataMember(Name="orgaoExpedidorIdentidade", EmitDefaultValue=false)]
        public string OrgaoExpedidorIdentidade { get; set; }
    
        /// <summary>
        /// Sigla da Unidade Federativa de onde foi expedido a Identidade
        /// </summary>
        /// <value>Sigla da Unidade Federativa de onde foi expedido a Identidade</value>
        [DataMember(Name="unidadeFederativaIdentidade", EmitDefaultValue=false)]
        public string UnidadeFederativaIdentidade { get; set; }
    
        /// <summary>
        /// Data emiss\u00E3o da Identidade
        /// </summary>
        /// <value>Data emiss\u00E3o da Identidade</value>
        [DataMember(Name="dataEmissaoIdentidade", EmitDefaultValue=false)]
        public string DataEmissaoIdentidade { get; set; }
    
        /// <summary>
        /// Estado civil do s\u00F3cio
        /// </summary>
        /// <value>Estado civil do s\u00F3cio</value>
        [DataMember(Name="estadoCivil", EmitDefaultValue=false)]
        public string EstadoCivil { get; set; }
    
        /// <summary>
        /// Profiss\u00E3o do s\u00F3cio
        /// </summary>
        /// <value>Profiss\u00E3o do s\u00F3cio</value>
        [DataMember(Name="profissao", EmitDefaultValue=false)]
        public string Profissao { get; set; }
    
        /// <summary>
        /// Nacionalidade do s\u00F3cio
        /// </summary>
        /// <value>Nacionalidade do s\u00F3cio</value>
        [DataMember(Name="nacionalidade", EmitDefaultValue=false)]
        public string Nacionalidade { get; set; }
    
        /// <summary>
        /// Email do s\u00F3cio
        /// </summary>
        /// <value>Email do s\u00F3cio</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Flag que identifica uma pessoa como deficiente visual
        /// </summary>
        /// <value>Flag que identifica uma pessoa como deficiente visual</value>
        [DataMember(Name="flagDeficienteVisual", EmitDefaultValue=false)]
        public bool? FlagDeficienteVisual { get; set; }
    
        /// <summary>
        /// Telefones do s\u00F3cio
        /// </summary>
        /// <value>Telefones do s\u00F3cio</value>
        [DataMember(Name="telefones", EmitDefaultValue=false)]
        public List<TelefonePessoaAprovadaResponse> Telefones { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SocioAprovadoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  DataNascimento: ").Append(DataNascimento).Append("\n");
            sb.Append("  Sexo: ").Append(Sexo).Append("\n");
            sb.Append("  NumeroIdentidade: ").Append(NumeroIdentidade).Append("\n");
            sb.Append("  OrgaoExpedidorIdentidade: ").Append(OrgaoExpedidorIdentidade).Append("\n");
            sb.Append("  UnidadeFederativaIdentidade: ").Append(UnidadeFederativaIdentidade).Append("\n");
            sb.Append("  DataEmissaoIdentidade: ").Append(DataEmissaoIdentidade).Append("\n");
            sb.Append("  EstadoCivil: ").Append(EstadoCivil).Append("\n");
            sb.Append("  Profissao: ").Append(Profissao).Append("\n");
            sb.Append("  Nacionalidade: ").Append(Nacionalidade).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FlagDeficienteVisual: ").Append(FlagDeficienteVisual).Append("\n");
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
            return this.Equals(obj as SocioAprovadoResponse);
        }

        /// <summary>
        /// Returns true if SocioAprovadoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SocioAprovadoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SocioAprovadoResponse other)
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
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.Cpf == other.Cpf ||
                    this.Cpf != null &&
                    this.Cpf.Equals(other.Cpf)
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
                    this.EstadoCivil == other.EstadoCivil ||
                    this.EstadoCivil != null &&
                    this.EstadoCivil.Equals(other.EstadoCivil)
                ) && 
                (
                    this.Profissao == other.Profissao ||
                    this.Profissao != null &&
                    this.Profissao.Equals(other.Profissao)
                ) && 
                (
                    this.Nacionalidade == other.Nacionalidade ||
                    this.Nacionalidade != null &&
                    this.Nacionalidade.Equals(other.Nacionalidade)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.FlagDeficienteVisual == other.FlagDeficienteVisual ||
                    this.FlagDeficienteVisual != null &&
                    this.FlagDeficienteVisual.Equals(other.FlagDeficienteVisual)
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
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.Cpf != null)
                    hash = hash * 59 + this.Cpf.GetHashCode();
                
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
                
                if (this.EstadoCivil != null)
                    hash = hash * 59 + this.EstadoCivil.GetHashCode();
                
                if (this.Profissao != null)
                    hash = hash * 59 + this.Profissao.GetHashCode();
                
                if (this.Nacionalidade != null)
                    hash = hash * 59 + this.Nacionalidade.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.FlagDeficienteVisual != null)
                    hash = hash * 59 + this.FlagDeficienteVisual.GetHashCode();
                
                if (this.Telefones != null)
                    hash = hash * 59 + this.Telefones.GetHashCode();
                
                return hash;
            }
        }

    }
}
