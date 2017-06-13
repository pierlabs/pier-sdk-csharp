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
    /// Representa\u00C3\u00A7\u00C3\u00A3o da resposta do recurso Antecipacao Simulada
    /// </summary>
    [DataContract]
    public partial class AntecipacaoSimuladaResponse :  IEquatable<AntecipacaoSimuladaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AntecipacaoSimuladaResponse" /> class.
        /// Initializes a new instance of the <see cref="AntecipacaoSimuladaResponse" />class.
        /// </summary>
        /// <param name="IdSimulacao">C\u00C3\u00B3digo identificador da simula\u00C3\u00A7\u00C3\u00A3o de antecipa\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="IdCompra">C\u00C3\u00B3digo identificador da compra..</param>
        /// <param name="IdConta">C\u00C3\u00B3digo identificador da conta..</param>
        /// <param name="DataHoraSimulacao">Data e hora em que a simula\u00C3\u00A7\u00C3\u00A3o foi feita..</param>
        /// <param name="Detalhes">Detalhes da simula\u00C3\u00A7\u00C3\u00A3o..</param>

        public AntecipacaoSimuladaResponse(long? IdSimulacao = null, long? IdCompra = null, long? IdConta = null, string DataHoraSimulacao = null, List<AntecipacaoSimuladaDetalhesResponse> Detalhes = null)
        {
            this.IdSimulacao = IdSimulacao;
            this.IdCompra = IdCompra;
            this.IdConta = IdConta;
            this.DataHoraSimulacao = DataHoraSimulacao;
            this.Detalhes = Detalhes;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador da simula\u00C3\u00A7\u00C3\u00A3o de antecipa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador da simula\u00C3\u00A7\u00C3\u00A3o de antecipa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="idSimulacao", EmitDefaultValue=false)]
        public long? IdSimulacao { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador da compra.
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador da compra.</value>
        [DataMember(Name="idCompra", EmitDefaultValue=false)]
        public long? IdCompra { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador da conta.
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador da conta.</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Data e hora em que a simula\u00C3\u00A7\u00C3\u00A3o foi feita.
        /// </summary>
        /// <value>Data e hora em que a simula\u00C3\u00A7\u00C3\u00A3o foi feita.</value>
        [DataMember(Name="dataHoraSimulacao", EmitDefaultValue=false)]
        public string DataHoraSimulacao { get; set; }
    
        /// <summary>
        /// Detalhes da simula\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Detalhes da simula\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="detalhes", EmitDefaultValue=false)]
        public List<AntecipacaoSimuladaDetalhesResponse> Detalhes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AntecipacaoSimuladaResponse {\n");
            sb.Append("  IdSimulacao: ").Append(IdSimulacao).Append("\n");
            sb.Append("  IdCompra: ").Append(IdCompra).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  DataHoraSimulacao: ").Append(DataHoraSimulacao).Append("\n");
            sb.Append("  Detalhes: ").Append(Detalhes).Append("\n");
            
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
            return this.Equals(obj as AntecipacaoSimuladaResponse);
        }

        /// <summary>
        /// Returns true if AntecipacaoSimuladaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AntecipacaoSimuladaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AntecipacaoSimuladaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdSimulacao == other.IdSimulacao ||
                    this.IdSimulacao != null &&
                    this.IdSimulacao.Equals(other.IdSimulacao)
                ) && 
                (
                    this.IdCompra == other.IdCompra ||
                    this.IdCompra != null &&
                    this.IdCompra.Equals(other.IdCompra)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.DataHoraSimulacao == other.DataHoraSimulacao ||
                    this.DataHoraSimulacao != null &&
                    this.DataHoraSimulacao.Equals(other.DataHoraSimulacao)
                ) && 
                (
                    this.Detalhes == other.Detalhes ||
                    this.Detalhes != null &&
                    this.Detalhes.SequenceEqual(other.Detalhes)
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
                
                if (this.IdSimulacao != null)
                    hash = hash * 59 + this.IdSimulacao.GetHashCode();
                
                if (this.IdCompra != null)
                    hash = hash * 59 + this.IdCompra.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.DataHoraSimulacao != null)
                    hash = hash * 59 + this.DataHoraSimulacao.GetHashCode();
                
                if (this.Detalhes != null)
                    hash = hash * 59 + this.Detalhes.GetHashCode();
                
                return hash;
            }
        }

    }
}
