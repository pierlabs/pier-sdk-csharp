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
    /// {{{pessoa_detalhe_response_description}}}
    /// </summary>
    [DataContract]
    public partial class PessoaDetalheResponse :  IEquatable<PessoaDetalheResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PessoaDetalheResponse" /> class.
        /// Initializes a new instance of the <see cref="PessoaDetalheResponse" />class.
        /// </summary>
        /// <param name="IdPessoa">{{{pessoa_detalhe_response_id_pessoa_value}}}.</param>
        /// <param name="NomeMae">{{{pessoa_detalhe_response_nome_mae_value}}}.</param>
        /// <param name="IdEstadoCivil">{{{pessoa_detalhe_response_id_estado_civil_value}}}.</param>
        /// <param name="IdProfissao">{{{pessoa_detalhe_response_id_profissao_value}}}.</param>
        /// <param name="IdNaturezaOcupacao">{{{pessoa_detalhe_response_id_natureza_ocupacao_value}}}.</param>
        /// <param name="IdNacionalidade">{{{pessoa_detalhe_response_id_nacionalidade_value}}}.</param>
        /// <param name="NumeroBanco">{{{pessoa_detalhe_response_numero_banco_value}}}.</param>
        /// <param name="NumeroAgencia">{{{pessoa_detalhe_response_numero_agencia_value}}}.</param>
        /// <param name="NumeroContaCorrente">{{{pessoa_detalhe_response_numero_conta_corrente_value}}}.</param>
        /// <param name="Email">{{{pessoa_detalhe_response_email_value}}}.</param>
        /// <param name="NomeEmpresa">{{{pessoa_detalhe_response_nome_empresa_value}}}.</param>
        /// <param name="NomeReferencia1">{{{pessoa_detalhe_response_nome_referencia_1_value}}}.</param>
        /// <param name="Salario">{{{pessoa_detalhe_response_salario_value}}}.</param>
        /// <param name="EnderecoReferencia1">{{{pessoa_detalhe_response_endereco_referencia_1_value}}}.</param>
        /// <param name="NomeReferencia2">{{{pessoa_detalhe_response_nome_referencia_2_value}}}.</param>
        /// <param name="EnderecoReferencia2">{{{pessoa_detalhe_response_endereco_referencia_2_value}}}.</param>

        public PessoaDetalheResponse(long? IdPessoa = null, string NomeMae = null, long? IdEstadoCivil = null, string IdProfissao = null, long? IdNaturezaOcupacao = null, long? IdNacionalidade = null, int? NumeroBanco = null, int? NumeroAgencia = null, string NumeroContaCorrente = null, string Email = null, string NomeEmpresa = null, string NomeReferencia1 = null, double? Salario = null, string EnderecoReferencia1 = null, string NomeReferencia2 = null, string EnderecoReferencia2 = null)
        {
            this.IdPessoa = IdPessoa;
            this.NomeMae = NomeMae;
            this.IdEstadoCivil = IdEstadoCivil;
            this.IdProfissao = IdProfissao;
            this.IdNaturezaOcupacao = IdNaturezaOcupacao;
            this.IdNacionalidade = IdNacionalidade;
            this.NumeroBanco = NumeroBanco;
            this.NumeroAgencia = NumeroAgencia;
            this.NumeroContaCorrente = NumeroContaCorrente;
            this.Email = Email;
            this.NomeEmpresa = NomeEmpresa;
            this.NomeReferencia1 = NomeReferencia1;
            this.Salario = Salario;
            this.EnderecoReferencia1 = EnderecoReferencia1;
            this.NomeReferencia2 = NomeReferencia2;
            this.EnderecoReferencia2 = EnderecoReferencia2;
            
        }
        
    
        /// <summary>
        /// {{{pessoa_detalhe_response_id_pessoa_value}}}
        /// </summary>
        /// <value>{{{pessoa_detalhe_response_id_pessoa_value}}}</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// {{{pessoa_detalhe_response_nome_mae_value}}}
        /// </summary>
        /// <value>{{{pessoa_detalhe_response_nome_mae_value}}}</value>
        [DataMember(Name="nomeMae", EmitDefaultValue=false)]
        public string NomeMae { get; set; }
    
        /// <summary>
        /// {{{pessoa_detalhe_response_id_estado_civil_value}}}
        /// </summary>
        /// <value>{{{pessoa_detalhe_response_id_estado_civil_value}}}</value>
        [DataMember(Name="idEstadoCivil", EmitDefaultValue=false)]
        public long? IdEstadoCivil { get; set; }
    
        /// <summary>
        /// {{{pessoa_detalhe_response_id_profissao_value}}}
        /// </summary>
        /// <value>{{{pessoa_detalhe_response_id_profissao_value}}}</value>
        [DataMember(Name="idProfissao", EmitDefaultValue=false)]
        public string IdProfissao { get; set; }
    
        /// <summary>
        /// {{{pessoa_detalhe_response_id_natureza_ocupacao_value}}}
        /// </summary>
        /// <value>{{{pessoa_detalhe_response_id_natureza_ocupacao_value}}}</value>
        [DataMember(Name="idNaturezaOcupacao", EmitDefaultValue=false)]
        public long? IdNaturezaOcupacao { get; set; }
    
        /// <summary>
        /// {{{pessoa_detalhe_response_id_nacionalidade_value}}}
        /// </summary>
        /// <value>{{{pessoa_detalhe_response_id_nacionalidade_value}}}</value>
        [DataMember(Name="idNacionalidade", EmitDefaultValue=false)]
        public long? IdNacionalidade { get; set; }
    
        /// <summary>
        /// {{{pessoa_detalhe_response_numero_banco_value}}}
        /// </summary>
        /// <value>{{{pessoa_detalhe_response_numero_banco_value}}}</value>
        [DataMember(Name="numeroBanco", EmitDefaultValue=false)]
        public int? NumeroBanco { get; set; }
    
        /// <summary>
        /// {{{pessoa_detalhe_response_numero_agencia_value}}}
        /// </summary>
        /// <value>{{{pessoa_detalhe_response_numero_agencia_value}}}</value>
        [DataMember(Name="numeroAgencia", EmitDefaultValue=false)]
        public int? NumeroAgencia { get; set; }
    
        /// <summary>
        /// {{{pessoa_detalhe_response_numero_conta_corrente_value}}}
        /// </summary>
        /// <value>{{{pessoa_detalhe_response_numero_conta_corrente_value}}}</value>
        [DataMember(Name="numeroContaCorrente", EmitDefaultValue=false)]
        public string NumeroContaCorrente { get; set; }
    
        /// <summary>
        /// {{{pessoa_detalhe_response_email_value}}}
        /// </summary>
        /// <value>{{{pessoa_detalhe_response_email_value}}}</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// {{{pessoa_detalhe_response_nome_empresa_value}}}
        /// </summary>
        /// <value>{{{pessoa_detalhe_response_nome_empresa_value}}}</value>
        [DataMember(Name="nomeEmpresa", EmitDefaultValue=false)]
        public string NomeEmpresa { get; set; }
    
        /// <summary>
        /// {{{pessoa_detalhe_response_nome_referencia_1_value}}}
        /// </summary>
        /// <value>{{{pessoa_detalhe_response_nome_referencia_1_value}}}</value>
        [DataMember(Name="nomeReferencia1", EmitDefaultValue=false)]
        public string NomeReferencia1 { get; set; }
    
        /// <summary>
        /// {{{pessoa_detalhe_response_salario_value}}}
        /// </summary>
        /// <value>{{{pessoa_detalhe_response_salario_value}}}</value>
        [DataMember(Name="salario", EmitDefaultValue=false)]
        public double? Salario { get; set; }
    
        /// <summary>
        /// {{{pessoa_detalhe_response_endereco_referencia_1_value}}}
        /// </summary>
        /// <value>{{{pessoa_detalhe_response_endereco_referencia_1_value}}}</value>
        [DataMember(Name="enderecoReferencia1", EmitDefaultValue=false)]
        public string EnderecoReferencia1 { get; set; }
    
        /// <summary>
        /// {{{pessoa_detalhe_response_nome_referencia_2_value}}}
        /// </summary>
        /// <value>{{{pessoa_detalhe_response_nome_referencia_2_value}}}</value>
        [DataMember(Name="nomeReferencia2", EmitDefaultValue=false)]
        public string NomeReferencia2 { get; set; }
    
        /// <summary>
        /// {{{pessoa_detalhe_response_endereco_referencia_2_value}}}
        /// </summary>
        /// <value>{{{pessoa_detalhe_response_endereco_referencia_2_value}}}</value>
        [DataMember(Name="enderecoReferencia2", EmitDefaultValue=false)]
        public string EnderecoReferencia2 { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PessoaDetalheResponse {\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  NomeMae: ").Append(NomeMae).Append("\n");
            sb.Append("  IdEstadoCivil: ").Append(IdEstadoCivil).Append("\n");
            sb.Append("  IdProfissao: ").Append(IdProfissao).Append("\n");
            sb.Append("  IdNaturezaOcupacao: ").Append(IdNaturezaOcupacao).Append("\n");
            sb.Append("  IdNacionalidade: ").Append(IdNacionalidade).Append("\n");
            sb.Append("  NumeroBanco: ").Append(NumeroBanco).Append("\n");
            sb.Append("  NumeroAgencia: ").Append(NumeroAgencia).Append("\n");
            sb.Append("  NumeroContaCorrente: ").Append(NumeroContaCorrente).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  NomeEmpresa: ").Append(NomeEmpresa).Append("\n");
            sb.Append("  NomeReferencia1: ").Append(NomeReferencia1).Append("\n");
            sb.Append("  Salario: ").Append(Salario).Append("\n");
            sb.Append("  EnderecoReferencia1: ").Append(EnderecoReferencia1).Append("\n");
            sb.Append("  NomeReferencia2: ").Append(NomeReferencia2).Append("\n");
            sb.Append("  EnderecoReferencia2: ").Append(EnderecoReferencia2).Append("\n");
            
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
            return this.Equals(obj as PessoaDetalheResponse);
        }

        /// <summary>
        /// Returns true if PessoaDetalheResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PessoaDetalheResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PessoaDetalheResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.NomeMae == other.NomeMae ||
                    this.NomeMae != null &&
                    this.NomeMae.Equals(other.NomeMae)
                ) && 
                (
                    this.IdEstadoCivil == other.IdEstadoCivil ||
                    this.IdEstadoCivil != null &&
                    this.IdEstadoCivil.Equals(other.IdEstadoCivil)
                ) && 
                (
                    this.IdProfissao == other.IdProfissao ||
                    this.IdProfissao != null &&
                    this.IdProfissao.Equals(other.IdProfissao)
                ) && 
                (
                    this.IdNaturezaOcupacao == other.IdNaturezaOcupacao ||
                    this.IdNaturezaOcupacao != null &&
                    this.IdNaturezaOcupacao.Equals(other.IdNaturezaOcupacao)
                ) && 
                (
                    this.IdNacionalidade == other.IdNacionalidade ||
                    this.IdNacionalidade != null &&
                    this.IdNacionalidade.Equals(other.IdNacionalidade)
                ) && 
                (
                    this.NumeroBanco == other.NumeroBanco ||
                    this.NumeroBanco != null &&
                    this.NumeroBanco.Equals(other.NumeroBanco)
                ) && 
                (
                    this.NumeroAgencia == other.NumeroAgencia ||
                    this.NumeroAgencia != null &&
                    this.NumeroAgencia.Equals(other.NumeroAgencia)
                ) && 
                (
                    this.NumeroContaCorrente == other.NumeroContaCorrente ||
                    this.NumeroContaCorrente != null &&
                    this.NumeroContaCorrente.Equals(other.NumeroContaCorrente)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.NomeEmpresa == other.NomeEmpresa ||
                    this.NomeEmpresa != null &&
                    this.NomeEmpresa.Equals(other.NomeEmpresa)
                ) && 
                (
                    this.NomeReferencia1 == other.NomeReferencia1 ||
                    this.NomeReferencia1 != null &&
                    this.NomeReferencia1.Equals(other.NomeReferencia1)
                ) && 
                (
                    this.Salario == other.Salario ||
                    this.Salario != null &&
                    this.Salario.Equals(other.Salario)
                ) && 
                (
                    this.EnderecoReferencia1 == other.EnderecoReferencia1 ||
                    this.EnderecoReferencia1 != null &&
                    this.EnderecoReferencia1.Equals(other.EnderecoReferencia1)
                ) && 
                (
                    this.NomeReferencia2 == other.NomeReferencia2 ||
                    this.NomeReferencia2 != null &&
                    this.NomeReferencia2.Equals(other.NomeReferencia2)
                ) && 
                (
                    this.EnderecoReferencia2 == other.EnderecoReferencia2 ||
                    this.EnderecoReferencia2 != null &&
                    this.EnderecoReferencia2.Equals(other.EnderecoReferencia2)
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
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.NomeMae != null)
                    hash = hash * 59 + this.NomeMae.GetHashCode();
                
                if (this.IdEstadoCivil != null)
                    hash = hash * 59 + this.IdEstadoCivil.GetHashCode();
                
                if (this.IdProfissao != null)
                    hash = hash * 59 + this.IdProfissao.GetHashCode();
                
                if (this.IdNaturezaOcupacao != null)
                    hash = hash * 59 + this.IdNaturezaOcupacao.GetHashCode();
                
                if (this.IdNacionalidade != null)
                    hash = hash * 59 + this.IdNacionalidade.GetHashCode();
                
                if (this.NumeroBanco != null)
                    hash = hash * 59 + this.NumeroBanco.GetHashCode();
                
                if (this.NumeroAgencia != null)
                    hash = hash * 59 + this.NumeroAgencia.GetHashCode();
                
                if (this.NumeroContaCorrente != null)
                    hash = hash * 59 + this.NumeroContaCorrente.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.NomeEmpresa != null)
                    hash = hash * 59 + this.NomeEmpresa.GetHashCode();
                
                if (this.NomeReferencia1 != null)
                    hash = hash * 59 + this.NomeReferencia1.GetHashCode();
                
                if (this.Salario != null)
                    hash = hash * 59 + this.Salario.GetHashCode();
                
                if (this.EnderecoReferencia1 != null)
                    hash = hash * 59 + this.EnderecoReferencia1.GetHashCode();
                
                if (this.NomeReferencia2 != null)
                    hash = hash * 59 + this.NomeReferencia2.GetHashCode();
                
                if (this.EnderecoReferencia2 != null)
                    hash = hash * 59 + this.EnderecoReferencia2.GetHashCode();
                
                return hash;
            }
        }

    }
}
