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
    /// Representa o objeto de resposta de uma indica\u00E7\u00E3o
    /// </summary>
    [DataContract]
    public partial class IndicacaoAmigoResponse :  IEquatable<IndicacaoAmigoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IndicacaoAmigoResponse" /> class.
        /// Initializes a new instance of the <see cref="IndicacaoAmigoResponse" />class.
        /// </summary>
        /// <param name="CodigoIndicacao">C\u00F3digo da indica\u00E7\u00E3o.</param>
        /// <param name="CpfIndicado">N\u00FAmero do CPF do amigo indicado.</param>
        /// <param name="DataIndicacao">Data da indica\u00E7\u00E3o.</param>
        /// <param name="DataUtilizacao">Data da utiliza\u00E7\u00E3o.</param>
        /// <param name="DataValidade">Data de validade da indica\u00E7\u00E3o.</param>
        /// <param name="EmailIndicado">Email do amigo indicado.</param>
        /// <param name="Id">C\u00F3digo identificador da indica\u00E7\u00E3o.</param>
        /// <param name="IdPessoa">C\u00F3digo identificador da pessoa.</param>
        /// <param name="Status">Status da indica\u00E7\u00E3o (1 - CRIADO, 2 - UTILIZADO, 3 - PAGO).</param>

        public IndicacaoAmigoResponse(long? CodigoIndicacao = null, string CpfIndicado = null, string DataIndicacao = null, string DataUtilizacao = null, string DataValidade = null, string EmailIndicado = null, long? Id = null, long? IdPessoa = null, int? Status = null)
        {
            this.CodigoIndicacao = CodigoIndicacao;
            this.CpfIndicado = CpfIndicado;
            this.DataIndicacao = DataIndicacao;
            this.DataUtilizacao = DataUtilizacao;
            this.DataValidade = DataValidade;
            this.EmailIndicado = EmailIndicado;
            this.Id = Id;
            this.IdPessoa = IdPessoa;
            this.Status = Status;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo da indica\u00E7\u00E3o
        /// </summary>
        /// <value>C\u00F3digo da indica\u00E7\u00E3o</value>
        [DataMember(Name="codigoIndicacao", EmitDefaultValue=false)]
        public long? CodigoIndicacao { get; set; }
    
        /// <summary>
        /// N\u00FAmero do CPF do amigo indicado
        /// </summary>
        /// <value>N\u00FAmero do CPF do amigo indicado</value>
        [DataMember(Name="cpfIndicado", EmitDefaultValue=false)]
        public string CpfIndicado { get; set; }
    
        /// <summary>
        /// Data da indica\u00E7\u00E3o
        /// </summary>
        /// <value>Data da indica\u00E7\u00E3o</value>
        [DataMember(Name="dataIndicacao", EmitDefaultValue=false)]
        public string DataIndicacao { get; set; }
    
        /// <summary>
        /// Data da utiliza\u00E7\u00E3o
        /// </summary>
        /// <value>Data da utiliza\u00E7\u00E3o</value>
        [DataMember(Name="dataUtilizacao", EmitDefaultValue=false)]
        public string DataUtilizacao { get; set; }
    
        /// <summary>
        /// Data de validade da indica\u00E7\u00E3o
        /// </summary>
        /// <value>Data de validade da indica\u00E7\u00E3o</value>
        [DataMember(Name="dataValidade", EmitDefaultValue=false)]
        public string DataValidade { get; set; }
    
        /// <summary>
        /// Email do amigo indicado
        /// </summary>
        /// <value>Email do amigo indicado</value>
        [DataMember(Name="emailIndicado", EmitDefaultValue=false)]
        public string EmailIndicado { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador da indica\u00E7\u00E3o
        /// </summary>
        /// <value>C\u00F3digo identificador da indica\u00E7\u00E3o</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador da pessoa
        /// </summary>
        /// <value>C\u00F3digo identificador da pessoa</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// Status da indica\u00E7\u00E3o (1 - CRIADO, 2 - UTILIZADO, 3 - PAGO)
        /// </summary>
        /// <value>Status da indica\u00E7\u00E3o (1 - CRIADO, 2 - UTILIZADO, 3 - PAGO)</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IndicacaoAmigoResponse {\n");
            sb.Append("  CodigoIndicacao: ").Append(CodigoIndicacao).Append("\n");
            sb.Append("  CpfIndicado: ").Append(CpfIndicado).Append("\n");
            sb.Append("  DataIndicacao: ").Append(DataIndicacao).Append("\n");
            sb.Append("  DataUtilizacao: ").Append(DataUtilizacao).Append("\n");
            sb.Append("  DataValidade: ").Append(DataValidade).Append("\n");
            sb.Append("  EmailIndicado: ").Append(EmailIndicado).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
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
            return this.Equals(obj as IndicacaoAmigoResponse);
        }

        /// <summary>
        /// Returns true if IndicacaoAmigoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of IndicacaoAmigoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndicacaoAmigoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CodigoIndicacao == other.CodigoIndicacao ||
                    this.CodigoIndicacao != null &&
                    this.CodigoIndicacao.Equals(other.CodigoIndicacao)
                ) && 
                (
                    this.CpfIndicado == other.CpfIndicado ||
                    this.CpfIndicado != null &&
                    this.CpfIndicado.Equals(other.CpfIndicado)
                ) && 
                (
                    this.DataIndicacao == other.DataIndicacao ||
                    this.DataIndicacao != null &&
                    this.DataIndicacao.Equals(other.DataIndicacao)
                ) && 
                (
                    this.DataUtilizacao == other.DataUtilizacao ||
                    this.DataUtilizacao != null &&
                    this.DataUtilizacao.Equals(other.DataUtilizacao)
                ) && 
                (
                    this.DataValidade == other.DataValidade ||
                    this.DataValidade != null &&
                    this.DataValidade.Equals(other.DataValidade)
                ) && 
                (
                    this.EmailIndicado == other.EmailIndicado ||
                    this.EmailIndicado != null &&
                    this.EmailIndicado.Equals(other.EmailIndicado)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
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
                
                if (this.CodigoIndicacao != null)
                    hash = hash * 59 + this.CodigoIndicacao.GetHashCode();
                
                if (this.CpfIndicado != null)
                    hash = hash * 59 + this.CpfIndicado.GetHashCode();
                
                if (this.DataIndicacao != null)
                    hash = hash * 59 + this.DataIndicacao.GetHashCode();
                
                if (this.DataUtilizacao != null)
                    hash = hash * 59 + this.DataUtilizacao.GetHashCode();
                
                if (this.DataValidade != null)
                    hash = hash * 59 + this.DataValidade.GetHashCode();
                
                if (this.EmailIndicado != null)
                    hash = hash * 59 + this.EmailIndicado.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }
}
