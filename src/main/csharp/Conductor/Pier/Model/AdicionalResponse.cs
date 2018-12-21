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
    /// Response of the additional register resource
    /// </summary>
    [DataContract]
    public partial class AdicionalResponse :  IEquatable<AdicionalResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdicionalResponse" /> class.
        /// Initializes a new instance of the <see cref="AdicionalResponse" />class.
        /// </summary>
        /// <param name="IdConta">Identification Code of the Account for the register of the Additional.</param>
        /// <param name="IdPessoa">Identification Code of the Additional.</param>
        /// <param name="Nome">Ful name of the Additional.</param>
        /// <param name="NomeImpresso">Name of the additional that will be printed on the card.</param>
        /// <param name="NumeroReceitaFederal">Number of CPF or CNPJ of the Additional.</param>
        /// <param name="DataNascimento">Birth date of the Additional.</param>
        /// <param name="Sexo">Identification Code of sex of the Person, when PP, being: (&#39;M&#39;: Male), (&#39;F&#39;: Female), (&#39;O&#39;: Other), (&#39;N&#39;: Not Specified).</param>
        /// <param name="NumeroIdentidade">Number of Document of the Additional.</param>
        /// <param name="OrgaoExpedidorIdentidade">Name of the Issuer of the Document of the Additional.</param>
        /// <param name="UnidadeFederativaIdentidade">Acronym of the Federal Unity where the Identity document of the additional was issued.</param>
        /// <param name="DataEmissaoIdentidade">Date of the issue of the Identity document of the Additional.</param>
        /// <param name="IdParentesco">Identification Code of kinship of the Additional with the holder.</param>
        /// <param name="FlagAtivo">Indicate if the additional is active =1 or inactive =0.</param>
        /// <param name="DataCadastroPortador">Indicate the date of additional register.</param>
        /// <param name="DataCancelamentoPortador">Indicate the date of the cancellation of the Additional.</param>

        public AdicionalResponse(long? IdConta = null, long? IdPessoa = null, string Nome = null, string NomeImpresso = null, string NumeroReceitaFederal = null, string DataNascimento = null, string Sexo = null, string NumeroIdentidade = null, string OrgaoExpedidorIdentidade = null, string UnidadeFederativaIdentidade = null, string DataEmissaoIdentidade = null, long? IdParentesco = null, int? FlagAtivo = null, string DataCadastroPortador = null, string DataCancelamentoPortador = null)
        {
            this.IdConta = IdConta;
            this.IdPessoa = IdPessoa;
            this.Nome = Nome;
            this.NomeImpresso = NomeImpresso;
            this.NumeroReceitaFederal = NumeroReceitaFederal;
            this.DataNascimento = DataNascimento;
            this.Sexo = Sexo;
            this.NumeroIdentidade = NumeroIdentidade;
            this.OrgaoExpedidorIdentidade = OrgaoExpedidorIdentidade;
            this.UnidadeFederativaIdentidade = UnidadeFederativaIdentidade;
            this.DataEmissaoIdentidade = DataEmissaoIdentidade;
            this.IdParentesco = IdParentesco;
            this.FlagAtivo = FlagAtivo;
            this.DataCadastroPortador = DataCadastroPortador;
            this.DataCancelamentoPortador = DataCancelamentoPortador;
            
        }
        
    
        /// <summary>
        /// Identification Code of the Account for the register of the Additional
        /// </summary>
        /// <value>Identification Code of the Account for the register of the Additional</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Identification Code of the Additional
        /// </summary>
        /// <value>Identification Code of the Additional</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// Ful name of the Additional
        /// </summary>
        /// <value>Ful name of the Additional</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Name of the additional that will be printed on the card
        /// </summary>
        /// <value>Name of the additional that will be printed on the card</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
        /// <summary>
        /// Number of CPF or CNPJ of the Additional
        /// </summary>
        /// <value>Number of CPF or CNPJ of the Additional</value>
        [DataMember(Name="numeroReceitaFederal", EmitDefaultValue=false)]
        public string NumeroReceitaFederal { get; set; }
    
        /// <summary>
        /// Birth date of the Additional
        /// </summary>
        /// <value>Birth date of the Additional</value>
        [DataMember(Name="dataNascimento", EmitDefaultValue=false)]
        public string DataNascimento { get; set; }
    
        /// <summary>
        /// Identification Code of sex of the Person, when PP, being: (&#39;M&#39;: Male), (&#39;F&#39;: Female), (&#39;O&#39;: Other), (&#39;N&#39;: Not Specified)
        /// </summary>
        /// <value>Identification Code of sex of the Person, when PP, being: (&#39;M&#39;: Male), (&#39;F&#39;: Female), (&#39;O&#39;: Other), (&#39;N&#39;: Not Specified)</value>
        [DataMember(Name="sexo", EmitDefaultValue=false)]
        public string Sexo { get; set; }
    
        /// <summary>
        /// Number of Document of the Additional
        /// </summary>
        /// <value>Number of Document of the Additional</value>
        [DataMember(Name="numeroIdentidade", EmitDefaultValue=false)]
        public string NumeroIdentidade { get; set; }
    
        /// <summary>
        /// Name of the Issuer of the Document of the Additional
        /// </summary>
        /// <value>Name of the Issuer of the Document of the Additional</value>
        [DataMember(Name="orgaoExpedidorIdentidade", EmitDefaultValue=false)]
        public string OrgaoExpedidorIdentidade { get; set; }
    
        /// <summary>
        /// Acronym of the Federal Unity where the Identity document of the additional was issued
        /// </summary>
        /// <value>Acronym of the Federal Unity where the Identity document of the additional was issued</value>
        [DataMember(Name="unidadeFederativaIdentidade", EmitDefaultValue=false)]
        public string UnidadeFederativaIdentidade { get; set; }
    
        /// <summary>
        /// Date of the issue of the Identity document of the Additional
        /// </summary>
        /// <value>Date of the issue of the Identity document of the Additional</value>
        [DataMember(Name="dataEmissaoIdentidade", EmitDefaultValue=false)]
        public string DataEmissaoIdentidade { get; set; }
    
        /// <summary>
        /// Identification Code of kinship of the Additional with the holder
        /// </summary>
        /// <value>Identification Code of kinship of the Additional with the holder</value>
        [DataMember(Name="idParentesco", EmitDefaultValue=false)]
        public long? IdParentesco { get; set; }
    
        /// <summary>
        /// Indicate if the additional is active =1 or inactive =0
        /// </summary>
        /// <value>Indicate if the additional is active =1 or inactive =0</value>
        [DataMember(Name="flagAtivo", EmitDefaultValue=false)]
        public int? FlagAtivo { get; set; }
    
        /// <summary>
        /// Indicate the date of additional register
        /// </summary>
        /// <value>Indicate the date of additional register</value>
        [DataMember(Name="dataCadastroPortador", EmitDefaultValue=false)]
        public string DataCadastroPortador { get; set; }
    
        /// <summary>
        /// Indicate the date of the cancellation of the Additional
        /// </summary>
        /// <value>Indicate the date of the cancellation of the Additional</value>
        [DataMember(Name="dataCancelamentoPortador", EmitDefaultValue=false)]
        public string DataCancelamentoPortador { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdicionalResponse {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  NomeImpresso: ").Append(NomeImpresso).Append("\n");
            sb.Append("  NumeroReceitaFederal: ").Append(NumeroReceitaFederal).Append("\n");
            sb.Append("  DataNascimento: ").Append(DataNascimento).Append("\n");
            sb.Append("  Sexo: ").Append(Sexo).Append("\n");
            sb.Append("  NumeroIdentidade: ").Append(NumeroIdentidade).Append("\n");
            sb.Append("  OrgaoExpedidorIdentidade: ").Append(OrgaoExpedidorIdentidade).Append("\n");
            sb.Append("  UnidadeFederativaIdentidade: ").Append(UnidadeFederativaIdentidade).Append("\n");
            sb.Append("  DataEmissaoIdentidade: ").Append(DataEmissaoIdentidade).Append("\n");
            sb.Append("  IdParentesco: ").Append(IdParentesco).Append("\n");
            sb.Append("  FlagAtivo: ").Append(FlagAtivo).Append("\n");
            sb.Append("  DataCadastroPortador: ").Append(DataCadastroPortador).Append("\n");
            sb.Append("  DataCancelamentoPortador: ").Append(DataCancelamentoPortador).Append("\n");
            
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
            return this.Equals(obj as AdicionalResponse);
        }

        /// <summary>
        /// Returns true if AdicionalResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AdicionalResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdicionalResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.NomeImpresso == other.NomeImpresso ||
                    this.NomeImpresso != null &&
                    this.NomeImpresso.Equals(other.NomeImpresso)
                ) && 
                (
                    this.NumeroReceitaFederal == other.NumeroReceitaFederal ||
                    this.NumeroReceitaFederal != null &&
                    this.NumeroReceitaFederal.Equals(other.NumeroReceitaFederal)
                ) && 
                (
                    this.DataNascimento == other.DataNascimento ||
                    this.DataNascimento != null &&
                    this.DataNascimento.Equals(other.DataNascimento)
                ) && 
                (
                    this.Sexo == other.Sexo ||
                    this.Sexo != null &&
                    this.Sexo.Equals(other.Sexo)
                ) && 
                (
                    this.NumeroIdentidade == other.NumeroIdentidade ||
                    this.NumeroIdentidade != null &&
                    this.NumeroIdentidade.Equals(other.NumeroIdentidade)
                ) && 
                (
                    this.OrgaoExpedidorIdentidade == other.OrgaoExpedidorIdentidade ||
                    this.OrgaoExpedidorIdentidade != null &&
                    this.OrgaoExpedidorIdentidade.Equals(other.OrgaoExpedidorIdentidade)
                ) && 
                (
                    this.UnidadeFederativaIdentidade == other.UnidadeFederativaIdentidade ||
                    this.UnidadeFederativaIdentidade != null &&
                    this.UnidadeFederativaIdentidade.Equals(other.UnidadeFederativaIdentidade)
                ) && 
                (
                    this.DataEmissaoIdentidade == other.DataEmissaoIdentidade ||
                    this.DataEmissaoIdentidade != null &&
                    this.DataEmissaoIdentidade.Equals(other.DataEmissaoIdentidade)
                ) && 
                (
                    this.IdParentesco == other.IdParentesco ||
                    this.IdParentesco != null &&
                    this.IdParentesco.Equals(other.IdParentesco)
                ) && 
                (
                    this.FlagAtivo == other.FlagAtivo ||
                    this.FlagAtivo != null &&
                    this.FlagAtivo.Equals(other.FlagAtivo)
                ) && 
                (
                    this.DataCadastroPortador == other.DataCadastroPortador ||
                    this.DataCadastroPortador != null &&
                    this.DataCadastroPortador.Equals(other.DataCadastroPortador)
                ) && 
                (
                    this.DataCancelamentoPortador == other.DataCancelamentoPortador ||
                    this.DataCancelamentoPortador != null &&
                    this.DataCancelamentoPortador.Equals(other.DataCancelamentoPortador)
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
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.NomeImpresso != null)
                    hash = hash * 59 + this.NomeImpresso.GetHashCode();
                
                if (this.NumeroReceitaFederal != null)
                    hash = hash * 59 + this.NumeroReceitaFederal.GetHashCode();
                
                if (this.DataNascimento != null)
                    hash = hash * 59 + this.DataNascimento.GetHashCode();
                
                if (this.Sexo != null)
                    hash = hash * 59 + this.Sexo.GetHashCode();
                
                if (this.NumeroIdentidade != null)
                    hash = hash * 59 + this.NumeroIdentidade.GetHashCode();
                
                if (this.OrgaoExpedidorIdentidade != null)
                    hash = hash * 59 + this.OrgaoExpedidorIdentidade.GetHashCode();
                
                if (this.UnidadeFederativaIdentidade != null)
                    hash = hash * 59 + this.UnidadeFederativaIdentidade.GetHashCode();
                
                if (this.DataEmissaoIdentidade != null)
                    hash = hash * 59 + this.DataEmissaoIdentidade.GetHashCode();
                
                if (this.IdParentesco != null)
                    hash = hash * 59 + this.IdParentesco.GetHashCode();
                
                if (this.FlagAtivo != null)
                    hash = hash * 59 + this.FlagAtivo.GetHashCode();
                
                if (this.DataCadastroPortador != null)
                    hash = hash * 59 + this.DataCadastroPortador.GetHashCode();
                
                if (this.DataCancelamentoPortador != null)
                    hash = hash * 59 + this.DataCancelamentoPortador.GetHashCode();
                
                return hash;
            }
        }

    }
}
