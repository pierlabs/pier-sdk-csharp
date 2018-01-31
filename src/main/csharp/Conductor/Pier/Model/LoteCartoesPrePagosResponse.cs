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
    /// Lote Cart\u00C3\u00B5es Pr\u00C3\u00A9-Pagos
    /// </summary>
    [DataContract]
    public partial class LoteCartoesPrePagosResponse :  IEquatable<LoteCartoesPrePagosResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LoteCartoesPrePagosResponse" /> class.
        /// Initializes a new instance of the <see cref="LoteCartoesPrePagosResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do lote de cart\u00C3\u00B5es pr\u00C3\u00A9-pagos (id). (required).</param>
        /// <param name="IdOrigemComercial">C\u00C3\u00B3digo identificador da origem comercial. (required).</param>
        /// <param name="IdProduto">C\u00C3\u00B3digo identificador do Produto. (required).</param>
        /// <param name="IdTipoCartao">C\u00C3\u00B3digo identificador do tipo do cart\u00C3\u00A3o. (required).</param>
        /// <param name="IdImagem">C\u00C3\u00B3digo identificador da Imagem do cart\u00C3\u00A3o. (required).</param>
        /// <param name="IdEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o. (required).</param>
        /// <param name="Quantidade">N\u00C3\u00BAmero de cart\u00C3\u00B5es existentes no Lote. (required).</param>
        /// <param name="DataCadastro">Data de cadastro do lote de cart\u00C3\u00B5es pr\u00C3\u00A9-pagos. (required).</param>
        /// <param name="UsuarioCadastro">Nome do usu\u00C3\u00A1rio que criou o lote. (required).</param>
        /// <param name="StatusProcessamento">Indica o status de processamento do lote. (required).</param>
        /// <param name="IdentificadorExterno">N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o externo (utilizado pelo emissor). (required).</param>

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
        /// C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do lote de cart\u00C3\u00B5es pr\u00C3\u00A9-pagos (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do lote de cart\u00C3\u00B5es pr\u00C3\u00A9-pagos (id).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador da origem comercial.
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador da origem comercial.</value>
        [DataMember(Name="idOrigemComercial", EmitDefaultValue=false)]
        public long? IdOrigemComercial { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador do Produto.
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador do Produto.</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador do tipo do cart\u00C3\u00A3o.
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador do tipo do cart\u00C3\u00A3o.</value>
        [DataMember(Name="idTipoCartao", EmitDefaultValue=false)]
        public long? IdTipoCartao { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador da Imagem do cart\u00C3\u00A3o.
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador da Imagem do cart\u00C3\u00A3o.</value>
        [DataMember(Name="idImagem", EmitDefaultValue=false)]
        public long? IdImagem { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o.</value>
        [DataMember(Name="idEndereco", EmitDefaultValue=false)]
        public long? IdEndereco { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero de cart\u00C3\u00B5es existentes no Lote.
        /// </summary>
        /// <value>N\u00C3\u00BAmero de cart\u00C3\u00B5es existentes no Lote.</value>
        [DataMember(Name="quantidade", EmitDefaultValue=false)]
        public int? Quantidade { get; set; }
    
        /// <summary>
        /// Data de cadastro do lote de cart\u00C3\u00B5es pr\u00C3\u00A9-pagos.
        /// </summary>
        /// <value>Data de cadastro do lote de cart\u00C3\u00B5es pr\u00C3\u00A9-pagos.</value>
        [DataMember(Name="dataCadastro", EmitDefaultValue=false)]
        public string DataCadastro { get; set; }
    
        /// <summary>
        /// Nome do usu\u00C3\u00A1rio que criou o lote.
        /// </summary>
        /// <value>Nome do usu\u00C3\u00A1rio que criou o lote.</value>
        [DataMember(Name="usuarioCadastro", EmitDefaultValue=false)]
        public string UsuarioCadastro { get; set; }
    
        /// <summary>
        /// Indica o status de processamento do lote.
        /// </summary>
        /// <value>Indica o status de processamento do lote.</value>
        [DataMember(Name="statusProcessamento", EmitDefaultValue=false)]
        public int? StatusProcessamento { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o externo (utilizado pelo emissor).
        /// </summary>
        /// <value>N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o externo (utilizado pelo emissor).</value>
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
