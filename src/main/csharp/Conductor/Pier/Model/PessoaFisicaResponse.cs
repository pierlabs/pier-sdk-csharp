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
    public partial class PessoaFisicaResponse :  IEquatable<PessoaFisicaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaFisicaResponse" /> class.
        /// Initializes a new instance of the <see cref="PessoaFisicaResponse" />class.
        /// </summary>
        /// <param name="Bairro">Bairro.</param>
        /// <param name="Cep">Cep.</param>
        /// <param name="Cidade">Cidade.</param>
        /// <param name="ComplementoLogradouro">ComplementoLogradouro.</param>
        /// <param name="Cpf">Cpf.</param>
        /// <param name="DataEmissaoIdentidade">DataEmissaoIdentidade.</param>
        /// <param name="DataNascimento">DataNascimento.</param>
        /// <param name="Dddcelular">Dddcelular.</param>
        /// <param name="Dddtelefone">Dddtelefone.</param>
        /// <param name="Endereco">Endereco.</param>
        /// <param name="IdPessoaFisica">IdPessoaFisica.</param>
        /// <param name="Identidade">Identidade.</param>
        /// <param name="Nome">Nome.</param>
        /// <param name="NumeroCelular">NumeroCelular.</param>
        /// <param name="NumeroLogradouro">NumeroLogradouro.</param>
        /// <param name="NumeroTelefone">NumeroTelefone.</param>
        /// <param name="OrgaoEmissor">OrgaoEmissor.</param>
        /// <param name="Sexo">Sexo.</param>
        /// <param name="Uf">Uf.</param>

        public PessoaFisicaResponse(string Bairro = null, string Cep = null, string Cidade = null, string ComplementoLogradouro = null, string Cpf = null, string DataEmissaoIdentidade = null, string DataNascimento = null, string Dddcelular = null, string Dddtelefone = null, string Endereco = null, int? IdPessoaFisica = null, string Identidade = null, string Nome = null, string NumeroCelular = null, int? NumeroLogradouro = null, string NumeroTelefone = null, string OrgaoEmissor = null, string Sexo = null, string Uf = null)
        {
            this.Bairro = Bairro;
            this.Cep = Cep;
            this.Cidade = Cidade;
            this.ComplementoLogradouro = ComplementoLogradouro;
            this.Cpf = Cpf;
            this.DataEmissaoIdentidade = DataEmissaoIdentidade;
            this.DataNascimento = DataNascimento;
            this.Dddcelular = Dddcelular;
            this.Dddtelefone = Dddtelefone;
            this.Endereco = Endereco;
            this.IdPessoaFisica = IdPessoaFisica;
            this.Identidade = Identidade;
            this.Nome = Nome;
            this.NumeroCelular = NumeroCelular;
            this.NumeroLogradouro = NumeroLogradouro;
            this.NumeroTelefone = NumeroTelefone;
            this.OrgaoEmissor = OrgaoEmissor;
            this.Sexo = Sexo;
            this.Uf = Uf;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Bairro
        /// </summary>
        [DataMember(Name="bairro", EmitDefaultValue=false)]
        public string Bairro { get; set; }
    
        /// <summary>
        /// Gets or Sets Cep
        /// </summary>
        [DataMember(Name="cep", EmitDefaultValue=false)]
        public string Cep { get; set; }
    
        /// <summary>
        /// Gets or Sets Cidade
        /// </summary>
        [DataMember(Name="cidade", EmitDefaultValue=false)]
        public string Cidade { get; set; }
    
        /// <summary>
        /// Gets or Sets ComplementoLogradouro
        /// </summary>
        [DataMember(Name="complementoLogradouro", EmitDefaultValue=false)]
        public string ComplementoLogradouro { get; set; }
    
        /// <summary>
        /// Gets or Sets Cpf
        /// </summary>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// Gets or Sets DataEmissaoIdentidade
        /// </summary>
        [DataMember(Name="dataEmissaoIdentidade", EmitDefaultValue=false)]
        public string DataEmissaoIdentidade { get; set; }
    
        /// <summary>
        /// Gets or Sets DataNascimento
        /// </summary>
        [DataMember(Name="dataNascimento", EmitDefaultValue=false)]
        public string DataNascimento { get; set; }
    
        /// <summary>
        /// Gets or Sets Dddcelular
        /// </summary>
        [DataMember(Name="dddcelular", EmitDefaultValue=false)]
        public string Dddcelular { get; set; }
    
        /// <summary>
        /// Gets or Sets Dddtelefone
        /// </summary>
        [DataMember(Name="dddtelefone", EmitDefaultValue=false)]
        public string Dddtelefone { get; set; }
    
        /// <summary>
        /// Gets or Sets Endereco
        /// </summary>
        [DataMember(Name="endereco", EmitDefaultValue=false)]
        public string Endereco { get; set; }
    
        /// <summary>
        /// Gets or Sets IdPessoaFisica
        /// </summary>
        [DataMember(Name="idPessoaFisica", EmitDefaultValue=false)]
        public int? IdPessoaFisica { get; set; }
    
        /// <summary>
        /// Gets or Sets Identidade
        /// </summary>
        [DataMember(Name="identidade", EmitDefaultValue=false)]
        public string Identidade { get; set; }
    
        /// <summary>
        /// Gets or Sets Nome
        /// </summary>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Gets or Sets NumeroCelular
        /// </summary>
        [DataMember(Name="numeroCelular", EmitDefaultValue=false)]
        public string NumeroCelular { get; set; }
    
        /// <summary>
        /// Gets or Sets NumeroLogradouro
        /// </summary>
        [DataMember(Name="numeroLogradouro", EmitDefaultValue=false)]
        public int? NumeroLogradouro { get; set; }
    
        /// <summary>
        /// Gets or Sets NumeroTelefone
        /// </summary>
        [DataMember(Name="numeroTelefone", EmitDefaultValue=false)]
        public string NumeroTelefone { get; set; }
    
        /// <summary>
        /// Gets or Sets OrgaoEmissor
        /// </summary>
        [DataMember(Name="orgaoEmissor", EmitDefaultValue=false)]
        public string OrgaoEmissor { get; set; }
    
        /// <summary>
        /// Gets or Sets Sexo
        /// </summary>
        [DataMember(Name="sexo", EmitDefaultValue=false)]
        public string Sexo { get; set; }
    
        /// <summary>
        /// Gets or Sets Uf
        /// </summary>
        [DataMember(Name="uf", EmitDefaultValue=false)]
        public string Uf { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PessoaFisicaResponse {\n");
            sb.Append("  Bairro: ").Append(Bairro).Append("\n");
            sb.Append("  Cep: ").Append(Cep).Append("\n");
            sb.Append("  Cidade: ").Append(Cidade).Append("\n");
            sb.Append("  ComplementoLogradouro: ").Append(ComplementoLogradouro).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  DataEmissaoIdentidade: ").Append(DataEmissaoIdentidade).Append("\n");
            sb.Append("  DataNascimento: ").Append(DataNascimento).Append("\n");
            sb.Append("  Dddcelular: ").Append(Dddcelular).Append("\n");
            sb.Append("  Dddtelefone: ").Append(Dddtelefone).Append("\n");
            sb.Append("  Endereco: ").Append(Endereco).Append("\n");
            sb.Append("  IdPessoaFisica: ").Append(IdPessoaFisica).Append("\n");
            sb.Append("  Identidade: ").Append(Identidade).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  NumeroCelular: ").Append(NumeroCelular).Append("\n");
            sb.Append("  NumeroLogradouro: ").Append(NumeroLogradouro).Append("\n");
            sb.Append("  NumeroTelefone: ").Append(NumeroTelefone).Append("\n");
            sb.Append("  OrgaoEmissor: ").Append(OrgaoEmissor).Append("\n");
            sb.Append("  Sexo: ").Append(Sexo).Append("\n");
            sb.Append("  Uf: ").Append(Uf).Append("\n");
            
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
            return this.Equals(obj as PessoaFisicaResponse);
        }

        /// <summary>
        /// Returns true if PessoaFisicaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PessoaFisicaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PessoaFisicaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Bairro == other.Bairro ||
                    this.Bairro != null &&
                    this.Bairro.Equals(other.Bairro)
                ) && 
                (
                    this.Cep == other.Cep ||
                    this.Cep != null &&
                    this.Cep.Equals(other.Cep)
                ) && 
                (
                    this.Cidade == other.Cidade ||
                    this.Cidade != null &&
                    this.Cidade.Equals(other.Cidade)
                ) && 
                (
                    this.ComplementoLogradouro == other.ComplementoLogradouro ||
                    this.ComplementoLogradouro != null &&
                    this.ComplementoLogradouro.Equals(other.ComplementoLogradouro)
                ) && 
                (
                    this.Cpf == other.Cpf ||
                    this.Cpf != null &&
                    this.Cpf.Equals(other.Cpf)
                ) && 
                (
                    this.DataEmissaoIdentidade == other.DataEmissaoIdentidade ||
                    this.DataEmissaoIdentidade != null &&
                    this.DataEmissaoIdentidade.Equals(other.DataEmissaoIdentidade)
                ) && 
                (
                    this.DataNascimento == other.DataNascimento ||
                    this.DataNascimento != null &&
                    this.DataNascimento.Equals(other.DataNascimento)
                ) && 
                (
                    this.Dddcelular == other.Dddcelular ||
                    this.Dddcelular != null &&
                    this.Dddcelular.Equals(other.Dddcelular)
                ) && 
                (
                    this.Dddtelefone == other.Dddtelefone ||
                    this.Dddtelefone != null &&
                    this.Dddtelefone.Equals(other.Dddtelefone)
                ) && 
                (
                    this.Endereco == other.Endereco ||
                    this.Endereco != null &&
                    this.Endereco.Equals(other.Endereco)
                ) && 
                (
                    this.IdPessoaFisica == other.IdPessoaFisica ||
                    this.IdPessoaFisica != null &&
                    this.IdPessoaFisica.Equals(other.IdPessoaFisica)
                ) && 
                (
                    this.Identidade == other.Identidade ||
                    this.Identidade != null &&
                    this.Identidade.Equals(other.Identidade)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.NumeroCelular == other.NumeroCelular ||
                    this.NumeroCelular != null &&
                    this.NumeroCelular.Equals(other.NumeroCelular)
                ) && 
                (
                    this.NumeroLogradouro == other.NumeroLogradouro ||
                    this.NumeroLogradouro != null &&
                    this.NumeroLogradouro.Equals(other.NumeroLogradouro)
                ) && 
                (
                    this.NumeroTelefone == other.NumeroTelefone ||
                    this.NumeroTelefone != null &&
                    this.NumeroTelefone.Equals(other.NumeroTelefone)
                ) && 
                (
                    this.OrgaoEmissor == other.OrgaoEmissor ||
                    this.OrgaoEmissor != null &&
                    this.OrgaoEmissor.Equals(other.OrgaoEmissor)
                ) && 
                (
                    this.Sexo == other.Sexo ||
                    this.Sexo != null &&
                    this.Sexo.Equals(other.Sexo)
                ) && 
                (
                    this.Uf == other.Uf ||
                    this.Uf != null &&
                    this.Uf.Equals(other.Uf)
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
                
                if (this.Bairro != null)
                    hash = hash * 59 + this.Bairro.GetHashCode();
                
                if (this.Cep != null)
                    hash = hash * 59 + this.Cep.GetHashCode();
                
                if (this.Cidade != null)
                    hash = hash * 59 + this.Cidade.GetHashCode();
                
                if (this.ComplementoLogradouro != null)
                    hash = hash * 59 + this.ComplementoLogradouro.GetHashCode();
                
                if (this.Cpf != null)
                    hash = hash * 59 + this.Cpf.GetHashCode();
                
                if (this.DataEmissaoIdentidade != null)
                    hash = hash * 59 + this.DataEmissaoIdentidade.GetHashCode();
                
                if (this.DataNascimento != null)
                    hash = hash * 59 + this.DataNascimento.GetHashCode();
                
                if (this.Dddcelular != null)
                    hash = hash * 59 + this.Dddcelular.GetHashCode();
                
                if (this.Dddtelefone != null)
                    hash = hash * 59 + this.Dddtelefone.GetHashCode();
                
                if (this.Endereco != null)
                    hash = hash * 59 + this.Endereco.GetHashCode();
                
                if (this.IdPessoaFisica != null)
                    hash = hash * 59 + this.IdPessoaFisica.GetHashCode();
                
                if (this.Identidade != null)
                    hash = hash * 59 + this.Identidade.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.NumeroCelular != null)
                    hash = hash * 59 + this.NumeroCelular.GetHashCode();
                
                if (this.NumeroLogradouro != null)
                    hash = hash * 59 + this.NumeroLogradouro.GetHashCode();
                
                if (this.NumeroTelefone != null)
                    hash = hash * 59 + this.NumeroTelefone.GetHashCode();
                
                if (this.OrgaoEmissor != null)
                    hash = hash * 59 + this.OrgaoEmissor.GetHashCode();
                
                if (this.Sexo != null)
                    hash = hash * 59 + this.Sexo.GetHashCode();
                
                if (this.Uf != null)
                    hash = hash * 59 + this.Uf.GetHashCode();
                
                return hash;
            }
        }

    }
}
