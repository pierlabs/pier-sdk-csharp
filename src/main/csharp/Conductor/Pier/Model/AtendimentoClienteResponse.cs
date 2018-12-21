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
    /// Object AttendanceClient
    /// </summary>
    [DataContract]
    public partial class AtendimentoClienteResponse :  IEquatable<AtendimentoClienteResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AtendimentoClienteResponse" /> class.
        /// Initializes a new instance of the <see cref="AtendimentoClienteResponse" />class.
        /// </summary>
        /// <param name="IdAtendimento">Identification Code of the Attendance (id).</param>
        /// <param name="IdConta">Identification Code of the account which the attendance is associated.</param>
        /// <param name="IdTipoAtendimento">Identification Code of the type of attendance (id).</param>
        /// <param name="DescricaoTipoAtendimento">Show the description of the Type of Attendance.</param>
        /// <param name="ConteudoAtendimento">Show the information that were used to retrieve, register or update information related to the Attendance.</param>
        /// <param name="DetalhesAtendimento">Show the details launched by the system or by the attendant during the attendance.</param>
        /// <param name="NomeAtendente">Show the name of the Attendant that registered the Attendance.</param>
        /// <param name="NomeSistema">Show the name of the System, Server, Module or Method REST that originated the register of the Attendance.</param>
        /// <param name="DataHoraInicioAtendimento">Show the date and time which the attendance was begun. Whe it is used, it serves to measure the performance of the attendances.</param>
        /// <param name="DataHoraFimAtendimento">Show the date and time which the attendance was begun. When it is used, it serves to measure the performance of the attendances.</param>
        /// <param name="DataAtendimento">Present the date and time which the attendance was made.</param>
        /// <param name="DataAgendamento">When it is used, according to the type of attendance, show the date and time for the processing or the date to return the Attendance.</param>
        /// <param name="DataProcessamento">When it is used, show the date and time which the request registered in the attendance.</param>
        /// <param name="FlagProcessamento">when applicable, according to the indication if the resquest processing has been made.</param>

        public AtendimentoClienteResponse(long? IdAtendimento = null, long? IdConta = null, long? IdTipoAtendimento = null, string DescricaoTipoAtendimento = null, string ConteudoAtendimento = null, string DetalhesAtendimento = null, string NomeAtendente = null, string NomeSistema = null, string DataHoraInicioAtendimento = null, string DataHoraFimAtendimento = null, string DataAtendimento = null, string DataAgendamento = null, string DataProcessamento = null, int? FlagProcessamento = null)
        {
            this.IdAtendimento = IdAtendimento;
            this.IdConta = IdConta;
            this.IdTipoAtendimento = IdTipoAtendimento;
            this.DescricaoTipoAtendimento = DescricaoTipoAtendimento;
            this.ConteudoAtendimento = ConteudoAtendimento;
            this.DetalhesAtendimento = DetalhesAtendimento;
            this.NomeAtendente = NomeAtendente;
            this.NomeSistema = NomeSistema;
            this.DataHoraInicioAtendimento = DataHoraInicioAtendimento;
            this.DataHoraFimAtendimento = DataHoraFimAtendimento;
            this.DataAtendimento = DataAtendimento;
            this.DataAgendamento = DataAgendamento;
            this.DataProcessamento = DataProcessamento;
            this.FlagProcessamento = FlagProcessamento;
            
        }
        
    
        /// <summary>
        /// Identification Code of the Attendance (id)
        /// </summary>
        /// <value>Identification Code of the Attendance (id)</value>
        [DataMember(Name="idAtendimento", EmitDefaultValue=false)]
        public long? IdAtendimento { get; set; }
    
        /// <summary>
        /// Identification Code of the account which the attendance is associated
        /// </summary>
        /// <value>Identification Code of the account which the attendance is associated</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Identification Code of the type of attendance (id)
        /// </summary>
        /// <value>Identification Code of the type of attendance (id)</value>
        [DataMember(Name="idTipoAtendimento", EmitDefaultValue=false)]
        public long? IdTipoAtendimento { get; set; }
    
        /// <summary>
        /// Show the description of the Type of Attendance
        /// </summary>
        /// <value>Show the description of the Type of Attendance</value>
        [DataMember(Name="descricaoTipoAtendimento", EmitDefaultValue=false)]
        public string DescricaoTipoAtendimento { get; set; }
    
        /// <summary>
        /// Show the information that were used to retrieve, register or update information related to the Attendance
        /// </summary>
        /// <value>Show the information that were used to retrieve, register or update information related to the Attendance</value>
        [DataMember(Name="conteudoAtendimento", EmitDefaultValue=false)]
        public string ConteudoAtendimento { get; set; }
    
        /// <summary>
        /// Show the details launched by the system or by the attendant during the attendance
        /// </summary>
        /// <value>Show the details launched by the system or by the attendant during the attendance</value>
        [DataMember(Name="detalhesAtendimento", EmitDefaultValue=false)]
        public string DetalhesAtendimento { get; set; }
    
        /// <summary>
        /// Show the name of the Attendant that registered the Attendance
        /// </summary>
        /// <value>Show the name of the Attendant that registered the Attendance</value>
        [DataMember(Name="nomeAtendente", EmitDefaultValue=false)]
        public string NomeAtendente { get; set; }
    
        /// <summary>
        /// Show the name of the System, Server, Module or Method REST that originated the register of the Attendance
        /// </summary>
        /// <value>Show the name of the System, Server, Module or Method REST that originated the register of the Attendance</value>
        [DataMember(Name="nomeSistema", EmitDefaultValue=false)]
        public string NomeSistema { get; set; }
    
        /// <summary>
        /// Show the date and time which the attendance was begun. Whe it is used, it serves to measure the performance of the attendances
        /// </summary>
        /// <value>Show the date and time which the attendance was begun. Whe it is used, it serves to measure the performance of the attendances</value>
        [DataMember(Name="dataHoraInicioAtendimento", EmitDefaultValue=false)]
        public string DataHoraInicioAtendimento { get; set; }
    
        /// <summary>
        /// Show the date and time which the attendance was begun. When it is used, it serves to measure the performance of the attendances
        /// </summary>
        /// <value>Show the date and time which the attendance was begun. When it is used, it serves to measure the performance of the attendances</value>
        [DataMember(Name="dataHoraFimAtendimento", EmitDefaultValue=false)]
        public string DataHoraFimAtendimento { get; set; }
    
        /// <summary>
        /// Present the date and time which the attendance was made
        /// </summary>
        /// <value>Present the date and time which the attendance was made</value>
        [DataMember(Name="dataAtendimento", EmitDefaultValue=false)]
        public string DataAtendimento { get; set; }
    
        /// <summary>
        /// When it is used, according to the type of attendance, show the date and time for the processing or the date to return the Attendance
        /// </summary>
        /// <value>When it is used, according to the type of attendance, show the date and time for the processing or the date to return the Attendance</value>
        [DataMember(Name="dataAgendamento", EmitDefaultValue=false)]
        public string DataAgendamento { get; set; }
    
        /// <summary>
        /// When it is used, show the date and time which the request registered in the attendance
        /// </summary>
        /// <value>When it is used, show the date and time which the request registered in the attendance</value>
        [DataMember(Name="dataProcessamento", EmitDefaultValue=false)]
        public string DataProcessamento { get; set; }
    
        /// <summary>
        /// when applicable, according to the indication if the resquest processing has been made
        /// </summary>
        /// <value>when applicable, according to the indication if the resquest processing has been made</value>
        [DataMember(Name="flagProcessamento", EmitDefaultValue=false)]
        public int? FlagProcessamento { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AtendimentoClienteResponse {\n");
            sb.Append("  IdAtendimento: ").Append(IdAtendimento).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdTipoAtendimento: ").Append(IdTipoAtendimento).Append("\n");
            sb.Append("  DescricaoTipoAtendimento: ").Append(DescricaoTipoAtendimento).Append("\n");
            sb.Append("  ConteudoAtendimento: ").Append(ConteudoAtendimento).Append("\n");
            sb.Append("  DetalhesAtendimento: ").Append(DetalhesAtendimento).Append("\n");
            sb.Append("  NomeAtendente: ").Append(NomeAtendente).Append("\n");
            sb.Append("  NomeSistema: ").Append(NomeSistema).Append("\n");
            sb.Append("  DataHoraInicioAtendimento: ").Append(DataHoraInicioAtendimento).Append("\n");
            sb.Append("  DataHoraFimAtendimento: ").Append(DataHoraFimAtendimento).Append("\n");
            sb.Append("  DataAtendimento: ").Append(DataAtendimento).Append("\n");
            sb.Append("  DataAgendamento: ").Append(DataAgendamento).Append("\n");
            sb.Append("  DataProcessamento: ").Append(DataProcessamento).Append("\n");
            sb.Append("  FlagProcessamento: ").Append(FlagProcessamento).Append("\n");
            
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
            return this.Equals(obj as AtendimentoClienteResponse);
        }

        /// <summary>
        /// Returns true if AtendimentoClienteResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AtendimentoClienteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AtendimentoClienteResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdAtendimento == other.IdAtendimento ||
                    this.IdAtendimento != null &&
                    this.IdAtendimento.Equals(other.IdAtendimento)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdTipoAtendimento == other.IdTipoAtendimento ||
                    this.IdTipoAtendimento != null &&
                    this.IdTipoAtendimento.Equals(other.IdTipoAtendimento)
                ) && 
                (
                    this.DescricaoTipoAtendimento == other.DescricaoTipoAtendimento ||
                    this.DescricaoTipoAtendimento != null &&
                    this.DescricaoTipoAtendimento.Equals(other.DescricaoTipoAtendimento)
                ) && 
                (
                    this.ConteudoAtendimento == other.ConteudoAtendimento ||
                    this.ConteudoAtendimento != null &&
                    this.ConteudoAtendimento.Equals(other.ConteudoAtendimento)
                ) && 
                (
                    this.DetalhesAtendimento == other.DetalhesAtendimento ||
                    this.DetalhesAtendimento != null &&
                    this.DetalhesAtendimento.Equals(other.DetalhesAtendimento)
                ) && 
                (
                    this.NomeAtendente == other.NomeAtendente ||
                    this.NomeAtendente != null &&
                    this.NomeAtendente.Equals(other.NomeAtendente)
                ) && 
                (
                    this.NomeSistema == other.NomeSistema ||
                    this.NomeSistema != null &&
                    this.NomeSistema.Equals(other.NomeSistema)
                ) && 
                (
                    this.DataHoraInicioAtendimento == other.DataHoraInicioAtendimento ||
                    this.DataHoraInicioAtendimento != null &&
                    this.DataHoraInicioAtendimento.Equals(other.DataHoraInicioAtendimento)
                ) && 
                (
                    this.DataHoraFimAtendimento == other.DataHoraFimAtendimento ||
                    this.DataHoraFimAtendimento != null &&
                    this.DataHoraFimAtendimento.Equals(other.DataHoraFimAtendimento)
                ) && 
                (
                    this.DataAtendimento == other.DataAtendimento ||
                    this.DataAtendimento != null &&
                    this.DataAtendimento.Equals(other.DataAtendimento)
                ) && 
                (
                    this.DataAgendamento == other.DataAgendamento ||
                    this.DataAgendamento != null &&
                    this.DataAgendamento.Equals(other.DataAgendamento)
                ) && 
                (
                    this.DataProcessamento == other.DataProcessamento ||
                    this.DataProcessamento != null &&
                    this.DataProcessamento.Equals(other.DataProcessamento)
                ) && 
                (
                    this.FlagProcessamento == other.FlagProcessamento ||
                    this.FlagProcessamento != null &&
                    this.FlagProcessamento.Equals(other.FlagProcessamento)
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
                
                if (this.IdAtendimento != null)
                    hash = hash * 59 + this.IdAtendimento.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdTipoAtendimento != null)
                    hash = hash * 59 + this.IdTipoAtendimento.GetHashCode();
                
                if (this.DescricaoTipoAtendimento != null)
                    hash = hash * 59 + this.DescricaoTipoAtendimento.GetHashCode();
                
                if (this.ConteudoAtendimento != null)
                    hash = hash * 59 + this.ConteudoAtendimento.GetHashCode();
                
                if (this.DetalhesAtendimento != null)
                    hash = hash * 59 + this.DetalhesAtendimento.GetHashCode();
                
                if (this.NomeAtendente != null)
                    hash = hash * 59 + this.NomeAtendente.GetHashCode();
                
                if (this.NomeSistema != null)
                    hash = hash * 59 + this.NomeSistema.GetHashCode();
                
                if (this.DataHoraInicioAtendimento != null)
                    hash = hash * 59 + this.DataHoraInicioAtendimento.GetHashCode();
                
                if (this.DataHoraFimAtendimento != null)
                    hash = hash * 59 + this.DataHoraFimAtendimento.GetHashCode();
                
                if (this.DataAtendimento != null)
                    hash = hash * 59 + this.DataAtendimento.GetHashCode();
                
                if (this.DataAgendamento != null)
                    hash = hash * 59 + this.DataAgendamento.GetHashCode();
                
                if (this.DataProcessamento != null)
                    hash = hash * 59 + this.DataProcessamento.GetHashCode();
                
                if (this.FlagProcessamento != null)
                    hash = hash * 59 + this.FlagProcessamento.GetHashCode();
                
                return hash;
            }
        }

    }
}
