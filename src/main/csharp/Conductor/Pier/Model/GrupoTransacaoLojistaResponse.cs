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
    /// Descri\u00E7\u00E3o do objeto de resposta do grupo de transa\u00E7\u00E3o lojista
    /// </summary>
    [DataContract]
    public partial class GrupoTransacaoLojistaResponse :  IEquatable<GrupoTransacaoLojistaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GrupoTransacaoLojistaResponse" /> class.
        /// Initializes a new instance of the <see cref="GrupoTransacaoLojistaResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo identificador do grupo de transa\u00E7\u00E3o lojista.</param>
        /// <param name="Descricao">Descri\u00E7\u00E3o do grupo de transa\u00E7\u00E3o lojista.</param>
        /// <param name="FlagCompra">Indica se permite compra.</param>
        /// <param name="FlagSaque">Indica se permite saque.</param>
        /// <param name="FlagComissao">Indica se recebe comiss\u00E3o.</param>
        /// <param name="FlagChargeBack">Indica se permite chargeback.</param>
        /// <param name="FlagOutrosDebitos">Indica se recebe outros d\u00E9bitos.</param>
        /// <param name="FlagPagamento">Indica pagamento.</param>
        /// <param name="FlagOutrosCreditos">Indica se recebe outros cr\u00E9ditos.</param>

        public GrupoTransacaoLojistaResponse(long? Id = null, string Descricao = null, bool? FlagCompra = null, bool? FlagSaque = null, bool? FlagComissao = null, bool? FlagChargeBack = null, bool? FlagOutrosDebitos = null, bool? FlagPagamento = null, bool? FlagOutrosCreditos = null)
        {
            this.Id = Id;
            this.Descricao = Descricao;
            this.FlagCompra = FlagCompra;
            this.FlagSaque = FlagSaque;
            this.FlagComissao = FlagComissao;
            this.FlagChargeBack = FlagChargeBack;
            this.FlagOutrosDebitos = FlagOutrosDebitos;
            this.FlagPagamento = FlagPagamento;
            this.FlagOutrosCreditos = FlagOutrosCreditos;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo identificador do grupo de transa\u00E7\u00E3o lojista
        /// </summary>
        /// <value>C\u00F3digo identificador do grupo de transa\u00E7\u00E3o lojista</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do grupo de transa\u00E7\u00E3o lojista
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do grupo de transa\u00E7\u00E3o lojista</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Indica se permite compra
        /// </summary>
        /// <value>Indica se permite compra</value>
        [DataMember(Name="flagCompra", EmitDefaultValue=false)]
        public bool? FlagCompra { get; set; }
    
        /// <summary>
        /// Indica se permite saque
        /// </summary>
        /// <value>Indica se permite saque</value>
        [DataMember(Name="flagSaque", EmitDefaultValue=false)]
        public bool? FlagSaque { get; set; }
    
        /// <summary>
        /// Indica se recebe comiss\u00E3o
        /// </summary>
        /// <value>Indica se recebe comiss\u00E3o</value>
        [DataMember(Name="flagComissao", EmitDefaultValue=false)]
        public bool? FlagComissao { get; set; }
    
        /// <summary>
        /// Indica se permite chargeback
        /// </summary>
        /// <value>Indica se permite chargeback</value>
        [DataMember(Name="flagChargeBack", EmitDefaultValue=false)]
        public bool? FlagChargeBack { get; set; }
    
        /// <summary>
        /// Indica se recebe outros d\u00E9bitos
        /// </summary>
        /// <value>Indica se recebe outros d\u00E9bitos</value>
        [DataMember(Name="flagOutrosDebitos", EmitDefaultValue=false)]
        public bool? FlagOutrosDebitos { get; set; }
    
        /// <summary>
        /// Indica pagamento
        /// </summary>
        /// <value>Indica pagamento</value>
        [DataMember(Name="flagPagamento", EmitDefaultValue=false)]
        public bool? FlagPagamento { get; set; }
    
        /// <summary>
        /// Indica se recebe outros cr\u00E9ditos
        /// </summary>
        /// <value>Indica se recebe outros cr\u00E9ditos</value>
        [DataMember(Name="flagOutrosCreditos", EmitDefaultValue=false)]
        public bool? FlagOutrosCreditos { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GrupoTransacaoLojistaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  FlagCompra: ").Append(FlagCompra).Append("\n");
            sb.Append("  FlagSaque: ").Append(FlagSaque).Append("\n");
            sb.Append("  FlagComissao: ").Append(FlagComissao).Append("\n");
            sb.Append("  FlagChargeBack: ").Append(FlagChargeBack).Append("\n");
            sb.Append("  FlagOutrosDebitos: ").Append(FlagOutrosDebitos).Append("\n");
            sb.Append("  FlagPagamento: ").Append(FlagPagamento).Append("\n");
            sb.Append("  FlagOutrosCreditos: ").Append(FlagOutrosCreditos).Append("\n");
            
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
            return this.Equals(obj as GrupoTransacaoLojistaResponse);
        }

        /// <summary>
        /// Returns true if GrupoTransacaoLojistaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of GrupoTransacaoLojistaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GrupoTransacaoLojistaResponse other)
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
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.FlagCompra == other.FlagCompra ||
                    this.FlagCompra != null &&
                    this.FlagCompra.Equals(other.FlagCompra)
                ) && 
                (
                    this.FlagSaque == other.FlagSaque ||
                    this.FlagSaque != null &&
                    this.FlagSaque.Equals(other.FlagSaque)
                ) && 
                (
                    this.FlagComissao == other.FlagComissao ||
                    this.FlagComissao != null &&
                    this.FlagComissao.Equals(other.FlagComissao)
                ) && 
                (
                    this.FlagChargeBack == other.FlagChargeBack ||
                    this.FlagChargeBack != null &&
                    this.FlagChargeBack.Equals(other.FlagChargeBack)
                ) && 
                (
                    this.FlagOutrosDebitos == other.FlagOutrosDebitos ||
                    this.FlagOutrosDebitos != null &&
                    this.FlagOutrosDebitos.Equals(other.FlagOutrosDebitos)
                ) && 
                (
                    this.FlagPagamento == other.FlagPagamento ||
                    this.FlagPagamento != null &&
                    this.FlagPagamento.Equals(other.FlagPagamento)
                ) && 
                (
                    this.FlagOutrosCreditos == other.FlagOutrosCreditos ||
                    this.FlagOutrosCreditos != null &&
                    this.FlagOutrosCreditos.Equals(other.FlagOutrosCreditos)
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
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.FlagCompra != null)
                    hash = hash * 59 + this.FlagCompra.GetHashCode();
                
                if (this.FlagSaque != null)
                    hash = hash * 59 + this.FlagSaque.GetHashCode();
                
                if (this.FlagComissao != null)
                    hash = hash * 59 + this.FlagComissao.GetHashCode();
                
                if (this.FlagChargeBack != null)
                    hash = hash * 59 + this.FlagChargeBack.GetHashCode();
                
                if (this.FlagOutrosDebitos != null)
                    hash = hash * 59 + this.FlagOutrosDebitos.GetHashCode();
                
                if (this.FlagPagamento != null)
                    hash = hash * 59 + this.FlagPagamento.GetHashCode();
                
                if (this.FlagOutrosCreditos != null)
                    hash = hash * 59 + this.FlagOutrosCreditos.GetHashCode();
                
                return hash;
            }
        }

    }
}
