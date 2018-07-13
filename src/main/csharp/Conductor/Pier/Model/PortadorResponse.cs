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
    /// {{{portador_response_description}}}
    /// </summary>
    [DataContract]
    public partial class PortadorResponse :  IEquatable<PortadorResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PortadorResponse" /> class.
        /// Initializes a new instance of the <see cref="PortadorResponse" />class.
        /// </summary>
        /// <param name="IdConta">{{{portador_response_id_conta_value}}}.</param>
        /// <param name="IdProduto">{{{portador_response_id_produto_value}}}.</param>
        /// <param name="IdPessoa">{{{portador_response_id_pessoa_value}}}.</param>
        /// <param name="IdParentesco">{{{portador_response_id_parentesco_value}}}.</param>
        /// <param name="TipoPortador">{{{portador_response_tipo_portador_value}}}.</param>
        /// <param name="NomeImpresso">{{{portador_response_nome_impresso_value}}}.</param>
        /// <param name="IdTipoCartao">{{{portador_response_id_tipo_cartao_value}}}.</param>
        /// <param name="FlagAtivo">{{{portador_response_flag_ativo_value}}}.</param>
        /// <param name="DataCadastroPortador">{{{portador_response_data_cadastro_portador_value}}}.</param>
        /// <param name="DataCancelamentoPortador">{{{portador_response_data_cancelamento_portador_value}}}.</param>

        public PortadorResponse(long? IdConta = null, long? IdProduto = null, long? IdPessoa = null, long? IdParentesco = null, string TipoPortador = null, string NomeImpresso = null, long? IdTipoCartao = null, int? FlagAtivo = null, string DataCadastroPortador = null, string DataCancelamentoPortador = null)
        {
            this.IdConta = IdConta;
            this.IdProduto = IdProduto;
            this.IdPessoa = IdPessoa;
            this.IdParentesco = IdParentesco;
            this.TipoPortador = TipoPortador;
            this.NomeImpresso = NomeImpresso;
            this.IdTipoCartao = IdTipoCartao;
            this.FlagAtivo = FlagAtivo;
            this.DataCadastroPortador = DataCadastroPortador;
            this.DataCancelamentoPortador = DataCancelamentoPortador;
            
        }
        
    
        /// <summary>
        /// {{{portador_response_id_conta_value}}}
        /// </summary>
        /// <value>{{{portador_response_id_conta_value}}}</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// {{{portador_response_id_produto_value}}}
        /// </summary>
        /// <value>{{{portador_response_id_produto_value}}}</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// {{{portador_response_id_pessoa_value}}}
        /// </summary>
        /// <value>{{{portador_response_id_pessoa_value}}}</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// {{{portador_response_id_parentesco_value}}}
        /// </summary>
        /// <value>{{{portador_response_id_parentesco_value}}}</value>
        [DataMember(Name="idParentesco", EmitDefaultValue=false)]
        public long? IdParentesco { get; set; }
    
        /// <summary>
        /// {{{portador_response_tipo_portador_value}}}
        /// </summary>
        /// <value>{{{portador_response_tipo_portador_value}}}</value>
        [DataMember(Name="tipoPortador", EmitDefaultValue=false)]
        public string TipoPortador { get; set; }
    
        /// <summary>
        /// {{{portador_response_nome_impresso_value}}}
        /// </summary>
        /// <value>{{{portador_response_nome_impresso_value}}}</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
        /// <summary>
        /// {{{portador_response_id_tipo_cartao_value}}}
        /// </summary>
        /// <value>{{{portador_response_id_tipo_cartao_value}}}</value>
        [DataMember(Name="idTipoCartao", EmitDefaultValue=false)]
        public long? IdTipoCartao { get; set; }
    
        /// <summary>
        /// {{{portador_response_flag_ativo_value}}}
        /// </summary>
        /// <value>{{{portador_response_flag_ativo_value}}}</value>
        [DataMember(Name="flagAtivo", EmitDefaultValue=false)]
        public int? FlagAtivo { get; set; }
    
        /// <summary>
        /// {{{portador_response_data_cadastro_portador_value}}}
        /// </summary>
        /// <value>{{{portador_response_data_cadastro_portador_value}}}</value>
        [DataMember(Name="dataCadastroPortador", EmitDefaultValue=false)]
        public string DataCadastroPortador { get; set; }
    
        /// <summary>
        /// {{{portador_response_data_cancelamento_portador_value}}}
        /// </summary>
        /// <value>{{{portador_response_data_cancelamento_portador_value}}}</value>
        [DataMember(Name="dataCancelamentoPortador", EmitDefaultValue=false)]
        public string DataCancelamentoPortador { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PortadorResponse {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  IdParentesco: ").Append(IdParentesco).Append("\n");
            sb.Append("  TipoPortador: ").Append(TipoPortador).Append("\n");
            sb.Append("  NomeImpresso: ").Append(NomeImpresso).Append("\n");
            sb.Append("  IdTipoCartao: ").Append(IdTipoCartao).Append("\n");
            sb.Append("  FlagAtivo: ").Append(FlagAtivo).Append("\n");
            sb.Append("  DataCadastroPortador: ").Append(DataCadastroPortador).Append("\n");
            sb.Append("  DataCancelamentoPortador: ").Append(DataCancelamentoPortador).Append("\n");
            
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
            return this.Equals(obj as PortadorResponse);
        }

        /// <summary>
        /// Returns true if PortadorResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PortadorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PortadorResponse other)
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
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.IdParentesco == other.IdParentesco ||
                    this.IdParentesco != null &&
                    this.IdParentesco.Equals(other.IdParentesco)
                ) && 
                (
                    this.TipoPortador == other.TipoPortador ||
                    this.TipoPortador != null &&
                    this.TipoPortador.Equals(other.TipoPortador)
                ) && 
                (
                    this.NomeImpresso == other.NomeImpresso ||
                    this.NomeImpresso != null &&
                    this.NomeImpresso.Equals(other.NomeImpresso)
                ) && 
                (
                    this.IdTipoCartao == other.IdTipoCartao ||
                    this.IdTipoCartao != null &&
                    this.IdTipoCartao.Equals(other.IdTipoCartao)
                ) && 
                (
                    this.FlagAtivo == other.FlagAtivo ||
                    this.FlagAtivo != null &&
                    this.FlagAtivo.Equals(other.FlagAtivo)
                ) && 
                (
                    this.DataCadastroPortador == other.DataCadastroPortador ||
                    this.DataCadastroPortador != null &&
                    this.DataCadastroPortador.Equals(other.DataCadastroPortador)
                ) && 
                (
                    this.DataCancelamentoPortador == other.DataCancelamentoPortador ||
                    this.DataCancelamentoPortador != null &&
                    this.DataCancelamentoPortador.Equals(other.DataCancelamentoPortador)
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
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.IdParentesco != null)
                    hash = hash * 59 + this.IdParentesco.GetHashCode();
                
                if (this.TipoPortador != null)
                    hash = hash * 59 + this.TipoPortador.GetHashCode();
                
                if (this.NomeImpresso != null)
                    hash = hash * 59 + this.NomeImpresso.GetHashCode();
                
                if (this.IdTipoCartao != null)
                    hash = hash * 59 + this.IdTipoCartao.GetHashCode();
                
                if (this.FlagAtivo != null)
                    hash = hash * 59 + this.FlagAtivo.GetHashCode();
                
                if (this.DataCadastroPortador != null)
                    hash = hash * 59 + this.DataCadastroPortador.GetHashCode();
                
                if (this.DataCancelamentoPortador != null)
                    hash = hash * 59 + this.DataCancelamentoPortador.GetHashCode();
                
                return hash;
            }
        }

    }
}
