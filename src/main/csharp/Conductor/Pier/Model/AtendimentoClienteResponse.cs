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
    /// Objeto AtendimentoCliente
    /// </summary>
    [DataContract]
    public partial class AtendimentoClienteResponse :  IEquatable<AtendimentoClienteResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AtendimentoClienteResponse" /> class.
        /// Initializes a new instance of the <see cref="AtendimentoClienteResponse" />class.
        /// </summary>
        /// <param name="IdAtendimento">C\u00F3digo de Identifica\u00E7\u00E3o do Atendimento (id).</param>
        /// <param name="IdConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o Atendimento est\u00E1 associado.</param>
        /// <param name="IdTipoAtendimento">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo de Atendimento (id).</param>
        /// <param name="DescricaoTipoAtendimento">Apresenta a descri\u00E7\u00E3o do Tipo de Atendimento.</param>
        /// <param name="ConteudoAtendimento">Apresenta as informa\u00E7\u00F5es que foram utilizadas para consultar, cadastrar ou alterar informa\u00E7\u00F5es relacionadas ao Atendimento..</param>
        /// <param name="DetalhesAtendimento">Apresenta os detalhes lan\u00E7ados pelo sistema ou pelo Atendente durante relacionados ao Atendimento..</param>
        /// <param name="NomeAtendente">Apresenta o nome do Atendente que registrou o Atendimento..</param>
        /// <param name="NomeSistema">Apresenta o nome do Sistema, Servidor, M\u00F3dulo ou M\u00E9todo REST que originou o registro do Atendimento..</param>
        /// <param name="DataHoraInicioAtendimento">Apresenta a data e hora em que o Atendimento foi iniciado. Quando utilizado, serve para medir a performance dos Atendimentos..</param>
        /// <param name="DataHoraFimAtendimento">Apresenta a data e hora em que o Atendimento foi iniciado. Quando utilizado, serve para medir a performance dos Atendimentos..</param>
        /// <param name="DataAtendimento">Apresenta a data e hora em que o Atendimento foi realizado..</param>
        /// <param name="DataAgendamento">Quando utilizado, de acordo com o Tipo de Atendimento, apresenta a data e hora para processamento ou a data para retorno do Atendimento..</param>
        /// <param name="DataProcessamento">Quando utilizado, apresenta a data e hora em que a solicita\u00E7\u00E3o registrada no Atendimento fora processada..</param>
        /// <param name="FlagProcessamento">Quando aplic\u00E1vel, de acordo com o Indica se o Processamento da solicita\u00E7\u00E3o fora realizado..</param>

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
        /// C\u00F3digo de Identifica\u00E7\u00E3o do Atendimento (id)
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do Atendimento (id)</value>
        [DataMember(Name="idAtendimento", EmitDefaultValue=false)]
        public long? IdAtendimento { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o Atendimento est\u00E1 associado
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o da Conta a qual o Atendimento est\u00E1 associado</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// C\u00F3digo de Identifica\u00E7\u00E3o do Tipo de Atendimento (id)
        /// </summary>
        /// <value>C\u00F3digo de Identifica\u00E7\u00E3o do Tipo de Atendimento (id)</value>
        [DataMember(Name="idTipoAtendimento", EmitDefaultValue=false)]
        public long? IdTipoAtendimento { get; set; }
    
        /// <summary>
        /// Apresenta a descri\u00E7\u00E3o do Tipo de Atendimento
        /// </summary>
        /// <value>Apresenta a descri\u00E7\u00E3o do Tipo de Atendimento</value>
        [DataMember(Name="descricaoTipoAtendimento", EmitDefaultValue=false)]
        public string DescricaoTipoAtendimento { get; set; }
    
        /// <summary>
        /// Apresenta as informa\u00E7\u00F5es que foram utilizadas para consultar, cadastrar ou alterar informa\u00E7\u00F5es relacionadas ao Atendimento.
        /// </summary>
        /// <value>Apresenta as informa\u00E7\u00F5es que foram utilizadas para consultar, cadastrar ou alterar informa\u00E7\u00F5es relacionadas ao Atendimento.</value>
        [DataMember(Name="conteudoAtendimento", EmitDefaultValue=false)]
        public string ConteudoAtendimento { get; set; }
    
        /// <summary>
        /// Apresenta os detalhes lan\u00E7ados pelo sistema ou pelo Atendente durante relacionados ao Atendimento.
        /// </summary>
        /// <value>Apresenta os detalhes lan\u00E7ados pelo sistema ou pelo Atendente durante relacionados ao Atendimento.</value>
        [DataMember(Name="detalhesAtendimento", EmitDefaultValue=false)]
        public string DetalhesAtendimento { get; set; }
    
        /// <summary>
        /// Apresenta o nome do Atendente que registrou o Atendimento.
        /// </summary>
        /// <value>Apresenta o nome do Atendente que registrou o Atendimento.</value>
        [DataMember(Name="nomeAtendente", EmitDefaultValue=false)]
        public string NomeAtendente { get; set; }
    
        /// <summary>
        /// Apresenta o nome do Sistema, Servidor, M\u00F3dulo ou M\u00E9todo REST que originou o registro do Atendimento.
        /// </summary>
        /// <value>Apresenta o nome do Sistema, Servidor, M\u00F3dulo ou M\u00E9todo REST que originou o registro do Atendimento.</value>
        [DataMember(Name="nomeSistema", EmitDefaultValue=false)]
        public string NomeSistema { get; set; }
    
        /// <summary>
        /// Apresenta a data e hora em que o Atendimento foi iniciado. Quando utilizado, serve para medir a performance dos Atendimentos.
        /// </summary>
        /// <value>Apresenta a data e hora em que o Atendimento foi iniciado. Quando utilizado, serve para medir a performance dos Atendimentos.</value>
        [DataMember(Name="dataHoraInicioAtendimento", EmitDefaultValue=false)]
        public string DataHoraInicioAtendimento { get; set; }
    
        /// <summary>
        /// Apresenta a data e hora em que o Atendimento foi iniciado. Quando utilizado, serve para medir a performance dos Atendimentos.
        /// </summary>
        /// <value>Apresenta a data e hora em que o Atendimento foi iniciado. Quando utilizado, serve para medir a performance dos Atendimentos.</value>
        [DataMember(Name="dataHoraFimAtendimento", EmitDefaultValue=false)]
        public string DataHoraFimAtendimento { get; set; }
    
        /// <summary>
        /// Apresenta a data e hora em que o Atendimento foi realizado.
        /// </summary>
        /// <value>Apresenta a data e hora em que o Atendimento foi realizado.</value>
        [DataMember(Name="dataAtendimento", EmitDefaultValue=false)]
        public string DataAtendimento { get; set; }
    
        /// <summary>
        /// Quando utilizado, de acordo com o Tipo de Atendimento, apresenta a data e hora para processamento ou a data para retorno do Atendimento.
        /// </summary>
        /// <value>Quando utilizado, de acordo com o Tipo de Atendimento, apresenta a data e hora para processamento ou a data para retorno do Atendimento.</value>
        [DataMember(Name="dataAgendamento", EmitDefaultValue=false)]
        public string DataAgendamento { get; set; }
    
        /// <summary>
        /// Quando utilizado, apresenta a data e hora em que a solicita\u00E7\u00E3o registrada no Atendimento fora processada.
        /// </summary>
        /// <value>Quando utilizado, apresenta a data e hora em que a solicita\u00E7\u00E3o registrada no Atendimento fora processada.</value>
        [DataMember(Name="dataProcessamento", EmitDefaultValue=false)]
        public string DataProcessamento { get; set; }
    
        /// <summary>
        /// Quando aplic\u00E1vel, de acordo com o Indica se o Processamento da solicita\u00E7\u00E3o fora realizado.
        /// </summary>
        /// <value>Quando aplic\u00E1vel, de acordo com o Indica se o Processamento da solicita\u00E7\u00E3o fora realizado.</value>
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
