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
    /// Representa\u00E7\u00E3o do recurso Par\u00E2metro Emissor
    /// </summary>
    [DataContract]
    public partial class ParametroEmissorResponse :  IEquatable<ParametroEmissorResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ParametroEmissorResponse" /> class.
        /// Initializes a new instance of the <see cref="ParametroEmissorResponse" />class.
        /// </summary>
        /// <param name="Codigo">C\u00F3digo do par\u00E2metro.</param>
        /// <param name="DataValidade">Data da validade do par\u00E2metro.</param>
        /// <param name="Descricao">Descri\u00E7\u00E3o do par\u00E2metro.</param>
        /// <param name="Tipo">Tipo do par\u00E2metro.</param>
        /// <param name="ValorParametro">Valor do par\u00E2metro.</param>

        public ParametroEmissorResponse(string Codigo = null, string DataValidade = null, string Descricao = null, string Tipo = null, string ValorParametro = null)
        {
            this.Codigo = Codigo;
            this.DataValidade = DataValidade;
            this.Descricao = Descricao;
            this.Tipo = Tipo;
            this.ValorParametro = ValorParametro;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo do par\u00E2metro
        /// </summary>
        /// <value>C\u00F3digo do par\u00E2metro</value>
        [DataMember(Name="codigo", EmitDefaultValue=false)]
        public string Codigo { get; set; }
    
        /// <summary>
        /// Data da validade do par\u00E2metro
        /// </summary>
        /// <value>Data da validade do par\u00E2metro</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do par\u00E2metro
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do par\u00E2metro</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Tipo do par\u00E2metro
        /// </summary>
        /// <value>Tipo do par\u00E2metro</value>
        [DataMember(Name="tipo", EmitDefaultValue=false)]
        public string Tipo { get; set; }
    
        /// <summary>
        /// Valor do par\u00E2metro
        /// </summary>
        /// <value>Valor do par\u00E2metro</value>
        [DataMember(Name="valorParametro", EmitDefaultValue=false)]
        public string ValorParametro { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParametroEmissorResponse {\n");
            sb.Append("  Codigo: ").Append(Codigo).Append("\n");
            sb.Append("  DataValidade: ").Append(DataValidade).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  Tipo: ").Append(Tipo).Append("\n");
            sb.Append("  ValorParametro: ").Append(ValorParametro).Append("\n");
            
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
            return this.Equals(obj as ParametroEmissorResponse);
        }

        /// <summary>
        /// Returns true if ParametroEmissorResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ParametroEmissorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParametroEmissorResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Codigo == other.Codigo ||
                    this.Codigo != null &&
                    this.Codigo.Equals(other.Codigo)
                ) && 
                (
                    this.DataValidade == other.DataValidade ||
                    this.DataValidade != null &&
                    this.DataValidade.Equals(other.DataValidade)
                ) && 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.Tipo == other.Tipo ||
                    this.Tipo != null &&
                    this.Tipo.Equals(other.Tipo)
                ) && 
                (
                    this.ValorParametro == other.ValorParametro ||
                    this.ValorParametro != null &&
                    this.ValorParametro.Equals(other.ValorParametro)
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
                
                if (this.Codigo != null)
                    hash = hash * 59 + this.Codigo.GetHashCode();
                
                if (this.DataValidade != null)
                    hash = hash * 59 + this.DataValidade.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.Tipo != null)
                    hash = hash * 59 + this.Tipo.GetHashCode();
                
                if (this.ValorParametro != null)
                    hash = hash * 59 + this.ValorParametro.GetHashCode();
                
                return hash;
            }
        }

    }
}
