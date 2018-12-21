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
    /// Batch Prepaid cards
    /// </summary>
    [DataContract]
    public partial class LoteCartoesPrePagosResponse :  IEquatable<LoteCartoesPrePagosResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LoteCartoesPrePagosResponse" /> class.
        /// Initializes a new instance of the <see cref="LoteCartoesPrePagosResponse" />class.
        /// </summary>
        /// <param name="Id">Identifica??o Code of the pre-paid card batch (id) (required).</param>
        /// <param name="IdOrigemComercial">Identifier code of the Commercial origin (required).</param>
        /// <param name="IdProduto">Identifier Code of the Product (required).</param>
        /// <param name="IdTipoCartao">Identifier Code of the card type (required).</param>
        /// <param name="IdImagem">Identifier code of the card image (required).</param>
        /// <param name="IdEndereco">Identification Code of the address (required).</param>
        /// <param name="Quantidade">Number of existing cards in the batch (required).</param>
        /// <param name="DataCadastro">Register date of the pre-paid card batch (required).</param>
        /// <param name="UsuarioCadastro">Username that created the batch (required).</param>
        /// <param name="StatusProcessamento">Indicate the processin status of the batch (required).</param>
        /// <param name="IdentificadorExterno">External identification number (used by the issuer) (required).</param>

        public LoteCartoesPrePagosResponse(long? Id = null, long? IdOrigemComercial = null, long? IdProduto = null, long? IdTipoCartao = null, long? IdImagem = null, long? IdEndereco = null, int? Quantidade = null, string DataCadastro = null, string UsuarioCadastro = null, int? StatusProcessamento = null, string IdentificadorExterno = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for LoteCartoesPrePagosResponse and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "IdOrigemComercial" is required (not null)
            if (IdOrigemComercial == null)
            {
                throw new InvalidDataException("IdOrigemComercial is a required property for LoteCartoesPrePagosResponse and cannot be null");
            }
            else
            {
                this.IdOrigemComercial = IdOrigemComercial;
            }
            // to ensure "IdProduto" is required (not null)
            if (IdProduto == null)
            {
                throw new InvalidDataException("IdProduto is a required property for LoteCartoesPrePagosResponse and cannot be null");
            }
            else
            {
                this.IdProduto = IdProduto;
            }
            // to ensure "IdTipoCartao" is required (not null)
            if (IdTipoCartao == null)
            {
                throw new InvalidDataException("IdTipoCartao is a required property for LoteCartoesPrePagosResponse and cannot be null");
            }
            else
            {
                this.IdTipoCartao = IdTipoCartao;
            }
            // to ensure "IdImagem" is required (not null)
            if (IdImagem == null)
            {
                throw new InvalidDataException("IdImagem is a required property for LoteCartoesPrePagosResponse and cannot be null");
            }
            else
            {
                this.IdImagem = IdImagem;
            }
            // to ensure "IdEndereco" is required (not null)
            if (IdEndereco == null)
            {
                throw new InvalidDataException("IdEndereco is a required property for LoteCartoesPrePagosResponse and cannot be null");
            }
            else
            {
                this.IdEndereco = IdEndereco;
            }
            // to ensure "Quantidade" is required (not null)
            if (Quantidade == null)
            {
                throw new InvalidDataException("Quantidade is a required property for LoteCartoesPrePagosResponse and cannot be null");
            }
            else
            {
                this.Quantidade = Quantidade;
            }
            // to ensure "DataCadastro" is required (not null)
            if (DataCadastro == null)
            {
                throw new InvalidDataException("DataCadastro is a required property for LoteCartoesPrePagosResponse and cannot be null");
            }
            else
            {
                this.DataCadastro = DataCadastro;
            }
            // to ensure "UsuarioCadastro" is required (not null)
            if (UsuarioCadastro == null)
            {
                throw new InvalidDataException("UsuarioCadastro is a required property for LoteCartoesPrePagosResponse and cannot be null");
            }
            else
            {
                this.UsuarioCadastro = UsuarioCadastro;
            }
            // to ensure "StatusProcessamento" is required (not null)
            if (StatusProcessamento == null)
            {
                throw new InvalidDataException("StatusProcessamento is a required property for LoteCartoesPrePagosResponse and cannot be null");
            }
            else
            {
                this.StatusProcessamento = StatusProcessamento;
            }
            // to ensure "IdentificadorExterno" is required (not null)
            if (IdentificadorExterno == null)
            {
                throw new InvalidDataException("IdentificadorExterno is a required property for LoteCartoesPrePagosResponse and cannot be null");
            }
            else
            {
                this.IdentificadorExterno = IdentificadorExterno;
            }
            
        }
        
    
        /// <summary>
        /// Identifica??o Code of the pre-paid card batch (id)
        /// </summary>
        /// <value>Identifica??o Code of the pre-paid card batch (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Identifier code of the Commercial origin
        /// </summary>
        /// <value>Identifier code of the Commercial origin</value>
        [DataMember(Name="idOrigemComercial", EmitDefaultValue=false)]
        public long? IdOrigemComercial { get; set; }
    
        /// <summary>
        /// Identifier Code of the Product
        /// </summary>
        /// <value>Identifier Code of the Product</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// Identifier Code of the card type
        /// </summary>
        /// <value>Identifier Code of the card type</value>
        [DataMember(Name="idTipoCartao", EmitDefaultValue=false)]
        public long? IdTipoCartao { get; set; }
    
        /// <summary>
        /// Identifier code of the card image
        /// </summary>
        /// <value>Identifier code of the card image</value>
        [DataMember(Name="idImagem", EmitDefaultValue=false)]
        public long? IdImagem { get; set; }
    
        /// <summary>
        /// Identification Code of the address
        /// </summary>
        /// <value>Identification Code of the address</value>
        [DataMember(Name="idEndereco", EmitDefaultValue=false)]
        public long? IdEndereco { get; set; }
    
        /// <summary>
        /// Number of existing cards in the batch
        /// </summary>
        /// <value>Number of existing cards in the batch</value>
        [DataMember(Name="quantidade", EmitDefaultValue=false)]
        public int? Quantidade { get; set; }
    
        /// <summary>
        /// Register date of the pre-paid card batch
        /// </summary>
        /// <value>Register date of the pre-paid card batch</value>
        [DataMember(Name="dataCadastro", EmitDefaultValue=false)]
        public string DataCadastro { get; set; }
    
        /// <summary>
        /// Username that created the batch
        /// </summary>
        /// <value>Username that created the batch</value>
        [DataMember(Name="usuarioCadastro", EmitDefaultValue=false)]
        public string UsuarioCadastro { get; set; }
    
        /// <summary>
        /// Indicate the processin status of the batch
        /// </summary>
        /// <value>Indicate the processin status of the batch</value>
        [DataMember(Name="statusProcessamento", EmitDefaultValue=false)]
        public int? StatusProcessamento { get; set; }
    
        /// <summary>
        /// External identification number (used by the issuer)
        /// </summary>
        /// <value>External identification number (used by the issuer)</value>
        [DataMember(Name="identificadorExterno", EmitDefaultValue=false)]
        public string IdentificadorExterno { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoteCartoesPrePagosResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdOrigemComercial: ").Append(IdOrigemComercial).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  IdTipoCartao: ").Append(IdTipoCartao).Append("\n");
            sb.Append("  IdImagem: ").Append(IdImagem).Append("\n");
            sb.Append("  IdEndereco: ").Append(IdEndereco).Append("\n");
            sb.Append("  Quantidade: ").Append(Quantidade).Append("\n");
            sb.Append("  DataCadastro: ").Append(DataCadastro).Append("\n");
            sb.Append("  UsuarioCadastro: ").Append(UsuarioCadastro).Append("\n");
            sb.Append("  StatusProcessamento: ").Append(StatusProcessamento).Append("\n");
            sb.Append("  IdentificadorExterno: ").Append(IdentificadorExterno).Append("\n");
            
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
            return this.Equals(obj as LoteCartoesPrePagosResponse);
        }

        /// <summary>
        /// Returns true if LoteCartoesPrePagosResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of LoteCartoesPrePagosResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoteCartoesPrePagosResponse other)
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
                    this.IdOrigemComercial == other.IdOrigemComercial ||
                    this.IdOrigemComercial != null &&
                    this.IdOrigemComercial.Equals(other.IdOrigemComercial)
                ) && 
                (
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.IdTipoCartao == other.IdTipoCartao ||
                    this.IdTipoCartao != null &&
                    this.IdTipoCartao.Equals(other.IdTipoCartao)
                ) && 
                (
                    this.IdImagem == other.IdImagem ||
                    this.IdImagem != null &&
                    this.IdImagem.Equals(other.IdImagem)
                ) && 
                (
                    this.IdEndereco == other.IdEndereco ||
                    this.IdEndereco != null &&
                    this.IdEndereco.Equals(other.IdEndereco)
                ) && 
                (
                    this.Quantidade == other.Quantidade ||
                    this.Quantidade != null &&
                    this.Quantidade.Equals(other.Quantidade)
                ) && 
                (
                    this.DataCadastro == other.DataCadastro ||
                    this.DataCadastro != null &&
                    this.DataCadastro.Equals(other.DataCadastro)
                ) && 
                (
                    this.UsuarioCadastro == other.UsuarioCadastro ||
                    this.UsuarioCadastro != null &&
                    this.UsuarioCadastro.Equals(other.UsuarioCadastro)
                ) && 
                (
                    this.StatusProcessamento == other.StatusProcessamento ||
                    this.StatusProcessamento != null &&
                    this.StatusProcessamento.Equals(other.StatusProcessamento)
                ) && 
                (
                    this.IdentificadorExterno == other.IdentificadorExterno ||
                    this.IdentificadorExterno != null &&
                    this.IdentificadorExterno.Equals(other.IdentificadorExterno)
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
                
                if (this.IdOrigemComercial != null)
                    hash = hash * 59 + this.IdOrigemComercial.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.IdTipoCartao != null)
                    hash = hash * 59 + this.IdTipoCartao.GetHashCode();
                
                if (this.IdImagem != null)
                    hash = hash * 59 + this.IdImagem.GetHashCode();
                
                if (this.IdEndereco != null)
                    hash = hash * 59 + this.IdEndereco.GetHashCode();
                
                if (this.Quantidade != null)
                    hash = hash * 59 + this.Quantidade.GetHashCode();
                
                if (this.DataCadastro != null)
                    hash = hash * 59 + this.DataCadastro.GetHashCode();
                
                if (this.UsuarioCadastro != null)
                    hash = hash * 59 + this.UsuarioCadastro.GetHashCode();
                
                if (this.StatusProcessamento != null)
                    hash = hash * 59 + this.StatusProcessamento.GetHashCode();
                
                if (this.IdentificadorExterno != null)
                    hash = hash * 59 + this.IdentificadorExterno.GetHashCode();
                
                return hash;
            }
        }

    }
}
