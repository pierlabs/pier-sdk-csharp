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
    /// {{{adesao_pacote_tarifa_persistencia_descricao}}}
    /// </summary>
    [DataContract]
    public partial class AdesaoPacoteTarifaPersistencia :  IEquatable<AdesaoPacoteTarifaPersistencia>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdesaoPacoteTarifaPersistencia" /> class.
        /// Initializes a new instance of the <see cref="AdesaoPacoteTarifaPersistencia" />class.
        /// </summary>
        /// <param name="IdPacoteTarifa">{{{adesao_pacote_tarifa_persistencia_id_pacote_tarefa_descricao}}} (required).</param>
        /// <param name="Ciclo">{{{adesao_pacote_tarifa_persistencia_ciclo_descricao}}}.</param>
        /// <param name="DataHoraAtivacao">{{{adesao_pacote_tarifa_persistencia_data_hora_ativacao_descricao}}}.</param>
        /// <param name="DataHoraDesativacao">{{{adesao_pacote_tarifa_persistencia_data_hora_desativacao_descricao}}}.</param>
        /// <param name="DataFimCiclo">{{{adesao_pacote_tarifa_persistencia_data_fim_ciclo_descricao}}}.</param>
        /// <param name="RecargaCelularUtilizado">{{{adesao_pacote_tarifa_persistencia_recarga_celular_utilizado_descricao}}} (required).</param>
        /// <param name="BilheteUnicoUtilizado">{{{adesao_pacote_tarifa_persistencia_bilhete_unico_utilizado_descricao}}} (required).</param>
        /// <param name="PagamentoContaUtilizado">{{{adesao_pacote_tarifa_persistencia_pagamento_conta_utilizado_descricao}}} (required).</param>
        /// <param name="SaqueUtilizado">{{{adesao_pacote_tarifa_persistencia_saque_utilizado_descricao}}} (required).</param>
        /// <param name="TransferenciaUtilizado">{{{adesao_pacote_tarifa_persistencia_transferencia_utilizado_descricao}}} (required).</param>
        /// <param name="BoletoUtilizado">{{{adesao_pacote_tarifa_persistencia_boleto_utilizado_descricao}}} (required).</param>
        /// <param name="AplicacaoUtilizado">{{{adesao_pacote_tarifa_persistencia_aplicacao_utilizado_descricao}}} (required).</param>
        /// <param name="TarifaManutencaoCobrada">{{{adesao_pacote_tarifa_persistencia_tarifa_manutencao_cobrada_descricao}}}.</param>
        /// <param name="CobraTarifa">{{{adesao_pacote_tarifa_persistencia_cobra_tarifa_descricao}}}.</param>

        public AdesaoPacoteTarifaPersistencia(long? IdPacoteTarifa = null, int? Ciclo = null, string DataHoraAtivacao = null, string DataHoraDesativacao = null, string DataFimCiclo = null, int? RecargaCelularUtilizado = null, int? BilheteUnicoUtilizado = null, int? PagamentoContaUtilizado = null, int? SaqueUtilizado = null, int? TransferenciaUtilizado = null, int? BoletoUtilizado = null, int? AplicacaoUtilizado = null, bool? TarifaManutencaoCobrada = null, bool? CobraTarifa = null)
        {
            // to ensure "IdPacoteTarifa" is required (not null)
            if (IdPacoteTarifa == null)
            {
                throw new InvalidDataException("IdPacoteTarifa is a required property for AdesaoPacoteTarifaPersistencia and cannot be null");
            }
            else
            {
                this.IdPacoteTarifa = IdPacoteTarifa;
            }
            // to ensure "RecargaCelularUtilizado" is required (not null)
            if (RecargaCelularUtilizado == null)
            {
                throw new InvalidDataException("RecargaCelularUtilizado is a required property for AdesaoPacoteTarifaPersistencia and cannot be null");
            }
            else
            {
                this.RecargaCelularUtilizado = RecargaCelularUtilizado;
            }
            // to ensure "BilheteUnicoUtilizado" is required (not null)
            if (BilheteUnicoUtilizado == null)
            {
                throw new InvalidDataException("BilheteUnicoUtilizado is a required property for AdesaoPacoteTarifaPersistencia and cannot be null");
            }
            else
            {
                this.BilheteUnicoUtilizado = BilheteUnicoUtilizado;
            }
            // to ensure "PagamentoContaUtilizado" is required (not null)
            if (PagamentoContaUtilizado == null)
            {
                throw new InvalidDataException("PagamentoContaUtilizado is a required property for AdesaoPacoteTarifaPersistencia and cannot be null");
            }
            else
            {
                this.PagamentoContaUtilizado = PagamentoContaUtilizado;
            }
            // to ensure "SaqueUtilizado" is required (not null)
            if (SaqueUtilizado == null)
            {
                throw new InvalidDataException("SaqueUtilizado is a required property for AdesaoPacoteTarifaPersistencia and cannot be null");
            }
            else
            {
                this.SaqueUtilizado = SaqueUtilizado;
            }
            // to ensure "TransferenciaUtilizado" is required (not null)
            if (TransferenciaUtilizado == null)
            {
                throw new InvalidDataException("TransferenciaUtilizado is a required property for AdesaoPacoteTarifaPersistencia and cannot be null");
            }
            else
            {
                this.TransferenciaUtilizado = TransferenciaUtilizado;
            }
            // to ensure "BoletoUtilizado" is required (not null)
            if (BoletoUtilizado == null)
            {
                throw new InvalidDataException("BoletoUtilizado is a required property for AdesaoPacoteTarifaPersistencia and cannot be null");
            }
            else
            {
                this.BoletoUtilizado = BoletoUtilizado;
            }
            // to ensure "AplicacaoUtilizado" is required (not null)
            if (AplicacaoUtilizado == null)
            {
                throw new InvalidDataException("AplicacaoUtilizado is a required property for AdesaoPacoteTarifaPersistencia and cannot be null");
            }
            else
            {
                this.AplicacaoUtilizado = AplicacaoUtilizado;
            }
            this.Ciclo = Ciclo;
            this.DataHoraAtivacao = DataHoraAtivacao;
            this.DataHoraDesativacao = DataHoraDesativacao;
            this.DataFimCiclo = DataFimCiclo;
            this.TarifaManutencaoCobrada = TarifaManutencaoCobrada;
            this.CobraTarifa = CobraTarifa;
            
        }
        
    
        /// <summary>
        /// {{{adesao_pacote_tarifa_persistencia_id_pacote_tarefa_descricao}}}
        /// </summary>
        /// <value>{{{adesao_pacote_tarifa_persistencia_id_pacote_tarefa_descricao}}}</value>
        [DataMember(Name="idPacoteTarifa", EmitDefaultValue=false)]
        public long? IdPacoteTarifa { get; set; }
    
        /// <summary>
        /// {{{adesao_pacote_tarifa_persistencia_ciclo_descricao}}}
        /// </summary>
        /// <value>{{{adesao_pacote_tarifa_persistencia_ciclo_descricao}}}</value>
        [DataMember(Name="ciclo", EmitDefaultValue=false)]
        public int? Ciclo { get; set; }
    
        /// <summary>
        /// {{{adesao_pacote_tarifa_persistencia_data_hora_ativacao_descricao}}}
        /// </summary>
        /// <value>{{{adesao_pacote_tarifa_persistencia_data_hora_ativacao_descricao}}}</value>
        [DataMember(Name="dataHoraAtivacao", EmitDefaultValue=false)]
        public string DataHoraAtivacao { get; set; }
    
        /// <summary>
        /// {{{adesao_pacote_tarifa_persistencia_data_hora_desativacao_descricao}}}
        /// </summary>
        /// <value>{{{adesao_pacote_tarifa_persistencia_data_hora_desativacao_descricao}}}</value>
        [DataMember(Name="dataHoraDesativacao", EmitDefaultValue=false)]
        public string DataHoraDesativacao { get; set; }
    
        /// <summary>
        /// {{{adesao_pacote_tarifa_persistencia_data_fim_ciclo_descricao}}}
        /// </summary>
        /// <value>{{{adesao_pacote_tarifa_persistencia_data_fim_ciclo_descricao}}}</value>
        [DataMember(Name="dataFimCiclo", EmitDefaultValue=false)]
        public string DataFimCiclo { get; set; }
    
        /// <summary>
        /// {{{adesao_pacote_tarifa_persistencia_recarga_celular_utilizado_descricao}}}
        /// </summary>
        /// <value>{{{adesao_pacote_tarifa_persistencia_recarga_celular_utilizado_descricao}}}</value>
        [DataMember(Name="recargaCelularUtilizado", EmitDefaultValue=false)]
        public int? RecargaCelularUtilizado { get; set; }
    
        /// <summary>
        /// {{{adesao_pacote_tarifa_persistencia_bilhete_unico_utilizado_descricao}}}
        /// </summary>
        /// <value>{{{adesao_pacote_tarifa_persistencia_bilhete_unico_utilizado_descricao}}}</value>
        [DataMember(Name="bilheteUnicoUtilizado", EmitDefaultValue=false)]
        public int? BilheteUnicoUtilizado { get; set; }
    
        /// <summary>
        /// {{{adesao_pacote_tarifa_persistencia_pagamento_conta_utilizado_descricao}}}
        /// </summary>
        /// <value>{{{adesao_pacote_tarifa_persistencia_pagamento_conta_utilizado_descricao}}}</value>
        [DataMember(Name="pagamentoContaUtilizado", EmitDefaultValue=false)]
        public int? PagamentoContaUtilizado { get; set; }
    
        /// <summary>
        /// {{{adesao_pacote_tarifa_persistencia_saque_utilizado_descricao}}}
        /// </summary>
        /// <value>{{{adesao_pacote_tarifa_persistencia_saque_utilizado_descricao}}}</value>
        [DataMember(Name="saqueUtilizado", EmitDefaultValue=false)]
        public int? SaqueUtilizado { get; set; }
    
        /// <summary>
        /// {{{adesao_pacote_tarifa_persistencia_transferencia_utilizado_descricao}}}
        /// </summary>
        /// <value>{{{adesao_pacote_tarifa_persistencia_transferencia_utilizado_descricao}}}</value>
        [DataMember(Name="transferenciaUtilizado", EmitDefaultValue=false)]
        public int? TransferenciaUtilizado { get; set; }
    
        /// <summary>
        /// {{{adesao_pacote_tarifa_persistencia_boleto_utilizado_descricao}}}
        /// </summary>
        /// <value>{{{adesao_pacote_tarifa_persistencia_boleto_utilizado_descricao}}}</value>
        [DataMember(Name="boletoUtilizado", EmitDefaultValue=false)]
        public int? BoletoUtilizado { get; set; }
    
        /// <summary>
        /// {{{adesao_pacote_tarifa_persistencia_aplicacao_utilizado_descricao}}}
        /// </summary>
        /// <value>{{{adesao_pacote_tarifa_persistencia_aplicacao_utilizado_descricao}}}</value>
        [DataMember(Name="aplicacaoUtilizado", EmitDefaultValue=false)]
        public int? AplicacaoUtilizado { get; set; }
    
        /// <summary>
        /// {{{adesao_pacote_tarifa_persistencia_tarifa_manutencao_cobrada_descricao}}}
        /// </summary>
        /// <value>{{{adesao_pacote_tarifa_persistencia_tarifa_manutencao_cobrada_descricao}}}</value>
        [DataMember(Name="tarifaManutencaoCobrada", EmitDefaultValue=false)]
        public bool? TarifaManutencaoCobrada { get; set; }
    
        /// <summary>
        /// {{{adesao_pacote_tarifa_persistencia_cobra_tarifa_descricao}}}
        /// </summary>
        /// <value>{{{adesao_pacote_tarifa_persistencia_cobra_tarifa_descricao}}}</value>
        [DataMember(Name="cobraTarifa", EmitDefaultValue=false)]
        public bool? CobraTarifa { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdesaoPacoteTarifaPersistencia {\n");
            sb.Append("  IdPacoteTarifa: ").Append(IdPacoteTarifa).Append("\n");
            sb.Append("  Ciclo: ").Append(Ciclo).Append("\n");
            sb.Append("  DataHoraAtivacao: ").Append(DataHoraAtivacao).Append("\n");
            sb.Append("  DataHoraDesativacao: ").Append(DataHoraDesativacao).Append("\n");
            sb.Append("  DataFimCiclo: ").Append(DataFimCiclo).Append("\n");
            sb.Append("  RecargaCelularUtilizado: ").Append(RecargaCelularUtilizado).Append("\n");
            sb.Append("  BilheteUnicoUtilizado: ").Append(BilheteUnicoUtilizado).Append("\n");
            sb.Append("  PagamentoContaUtilizado: ").Append(PagamentoContaUtilizado).Append("\n");
            sb.Append("  SaqueUtilizado: ").Append(SaqueUtilizado).Append("\n");
            sb.Append("  TransferenciaUtilizado: ").Append(TransferenciaUtilizado).Append("\n");
            sb.Append("  BoletoUtilizado: ").Append(BoletoUtilizado).Append("\n");
            sb.Append("  AplicacaoUtilizado: ").Append(AplicacaoUtilizado).Append("\n");
            sb.Append("  TarifaManutencaoCobrada: ").Append(TarifaManutencaoCobrada).Append("\n");
            sb.Append("  CobraTarifa: ").Append(CobraTarifa).Append("\n");
            
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
            return this.Equals(obj as AdesaoPacoteTarifaPersistencia);
        }

        /// <summary>
        /// Returns true if AdesaoPacoteTarifaPersistencia instances are equal
        /// </summary>
        /// <param name="other">Instance of AdesaoPacoteTarifaPersistencia to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdesaoPacoteTarifaPersistencia other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdPacoteTarifa == other.IdPacoteTarifa ||
                    this.IdPacoteTarifa != null &&
                    this.IdPacoteTarifa.Equals(other.IdPacoteTarifa)
                ) && 
                (
                    this.Ciclo == other.Ciclo ||
                    this.Ciclo != null &&
                    this.Ciclo.Equals(other.Ciclo)
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
                    this.DataFimCiclo == other.DataFimCiclo ||
                    this.DataFimCiclo != null &&
                    this.DataFimCiclo.Equals(other.DataFimCiclo)
                ) && 
                (
                    this.RecargaCelularUtilizado == other.RecargaCelularUtilizado ||
                    this.RecargaCelularUtilizado != null &&
                    this.RecargaCelularUtilizado.Equals(other.RecargaCelularUtilizado)
                ) && 
                (
                    this.BilheteUnicoUtilizado == other.BilheteUnicoUtilizado ||
                    this.BilheteUnicoUtilizado != null &&
                    this.BilheteUnicoUtilizado.Equals(other.BilheteUnicoUtilizado)
                ) && 
                (
                    this.PagamentoContaUtilizado == other.PagamentoContaUtilizado ||
                    this.PagamentoContaUtilizado != null &&
                    this.PagamentoContaUtilizado.Equals(other.PagamentoContaUtilizado)
                ) && 
                (
                    this.SaqueUtilizado == other.SaqueUtilizado ||
                    this.SaqueUtilizado != null &&
                    this.SaqueUtilizado.Equals(other.SaqueUtilizado)
                ) && 
                (
                    this.TransferenciaUtilizado == other.TransferenciaUtilizado ||
                    this.TransferenciaUtilizado != null &&
                    this.TransferenciaUtilizado.Equals(other.TransferenciaUtilizado)
                ) && 
                (
                    this.BoletoUtilizado == other.BoletoUtilizado ||
                    this.BoletoUtilizado != null &&
                    this.BoletoUtilizado.Equals(other.BoletoUtilizado)
                ) && 
                (
                    this.AplicacaoUtilizado == other.AplicacaoUtilizado ||
                    this.AplicacaoUtilizado != null &&
                    this.AplicacaoUtilizado.Equals(other.AplicacaoUtilizado)
                ) && 
                (
                    this.TarifaManutencaoCobrada == other.TarifaManutencaoCobrada ||
                    this.TarifaManutencaoCobrada != null &&
                    this.TarifaManutencaoCobrada.Equals(other.TarifaManutencaoCobrada)
                ) && 
                (
                    this.CobraTarifa == other.CobraTarifa ||
                    this.CobraTarifa != null &&
                    this.CobraTarifa.Equals(other.CobraTarifa)
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
                
                if (this.IdPacoteTarifa != null)
                    hash = hash * 59 + this.IdPacoteTarifa.GetHashCode();
                
                if (this.Ciclo != null)
                    hash = hash * 59 + this.Ciclo.GetHashCode();
                
                if (this.DataHoraAtivacao != null)
                    hash = hash * 59 + this.DataHoraAtivacao.GetHashCode();
                
                if (this.DataHoraDesativacao != null)
                    hash = hash * 59 + this.DataHoraDesativacao.GetHashCode();
                
                if (this.DataFimCiclo != null)
                    hash = hash * 59 + this.DataFimCiclo.GetHashCode();
                
                if (this.RecargaCelularUtilizado != null)
                    hash = hash * 59 + this.RecargaCelularUtilizado.GetHashCode();
                
                if (this.BilheteUnicoUtilizado != null)
                    hash = hash * 59 + this.BilheteUnicoUtilizado.GetHashCode();
                
                if (this.PagamentoContaUtilizado != null)
                    hash = hash * 59 + this.PagamentoContaUtilizado.GetHashCode();
                
                if (this.SaqueUtilizado != null)
                    hash = hash * 59 + this.SaqueUtilizado.GetHashCode();
                
                if (this.TransferenciaUtilizado != null)
                    hash = hash * 59 + this.TransferenciaUtilizado.GetHashCode();
                
                if (this.BoletoUtilizado != null)
                    hash = hash * 59 + this.BoletoUtilizado.GetHashCode();
                
                if (this.AplicacaoUtilizado != null)
                    hash = hash * 59 + this.AplicacaoUtilizado.GetHashCode();
                
                if (this.TarifaManutencaoCobrada != null)
                    hash = hash * 59 + this.TarifaManutencaoCobrada.GetHashCode();
                
                if (this.CobraTarifa != null)
                    hash = hash * 59 + this.CobraTarifa.GetHashCode();
                
                return hash;
            }
        }

    }
}
