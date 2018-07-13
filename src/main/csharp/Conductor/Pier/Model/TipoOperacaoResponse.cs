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
    /// {{{tipo_operacao_response_description}}}
    /// </summary>
    [DataContract]
    public partial class TipoOperacaoResponse :  IEquatable<TipoOperacaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoOperacaoResponse" /> class.
        /// Initializes a new instance of the <see cref="TipoOperacaoResponse" />class.
        /// </summary>
        /// <param name="Id">{{{tipo_operacao_response_id_value}}} (required).</param>
        /// <param name="TipoOperacao">{{{tipo_operacao_response_tipo_operacao_value}}} (required).</param>
        /// <param name="Nome">{{{tipo_operacao_response_nome_value}}} (required).</param>
        /// <param name="Descricao">{{{tipo_operacao_response_descricao_value}}} (required).</param>
        /// <param name="ExcedentePermitido">{{{tipo_operacao_response_excedente_permitido_value}}}.</param>
        /// <param name="TipoExcedentePermitido">{{{tipo_operacao_response_tipo_excedente_permitido_value}}}.</param>
        /// <param name="ValorMinimo">{{{tipo_operacao_response_valor_minimo_value}}} (required).</param>
        /// <param name="ValorMaximo">{{{tipo_operacao_response_valor_maximo_value}}} (required).</param>
        /// <param name="ValorTAC">{{{tipo_operacao_response_valor_t_a_c_value}}}.</param>
        /// <param name="FlagTiraTac">{{{tipo_operacao_response_flag_tira_tac_value}}}.</param>
        /// <param name="IdProduto">{{{tipo_operacao_response_id_produto_value}}} (required).</param>
        /// <param name="IdEstabelecimento">{{{tipo_operacao_response_id_estabelecimento_value}}} (required).</param>
        /// <param name="Tarifa">{{{tipo_operacao_response_tarifa_value}}}.</param>
        /// <param name="RemuneracaoEmissor">{{{tipo_operacao_response_remuneracao_emissor_value}}}.</param>
        /// <param name="PlanoMaximo">{{{tipo_operacao_response_plano_maximo_value}}} (required).</param>
        /// <param name="PlanoMinimo">{{{tipo_operacao_response_plano_minimo_value}}} (required).</param>

        public TipoOperacaoResponse(long? Id = null, string TipoOperacao = null, string Nome = null, string Descricao = null, double? ExcedentePermitido = null, string TipoExcedentePermitido = null, double? ValorMinimo = null, double? ValorMaximo = null, double? ValorTAC = null, int? FlagTiraTac = null, long? IdProduto = null, long? IdEstabelecimento = null, double? Tarifa = null, double? RemuneracaoEmissor = null, int? PlanoMaximo = null, int? PlanoMinimo = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for TipoOperacaoResponse and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "TipoOperacao" is required (not null)
            if (TipoOperacao == null)
            {
                throw new InvalidDataException("TipoOperacao is a required property for TipoOperacaoResponse and cannot be null");
            }
            else
            {
                this.TipoOperacao = TipoOperacao;
            }
            // to ensure "Nome" is required (not null)
            if (Nome == null)
            {
                throw new InvalidDataException("Nome is a required property for TipoOperacaoResponse and cannot be null");
            }
            else
            {
                this.Nome = Nome;
            }
            // to ensure "Descricao" is required (not null)
            if (Descricao == null)
            {
                throw new InvalidDataException("Descricao is a required property for TipoOperacaoResponse and cannot be null");
            }
            else
            {
                this.Descricao = Descricao;
            }
            // to ensure "ValorMinimo" is required (not null)
            if (ValorMinimo == null)
            {
                throw new InvalidDataException("ValorMinimo is a required property for TipoOperacaoResponse and cannot be null");
            }
            else
            {
                this.ValorMinimo = ValorMinimo;
            }
            // to ensure "ValorMaximo" is required (not null)
            if (ValorMaximo == null)
            {
                throw new InvalidDataException("ValorMaximo is a required property for TipoOperacaoResponse and cannot be null");
            }
            else
            {
                this.ValorMaximo = ValorMaximo;
            }
            // to ensure "IdProduto" is required (not null)
            if (IdProduto == null)
            {
                throw new InvalidDataException("IdProduto is a required property for TipoOperacaoResponse and cannot be null");
            }
            else
            {
                this.IdProduto = IdProduto;
            }
            // to ensure "IdEstabelecimento" is required (not null)
            if (IdEstabelecimento == null)
            {
                throw new InvalidDataException("IdEstabelecimento is a required property for TipoOperacaoResponse and cannot be null");
            }
            else
            {
                this.IdEstabelecimento = IdEstabelecimento;
            }
            // to ensure "PlanoMaximo" is required (not null)
            if (PlanoMaximo == null)
            {
                throw new InvalidDataException("PlanoMaximo is a required property for TipoOperacaoResponse and cannot be null");
            }
            else
            {
                this.PlanoMaximo = PlanoMaximo;
            }
            // to ensure "PlanoMinimo" is required (not null)
            if (PlanoMinimo == null)
            {
                throw new InvalidDataException("PlanoMinimo is a required property for TipoOperacaoResponse and cannot be null");
            }
            else
            {
                this.PlanoMinimo = PlanoMinimo;
            }
            this.ExcedentePermitido = ExcedentePermitido;
            this.TipoExcedentePermitido = TipoExcedentePermitido;
            this.ValorTAC = ValorTAC;
            this.FlagTiraTac = FlagTiraTac;
            this.Tarifa = Tarifa;
            this.RemuneracaoEmissor = RemuneracaoEmissor;
            
        }
        
    
        /// <summary>
        /// {{{tipo_operacao_response_id_value}}}
        /// </summary>
        /// <value>{{{tipo_operacao_response_id_value}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{tipo_operacao_response_tipo_operacao_value}}}
        /// </summary>
        /// <value>{{{tipo_operacao_response_tipo_operacao_value}}}</value>
        [DataMember(Name="tipoOperacao", EmitDefaultValue=false)]
        public string TipoOperacao { get; set; }
    
        /// <summary>
        /// {{{tipo_operacao_response_nome_value}}}
        /// </summary>
        /// <value>{{{tipo_operacao_response_nome_value}}}</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// {{{tipo_operacao_response_descricao_value}}}
        /// </summary>
        /// <value>{{{tipo_operacao_response_descricao_value}}}</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// {{{tipo_operacao_response_excedente_permitido_value}}}
        /// </summary>
        /// <value>{{{tipo_operacao_response_excedente_permitido_value}}}</value>
        [DataMember(Name="excedentePermitido", EmitDefaultValue=false)]
        public double? ExcedentePermitido { get; set; }
    
        /// <summary>
        /// {{{tipo_operacao_response_tipo_excedente_permitido_value}}}
        /// </summary>
        /// <value>{{{tipo_operacao_response_tipo_excedente_permitido_value}}}</value>
        [DataMember(Name="tipoExcedentePermitido", EmitDefaultValue=false)]
        public string TipoExcedentePermitido { get; set; }
    
        /// <summary>
        /// {{{tipo_operacao_response_valor_minimo_value}}}
        /// </summary>
        /// <value>{{{tipo_operacao_response_valor_minimo_value}}}</value>
        [DataMember(Name="valorMinimo", EmitDefaultValue=false)]
        public double? ValorMinimo { get; set; }
    
        /// <summary>
        /// {{{tipo_operacao_response_valor_maximo_value}}}
        /// </summary>
        /// <value>{{{tipo_operacao_response_valor_maximo_value}}}</value>
        [DataMember(Name="valorMaximo", EmitDefaultValue=false)]
        public double? ValorMaximo { get; set; }
    
        /// <summary>
        /// {{{tipo_operacao_response_valor_t_a_c_value}}}
        /// </summary>
        /// <value>{{{tipo_operacao_response_valor_t_a_c_value}}}</value>
        [DataMember(Name="valorTAC", EmitDefaultValue=false)]
        public double? ValorTAC { get; set; }
    
        /// <summary>
        /// {{{tipo_operacao_response_flag_tira_tac_value}}}
        /// </summary>
        /// <value>{{{tipo_operacao_response_flag_tira_tac_value}}}</value>
        [DataMember(Name="flagTiraTac", EmitDefaultValue=false)]
        public int? FlagTiraTac { get; set; }
    
        /// <summary>
        /// {{{tipo_operacao_response_id_produto_value}}}
        /// </summary>
        /// <value>{{{tipo_operacao_response_id_produto_value}}}</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// {{{tipo_operacao_response_id_estabelecimento_value}}}
        /// </summary>
        /// <value>{{{tipo_operacao_response_id_estabelecimento_value}}}</value>
        [DataMember(Name="idEstabelecimento", EmitDefaultValue=false)]
        public long? IdEstabelecimento { get; set; }
    
        /// <summary>
        /// {{{tipo_operacao_response_tarifa_value}}}
        /// </summary>
        /// <value>{{{tipo_operacao_response_tarifa_value}}}</value>
        [DataMember(Name="tarifa", EmitDefaultValue=false)]
        public double? Tarifa { get; set; }
    
        /// <summary>
        /// {{{tipo_operacao_response_remuneracao_emissor_value}}}
        /// </summary>
        /// <value>{{{tipo_operacao_response_remuneracao_emissor_value}}}</value>
        [DataMember(Name="remuneracaoEmissor", EmitDefaultValue=false)]
        public double? RemuneracaoEmissor { get; set; }
    
        /// <summary>
        /// {{{tipo_operacao_response_plano_maximo_value}}}
        /// </summary>
        /// <value>{{{tipo_operacao_response_plano_maximo_value}}}</value>
        [DataMember(Name="planoMaximo", EmitDefaultValue=false)]
        public int? PlanoMaximo { get; set; }
    
        /// <summary>
        /// {{{tipo_operacao_response_plano_minimo_value}}}
        /// </summary>
        /// <value>{{{tipo_operacao_response_plano_minimo_value}}}</value>
        [DataMember(Name="planoMinimo", EmitDefaultValue=false)]
        public int? PlanoMinimo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoOperacaoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TipoOperacao: ").Append(TipoOperacao).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  ExcedentePermitido: ").Append(ExcedentePermitido).Append("\n");
            sb.Append("  TipoExcedentePermitido: ").Append(TipoExcedentePermitido).Append("\n");
            sb.Append("  ValorMinimo: ").Append(ValorMinimo).Append("\n");
            sb.Append("  ValorMaximo: ").Append(ValorMaximo).Append("\n");
            sb.Append("  ValorTAC: ").Append(ValorTAC).Append("\n");
            sb.Append("  FlagTiraTac: ").Append(FlagTiraTac).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  IdEstabelecimento: ").Append(IdEstabelecimento).Append("\n");
            sb.Append("  Tarifa: ").Append(Tarifa).Append("\n");
            sb.Append("  RemuneracaoEmissor: ").Append(RemuneracaoEmissor).Append("\n");
            sb.Append("  PlanoMaximo: ").Append(PlanoMaximo).Append("\n");
            sb.Append("  PlanoMinimo: ").Append(PlanoMinimo).Append("\n");
            
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
            return this.Equals(obj as TipoOperacaoResponse);
        }

        /// <summary>
        /// Returns true if TipoOperacaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoOperacaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoOperacaoResponse other)
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
                    this.TipoOperacao == other.TipoOperacao ||
                    this.TipoOperacao != null &&
                    this.TipoOperacao.Equals(other.TipoOperacao)
                ) && 
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
                    this.ExcedentePermitido == other.ExcedentePermitido ||
                    this.ExcedentePermitido != null &&
                    this.ExcedentePermitido.Equals(other.ExcedentePermitido)
                ) && 
                (
                    this.TipoExcedentePermitido == other.TipoExcedentePermitido ||
                    this.TipoExcedentePermitido != null &&
                    this.TipoExcedentePermitido.Equals(other.TipoExcedentePermitido)
                ) && 
                (
                    this.ValorMinimo == other.ValorMinimo ||
                    this.ValorMinimo != null &&
                    this.ValorMinimo.Equals(other.ValorMinimo)
                ) && 
                (
                    this.ValorMaximo == other.ValorMaximo ||
                    this.ValorMaximo != null &&
                    this.ValorMaximo.Equals(other.ValorMaximo)
                ) && 
                (
                    this.ValorTAC == other.ValorTAC ||
                    this.ValorTAC != null &&
                    this.ValorTAC.Equals(other.ValorTAC)
                ) && 
                (
                    this.FlagTiraTac == other.FlagTiraTac ||
                    this.FlagTiraTac != null &&
                    this.FlagTiraTac.Equals(other.FlagTiraTac)
                ) && 
                (
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.IdEstabelecimento == other.IdEstabelecimento ||
                    this.IdEstabelecimento != null &&
                    this.IdEstabelecimento.Equals(other.IdEstabelecimento)
                ) && 
                (
                    this.Tarifa == other.Tarifa ||
                    this.Tarifa != null &&
                    this.Tarifa.Equals(other.Tarifa)
                ) && 
                (
                    this.RemuneracaoEmissor == other.RemuneracaoEmissor ||
                    this.RemuneracaoEmissor != null &&
                    this.RemuneracaoEmissor.Equals(other.RemuneracaoEmissor)
                ) && 
                (
                    this.PlanoMaximo == other.PlanoMaximo ||
                    this.PlanoMaximo != null &&
                    this.PlanoMaximo.Equals(other.PlanoMaximo)
                ) && 
                (
                    this.PlanoMinimo == other.PlanoMinimo ||
                    this.PlanoMinimo != null &&
                    this.PlanoMinimo.Equals(other.PlanoMinimo)
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
                
                if (this.TipoOperacao != null)
                    hash = hash * 59 + this.TipoOperacao.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.ExcedentePermitido != null)
                    hash = hash * 59 + this.ExcedentePermitido.GetHashCode();
                
                if (this.TipoExcedentePermitido != null)
                    hash = hash * 59 + this.TipoExcedentePermitido.GetHashCode();
                
                if (this.ValorMinimo != null)
                    hash = hash * 59 + this.ValorMinimo.GetHashCode();
                
                if (this.ValorMaximo != null)
                    hash = hash * 59 + this.ValorMaximo.GetHashCode();
                
                if (this.ValorTAC != null)
                    hash = hash * 59 + this.ValorTAC.GetHashCode();
                
                if (this.FlagTiraTac != null)
                    hash = hash * 59 + this.FlagTiraTac.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.IdEstabelecimento != null)
                    hash = hash * 59 + this.IdEstabelecimento.GetHashCode();
                
                if (this.Tarifa != null)
                    hash = hash * 59 + this.Tarifa.GetHashCode();
                
                if (this.RemuneracaoEmissor != null)
                    hash = hash * 59 + this.RemuneracaoEmissor.GetHashCode();
                
                if (this.PlanoMaximo != null)
                    hash = hash * 59 + this.PlanoMaximo.GetHashCode();
                
                if (this.PlanoMinimo != null)
                    hash = hash * 59 + this.PlanoMinimo.GetHashCode();
                
                return hash;
            }
        }

    }
}
