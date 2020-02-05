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
    /// Objeto de resposta do recurso lotes de cart\u00F5es
    /// </summary>
    [DataContract]
    public partial class LoteCartaoResponse :  IEquatable<LoteCartaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LoteCartaoResponse" /> class.
        /// Initializes a new instance of the <see cref="LoteCartaoResponse" />class.
        /// </summary>
        /// <param name="DataAgendamento">Data e hora da gera\u00E7\u00E3o do lote.</param>
        /// <param name="DataHoraStatus">Data e hora da modifica\u00E7\u00E3o do status do lote.</param>
        /// <param name="FlagMultiApp">Indica se o lote ser\u00E1 de cart\u00F5es m\u00FAltiplos.</param>
        /// <param name="IdContaDefault">C\u00F3digo identificador da conta padr\u00E3o, caso seja informado os cart\u00F5es do lote ser\u00E3o criados para o id informado.</param>
        /// <param name="IdImagem">C\u00F3digo identificador do tipo pl\u00E1stico imagem.</param>
        /// <param name="IdLote">Identificador do Lote.</param>
        /// <param name="IdOrigemComercial">C\u00F3digo identificador da origem comercial.</param>
        /// <param name="IdPlastico">C\u00F3digo identificador do tipo pl\u00E1stico associado ao produto.</param>
        /// <param name="IdProduto">Identificador do Produto.</param>
        /// <param name="IdSolicitante">Identificador do Solicitante.</param>
        /// <param name="QtdSolicitada">Quantidade Solicitada.</param>
        /// <param name="StatusLote">Status do Lote.</param>
        /// <param name="TipoLote">Tipo do Lote.</param>

        public LoteCartaoResponse(string DataAgendamento = null, string DataHoraStatus = null, bool? FlagMultiApp = null, long? IdContaDefault = null, long? IdImagem = null, long? IdLote = null, long? IdOrigemComercial = null, long? IdPlastico = null, long? IdProduto = null, long? IdSolicitante = null, long? QtdSolicitada = null, int? StatusLote = null, int? TipoLote = null)
        {
            this.DataAgendamento = DataAgendamento;
            this.DataHoraStatus = DataHoraStatus;
            this.FlagMultiApp = FlagMultiApp;
            this.IdContaDefault = IdContaDefault;
            this.IdImagem = IdImagem;
            this.IdLote = IdLote;
            this.IdOrigemComercial = IdOrigemComercial;
            this.IdPlastico = IdPlastico;
            this.IdProduto = IdProduto;
            this.IdSolicitante = IdSolicitante;
            this.QtdSolicitada = QtdSolicitada;
            this.StatusLote = StatusLote;
            this.TipoLote = TipoLote;
            
        }
        
    
        /// <summary>
        /// Data e hora da gera\u00E7\u00E3o do lote
        /// </summary>
        /// <value>Data e hora da gera\u00E7\u00E3o do lote</value>
        [DataMember(Name="dataAgendamento", EmitDefaultValue=false)]
        public string DataAgendamento { get; set; }
    
        /// <summary>
        /// Data e hora da modifica\u00E7\u00E3o do status do lote
        /// </summary>
        /// <value>Data e hora da modifica\u00E7\u00E3o do status do lote</value>
        [DataMember(Name="dataHoraStatus", EmitDefaultValue=false)]
        public string DataHoraStatus { get; set; }
    
        /// <summary>
        /// Indica se o lote ser\u00E1 de cart\u00F5es m\u00FAltiplos
        /// </summary>
        /// <value>Indica se o lote ser\u00E1 de cart\u00F5es m\u00FAltiplos</value>
        [DataMember(Name="flagMultiApp", EmitDefaultValue=false)]
        public bool? FlagMultiApp { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador da conta padr\u00E3o, caso seja informado os cart\u00F5es do lote ser\u00E3o criados para o id informado
        /// </summary>
        /// <value>C\u00F3digo identificador da conta padr\u00E3o, caso seja informado os cart\u00F5es do lote ser\u00E3o criados para o id informado</value>
        [DataMember(Name="idContaDefault", EmitDefaultValue=false)]
        public long? IdContaDefault { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador do tipo pl\u00E1stico imagem
        /// </summary>
        /// <value>C\u00F3digo identificador do tipo pl\u00E1stico imagem</value>
        [DataMember(Name="idImagem", EmitDefaultValue=false)]
        public long? IdImagem { get; set; }
    
        /// <summary>
        /// Identificador do Lote
        /// </summary>
        /// <value>Identificador do Lote</value>
        [DataMember(Name="idLote", EmitDefaultValue=false)]
        public long? IdLote { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador da origem comercial
        /// </summary>
        /// <value>C\u00F3digo identificador da origem comercial</value>
        [DataMember(Name="idOrigemComercial", EmitDefaultValue=false)]
        public long? IdOrigemComercial { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador do tipo pl\u00E1stico associado ao produto
        /// </summary>
        /// <value>C\u00F3digo identificador do tipo pl\u00E1stico associado ao produto</value>
        [DataMember(Name="idPlastico", EmitDefaultValue=false)]
        public long? IdPlastico { get; set; }
    
        /// <summary>
        /// Identificador do Produto
        /// </summary>
        /// <value>Identificador do Produto</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// Identificador do Solicitante
        /// </summary>
        /// <value>Identificador do Solicitante</value>
        [DataMember(Name="idSolicitante", EmitDefaultValue=false)]
        public long? IdSolicitante { get; set; }
    
        /// <summary>
        /// Quantidade Solicitada
        /// </summary>
        /// <value>Quantidade Solicitada</value>
        [DataMember(Name="qtdSolicitada", EmitDefaultValue=false)]
        public long? QtdSolicitada { get; set; }
    
        /// <summary>
        /// Status do Lote
        /// </summary>
        /// <value>Status do Lote</value>
        [DataMember(Name="statusLote", EmitDefaultValue=false)]
        public int? StatusLote { get; set; }
    
        /// <summary>
        /// Tipo do Lote
        /// </summary>
        /// <value>Tipo do Lote</value>
        [DataMember(Name="tipoLote", EmitDefaultValue=false)]
        public int? TipoLote { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoteCartaoResponse {\n");
            sb.Append("  DataAgendamento: ").Append(DataAgendamento).Append("\n");
            sb.Append("  DataHoraStatus: ").Append(DataHoraStatus).Append("\n");
            sb.Append("  FlagMultiApp: ").Append(FlagMultiApp).Append("\n");
            sb.Append("  IdContaDefault: ").Append(IdContaDefault).Append("\n");
            sb.Append("  IdImagem: ").Append(IdImagem).Append("\n");
            sb.Append("  IdLote: ").Append(IdLote).Append("\n");
            sb.Append("  IdOrigemComercial: ").Append(IdOrigemComercial).Append("\n");
            sb.Append("  IdPlastico: ").Append(IdPlastico).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  IdSolicitante: ").Append(IdSolicitante).Append("\n");
            sb.Append("  QtdSolicitada: ").Append(QtdSolicitada).Append("\n");
            sb.Append("  StatusLote: ").Append(StatusLote).Append("\n");
            sb.Append("  TipoLote: ").Append(TipoLote).Append("\n");
            
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
            return this.Equals(obj as LoteCartaoResponse);
        }

        /// <summary>
        /// Returns true if LoteCartaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of LoteCartaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoteCartaoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DataAgendamento == other.DataAgendamento ||
                    this.DataAgendamento != null &&
                    this.DataAgendamento.Equals(other.DataAgendamento)
                ) && 
                (
                    this.DataHoraStatus == other.DataHoraStatus ||
                    this.DataHoraStatus != null &&
                    this.DataHoraStatus.Equals(other.DataHoraStatus)
                ) && 
                (
                    this.FlagMultiApp == other.FlagMultiApp ||
                    this.FlagMultiApp != null &&
                    this.FlagMultiApp.Equals(other.FlagMultiApp)
                ) && 
                (
                    this.IdContaDefault == other.IdContaDefault ||
                    this.IdContaDefault != null &&
                    this.IdContaDefault.Equals(other.IdContaDefault)
                ) && 
                (
                    this.IdImagem == other.IdImagem ||
                    this.IdImagem != null &&
                    this.IdImagem.Equals(other.IdImagem)
                ) && 
                (
                    this.IdLote == other.IdLote ||
                    this.IdLote != null &&
                    this.IdLote.Equals(other.IdLote)
                ) && 
                (
                    this.IdOrigemComercial == other.IdOrigemComercial ||
                    this.IdOrigemComercial != null &&
                    this.IdOrigemComercial.Equals(other.IdOrigemComercial)
                ) && 
                (
                    this.IdPlastico == other.IdPlastico ||
                    this.IdPlastico != null &&
                    this.IdPlastico.Equals(other.IdPlastico)
                ) && 
                (
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.IdSolicitante == other.IdSolicitante ||
                    this.IdSolicitante != null &&
                    this.IdSolicitante.Equals(other.IdSolicitante)
                ) && 
                (
                    this.QtdSolicitada == other.QtdSolicitada ||
                    this.QtdSolicitada != null &&
                    this.QtdSolicitada.Equals(other.QtdSolicitada)
                ) && 
                (
                    this.StatusLote == other.StatusLote ||
                    this.StatusLote != null &&
                    this.StatusLote.Equals(other.StatusLote)
                ) && 
                (
                    this.TipoLote == other.TipoLote ||
                    this.TipoLote != null &&
                    this.TipoLote.Equals(other.TipoLote)
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
                
                if (this.DataAgendamento != null)
                    hash = hash * 59 + this.DataAgendamento.GetHashCode();
                
                if (this.DataHoraStatus != null)
                    hash = hash * 59 + this.DataHoraStatus.GetHashCode();
                
                if (this.FlagMultiApp != null)
                    hash = hash * 59 + this.FlagMultiApp.GetHashCode();
                
                if (this.IdContaDefault != null)
                    hash = hash * 59 + this.IdContaDefault.GetHashCode();
                
                if (this.IdImagem != null)
                    hash = hash * 59 + this.IdImagem.GetHashCode();
                
                if (this.IdLote != null)
                    hash = hash * 59 + this.IdLote.GetHashCode();
                
                if (this.IdOrigemComercial != null)
                    hash = hash * 59 + this.IdOrigemComercial.GetHashCode();
                
                if (this.IdPlastico != null)
                    hash = hash * 59 + this.IdPlastico.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.IdSolicitante != null)
                    hash = hash * 59 + this.IdSolicitante.GetHashCode();
                
                if (this.QtdSolicitada != null)
                    hash = hash * 59 + this.QtdSolicitada.GetHashCode();
                
                if (this.StatusLote != null)
                    hash = hash * 59 + this.StatusLote.GetHashCode();
                
                if (this.TipoLote != null)
                    hash = hash * 59 + this.TipoLote.GetHashCode();
                
                return hash;
            }
        }

    }
}
