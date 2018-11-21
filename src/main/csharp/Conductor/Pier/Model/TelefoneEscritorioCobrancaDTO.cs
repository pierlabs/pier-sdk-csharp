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
    /// {{{telefone_escritorio_cobranca_d_t_o_description}}}
    /// </summary>
    [DataContract]
    public partial class TelefoneEscritorioCobrancaDTO :  IEquatable<TelefoneEscritorioCobrancaDTO>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TelefoneEscritorioCobrancaDTO" /> class.
        /// Initializes a new instance of the <see cref="TelefoneEscritorioCobrancaDTO" />class.
        /// </summary>
        /// <param name="IdCredor">{{{telefone_escritorio_cobranca_d_t_o_id_credor_value}}} (required).</param>
        /// <param name="Ddd">{{{telefone_escritorio_cobranca_d_t_o_ddd_value}}} (required).</param>
        /// <param name="Telefone">{{{telefone_escritorio_cobranca_d_t_o_telefone_value}}} (required).</param>
        /// <param name="Ramal">{{{telefone_escritorio_cobranca_d_t_o_ramal_value}}}.</param>

        public TelefoneEscritorioCobrancaDTO(long? IdCredor = null, string Ddd = null, string Telefone = null, string Ramal = null)
        {
            // to ensure "IdCredor" is required (not null)
            if (IdCredor == null)
            {
                throw new InvalidDataException("IdCredor is a required property for TelefoneEscritorioCobrancaDTO and cannot be null");
            }
            else
            {
                this.IdCredor = IdCredor;
            }
            // to ensure "Ddd" is required (not null)
            if (Ddd == null)
            {
                throw new InvalidDataException("Ddd is a required property for TelefoneEscritorioCobrancaDTO and cannot be null");
            }
            else
            {
                this.Ddd = Ddd;
            }
            // to ensure "Telefone" is required (not null)
            if (Telefone == null)
            {
                throw new InvalidDataException("Telefone is a required property for TelefoneEscritorioCobrancaDTO and cannot be null");
            }
            else
            {
                this.Telefone = Telefone;
            }
            this.Ramal = Ramal;
            
        }
        
    
        /// <summary>
        /// {{{telefone_escritorio_cobranca_d_t_o_id_credor_value}}}
        /// </summary>
        /// <value>{{{telefone_escritorio_cobranca_d_t_o_id_credor_value}}}</value>
        [DataMember(Name="idCredor", EmitDefaultValue=false)]
        public long? IdCredor { get; set; }
    
        /// <summary>
        /// {{{telefone_escritorio_cobranca_d_t_o_ddd_value}}}
        /// </summary>
        /// <value>{{{telefone_escritorio_cobranca_d_t_o_ddd_value}}}</value>
        [DataMember(Name="ddd", EmitDefaultValue=false)]
        public string Ddd { get; set; }
    
        /// <summary>
        /// {{{telefone_escritorio_cobranca_d_t_o_telefone_value}}}
        /// </summary>
        /// <value>{{{telefone_escritorio_cobranca_d_t_o_telefone_value}}}</value>
        [DataMember(Name="telefone", EmitDefaultValue=false)]
        public string Telefone { get; set; }
    
        /// <summary>
        /// {{{telefone_escritorio_cobranca_d_t_o_ramal_value}}}
        /// </summary>
        /// <value>{{{telefone_escritorio_cobranca_d_t_o_ramal_value}}}</value>
        [DataMember(Name="ramal", EmitDefaultValue=false)]
        public string Ramal { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TelefoneEscritorioCobrancaDTO {\n");
            sb.Append("  IdCredor: ").Append(IdCredor).Append("\n");
            sb.Append("  Ddd: ").Append(Ddd).Append("\n");
            sb.Append("  Telefone: ").Append(Telefone).Append("\n");
            sb.Append("  Ramal: ").Append(Ramal).Append("\n");
            
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
            return this.Equals(obj as TelefoneEscritorioCobrancaDTO);
        }

        /// <summary>
        /// Returns true if TelefoneEscritorioCobrancaDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of TelefoneEscritorioCobrancaDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TelefoneEscritorioCobrancaDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdCredor == other.IdCredor ||
                    this.IdCredor != null &&
                    this.IdCredor.Equals(other.IdCredor)
                ) && 
                (
                    this.Ddd == other.Ddd ||
                    this.Ddd != null &&
                    this.Ddd.Equals(other.Ddd)
                ) && 
                (
                    this.Telefone == other.Telefone ||
                    this.Telefone != null &&
                    this.Telefone.Equals(other.Telefone)
                ) && 
                (
                    this.Ramal == other.Ramal ||
                    this.Ramal != null &&
                    this.Ramal.Equals(other.Ramal)
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
                
                if (this.IdCredor != null)
                    hash = hash * 59 + this.IdCredor.GetHashCode();
                
                if (this.Ddd != null)
                    hash = hash * 59 + this.Ddd.GetHashCode();
                
                if (this.Telefone != null)
                    hash = hash * 59 + this.Telefone.GetHashCode();
                
                if (this.Ramal != null)
                    hash = hash * 59 + this.Ramal.GetHashCode();
                
                return hash;
            }
        }

    }
}
