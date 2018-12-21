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
    /// Response Representation of the country resource
    /// </summary>
    [DataContract]
    public partial class PaisResponse :  IEquatable<PaisResponse>
    { 
    
        /// <summary>
        /// Continent which the country takes part
        /// </summary>
        /// <value>Continent which the country takes part</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ContinenteEnum {
            
            [EnumMember(Value = "AFRICA")]
            Africa,
            
            [EnumMember(Value = "AMERICA_LATINA")]
            AmericaLatina,
            
            [EnumMember(Value = "AMERICA_NORTE")]
            AmericaNorte,
            
            [EnumMember(Value = "ASIA")]
            Asia,
            
            [EnumMember(Value = "ANTARTIDA")]
            Antartida,
            
            [EnumMember(Value = "EUROPA")]
            Europa,
            
            [EnumMember(Value = "OCEANIA")]
            Oceania
        }

    
        /// <summary>
        /// Continent which the country takes part
        /// </summary>
        /// <value>Continent which the country takes part</value>
        [DataMember(Name="continente", EmitDefaultValue=false)]
        public ContinenteEnum? Continente { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PaisResponse" /> class.
        /// Initializes a new instance of the <see cref="PaisResponse" />class.
        /// </summary>
        /// <param name="Id">Unique Identifier Code of the country in the base.</param>
        /// <param name="Codigo">Identifier Code of the Country.</param>
        /// <param name="Sigla">Country Acronym.</param>
        /// <param name="Descricao">Country Name.</param>
        /// <param name="Continente">Continent which the country takes part.</param>
        /// <param name="FlagAtivo">Attribute that represents if the country is active.</param>

        public PaisResponse(long? Id = null, string Codigo = null, string Sigla = null, string Descricao = null, ContinenteEnum? Continente = null, bool? FlagAtivo = null)
        {
            this.Id = Id;
            this.Codigo = Codigo;
            this.Sigla = Sigla;
            this.Descricao = Descricao;
            this.Continente = Continente;
            this.FlagAtivo = FlagAtivo;
            
        }
        
    
        /// <summary>
        /// Unique Identifier Code of the country in the base
        /// </summary>
        /// <value>Unique Identifier Code of the country in the base</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Identifier Code of the Country
        /// </summary>
        /// <value>Identifier Code of the Country</value>
        [DataMember(Name="codigo", EmitDefaultValue=false)]
        public string Codigo { get; set; }
    
        /// <summary>
        /// Country Acronym
        /// </summary>
        /// <value>Country Acronym</value>
        [DataMember(Name="sigla", EmitDefaultValue=false)]
        public string Sigla { get; set; }
    
        /// <summary>
        /// Country Name
        /// </summary>
        /// <value>Country Name</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Attribute that represents if the country is active
        /// </summary>
        /// <value>Attribute that represents if the country is active</value>
        [DataMember(Name="flagAtivo", EmitDefaultValue=false)]
        public bool? FlagAtivo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaisResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Codigo: ").Append(Codigo).Append("\n");
            sb.Append("  Sigla: ").Append(Sigla).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  Continente: ").Append(Continente).Append("\n");
            sb.Append("  FlagAtivo: ").Append(FlagAtivo).Append("\n");
            
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
            return this.Equals(obj as PaisResponse);
        }

        /// <summary>
        /// Returns true if PaisResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PaisResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaisResponse other)
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
                    this.Codigo == other.Codigo ||
                    this.Codigo != null &&
                    this.Codigo.Equals(other.Codigo)
                ) && 
                (
                    this.Sigla == other.Sigla ||
                    this.Sigla != null &&
                    this.Sigla.Equals(other.Sigla)
                ) && 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.Continente == other.Continente ||
                    this.Continente != null &&
                    this.Continente.Equals(other.Continente)
                ) && 
                (
                    this.FlagAtivo == other.FlagAtivo ||
                    this.FlagAtivo != null &&
                    this.FlagAtivo.Equals(other.FlagAtivo)
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
                
                if (this.Codigo != null)
                    hash = hash * 59 + this.Codigo.GetHashCode();
                
                if (this.Sigla != null)
                    hash = hash * 59 + this.Sigla.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.Continente != null)
                    hash = hash * 59 + this.Continente.GetHashCode();
                
                if (this.FlagAtivo != null)
                    hash = hash * 59 + this.FlagAtivo.GetHashCode();
                
                return hash;
            }
        }

    }
}
