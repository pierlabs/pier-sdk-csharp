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
    /// Representa\u00E7\u00E3o de um objeto de respota para convenio
    /// </summary>
    [DataContract]
    public partial class ConvenioResponse :  IEquatable<ConvenioResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvenioResponse" /> class.
        /// Initializes a new instance of the <see cref="ConvenioResponse" />class.
        /// </summary>
        /// <param name="Id">Id do Convenio.</param>
        /// <param name="Banco">Identifica\u00E7\u00E3o do banco.</param>
        /// <param name="Agencia">N\u00FAmero da ag\u00EAncia.</param>
        /// <param name="ContaCorrente">Conta corrente.</param>
        /// <param name="Especie">C\u00F3digo do tipo de esp\u00E9cie do documento.</param>
        /// <param name="NumeroConvenio">C\u00F3digo de identifica\u00E7\u00E3o do conv\u00EAnio.</param>
        /// <param name="Carteira">C\u00F3digo da carteira de cobran\u00E7a.</param>
        /// <param name="CodigoCedente">C\u00F3digo do cedente.</param>
        /// <param name="EspecieTipo">Tipo de esp\u00E9cie de t\u00EDtulo de cr\u00E9dito.</param>
        /// <param name="EspecieDocumento">Tipo de esp\u00E9cie de documento.</param>
        /// <param name="Aceite">Indica se o pagador assinou o documento de cobran\u00E7a que originou o boleto. O padr\u00E3o \u00E9 usar N.</param>
        /// <param name="Instrucoes">Instru\u00E7\u00F5es para pagamento.</param>
        /// <param name="LocalPagamento1">Local preferencial onde pode ser efetuado o pagamento.</param>
        /// <param name="LocalPagamento2">Local para pagamento (campo adicional).</param>
        /// <param name="EnderecoCobrancaEmissor">Endere\u00E7o de cobran\u00E7a do emissor.</param>
        /// <param name="NomeBeneficiario">Nome do benefici\u00E1rio/cedente da cobran\u00E7a.</param>
        /// <param name="CnpjBeneficiario">CNPJ do benefici\u00E1rio/cedente da cobran\u00E7a.</param>
        /// <param name="Operador">Usu\u00E1rio responsavel pelo cadastro e/ou altera\u00E7\u00E3o do conv\u00EAnio.</param>
        /// <param name="Data">Data de cadastro/altera\u00E7\u00E3o do conv\u00EAnio.</param>
        /// <param name="Maquina">M\u00E1quina pela qual foi realizado o cadastro ou altera\u00E7\u00E3o.</param>

        public ConvenioResponse(long? Id = null, long? Banco = null, long? Agencia = null, string ContaCorrente = null, string Especie = null, double? NumeroConvenio = null, long? Carteira = null, string CodigoCedente = null, string EspecieTipo = null, string EspecieDocumento = null, string Aceite = null, string Instrucoes = null, string LocalPagamento1 = null, string LocalPagamento2 = null, string EnderecoCobrancaEmissor = null, string NomeBeneficiario = null, string CnpjBeneficiario = null, string Operador = null, string Data = null, string Maquina = null)
        {
            this.Id = Id;
            this.Banco = Banco;
            this.Agencia = Agencia;
            this.ContaCorrente = ContaCorrente;
            this.Especie = Especie;
            this.NumeroConvenio = NumeroConvenio;
            this.Carteira = Carteira;
            this.CodigoCedente = CodigoCedente;
            this.EspecieTipo = EspecieTipo;
            this.EspecieDocumento = EspecieDocumento;
            this.Aceite = Aceite;
            this.Instrucoes = Instrucoes;
            this.LocalPagamento1 = LocalPagamento1;
            this.LocalPagamento2 = LocalPagamento2;
            this.EnderecoCobrancaEmissor = EnderecoCobrancaEmissor;
            this.NomeBeneficiario = NomeBeneficiario;
            this.CnpjBeneficiario = CnpjBeneficiario;
            this.Operador = Operador;
            this.Data = Data;
            this.Maquina = Maquina;
            
        }
        
    
        /// <summary>
        /// Id do Convenio
        /// </summary>
        /// <value>Id do Convenio</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Identifica\u00E7\u00E3o do banco
        /// </summary>
        /// <value>Identifica\u00E7\u00E3o do banco</value>
        [DataMember(Name="banco", EmitDefaultValue=false)]
        public long? Banco { get; set; }
    
        /// <summary>
        /// N\u00FAmero da ag\u00EAncia
        /// </summary>
        /// <value>N\u00FAmero da ag\u00EAncia</value>
        [DataMember(Name="agencia", EmitDefaultValue=false)]
        public long? Agencia { get; set; }
    
        /// <summary>
        /// Conta corrente
        /// </summary>
        /// <value>Conta corrente</value>
        [DataMember(Name="contaCorrente", EmitDefaultValue=false)]
        public string ContaCorrente { get; set; }
    
        /// <summary>
        /// C\u00F3digo do tipo de esp\u00E9cie do documento
        /// </summary>
        /// <value>C\u00F3digo do tipo de esp\u00E9cie do documento</value>
        [DataMember(Name="especie", EmitDefaultValue=false)]
        public string Especie { get; set; }
    
        /// <summary>
        /// C\u00F3digo de identifica\u00E7\u00E3o do conv\u00EAnio
        /// </summary>
        /// <value>C\u00F3digo de identifica\u00E7\u00E3o do conv\u00EAnio</value>
        [DataMember(Name="numeroConvenio", EmitDefaultValue=false)]
        public double? NumeroConvenio { get; set; }
    
        /// <summary>
        /// C\u00F3digo da carteira de cobran\u00E7a
        /// </summary>
        /// <value>C\u00F3digo da carteira de cobran\u00E7a</value>
        [DataMember(Name="carteira", EmitDefaultValue=false)]
        public long? Carteira { get; set; }
    
        /// <summary>
        /// C\u00F3digo do cedente
        /// </summary>
        /// <value>C\u00F3digo do cedente</value>
        [DataMember(Name="codigoCedente", EmitDefaultValue=false)]
        public string CodigoCedente { get; set; }
    
        /// <summary>
        /// Tipo de esp\u00E9cie de t\u00EDtulo de cr\u00E9dito
        /// </summary>
        /// <value>Tipo de esp\u00E9cie de t\u00EDtulo de cr\u00E9dito</value>
        [DataMember(Name="especieTipo", EmitDefaultValue=false)]
        public string EspecieTipo { get; set; }
    
        /// <summary>
        /// Tipo de esp\u00E9cie de documento
        /// </summary>
        /// <value>Tipo de esp\u00E9cie de documento</value>
        [DataMember(Name="especieDocumento", EmitDefaultValue=false)]
        public string EspecieDocumento { get; set; }
    
        /// <summary>
        /// Indica se o pagador assinou o documento de cobran\u00E7a que originou o boleto. O padr\u00E3o \u00E9 usar N
        /// </summary>
        /// <value>Indica se o pagador assinou o documento de cobran\u00E7a que originou o boleto. O padr\u00E3o \u00E9 usar N</value>
        [DataMember(Name="aceite", EmitDefaultValue=false)]
        public string Aceite { get; set; }
    
        /// <summary>
        /// Instru\u00E7\u00F5es para pagamento
        /// </summary>
        /// <value>Instru\u00E7\u00F5es para pagamento</value>
        [DataMember(Name="instrucoes", EmitDefaultValue=false)]
        public string Instrucoes { get; set; }
    
        /// <summary>
        /// Local preferencial onde pode ser efetuado o pagamento
        /// </summary>
        /// <value>Local preferencial onde pode ser efetuado o pagamento</value>
        [DataMember(Name="localPagamento1", EmitDefaultValue=false)]
        public string LocalPagamento1 { get; set; }
    
        /// <summary>
        /// Local para pagamento (campo adicional)
        /// </summary>
        /// <value>Local para pagamento (campo adicional)</value>
        [DataMember(Name="localPagamento2", EmitDefaultValue=false)]
        public string LocalPagamento2 { get; set; }
    
        /// <summary>
        /// Endere\u00E7o de cobran\u00E7a do emissor
        /// </summary>
        /// <value>Endere\u00E7o de cobran\u00E7a do emissor</value>
        [DataMember(Name="enderecoCobrancaEmissor", EmitDefaultValue=false)]
        public string EnderecoCobrancaEmissor { get; set; }
    
        /// <summary>
        /// Nome do benefici\u00E1rio/cedente da cobran\u00E7a
        /// </summary>
        /// <value>Nome do benefici\u00E1rio/cedente da cobran\u00E7a</value>
        [DataMember(Name="nomeBeneficiario", EmitDefaultValue=false)]
        public string NomeBeneficiario { get; set; }
    
        /// <summary>
        /// CNPJ do benefici\u00E1rio/cedente da cobran\u00E7a
        /// </summary>
        /// <value>CNPJ do benefici\u00E1rio/cedente da cobran\u00E7a</value>
        [DataMember(Name="cnpjBeneficiario", EmitDefaultValue=false)]
        public string CnpjBeneficiario { get; set; }
    
        /// <summary>
        /// Usu\u00E1rio responsavel pelo cadastro e/ou altera\u00E7\u00E3o do conv\u00EAnio
        /// </summary>
        /// <value>Usu\u00E1rio responsavel pelo cadastro e/ou altera\u00E7\u00E3o do conv\u00EAnio</value>
        [DataMember(Name="operador", EmitDefaultValue=false)]
        public string Operador { get; set; }
    
        /// <summary>
        /// Data de cadastro/altera\u00E7\u00E3o do conv\u00EAnio
        /// </summary>
        /// <value>Data de cadastro/altera\u00E7\u00E3o do conv\u00EAnio</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public string Data { get; set; }
    
        /// <summary>
        /// M\u00E1quina pela qual foi realizado o cadastro ou altera\u00E7\u00E3o
        /// </summary>
        /// <value>M\u00E1quina pela qual foi realizado o cadastro ou altera\u00E7\u00E3o</value>
        [DataMember(Name="maquina", EmitDefaultValue=false)]
        public string Maquina { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConvenioResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Banco: ").Append(Banco).Append("\n");
            sb.Append("  Agencia: ").Append(Agencia).Append("\n");
            sb.Append("  ContaCorrente: ").Append(ContaCorrente).Append("\n");
            sb.Append("  Especie: ").Append(Especie).Append("\n");
            sb.Append("  NumeroConvenio: ").Append(NumeroConvenio).Append("\n");
            sb.Append("  Carteira: ").Append(Carteira).Append("\n");
            sb.Append("  CodigoCedente: ").Append(CodigoCedente).Append("\n");
            sb.Append("  EspecieTipo: ").Append(EspecieTipo).Append("\n");
            sb.Append("  EspecieDocumento: ").Append(EspecieDocumento).Append("\n");
            sb.Append("  Aceite: ").Append(Aceite).Append("\n");
            sb.Append("  Instrucoes: ").Append(Instrucoes).Append("\n");
            sb.Append("  LocalPagamento1: ").Append(LocalPagamento1).Append("\n");
            sb.Append("  LocalPagamento2: ").Append(LocalPagamento2).Append("\n");
            sb.Append("  EnderecoCobrancaEmissor: ").Append(EnderecoCobrancaEmissor).Append("\n");
            sb.Append("  NomeBeneficiario: ").Append(NomeBeneficiario).Append("\n");
            sb.Append("  CnpjBeneficiario: ").Append(CnpjBeneficiario).Append("\n");
            sb.Append("  Operador: ").Append(Operador).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Maquina: ").Append(Maquina).Append("\n");
            
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
            return this.Equals(obj as ConvenioResponse);
        }

        /// <summary>
        /// Returns true if ConvenioResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ConvenioResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConvenioResponse other)
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
                    this.ContaCorrente == other.ContaCorrente ||
                    this.ContaCorrente != null &&
                    this.ContaCorrente.Equals(other.ContaCorrente)
                ) && 
                (
                    this.Especie == other.Especie ||
                    this.Especie != null &&
                    this.Especie.Equals(other.Especie)
                ) && 
                (
                    this.NumeroConvenio == other.NumeroConvenio ||
                    this.NumeroConvenio != null &&
                    this.NumeroConvenio.Equals(other.NumeroConvenio)
                ) && 
                (
                    this.Carteira == other.Carteira ||
                    this.Carteira != null &&
                    this.Carteira.Equals(other.Carteira)
                ) && 
                (
                    this.CodigoCedente == other.CodigoCedente ||
                    this.CodigoCedente != null &&
                    this.CodigoCedente.Equals(other.CodigoCedente)
                ) && 
                (
                    this.EspecieTipo == other.EspecieTipo ||
                    this.EspecieTipo != null &&
                    this.EspecieTipo.Equals(other.EspecieTipo)
                ) && 
                (
                    this.EspecieDocumento == other.EspecieDocumento ||
                    this.EspecieDocumento != null &&
                    this.EspecieDocumento.Equals(other.EspecieDocumento)
                ) && 
                (
                    this.Aceite == other.Aceite ||
                    this.Aceite != null &&
                    this.Aceite.Equals(other.Aceite)
                ) && 
                (
                    this.Instrucoes == other.Instrucoes ||
                    this.Instrucoes != null &&
                    this.Instrucoes.Equals(other.Instrucoes)
                ) && 
                (
                    this.LocalPagamento1 == other.LocalPagamento1 ||
                    this.LocalPagamento1 != null &&
                    this.LocalPagamento1.Equals(other.LocalPagamento1)
                ) && 
                (
                    this.LocalPagamento2 == other.LocalPagamento2 ||
                    this.LocalPagamento2 != null &&
                    this.LocalPagamento2.Equals(other.LocalPagamento2)
                ) && 
                (
                    this.EnderecoCobrancaEmissor == other.EnderecoCobrancaEmissor ||
                    this.EnderecoCobrancaEmissor != null &&
                    this.EnderecoCobrancaEmissor.Equals(other.EnderecoCobrancaEmissor)
                ) && 
                (
                    this.NomeBeneficiario == other.NomeBeneficiario ||
                    this.NomeBeneficiario != null &&
                    this.NomeBeneficiario.Equals(other.NomeBeneficiario)
                ) && 
                (
                    this.CnpjBeneficiario == other.CnpjBeneficiario ||
                    this.CnpjBeneficiario != null &&
                    this.CnpjBeneficiario.Equals(other.CnpjBeneficiario)
                ) && 
                (
                    this.Operador == other.Operador ||
                    this.Operador != null &&
                    this.Operador.Equals(other.Operador)
                ) && 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.Equals(other.Data)
                ) && 
                (
                    this.Maquina == other.Maquina ||
                    this.Maquina != null &&
                    this.Maquina.Equals(other.Maquina)
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
                
                if (this.Banco != null)
                    hash = hash * 59 + this.Banco.GetHashCode();
                
                if (this.Agencia != null)
                    hash = hash * 59 + this.Agencia.GetHashCode();
                
                if (this.ContaCorrente != null)
                    hash = hash * 59 + this.ContaCorrente.GetHashCode();
                
                if (this.Especie != null)
                    hash = hash * 59 + this.Especie.GetHashCode();
                
                if (this.NumeroConvenio != null)
                    hash = hash * 59 + this.NumeroConvenio.GetHashCode();
                
                if (this.Carteira != null)
                    hash = hash * 59 + this.Carteira.GetHashCode();
                
                if (this.CodigoCedente != null)
                    hash = hash * 59 + this.CodigoCedente.GetHashCode();
                
                if (this.EspecieTipo != null)
                    hash = hash * 59 + this.EspecieTipo.GetHashCode();
                
                if (this.EspecieDocumento != null)
                    hash = hash * 59 + this.EspecieDocumento.GetHashCode();
                
                if (this.Aceite != null)
                    hash = hash * 59 + this.Aceite.GetHashCode();
                
                if (this.Instrucoes != null)
                    hash = hash * 59 + this.Instrucoes.GetHashCode();
                
                if (this.LocalPagamento1 != null)
                    hash = hash * 59 + this.LocalPagamento1.GetHashCode();
                
                if (this.LocalPagamento2 != null)
                    hash = hash * 59 + this.LocalPagamento2.GetHashCode();
                
                if (this.EnderecoCobrancaEmissor != null)
                    hash = hash * 59 + this.EnderecoCobrancaEmissor.GetHashCode();
                
                if (this.NomeBeneficiario != null)
                    hash = hash * 59 + this.NomeBeneficiario.GetHashCode();
                
                if (this.CnpjBeneficiario != null)
                    hash = hash * 59 + this.CnpjBeneficiario.GetHashCode();
                
                if (this.Operador != null)
                    hash = hash * 59 + this.Operador.GetHashCode();
                
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                
                if (this.Maquina != null)
                    hash = hash * 59 + this.Maquina.GetHashCode();
                
                return hash;
            }
        }

    }
}
