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
    /// {{{produto_detalhes_response_description}}}
    /// </summary>
    [DataContract]
    public partial class ProdutoDetalhesResponse :  IEquatable<ProdutoDetalhesResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProdutoDetalhesResponse" /> class.
        /// Initializes a new instance of the <see cref="ProdutoDetalhesResponse" />class.
        /// </summary>
        /// <param name="Id">{{{produto_response_id_value}}} (required).</param>
        /// <param name="Nome">{{{produto_response_nome_value}}} (required).</param>
        /// <param name="Status">{{{produto_response_status_value}}} (required).</param>
        /// <param name="IdFantasiaBasica">{{{produto_response_id_fantasia_basica_value}}}.</param>
        /// <param name="FantasiaBasica">{{{produto_detalhes_response_fantasia_basica_value}}}.</param>
        /// <param name="UsoExterior">{{{produto_detalhes_response_uso_exterior_value}}}.</param>

        public ProdutoDetalhesResponse(long? Id = null, string Nome = null, int? Status = null, long? IdFantasiaBasica = null, string FantasiaBasica = null, bool? UsoExterior = null)
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
            this.UsoExterior = UsoExterior;
            
        }
        
    
        /// <summary>
        /// {{{produto_response_id_value}}}
        /// </summary>
        /// <value>{{{produto_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{produto_response_nome_value}}}
        /// </summary>
        /// <value>{{{produto_response_nome_value}}}</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// {{{produto_response_status_value}}}
        /// </summary>
        /// <value>{{{produto_response_status_value}}}</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
    
        /// <summary>
        /// {{{produto_response_id_fantasia_basica_value}}}
        /// </summary>
        /// <value>{{{produto_response_id_fantasia_basica_value}}}</value>
        [DataMember(Name="idFantasiaBasica", EmitDefaultValue=false)]
        public long? IdFantasiaBasica { get; set; }
    
        /// <summary>
        /// {{{produto_detalhes_response_fantasia_basica_value}}}
        /// </summary>
        /// <value>{{{produto_detalhes_response_fantasia_basica_value}}}</value>
        [DataMember(Name="fantasiaBasica", EmitDefaultValue=false)]
        public string FantasiaBasica { get; set; }
    
        /// <summary>
        /// {{{produto_detalhes_response_uso_exterior_value}}}
        /// </summary>
        /// <value>{{{produto_detalhes_response_uso_exterior_value}}}</value>
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
                
                if (this.UsoExterior != null)
                    hash = hash * 59 + this.UsoExterior.GetHashCode();
                
                return hash;
            }
        }

    }
}
