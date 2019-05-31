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
    /// Objeto de persist\u00EAncia do endere\u00E7o
    /// </summary>
    [DataContract]
    public partial class EnderecoAprovadoPersist :  IEquatable<EnderecoAprovadoPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EnderecoAprovadoPersist" /> class.
        /// Initializes a new instance of the <see cref="EnderecoAprovadoPersist" />class.
        /// </summary>
        /// <param name="IdTipoEndereco">C\u00F3digo de identifica\u00E7\u00E3o do tipo de endere\u00E7o (required).</param>
        /// <param name="Cep">C\u00F3digo de Endere\u00E7amento Postal (CEP).</param>
        /// <param name="Logradouro">Nome do logradouro.</param>
        /// <param name="Numero">N\u00FAmero do endere\u00E7o.</param>
        /// <param name="Complemento">Descri\u00E7\u00F5es complementares referentes ao endere\u00E7o.</param>
        /// <param name="PontoReferencia">Descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o.</param>
        /// <param name="Bairro">Nome do bairro.</param>
        /// <param name="Cidade">Nome da cidade (required).</param>
        /// <param name="Uf">Sigla da Unidade Federativa (required).</param>
        /// <param name="Pais">Nome do Pa\u00EDs.</param>
        /// <param name="EnderecoCorrespondencia">Indica se o endere\u00E7o informado \u00E9 o de correspond\u00EAncia (required).</param>
        /// <param name="TempoResidenciaAnos">Tempo de resid\u00EAncia em anos.</param>
        /// <param name="TempoResidenciaMeses">Tempo de resid\u00EAncia em meses.</param>

        public EnderecoAprovadoPersist(long? IdTipoEndereco = null, string Cep = null, string Logradouro = null, int? Numero = null, string Complemento = null, string PontoReferencia = null, string Bairro = null, string Cidade = null, string Uf = null, string Pais = null, bool? EnderecoCorrespondencia = null, int? TempoResidenciaAnos = null, int? TempoResidenciaMeses = null)
        {
            // to ensure "IdTipoEndereco" is required (not null)
            if (IdTipoEndereco == null)
            {
                throw new InvalidDataException("IdTipoEndereco is a required property for EnderecoAprovadoPersist and cannot be null");
            }
            else
            {
                this.IdTipoEndereco = IdTipoEndereco;
            }
            // to ensure "Cidade" is required (not null)
            if (Cidade == null)
            {
                throw new InvalidDataException("Cidade is a required property for EnderecoAprovadoPersist and cannot be null");
            }
            else
            {
                this.Cidade = Cidade;
            }
            // to ensure "Uf" is required (not null)
            if (Uf == null)
            {
                throw new InvalidDataException("Uf is a required property for EnderecoAprovadoPersist and cannot be null");
            }
            else
            {
                this.Uf = Uf;
            }
            // to ensure "EnderecoCorrespondencia" is required (not null)
            if (EnderecoCorrespondencia == null)
            {
                throw new InvalidDataException("EnderecoCorrespondencia is a required property for EnderecoAprovadoPersist and cannot be null");
            }
            else
            {
                this.EnderecoCorrespondencia = EnderecoCorrespondencia;
            }
            this.Cep = Cep;
            this.Logradouro = Logradouro;
            this.Numero = Numero;
            this.Complemento = Complemento;
            this.PontoReferencia = PontoReferencia;
            this.Bairro = Bairro;
            this.Pais = Pais;
            this.TempoResidenciaAnos = TempoResidenciaAnos;
            this.TempoResidenciaMeses = TempoResidenciaMeses;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do tipo de endere\u00E7o
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do tipo de endere\u00E7o</value>
        [DataMember(Name="idTipoEndereco", EmitDefaultValue=false)]
        public long? IdTipoEndereco { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Endere\u00E7amento Postal (CEP)
        /// </summary>
        /// <value>C\u00F3digo de Endere\u00E7amento Postal (CEP)</value>
        [DataMember(Name="cep", EmitDefaultValue=false)]
        public string Cep { get; set; }
    
        /// <summary>
        /// Nome do logradouro
        /// </summary>
        /// <value>Nome do logradouro</value>
        [DataMember(Name="logradouro", EmitDefaultValue=false)]
        public string Logradouro { get; set; }
    
        /// <summary>
        /// N\u00FAmero do endere\u00E7o
        /// </summary>
        /// <value>N\u00FAmero do endere\u00E7o</value>
        [DataMember(Name="numero", EmitDefaultValue=false)]
        public int? Numero { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00F5es complementares referentes ao endere\u00E7o
        /// </summary>
        /// <value>Descri\u00E7\u00F5es complementares referentes ao endere\u00E7o</value>
        [DataMember(Name="complemento", EmitDefaultValue=false)]
        public string Complemento { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o
        /// </summary>
        /// <value>Descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o</value>
        [DataMember(Name="pontoReferencia", EmitDefaultValue=false)]
        public string PontoReferencia { get; set; }
    
        /// <summary>
        /// Nome do bairro
        /// </summary>
        /// <value>Nome do bairro</value>
        [DataMember(Name="bairro", EmitDefaultValue=false)]
        public string Bairro { get; set; }
    
        /// <summary>
        /// Nome da cidade
        /// </summary>
        /// <value>Nome da cidade</value>
        [DataMember(Name="cidade", EmitDefaultValue=false)]
        public string Cidade { get; set; }
    
        /// <summary>
        /// Sigla da Unidade Federativa
        /// </summary>
        /// <value>Sigla da Unidade Federativa</value>
        [DataMember(Name="uf", EmitDefaultValue=false)]
        public string Uf { get; set; }
    
        /// <summary>
        /// Nome do Pa\u00EDs
        /// </summary>
        /// <value>Nome do Pa\u00EDs</value>
        [DataMember(Name="pais", EmitDefaultValue=false)]
        public string Pais { get; set; }
    
        /// <summary>
        /// Indica se o endere\u00E7o informado \u00E9 o de correspond\u00EAncia
        /// </summary>
        /// <value>Indica se o endere\u00E7o informado \u00E9 o de correspond\u00EAncia</value>
        [DataMember(Name="enderecoCorrespondencia", EmitDefaultValue=false)]
        public bool? EnderecoCorrespondencia { get; set; }
    
        /// <summary>
        /// Tempo de resid\u00EAncia em anos
        /// </summary>
        /// <value>Tempo de resid\u00EAncia em anos</value>
        [DataMember(Name="tempoResidenciaAnos", EmitDefaultValue=false)]
        public int? TempoResidenciaAnos { get; set; }
    
        /// <summary>
        /// Tempo de resid\u00EAncia em meses
        /// </summary>
        /// <value>Tempo de resid\u00EAncia em meses</value>
        [DataMember(Name="tempoResidenciaMeses", EmitDefaultValue=false)]
        public int? TempoResidenciaMeses { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnderecoAprovadoPersist {\n");
            sb.Append("  IdTipoEndereco: ").Append(IdTipoEndereco).Append("\n");
            sb.Append("  Cep: ").Append(Cep).Append("\n");
            sb.Append("  Logradouro: ").Append(Logradouro).Append("\n");
            sb.Append("  Numero: ").Append(Numero).Append("\n");
            sb.Append("  Complemento: ").Append(Complemento).Append("\n");
            sb.Append("  PontoReferencia: ").Append(PontoReferencia).Append("\n");
            sb.Append("  Bairro: ").Append(Bairro).Append("\n");
            sb.Append("  Cidade: ").Append(Cidade).Append("\n");
            sb.Append("  Uf: ").Append(Uf).Append("\n");
            sb.Append("  Pais: ").Append(Pais).Append("\n");
            sb.Append("  EnderecoCorrespondencia: ").Append(EnderecoCorrespondencia).Append("\n");
            sb.Append("  TempoResidenciaAnos: ").Append(TempoResidenciaAnos).Append("\n");
            sb.Append("  TempoResidenciaMeses: ").Append(TempoResidenciaMeses).Append("\n");
            
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
            return this.Equals(obj as EnderecoAprovadoPersist);
        }

        /// <summary>
        /// Returns true if EnderecoAprovadoPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of EnderecoAprovadoPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnderecoAprovadoPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdTipoEndereco == other.IdTipoEndereco ||
                    this.IdTipoEndereco != null &&
                    this.IdTipoEndereco.Equals(other.IdTipoEndereco)
                ) && 
                (
                    this.Cep == other.Cep ||
                    this.Cep != null &&
                    this.Cep.Equals(other.Cep)
                ) && 
                (
                    this.Logradouro == other.Logradouro ||
                    this.Logradouro != null &&
                    this.Logradouro.Equals(other.Logradouro)
                ) && 
                (
                    this.Numero == other.Numero ||
                    this.Numero != null &&
                    this.Numero.Equals(other.Numero)
                ) && 
                (
                    this.Complemento == other.Complemento ||
                    this.Complemento != null &&
                    this.Complemento.Equals(other.Complemento)
                ) && 
                (
                    this.PontoReferencia == other.PontoReferencia ||
                    this.PontoReferencia != null &&
                    this.PontoReferencia.Equals(other.PontoReferencia)
                ) && 
                (
                    this.Bairro == other.Bairro ||
                    this.Bairro != null &&
                    this.Bairro.Equals(other.Bairro)
                ) && 
                (
                    this.Cidade == other.Cidade ||
                    this.Cidade != null &&
                    this.Cidade.Equals(other.Cidade)
                ) && 
                (
                    this.Uf == other.Uf ||
                    this.Uf != null &&
                    this.Uf.Equals(other.Uf)
                ) && 
                (
                    this.Pais == other.Pais ||
                    this.Pais != null &&
                    this.Pais.Equals(other.Pais)
                ) && 
                (
                    this.EnderecoCorrespondencia == other.EnderecoCorrespondencia ||
                    this.EnderecoCorrespondencia != null &&
                    this.EnderecoCorrespondencia.Equals(other.EnderecoCorrespondencia)
                ) && 
                (
                    this.TempoResidenciaAnos == other.TempoResidenciaAnos ||
                    this.TempoResidenciaAnos != null &&
                    this.TempoResidenciaAnos.Equals(other.TempoResidenciaAnos)
                ) && 
                (
                    this.TempoResidenciaMeses == other.TempoResidenciaMeses ||
                    this.TempoResidenciaMeses != null &&
                    this.TempoResidenciaMeses.Equals(other.TempoResidenciaMeses)
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
                
                if (this.IdTipoEndereco != null)
                    hash = hash * 59 + this.IdTipoEndereco.GetHashCode();
                
                if (this.Cep != null)
                    hash = hash * 59 + this.Cep.GetHashCode();
                
                if (this.Logradouro != null)
                    hash = hash * 59 + this.Logradouro.GetHashCode();
                
                if (this.Numero != null)
                    hash = hash * 59 + this.Numero.GetHashCode();
                
                if (this.Complemento != null)
                    hash = hash * 59 + this.Complemento.GetHashCode();
                
                if (this.PontoReferencia != null)
                    hash = hash * 59 + this.PontoReferencia.GetHashCode();
                
                if (this.Bairro != null)
                    hash = hash * 59 + this.Bairro.GetHashCode();
                
                if (this.Cidade != null)
                    hash = hash * 59 + this.Cidade.GetHashCode();
                
                if (this.Uf != null)
                    hash = hash * 59 + this.Uf.GetHashCode();
                
                if (this.Pais != null)
                    hash = hash * 59 + this.Pais.GetHashCode();
                
                if (this.EnderecoCorrespondencia != null)
                    hash = hash * 59 + this.EnderecoCorrespondencia.GetHashCode();
                
                if (this.TempoResidenciaAnos != null)
                    hash = hash * 59 + this.TempoResidenciaAnos.GetHashCode();
                
                if (this.TempoResidenciaMeses != null)
                    hash = hash * 59 + this.TempoResidenciaMeses.GetHashCode();
                
                return hash;
            }
        }

    }
}
