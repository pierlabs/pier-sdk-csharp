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
    /// Response Representation of the recurrent debit type resource
    /// </summary>
    [DataContract]
    public partial class TipoDebitoRecorrenteResponse :  IEquatable<TipoDebitoRecorrenteResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoDebitoRecorrenteResponse" /> class.
        /// Initializes a new instance of the <see cref="TipoDebitoRecorrenteResponse" />class.
        /// </summary>
        /// <param name="FlagAnuidadeBonificada">FlagAnuidadeBonificada.</param>
        /// <param name="Id">Identification Code of the recurrent debit type (id).</param>
        /// <param name="Nome">Description of the recurrent debit type.</param>
        /// <param name="Valor">Value of the recurrent debit type.</param>
        /// <param name="FlagAtivo">Flag that identifies if the type of recurrent debit is active.</param>
        /// <param name="ValorBonus">Bonus value referring to the plan.</param>
        /// <param name="NumeroParcelas">Parcel Number referring to the plan.</param>
        /// <param name="FlagAdereAutomatico">Flag that indicates if the renovation is going to be automatic.</param>
        /// <param name="FlagGeraNumeroSorte">Flag that indicates if the renewal is going to be automatic.</param>
        /// <param name="FaixaEtaria">Indicates the age range to join to the plan.</param>
        /// <param name="FlagSeguro">Flag indicates if the plan is safe.</param>
        /// <param name="SorteiosMensais">Indicates which award referring to the month.</param>
        /// <param name="FlagAdesaoAutomatica">Flag that indicates if the accession of the plan will be automatic.</param>
        /// <param name="FlagDependente">Flag indicate if the plan covers the dependent.</param>
        /// <param name="QuantidadeDependente">Indicate dependent numbers.</param>
        /// <param name="IdTermoSeguroServico">Identification Code of the security service term (id).</param>
        /// <param name="IdadeMinima">Minimum age to join to the plan.</param>
        /// <param name="IdadeMaxima">Maximum age to join to the plan.</param>
        /// <param name="FlagDebitoIncondicional">Flag indicates if the plan will have an unconditional debit.</param>
        /// <param name="FlagExtratoIncondicional">Flag that indicates if the plan will be unconditional extract.</param>
        /// <param name="FlagEstornoAutomatico">Flag indicates if the plan will have any automatic reversal.</param>
        /// <param name="ValorRepassadoSeguradora">Value passed to the insurer.</param>
        /// <param name="FlagLancaTransacao">Flag that indicates if it is going to launched a transaction.</param>
        /// <param name="FlagTransferenciaAutomatica">Flag that indicates if it is going to be made an automatic transfer.</param>
        /// <param name="IdProduto">Identification Code of the products (id).</param>
        /// <param name="IdGrupoDebitoRecorrente">Identification Code of the recurrent debit group (id).</param>
        /// <param name="QuantidadeTentativasCobranca">Attempt Quantities for the collection.</param>
        /// <param name="IdAjuste">Identification Code of the adjustment types (id).</param>

        public TipoDebitoRecorrenteResponse(bool? FlagAnuidadeBonificada = null, long? Id = null, string Nome = null, double? Valor = null, bool? FlagAtivo = null, double? ValorBonus = null, int? NumeroParcelas = null, bool? FlagAdereAutomatico = null, bool? FlagGeraNumeroSorte = null, string FaixaEtaria = null, bool? FlagSeguro = null, string SorteiosMensais = null, bool? FlagAdesaoAutomatica = null, bool? FlagDependente = null, int? QuantidadeDependente = null, long? IdTermoSeguroServico = null, int? IdadeMinima = null, int? IdadeMaxima = null, bool? FlagDebitoIncondicional = null, bool? FlagExtratoIncondicional = null, bool? FlagEstornoAutomatico = null, double? ValorRepassadoSeguradora = null, bool? FlagLancaTransacao = null, bool? FlagTransferenciaAutomatica = null, long? IdProduto = null, long? IdGrupoDebitoRecorrente = null, int? QuantidadeTentativasCobranca = null, long? IdAjuste = null)
        {
            this.FlagAnuidadeBonificada = FlagAnuidadeBonificada;
            this.Id = Id;
            this.Nome = Nome;
            this.Valor = Valor;
            this.FlagAtivo = FlagAtivo;
            this.ValorBonus = ValorBonus;
            this.NumeroParcelas = NumeroParcelas;
            this.FlagAdereAutomatico = FlagAdereAutomatico;
            this.FlagGeraNumeroSorte = FlagGeraNumeroSorte;
            this.FaixaEtaria = FaixaEtaria;
            this.FlagSeguro = FlagSeguro;
            this.SorteiosMensais = SorteiosMensais;
            this.FlagAdesaoAutomatica = FlagAdesaoAutomatica;
            this.FlagDependente = FlagDependente;
            this.QuantidadeDependente = QuantidadeDependente;
            this.IdTermoSeguroServico = IdTermoSeguroServico;
            this.IdadeMinima = IdadeMinima;
            this.IdadeMaxima = IdadeMaxima;
            this.FlagDebitoIncondicional = FlagDebitoIncondicional;
            this.FlagExtratoIncondicional = FlagExtratoIncondicional;
            this.FlagEstornoAutomatico = FlagEstornoAutomatico;
            this.ValorRepassadoSeguradora = ValorRepassadoSeguradora;
            this.FlagLancaTransacao = FlagLancaTransacao;
            this.FlagTransferenciaAutomatica = FlagTransferenciaAutomatica;
            this.IdProduto = IdProduto;
            this.IdGrupoDebitoRecorrente = IdGrupoDebitoRecorrente;
            this.QuantidadeTentativasCobranca = QuantidadeTentativasCobranca;
            this.IdAjuste = IdAjuste;
            
        }
        
    
        /// <summary>
        /// Gets or Sets FlagAnuidadeBonificada
        /// </summary>
        [DataMember(Name="flagAnuidadeBonificada", EmitDefaultValue=false)]
        public bool? FlagAnuidadeBonificada { get; set; }
    
        /// <summary>
        /// Identification Code of the recurrent debit type (id)
        /// </summary>
        /// <value>Identification Code of the recurrent debit type (id)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Description of the recurrent debit type
        /// </summary>
        /// <value>Description of the recurrent debit type</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// Value of the recurrent debit type
        /// </summary>
        /// <value>Value of the recurrent debit type</value>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }
    
        /// <summary>
        /// Flag that identifies if the type of recurrent debit is active
        /// </summary>
        /// <value>Flag that identifies if the type of recurrent debit is active</value>
        [DataMember(Name="flagAtivo", EmitDefaultValue=false)]
        public bool? FlagAtivo { get; set; }
    
        /// <summary>
        /// Bonus value referring to the plan
        /// </summary>
        /// <value>Bonus value referring to the plan</value>
        [DataMember(Name="valorBonus", EmitDefaultValue=false)]
        public double? ValorBonus { get; set; }
    
        /// <summary>
        /// Parcel Number referring to the plan
        /// </summary>
        /// <value>Parcel Number referring to the plan</value>
        [DataMember(Name="numeroParcelas", EmitDefaultValue=false)]
        public int? NumeroParcelas { get; set; }
    
        /// <summary>
        /// Flag that indicates if the renovation is going to be automatic
        /// </summary>
        /// <value>Flag that indicates if the renovation is going to be automatic</value>
        [DataMember(Name="flagAdereAutomatico", EmitDefaultValue=false)]
        public bool? FlagAdereAutomatico { get; set; }
    
        /// <summary>
        /// Flag that indicates if the renewal is going to be automatic
        /// </summary>
        /// <value>Flag that indicates if the renewal is going to be automatic</value>
        [DataMember(Name="flagGeraNumeroSorte", EmitDefaultValue=false)]
        public bool? FlagGeraNumeroSorte { get; set; }
    
        /// <summary>
        /// Indicates the age range to join to the plan
        /// </summary>
        /// <value>Indicates the age range to join to the plan</value>
        [DataMember(Name="faixaEtaria", EmitDefaultValue=false)]
        public string FaixaEtaria { get; set; }
    
        /// <summary>
        /// Flag indicates if the plan is safe
        /// </summary>
        /// <value>Flag indicates if the plan is safe</value>
        [DataMember(Name="flagSeguro", EmitDefaultValue=false)]
        public bool? FlagSeguro { get; set; }
    
        /// <summary>
        /// Indicates which award referring to the month
        /// </summary>
        /// <value>Indicates which award referring to the month</value>
        [DataMember(Name="sorteiosMensais", EmitDefaultValue=false)]
        public string SorteiosMensais { get; set; }
    
        /// <summary>
        /// Flag that indicates if the accession of the plan will be automatic
        /// </summary>
        /// <value>Flag that indicates if the accession of the plan will be automatic</value>
        [DataMember(Name="flagAdesaoAutomatica", EmitDefaultValue=false)]
        public bool? FlagAdesaoAutomatica { get; set; }
    
        /// <summary>
        /// Flag indicate if the plan covers the dependent
        /// </summary>
        /// <value>Flag indicate if the plan covers the dependent</value>
        [DataMember(Name="flagDependente", EmitDefaultValue=false)]
        public bool? FlagDependente { get; set; }
    
        /// <summary>
        /// Indicate dependent numbers
        /// </summary>
        /// <value>Indicate dependent numbers</value>
        [DataMember(Name="quantidadeDependente", EmitDefaultValue=false)]
        public int? QuantidadeDependente { get; set; }
    
        /// <summary>
        /// Identification Code of the security service term (id)
        /// </summary>
        /// <value>Identification Code of the security service term (id)</value>
        [DataMember(Name="idTermoSeguroServico", EmitDefaultValue=false)]
        public long? IdTermoSeguroServico { get; set; }
    
        /// <summary>
        /// Minimum age to join to the plan
        /// </summary>
        /// <value>Minimum age to join to the plan</value>
        [DataMember(Name="idadeMinima", EmitDefaultValue=false)]
        public int? IdadeMinima { get; set; }
    
        /// <summary>
        /// Maximum age to join to the plan
        /// </summary>
        /// <value>Maximum age to join to the plan</value>
        [DataMember(Name="idadeMaxima", EmitDefaultValue=false)]
        public int? IdadeMaxima { get; set; }
    
        /// <summary>
        /// Flag indicates if the plan will have an unconditional debit
        /// </summary>
        /// <value>Flag indicates if the plan will have an unconditional debit</value>
        [DataMember(Name="flagDebitoIncondicional", EmitDefaultValue=false)]
        public bool? FlagDebitoIncondicional { get; set; }
    
        /// <summary>
        /// Flag that indicates if the plan will be unconditional extract
        /// </summary>
        /// <value>Flag that indicates if the plan will be unconditional extract</value>
        [DataMember(Name="flagExtratoIncondicional", EmitDefaultValue=false)]
        public bool? FlagExtratoIncondicional { get; set; }
    
        /// <summary>
        /// Flag indicates if the plan will have any automatic reversal
        /// </summary>
        /// <value>Flag indicates if the plan will have any automatic reversal</value>
        [DataMember(Name="flagEstornoAutomatico", EmitDefaultValue=false)]
        public bool? FlagEstornoAutomatico { get; set; }
    
        /// <summary>
        /// Value passed to the insurer
        /// </summary>
        /// <value>Value passed to the insurer</value>
        [DataMember(Name="valorRepassadoSeguradora", EmitDefaultValue=false)]
        public double? ValorRepassadoSeguradora { get; set; }
    
        /// <summary>
        /// Flag that indicates if it is going to launched a transaction
        /// </summary>
        /// <value>Flag that indicates if it is going to launched a transaction</value>
        [DataMember(Name="flagLancaTransacao", EmitDefaultValue=false)]
        public bool? FlagLancaTransacao { get; set; }
    
        /// <summary>
        /// Flag that indicates if it is going to be made an automatic transfer
        /// </summary>
        /// <value>Flag that indicates if it is going to be made an automatic transfer</value>
        [DataMember(Name="flagTransferenciaAutomatica", EmitDefaultValue=false)]
        public bool? FlagTransferenciaAutomatica { get; set; }
    
        /// <summary>
        /// Identification Code of the products (id)
        /// </summary>
        /// <value>Identification Code of the products (id)</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// Identification Code of the recurrent debit group (id)
        /// </summary>
        /// <value>Identification Code of the recurrent debit group (id)</value>
        [DataMember(Name="idGrupoDebitoRecorrente", EmitDefaultValue=false)]
        public long? IdGrupoDebitoRecorrente { get; set; }
    
        /// <summary>
        /// Attempt Quantities for the collection
        /// </summary>
        /// <value>Attempt Quantities for the collection</value>
        [DataMember(Name="quantidadeTentativasCobranca", EmitDefaultValue=false)]
        public int? QuantidadeTentativasCobranca { get; set; }
    
        /// <summary>
        /// Identification Code of the adjustment types (id)
        /// </summary>
        /// <value>Identification Code of the adjustment types (id)</value>
        [DataMember(Name="idAjuste", EmitDefaultValue=false)]
        public long? IdAjuste { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoDebitoRecorrenteResponse {\n");
            sb.Append("  FlagAnuidadeBonificada: ").Append(FlagAnuidadeBonificada).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  FlagAtivo: ").Append(FlagAtivo).Append("\n");
            sb.Append("  ValorBonus: ").Append(ValorBonus).Append("\n");
            sb.Append("  NumeroParcelas: ").Append(NumeroParcelas).Append("\n");
            sb.Append("  FlagAdereAutomatico: ").Append(FlagAdereAutomatico).Append("\n");
            sb.Append("  FlagGeraNumeroSorte: ").Append(FlagGeraNumeroSorte).Append("\n");
            sb.Append("  FaixaEtaria: ").Append(FaixaEtaria).Append("\n");
            sb.Append("  FlagSeguro: ").Append(FlagSeguro).Append("\n");
            sb.Append("  SorteiosMensais: ").Append(SorteiosMensais).Append("\n");
            sb.Append("  FlagAdesaoAutomatica: ").Append(FlagAdesaoAutomatica).Append("\n");
            sb.Append("  FlagDependente: ").Append(FlagDependente).Append("\n");
            sb.Append("  QuantidadeDependente: ").Append(QuantidadeDependente).Append("\n");
            sb.Append("  IdTermoSeguroServico: ").Append(IdTermoSeguroServico).Append("\n");
            sb.Append("  IdadeMinima: ").Append(IdadeMinima).Append("\n");
            sb.Append("  IdadeMaxima: ").Append(IdadeMaxima).Append("\n");
            sb.Append("  FlagDebitoIncondicional: ").Append(FlagDebitoIncondicional).Append("\n");
            sb.Append("  FlagExtratoIncondicional: ").Append(FlagExtratoIncondicional).Append("\n");
            sb.Append("  FlagEstornoAutomatico: ").Append(FlagEstornoAutomatico).Append("\n");
            sb.Append("  ValorRepassadoSeguradora: ").Append(ValorRepassadoSeguradora).Append("\n");
            sb.Append("  FlagLancaTransacao: ").Append(FlagLancaTransacao).Append("\n");
            sb.Append("  FlagTransferenciaAutomatica: ").Append(FlagTransferenciaAutomatica).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  IdGrupoDebitoRecorrente: ").Append(IdGrupoDebitoRecorrente).Append("\n");
            sb.Append("  QuantidadeTentativasCobranca: ").Append(QuantidadeTentativasCobranca).Append("\n");
            sb.Append("  IdAjuste: ").Append(IdAjuste).Append("\n");
            
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
            return this.Equals(obj as TipoDebitoRecorrenteResponse);
        }

        /// <summary>
        /// Returns true if TipoDebitoRecorrenteResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TipoDebitoRecorrenteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoDebitoRecorrenteResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FlagAnuidadeBonificada == other.FlagAnuidadeBonificada ||
                    this.FlagAnuidadeBonificada != null &&
                    this.FlagAnuidadeBonificada.Equals(other.FlagAnuidadeBonificada)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.Valor == other.Valor ||
                    this.Valor != null &&
                    this.Valor.Equals(other.Valor)
                ) && 
                (
                    this.FlagAtivo == other.FlagAtivo ||
                    this.FlagAtivo != null &&
                    this.FlagAtivo.Equals(other.FlagAtivo)
                ) && 
                (
                    this.ValorBonus == other.ValorBonus ||
                    this.ValorBonus != null &&
                    this.ValorBonus.Equals(other.ValorBonus)
                ) && 
                (
                    this.NumeroParcelas == other.NumeroParcelas ||
                    this.NumeroParcelas != null &&
                    this.NumeroParcelas.Equals(other.NumeroParcelas)
                ) && 
                (
                    this.FlagAdereAutomatico == other.FlagAdereAutomatico ||
                    this.FlagAdereAutomatico != null &&
                    this.FlagAdereAutomatico.Equals(other.FlagAdereAutomatico)
                ) && 
                (
                    this.FlagGeraNumeroSorte == other.FlagGeraNumeroSorte ||
                    this.FlagGeraNumeroSorte != null &&
                    this.FlagGeraNumeroSorte.Equals(other.FlagGeraNumeroSorte)
                ) && 
                (
                    this.FaixaEtaria == other.FaixaEtaria ||
                    this.FaixaEtaria != null &&
                    this.FaixaEtaria.Equals(other.FaixaEtaria)
                ) && 
                (
                    this.FlagSeguro == other.FlagSeguro ||
                    this.FlagSeguro != null &&
                    this.FlagSeguro.Equals(other.FlagSeguro)
                ) && 
                (
                    this.SorteiosMensais == other.SorteiosMensais ||
                    this.SorteiosMensais != null &&
                    this.SorteiosMensais.Equals(other.SorteiosMensais)
                ) && 
                (
                    this.FlagAdesaoAutomatica == other.FlagAdesaoAutomatica ||
                    this.FlagAdesaoAutomatica != null &&
                    this.FlagAdesaoAutomatica.Equals(other.FlagAdesaoAutomatica)
                ) && 
                (
                    this.FlagDependente == other.FlagDependente ||
                    this.FlagDependente != null &&
                    this.FlagDependente.Equals(other.FlagDependente)
                ) && 
                (
                    this.QuantidadeDependente == other.QuantidadeDependente ||
                    this.QuantidadeDependente != null &&
                    this.QuantidadeDependente.Equals(other.QuantidadeDependente)
                ) && 
                (
                    this.IdTermoSeguroServico == other.IdTermoSeguroServico ||
                    this.IdTermoSeguroServico != null &&
                    this.IdTermoSeguroServico.Equals(other.IdTermoSeguroServico)
                ) && 
                (
                    this.IdadeMinima == other.IdadeMinima ||
                    this.IdadeMinima != null &&
                    this.IdadeMinima.Equals(other.IdadeMinima)
                ) && 
                (
                    this.IdadeMaxima == other.IdadeMaxima ||
                    this.IdadeMaxima != null &&
                    this.IdadeMaxima.Equals(other.IdadeMaxima)
                ) && 
                (
                    this.FlagDebitoIncondicional == other.FlagDebitoIncondicional ||
                    this.FlagDebitoIncondicional != null &&
                    this.FlagDebitoIncondicional.Equals(other.FlagDebitoIncondicional)
                ) && 
                (
                    this.FlagExtratoIncondicional == other.FlagExtratoIncondicional ||
                    this.FlagExtratoIncondicional != null &&
                    this.FlagExtratoIncondicional.Equals(other.FlagExtratoIncondicional)
                ) && 
                (
                    this.FlagEstornoAutomatico == other.FlagEstornoAutomatico ||
                    this.FlagEstornoAutomatico != null &&
                    this.FlagEstornoAutomatico.Equals(other.FlagEstornoAutomatico)
                ) && 
                (
                    this.ValorRepassadoSeguradora == other.ValorRepassadoSeguradora ||
                    this.ValorRepassadoSeguradora != null &&
                    this.ValorRepassadoSeguradora.Equals(other.ValorRepassadoSeguradora)
                ) && 
                (
                    this.FlagLancaTransacao == other.FlagLancaTransacao ||
                    this.FlagLancaTransacao != null &&
                    this.FlagLancaTransacao.Equals(other.FlagLancaTransacao)
                ) && 
                (
                    this.FlagTransferenciaAutomatica == other.FlagTransferenciaAutomatica ||
                    this.FlagTransferenciaAutomatica != null &&
                    this.FlagTransferenciaAutomatica.Equals(other.FlagTransferenciaAutomatica)
                ) && 
                (
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.IdGrupoDebitoRecorrente == other.IdGrupoDebitoRecorrente ||
                    this.IdGrupoDebitoRecorrente != null &&
                    this.IdGrupoDebitoRecorrente.Equals(other.IdGrupoDebitoRecorrente)
                ) && 
                (
                    this.QuantidadeTentativasCobranca == other.QuantidadeTentativasCobranca ||
                    this.QuantidadeTentativasCobranca != null &&
                    this.QuantidadeTentativasCobranca.Equals(other.QuantidadeTentativasCobranca)
                ) && 
                (
                    this.IdAjuste == other.IdAjuste ||
                    this.IdAjuste != null &&
                    this.IdAjuste.Equals(other.IdAjuste)
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
                
                if (this.FlagAnuidadeBonificada != null)
                    hash = hash * 59 + this.FlagAnuidadeBonificada.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
                if (this.FlagAtivo != null)
                    hash = hash * 59 + this.FlagAtivo.GetHashCode();
                
                if (this.ValorBonus != null)
                    hash = hash * 59 + this.ValorBonus.GetHashCode();
                
                if (this.NumeroParcelas != null)
                    hash = hash * 59 + this.NumeroParcelas.GetHashCode();
                
                if (this.FlagAdereAutomatico != null)
                    hash = hash * 59 + this.FlagAdereAutomatico.GetHashCode();
                
                if (this.FlagGeraNumeroSorte != null)
                    hash = hash * 59 + this.FlagGeraNumeroSorte.GetHashCode();
                
                if (this.FaixaEtaria != null)
                    hash = hash * 59 + this.FaixaEtaria.GetHashCode();
                
                if (this.FlagSeguro != null)
                    hash = hash * 59 + this.FlagSeguro.GetHashCode();
                
                if (this.SorteiosMensais != null)
                    hash = hash * 59 + this.SorteiosMensais.GetHashCode();
                
                if (this.FlagAdesaoAutomatica != null)
                    hash = hash * 59 + this.FlagAdesaoAutomatica.GetHashCode();
                
                if (this.FlagDependente != null)
                    hash = hash * 59 + this.FlagDependente.GetHashCode();
                
                if (this.QuantidadeDependente != null)
                    hash = hash * 59 + this.QuantidadeDependente.GetHashCode();
                
                if (this.IdTermoSeguroServico != null)
                    hash = hash * 59 + this.IdTermoSeguroServico.GetHashCode();
                
                if (this.IdadeMinima != null)
                    hash = hash * 59 + this.IdadeMinima.GetHashCode();
                
                if (this.IdadeMaxima != null)
                    hash = hash * 59 + this.IdadeMaxima.GetHashCode();
                
                if (this.FlagDebitoIncondicional != null)
                    hash = hash * 59 + this.FlagDebitoIncondicional.GetHashCode();
                
                if (this.FlagExtratoIncondicional != null)
                    hash = hash * 59 + this.FlagExtratoIncondicional.GetHashCode();
                
                if (this.FlagEstornoAutomatico != null)
                    hash = hash * 59 + this.FlagEstornoAutomatico.GetHashCode();
                
                if (this.ValorRepassadoSeguradora != null)
                    hash = hash * 59 + this.ValorRepassadoSeguradora.GetHashCode();
                
                if (this.FlagLancaTransacao != null)
                    hash = hash * 59 + this.FlagLancaTransacao.GetHashCode();
                
                if (this.FlagTransferenciaAutomatica != null)
                    hash = hash * 59 + this.FlagTransferenciaAutomatica.GetHashCode();
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.IdGrupoDebitoRecorrente != null)
                    hash = hash * 59 + this.IdGrupoDebitoRecorrente.GetHashCode();
                
                if (this.QuantidadeTentativasCobranca != null)
                    hash = hash * 59 + this.QuantidadeTentativasCobranca.GetHashCode();
                
                if (this.IdAjuste != null)
                    hash = hash * 59 + this.IdAjuste.GetHashCode();
                
                return hash;
            }
        }

    }
}
