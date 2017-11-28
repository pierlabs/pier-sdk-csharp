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
    /// Representa\u00C3\u00A7\u00C3\u00A3o da resposta do recurso de pessoa jur\u00C3\u00ADdica
    /// </summary>
    [DataContract]
    public partial class PessoaJuridicaResponse :  IEquatable<PessoaJuridicaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaJuridicaResponse" /> class.
        /// Initializes a new instance of the <see cref="PessoaJuridicaResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo identificador da pessoa jur\u00C3\u00ADdica.</param>
        /// <param name="RazaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica.</param>
        /// <param name="Cnpj">C\u00C3\u00B3digo do Cadastro Nacional de Pessoas Jur\u00C3\u00ADdicas.</param>
        /// <param name="InscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual.</param>
        /// <param name="Contato">Nome da pessoa para entrar em contato.</param>
        /// <param name="Banco">C\u00C3\u00B3digo do banco.</param>
        /// <param name="Agencia">C\u00C3\u00B3digo da ag\u00C3\u00AAncia.</param>
        /// <param name="DigitoVerificadorAgencia">D\u00C3\u00ADgito verificador da ag\u00C3\u00AAncia.</param>
        /// <param name="ContaCorrente">C\u00C3\u00B3digo da Conta Corrente.</param>
        /// <param name="DigitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente.</param>
        /// <param name="Usuario">Login do usu\u00C3\u00A1rio para registro da inser\u00C3\u00A7\u00C3\u00A3o.</param>

        public PessoaJuridicaResponse(long? Id = null, string RazaoSocial = null, string Cnpj = null, string InscricaoEstadual = null, string Contato = null, int? Banco = null, int? Agencia = null, string DigitoVerificadorAgencia = null, string ContaCorrente = null, string DigitoVerificadorContaCorrente = null, string Usuario = null)
        {
            this.Id = Id;
            this.RazaoSocial = RazaoSocial;
            this.Cnpj = Cnpj;
            this.InscricaoEstadual = InscricaoEstadual;
            this.Contato = Contato;
            this.Banco = Banco;
            this.Agencia = Agencia;
            this.DigitoVerificadorAgencia = DigitoVerificadorAgencia;
            this.ContaCorrente = ContaCorrente;
            this.DigitoVerificadorContaCorrente = DigitoVerificadorContaCorrente;
            this.Usuario = Usuario;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo identificador da pessoa jur\u00C3\u00ADdica
        /// </summary>
        /// <value>C\u00C3\u00B3digo identificador da pessoa jur\u00C3\u00ADdica</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica
        /// </summary>
        /// <value>Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica</value>
        [DataMember(Name="razaoSocial", EmitDefaultValue=false)]
        public string RazaoSocial { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo do Cadastro Nacional de Pessoas Jur\u00C3\u00ADdicas
        /// </summary>
        /// <value>C\u00C3\u00B3digo do Cadastro Nacional de Pessoas Jur\u00C3\u00ADdicas</value>
        [DataMember(Name="cnpj", EmitDefaultValue=false)]
        public string Cnpj { get; set; }
    
        /// <summary>
        /// N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual
        /// </summary>
        /// <value>N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual</value>
        [DataMember(Name="inscricaoEstadual", EmitDefaultValue=false)]
        public string InscricaoEstadual { get; set; }
    
        /// <summary>
        /// Nome da pessoa para entrar em contato
        /// </summary>
        /// <value>Nome da pessoa para entrar em contato</value>
        [DataMember(Name="contato", EmitDefaultValue=false)]
        public string Contato { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo do banco
        /// </summary>
        /// <value>C\u00C3\u00B3digo do banco</value>
        [DataMember(Name="banco", EmitDefaultValue=false)]
        public int? Banco { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo da ag\u00C3\u00AAncia
        /// </summary>
        /// <value>C\u00C3\u00B3digo da ag\u00C3\u00AAncia</value>
        [DataMember(Name="agencia", EmitDefaultValue=false)]
        public int? Agencia { get; set; }
    
        /// <summary>
        /// D\u00C3\u00ADgito verificador da ag\u00C3\u00AAncia
        /// </summary>
        /// <value>D\u00C3\u00ADgito verificador da ag\u00C3\u00AAncia</value>
        [DataMember(Name="digitoVerificadorAgencia", EmitDefaultValue=false)]
        public string DigitoVerificadorAgencia { get; set; }
    
        /// <summary>
        /// C\u00C3\u00B3digo da Conta Corrente
        /// </summary>
        /// <value>C\u00C3\u00B3digo da Conta Corrente</value>
        [DataMember(Name="contaCorrente", EmitDefaultValue=false)]
        public string ContaCorrente { get; set; }
    
        /// <summary>
        /// D\u00C3\u00ADgito Verificador da Conta Corrente
        /// </summary>
        /// <value>D\u00C3\u00ADgito Verificador da Conta Corrente</value>
        [DataMember(Name="digitoVerificadorContaCorrente", EmitDefaultValue=false)]
        public string DigitoVerificadorContaCorrente { get; set; }
    
        /// <summary>
        /// Login do usu\u00C3\u00A1rio para registro da inser\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <value>Login do usu\u00C3\u00A1rio para registro da inser\u00C3\u00A7\u00C3\u00A3o</value>
        [DataMember(Name="usuario", EmitDefaultValue=false)]
        public string Usuario { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PessoaJuridicaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RazaoSocial: ").Append(RazaoSocial).Append("\n");
            sb.Append("  Cnpj: ").Append(Cnpj).Append("\n");
            sb.Append("  InscricaoEstadual: ").Append(InscricaoEstadual).Append("\n");
            sb.Append("  Contato: ").Append(Contato).Append("\n");
            sb.Append("  Banco: ").Append(Banco).Append("\n");
            sb.Append("  Agencia: ").Append(Agencia).Append("\n");
            sb.Append("  DigitoVerificadorAgencia: ").Append(DigitoVerificadorAgencia).Append("\n");
            sb.Append("  ContaCorrente: ").Append(ContaCorrente).Append("\n");
            sb.Append("  DigitoVerificadorContaCorrente: ").Append(DigitoVerificadorContaCorrente).Append("\n");
            sb.Append("  Usuario: ").Append(Usuario).Append("\n");
            
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
            return this.Equals(obj as PessoaJuridicaResponse);
        }

        /// <summary>
        /// Returns true if PessoaJuridicaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PessoaJuridicaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PessoaJuridicaResponse other)
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
                    this.RazaoSocial == other.RazaoSocial ||
                    this.RazaoSocial != null &&
                    this.RazaoSocial.Equals(other.RazaoSocial)
                ) && 
                (
                    this.Cnpj == other.Cnpj ||
                    this.Cnpj != null &&
                    this.Cnpj.Equals(other.Cnpj)
                ) && 
                (
                    this.InscricaoEstadual == other.InscricaoEstadual ||
                    this.InscricaoEstadual != null &&
                    this.InscricaoEstadual.Equals(other.InscricaoEstadual)
                ) && 
                (
                    this.Contato == other.Contato ||
                    this.Contato != null &&
                    this.Contato.Equals(other.Contato)
                ) && 
                (
                    this.Banco == other.Banco ||
                    this.Banco != null &&
                    this.Banco.Equals(other.Banco)
                ) && 
                (
                    this.Agencia == other.Agencia ||
                    this.Agencia != null &&
                    this.Agencia.Equals(other.Agencia)
                ) && 
                (
                    this.DigitoVerificadorAgencia == other.DigitoVerificadorAgencia ||
                    this.DigitoVerificadorAgencia != null &&
                    this.DigitoVerificadorAgencia.Equals(other.DigitoVerificadorAgencia)
                ) && 
                (
                    this.ContaCorrente == other.ContaCorrente ||
                    this.ContaCorrente != null &&
                    this.ContaCorrente.Equals(other.ContaCorrente)
                ) && 
                (
                    this.DigitoVerificadorContaCorrente == other.DigitoVerificadorContaCorrente ||
                    this.DigitoVerificadorContaCorrente != null &&
                    this.DigitoVerificadorContaCorrente.Equals(other.DigitoVerificadorContaCorrente)
                ) && 
                (
                    this.Usuario == other.Usuario ||
                    this.Usuario != null &&
                    this.Usuario.Equals(other.Usuario)
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
                
                if (this.RazaoSocial != null)
                    hash = hash * 59 + this.RazaoSocial.GetHashCode();
                
                if (this.Cnpj != null)
                    hash = hash * 59 + this.Cnpj.GetHashCode();
                
                if (this.InscricaoEstadual != null)
                    hash = hash * 59 + this.InscricaoEstadual.GetHashCode();
                
                if (this.Contato != null)
                    hash = hash * 59 + this.Contato.GetHashCode();
                
                if (this.Banco != null)
                    hash = hash * 59 + this.Banco.GetHashCode();
                
                if (this.Agencia != null)
                    hash = hash * 59 + this.Agencia.GetHashCode();
                
                if (this.DigitoVerificadorAgencia != null)
                    hash = hash * 59 + this.DigitoVerificadorAgencia.GetHashCode();
                
                if (this.ContaCorrente != null)
                    hash = hash * 59 + this.ContaCorrente.GetHashCode();
                
                if (this.DigitoVerificadorContaCorrente != null)
                    hash = hash * 59 + this.DigitoVerificadorContaCorrente.GetHashCode();
                
                if (this.Usuario != null)
                    hash = hash * 59 + this.Usuario.GetHashCode();
                
                return hash;
            }
        }

    }
}
