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
    /// Objeto de atualiza\u00E7\u00E3o TokenCartaoUpdate
    /// </summary>
    [DataContract]
    public partial class TokenCartaoUpdate :  IEquatable<TokenCartaoUpdate>
    { 
    
        /// <summary>
        /// Status do token
        /// </summary>
        /// <value>Status do token</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "ATIVO")]
            Ativo,
            
            [EnumMember(Value = "INATIVO")]
            Inativo,
            
            [EnumMember(Value = "SUSPENSO")]
            Suspenso,
            
            [EnumMember(Value = "EXCLUIDO")]
            Excluido
        }

    
        /// <summary>
        /// Ultimo status do token
        /// </summary>
        /// <value>Ultimo status do token</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UltimoStatusEnum {
            
            [EnumMember(Value = "ATIVO")]
            Ativo,
            
            [EnumMember(Value = "INATIVO")]
            Inativo,
            
            [EnumMember(Value = "SUSPENSO")]
            Suspenso,
            
            [EnumMember(Value = "EXCLUIDO")]
            Excluido
        }

    
        /// <summary>
        /// Status do token
        /// </summary>
        /// <value>Status do token</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Ultimo status do token
        /// </summary>
        /// <value>Ultimo status do token</value>
        [DataMember(Name="ultimoStatus", EmitDefaultValue=false)]
        public UltimoStatusEnum? UltimoStatus { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenCartaoUpdate" /> class.
        /// Initializes a new instance of the <see cref="TokenCartaoUpdate" />class.
        /// </summary>
        /// <param name="Token">Token.</param>
        /// <param name="RequestorID">Identificador requestorID.</param>
        /// <param name="ReferenceID">Identificador referenceID.</param>
        /// <param name="PanReferenceID">Indentificador panReferenceID.</param>
        /// <param name="Tipo">Tipo do token.</param>
        /// <param name="Status">Status do token.</param>
        /// <param name="UltimoStatus">Ultimo status do token.</param>
        /// <param name="CodigoAtivacao">C\u00F3digo de ativa\u00E7\u00E3o.</param>
        /// <param name="TentativasAtivacao">Tentativas de ativa\u00E7\u00E3o.</param>
        /// <param name="QtdCodigosAtivacao">Quantidade de c\u00F3digos de ativa\u00E7\u00E3o.</param>
        /// <param name="Score">Score.</param>
        /// <param name="ResultadoAprovisionamento">Resultado do aprovisionamento.</param>
        /// <param name="Validade">Data de validade.</param>
        /// <param name="DataAtualizacaoChaveDispositivo">Data de atualiza\u00E7\u00E3o da chave do dispositivo.</param>

        public TokenCartaoUpdate(string Token = null, string RequestorID = null, string ReferenceID = null, string PanReferenceID = null, string Tipo = null, StatusEnum? Status = null, UltimoStatusEnum? UltimoStatus = null, string CodigoAtivacao = null, int? TentativasAtivacao = null, int? QtdCodigosAtivacao = null, int? Score = null, string ResultadoAprovisionamento = null, string Validade = null, string DataAtualizacaoChaveDispositivo = null)
        {
            this.Token = Token;
            this.RequestorID = RequestorID;
            this.ReferenceID = ReferenceID;
            this.PanReferenceID = PanReferenceID;
            this.Tipo = Tipo;
            this.Status = Status;
            this.UltimoStatus = UltimoStatus;
            this.CodigoAtivacao = CodigoAtivacao;
            this.TentativasAtivacao = TentativasAtivacao;
            this.QtdCodigosAtivacao = QtdCodigosAtivacao;
            this.Score = Score;
            this.ResultadoAprovisionamento = ResultadoAprovisionamento;
            this.Validade = Validade;
            this.DataAtualizacaoChaveDispositivo = DataAtualizacaoChaveDispositivo;
            
        }
        
    
        /// <summary>
        /// Token
        /// </summary>
        /// <value>Token</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }
    
        /// <summary>
        /// Identificador requestorID
        /// </summary>
        /// <value>Identificador requestorID</value>
        [DataMember(Name="requestorID", EmitDefaultValue=false)]
        public string RequestorID { get; set; }
    
        /// <summary>
        /// Identificador referenceID
        /// </summary>
        /// <value>Identificador referenceID</value>
        [DataMember(Name="referenceID", EmitDefaultValue=false)]
        public string ReferenceID { get; set; }
    
        /// <summary>
        /// Indentificador panReferenceID
        /// </summary>
        /// <value>Indentificador panReferenceID</value>
        [DataMember(Name="panReferenceID", EmitDefaultValue=false)]
        public string PanReferenceID { get; set; }
    
        /// <summary>
        /// Tipo do token
        /// </summary>
        /// <value>Tipo do token</value>
        [DataMember(Name="tipo", EmitDefaultValue=false)]
        public string Tipo { get; set; }
    
        /// <summary>
        /// C\u00F3digo de ativa\u00E7\u00E3o
        /// </summary>
        /// <value>C\u00F3digo de ativa\u00E7\u00E3o</value>
        [DataMember(Name="codigoAtivacao", EmitDefaultValue=false)]
        public string CodigoAtivacao { get; set; }
    
        /// <summary>
        /// Tentativas de ativa\u00E7\u00E3o
        /// </summary>
        /// <value>Tentativas de ativa\u00E7\u00E3o</value>
        [DataMember(Name="tentativasAtivacao", EmitDefaultValue=false)]
        public int? TentativasAtivacao { get; set; }
    
        /// <summary>
        /// Quantidade de c\u00F3digos de ativa\u00E7\u00E3o
        /// </summary>
        /// <value>Quantidade de c\u00F3digos de ativa\u00E7\u00E3o</value>
        [DataMember(Name="qtdCodigosAtivacao", EmitDefaultValue=false)]
        public int? QtdCodigosAtivacao { get; set; }
    
        /// <summary>
        /// Score
        /// </summary>
        /// <value>Score</value>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public int? Score { get; set; }
    
        /// <summary>
        /// Resultado do aprovisionamento
        /// </summary>
        /// <value>Resultado do aprovisionamento</value>
        [DataMember(Name="resultadoAprovisionamento", EmitDefaultValue=false)]
        public string ResultadoAprovisionamento { get; set; }
    
        /// <summary>
        /// Data de validade
        /// </summary>
        /// <value>Data de validade</value>
        [DataMember(Name="validade", EmitDefaultValue=false)]
        public string Validade { get; set; }
    
        /// <summary>
        /// Data de atualiza\u00E7\u00E3o da chave do dispositivo
        /// </summary>
        /// <value>Data de atualiza\u00E7\u00E3o da chave do dispositivo</value>
        [DataMember(Name="dataAtualizacaoChaveDispositivo", EmitDefaultValue=false)]
        public string DataAtualizacaoChaveDispositivo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenCartaoUpdate {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  RequestorID: ").Append(RequestorID).Append("\n");
            sb.Append("  ReferenceID: ").Append(ReferenceID).Append("\n");
            sb.Append("  PanReferenceID: ").Append(PanReferenceID).Append("\n");
            sb.Append("  Tipo: ").Append(Tipo).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UltimoStatus: ").Append(UltimoStatus).Append("\n");
            sb.Append("  CodigoAtivacao: ").Append(CodigoAtivacao).Append("\n");
            sb.Append("  TentativasAtivacao: ").Append(TentativasAtivacao).Append("\n");
            sb.Append("  QtdCodigosAtivacao: ").Append(QtdCodigosAtivacao).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  ResultadoAprovisionamento: ").Append(ResultadoAprovisionamento).Append("\n");
            sb.Append("  Validade: ").Append(Validade).Append("\n");
            sb.Append("  DataAtualizacaoChaveDispositivo: ").Append(DataAtualizacaoChaveDispositivo).Append("\n");
            
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
            return this.Equals(obj as TokenCartaoUpdate);
        }

        /// <summary>
        /// Returns true if TokenCartaoUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of TokenCartaoUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenCartaoUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
                ) && 
                (
                    this.RequestorID == other.RequestorID ||
                    this.RequestorID != null &&
                    this.RequestorID.Equals(other.RequestorID)
                ) && 
                (
                    this.ReferenceID == other.ReferenceID ||
                    this.ReferenceID != null &&
                    this.ReferenceID.Equals(other.ReferenceID)
                ) && 
                (
                    this.PanReferenceID == other.PanReferenceID ||
                    this.PanReferenceID != null &&
                    this.PanReferenceID.Equals(other.PanReferenceID)
                ) && 
                (
                    this.Tipo == other.Tipo ||
                    this.Tipo != null &&
                    this.Tipo.Equals(other.Tipo)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.UltimoStatus == other.UltimoStatus ||
                    this.UltimoStatus != null &&
                    this.UltimoStatus.Equals(other.UltimoStatus)
                ) && 
                (
                    this.CodigoAtivacao == other.CodigoAtivacao ||
                    this.CodigoAtivacao != null &&
                    this.CodigoAtivacao.Equals(other.CodigoAtivacao)
                ) && 
                (
                    this.TentativasAtivacao == other.TentativasAtivacao ||
                    this.TentativasAtivacao != null &&
                    this.TentativasAtivacao.Equals(other.TentativasAtivacao)
                ) && 
                (
                    this.QtdCodigosAtivacao == other.QtdCodigosAtivacao ||
                    this.QtdCodigosAtivacao != null &&
                    this.QtdCodigosAtivacao.Equals(other.QtdCodigosAtivacao)
                ) && 
                (
                    this.Score == other.Score ||
                    this.Score != null &&
                    this.Score.Equals(other.Score)
                ) && 
                (
                    this.ResultadoAprovisionamento == other.ResultadoAprovisionamento ||
                    this.ResultadoAprovisionamento != null &&
                    this.ResultadoAprovisionamento.Equals(other.ResultadoAprovisionamento)
                ) && 
                (
                    this.Validade == other.Validade ||
                    this.Validade != null &&
                    this.Validade.Equals(other.Validade)
                ) && 
                (
                    this.DataAtualizacaoChaveDispositivo == other.DataAtualizacaoChaveDispositivo ||
                    this.DataAtualizacaoChaveDispositivo != null &&
                    this.DataAtualizacaoChaveDispositivo.Equals(other.DataAtualizacaoChaveDispositivo)
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
                
                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
                
                if (this.RequestorID != null)
                    hash = hash * 59 + this.RequestorID.GetHashCode();
                
                if (this.ReferenceID != null)
                    hash = hash * 59 + this.ReferenceID.GetHashCode();
                
                if (this.PanReferenceID != null)
                    hash = hash * 59 + this.PanReferenceID.GetHashCode();
                
                if (this.Tipo != null)
                    hash = hash * 59 + this.Tipo.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.UltimoStatus != null)
                    hash = hash * 59 + this.UltimoStatus.GetHashCode();
                
                if (this.CodigoAtivacao != null)
                    hash = hash * 59 + this.CodigoAtivacao.GetHashCode();
                
                if (this.TentativasAtivacao != null)
                    hash = hash * 59 + this.TentativasAtivacao.GetHashCode();
                
                if (this.QtdCodigosAtivacao != null)
                    hash = hash * 59 + this.QtdCodigosAtivacao.GetHashCode();
                
                if (this.Score != null)
                    hash = hash * 59 + this.Score.GetHashCode();
                
                if (this.ResultadoAprovisionamento != null)
                    hash = hash * 59 + this.ResultadoAprovisionamento.GetHashCode();
                
                if (this.Validade != null)
                    hash = hash * 59 + this.Validade.GetHashCode();
                
                if (this.DataAtualizacaoChaveDispositivo != null)
                    hash = hash * 59 + this.DataAtualizacaoChaveDispositivo.GetHashCode();
                
                return hash;
            }
        }

    }
}
