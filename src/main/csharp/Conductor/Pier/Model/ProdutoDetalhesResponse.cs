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
    /// ProdutoDetalhes
    /// </summary>
    [DataContract]
    public partial class ProdutoDetalhesResponse :  IEquatable<ProdutoDetalhesResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProdutoDetalhesResponse" /> class.
        /// Initializes a new instance of the <see cref="ProdutoDetalhesResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id) (required).</param>
        /// <param name="Nome">Descri\u00E7\u00E3o do Nome do Produto (required).</param>
        /// <param name="Status">Representa o Status do Produto, onde: (&#39;0&#39;: Inativo), (&#39;1&#39;: Ativo) (required).</param>
        /// <param name="IdFantasiaBasica">C\u00F3digo de Identifica\u00E7\u00E3o da Fantasia B\u00E1sica (id) a qual o produto pertence.</param>
        /// <param name="FantasiaBasica">Descri\u00E7\u00E3o da Fantasia B\u00E1sica a qual o produto pertence.</param>
        /// <param name="IdBandeira">C\u00F3digo de identifica\u00E7\u00E3o da bandeira.</param>
        /// <param name="UsoExterior">Par\u00E2metro que indica se o produto est\u00E1 habilitado para compras no exterior.</param>

        public ProdutoDetalhesResponse(long? Id = null, string Nome = null, int? Status = null, long? IdFantasiaBasica = null, string FantasiaBasica = null, long? IdBandeira = null, bool? UsoExterior = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for ProdutoDetalhesResponse and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Nome" is required (not null)
            if (Nome == null)
            {
                throw new InvalidDataException("Nome is a required property for ProdutoDetalhesResponse and cannot be null");
            }
            else
            {
                this.Nome = Nome;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for ProdutoDetalhesResponse and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            this.IdFantasiaBasica = IdFantasiaBasica;
            this.FantasiaBasica = FantasiaBasica;
            this.IdBandeira = IdBandeira;
            this.UsoExterior = UsoExterior;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id)
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do Produto (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do Nome do Produto
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do Nome do Produto</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Representa o Status do Produto, onde: (&#39;0&#39;: Inativo), (&#39;1&#39;: Ativo)
        /// </summary>
        /// <value>Representa o Status do Produto, onde: (&#39;0&#39;: Inativo), (&#39;1&#39;: Ativo)</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da Fantasia B\u00E1sica (id) a qual o produto pertence
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da Fantasia B\u00E1sica (id) a qual o produto pertence</value>
        [DataMember(Name="idFantasiaBasica", EmitDefaultValue=false)]
        public long? IdFantasiaBasica { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o da Fantasia B\u00E1sica a qual o produto pertence
        /// </summary>
        /// <value>Descri\u00E7\u00E3o da Fantasia B\u00E1sica a qual o produto pertence</value>
        [DataMember(Name="fantasiaBasica", EmitDefaultValue=false)]
        public string FantasiaBasica { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da bandeira
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da bandeira</value>
        [DataMember(Name="idBandeira", EmitDefaultValue=false)]
        public long? IdBandeira { get; set; }
    
        /// <summary>
        /// Par\u00E2metro que indica se o produto est\u00E1 habilitado para compras no exterior
        /// </summary>
        /// <value>Par\u00E2metro que indica se o produto est\u00E1 habilitado para compras no exterior</value>
        [DataMember(Name="usoExterior", EmitDefaultValue=false)]
        public bool? UsoExterior { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProdutoDetalhesResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  IdFantasiaBasica: ").Append(IdFantasiaBasica).Append("\n");
            sb.Append("  FantasiaBasica: ").Append(FantasiaBasica).Append("\n");
            sb.Append("  IdBandeira: ").Append(IdBandeira).Append("\n");
            sb.Append("  UsoExterior: ").Append(UsoExterior).Append("\n");
            
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
            return this.Equals(obj as ProdutoDetalhesResponse);
        }

        /// <summary>
        /// Returns true if ProdutoDetalhesResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ProdutoDetalhesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProdutoDetalhesResponse other)
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
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.IdFantasiaBasica == other.IdFantasiaBasica ||
                    this.IdFantasiaBasica != null &&
                    this.IdFantasiaBasica.Equals(other.IdFantasiaBasica)
                ) && 
                (
                    this.FantasiaBasica == other.FantasiaBasica ||
                    this.FantasiaBasica != null &&
                    this.FantasiaBasica.Equals(other.FantasiaBasica)
                ) && 
                (
                    this.IdBandeira == other.IdBandeira ||
                    this.IdBandeira != null &&
                    this.IdBandeira.Equals(other.IdBandeira)
                ) && 
                (
                    this.UsoExterior == other.UsoExterior ||
                    this.UsoExterior != null &&
                    this.UsoExterior.Equals(other.UsoExterior)
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
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.IdFantasiaBasica != null)
                    hash = hash * 59 + this.IdFantasiaBasica.GetHashCode();
                
                if (this.FantasiaBasica != null)
                    hash = hash * 59 + this.FantasiaBasica.GetHashCode();
                
                if (this.IdBandeira != null)
                    hash = hash * 59 + this.IdBandeira.GetHashCode();
                
                if (this.UsoExterior != null)
                    hash = hash * 59 + this.UsoExterior.GetHashCode();
                
                return hash;
            }
        }

    }
}
