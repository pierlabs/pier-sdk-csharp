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
    /// {{{celular_recarga_programada_resposta_descricao}}}
    /// </summary>
    [DataContract]
    public partial class CelularRecargaProgramadaResponse :  IEquatable<CelularRecargaProgramadaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CelularRecargaProgramadaResponse" /> class.
        /// Initializes a new instance of the <see cref="CelularRecargaProgramadaResponse" />class.
        /// </summary>
        /// <param name="CodigoOperadora">{{{celular_recarga_programada_resposta_codigo_operadora_descricao}}}.</param>
        /// <param name="CodigoProduto">{{{celular_recarga_programada_resposta_codigo_produto_descricao}}}.</param>
        /// <param name="FlagGeraTarifa">{{{celular_recarga_programada_resposta_flag_gera_tarifa_descricao}}}.</param>
        /// <param name="Id">{{{celular_recarga_programada_resposta_id_recarga_programada_descricao}}}.</param>
        /// <param name="IdCartao">{{{celular_recarga_programada_resposta_id_cartao_descricao}}}.</param>
        /// <param name="IdCelularRecarga">{{{celular_recarga_programada_resposta_id_celular_recarga_descricao}}}.</param>
        /// <param name="IdConta">{{{celular_recarga_programada_resposta_id_conta_descricao}}}.</param>
        /// <param name="IdDescricaoTipoRecargaProgramada">{{{celular_recarga_programada_resposta_id_descricao_tipo_recarga_programada_descricao}}}.</param>
        /// <param name="IdOrigemComercial">{{{celular_recarga_programada_resposta_id_origem_comercial_descricao}}}.</param>
        /// <param name="IdProposta">{{{celular_recarga_programada_resposta_id_proposta_descricao}}}.</param>
        /// <param name="IdUsuarioRecarga">{{{celular_recarga_programada_resposta_id_usuario_recarga_descricao}}}.</param>
        /// <param name="IdiPlataforma">{{{celular_recarga_programada_resposta_id_plataforma_descricao}}}.</param>
        /// <param name="MotivoCancelamento">{{{celular_recarga_programada_resposta_motivo_cancelamento_descricao}}}.</param>
        /// <param name="Valor">{{{celular_recarga_programada_resposta_valor_descricao}}}.</param>

        public CelularRecargaProgramadaResponse(long? CodigoOperadora = null, long? CodigoProduto = null, bool? FlagGeraTarifa = null, long? Id = null, long? IdCartao = null, long? IdCelularRecarga = null, long? IdConta = null, long? IdDescricaoTipoRecargaProgramada = null, long? IdOrigemComercial = null, long? IdProposta = null, long? IdUsuarioRecarga = null, long? IdiPlataforma = null, long? MotivoCancelamento = null, double? Valor = null)
        {
            this.CodigoOperadora = CodigoOperadora;
            this.CodigoProduto = CodigoProduto;
            this.FlagGeraTarifa = FlagGeraTarifa;
            this.Id = Id;
            this.IdCartao = IdCartao;
            this.IdCelularRecarga = IdCelularRecarga;
            this.IdConta = IdConta;
            this.IdDescricaoTipoRecargaProgramada = IdDescricaoTipoRecargaProgramada;
            this.IdOrigemComercial = IdOrigemComercial;
            this.IdProposta = IdProposta;
            this.IdUsuarioRecarga = IdUsuarioRecarga;
            this.IdiPlataforma = IdiPlataforma;
            this.MotivoCancelamento = MotivoCancelamento;
            this.Valor = Valor;
            
        }
        
    
        /// <summary>
        /// {{{celular_recarga_programada_resposta_codigo_operadora_descricao}}}
        /// </summary>
        /// <value>{{{celular_recarga_programada_resposta_codigo_operadora_descricao}}}</value>
        [DataMember(Name="codigoOperadora", EmitDefaultValue=false)]
        public long? CodigoOperadora { get; set; }
    
        /// <summary>
        /// {{{celular_recarga_programada_resposta_codigo_produto_descricao}}}
        /// </summary>
        /// <value>{{{celular_recarga_programada_resposta_codigo_produto_descricao}}}</value>
        [DataMember(Name="codigoProduto", EmitDefaultValue=false)]
        public long? CodigoProduto { get; set; }
    
        /// <summary>
        /// {{{celular_recarga_programada_resposta_flag_gera_tarifa_descricao}}}
        /// </summary>
        /// <value>{{{celular_recarga_programada_resposta_flag_gera_tarifa_descricao}}}</value>
        [DataMember(Name="flagGeraTarifa", EmitDefaultValue=false)]
        public bool? FlagGeraTarifa { get; set; }
    
        /// <summary>
        /// {{{celular_recarga_programada_resposta_id_recarga_programada_descricao}}}
        /// </summary>
        /// <value>{{{celular_recarga_programada_resposta_id_recarga_programada_descricao}}}</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// {{{celular_recarga_programada_resposta_id_cartao_descricao}}}
        /// </summary>
        /// <value>{{{celular_recarga_programada_resposta_id_cartao_descricao}}}</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// {{{celular_recarga_programada_resposta_id_celular_recarga_descricao}}}
        /// </summary>
        /// <value>{{{celular_recarga_programada_resposta_id_celular_recarga_descricao}}}</value>
        [DataMember(Name="idCelularRecarga", EmitDefaultValue=false)]
        public long? IdCelularRecarga { get; set; }
    
        /// <summary>
        /// {{{celular_recarga_programada_resposta_id_conta_descricao}}}
        /// </summary>
        /// <value>{{{celular_recarga_programada_resposta_id_conta_descricao}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{celular_recarga_programada_resposta_id_descricao_tipo_recarga_programada_descricao}}}
        /// </summary>
        /// <value>{{{celular_recarga_programada_resposta_id_descricao_tipo_recarga_programada_descricao}}}</value>
        [DataMember(Name="idDescricaoTipoRecargaProgramada", EmitDefaultValue=false)]
        public long? IdDescricaoTipoRecargaProgramada { get; set; }
    
        /// <summary>
        /// {{{celular_recarga_programada_resposta_id_origem_comercial_descricao}}}
        /// </summary>
        /// <value>{{{celular_recarga_programada_resposta_id_origem_comercial_descricao}}}</value>
        [DataMember(Name="idOrigemComercial", EmitDefaultValue=false)]
        public long? IdOrigemComercial { get; set; }
    
        /// <summary>
        /// {{{celular_recarga_programada_resposta_id_proposta_descricao}}}
        /// </summary>
        /// <value>{{{celular_recarga_programada_resposta_id_proposta_descricao}}}</value>
        [DataMember(Name="idProposta", EmitDefaultValue=false)]
        public long? IdProposta { get; set; }
    
        /// <summary>
        /// {{{celular_recarga_programada_resposta_id_usuario_recarga_descricao}}}
        /// </summary>
        /// <value>{{{celular_recarga_programada_resposta_id_usuario_recarga_descricao}}}</value>
        [DataMember(Name="idUsuarioRecarga", EmitDefaultValue=false)]
        public long? IdUsuarioRecarga { get; set; }
    
        /// <summary>
        /// {{{celular_recarga_programada_resposta_id_plataforma_descricao}}}
        /// </summary>
        /// <value>{{{celular_recarga_programada_resposta_id_plataforma_descricao}}}</value>
        [DataMember(Name="idiPlataforma", EmitDefaultValue=false)]
        public long? IdiPlataforma { get; set; }
    
        /// <summary>
        /// {{{celular_recarga_programada_resposta_motivo_cancelamento_descricao}}}
        /// </summary>
        /// <value>{{{celular_recarga_programada_resposta_motivo_cancelamento_descricao}}}</value>
        [DataMember(Name="motivoCancelamento", EmitDefaultValue=false)]
        public long? MotivoCancelamento { get; set; }
    
        /// <summary>
        /// {{{celular_recarga_programada_resposta_valor_descricao}}}
        /// </summary>
        /// <value>{{{celular_recarga_programada_resposta_valor_descricao}}}</value>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CelularRecargaProgramadaResponse {\n");
            sb.Append("  CodigoOperadora: ").Append(CodigoOperadora).Append("\n");
            sb.Append("  CodigoProduto: ").Append(CodigoProduto).Append("\n");
            sb.Append("  FlagGeraTarifa: ").Append(FlagGeraTarifa).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  IdCelularRecarga: ").Append(IdCelularRecarga).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdDescricaoTipoRecargaProgramada: ").Append(IdDescricaoTipoRecargaProgramada).Append("\n");
            sb.Append("  IdOrigemComercial: ").Append(IdOrigemComercial).Append("\n");
            sb.Append("  IdProposta: ").Append(IdProposta).Append("\n");
            sb.Append("  IdUsuarioRecarga: ").Append(IdUsuarioRecarga).Append("\n");
            sb.Append("  IdiPlataforma: ").Append(IdiPlataforma).Append("\n");
            sb.Append("  MotivoCancelamento: ").Append(MotivoCancelamento).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            
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
            return this.Equals(obj as CelularRecargaProgramadaResponse);
        }

        /// <summary>
        /// Returns true if CelularRecargaProgramadaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CelularRecargaProgramadaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CelularRecargaProgramadaResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CodigoOperadora == other.CodigoOperadora ||
                    this.CodigoOperadora != null &&
                    this.CodigoOperadora.Equals(other.CodigoOperadora)
                ) && 
                (
                    this.CodigoProduto == other.CodigoProduto ||
                    this.CodigoProduto != null &&
                    this.CodigoProduto.Equals(other.CodigoProduto)
                ) && 
                (
                    this.FlagGeraTarifa == other.FlagGeraTarifa ||
                    this.FlagGeraTarifa != null &&
                    this.FlagGeraTarifa.Equals(other.FlagGeraTarifa)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.IdCelularRecarga == other.IdCelularRecarga ||
                    this.IdCelularRecarga != null &&
                    this.IdCelularRecarga.Equals(other.IdCelularRecarga)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdDescricaoTipoRecargaProgramada == other.IdDescricaoTipoRecargaProgramada ||
                    this.IdDescricaoTipoRecargaProgramada != null &&
                    this.IdDescricaoTipoRecargaProgramada.Equals(other.IdDescricaoTipoRecargaProgramada)
                ) && 
                (
                    this.IdOrigemComercial == other.IdOrigemComercial ||
                    this.IdOrigemComercial != null &&
                    this.IdOrigemComercial.Equals(other.IdOrigemComercial)
                ) && 
                (
                    this.IdProposta == other.IdProposta ||
                    this.IdProposta != null &&
                    this.IdProposta.Equals(other.IdProposta)
                ) && 
                (
                    this.IdUsuarioRecarga == other.IdUsuarioRecarga ||
                    this.IdUsuarioRecarga != null &&
                    this.IdUsuarioRecarga.Equals(other.IdUsuarioRecarga)
                ) && 
                (
                    this.IdiPlataforma == other.IdiPlataforma ||
                    this.IdiPlataforma != null &&
                    this.IdiPlataforma.Equals(other.IdiPlataforma)
                ) && 
                (
                    this.MotivoCancelamento == other.MotivoCancelamento ||
                    this.MotivoCancelamento != null &&
                    this.MotivoCancelamento.Equals(other.MotivoCancelamento)
                ) && 
                (
                    this.Valor == other.Valor ||
                    this.Valor != null &&
                    this.Valor.Equals(other.Valor)
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
                
                if (this.CodigoOperadora != null)
                    hash = hash * 59 + this.CodigoOperadora.GetHashCode();
                
                if (this.CodigoProduto != null)
                    hash = hash * 59 + this.CodigoProduto.GetHashCode();
                
                if (this.FlagGeraTarifa != null)
                    hash = hash * 59 + this.FlagGeraTarifa.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.IdCelularRecarga != null)
                    hash = hash * 59 + this.IdCelularRecarga.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdDescricaoTipoRecargaProgramada != null)
                    hash = hash * 59 + this.IdDescricaoTipoRecargaProgramada.GetHashCode();
                
                if (this.IdOrigemComercial != null)
                    hash = hash * 59 + this.IdOrigemComercial.GetHashCode();
                
                if (this.IdProposta != null)
                    hash = hash * 59 + this.IdProposta.GetHashCode();
                
                if (this.IdUsuarioRecarga != null)
                    hash = hash * 59 + this.IdUsuarioRecarga.GetHashCode();
                
                if (this.IdiPlataforma != null)
                    hash = hash * 59 + this.IdiPlataforma.GetHashCode();
                
                if (this.MotivoCancelamento != null)
                    hash = hash * 59 + this.MotivoCancelamento.GetHashCode();
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
                return hash;
            }
        }

    }
}
