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
    /// Objeto de resposta que apresenta as informa\u00E7\u00F5es configuradas em um parcelamento personalizado
    /// </summary>
    [DataContract]
    public partial class PersonalizacaoParcelamentoResponse :  IEquatable<PersonalizacaoParcelamentoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalizacaoParcelamentoResponse" /> class.
        /// Initializes a new instance of the <see cref="PersonalizacaoParcelamentoResponse" />class.
        /// </summary>
        /// <param name="Id">Identificador da configura\u00E7\u00E3o de parcelamento personalizado.</param>
        /// <param name="IdRegraCampanha">Identificador da campanha.</param>
        /// <param name="IdRegraCampanhaRotativo">Identificador da campanha de rotativo.</param>
        /// <param name="FlagAntecipaContratosAbertos">Flag que identifica a ativa\u00E7\u00E3o da antecipa\u00E7\u00E3o de contratos abertos.</param>
        /// <param name="FlagAntecipaParcRotativo">Flag que identifica a ativa\u00E7\u00E3o da antecipa\u00E7\u00E3o de parcelamento rotativo.</param>
        /// <param name="IdOperacao">Identificador da opera\u00E7\u00E3o.</param>
        /// <param name="IdOperacaoRotativo">Identificador da opera\u00E7\u00E3o de rotativo.</param>

        public PersonalizacaoParcelamentoResponse(long? Id = null, long? IdRegraCampanha = null, long? IdRegraCampanhaRotativo = null, bool? FlagAntecipaContratosAbertos = null, bool? FlagAntecipaParcRotativo = null, long? IdOperacao = null, long? IdOperacaoRotativo = null)
        {
            this.Id = Id;
            this.IdRegraCampanha = IdRegraCampanha;
            this.IdRegraCampanhaRotativo = IdRegraCampanhaRotativo;
            this.FlagAntecipaContratosAbertos = FlagAntecipaContratosAbertos;
            this.FlagAntecipaParcRotativo = FlagAntecipaParcRotativo;
            this.IdOperacao = IdOperacao;
            this.IdOperacaoRotativo = IdOperacaoRotativo;
            
        }
        
    
        /// <summary>
        /// Identificador da configura\u00E7\u00E3o de parcelamento personalizado
        /// </summary>
        /// <value>Identificador da configura\u00E7\u00E3o de parcelamento personalizado</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Identificador da campanha
        /// </summary>
        /// <value>Identificador da campanha</value>
        [DataMember(Name="idRegraCampanha", EmitDefaultValue=false)]
        public long? IdRegraCampanha { get; set; }
    
        /// <summary>
        /// Identificador da campanha de rotativo
        /// </summary>
        /// <value>Identificador da campanha de rotativo</value>
        [DataMember(Name="idRegraCampanhaRotativo", EmitDefaultValue=false)]
        public long? IdRegraCampanhaRotativo { get; set; }
    
        /// <summary>
        /// Flag que identifica a ativa\u00E7\u00E3o da antecipa\u00E7\u00E3o de contratos abertos
        /// </summary>
        /// <value>Flag que identifica a ativa\u00E7\u00E3o da antecipa\u00E7\u00E3o de contratos abertos</value>
        [DataMember(Name="flagAntecipaContratosAbertos", EmitDefaultValue=false)]
        public bool? FlagAntecipaContratosAbertos { get; set; }
    
        /// <summary>
        /// Flag que identifica a ativa\u00E7\u00E3o da antecipa\u00E7\u00E3o de parcelamento rotativo
        /// </summary>
        /// <value>Flag que identifica a ativa\u00E7\u00E3o da antecipa\u00E7\u00E3o de parcelamento rotativo</value>
        [DataMember(Name="flagAntecipaParcRotativo", EmitDefaultValue=false)]
        public bool? FlagAntecipaParcRotativo { get; set; }
    
        /// <summary>
        /// Identificador da opera\u00E7\u00E3o
        /// </summary>
        /// <value>Identificador da opera\u00E7\u00E3o</value>
        [DataMember(Name="idOperacao", EmitDefaultValue=false)]
        public long? IdOperacao { get; set; }
    
        /// <summary>
        /// Identificador da opera\u00E7\u00E3o de rotativo
        /// </summary>
        /// <value>Identificador da opera\u00E7\u00E3o de rotativo</value>
        [DataMember(Name="idOperacaoRotativo", EmitDefaultValue=false)]
        public long? IdOperacaoRotativo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersonalizacaoParcelamentoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdRegraCampanha: ").Append(IdRegraCampanha).Append("\n");
            sb.Append("  IdRegraCampanhaRotativo: ").Append(IdRegraCampanhaRotativo).Append("\n");
            sb.Append("  FlagAntecipaContratosAbertos: ").Append(FlagAntecipaContratosAbertos).Append("\n");
            sb.Append("  FlagAntecipaParcRotativo: ").Append(FlagAntecipaParcRotativo).Append("\n");
            sb.Append("  IdOperacao: ").Append(IdOperacao).Append("\n");
            sb.Append("  IdOperacaoRotativo: ").Append(IdOperacaoRotativo).Append("\n");
            
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
            return this.Equals(obj as PersonalizacaoParcelamentoResponse);
        }

        /// <summary>
        /// Returns true if PersonalizacaoParcelamentoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PersonalizacaoParcelamentoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PersonalizacaoParcelamentoResponse other)
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
                    this.IdRegraCampanha == other.IdRegraCampanha ||
                    this.IdRegraCampanha != null &&
                    this.IdRegraCampanha.Equals(other.IdRegraCampanha)
                ) && 
                (
                    this.IdRegraCampanhaRotativo == other.IdRegraCampanhaRotativo ||
                    this.IdRegraCampanhaRotativo != null &&
                    this.IdRegraCampanhaRotativo.Equals(other.IdRegraCampanhaRotativo)
                ) && 
                (
                    this.FlagAntecipaContratosAbertos == other.FlagAntecipaContratosAbertos ||
                    this.FlagAntecipaContratosAbertos != null &&
                    this.FlagAntecipaContratosAbertos.Equals(other.FlagAntecipaContratosAbertos)
                ) && 
                (
                    this.FlagAntecipaParcRotativo == other.FlagAntecipaParcRotativo ||
                    this.FlagAntecipaParcRotativo != null &&
                    this.FlagAntecipaParcRotativo.Equals(other.FlagAntecipaParcRotativo)
                ) && 
                (
                    this.IdOperacao == other.IdOperacao ||
                    this.IdOperacao != null &&
                    this.IdOperacao.Equals(other.IdOperacao)
                ) && 
                (
                    this.IdOperacaoRotativo == other.IdOperacaoRotativo ||
                    this.IdOperacaoRotativo != null &&
                    this.IdOperacaoRotativo.Equals(other.IdOperacaoRotativo)
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
                
                if (this.IdRegraCampanha != null)
                    hash = hash * 59 + this.IdRegraCampanha.GetHashCode();
                
                if (this.IdRegraCampanhaRotativo != null)
                    hash = hash * 59 + this.IdRegraCampanhaRotativo.GetHashCode();
                
                if (this.FlagAntecipaContratosAbertos != null)
                    hash = hash * 59 + this.FlagAntecipaContratosAbertos.GetHashCode();
                
                if (this.FlagAntecipaParcRotativo != null)
                    hash = hash * 59 + this.FlagAntecipaParcRotativo.GetHashCode();
                
                if (this.IdOperacao != null)
                    hash = hash * 59 + this.IdOperacao.GetHashCode();
                
                if (this.IdOperacaoRotativo != null)
                    hash = hash * 59 + this.IdOperacaoRotativo.GetHashCode();
                
                return hash;
            }
        }

    }
}
