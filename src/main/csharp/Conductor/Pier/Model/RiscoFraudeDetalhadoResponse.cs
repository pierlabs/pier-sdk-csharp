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
    /// {{{risco_fraude_detalhado_response_description}}}
    /// </summary>
    [DataContract]
    public partial class RiscoFraudeDetalhadoResponse :  IEquatable<RiscoFraudeDetalhadoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RiscoFraudeDetalhadoResponse" /> class.
        /// Initializes a new instance of the <see cref="RiscoFraudeDetalhadoResponse" />class.
        /// </summary>
        /// <param name="Id">{{{risco_fraude_detalhado_response_id_value}}}.</param>
        /// <param name="IdTipoResolucao">{{{risco_fraude_detalhado_response_id_tipo_resolucao_value}}}.</param>
        /// <param name="DescricaoTipoResolucao">{{{risco_fraude_detalhado_response_descricao_tipo_resolucao_value}}}.</param>
        /// <param name="FlagAltoRisco">{{{risco_fraude_detalhado_response_flag_alto_risco_value}}}.</param>
        /// <param name="IdConta">{{{risco_fraude_detalhado_response_id_conta_value}}}.</param>
        /// <param name="IdCartao">{{{risco_fraude_detalhado_response_id_cartao_value}}}.</param>
        /// <param name="IdProduto">{{{risco_fraude_detalhado_response_id_produto_value}}}.</param>
        /// <param name="IdTransacao">{{{risco_fraude_detalhado_response_id_transacao_value}}}.</param>
        /// <param name="DataTransacao">{{{risco_fraude_detalhado_response_data_transacao_value}}}.</param>
        /// <param name="ValorTransacao">{{{risco_fraude_detalhado_response_valor_transacao_value}}}.</param>
        /// <param name="CodigoMoedaOrigem">{{{risco_fraude_detalhado_response_codigo_moeda_origem_value}}}.</param>
        /// <param name="ValorOrigem">{{{risco_fraude_detalhado_response_valor_origem_value}}}.</param>
        /// <param name="CodigoMoedaDestino">{{{risco_fraude_detalhado_response_codigo_moeda_destino_value}}}.</param>
        /// <param name="ValorDestino">{{{risco_fraude_detalhado_response_valor_destino_value}}}.</param>
        /// <param name="NomeEstabelecimento">{{{risco_fraude_detalhado_response_nome_estabelecimento_value}}}.</param>
        /// <param name="IdPais">{{{risco_fraude_detalhado_response_id_pais_value}}}.</param>
        /// <param name="CodigoRespostaAutorizador">{{{risco_fraude_detalhado_response_codigo_resposta_autorizador_value}}}.</param>
        /// <param name="DescricaoRespostaAutorizador">{{{risco_fraude_detalhado_response_descricao_resposta_autorizador_value}}}.</param>
        /// <param name="CodigoRespostaFraude">{{{risco_fraude_detalhado_response_codigo_resposta_fraude_value}}}.</param>
        /// <param name="DescricaoRespostaFraude">{{{risco_fraude_detalhado_response_descricao_resposta_fraude_value}}}.</param>
        /// <param name="OrigemTransacao">{{{risco_fraude_detalhado_response_origem_transacao_value}}}.</param>
        /// <param name="CodigoModoEntradaTerminal">{{{risco_fraude_detalhado_response_codigo_modo_entrada_terminal_value}}}.</param>
        /// <param name="DescricaoModoEntradaTerminal">{{{risco_fraude_detalhado_response_descricao_modo_entrada_terminal_value}}}.</param>
        /// <param name="Cpf">{{{risco_fraude_detalhado_response_cpf_value}}}.</param>
        /// <param name="Cnpj">{{{risco_fraude_detalhado_response_cnpj_value}}}.</param>
        /// <param name="Email">{{{risco_fraude_detalhado_response_email_value}}}.</param>
        /// <param name="Telefones">{{{risco_fraude_detalhado_response_telefones_value}}}.</param>

        public RiscoFraudeDetalhadoResponse(long? Id = null, long? IdTipoResolucao = null, string DescricaoTipoResolucao = null, bool? FlagAltoRisco = null, long? IdConta = null, long? IdCartao = null, long? IdProduto = null, long? IdTransacao = null, string DataTransacao = null, double? ValorTransacao = null, string CodigoMoedaOrigem = null, double? ValorOrigem = null, string CodigoMoedaDestino = null, double? ValorDestino = null, string NomeEstabelecimento = null, string IdPais = null, string CodigoRespostaAutorizador = null, string DescricaoRespostaAutorizador = null, string CodigoRespostaFraude = null, string DescricaoRespostaFraude = null, string OrigemTransacao = null, string CodigoModoEntradaTerminal = null, string DescricaoModoEntradaTerminal = null, string Cpf = null, string Cnpj = null, string Email = null, List<TelefoneResponse> Telefones = null)
        {
            this.Id = Id;
            this.IdTipoResolucao = IdTipoResolucao;
            this.DescricaoTipoResolucao = DescricaoTipoResolucao;
            this.FlagAltoRisco = FlagAltoRisco;
            this.IdConta = IdConta;
            this.IdCartao = IdCartao;
            this.IdProduto = IdProduto;
            this.IdTransacao = IdTransacao;
            this.DataTransacao = DataTransacao;
            this.ValorTransacao = ValorTransacao;
            this.CodigoMoedaOrigem = CodigoMoedaOrigem;
            this.ValorOrigem = ValorOrigem;
            this.CodigoMoedaDestino = CodigoMoedaDestino;
            this.ValorDestino = ValorDestino;
            this.NomeEstabelecimento = NomeEstabelecimento;
            this.IdPais = IdPais;
            this.CodigoRespostaAutorizador = CodigoRespostaAutorizador;
            this.DescricaoRespostaAutorizador = DescricaoRespostaAutorizador;
            this.CodigoRespostaFraude = CodigoRespostaFraude;
            this.DescricaoRespostaFraude = DescricaoRespostaFraude;
            this.OrigemTransacao = OrigemTransacao;
            this.CodigoModoEntradaTerminal = CodigoModoEntradaTerminal;
            this.DescricaoModoEntradaTerminal = DescricaoModoEntradaTerminal;
            this.Cpf = Cpf;
            this.Cnpj = Cnpj;
            this.Email = Email;
            this.Telefones = Telefones;
            
        }
        
    
        /// <summary>
        /// {{{risco_fraude_detalhado_response_id_value}}}
        /// </summary>
        /// <value>{{{risco_fraude_detalhado_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{risco_fraude_detalhado_response_id_tipo_resolucao_value}}}
        /// </summary>
        /// <value>{{{risco_fraude_detalhado_response_id_tipo_resolucao_value}}}</value>
        [DataMember(Name="idTipoResolucao", EmitDefaultValue=false)]
        public long? IdTipoResolucao { get; set; }
    
        /// <summary>
        /// {{{risco_fraude_detalhado_response_descricao_tipo_resolucao_value}}}
        /// </summary>
        /// <value>{{{risco_fraude_detalhado_response_descricao_tipo_resolucao_value}}}</value>
        [DataMember(Name="descricaoTipoResolucao", EmitDefaultValue=false)]
        public string DescricaoTipoResolucao { get; set; }
    
        /// <summary>
        /// {{{risco_fraude_detalhado_response_flag_alto_risco_value}}}
        /// </summary>
        /// <value>{{{risco_fraude_detalhado_response_flag_alto_risco_value}}}</value>
        [DataMember(Name="flagAltoRisco", EmitDefaultValue=false)]
        public bool? FlagAltoRisco { get; set; }
    
        /// <summary>
        /// {{{risco_fraude_detalhado_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{risco_fraude_detalhado_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{risco_fraude_detalhado_response_id_cartao_value}}}
        /// </summary>
        /// <value>{{{risco_fraude_detalhado_response_id_cartao_value}}}</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// {{{risco_fraude_detalhado_response_id_produto_value}}}
        /// </summary>
        /// <value>{{{risco_fraude_detalhado_response_id_produto_value}}}</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// {{{risco_fraude_detalhado_response_id_transacao_value}}}
        /// </summary>
        /// <value>{{{risco_fraude_detalhado_response_id_transacao_value}}}</value>
        [DataMember(Name="idTransacao", EmitDefaultValue=false)]
        public long? IdTransacao { get; set; }
    
        /// <summary>
        /// {{{risco_fraude_detalhado_response_data_transacao_value}}}
        /// </summary>
        /// <value>{{{risco_fraude_detalhado_response_data_transacao_value}}}</value>
        [DataMember(Name="dataTransacao", EmitDefaultValue=false)]
        public string DataTransacao { get; set; }
    
        /// <summary>
        /// {{{risco_fraude_detalhado_response_valor_transacao_value}}}
        /// </summary>
        /// <value>{{{risco_fraude_detalhado_response_valor_transacao_value}}}</value>
        [DataMember(Name="valorTransacao", EmitDefaultValue=false)]
        public double? ValorTransacao { get; set; }
    
        /// <summary>
        /// {{{risco_fraude_detalhado_response_codigo_moeda_origem_value}}}
        /// </summary>
        /// <value>{{{risco_fraude_detalhado_response_codigo_moeda_origem_value}}}</value>
        [DataMember(Name="codigoMoedaOrigem", EmitDefaultValue=false)]
        public string CodigoMoedaOrigem { get; set; }
    
        /// <summary>
        /// {{{risco_fraude_detalhado_response_valor_origem_value}}}
        /// </summary>
        /// <value>{{{risco_fraude_detalhado_response_valor_origem_value}}}</value>
        [DataMember(Name="valorOrigem", EmitDefaultValue=false)]
        public double? ValorOrigem { get; set; }
    
        /// <summary>
        /// {{{risco_fraude_detalhado_response_codigo_moeda_destino_value}}}
        /// </summary>
        /// <value>{{{risco_fraude_detalhado_response_codigo_moeda_destino_value}}}</value>
        [DataMember(Name="codigoMoedaDestino", EmitDefaultValue=false)]
        public string CodigoMoedaDestino { get; set; }
    
        /// <summary>
        /// {{{risco_fraude_detalhado_response_valor_destino_value}}}
        /// </summary>
        /// <value>{{{risco_fraude_detalhado_response_valor_destino_value}}}</value>
        [DataMember(Name="valorDestino", EmitDefaultValue=false)]
        public double? ValorDestino { get; set; }
    
        /// <summary>
        /// {{{risco_fraude_detalhado_response_nome_estabelecimento_value}}}
        /// </summary>
        /// <value>{{{risco_fraude_detalhado_response_nome_estabelecimento_value}}}</value>
        [DataMember(Name="nomeEstabelecimento", EmitDefaultValue=false)]
        public string NomeEstabelecimento { get; set; }
    
        /// <summary>
        /// {{{risco_fraude_detalhado_response_id_pais_value}}}
        /// </summary>
        /// <value>{{{risco_fraude_detalhado_response_id_pais_value}}}</value>
        [DataMember(Name="idPais", EmitDefaultValue=false)]
        public string IdPais { get; set; }
    
        /// <summary>
        /// {{{risco_fraude_detalhado_response_codigo_resposta_autorizador_value}}}
        /// </summary>
        /// <value>{{{risco_fraude_detalhado_response_codigo_resposta_autorizador_value}}}</value>
        [DataMember(Name="codigoRespostaAutorizador", EmitDefaultValue=false)]
        public string CodigoRespostaAutorizador { get; set; }
    
        /// <summary>
        /// {{{risco_fraude_detalhado_response_descricao_resposta_autorizador_value}}}
        /// </summary>
        /// <value>{{{risco_fraude_detalhado_response_descricao_resposta_autorizador_value}}}</value>
        [DataMember(Name="descricaoRespostaAutorizador", EmitDefaultValue=false)]
        public string DescricaoRespostaAutorizador { get; set; }
    
        /// <summary>
        /// {{{risco_fraude_detalhado_response_codigo_resposta_fraude_value}}}
        /// </summary>
        /// <value>{{{risco_fraude_detalhado_response_codigo_resposta_fraude_value}}}</value>
        [DataMember(Name="codigoRespostaFraude", EmitDefaultValue=false)]
        public string CodigoRespostaFraude { get; set; }
    
        /// <summary>
        /// {{{risco_fraude_detalhado_response_descricao_resposta_fraude_value}}}
        /// </summary>
        /// <value>{{{risco_fraude_detalhado_response_descricao_resposta_fraude_value}}}</value>
        [DataMember(Name="descricaoRespostaFraude", EmitDefaultValue=false)]
        public string DescricaoRespostaFraude { get; set; }
    
        /// <summary>
        /// {{{risco_fraude_detalhado_response_origem_transacao_value}}}
        /// </summary>
        /// <value>{{{risco_fraude_detalhado_response_origem_transacao_value}}}</value>
        [DataMember(Name="origemTransacao", EmitDefaultValue=false)]
        public string OrigemTransacao { get; set; }
    
        /// <summary>
        /// {{{risco_fraude_detalhado_response_codigo_modo_entrada_terminal_value}}}
        /// </summary>
        /// <value>{{{risco_fraude_detalhado_response_codigo_modo_entrada_terminal_value}}}</value>
        [DataMember(Name="codigoModoEntradaTerminal", EmitDefaultValue=false)]
        public string CodigoModoEntradaTerminal { get; set; }
    
        /// <summary>
        /// {{{risco_fraude_detalhado_response_descricao_modo_entrada_terminal_value}}}
        /// </summary>
        /// <value>{{{risco_fraude_detalhado_response_descricao_modo_entrada_terminal_value}}}</value>
        [DataMember(Name="descricaoModoEntradaTerminal", EmitDefaultValue=false)]
        public string DescricaoModoEntradaTerminal { get; set; }
    
        /// <summary>
        /// {{{risco_fraude_detalhado_response_cpf_value}}}
        /// </summary>
        /// <value>{{{risco_fraude_detalhado_response_cpf_value}}}</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// {{{risco_fraude_detalhado_response_cnpj_value}}}
        /// </summary>
        /// <value>{{{risco_fraude_detalhado_response_cnpj_value}}}</value>
        [DataMember(Name="cnpj", EmitDefaultValue=false)]
        public string Cnpj { get; set; }
    
        /// <summary>
        /// {{{risco_fraude_detalhado_response_email_value}}}
        /// </summary>
        /// <value>{{{risco_fraude_detalhado_response_email_value}}}</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// {{{risco_fraude_detalhado_response_telefones_value}}}
        /// </summary>
        /// <value>{{{risco_fraude_detalhado_response_telefones_value}}}</value>
        [DataMember(Name="telefones", EmitDefaultValue=false)]
        public List<TelefoneResponse> Telefones { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RiscoFraudeDetalhadoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdTipoResolucao: ").Append(IdTipoResolucao).Append("\n");
            sb.Append("  DescricaoTipoResolucao: ").Append(DescricaoTipoResolucao).Append("\n");
            sb.Append("  FlagAltoRisco: ").Append(FlagAltoRisco).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  IdTransacao: ").Append(IdTransacao).Append("\n");
            sb.Append("  DataTransacao: ").Append(DataTransacao).Append("\n");
            sb.Append("  ValorTransacao: ").Append(ValorTransacao).Append("\n");
            sb.Append("  CodigoMoedaOrigem: ").Append(CodigoMoedaOrigem).Append("\n");
            sb.Append("  ValorOrigem: ").Append(ValorOrigem).Append("\n");
            sb.Append("  CodigoMoedaDestino: ").Append(CodigoMoedaDestino).Append("\n");
            sb.Append("  ValorDestino: ").Append(ValorDestino).Append("\n");
            sb.Append("  NomeEstabelecimento: ").Append(NomeEstabelecimento).Append("\n");
            sb.Append("  IdPais: ").Append(IdPais).Append("\n");
            sb.Append("  CodigoRespostaAutorizador: ").Append(CodigoRespostaAutorizador).Append("\n");
            sb.Append("  DescricaoRespostaAutorizador: ").Append(DescricaoRespostaAutorizador).Append("\n");
            sb.Append("  CodigoRespostaFraude: ").Append(CodigoRespostaFraude).Append("\n");
            sb.Append("  DescricaoRespostaFraude: ").Append(DescricaoRespostaFraude).Append("\n");
            sb.Append("  OrigemTransacao: ").Append(OrigemTransacao).Append("\n");
            sb.Append("  CodigoModoEntradaTerminal: ").Append(CodigoModoEntradaTerminal).Append("\n");
            sb.Append("  DescricaoModoEntradaTerminal: ").Append(DescricaoModoEntradaTerminal).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  Cnpj: ").Append(Cnpj).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Telefones: ").Append(Telefones).Append("\n");
            
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
            return this.Equals(obj as RiscoFraudeDetalhadoResponse);
        }

        /// <summary>
        /// Returns true if RiscoFraudeDetalhadoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of RiscoFraudeDetalhadoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RiscoFraudeDetalhadoResponse other)
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
                    this.IdTipoResolucao == other.IdTipoResolucao ||
                    this.IdTipoResolucao != null &&
                    this.IdTipoResolucao.Equals(other.IdTipoResolucao)
                ) && 
                (
                    this.DescricaoTipoResolucao == other.DescricaoTipoResolucao ||
                    this.DescricaoTipoResolucao != null &&
                    this.DescricaoTipoResolucao.Equals(other.DescricaoTipoResolucao)
                ) && 
                (
                    this.FlagAltoRisco == other.FlagAltoRisco ||
                    this.FlagAltoRisco != null &&
                    this.FlagAltoRisco.Equals(other.FlagAltoRisco)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.IdTransacao == other.IdTransacao ||
                    this.IdTransacao != null &&
                    this.IdTransacao.Equals(other.IdTransacao)
                ) && 
                (
                    this.DataTransacao == other.DataTransacao ||
                    this.DataTransacao != null &&
                    this.DataTransacao.Equals(other.DataTransacao)
                ) && 
                (
                    this.ValorTransacao == other.ValorTransacao ||
                    this.ValorTransacao != null &&
                    this.ValorTransacao.Equals(other.ValorTransacao)
                ) && 
                (
                    this.CodigoMoedaOrigem == other.CodigoMoedaOrigem ||
                    this.CodigoMoedaOrigem != null &&
                    this.CodigoMoedaOrigem.Equals(other.CodigoMoedaOrigem)
                ) && 
                (
                    this.ValorOrigem == other.ValorOrigem ||
                    this.ValorOrigem != null &&
                    this.ValorOrigem.Equals(other.ValorOrigem)
                ) && 
                (
                    this.CodigoMoedaDestino == other.CodigoMoedaDestino ||
                    this.CodigoMoedaDestino != null &&
                    this.CodigoMoedaDestino.Equals(other.CodigoMoedaDestino)
                ) && 
                (
                    this.ValorDestino == other.ValorDestino ||
                    this.ValorDestino != null &&
                    this.ValorDestino.Equals(other.ValorDestino)
                ) && 
                (
                    this.NomeEstabelecimento == other.NomeEstabelecimento ||
                    this.NomeEstabelecimento != null &&
                    this.NomeEstabelecimento.Equals(other.NomeEstabelecimento)
                ) && 
                (
                    this.IdPais == other.IdPais ||
                    this.IdPais != null &&
                    this.IdPais.Equals(other.IdPais)
                ) && 
                (
                    this.CodigoRespostaAutorizador == other.CodigoRespostaAutorizador ||
                    this.CodigoRespostaAutorizador != null &&
                    this.CodigoRespostaAutorizador.Equals(other.CodigoRespostaAutorizador)
                ) && 
                (
                    this.DescricaoRespostaAutorizador == other.DescricaoRespostaAutorizador ||
                    this.DescricaoRespostaAutorizador != null &&
                    this.DescricaoRespostaAutorizador.Equals(other.DescricaoRespostaAutorizador)
                ) && 
                (
                    this.CodigoRespostaFraude == other.CodigoRespostaFraude ||
                    this.CodigoRespostaFraude != null &&
                    this.CodigoRespostaFraude.Equals(other.CodigoRespostaFraude)
                ) && 
                (
                    this.DescricaoRespostaFraude == other.DescricaoRespostaFraude ||
                    this.DescricaoRespostaFraude != null &&
                    this.DescricaoRespostaFraude.Equals(other.DescricaoRespostaFraude)
                ) && 
                (
                    this.OrigemTransacao == other.OrigemTransacao ||
                    this.OrigemTransacao != null &&
                    this.OrigemTransacao.Equals(other.OrigemTransacao)
                ) && 
                (
                    this.CodigoModoEntradaTerminal == other.CodigoModoEntradaTerminal ||
                    this.CodigoModoEntradaTerminal != null &&
                    this.CodigoModoEntradaTerminal.Equals(other.CodigoModoEntradaTerminal)
                ) && 
                (
                    this.DescricaoModoEntradaTerminal == other.DescricaoModoEntradaTerminal ||
                    this.DescricaoModoEntradaTerminal != null &&
                    this.DescricaoModoEntradaTerminal.Equals(other.DescricaoModoEntradaTerminal)
                ) && 
                (
                    this.Cpf == other.Cpf ||
                    this.Cpf != null &&
                    this.Cpf.Equals(other.Cpf)
                ) && 
                (
                    this.Cnpj == other.Cnpj ||
                    this.Cnpj != null &&
                    this.Cnpj.Equals(other.Cnpj)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Telefones == other.Telefones ||
                    this.Telefones != null &&
                    this.Telefones.SequenceEqual(other.Telefones)
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
                
                if (this.IdTipoResolucao != null)
                    hash = hash * 59 + this.IdTipoResolucao.GetHashCode();
                
                if (this.DescricaoTipoResolucao != null)
                    hash = hash * 59 + this.DescricaoTipoResolucao.GetHashCode();
                
                if (this.FlagAltoRisco != null)
                    hash = hash * 59 + this.FlagAltoRisco.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.IdTransacao != null)
                    hash = hash * 59 + this.IdTransacao.GetHashCode();
                
                if (this.DataTransacao != null)
                    hash = hash * 59 + this.DataTransacao.GetHashCode();
                
                if (this.ValorTransacao != null)
                    hash = hash * 59 + this.ValorTransacao.GetHashCode();
                
                if (this.CodigoMoedaOrigem != null)
                    hash = hash * 59 + this.CodigoMoedaOrigem.GetHashCode();
                
                if (this.ValorOrigem != null)
                    hash = hash * 59 + this.ValorOrigem.GetHashCode();
                
                if (this.CodigoMoedaDestino != null)
                    hash = hash * 59 + this.CodigoMoedaDestino.GetHashCode();
                
                if (this.ValorDestino != null)
                    hash = hash * 59 + this.ValorDestino.GetHashCode();
                
                if (this.NomeEstabelecimento != null)
                    hash = hash * 59 + this.NomeEstabelecimento.GetHashCode();
                
                if (this.IdPais != null)
                    hash = hash * 59 + this.IdPais.GetHashCode();
                
                if (this.CodigoRespostaAutorizador != null)
                    hash = hash * 59 + this.CodigoRespostaAutorizador.GetHashCode();
                
                if (this.DescricaoRespostaAutorizador != null)
                    hash = hash * 59 + this.DescricaoRespostaAutorizador.GetHashCode();
                
                if (this.CodigoRespostaFraude != null)
                    hash = hash * 59 + this.CodigoRespostaFraude.GetHashCode();
                
                if (this.DescricaoRespostaFraude != null)
                    hash = hash * 59 + this.DescricaoRespostaFraude.GetHashCode();
                
                if (this.OrigemTransacao != null)
                    hash = hash * 59 + this.OrigemTransacao.GetHashCode();
                
                if (this.CodigoModoEntradaTerminal != null)
                    hash = hash * 59 + this.CodigoModoEntradaTerminal.GetHashCode();
                
                if (this.DescricaoModoEntradaTerminal != null)
                    hash = hash * 59 + this.DescricaoModoEntradaTerminal.GetHashCode();
                
                if (this.Cpf != null)
                    hash = hash * 59 + this.Cpf.GetHashCode();
                
                if (this.Cnpj != null)
                    hash = hash * 59 + this.Cnpj.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.Telefones != null)
                    hash = hash * 59 + this.Telefones.GetHashCode();
                
                return hash;
            }
        }

    }
}
