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
    /// Objeto que representa um tipo de opera\u00E7\u00E3o banc\u00E1ria
    /// </summary>
    [DataContract]
    public partial class TipoOperacaoBancariaResponse :  IEquatable<TipoOperacaoBancariaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoOperacaoBancariaResponse" /> class.
        /// Initializes a new instance of the <see cref="TipoOperacaoBancariaResponse" />class.
        /// </summary>
        /// <param name="Descricao">Descri\u00E7\u00E3o do tipo de opera\u00E7\u00E3o banc\u00E1ria.</param>
        /// <param name="HorarioMaximo">Hor\u00E1rio m\u00E1ximo que pode ser realizada uma opera\u00E7\u00E3o.</param>
        /// <param name="HorarioMinimo">Hor\u00E1rio m\u00EDnimo que pode ser realizada uma opera\u00E7\u00E3o.</param>
        /// <param name="Id">C\u00F3digo identificador do tipo de opera\u00E7\u00E3o banc\u00E1ria.</param>
        /// <param name="IdTipoTemplate">C\u00F3digo identificador do tipo do template.</param>

        public TipoOperacaoBancariaResponse(string Descricao = null, string HorarioMaximo = null, string HorarioMinimo = null, long? Id = null, long? IdTipoTemplate = null)
        {
            this.Descricao = Descricao;
            this.HorarioMaximo = HorarioMaximo;
            this.HorarioMinimo = HorarioMinimo;
            this.Id = Id;
            this.IdTipoTemplate = IdTipoTemplate;
            
        }
        
    
        /// <summary>
        /// Descri\u00E7\u00E3o do tipo de opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do tipo de opera\u00E7\u00E3o banc\u00E1ria</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Hor\u00E1rio m\u00E1ximo que pode ser realizada uma opera\u00E7\u00E3o
        /// </summary>
        /// <value>Hor\u00E1rio m\u00E1ximo que pode ser realizada uma opera\u00E7\u00E3o</value>
        [DataMember(Name="horarioMaximo", EmitDefaultValue=false)]
        public string HorarioMaximo { get; set; }
    
        /// <summary>
        /// Hor\u00E1rio m\u00EDnimo que pode ser realizada uma opera\u00E7\u00E3o
        /// </summary>
        /// <value>Hor\u00E1rio m\u00EDnimo que pode ser realizada uma opera\u00E7\u00E3o</value>
        [DataMember(Name="horarioMinimo", EmitDefaultValue=false)]
        public string HorarioMinimo { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador do tipo de opera\u00E7\u00E3o banc\u00E1ria
        /// </summary>
        /// <value>C\u00F3digo identificador do tipo de opera\u00E7\u00E3o banc\u00E1ria</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador do tipo do template
        /// </summary>
        /// <value>C\u00F3digo identificador do tipo do template</value>
        [DataMember(Name="idTipoTemplate", EmitDefaultValue=false)]
        public long? IdTipoTemplate { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoOperacaoBancariaResponse {\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  HorarioMaximo: ").Append(HorarioMaximo).Append("\n");
            sb.Append("  HorarioMinimo: ").Append(HorarioMinimo).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdTipoTemplate: ").Append(IdTipoTemplate).Append("\n");
            
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
            return this.Equals(obj as TipoOperacaoBancariaResponse);
        }

        /// <summary>
        /// Returns true if TipoOperacaoBancariaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoOperacaoBancariaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoOperacaoBancariaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.HorarioMaximo == other.HorarioMaximo ||
                    this.HorarioMaximo != null &&
                    this.HorarioMaximo.Equals(other.HorarioMaximo)
                ) && 
                (
                    this.HorarioMinimo == other.HorarioMinimo ||
                    this.HorarioMinimo != null &&
                    this.HorarioMinimo.Equals(other.HorarioMinimo)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdTipoTemplate == other.IdTipoTemplate ||
                    this.IdTipoTemplate != null &&
                    this.IdTipoTemplate.Equals(other.IdTipoTemplate)
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
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.HorarioMaximo != null)
                    hash = hash * 59 + this.HorarioMaximo.GetHashCode();
                
                if (this.HorarioMinimo != null)
                    hash = hash * 59 + this.HorarioMinimo.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdTipoTemplate != null)
                    hash = hash * 59 + this.IdTipoTemplate.GetHashCode();
                
                return hash;
            }
        }

    }
}
