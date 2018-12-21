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
    /// Object Response of the file auditorial
    /// </summary>
    [DataContract]
    public partial class ArquivoAUDResponse :  IEquatable<ArquivoAUDResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ArquivoAUDResponse" /> class.
        /// Initializes a new instance of the <see cref="ArquivoAUDResponse" />class.
        /// </summary>
        /// <param name="Rev">Identifier of the auditorail File.</param>
        /// <param name="RevType">Identifier of the auditorial type (0 - Created, 1 - Updated, 2 - Excluded).</param>
        /// <param name="Id">Identifier of the audited file.</param>
        /// <param name="Nome">File name audited.</param>
        /// <param name="IdRespostaAcessoDigital">Identifier of the answer of the Digital Access.</param>
        /// <param name="DataHoraRespostaAcessoDigital">Date of response of the Digital Access.</param>
        /// <param name="IdRespostaNeurotech">Identifier of the response of Neurotech.</param>
        /// <param name="DataHoraRespostaNeurotech">Date of response of the Neurotech.</param>
        /// <param name="Uri">Uri of access.</param>
        /// <param name="DataHoraInclusao">Date of inclusion of the audited file.</param>
        /// <param name="DataHoraAlteracao">Date of the audited file update.</param>
        /// <param name="Extensao">Extension of the audited file.</param>
        /// <param name="Parametros">List of parameter of the audited file.</param>

        public ArquivoAUDResponse(long? Rev = null, int? RevType = null, long? Id = null, string Nome = null, string IdRespostaAcessoDigital = null, string DataHoraRespostaAcessoDigital = null, string IdRespostaNeurotech = null, string DataHoraRespostaNeurotech = null, string Uri = null, string DataHoraInclusao = null, string DataHoraAlteracao = null, string Extensao = null, List<ArquivoParametroAUDResponse> Parametros = null)
        {
            this.Rev = Rev;
            this.RevType = RevType;
            this.Id = Id;
            this.Nome = Nome;
            this.IdRespostaAcessoDigital = IdRespostaAcessoDigital;
            this.DataHoraRespostaAcessoDigital = DataHoraRespostaAcessoDigital;
            this.IdRespostaNeurotech = IdRespostaNeurotech;
            this.DataHoraRespostaNeurotech = DataHoraRespostaNeurotech;
            this.Uri = Uri;
            this.DataHoraInclusao = DataHoraInclusao;
            this.DataHoraAlteracao = DataHoraAlteracao;
            this.Extensao = Extensao;
            this.Parametros = Parametros;
            
        }
        
    
        /// <summary>
        /// Identifier of the auditorail File
        /// </summary>
        /// <value>Identifier of the auditorail File</value>
        [DataMember(Name="rev", EmitDefaultValue=false)]
        public long? Rev { get; set; }
    
        /// <summary>
        /// Identifier of the auditorial type (0 - Created, 1 - Updated, 2 - Excluded)
        /// </summary>
        /// <value>Identifier of the auditorial type (0 - Created, 1 - Updated, 2 - Excluded)</value>
        [DataMember(Name="revType", EmitDefaultValue=false)]
        public int? RevType { get; set; }
    
        /// <summary>
        /// Identifier of the audited file
        /// </summary>
        /// <value>Identifier of the audited file</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// File name audited
        /// </summary>
        /// <value>File name audited</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Identifier of the answer of the Digital Access
        /// </summary>
        /// <value>Identifier of the answer of the Digital Access</value>
        [DataMember(Name="idRespostaAcessoDigital", EmitDefaultValue=false)]
        public string IdRespostaAcessoDigital { get; set; }
    
        /// <summary>
        /// Date of response of the Digital Access
        /// </summary>
        /// <value>Date of response of the Digital Access</value>
        [DataMember(Name="dataHoraRespostaAcessoDigital", EmitDefaultValue=false)]
        public string DataHoraRespostaAcessoDigital { get; set; }
    
        /// <summary>
        /// Identifier of the response of Neurotech
        /// </summary>
        /// <value>Identifier of the response of Neurotech</value>
        [DataMember(Name="idRespostaNeurotech", EmitDefaultValue=false)]
        public string IdRespostaNeurotech { get; set; }
    
        /// <summary>
        /// Date of response of the Neurotech
        /// </summary>
        /// <value>Date of response of the Neurotech</value>
        [DataMember(Name="dataHoraRespostaNeurotech", EmitDefaultValue=false)]
        public string DataHoraRespostaNeurotech { get; set; }
    
        /// <summary>
        /// Uri of access
        /// </summary>
        /// <value>Uri of access</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
    
        /// <summary>
        /// Date of inclusion of the audited file
        /// </summary>
        /// <value>Date of inclusion of the audited file</value>
        [DataMember(Name="dataHoraInclusao", EmitDefaultValue=false)]
        public string DataHoraInclusao { get; set; }
    
        /// <summary>
        /// Date of the audited file update
        /// </summary>
        /// <value>Date of the audited file update</value>
        [DataMember(Name="dataHoraAlteracao", EmitDefaultValue=false)]
        public string DataHoraAlteracao { get; set; }
    
        /// <summary>
        /// Extension of the audited file
        /// </summary>
        /// <value>Extension of the audited file</value>
        [DataMember(Name="extensao", EmitDefaultValue=false)]
        public string Extensao { get; set; }
    
        /// <summary>
        /// List of parameter of the audited file
        /// </summary>
        /// <value>List of parameter of the audited file</value>
        [DataMember(Name="parametros", EmitDefaultValue=false)]
        public List<ArquivoParametroAUDResponse> Parametros { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArquivoAUDResponse {\n");
            sb.Append("  Rev: ").Append(Rev).Append("\n");
            sb.Append("  RevType: ").Append(RevType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  IdRespostaAcessoDigital: ").Append(IdRespostaAcessoDigital).Append("\n");
            sb.Append("  DataHoraRespostaAcessoDigital: ").Append(DataHoraRespostaAcessoDigital).Append("\n");
            sb.Append("  IdRespostaNeurotech: ").Append(IdRespostaNeurotech).Append("\n");
            sb.Append("  DataHoraRespostaNeurotech: ").Append(DataHoraRespostaNeurotech).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  DataHoraInclusao: ").Append(DataHoraInclusao).Append("\n");
            sb.Append("  DataHoraAlteracao: ").Append(DataHoraAlteracao).Append("\n");
            sb.Append("  Extensao: ").Append(Extensao).Append("\n");
            sb.Append("  Parametros: ").Append(Parametros).Append("\n");
            
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
            return this.Equals(obj as ArquivoAUDResponse);
        }

        /// <summary>
        /// Returns true if ArquivoAUDResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ArquivoAUDResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArquivoAUDResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Rev == other.Rev ||
                    this.Rev != null &&
                    this.Rev.Equals(other.Rev)
                ) && 
                (
                    this.RevType == other.RevType ||
                    this.RevType != null &&
                    this.RevType.Equals(other.RevType)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.IdRespostaAcessoDigital == other.IdRespostaAcessoDigital ||
                    this.IdRespostaAcessoDigital != null &&
                    this.IdRespostaAcessoDigital.Equals(other.IdRespostaAcessoDigital)
                ) && 
                (
                    this.DataHoraRespostaAcessoDigital == other.DataHoraRespostaAcessoDigital ||
                    this.DataHoraRespostaAcessoDigital != null &&
                    this.DataHoraRespostaAcessoDigital.Equals(other.DataHoraRespostaAcessoDigital)
                ) && 
                (
                    this.IdRespostaNeurotech == other.IdRespostaNeurotech ||
                    this.IdRespostaNeurotech != null &&
                    this.IdRespostaNeurotech.Equals(other.IdRespostaNeurotech)
                ) && 
                (
                    this.DataHoraRespostaNeurotech == other.DataHoraRespostaNeurotech ||
                    this.DataHoraRespostaNeurotech != null &&
                    this.DataHoraRespostaNeurotech.Equals(other.DataHoraRespostaNeurotech)
                ) && 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
                ) && 
                (
                    this.DataHoraInclusao == other.DataHoraInclusao ||
                    this.DataHoraInclusao != null &&
                    this.DataHoraInclusao.Equals(other.DataHoraInclusao)
                ) && 
                (
                    this.DataHoraAlteracao == other.DataHoraAlteracao ||
                    this.DataHoraAlteracao != null &&
                    this.DataHoraAlteracao.Equals(other.DataHoraAlteracao)
                ) && 
                (
                    this.Extensao == other.Extensao ||
                    this.Extensao != null &&
                    this.Extensao.Equals(other.Extensao)
                ) && 
                (
                    this.Parametros == other.Parametros ||
                    this.Parametros != null &&
                    this.Parametros.SequenceEqual(other.Parametros)
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
                
                if (this.Rev != null)
                    hash = hash * 59 + this.Rev.GetHashCode();
                
                if (this.RevType != null)
                    hash = hash * 59 + this.RevType.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.IdRespostaAcessoDigital != null)
                    hash = hash * 59 + this.IdRespostaAcessoDigital.GetHashCode();
                
                if (this.DataHoraRespostaAcessoDigital != null)
                    hash = hash * 59 + this.DataHoraRespostaAcessoDigital.GetHashCode();
                
                if (this.IdRespostaNeurotech != null)
                    hash = hash * 59 + this.IdRespostaNeurotech.GetHashCode();
                
                if (this.DataHoraRespostaNeurotech != null)
                    hash = hash * 59 + this.DataHoraRespostaNeurotech.GetHashCode();
                
                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                
                if (this.DataHoraInclusao != null)
                    hash = hash * 59 + this.DataHoraInclusao.GetHashCode();
                
                if (this.DataHoraAlteracao != null)
                    hash = hash * 59 + this.DataHoraAlteracao.GetHashCode();
                
                if (this.Extensao != null)
                    hash = hash * 59 + this.Extensao.GetHashCode();
                
                if (this.Parametros != null)
                    hash = hash * 59 + this.Parametros.GetHashCode();
                
                return hash;
            }
        }

    }
}
