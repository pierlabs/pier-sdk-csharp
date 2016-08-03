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
    /// 
    /// </summary>
    [DataContract]
    public partial class ContaCartaoResponse :  IEquatable<ContaCartaoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContaCartaoResponse" /> class.
        /// Initializes a new instance of the <see cref="ContaCartaoResponse" />class.
        /// </summary>
        /// <param name="CnpjLoja">CnpjLoja.</param>
        /// <param name="Cpf">Cpf.</param>
        /// <param name="DataCadastroConta">DataCadastroConta.</param>
        /// <param name="DataEmissaoIdentidade">DataEmissaoIdentidade.</param>
        /// <param name="DataNascimento">DataNascimento.</param>
        /// <param name="DddCelular">DddCelular.</param>
        /// <param name="IdConta">IdConta.</param>
        /// <param name="Nome">Nome.</param>
        /// <param name="NumeroCelular">NumeroCelular.</param>
        /// <param name="NumeroIdentidade">NumeroIdentidade.</param>
        /// <param name="OrgaoIdentidade">OrgaoIdentidade.</param>
        /// <param name="PossuiCompraAprovada">PossuiCompraAprovada.</param>
        /// <param name="StatusConta">StatusConta.</param>
        /// <param name="UfIdentidade">UfIdentidade.</param>

        public ContaCartaoResponse(string CnpjLoja = null, string Cpf = null, DateTime? DataCadastroConta = null, DateTime? DataEmissaoIdentidade = null, DateTime? DataNascimento = null, string DddCelular = null, int? IdConta = null, string Nome = null, string NumeroCelular = null, string NumeroIdentidade = null, string OrgaoIdentidade = null, string PossuiCompraAprovada = null, int? StatusConta = null, string UfIdentidade = null)
        {
            this.CnpjLoja = CnpjLoja;
            this.Cpf = Cpf;
            this.DataCadastroConta = DataCadastroConta;
            this.DataEmissaoIdentidade = DataEmissaoIdentidade;
            this.DataNascimento = DataNascimento;
            this.DddCelular = DddCelular;
            this.IdConta = IdConta;
            this.Nome = Nome;
            this.NumeroCelular = NumeroCelular;
            this.NumeroIdentidade = NumeroIdentidade;
            this.OrgaoIdentidade = OrgaoIdentidade;
            this.PossuiCompraAprovada = PossuiCompraAprovada;
            this.StatusConta = StatusConta;
            this.UfIdentidade = UfIdentidade;
            
        }
        
    
        /// <summary>
        /// Gets or Sets CnpjLoja
        /// </summary>
        [DataMember(Name="cnpjLoja", EmitDefaultValue=false)]
        public string CnpjLoja { get; set; }
    
        /// <summary>
        /// Gets or Sets Cpf
        /// </summary>
        [DataMember(Name="cpf", EmitDefaultValue=false)]
        public string Cpf { get; set; }
    
        /// <summary>
        /// Gets or Sets DataCadastroConta
        /// </summary>
        [DataMember(Name="dataCadastroConta", EmitDefaultValue=false)]
        public DateTime? DataCadastroConta { get; set; }
    
        /// <summary>
        /// Gets or Sets DataEmissaoIdentidade
        /// </summary>
        [DataMember(Name="dataEmissaoIdentidade", EmitDefaultValue=false)]
        public DateTime? DataEmissaoIdentidade { get; set; }
    
        /// <summary>
        /// Gets or Sets DataNascimento
        /// </summary>
        [DataMember(Name="dataNascimento", EmitDefaultValue=false)]
        public DateTime? DataNascimento { get; set; }
    
        /// <summary>
        /// Gets or Sets DddCelular
        /// </summary>
        [DataMember(Name="dddCelular", EmitDefaultValue=false)]
        public string DddCelular { get; set; }
    
        /// <summary>
        /// Gets or Sets IdConta
        /// </summary>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public int? IdConta { get; set; }
    
        /// <summary>
        /// Gets or Sets Nome
        /// </summary>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Gets or Sets NumeroCelular
        /// </summary>
        [DataMember(Name="numeroCelular", EmitDefaultValue=false)]
        public string NumeroCelular { get; set; }
    
        /// <summary>
        /// Gets or Sets NumeroIdentidade
        /// </summary>
        [DataMember(Name="numeroIdentidade", EmitDefaultValue=false)]
        public string NumeroIdentidade { get; set; }
    
        /// <summary>
        /// Gets or Sets OrgaoIdentidade
        /// </summary>
        [DataMember(Name="orgaoIdentidade", EmitDefaultValue=false)]
        public string OrgaoIdentidade { get; set; }
    
        /// <summary>
        /// Gets or Sets PossuiCompraAprovada
        /// </summary>
        [DataMember(Name="possuiCompraAprovada", EmitDefaultValue=false)]
        public string PossuiCompraAprovada { get; set; }
    
        /// <summary>
        /// Gets or Sets StatusConta
        /// </summary>
        [DataMember(Name="statusConta", EmitDefaultValue=false)]
        public int? StatusConta { get; set; }
    
        /// <summary>
        /// Gets or Sets UfIdentidade
        /// </summary>
        [DataMember(Name="ufIdentidade", EmitDefaultValue=false)]
        public string UfIdentidade { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContaCartaoResponse {\n");
            sb.Append("  CnpjLoja: ").Append(CnpjLoja).Append("\n");
            sb.Append("  Cpf: ").Append(Cpf).Append("\n");
            sb.Append("  DataCadastroConta: ").Append(DataCadastroConta).Append("\n");
            sb.Append("  DataEmissaoIdentidade: ").Append(DataEmissaoIdentidade).Append("\n");
            sb.Append("  DataNascimento: ").Append(DataNascimento).Append("\n");
            sb.Append("  DddCelular: ").Append(DddCelular).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  NumeroCelular: ").Append(NumeroCelular).Append("\n");
            sb.Append("  NumeroIdentidade: ").Append(NumeroIdentidade).Append("\n");
            sb.Append("  OrgaoIdentidade: ").Append(OrgaoIdentidade).Append("\n");
            sb.Append("  PossuiCompraAprovada: ").Append(PossuiCompraAprovada).Append("\n");
            sb.Append("  StatusConta: ").Append(StatusConta).Append("\n");
            sb.Append("  UfIdentidade: ").Append(UfIdentidade).Append("\n");
            
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
            return this.Equals(obj as ContaCartaoResponse);
        }

        /// <summary>
        /// Returns true if ContaCartaoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ContaCartaoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContaCartaoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CnpjLoja == other.CnpjLoja ||
                    this.CnpjLoja != null &&
                    this.CnpjLoja.Equals(other.CnpjLoja)
                ) && 
                (
                    this.Cpf == other.Cpf ||
                    this.Cpf != null &&
                    this.Cpf.Equals(other.Cpf)
                ) && 
                (
                    this.DataCadastroConta == other.DataCadastroConta ||
                    this.DataCadastroConta != null &&
                    this.DataCadastroConta.Equals(other.DataCadastroConta)
                ) && 
                (
                    this.DataEmissaoIdentidade == other.DataEmissaoIdentidade ||
                    this.DataEmissaoIdentidade != null &&
                    this.DataEmissaoIdentidade.Equals(other.DataEmissaoIdentidade)
                ) && 
                (
                    this.DataNascimento == other.DataNascimento ||
                    this.DataNascimento != null &&
                    this.DataNascimento.Equals(other.DataNascimento)
                ) && 
                (
                    this.DddCelular == other.DddCelular ||
                    this.DddCelular != null &&
                    this.DddCelular.Equals(other.DddCelular)
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
                    this.NumeroCelular == other.NumeroCelular ||
                    this.NumeroCelular != null &&
                    this.NumeroCelular.Equals(other.NumeroCelular)
                ) && 
                (
                    this.NumeroIdentidade == other.NumeroIdentidade ||
                    this.NumeroIdentidade != null &&
                    this.NumeroIdentidade.Equals(other.NumeroIdentidade)
                ) && 
                (
                    this.OrgaoIdentidade == other.OrgaoIdentidade ||
                    this.OrgaoIdentidade != null &&
                    this.OrgaoIdentidade.Equals(other.OrgaoIdentidade)
                ) && 
                (
                    this.PossuiCompraAprovada == other.PossuiCompraAprovada ||
                    this.PossuiCompraAprovada != null &&
                    this.PossuiCompraAprovada.Equals(other.PossuiCompraAprovada)
                ) && 
                (
                    this.StatusConta == other.StatusConta ||
                    this.StatusConta != null &&
                    this.StatusConta.Equals(other.StatusConta)
                ) && 
                (
                    this.UfIdentidade == other.UfIdentidade ||
                    this.UfIdentidade != null &&
                    this.UfIdentidade.Equals(other.UfIdentidade)
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
                
                if (this.CnpjLoja != null)
                    hash = hash * 59 + this.CnpjLoja.GetHashCode();
                
                if (this.Cpf != null)
                    hash = hash * 59 + this.Cpf.GetHashCode();
                
                if (this.DataCadastroConta != null)
                    hash = hash * 59 + this.DataCadastroConta.GetHashCode();
                
                if (this.DataEmissaoIdentidade != null)
                    hash = hash * 59 + this.DataEmissaoIdentidade.GetHashCode();
                
                if (this.DataNascimento != null)
                    hash = hash * 59 + this.DataNascimento.GetHashCode();
                
                if (this.DddCelular != null)
                    hash = hash * 59 + this.DddCelular.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.NumeroCelular != null)
                    hash = hash * 59 + this.NumeroCelular.GetHashCode();
                
                if (this.NumeroIdentidade != null)
                    hash = hash * 59 + this.NumeroIdentidade.GetHashCode();
                
                if (this.OrgaoIdentidade != null)
                    hash = hash * 59 + this.OrgaoIdentidade.GetHashCode();
                
                if (this.PossuiCompraAprovada != null)
                    hash = hash * 59 + this.PossuiCompraAprovada.GetHashCode();
                
                if (this.StatusConta != null)
                    hash = hash * 59 + this.StatusConta.GetHashCode();
                
                if (this.UfIdentidade != null)
                    hash = hash * 59 + this.UfIdentidade.GetHashCode();
                
                return hash;
            }
        }

    }
}
