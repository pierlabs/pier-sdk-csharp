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
    /// {{{telefone_escritorio_cobranca_d_t_o_description}}}
    /// </summary>
    [DataContract]
    public partial class EscritorioCobrancaDTO :  IEquatable<EscritorioCobrancaDTO>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EscritorioCobrancaDTO" /> class.
        /// Initializes a new instance of the <see cref="EscritorioCobrancaDTO" />class.
        /// </summary>
        /// <param name="IdCredor">{{{escritorio_cobranca_d_t_o_id_credor_value}}} (required).</param>
        /// <param name="Prefixo">{{{escritorio_cobranca_d_t_o_prefixo_value}}} (required).</param>
        /// <param name="Ativo">{{{escritorio_cobranca_d_t_o_ativo_value}}} (required).</param>
        /// <param name="NomeContato">{{{escritorio_cobranca_d_t_o_nome_contato_value}}}.</param>
        /// <param name="Email">{{{escritorio_cobranca_d_t_o_email_value}}}.</param>
        /// <param name="NomeLogradouro">{{{escritorio_cobranca_d_t_o_nome_logradouro_value}}}.</param>
        /// <param name="NumeroEndereco">{{{escritorio_cobranca_d_t_o_numero_endereco_value}}}.</param>
        /// <param name="ComplementoEndereco">{{{escritorio_cobranca_d_t_o_complemento_endereco_value}}}.</param>
        /// <param name="Bairro">{{{escritorio_cobranca_d_t_o_bairro_value}}}.</param>
        /// <param name="Cidade">{{{escritorio_cobranca_d_t_o_cidade_value}}}.</param>
        /// <param name="Cep">{{{escritorio_cobranca_d_t_o_cep_value}}}.</param>
        /// <param name="Uf">{{{escritorio_cobranca_d_t_o_uf_value}}}.</param>
        /// <param name="Responsavel">{{{escritorio_cobranca_d_t_o_responsavel_value}}}.</param>
        /// <param name="FlagSegundaViaAcordo">{{{escritorio_cobranca_d_t_o_flag_segunda_via_acordo_value}}}.</param>
        /// <param name="ValorMinimoParcela">{{{escritorio_cobranca_d_t_o_valor_minimo_parcela_value}}}.</param>
        /// <param name="DescontoMaximo">{{{escritorio_cobranca_d_t_o_desconto_maximo_value}}}.</param>

        public EscritorioCobrancaDTO(long? IdCredor = null, string Prefixo = null, bool? Ativo = null, string NomeContato = null, string Email = null, string NomeLogradouro = null, int? NumeroEndereco = null, string ComplementoEndereco = null, string Bairro = null, string Cidade = null, string Cep = null, string Uf = null, string Responsavel = null, int? FlagSegundaViaAcordo = null, double? ValorMinimoParcela = null, double? DescontoMaximo = null)
        {
            // to ensure "IdCredor" is required (not null)
            if (IdCredor == null)
            {
                throw new InvalidDataException("IdCredor is a required property for EscritorioCobrancaDTO and cannot be null");
            }
            else
            {
                this.IdCredor = IdCredor;
            }
            // to ensure "Prefixo" is required (not null)
            if (Prefixo == null)
            {
                throw new InvalidDataException("Prefixo is a required property for EscritorioCobrancaDTO and cannot be null");
            }
            else
            {
                this.Prefixo = Prefixo;
            }
            // to ensure "Ativo" is required (not null)
            if (Ativo == null)
            {
                throw new InvalidDataException("Ativo is a required property for EscritorioCobrancaDTO and cannot be null");
            }
            else
            {
                this.Ativo = Ativo;
            }
            this.NomeContato = NomeContato;
            this.Email = Email;
            this.NomeLogradouro = NomeLogradouro;
            this.NumeroEndereco = NumeroEndereco;
            this.ComplementoEndereco = ComplementoEndereco;
            this.Bairro = Bairro;
            this.Cidade = Cidade;
            this.Cep = Cep;
            this.Uf = Uf;
            this.Responsavel = Responsavel;
            this.FlagSegundaViaAcordo = FlagSegundaViaAcordo;
            this.ValorMinimoParcela = ValorMinimoParcela;
            this.DescontoMaximo = DescontoMaximo;
            
        }
        
    
        /// <summary>
        /// {{{escritorio_cobranca_d_t_o_id_credor_value}}}
        /// </summary>
        /// <value>{{{escritorio_cobranca_d_t_o_id_credor_value}}}</value>
        [DataMember(Name="idCredor", EmitDefaultValue=false)]
        public long? IdCredor { get; set; }
    
        /// <summary>
        /// {{{escritorio_cobranca_d_t_o_prefixo_value}}}
        /// </summary>
        /// <value>{{{escritorio_cobranca_d_t_o_prefixo_value}}}</value>
        [DataMember(Name="prefixo", EmitDefaultValue=false)]
        public string Prefixo { get; set; }
    
        /// <summary>
        /// {{{escritorio_cobranca_d_t_o_ativo_value}}}
        /// </summary>
        /// <value>{{{escritorio_cobranca_d_t_o_ativo_value}}}</value>
        [DataMember(Name="ativo", EmitDefaultValue=false)]
        public bool? Ativo { get; set; }
    
        /// <summary>
        /// {{{escritorio_cobranca_d_t_o_nome_contato_value}}}
        /// </summary>
        /// <value>{{{escritorio_cobranca_d_t_o_nome_contato_value}}}</value>
        [DataMember(Name="nomeContato", EmitDefaultValue=false)]
        public string NomeContato { get; set; }
    
        /// <summary>
        /// {{{escritorio_cobranca_d_t_o_email_value}}}
        /// </summary>
        /// <value>{{{escritorio_cobranca_d_t_o_email_value}}}</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// {{{escritorio_cobranca_d_t_o_nome_logradouro_value}}}
        /// </summary>
        /// <value>{{{escritorio_cobranca_d_t_o_nome_logradouro_value}}}</value>
        [DataMember(Name="nomeLogradouro", EmitDefaultValue=false)]
        public string NomeLogradouro { get; set; }
    
        /// <summary>
        /// {{{escritorio_cobranca_d_t_o_numero_endereco_value}}}
        /// </summary>
        /// <value>{{{escritorio_cobranca_d_t_o_numero_endereco_value}}}</value>
        [DataMember(Name="numeroEndereco", EmitDefaultValue=false)]
        public int? NumeroEndereco { get; set; }
    
        /// <summary>
        /// {{{escritorio_cobranca_d_t_o_complemento_endereco_value}}}
        /// </summary>
        /// <value>{{{escritorio_cobranca_d_t_o_complemento_endereco_value}}}</value>
        [DataMember(Name="complementoEndereco", EmitDefaultValue=false)]
        public string ComplementoEndereco { get; set; }
    
        /// <summary>
        /// {{{escritorio_cobranca_d_t_o_bairro_value}}}
        /// </summary>
        /// <value>{{{escritorio_cobranca_d_t_o_bairro_value}}}</value>
        [DataMember(Name="bairro", EmitDefaultValue=false)]
        public string Bairro { get; set; }
    
        /// <summary>
        /// {{{escritorio_cobranca_d_t_o_cidade_value}}}
        /// </summary>
        /// <value>{{{escritorio_cobranca_d_t_o_cidade_value}}}</value>
        [DataMember(Name="cidade", EmitDefaultValue=false)]
        public string Cidade { get; set; }
    
        /// <summary>
        /// {{{escritorio_cobranca_d_t_o_cep_value}}}
        /// </summary>
        /// <value>{{{escritorio_cobranca_d_t_o_cep_value}}}</value>
        [DataMember(Name="cep", EmitDefaultValue=false)]
        public string Cep { get; set; }
    
        /// <summary>
        /// {{{escritorio_cobranca_d_t_o_uf_value}}}
        /// </summary>
        /// <value>{{{escritorio_cobranca_d_t_o_uf_value}}}</value>
        [DataMember(Name="uf", EmitDefaultValue=false)]
        public string Uf { get; set; }
    
        /// <summary>
        /// {{{escritorio_cobranca_d_t_o_responsavel_value}}}
        /// </summary>
        /// <value>{{{escritorio_cobranca_d_t_o_responsavel_value}}}</value>
        [DataMember(Name="responsavel", EmitDefaultValue=false)]
        public string Responsavel { get; set; }
    
        /// <summary>
        /// {{{escritorio_cobranca_d_t_o_flag_segunda_via_acordo_value}}}
        /// </summary>
        /// <value>{{{escritorio_cobranca_d_t_o_flag_segunda_via_acordo_value}}}</value>
        [DataMember(Name="flagSegundaViaAcordo", EmitDefaultValue=false)]
        public int? FlagSegundaViaAcordo { get; set; }
    
        /// <summary>
        /// {{{escritorio_cobranca_d_t_o_valor_minimo_parcela_value}}}
        /// </summary>
        /// <value>{{{escritorio_cobranca_d_t_o_valor_minimo_parcela_value}}}</value>
        [DataMember(Name="valorMinimoParcela", EmitDefaultValue=false)]
        public double? ValorMinimoParcela { get; set; }
    
        /// <summary>
        /// {{{escritorio_cobranca_d_t_o_desconto_maximo_value}}}
        /// </summary>
        /// <value>{{{escritorio_cobranca_d_t_o_desconto_maximo_value}}}</value>
        [DataMember(Name="descontoMaximo", EmitDefaultValue=false)]
        public double? DescontoMaximo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EscritorioCobrancaDTO {\n");
            sb.Append("  IdCredor: ").Append(IdCredor).Append("\n");
            sb.Append("  Prefixo: ").Append(Prefixo).Append("\n");
            sb.Append("  Ativo: ").Append(Ativo).Append("\n");
            sb.Append("  NomeContato: ").Append(NomeContato).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  NomeLogradouro: ").Append(NomeLogradouro).Append("\n");
            sb.Append("  NumeroEndereco: ").Append(NumeroEndereco).Append("\n");
            sb.Append("  ComplementoEndereco: ").Append(ComplementoEndereco).Append("\n");
            sb.Append("  Bairro: ").Append(Bairro).Append("\n");
            sb.Append("  Cidade: ").Append(Cidade).Append("\n");
            sb.Append("  Cep: ").Append(Cep).Append("\n");
            sb.Append("  Uf: ").Append(Uf).Append("\n");
            sb.Append("  Responsavel: ").Append(Responsavel).Append("\n");
            sb.Append("  FlagSegundaViaAcordo: ").Append(FlagSegundaViaAcordo).Append("\n");
            sb.Append("  ValorMinimoParcela: ").Append(ValorMinimoParcela).Append("\n");
            sb.Append("  DescontoMaximo: ").Append(DescontoMaximo).Append("\n");
            
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
            return this.Equals(obj as EscritorioCobrancaDTO);
        }

        /// <summary>
        /// Returns true if EscritorioCobrancaDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of EscritorioCobrancaDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EscritorioCobrancaDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdCredor == other.IdCredor ||
                    this.IdCredor != null &&
                    this.IdCredor.Equals(other.IdCredor)
                ) && 
                (
                    this.Prefixo == other.Prefixo ||
                    this.Prefixo != null &&
                    this.Prefixo.Equals(other.Prefixo)
                ) && 
                (
                    this.Ativo == other.Ativo ||
                    this.Ativo != null &&
                    this.Ativo.Equals(other.Ativo)
                ) && 
                (
                    this.NomeContato == other.NomeContato ||
                    this.NomeContato != null &&
                    this.NomeContato.Equals(other.NomeContato)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.NomeLogradouro == other.NomeLogradouro ||
                    this.NomeLogradouro != null &&
                    this.NomeLogradouro.Equals(other.NomeLogradouro)
                ) && 
                (
                    this.NumeroEndereco == other.NumeroEndereco ||
                    this.NumeroEndereco != null &&
                    this.NumeroEndereco.Equals(other.NumeroEndereco)
                ) && 
                (
                    this.ComplementoEndereco == other.ComplementoEndereco ||
                    this.ComplementoEndereco != null &&
                    this.ComplementoEndereco.Equals(other.ComplementoEndereco)
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
                    this.Cep == other.Cep ||
                    this.Cep != null &&
                    this.Cep.Equals(other.Cep)
                ) && 
                (
                    this.Uf == other.Uf ||
                    this.Uf != null &&
                    this.Uf.Equals(other.Uf)
                ) && 
                (
                    this.Responsavel == other.Responsavel ||
                    this.Responsavel != null &&
                    this.Responsavel.Equals(other.Responsavel)
                ) && 
                (
                    this.FlagSegundaViaAcordo == other.FlagSegundaViaAcordo ||
                    this.FlagSegundaViaAcordo != null &&
                    this.FlagSegundaViaAcordo.Equals(other.FlagSegundaViaAcordo)
                ) && 
                (
                    this.ValorMinimoParcela == other.ValorMinimoParcela ||
                    this.ValorMinimoParcela != null &&
                    this.ValorMinimoParcela.Equals(other.ValorMinimoParcela)
                ) && 
                (
                    this.DescontoMaximo == other.DescontoMaximo ||
                    this.DescontoMaximo != null &&
                    this.DescontoMaximo.Equals(other.DescontoMaximo)
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
                
                if (this.IdCredor != null)
                    hash = hash * 59 + this.IdCredor.GetHashCode();
                
                if (this.Prefixo != null)
                    hash = hash * 59 + this.Prefixo.GetHashCode();
                
                if (this.Ativo != null)
                    hash = hash * 59 + this.Ativo.GetHashCode();
                
                if (this.NomeContato != null)
                    hash = hash * 59 + this.NomeContato.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.NomeLogradouro != null)
                    hash = hash * 59 + this.NomeLogradouro.GetHashCode();
                
                if (this.NumeroEndereco != null)
                    hash = hash * 59 + this.NumeroEndereco.GetHashCode();
                
                if (this.ComplementoEndereco != null)
                    hash = hash * 59 + this.ComplementoEndereco.GetHashCode();
                
                if (this.Bairro != null)
                    hash = hash * 59 + this.Bairro.GetHashCode();
                
                if (this.Cidade != null)
                    hash = hash * 59 + this.Cidade.GetHashCode();
                
                if (this.Cep != null)
                    hash = hash * 59 + this.Cep.GetHashCode();
                
                if (this.Uf != null)
                    hash = hash * 59 + this.Uf.GetHashCode();
                
                if (this.Responsavel != null)
                    hash = hash * 59 + this.Responsavel.GetHashCode();
                
                if (this.FlagSegundaViaAcordo != null)
                    hash = hash * 59 + this.FlagSegundaViaAcordo.GetHashCode();
                
                if (this.ValorMinimoParcela != null)
                    hash = hash * 59 + this.ValorMinimoParcela.GetHashCode();
                
                if (this.DescontoMaximo != null)
                    hash = hash * 59 + this.DescontoMaximo.GetHashCode();
                
                return hash;
            }
        }

    }
}
