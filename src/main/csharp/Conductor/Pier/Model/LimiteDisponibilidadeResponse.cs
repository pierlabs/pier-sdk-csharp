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
    /// Limite Disponibilidade
    /// </summary>
    [DataContract]
    public partial class LimiteDisponibilidadeResponse :  IEquatable<LimiteDisponibilidadeResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LimiteDisponibilidadeResponse" /> class.
        /// Initializes a new instance of the <see cref="LimiteDisponibilidadeResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o de Limite e Disponibilidade (id)..</param>
        /// <param name="LimiteGlobal">Valor do limite de cr\u00C3\u00A9dito..</param>
        /// <param name="LimiteCompra">Valor do limite de cr\u00C3\u00A9dito para uso exclusivo em compras nacionais..</param>
        /// <param name="LimiteParcelado">Valor do limite de cr\u00C3\u00A9dito para transa\u00C3\u00A7\u00C3\u00B5es de compras parceladas..</param>
        /// <param name="LimiteParcelas">Valor do limite de cr\u00C3\u00A9dito acumulado da soma das parcelas das compras que forem realizadas nesta modalidade..</param>
        /// <param name="LimiteSaqueGlobal">Valor do limite de cr\u00C3\u00A9dito para transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional..</param>
        /// <param name="LimiteSaquePeriodo">Valor do limite de cr\u00C3\u00A9dito para transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional dentro de cada ciclo de faturamento..</param>
        /// <param name="LimiteConsignado">Valor da margem de cr\u00C3\u00A9dito para consigna\u00C3\u00A7\u00C3\u00B5es (desconto em folha)..</param>
        /// <param name="LimiteInternacionalCompra">Valor do limite de cr\u00C3\u00A9dito para uso exclusivo em compras internacionais..</param>
        /// <param name="LimiteInternacionalParcelado">Valor do limite de cr\u00C3\u00A9dito para transa\u00C3\u00A7\u00C3\u00B5es internacionais de compras parceladas..</param>
        /// <param name="LimiteInternacionalParcelas">Valor do limite de cr\u00C3\u00A9dito acumulado da soma das parcelas das compras internacionais que forem realizadas nesta modalidade..</param>
        /// <param name="LimiteInternacionalSaqueGlobal">Valor do limite de cr\u00C3\u00A9dito para transa\u00C3\u00A7\u00C3\u00B5es de saque internacional..</param>
        /// <param name="LimiteInternacionalSaquePeriodo">Valor do limite de cr\u00C3\u00A9dito para transa\u00C3\u00A7\u00C3\u00B5es de saque internacional dentro de cada ciclo de faturamento..</param>
        /// <param name="LimiteMaximo">Valor m\u00C3\u00A1ximo do limite de cr\u00C3\u00A9dito para realizar transa\u00C3\u00A7\u00C3\u00B5es..</param>
        /// <param name="SaldoDisponivelGlobal">Valor de cr\u00C3\u00A9dito dispon\u00C3\u00ADvel para transa\u00C3\u00A7\u00C3\u00B5es..</param>
        /// <param name="SaldoDisponivelCompra">Valor de cr\u00C3\u00A9dito dispon\u00C3\u00ADvel para transa\u00C3\u00A7\u00C3\u00B5es de compra nacional..</param>
        /// <param name="SaldoDisponivelParcelado">Valor de cr\u00C3\u00A9dito dispon\u00C3\u00ADvel para transa\u00C3\u00A7\u00C3\u00B5es de compra nacional parcelada..</param>
        /// <param name="SaldoDisponivelParcelas">Valor de cr\u00C3\u00A9dito dispon\u00C3\u00ADvel para utilizar como valor de parcelas Nacionais em um determinado ciclo de faturamento..</param>
        /// <param name="SaldoDisponivelSaque">Valor de cr\u00C3\u00A9dito que o portador possui dispon\u00C3\u00ADvel para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional..</param>
        /// <param name="SaldoPontosFidelidade">Saldo atual de pontos do programa de fidelidade..</param>
        /// <param name="SaldoDisponivelCompraInternacional">Valor de cr\u00C3\u00A9dito dispon\u00C3\u00ADvel para transa\u00C3\u00A7\u00C3\u00B5es de compra internacional..</param>
        /// <param name="SaldoDisponivelSaqueInternacional">Valor de cr\u00C3\u00A9dito dispon\u00C3\u00ADvel para transa\u00C3\u00A7\u00C3\u00B5es de saque internacional..</param>

        public LimiteDisponibilidadeResponse(long? Id = null, double? LimiteGlobal = null, double? LimiteCompra = null, double? LimiteParcelado = null, double? LimiteParcelas = null, double? LimiteSaqueGlobal = null, double? LimiteSaquePeriodo = null, double? LimiteConsignado = null, double? LimiteInternacionalCompra = null, double? LimiteInternacionalParcelado = null, double? LimiteInternacionalParcelas = null, double? LimiteInternacionalSaqueGlobal = null, double? LimiteInternacionalSaquePeriodo = null, double? LimiteMaximo = null, double? SaldoDisponivelGlobal = null, double? SaldoDisponivelCompra = null, double? SaldoDisponivelParcelado = null, double? SaldoDisponivelParcelas = null, double? SaldoDisponivelSaque = null, double? SaldoPontosFidelidade = null, double? SaldoDisponivelCompraInternacional = null, double? SaldoDisponivelSaqueInternacional = null)
        {
            this.Id = Id;
            this.LimiteGlobal = LimiteGlobal;
            this.LimiteCompra = LimiteCompra;
            this.LimiteParcelado = LimiteParcelado;
            this.LimiteParcelas = LimiteParcelas;
            this.LimiteSaqueGlobal = LimiteSaqueGlobal;
            this.LimiteSaquePeriodo = LimiteSaquePeriodo;
            this.LimiteConsignado = LimiteConsignado;
            this.LimiteInternacionalCompra = LimiteInternacionalCompra;
            this.LimiteInternacionalParcelado = LimiteInternacionalParcelado;
            this.LimiteInternacionalParcelas = LimiteInternacionalParcelas;
            this.LimiteInternacionalSaqueGlobal = LimiteInternacionalSaqueGlobal;
            this.LimiteInternacionalSaquePeriodo = LimiteInternacionalSaquePeriodo;
            this.LimiteMaximo = LimiteMaximo;
            this.SaldoDisponivelGlobal = SaldoDisponivelGlobal;
            this.SaldoDisponivelCompra = SaldoDisponivelCompra;
            this.SaldoDisponivelParcelado = SaldoDisponivelParcelado;
            this.SaldoDisponivelParcelas = SaldoDisponivelParcelas;
            this.SaldoDisponivelSaque = SaldoDisponivelSaque;
            this.SaldoPontosFidelidade = SaldoPontosFidelidade;
            this.SaldoDisponivelCompraInternacional = SaldoDisponivelCompraInternacional;
            this.SaldoDisponivelSaqueInternacional = SaldoDisponivelSaqueInternacional;
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o de Limite e Disponibilidade (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o de Limite e Disponibilidade (id).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Valor do limite de cr\u00C3\u00A9dito.
        /// </summary>
        /// <value>Valor do limite de cr\u00C3\u00A9dito.</value>
        [DataMember(Name="limiteGlobal", EmitDefaultValue=false)]
        public double? LimiteGlobal { get; set; }
    
        /// <summary>
        /// Valor do limite de cr\u00C3\u00A9dito para uso exclusivo em compras nacionais.
        /// </summary>
        /// <value>Valor do limite de cr\u00C3\u00A9dito para uso exclusivo em compras nacionais.</value>
        [DataMember(Name="limiteCompra", EmitDefaultValue=false)]
        public double? LimiteCompra { get; set; }
    
        /// <summary>
        /// Valor do limite de cr\u00C3\u00A9dito para transa\u00C3\u00A7\u00C3\u00B5es de compras parceladas.
        /// </summary>
        /// <value>Valor do limite de cr\u00C3\u00A9dito para transa\u00C3\u00A7\u00C3\u00B5es de compras parceladas.</value>
        [DataMember(Name="limiteParcelado", EmitDefaultValue=false)]
        public double? LimiteParcelado { get; set; }
    
        /// <summary>
        /// Valor do limite de cr\u00C3\u00A9dito acumulado da soma das parcelas das compras que forem realizadas nesta modalidade.
        /// </summary>
        /// <value>Valor do limite de cr\u00C3\u00A9dito acumulado da soma das parcelas das compras que forem realizadas nesta modalidade.</value>
        [DataMember(Name="limiteParcelas", EmitDefaultValue=false)]
        public double? LimiteParcelas { get; set; }
    
        /// <summary>
        /// Valor do limite de cr\u00C3\u00A9dito para transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional.
        /// </summary>
        /// <value>Valor do limite de cr\u00C3\u00A9dito para transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional.</value>
        [DataMember(Name="limiteSaqueGlobal", EmitDefaultValue=false)]
        public double? LimiteSaqueGlobal { get; set; }
    
        /// <summary>
        /// Valor do limite de cr\u00C3\u00A9dito para transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional dentro de cada ciclo de faturamento.
        /// </summary>
        /// <value>Valor do limite de cr\u00C3\u00A9dito para transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional dentro de cada ciclo de faturamento.</value>
        [DataMember(Name="limiteSaquePeriodo", EmitDefaultValue=false)]
        public double? LimiteSaquePeriodo { get; set; }
    
        /// <summary>
        /// Valor da margem de cr\u00C3\u00A9dito para consigna\u00C3\u00A7\u00C3\u00B5es (desconto em folha).
        /// </summary>
        /// <value>Valor da margem de cr\u00C3\u00A9dito para consigna\u00C3\u00A7\u00C3\u00B5es (desconto em folha).</value>
        [DataMember(Name="limiteConsignado", EmitDefaultValue=false)]
        public double? LimiteConsignado { get; set; }
    
        /// <summary>
        /// Valor do limite de cr\u00C3\u00A9dito para uso exclusivo em compras internacionais.
        /// </summary>
        /// <value>Valor do limite de cr\u00C3\u00A9dito para uso exclusivo em compras internacionais.</value>
        [DataMember(Name="limiteInternacionalCompra", EmitDefaultValue=false)]
        public double? LimiteInternacionalCompra { get; set; }
    
        /// <summary>
        /// Valor do limite de cr\u00C3\u00A9dito para transa\u00C3\u00A7\u00C3\u00B5es internacionais de compras parceladas.
        /// </summary>
        /// <value>Valor do limite de cr\u00C3\u00A9dito para transa\u00C3\u00A7\u00C3\u00B5es internacionais de compras parceladas.</value>
        [DataMember(Name="limiteInternacionalParcelado", EmitDefaultValue=false)]
        public double? LimiteInternacionalParcelado { get; set; }
    
        /// <summary>
        /// Valor do limite de cr\u00C3\u00A9dito acumulado da soma das parcelas das compras internacionais que forem realizadas nesta modalidade.
        /// </summary>
        /// <value>Valor do limite de cr\u00C3\u00A9dito acumulado da soma das parcelas das compras internacionais que forem realizadas nesta modalidade.</value>
        [DataMember(Name="limiteInternacionalParcelas", EmitDefaultValue=false)]
        public double? LimiteInternacionalParcelas { get; set; }
    
        /// <summary>
        /// Valor do limite de cr\u00C3\u00A9dito para transa\u00C3\u00A7\u00C3\u00B5es de saque internacional.
        /// </summary>
        /// <value>Valor do limite de cr\u00C3\u00A9dito para transa\u00C3\u00A7\u00C3\u00B5es de saque internacional.</value>
        [DataMember(Name="limiteInternacionalSaqueGlobal", EmitDefaultValue=false)]
        public double? LimiteInternacionalSaqueGlobal { get; set; }
    
        /// <summary>
        /// Valor do limite de cr\u00C3\u00A9dito para transa\u00C3\u00A7\u00C3\u00B5es de saque internacional dentro de cada ciclo de faturamento.
        /// </summary>
        /// <value>Valor do limite de cr\u00C3\u00A9dito para transa\u00C3\u00A7\u00C3\u00B5es de saque internacional dentro de cada ciclo de faturamento.</value>
        [DataMember(Name="limiteInternacionalSaquePeriodo", EmitDefaultValue=false)]
        public double? LimiteInternacionalSaquePeriodo { get; set; }
    
        /// <summary>
        /// Valor m\u00C3\u00A1ximo do limite de cr\u00C3\u00A9dito para realizar transa\u00C3\u00A7\u00C3\u00B5es.
        /// </summary>
        /// <value>Valor m\u00C3\u00A1ximo do limite de cr\u00C3\u00A9dito para realizar transa\u00C3\u00A7\u00C3\u00B5es.</value>
        [DataMember(Name="limiteMaximo", EmitDefaultValue=false)]
        public double? LimiteMaximo { get; set; }
    
        /// <summary>
        /// Valor de cr\u00C3\u00A9dito dispon\u00C3\u00ADvel para transa\u00C3\u00A7\u00C3\u00B5es.
        /// </summary>
        /// <value>Valor de cr\u00C3\u00A9dito dispon\u00C3\u00ADvel para transa\u00C3\u00A7\u00C3\u00B5es.</value>
        [DataMember(Name="saldoDisponivelGlobal", EmitDefaultValue=false)]
        public double? SaldoDisponivelGlobal { get; set; }
    
        /// <summary>
        /// Valor de cr\u00C3\u00A9dito dispon\u00C3\u00ADvel para transa\u00C3\u00A7\u00C3\u00B5es de compra nacional.
        /// </summary>
        /// <value>Valor de cr\u00C3\u00A9dito dispon\u00C3\u00ADvel para transa\u00C3\u00A7\u00C3\u00B5es de compra nacional.</value>
        [DataMember(Name="saldoDisponivelCompra", EmitDefaultValue=false)]
        public double? SaldoDisponivelCompra { get; set; }
    
        /// <summary>
        /// Valor de cr\u00C3\u00A9dito dispon\u00C3\u00ADvel para transa\u00C3\u00A7\u00C3\u00B5es de compra nacional parcelada.
        /// </summary>
        /// <value>Valor de cr\u00C3\u00A9dito dispon\u00C3\u00ADvel para transa\u00C3\u00A7\u00C3\u00B5es de compra nacional parcelada.</value>
        [DataMember(Name="saldoDisponivelParcelado", EmitDefaultValue=false)]
        public double? SaldoDisponivelParcelado { get; set; }
    
        /// <summary>
        /// Valor de cr\u00C3\u00A9dito dispon\u00C3\u00ADvel para utilizar como valor de parcelas Nacionais em um determinado ciclo de faturamento.
        /// </summary>
        /// <value>Valor de cr\u00C3\u00A9dito dispon\u00C3\u00ADvel para utilizar como valor de parcelas Nacionais em um determinado ciclo de faturamento.</value>
        [DataMember(Name="saldoDisponivelParcelas", EmitDefaultValue=false)]
        public double? SaldoDisponivelParcelas { get; set; }
    
        /// <summary>
        /// Valor de cr\u00C3\u00A9dito que o portador possui dispon\u00C3\u00ADvel para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional.
        /// </summary>
        /// <value>Valor de cr\u00C3\u00A9dito que o portador possui dispon\u00C3\u00ADvel para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional.</value>
        [DataMember(Name="saldoDisponivelSaque", EmitDefaultValue=false)]
        public double? SaldoDisponivelSaque { get; set; }
    
        /// <summary>
        /// Saldo atual de pontos do programa de fidelidade.
        /// </summary>
        /// <value>Saldo atual de pontos do programa de fidelidade.</value>
        [DataMember(Name="saldoPontosFidelidade", EmitDefaultValue=false)]
        public double? SaldoPontosFidelidade { get; set; }
    
        /// <summary>
        /// Valor de cr\u00C3\u00A9dito dispon\u00C3\u00ADvel para transa\u00C3\u00A7\u00C3\u00B5es de compra internacional.
        /// </summary>
        /// <value>Valor de cr\u00C3\u00A9dito dispon\u00C3\u00ADvel para transa\u00C3\u00A7\u00C3\u00B5es de compra internacional.</value>
        [DataMember(Name="saldoDisponivelCompraInternacional", EmitDefaultValue=false)]
        public double? SaldoDisponivelCompraInternacional { get; set; }
    
        /// <summary>
        /// Valor de cr\u00C3\u00A9dito dispon\u00C3\u00ADvel para transa\u00C3\u00A7\u00C3\u00B5es de saque internacional.
        /// </summary>
        /// <value>Valor de cr\u00C3\u00A9dito dispon\u00C3\u00ADvel para transa\u00C3\u00A7\u00C3\u00B5es de saque internacional.</value>
        [DataMember(Name="saldoDisponivelSaqueInternacional", EmitDefaultValue=false)]
        public double? SaldoDisponivelSaqueInternacional { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LimiteDisponibilidadeResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LimiteGlobal: ").Append(LimiteGlobal).Append("\n");
            sb.Append("  LimiteCompra: ").Append(LimiteCompra).Append("\n");
            sb.Append("  LimiteParcelado: ").Append(LimiteParcelado).Append("\n");
            sb.Append("  LimiteParcelas: ").Append(LimiteParcelas).Append("\n");
            sb.Append("  LimiteSaqueGlobal: ").Append(LimiteSaqueGlobal).Append("\n");
            sb.Append("  LimiteSaquePeriodo: ").Append(LimiteSaquePeriodo).Append("\n");
            sb.Append("  LimiteConsignado: ").Append(LimiteConsignado).Append("\n");
            sb.Append("  LimiteInternacionalCompra: ").Append(LimiteInternacionalCompra).Append("\n");
            sb.Append("  LimiteInternacionalParcelado: ").Append(LimiteInternacionalParcelado).Append("\n");
            sb.Append("  LimiteInternacionalParcelas: ").Append(LimiteInternacionalParcelas).Append("\n");
            sb.Append("  LimiteInternacionalSaqueGlobal: ").Append(LimiteInternacionalSaqueGlobal).Append("\n");
            sb.Append("  LimiteInternacionalSaquePeriodo: ").Append(LimiteInternacionalSaquePeriodo).Append("\n");
            sb.Append("  LimiteMaximo: ").Append(LimiteMaximo).Append("\n");
            sb.Append("  SaldoDisponivelGlobal: ").Append(SaldoDisponivelGlobal).Append("\n");
            sb.Append("  SaldoDisponivelCompra: ").Append(SaldoDisponivelCompra).Append("\n");
            sb.Append("  SaldoDisponivelParcelado: ").Append(SaldoDisponivelParcelado).Append("\n");
            sb.Append("  SaldoDisponivelParcelas: ").Append(SaldoDisponivelParcelas).Append("\n");
            sb.Append("  SaldoDisponivelSaque: ").Append(SaldoDisponivelSaque).Append("\n");
            sb.Append("  SaldoPontosFidelidade: ").Append(SaldoPontosFidelidade).Append("\n");
            sb.Append("  SaldoDisponivelCompraInternacional: ").Append(SaldoDisponivelCompraInternacional).Append("\n");
            sb.Append("  SaldoDisponivelSaqueInternacional: ").Append(SaldoDisponivelSaqueInternacional).Append("\n");
            
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
            return this.Equals(obj as LimiteDisponibilidadeResponse);
        }

        /// <summary>
        /// Returns true if LimiteDisponibilidadeResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of LimiteDisponibilidadeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LimiteDisponibilidadeResponse other)
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
                    this.LimiteGlobal == other.LimiteGlobal ||
                    this.LimiteGlobal != null &&
                    this.LimiteGlobal.Equals(other.LimiteGlobal)
                ) && 
                (
                    this.LimiteCompra == other.LimiteCompra ||
                    this.LimiteCompra != null &&
                    this.LimiteCompra.Equals(other.LimiteCompra)
                ) && 
                (
                    this.LimiteParcelado == other.LimiteParcelado ||
                    this.LimiteParcelado != null &&
                    this.LimiteParcelado.Equals(other.LimiteParcelado)
                ) && 
                (
                    this.LimiteParcelas == other.LimiteParcelas ||
                    this.LimiteParcelas != null &&
                    this.LimiteParcelas.Equals(other.LimiteParcelas)
                ) && 
                (
                    this.LimiteSaqueGlobal == other.LimiteSaqueGlobal ||
                    this.LimiteSaqueGlobal != null &&
                    this.LimiteSaqueGlobal.Equals(other.LimiteSaqueGlobal)
                ) && 
                (
                    this.LimiteSaquePeriodo == other.LimiteSaquePeriodo ||
                    this.LimiteSaquePeriodo != null &&
                    this.LimiteSaquePeriodo.Equals(other.LimiteSaquePeriodo)
                ) && 
                (
                    this.LimiteConsignado == other.LimiteConsignado ||
                    this.LimiteConsignado != null &&
                    this.LimiteConsignado.Equals(other.LimiteConsignado)
                ) && 
                (
                    this.LimiteInternacionalCompra == other.LimiteInternacionalCompra ||
                    this.LimiteInternacionalCompra != null &&
                    this.LimiteInternacionalCompra.Equals(other.LimiteInternacionalCompra)
                ) && 
                (
                    this.LimiteInternacionalParcelado == other.LimiteInternacionalParcelado ||
                    this.LimiteInternacionalParcelado != null &&
                    this.LimiteInternacionalParcelado.Equals(other.LimiteInternacionalParcelado)
                ) && 
                (
                    this.LimiteInternacionalParcelas == other.LimiteInternacionalParcelas ||
                    this.LimiteInternacionalParcelas != null &&
                    this.LimiteInternacionalParcelas.Equals(other.LimiteInternacionalParcelas)
                ) && 
                (
                    this.LimiteInternacionalSaqueGlobal == other.LimiteInternacionalSaqueGlobal ||
                    this.LimiteInternacionalSaqueGlobal != null &&
                    this.LimiteInternacionalSaqueGlobal.Equals(other.LimiteInternacionalSaqueGlobal)
                ) && 
                (
                    this.LimiteInternacionalSaquePeriodo == other.LimiteInternacionalSaquePeriodo ||
                    this.LimiteInternacionalSaquePeriodo != null &&
                    this.LimiteInternacionalSaquePeriodo.Equals(other.LimiteInternacionalSaquePeriodo)
                ) && 
                (
                    this.LimiteMaximo == other.LimiteMaximo ||
                    this.LimiteMaximo != null &&
                    this.LimiteMaximo.Equals(other.LimiteMaximo)
                ) && 
                (
                    this.SaldoDisponivelGlobal == other.SaldoDisponivelGlobal ||
                    this.SaldoDisponivelGlobal != null &&
                    this.SaldoDisponivelGlobal.Equals(other.SaldoDisponivelGlobal)
                ) && 
                (
                    this.SaldoDisponivelCompra == other.SaldoDisponivelCompra ||
                    this.SaldoDisponivelCompra != null &&
                    this.SaldoDisponivelCompra.Equals(other.SaldoDisponivelCompra)
                ) && 
                (
                    this.SaldoDisponivelParcelado == other.SaldoDisponivelParcelado ||
                    this.SaldoDisponivelParcelado != null &&
                    this.SaldoDisponivelParcelado.Equals(other.SaldoDisponivelParcelado)
                ) && 
                (
                    this.SaldoDisponivelParcelas == other.SaldoDisponivelParcelas ||
                    this.SaldoDisponivelParcelas != null &&
                    this.SaldoDisponivelParcelas.Equals(other.SaldoDisponivelParcelas)
                ) && 
                (
                    this.SaldoDisponivelSaque == other.SaldoDisponivelSaque ||
                    this.SaldoDisponivelSaque != null &&
                    this.SaldoDisponivelSaque.Equals(other.SaldoDisponivelSaque)
                ) && 
                (
                    this.SaldoPontosFidelidade == other.SaldoPontosFidelidade ||
                    this.SaldoPontosFidelidade != null &&
                    this.SaldoPontosFidelidade.Equals(other.SaldoPontosFidelidade)
                ) && 
                (
                    this.SaldoDisponivelCompraInternacional == other.SaldoDisponivelCompraInternacional ||
                    this.SaldoDisponivelCompraInternacional != null &&
                    this.SaldoDisponivelCompraInternacional.Equals(other.SaldoDisponivelCompraInternacional)
                ) && 
                (
                    this.SaldoDisponivelSaqueInternacional == other.SaldoDisponivelSaqueInternacional ||
                    this.SaldoDisponivelSaqueInternacional != null &&
                    this.SaldoDisponivelSaqueInternacional.Equals(other.SaldoDisponivelSaqueInternacional)
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
                
                if (this.LimiteGlobal != null)
                    hash = hash * 59 + this.LimiteGlobal.GetHashCode();
                
                if (this.LimiteCompra != null)
                    hash = hash * 59 + this.LimiteCompra.GetHashCode();
                
                if (this.LimiteParcelado != null)
                    hash = hash * 59 + this.LimiteParcelado.GetHashCode();
                
                if (this.LimiteParcelas != null)
                    hash = hash * 59 + this.LimiteParcelas.GetHashCode();
                
                if (this.LimiteSaqueGlobal != null)
                    hash = hash * 59 + this.LimiteSaqueGlobal.GetHashCode();
                
                if (this.LimiteSaquePeriodo != null)
                    hash = hash * 59 + this.LimiteSaquePeriodo.GetHashCode();
                
                if (this.LimiteConsignado != null)
                    hash = hash * 59 + this.LimiteConsignado.GetHashCode();
                
                if (this.LimiteInternacionalCompra != null)
                    hash = hash * 59 + this.LimiteInternacionalCompra.GetHashCode();
                
                if (this.LimiteInternacionalParcelado != null)
                    hash = hash * 59 + this.LimiteInternacionalParcelado.GetHashCode();
                
                if (this.LimiteInternacionalParcelas != null)
                    hash = hash * 59 + this.LimiteInternacionalParcelas.GetHashCode();
                
                if (this.LimiteInternacionalSaqueGlobal != null)
                    hash = hash * 59 + this.LimiteInternacionalSaqueGlobal.GetHashCode();
                
                if (this.LimiteInternacionalSaquePeriodo != null)
                    hash = hash * 59 + this.LimiteInternacionalSaquePeriodo.GetHashCode();
                
                if (this.LimiteMaximo != null)
                    hash = hash * 59 + this.LimiteMaximo.GetHashCode();
                
                if (this.SaldoDisponivelGlobal != null)
                    hash = hash * 59 + this.SaldoDisponivelGlobal.GetHashCode();
                
                if (this.SaldoDisponivelCompra != null)
                    hash = hash * 59 + this.SaldoDisponivelCompra.GetHashCode();
                
                if (this.SaldoDisponivelParcelado != null)
                    hash = hash * 59 + this.SaldoDisponivelParcelado.GetHashCode();
                
                if (this.SaldoDisponivelParcelas != null)
                    hash = hash * 59 + this.SaldoDisponivelParcelas.GetHashCode();
                
                if (this.SaldoDisponivelSaque != null)
                    hash = hash * 59 + this.SaldoDisponivelSaque.GetHashCode();
                
                if (this.SaldoPontosFidelidade != null)
                    hash = hash * 59 + this.SaldoPontosFidelidade.GetHashCode();
                
                if (this.SaldoDisponivelCompraInternacional != null)
                    hash = hash * 59 + this.SaldoDisponivelCompraInternacional.GetHashCode();
                
                if (this.SaldoDisponivelSaqueInternacional != null)
                    hash = hash * 59 + this.SaldoDisponivelSaqueInternacional.GetHashCode();
                
                return hash;
            }
        }

    }
}
