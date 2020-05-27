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
    /// Objeto para altera\u00E7\u00E3o de contas. Nenhum dos campos s\u00E3o obrigat\u00F3rios. Devem ser informados apenas os campos que deseja modificar
    /// </summary>
    [DataContract]
    public partial class ContaPartialUpdate :  IEquatable<ContaPartialUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaPartialUpdate" /> class.
        /// Initializes a new instance of the <see cref="ContaPartialUpdate" />class.
        /// </summary>
        /// <param name="FuncaoAtiva">Fun\u00E7\u00E3o ativa da conta. Representa a fun\u00E7\u00E3o na qual a conta encontra-se habilitada. Propriedade s\u00F3 deve ser informada caso o emissor fa\u00E7a uso de fun\u00E7\u00F5es para contas. As fun\u00E7\u00F5es dispon\u00EDveis para contas podem ser visualizadas em api/contas/tipos-funcoes.</param>
        /// <param name="IdContaEmissor">Identificador da conta de controle interno criado pelo emissor.</param>
        /// <param name="DataCadastro">dataCadastro.</param>
        /// <param name="ValorRenda">valorRenda.</param>
        /// <param name="PossuiOverLimit">Sinaliza se o OverLimit da conta est\u00E1 ativo.</param>
        /// <param name="UsuarioModificacao">usuarioModificacao.</param>
        /// <param name="BehaviorScore">Valor da pontua\u00E7\u00E3o de comportamento (behavior score)..</param>
        /// <param name="Banco">C\u00F3digo de identifica\u00E7\u00E3o do banco.</param>
        /// <param name="Agencia">C\u00F3digo de identifica\u00E7\u00E3o da ag\u00EAncia.</param>

        public ContaPartialUpdate(string FuncaoAtiva = null, long? IdContaEmissor = null, string DataCadastro = null, double? ValorRenda = null, bool? PossuiOverLimit = null, string UsuarioModificacao = null, int? BehaviorScore = null, long? Banco = null, long? Agencia = null)
        {
            this.FuncaoAtiva = FuncaoAtiva;
            this.IdContaEmissor = IdContaEmissor;
            this.DataCadastro = DataCadastro;
            this.ValorRenda = ValorRenda;
            this.PossuiOverLimit = PossuiOverLimit;
            this.UsuarioModificacao = UsuarioModificacao;
            this.BehaviorScore = BehaviorScore;
            this.Banco = Banco;
            this.Agencia = Agencia;
            
        }
        
    
        /// <summary>
        /// Fun\u00E7\u00E3o ativa da conta. Representa a fun\u00E7\u00E3o na qual a conta encontra-se habilitada. Propriedade s\u00F3 deve ser informada caso o emissor fa\u00E7a uso de fun\u00E7\u00F5es para contas. As fun\u00E7\u00F5es dispon\u00EDveis para contas podem ser visualizadas em api/contas/tipos-funcoes
        /// </summary>
        /// <value>Fun\u00E7\u00E3o ativa da conta. Representa a fun\u00E7\u00E3o na qual a conta encontra-se habilitada. Propriedade s\u00F3 deve ser informada caso o emissor fa\u00E7a uso de fun\u00E7\u00F5es para contas. As fun\u00E7\u00F5es dispon\u00EDveis para contas podem ser visualizadas em api/contas/tipos-funcoes</value>
        [DataMember(Name="funcaoAtiva", EmitDefaultValue=false)]
        public string FuncaoAtiva { get; set; }
    
        /// <summary>
        /// Identificador da conta de controle interno criado pelo emissor
        /// </summary>
        /// <value>Identificador da conta de controle interno criado pelo emissor</value>
        [DataMember(Name="idContaEmissor", EmitDefaultValue=false)]
        public long? IdContaEmissor { get; set; }
    
        /// <summary>
        /// dataCadastro
        /// </summary>
        /// <value>dataCadastro</value>
        [DataMember(Name="dataCadastro", EmitDefaultValue=false)]
        public string DataCadastro { get; set; }
    
        /// <summary>
        /// valorRenda
        /// </summary>
        /// <value>valorRenda</value>
        [DataMember(Name="valorRenda", EmitDefaultValue=false)]
        public double? ValorRenda { get; set; }
    
        /// <summary>
        /// Sinaliza se o OverLimit da conta est\u00E1 ativo
        /// </summary>
        /// <value>Sinaliza se o OverLimit da conta est\u00E1 ativo</value>
        [DataMember(Name="possuiOverLimit", EmitDefaultValue=false)]
        public bool? PossuiOverLimit { get; set; }
    
        /// <summary>
        /// usuarioModificacao
        /// </summary>
        /// <value>usuarioModificacao</value>
        [DataMember(Name="usuarioModificacao", EmitDefaultValue=false)]
        public string UsuarioModificacao { get; set; }
    
        /// <summary>
        /// Valor da pontua\u00E7\u00E3o de comportamento (behavior score).
        /// </summary>
        /// <value>Valor da pontua\u00E7\u00E3o de comportamento (behavior score).</value>
        [DataMember(Name="behaviorScore", EmitDefaultValue=false)]
        public int? BehaviorScore { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do banco
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do banco</value>
        [DataMember(Name="banco", EmitDefaultValue=false)]
        public long? Banco { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o da ag\u00EAncia
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o da ag\u00EAncia</value>
        [DataMember(Name="agencia", EmitDefaultValue=false)]
        public long? Agencia { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContaPartialUpdate {\n");
            sb.Append("  FuncaoAtiva: ").Append(FuncaoAtiva).Append("\n");
            sb.Append("  IdContaEmissor: ").Append(IdContaEmissor).Append("\n");
            sb.Append("  DataCadastro: ").Append(DataCadastro).Append("\n");
            sb.Append("  ValorRenda: ").Append(ValorRenda).Append("\n");
            sb.Append("  PossuiOverLimit: ").Append(PossuiOverLimit).Append("\n");
            sb.Append("  UsuarioModificacao: ").Append(UsuarioModificacao).Append("\n");
            sb.Append("  BehaviorScore: ").Append(BehaviorScore).Append("\n");
            sb.Append("  Banco: ").Append(Banco).Append("\n");
            sb.Append("  Agencia: ").Append(Agencia).Append("\n");
            
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
            return this.Equals(obj as ContaPartialUpdate);
        }

        /// <summary>
        /// Returns true if ContaPartialUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of ContaPartialUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContaPartialUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FuncaoAtiva == other.FuncaoAtiva ||
                    this.FuncaoAtiva != null &&
                    this.FuncaoAtiva.Equals(other.FuncaoAtiva)
                ) && 
                (
                    this.IdContaEmissor == other.IdContaEmissor ||
                    this.IdContaEmissor != null &&
                    this.IdContaEmissor.Equals(other.IdContaEmissor)
                ) && 
                (
                    this.DataCadastro == other.DataCadastro ||
                    this.DataCadastro != null &&
                    this.DataCadastro.Equals(other.DataCadastro)
                ) && 
                (
                    this.ValorRenda == other.ValorRenda ||
                    this.ValorRenda != null &&
                    this.ValorRenda.Equals(other.ValorRenda)
                ) && 
                (
                    this.PossuiOverLimit == other.PossuiOverLimit ||
                    this.PossuiOverLimit != null &&
                    this.PossuiOverLimit.Equals(other.PossuiOverLimit)
                ) && 
                (
                    this.UsuarioModificacao == other.UsuarioModificacao ||
                    this.UsuarioModificacao != null &&
                    this.UsuarioModificacao.Equals(other.UsuarioModificacao)
                ) && 
                (
                    this.BehaviorScore == other.BehaviorScore ||
                    this.BehaviorScore != null &&
                    this.BehaviorScore.Equals(other.BehaviorScore)
                ) && 
                (
                    this.Banco == other.Banco ||
                    this.Banco != null &&
                    this.Banco.Equals(other.Banco)
                ) && 
                (
                    this.Agencia == other.Agencia ||
                    this.Agencia != null &&
                    this.Agencia.Equals(other.Agencia)
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
                
                if (this.FuncaoAtiva != null)
                    hash = hash * 59 + this.FuncaoAtiva.GetHashCode();
                
                if (this.IdContaEmissor != null)
                    hash = hash * 59 + this.IdContaEmissor.GetHashCode();
                
                if (this.DataCadastro != null)
                    hash = hash * 59 + this.DataCadastro.GetHashCode();
                
                if (this.ValorRenda != null)
                    hash = hash * 59 + this.ValorRenda.GetHashCode();
                
                if (this.PossuiOverLimit != null)
                    hash = hash * 59 + this.PossuiOverLimit.GetHashCode();
                
                if (this.UsuarioModificacao != null)
                    hash = hash * 59 + this.UsuarioModificacao.GetHashCode();
                
                if (this.BehaviorScore != null)
                    hash = hash * 59 + this.BehaviorScore.GetHashCode();
                
                if (this.Banco != null)
                    hash = hash * 59 + this.Banco.GetHashCode();
                
                if (this.Agencia != null)
                    hash = hash * 59 + this.Agencia.GetHashCode();
                
                return hash;
            }
        }

    }
}
