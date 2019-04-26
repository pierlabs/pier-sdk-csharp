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
    /// Objeto da atualiza\u00E7\u00E3o parcial da seguran\u00E7a mobile
    /// </summary>
    [DataContract]
    public partial class SegurancaMobileParcialUpdate :  IEquatable<SegurancaMobileParcialUpdate>
    { 
    
        /// <summary>
        /// Status da requisi\u00E7\u00E3o/solicita\u00E7\u00E3o do token
        /// </summary>
        /// <value>Status da requisi\u00E7\u00E3o/solicita\u00E7\u00E3o do token</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusRequisicaoEnum {
            
            [EnumMember(Value = "PENDENTE")]
            Pendente,
            
            [EnumMember(Value = "APROVADA")]
            Aprovada,
            
            [EnumMember(Value = "NEGADA")]
            Negada,
            
            [EnumMember(Value = "CANCELADA")]
            Cancelada,
            
            [EnumMember(Value = "ATIVADO")]
            Ativado
        }

    
        /// <summary>
        /// Status da requisi\u00E7\u00E3o/solicita\u00E7\u00E3o do token
        /// </summary>
        /// <value>Status da requisi\u00E7\u00E3o/solicita\u00E7\u00E3o do token</value>
        [DataMember(Name="statusRequisicao", EmitDefaultValue=false)]
        public StatusRequisicaoEnum? StatusRequisicao { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SegurancaMobileParcialUpdate" /> class.
        /// Initializes a new instance of the <see cref="SegurancaMobileParcialUpdate" />class.
        /// </summary>
        /// <param name="Token">Valor do token.</param>
        /// <param name="Tablet">Identificador do Tablet.</param>
        /// <param name="CpfCnpj">CNPJ ou CPF da pessoa.</param>
        /// <param name="DeviceName">Nome do dispositivo.</param>
        /// <param name="DeviceToken">Token do dispositivo.</param>
        /// <param name="Canal">Canal de entrada.</param>
        /// <param name="StatusRequisicao">Status da requisi\u00E7\u00E3o/solicita\u00E7\u00E3o do token.</param>
        /// <param name="DataUtilizacao">Data da utiliza\u00E7\u00E3o do token.</param>
        /// <param name="DataAtivacao">Data da ativa\u00E7\u00E3o do token.</param>
        /// <param name="ChapaPromotor">Chapa do promotor .</param>
        /// <param name="CodOperacaoNeurotech">C\u00F3digo de opera\u00E7\u00E3o da Neurotech.</param>
        /// <param name="RespostaNeurotech">Resposta da Neurotech.</param>

        public SegurancaMobileParcialUpdate(string Token = null, string Tablet = null, string CpfCnpj = null, string DeviceName = null, string DeviceToken = null, string Canal = null, StatusRequisicaoEnum? StatusRequisicao = null, string DataUtilizacao = null, string DataAtivacao = null, string ChapaPromotor = null, string CodOperacaoNeurotech = null, string RespostaNeurotech = null)
        {
            this.Token = Token;
            this.Tablet = Tablet;
            this.CpfCnpj = CpfCnpj;
            this.DeviceName = DeviceName;
            this.DeviceToken = DeviceToken;
            this.Canal = Canal;
            this.StatusRequisicao = StatusRequisicao;
            this.DataUtilizacao = DataUtilizacao;
            this.DataAtivacao = DataAtivacao;
            this.ChapaPromotor = ChapaPromotor;
            this.CodOperacaoNeurotech = CodOperacaoNeurotech;
            this.RespostaNeurotech = RespostaNeurotech;
            
        }
        
    
        /// <summary>
        /// Valor do token
        /// </summary>
        /// <value>Valor do token</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }
    
        /// <summary>
        /// Identificador do Tablet
        /// </summary>
        /// <value>Identificador do Tablet</value>
        [DataMember(Name="tablet", EmitDefaultValue=false)]
        public string Tablet { get; set; }
    
        /// <summary>
        /// CNPJ ou CPF da pessoa
        /// </summary>
        /// <value>CNPJ ou CPF da pessoa</value>
        [DataMember(Name="cpfCnpj", EmitDefaultValue=false)]
        public string CpfCnpj { get; set; }
    
        /// <summary>
        /// Nome do dispositivo
        /// </summary>
        /// <value>Nome do dispositivo</value>
        [DataMember(Name="deviceName", EmitDefaultValue=false)]
        public string DeviceName { get; set; }
    
        /// <summary>
        /// Token do dispositivo
        /// </summary>
        /// <value>Token do dispositivo</value>
        [DataMember(Name="deviceToken", EmitDefaultValue=false)]
        public string DeviceToken { get; set; }
    
        /// <summary>
        /// Canal de entrada
        /// </summary>
        /// <value>Canal de entrada</value>
        [DataMember(Name="canal", EmitDefaultValue=false)]
        public string Canal { get; set; }
    
        /// <summary>
        /// Data da utiliza\u00E7\u00E3o do token
        /// </summary>
        /// <value>Data da utiliza\u00E7\u00E3o do token</value>
        [DataMember(Name="dataUtilizacao", EmitDefaultValue=false)]
        public string DataUtilizacao { get; set; }
    
        /// <summary>
        /// Data da ativa\u00E7\u00E3o do token
        /// </summary>
        /// <value>Data da ativa\u00E7\u00E3o do token</value>
        [DataMember(Name="dataAtivacao", EmitDefaultValue=false)]
        public string DataAtivacao { get; set; }
    
        /// <summary>
        /// Chapa do promotor 
        /// </summary>
        /// <value>Chapa do promotor </value>
        [DataMember(Name="chapaPromotor", EmitDefaultValue=false)]
        public string ChapaPromotor { get; set; }
    
        /// <summary>
        /// C\u00F3digo de opera\u00E7\u00E3o da Neurotech
        /// </summary>
        /// <value>C\u00F3digo de opera\u00E7\u00E3o da Neurotech</value>
        [DataMember(Name="codOperacaoNeurotech", EmitDefaultValue=false)]
        public string CodOperacaoNeurotech { get; set; }
    
        /// <summary>
        /// Resposta da Neurotech
        /// </summary>
        /// <value>Resposta da Neurotech</value>
        [DataMember(Name="respostaNeurotech", EmitDefaultValue=false)]
        public string RespostaNeurotech { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SegurancaMobileParcialUpdate {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Tablet: ").Append(Tablet).Append("\n");
            sb.Append("  CpfCnpj: ").Append(CpfCnpj).Append("\n");
            sb.Append("  DeviceName: ").Append(DeviceName).Append("\n");
            sb.Append("  DeviceToken: ").Append(DeviceToken).Append("\n");
            sb.Append("  Canal: ").Append(Canal).Append("\n");
            sb.Append("  StatusRequisicao: ").Append(StatusRequisicao).Append("\n");
            sb.Append("  DataUtilizacao: ").Append(DataUtilizacao).Append("\n");
            sb.Append("  DataAtivacao: ").Append(DataAtivacao).Append("\n");
            sb.Append("  ChapaPromotor: ").Append(ChapaPromotor).Append("\n");
            sb.Append("  CodOperacaoNeurotech: ").Append(CodOperacaoNeurotech).Append("\n");
            sb.Append("  RespostaNeurotech: ").Append(RespostaNeurotech).Append("\n");
            
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
            return this.Equals(obj as SegurancaMobileParcialUpdate);
        }

        /// <summary>
        /// Returns true if SegurancaMobileParcialUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of SegurancaMobileParcialUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SegurancaMobileParcialUpdate other)
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
                    this.Tablet == other.Tablet ||
                    this.Tablet != null &&
                    this.Tablet.Equals(other.Tablet)
                ) && 
                (
                    this.CpfCnpj == other.CpfCnpj ||
                    this.CpfCnpj != null &&
                    this.CpfCnpj.Equals(other.CpfCnpj)
                ) && 
                (
                    this.DeviceName == other.DeviceName ||
                    this.DeviceName != null &&
                    this.DeviceName.Equals(other.DeviceName)
                ) && 
                (
                    this.DeviceToken == other.DeviceToken ||
                    this.DeviceToken != null &&
                    this.DeviceToken.Equals(other.DeviceToken)
                ) && 
                (
                    this.Canal == other.Canal ||
                    this.Canal != null &&
                    this.Canal.Equals(other.Canal)
                ) && 
                (
                    this.StatusRequisicao == other.StatusRequisicao ||
                    this.StatusRequisicao != null &&
                    this.StatusRequisicao.Equals(other.StatusRequisicao)
                ) && 
                (
                    this.DataUtilizacao == other.DataUtilizacao ||
                    this.DataUtilizacao != null &&
                    this.DataUtilizacao.Equals(other.DataUtilizacao)
                ) && 
                (
                    this.DataAtivacao == other.DataAtivacao ||
                    this.DataAtivacao != null &&
                    this.DataAtivacao.Equals(other.DataAtivacao)
                ) && 
                (
                    this.ChapaPromotor == other.ChapaPromotor ||
                    this.ChapaPromotor != null &&
                    this.ChapaPromotor.Equals(other.ChapaPromotor)
                ) && 
                (
                    this.CodOperacaoNeurotech == other.CodOperacaoNeurotech ||
                    this.CodOperacaoNeurotech != null &&
                    this.CodOperacaoNeurotech.Equals(other.CodOperacaoNeurotech)
                ) && 
                (
                    this.RespostaNeurotech == other.RespostaNeurotech ||
                    this.RespostaNeurotech != null &&
                    this.RespostaNeurotech.Equals(other.RespostaNeurotech)
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
                
                if (this.Tablet != null)
                    hash = hash * 59 + this.Tablet.GetHashCode();
                
                if (this.CpfCnpj != null)
                    hash = hash * 59 + this.CpfCnpj.GetHashCode();
                
                if (this.DeviceName != null)
                    hash = hash * 59 + this.DeviceName.GetHashCode();
                
                if (this.DeviceToken != null)
                    hash = hash * 59 + this.DeviceToken.GetHashCode();
                
                if (this.Canal != null)
                    hash = hash * 59 + this.Canal.GetHashCode();
                
                if (this.StatusRequisicao != null)
                    hash = hash * 59 + this.StatusRequisicao.GetHashCode();
                
                if (this.DataUtilizacao != null)
                    hash = hash * 59 + this.DataUtilizacao.GetHashCode();
                
                if (this.DataAtivacao != null)
                    hash = hash * 59 + this.DataAtivacao.GetHashCode();
                
                if (this.ChapaPromotor != null)
                    hash = hash * 59 + this.ChapaPromotor.GetHashCode();
                
                if (this.CodOperacaoNeurotech != null)
                    hash = hash * 59 + this.CodOperacaoNeurotech.GetHashCode();
                
                if (this.RespostaNeurotech != null)
                    hash = hash * 59 + this.RespostaNeurotech.GetHashCode();
                
                return hash;
            }
        }

    }
}
