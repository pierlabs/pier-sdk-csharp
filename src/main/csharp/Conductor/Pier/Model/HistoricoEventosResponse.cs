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
    /// {{{historico_eventos_response_description}}}
    /// </summary>
    [DataContract]
    public partial class HistoricoEventosResponse :  IEquatable<HistoricoEventosResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricoEventosResponse" /> class.
        /// Initializes a new instance of the <see cref="HistoricoEventosResponse" />class.
        /// </summary>
        /// <param name="IdHistorico">{{{historico_eventos_response_id_historico_value}}} (required).</param>
        /// <param name="DataHistorico">{{{historico_eventos_response_data_historico_value}}} (required).</param>
        /// <param name="TipoHistorico">{{{historico_eventos_response_tipo_historico_value}}} (required).</param>
        /// <param name="ValorAnterior">{{{historico_eventos_response_valor_anterior_value}}}.</param>
        /// <param name="ValorAtribuido">{{{historico_eventos_response_valor_atribuido_value}}} (required).</param>

        public HistoricoEventosResponse(long? IdHistorico = null, string DataHistorico = null, string TipoHistorico = null, string ValorAnterior = null, string ValorAtribuido = null)
        {
            // to ensure "IdHistorico" is required (not null)
            if (IdHistorico == null)
            {
                throw new InvalidDataException("IdHistorico is a required property for HistoricoEventosResponse and cannot be null");
            }
            else
            {
                this.IdHistorico = IdHistorico;
            }
            // to ensure "DataHistorico" is required (not null)
            if (DataHistorico == null)
            {
                throw new InvalidDataException("DataHistorico is a required property for HistoricoEventosResponse and cannot be null");
            }
            else
            {
                this.DataHistorico = DataHistorico;
            }
            // to ensure "TipoHistorico" is required (not null)
            if (TipoHistorico == null)
            {
                throw new InvalidDataException("TipoHistorico is a required property for HistoricoEventosResponse and cannot be null");
            }
            else
            {
                this.TipoHistorico = TipoHistorico;
            }
            // to ensure "ValorAtribuido" is required (not null)
            if (ValorAtribuido == null)
            {
                throw new InvalidDataException("ValorAtribuido is a required property for HistoricoEventosResponse and cannot be null");
            }
            else
            {
                this.ValorAtribuido = ValorAtribuido;
            }
            this.ValorAnterior = ValorAnterior;
            
        }
        
    
        /// <summary>
        /// {{{historico_eventos_response_id_historico_value}}}
        /// </summary>
        /// <value>{{{historico_eventos_response_id_historico_value}}}</value>
        [DataMember(Name="idHistorico", EmitDefaultValue=false)]
        public long? IdHistorico { get; set; }
    
        /// <summary>
        /// {{{historico_eventos_response_data_historico_value}}}
        /// </summary>
        /// <value>{{{historico_eventos_response_data_historico_value}}}</value>
        [DataMember(Name="dataHistorico", EmitDefaultValue=false)]
        public string DataHistorico { get; set; }
    
        /// <summary>
        /// {{{historico_eventos_response_tipo_historico_value}}}
        /// </summary>
        /// <value>{{{historico_eventos_response_tipo_historico_value}}}</value>
        [DataMember(Name="tipoHistorico", EmitDefaultValue=false)]
        public string TipoHistorico { get; set; }
    
        /// <summary>
        /// {{{historico_eventos_response_valor_anterior_value}}}
        /// </summary>
        /// <value>{{{historico_eventos_response_valor_anterior_value}}}</value>
        [DataMember(Name="valorAnterior", EmitDefaultValue=false)]
        public string ValorAnterior { get; set; }
    
        /// <summary>
        /// {{{historico_eventos_response_valor_atribuido_value}}}
        /// </summary>
        /// <value>{{{historico_eventos_response_valor_atribuido_value}}}</value>
        [DataMember(Name="valorAtribuido", EmitDefaultValue=false)]
        public string ValorAtribuido { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricoEventosResponse {\n");
            sb.Append("  IdHistorico: ").Append(IdHistorico).Append("\n");
            sb.Append("  DataHistorico: ").Append(DataHistorico).Append("\n");
            sb.Append("  TipoHistorico: ").Append(TipoHistorico).Append("\n");
            sb.Append("  ValorAnterior: ").Append(ValorAnterior).Append("\n");
            sb.Append("  ValorAtribuido: ").Append(ValorAtribuido).Append("\n");
            
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
            return this.Equals(obj as HistoricoEventosResponse);
        }

        /// <summary>
        /// Returns true if HistoricoEventosResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of HistoricoEventosResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricoEventosResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdHistorico == other.IdHistorico ||
                    this.IdHistorico != null &&
                    this.IdHistorico.Equals(other.IdHistorico)
                ) && 
                (
                    this.DataHistorico == other.DataHistorico ||
                    this.DataHistorico != null &&
                    this.DataHistorico.Equals(other.DataHistorico)
                ) && 
                (
                    this.TipoHistorico == other.TipoHistorico ||
                    this.TipoHistorico != null &&
                    this.TipoHistorico.Equals(other.TipoHistorico)
                ) && 
                (
                    this.ValorAnterior == other.ValorAnterior ||
                    this.ValorAnterior != null &&
                    this.ValorAnterior.Equals(other.ValorAnterior)
                ) && 
                (
                    this.ValorAtribuido == other.ValorAtribuido ||
                    this.ValorAtribuido != null &&
                    this.ValorAtribuido.Equals(other.ValorAtribuido)
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
                
                if (this.IdHistorico != null)
                    hash = hash * 59 + this.IdHistorico.GetHashCode();
                
                if (this.DataHistorico != null)
                    hash = hash * 59 + this.DataHistorico.GetHashCode();
                
                if (this.TipoHistorico != null)
                    hash = hash * 59 + this.TipoHistorico.GetHashCode();
                
                if (this.ValorAnterior != null)
                    hash = hash * 59 + this.ValorAnterior.GetHashCode();
                
                if (this.ValorAtribuido != null)
                    hash = hash * 59 + this.ValorAtribuido.GetHashCode();
                
                return hash;
            }
        }

    }
}
