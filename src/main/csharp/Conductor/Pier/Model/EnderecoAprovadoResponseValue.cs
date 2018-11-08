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
    public partial class EnderecoAprovadoResponseValue :  IEquatable<EnderecoAprovadoResponseValue>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EnderecoAprovadoResponseValue" /> class.
        /// Initializes a new instance of the <see cref="EnderecoAprovadoResponseValue" />class.
        /// </summary>
        /// <param name="Id">{{{endereco_aprovado_response_id_value}}}.</param>
        /// <param name="IdTipoEndereco">{{{endereco_aprovado_response_id_tipo_endereco_value}}}.</param>
        /// <param name="Cep">{{{endereco_aprovado_response_cep_value}}}.</param>
        /// <param name="Logradouro">{{{endereco_aprovado_response_logradouro_value}}}.</param>
        /// <param name="Numero">{{{endereco_aprovado_response_numero_value}}}.</param>
        /// <param name="Complemento">{{{endereco_aprovado_response_complemento_value}}}.</param>
        /// <param name="PontoReferencia">{{{endereco_aprovado_response_ponto_referencia_value}}}.</param>
        /// <param name="Bairro">{{{endereco_aprovado_response_bairro_value}}}.</param>
        /// <param name="Cidade">{{{endereco_aprovado_response_cidade_value}}}.</param>
        /// <param name="Uf">{{{endereco_aprovado_response_uf_value}}}.</param>
        /// <param name="Pais">{{{endereco_aprovado_response_pais_value}}}.</param>
        /// <param name="EnderecoCorrespondencia">{{{endereco_aprovado_response_endereco_correspondencia_value}}}.</param>
        /// <param name="TempoResidenciaAnos">{{{endereco_aprovado_response_tempo_Residencia_Anos_value}}}.</param>
        /// <param name="TempoResidenciaMeses">{{{endereco_aprovado_response_tempo_Residencia_Meses_value}}}.</param>

        public EnderecoAprovadoResponseValue(long? Id = null, long? IdTipoEndereco = null, string Cep = null, string Logradouro = null, int? Numero = null, string Complemento = null, string PontoReferencia = null, string Bairro = null, string Cidade = null, string Uf = null, string Pais = null, bool? EnderecoCorrespondencia = null, int? TempoResidenciaAnos = null, int? TempoResidenciaMeses = null)
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
        /// {{{endereco_aprovado_response_id_value}}}
        /// </summary>
        /// <value>{{{endereco_aprovado_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{endereco_aprovado_response_id_tipo_endereco_value}}}
        /// </summary>
        /// <value>{{{endereco_aprovado_response_id_tipo_endereco_value}}}</value>
        [DataMember(Name="idTipoEndereco", EmitDefaultValue=false)]
        public long? IdTipoEndereco { get; set; }
    
        /// <summary>
        /// {{{endereco_aprovado_response_cep_value}}}
        /// </summary>
        /// <value>{{{endereco_aprovado_response_cep_value}}}</value>
        [DataMember(Name="cep", EmitDefaultValue=false)]
        public string Cep { get; set; }
    
        /// <summary>
        /// {{{endereco_aprovado_response_logradouro_value}}}
        /// </summary>
        /// <value>{{{endereco_aprovado_response_logradouro_value}}}</value>
        [DataMember(Name="logradouro", EmitDefaultValue=false)]
        public string Logradouro { get; set; }
    
        /// <summary>
        /// {{{endereco_aprovado_response_numero_value}}}
        /// </summary>
        /// <value>{{{endereco_aprovado_response_numero_value}}}</value>
        [DataMember(Name="numero", EmitDefaultValue=false)]
        public int? Numero { get; set; }
    
        /// <summary>
        /// {{{endereco_aprovado_response_complemento_value}}}
        /// </summary>
        /// <value>{{{endereco_aprovado_response_complemento_value}}}</value>
        [DataMember(Name="complemento", EmitDefaultValue=false)]
        public string Complemento { get; set; }
    
        /// <summary>
        /// {{{endereco_aprovado_response_ponto_referencia_value}}}
        /// </summary>
        /// <value>{{{endereco_aprovado_response_ponto_referencia_value}}}</value>
        [DataMember(Name="pontoReferencia", EmitDefaultValue=false)]
        public string PontoReferencia { get; set; }
    
        /// <summary>
        /// {{{endereco_aprovado_response_bairro_value}}}
        /// </summary>
        /// <value>{{{endereco_aprovado_response_bairro_value}}}</value>
        [DataMember(Name="bairro", EmitDefaultValue=false)]
        public string Bairro { get; set; }
    
        /// <summary>
        /// {{{endereco_aprovado_response_cidade_value}}}
        /// </summary>
        /// <value>{{{endereco_aprovado_response_cidade_value}}}</value>
        [DataMember(Name="cidade", EmitDefaultValue=false)]
        public string Cidade { get; set; }
    
        /// <summary>
        /// {{{endereco_aprovado_response_uf_value}}}
        /// </summary>
        /// <value>{{{endereco_aprovado_response_uf_value}}}</value>
        [DataMember(Name="uf", EmitDefaultValue=false)]
        public string Uf { get; set; }
    
        /// <summary>
        /// {{{endereco_aprovado_response_pais_value}}}
        /// </summary>
        /// <value>{{{endereco_aprovado_response_pais_value}}}</value>
        [DataMember(Name="pais", EmitDefaultValue=false)]
        public string Pais { get; set; }
    
        /// <summary>
        /// {{{endereco_aprovado_response_endereco_correspondencia_value}}}
        /// </summary>
        /// <value>{{{endereco_aprovado_response_endereco_correspondencia_value}}}</value>
        [DataMember(Name="enderecoCorrespondencia", EmitDefaultValue=false)]
        public bool? EnderecoCorrespondencia { get; set; }
    
        /// <summary>
        /// {{{endereco_aprovado_response_tempo_Residencia_Anos_value}}}
        /// </summary>
        /// <value>{{{endereco_aprovado_response_tempo_Residencia_Anos_value}}}</value>
        [DataMember(Name="tempoResidenciaAnos", EmitDefaultValue=false)]
        public int? TempoResidenciaAnos { get; set; }
    
        /// <summary>
        /// {{{endereco_aprovado_response_tempo_Residencia_Meses_value}}}
        /// </summary>
        /// <value>{{{endereco_aprovado_response_tempo_Residencia_Meses_value}}}</value>
        [DataMember(Name="tempoResidenciaMeses", EmitDefaultValue=false)]
        public int? TempoResidenciaMeses { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnderecoAprovadoResponseValue {\n");
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
            return this.Equals(obj as EnderecoAprovadoResponseValue);
        }

        /// <summary>
        /// Returns true if EnderecoAprovadoResponseValue instances are equal
        /// </summary>
        /// <param name="other">Instance of EnderecoAprovadoResponseValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnderecoAprovadoResponseValue other)
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
