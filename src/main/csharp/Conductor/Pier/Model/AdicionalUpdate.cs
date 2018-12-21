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
    /// {{{adicional_update_description}}}
    /// </summary>
    [DataContract]
    public partial class AdicionalUpdate :  IEquatable<AdicionalUpdate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdicionalUpdate" /> class.
        /// Initializes a new instance of the <see cref="AdicionalUpdate" />class.
        /// </summary>
        /// <param name="Nome">{{{adicional_update_nome_value}}} (required).</param>
        /// <param name="NomeImpresso">{{{adicional_update_nome_impresso_value}}}.</param>
        /// <param name="NumeroReceitaFederal">{{{adicional_update_numero_receita_federal_value}}} (required).</param>
        /// <param name="DataNascimento">{{{adicional_update_data_nascimento_value}}}.</param>
        /// <param name="Sexo">{{{adicional_update_sexo_value}}}.</param>
        /// <param name="NumeroIdentidade">{{{adicional_update_numero_identidade_value}}}.</param>
        /// <param name="OrgaoExpedidorIdentidade">{{{adicional_update_orgao_expedidor_identidade_value}}}.</param>
        /// <param name="UnidadeFederativaIdentidade">{{{adicional_update_unidade_federativa_identidade_value}}}.</param>
        /// <param name="DataEmissaoIdentidade">{{{adicional_update_data_emissao_identidade_value}}}.</param>
        /// <param name="IdParentesco">{{{adicional_update_id_parentesco_value}}}.</param>
        /// <param name="Telefones">{{{adicional_update_telefones_value}}}.</param>

        public AdicionalUpdate(string Nome = null, string NomeImpresso = null, string NumeroReceitaFederal = null, string DataNascimento = null, string Sexo = null, string NumeroIdentidade = null, string OrgaoExpedidorIdentidade = null, string UnidadeFederativaIdentidade = null, string DataEmissaoIdentidade = null, long? IdParentesco = null, List<TelefoneAdicionalUpdate> Telefones = null)
        {
            // to ensure "Nome" is required (not null)
            if (Nome == null)
            {
                throw new InvalidDataException("Nome is a required property for AdicionalUpdate and cannot be null");
            }
            else
            {
                this.Nome = Nome;
            }
            // to ensure "NumeroReceitaFederal" is required (not null)
            if (NumeroReceitaFederal == null)
            {
                throw new InvalidDataException("NumeroReceitaFederal is a required property for AdicionalUpdate and cannot be null");
            }
            else
            {
                this.NumeroReceitaFederal = NumeroReceitaFederal;
            }
            this.NomeImpresso = NomeImpresso;
            this.DataNascimento = DataNascimento;
            this.Sexo = Sexo;
            this.NumeroIdentidade = NumeroIdentidade;
            this.OrgaoExpedidorIdentidade = OrgaoExpedidorIdentidade;
            this.UnidadeFederativaIdentidade = UnidadeFederativaIdentidade;
            this.DataEmissaoIdentidade = DataEmissaoIdentidade;
            this.IdParentesco = IdParentesco;
            this.Telefones = Telefones;
            
        }
        
    
        /// <summary>
        /// {{{adicional_update_nome_value}}}
        /// </summary>
        /// <value>{{{adicional_update_nome_value}}}</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// {{{adicional_update_nome_impresso_value}}}
        /// </summary>
        /// <value>{{{adicional_update_nome_impresso_value}}}</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
        /// <summary>
        /// {{{adicional_update_numero_receita_federal_value}}}
        /// </summary>
        /// <value>{{{adicional_update_numero_receita_federal_value}}}</value>
        [DataMember(Name="numeroReceitaFederal", EmitDefaultValue=false)]
        public string NumeroReceitaFederal { get; set; }
    
        /// <summary>
        /// {{{adicional_update_data_nascimento_value}}}
        /// </summary>
        /// <value>{{{adicional_update_data_nascimento_value}}}</value>
        [DataMember(Name="dataNascimento", EmitDefaultValue=false)]
        public string DataNascimento { get; set; }
    
        /// <summary>
        /// {{{adicional_update_sexo_value}}}
        /// </summary>
        /// <value>{{{adicional_update_sexo_value}}}</value>
        [DataMember(Name="sexo", EmitDefaultValue=false)]
        public string Sexo { get; set; }
    
        /// <summary>
        /// {{{adicional_update_numero_identidade_value}}}
        /// </summary>
        /// <value>{{{adicional_update_numero_identidade_value}}}</value>
        [DataMember(Name="numeroIdentidade", EmitDefaultValue=false)]
        public string NumeroIdentidade { get; set; }
    
        /// <summary>
        /// {{{adicional_update_orgao_expedidor_identidade_value}}}
        /// </summary>
        /// <value>{{{adicional_update_orgao_expedidor_identidade_value}}}</value>
        [DataMember(Name="orgaoExpedidorIdentidade", EmitDefaultValue=false)]
        public string OrgaoExpedidorIdentidade { get; set; }
    
        /// <summary>
        /// {{{adicional_update_unidade_federativa_identidade_value}}}
        /// </summary>
        /// <value>{{{adicional_update_unidade_federativa_identidade_value}}}</value>
        [DataMember(Name="unidadeFederativaIdentidade", EmitDefaultValue=false)]
        public string UnidadeFederativaIdentidade { get; set; }
    
        /// <summary>
        /// {{{adicional_update_data_emissao_identidade_value}}}
        /// </summary>
        /// <value>{{{adicional_update_data_emissao_identidade_value}}}</value>
        [DataMember(Name="dataEmissaoIdentidade", EmitDefaultValue=false)]
        public string DataEmissaoIdentidade { get; set; }
    
        /// <summary>
        /// {{{adicional_update_id_parentesco_value}}}
        /// </summary>
        /// <value>{{{adicional_update_id_parentesco_value}}}</value>
        [DataMember(Name="idParentesco", EmitDefaultValue=false)]
        public long? IdParentesco { get; set; }
    
        /// <summary>
        /// {{{adicional_update_telefones_value}}}
        /// </summary>
        /// <value>{{{adicional_update_telefones_value}}}</value>
        [DataMember(Name="telefones", EmitDefaultValue=false)]
        public List<TelefoneAdicionalUpdate> Telefones { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdicionalUpdate {\n");
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
            sb.Append("  Telefones: ").Append(Telefones).Append("\n");
            
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
            return this.Equals(obj as AdicionalUpdate);
        }

        /// <summary>
        /// Returns true if AdicionalUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of AdicionalUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdicionalUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.Telefones == other.Telefones ||
                    this.Telefones != null &&
                    this.Telefones.SequenceEqual(other.Telefones)
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
                
                if (this.Telefones != null)
                    hash = hash * 59 + this.Telefones.GetHashCode();
                
                return hash;
            }
        }

    }
}
