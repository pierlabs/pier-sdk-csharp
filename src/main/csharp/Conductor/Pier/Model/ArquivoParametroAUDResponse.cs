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
    /// {{{arquivo_parametro_a_u_d_response_description}}}
    /// </summary>
    [DataContract]
    public partial class ArquivoParametroAUDResponse :  IEquatable<ArquivoParametroAUDResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ArquivoParametroAUDResponse" /> class.
        /// Initializes a new instance of the <see cref="ArquivoParametroAUDResponse" />class.
        /// </summary>
        /// <param name="Rev">{{{arquivo_parametro_a_u_d_response_rev_value}}}.</param>
        /// <param name="RevType">{{{arquivo_parametro_a_u_d_response_rev_type_value}}}.</param>
        /// <param name="Id">{{{arquivo_parametro_a_u_d_response_id_value}}}.</param>
        /// <param name="Parametro">{{{arquivo_parametro_a_u_d_response_parametro_value}}}.</param>
        /// <param name="Conteudo">{{{arquivo_parametro_a_u_d_response_conteudo_value}}}.</param>
        /// <param name="DataHoraInclusao">{{{arquivo_parametro_a_u_d_response_data_hora_inclusao_value}}}.</param>
        /// <param name="DataHoraAlteracao">{{{arquivo_parametro_a_u_d_response_data_hora_alteracao_value}}}.</param>

        public ArquivoParametroAUDResponse(long? Rev = null, int? RevType = null, string Id = null, string Parametro = null, string Conteudo = null, string DataHoraInclusao = null, string DataHoraAlteracao = null)
        {
            this.Rev = Rev;
            this.RevType = RevType;
            this.Id = Id;
            this.Parametro = Parametro;
            this.Conteudo = Conteudo;
            this.DataHoraInclusao = DataHoraInclusao;
            this.DataHoraAlteracao = DataHoraAlteracao;
            
        }
        
    
        /// <summary>
        /// {{{arquivo_parametro_a_u_d_response_rev_value}}}
        /// </summary>
        /// <value>{{{arquivo_parametro_a_u_d_response_rev_value}}}</value>
        [DataMember(Name="rev", EmitDefaultValue=false)]
        public long? Rev { get; set; }
    
        /// <summary>
        /// {{{arquivo_parametro_a_u_d_response_rev_type_value}}}
        /// </summary>
        /// <value>{{{arquivo_parametro_a_u_d_response_rev_type_value}}}</value>
        [DataMember(Name="revType", EmitDefaultValue=false)]
        public int? RevType { get; set; }
    
        /// <summary>
        /// {{{arquivo_parametro_a_u_d_response_id_value}}}
        /// </summary>
        /// <value>{{{arquivo_parametro_a_u_d_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// {{{arquivo_parametro_a_u_d_response_parametro_value}}}
        /// </summary>
        /// <value>{{{arquivo_parametro_a_u_d_response_parametro_value}}}</value>
        [DataMember(Name="parametro", EmitDefaultValue=false)]
        public string Parametro { get; set; }
    
        /// <summary>
        /// {{{arquivo_parametro_a_u_d_response_conteudo_value}}}
        /// </summary>
        /// <value>{{{arquivo_parametro_a_u_d_response_conteudo_value}}}</value>
        [DataMember(Name="conteudo", EmitDefaultValue=false)]
        public string Conteudo { get; set; }
    
        /// <summary>
        /// {{{arquivo_parametro_a_u_d_response_data_hora_inclusao_value}}}
        /// </summary>
        /// <value>{{{arquivo_parametro_a_u_d_response_data_hora_inclusao_value}}}</value>
        [DataMember(Name="dataHoraInclusao", EmitDefaultValue=false)]
        public string DataHoraInclusao { get; set; }
    
        /// <summary>
        /// {{{arquivo_parametro_a_u_d_response_data_hora_alteracao_value}}}
        /// </summary>
        /// <value>{{{arquivo_parametro_a_u_d_response_data_hora_alteracao_value}}}</value>
        [DataMember(Name="dataHoraAlteracao", EmitDefaultValue=false)]
        public string DataHoraAlteracao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArquivoParametroAUDResponse {\n");
            sb.Append("  Rev: ").Append(Rev).Append("\n");
            sb.Append("  RevType: ").Append(RevType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Parametro: ").Append(Parametro).Append("\n");
            sb.Append("  Conteudo: ").Append(Conteudo).Append("\n");
            sb.Append("  DataHoraInclusao: ").Append(DataHoraInclusao).Append("\n");
            sb.Append("  DataHoraAlteracao: ").Append(DataHoraAlteracao).Append("\n");
            
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
            return this.Equals(obj as ArquivoParametroAUDResponse);
        }

        /// <summary>
        /// Returns true if ArquivoParametroAUDResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ArquivoParametroAUDResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArquivoParametroAUDResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Rev == other.Rev ||
                    this.Rev != null &&
                    this.Rev.Equals(other.Rev)
                ) && 
                (
                    this.RevType == other.RevType ||
                    this.RevType != null &&
                    this.RevType.Equals(other.RevType)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Parametro == other.Parametro ||
                    this.Parametro != null &&
                    this.Parametro.Equals(other.Parametro)
                ) && 
                (
                    this.Conteudo == other.Conteudo ||
                    this.Conteudo != null &&
                    this.Conteudo.Equals(other.Conteudo)
                ) && 
                (
                    this.DataHoraInclusao == other.DataHoraInclusao ||
                    this.DataHoraInclusao != null &&
                    this.DataHoraInclusao.Equals(other.DataHoraInclusao)
                ) && 
                (
                    this.DataHoraAlteracao == other.DataHoraAlteracao ||
                    this.DataHoraAlteracao != null &&
                    this.DataHoraAlteracao.Equals(other.DataHoraAlteracao)
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
                
                if (this.Rev != null)
                    hash = hash * 59 + this.Rev.GetHashCode();
                
                if (this.RevType != null)
                    hash = hash * 59 + this.RevType.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Parametro != null)
                    hash = hash * 59 + this.Parametro.GetHashCode();
                
                if (this.Conteudo != null)
                    hash = hash * 59 + this.Conteudo.GetHashCode();
                
                if (this.DataHoraInclusao != null)
                    hash = hash * 59 + this.DataHoraInclusao.GetHashCode();
                
                if (this.DataHoraAlteracao != null)
                    hash = hash * 59 + this.DataHoraAlteracao.GetHashCode();
                
                return hash;
            }
        }

    }
}
