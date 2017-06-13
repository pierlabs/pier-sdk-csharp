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
    /// Fatura
    /// </summary>
    [DataContract]
    public partial class FaturaResponse :  IEquatable<FaturaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FaturaResponse" /> class.
        /// Initializes a new instance of the <see cref="FaturaResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo identificador do tipo de boleto..</param>
        /// <param name="Descricao">Descri\u00C3\u00A7\u00C3\u00A3o do tipo de boleto..</param>
        /// <param name="Banco">C\u00C3\u00B3digo identificador do banco..</param>
        /// <param name="FaixaNossoNumero">Faixa permitida para cria\u00C3\u00A7\u00C3\u00A3o do nosso n\u00C3\u00BAmero..</param>
        /// <param name="MinNossoNumero">N\u00C3\u00BAmero minimo para o nosso n\u00C3\u00BAmero..</param>
        /// <param name="MaxNossoNumero">N\u00C3\u00BAmero m\u00C3\u00A1ximo para o nosso n\u00C3\u00BAmero..</param>
        /// <param name="TamNossoNumero">Tamanho do nosso n\u00C3\u00BAmero..</param>
        /// <param name="UltimoNossoNumero">\u00C3\u009Altimo nosso n\u00C3\u00BAmero utilizado..</param>

        public FaturaResponse(long? Id = null, string Descricao = null, long? Banco = null, int? FaixaNossoNumero = null, double? MinNossoNumero = null, double? MaxNossoNumero = null, int? TamNossoNumero = null, double? UltimoNossoNumero = null)
        {
            this.Id = Id;
            this.Descricao = Descricao;
            this.Banco = Banco;
            this.FaixaNossoNumero = FaixaNossoNumero;
            this.MinNossoNumero = MinNossoNumero;
            this.MaxNossoNumero = MaxNossoNumero;
            this.TamNossoNumero = TamNossoNumero;
            this.UltimoNossoNumero = UltimoNossoNumero;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador do tipo de boleto.
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador do tipo de boleto.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Descri\u00C3\u00A7\u00C3\u00A3o do tipo de boleto.
        /// </summary>
        /// <value>Descri\u00C3\u00A7\u00C3\u00A3o do tipo de boleto.</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador do banco.
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador do banco.</value>
        [DataMember(Name="banco", EmitDefaultValue=false)]
        public long? Banco { get; set; }
    
        /// <summary>
        /// Faixa permitida para cria\u00C3\u00A7\u00C3\u00A3o do nosso n\u00C3\u00BAmero.
        /// </summary>
        /// <value>Faixa permitida para cria\u00C3\u00A7\u00C3\u00A3o do nosso n\u00C3\u00BAmero.</value>
        [DataMember(Name="faixaNossoNumero", EmitDefaultValue=false)]
        public int? FaixaNossoNumero { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero minimo para o nosso n\u00C3\u00BAmero.
        /// </summary>
        /// <value>N\u00C3\u00BAmero minimo para o nosso n\u00C3\u00BAmero.</value>
        [DataMember(Name="minNossoNumero", EmitDefaultValue=false)]
        public double? MinNossoNumero { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero m\u00C3\u00A1ximo para o nosso n\u00C3\u00BAmero.
        /// </summary>
        /// <value>N\u00C3\u00BAmero m\u00C3\u00A1ximo para o nosso n\u00C3\u00BAmero.</value>
        [DataMember(Name="maxNossoNumero", EmitDefaultValue=false)]
        public double? MaxNossoNumero { get; set; }
    
        /// <summary>
        /// Tamanho do nosso n\u00C3\u00BAmero.
        /// </summary>
        /// <value>Tamanho do nosso n\u00C3\u00BAmero.</value>
        [DataMember(Name="tamNossoNumero", EmitDefaultValue=false)]
        public int? TamNossoNumero { get; set; }
    
        /// <summary>
        /// \u00C3\u009Altimo nosso n\u00C3\u00BAmero utilizado.
        /// </summary>
        /// <value>\u00C3\u009Altimo nosso n\u00C3\u00BAmero utilizado.</value>
        [DataMember(Name="ultimoNossoNumero", EmitDefaultValue=false)]
        public double? UltimoNossoNumero { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FaturaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  Banco: ").Append(Banco).Append("\n");
            sb.Append("  FaixaNossoNumero: ").Append(FaixaNossoNumero).Append("\n");
            sb.Append("  MinNossoNumero: ").Append(MinNossoNumero).Append("\n");
            sb.Append("  MaxNossoNumero: ").Append(MaxNossoNumero).Append("\n");
            sb.Append("  TamNossoNumero: ").Append(TamNossoNumero).Append("\n");
            sb.Append("  UltimoNossoNumero: ").Append(UltimoNossoNumero).Append("\n");
            
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
            return this.Equals(obj as FaturaResponse);
        }

        /// <summary>
        /// Returns true if FaturaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of FaturaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FaturaResponse other)
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
                    this.Banco == other.Banco ||
                    this.Banco != null &&
                    this.Banco.Equals(other.Banco)
                ) && 
                (
                    this.FaixaNossoNumero == other.FaixaNossoNumero ||
                    this.FaixaNossoNumero != null &&
                    this.FaixaNossoNumero.Equals(other.FaixaNossoNumero)
                ) && 
                (
                    this.MinNossoNumero == other.MinNossoNumero ||
                    this.MinNossoNumero != null &&
                    this.MinNossoNumero.Equals(other.MinNossoNumero)
                ) && 
                (
                    this.MaxNossoNumero == other.MaxNossoNumero ||
                    this.MaxNossoNumero != null &&
                    this.MaxNossoNumero.Equals(other.MaxNossoNumero)
                ) && 
                (
                    this.TamNossoNumero == other.TamNossoNumero ||
                    this.TamNossoNumero != null &&
                    this.TamNossoNumero.Equals(other.TamNossoNumero)
                ) && 
                (
                    this.UltimoNossoNumero == other.UltimoNossoNumero ||
                    this.UltimoNossoNumero != null &&
                    this.UltimoNossoNumero.Equals(other.UltimoNossoNumero)
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
                
                if (this.Banco != null)
                    hash = hash * 59 + this.Banco.GetHashCode();
                
                if (this.FaixaNossoNumero != null)
                    hash = hash * 59 + this.FaixaNossoNumero.GetHashCode();
                
                if (this.MinNossoNumero != null)
                    hash = hash * 59 + this.MinNossoNumero.GetHashCode();
                
                if (this.MaxNossoNumero != null)
                    hash = hash * 59 + this.MaxNossoNumero.GetHashCode();
                
                if (this.TamNossoNumero != null)
                    hash = hash * 59 + this.TamNossoNumero.GetHashCode();
                
                if (this.UltimoNossoNumero != null)
                    hash = hash * 59 + this.UltimoNossoNumero.GetHashCode();
                
                return hash;
            }
        }

    }
}
