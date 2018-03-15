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
    /// Objeto Campanha
    /// </summary>
    [DataContract]
    public partial class CampanhaUpdate :  IEquatable<CampanhaUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CampanhaUpdate" /> class.
        /// Initializes a new instance of the <see cref="CampanhaUpdate" />class.
        /// </summary>
        /// <param name="Nome">Nome da campanha.</param>
        /// <param name="IdTipoCampanha">C\u00F3digo de Identifica\u00E7\u00E3o do tipo da campanha..</param>
        /// <param name="PlanosCampanhas">Lista com os planos de campanha.</param>

        public CampanhaUpdate(string Nome = null, long? IdTipoCampanha = null, List<PlanoCampanhaUpdate> PlanosCampanhas = null)
        {
            this.Nome = Nome;
            this.IdTipoCampanha = IdTipoCampanha;
            this.PlanosCampanhas = PlanosCampanhas;
            
        }
        
    
        /// <summary>
        /// Nome da campanha
        /// </summary>
        /// <value>Nome da campanha</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do tipo da campanha.
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do tipo da campanha.</value>
        [DataMember(Name="idTipoCampanha", EmitDefaultValue=false)]
        public long? IdTipoCampanha { get; set; }
    
        /// <summary>
        /// Lista com os planos de campanha
        /// </summary>
        /// <value>Lista com os planos de campanha</value>
        [DataMember(Name="planosCampanhas", EmitDefaultValue=false)]
        public List<PlanoCampanhaUpdate> PlanosCampanhas { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampanhaUpdate {\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  IdTipoCampanha: ").Append(IdTipoCampanha).Append("\n");
            sb.Append("  PlanosCampanhas: ").Append(PlanosCampanhas).Append("\n");
            
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
            return this.Equals(obj as CampanhaUpdate);
        }

        /// <summary>
        /// Returns true if CampanhaUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of CampanhaUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampanhaUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.IdTipoCampanha == other.IdTipoCampanha ||
                    this.IdTipoCampanha != null &&
                    this.IdTipoCampanha.Equals(other.IdTipoCampanha)
                ) && 
                (
                    this.PlanosCampanhas == other.PlanosCampanhas ||
                    this.PlanosCampanhas != null &&
                    this.PlanosCampanhas.SequenceEqual(other.PlanosCampanhas)
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
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.IdTipoCampanha != null)
                    hash = hash * 59 + this.IdTipoCampanha.GetHashCode();
                
                if (this.PlanosCampanhas != null)
                    hash = hash * 59 + this.PlanosCampanhas.GetHashCode();
                
                return hash;
            }
        }

    }
}
