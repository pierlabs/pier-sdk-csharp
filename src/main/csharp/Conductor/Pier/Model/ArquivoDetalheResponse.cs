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
    /// Objeto Response do arquivo
    /// </summary>
    [DataContract]
    public partial class ArquivoDetalheResponse :  IEquatable<ArquivoDetalheResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ArquivoDetalheResponse" /> class.
        /// Initializes a new instance of the <see cref="ArquivoDetalheResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo de identifica\u00E7\u00E3o do arquivo.</param>
        /// <param name="IdTipoArquivo">C\u00F3digo de identifica\u00E7\u00E3o do Tipo do arquivo.</param>
        /// <param name="NomeTipoArquivo">Descri\u00E7\u00E3o do tipo do arquivo.</param>
        /// <param name="Arquivo">Conte\u00FAdo do arquivo convertido em Base 64.</param>
        /// <param name="IdStatusArquivo">C\u00F3digo de identifica\u00E7\u00E3o do Status do arquivo.</param>
        /// <param name="NomeStatusArquivo">Desci\u00E7\u00E3o do status do arquivo.</param>
        /// <param name="Nome">Nome do arquivo.</param>
        /// <param name="Extensao">Formato/Extens\u00E3o do arquivo.</param>
        /// <param name="DataInclusao">Data de inclus\u00E3o do arquivo.</param>
        /// <param name="DataAlteracao">Data da \u00FAltima altera\u00E7\u00E3o do aquivo.</param>
        /// <param name="Detalhes">Detalhes contendo informa\u00E7\u00F5es adicionais, relacionadas ao arquivo.</param>

        public ArquivoDetalheResponse(long? Id = null, long? IdTipoArquivo = null, string NomeTipoArquivo = null, string Arquivo = null, long? IdStatusArquivo = null, string NomeStatusArquivo = null, string Nome = null, string Extensao = null, string DataInclusao = null, string DataAlteracao = null, List<ArquivoParametroResponse> Detalhes = null)
        {
            this.Id = Id;
            this.IdTipoArquivo = IdTipoArquivo;
            this.NomeTipoArquivo = NomeTipoArquivo;
            this.Arquivo = Arquivo;
            this.IdStatusArquivo = IdStatusArquivo;
            this.NomeStatusArquivo = NomeStatusArquivo;
            this.Nome = Nome;
            this.Extensao = Extensao;
            this.DataInclusao = DataInclusao;
            this.DataAlteracao = DataAlteracao;
            this.Detalhes = Detalhes;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do arquivo
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do arquivo</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do Tipo do arquivo
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do Tipo do arquivo</value>
        [DataMember(Name="idTipoArquivo", EmitDefaultValue=false)]
        public long? IdTipoArquivo { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do tipo do arquivo
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do tipo do arquivo</value>
        [DataMember(Name="nomeTipoArquivo", EmitDefaultValue=false)]
        public string NomeTipoArquivo { get; set; }
    
        /// <summary>
        /// Conte\u00FAdo do arquivo convertido em Base 64
        /// </summary>
        /// <value>Conte\u00FAdo do arquivo convertido em Base 64</value>
        [DataMember(Name="arquivo", EmitDefaultValue=false)]
        public string Arquivo { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do Status do arquivo
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do Status do arquivo</value>
        [DataMember(Name="idStatusArquivo", EmitDefaultValue=false)]
        public long? IdStatusArquivo { get; set; }
    
        /// <summary>
        /// Desci\u00E7\u00E3o do status do arquivo
        /// </summary>
        /// <value>Desci\u00E7\u00E3o do status do arquivo</value>
        [DataMember(Name="nomeStatusArquivo", EmitDefaultValue=false)]
        public string NomeStatusArquivo { get; set; }
    
        /// <summary>
        /// Nome do arquivo
        /// </summary>
        /// <value>Nome do arquivo</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Formato/Extens\u00E3o do arquivo
        /// </summary>
        /// <value>Formato/Extens\u00E3o do arquivo</value>
        [DataMember(Name="extensao", EmitDefaultValue=false)]
        public string Extensao { get; set; }
    
        /// <summary>
        /// Data de inclus\u00E3o do arquivo
        /// </summary>
        /// <value>Data de inclus\u00E3o do arquivo</value>
        [DataMember(Name="dataInclusao", EmitDefaultValue=false)]
        public string DataInclusao { get; set; }
    
        /// <summary>
        /// Data da \u00FAltima altera\u00E7\u00E3o do aquivo
        /// </summary>
        /// <value>Data da \u00FAltima altera\u00E7\u00E3o do aquivo</value>
        [DataMember(Name="dataAlteracao", EmitDefaultValue=false)]
        public string DataAlteracao { get; set; }
    
        /// <summary>
        /// Detalhes contendo informa\u00E7\u00F5es adicionais, relacionadas ao arquivo
        /// </summary>
        /// <value>Detalhes contendo informa\u00E7\u00F5es adicionais, relacionadas ao arquivo</value>
        [DataMember(Name="detalhes", EmitDefaultValue=false)]
        public List<ArquivoParametroResponse> Detalhes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArquivoDetalheResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdTipoArquivo: ").Append(IdTipoArquivo).Append("\n");
            sb.Append("  NomeTipoArquivo: ").Append(NomeTipoArquivo).Append("\n");
            sb.Append("  Arquivo: ").Append(Arquivo).Append("\n");
            sb.Append("  IdStatusArquivo: ").Append(IdStatusArquivo).Append("\n");
            sb.Append("  NomeStatusArquivo: ").Append(NomeStatusArquivo).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Extensao: ").Append(Extensao).Append("\n");
            sb.Append("  DataInclusao: ").Append(DataInclusao).Append("\n");
            sb.Append("  DataAlteracao: ").Append(DataAlteracao).Append("\n");
            sb.Append("  Detalhes: ").Append(Detalhes).Append("\n");
            
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
            return this.Equals(obj as ArquivoDetalheResponse);
        }

        /// <summary>
        /// Returns true if ArquivoDetalheResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ArquivoDetalheResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArquivoDetalheResponse other)
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
                    this.IdTipoArquivo == other.IdTipoArquivo ||
                    this.IdTipoArquivo != null &&
                    this.IdTipoArquivo.Equals(other.IdTipoArquivo)
                ) && 
                (
                    this.NomeTipoArquivo == other.NomeTipoArquivo ||
                    this.NomeTipoArquivo != null &&
                    this.NomeTipoArquivo.Equals(other.NomeTipoArquivo)
                ) && 
                (
                    this.Arquivo == other.Arquivo ||
                    this.Arquivo != null &&
                    this.Arquivo.Equals(other.Arquivo)
                ) && 
                (
                    this.IdStatusArquivo == other.IdStatusArquivo ||
                    this.IdStatusArquivo != null &&
                    this.IdStatusArquivo.Equals(other.IdStatusArquivo)
                ) && 
                (
                    this.NomeStatusArquivo == other.NomeStatusArquivo ||
                    this.NomeStatusArquivo != null &&
                    this.NomeStatusArquivo.Equals(other.NomeStatusArquivo)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.Extensao == other.Extensao ||
                    this.Extensao != null &&
                    this.Extensao.Equals(other.Extensao)
                ) && 
                (
                    this.DataInclusao == other.DataInclusao ||
                    this.DataInclusao != null &&
                    this.DataInclusao.Equals(other.DataInclusao)
                ) && 
                (
                    this.DataAlteracao == other.DataAlteracao ||
                    this.DataAlteracao != null &&
                    this.DataAlteracao.Equals(other.DataAlteracao)
                ) && 
                (
                    this.Detalhes == other.Detalhes ||
                    this.Detalhes != null &&
                    this.Detalhes.SequenceEqual(other.Detalhes)
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
                
                if (this.IdTipoArquivo != null)
                    hash = hash * 59 + this.IdTipoArquivo.GetHashCode();
                
                if (this.NomeTipoArquivo != null)
                    hash = hash * 59 + this.NomeTipoArquivo.GetHashCode();
                
                if (this.Arquivo != null)
                    hash = hash * 59 + this.Arquivo.GetHashCode();
                
                if (this.IdStatusArquivo != null)
                    hash = hash * 59 + this.IdStatusArquivo.GetHashCode();
                
                if (this.NomeStatusArquivo != null)
                    hash = hash * 59 + this.NomeStatusArquivo.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.Extensao != null)
                    hash = hash * 59 + this.Extensao.GetHashCode();
                
                if (this.DataInclusao != null)
                    hash = hash * 59 + this.DataInclusao.GetHashCode();
                
                if (this.DataAlteracao != null)
                    hash = hash * 59 + this.DataAlteracao.GetHashCode();
                
                if (this.Detalhes != null)
                    hash = hash * 59 + this.Detalhes.GetHashCode();
                
                return hash;
            }
        }

    }
}
