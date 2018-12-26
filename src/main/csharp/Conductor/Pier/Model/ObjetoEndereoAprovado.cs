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
    public partial class ObjetoEndereoAprovado :  IEquatable<ObjetoEndereoAprovado>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjetoEndereoAprovado" /> class.
        /// Initializes a new instance of the <see cref="ObjetoEndereoAprovado" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id).</param>
        /// <param name="IdTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id).</param>
        /// <param name="Cep">Retorna o CEP no formato &#39;58800000&#39;.</param>
        /// <param name="Logradouro">Apresenta o nome do Logradouro.</param>
        /// <param name="Numero">Apresenta o n\u00FAmero do endere\u00E7o.</param>
        /// <param name="Complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o.</param>
        /// <param name="PontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o.</param>
        /// <param name="Bairro">Apresenta nome do bairro.</param>
        /// <param name="Cidade">Apresenta nome da cidade.</param>
        /// <param name="Uf">Apresenta sigla da Unidade Federativa.</param>
        /// <param name="Pais">Apresenta nome do Pa\u00EDs.</param>
        /// <param name="EnderecoCorrespondencia">Indica se o endere\u00E7o informado \u00E9 o de correspond\u00EAncia.</param>
        /// <param name="TempoResidenciaAnos">Apresenta o tempo de resid\u00EAncia em anos.</param>
        /// <param name="TempoResidenciaMeses">Apresenta o tempo de resid\u00EAncia em meses.</param>

        public ObjetoEndereoAprovado(long? Id = null, long? IdTipoEndereco = null, string Cep = null, string Logradouro = null, int? Numero = null, string Complemento = null, string PontoReferencia = null, string Bairro = null, string Cidade = null, string Uf = null, string Pais = null, bool? EnderecoCorrespondencia = null, int? TempoResidenciaAnos = null, int? TempoResidenciaMeses = null)
        {
            this.Id = Id;
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
            this.EnderecoCorrespondencia = EnderecoCorrespondencia;
            this.TempoResidenciaAnos = TempoResidenciaAnos;
            this.TempoResidenciaMeses = TempoResidenciaMeses;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id)
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id)</value>
        [DataMember(Name="idTipoEndereco", EmitDefaultValue=false)]
        public long? IdTipoEndereco { get; set; }
    
        /// <summary>
        /// Retorna o CEP no formato &#39;58800000&#39;
        /// </summary>
        /// <value>Retorna o CEP no formato &#39;58800000&#39;</value>
        [DataMember(Name="cep", EmitDefaultValue=false)]
        public string Cep { get; set; }
    
        /// <summary>
        /// Apresenta o nome do Logradouro
        /// </summary>
        /// <value>Apresenta o nome do Logradouro</value>
        [DataMember(Name="logradouro", EmitDefaultValue=false)]
        public string Logradouro { get; set; }
    
        /// <summary>
        /// Apresenta o n\u00FAmero do endere\u00E7o
        /// </summary>
        /// <value>Apresenta o n\u00FAmero do endere\u00E7o</value>
        [DataMember(Name="numero", EmitDefaultValue=false)]
        public int? Numero { get; set; }
    
        /// <summary>
        /// Apresenta descri\u00E7oes complementares referente ao endere\u00E7o
        /// </summary>
        /// <value>Apresenta descri\u00E7oes complementares referente ao endere\u00E7o</value>
        [DataMember(Name="complemento", EmitDefaultValue=false)]
        public string Complemento { get; set; }
    
        /// <summary>
        /// Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o
        /// </summary>
        /// <value>Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o</value>
        [DataMember(Name="pontoReferencia", EmitDefaultValue=false)]
        public string PontoReferencia { get; set; }
    
        /// <summary>
        /// Apresenta nome do bairro
        /// </summary>
        /// <value>Apresenta nome do bairro</value>
        [DataMember(Name="bairro", EmitDefaultValue=false)]
        public string Bairro { get; set; }
    
        /// <summary>
        /// Apresenta nome da cidade
        /// </summary>
        /// <value>Apresenta nome da cidade</value>
        [DataMember(Name="cidade", EmitDefaultValue=false)]
        public string Cidade { get; set; }
    
        /// <summary>
        /// Apresenta sigla da Unidade Federativa
        /// </summary>
        /// <value>Apresenta sigla da Unidade Federativa</value>
        [DataMember(Name="uf", EmitDefaultValue=false)]
        public string Uf { get; set; }
    
        /// <summary>
        /// Apresenta nome do Pa\u00EDs
        /// </summary>
        /// <value>Apresenta nome do Pa\u00EDs</value>
        [DataMember(Name="pais", EmitDefaultValue=false)]
        public string Pais { get; set; }
    
        /// <summary>
        /// Indica se o endere\u00E7o informado \u00E9 o de correspond\u00EAncia
        /// </summary>
        /// <value>Indica se o endere\u00E7o informado \u00E9 o de correspond\u00EAncia</value>
        [DataMember(Name="enderecoCorrespondencia", EmitDefaultValue=false)]
        public bool? EnderecoCorrespondencia { get; set; }
    
        /// <summary>
        /// Apresenta o tempo de resid\u00EAncia em anos
        /// </summary>
        /// <value>Apresenta o tempo de resid\u00EAncia em anos</value>
        [DataMember(Name="tempoResidenciaAnos", EmitDefaultValue=false)]
        public int? TempoResidenciaAnos { get; set; }
    
        /// <summary>
        /// Apresenta o tempo de resid\u00EAncia em meses
        /// </summary>
        /// <value>Apresenta o tempo de resid\u00EAncia em meses</value>
        [DataMember(Name="tempoResidenciaMeses", EmitDefaultValue=false)]
        public int? TempoResidenciaMeses { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjetoEndereoAprovado {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as ObjetoEndereoAprovado);
        }

        /// <summary>
        /// Returns true if ObjetoEndereoAprovado instances are equal
        /// </summary>
        /// <param name="other">Instance of ObjetoEndereoAprovado to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjetoEndereoAprovado other)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
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
