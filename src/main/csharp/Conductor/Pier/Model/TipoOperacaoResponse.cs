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
    /// Response Representation of the TypeOperation Resource
    /// </summary>
    [DataContract]
    public partial class TipoOperacaoResponse :  IEquatable<TipoOperacaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoOperacaoResponse" /> class.
        /// Initializes a new instance of the <see cref="TipoOperacaoResponse" />class.
        /// </summary>
        /// <param name="Id">Identifier Code of the OperationType (required).</param>
        /// <param name="TipoOperacao">OperationType Code (required).</param>
        /// <param name="Nome">Name of the Operationtype (required).</param>
        /// <param name="Descricao">Decri??o of the OperationType (required).</param>
        /// <param name="ExcedentePermitido">Exceed allowed for the TypeOperation.</param>
        /// <param name="TipoExcedentePermitido">Type of the allowed exceeded for the OperationType.</param>
        /// <param name="ValorMinimo">Minimum value for the transaction of OperationType (required).</param>
        /// <param name="ValorMaximo">Maximum valuie for the transaction of the OperationType (required).</param>
        /// <param name="ValorTAC">TAC value of the transaction of OperationType.</param>
        /// <param name="FlagTiraTac">Flag stripe TAC of the OperationType.</param>
        /// <param name="IdProduto">Identifier of the TypeOperation of Product (required).</param>
        /// <param name="IdEstabelecimento">Identifier of the Merchant of OperationType (required).</param>
        /// <param name="Tarifa">OperationType fee.</param>
        /// <param name="RemuneracaoEmissor">Remunaration of the Issuer for the OperatioType.</param>
        /// <param name="PlanoMaximo">Maximum Plan of the OperationType (required).</param>
        /// <param name="PlanoMinimo">Minimum Plan of the OperationType (required).</param>

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
        /// Identifier Code of the OperationType
        /// </summary>
        /// <value>Identifier Code of the OperationType</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// OperationType Code
        /// </summary>
        /// <value>OperationType Code</value>
        [DataMember(Name="tipoOperacao", EmitDefaultValue=false)]
        public string TipoOperacao { get; set; }
    
        /// <summary>
        /// Name of the Operationtype
        /// </summary>
        /// <value>Name of the Operationtype</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Decri??o of the OperationType
        /// </summary>
        /// <value>Decri??o of the OperationType</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Exceed allowed for the TypeOperation
        /// </summary>
        /// <value>Exceed allowed for the TypeOperation</value>
        [DataMember(Name="excedentePermitido", EmitDefaultValue=false)]
        public double? ExcedentePermitido { get; set; }
    
        /// <summary>
        /// Type of the allowed exceeded for the OperationType
        /// </summary>
        /// <value>Type of the allowed exceeded for the OperationType</value>
        [DataMember(Name="tipoExcedentePermitido", EmitDefaultValue=false)]
        public string TipoExcedentePermitido { get; set; }
    
        /// <summary>
        /// Minimum value for the transaction of OperationType
        /// </summary>
        /// <value>Minimum value for the transaction of OperationType</value>
        [DataMember(Name="valorMinimo", EmitDefaultValue=false)]
        public double? ValorMinimo { get; set; }
    
        /// <summary>
        /// Maximum valuie for the transaction of the OperationType
        /// </summary>
        /// <value>Maximum valuie for the transaction of the OperationType</value>
        [DataMember(Name="valorMaximo", EmitDefaultValue=false)]
        public double? ValorMaximo { get; set; }
    
        /// <summary>
        /// TAC value of the transaction of OperationType
        /// </summary>
        /// <value>TAC value of the transaction of OperationType</value>
        [DataMember(Name="valorTAC", EmitDefaultValue=false)]
        public double? ValorTAC { get; set; }
    
        /// <summary>
        /// Flag stripe TAC of the OperationType
        /// </summary>
        /// <value>Flag stripe TAC of the OperationType</value>
        [DataMember(Name="flagTiraTac", EmitDefaultValue=false)]
        public int? FlagTiraTac { get; set; }
    
        /// <summary>
        /// Identifier of the TypeOperation of Product
        /// </summary>
        /// <value>Identifier of the TypeOperation of Product</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// Identifier of the Merchant of OperationType
        /// </summary>
        /// <value>Identifier of the Merchant of OperationType</value>
        [DataMember(Name="idEstabelecimento", EmitDefaultValue=false)]
        public long? IdEstabelecimento { get; set; }
    
        /// <summary>
        /// OperationType fee
        /// </summary>
        /// <value>OperationType fee</value>
        [DataMember(Name="tarifa", EmitDefaultValue=false)]
        public double? Tarifa { get; set; }
    
        /// <summary>
        /// Remunaration of the Issuer for the OperatioType
        /// </summary>
        /// <value>Remunaration of the Issuer for the OperatioType</value>
        [DataMember(Name="remuneracaoEmissor", EmitDefaultValue=false)]
        public double? RemuneracaoEmissor { get; set; }
    
        /// <summary>
        /// Maximum Plan of the OperationType
        /// </summary>
        /// <value>Maximum Plan of the OperationType</value>
        [DataMember(Name="planoMaximo", EmitDefaultValue=false)]
        public int? PlanoMaximo { get; set; }
    
        /// <summary>
        /// Minimum Plan of the OperationType
        /// </summary>
        /// <value>Minimum Plan of the OperationType</value>
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
