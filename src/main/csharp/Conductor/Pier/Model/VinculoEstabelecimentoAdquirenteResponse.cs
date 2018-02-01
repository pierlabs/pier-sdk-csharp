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
    /// Objeto de resposta do VinculoEstabelecimentoAdquirente
    /// </summary>
    [DataContract]
    public partial class VinculoEstabelecimentoAdquirenteResponse :  IEquatable<VinculoEstabelecimentoAdquirenteResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VinculoEstabelecimentoAdquirenteResponse" /> class.
        /// Initializes a new instance of the <see cref="VinculoEstabelecimentoAdquirenteResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do VinculoEstabelecimentoAdquirente (id)..</param>
        /// <param name="IdEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento (id)..</param>
        /// <param name="IdAdquirente">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Adquirente (id)..</param>
        /// <param name="CodigoEstabelecimentoAdquirente">C\u00C3\u00B3digo do v\u00C3\u00ADnculo entre o estabelecimento e o adquirente..</param>
        /// <param name="DataHoraCadastro">Data de cadastro do v\u00C3\u00ADnculo..</param>
        /// <param name="Mensagem">Data de cadastro do v\u00C3\u00ADnculo..</param>
        /// <param name="Status">Data de cadastro do v\u00C3\u00ADnculo..</param>

        public VinculoEstabelecimentoAdquirenteResponse(long? Id = null, long? IdEstabelecimento = null, long? IdAdquirente = null, string CodigoEstabelecimentoAdquirente = null, string DataHoraCadastro = null, string Mensagem = null, int? Status = null)
        {
            this.Id = Id;
            this.IdEstabelecimento = IdEstabelecimento;
            this.IdAdquirente = IdAdquirente;
            this.CodigoEstabelecimentoAdquirente = CodigoEstabelecimentoAdquirente;
            this.DataHoraCadastro = DataHoraCadastro;
            this.Mensagem = Mensagem;
            this.Status = Status;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do VinculoEstabelecimentoAdquirente (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do VinculoEstabelecimentoAdquirente (id).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento (id).</value>
        [DataMember(Name="idEstabelecimento", EmitDefaultValue=false)]
        public long? IdEstabelecimento { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Adquirente (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Adquirente (id).</value>
        [DataMember(Name="idAdquirente", EmitDefaultValue=false)]
        public long? IdAdquirente { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo do v\u00C3\u00ADnculo entre o estabelecimento e o adquirente.
        /// </summary>
        /// <value>C\u00C3\u00B3digo do v\u00C3\u00ADnculo entre o estabelecimento e o adquirente.</value>
        [DataMember(Name="codigoEstabelecimentoAdquirente", EmitDefaultValue=false)]
        public string CodigoEstabelecimentoAdquirente { get; set; }
    
        /// <summary>
        /// Data de cadastro do v\u00C3\u00ADnculo.
        /// </summary>
        /// <value>Data de cadastro do v\u00C3\u00ADnculo.</value>
        [DataMember(Name="dataHoraCadastro", EmitDefaultValue=false)]
        public string DataHoraCadastro { get; set; }
    
        /// <summary>
        /// Data de cadastro do v\u00C3\u00ADnculo.
        /// </summary>
        /// <value>Data de cadastro do v\u00C3\u00ADnculo.</value>
        [DataMember(Name="mensagem", EmitDefaultValue=false)]
        public string Mensagem { get; set; }
    
        /// <summary>
        /// Data de cadastro do v\u00C3\u00ADnculo.
        /// </summary>
        /// <value>Data de cadastro do v\u00C3\u00ADnculo.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VinculoEstabelecimentoAdquirenteResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdEstabelecimento: ").Append(IdEstabelecimento).Append("\n");
            sb.Append("  IdAdquirente: ").Append(IdAdquirente).Append("\n");
            sb.Append("  CodigoEstabelecimentoAdquirente: ").Append(CodigoEstabelecimentoAdquirente).Append("\n");
            sb.Append("  DataHoraCadastro: ").Append(DataHoraCadastro).Append("\n");
            sb.Append("  Mensagem: ").Append(Mensagem).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            
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
            return this.Equals(obj as VinculoEstabelecimentoAdquirenteResponse);
        }

        /// <summary>
        /// Returns true if VinculoEstabelecimentoAdquirenteResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of VinculoEstabelecimentoAdquirenteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VinculoEstabelecimentoAdquirenteResponse other)
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
                    this.IdEstabelecimento == other.IdEstabelecimento ||
                    this.IdEstabelecimento != null &&
                    this.IdEstabelecimento.Equals(other.IdEstabelecimento)
                ) && 
                (
                    this.IdAdquirente == other.IdAdquirente ||
                    this.IdAdquirente != null &&
                    this.IdAdquirente.Equals(other.IdAdquirente)
                ) && 
                (
                    this.CodigoEstabelecimentoAdquirente == other.CodigoEstabelecimentoAdquirente ||
                    this.CodigoEstabelecimentoAdquirente != null &&
                    this.CodigoEstabelecimentoAdquirente.Equals(other.CodigoEstabelecimentoAdquirente)
                ) && 
                (
                    this.DataHoraCadastro == other.DataHoraCadastro ||
                    this.DataHoraCadastro != null &&
                    this.DataHoraCadastro.Equals(other.DataHoraCadastro)
                ) && 
                (
                    this.Mensagem == other.Mensagem ||
                    this.Mensagem != null &&
                    this.Mensagem.Equals(other.Mensagem)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                
                if (this.IdEstabelecimento != null)
                    hash = hash * 59 + this.IdEstabelecimento.GetHashCode();
                
                if (this.IdAdquirente != null)
                    hash = hash * 59 + this.IdAdquirente.GetHashCode();
                
                if (this.CodigoEstabelecimentoAdquirente != null)
                    hash = hash * 59 + this.CodigoEstabelecimentoAdquirente.GetHashCode();
                
                if (this.DataHoraCadastro != null)
                    hash = hash * 59 + this.DataHoraCadastro.GetHashCode();
                
                if (this.Mensagem != null)
                    hash = hash * 59 + this.Mensagem.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }
}
