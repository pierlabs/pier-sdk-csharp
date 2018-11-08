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
    /// {{{produto_pacote_tarifa_response_descricao}}}
    /// </summary>
    [DataContract]
    public partial class ProdutoPacoteTarifaResponse :  IEquatable<ProdutoPacoteTarifaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProdutoPacoteTarifaResponse" /> class.
        /// Initializes a new instance of the <see cref="ProdutoPacoteTarifaResponse" />class.
        /// </summary>
        /// <param name="FlagDefault">{{{produto_pacote_tarifa_response_flag_default_descricao}}}.</param>
        /// <param name="Id">{{{produto_pacote_tarifa_response_id_descricao}}}.</param>
        /// <param name="IdPacoteTarifa">{{{produto_pacote_tarifa_response_id_pacote_tarifa_descricao}}}.</param>
        /// <param name="IdProduto">{{{produto_pacote_tarifa_response_id_produto_descricao}}}.</param>

        public ProdutoPacoteTarifaResponse(bool? FlagDefault = null, long? Id = null, long? IdPacoteTarifa = null, long? IdProduto = null)
        {
            this.FlagDefault = FlagDefault;
            this.Id = Id;
            this.IdPacoteTarifa = IdPacoteTarifa;
            this.IdProduto = IdProduto;
            
        }
        
    
        /// <summary>
        /// {{{produto_pacote_tarifa_response_flag_default_descricao}}}
        /// </summary>
        /// <value>{{{produto_pacote_tarifa_response_flag_default_descricao}}}</value>
        [DataMember(Name="flagDefault", EmitDefaultValue=false)]
        public bool? FlagDefault { get; set; }
    
        /// <summary>
        /// {{{produto_pacote_tarifa_response_id_descricao}}}
        /// </summary>
        /// <value>{{{produto_pacote_tarifa_response_id_descricao}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{produto_pacote_tarifa_response_id_pacote_tarifa_descricao}}}
        /// </summary>
        /// <value>{{{produto_pacote_tarifa_response_id_pacote_tarifa_descricao}}}</value>
        [DataMember(Name="idPacoteTarifa", EmitDefaultValue=false)]
        public long? IdPacoteTarifa { get; set; }
    
        /// <summary>
        /// {{{produto_pacote_tarifa_response_id_produto_descricao}}}
        /// </summary>
        /// <value>{{{produto_pacote_tarifa_response_id_produto_descricao}}}</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProdutoPacoteTarifaResponse {\n");
            sb.Append("  FlagDefault: ").Append(FlagDefault).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdPacoteTarifa: ").Append(IdPacoteTarifa).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            
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
            return this.Equals(obj as ProdutoPacoteTarifaResponse);
        }

        /// <summary>
        /// Returns true if ProdutoPacoteTarifaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ProdutoPacoteTarifaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProdutoPacoteTarifaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FlagDefault == other.FlagDefault ||
                    this.FlagDefault != null &&
                    this.FlagDefault.Equals(other.FlagDefault)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdPacoteTarifa == other.IdPacoteTarifa ||
                    this.IdPacoteTarifa != null &&
                    this.IdPacoteTarifa.Equals(other.IdPacoteTarifa)
                ) && 
                (
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
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
                
                if (this.FlagDefault != null)
                    hash = hash * 59 + this.FlagDefault.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdPacoteTarifa != null)
                    hash = hash * 59 + this.IdPacoteTarifa.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                return hash;
            }
        }

    }
}
