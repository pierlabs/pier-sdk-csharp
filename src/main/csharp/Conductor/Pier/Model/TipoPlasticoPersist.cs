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
    /// 
    /// </summary>
    [DataContract]
    public partial class TipoPlasticoPersist :  IEquatable<TipoPlasticoPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoPlasticoPersist" /> class.
        /// Initializes a new instance of the <see cref="TipoPlasticoPersist" />class.
        /// </summary>
        /// <param name="Bandeirado">Bandeirado.</param>
        /// <param name="Fabrica">Fabrica.</param>
        /// <param name="IdEntidade">IdEntidade.</param>
        /// <param name="Nome">Nome.</param>
        /// <param name="NomeArquivo">NomeArquivo.</param>
        /// <param name="TamanhoLinhas">TamanhoLinhas.</param>
        /// <param name="ValorEmissao">ValorEmissao.</param>

        public TipoPlasticoPersist(bool? Bandeirado = null, string Fabrica = null, long? IdEntidade = null, string Nome = null, string NomeArquivo = null, string TamanhoLinhas = null, double? ValorEmissao = null)
        {
            this.Bandeirado = Bandeirado;
            this.Fabrica = Fabrica;
            this.IdEntidade = IdEntidade;
            this.Nome = Nome;
            this.NomeArquivo = NomeArquivo;
            this.TamanhoLinhas = TamanhoLinhas;
            this.ValorEmissao = ValorEmissao;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Bandeirado
        /// </summary>
        [DataMember(Name="bandeirado", EmitDefaultValue=false)]
        public bool? Bandeirado { get; set; }
    
        /// <summary>
        /// Gets or Sets Fabrica
        /// </summary>
        [DataMember(Name="fabrica", EmitDefaultValue=false)]
        public string Fabrica { get; set; }
    
        /// <summary>
        /// Gets or Sets IdEntidade
        /// </summary>
        [DataMember(Name="idEntidade", EmitDefaultValue=false)]
        public long? IdEntidade { get; set; }
    
        /// <summary>
        /// Gets or Sets Nome
        /// </summary>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Gets or Sets NomeArquivo
        /// </summary>
        [DataMember(Name="nomeArquivo", EmitDefaultValue=false)]
        public string NomeArquivo { get; set; }
    
        /// <summary>
        /// Gets or Sets TamanhoLinhas
        /// </summary>
        [DataMember(Name="tamanhoLinhas", EmitDefaultValue=false)]
        public string TamanhoLinhas { get; set; }
    
        /// <summary>
        /// Gets or Sets ValorEmissao
        /// </summary>
        [DataMember(Name="valorEmissao", EmitDefaultValue=false)]
        public double? ValorEmissao { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoPlasticoPersist {\n");
            sb.Append("  Bandeirado: ").Append(Bandeirado).Append("\n");
            sb.Append("  Fabrica: ").Append(Fabrica).Append("\n");
            sb.Append("  IdEntidade: ").Append(IdEntidade).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  NomeArquivo: ").Append(NomeArquivo).Append("\n");
            sb.Append("  TamanhoLinhas: ").Append(TamanhoLinhas).Append("\n");
            sb.Append("  ValorEmissao: ").Append(ValorEmissao).Append("\n");
            
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
            return this.Equals(obj as TipoPlasticoPersist);
        }

        /// <summary>
        /// Returns true if TipoPlasticoPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoPlasticoPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoPlasticoPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Bandeirado == other.Bandeirado ||
                    this.Bandeirado != null &&
                    this.Bandeirado.Equals(other.Bandeirado)
                ) && 
                (
                    this.Fabrica == other.Fabrica ||
                    this.Fabrica != null &&
                    this.Fabrica.Equals(other.Fabrica)
                ) && 
                (
                    this.IdEntidade == other.IdEntidade ||
                    this.IdEntidade != null &&
                    this.IdEntidade.Equals(other.IdEntidade)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.NomeArquivo == other.NomeArquivo ||
                    this.NomeArquivo != null &&
                    this.NomeArquivo.Equals(other.NomeArquivo)
                ) && 
                (
                    this.TamanhoLinhas == other.TamanhoLinhas ||
                    this.TamanhoLinhas != null &&
                    this.TamanhoLinhas.Equals(other.TamanhoLinhas)
                ) && 
                (
                    this.ValorEmissao == other.ValorEmissao ||
                    this.ValorEmissao != null &&
                    this.ValorEmissao.Equals(other.ValorEmissao)
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
                
                if (this.Bandeirado != null)
                    hash = hash * 59 + this.Bandeirado.GetHashCode();
                
                if (this.Fabrica != null)
                    hash = hash * 59 + this.Fabrica.GetHashCode();
                
                if (this.IdEntidade != null)
                    hash = hash * 59 + this.IdEntidade.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.NomeArquivo != null)
                    hash = hash * 59 + this.NomeArquivo.GetHashCode();
                
                if (this.TamanhoLinhas != null)
                    hash = hash * 59 + this.TamanhoLinhas.GetHashCode();
                
                if (this.ValorEmissao != null)
                    hash = hash * 59 + this.ValorEmissao.GetHashCode();
                
                return hash;
            }
        }

    }
}
