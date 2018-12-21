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
    public partial class ObjectAddressApproved :  IEquatable<ObjectAddressApproved>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectAddressApproved" /> class.
        /// Initializes a new instance of the <see cref="ObjectAddressApproved" />class.
        /// </summary>
        /// <param name="IdTipoEndereco">Identification Code of the Address (id) (required).</param>
        /// <param name="Cep">CEP.</param>
        /// <param name="Logradouro">show the name of the street.</param>
        /// <param name="Numero">Show the address name.</param>
        /// <param name="Complemento">Show complementary descriptions referring to the address.</param>
        /// <param name="PontoReferencia">Show the description of the address landmark.</param>
        /// <param name="Bairro">Show the name of the neighborhood.</param>
        /// <param name="Cidade">Show the name of the city (required).</param>
        /// <param name="Uf">Show the acronym of the Federal Unity (required).</param>
        /// <param name="Pais">Show the name of the country.</param>
        /// <param name="EnderecoCorrespondencia">Indicate if the informed address is for the mail (required).</param>
        /// <param name="TempoResidenciaAnos">Displays the residence time in years.</param>
        /// <param name="TempoResidenciaMeses">Displays the residence time in months.</param>

        public ObjectAddressApproved(long? IdTipoEndereco = null, string Cep = null, string Logradouro = null, int? Numero = null, string Complemento = null, string PontoReferencia = null, string Bairro = null, string Cidade = null, string Uf = null, string Pais = null, bool? EnderecoCorrespondencia = null, int? TempoResidenciaAnos = null, int? TempoResidenciaMeses = null)
        {
            // to ensure "IdTipoEndereco" is required (not null)
            if (IdTipoEndereco == null)
            {
                throw new InvalidDataException("IdTipoEndereco is a required property for ObjectAddressApproved and cannot be null");
            }
            else
            {
                this.IdTipoEndereco = IdTipoEndereco;
            }
            // to ensure "Cidade" is required (not null)
            if (Cidade == null)
            {
                throw new InvalidDataException("Cidade is a required property for ObjectAddressApproved and cannot be null");
            }
            else
            {
                this.Cidade = Cidade;
            }
            // to ensure "Uf" is required (not null)
            if (Uf == null)
            {
                throw new InvalidDataException("Uf is a required property for ObjectAddressApproved and cannot be null");
            }
            else
            {
                this.Uf = Uf;
            }
            // to ensure "EnderecoCorrespondencia" is required (not null)
            if (EnderecoCorrespondencia == null)
            {
                throw new InvalidDataException("EnderecoCorrespondencia is a required property for ObjectAddressApproved and cannot be null");
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
        /// Identification Code of the Address (id)
        /// </summary>
        /// <value>Identification Code of the Address (id)</value>
        [DataMember(Name="idTipoEndereco", EmitDefaultValue=false)]
        public long? IdTipoEndereco { get; set; }
    
        /// <summary>
        /// CEP
        /// </summary>
        /// <value>CEP</value>
        [DataMember(Name="cep", EmitDefaultValue=false)]
        public string Cep { get; set; }
    
        /// <summary>
        /// show the name of the street
        /// </summary>
        /// <value>show the name of the street</value>
        [DataMember(Name="logradouro", EmitDefaultValue=false)]
        public string Logradouro { get; set; }
    
        /// <summary>
        /// Show the address name
        /// </summary>
        /// <value>Show the address name</value>
        [DataMember(Name="numero", EmitDefaultValue=false)]
        public int? Numero { get; set; }
    
        /// <summary>
        /// Show complementary descriptions referring to the address
        /// </summary>
        /// <value>Show complementary descriptions referring to the address</value>
        [DataMember(Name="complemento", EmitDefaultValue=false)]
        public string Complemento { get; set; }
    
        /// <summary>
        /// Show the description of the address landmark
        /// </summary>
        /// <value>Show the description of the address landmark</value>
        [DataMember(Name="pontoReferencia", EmitDefaultValue=false)]
        public string PontoReferencia { get; set; }
    
        /// <summary>
        /// Show the name of the neighborhood
        /// </summary>
        /// <value>Show the name of the neighborhood</value>
        [DataMember(Name="bairro", EmitDefaultValue=false)]
        public string Bairro { get; set; }
    
        /// <summary>
        /// Show the name of the city
        /// </summary>
        /// <value>Show the name of the city</value>
        [DataMember(Name="cidade", EmitDefaultValue=false)]
        public string Cidade { get; set; }
    
        /// <summary>
        /// Show the acronym of the Federal Unity
        /// </summary>
        /// <value>Show the acronym of the Federal Unity</value>
        [DataMember(Name="uf", EmitDefaultValue=false)]
        public string Uf { get; set; }
    
        /// <summary>
        /// Show the name of the country
        /// </summary>
        /// <value>Show the name of the country</value>
        [DataMember(Name="pais", EmitDefaultValue=false)]
        public string Pais { get; set; }
    
        /// <summary>
        /// Indicate if the informed address is for the mail
        /// </summary>
        /// <value>Indicate if the informed address is for the mail</value>
        [DataMember(Name="enderecoCorrespondencia", EmitDefaultValue=false)]
        public bool? EnderecoCorrespondencia { get; set; }
    
        /// <summary>
        /// Displays the residence time in years
        /// </summary>
        /// <value>Displays the residence time in years</value>
        [DataMember(Name="tempoResidenciaAnos", EmitDefaultValue=false)]
        public int? TempoResidenciaAnos { get; set; }
    
        /// <summary>
        /// Displays the residence time in months
        /// </summary>
        /// <value>Displays the residence time in months</value>
        [DataMember(Name="tempoResidenciaMeses", EmitDefaultValue=false)]
        public int? TempoResidenciaMeses { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjectAddressApproved {\n");
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
            return this.Equals(obj as ObjectAddressApproved);
        }

        /// <summary>
        /// Returns true if ObjectAddressApproved instances are equal
        /// </summary>
        /// <param name="other">Instance of ObjectAddressApproved to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectAddressApproved other)
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
