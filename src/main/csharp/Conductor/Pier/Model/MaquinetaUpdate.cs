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
    /// {{{maquineta_update_description}}}
    /// </summary>
    [DataContract]
    public partial class MaquinetaUpdate :  IEquatable<MaquinetaUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MaquinetaUpdate" /> class.
        /// Initializes a new instance of the <see cref="MaquinetaUpdate" />class.
        /// </summary>
        /// <param name="IdTerminal">{{{maquineta_update_id_terminal_value}}} (required).</param>
        /// <param name="IdTipoMaquineta">{{{maquineta_update_id_tipo_maquineta_value}}} (required).</param>
        /// <param name="Valor">{{{maquineta_update_valor_value}}} (required).</param>
        /// <param name="DataHoraImplantacao">{{{maquineta_update_data_hora_implantacao_value}}} (required).</param>

        public MaquinetaUpdate(long? IdTerminal = null, long? IdTipoMaquineta = null, double? Valor = null, string DataHoraImplantacao = null)
        {
            // to ensure "IdTerminal" is required (not null)
            if (IdTerminal == null)
            {
                throw new InvalidDataException("IdTerminal is a required property for MaquinetaUpdate and cannot be null");
            }
            else
            {
                this.IdTerminal = IdTerminal;
            }
            // to ensure "IdTipoMaquineta" is required (not null)
            if (IdTipoMaquineta == null)
            {
                throw new InvalidDataException("IdTipoMaquineta is a required property for MaquinetaUpdate and cannot be null");
            }
            else
            {
                this.IdTipoMaquineta = IdTipoMaquineta;
            }
            // to ensure "Valor" is required (not null)
            if (Valor == null)
            {
                throw new InvalidDataException("Valor is a required property for MaquinetaUpdate and cannot be null");
            }
            else
            {
                this.Valor = Valor;
            }
            // to ensure "DataHoraImplantacao" is required (not null)
            if (DataHoraImplantacao == null)
            {
                throw new InvalidDataException("DataHoraImplantacao is a required property for MaquinetaUpdate and cannot be null");
            }
            else
            {
                this.DataHoraImplantacao = DataHoraImplantacao;
            }
            
        }
        
    
        /// <summary>
        /// {{{maquineta_update_id_terminal_value}}}
        /// </summary>
        /// <value>{{{maquineta_update_id_terminal_value}}}</value>
        [DataMember(Name="idTerminal", EmitDefaultValue=false)]
        public long? IdTerminal { get; set; }
    
        /// <summary>
        /// {{{maquineta_update_id_tipo_maquineta_value}}}
        /// </summary>
        /// <value>{{{maquineta_update_id_tipo_maquineta_value}}}</value>
        [DataMember(Name="idTipoMaquineta", EmitDefaultValue=false)]
        public long? IdTipoMaquineta { get; set; }
    
        /// <summary>
        /// {{{maquineta_update_valor_value}}}
        /// </summary>
        /// <value>{{{maquineta_update_valor_value}}}</value>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }
    
        /// <summary>
        /// {{{maquineta_update_data_hora_implantacao_value}}}
        /// </summary>
        /// <value>{{{maquineta_update_data_hora_implantacao_value}}}</value>
        [DataMember(Name="dataHoraImplantacao", EmitDefaultValue=false)]
        public string DataHoraImplantacao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MaquinetaUpdate {\n");
            sb.Append("  IdTerminal: ").Append(IdTerminal).Append("\n");
            sb.Append("  IdTipoMaquineta: ").Append(IdTipoMaquineta).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  DataHoraImplantacao: ").Append(DataHoraImplantacao).Append("\n");
            
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
            return this.Equals(obj as MaquinetaUpdate);
        }

        /// <summary>
        /// Returns true if MaquinetaUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of MaquinetaUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MaquinetaUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdTerminal == other.IdTerminal ||
                    this.IdTerminal != null &&
                    this.IdTerminal.Equals(other.IdTerminal)
                ) && 
                (
                    this.IdTipoMaquineta == other.IdTipoMaquineta ||
                    this.IdTipoMaquineta != null &&
                    this.IdTipoMaquineta.Equals(other.IdTipoMaquineta)
                ) && 
                (
                    this.Valor == other.Valor ||
                    this.Valor != null &&
                    this.Valor.Equals(other.Valor)
                ) && 
                (
                    this.DataHoraImplantacao == other.DataHoraImplantacao ||
                    this.DataHoraImplantacao != null &&
                    this.DataHoraImplantacao.Equals(other.DataHoraImplantacao)
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
                
                if (this.IdTerminal != null)
                    hash = hash * 59 + this.IdTerminal.GetHashCode();
                
                if (this.IdTipoMaquineta != null)
                    hash = hash * 59 + this.IdTipoMaquineta.GetHashCode();
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
                if (this.DataHoraImplantacao != null)
                    hash = hash * 59 + this.DataHoraImplantacao.GetHashCode();
                
                return hash;
            }
        }

    }
}
