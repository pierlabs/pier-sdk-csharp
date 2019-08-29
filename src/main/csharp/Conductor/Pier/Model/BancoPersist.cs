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
    /// Objeto banco a ser persistido
    /// </summary>
    [DataContract]
    public partial class BancoPersist :  IEquatable<BancoPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BancoPersist" /> class.
        /// Initializes a new instance of the <see cref="BancoPersist" />class.
        /// </summary>
        /// <param name="Nome">Nome do banco.</param>
        /// <param name="Descricao">Descri\u00E7\u00E3o do banco.</param>
        /// <param name="DigitoBanco">D\u00EDgito identificador do banco.</param>
        /// <param name="CodigoBanco">Codigo identificador do banco.</param>
        /// <param name="Ispb">Numero ispb do banco.</param>
        /// <param name="Cnpj">N\u00FAmero do CNPJ do banco.</param>
        /// <param name="FlagAtivoBacen">Indica se o banco est\u00E1 ativo no BACEN.</param>

        public BancoPersist(string Nome = null, string Descricao = null, string DigitoBanco = null, long? CodigoBanco = null, string Ispb = null, string Cnpj = null, bool? FlagAtivoBacen = null)
        {
            this.Nome = Nome;
            this.Descricao = Descricao;
            this.DigitoBanco = DigitoBanco;
            this.CodigoBanco = CodigoBanco;
            this.Ispb = Ispb;
            this.Cnpj = Cnpj;
            this.FlagAtivoBacen = FlagAtivoBacen;
            
        }
        
    
        /// <summary>
        /// Nome do banco
        /// </summary>
        /// <value>Nome do banco</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do banco
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do banco</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// D\u00EDgito identificador do banco
        /// </summary>
        /// <value>D\u00EDgito identificador do banco</value>
        [DataMember(Name="digitoBanco", EmitDefaultValue=false)]
        public string DigitoBanco { get; set; }
    
        /// <summary>
        /// Codigo identificador do banco
        /// </summary>
        /// <value>Codigo identificador do banco</value>
        [DataMember(Name="codigoBanco", EmitDefaultValue=false)]
        public long? CodigoBanco { get; set; }
    
        /// <summary>
        /// Numero ispb do banco
        /// </summary>
        /// <value>Numero ispb do banco</value>
        [DataMember(Name="ispb", EmitDefaultValue=false)]
        public string Ispb { get; set; }
    
        /// <summary>
        /// N\u00FAmero do CNPJ do banco
        /// </summary>
        /// <value>N\u00FAmero do CNPJ do banco</value>
        [DataMember(Name="cnpj", EmitDefaultValue=false)]
        public string Cnpj { get; set; }
    
        /// <summary>
        /// Indica se o banco est\u00E1 ativo no BACEN
        /// </summary>
        /// <value>Indica se o banco est\u00E1 ativo no BACEN</value>
        [DataMember(Name="flagAtivoBacen", EmitDefaultValue=false)]
        public bool? FlagAtivoBacen { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BancoPersist {\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  DigitoBanco: ").Append(DigitoBanco).Append("\n");
            sb.Append("  CodigoBanco: ").Append(CodigoBanco).Append("\n");
            sb.Append("  Ispb: ").Append(Ispb).Append("\n");
            sb.Append("  Cnpj: ").Append(Cnpj).Append("\n");
            sb.Append("  FlagAtivoBacen: ").Append(FlagAtivoBacen).Append("\n");
            
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
            return this.Equals(obj as BancoPersist);
        }

        /// <summary>
        /// Returns true if BancoPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of BancoPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BancoPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.DigitoBanco == other.DigitoBanco ||
                    this.DigitoBanco != null &&
                    this.DigitoBanco.Equals(other.DigitoBanco)
                ) && 
                (
                    this.CodigoBanco == other.CodigoBanco ||
                    this.CodigoBanco != null &&
                    this.CodigoBanco.Equals(other.CodigoBanco)
                ) && 
                (
                    this.Ispb == other.Ispb ||
                    this.Ispb != null &&
                    this.Ispb.Equals(other.Ispb)
                ) && 
                (
                    this.Cnpj == other.Cnpj ||
                    this.Cnpj != null &&
                    this.Cnpj.Equals(other.Cnpj)
                ) && 
                (
                    this.FlagAtivoBacen == other.FlagAtivoBacen ||
                    this.FlagAtivoBacen != null &&
                    this.FlagAtivoBacen.Equals(other.FlagAtivoBacen)
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
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.DigitoBanco != null)
                    hash = hash * 59 + this.DigitoBanco.GetHashCode();
                
                if (this.CodigoBanco != null)
                    hash = hash * 59 + this.CodigoBanco.GetHashCode();
                
                if (this.Ispb != null)
                    hash = hash * 59 + this.Ispb.GetHashCode();
                
                if (this.Cnpj != null)
                    hash = hash * 59 + this.Cnpj.GetHashCode();
                
                if (this.FlagAtivoBacen != null)
                    hash = hash * 59 + this.FlagAtivoBacen.GetHashCode();
                
                return hash;
            }
        }

    }
}
