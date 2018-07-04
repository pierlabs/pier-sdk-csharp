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
    /// {{{cartao_impressao_response_description}}}
    /// </summary>
    [DataContract]
    public partial class CartaoImpressaoResponse :  IEquatable<CartaoImpressaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoImpressaoResponse" /> class.
        /// Initializes a new instance of the <see cref="CartaoImpressaoResponse" />class.
        /// </summary>
        /// <param name="IdConta">{{{cartao_impressao_response_id_conta_value}}}.</param>
        /// <param name="IdPessoa">{{{cartao_impressao_response_id_pessoa_value}}}.</param>
        /// <param name="IdCartao">{{{cartao_impressao_response_id_cartao_value}}}.</param>
        /// <param name="IdBandeira">{{{cartao_impressao_response_id_bandeira_value}}}.</param>
        /// <param name="IdTipoCartao">{{{cartao_impressao_response_id_tipo_cartao_value}}}.</param>
        /// <param name="NumeroCartao">{{{cartao_impressao_response_numero_cartao_value}}}.</param>
        /// <param name="NomePlastico">{{{cartao_impressao_response_nome_plastico_value}}}.</param>
        /// <param name="Cvv2">{{{cartao_impressao_response_cvv2_value}}}.</param>
        /// <param name="DataGeracao">{{{cartao_impressao_response_data_geracao_value}}}.</param>
        /// <param name="DataValidade">{{{cartao_impressao_response_data_validade_value}}}.</param>
        /// <param name="NomeOrigemComercial">{{{cartao_impressao_response_nome_origem_comercial_value}}}.</param>
        /// <param name="NomeEmpresa">{{{cartao_impressao_response_nome_empresa_value}}}.</param>
        /// <param name="NumeroAgencia">{{{cartao_impressao_response_numero_agencia_value}}}.</param>
        /// <param name="NumeroContaCorente">{{{cartao_impressao_response_numero_conta_corente_value}}}.</param>
        /// <param name="NomeEmpresaBeneficio">{{{cartao_impressao_response_nome_empresa_beneficio_value}}}.</param>
        /// <param name="Cpf">{{{cartao_impressao_response_cpf_value}}}.</param>
        /// <param name="TipoPortador">{{{cartao_impressao_response_tipo_portador_value}}}.</param>
        /// <param name="NomeEmpregador">{{{cartao_impressao_response_nome_empregador_value}}}.</param>
        /// <param name="Trilha1">{{{cartao_impressao_response_trilha1_value}}}.</param>
        /// <param name="Trilha2">{{{cartao_impressao_response_trilha2_value}}}.</param>
        /// <param name="TrilhaCVV1">{{{cartao_impressao_response_trilha_c_v_v1_value}}}.</param>
        /// <param name="TrilhaCVV2">{{{cartao_impressao_response_trilha_c_v_v2_value}}}.</param>
        /// <param name="FlagVirtual">{{{cartao_impressao_response_flag_virtual_value}}}.</param>
        /// <param name="NumeroCartaoHash">{{{cartao_impressao_response_numero_cartao_hash_value}}}.</param>

        public CartaoImpressaoResponse(long? IdConta = null, long? IdPessoa = null, long? IdCartao = null, long? IdBandeira = null, long? IdTipoCartao = null, string NumeroCartao = null, string NomePlastico = null, string Cvv2 = null, string DataGeracao = null, string DataValidade = null, string NomeOrigemComercial = null, string NomeEmpresa = null, int? NumeroAgencia = null, string NumeroContaCorente = null, string NomeEmpresaBeneficio = null, string Cpf = null, string TipoPortador = null, string NomeEmpregador = null, string Trilha1 = null, string Trilha2 = null, string TrilhaCVV1 = null, string TrilhaCVV2 = null, int? FlagVirtual = null, long? NumeroCartaoHash = null)
        {
            this.IdConta = IdConta;
            this.IdPessoa = IdPessoa;
            this.IdCartao = IdCartao;
            this.IdBandeira = IdBandeira;
            this.IdTipoCartao = IdTipoCartao;
            this.NumeroCartao = NumeroCartao;
            this.NomePlastico = NomePlastico;
            this.Cvv2 = Cvv2;
            this.DataGeracao = DataGeracao;
            this.DataValidade = DataValidade;
            this.NomeOrigemComercial = NomeOrigemComercial;
            this.NomeEmpresa = NomeEmpresa;
            this.NumeroAgencia = NumeroAgencia;
            this.NumeroContaCorente = NumeroContaCorente;
            this.NomeEmpresaBeneficio = NomeEmpresaBeneficio;
            this.Cpf = Cpf;
            this.TipoPortador = TipoPortador;
            this.NomeEmpregador = NomeEmpregador;
            this.Trilha1 = Trilha1;
            this.Trilha2 = Trilha2;
            this.TrilhaCVV1 = TrilhaCVV1;
            this.TrilhaCVV2 = TrilhaCVV2;
            this.FlagVirtual = FlagVirtual;
            this.NumeroCartaoHash = NumeroCartaoHash;
            
        }
        
    
        /// <summary>
        /// {{{cartao_impressao_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_response_id_pessoa_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_response_id_pessoa_value}}}</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_response_id_cartao_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_response_id_cartao_value}}}</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_response_id_bandeira_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_response_id_bandeira_value}}}</value>
        [DataMember(Name="idBandeira", EmitDefaultValue=false)]
        public long? IdBandeira { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_response_id_tipo_cartao_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_response_id_tipo_cartao_value}}}</value>
        [DataMember(Name="idTipoCartao", EmitDefaultValue=false)]
        public long? IdTipoCartao { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_response_numero_cartao_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_response_numero_cartao_value}}}</value>
        [DataMember(Name="numeroCartao", EmitDefaultValue=false)]
        public string NumeroCartao { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_response_nome_plastico_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_response_nome_plastico_value}}}</value>
        [DataMember(Name="nomePlastico", EmitDefaultValue=false)]
        public string NomePlastico { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_response_cvv2_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_response_cvv2_value}}}</value>
        [DataMember(Name="cvv2", EmitDefaultValue=false)]
        public string Cvv2 { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_response_data_geracao_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_response_data_geracao_value}}}</value>
        [DataMember(Name="dataGeracao", EmitDefaultValue=false)]
        public string DataGeracao { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_response_data_validade_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_response_data_validade_value}}}</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_response_nome_origem_comercial_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_response_nome_origem_comercial_value}}}</value>
        [DataMember(Name="nomeOrigemComercial", EmitDefaultValue=false)]
        public string NomeOrigemComercial { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_response_nome_empresa_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_response_nome_empresa_value}}}</value>
        [DataMember(Name="nomeEmpresa", EmitDefaultValue=false)]
        public string NomeEmpresa { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_response_numero_agencia_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_response_numero_agencia_value}}}</value>
        [DataMember(Name="numeroAgencia", EmitDefaultValue=false)]
        public int? NumeroAgencia { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_response_numero_conta_corente_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_response_numero_conta_corente_value}}}</value>
        [DataMember(Name="numeroContaCorente", EmitDefaultValue=false)]
        public string NumeroContaCorente { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_response_nome_empresa_beneficio_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_response_nome_empresa_beneficio_value}}}</value>
        [DataMember(Name="nomeEmpresaBeneficio", EmitDefaultValue=false)]
        public string NomeEmpresaBeneficio { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_response_cpf_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_response_cpf_value}}}</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_response_tipo_portador_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_response_tipo_portador_value}}}</value>
        [DataMember(Name="tipoPortador", EmitDefaultValue=false)]
        public string TipoPortador { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_response_nome_empregador_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_response_nome_empregador_value}}}</value>
        [DataMember(Name="nomeEmpregador", EmitDefaultValue=false)]
        public string NomeEmpregador { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_response_trilha1_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_response_trilha1_value}}}</value>
        [DataMember(Name="trilha1", EmitDefaultValue=false)]
        public string Trilha1 { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_response_trilha2_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_response_trilha2_value}}}</value>
        [DataMember(Name="trilha2", EmitDefaultValue=false)]
        public string Trilha2 { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_response_trilha_c_v_v1_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_response_trilha_c_v_v1_value}}}</value>
        [DataMember(Name="trilhaCVV1", EmitDefaultValue=false)]
        public string TrilhaCVV1 { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_response_trilha_c_v_v2_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_response_trilha_c_v_v2_value}}}</value>
        [DataMember(Name="trilhaCVV2", EmitDefaultValue=false)]
        public string TrilhaCVV2 { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_response_flag_virtual_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_response_flag_virtual_value}}}</value>
        [DataMember(Name="flagVirtual", EmitDefaultValue=false)]
        public int? FlagVirtual { get; set; }
    
        /// <summary>
        /// {{{cartao_impressao_response_numero_cartao_hash_value}}}
        /// </summary>
        /// <value>{{{cartao_impressao_response_numero_cartao_hash_value}}}</value>
        [DataMember(Name="numeroCartaoHash", EmitDefaultValue=false)]
        public long? NumeroCartaoHash { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartaoImpressaoResponse {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  IdBandeira: ").Append(IdBandeira).Append("\n");
            sb.Append("  IdTipoCartao: ").Append(IdTipoCartao).Append("\n");
            sb.Append("  NumeroCartao: ").Append(NumeroCartao).Append("\n");
            sb.Append("  NomePlastico: ").Append(NomePlastico).Append("\n");
            sb.Append("  Cvv2: ").Append(Cvv2).Append("\n");
            sb.Append("  DataGeracao: ").Append(DataGeracao).Append("\n");
            sb.Append("  DataValidade: ").Append(DataValidade).Append("\n");
            sb.Append("  NomeOrigemComercial: ").Append(NomeOrigemComercial).Append("\n");
            sb.Append("  NomeEmpresa: ").Append(NomeEmpresa).Append("\n");
            sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
            sb.Append("  NumeroContaCorente: ").Append(NumeroContaCorente).Append("\n");
            sb.Append("  NomeEmpresaBeneficio: ").Append(NomeEmpresaBeneficio).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  TipoPortador: ").Append(TipoPortador).Append("\n");
            sb.Append("  NomeEmpregador: ").Append(NomeEmpregador).Append("\n");
            sb.Append("  Trilha1: ").Append(Trilha1).Append("\n");
            sb.Append("  Trilha2: ").Append(Trilha2).Append("\n");
            sb.Append("  TrilhaCVV1: ").Append(TrilhaCVV1).Append("\n");
            sb.Append("  TrilhaCVV2: ").Append(TrilhaCVV2).Append("\n");
            sb.Append("  FlagVirtual: ").Append(FlagVirtual).Append("\n");
            sb.Append("  NumeroCartaoHash: ").Append(NumeroCartaoHash).Append("\n");
            
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
            return this.Equals(obj as CartaoImpressaoResponse);
        }

        /// <summary>
        /// Returns true if CartaoImpressaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CartaoImpressaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartaoImpressaoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.IdBandeira == other.IdBandeira ||
                    this.IdBandeira != null &&
                    this.IdBandeira.Equals(other.IdBandeira)
                ) && 
                (
                    this.IdTipoCartao == other.IdTipoCartao ||
                    this.IdTipoCartao != null &&
                    this.IdTipoCartao.Equals(other.IdTipoCartao)
                ) && 
                (
                    this.NumeroCartao == other.NumeroCartao ||
                    this.NumeroCartao != null &&
                    this.NumeroCartao.Equals(other.NumeroCartao)
                ) && 
                (
                    this.NomePlastico == other.NomePlastico ||
                    this.NomePlastico != null &&
                    this.NomePlastico.Equals(other.NomePlastico)
                ) && 
                (
                    this.Cvv2 == other.Cvv2 ||
                    this.Cvv2 != null &&
                    this.Cvv2.Equals(other.Cvv2)
                ) && 
                (
                    this.DataGeracao == other.DataGeracao ||
                    this.DataGeracao != null &&
                    this.DataGeracao.Equals(other.DataGeracao)
                ) && 
                (
                    this.DataValidade == other.DataValidade ||
                    this.DataValidade != null &&
                    this.DataValidade.Equals(other.DataValidade)
                ) && 
                (
                    this.NomeOrigemComercial == other.NomeOrigemComercial ||
                    this.NomeOrigemComercial != null &&
                    this.NomeOrigemComercial.Equals(other.NomeOrigemComercial)
                ) && 
                (
                    this.NomeEmpresa == other.NomeEmpresa ||
                    this.NomeEmpresa != null &&
                    this.NomeEmpresa.Equals(other.NomeEmpresa)
                ) && 
                (
                    this.NumeroAgencia == other.NumeroAgencia ||
                    this.NumeroAgencia != null &&
                    this.NumeroAgencia.Equals(other.NumeroAgencia)
                ) && 
                (
                    this.NumeroContaCorente == other.NumeroContaCorente ||
                    this.NumeroContaCorente != null &&
                    this.NumeroContaCorente.Equals(other.NumeroContaCorente)
                ) && 
                (
                    this.NomeEmpresaBeneficio == other.NomeEmpresaBeneficio ||
                    this.NomeEmpresaBeneficio != null &&
                    this.NomeEmpresaBeneficio.Equals(other.NomeEmpresaBeneficio)
                ) && 
                (
                    this.Cpf == other.Cpf ||
                    this.Cpf != null &&
                    this.Cpf.Equals(other.Cpf)
                ) && 
                (
                    this.TipoPortador == other.TipoPortador ||
                    this.TipoPortador != null &&
                    this.TipoPortador.Equals(other.TipoPortador)
                ) && 
                (
                    this.NomeEmpregador == other.NomeEmpregador ||
                    this.NomeEmpregador != null &&
                    this.NomeEmpregador.Equals(other.NomeEmpregador)
                ) && 
                (
                    this.Trilha1 == other.Trilha1 ||
                    this.Trilha1 != null &&
                    this.Trilha1.Equals(other.Trilha1)
                ) && 
                (
                    this.Trilha2 == other.Trilha2 ||
                    this.Trilha2 != null &&
                    this.Trilha2.Equals(other.Trilha2)
                ) && 
                (
                    this.TrilhaCVV1 == other.TrilhaCVV1 ||
                    this.TrilhaCVV1 != null &&
                    this.TrilhaCVV1.Equals(other.TrilhaCVV1)
                ) && 
                (
                    this.TrilhaCVV2 == other.TrilhaCVV2 ||
                    this.TrilhaCVV2 != null &&
                    this.TrilhaCVV2.Equals(other.TrilhaCVV2)
                ) && 
                (
                    this.FlagVirtual == other.FlagVirtual ||
                    this.FlagVirtual != null &&
                    this.FlagVirtual.Equals(other.FlagVirtual)
                ) && 
                (
                    this.NumeroCartaoHash == other.NumeroCartaoHash ||
                    this.NumeroCartaoHash != null &&
                    this.NumeroCartaoHash.Equals(other.NumeroCartaoHash)
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
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.IdBandeira != null)
                    hash = hash * 59 + this.IdBandeira.GetHashCode();
                
                if (this.IdTipoCartao != null)
                    hash = hash * 59 + this.IdTipoCartao.GetHashCode();
                
                if (this.NumeroCartao != null)
                    hash = hash * 59 + this.NumeroCartao.GetHashCode();
                
                if (this.NomePlastico != null)
                    hash = hash * 59 + this.NomePlastico.GetHashCode();
                
                if (this.Cvv2 != null)
                    hash = hash * 59 + this.Cvv2.GetHashCode();
                
                if (this.DataGeracao != null)
                    hash = hash * 59 + this.DataGeracao.GetHashCode();
                
                if (this.DataValidade != null)
                    hash = hash * 59 + this.DataValidade.GetHashCode();
                
                if (this.NomeOrigemComercial != null)
                    hash = hash * 59 + this.NomeOrigemComercial.GetHashCode();
                
                if (this.NomeEmpresa != null)
                    hash = hash * 59 + this.NomeEmpresa.GetHashCode();
                
                if (this.NumeroAgencia != null)
                    hash = hash * 59 + this.NumeroAgencia.GetHashCode();
                
                if (this.NumeroContaCorente != null)
                    hash = hash * 59 + this.NumeroContaCorente.GetHashCode();
                
                if (this.NomeEmpresaBeneficio != null)
                    hash = hash * 59 + this.NomeEmpresaBeneficio.GetHashCode();
                
                if (this.Cpf != null)
                    hash = hash * 59 + this.Cpf.GetHashCode();
                
                if (this.TipoPortador != null)
                    hash = hash * 59 + this.TipoPortador.GetHashCode();
                
                if (this.NomeEmpregador != null)
                    hash = hash * 59 + this.NomeEmpregador.GetHashCode();
                
                if (this.Trilha1 != null)
                    hash = hash * 59 + this.Trilha1.GetHashCode();
                
                if (this.Trilha2 != null)
                    hash = hash * 59 + this.Trilha2.GetHashCode();
                
                if (this.TrilhaCVV1 != null)
                    hash = hash * 59 + this.TrilhaCVV1.GetHashCode();
                
                if (this.TrilhaCVV2 != null)
                    hash = hash * 59 + this.TrilhaCVV2.GetHashCode();
                
                if (this.FlagVirtual != null)
                    hash = hash * 59 + this.FlagVirtual.GetHashCode();
                
                if (this.NumeroCartaoHash != null)
                    hash = hash * 59 + this.NumeroCartaoHash.GetHashCode();
                
                return hash;
            }
        }

    }
}
