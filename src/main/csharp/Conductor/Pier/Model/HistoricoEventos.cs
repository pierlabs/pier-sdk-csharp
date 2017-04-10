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
    /// Representa\u00C3\u00A7\u00C3\u00A3o do objeto que abstrai o hist\u00C3\u00B3rico de eventos
    /// </summary>
    [DataContract]
    public partial class HistoricoEventos :  IEquatable<HistoricoEventos>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricoEventos" /> class.
        /// Initializes a new instance of the <see cref="HistoricoEventos" />class.
        /// </summary>
        /// <param name="IdHistorico">C\u00C3\u00B3digo identificador do evento (required).</param>
        /// <param name="DataHistorico">Data do evento (required).</param>
        /// <param name="TipoHistorico">Nome do campo alterado (required).</param>
        /// <param name="ValorAnterior">Valor anterior a modifica\u00C3\u00A7\u00C3\u00A3o.</param>
        /// <param name="ValorAtribuido">Valor atribu\u00C3\u00ADdo na modifica\u00C3\u00A7\u00C3\u00A3o (required).</param>

        public HistoricoEventos(long? IdHistorico = null, DateTime? DataHistorico = null, string TipoHistorico = null, string ValorAnterior = null, string ValorAtribuido = null)
        {
            // to ensure "IdHistorico" is required (not null)
            if (IdHistorico == null)
            {
                throw new InvalidDataException("IdHistorico is a required property for HistoricoEventos and cannot be null");
            }
            else
            {
                this.IdHistorico = IdHistorico;
            }
            // to ensure "DataHistorico" is required (not null)
            if (DataHistorico == null)
            {
                throw new InvalidDataException("DataHistorico is a required property for HistoricoEventos and cannot be null");
            }
            else
            {
                this.DataHistorico = DataHistorico;
            }
            // to ensure "TipoHistorico" is required (not null)
            if (TipoHistorico == null)
            {
                throw new InvalidDataException("TipoHistorico is a required property for HistoricoEventos and cannot be null");
            }
            else
            {
                this.TipoHistorico = TipoHistorico;
            }
            // to ensure "ValorAtribuido" is required (not null)
            if (ValorAtribuido == null)
            {
                throw new InvalidDataException("ValorAtribuido is a required property for HistoricoEventos and cannot be null");
            }
            else
            {
                this.ValorAtribuido = ValorAtribuido;
            }
            this.ValorAnterior = ValorAnterior;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador do evento
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador do evento</value>
        [DataMember(Name="idHistorico", EmitDefaultValue=false)]
        public long? IdHistorico { get; set; }
    
        /// <summary>
        /// Data do evento
        /// </summary>
        /// <value>Data do evento</value>
        [DataMember(Name="dataHistorico", EmitDefaultValue=false)]
        public DateTime? DataHistorico { get; set; }
    
        /// <summary>
        /// Nome do campo alterado
        /// </summary>
        /// <value>Nome do campo alterado</value>
        [DataMember(Name="tipoHistorico", EmitDefaultValue=false)]
        public string TipoHistorico { get; set; }
    
        /// <summary>
        /// Valor anterior a modifica\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <value>Valor anterior a modifica\u00C3\u00A7\u00C3\u00A3o</value>
        [DataMember(Name="valorAnterior", EmitDefaultValue=false)]
        public string ValorAnterior { get; set; }
    
        /// <summary>
        /// Valor atribu\u00C3\u00ADdo na modifica\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <value>Valor atribu\u00C3\u00ADdo na modifica\u00C3\u00A7\u00C3\u00A3o</value>
        [DataMember(Name="valorAtribuido", EmitDefaultValue=false)]
        public string ValorAtribuido { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricoEventos {\n");
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
            return this.Equals(obj as HistoricoEventos);
        }

        /// <summary>
        /// Returns true if HistoricoEventos instances are equal
        /// </summary>
        /// <param name="other">Instance of HistoricoEventos to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricoEventos other)
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
