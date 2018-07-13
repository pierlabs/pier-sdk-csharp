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
    /// {{{endereco_response_description}}}
    /// </summary>
    [DataContract]
    public partial class EnderecoResponse :  IEquatable<EnderecoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EnderecoResponse" /> class.
        /// Initializes a new instance of the <see cref="EnderecoResponse" />class.
        /// </summary>
        /// <param name="Id">{{{endereco_response_id_value}}}.</param>
        /// <param name="IdPessoa">{{{endereco_response_id_pessoa_value}}}.</param>
        /// <param name="IdTipoEndereco">{{{endereco_response_id_tipo_endereco_value}}}.</param>
        /// <param name="Cep">{{{endereco_response_cep_value}}}.</param>
        /// <param name="Logradouro">{{{endereco_response_logradouro_value}}}.</param>
        /// <param name="Numero">{{{endereco_response_numero_value}}}.</param>
        /// <param name="Complemento">{{{endereco_response_complemento_value}}}.</param>
        /// <param name="PontoReferencia">{{{endereco_response_ponto_referencia_value}}}.</param>
        /// <param name="Bairro">{{{endereco_response_bairro_value}}}.</param>
        /// <param name="Cidade">{{{endereco_response_cidade_value}}}.</param>
        /// <param name="Uf">{{{endereco_response_uf_value}}}.</param>
        /// <param name="Pais">{{{endereco_response_pais_value}}}.</param>
        /// <param name="DataInclusao">{{{endereco_response_data_inclusao_value}}}.</param>
        /// <param name="DataUltimaAtualizacao">{{{endereco_response_data_ultima_atualizacao_value}}}.</param>
        /// <param name="FlagCorrespondencia">{{{endereco_response_flag_correspondencia_value}}}.</param>

        public EnderecoResponse(long? Id = null, long? IdPessoa = null, long? IdTipoEndereco = null, string Cep = null, string Logradouro = null, int? Numero = null, string Complemento = null, string PontoReferencia = null, string Bairro = null, string Cidade = null, string Uf = null, string Pais = null, string DataInclusao = null, string DataUltimaAtualizacao = null, bool? FlagCorrespondencia = null)
        {
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
        /// {{{endereco_response_id_value}}}
        /// </summary>
        /// <value>{{{endereco_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{endereco_response_id_pessoa_value}}}
        /// </summary>
        /// <value>{{{endereco_response_id_pessoa_value}}}</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// {{{endereco_response_id_tipo_endereco_value}}}
        /// </summary>
        /// <value>{{{endereco_response_id_tipo_endereco_value}}}</value>
        [DataMember(Name="idTipoEndereco", EmitDefaultValue=false)]
        public long? IdTipoEndereco { get; set; }
    
        /// <summary>
        /// {{{endereco_response_cep_value}}}
        /// </summary>
        /// <value>{{{endereco_response_cep_value}}}</value>
        [DataMember(Name="cep", EmitDefaultValue=false)]
        public string Cep { get; set; }
    
        /// <summary>
        /// {{{endereco_response_logradouro_value}}}
        /// </summary>
        /// <value>{{{endereco_response_logradouro_value}}}</value>
        [DataMember(Name="logradouro", EmitDefaultValue=false)]
        public string Logradouro { get; set; }
    
        /// <summary>
        /// {{{endereco_response_numero_value}}}
        /// </summary>
        /// <value>{{{endereco_response_numero_value}}}</value>
        [DataMember(Name="numero", EmitDefaultValue=false)]
        public int? Numero { get; set; }
    
        /// <summary>
        /// {{{endereco_response_complemento_value}}}
        /// </summary>
        /// <value>{{{endereco_response_complemento_value}}}</value>
        [DataMember(Name="complemento", EmitDefaultValue=false)]
        public string Complemento { get; set; }
    
        /// <summary>
        /// {{{endereco_response_ponto_referencia_value}}}
        /// </summary>
        /// <value>{{{endereco_response_ponto_referencia_value}}}</value>
        [DataMember(Name="pontoReferencia", EmitDefaultValue=false)]
        public string PontoReferencia { get; set; }
    
        /// <summary>
        /// {{{endereco_response_bairro_value}}}
        /// </summary>
        /// <value>{{{endereco_response_bairro_value}}}</value>
        [DataMember(Name="bairro", EmitDefaultValue=false)]
        public string Bairro { get; set; }
    
        /// <summary>
        /// {{{endereco_response_cidade_value}}}
        /// </summary>
        /// <value>{{{endereco_response_cidade_value}}}</value>
        [DataMember(Name="cidade", EmitDefaultValue=false)]
        public string Cidade { get; set; }
    
        /// <summary>
        /// {{{endereco_response_uf_value}}}
        /// </summary>
        /// <value>{{{endereco_response_uf_value}}}</value>
        [DataMember(Name="uf", EmitDefaultValue=false)]
        public string Uf { get; set; }
    
        /// <summary>
        /// {{{endereco_response_pais_value}}}
        /// </summary>
        /// <value>{{{endereco_response_pais_value}}}</value>
        [DataMember(Name="pais", EmitDefaultValue=false)]
        public string Pais { get; set; }
    
        /// <summary>
        /// {{{endereco_response_data_inclusao_value}}}
        /// </summary>
        /// <value>{{{endereco_response_data_inclusao_value}}}</value>
        [DataMember(Name="dataInclusao", EmitDefaultValue=false)]
        public string DataInclusao { get; set; }
    
        /// <summary>
        /// {{{endereco_response_data_ultima_atualizacao_value}}}
        /// </summary>
        /// <value>{{{endereco_response_data_ultima_atualizacao_value}}}</value>
        [DataMember(Name="dataUltimaAtualizacao", EmitDefaultValue=false)]
        public string DataUltimaAtualizacao { get; set; }
    
        /// <summary>
        /// {{{endereco_response_flag_correspondencia_value}}}
        /// </summary>
        /// <value>{{{endereco_response_flag_correspondencia_value}}}</value>
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
