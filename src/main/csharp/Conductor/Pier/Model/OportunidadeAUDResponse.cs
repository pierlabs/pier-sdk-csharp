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
    /// {{{oportunidade_a_u_d_response_description}}}
    /// </summary>
    [DataContract]
    public partial class OportunidadeAUDResponse :  IEquatable<OportunidadeAUDResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OportunidadeAUDResponse" /> class.
        /// Initializes a new instance of the <see cref="OportunidadeAUDResponse" />class.
        /// </summary>
        /// <param name="Id">{{{oportunidade_a_u_d_response_id_value}}}.</param>
        /// <param name="IdTipoOportunidade">{{{oportunidade_a_u_d_response_id_tipo_oportunidade_value}}}.</param>
        /// <param name="IdStatusOportunidade">{{{oportunidade_a_u_d_response_id_status_oportunidade_value}}}.</param>
        /// <param name="DataCadastro">{{{oportunidade_a_u_d_response_data_cadastro_value}}}.</param>
        /// <param name="DataAtualizacao">{{{oportunidade_a_u_d_response_data_atualizacao_value}}}.</param>
        /// <param name="NumeroReceitaFederal">{{{oportunidade_a_u_d_response_numero_receita_federal_value}}}.</param>
        /// <param name="DataInicioVigencia">{{{oportunidade_a_u_d_response_data_inicio_vigencia_value}}}.</param>
        /// <param name="DataFimVigencia">{{{oportunidade_a_u_d_response_data_fim_vigencia_value}}}.</param>
        /// <param name="FlagAtivo">{{{oportunidade_a_u_d_response_flag_ativo_value}}}.</param>
        /// <param name="Detalhes">{{{oportunidade_a_u_d_response_detalhes_value}}}.</param>
        /// <param name="RevDate">{{{oportunidade_a_u_d_response_rev_date_value}}}.</param>
        /// <param name="RevType">{{{oportunidade_a_u_d_response_rev_type_value}}}.</param>
        /// <param name="Rev">{{{oportunidade_a_u_d_response_rev_value}}}.</param>

        public OportunidadeAUDResponse(long? Id = null, long? IdTipoOportunidade = null, long? IdStatusOportunidade = null, string DataCadastro = null, string DataAtualizacao = null, string NumeroReceitaFederal = null, string DataInicioVigencia = null, string DataFimVigencia = null, bool? FlagAtivo = null, List<CdtDetalheOportunidadeAUD> Detalhes = null, string RevDate = null, long? RevType = null, long? Rev = null)
        {
            this.Id = Id;
            this.IdTipoOportunidade = IdTipoOportunidade;
            this.IdStatusOportunidade = IdStatusOportunidade;
            this.DataCadastro = DataCadastro;
            this.DataAtualizacao = DataAtualizacao;
            this.NumeroReceitaFederal = NumeroReceitaFederal;
            this.DataInicioVigencia = DataInicioVigencia;
            this.DataFimVigencia = DataFimVigencia;
            this.FlagAtivo = FlagAtivo;
            this.Detalhes = Detalhes;
            this.RevDate = RevDate;
            this.RevType = RevType;
            this.Rev = Rev;
            
        }
        
    
        /// <summary>
        /// {{{oportunidade_a_u_d_response_id_value}}}
        /// </summary>
        /// <value>{{{oportunidade_a_u_d_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{oportunidade_a_u_d_response_id_tipo_oportunidade_value}}}
        /// </summary>
        /// <value>{{{oportunidade_a_u_d_response_id_tipo_oportunidade_value}}}</value>
        [DataMember(Name="idTipoOportunidade", EmitDefaultValue=false)]
        public long? IdTipoOportunidade { get; set; }
    
        /// <summary>
        /// {{{oportunidade_a_u_d_response_id_status_oportunidade_value}}}
        /// </summary>
        /// <value>{{{oportunidade_a_u_d_response_id_status_oportunidade_value}}}</value>
        [DataMember(Name="idStatusOportunidade", EmitDefaultValue=false)]
        public long? IdStatusOportunidade { get; set; }
    
        /// <summary>
        /// {{{oportunidade_a_u_d_response_data_cadastro_value}}}
        /// </summary>
        /// <value>{{{oportunidade_a_u_d_response_data_cadastro_value}}}</value>
        [DataMember(Name="dataCadastro", EmitDefaultValue=false)]
        public string DataCadastro { get; set; }
    
        /// <summary>
        /// {{{oportunidade_a_u_d_response_data_atualizacao_value}}}
        /// </summary>
        /// <value>{{{oportunidade_a_u_d_response_data_atualizacao_value}}}</value>
        [DataMember(Name="dataAtualizacao", EmitDefaultValue=false)]
        public string DataAtualizacao { get; set; }
    
        /// <summary>
        /// {{{oportunidade_a_u_d_response_numero_receita_federal_value}}}
        /// </summary>
        /// <value>{{{oportunidade_a_u_d_response_numero_receita_federal_value}}}</value>
        [DataMember(Name="numeroReceitaFederal", EmitDefaultValue=false)]
        public string NumeroReceitaFederal { get; set; }
    
        /// <summary>
        /// {{{oportunidade_a_u_d_response_data_inicio_vigencia_value}}}
        /// </summary>
        /// <value>{{{oportunidade_a_u_d_response_data_inicio_vigencia_value}}}</value>
        [DataMember(Name="dataInicioVigencia", EmitDefaultValue=false)]
        public string DataInicioVigencia { get; set; }
    
        /// <summary>
        /// {{{oportunidade_a_u_d_response_data_fim_vigencia_value}}}
        /// </summary>
        /// <value>{{{oportunidade_a_u_d_response_data_fim_vigencia_value}}}</value>
        [DataMember(Name="dataFimVigencia", EmitDefaultValue=false)]
        public string DataFimVigencia { get; set; }
    
        /// <summary>
        /// {{{oportunidade_a_u_d_response_flag_ativo_value}}}
        /// </summary>
        /// <value>{{{oportunidade_a_u_d_response_flag_ativo_value}}}</value>
        [DataMember(Name="flagAtivo", EmitDefaultValue=false)]
        public bool? FlagAtivo { get; set; }
    
        /// <summary>
        /// {{{oportunidade_a_u_d_response_detalhes_value}}}
        /// </summary>
        /// <value>{{{oportunidade_a_u_d_response_detalhes_value}}}</value>
        [DataMember(Name="detalhes", EmitDefaultValue=false)]
        public List<CdtDetalheOportunidadeAUD> Detalhes { get; set; }
    
        /// <summary>
        /// {{{oportunidade_a_u_d_response_rev_date_value}}}
        /// </summary>
        /// <value>{{{oportunidade_a_u_d_response_rev_date_value}}}</value>
        [DataMember(Name="revDate", EmitDefaultValue=false)]
        public string RevDate { get; set; }
    
        /// <summary>
        /// {{{oportunidade_a_u_d_response_rev_type_value}}}
        /// </summary>
        /// <value>{{{oportunidade_a_u_d_response_rev_type_value}}}</value>
        [DataMember(Name="revType", EmitDefaultValue=false)]
        public long? RevType { get; set; }
    
        /// <summary>
        /// {{{oportunidade_a_u_d_response_rev_value}}}
        /// </summary>
        /// <value>{{{oportunidade_a_u_d_response_rev_value}}}</value>
        [DataMember(Name="rev", EmitDefaultValue=false)]
        public long? Rev { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OportunidadeAUDResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdTipoOportunidade: ").Append(IdTipoOportunidade).Append("\n");
            sb.Append("  IdStatusOportunidade: ").Append(IdStatusOportunidade).Append("\n");
            sb.Append("  DataCadastro: ").Append(DataCadastro).Append("\n");
            sb.Append("  DataAtualizacao: ").Append(DataAtualizacao).Append("\n");
            sb.Append("  NumeroReceitaFederal: ").Append(NumeroReceitaFederal).Append("\n");
            sb.Append("  DataInicioVigencia: ").Append(DataInicioVigencia).Append("\n");
            sb.Append("  DataFimVigencia: ").Append(DataFimVigencia).Append("\n");
            sb.Append("  FlagAtivo: ").Append(FlagAtivo).Append("\n");
            sb.Append("  Detalhes: ").Append(Detalhes).Append("\n");
            sb.Append("  RevDate: ").Append(RevDate).Append("\n");
            sb.Append("  RevType: ").Append(RevType).Append("\n");
            sb.Append("  Rev: ").Append(Rev).Append("\n");
            
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
            return this.Equals(obj as OportunidadeAUDResponse);
        }

        /// <summary>
        /// Returns true if OportunidadeAUDResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of OportunidadeAUDResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OportunidadeAUDResponse other)
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
                    this.IdTipoOportunidade == other.IdTipoOportunidade ||
                    this.IdTipoOportunidade != null &&
                    this.IdTipoOportunidade.Equals(other.IdTipoOportunidade)
                ) && 
                (
                    this.IdStatusOportunidade == other.IdStatusOportunidade ||
                    this.IdStatusOportunidade != null &&
                    this.IdStatusOportunidade.Equals(other.IdStatusOportunidade)
                ) && 
                (
                    this.DataCadastro == other.DataCadastro ||
                    this.DataCadastro != null &&
                    this.DataCadastro.Equals(other.DataCadastro)
                ) && 
                (
                    this.DataAtualizacao == other.DataAtualizacao ||
                    this.DataAtualizacao != null &&
                    this.DataAtualizacao.Equals(other.DataAtualizacao)
                ) && 
                (
                    this.NumeroReceitaFederal == other.NumeroReceitaFederal ||
                    this.NumeroReceitaFederal != null &&
                    this.NumeroReceitaFederal.Equals(other.NumeroReceitaFederal)
                ) && 
                (
                    this.DataInicioVigencia == other.DataInicioVigencia ||
                    this.DataInicioVigencia != null &&
                    this.DataInicioVigencia.Equals(other.DataInicioVigencia)
                ) && 
                (
                    this.DataFimVigencia == other.DataFimVigencia ||
                    this.DataFimVigencia != null &&
                    this.DataFimVigencia.Equals(other.DataFimVigencia)
                ) && 
                (
                    this.FlagAtivo == other.FlagAtivo ||
                    this.FlagAtivo != null &&
                    this.FlagAtivo.Equals(other.FlagAtivo)
                ) && 
                (
                    this.Detalhes == other.Detalhes ||
                    this.Detalhes != null &&
                    this.Detalhes.SequenceEqual(other.Detalhes)
                ) && 
                (
                    this.RevDate == other.RevDate ||
                    this.RevDate != null &&
                    this.RevDate.Equals(other.RevDate)
                ) && 
                (
                    this.RevType == other.RevType ||
                    this.RevType != null &&
                    this.RevType.Equals(other.RevType)
                ) && 
                (
                    this.Rev == other.Rev ||
                    this.Rev != null &&
                    this.Rev.Equals(other.Rev)
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
                
                if (this.IdTipoOportunidade != null)
                    hash = hash * 59 + this.IdTipoOportunidade.GetHashCode();
                
                if (this.IdStatusOportunidade != null)
                    hash = hash * 59 + this.IdStatusOportunidade.GetHashCode();
                
                if (this.DataCadastro != null)
                    hash = hash * 59 + this.DataCadastro.GetHashCode();
                
                if (this.DataAtualizacao != null)
                    hash = hash * 59 + this.DataAtualizacao.GetHashCode();
                
                if (this.NumeroReceitaFederal != null)
                    hash = hash * 59 + this.NumeroReceitaFederal.GetHashCode();
                
                if (this.DataInicioVigencia != null)
                    hash = hash * 59 + this.DataInicioVigencia.GetHashCode();
                
                if (this.DataFimVigencia != null)
                    hash = hash * 59 + this.DataFimVigencia.GetHashCode();
                
                if (this.FlagAtivo != null)
                    hash = hash * 59 + this.FlagAtivo.GetHashCode();
                
                if (this.Detalhes != null)
                    hash = hash * 59 + this.Detalhes.GetHashCode();
                
                if (this.RevDate != null)
                    hash = hash * 59 + this.RevDate.GetHashCode();
                
                if (this.RevType != null)
                    hash = hash * 59 + this.RevType.GetHashCode();
                
                if (this.Rev != null)
                    hash = hash * 59 + this.Rev.GetHashCode();
                
                return hash;
            }
        }

    }
}
