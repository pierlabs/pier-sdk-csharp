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
    /// Objeto conta
    /// </summary>
    [DataContract]
    public partial class Conta :  IEquatable<Conta>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Conta" /> class.
        /// Initializes a new instance of the <see cref="Conta" />class.
        /// </summary>
        /// <param name="DataCadastro">Apresenta a data em que o cart\u00C3\u00A3o foi gerado..</param>
        /// <param name="DataStatusConta">Apresenta a data em que o idStatusConta atual fora atribu\u00C3\u00ADdo para ela..</param>
        /// <param name="DataUltimaAlteracaoVencimento">Apresenta a data da ultima altera\u00C3\u00A7\u00C3\u00A3o de vencimento..</param>
        /// <param name="DiaVencimento">Apresenta o dia de vencimento..</param>
        /// <param name="Id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de conta (id)..</param>
        /// <param name="IdOrigemComercial">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id) que deu origem a Conta..</param>
        /// <param name="IdPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa Titular da Conta (id)..</param>
        /// <param name="IdProduto">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do produto ao qual a conta faz parte. (id)..</param>
        /// <param name="IdStatusConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id)..</param>
        /// <param name="MelhorDiaCompra">Apresenta o melhor dia de compra..</param>

        public Conta(DateTime? DataCadastro = null, DateTime? DataStatusConta = null, DateTime? DataUltimaAlteracaoVencimento = null, int? DiaVencimento = null, long? Id = null, long? IdOrigemComercial = null, long? IdPessoa = null, long? IdProduto = null, long? IdStatusConta = null, int? MelhorDiaCompra = null)
        {
            this.DataCadastro = DataCadastro;
            this.DataStatusConta = DataStatusConta;
            this.DataUltimaAlteracaoVencimento = DataUltimaAlteracaoVencimento;
            this.DiaVencimento = DiaVencimento;
            this.Id = Id;
            this.IdOrigemComercial = IdOrigemComercial;
            this.IdPessoa = IdPessoa;
            this.IdProduto = IdProduto;
            this.IdStatusConta = IdStatusConta;
            this.MelhorDiaCompra = MelhorDiaCompra;
            
        }
        
    
        /// <summary>
        /// Apresenta a data em que o cart\u00C3\u00A3o foi gerado.
        /// </summary>
        /// <value>Apresenta a data em que o cart\u00C3\u00A3o foi gerado.</value>
        [DataMember(Name="dataCadastro", EmitDefaultValue=false)]
        public DateTime? DataCadastro { get; set; }
    
        /// <summary>
        /// Apresenta a data em que o idStatusConta atual fora atribu\u00C3\u00ADdo para ela.
        /// </summary>
        /// <value>Apresenta a data em que o idStatusConta atual fora atribu\u00C3\u00ADdo para ela.</value>
        [DataMember(Name="dataStatusConta", EmitDefaultValue=false)]
        public DateTime? DataStatusConta { get; set; }
    
        /// <summary>
        /// Apresenta a data da ultima altera\u00C3\u00A7\u00C3\u00A3o de vencimento.
        /// </summary>
        /// <value>Apresenta a data da ultima altera\u00C3\u00A7\u00C3\u00A3o de vencimento.</value>
        [DataMember(Name="dataUltimaAlteracaoVencimento", EmitDefaultValue=false)]
        public DateTime? DataUltimaAlteracaoVencimento { get; set; }
    
        /// <summary>
        /// Apresenta o dia de vencimento.
        /// </summary>
        /// <value>Apresenta o dia de vencimento.</value>
        [DataMember(Name="diaVencimento", EmitDefaultValue=false)]
        public int? DiaVencimento { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de conta (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o de conta (id).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id) que deu origem a Conta.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Origem Comercial (id) que deu origem a Conta.</value>
        [DataMember(Name="idOrigemComercial", EmitDefaultValue=false)]
        public long? IdOrigemComercial { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa Titular da Conta (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa Titular da Conta (id).</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do produto ao qual a conta faz parte. (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do produto ao qual a conta faz parte. (id).</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto a qual o cart\u00C3\u00A3o pertence (id).</value>
        [DataMember(Name="idStatusConta", EmitDefaultValue=false)]
        public long? IdStatusConta { get; set; }
    
        /// <summary>
        /// Apresenta o melhor dia de compra.
        /// </summary>
        /// <value>Apresenta o melhor dia de compra.</value>
        [DataMember(Name="melhorDiaCompra", EmitDefaultValue=false)]
        public int? MelhorDiaCompra { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Conta {\n");
            sb.Append("  DataCadastro: ").Append(DataCadastro).Append("\n");
            sb.Append("  DataStatusConta: ").Append(DataStatusConta).Append("\n");
            sb.Append("  DataUltimaAlteracaoVencimento: ").Append(DataUltimaAlteracaoVencimento).Append("\n");
            sb.Append("  DiaVencimento: ").Append(DiaVencimento).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdOrigemComercial: ").Append(IdOrigemComercial).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  IdStatusConta: ").Append(IdStatusConta).Append("\n");
            sb.Append("  MelhorDiaCompra: ").Append(MelhorDiaCompra).Append("\n");
            
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
            return this.Equals(obj as Conta);
        }

        /// <summary>
        /// Returns true if Conta instances are equal
        /// </summary>
        /// <param name="other">Instance of Conta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Conta other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DataCadastro == other.DataCadastro ||
                    this.DataCadastro != null &&
                    this.DataCadastro.Equals(other.DataCadastro)
                ) && 
                (
                    this.DataStatusConta == other.DataStatusConta ||
                    this.DataStatusConta != null &&
                    this.DataStatusConta.Equals(other.DataStatusConta)
                ) && 
                (
                    this.DataUltimaAlteracaoVencimento == other.DataUltimaAlteracaoVencimento ||
                    this.DataUltimaAlteracaoVencimento != null &&
                    this.DataUltimaAlteracaoVencimento.Equals(other.DataUltimaAlteracaoVencimento)
                ) && 
                (
                    this.DiaVencimento == other.DiaVencimento ||
                    this.DiaVencimento != null &&
                    this.DiaVencimento.Equals(other.DiaVencimento)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdOrigemComercial == other.IdOrigemComercial ||
                    this.IdOrigemComercial != null &&
                    this.IdOrigemComercial.Equals(other.IdOrigemComercial)
                ) && 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.IdStatusConta == other.IdStatusConta ||
                    this.IdStatusConta != null &&
                    this.IdStatusConta.Equals(other.IdStatusConta)
                ) && 
                (
                    this.MelhorDiaCompra == other.MelhorDiaCompra ||
                    this.MelhorDiaCompra != null &&
                    this.MelhorDiaCompra.Equals(other.MelhorDiaCompra)
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
                
                if (this.DataCadastro != null)
                    hash = hash * 59 + this.DataCadastro.GetHashCode();
                
                if (this.DataStatusConta != null)
                    hash = hash * 59 + this.DataStatusConta.GetHashCode();
                
                if (this.DataUltimaAlteracaoVencimento != null)
                    hash = hash * 59 + this.DataUltimaAlteracaoVencimento.GetHashCode();
                
                if (this.DiaVencimento != null)
                    hash = hash * 59 + this.DiaVencimento.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdOrigemComercial != null)
                    hash = hash * 59 + this.IdOrigemComercial.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.IdStatusConta != null)
                    hash = hash * 59 + this.IdStatusConta.GetHashCode();
                
                if (this.MelhorDiaCompra != null)
                    hash = hash * 59 + this.MelhorDiaCompra.GetHashCode();
                
                return hash;
            }
        }

    }
}
