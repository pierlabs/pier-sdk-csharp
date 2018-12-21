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
    /// Response Representation of the Recurrent Debit Account resource
    /// </summary>
    [DataContract]
    public partial class ContaDebitoRecorrenteResponse :  IEquatable<ContaDebitoRecorrenteResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaDebitoRecorrenteResponse" /> class.
        /// Initializes a new instance of the <see cref="ContaDebitoRecorrenteResponse" />class.
        /// </summary>
        /// <param name="Ativo">Identify if the debit recurrent is active.</param>
        /// <param name="DataHoraFim">Ending date the recurrent debit.</param>
        /// <param name="DataHoraInicio">Beginning date of the recurrent debit.</param>
        /// <param name="DataHoraUltimoPagamento">Date of the last payment effected.</param>
        /// <param name="Descricao">Description of the type of recurrent debit.</param>
        /// <param name="IdConta">Identification Code of the Account (id).</param>
        /// <param name="IdContaDebitoRecorrente">Identification Code of the DebitAccountRecurrent (id).</param>
        /// <param name="IdTipoDebitoRecorrente">Identification Code of the type of recurrent debit (id).</param>
        /// <param name="IdUsuario">Logged user id.</param>
        /// <param name="Login">User loging logged in the system.</param>
        /// <param name="NumeroParcelas">Portion quantity for recurrent debit.</param>
        /// <param name="Origem">Origin where was made the register modification.</param>

        public ContaDebitoRecorrenteResponse(bool? Ativo = null, string DataHoraFim = null, string DataHoraInicio = null, string DataHoraUltimoPagamento = null, string Descricao = null, long? IdConta = null, long? IdContaDebitoRecorrente = null, long? IdTipoDebitoRecorrente = null, long? IdUsuario = null, string Login = null, int? NumeroParcelas = null, string Origem = null)
        {
            this.Ativo = Ativo;
            this.DataHoraFim = DataHoraFim;
            this.DataHoraInicio = DataHoraInicio;
            this.DataHoraUltimoPagamento = DataHoraUltimoPagamento;
            this.Descricao = Descricao;
            this.IdConta = IdConta;
            this.IdContaDebitoRecorrente = IdContaDebitoRecorrente;
            this.IdTipoDebitoRecorrente = IdTipoDebitoRecorrente;
            this.IdUsuario = IdUsuario;
            this.Login = Login;
            this.NumeroParcelas = NumeroParcelas;
            this.Origem = Origem;
            
        }
        
    
        /// <summary>
        /// Identify if the debit recurrent is active
        /// </summary>
        /// <value>Identify if the debit recurrent is active</value>
        [DataMember(Name="ativo", EmitDefaultValue=false)]
        public bool? Ativo { get; set; }
    
        /// <summary>
        /// Ending date the recurrent debit
        /// </summary>
        /// <value>Ending date the recurrent debit</value>
        [DataMember(Name="dataHoraFim", EmitDefaultValue=false)]
        public string DataHoraFim { get; set; }
    
        /// <summary>
        /// Beginning date of the recurrent debit
        /// </summary>
        /// <value>Beginning date of the recurrent debit</value>
        [DataMember(Name="dataHoraInicio", EmitDefaultValue=false)]
        public string DataHoraInicio { get; set; }
    
        /// <summary>
        /// Date of the last payment effected
        /// </summary>
        /// <value>Date of the last payment effected</value>
        [DataMember(Name="dataHoraUltimoPagamento", EmitDefaultValue=false)]
        public string DataHoraUltimoPagamento { get; set; }
    
        /// <summary>
        /// Description of the type of recurrent debit
        /// </summary>
        /// <value>Description of the type of recurrent debit</value>
        [DataMember(Name="descricao", EmitDefaultValue=false)]
        public string Descricao { get; set; }
    
        /// <summary>
        /// Identification Code of the Account (id)
        /// </summary>
        /// <value>Identification Code of the Account (id)</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Identification Code of the DebitAccountRecurrent (id)
        /// </summary>
        /// <value>Identification Code of the DebitAccountRecurrent (id)</value>
        [DataMember(Name="idContaDebitoRecorrente", EmitDefaultValue=false)]
        public long? IdContaDebitoRecorrente { get; set; }
    
        /// <summary>
        /// Identification Code of the type of recurrent debit (id)
        /// </summary>
        /// <value>Identification Code of the type of recurrent debit (id)</value>
        [DataMember(Name="idTipoDebitoRecorrente", EmitDefaultValue=false)]
        public long? IdTipoDebitoRecorrente { get; set; }
    
        /// <summary>
        /// Logged user id
        /// </summary>
        /// <value>Logged user id</value>
        [DataMember(Name="idUsuario", EmitDefaultValue=false)]
        public long? IdUsuario { get; set; }
    
        /// <summary>
        /// User loging logged in the system
        /// </summary>
        /// <value>User loging logged in the system</value>
        [DataMember(Name="login", EmitDefaultValue=false)]
        public string Login { get; set; }
    
        /// <summary>
        /// Portion quantity for recurrent debit
        /// </summary>
        /// <value>Portion quantity for recurrent debit</value>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public int? NumeroParcelas { get; set; }
    
        /// <summary>
        /// Origin where was made the register modification
        /// </summary>
        /// <value>Origin where was made the register modification</value>
        [DataMember(Name="origem", EmitDefaultValue=false)]
        public string Origem { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContaDebitoRecorrenteResponse {\n");
            sb.Append("  Ativo: ").Append(Ativo).Append("\n");
            sb.Append("  DataHoraFim: ").Append(DataHoraFim).Append("\n");
            sb.Append("  DataHoraInicio: ").Append(DataHoraInicio).Append("\n");
            sb.Append("  DataHoraUltimoPagamento: ").Append(DataHoraUltimoPagamento).Append("\n");
            sb.Append("  Descricao: ").Append(Descricao).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdContaDebitoRecorrente: ").Append(IdContaDebitoRecorrente).Append("\n");
            sb.Append("  IdTipoDebitoRecorrente: ").Append(IdTipoDebitoRecorrente).Append("\n");
            sb.Append("  IdUsuario: ").Append(IdUsuario).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  NumeroParcelas: ").Append(NumeroParcelas).Append("\n");
            sb.Append("  Origem: ").Append(Origem).Append("\n");
            
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
            return this.Equals(obj as ContaDebitoRecorrenteResponse);
        }

        /// <summary>
        /// Returns true if ContaDebitoRecorrenteResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ContaDebitoRecorrenteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContaDebitoRecorrenteResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Ativo == other.Ativo ||
                    this.Ativo != null &&
                    this.Ativo.Equals(other.Ativo)
                ) && 
                (
                    this.DataHoraFim == other.DataHoraFim ||
                    this.DataHoraFim != null &&
                    this.DataHoraFim.Equals(other.DataHoraFim)
                ) && 
                (
                    this.DataHoraInicio == other.DataHoraInicio ||
                    this.DataHoraInicio != null &&
                    this.DataHoraInicio.Equals(other.DataHoraInicio)
                ) && 
                (
                    this.DataHoraUltimoPagamento == other.DataHoraUltimoPagamento ||
                    this.DataHoraUltimoPagamento != null &&
                    this.DataHoraUltimoPagamento.Equals(other.DataHoraUltimoPagamento)
                ) && 
                (
                    this.Descricao == other.Descricao ||
                    this.Descricao != null &&
                    this.Descricao.Equals(other.Descricao)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdContaDebitoRecorrente == other.IdContaDebitoRecorrente ||
                    this.IdContaDebitoRecorrente != null &&
                    this.IdContaDebitoRecorrente.Equals(other.IdContaDebitoRecorrente)
                ) && 
                (
                    this.IdTipoDebitoRecorrente == other.IdTipoDebitoRecorrente ||
                    this.IdTipoDebitoRecorrente != null &&
                    this.IdTipoDebitoRecorrente.Equals(other.IdTipoDebitoRecorrente)
                ) && 
                (
                    this.IdUsuario == other.IdUsuario ||
                    this.IdUsuario != null &&
                    this.IdUsuario.Equals(other.IdUsuario)
                ) && 
                (
                    this.Login == other.Login ||
                    this.Login != null &&
                    this.Login.Equals(other.Login)
                ) && 
                (
                    this.NumeroParcelas == other.NumeroParcelas ||
                    this.NumeroParcelas != null &&
                    this.NumeroParcelas.Equals(other.NumeroParcelas)
                ) && 
                (
                    this.Origem == other.Origem ||
                    this.Origem != null &&
                    this.Origem.Equals(other.Origem)
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
                
                if (this.Ativo != null)
                    hash = hash * 59 + this.Ativo.GetHashCode();
                
                if (this.DataHoraFim != null)
                    hash = hash * 59 + this.DataHoraFim.GetHashCode();
                
                if (this.DataHoraInicio != null)
                    hash = hash * 59 + this.DataHoraInicio.GetHashCode();
                
                if (this.DataHoraUltimoPagamento != null)
                    hash = hash * 59 + this.DataHoraUltimoPagamento.GetHashCode();
                
                if (this.Descricao != null)
                    hash = hash * 59 + this.Descricao.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdContaDebitoRecorrente != null)
                    hash = hash * 59 + this.IdContaDebitoRecorrente.GetHashCode();
                
                if (this.IdTipoDebitoRecorrente != null)
                    hash = hash * 59 + this.IdTipoDebitoRecorrente.GetHashCode();
                
                if (this.IdUsuario != null)
                    hash = hash * 59 + this.IdUsuario.GetHashCode();
                
                if (this.Login != null)
                    hash = hash * 59 + this.Login.GetHashCode();
                
                if (this.NumeroParcelas != null)
                    hash = hash * 59 + this.NumeroParcelas.GetHashCode();
                
                if (this.Origem != null)
                    hash = hash * 59 + this.Origem.GetHashCode();
                
                return hash;
            }
        }

    }
}
