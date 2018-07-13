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
    /// {{{conta_debito_recorrente_response_description}}}
    /// </summary>
    [DataContract]
    public partial class ContaDebitoRecorrenteResponse :  IEquatable<ContaDebitoRecorrenteResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaDebitoRecorrenteResponse" /> class.
        /// Initializes a new instance of the <see cref="ContaDebitoRecorrenteResponse" />class.
        /// </summary>
        /// <param name="Ativo">{{{conta_debito_recorrente_response_ativo_value}}}.</param>
        /// <param name="DataHoraFim">{{{conta_debito_recorrente_response_data_hora_fim_value}}}.</param>
        /// <param name="DataHoraInicio">{{{conta_debito_recorrente_response_data_hora_inicio_value}}}.</param>
        /// <param name="DataHoraUltimoPagamento">{{{conta_debito_recorrente_response_data_hora_ultimo_pagamento_value}}}.</param>
        /// <param name="Descricao">{{{conta_debito_recorrente_response_descricao_value}}}.</param>
        /// <param name="IdConta">{{{conta_debito_recorrente_response_id_conta_value}}}.</param>
        /// <param name="IdContaDebitoRecorrente">{{{conta_debito_recorrente_response_id_conta_debito_recorrente_value}}}.</param>
        /// <param name="IdTipoDebitoRecorrente">{{{conta_debito_recorrente_response_id_tipo_debito_recorrente_value}}}.</param>
        /// <param name="IdUsuario">{{{conta_debito_recorrente_response_id_usuario_value}}}.</param>
        /// <param name="Login">{{{conta_debito_recorrente_response_id_login_value}}}.</param>
        /// <param name="NumeroParcelas">{{{conta_debito_recorrente_response_num_parcelas_value}}}.</param>
        /// <param name="Origem">{{{conta_debito_recorrente_response_origem_value}}}.</param>

        public ContaDebitoRecorrenteResponse(bool? Ativo = null, string DataHoraFim = null, string DataHoraInicio = null, string DataHoraUltimoPagamento = null, string Descricao = null, long? IdConta = null, long? IdContaDebitoRecorrente = null, long? IdTipoDebitoRecorrente = null, long? IdUsuario = null, string Login = null, int? NumeroParcelas = null, string Origem = null)
        {
            this.Ativo = Ativo;
            this.DataHoraFim = DataHoraFim;
            this.DataHoraInicio = DataHoraInicio;
            this.DataHoraUltimoPagamento = DataHoraUltimoPagamento;
            this.Descricao = Descricao;
            this.IdConta = IdConta;
            this.IdContaDebitoRecorrente = IdContaDebitoRecorrente;
            this.IdTipoDebitoRecorrente = IdTipoDebitoRecorrente;
            this.IdUsuario = IdUsuario;
            this.Login = Login;
            this.NumeroParcelas = NumeroParcelas;
            this.Origem = Origem;
            
        }
        
    
        /// <summary>
        /// {{{conta_debito_recorrente_response_ativo_value}}}
        /// </summary>
        /// <value>{{{conta_debito_recorrente_response_ativo_value}}}</value>
        [DataMember(Name="ativo", EmitDefaultValue=false)]
        public bool? Ativo { get; set; }
    
        /// <summary>
        /// {{{conta_debito_recorrente_response_data_hora_fim_value}}}
        /// </summary>
        /// <value>{{{conta_debito_recorrente_response_data_hora_fim_value}}}</value>
        [DataMember(Name="dataHoraFim", EmitDefaultValue=false)]
        public string DataHoraFim { get; set; }
    
        /// <summary>
        /// {{{conta_debito_recorrente_response_data_hora_inicio_value}}}
        /// </summary>
        /// <value>{{{conta_debito_recorrente_response_data_hora_inicio_value}}}</value>
        [DataMember(Name="dataHoraInicio", EmitDefaultValue=false)]
        public string DataHoraInicio { get; set; }
    
        /// <summary>
        /// {{{conta_debito_recorrente_response_data_hora_ultimo_pagamento_value}}}
        /// </summary>
        /// <value>{{{conta_debito_recorrente_response_data_hora_ultimo_pagamento_value}}}</value>
        [DataMember(Name="dataHoraUltimoPagamento", EmitDefaultValue=false)]
        public string DataHoraUltimoPagamento { get; set; }
    
        /// <summary>
        /// {{{conta_debito_recorrente_response_descricao_value}}}
        /// </summary>
        /// <value>{{{conta_debito_recorrente_response_descricao_value}}}</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// {{{conta_debito_recorrente_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{conta_debito_recorrente_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{conta_debito_recorrente_response_id_conta_debito_recorrente_value}}}
        /// </summary>
        /// <value>{{{conta_debito_recorrente_response_id_conta_debito_recorrente_value}}}</value>
        [DataMember(Name="idContaDebitoRecorrente", EmitDefaultValue=false)]
        public long? IdContaDebitoRecorrente { get; set; }
    
        /// <summary>
        /// {{{conta_debito_recorrente_response_id_tipo_debito_recorrente_value}}}
        /// </summary>
        /// <value>{{{conta_debito_recorrente_response_id_tipo_debito_recorrente_value}}}</value>
        [DataMember(Name="idTipoDebitoRecorrente", EmitDefaultValue=false)]
        public long? IdTipoDebitoRecorrente { get; set; }
    
        /// <summary>
        /// {{{conta_debito_recorrente_response_id_usuario_value}}}
        /// </summary>
        /// <value>{{{conta_debito_recorrente_response_id_usuario_value}}}</value>
        [DataMember(Name="idUsuario", EmitDefaultValue=false)]
        public long? IdUsuario { get; set; }
    
        /// <summary>
        /// {{{conta_debito_recorrente_response_id_login_value}}}
        /// </summary>
        /// <value>{{{conta_debito_recorrente_response_id_login_value}}}</value>
        [DataMember(Name="login", EmitDefaultValue=false)]
        public string Login { get; set; }
    
        /// <summary>
        /// {{{conta_debito_recorrente_response_num_parcelas_value}}}
        /// </summary>
        /// <value>{{{conta_debito_recorrente_response_num_parcelas_value}}}</value>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public int? NumeroParcelas { get; set; }
    
        /// <summary>
        /// {{{conta_debito_recorrente_response_origem_value}}}
        /// </summary>
        /// <value>{{{conta_debito_recorrente_response_origem_value}}}</value>
        [DataMember(Name="origem", EmitDefaultValue=false)]
        public string Origem { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContaDebitoRecorrenteResponse {\n");
            sb.Append("  Ativo: ").Append(Ativo).Append("\n");
            sb.Append("  DataHoraFim: ").Append(DataHoraFim).Append("\n");
            sb.Append("  DataHoraInicio: ").Append(DataHoraInicio).Append("\n");
            sb.Append("  DataHoraUltimoPagamento: ").Append(DataHoraUltimoPagamento).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdContaDebitoRecorrente: ").Append(IdContaDebitoRecorrente).Append("\n");
            sb.Append("  IdTipoDebitoRecorrente: ").Append(IdTipoDebitoRecorrente).Append("\n");
            sb.Append("  IdUsuario: ").Append(IdUsuario).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  NumeroParcelas: ").Append(NumeroParcelas).Append("\n");
            sb.Append("  Origem: ").Append(Origem).Append("\n");
            
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
            return this.Equals(obj as ContaDebitoRecorrenteResponse);
        }

        /// <summary>
        /// Returns true if ContaDebitoRecorrenteResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ContaDebitoRecorrenteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContaDebitoRecorrenteResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Ativo == other.Ativo ||
                    this.Ativo != null &&
                    this.Ativo.Equals(other.Ativo)
                ) && 
                (
                    this.DataHoraFim == other.DataHoraFim ||
                    this.DataHoraFim != null &&
                    this.DataHoraFim.Equals(other.DataHoraFim)
                ) && 
                (
                    this.DataHoraInicio == other.DataHoraInicio ||
                    this.DataHoraInicio != null &&
                    this.DataHoraInicio.Equals(other.DataHoraInicio)
                ) && 
                (
                    this.DataHoraUltimoPagamento == other.DataHoraUltimoPagamento ||
                    this.DataHoraUltimoPagamento != null &&
                    this.DataHoraUltimoPagamento.Equals(other.DataHoraUltimoPagamento)
                ) && 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdContaDebitoRecorrente == other.IdContaDebitoRecorrente ||
                    this.IdContaDebitoRecorrente != null &&
                    this.IdContaDebitoRecorrente.Equals(other.IdContaDebitoRecorrente)
                ) && 
                (
                    this.IdTipoDebitoRecorrente == other.IdTipoDebitoRecorrente ||
                    this.IdTipoDebitoRecorrente != null &&
                    this.IdTipoDebitoRecorrente.Equals(other.IdTipoDebitoRecorrente)
                ) && 
                (
                    this.IdUsuario == other.IdUsuario ||
                    this.IdUsuario != null &&
                    this.IdUsuario.Equals(other.IdUsuario)
                ) && 
                (
                    this.Login == other.Login ||
                    this.Login != null &&
                    this.Login.Equals(other.Login)
                ) && 
                (
                    this.NumeroParcelas == other.NumeroParcelas ||
                    this.NumeroParcelas != null &&
                    this.NumeroParcelas.Equals(other.NumeroParcelas)
                ) && 
                (
                    this.Origem == other.Origem ||
                    this.Origem != null &&
                    this.Origem.Equals(other.Origem)
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
                
                if (this.Ativo != null)
                    hash = hash * 59 + this.Ativo.GetHashCode();
                
                if (this.DataHoraFim != null)
                    hash = hash * 59 + this.DataHoraFim.GetHashCode();
                
                if (this.DataHoraInicio != null)
                    hash = hash * 59 + this.DataHoraInicio.GetHashCode();
                
                if (this.DataHoraUltimoPagamento != null)
                    hash = hash * 59 + this.DataHoraUltimoPagamento.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdContaDebitoRecorrente != null)
                    hash = hash * 59 + this.IdContaDebitoRecorrente.GetHashCode();
                
                if (this.IdTipoDebitoRecorrente != null)
                    hash = hash * 59 + this.IdTipoDebitoRecorrente.GetHashCode();
                
                if (this.IdUsuario != null)
                    hash = hash * 59 + this.IdUsuario.GetHashCode();
                
                if (this.Login != null)
                    hash = hash * 59 + this.Login.GetHashCode();
                
                if (this.NumeroParcelas != null)
                    hash = hash * 59 + this.NumeroParcelas.GetHashCode();
                
                if (this.Origem != null)
                    hash = hash * 59 + this.Origem.GetHashCode();
                
                return hash;
            }
        }

    }
}
