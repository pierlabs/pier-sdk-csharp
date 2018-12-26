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
    /// Objeto VinculoEstabelecimentoPersist
    /// </summary>
    [DataContract]
    public partial class VinculoEstabelecimentoAdquirentePersist :  IEquatable<VinculoEstabelecimentoAdquirentePersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VinculoEstabelecimentoAdquirentePersist" /> class.
        /// Initializes a new instance of the <see cref="VinculoEstabelecimentoAdquirentePersist" />class.
        /// </summary>
        /// <param name="IdEstabelecimento">Apresenta o id do estabelecimento (required).</param>
        /// <param name="IdAdquirente">Apresenta o id do adquirente (required).</param>
        /// <param name="CodigoEstabelecimentoAdquirente">Apresenta o c\u00F3digo de v\u00EDnculo entre o estabelecimento e o adquirente (required).</param>

        public VinculoEstabelecimentoAdquirentePersist(long? IdEstabelecimento = null, long? IdAdquirente = null, string CodigoEstabelecimentoAdquirente = null)
        {
            // to ensure "IdEstabelecimento" is required (not null)
            if (IdEstabelecimento == null)
            {
                throw new InvalidDataException("IdEstabelecimento is a required property for VinculoEstabelecimentoAdquirentePersist and cannot be null");
            }
            else
            {
                this.IdEstabelecimento = IdEstabelecimento;
            }
            // to ensure "IdAdquirente" is required (not null)
            if (IdAdquirente == null)
            {
                throw new InvalidDataException("IdAdquirente is a required property for VinculoEstabelecimentoAdquirentePersist and cannot be null");
            }
            else
            {
                this.IdAdquirente = IdAdquirente;
            }
            // to ensure "CodigoEstabelecimentoAdquirente" is required (not null)
            if (CodigoEstabelecimentoAdquirente == null)
            {
                throw new InvalidDataException("CodigoEstabelecimentoAdquirente is a required property for VinculoEstabelecimentoAdquirentePersist and cannot be null");
            }
            else
            {
                this.CodigoEstabelecimentoAdquirente = CodigoEstabelecimentoAdquirente;
            }
            
        }
        
    
        /// <summary>
        /// Apresenta o id do estabelecimento
        /// </summary>
        /// <value>Apresenta o id do estabelecimento</value>
        [DataMember(Name="idEstabelecimento", EmitDefaultValue=false)]
        public long? IdEstabelecimento { get; set; }
    
        /// <summary>
        /// Apresenta o id do adquirente
        /// </summary>
        /// <value>Apresenta o id do adquirente</value>
        [DataMember(Name="idAdquirente", EmitDefaultValue=false)]
        public long? IdAdquirente { get; set; }
    
        /// <summary>
        /// Apresenta o c\u00F3digo de v\u00EDnculo entre o estabelecimento e o adquirente
        /// </summary>
        /// <value>Apresenta o c\u00F3digo de v\u00EDnculo entre o estabelecimento e o adquirente</value>
        [DataMember(Name="codigoEstabelecimentoAdquirente", EmitDefaultValue=false)]
        public string CodigoEstabelecimentoAdquirente { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VinculoEstabelecimentoAdquirentePersist {\n");
            sb.Append("  IdEstabelecimento: ").Append(IdEstabelecimento).Append("\n");
            sb.Append("  IdAdquirente: ").Append(IdAdquirente).Append("\n");
            sb.Append("  CodigoEstabelecimentoAdquirente: ").Append(CodigoEstabelecimentoAdquirente).Append("\n");
            
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
            return this.Equals(obj as VinculoEstabelecimentoAdquirentePersist);
        }

        /// <summary>
        /// Returns true if VinculoEstabelecimentoAdquirentePersist instances are equal
        /// </summary>
        /// <param name="other">Instance of VinculoEstabelecimentoAdquirentePersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VinculoEstabelecimentoAdquirentePersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdEstabelecimento == other.IdEstabelecimento ||
                    this.IdEstabelecimento != null &&
                    this.IdEstabelecimento.Equals(other.IdEstabelecimento)
                ) && 
                (
                    this.IdAdquirente == other.IdAdquirente ||
                    this.IdAdquirente != null &&
                    this.IdAdquirente.Equals(other.IdAdquirente)
                ) && 
                (
                    this.CodigoEstabelecimentoAdquirente == other.CodigoEstabelecimentoAdquirente ||
                    this.CodigoEstabelecimentoAdquirente != null &&
                    this.CodigoEstabelecimentoAdquirente.Equals(other.CodigoEstabelecimentoAdquirente)
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
                
                if (this.IdEstabelecimento != null)
                    hash = hash * 59 + this.IdEstabelecimento.GetHashCode();
                
                if (this.IdAdquirente != null)
                    hash = hash * 59 + this.IdAdquirente.GetHashCode();
                
                if (this.CodigoEstabelecimentoAdquirente != null)
                    hash = hash * 59 + this.CodigoEstabelecimentoAdquirente.GetHashCode();
                
                return hash;
            }
        }

    }
}
