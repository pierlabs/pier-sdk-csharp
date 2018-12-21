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
    /// Representation of the Accession Fee Package Tariff
    /// </summary>
    [DataContract]
    public partial class AdesaoPacoteTarifaResponse :  IEquatable<AdesaoPacoteTarifaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdesaoPacoteTarifaResponse" /> class.
        /// Initializes a new instance of the <see cref="AdesaoPacoteTarifaResponse" />class.
        /// </summary>
        /// <param name="AplicacaoUtilizado">application used.</param>
        /// <param name="BilheteUnicoUtilizado">single ticket used.</param>
        /// <param name="BoletoUtilizado">ticket used.</param>
        /// <param name="Ciclo">adhesion cycle.</param>
        /// <param name="CobraTarifa">tariff charged.</param>
        /// <param name="DataFimCiclo">end date of the cycle.</param>
        /// <param name="DataHoraAtivacao">date of activation.</param>
        /// <param name="DataHoraDesativacao">date of deactivation.</param>
        /// <param name="Id">Adhesion id.</param>
        /// <param name="IdConta">account id.</param>
        /// <param name="PacoteTarifa">Rate package.</param>
        /// <param name="PagamentoContaUtilizado">payment for the account used.</param>
        /// <param name="RecargaCelularUtilizado">used cellular recharge.</param>
        /// <param name="SaqueUtilizado">used service.</param>
        /// <param name="TarifaManutencaoCobrada">maintenance charge charged.</param>
        /// <param name="TransferenciaUtilizado">used transfer.</param>

        public AdesaoPacoteTarifaResponse(int? AplicacaoUtilizado = null, int? BilheteUnicoUtilizado = null, int? BoletoUtilizado = null, int? Ciclo = null, bool? CobraTarifa = null, string DataFimCiclo = null, string DataHoraAtivacao = null, string DataHoraDesativacao = null, long? Id = null, long? IdConta = null, PacoteTarifaResponse PacoteTarifa = null, int? PagamentoContaUtilizado = null, int? RecargaCelularUtilizado = null, int? SaqueUtilizado = null, bool? TarifaManutencaoCobrada = null, int? TransferenciaUtilizado = null)
        {
            this.AplicacaoUtilizado = AplicacaoUtilizado;
            this.BilheteUnicoUtilizado = BilheteUnicoUtilizado;
            this.BoletoUtilizado = BoletoUtilizado;
            this.Ciclo = Ciclo;
            this.CobraTarifa = CobraTarifa;
            this.DataFimCiclo = DataFimCiclo;
            this.DataHoraAtivacao = DataHoraAtivacao;
            this.DataHoraDesativacao = DataHoraDesativacao;
            this.Id = Id;
            this.IdConta = IdConta;
            this.PacoteTarifa = PacoteTarifa;
            this.PagamentoContaUtilizado = PagamentoContaUtilizado;
            this.RecargaCelularUtilizado = RecargaCelularUtilizado;
            this.SaqueUtilizado = SaqueUtilizado;
            this.TarifaManutencaoCobrada = TarifaManutencaoCobrada;
            this.TransferenciaUtilizado = TransferenciaUtilizado;
            
        }
        
    
        /// <summary>
        /// application used
        /// </summary>
        /// <value>application used</value>
        [DataMember(Name="aplicacaoUtilizado", EmitDefaultValue=false)]
        public int? AplicacaoUtilizado { get; set; }
    
        /// <summary>
        /// single ticket used
        /// </summary>
        /// <value>single ticket used</value>
        [DataMember(Name="bilheteUnicoUtilizado", EmitDefaultValue=false)]
        public int? BilheteUnicoUtilizado { get; set; }
    
        /// <summary>
        /// ticket used
        /// </summary>
        /// <value>ticket used</value>
        [DataMember(Name="boletoUtilizado", EmitDefaultValue=false)]
        public int? BoletoUtilizado { get; set; }
    
        /// <summary>
        /// adhesion cycle
        /// </summary>
        /// <value>adhesion cycle</value>
        [DataMember(Name="ciclo", EmitDefaultValue=false)]
        public int? Ciclo { get; set; }
    
        /// <summary>
        /// tariff charged
        /// </summary>
        /// <value>tariff charged</value>
        [DataMember(Name="cobraTarifa", EmitDefaultValue=false)]
        public bool? CobraTarifa { get; set; }
    
        /// <summary>
        /// end date of the cycle
        /// </summary>
        /// <value>end date of the cycle</value>
        [DataMember(Name="dataFimCiclo", EmitDefaultValue=false)]
        public string DataFimCiclo { get; set; }
    
        /// <summary>
        /// date of activation
        /// </summary>
        /// <value>date of activation</value>
        [DataMember(Name="dataHoraAtivacao", EmitDefaultValue=false)]
        public string DataHoraAtivacao { get; set; }
    
        /// <summary>
        /// date of deactivation
        /// </summary>
        /// <value>date of deactivation</value>
        [DataMember(Name="dataHoraDesativacao", EmitDefaultValue=false)]
        public string DataHoraDesativacao { get; set; }
    
        /// <summary>
        /// Adhesion id
        /// </summary>
        /// <value>Adhesion id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// account id
        /// </summary>
        /// <value>account id</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Rate package
        /// </summary>
        /// <value>Rate package</value>
        [DataMember(Name="pacoteTarifa", EmitDefaultValue=false)]
        public PacoteTarifaResponse PacoteTarifa { get; set; }
    
        /// <summary>
        /// payment for the account used
        /// </summary>
        /// <value>payment for the account used</value>
        [DataMember(Name="pagamentoContaUtilizado", EmitDefaultValue=false)]
        public int? PagamentoContaUtilizado { get; set; }
    
        /// <summary>
        /// used cellular recharge
        /// </summary>
        /// <value>used cellular recharge</value>
        [DataMember(Name="recargaCelularUtilizado", EmitDefaultValue=false)]
        public int? RecargaCelularUtilizado { get; set; }
    
        /// <summary>
        /// used service
        /// </summary>
        /// <value>used service</value>
        [DataMember(Name="saqueUtilizado", EmitDefaultValue=false)]
        public int? SaqueUtilizado { get; set; }
    
        /// <summary>
        /// maintenance charge charged
        /// </summary>
        /// <value>maintenance charge charged</value>
        [DataMember(Name="tarifaManutencaoCobrada", EmitDefaultValue=false)]
        public bool? TarifaManutencaoCobrada { get; set; }
    
        /// <summary>
        /// used transfer
        /// </summary>
        /// <value>used transfer</value>
        [DataMember(Name="transferenciaUtilizado", EmitDefaultValue=false)]
        public int? TransferenciaUtilizado { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdesaoPacoteTarifaResponse {\n");
            sb.Append("  AplicacaoUtilizado: ").Append(AplicacaoUtilizado).Append("\n");
            sb.Append("  BilheteUnicoUtilizado: ").Append(BilheteUnicoUtilizado).Append("\n");
            sb.Append("  BoletoUtilizado: ").Append(BoletoUtilizado).Append("\n");
            sb.Append("  Ciclo: ").Append(Ciclo).Append("\n");
            sb.Append("  CobraTarifa: ").Append(CobraTarifa).Append("\n");
            sb.Append("  DataFimCiclo: ").Append(DataFimCiclo).Append("\n");
            sb.Append("  DataHoraAtivacao: ").Append(DataHoraAtivacao).Append("\n");
            sb.Append("  DataHoraDesativacao: ").Append(DataHoraDesativacao).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  PacoteTarifa: ").Append(PacoteTarifa).Append("\n");
            sb.Append("  PagamentoContaUtilizado: ").Append(PagamentoContaUtilizado).Append("\n");
            sb.Append("  RecargaCelularUtilizado: ").Append(RecargaCelularUtilizado).Append("\n");
            sb.Append("  SaqueUtilizado: ").Append(SaqueUtilizado).Append("\n");
            sb.Append("  TarifaManutencaoCobrada: ").Append(TarifaManutencaoCobrada).Append("\n");
            sb.Append("  TransferenciaUtilizado: ").Append(TransferenciaUtilizado).Append("\n");
            
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
            return this.Equals(obj as AdesaoPacoteTarifaResponse);
        }

        /// <summary>
        /// Returns true if AdesaoPacoteTarifaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AdesaoPacoteTarifaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdesaoPacoteTarifaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AplicacaoUtilizado == other.AplicacaoUtilizado ||
                    this.AplicacaoUtilizado != null &&
                    this.AplicacaoUtilizado.Equals(other.AplicacaoUtilizado)
                ) && 
                (
                    this.BilheteUnicoUtilizado == other.BilheteUnicoUtilizado ||
                    this.BilheteUnicoUtilizado != null &&
                    this.BilheteUnicoUtilizado.Equals(other.BilheteUnicoUtilizado)
                ) && 
                (
                    this.BoletoUtilizado == other.BoletoUtilizado ||
                    this.BoletoUtilizado != null &&
                    this.BoletoUtilizado.Equals(other.BoletoUtilizado)
                ) && 
                (
                    this.Ciclo == other.Ciclo ||
                    this.Ciclo != null &&
                    this.Ciclo.Equals(other.Ciclo)
                ) && 
                (
                    this.CobraTarifa == other.CobraTarifa ||
                    this.CobraTarifa != null &&
                    this.CobraTarifa.Equals(other.CobraTarifa)
                ) && 
                (
                    this.DataFimCiclo == other.DataFimCiclo ||
                    this.DataFimCiclo != null &&
                    this.DataFimCiclo.Equals(other.DataFimCiclo)
                ) && 
                (
                    this.DataHoraAtivacao == other.DataHoraAtivacao ||
                    this.DataHoraAtivacao != null &&
                    this.DataHoraAtivacao.Equals(other.DataHoraAtivacao)
                ) && 
                (
                    this.DataHoraDesativacao == other.DataHoraDesativacao ||
                    this.DataHoraDesativacao != null &&
                    this.DataHoraDesativacao.Equals(other.DataHoraDesativacao)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.PacoteTarifa == other.PacoteTarifa ||
                    this.PacoteTarifa != null &&
                    this.PacoteTarifa.Equals(other.PacoteTarifa)
                ) && 
                (
                    this.PagamentoContaUtilizado == other.PagamentoContaUtilizado ||
                    this.PagamentoContaUtilizado != null &&
                    this.PagamentoContaUtilizado.Equals(other.PagamentoContaUtilizado)
                ) && 
                (
                    this.RecargaCelularUtilizado == other.RecargaCelularUtilizado ||
                    this.RecargaCelularUtilizado != null &&
                    this.RecargaCelularUtilizado.Equals(other.RecargaCelularUtilizado)
                ) && 
                (
                    this.SaqueUtilizado == other.SaqueUtilizado ||
                    this.SaqueUtilizado != null &&
                    this.SaqueUtilizado.Equals(other.SaqueUtilizado)
                ) && 
                (
                    this.TarifaManutencaoCobrada == other.TarifaManutencaoCobrada ||
                    this.TarifaManutencaoCobrada != null &&
                    this.TarifaManutencaoCobrada.Equals(other.TarifaManutencaoCobrada)
                ) && 
                (
                    this.TransferenciaUtilizado == other.TransferenciaUtilizado ||
                    this.TransferenciaUtilizado != null &&
                    this.TransferenciaUtilizado.Equals(other.TransferenciaUtilizado)
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
                
                if (this.AplicacaoUtilizado != null)
                    hash = hash * 59 + this.AplicacaoUtilizado.GetHashCode();
                
                if (this.BilheteUnicoUtilizado != null)
                    hash = hash * 59 + this.BilheteUnicoUtilizado.GetHashCode();
                
                if (this.BoletoUtilizado != null)
                    hash = hash * 59 + this.BoletoUtilizado.GetHashCode();
                
                if (this.Ciclo != null)
                    hash = hash * 59 + this.Ciclo.GetHashCode();
                
                if (this.CobraTarifa != null)
                    hash = hash * 59 + this.CobraTarifa.GetHashCode();
                
                if (this.DataFimCiclo != null)
                    hash = hash * 59 + this.DataFimCiclo.GetHashCode();
                
                if (this.DataHoraAtivacao != null)
                    hash = hash * 59 + this.DataHoraAtivacao.GetHashCode();
                
                if (this.DataHoraDesativacao != null)
                    hash = hash * 59 + this.DataHoraDesativacao.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.PacoteTarifa != null)
                    hash = hash * 59 + this.PacoteTarifa.GetHashCode();
                
                if (this.PagamentoContaUtilizado != null)
                    hash = hash * 59 + this.PagamentoContaUtilizado.GetHashCode();
                
                if (this.RecargaCelularUtilizado != null)
                    hash = hash * 59 + this.RecargaCelularUtilizado.GetHashCode();
                
                if (this.SaqueUtilizado != null)
                    hash = hash * 59 + this.SaqueUtilizado.GetHashCode();
                
                if (this.TarifaManutencaoCobrada != null)
                    hash = hash * 59 + this.TarifaManutencaoCobrada.GetHashCode();
                
                if (this.TransferenciaUtilizado != null)
                    hash = hash * 59 + this.TransferenciaUtilizado.GetHashCode();
                
                return hash;
            }
        }

    }
}
