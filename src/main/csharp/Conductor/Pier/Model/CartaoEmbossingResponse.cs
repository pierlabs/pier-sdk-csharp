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
    /// Objeto Cart\u00C3\u00A3o para Impress\u00C3\u00A3o pela Gr\u00C3\u00A1fica
    /// </summary>
    [DataContract]
    public partial class CartaoEmbossingResponse :  IEquatable<CartaoEmbossingResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartaoEmbossingResponse" /> class.
        /// Initializes a new instance of the <see cref="CartaoEmbossingResponse" />class.
        /// </summary>
        /// <param name="FlagVirtual">Apresenta o status que informa se o cart\u00C3\u00A3o \u00C3\u00A9 virtual .</param>
        /// <param name="IdConta">Apresenta o C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id) a qual o cart\u00C3\u00A3o gerado pertence..</param>
        /// <param name="IdPessoa">Apresenta o C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) portadora do cart\u00C3\u00A3o gerado..</param>
        /// <param name="IdCartao">Apresenta o C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id) que foi gerado..</param>
        /// <param name="IdBandeira">Apresenta o C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Bandeira (id) a qual o Cart\u00C3\u00A3o pertence, quando bandeirado..</param>
        /// <param name="IdTipoCartao">Apresenta o C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Cart\u00C3\u00A3o (id) atribu\u00C3\u00ADdo ao Cart\u00C3\u00A3o..</param>
        /// <param name="DataGeracao">Apresenta a data de emiss\u00C3\u00A3o do Cart\u00C3\u00A3o..</param>
        /// <param name="DataValidade">Apresenta a data de Validade do Cart\u00C3\u00A3o..</param>
        /// <param name="NomeOrigemComercial">Apresenta o nome da Origem Comercial que realizou o cadastro do Titular da Conta a qual o Cart\u00C3\u00A3o pertence..</param>
        /// <param name="Cpf">Apresenta o CPF do Portador do Cart\u00C3\u00A3o..</param>

        public CartaoEmbossingResponse(int? FlagVirtual = null, long? IdConta = null, long? IdPessoa = null, long? IdCartao = null, long? IdBandeira = null, long? IdTipoCartao = null, string DataGeracao = null, string DataValidade = null, string NomeOrigemComercial = null, string Cpf = null)
        {
            this.FlagVirtual = FlagVirtual;
            this.IdConta = IdConta;
            this.IdPessoa = IdPessoa;
            this.IdCartao = IdCartao;
            this.IdBandeira = IdBandeira;
            this.IdTipoCartao = IdTipoCartao;
            this.DataGeracao = DataGeracao;
            this.DataValidade = DataValidade;
            this.NomeOrigemComercial = NomeOrigemComercial;
            this.Cpf = Cpf;
            
        }
        
    
        /// <summary>
        /// Apresenta o status que informa se o cart\u00C3\u00A3o \u00C3\u00A9 virtual 
        /// </summary>
        /// <value>Apresenta o status que informa se o cart\u00C3\u00A3o \u00C3\u00A9 virtual </value>
        [DataMember(Name="flagVirtual", EmitDefaultValue=false)]
        public int? FlagVirtual { get; set; }
    
        /// <summary>
        /// Apresenta o C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id) a qual o cart\u00C3\u00A3o gerado pertence.
        /// </summary>
        /// <value>Apresenta o C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id) a qual o cart\u00C3\u00A3o gerado pertence.</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Apresenta o C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) portadora do cart\u00C3\u00A3o gerado.
        /// </summary>
        /// <value>Apresenta o C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) portadora do cart\u00C3\u00A3o gerado.</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// Apresenta o C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id) que foi gerado.
        /// </summary>
        /// <value>Apresenta o C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Cart\u00C3\u00A3o (id) que foi gerado.</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// Apresenta o C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Bandeira (id) a qual o Cart\u00C3\u00A3o pertence, quando bandeirado.
        /// </summary>
        /// <value>Apresenta o C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Bandeira (id) a qual o Cart\u00C3\u00A3o pertence, quando bandeirado.</value>
        [DataMember(Name="idBandeira", EmitDefaultValue=false)]
        public long? IdBandeira { get; set; }
    
        /// <summary>
        /// Apresenta o C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Cart\u00C3\u00A3o (id) atribu\u00C3\u00ADdo ao Cart\u00C3\u00A3o.
        /// </summary>
        /// <value>Apresenta o C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Cart\u00C3\u00A3o (id) atribu\u00C3\u00ADdo ao Cart\u00C3\u00A3o.</value>
        [DataMember(Name="idTipoCartao", EmitDefaultValue=false)]
        public long? IdTipoCartao { get; set; }
    
        /// <summary>
        /// Apresenta a data de emiss\u00C3\u00A3o do Cart\u00C3\u00A3o.
        /// </summary>
        /// <value>Apresenta a data de emiss\u00C3\u00A3o do Cart\u00C3\u00A3o.</value>
        [DataMember(Name="dataGeracao", EmitDefaultValue=false)]
        public string DataGeracao { get; set; }
    
        /// <summary>
        /// Apresenta a data de Validade do Cart\u00C3\u00A3o.
        /// </summary>
        /// <value>Apresenta a data de Validade do Cart\u00C3\u00A3o.</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
    
        /// <summary>
        /// Apresenta o nome da Origem Comercial que realizou o cadastro do Titular da Conta a qual o Cart\u00C3\u00A3o pertence.
        /// </summary>
        /// <value>Apresenta o nome da Origem Comercial que realizou o cadastro do Titular da Conta a qual o Cart\u00C3\u00A3o pertence.</value>
        [DataMember(Name="nomeOrigemComercial", EmitDefaultValue=false)]
        public string NomeOrigemComercial { get; set; }
    
        /// <summary>
        /// Apresenta o CPF do Portador do Cart\u00C3\u00A3o.
        /// </summary>
        /// <value>Apresenta o CPF do Portador do Cart\u00C3\u00A3o.</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CartaoEmbossingResponse {\n");
            sb.Append("  FlagVirtual: ").Append(FlagVirtual).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  IdBandeira: ").Append(IdBandeira).Append("\n");
            sb.Append("  IdTipoCartao: ").Append(IdTipoCartao).Append("\n");
            sb.Append("  DataGeracao: ").Append(DataGeracao).Append("\n");
            sb.Append("  DataValidade: ").Append(DataValidade).Append("\n");
            sb.Append("  NomeOrigemComercial: ").Append(NomeOrigemComercial).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            
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
            return this.Equals(obj as CartaoEmbossingResponse);
        }

        /// <summary>
        /// Returns true if CartaoEmbossingResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CartaoEmbossingResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CartaoEmbossingResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FlagVirtual == other.FlagVirtual ||
                    this.FlagVirtual != null &&
                    this.FlagVirtual.Equals(other.FlagVirtual)
                ) && 
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
                    this.Cpf == other.Cpf ||
                    this.Cpf != null &&
                    this.Cpf.Equals(other.Cpf)
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
                
                if (this.FlagVirtual != null)
                    hash = hash * 59 + this.FlagVirtual.GetHashCode();
                
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
                
                if (this.DataGeracao != null)
                    hash = hash * 59 + this.DataGeracao.GetHashCode();
                
                if (this.DataValidade != null)
                    hash = hash * 59 + this.DataValidade.GetHashCode();
                
                if (this.NomeOrigemComercial != null)
                    hash = hash * 59 + this.NomeOrigemComercial.GetHashCode();
                
                if (this.Cpf != null)
                    hash = hash * 59 + this.Cpf.GetHashCode();
                
                return hash;
            }
        }

    }
}
