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
    /// Objeto Estabelecimento
    /// </summary>
    [DataContract]
    public partial class Estabelecimento :  IEquatable<Estabelecimento>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Estabelecimento" /> class.
        /// Initializes a new instance of the <see cref="Estabelecimento" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id)..</param>
        /// <param name="NumeroEstabelecimento">N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Conductor, com dois d\u00C3\u00ADgitos..</param>
        /// <param name="NumeroReceitaFederal">Apresenta o n\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Receita Federal..</param>
        /// <param name="Nome">Nome do Estabelecimento..</param>
        /// <param name="Descricao">Raz\u00C3\u00A3o Social do Estabelecimento..</param>
        /// <param name="NomeFantasia">T\u00C3\u00ADtulo Comercial do Estabelecimento..</param>
        /// <param name="Cep">C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP)..</param>
        /// <param name="NomeLogradouro">Nome do Logradouro..</param>
        /// <param name="NumeroEndereco">N\u00C3\u00BAmero do endere\u00C3\u00A7o..</param>
        /// <param name="Complemento">Descri\u00C3\u00A7\u00C3\u00B5es complementares referente ao endere\u00C3\u00A7o..</param>
        /// <param name="Bairro">Nome do bairro do endere\u00C3\u00A7o..</param>
        /// <param name="Cidade">Nome da cidade do endere\u00C3\u00A7o..</param>
        /// <param name="Uf">Sigla de identifica\u00C3\u00A7\u00C3\u00A3o da Unidade Federativa do endere\u00C3\u00A7o..</param>
        /// <param name="Pais">Nome do pa\u00C3\u00ADs..</param>
        /// <param name="DataCadastramento">Data de Cadastro do Estabelecimento..</param>
        /// <param name="Obs">Detalhes espec\u00C3\u00ADficos quanto ao Cadastro do Estabelecimento..</param>
        /// <param name="Contato">Nome da pessoa para contato com o Estabelecimento..</param>
        /// <param name="Email">E-mail da pessoa para contato com o Estabelecimento..</param>
        /// <param name="FlagArquivoSecrFazenda">Indica se o estabelecimento ser\u00C3\u00A1 inclu\u00C3\u00ADdo no arquivo de registro para a Secretaria da Fazenda Estadual..</param>
        /// <param name="FlagCartaoDigitado">Indica se o estabelecimento poder\u00C3\u00A1 originar transa\u00C3\u00A7\u00C3\u00B5es sem a leitura da tarja ou do chip do cart\u00C3\u00A3o..</param>
        /// <param name="Inativo">Indica se o estabelecimento est\u00C3\u00A1 inativo..</param>

        public Estabelecimento(long? Id = null, string NumeroEstabelecimento = null, long? NumeroReceitaFederal = null, string Nome = null, string Descricao = null, string NomeFantasia = null, string Cep = null, string NomeLogradouro = null, string NumeroEndereco = null, string Complemento = null, string Bairro = null, string Cidade = null, string Uf = null, string Pais = null, DateTime? DataCadastramento = null, string Obs = null, string Contato = null, string Email = null, int? FlagArquivoSecrFazenda = null, int? FlagCartaoDigitado = null, int? Inativo = null)
        {
            this.Id = Id;
            this.NumeroEstabelecimento = NumeroEstabelecimento;
            this.NumeroReceitaFederal = NumeroReceitaFederal;
            this.Nome = Nome;
            this.Descricao = Descricao;
            this.NomeFantasia = NomeFantasia;
            this.Cep = Cep;
            this.NomeLogradouro = NomeLogradouro;
            this.NumeroEndereco = NumeroEndereco;
            this.Complemento = Complemento;
            this.Bairro = Bairro;
            this.Cidade = Cidade;
            this.Uf = Uf;
            this.Pais = Pais;
            this.DataCadastramento = DataCadastramento;
            this.Obs = Obs;
            this.Contato = Contato;
            this.Email = Email;
            this.FlagArquivoSecrFazenda = FlagArquivoSecrFazenda;
            this.FlagCartaoDigitado = FlagCartaoDigitado;
            this.Inativo = Inativo;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Conductor, com dois d\u00C3\u00ADgitos.
        /// </summary>
        /// <value>N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Conductor, com dois d\u00C3\u00ADgitos.</value>
        [DataMember(Name="numeroEstabelecimento", EmitDefaultValue=false)]
        public string NumeroEstabelecimento { get; set; }
    
        /// <summary>
        /// Apresenta o n\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Receita Federal.
        /// </summary>
        /// <value>Apresenta o n\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Receita Federal.</value>
        [DataMember(Name="numeroReceitaFederal", EmitDefaultValue=false)]
        public long? NumeroReceitaFederal { get; set; }
    
        /// <summary>
        /// Nome do Estabelecimento.
        /// </summary>
        /// <value>Nome do Estabelecimento.</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Raz\u00C3\u00A3o Social do Estabelecimento.
        /// </summary>
        /// <value>Raz\u00C3\u00A3o Social do Estabelecimento.</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// T\u00C3\u00ADtulo Comercial do Estabelecimento.
        /// </summary>
        /// <value>T\u00C3\u00ADtulo Comercial do Estabelecimento.</value>
        [DataMember(Name="nomeFantasia", EmitDefaultValue=false)]
        public string NomeFantasia { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP).</value>
        [DataMember(Name="cep", EmitDefaultValue=false)]
        public string Cep { get; set; }
    
        /// <summary>
        /// Nome do Logradouro.
        /// </summary>
        /// <value>Nome do Logradouro.</value>
        [DataMember(Name="nomeLogradouro", EmitDefaultValue=false)]
        public string NomeLogradouro { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero do endere\u00C3\u00A7o.
        /// </summary>
        /// <value>N\u00C3\u00BAmero do endere\u00C3\u00A7o.</value>
        [DataMember(Name="numeroEndereco", EmitDefaultValue=false)]
        public string NumeroEndereco { get; set; }
    
        /// <summary>
        /// Descri\u00C3\u00A7\u00C3\u00B5es complementares referente ao endere\u00C3\u00A7o.
        /// </summary>
        /// <value>Descri\u00C3\u00A7\u00C3\u00B5es complementares referente ao endere\u00C3\u00A7o.</value>
        [DataMember(Name="complemento", EmitDefaultValue=false)]
        public string Complemento { get; set; }
    
        /// <summary>
        /// Nome do bairro do endere\u00C3\u00A7o.
        /// </summary>
        /// <value>Nome do bairro do endere\u00C3\u00A7o.</value>
        [DataMember(Name="bairro", EmitDefaultValue=false)]
        public string Bairro { get; set; }
    
        /// <summary>
        /// Nome da cidade do endere\u00C3\u00A7o.
        /// </summary>
        /// <value>Nome da cidade do endere\u00C3\u00A7o.</value>
        [DataMember(Name="cidade", EmitDefaultValue=false)]
        public string Cidade { get; set; }
    
        /// <summary>
        /// Sigla de identifica\u00C3\u00A7\u00C3\u00A3o da Unidade Federativa do endere\u00C3\u00A7o.
        /// </summary>
        /// <value>Sigla de identifica\u00C3\u00A7\u00C3\u00A3o da Unidade Federativa do endere\u00C3\u00A7o.</value>
        [DataMember(Name="uf", EmitDefaultValue=false)]
        public string Uf { get; set; }
    
        /// <summary>
        /// Nome do pa\u00C3\u00ADs.
        /// </summary>
        /// <value>Nome do pa\u00C3\u00ADs.</value>
        [DataMember(Name="pais", EmitDefaultValue=false)]
        public string Pais { get; set; }
    
        /// <summary>
        /// Data de Cadastro do Estabelecimento.
        /// </summary>
        /// <value>Data de Cadastro do Estabelecimento.</value>
        [DataMember(Name="dataCadastramento", EmitDefaultValue=false)]
        public DateTime? DataCadastramento { get; set; }
    
        /// <summary>
        /// Detalhes espec\u00C3\u00ADficos quanto ao Cadastro do Estabelecimento.
        /// </summary>
        /// <value>Detalhes espec\u00C3\u00ADficos quanto ao Cadastro do Estabelecimento.</value>
        [DataMember(Name="obs", EmitDefaultValue=false)]
        public string Obs { get; set; }
    
        /// <summary>
        /// Nome da pessoa para contato com o Estabelecimento.
        /// </summary>
        /// <value>Nome da pessoa para contato com o Estabelecimento.</value>
        [DataMember(Name="contato", EmitDefaultValue=false)]
        public string Contato { get; set; }
    
        /// <summary>
        /// E-mail da pessoa para contato com o Estabelecimento.
        /// </summary>
        /// <value>E-mail da pessoa para contato com o Estabelecimento.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Indica se o estabelecimento ser\u00C3\u00A1 inclu\u00C3\u00ADdo no arquivo de registro para a Secretaria da Fazenda Estadual.
        /// </summary>
        /// <value>Indica se o estabelecimento ser\u00C3\u00A1 inclu\u00C3\u00ADdo no arquivo de registro para a Secretaria da Fazenda Estadual.</value>
        [DataMember(Name="flagArquivoSecrFazenda", EmitDefaultValue=false)]
        public int? FlagArquivoSecrFazenda { get; set; }
    
        /// <summary>
        /// Indica se o estabelecimento poder\u00C3\u00A1 originar transa\u00C3\u00A7\u00C3\u00B5es sem a leitura da tarja ou do chip do cart\u00C3\u00A3o.
        /// </summary>
        /// <value>Indica se o estabelecimento poder\u00C3\u00A1 originar transa\u00C3\u00A7\u00C3\u00B5es sem a leitura da tarja ou do chip do cart\u00C3\u00A3o.</value>
        [DataMember(Name="flagCartaoDigitado", EmitDefaultValue=false)]
        public int? FlagCartaoDigitado { get; set; }
    
        /// <summary>
        /// Indica se o estabelecimento est\u00C3\u00A1 inativo.
        /// </summary>
        /// <value>Indica se o estabelecimento est\u00C3\u00A1 inativo.</value>
        [DataMember(Name="inativo", EmitDefaultValue=false)]
        public int? Inativo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Estabelecimento {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NumeroEstabelecimento: ").Append(NumeroEstabelecimento).Append("\n");
            sb.Append("  NumeroReceitaFederal: ").Append(NumeroReceitaFederal).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  NomeFantasia: ").Append(NomeFantasia).Append("\n");
            sb.Append("  Cep: ").Append(Cep).Append("\n");
            sb.Append("  NomeLogradouro: ").Append(NomeLogradouro).Append("\n");
            sb.Append("  NumeroEndereco: ").Append(NumeroEndereco).Append("\n");
            sb.Append("  Complemento: ").Append(Complemento).Append("\n");
            sb.Append("  Bairro: ").Append(Bairro).Append("\n");
            sb.Append("  Cidade: ").Append(Cidade).Append("\n");
            sb.Append("  Uf: ").Append(Uf).Append("\n");
            sb.Append("  Pais: ").Append(Pais).Append("\n");
            sb.Append("  DataCadastramento: ").Append(DataCadastramento).Append("\n");
            sb.Append("  Obs: ").Append(Obs).Append("\n");
            sb.Append("  Contato: ").Append(Contato).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FlagArquivoSecrFazenda: ").Append(FlagArquivoSecrFazenda).Append("\n");
            sb.Append("  FlagCartaoDigitado: ").Append(FlagCartaoDigitado).Append("\n");
            sb.Append("  Inativo: ").Append(Inativo).Append("\n");
            
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
            return this.Equals(obj as Estabelecimento);
        }

        /// <summary>
        /// Returns true if Estabelecimento instances are equal
        /// </summary>
        /// <param name="other">Instance of Estabelecimento to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Estabelecimento other)
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
                    this.NumeroEstabelecimento == other.NumeroEstabelecimento ||
                    this.NumeroEstabelecimento != null &&
                    this.NumeroEstabelecimento.Equals(other.NumeroEstabelecimento)
                ) && 
                (
                    this.NumeroReceitaFederal == other.NumeroReceitaFederal ||
                    this.NumeroReceitaFederal != null &&
                    this.NumeroReceitaFederal.Equals(other.NumeroReceitaFederal)
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
                    this.Complemento == other.Complemento ||
                    this.Complemento != null &&
                    this.Complemento.Equals(other.Complemento)
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
                    this.Uf == other.Uf ||
                    this.Uf != null &&
                    this.Uf.Equals(other.Uf)
                ) && 
                (
                    this.Pais == other.Pais ||
                    this.Pais != null &&
                    this.Pais.Equals(other.Pais)
                ) && 
                (
                    this.DataCadastramento == other.DataCadastramento ||
                    this.DataCadastramento != null &&
                    this.DataCadastramento.Equals(other.DataCadastramento)
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
                
                if (this.NumeroEstabelecimento != null)
                    hash = hash * 59 + this.NumeroEstabelecimento.GetHashCode();
                
                if (this.NumeroReceitaFederal != null)
                    hash = hash * 59 + this.NumeroReceitaFederal.GetHashCode();
                
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
                
                if (this.Complemento != null)
                    hash = hash * 59 + this.Complemento.GetHashCode();
                
                if (this.Bairro != null)
                    hash = hash * 59 + this.Bairro.GetHashCode();
                
                if (this.Cidade != null)
                    hash = hash * 59 + this.Cidade.GetHashCode();
                
                if (this.Uf != null)
                    hash = hash * 59 + this.Uf.GetHashCode();
                
                if (this.Pais != null)
                    hash = hash * 59 + this.Pais.GetHashCode();
                
                if (this.DataCadastramento != null)
                    hash = hash * 59 + this.DataCadastramento.GetHashCode();
                
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
                
                return hash;
            }
        }

    }
}
