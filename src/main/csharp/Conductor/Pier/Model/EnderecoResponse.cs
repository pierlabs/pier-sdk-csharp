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
    /// Object Address
    /// </summary>
    [DataContract]
    public partial class EnderecoResponse :  IEquatable<EnderecoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EnderecoResponse" /> class.
        /// Initializes a new instance of the <see cref="EnderecoResponse" />class.
        /// </summary>
        /// <param name="TempoResidenciaAnos">Displays the number of years spent living in the residence.</param>
        /// <param name="TempoResidenciaMeses">Displays the number of months spent living in the residence.</param>
        /// <param name="Id">Identification Code of the address (id).</param>
        /// <param name="IdPessoa">Identification Code of the Person which the address belongs (id).</param>
        /// <param name="IdTipoEndereco">Identification Code of the address (id).</param>
        /// <param name="Cep">Show the Zipcode in format &#39;58800000&#39;.</param>
        /// <param name="Logradouro">Show the name of the Street.</param>
        /// <param name="Numero">Show the address number.</param>
        /// <param name="Complemento">Show the complementary descriptions referring to the address.</param>
        /// <param name="PontoReferencia">Show the description of the landmark.</param>
        /// <param name="Bairro">Show the name of the neighborhood.</param>
        /// <param name="Cidade">Show the name of the city.</param>
        /// <param name="Uf">Show the acronym of the Federal Unity.</param>
        /// <param name="Pais">Show the name of the country.</param>
        /// <param name="DataInclusao">Show the date tat was registered the address.</param>
        /// <param name="DataUltimaAtualizacao">Date that was made the last update in this address. When there isn&#39;t change, it will have the same information that the field dateInclusion.</param>
        /// <param name="FlagCorrespondencia">Displays the flag that informs if the address is the correspondence.</param>

        public EnderecoResponse(int? TempoResidenciaAnos = null, int? TempoResidenciaMeses = null, long? Id = null, long? IdPessoa = null, long? IdTipoEndereco = null, string Cep = null, string Logradouro = null, int? Numero = null, string Complemento = null, string PontoReferencia = null, string Bairro = null, string Cidade = null, string Uf = null, string Pais = null, string DataInclusao = null, string DataUltimaAtualizacao = null, bool? FlagCorrespondencia = null)
        {
            this.TempoResidenciaAnos = TempoResidenciaAnos;
            this.TempoResidenciaMeses = TempoResidenciaMeses;
            this.Id = Id;
            this.IdPessoa = IdPessoa;
            this.IdTipoEndereco = IdTipoEndereco;
            this.Cep = Cep;
            this.Logradouro = Logradouro;
            this.Numero = Numero;
            this.Complemento = Complemento;
            this.PontoReferencia = PontoReferencia;
            this.Bairro = Bairro;
            this.Cidade = Cidade;
            this.Uf = Uf;
            this.Pais = Pais;
            this.DataInclusao = DataInclusao;
            this.DataUltimaAtualizacao = DataUltimaAtualizacao;
            this.FlagCorrespondencia = FlagCorrespondencia;
            
        }
        
    
        /// <summary>
        /// Displays the number of years spent living in the residence
        /// </summary>
        /// <value>Displays the number of years spent living in the residence</value>
        [DataMember(Name="tempoResidenciaAnos", EmitDefaultValue=false)]
        public int? TempoResidenciaAnos { get; set; }
    
        /// <summary>
        /// Displays the number of months spent living in the residence
        /// </summary>
        /// <value>Displays the number of months spent living in the residence</value>
        [DataMember(Name="tempoResidenciaMeses", EmitDefaultValue=false)]
        public int? TempoResidenciaMeses { get; set; }
    
        /// <summary>
        /// Identification Code of the address (id)
        /// </summary>
        /// <value>Identification Code of the address (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Identification Code of the Person which the address belongs (id)
        /// </summary>
        /// <value>Identification Code of the Person which the address belongs (id)</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// Identification Code of the address (id)
        /// </summary>
        /// <value>Identification Code of the address (id)</value>
        [DataMember(Name="idTipoEndereco", EmitDefaultValue=false)]
        public long? IdTipoEndereco { get; set; }
    
        /// <summary>
        /// Show the Zipcode in format &#39;58800000&#39;
        /// </summary>
        /// <value>Show the Zipcode in format &#39;58800000&#39;</value>
        [DataMember(Name="cep", EmitDefaultValue=false)]
        public string Cep { get; set; }
    
        /// <summary>
        /// Show the name of the Street
        /// </summary>
        /// <value>Show the name of the Street</value>
        [DataMember(Name="logradouro", EmitDefaultValue=false)]
        public string Logradouro { get; set; }
    
        /// <summary>
        /// Show the address number
        /// </summary>
        /// <value>Show the address number</value>
        [DataMember(Name="numero", EmitDefaultValue=false)]
        public int? Numero { get; set; }
    
        /// <summary>
        /// Show the complementary descriptions referring to the address
        /// </summary>
        /// <value>Show the complementary descriptions referring to the address</value>
        [DataMember(Name="complemento", EmitDefaultValue=false)]
        public string Complemento { get; set; }
    
        /// <summary>
        /// Show the description of the landmark
        /// </summary>
        /// <value>Show the description of the landmark</value>
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
        /// Show the date tat was registered the address
        /// </summary>
        /// <value>Show the date tat was registered the address</value>
        [DataMember(Name="dataInclusao", EmitDefaultValue=false)]
        public string DataInclusao { get; set; }
    
        /// <summary>
        /// Date that was made the last update in this address. When there isn&#39;t change, it will have the same information that the field dateInclusion
        /// </summary>
        /// <value>Date that was made the last update in this address. When there isn&#39;t change, it will have the same information that the field dateInclusion</value>
        [DataMember(Name="dataUltimaAtualizacao", EmitDefaultValue=false)]
        public string DataUltimaAtualizacao { get; set; }
    
        /// <summary>
        /// Displays the flag that informs if the address is the correspondence
        /// </summary>
        /// <value>Displays the flag that informs if the address is the correspondence</value>
        [DataMember(Name="flagCorrespondencia", EmitDefaultValue=false)]
        public bool? FlagCorrespondencia { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnderecoResponse {\n");
            sb.Append("  TempoResidenciaAnos: ").Append(TempoResidenciaAnos).Append("\n");
            sb.Append("  TempoResidenciaMeses: ").Append(TempoResidenciaMeses).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
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
            sb.Append("  DataInclusao: ").Append(DataInclusao).Append("\n");
            sb.Append("  DataUltimaAtualizacao: ").Append(DataUltimaAtualizacao).Append("\n");
            sb.Append("  FlagCorrespondencia: ").Append(FlagCorrespondencia).Append("\n");
            
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
            return this.Equals(obj as EnderecoResponse);
        }

        /// <summary>
        /// Returns true if EnderecoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of EnderecoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnderecoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TempoResidenciaAnos == other.TempoResidenciaAnos ||
                    this.TempoResidenciaAnos != null &&
                    this.TempoResidenciaAnos.Equals(other.TempoResidenciaAnos)
                ) && 
                (
                    this.TempoResidenciaMeses == other.TempoResidenciaMeses ||
                    this.TempoResidenciaMeses != null &&
                    this.TempoResidenciaMeses.Equals(other.TempoResidenciaMeses)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
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
                    this.DataInclusao == other.DataInclusao ||
                    this.DataInclusao != null &&
                    this.DataInclusao.Equals(other.DataInclusao)
                ) && 
                (
                    this.DataUltimaAtualizacao == other.DataUltimaAtualizacao ||
                    this.DataUltimaAtualizacao != null &&
                    this.DataUltimaAtualizacao.Equals(other.DataUltimaAtualizacao)
                ) && 
                (
                    this.FlagCorrespondencia == other.FlagCorrespondencia ||
                    this.FlagCorrespondencia != null &&
                    this.FlagCorrespondencia.Equals(other.FlagCorrespondencia)
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
                
                if (this.TempoResidenciaAnos != null)
                    hash = hash * 59 + this.TempoResidenciaAnos.GetHashCode();
                
                if (this.TempoResidenciaMeses != null)
                    hash = hash * 59 + this.TempoResidenciaMeses.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
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
                
                if (this.DataInclusao != null)
                    hash = hash * 59 + this.DataInclusao.GetHashCode();
                
                if (this.DataUltimaAtualizacao != null)
                    hash = hash * 59 + this.DataUltimaAtualizacao.GetHashCode();
                
                if (this.FlagCorrespondencia != null)
                    hash = hash * 59 + this.FlagCorrespondencia.GetHashCode();
                
                return hash;
            }
        }

    }
}
