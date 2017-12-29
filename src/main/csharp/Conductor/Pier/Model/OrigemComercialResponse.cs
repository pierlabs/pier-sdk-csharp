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
    /// Origem Comercial
    /// </summary>
    [DataContract]
    public partial class OrigemComercialResponse :  IEquatable<OrigemComercialResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrigemComercialResponse" /> class.
        /// Initializes a new instance of the <see cref="OrigemComercialResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (required).</param>
        /// <param name="Nome">Nome da origem comercial (required).</param>
        /// <param name="Descricao">Descri\u00C3\u00A7\u00C3\u00A3o completa do nome da Origem Comercial (required).</param>
        /// <param name="ProdutosOrigem">Lista de  ProdutosOrigem associados \u00C3\u00A0 Origem comercial (required).</param>
        /// <param name="IdEstabelecimento">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento (required).</param>
        /// <param name="IdTipoOrigemComercial">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Tipo da Origem Comercial (required).</param>
        /// <param name="NomeTipoOrigemComercial">Nome do Tipo da Origem Comercial (required).</param>
        /// <param name="IdGrupoOrigemComercial">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Grupo a qual a Origem Comercial pertence (required).</param>
        /// <param name="NomeGrupoOrigemComercial">Nome do Grupo a qual a Origem Comercial pertence (required).</param>
        /// <param name="Status">Status da origem comercial (required).</param>

        public OrigemComercialResponse(long? Id = null, string Nome = null, string Descricao = null, List<ProdutoOrigemResponse> ProdutosOrigem = null, long? IdEstabelecimento = null, long? IdTipoOrigemComercial = null, string NomeTipoOrigemComercial = null, long? IdGrupoOrigemComercial = null, string NomeGrupoOrigemComercial = null, bool? Status = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for OrigemComercialResponse and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Nome" is required (not null)
            if (Nome == null)
            {
                throw new InvalidDataException("Nome is a required property for OrigemComercialResponse and cannot be null");
            }
            else
            {
                this.Nome = Nome;
            }
            // to ensure "Descricao" is required (not null)
            if (Descricao == null)
            {
                throw new InvalidDataException("Descricao is a required property for OrigemComercialResponse and cannot be null");
            }
            else
            {
                this.Descricao = Descricao;
            }
            // to ensure "ProdutosOrigem" is required (not null)
            if (ProdutosOrigem == null)
            {
                throw new InvalidDataException("ProdutosOrigem is a required property for OrigemComercialResponse and cannot be null");
            }
            else
            {
                this.ProdutosOrigem = ProdutosOrigem;
            }
            // to ensure "IdEstabelecimento" is required (not null)
            if (IdEstabelecimento == null)
            {
                throw new InvalidDataException("IdEstabelecimento is a required property for OrigemComercialResponse and cannot be null");
            }
            else
            {
                this.IdEstabelecimento = IdEstabelecimento;
            }
            // to ensure "IdTipoOrigemComercial" is required (not null)
            if (IdTipoOrigemComercial == null)
            {
                throw new InvalidDataException("IdTipoOrigemComercial is a required property for OrigemComercialResponse and cannot be null");
            }
            else
            {
                this.IdTipoOrigemComercial = IdTipoOrigemComercial;
            }
            // to ensure "NomeTipoOrigemComercial" is required (not null)
            if (NomeTipoOrigemComercial == null)
            {
                throw new InvalidDataException("NomeTipoOrigemComercial is a required property for OrigemComercialResponse and cannot be null");
            }
            else
            {
                this.NomeTipoOrigemComercial = NomeTipoOrigemComercial;
            }
            // to ensure "IdGrupoOrigemComercial" is required (not null)
            if (IdGrupoOrigemComercial == null)
            {
                throw new InvalidDataException("IdGrupoOrigemComercial is a required property for OrigemComercialResponse and cannot be null");
            }
            else
            {
                this.IdGrupoOrigemComercial = IdGrupoOrigemComercial;
            }
            // to ensure "NomeGrupoOrigemComercial" is required (not null)
            if (NomeGrupoOrigemComercial == null)
            {
                throw new InvalidDataException("NomeGrupoOrigemComercial is a required property for OrigemComercialResponse and cannot be null");
            }
            else
            {
                this.NomeGrupoOrigemComercial = NomeGrupoOrigemComercial;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for OrigemComercialResponse and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Nome da origem comercial
        /// </summary>
        /// <value>Nome da origem comercial</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Descri\u00C3\u00A7\u00C3\u00A3o completa do nome da Origem Comercial
        /// </summary>
        /// <value>Descri\u00C3\u00A7\u00C3\u00A3o completa do nome da Origem Comercial</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Lista de  ProdutosOrigem associados \u00C3\u00A0 Origem comercial
        /// </summary>
        /// <value>Lista de  ProdutosOrigem associados \u00C3\u00A0 Origem comercial</value>
        [DataMember(Name="produtosOrigem", EmitDefaultValue=false)]
        public List<ProdutoOrigemResponse> ProdutosOrigem { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento</value>
        [DataMember(Name="idEstabelecimento", EmitDefaultValue=false)]
        public long? IdEstabelecimento { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Tipo da Origem Comercial
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Tipo da Origem Comercial</value>
        [DataMember(Name="idTipoOrigemComercial", EmitDefaultValue=false)]
        public long? IdTipoOrigemComercial { get; set; }
    
        /// <summary>
        /// Nome do Tipo da Origem Comercial
        /// </summary>
        /// <value>Nome do Tipo da Origem Comercial</value>
        [DataMember(Name="nomeTipoOrigemComercial", EmitDefaultValue=false)]
        public string NomeTipoOrigemComercial { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Grupo a qual a Origem Comercial pertence
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do Grupo a qual a Origem Comercial pertence</value>
        [DataMember(Name="idGrupoOrigemComercial", EmitDefaultValue=false)]
        public long? IdGrupoOrigemComercial { get; set; }
    
        /// <summary>
        /// Nome do Grupo a qual a Origem Comercial pertence
        /// </summary>
        /// <value>Nome do Grupo a qual a Origem Comercial pertence</value>
        [DataMember(Name="nomeGrupoOrigemComercial", EmitDefaultValue=false)]
        public string NomeGrupoOrigemComercial { get; set; }
    
        /// <summary>
        /// Status da origem comercial
        /// </summary>
        /// <value>Status da origem comercial</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public bool? Status { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrigemComercialResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  ProdutosOrigem: ").Append(ProdutosOrigem).Append("\n");
            sb.Append("  IdEstabelecimento: ").Append(IdEstabelecimento).Append("\n");
            sb.Append("  IdTipoOrigemComercial: ").Append(IdTipoOrigemComercial).Append("\n");
            sb.Append("  NomeTipoOrigemComercial: ").Append(NomeTipoOrigemComercial).Append("\n");
            sb.Append("  IdGrupoOrigemComercial: ").Append(IdGrupoOrigemComercial).Append("\n");
            sb.Append("  NomeGrupoOrigemComercial: ").Append(NomeGrupoOrigemComercial).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            
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
            return this.Equals(obj as OrigemComercialResponse);
        }

        /// <summary>
        /// Returns true if OrigemComercialResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of OrigemComercialResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrigemComercialResponse other)
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
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.ProdutosOrigem == other.ProdutosOrigem ||
                    this.ProdutosOrigem != null &&
                    this.ProdutosOrigem.SequenceEqual(other.ProdutosOrigem)
                ) && 
                (
                    this.IdEstabelecimento == other.IdEstabelecimento ||
                    this.IdEstabelecimento != null &&
                    this.IdEstabelecimento.Equals(other.IdEstabelecimento)
                ) && 
                (
                    this.IdTipoOrigemComercial == other.IdTipoOrigemComercial ||
                    this.IdTipoOrigemComercial != null &&
                    this.IdTipoOrigemComercial.Equals(other.IdTipoOrigemComercial)
                ) && 
                (
                    this.NomeTipoOrigemComercial == other.NomeTipoOrigemComercial ||
                    this.NomeTipoOrigemComercial != null &&
                    this.NomeTipoOrigemComercial.Equals(other.NomeTipoOrigemComercial)
                ) && 
                (
                    this.IdGrupoOrigemComercial == other.IdGrupoOrigemComercial ||
                    this.IdGrupoOrigemComercial != null &&
                    this.IdGrupoOrigemComercial.Equals(other.IdGrupoOrigemComercial)
                ) && 
                (
                    this.NomeGrupoOrigemComercial == other.NomeGrupoOrigemComercial ||
                    this.NomeGrupoOrigemComercial != null &&
                    this.NomeGrupoOrigemComercial.Equals(other.NomeGrupoOrigemComercial)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.ProdutosOrigem != null)
                    hash = hash * 59 + this.ProdutosOrigem.GetHashCode();
                
                if (this.IdEstabelecimento != null)
                    hash = hash * 59 + this.IdEstabelecimento.GetHashCode();
                
                if (this.IdTipoOrigemComercial != null)
                    hash = hash * 59 + this.IdTipoOrigemComercial.GetHashCode();
                
                if (this.NomeTipoOrigemComercial != null)
                    hash = hash * 59 + this.NomeTipoOrigemComercial.GetHashCode();
                
                if (this.IdGrupoOrigemComercial != null)
                    hash = hash * 59 + this.IdGrupoOrigemComercial.GetHashCode();
                
                if (this.NomeGrupoOrigemComercial != null)
                    hash = hash * 59 + this.NomeGrupoOrigemComercial.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }
}
