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
    /// Objeto que representa o DTO update do recurso lotes de cart\u00F5es
    /// </summary>
    [DataContract]
    public partial class LoteCartaoUpdate :  IEquatable<LoteCartaoUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LoteCartaoUpdate" /> class.
        /// Initializes a new instance of the <see cref="LoteCartaoUpdate" />class.
        /// </summary>
        /// <param name="QtdSolicitada">Quantidade de cart\u00F5es a ser emitido.</param>
        /// <param name="IdProduto">C\u00F3digo identificador do produto.</param>
        /// <param name="IdSolicitante">C\u00F3digo identificador do solicitante.</param>
        /// <param name="IdOrigemComercial">C\u00F3digo identificador da origem comercial.</param>
        /// <param name="IdPlastico">C\u00F3digo identificador do tipo pl\u00E1stico associado ao produto.</param>
        /// <param name="IdImagem">C\u00F3digo identificador do tipo pl\u00E1stico imagem.</param>
        /// <param name="IdContaDefault">C\u00F3digo identificador da conta padr\u00E3o, caso seja informado os cart\u00F5es do lote ser\u00E3o criados para o id informado.</param>
        /// <param name="FlagMultiApp">Indica se o lote ser\u00E1 de cart\u00F5es m\u00FAltiplos.</param>
        /// <param name="DataAgendamento">Data de agendamento da execu\u00E7\u00E3o do lote.</param>

        public LoteCartaoUpdate(int? QtdSolicitada = null, long? IdProduto = null, long? IdSolicitante = null, long? IdOrigemComercial = null, long? IdPlastico = null, long? IdImagem = null, long? IdContaDefault = null, bool? FlagMultiApp = null, string DataAgendamento = null)
        {
            this.QtdSolicitada = QtdSolicitada;
            this.IdProduto = IdProduto;
            this.IdSolicitante = IdSolicitante;
            this.IdOrigemComercial = IdOrigemComercial;
            this.IdPlastico = IdPlastico;
            this.IdImagem = IdImagem;
            this.IdContaDefault = IdContaDefault;
            this.FlagMultiApp = FlagMultiApp;
            this.DataAgendamento = DataAgendamento;
            
        }
        
    
        /// <summary>
        /// Quantidade de cart\u00F5es a ser emitido
        /// </summary>
        /// <value>Quantidade de cart\u00F5es a ser emitido</value>
        [DataMember(Name="qtdSolicitada", EmitDefaultValue=false)]
        public int? QtdSolicitada { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador do produto
        /// </summary>
        /// <value>C\u00F3digo identificador do produto</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador do solicitante
        /// </summary>
        /// <value>C\u00F3digo identificador do solicitante</value>
        [DataMember(Name="idSolicitante", EmitDefaultValue=false)]
        public long? IdSolicitante { get; set; }
    
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
        /// C\u00F3digo identificador do tipo pl\u00E1stico imagem
        /// </summary>
        /// <value>C\u00F3digo identificador do tipo pl\u00E1stico imagem</value>
        [DataMember(Name="idImagem", EmitDefaultValue=false)]
        public long? IdImagem { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador da conta padr\u00E3o, caso seja informado os cart\u00F5es do lote ser\u00E3o criados para o id informado
        /// </summary>
        /// <value>C\u00F3digo identificador da conta padr\u00E3o, caso seja informado os cart\u00F5es do lote ser\u00E3o criados para o id informado</value>
        [DataMember(Name="idContaDefault", EmitDefaultValue=false)]
        public long? IdContaDefault { get; set; }
    
        /// <summary>
        /// Indica se o lote ser\u00E1 de cart\u00F5es m\u00FAltiplos
        /// </summary>
        /// <value>Indica se o lote ser\u00E1 de cart\u00F5es m\u00FAltiplos</value>
        [DataMember(Name="flagMultiApp", EmitDefaultValue=false)]
        public bool? FlagMultiApp { get; set; }
    
        /// <summary>
        /// Data de agendamento da execu\u00E7\u00E3o do lote
        /// </summary>
        /// <value>Data de agendamento da execu\u00E7\u00E3o do lote</value>
        [DataMember(Name="dataAgendamento", EmitDefaultValue=false)]
        public string DataAgendamento { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoteCartaoUpdate {\n");
            sb.Append("  QtdSolicitada: ").Append(QtdSolicitada).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  IdSolicitante: ").Append(IdSolicitante).Append("\n");
            sb.Append("  IdOrigemComercial: ").Append(IdOrigemComercial).Append("\n");
            sb.Append("  IdPlastico: ").Append(IdPlastico).Append("\n");
            sb.Append("  IdImagem: ").Append(IdImagem).Append("\n");
            sb.Append("  IdContaDefault: ").Append(IdContaDefault).Append("\n");
            sb.Append("  FlagMultiApp: ").Append(FlagMultiApp).Append("\n");
            sb.Append("  DataAgendamento: ").Append(DataAgendamento).Append("\n");
            
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
            return this.Equals(obj as LoteCartaoUpdate);
        }

        /// <summary>
        /// Returns true if LoteCartaoUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of LoteCartaoUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoteCartaoUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.QtdSolicitada == other.QtdSolicitada ||
                    this.QtdSolicitada != null &&
                    this.QtdSolicitada.Equals(other.QtdSolicitada)
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
                    this.IdImagem == other.IdImagem ||
                    this.IdImagem != null &&
                    this.IdImagem.Equals(other.IdImagem)
                ) && 
                (
                    this.IdContaDefault == other.IdContaDefault ||
                    this.IdContaDefault != null &&
                    this.IdContaDefault.Equals(other.IdContaDefault)
                ) && 
                (
                    this.FlagMultiApp == other.FlagMultiApp ||
                    this.FlagMultiApp != null &&
                    this.FlagMultiApp.Equals(other.FlagMultiApp)
                ) && 
                (
                    this.DataAgendamento == other.DataAgendamento ||
                    this.DataAgendamento != null &&
                    this.DataAgendamento.Equals(other.DataAgendamento)
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
                
                if (this.QtdSolicitada != null)
                    hash = hash * 59 + this.QtdSolicitada.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.IdSolicitante != null)
                    hash = hash * 59 + this.IdSolicitante.GetHashCode();
                
                if (this.IdOrigemComercial != null)
                    hash = hash * 59 + this.IdOrigemComercial.GetHashCode();
                
                if (this.IdPlastico != null)
                    hash = hash * 59 + this.IdPlastico.GetHashCode();
                
                if (this.IdImagem != null)
                    hash = hash * 59 + this.IdImagem.GetHashCode();
                
                if (this.IdContaDefault != null)
                    hash = hash * 59 + this.IdContaDefault.GetHashCode();
                
                if (this.FlagMultiApp != null)
                    hash = hash * 59 + this.FlagMultiApp.GetHashCode();
                
                if (this.DataAgendamento != null)
                    hash = hash * 59 + this.DataAgendamento.GetHashCode();
                
                return hash;
            }
        }

    }
}
