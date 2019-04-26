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
    /// Objeto de atualiza\u00E7\u00E3o parcial do Portador
    /// </summary>
    [DataContract]
    public partial class PortadorParcialUpdate :  IEquatable<PortadorParcialUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PortadorParcialUpdate" /> class.
        /// Initializes a new instance of the <see cref="PortadorParcialUpdate" />class.
        /// </summary>
        /// <param name="NomeImpresso">Nome impresso.</param>
        /// <param name="Observacao">Observa\u00E7\u00F5es do portador.</param>
        /// <param name="DataHoraCancelamento">Data e hora de cancelamento.</param>
        /// <param name="Parentesco">Parentesco do portador.</param>
        /// <param name="IdParentesco">C\u00F3digo identificador do parentesco.</param>
        /// <param name="Ativo">Flag que indica se o portador est\u00E1 ativo.</param>

        public PortadorParcialUpdate(string NomeImpresso = null, string Observacao = null, string DataHoraCancelamento = null, string Parentesco = null, long? IdParentesco = null, bool? Ativo = null)
        {
            this.NomeImpresso = NomeImpresso;
            this.Observacao = Observacao;
            this.DataHoraCancelamento = DataHoraCancelamento;
            this.Parentesco = Parentesco;
            this.IdParentesco = IdParentesco;
            this.Ativo = Ativo;
            
        }
        
    
        /// <summary>
        /// Nome impresso
        /// </summary>
        /// <value>Nome impresso</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
        /// <summary>
        /// Observa\u00E7\u00F5es do portador
        /// </summary>
        /// <value>Observa\u00E7\u00F5es do portador</value>
        [DataMember(Name="observacao", EmitDefaultValue=false)]
        public string Observacao { get; set; }
    
        /// <summary>
        /// Data e hora de cancelamento
        /// </summary>
        /// <value>Data e hora de cancelamento</value>
        [DataMember(Name="dataHoraCancelamento", EmitDefaultValue=false)]
        public string DataHoraCancelamento { get; set; }
    
        /// <summary>
        /// Parentesco do portador
        /// </summary>
        /// <value>Parentesco do portador</value>
        [DataMember(Name="parentesco", EmitDefaultValue=false)]
        public string Parentesco { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador do parentesco
        /// </summary>
        /// <value>C\u00F3digo identificador do parentesco</value>
        [DataMember(Name="idParentesco", EmitDefaultValue=false)]
        public long? IdParentesco { get; set; }
    
        /// <summary>
        /// Flag que indica se o portador est\u00E1 ativo
        /// </summary>
        /// <value>Flag que indica se o portador est\u00E1 ativo</value>
        [DataMember(Name="ativo", EmitDefaultValue=false)]
        public bool? Ativo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PortadorParcialUpdate {\n");
            sb.Append("  NomeImpresso: ").Append(NomeImpresso).Append("\n");
            sb.Append("  Observacao: ").Append(Observacao).Append("\n");
            sb.Append("  DataHoraCancelamento: ").Append(DataHoraCancelamento).Append("\n");
            sb.Append("  Parentesco: ").Append(Parentesco).Append("\n");
            sb.Append("  IdParentesco: ").Append(IdParentesco).Append("\n");
            sb.Append("  Ativo: ").Append(Ativo).Append("\n");
            
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
            return this.Equals(obj as PortadorParcialUpdate);
        }

        /// <summary>
        /// Returns true if PortadorParcialUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of PortadorParcialUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PortadorParcialUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NomeImpresso == other.NomeImpresso ||
                    this.NomeImpresso != null &&
                    this.NomeImpresso.Equals(other.NomeImpresso)
                ) && 
                (
                    this.Observacao == other.Observacao ||
                    this.Observacao != null &&
                    this.Observacao.Equals(other.Observacao)
                ) && 
                (
                    this.DataHoraCancelamento == other.DataHoraCancelamento ||
                    this.DataHoraCancelamento != null &&
                    this.DataHoraCancelamento.Equals(other.DataHoraCancelamento)
                ) && 
                (
                    this.Parentesco == other.Parentesco ||
                    this.Parentesco != null &&
                    this.Parentesco.Equals(other.Parentesco)
                ) && 
                (
                    this.IdParentesco == other.IdParentesco ||
                    this.IdParentesco != null &&
                    this.IdParentesco.Equals(other.IdParentesco)
                ) && 
                (
                    this.Ativo == other.Ativo ||
                    this.Ativo != null &&
                    this.Ativo.Equals(other.Ativo)
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
                
                if (this.NomeImpresso != null)
                    hash = hash * 59 + this.NomeImpresso.GetHashCode();
                
                if (this.Observacao != null)
                    hash = hash * 59 + this.Observacao.GetHashCode();
                
                if (this.DataHoraCancelamento != null)
                    hash = hash * 59 + this.DataHoraCancelamento.GetHashCode();
                
                if (this.Parentesco != null)
                    hash = hash * 59 + this.Parentesco.GetHashCode();
                
                if (this.IdParentesco != null)
                    hash = hash * 59 + this.IdParentesco.GetHashCode();
                
                if (this.Ativo != null)
                    hash = hash * 59 + this.Ativo.GetHashCode();
                
                return hash;
            }
        }

    }
}
