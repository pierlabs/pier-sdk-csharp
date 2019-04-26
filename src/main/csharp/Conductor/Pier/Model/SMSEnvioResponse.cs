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
    /// Objeto SMS
    /// </summary>
    [DataContract]
    public partial class SMSEnvioResponse :  IEquatable<SMSEnvioResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SMSEnvioResponse" /> class.
        /// Initializes a new instance of the <see cref="SMSEnvioResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo identificador.</param>
        /// <param name="Status">Status do SMS.</param>
        /// <param name="IdConta">identificador da conta.</param>
        /// <param name="Celular">N\u00FAmero do celular.</param>
        /// <param name="Conteudo">Conte\u00FAdo da mensagem.</param>
        /// <param name="QuantidadeTentativasEnvio">N\u00FAmero de tentativas de envio.</param>
        /// <param name="DataInclusao">Data de Inclus\u00E3o.</param>
        /// <param name="Cpf">CPF do cliente referente ao SMS enviado.</param>

        public SMSEnvioResponse(long? Id = null, string Status = null, long? IdConta = null, string Celular = null, string Conteudo = null, int? QuantidadeTentativasEnvio = null, string DataInclusao = null, string Cpf = null)
        {
            this.Id = Id;
            this.Status = Status;
            this.IdConta = IdConta;
            this.Celular = Celular;
            this.Conteudo = Conteudo;
            this.QuantidadeTentativasEnvio = QuantidadeTentativasEnvio;
            this.DataInclusao = DataInclusao;
            this.Cpf = Cpf;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo identificador
        /// </summary>
        /// <value>C\u00F3digo identificador</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Status do SMS
        /// </summary>
        /// <value>Status do SMS</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// identificador da conta
        /// </summary>
        /// <value>identificador da conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// N\u00FAmero do celular
        /// </summary>
        /// <value>N\u00FAmero do celular</value>
        [DataMember(Name="celular", EmitDefaultValue=false)]
        public string Celular { get; set; }
    
        /// <summary>
        /// Conte\u00FAdo da mensagem
        /// </summary>
        /// <value>Conte\u00FAdo da mensagem</value>
        [DataMember(Name="conteudo", EmitDefaultValue=false)]
        public string Conteudo { get; set; }
    
        /// <summary>
        /// N\u00FAmero de tentativas de envio
        /// </summary>
        /// <value>N\u00FAmero de tentativas de envio</value>
        [DataMember(Name="quantidadeTentativasEnvio", EmitDefaultValue=false)]
        public int? QuantidadeTentativasEnvio { get; set; }
    
        /// <summary>
        /// Data de Inclus\u00E3o
        /// </summary>
        /// <value>Data de Inclus\u00E3o</value>
        [DataMember(Name="dataInclusao", EmitDefaultValue=false)]
        public string DataInclusao { get; set; }
    
        /// <summary>
        /// CPF do cliente referente ao SMS enviado
        /// </summary>
        /// <value>CPF do cliente referente ao SMS enviado</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SMSEnvioResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  Celular: ").Append(Celular).Append("\n");
            sb.Append("  Conteudo: ").Append(Conteudo).Append("\n");
            sb.Append("  QuantidadeTentativasEnvio: ").Append(QuantidadeTentativasEnvio).Append("\n");
            sb.Append("  DataInclusao: ").Append(DataInclusao).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            
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
            return this.Equals(obj as SMSEnvioResponse);
        }

        /// <summary>
        /// Returns true if SMSEnvioResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SMSEnvioResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SMSEnvioResponse other)
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
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.Celular == other.Celular ||
                    this.Celular != null &&
                    this.Celular.Equals(other.Celular)
                ) && 
                (
                    this.Conteudo == other.Conteudo ||
                    this.Conteudo != null &&
                    this.Conteudo.Equals(other.Conteudo)
                ) && 
                (
                    this.QuantidadeTentativasEnvio == other.QuantidadeTentativasEnvio ||
                    this.QuantidadeTentativasEnvio != null &&
                    this.QuantidadeTentativasEnvio.Equals(other.QuantidadeTentativasEnvio)
                ) && 
                (
                    this.DataInclusao == other.DataInclusao ||
                    this.DataInclusao != null &&
                    this.DataInclusao.Equals(other.DataInclusao)
                ) && 
                (
                    this.Cpf == other.Cpf ||
                    this.Cpf != null &&
                    this.Cpf.Equals(other.Cpf)
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
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.Celular != null)
                    hash = hash * 59 + this.Celular.GetHashCode();
                
                if (this.Conteudo != null)
                    hash = hash * 59 + this.Conteudo.GetHashCode();
                
                if (this.QuantidadeTentativasEnvio != null)
                    hash = hash * 59 + this.QuantidadeTentativasEnvio.GetHashCode();
                
                if (this.DataInclusao != null)
                    hash = hash * 59 + this.DataInclusao.GetHashCode();
                
                if (this.Cpf != null)
                    hash = hash * 59 + this.Cpf.GetHashCode();
                
                return hash;
            }
        }

    }
}
