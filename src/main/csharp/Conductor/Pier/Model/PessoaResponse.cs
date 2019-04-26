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
    /// Pessoa
    /// </summary>
    [DataContract]
    public partial class PessoaResponse :  IEquatable<PessoaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaResponse" /> class.
        /// Initializes a new instance of the <see cref="PessoaResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) (required).</param>
        /// <param name="Nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39; (required).</param>
        /// <param name="Tipo">C\u00F3digo de identifica\u00E7\u00E3o do tipo da Pessoa, sendo: (&#39;PF&#39;: Pessoa F\u00EDsica), (&#39;PJ&#39;: Pessoa Jur\u00EDdica) (required).</param>
        /// <param name="Cpf">N\u00FAmero do CPF, quando PF.</param>
        /// <param name="Cnpj">N\u00FAmero do CNPJ, quando PJ.</param>
        /// <param name="DataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ.</param>
        /// <param name="NumeroIdentidade">N\u00FAmero da Identidade.</param>
        /// <param name="OrgaoExpedidorIdentidade">Org\u00E3o expedidor do RG.</param>
        /// <param name="Sexo">C\u00F3digo de identifica\u00E7\u00E3o do sexo da Pessoa, quando PF, sendo: (&#39;M&#39;: Masculino), (&#39;F&#39;: Feminino), (&#39;O&#39;: Outro), (&#39;N&#39;: N\u00E3o Especificado).</param>
        /// <param name="UnidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade.</param>
        /// <param name="DataEmissaoIdentidade">Data emiss\u00E3o da identidade no formato aaaa-MM-dd.</param>

        public PessoaResponse(long? Id = null, string Nome = null, string Tipo = null, string Cpf = null, string Cnpj = null, string DataNascimento = null, string NumeroIdentidade = null, string OrgaoExpedidorIdentidade = null, string Sexo = null, string UnidadeFederativaIdentidade = null, string DataEmissaoIdentidade = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for PessoaResponse and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Nome" is required (not null)
            if (Nome == null)
            {
                throw new InvalidDataException("Nome is a required property for PessoaResponse and cannot be null");
            }
            else
            {
                this.Nome = Nome;
            }
            // to ensure "Tipo" is required (not null)
            if (Tipo == null)
            {
                throw new InvalidDataException("Tipo is a required property for PessoaResponse and cannot be null");
            }
            else
            {
                this.Tipo = Tipo;
            }
            this.Cpf = Cpf;
            this.Cnpj = Cnpj;
            this.DataNascimento = DataNascimento;
            this.NumeroIdentidade = NumeroIdentidade;
            this.OrgaoExpedidorIdentidade = OrgaoExpedidorIdentidade;
            this.Sexo = Sexo;
            this.UnidadeFederativaIdentidade = UnidadeFederativaIdentidade;
            this.DataEmissaoIdentidade = DataEmissaoIdentidade;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id)
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;
        /// </summary>
        /// <value>Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do tipo da Pessoa, sendo: (&#39;PF&#39;: Pessoa F\u00EDsica), (&#39;PJ&#39;: Pessoa Jur\u00EDdica)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do tipo da Pessoa, sendo: (&#39;PF&#39;: Pessoa F\u00EDsica), (&#39;PJ&#39;: Pessoa Jur\u00EDdica)</value>
        [DataMember(Name="tipo", EmitDefaultValue=false)]
        public string Tipo { get; set; }
    
        /// <summary>
        /// N\u00FAmero do CPF, quando PF
        /// </summary>
        /// <value>N\u00FAmero do CPF, quando PF</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// N\u00FAmero do CNPJ, quando PJ
        /// </summary>
        /// <value>N\u00FAmero do CNPJ, quando PJ</value>
        [DataMember(Name="cnpj", EmitDefaultValue=false)]
        public string Cnpj { get; set; }
    
        /// <summary>
        /// Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ
        /// </summary>
        /// <value>Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ</value>
        [DataMember(Name="dataNascimento", EmitDefaultValue=false)]
        public string DataNascimento { get; set; }
    
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
        /// C\u00F3digo de identifica\u00E7\u00E3o do sexo da Pessoa, quando PF, sendo: (&#39;M&#39;: Masculino), (&#39;F&#39;: Feminino), (&#39;O&#39;: Outro), (&#39;N&#39;: N\u00E3o Especificado)
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do sexo da Pessoa, quando PF, sendo: (&#39;M&#39;: Masculino), (&#39;F&#39;: Feminino), (&#39;O&#39;: Outro), (&#39;N&#39;: N\u00E3o Especificado)</value>
        [DataMember(Name="sexo", EmitDefaultValue=false)]
        public string Sexo { get; set; }
    
        /// <summary>
        /// Sigla da Unidade Federativa de onde foi expedido a Identidade
        /// </summary>
        /// <value>Sigla da Unidade Federativa de onde foi expedido a Identidade</value>
        [DataMember(Name="unidadeFederativaIdentidade", EmitDefaultValue=false)]
        public string UnidadeFederativaIdentidade { get; set; }
    
        /// <summary>
        /// Data emiss\u00E3o da identidade no formato aaaa-MM-dd
        /// </summary>
        /// <value>Data emiss\u00E3o da identidade no formato aaaa-MM-dd</value>
        [DataMember(Name="dataEmissaoIdentidade", EmitDefaultValue=false)]
        public string DataEmissaoIdentidade { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PessoaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Tipo: ").Append(Tipo).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  Cnpj: ").Append(Cnpj).Append("\n");
            sb.Append("  DataNascimento: ").Append(DataNascimento).Append("\n");
            sb.Append("  NumeroIdentidade: ").Append(NumeroIdentidade).Append("\n");
            sb.Append("  OrgaoExpedidorIdentidade: ").Append(OrgaoExpedidorIdentidade).Append("\n");
            sb.Append("  Sexo: ").Append(Sexo).Append("\n");
            sb.Append("  UnidadeFederativaIdentidade: ").Append(UnidadeFederativaIdentidade).Append("\n");
            sb.Append("  DataEmissaoIdentidade: ").Append(DataEmissaoIdentidade).Append("\n");
            
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
            return this.Equals(obj as PessoaResponse);
        }

        /// <summary>
        /// Returns true if PessoaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PessoaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PessoaResponse other)
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
                    this.Tipo == other.Tipo ||
                    this.Tipo != null &&
                    this.Tipo.Equals(other.Tipo)
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
                    this.DataNascimento == other.DataNascimento ||
                    this.DataNascimento != null &&
                    this.DataNascimento.Equals(other.DataNascimento)
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
                    this.Sexo == other.Sexo ||
                    this.Sexo != null &&
                    this.Sexo.Equals(other.Sexo)
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
                
                if (this.Tipo != null)
                    hash = hash * 59 + this.Tipo.GetHashCode();
                
                if (this.Cpf != null)
                    hash = hash * 59 + this.Cpf.GetHashCode();
                
                if (this.Cnpj != null)
                    hash = hash * 59 + this.Cnpj.GetHashCode();
                
                if (this.DataNascimento != null)
                    hash = hash * 59 + this.DataNascimento.GetHashCode();
                
                if (this.NumeroIdentidade != null)
                    hash = hash * 59 + this.NumeroIdentidade.GetHashCode();
                
                if (this.OrgaoExpedidorIdentidade != null)
                    hash = hash * 59 + this.OrgaoExpedidorIdentidade.GetHashCode();
                
                if (this.Sexo != null)
                    hash = hash * 59 + this.Sexo.GetHashCode();
                
                if (this.UnidadeFederativaIdentidade != null)
                    hash = hash * 59 + this.UnidadeFederativaIdentidade.GetHashCode();
                
                if (this.DataEmissaoIdentidade != null)
                    hash = hash * 59 + this.DataEmissaoIdentidade.GetHashCode();
                
                return hash;
            }
        }

    }
}
