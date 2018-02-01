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
    /// Objeto de Resposta de Maquineta
    /// </summary>
    [DataContract]
    public partial class MaquinetaResponse :  IEquatable<MaquinetaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MaquinetaResponse" /> class.
        /// Initializes a new instance of the <see cref="MaquinetaResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Maquineta..</param>
        /// <param name="IdEstabelecimento">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do EStabelecimento..</param>
        /// <param name="IdTipoMaquineta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo Maquineta..</param>
        /// <param name="Valor">Valor de manuten\u00C3\u00A7\u00C3\u00A3o da Maquineta..</param>
        /// <param name="DataHoraImplantacao">Data de implanta\u00C3\u00A7\u00C3\u00A3o da Maquineta..</param>
        /// <param name="DataHoraCadastramento">Data de cadastramento da Maquineta..</param>
        /// <param name="Terminal">N\u00C3\u00BAmero do terminal vinculado a Maquineta..</param>
        /// <param name="UsuarioApl">Usu\u00C3\u00A1rio da aplica\u00C3\u00A7\u00C3\u00A3o..</param>

        public MaquinetaResponse(long? Id = null, long? IdEstabelecimento = null, long? IdTipoMaquineta = null, double? Valor = null, string DataHoraImplantacao = null, string DataHoraCadastramento = null, string Terminal = null, string UsuarioApl = null)
        {
            this.Id = Id;
            this.IdEstabelecimento = IdEstabelecimento;
            this.IdTipoMaquineta = IdTipoMaquineta;
            this.Valor = Valor;
            this.DataHoraImplantacao = DataHoraImplantacao;
            this.DataHoraCadastramento = DataHoraCadastramento;
            this.Terminal = Terminal;
            this.UsuarioApl = UsuarioApl;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Maquineta.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Maquineta.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do EStabelecimento.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do EStabelecimento.</value>
        [DataMember(Name="idEstabelecimento", EmitDefaultValue=false)]
        public long? IdEstabelecimento { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo Maquineta.
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo Maquineta.</value>
        [DataMember(Name="idTipoMaquineta", EmitDefaultValue=false)]
        public long? IdTipoMaquineta { get; set; }
    
        /// <summary>
        /// Valor de manuten\u00C3\u00A7\u00C3\u00A3o da Maquineta.
        /// </summary>
        /// <value>Valor de manuten\u00C3\u00A7\u00C3\u00A3o da Maquineta.</value>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }
    
        /// <summary>
        /// Data de implanta\u00C3\u00A7\u00C3\u00A3o da Maquineta.
        /// </summary>
        /// <value>Data de implanta\u00C3\u00A7\u00C3\u00A3o da Maquineta.</value>
        [DataMember(Name="dataHoraImplantacao", EmitDefaultValue=false)]
        public string DataHoraImplantacao { get; set; }
    
        /// <summary>
        /// Data de cadastramento da Maquineta.
        /// </summary>
        /// <value>Data de cadastramento da Maquineta.</value>
        [DataMember(Name="dataHoraCadastramento", EmitDefaultValue=false)]
        public string DataHoraCadastramento { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero do terminal vinculado a Maquineta.
        /// </summary>
        /// <value>N\u00C3\u00BAmero do terminal vinculado a Maquineta.</value>
        [DataMember(Name="terminal", EmitDefaultValue=false)]
        public string Terminal { get; set; }
    
        /// <summary>
        /// Usu\u00C3\u00A1rio da aplica\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <value>Usu\u00C3\u00A1rio da aplica\u00C3\u00A7\u00C3\u00A3o.</value>
        [DataMember(Name="usuarioApl", EmitDefaultValue=false)]
        public string UsuarioApl { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MaquinetaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdEstabelecimento: ").Append(IdEstabelecimento).Append("\n");
            sb.Append("  IdTipoMaquineta: ").Append(IdTipoMaquineta).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  DataHoraImplantacao: ").Append(DataHoraImplantacao).Append("\n");
            sb.Append("  DataHoraCadastramento: ").Append(DataHoraCadastramento).Append("\n");
            sb.Append("  Terminal: ").Append(Terminal).Append("\n");
            sb.Append("  UsuarioApl: ").Append(UsuarioApl).Append("\n");
            
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
            return this.Equals(obj as MaquinetaResponse);
        }

        /// <summary>
        /// Returns true if MaquinetaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of MaquinetaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MaquinetaResponse other)
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
                    this.IdTipoMaquineta == other.IdTipoMaquineta ||
                    this.IdTipoMaquineta != null &&
                    this.IdTipoMaquineta.Equals(other.IdTipoMaquineta)
                ) && 
                (
                    this.Valor == other.Valor ||
                    this.Valor != null &&
                    this.Valor.Equals(other.Valor)
                ) && 
                (
                    this.DataHoraImplantacao == other.DataHoraImplantacao ||
                    this.DataHoraImplantacao != null &&
                    this.DataHoraImplantacao.Equals(other.DataHoraImplantacao)
                ) && 
                (
                    this.DataHoraCadastramento == other.DataHoraCadastramento ||
                    this.DataHoraCadastramento != null &&
                    this.DataHoraCadastramento.Equals(other.DataHoraCadastramento)
                ) && 
                (
                    this.Terminal == other.Terminal ||
                    this.Terminal != null &&
                    this.Terminal.Equals(other.Terminal)
                ) && 
                (
                    this.UsuarioApl == other.UsuarioApl ||
                    this.UsuarioApl != null &&
                    this.UsuarioApl.Equals(other.UsuarioApl)
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
                
                if (this.IdTipoMaquineta != null)
                    hash = hash * 59 + this.IdTipoMaquineta.GetHashCode();
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
                if (this.DataHoraImplantacao != null)
                    hash = hash * 59 + this.DataHoraImplantacao.GetHashCode();
                
                if (this.DataHoraCadastramento != null)
                    hash = hash * 59 + this.DataHoraCadastramento.GetHashCode();
                
                if (this.Terminal != null)
                    hash = hash * 59 + this.Terminal.GetHashCode();
                
                if (this.UsuarioApl != null)
                    hash = hash * 59 + this.UsuarioApl.GetHashCode();
                
                return hash;
            }
        }

    }
}
