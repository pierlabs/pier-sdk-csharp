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
    /// Objeto Response da auditoria do arquivo.
    /// </summary>
    [DataContract]
    public partial class ArquivoAUDResponse :  IEquatable<ArquivoAUDResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ArquivoAUDResponse" /> class.
        /// Initializes a new instance of the <see cref="ArquivoAUDResponse" />class.
        /// </summary>
        /// <param name="Rev">Identificador da auditoria arquivo.</param>
        /// <param name="RevType">Identificador do tipo de auditoria (0 - Criado, 1 - Alterado, 2 - Exclu\u00C3\u00ADdo).</param>
        /// <param name="Id">Identificador do arquivo auditado.</param>
        /// <param name="Nome">Nome do arquivo auditado.</param>
        /// <param name="IdRespostaAcessoDigital">Identificador da resposta da Acesso Digital.</param>
        /// <param name="DataHoraRespostaAcessoDigital">Data de resposta da Acesso Digital.</param>
        /// <param name="IdRespostaNeurotech">Identificador da resposta da Neurotech.</param>
        /// <param name="DataHoraRespostaNeurotech">Data de resposta da Neurotech.</param>
        /// <param name="Uri">Uri de acesso.</param>
        /// <param name="DataHoraInclusao">Data de inclus\u00C3\u00A3o do arquivo auditado.</param>
        /// <param name="DataHoraAlteracao">Data de altera\u00C3\u00A7\u00C3\u00A3o do arquivo auditado.</param>
        /// <param name="Extensao">Extens\u00C3\u00A3o do arquivo auditado.</param>
        /// <param name="Parametros">Lista  de par\u00C3\u00A2metros do arquivo auditado.</param>

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
        /// Identificador da auditoria arquivo
        /// </summary>
        /// <value>Identificador da auditoria arquivo</value>
        [DataMember(Name="rev", EmitDefaultValue=false)]
        public long? Rev { get; set; }
    
        /// <summary>
        /// Identificador do tipo de auditoria (0 - Criado, 1 - Alterado, 2 - Exclu\u00C3\u00ADdo)
        /// </summary>
        /// <value>Identificador do tipo de auditoria (0 - Criado, 1 - Alterado, 2 - Exclu\u00C3\u00ADdo)</value>
        [DataMember(Name="revType", EmitDefaultValue=false)]
        public int? RevType { get; set; }
    
        /// <summary>
        /// Identificador do arquivo auditado
        /// </summary>
        /// <value>Identificador do arquivo auditado</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Nome do arquivo auditado
        /// </summary>
        /// <value>Nome do arquivo auditado</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Identificador da resposta da Acesso Digital
        /// </summary>
        /// <value>Identificador da resposta da Acesso Digital</value>
        [DataMember(Name="idRespostaAcessoDigital", EmitDefaultValue=false)]
        public string IdRespostaAcessoDigital { get; set; }
    
        /// <summary>
        /// Data de resposta da Acesso Digital
        /// </summary>
        /// <value>Data de resposta da Acesso Digital</value>
        [DataMember(Name="dataHoraRespostaAcessoDigital", EmitDefaultValue=false)]
        public string DataHoraRespostaAcessoDigital { get; set; }
    
        /// <summary>
        /// Identificador da resposta da Neurotech
        /// </summary>
        /// <value>Identificador da resposta da Neurotech</value>
        [DataMember(Name="idRespostaNeurotech", EmitDefaultValue=false)]
        public string IdRespostaNeurotech { get; set; }
    
        /// <summary>
        /// Data de resposta da Neurotech
        /// </summary>
        /// <value>Data de resposta da Neurotech</value>
        [DataMember(Name="dataHoraRespostaNeurotech", EmitDefaultValue=false)]
        public string DataHoraRespostaNeurotech { get; set; }
    
        /// <summary>
        /// Uri de acesso
        /// </summary>
        /// <value>Uri de acesso</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
    
        /// <summary>
        /// Data de inclus\u00C3\u00A3o do arquivo auditado
        /// </summary>
        /// <value>Data de inclus\u00C3\u00A3o do arquivo auditado</value>
        [DataMember(Name="dataHoraInclusao", EmitDefaultValue=false)]
        public string DataHoraInclusao { get; set; }
    
        /// <summary>
        /// Data de altera\u00C3\u00A7\u00C3\u00A3o do arquivo auditado
        /// </summary>
        /// <value>Data de altera\u00C3\u00A7\u00C3\u00A3o do arquivo auditado</value>
        [DataMember(Name="dataHoraAlteracao", EmitDefaultValue=false)]
        public string DataHoraAlteracao { get; set; }
    
        /// <summary>
        /// Extens\u00C3\u00A3o do arquivo auditado
        /// </summary>
        /// <value>Extens\u00C3\u00A3o do arquivo auditado</value>
        [DataMember(Name="extensao", EmitDefaultValue=false)]
        public string Extensao { get; set; }
    
        /// <summary>
        /// Lista  de par\u00C3\u00A2metros do arquivo auditado
        /// </summary>
        /// <value>Lista  de par\u00C3\u00A2metros do arquivo auditado</value>
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
