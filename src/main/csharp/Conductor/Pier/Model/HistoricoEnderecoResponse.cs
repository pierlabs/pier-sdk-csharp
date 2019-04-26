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
    /// Objeto Response da lista de hist\u00F3rico altera\u00E7\u00E3o de endere\u00E7o
    /// </summary>
    [DataContract]
    public partial class HistoricoEnderecoResponse :  IEquatable<HistoricoEnderecoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricoEnderecoResponse" /> class.
        /// Initializes a new instance of the <see cref="HistoricoEnderecoResponse" />class.
        /// </summary>
        /// <param name="DataUltimaAtualizacao">Data de \u00FAltima altera\u00E7\u00E3o.</param>
        /// <param name="Cpf">Cpf.</param>
        /// <param name="IdConta">Identificador da conta.</param>
        /// <param name="Nome">Nome da pessoa.</param>
        /// <param name="NomeLogradouroAnterior">Nome do logradouro do endere\u00E7o antigo.</param>
        /// <param name="UfAnterior">Estado do endere\u00E7o antigo.</param>
        /// <param name="CidadeAnterior">Cidade do endere\u00E7o antigo.</param>
        /// <param name="CepAnterior">Cep do endere\u00E7o antigo.</param>
        /// <param name="NumeroAnterior">N\u00FAmero do logradouro do endere\u00E7o antigo.</param>
        /// <param name="ComplementoAnterior">Complemento do endere\u00E7o antigo.</param>
        /// <param name="TipoEnderecoAnterior">Tipo de endere\u00E7o do endere\u00E7o antigo.</param>
        /// <param name="DataInclusaoAnterior">Data de inclus\u00E3o do endere\u00E7o antigo.</param>
        /// <param name="NomeLogradouro">Nome do logradouro do endere\u00E7o novo.</param>
        /// <param name="Uf">Estado do endere\u00E7o novo.</param>
        /// <param name="Cidade">Cidade do endere\u00E7o novo.</param>
        /// <param name="Cep">Cep do endere\u00E7o novo.</param>
        /// <param name="Numero">N\u00FAmero do logradouro do endere\u00E7o novo.</param>
        /// <param name="Complemento">Complemento do endere\u00E7o novo.</param>
        /// <param name="TipoEndereco">Tipo de endere\u00E7o do endere\u00E7o novo.</param>
        /// <param name="DataInclusao">Data de inclus\u00E3o do endere\u00E7o novo.</param>
        /// <param name="AlteracaoAplicativo">Aplicativo respons\u00E1vel pela altera\u00E7\u00E3o.</param>

        public HistoricoEnderecoResponse(string DataUltimaAtualizacao = null, string Cpf = null, long? IdConta = null, string Nome = null, string NomeLogradouroAnterior = null, string UfAnterior = null, string CidadeAnterior = null, string CepAnterior = null, int? NumeroAnterior = null, string ComplementoAnterior = null, string TipoEnderecoAnterior = null, string DataInclusaoAnterior = null, string NomeLogradouro = null, string Uf = null, string Cidade = null, string Cep = null, int? Numero = null, string Complemento = null, string TipoEndereco = null, string DataInclusao = null, string AlteracaoAplicativo = null)
        {
            this.DataUltimaAtualizacao = DataUltimaAtualizacao;
            this.Cpf = Cpf;
            this.IdConta = IdConta;
            this.Nome = Nome;
            this.NomeLogradouroAnterior = NomeLogradouroAnterior;
            this.UfAnterior = UfAnterior;
            this.CidadeAnterior = CidadeAnterior;
            this.CepAnterior = CepAnterior;
            this.NumeroAnterior = NumeroAnterior;
            this.ComplementoAnterior = ComplementoAnterior;
            this.TipoEnderecoAnterior = TipoEnderecoAnterior;
            this.DataInclusaoAnterior = DataInclusaoAnterior;
            this.NomeLogradouro = NomeLogradouro;
            this.Uf = Uf;
            this.Cidade = Cidade;
            this.Cep = Cep;
            this.Numero = Numero;
            this.Complemento = Complemento;
            this.TipoEndereco = TipoEndereco;
            this.DataInclusao = DataInclusao;
            this.AlteracaoAplicativo = AlteracaoAplicativo;
            
        }
        
    
        /// <summary>
        /// Data de \u00FAltima altera\u00E7\u00E3o
        /// </summary>
        /// <value>Data de \u00FAltima altera\u00E7\u00E3o</value>
        [DataMember(Name="dataUltimaAtualizacao", EmitDefaultValue=false)]
        public string DataUltimaAtualizacao { get; set; }
    
        /// <summary>
        /// Cpf
        /// </summary>
        /// <value>Cpf</value>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// Identificador da conta
        /// </summary>
        /// <value>Identificador da conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Nome da pessoa
        /// </summary>
        /// <value>Nome da pessoa</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Nome do logradouro do endere\u00E7o antigo
        /// </summary>
        /// <value>Nome do logradouro do endere\u00E7o antigo</value>
        [DataMember(Name="nomeLogradouroAnterior", EmitDefaultValue=false)]
        public string NomeLogradouroAnterior { get; set; }
    
        /// <summary>
        /// Estado do endere\u00E7o antigo
        /// </summary>
        /// <value>Estado do endere\u00E7o antigo</value>
        [DataMember(Name="ufAnterior", EmitDefaultValue=false)]
        public string UfAnterior { get; set; }
    
        /// <summary>
        /// Cidade do endere\u00E7o antigo
        /// </summary>
        /// <value>Cidade do endere\u00E7o antigo</value>
        [DataMember(Name="cidadeAnterior", EmitDefaultValue=false)]
        public string CidadeAnterior { get; set; }
    
        /// <summary>
        /// Cep do endere\u00E7o antigo
        /// </summary>
        /// <value>Cep do endere\u00E7o antigo</value>
        [DataMember(Name="cepAnterior", EmitDefaultValue=false)]
        public string CepAnterior { get; set; }
    
        /// <summary>
        /// N\u00FAmero do logradouro do endere\u00E7o antigo
        /// </summary>
        /// <value>N\u00FAmero do logradouro do endere\u00E7o antigo</value>
        [DataMember(Name="numeroAnterior", EmitDefaultValue=false)]
        public int? NumeroAnterior { get; set; }
    
        /// <summary>
        /// Complemento do endere\u00E7o antigo
        /// </summary>
        /// <value>Complemento do endere\u00E7o antigo</value>
        [DataMember(Name="complementoAnterior", EmitDefaultValue=false)]
        public string ComplementoAnterior { get; set; }
    
        /// <summary>
        /// Tipo de endere\u00E7o do endere\u00E7o antigo
        /// </summary>
        /// <value>Tipo de endere\u00E7o do endere\u00E7o antigo</value>
        [DataMember(Name="tipoEnderecoAnterior", EmitDefaultValue=false)]
        public string TipoEnderecoAnterior { get; set; }
    
        /// <summary>
        /// Data de inclus\u00E3o do endere\u00E7o antigo
        /// </summary>
        /// <value>Data de inclus\u00E3o do endere\u00E7o antigo</value>
        [DataMember(Name="dataInclusaoAnterior", EmitDefaultValue=false)]
        public string DataInclusaoAnterior { get; set; }
    
        /// <summary>
        /// Nome do logradouro do endere\u00E7o novo
        /// </summary>
        /// <value>Nome do logradouro do endere\u00E7o novo</value>
        [DataMember(Name="nomeLogradouro", EmitDefaultValue=false)]
        public string NomeLogradouro { get; set; }
    
        /// <summary>
        /// Estado do endere\u00E7o novo
        /// </summary>
        /// <value>Estado do endere\u00E7o novo</value>
        [DataMember(Name="uf", EmitDefaultValue=false)]
        public string Uf { get; set; }
    
        /// <summary>
        /// Cidade do endere\u00E7o novo
        /// </summary>
        /// <value>Cidade do endere\u00E7o novo</value>
        [DataMember(Name="cidade", EmitDefaultValue=false)]
        public string Cidade { get; set; }
    
        /// <summary>
        /// Cep do endere\u00E7o novo
        /// </summary>
        /// <value>Cep do endere\u00E7o novo</value>
        [DataMember(Name="cep", EmitDefaultValue=false)]
        public string Cep { get; set; }
    
        /// <summary>
        /// N\u00FAmero do logradouro do endere\u00E7o novo
        /// </summary>
        /// <value>N\u00FAmero do logradouro do endere\u00E7o novo</value>
        [DataMember(Name="numero", EmitDefaultValue=false)]
        public int? Numero { get; set; }
    
        /// <summary>
        /// Complemento do endere\u00E7o novo
        /// </summary>
        /// <value>Complemento do endere\u00E7o novo</value>
        [DataMember(Name="complemento", EmitDefaultValue=false)]
        public string Complemento { get; set; }
    
        /// <summary>
        /// Tipo de endere\u00E7o do endere\u00E7o novo
        /// </summary>
        /// <value>Tipo de endere\u00E7o do endere\u00E7o novo</value>
        [DataMember(Name="tipoEndereco", EmitDefaultValue=false)]
        public string TipoEndereco { get; set; }
    
        /// <summary>
        /// Data de inclus\u00E3o do endere\u00E7o novo
        /// </summary>
        /// <value>Data de inclus\u00E3o do endere\u00E7o novo</value>
        [DataMember(Name="dataInclusao", EmitDefaultValue=false)]
        public string DataInclusao { get; set; }
    
        /// <summary>
        /// Aplicativo respons\u00E1vel pela altera\u00E7\u00E3o
        /// </summary>
        /// <value>Aplicativo respons\u00E1vel pela altera\u00E7\u00E3o</value>
        [DataMember(Name="alteracaoAplicativo", EmitDefaultValue=false)]
        public string AlteracaoAplicativo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricoEnderecoResponse {\n");
            sb.Append("  DataUltimaAtualizacao: ").Append(DataUltimaAtualizacao).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  NomeLogradouroAnterior: ").Append(NomeLogradouroAnterior).Append("\n");
            sb.Append("  UfAnterior: ").Append(UfAnterior).Append("\n");
            sb.Append("  CidadeAnterior: ").Append(CidadeAnterior).Append("\n");
            sb.Append("  CepAnterior: ").Append(CepAnterior).Append("\n");
            sb.Append("  NumeroAnterior: ").Append(NumeroAnterior).Append("\n");
            sb.Append("  ComplementoAnterior: ").Append(ComplementoAnterior).Append("\n");
            sb.Append("  TipoEnderecoAnterior: ").Append(TipoEnderecoAnterior).Append("\n");
            sb.Append("  DataInclusaoAnterior: ").Append(DataInclusaoAnterior).Append("\n");
            sb.Append("  NomeLogradouro: ").Append(NomeLogradouro).Append("\n");
            sb.Append("  Uf: ").Append(Uf).Append("\n");
            sb.Append("  Cidade: ").Append(Cidade).Append("\n");
            sb.Append("  Cep: ").Append(Cep).Append("\n");
            sb.Append("  Numero: ").Append(Numero).Append("\n");
            sb.Append("  Complemento: ").Append(Complemento).Append("\n");
            sb.Append("  TipoEndereco: ").Append(TipoEndereco).Append("\n");
            sb.Append("  DataInclusao: ").Append(DataInclusao).Append("\n");
            sb.Append("  AlteracaoAplicativo: ").Append(AlteracaoAplicativo).Append("\n");
            
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
            return this.Equals(obj as HistoricoEnderecoResponse);
        }

        /// <summary>
        /// Returns true if HistoricoEnderecoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of HistoricoEnderecoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricoEnderecoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DataUltimaAtualizacao == other.DataUltimaAtualizacao ||
                    this.DataUltimaAtualizacao != null &&
                    this.DataUltimaAtualizacao.Equals(other.DataUltimaAtualizacao)
                ) && 
                (
                    this.Cpf == other.Cpf ||
                    this.Cpf != null &&
                    this.Cpf.Equals(other.Cpf)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.NomeLogradouroAnterior == other.NomeLogradouroAnterior ||
                    this.NomeLogradouroAnterior != null &&
                    this.NomeLogradouroAnterior.Equals(other.NomeLogradouroAnterior)
                ) && 
                (
                    this.UfAnterior == other.UfAnterior ||
                    this.UfAnterior != null &&
                    this.UfAnterior.Equals(other.UfAnterior)
                ) && 
                (
                    this.CidadeAnterior == other.CidadeAnterior ||
                    this.CidadeAnterior != null &&
                    this.CidadeAnterior.Equals(other.CidadeAnterior)
                ) && 
                (
                    this.CepAnterior == other.CepAnterior ||
                    this.CepAnterior != null &&
                    this.CepAnterior.Equals(other.CepAnterior)
                ) && 
                (
                    this.NumeroAnterior == other.NumeroAnterior ||
                    this.NumeroAnterior != null &&
                    this.NumeroAnterior.Equals(other.NumeroAnterior)
                ) && 
                (
                    this.ComplementoAnterior == other.ComplementoAnterior ||
                    this.ComplementoAnterior != null &&
                    this.ComplementoAnterior.Equals(other.ComplementoAnterior)
                ) && 
                (
                    this.TipoEnderecoAnterior == other.TipoEnderecoAnterior ||
                    this.TipoEnderecoAnterior != null &&
                    this.TipoEnderecoAnterior.Equals(other.TipoEnderecoAnterior)
                ) && 
                (
                    this.DataInclusaoAnterior == other.DataInclusaoAnterior ||
                    this.DataInclusaoAnterior != null &&
                    this.DataInclusaoAnterior.Equals(other.DataInclusaoAnterior)
                ) && 
                (
                    this.NomeLogradouro == other.NomeLogradouro ||
                    this.NomeLogradouro != null &&
                    this.NomeLogradouro.Equals(other.NomeLogradouro)
                ) && 
                (
                    this.Uf == other.Uf ||
                    this.Uf != null &&
                    this.Uf.Equals(other.Uf)
                ) && 
                (
                    this.Cidade == other.Cidade ||
                    this.Cidade != null &&
                    this.Cidade.Equals(other.Cidade)
                ) && 
                (
                    this.Cep == other.Cep ||
                    this.Cep != null &&
                    this.Cep.Equals(other.Cep)
                ) && 
                (
                    this.Numero == other.Numero ||
                    this.Numero != null &&
                    this.Numero.Equals(other.Numero)
                ) && 
                (
                    this.Complemento == other.Complemento ||
                    this.Complemento != null &&
                    this.Complemento.Equals(other.Complemento)
                ) && 
                (
                    this.TipoEndereco == other.TipoEndereco ||
                    this.TipoEndereco != null &&
                    this.TipoEndereco.Equals(other.TipoEndereco)
                ) && 
                (
                    this.DataInclusao == other.DataInclusao ||
                    this.DataInclusao != null &&
                    this.DataInclusao.Equals(other.DataInclusao)
                ) && 
                (
                    this.AlteracaoAplicativo == other.AlteracaoAplicativo ||
                    this.AlteracaoAplicativo != null &&
                    this.AlteracaoAplicativo.Equals(other.AlteracaoAplicativo)
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
                
                if (this.DataUltimaAtualizacao != null)
                    hash = hash * 59 + this.DataUltimaAtualizacao.GetHashCode();
                
                if (this.Cpf != null)
                    hash = hash * 59 + this.Cpf.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.NomeLogradouroAnterior != null)
                    hash = hash * 59 + this.NomeLogradouroAnterior.GetHashCode();
                
                if (this.UfAnterior != null)
                    hash = hash * 59 + this.UfAnterior.GetHashCode();
                
                if (this.CidadeAnterior != null)
                    hash = hash * 59 + this.CidadeAnterior.GetHashCode();
                
                if (this.CepAnterior != null)
                    hash = hash * 59 + this.CepAnterior.GetHashCode();
                
                if (this.NumeroAnterior != null)
                    hash = hash * 59 + this.NumeroAnterior.GetHashCode();
                
                if (this.ComplementoAnterior != null)
                    hash = hash * 59 + this.ComplementoAnterior.GetHashCode();
                
                if (this.TipoEnderecoAnterior != null)
                    hash = hash * 59 + this.TipoEnderecoAnterior.GetHashCode();
                
                if (this.DataInclusaoAnterior != null)
                    hash = hash * 59 + this.DataInclusaoAnterior.GetHashCode();
                
                if (this.NomeLogradouro != null)
                    hash = hash * 59 + this.NomeLogradouro.GetHashCode();
                
                if (this.Uf != null)
                    hash = hash * 59 + this.Uf.GetHashCode();
                
                if (this.Cidade != null)
                    hash = hash * 59 + this.Cidade.GetHashCode();
                
                if (this.Cep != null)
                    hash = hash * 59 + this.Cep.GetHashCode();
                
                if (this.Numero != null)
                    hash = hash * 59 + this.Numero.GetHashCode();
                
                if (this.Complemento != null)
                    hash = hash * 59 + this.Complemento.GetHashCode();
                
                if (this.TipoEndereco != null)
                    hash = hash * 59 + this.TipoEndereco.GetHashCode();
                
                if (this.DataInclusao != null)
                    hash = hash * 59 + this.DataInclusao.GetHashCode();
                
                if (this.AlteracaoAplicativo != null)
                    hash = hash * 59 + this.AlteracaoAplicativo.GetHashCode();
                
                return hash;
            }
        }

    }
}
