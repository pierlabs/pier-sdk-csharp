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
    /// 
    /// </summary>
    [DataContract]
    public partial class ConsultaCadastroEstabelecimentoDTO :  IEquatable<ConsultaCadastroEstabelecimentoDTO>
    { 
    
        /// <summary>
        /// Status da consulta (1 - OK, 2 - NOK).
        /// </summary>
        /// <value>Status da consulta (1 - OK, 2 - NOK).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "OK")]
            Ok,
            
            [EnumMember(Value = "NOK")]
            Nok
        }

    
        /// <summary>
        /// Tipo da entidade (1 - ATIVO, 2 - BLOQUEADO).
        /// </summary>
        /// <value>Tipo da entidade (1 - ATIVO, 2 - BLOQUEADO).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TipoEntidadeEnum {
            
            [EnumMember(Value = "ATIVO")]
            Ativo,
            
            [EnumMember(Value = "BLOQUEADO")]
            Bloqueado
        }

    
        /// <summary>
        /// Status da consulta (1 - OK, 2 - NOK).
        /// </summary>
        /// <value>Status da consulta (1 - OK, 2 - NOK).</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Tipo da entidade (1 - ATIVO, 2 - BLOQUEADO).
        /// </summary>
        /// <value>Tipo da entidade (1 - ATIVO, 2 - BLOQUEADO).</value>
        [DataMember(Name="tipoEntidade", EmitDefaultValue=false)]
        public TipoEntidadeEnum? TipoEntidade { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsultaCadastroEstabelecimentoDTO" /> class.
        /// Initializes a new instance of the <see cref="ConsultaCadastroEstabelecimentoDTO" />class.
        /// </summary>
        /// <param name="DataHoraConsulta">Data hora de cadastro..</param>
        /// <param name="Status">Status da consulta (1 - OK, 2 - NOK)..</param>
        /// <param name="TipoEntidade">Tipo da entidade (1 - ATIVO, 2 - BLOQUEADO)..</param>

        public ConsultaCadastroEstabelecimentoDTO(string DataHoraConsulta = null, StatusEnum? Status = null, TipoEntidadeEnum? TipoEntidade = null)
        {
            this.DataHoraConsulta = DataHoraConsulta;
            this.Status = Status;
            this.TipoEntidade = TipoEntidade;
            
        }
        
    
        /// <summary>
        /// Data hora de cadastro.
        /// </summary>
        /// <value>Data hora de cadastro.</value>
        [DataMember(Name="dataHoraConsulta", EmitDefaultValue=false)]
        public string DataHoraConsulta { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsultaCadastroEstabelecimentoDTO {\n");
            sb.Append("  DataHoraConsulta: ").Append(DataHoraConsulta).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TipoEntidade: ").Append(TipoEntidade).Append("\n");
            
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
            return this.Equals(obj as ConsultaCadastroEstabelecimentoDTO);
        }

        /// <summary>
        /// Returns true if ConsultaCadastroEstabelecimentoDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of ConsultaCadastroEstabelecimentoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsultaCadastroEstabelecimentoDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DataHoraConsulta == other.DataHoraConsulta ||
                    this.DataHoraConsulta != null &&
                    this.DataHoraConsulta.Equals(other.DataHoraConsulta)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.TipoEntidade == other.TipoEntidade ||
                    this.TipoEntidade != null &&
                    this.TipoEntidade.Equals(other.TipoEntidade)
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
                
                if (this.DataHoraConsulta != null)
                    hash = hash * 59 + this.DataHoraConsulta.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.TipoEntidade != null)
                    hash = hash * 59 + this.TipoEntidade.GetHashCode();
                
                return hash;
            }
        }

    }
}
