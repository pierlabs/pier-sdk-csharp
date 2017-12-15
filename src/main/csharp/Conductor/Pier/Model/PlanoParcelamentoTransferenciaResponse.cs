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
    /// Parcelamento para Transfer\u00C3\u00AAncia de cr\u00C3\u00A9dito para contas banc\u00C3\u00A1rias
    /// </summary>
    [DataContract]
    public partial class PlanoParcelamentoTransferenciaResponse :  IEquatable<PlanoParcelamentoTransferenciaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanoParcelamentoTransferenciaResponse" /> class.
        /// Initializes a new instance of the <see cref="PlanoParcelamentoTransferenciaResponse" />class.
        /// </summary>
        /// <param name="CodigoEspecial">C\u00C3\u00B3digo de processamento da transa\u00C3\u00A7\u00C3\u00A3o..</param>
        /// <param name="VencimentoPrimeiraParcela">Data de vencimento da primeira parcela..</param>
        /// <param name="FlagJuros">Flag indicativa para juros..</param>
        /// <param name="NumeroMesesCarencia">N\u00C3\u00BAmero de meses para car\u00C3\u00AAncia..</param>
        /// <param name="Parcelas">Lista com os planos de parcelamento..</param>

        public PlanoParcelamentoTransferenciaResponse(long? CodigoEspecial = null, string VencimentoPrimeiraParcela = null, int? FlagJuros = null, int? NumeroMesesCarencia = null, List<ParcelamentoTransferenciaResponse> Parcelas = null)
        {
            this.CodigoEspecial = CodigoEspecial;
            this.VencimentoPrimeiraParcela = VencimentoPrimeiraParcela;
            this.FlagJuros = FlagJuros;
            this.NumeroMesesCarencia = NumeroMesesCarencia;
            this.Parcelas = Parcelas;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de processamento da transa\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de processamento da transa\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="codigoEspecial", EmitDefaultValue=false)]
        public long? CodigoEspecial { get; set; }
    
        /// <summary>
        /// Data de vencimento da primeira parcela.
        /// </summary>
        /// <value>Data de vencimento da primeira parcela.</value>
        [DataMember(Name="vencimentoPrimeiraParcela", EmitDefaultValue=false)]
        public string VencimentoPrimeiraParcela { get; set; }
    
        /// <summary>
        /// Flag indicativa para juros.
        /// </summary>
        /// <value>Flag indicativa para juros.</value>
        [DataMember(Name="flagJuros", EmitDefaultValue=false)]
        public int? FlagJuros { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero de meses para car\u00C3\u00AAncia.
        /// </summary>
        /// <value>N\u00C3\u00BAmero de meses para car\u00C3\u00AAncia.</value>
        [DataMember(Name="numeroMesesCarencia", EmitDefaultValue=false)]
        public int? NumeroMesesCarencia { get; set; }
    
        /// <summary>
        /// Lista com os planos de parcelamento.
        /// </summary>
        /// <value>Lista com os planos de parcelamento.</value>
        [DataMember(Name="parcelas", EmitDefaultValue=false)]
        public List<ParcelamentoTransferenciaResponse> Parcelas { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlanoParcelamentoTransferenciaResponse {\n");
            sb.Append("  CodigoEspecial: ").Append(CodigoEspecial).Append("\n");
            sb.Append("  VencimentoPrimeiraParcela: ").Append(VencimentoPrimeiraParcela).Append("\n");
            sb.Append("  FlagJuros: ").Append(FlagJuros).Append("\n");
            sb.Append("  NumeroMesesCarencia: ").Append(NumeroMesesCarencia).Append("\n");
            sb.Append("  Parcelas: ").Append(Parcelas).Append("\n");
            
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
            return this.Equals(obj as PlanoParcelamentoTransferenciaResponse);
        }

        /// <summary>
        /// Returns true if PlanoParcelamentoTransferenciaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PlanoParcelamentoTransferenciaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlanoParcelamentoTransferenciaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CodigoEspecial == other.CodigoEspecial ||
                    this.CodigoEspecial != null &&
                    this.CodigoEspecial.Equals(other.CodigoEspecial)
                ) && 
                (
                    this.VencimentoPrimeiraParcela == other.VencimentoPrimeiraParcela ||
                    this.VencimentoPrimeiraParcela != null &&
                    this.VencimentoPrimeiraParcela.Equals(other.VencimentoPrimeiraParcela)
                ) && 
                (
                    this.FlagJuros == other.FlagJuros ||
                    this.FlagJuros != null &&
                    this.FlagJuros.Equals(other.FlagJuros)
                ) && 
                (
                    this.NumeroMesesCarencia == other.NumeroMesesCarencia ||
                    this.NumeroMesesCarencia != null &&
                    this.NumeroMesesCarencia.Equals(other.NumeroMesesCarencia)
                ) && 
                (
                    this.Parcelas == other.Parcelas ||
                    this.Parcelas != null &&
                    this.Parcelas.SequenceEqual(other.Parcelas)
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
                
                if (this.CodigoEspecial != null)
                    hash = hash * 59 + this.CodigoEspecial.GetHashCode();
                
                if (this.VencimentoPrimeiraParcela != null)
                    hash = hash * 59 + this.VencimentoPrimeiraParcela.GetHashCode();
                
                if (this.FlagJuros != null)
                    hash = hash * 59 + this.FlagJuros.GetHashCode();
                
                if (this.NumeroMesesCarencia != null)
                    hash = hash * 59 + this.NumeroMesesCarencia.GetHashCode();
                
                if (this.Parcelas != null)
                    hash = hash * 59 + this.Parcelas.GetHashCode();
                
                return hash;
            }
        }

    }
}
