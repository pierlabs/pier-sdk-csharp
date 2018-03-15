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
    /// Representa\u00E7\u00E3o da resposta do {@link HistoricoAssessoriaResponse}
    /// </summary>
    [DataContract]
    public partial class HistoricoAssessoriaResponse :  IEquatable<HistoricoAssessoriaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricoAssessoriaResponse" /> class.
        /// Initializes a new instance of the <see cref="HistoricoAssessoriaResponse" />class.
        /// </summary>
        /// <param name="DataHoraHistorico">Apresenta a data e hora do hist\u00F3rico.</param>
        /// <param name="TipoHistorico">Apresenta o tipo do hist\u00F3rico podendo ser ENTRADA ou SAIDA.</param>
        /// <param name="NomeAssessoria">Apresenta o nome da Assessoria de Cobran\u00E7a relacionada ao hist\u00F3rico.</param>

        public HistoricoAssessoriaResponse(string DataHoraHistorico = null, string TipoHistorico = null, string NomeAssessoria = null)
        {
            this.DataHoraHistorico = DataHoraHistorico;
            this.TipoHistorico = TipoHistorico;
            this.NomeAssessoria = NomeAssessoria;
            
        }
        
    
        /// <summary>
        /// Apresenta a data e hora do hist\u00F3rico
        /// </summary>
        /// <value>Apresenta a data e hora do hist\u00F3rico</value>
        [DataMember(Name="dataHoraHistorico", EmitDefaultValue=false)]
        public string DataHoraHistorico { get; set; }
    
        /// <summary>
        /// Apresenta o tipo do hist\u00F3rico podendo ser ENTRADA ou SAIDA
        /// </summary>
        /// <value>Apresenta o tipo do hist\u00F3rico podendo ser ENTRADA ou SAIDA</value>
        [DataMember(Name="tipoHistorico", EmitDefaultValue=false)]
        public string TipoHistorico { get; set; }
    
        /// <summary>
        /// Apresenta o nome da Assessoria de Cobran\u00E7a relacionada ao hist\u00F3rico
        /// </summary>
        /// <value>Apresenta o nome da Assessoria de Cobran\u00E7a relacionada ao hist\u00F3rico</value>
        [DataMember(Name="nomeAssessoria", EmitDefaultValue=false)]
        public string NomeAssessoria { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricoAssessoriaResponse {\n");
            sb.Append("  DataHoraHistorico: ").Append(DataHoraHistorico).Append("\n");
            sb.Append("  TipoHistorico: ").Append(TipoHistorico).Append("\n");
            sb.Append("  NomeAssessoria: ").Append(NomeAssessoria).Append("\n");
            
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
            return this.Equals(obj as HistoricoAssessoriaResponse);
        }

        /// <summary>
        /// Returns true if HistoricoAssessoriaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of HistoricoAssessoriaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricoAssessoriaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DataHoraHistorico == other.DataHoraHistorico ||
                    this.DataHoraHistorico != null &&
                    this.DataHoraHistorico.Equals(other.DataHoraHistorico)
                ) && 
                (
                    this.TipoHistorico == other.TipoHistorico ||
                    this.TipoHistorico != null &&
                    this.TipoHistorico.Equals(other.TipoHistorico)
                ) && 
                (
                    this.NomeAssessoria == other.NomeAssessoria ||
                    this.NomeAssessoria != null &&
                    this.NomeAssessoria.Equals(other.NomeAssessoria)
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
                
                if (this.DataHoraHistorico != null)
                    hash = hash * 59 + this.DataHoraHistorico.GetHashCode();
                
                if (this.TipoHistorico != null)
                    hash = hash * 59 + this.TipoHistorico.GetHashCode();
                
                if (this.NomeAssessoria != null)
                    hash = hash * 59 + this.NomeAssessoria.GetHashCode();
                
                return hash;
            }
        }

    }
}
