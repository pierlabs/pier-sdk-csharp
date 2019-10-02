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
    /// Objeto de resposta do CVV din\u00E2mico
    /// </summary>
    [DataContract]
    public partial class CvvDinamicoResponse :  IEquatable<CvvDinamicoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CvvDinamicoResponse" /> class.
        /// Initializes a new instance of the <see cref="CvvDinamicoResponse" />class.
        /// </summary>
        /// <param name="Id">Identificador da entidade.</param>
        /// <param name="IdCartao">Identificador do cart\u00E3o.</param>
        /// <param name="DataExpiracao">Data de expira\u00E7\u00E3o do CVV din\u00E2mico.</param>
        /// <param name="DataGeracao">Data de gera\u00E7\u00E3o do CVV din\u00E2mico.</param>
        /// <param name="Cvv2">CVV2.</param>

        public CvvDinamicoResponse(long? Id = null, long? IdCartao = null, string DataExpiracao = null, string DataGeracao = null, string Cvv2 = null)
        {
            this.Id = Id;
            this.IdCartao = IdCartao;
            this.DataExpiracao = DataExpiracao;
            this.DataGeracao = DataGeracao;
            this.Cvv2 = Cvv2;
            
        }
        
    
        /// <summary>
        /// Identificador da entidade
        /// </summary>
        /// <value>Identificador da entidade</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Identificador do cart\u00E3o
        /// </summary>
        /// <value>Identificador do cart\u00E3o</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// Data de expira\u00E7\u00E3o do CVV din\u00E2mico
        /// </summary>
        /// <value>Data de expira\u00E7\u00E3o do CVV din\u00E2mico</value>
        [DataMember(Name="dataExpiracao", EmitDefaultValue=false)]
        public string DataExpiracao { get; set; }
    
        /// <summary>
        /// Data de gera\u00E7\u00E3o do CVV din\u00E2mico
        /// </summary>
        /// <value>Data de gera\u00E7\u00E3o do CVV din\u00E2mico</value>
        [DataMember(Name="dataGeracao", EmitDefaultValue=false)]
        public string DataGeracao { get; set; }
    
        /// <summary>
        /// CVV2
        /// </summary>
        /// <value>CVV2</value>
        [DataMember(Name="cvv2", EmitDefaultValue=false)]
        public string Cvv2 { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CvvDinamicoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  DataExpiracao: ").Append(DataExpiracao).Append("\n");
            sb.Append("  DataGeracao: ").Append(DataGeracao).Append("\n");
            sb.Append("  Cvv2: ").Append(Cvv2).Append("\n");
            
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
            return this.Equals(obj as CvvDinamicoResponse);
        }

        /// <summary>
        /// Returns true if CvvDinamicoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CvvDinamicoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CvvDinamicoResponse other)
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
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.DataExpiracao == other.DataExpiracao ||
                    this.DataExpiracao != null &&
                    this.DataExpiracao.Equals(other.DataExpiracao)
                ) && 
                (
                    this.DataGeracao == other.DataGeracao ||
                    this.DataGeracao != null &&
                    this.DataGeracao.Equals(other.DataGeracao)
                ) && 
                (
                    this.Cvv2 == other.Cvv2 ||
                    this.Cvv2 != null &&
                    this.Cvv2.Equals(other.Cvv2)
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
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.DataExpiracao != null)
                    hash = hash * 59 + this.DataExpiracao.GetHashCode();
                
                if (this.DataGeracao != null)
                    hash = hash * 59 + this.DataGeracao.GetHashCode();
                
                if (this.Cvv2 != null)
                    hash = hash * 59 + this.Cvv2.GetHashCode();
                
                return hash;
            }
        }

    }
}
