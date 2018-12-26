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
    /// {{{aviso_viagem_response_description}}}
    /// </summary>
    [DataContract]
    public partial class AvisoViagemResponse :  IEquatable<AvisoViagemResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AvisoViagemResponse" /> class.
        /// Initializes a new instance of the <see cref="AvisoViagemResponse" />class.
        /// </summary>
        /// <param name="Id">{{{aviso_viagem_response_id_value}}}.</param>
        /// <param name="IdCartao">{{{aviso_viagem_response_id_cartao_value}}}.</param>
        /// <param name="CodigoPais">{{{aviso_viagem_response_codigo_pais_value}}}.</param>
        /// <param name="DataInicio">{{{aviso_viagem_response_data_inicio_value}}}.</param>
        /// <param name="DataFim">{{{aviso_viagem_response_data_fim_value}}}.</param>
        /// <param name="FlagAtivo">{{{aviso_viagem_response_flag_ativo_value}}}.</param>

        public AvisoViagemResponse(long? Id = null, long? IdCartao = null, string CodigoPais = null, string DataInicio = null, string DataFim = null, int? FlagAtivo = null)
        {
            this.Id = Id;
            this.IdCartao = IdCartao;
            this.CodigoPais = CodigoPais;
            this.DataInicio = DataInicio;
            this.DataFim = DataFim;
            this.FlagAtivo = FlagAtivo;
            
        }
        
    
        /// <summary>
        /// {{{aviso_viagem_response_id_value}}}
        /// </summary>
        /// <value>{{{aviso_viagem_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{aviso_viagem_response_id_cartao_value}}}
        /// </summary>
        /// <value>{{{aviso_viagem_response_id_cartao_value}}}</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// {{{aviso_viagem_response_codigo_pais_value}}}
        /// </summary>
        /// <value>{{{aviso_viagem_response_codigo_pais_value}}}</value>
        [DataMember(Name="codigoPais", EmitDefaultValue=false)]
        public string CodigoPais { get; set; }
    
        /// <summary>
        /// {{{aviso_viagem_response_data_inicio_value}}}
        /// </summary>
        /// <value>{{{aviso_viagem_response_data_inicio_value}}}</value>
        [DataMember(Name="dataInicio", EmitDefaultValue=false)]
        public string DataInicio { get; set; }
    
        /// <summary>
        /// {{{aviso_viagem_response_data_fim_value}}}
        /// </summary>
        /// <value>{{{aviso_viagem_response_data_fim_value}}}</value>
        [DataMember(Name="dataFim", EmitDefaultValue=false)]
        public string DataFim { get; set; }
    
        /// <summary>
        /// {{{aviso_viagem_response_flag_ativo_value}}}
        /// </summary>
        /// <value>{{{aviso_viagem_response_flag_ativo_value}}}</value>
        [DataMember(Name="flagAtivo", EmitDefaultValue=false)]
        public int? FlagAtivo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvisoViagemResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  CodigoPais: ").Append(CodigoPais).Append("\n");
            sb.Append("  DataInicio: ").Append(DataInicio).Append("\n");
            sb.Append("  DataFim: ").Append(DataFim).Append("\n");
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
            return this.Equals(obj as AvisoViagemResponse);
        }

        /// <summary>
        /// Returns true if AvisoViagemResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AvisoViagemResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvisoViagemResponse other)
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
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.CodigoPais == other.CodigoPais ||
                    this.CodigoPais != null &&
                    this.CodigoPais.Equals(other.CodigoPais)
                ) && 
                (
                    this.DataInicio == other.DataInicio ||
                    this.DataInicio != null &&
                    this.DataInicio.Equals(other.DataInicio)
                ) && 
                (
                    this.DataFim == other.DataFim ||
                    this.DataFim != null &&
                    this.DataFim.Equals(other.DataFim)
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
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.CodigoPais != null)
                    hash = hash * 59 + this.CodigoPais.GetHashCode();
                
                if (this.DataInicio != null)
                    hash = hash * 59 + this.DataInicio.GetHashCode();
                
                if (this.DataFim != null)
                    hash = hash * 59 + this.DataFim.GetHashCode();
                
                if (this.FlagAtivo != null)
                    hash = hash * 59 + this.FlagAtivo.GetHashCode();
                
                return hash;
            }
        }

    }
}
