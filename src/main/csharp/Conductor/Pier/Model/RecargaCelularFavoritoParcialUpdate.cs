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
    /// Objeto da atualiza\u00E7\u00E3o parcial de favorito de recarga de celular
    /// </summary>
    [DataContract]
    public partial class RecargaCelularFavoritoParcialUpdate :  IEquatable<RecargaCelularFavoritoParcialUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RecargaCelularFavoritoParcialUpdate" /> class.
        /// Initializes a new instance of the <see cref="RecargaCelularFavoritoParcialUpdate" />class.
        /// </summary>
        /// <param name="DddCelular">DDD do celular.</param>
        /// <param name="NumeroCelular">N\u00FAmero do celular.</param>
        /// <param name="Nome">Nome do propriet\u00E1rio do celular.</param>
        /// <param name="Ativo">Indicador de status do favorito.</param>

        public RecargaCelularFavoritoParcialUpdate(string DddCelular = null, string NumeroCelular = null, string Nome = null, bool? Ativo = null)
        {
            this.DddCelular = DddCelular;
            this.NumeroCelular = NumeroCelular;
            this.Nome = Nome;
            this.Ativo = Ativo;
            
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
        /// Nome do propriet\u00E1rio do celular
        /// </summary>
        /// <value>Nome do propriet\u00E1rio do celular</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Indicador de status do favorito
        /// </summary>
        /// <value>Indicador de status do favorito</value>
        [DataMember(Name="ativo", EmitDefaultValue=false)]
        public bool? Ativo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecargaCelularFavoritoParcialUpdate {\n");
            sb.Append("  DddCelular: ").Append(DddCelular).Append("\n");
            sb.Append("  NumeroCelular: ").Append(NumeroCelular).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Ativo: ").Append(Ativo).Append("\n");
            
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
            return this.Equals(obj as RecargaCelularFavoritoParcialUpdate);
        }

        /// <summary>
        /// Returns true if RecargaCelularFavoritoParcialUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of RecargaCelularFavoritoParcialUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecargaCelularFavoritoParcialUpdate other)
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
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.Ativo == other.Ativo ||
                    this.Ativo != null &&
                    this.Ativo.Equals(other.Ativo)
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
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.Ativo != null)
                    hash = hash * 59 + this.Ativo.GetHashCode();
                
                return hash;
            }
        }

    }
}
