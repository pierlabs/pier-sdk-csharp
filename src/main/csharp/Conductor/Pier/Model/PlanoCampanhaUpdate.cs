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
    /// Objeto PlanoCampanha
    /// </summary>
    [DataContract]
    public partial class PlanoCampanhaUpdate :  IEquatable<PlanoCampanhaUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanoCampanhaUpdate" /> class.
        /// Initializes a new instance of the <see cref="PlanoCampanhaUpdate" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo identificador do plano campanha.</param>
        /// <param name="Parcelas">Quantidade de parcelas.</param>
        /// <param name="Taxa">Taxa de juros.</param>
        /// <param name="Usuario">Nome do usu\u00C3\u00A1rio.</param>

        public PlanoCampanhaUpdate(long? Id = null, int? Parcelas = null, double? Taxa = null, string Usuario = null)
        {
            this.Id = Id;
            this.Parcelas = Parcelas;
            this.Taxa = Taxa;
            this.Usuario = Usuario;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador do plano campanha
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador do plano campanha</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Quantidade de parcelas
        /// </summary>
        /// <value>Quantidade de parcelas</value>
        [DataMember(Name="parcelas", EmitDefaultValue=false)]
        public int? Parcelas { get; set; }
    
        /// <summary>
        /// Taxa de juros
        /// </summary>
        /// <value>Taxa de juros</value>
        [DataMember(Name="taxa", EmitDefaultValue=false)]
        public double? Taxa { get; set; }
    
        /// <summary>
        /// Nome do usu\u00C3\u00A1rio
        /// </summary>
        /// <value>Nome do usu\u00C3\u00A1rio</value>
        [DataMember(Name="usuario", EmitDefaultValue=false)]
        public string Usuario { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlanoCampanhaUpdate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Parcelas: ").Append(Parcelas).Append("\n");
            sb.Append("  Taxa: ").Append(Taxa).Append("\n");
            sb.Append("  Usuario: ").Append(Usuario).Append("\n");
            
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
            return this.Equals(obj as PlanoCampanhaUpdate);
        }

        /// <summary>
        /// Returns true if PlanoCampanhaUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of PlanoCampanhaUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlanoCampanhaUpdate other)
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
                    this.Parcelas == other.Parcelas ||
                    this.Parcelas != null &&
                    this.Parcelas.Equals(other.Parcelas)
                ) && 
                (
                    this.Taxa == other.Taxa ||
                    this.Taxa != null &&
                    this.Taxa.Equals(other.Taxa)
                ) && 
                (
                    this.Usuario == other.Usuario ||
                    this.Usuario != null &&
                    this.Usuario.Equals(other.Usuario)
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
                
                if (this.Parcelas != null)
                    hash = hash * 59 + this.Parcelas.GetHashCode();
                
                if (this.Taxa != null)
                    hash = hash * 59 + this.Taxa.GetHashCode();
                
                if (this.Usuario != null)
                    hash = hash * 59 + this.Usuario.GetHashCode();
                
                return hash;
            }
        }

    }
}
