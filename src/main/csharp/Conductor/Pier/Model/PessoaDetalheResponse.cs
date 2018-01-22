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
    /// PessoaDetalheResponse
    /// </summary>
    [DataContract]
    public partial class PessoaDetalheResponse :  IEquatable<PessoaDetalheResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaDetalheResponse" /> class.
        /// Initializes a new instance of the <see cref="PessoaDetalheResponse" />class.
        /// </summary>
        /// <param name="IdPessoa">C\u00C3\u00B3digo identificador da pessoa.</param>
        /// <param name="NomeMae">Apresenta o nome da m\u00C3\u00A3e da pessoa fisica.</param>
        /// <param name="IdEstadoCivil">Id Estado civil da pessoa fisica.</param>
        /// <param name="IdProfissao">Profiss\u00C3\u00A3o da pessoa fisica.</param>
        /// <param name="IdNaturezaOcupacao">Id Natureza Ocupa\u00C3\u00A7\u00C3\u00A3o da pessoa fisica.</param>
        /// <param name="IdNacionalidade">Id Nacionalidade da pessoa fisica.</param>
        /// <param name="NumeroBanco">N\u00C3\u00BAmero do banco..</param>
        /// <param name="NumeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia..</param>
        /// <param name="NumeroContaCorrente">N\u00C3\u00BAmero da conta corrente..</param>
        /// <param name="Email">Email da pessoa fisica.</param>
        /// <param name="NomeEmpresa">Nome que deve ser impresso no cart\u00C3\u00A3o.</param>

        public PessoaDetalheResponse(long? IdPessoa = null, string NomeMae = null, long? IdEstadoCivil = null, string IdProfissao = null, long? IdNaturezaOcupacao = null, long? IdNacionalidade = null, int? NumeroBanco = null, int? NumeroAgencia = null, string NumeroContaCorrente = null, string Email = null, string NomeEmpresa = null)
        {
            this.IdPessoa = IdPessoa;
            this.NomeMae = NomeMae;
            this.IdEstadoCivil = IdEstadoCivil;
            this.IdProfissao = IdProfissao;
            this.IdNaturezaOcupacao = IdNaturezaOcupacao;
            this.IdNacionalidade = IdNacionalidade;
            this.NumeroBanco = NumeroBanco;
            this.NumeroAgencia = NumeroAgencia;
            this.NumeroContaCorrente = NumeroContaCorrente;
            this.Email = Email;
            this.NomeEmpresa = NomeEmpresa;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador da pessoa
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador da pessoa</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// Apresenta o nome da m\u00C3\u00A3e da pessoa fisica
        /// </summary>
        /// <value>Apresenta o nome da m\u00C3\u00A3e da pessoa fisica</value>
        [DataMember(Name="nomeMae", EmitDefaultValue=false)]
        public string NomeMae { get; set; }
    
        /// <summary>
        /// Id Estado civil da pessoa fisica
        /// </summary>
        /// <value>Id Estado civil da pessoa fisica</value>
        [DataMember(Name="idEstadoCivil", EmitDefaultValue=false)]
        public long? IdEstadoCivil { get; set; }
    
        /// <summary>
        /// Profiss\u00C3\u00A3o da pessoa fisica
        /// </summary>
        /// <value>Profiss\u00C3\u00A3o da pessoa fisica</value>
        [DataMember(Name="idProfissao", EmitDefaultValue=false)]
        public string IdProfissao { get; set; }
    
        /// <summary>
        /// Id Natureza Ocupa\u00C3\u00A7\u00C3\u00A3o da pessoa fisica
        /// </summary>
        /// <value>Id Natureza Ocupa\u00C3\u00A7\u00C3\u00A3o da pessoa fisica</value>
        [DataMember(Name="idNaturezaOcupacao", EmitDefaultValue=false)]
        public long? IdNaturezaOcupacao { get; set; }
    
        /// <summary>
        /// Id Nacionalidade da pessoa fisica
        /// </summary>
        /// <value>Id Nacionalidade da pessoa fisica</value>
        [DataMember(Name="idNacionalidade", EmitDefaultValue=false)]
        public long? IdNacionalidade { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero do banco.
        /// </summary>
        /// <value>N\u00C3\u00BAmero do banco.</value>
        [DataMember(Name="numeroBanco", EmitDefaultValue=false)]
        public int? NumeroBanco { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero da ag\u00C3\u00AAncia.
        /// </summary>
        /// <value>N\u00C3\u00BAmero da ag\u00C3\u00AAncia.</value>
        [DataMember(Name="numeroAgencia", EmitDefaultValue=false)]
        public int? NumeroAgencia { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero da conta corrente.
        /// </summary>
        /// <value>N\u00C3\u00BAmero da conta corrente.</value>
        [DataMember(Name="numeroContaCorrente", EmitDefaultValue=false)]
        public string NumeroContaCorrente { get; set; }
    
        /// <summary>
        /// Email da pessoa fisica
        /// </summary>
        /// <value>Email da pessoa fisica</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Nome que deve ser impresso no cart\u00C3\u00A3o
        /// </summary>
        /// <value>Nome que deve ser impresso no cart\u00C3\u00A3o</value>
        [DataMember(Name="nomeEmpresa", EmitDefaultValue=false)]
        public string NomeEmpresa { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PessoaDetalheResponse {\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  NomeMae: ").Append(NomeMae).Append("\n");
            sb.Append("  IdEstadoCivil: ").Append(IdEstadoCivil).Append("\n");
            sb.Append("  IdProfissao: ").Append(IdProfissao).Append("\n");
            sb.Append("  IdNaturezaOcupacao: ").Append(IdNaturezaOcupacao).Append("\n");
            sb.Append("  IdNacionalidade: ").Append(IdNacionalidade).Append("\n");
            sb.Append("  NumeroBanco: ").Append(NumeroBanco).Append("\n");
            sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
            sb.Append("  NumeroContaCorrente: ").Append(NumeroContaCorrente).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  NomeEmpresa: ").Append(NomeEmpresa).Append("\n");
            
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
            return this.Equals(obj as PessoaDetalheResponse);
        }

        /// <summary>
        /// Returns true if PessoaDetalheResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PessoaDetalheResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PessoaDetalheResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.NomeMae == other.NomeMae ||
                    this.NomeMae != null &&
                    this.NomeMae.Equals(other.NomeMae)
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
                    this.IdNaturezaOcupacao == other.IdNaturezaOcupacao ||
                    this.IdNaturezaOcupacao != null &&
                    this.IdNaturezaOcupacao.Equals(other.IdNaturezaOcupacao)
                ) && 
                (
                    this.IdNacionalidade == other.IdNacionalidade ||
                    this.IdNacionalidade != null &&
                    this.IdNacionalidade.Equals(other.IdNacionalidade)
                ) && 
                (
                    this.NumeroBanco == other.NumeroBanco ||
                    this.NumeroBanco != null &&
                    this.NumeroBanco.Equals(other.NumeroBanco)
                ) && 
                (
                    this.NumeroAgencia == other.NumeroAgencia ||
                    this.NumeroAgencia != null &&
                    this.NumeroAgencia.Equals(other.NumeroAgencia)
                ) && 
                (
                    this.NumeroContaCorrente == other.NumeroContaCorrente ||
                    this.NumeroContaCorrente != null &&
                    this.NumeroContaCorrente.Equals(other.NumeroContaCorrente)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.NomeEmpresa == other.NomeEmpresa ||
                    this.NomeEmpresa != null &&
                    this.NomeEmpresa.Equals(other.NomeEmpresa)
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
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.NomeMae != null)
                    hash = hash * 59 + this.NomeMae.GetHashCode();
                
                if (this.IdEstadoCivil != null)
                    hash = hash * 59 + this.IdEstadoCivil.GetHashCode();
                
                if (this.IdProfissao != null)
                    hash = hash * 59 + this.IdProfissao.GetHashCode();
                
                if (this.IdNaturezaOcupacao != null)
                    hash = hash * 59 + this.IdNaturezaOcupacao.GetHashCode();
                
                if (this.IdNacionalidade != null)
                    hash = hash * 59 + this.IdNacionalidade.GetHashCode();
                
                if (this.NumeroBanco != null)
                    hash = hash * 59 + this.NumeroBanco.GetHashCode();
                
                if (this.NumeroAgencia != null)
                    hash = hash * 59 + this.NumeroAgencia.GetHashCode();
                
                if (this.NumeroContaCorrente != null)
                    hash = hash * 59 + this.NumeroContaCorrente.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.NomeEmpresa != null)
                    hash = hash * 59 + this.NomeEmpresa.GetHashCode();
                
                return hash;
            }
        }

    }
}
