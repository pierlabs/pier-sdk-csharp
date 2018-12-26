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
    /// {{{celular_recarga_programada_persistencia_descricao}}}
    /// </summary>
    [DataContract]
    public partial class CelularRecargaProgramadaPersist :  IEquatable<CelularRecargaProgramadaPersist>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CelularRecargaProgramadaPersist" /> class.
        /// Initializes a new instance of the <see cref="CelularRecargaProgramadaPersist" />class.
        /// </summary>
        /// <param name="IdCartao">{{{celular_recarga_programada_persistencia_id_cartao_descricao}}} (required).</param>
        /// <param name="IdUsuarioRecarga">{{{celular_recarga_programada_persistencia_id_usuario_recarga_descricao}}}.</param>
        /// <param name="IdDescricaoTipoRecargaProgramada">{{{celular_recarga_programada_persistencia_id_descricao_tipo_recarga_programada_descricao}}} (required).</param>
        /// <param name="CodigoProduto">{{{celular_recarga_programada_persistencia_codigo_produto_descricao}}} (required).</param>
        /// <param name="CodigoOperadora">{{{celular_recarga_programada_persistencia_codigo_operadora_descricao}}} (required).</param>
        /// <param name="Valor">{{{celular_recarga_programada_persistencia_valor_descricao}}} (required).</param>
        /// <param name="IdPlataforma">{{{celular_recarga_programada_persistencia_id_plataforma_descricao}}}.</param>
        /// <param name="FlagGeraTarifa">{{{celular_recarga_programada_persistencia_flag_gera_tarifa_descricao}}} (required).</param>
        /// <param name="IdProposta">{{{celular_recarga_programada_persistencia_id_proposta_descricao}}}.</param>
        /// <param name="IdOrigemComercial">{{{celular_recarga_programada_persistencia_id_origem_comercial_descricao}}} (required).</param>
        /// <param name="DddCelularRecarga">{{{celular_recarga_programada_persistencia_ddd_celular_recarga_descricao}}} (required).</param>
        /// <param name="NumeroCelularRecarga">{{{celular_recarga_programada_persistencia_numero_celular_recarga_descricao}}} (required).</param>

        public CelularRecargaProgramadaPersist(long? IdCartao = null, long? IdUsuarioRecarga = null, long? IdDescricaoTipoRecargaProgramada = null, long? CodigoProduto = null, long? CodigoOperadora = null, double? Valor = null, long? IdPlataforma = null, bool? FlagGeraTarifa = null, long? IdProposta = null, long? IdOrigemComercial = null, string DddCelularRecarga = null, string NumeroCelularRecarga = null)
        {
            // to ensure "IdCartao" is required (not null)
            if (IdCartao == null)
            {
                throw new InvalidDataException("IdCartao is a required property for CelularRecargaProgramadaPersist and cannot be null");
            }
            else
            {
                this.IdCartao = IdCartao;
            }
            // to ensure "IdDescricaoTipoRecargaProgramada" is required (not null)
            if (IdDescricaoTipoRecargaProgramada == null)
            {
                throw new InvalidDataException("IdDescricaoTipoRecargaProgramada is a required property for CelularRecargaProgramadaPersist and cannot be null");
            }
            else
            {
                this.IdDescricaoTipoRecargaProgramada = IdDescricaoTipoRecargaProgramada;
            }
            // to ensure "CodigoProduto" is required (not null)
            if (CodigoProduto == null)
            {
                throw new InvalidDataException("CodigoProduto is a required property for CelularRecargaProgramadaPersist and cannot be null");
            }
            else
            {
                this.CodigoProduto = CodigoProduto;
            }
            // to ensure "CodigoOperadora" is required (not null)
            if (CodigoOperadora == null)
            {
                throw new InvalidDataException("CodigoOperadora is a required property for CelularRecargaProgramadaPersist and cannot be null");
            }
            else
            {
                this.CodigoOperadora = CodigoOperadora;
            }
            // to ensure "Valor" is required (not null)
            if (Valor == null)
            {
                throw new InvalidDataException("Valor is a required property for CelularRecargaProgramadaPersist and cannot be null");
            }
            else
            {
                this.Valor = Valor;
            }
            // to ensure "FlagGeraTarifa" is required (not null)
            if (FlagGeraTarifa == null)
            {
                throw new InvalidDataException("FlagGeraTarifa is a required property for CelularRecargaProgramadaPersist and cannot be null");
            }
            else
            {
                this.FlagGeraTarifa = FlagGeraTarifa;
            }
            // to ensure "IdOrigemComercial" is required (not null)
            if (IdOrigemComercial == null)
            {
                throw new InvalidDataException("IdOrigemComercial is a required property for CelularRecargaProgramadaPersist and cannot be null");
            }
            else
            {
                this.IdOrigemComercial = IdOrigemComercial;
            }
            // to ensure "DddCelularRecarga" is required (not null)
            if (DddCelularRecarga == null)
            {
                throw new InvalidDataException("DddCelularRecarga is a required property for CelularRecargaProgramadaPersist and cannot be null");
            }
            else
            {
                this.DddCelularRecarga = DddCelularRecarga;
            }
            // to ensure "NumeroCelularRecarga" is required (not null)
            if (NumeroCelularRecarga == null)
            {
                throw new InvalidDataException("NumeroCelularRecarga is a required property for CelularRecargaProgramadaPersist and cannot be null");
            }
            else
            {
                this.NumeroCelularRecarga = NumeroCelularRecarga;
            }
            this.IdUsuarioRecarga = IdUsuarioRecarga;
            this.IdPlataforma = IdPlataforma;
            this.IdProposta = IdProposta;
            
        }
        
    
        /// <summary>
        /// {{{celular_recarga_programada_persistencia_id_cartao_descricao}}}
        /// </summary>
        /// <value>{{{celular_recarga_programada_persistencia_id_cartao_descricao}}}</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// {{{celular_recarga_programada_persistencia_id_usuario_recarga_descricao}}}
        /// </summary>
        /// <value>{{{celular_recarga_programada_persistencia_id_usuario_recarga_descricao}}}</value>
        [DataMember(Name="idUsuarioRecarga", EmitDefaultValue=false)]
        public long? IdUsuarioRecarga { get; set; }
    
        /// <summary>
        /// {{{celular_recarga_programada_persistencia_id_descricao_tipo_recarga_programada_descricao}}}
        /// </summary>
        /// <value>{{{celular_recarga_programada_persistencia_id_descricao_tipo_recarga_programada_descricao}}}</value>
        [DataMember(Name="idDescricaoTipoRecargaProgramada", EmitDefaultValue=false)]
        public long? IdDescricaoTipoRecargaProgramada { get; set; }
    
        /// <summary>
        /// {{{celular_recarga_programada_persistencia_codigo_produto_descricao}}}
        /// </summary>
        /// <value>{{{celular_recarga_programada_persistencia_codigo_produto_descricao}}}</value>
        [DataMember(Name="codigoProduto", EmitDefaultValue=false)]
        public long? CodigoProduto { get; set; }
    
        /// <summary>
        /// {{{celular_recarga_programada_persistencia_codigo_operadora_descricao}}}
        /// </summary>
        /// <value>{{{celular_recarga_programada_persistencia_codigo_operadora_descricao}}}</value>
        [DataMember(Name="codigoOperadora", EmitDefaultValue=false)]
        public long? CodigoOperadora { get; set; }
    
        /// <summary>
        /// {{{celular_recarga_programada_persistencia_valor_descricao}}}
        /// </summary>
        /// <value>{{{celular_recarga_programada_persistencia_valor_descricao}}}</value>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }
    
        /// <summary>
        /// {{{celular_recarga_programada_persistencia_id_plataforma_descricao}}}
        /// </summary>
        /// <value>{{{celular_recarga_programada_persistencia_id_plataforma_descricao}}}</value>
        [DataMember(Name="idPlataforma", EmitDefaultValue=false)]
        public long? IdPlataforma { get; set; }
    
        /// <summary>
        /// {{{celular_recarga_programada_persistencia_flag_gera_tarifa_descricao}}}
        /// </summary>
        /// <value>{{{celular_recarga_programada_persistencia_flag_gera_tarifa_descricao}}}</value>
        [DataMember(Name="flagGeraTarifa", EmitDefaultValue=false)]
        public bool? FlagGeraTarifa { get; set; }
    
        /// <summary>
        /// {{{celular_recarga_programada_persistencia_id_proposta_descricao}}}
        /// </summary>
        /// <value>{{{celular_recarga_programada_persistencia_id_proposta_descricao}}}</value>
        [DataMember(Name="idProposta", EmitDefaultValue=false)]
        public long? IdProposta { get; set; }
    
        /// <summary>
        /// {{{celular_recarga_programada_persistencia_id_origem_comercial_descricao}}}
        /// </summary>
        /// <value>{{{celular_recarga_programada_persistencia_id_origem_comercial_descricao}}}</value>
        [DataMember(Name="idOrigemComercial", EmitDefaultValue=false)]
        public long? IdOrigemComercial { get; set; }
    
        /// <summary>
        /// {{{celular_recarga_programada_persistencia_ddd_celular_recarga_descricao}}}
        /// </summary>
        /// <value>{{{celular_recarga_programada_persistencia_ddd_celular_recarga_descricao}}}</value>
        [DataMember(Name="dddCelularRecarga", EmitDefaultValue=false)]
        public string DddCelularRecarga { get; set; }
    
        /// <summary>
        /// {{{celular_recarga_programada_persistencia_numero_celular_recarga_descricao}}}
        /// </summary>
        /// <value>{{{celular_recarga_programada_persistencia_numero_celular_recarga_descricao}}}</value>
        [DataMember(Name="numeroCelularRecarga", EmitDefaultValue=false)]
        public string NumeroCelularRecarga { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CelularRecargaProgramadaPersist {\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  IdUsuarioRecarga: ").Append(IdUsuarioRecarga).Append("\n");
            sb.Append("  IdDescricaoTipoRecargaProgramada: ").Append(IdDescricaoTipoRecargaProgramada).Append("\n");
            sb.Append("  CodigoProduto: ").Append(CodigoProduto).Append("\n");
            sb.Append("  CodigoOperadora: ").Append(CodigoOperadora).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  IdPlataforma: ").Append(IdPlataforma).Append("\n");
            sb.Append("  FlagGeraTarifa: ").Append(FlagGeraTarifa).Append("\n");
            sb.Append("  IdProposta: ").Append(IdProposta).Append("\n");
            sb.Append("  IdOrigemComercial: ").Append(IdOrigemComercial).Append("\n");
            sb.Append("  DddCelularRecarga: ").Append(DddCelularRecarga).Append("\n");
            sb.Append("  NumeroCelularRecarga: ").Append(NumeroCelularRecarga).Append("\n");
            
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
            return this.Equals(obj as CelularRecargaProgramadaPersist);
        }

        /// <summary>
        /// Returns true if CelularRecargaProgramadaPersist instances are equal
        /// </summary>
        /// <param name="other">Instance of CelularRecargaProgramadaPersist to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CelularRecargaProgramadaPersist other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.IdUsuarioRecarga == other.IdUsuarioRecarga ||
                    this.IdUsuarioRecarga != null &&
                    this.IdUsuarioRecarga.Equals(other.IdUsuarioRecarga)
                ) && 
                (
                    this.IdDescricaoTipoRecargaProgramada == other.IdDescricaoTipoRecargaProgramada ||
                    this.IdDescricaoTipoRecargaProgramada != null &&
                    this.IdDescricaoTipoRecargaProgramada.Equals(other.IdDescricaoTipoRecargaProgramada)
                ) && 
                (
                    this.CodigoProduto == other.CodigoProduto ||
                    this.CodigoProduto != null &&
                    this.CodigoProduto.Equals(other.CodigoProduto)
                ) && 
                (
                    this.CodigoOperadora == other.CodigoOperadora ||
                    this.CodigoOperadora != null &&
                    this.CodigoOperadora.Equals(other.CodigoOperadora)
                ) && 
                (
                    this.Valor == other.Valor ||
                    this.Valor != null &&
                    this.Valor.Equals(other.Valor)
                ) && 
                (
                    this.IdPlataforma == other.IdPlataforma ||
                    this.IdPlataforma != null &&
                    this.IdPlataforma.Equals(other.IdPlataforma)
                ) && 
                (
                    this.FlagGeraTarifa == other.FlagGeraTarifa ||
                    this.FlagGeraTarifa != null &&
                    this.FlagGeraTarifa.Equals(other.FlagGeraTarifa)
                ) && 
                (
                    this.IdProposta == other.IdProposta ||
                    this.IdProposta != null &&
                    this.IdProposta.Equals(other.IdProposta)
                ) && 
                (
                    this.IdOrigemComercial == other.IdOrigemComercial ||
                    this.IdOrigemComercial != null &&
                    this.IdOrigemComercial.Equals(other.IdOrigemComercial)
                ) && 
                (
                    this.DddCelularRecarga == other.DddCelularRecarga ||
                    this.DddCelularRecarga != null &&
                    this.DddCelularRecarga.Equals(other.DddCelularRecarga)
                ) && 
                (
                    this.NumeroCelularRecarga == other.NumeroCelularRecarga ||
                    this.NumeroCelularRecarga != null &&
                    this.NumeroCelularRecarga.Equals(other.NumeroCelularRecarga)
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
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.IdUsuarioRecarga != null)
                    hash = hash * 59 + this.IdUsuarioRecarga.GetHashCode();
                
                if (this.IdDescricaoTipoRecargaProgramada != null)
                    hash = hash * 59 + this.IdDescricaoTipoRecargaProgramada.GetHashCode();
                
                if (this.CodigoProduto != null)
                    hash = hash * 59 + this.CodigoProduto.GetHashCode();
                
                if (this.CodigoOperadora != null)
                    hash = hash * 59 + this.CodigoOperadora.GetHashCode();
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
                if (this.IdPlataforma != null)
                    hash = hash * 59 + this.IdPlataforma.GetHashCode();
                
                if (this.FlagGeraTarifa != null)
                    hash = hash * 59 + this.FlagGeraTarifa.GetHashCode();
                
                if (this.IdProposta != null)
                    hash = hash * 59 + this.IdProposta.GetHashCode();
                
                if (this.IdOrigemComercial != null)
                    hash = hash * 59 + this.IdOrigemComercial.GetHashCode();
                
                if (this.DddCelularRecarga != null)
                    hash = hash * 59 + this.DddCelularRecarga.GetHashCode();
                
                if (this.NumeroCelularRecarga != null)
                    hash = hash * 59 + this.NumeroCelularRecarga.GetHashCode();
                
                return hash;
            }
        }

    }
}
