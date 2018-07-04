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
    /// {{{arquivo_ajuste_lote_response_description}}}
    /// </summary>
    [DataContract]
    public partial class ArquivoAjusteLoteResponse :  IEquatable<ArquivoAjusteLoteResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ArquivoAjusteLoteResponse" /> class.
        /// Initializes a new instance of the <see cref="ArquivoAjusteLoteResponse" />class.
        /// </summary>
        /// <param name="DataProcessamento">DataProcessamento.</param>
        /// <param name="Id">{{{arquivo_ajuste_lote_response_id_value}}}.</param>
        /// <param name="Length">{{{arquivo_ajuste_lote_response_length_value}}}.</param>
        /// <param name="Lines">{{{arquivo_ajuste_lote_response_lines_value}}}.</param>
        /// <param name="Name">{{{arquivo_ajuste_lote_response_name_value}}}.</param>
        /// <param name="Status">{{{arquivo_ajuste_lote_response_status_value}}}.</param>
        /// <param name="SrcName">{{{arquivo_ajuste_lote_response_srcName_value}}}.</param>

        public ArquivoAjusteLoteResponse(DateTime? DataProcessamento = null, long? Id = null, int? Length = null, int? Lines = null, string Name = null, string Status = null, string SrcName = null)
        {
            this.DataProcessamento = DataProcessamento;
            this.Id = Id;
            this.Length = Length;
            this.Lines = Lines;
            this.Name = Name;
            this.Status = Status;
            this.SrcName = SrcName;
            
        }
        
    
        /// <summary>
        /// Gets or Sets DataProcessamento
        /// </summary>
        [DataMember(Name="dataProcessamento", EmitDefaultValue=false)]
        public DateTime? DataProcessamento { get; set; }
    
        /// <summary>
        /// {{{arquivo_ajuste_lote_response_id_value}}}
        /// </summary>
        /// <value>{{{arquivo_ajuste_lote_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{arquivo_ajuste_lote_response_length_value}}}
        /// </summary>
        /// <value>{{{arquivo_ajuste_lote_response_length_value}}}</value>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public int? Length { get; set; }
    
        /// <summary>
        /// {{{arquivo_ajuste_lote_response_lines_value}}}
        /// </summary>
        /// <value>{{{arquivo_ajuste_lote_response_lines_value}}}</value>
        [DataMember(Name="lines", EmitDefaultValue=false)]
        public int? Lines { get; set; }
    
        /// <summary>
        /// {{{arquivo_ajuste_lote_response_name_value}}}
        /// </summary>
        /// <value>{{{arquivo_ajuste_lote_response_name_value}}}</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// {{{arquivo_ajuste_lote_response_status_value}}}
        /// </summary>
        /// <value>{{{arquivo_ajuste_lote_response_status_value}}}</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// {{{arquivo_ajuste_lote_response_srcName_value}}}
        /// </summary>
        /// <value>{{{arquivo_ajuste_lote_response_srcName_value}}}</value>
        [DataMember(Name="srcName", EmitDefaultValue=false)]
        public string SrcName { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArquivoAjusteLoteResponse {\n");
            sb.Append("  DataProcessamento: ").Append(DataProcessamento).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SrcName: ").Append(SrcName).Append("\n");
            
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
            return this.Equals(obj as ArquivoAjusteLoteResponse);
        }

        /// <summary>
        /// Returns true if ArquivoAjusteLoteResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ArquivoAjusteLoteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArquivoAjusteLoteResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DataProcessamento == other.DataProcessamento ||
                    this.DataProcessamento != null &&
                    this.DataProcessamento.Equals(other.DataProcessamento)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Length == other.Length ||
                    this.Length != null &&
                    this.Length.Equals(other.Length)
                ) && 
                (
                    this.Lines == other.Lines ||
                    this.Lines != null &&
                    this.Lines.Equals(other.Lines)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.SrcName == other.SrcName ||
                    this.SrcName != null &&
                    this.SrcName.Equals(other.SrcName)
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
                
                if (this.DataProcessamento != null)
                    hash = hash * 59 + this.DataProcessamento.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Length != null)
                    hash = hash * 59 + this.Length.GetHashCode();
                
                if (this.Lines != null)
                    hash = hash * 59 + this.Lines.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.SrcName != null)
                    hash = hash * 59 + this.SrcName.GetHashCode();
                
                return hash;
            }
        }

    }
}
