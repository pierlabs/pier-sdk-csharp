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
    /// Objeto de requisi\u00E7\u00E3o do agendamento 
    /// </summary>
    [DataContract]
    public partial class AgendamentoPersist :  IEquatable<AgendamentoPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AgendamentoPersist" /> class.
        /// Initializes a new instance of the <see cref="AgendamentoPersist" />class.
        /// </summary>
        /// <param name="TipoOperacao">Tipo opera\u00E7\u00E3o .</param>
        /// <param name="TipoRecorrencia">Tipo Recorr\u00EAncia.</param>
        /// <param name="QuantidadeAgendamento">Quantidade agendamento .</param>
        /// <param name="DiaRecorrencia">Dia recorr\u00EAncia.</param>
        /// <param name="Valor">Valor Agendamento.</param>
        /// <param name="Sort">Tipo de ordena\u00E7\u00E3o dos registros.</param>

        public AgendamentoPersist(int? TipoOperacao = null, int? TipoRecorrencia = null, int? QuantidadeAgendamento = null, int? DiaRecorrencia = null, double? Valor = null, List<string> Sort = null)
        {
            this.TipoOperacao = TipoOperacao;
            this.TipoRecorrencia = TipoRecorrencia;
            this.QuantidadeAgendamento = QuantidadeAgendamento;
            this.DiaRecorrencia = DiaRecorrencia;
            this.Valor = Valor;
            this.Sort = Sort;
            
        }
        
    
        /// <summary>
        /// Tipo opera\u00E7\u00E3o 
        /// </summary>
        /// <value>Tipo opera\u00E7\u00E3o </value>
        [DataMember(Name="tipoOperacao", EmitDefaultValue=false)]
        public int? TipoOperacao { get; set; }
    
        /// <summary>
        /// Tipo Recorr\u00EAncia
        /// </summary>
        /// <value>Tipo Recorr\u00EAncia</value>
        [DataMember(Name="tipoRecorrencia", EmitDefaultValue=false)]
        public int? TipoRecorrencia { get; set; }
    
        /// <summary>
        /// Quantidade agendamento 
        /// </summary>
        /// <value>Quantidade agendamento </value>
        [DataMember(Name="quantidadeAgendamento", EmitDefaultValue=false)]
        public int? QuantidadeAgendamento { get; set; }
    
        /// <summary>
        /// Dia recorr\u00EAncia
        /// </summary>
        /// <value>Dia recorr\u00EAncia</value>
        [DataMember(Name="diaRecorrencia", EmitDefaultValue=false)]
        public int? DiaRecorrencia { get; set; }
    
        /// <summary>
        /// Valor Agendamento
        /// </summary>
        /// <value>Valor Agendamento</value>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }
    
        /// <summary>
        /// Tipo de ordena\u00E7\u00E3o dos registros
        /// </summary>
        /// <value>Tipo de ordena\u00E7\u00E3o dos registros</value>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public List<string> Sort { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgendamentoPersist {\n");
            sb.Append("  TipoOperacao: ").Append(TipoOperacao).Append("\n");
            sb.Append("  TipoRecorrencia: ").Append(TipoRecorrencia).Append("\n");
            sb.Append("  QuantidadeAgendamento: ").Append(QuantidadeAgendamento).Append("\n");
            sb.Append("  DiaRecorrencia: ").Append(DiaRecorrencia).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            
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
            return this.Equals(obj as AgendamentoPersist);
        }

        /// <summary>
        /// Returns true if AgendamentoPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of AgendamentoPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgendamentoPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TipoOperacao == other.TipoOperacao ||
                    this.TipoOperacao != null &&
                    this.TipoOperacao.Equals(other.TipoOperacao)
                ) && 
                (
                    this.TipoRecorrencia == other.TipoRecorrencia ||
                    this.TipoRecorrencia != null &&
                    this.TipoRecorrencia.Equals(other.TipoRecorrencia)
                ) && 
                (
                    this.QuantidadeAgendamento == other.QuantidadeAgendamento ||
                    this.QuantidadeAgendamento != null &&
                    this.QuantidadeAgendamento.Equals(other.QuantidadeAgendamento)
                ) && 
                (
                    this.DiaRecorrencia == other.DiaRecorrencia ||
                    this.DiaRecorrencia != null &&
                    this.DiaRecorrencia.Equals(other.DiaRecorrencia)
                ) && 
                (
                    this.Valor == other.Valor ||
                    this.Valor != null &&
                    this.Valor.Equals(other.Valor)
                ) && 
                (
                    this.Sort == other.Sort ||
                    this.Sort != null &&
                    this.Sort.SequenceEqual(other.Sort)
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
                
                if (this.TipoOperacao != null)
                    hash = hash * 59 + this.TipoOperacao.GetHashCode();
                
                if (this.TipoRecorrencia != null)
                    hash = hash * 59 + this.TipoRecorrencia.GetHashCode();
                
                if (this.QuantidadeAgendamento != null)
                    hash = hash * 59 + this.QuantidadeAgendamento.GetHashCode();
                
                if (this.DiaRecorrencia != null)
                    hash = hash * 59 + this.DiaRecorrencia.GetHashCode();
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
                if (this.Sort != null)
                    hash = hash * 59 + this.Sort.GetHashCode();
                
                return hash;
            }
        }

    }
}
