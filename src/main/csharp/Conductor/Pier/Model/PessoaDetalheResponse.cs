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
        /// <param name="Content">Content.</param>
        /// <param name="First">First.</param>
        /// <param name="FirstPage">FirstPage.</param>
        /// <param name="HasContent">HasContent.</param>
        /// <param name="HasNextPage">HasNextPage.</param>
        /// <param name="HasPreviousPage">HasPreviousPage.</param>
        /// <param name="IdPessoa">C\u00C3\u00B3digo identificador da pessoa.</param>
        /// <param name="Last">Last.</param>
        /// <param name="NextPage">NextPage.</param>
        /// <param name="Number">Number.</param>
        /// <param name="NumberOfElements">NumberOfElements.</param>
        /// <param name="PreviousPage">PreviousPage.</param>
        /// <param name="Size">Size.</param>
        /// <param name="TotalElements">TotalElements.</param>
        /// <param name="TotalPages">TotalPages.</param>
        /// <param name="NomeMae">Apresenta o nome da m\u00C3\u00A3e da pessoa fisica.</param>
        /// <param name="IdEstadoCivil">Id Estado civil da pessoa fisica.</param>
        /// <param name="Profissao">Profiss\u00C3\u00A3o da pessoa fisica.</param>
        /// <param name="IdNaturezaOcupacao">Id Natureza Ocupa\u00C3\u00A7\u00C3\u00A3o da pessoa fisica.</param>
        /// <param name="IdNacionalidade">Id Nacionalidade da pessoa fisica.</param>
        /// <param name="NumeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia..</param>
        /// <param name="NumeroContaCorrente">N\u00C3\u00BAmero da conta corrente..</param>
        /// <param name="Email">Email da pessoa fisica.</param>
        /// <param name="NomeEmpresa">Nome que deve ser impresso no cart\u00C3\u00A3o.</param>

        public PessoaDetalheResponse(List<PessoaDetalheResponse> Content = null, bool? First = null, bool? FirstPage = null, bool? HasContent = null, bool? HasNextPage = null, bool? HasPreviousPage = null, long? IdPessoa = null, bool? Last = null, int? NextPage = null, int? Number = null, int? NumberOfElements = null, int? PreviousPage = null, int? Size = null, long? TotalElements = null, int? TotalPages = null, string NomeMae = null, long? IdEstadoCivil = null, string Profissao = null, long? IdNaturezaOcupacao = null, long? IdNacionalidade = null, int? NumeroAgencia = null, string NumeroContaCorrente = null, string Email = null, string NomeEmpresa = null)
        {
            this.Content = Content;
            this.First = First;
            this.FirstPage = FirstPage;
            this.HasContent = HasContent;
            this.HasNextPage = HasNextPage;
            this.HasPreviousPage = HasPreviousPage;
            this.IdPessoa = IdPessoa;
            this.Last = Last;
            this.NextPage = NextPage;
            this.Number = Number;
            this.NumberOfElements = NumberOfElements;
            this.PreviousPage = PreviousPage;
            this.Size = Size;
            this.TotalElements = TotalElements;
            this.TotalPages = TotalPages;
            this.NomeMae = NomeMae;
            this.IdEstadoCivil = IdEstadoCivil;
            this.Profissao = Profissao;
            this.IdNaturezaOcupacao = IdNaturezaOcupacao;
            this.IdNacionalidade = IdNacionalidade;
            this.NumeroAgencia = NumeroAgencia;
            this.NumeroContaCorrente = NumeroContaCorrente;
            this.Email = Email;
            this.NomeEmpresa = NomeEmpresa;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public List<PessoaDetalheResponse> Content { get; set; }
    
        /// <summary>
        /// Gets or Sets First
        /// </summary>
        [DataMember(Name="first", EmitDefaultValue=false)]
        public bool? First { get; set; }
    
        /// <summary>
        /// Gets or Sets FirstPage
        /// </summary>
        [DataMember(Name="firstPage", EmitDefaultValue=false)]
        public bool? FirstPage { get; set; }
    
        /// <summary>
        /// Gets or Sets HasContent
        /// </summary>
        [DataMember(Name="hasContent", EmitDefaultValue=false)]
        public bool? HasContent { get; set; }
    
        /// <summary>
        /// Gets or Sets HasNextPage
        /// </summary>
        [DataMember(Name="hasNextPage", EmitDefaultValue=false)]
        public bool? HasNextPage { get; set; }
    
        /// <summary>
        /// Gets or Sets HasPreviousPage
        /// </summary>
        [DataMember(Name="hasPreviousPage", EmitDefaultValue=false)]
        public bool? HasPreviousPage { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador da pessoa
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador da pessoa</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// Gets or Sets Last
        /// </summary>
        [DataMember(Name="last", EmitDefaultValue=false)]
        public bool? Last { get; set; }
    
        /// <summary>
        /// Gets or Sets NextPage
        /// </summary>
        [DataMember(Name="nextPage", EmitDefaultValue=false)]
        public int? NextPage { get; set; }
    
        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public int? Number { get; set; }
    
        /// <summary>
        /// Gets or Sets NumberOfElements
        /// </summary>
        [DataMember(Name="numberOfElements", EmitDefaultValue=false)]
        public int? NumberOfElements { get; set; }
    
        /// <summary>
        /// Gets or Sets PreviousPage
        /// </summary>
        [DataMember(Name="previousPage", EmitDefaultValue=false)]
        public int? PreviousPage { get; set; }
    
        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalElements
        /// </summary>
        [DataMember(Name="totalElements", EmitDefaultValue=false)]
        public long? TotalElements { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalPages
        /// </summary>
        [DataMember(Name="totalPages", EmitDefaultValue=false)]
        public int? TotalPages { get; set; }
    
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
        [DataMember(Name="profissao", EmitDefaultValue=false)]
        public string Profissao { get; set; }
    
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
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  FirstPage: ").Append(FirstPage).Append("\n");
            sb.Append("  HasContent: ").Append(HasContent).Append("\n");
            sb.Append("  HasNextPage: ").Append(HasNextPage).Append("\n");
            sb.Append("  HasPreviousPage: ").Append(HasPreviousPage).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  NumberOfElements: ").Append(NumberOfElements).Append("\n");
            sb.Append("  PreviousPage: ").Append(PreviousPage).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  TotalElements: ").Append(TotalElements).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("  NomeMae: ").Append(NomeMae).Append("\n");
            sb.Append("  IdEstadoCivil: ").Append(IdEstadoCivil).Append("\n");
            sb.Append("  Profissao: ").Append(Profissao).Append("\n");
            sb.Append("  IdNaturezaOcupacao: ").Append(IdNaturezaOcupacao).Append("\n");
            sb.Append("  IdNacionalidade: ").Append(IdNacionalidade).Append("\n");
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
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.SequenceEqual(other.Content)
                ) && 
                (
                    this.First == other.First ||
                    this.First != null &&
                    this.First.Equals(other.First)
                ) && 
                (
                    this.FirstPage == other.FirstPage ||
                    this.FirstPage != null &&
                    this.FirstPage.Equals(other.FirstPage)
                ) && 
                (
                    this.HasContent == other.HasContent ||
                    this.HasContent != null &&
                    this.HasContent.Equals(other.HasContent)
                ) && 
                (
                    this.HasNextPage == other.HasNextPage ||
                    this.HasNextPage != null &&
                    this.HasNextPage.Equals(other.HasNextPage)
                ) && 
                (
                    this.HasPreviousPage == other.HasPreviousPage ||
                    this.HasPreviousPage != null &&
                    this.HasPreviousPage.Equals(other.HasPreviousPage)
                ) && 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.Last == other.Last ||
                    this.Last != null &&
                    this.Last.Equals(other.Last)
                ) && 
                (
                    this.NextPage == other.NextPage ||
                    this.NextPage != null &&
                    this.NextPage.Equals(other.NextPage)
                ) && 
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) && 
                (
                    this.NumberOfElements == other.NumberOfElements ||
                    this.NumberOfElements != null &&
                    this.NumberOfElements.Equals(other.NumberOfElements)
                ) && 
                (
                    this.PreviousPage == other.PreviousPage ||
                    this.PreviousPage != null &&
                    this.PreviousPage.Equals(other.PreviousPage)
                ) && 
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
                ) && 
                (
                    this.TotalElements == other.TotalElements ||
                    this.TotalElements != null &&
                    this.TotalElements.Equals(other.TotalElements)
                ) && 
                (
                    this.TotalPages == other.TotalPages ||
                    this.TotalPages != null &&
                    this.TotalPages.Equals(other.TotalPages)
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
                    this.Profissao == other.Profissao ||
                    this.Profissao != null &&
                    this.Profissao.Equals(other.Profissao)
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
                
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();
                
                if (this.First != null)
                    hash = hash * 59 + this.First.GetHashCode();
                
                if (this.FirstPage != null)
                    hash = hash * 59 + this.FirstPage.GetHashCode();
                
                if (this.HasContent != null)
                    hash = hash * 59 + this.HasContent.GetHashCode();
                
                if (this.HasNextPage != null)
                    hash = hash * 59 + this.HasNextPage.GetHashCode();
                
                if (this.HasPreviousPage != null)
                    hash = hash * 59 + this.HasPreviousPage.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.Last != null)
                    hash = hash * 59 + this.Last.GetHashCode();
                
                if (this.NextPage != null)
                    hash = hash * 59 + this.NextPage.GetHashCode();
                
                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
                
                if (this.NumberOfElements != null)
                    hash = hash * 59 + this.NumberOfElements.GetHashCode();
                
                if (this.PreviousPage != null)
                    hash = hash * 59 + this.PreviousPage.GetHashCode();
                
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                
                if (this.TotalElements != null)
                    hash = hash * 59 + this.TotalElements.GetHashCode();
                
                if (this.TotalPages != null)
                    hash = hash * 59 + this.TotalPages.GetHashCode();
                
                if (this.NomeMae != null)
                    hash = hash * 59 + this.NomeMae.GetHashCode();
                
                if (this.IdEstadoCivil != null)
                    hash = hash * 59 + this.IdEstadoCivil.GetHashCode();
                
                if (this.Profissao != null)
                    hash = hash * 59 + this.Profissao.GetHashCode();
                
                if (this.IdNaturezaOcupacao != null)
                    hash = hash * 59 + this.IdNaturezaOcupacao.GetHashCode();
                
                if (this.IdNacionalidade != null)
                    hash = hash * 59 + this.IdNacionalidade.GetHashCode();
                
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
