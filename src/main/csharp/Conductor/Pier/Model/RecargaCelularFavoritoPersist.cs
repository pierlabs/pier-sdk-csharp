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
    /// Objeto de persist\u00EAncia de favorito de recarga de celular
    /// </summary>
    [DataContract]
    public partial class RecargaCelularFavoritoPersist :  IEquatable<RecargaCelularFavoritoPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RecargaCelularFavoritoPersist" /> class.
        /// Initializes a new instance of the <see cref="RecargaCelularFavoritoPersist" />class.
        /// </summary>
        /// <param name="DddCelular">DDD do celular (required).</param>
        /// <param name="NumeroCelular">N\u00FAmero do celular (required).</param>
        /// <param name="Ativo">Indicador de status.</param>
        /// <param name="Nome">Nome do propriet\u00E1rio do celular.</param>
        /// <param name="DescricaoOperadora">Descri\u00E7\u00E3o da operadora.</param>

        public RecargaCelularFavoritoPersist(string DddCelular = null, string NumeroCelular = null, bool? Ativo = null, string Nome = null, string DescricaoOperadora = null)
        {
            // to ensure "DddCelular" is required (not null)
            if (DddCelular == null)
            {
                throw new InvalidDataException("DddCelular is a required property for RecargaCelularFavoritoPersist and cannot be null");
            }
            else
            {
                this.DddCelular = DddCelular;
            }
            // to ensure "NumeroCelular" is required (not null)
            if (NumeroCelular == null)
            {
                throw new InvalidDataException("NumeroCelular is a required property for RecargaCelularFavoritoPersist and cannot be null");
            }
            else
            {
                this.NumeroCelular = NumeroCelular;
            }
            this.Ativo = Ativo;
            this.Nome = Nome;
            this.DescricaoOperadora = DescricaoOperadora;
            
        }
        
    
        /// <summary>
        /// DDD do celular
        /// </summary>
        /// <value>DDD do celular</value>
        [DataMember(Name="dddCelular", EmitDefaultValue=false)]
        public string DddCelular { get; set; }
    
        /// <summary>
        /// N\u00FAmero do celular
        /// </summary>
        /// <value>N\u00FAmero do celular</value>
        [DataMember(Name="numeroCelular", EmitDefaultValue=false)]
        public string NumeroCelular { get; set; }
    
        /// <summary>
        /// Indicador de status
        /// </summary>
        /// <value>Indicador de status</value>
        [DataMember(Name="ativo", EmitDefaultValue=false)]
        public bool? Ativo { get; set; }
    
        /// <summary>
        /// Nome do propriet\u00E1rio do celular
        /// </summary>
        /// <value>Nome do propriet\u00E1rio do celular</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o da operadora
        /// </summary>
        /// <value>Descri\u00E7\u00E3o da operadora</value>
        [DataMember(Name="descricaoOperadora", EmitDefaultValue=false)]
        public string DescricaoOperadora { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecargaCelularFavoritoPersist {\n");
            sb.Append("  DddCelular: ").Append(DddCelular).Append("\n");
            sb.Append("  NumeroCelular: ").Append(NumeroCelular).Append("\n");
            sb.Append("  Ativo: ").Append(Ativo).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  DescricaoOperadora: ").Append(DescricaoOperadora).Append("\n");
            
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
            return this.Equals(obj as RecargaCelularFavoritoPersist);
        }

        /// <summary>
        /// Returns true if RecargaCelularFavoritoPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of RecargaCelularFavoritoPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecargaCelularFavoritoPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DddCelular == other.DddCelular ||
                    this.DddCelular != null &&
                    this.DddCelular.Equals(other.DddCelular)
                ) && 
                (
                    this.NumeroCelular == other.NumeroCelular ||
                    this.NumeroCelular != null &&
                    this.NumeroCelular.Equals(other.NumeroCelular)
                ) && 
                (
                    this.Ativo == other.Ativo ||
                    this.Ativo != null &&
                    this.Ativo.Equals(other.Ativo)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.DescricaoOperadora == other.DescricaoOperadora ||
                    this.DescricaoOperadora != null &&
                    this.DescricaoOperadora.Equals(other.DescricaoOperadora)
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
                
                if (this.DddCelular != null)
                    hash = hash * 59 + this.DddCelular.GetHashCode();
                
                if (this.NumeroCelular != null)
                    hash = hash * 59 + this.NumeroCelular.GetHashCode();
                
                if (this.Ativo != null)
                    hash = hash * 59 + this.Ativo.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.DescricaoOperadora != null)
                    hash = hash * 59 + this.DescricaoOperadora.GetHashCode();
                
                return hash;
            }
        }

    }
}
