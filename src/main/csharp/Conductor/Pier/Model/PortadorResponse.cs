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
    /// Cardholder
    /// </summary>
    [DataContract]
    public partial class PortadorResponse :  IEquatable<PortadorResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PortadorResponse" /> class.
        /// Initializes a new instance of the <see cref="PortadorResponse" />class.
        /// </summary>
        /// <param name="IdConta">Identification Code of the Account (id).</param>
        /// <param name="IdProduto">Identification Code of the Product (id).</param>
        /// <param name="IdPessoa">Identification Code of the Person (id).</param>
        /// <param name="IdParentesco">Identification Code of the Kinship (id).</param>
        /// <param name="TipoPortador">Show the type of Cardholder, being (&#39;H&#39;: Holder, &#39;A&#39;: Additional).</param>
        /// <param name="NomeImpresso">Show the name to be printed on the card.</param>
        /// <param name="IdTipoCartao">Show the identification Code of the Card type (id), that will be used to create cards of this cardholder, linked to the respective account through the Idaccount field.</param>
        /// <param name="FlagAtivo">When it is active, indicate that the register of the Cardholder is active, in issuers that make this type of manangement.</param>
        /// <param name="DataCadastroPortador">show the date which the Cardholder was registered, when there is this information.</param>
        /// <param name="DataCancelamentoPortador">Show the date which the Cardholder was canceled, when there is this information.</param>

        public PortadorResponse(long? IdConta = null, long? IdProduto = null, long? IdPessoa = null, long? IdParentesco = null, string TipoPortador = null, string NomeImpresso = null, long? IdTipoCartao = null, int? FlagAtivo = null, string DataCadastroPortador = null, string DataCancelamentoPortador = null)
        {
            this.IdConta = IdConta;
            this.IdProduto = IdProduto;
            this.IdPessoa = IdPessoa;
            this.IdParentesco = IdParentesco;
            this.TipoPortador = TipoPortador;
            this.NomeImpresso = NomeImpresso;
            this.IdTipoCartao = IdTipoCartao;
            this.FlagAtivo = FlagAtivo;
            this.DataCadastroPortador = DataCadastroPortador;
            this.DataCancelamentoPortador = DataCancelamentoPortador;
            
        }
        
    
        /// <summary>
        /// Identification Code of the Account (id)
        /// </summary>
        /// <value>Identification Code of the Account (id)</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Identification Code of the Product (id)
        /// </summary>
        /// <value>Identification Code of the Product (id)</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// Identification Code of the Person (id)
        /// </summary>
        /// <value>Identification Code of the Person (id)</value>
        [DataMember(Name="idPessoa", EmitDefaultValue=false)]
        public long? IdPessoa { get; set; }
    
        /// <summary>
        /// Identification Code of the Kinship (id)
        /// </summary>
        /// <value>Identification Code of the Kinship (id)</value>
        [DataMember(Name="idParentesco", EmitDefaultValue=false)]
        public long? IdParentesco { get; set; }
    
        /// <summary>
        /// Show the type of Cardholder, being (&#39;H&#39;: Holder, &#39;A&#39;: Additional)
        /// </summary>
        /// <value>Show the type of Cardholder, being (&#39;H&#39;: Holder, &#39;A&#39;: Additional)</value>
        [DataMember(Name="tipoPortador", EmitDefaultValue=false)]
        public string TipoPortador { get; set; }
    
        /// <summary>
        /// Show the name to be printed on the card
        /// </summary>
        /// <value>Show the name to be printed on the card</value>
        [DataMember(Name="nomeImpresso", EmitDefaultValue=false)]
        public string NomeImpresso { get; set; }
    
        /// <summary>
        /// Show the identification Code of the Card type (id), that will be used to create cards of this cardholder, linked to the respective account through the Idaccount field
        /// </summary>
        /// <value>Show the identification Code of the Card type (id), that will be used to create cards of this cardholder, linked to the respective account through the Idaccount field</value>
        [DataMember(Name="idTipoCartao", EmitDefaultValue=false)]
        public long? IdTipoCartao { get; set; }
    
        /// <summary>
        /// When it is active, indicate that the register of the Cardholder is active, in issuers that make this type of manangement
        /// </summary>
        /// <value>When it is active, indicate that the register of the Cardholder is active, in issuers that make this type of manangement</value>
        [DataMember(Name="flagAtivo", EmitDefaultValue=false)]
        public int? FlagAtivo { get; set; }
    
        /// <summary>
        /// show the date which the Cardholder was registered, when there is this information
        /// </summary>
        /// <value>show the date which the Cardholder was registered, when there is this information</value>
        [DataMember(Name="dataCadastroPortador", EmitDefaultValue=false)]
        public string DataCadastroPortador { get; set; }
    
        /// <summary>
        /// Show the date which the Cardholder was canceled, when there is this information
        /// </summary>
        /// <value>Show the date which the Cardholder was canceled, when there is this information</value>
        [DataMember(Name="dataCancelamentoPortador", EmitDefaultValue=false)]
        public string DataCancelamentoPortador { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PortadorResponse {\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  IdPessoa: ").Append(IdPessoa).Append("\n");
            sb.Append("  IdParentesco: ").Append(IdParentesco).Append("\n");
            sb.Append("  TipoPortador: ").Append(TipoPortador).Append("\n");
            sb.Append("  NomeImpresso: ").Append(NomeImpresso).Append("\n");
            sb.Append("  IdTipoCartao: ").Append(IdTipoCartao).Append("\n");
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
            return this.Equals(obj as PortadorResponse);
        }

        /// <summary>
        /// Returns true if PortadorResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PortadorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PortadorResponse other)
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
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.IdPessoa == other.IdPessoa ||
                    this.IdPessoa != null &&
                    this.IdPessoa.Equals(other.IdPessoa)
                ) && 
                (
                    this.IdParentesco == other.IdParentesco ||
                    this.IdParentesco != null &&
                    this.IdParentesco.Equals(other.IdParentesco)
                ) && 
                (
                    this.TipoPortador == other.TipoPortador ||
                    this.TipoPortador != null &&
                    this.TipoPortador.Equals(other.TipoPortador)
                ) && 
                (
                    this.NomeImpresso == other.NomeImpresso ||
                    this.NomeImpresso != null &&
                    this.NomeImpresso.Equals(other.NomeImpresso)
                ) && 
                (
                    this.IdTipoCartao == other.IdTipoCartao ||
                    this.IdTipoCartao != null &&
                    this.IdTipoCartao.Equals(other.IdTipoCartao)
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
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.IdPessoa != null)
                    hash = hash * 59 + this.IdPessoa.GetHashCode();
                
                if (this.IdParentesco != null)
                    hash = hash * 59 + this.IdParentesco.GetHashCode();
                
                if (this.TipoPortador != null)
                    hash = hash * 59 + this.TipoPortador.GetHashCode();
                
                if (this.NomeImpresso != null)
                    hash = hash * 59 + this.NomeImpresso.GetHashCode();
                
                if (this.IdTipoCartao != null)
                    hash = hash * 59 + this.IdTipoCartao.GetHashCode();
                
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
