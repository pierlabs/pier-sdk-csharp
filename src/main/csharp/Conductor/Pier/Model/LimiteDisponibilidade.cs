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
    public partial class LimiteDisponibilidade :  IEquatable<LimiteDisponibilidade>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LimiteDisponibilidade" /> class.
        /// Initializes a new instance of the <see cref="LimiteDisponibilidade" />class.
        /// </summary>
        /// <param name="Id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o de Limite e Disponibilidade (id). (required).</param>
        /// <param name="LimiteCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para uso exclusivo em Compras Nacionais (required).</param>
        /// <param name="LimiteConsignado">Quando utilizado pelo emissor, este campo apresenta o valor da margem de cr\u00C3\u00A9dito que ele poder\u00C3\u00A1 utilizar para ser cobrado de forma consignada (desconto em folha) em seu sal\u00C3\u00A1rio/vencimentos. (required).</param>
        /// <param name="LimiteExterno">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para realizar transa\u00C3\u00A7\u00C3\u00B5es fora da rede pr\u00C3\u00B3pria do emissor, tamb\u00C3\u00A9m chamado de limite para transa\u00C3\u00A7\u00C3\u00B5es off-us. (required).</param>
        /// <param name="LimiteExtra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para utiliza\u00C3\u00A7\u00C3\u00A3o al\u00C3\u00A9m do valor do limiteGlobal.  (required).</param>
        /// <param name="LimiteGlobal">Apresenta o valor do limite de cr\u00C3\u00A9dito que o portador do cart\u00C3\u00A3o possui. (required).</param>
        /// <param name="LimiteInternacionalCompra">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para uso exclusivo em Compras Internacionais. (required).</param>
        /// <param name="LimiteInternacionalParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para realizar transa\u00C3\u00A7\u00C3\u00B5es Internacionais de Compras Parceladas. (required).</param>
        /// <param name="LimiteInternacionalParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que portador pode acumular a partir da soma das parcelas das compras internacionais que forem realizadas nesta modalidade. (required).</param>
        /// <param name="LimiteInternacionalSaqueGlobal">LimiteInternacionalSaqueGlobal (required).</param>
        /// <param name="LimiteInternacionalSaquePeriodo">LimiteInternacionalSaquePeriodo (required).</param>
        /// <param name="LimiteMensal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que a fatura do portador pode ter em um determinado per\u00C3\u00ADodo. (required).</param>
        /// <param name="LimiteParcelado">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para realizar transa\u00C3\u00A7\u00C3\u00B5es de compras parceladas. (required).</param>
        /// <param name="LimiteParcelas">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que portador pode acumular a partir da soma das parcelas das compras que forem realizadas nesta modalidade. (required).</param>
        /// <param name="LimiteSaqueGlobal">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional. (required).</param>
        /// <param name="LimiteSaquePeriodo">Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional dentro de cada ciclo de faturamento. (required).</param>
        /// <param name="SaldoDisponivelCompra">SaldoDisponivelCompra (required).</param>
        /// <param name="SaldoDisponivelCompraInternacional">SaldoDisponivelCompraInternacional (required).</param>
        /// <param name="SaldoDisponivelExterno">SaldoDisponivelExterno (required).</param>
        /// <param name="SaldoDisponivelExtra">SaldoDisponivelExtra (required).</param>
        /// <param name="SaldoDisponivelGlobal">Campo que  (required).</param>
        /// <param name="SaldoDisponivelMensal">SaldoDisponivelMensal (required).</param>
        /// <param name="SaldoDisponivelParcelado">SaldoDisponivelParcelado (required).</param>
        /// <param name="SaldoDisponivelParcelas">SaldoDisponivelParcelas (required).</param>
        /// <param name="SaldoDisponivelSaque">SaldoDisponivelSaque (required).</param>
        /// <param name="SaldoDisponivelSaqueInternacional">SaldoDisponivelSaqueInternacional (required).</param>
        /// <param name="SaldoPontosFidelidade">SaldoPontosFidelidade (required).</param>

        public LimiteDisponibilidade(long? Id = null, double? LimiteCompra = null, double? LimiteConsignado = null, double? LimiteExterno = null, double? LimiteExtra = null, double? LimiteGlobal = null, double? LimiteInternacionalCompra = null, double? LimiteInternacionalParcelado = null, double? LimiteInternacionalParcelas = null, double? LimiteInternacionalSaqueGlobal = null, double? LimiteInternacionalSaquePeriodo = null, double? LimiteMensal = null, double? LimiteParcelado = null, double? LimiteParcelas = null, double? LimiteSaqueGlobal = null, double? LimiteSaquePeriodo = null, double? SaldoDisponivelCompra = null, double? SaldoDisponivelCompraInternacional = null, double? SaldoDisponivelExterno = null, double? SaldoDisponivelExtra = null, double? SaldoDisponivelGlobal = null, double? SaldoDisponivelMensal = null, double? SaldoDisponivelParcelado = null, double? SaldoDisponivelParcelas = null, double? SaldoDisponivelSaque = null, double? SaldoDisponivelSaqueInternacional = null, double? SaldoPontosFidelidade = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for LimiteDisponibilidade and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "LimiteCompra" is required (not null)
            if (LimiteCompra == null)
            {
                throw new InvalidDataException("LimiteCompra is a required property for LimiteDisponibilidade and cannot be null");
            }
            else
            {
                this.LimiteCompra = LimiteCompra;
            }
            // to ensure "LimiteConsignado" is required (not null)
            if (LimiteConsignado == null)
            {
                throw new InvalidDataException("LimiteConsignado is a required property for LimiteDisponibilidade and cannot be null");
            }
            else
            {
                this.LimiteConsignado = LimiteConsignado;
            }
            // to ensure "LimiteExterno" is required (not null)
            if (LimiteExterno == null)
            {
                throw new InvalidDataException("LimiteExterno is a required property for LimiteDisponibilidade and cannot be null");
            }
            else
            {
                this.LimiteExterno = LimiteExterno;
            }
            // to ensure "LimiteExtra" is required (not null)
            if (LimiteExtra == null)
            {
                throw new InvalidDataException("LimiteExtra is a required property for LimiteDisponibilidade and cannot be null");
            }
            else
            {
                this.LimiteExtra = LimiteExtra;
            }
            // to ensure "LimiteGlobal" is required (not null)
            if (LimiteGlobal == null)
            {
                throw new InvalidDataException("LimiteGlobal is a required property for LimiteDisponibilidade and cannot be null");
            }
            else
            {
                this.LimiteGlobal = LimiteGlobal;
            }
            // to ensure "LimiteInternacionalCompra" is required (not null)
            if (LimiteInternacionalCompra == null)
            {
                throw new InvalidDataException("LimiteInternacionalCompra is a required property for LimiteDisponibilidade and cannot be null");
            }
            else
            {
                this.LimiteInternacionalCompra = LimiteInternacionalCompra;
            }
            // to ensure "LimiteInternacionalParcelado" is required (not null)
            if (LimiteInternacionalParcelado == null)
            {
                throw new InvalidDataException("LimiteInternacionalParcelado is a required property for LimiteDisponibilidade and cannot be null");
            }
            else
            {
                this.LimiteInternacionalParcelado = LimiteInternacionalParcelado;
            }
            // to ensure "LimiteInternacionalParcelas" is required (not null)
            if (LimiteInternacionalParcelas == null)
            {
                throw new InvalidDataException("LimiteInternacionalParcelas is a required property for LimiteDisponibilidade and cannot be null");
            }
            else
            {
                this.LimiteInternacionalParcelas = LimiteInternacionalParcelas;
            }
            // to ensure "LimiteInternacionalSaqueGlobal" is required (not null)
            if (LimiteInternacionalSaqueGlobal == null)
            {
                throw new InvalidDataException("LimiteInternacionalSaqueGlobal is a required property for LimiteDisponibilidade and cannot be null");
            }
            else
            {
                this.LimiteInternacionalSaqueGlobal = LimiteInternacionalSaqueGlobal;
            }
            // to ensure "LimiteInternacionalSaquePeriodo" is required (not null)
            if (LimiteInternacionalSaquePeriodo == null)
            {
                throw new InvalidDataException("LimiteInternacionalSaquePeriodo is a required property for LimiteDisponibilidade and cannot be null");
            }
            else
            {
                this.LimiteInternacionalSaquePeriodo = LimiteInternacionalSaquePeriodo;
            }
            // to ensure "LimiteMensal" is required (not null)
            if (LimiteMensal == null)
            {
                throw new InvalidDataException("LimiteMensal is a required property for LimiteDisponibilidade and cannot be null");
            }
            else
            {
                this.LimiteMensal = LimiteMensal;
            }
            // to ensure "LimiteParcelado" is required (not null)
            if (LimiteParcelado == null)
            {
                throw new InvalidDataException("LimiteParcelado is a required property for LimiteDisponibilidade and cannot be null");
            }
            else
            {
                this.LimiteParcelado = LimiteParcelado;
            }
            // to ensure "LimiteParcelas" is required (not null)
            if (LimiteParcelas == null)
            {
                throw new InvalidDataException("LimiteParcelas is a required property for LimiteDisponibilidade and cannot be null");
            }
            else
            {
                this.LimiteParcelas = LimiteParcelas;
            }
            // to ensure "LimiteSaqueGlobal" is required (not null)
            if (LimiteSaqueGlobal == null)
            {
                throw new InvalidDataException("LimiteSaqueGlobal is a required property for LimiteDisponibilidade and cannot be null");
            }
            else
            {
                this.LimiteSaqueGlobal = LimiteSaqueGlobal;
            }
            // to ensure "LimiteSaquePeriodo" is required (not null)
            if (LimiteSaquePeriodo == null)
            {
                throw new InvalidDataException("LimiteSaquePeriodo is a required property for LimiteDisponibilidade and cannot be null");
            }
            else
            {
                this.LimiteSaquePeriodo = LimiteSaquePeriodo;
            }
            // to ensure "SaldoDisponivelCompra" is required (not null)
            if (SaldoDisponivelCompra == null)
            {
                throw new InvalidDataException("SaldoDisponivelCompra is a required property for LimiteDisponibilidade and cannot be null");
            }
            else
            {
                this.SaldoDisponivelCompra = SaldoDisponivelCompra;
            }
            // to ensure "SaldoDisponivelCompraInternacional" is required (not null)
            if (SaldoDisponivelCompraInternacional == null)
            {
                throw new InvalidDataException("SaldoDisponivelCompraInternacional is a required property for LimiteDisponibilidade and cannot be null");
            }
            else
            {
                this.SaldoDisponivelCompraInternacional = SaldoDisponivelCompraInternacional;
            }
            // to ensure "SaldoDisponivelExterno" is required (not null)
            if (SaldoDisponivelExterno == null)
            {
                throw new InvalidDataException("SaldoDisponivelExterno is a required property for LimiteDisponibilidade and cannot be null");
            }
            else
            {
                this.SaldoDisponivelExterno = SaldoDisponivelExterno;
            }
            // to ensure "SaldoDisponivelExtra" is required (not null)
            if (SaldoDisponivelExtra == null)
            {
                throw new InvalidDataException("SaldoDisponivelExtra is a required property for LimiteDisponibilidade and cannot be null");
            }
            else
            {
                this.SaldoDisponivelExtra = SaldoDisponivelExtra;
            }
            // to ensure "SaldoDisponivelGlobal" is required (not null)
            if (SaldoDisponivelGlobal == null)
            {
                throw new InvalidDataException("SaldoDisponivelGlobal is a required property for LimiteDisponibilidade and cannot be null");
            }
            else
            {
                this.SaldoDisponivelGlobal = SaldoDisponivelGlobal;
            }
            // to ensure "SaldoDisponivelMensal" is required (not null)
            if (SaldoDisponivelMensal == null)
            {
                throw new InvalidDataException("SaldoDisponivelMensal is a required property for LimiteDisponibilidade and cannot be null");
            }
            else
            {
                this.SaldoDisponivelMensal = SaldoDisponivelMensal;
            }
            // to ensure "SaldoDisponivelParcelado" is required (not null)
            if (SaldoDisponivelParcelado == null)
            {
                throw new InvalidDataException("SaldoDisponivelParcelado is a required property for LimiteDisponibilidade and cannot be null");
            }
            else
            {
                this.SaldoDisponivelParcelado = SaldoDisponivelParcelado;
            }
            // to ensure "SaldoDisponivelParcelas" is required (not null)
            if (SaldoDisponivelParcelas == null)
            {
                throw new InvalidDataException("SaldoDisponivelParcelas is a required property for LimiteDisponibilidade and cannot be null");
            }
            else
            {
                this.SaldoDisponivelParcelas = SaldoDisponivelParcelas;
            }
            // to ensure "SaldoDisponivelSaque" is required (not null)
            if (SaldoDisponivelSaque == null)
            {
                throw new InvalidDataException("SaldoDisponivelSaque is a required property for LimiteDisponibilidade and cannot be null");
            }
            else
            {
                this.SaldoDisponivelSaque = SaldoDisponivelSaque;
            }
            // to ensure "SaldoDisponivelSaqueInternacional" is required (not null)
            if (SaldoDisponivelSaqueInternacional == null)
            {
                throw new InvalidDataException("SaldoDisponivelSaqueInternacional is a required property for LimiteDisponibilidade and cannot be null");
            }
            else
            {
                this.SaldoDisponivelSaqueInternacional = SaldoDisponivelSaqueInternacional;
            }
            // to ensure "SaldoPontosFidelidade" is required (not null)
            if (SaldoPontosFidelidade == null)
            {
                throw new InvalidDataException("SaldoPontosFidelidade is a required property for LimiteDisponibilidade and cannot be null");
            }
            else
            {
                this.SaldoPontosFidelidade = SaldoPontosFidelidade;
            }
            
        }
        
    
        /// <summary>
        /// C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o de Limite e Disponibilidade (id).
        /// </summary>
        /// <value>C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o de Limite e Disponibilidade (id).</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para uso exclusivo em Compras Nacionais
        /// </summary>
        /// <value>Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para uso exclusivo em Compras Nacionais</value>
        [DataMember(Name="limiteCompra", EmitDefaultValue=false)]
        public double? LimiteCompra { get; set; }
    
        /// <summary>
        /// Quando utilizado pelo emissor, este campo apresenta o valor da margem de cr\u00C3\u00A9dito que ele poder\u00C3\u00A1 utilizar para ser cobrado de forma consignada (desconto em folha) em seu sal\u00C3\u00A1rio/vencimentos.
        /// </summary>
        /// <value>Quando utilizado pelo emissor, este campo apresenta o valor da margem de cr\u00C3\u00A9dito que ele poder\u00C3\u00A1 utilizar para ser cobrado de forma consignada (desconto em folha) em seu sal\u00C3\u00A1rio/vencimentos.</value>
        [DataMember(Name="limiteConsignado", EmitDefaultValue=false)]
        public double? LimiteConsignado { get; set; }
    
        /// <summary>
        /// Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para realizar transa\u00C3\u00A7\u00C3\u00B5es fora da rede pr\u00C3\u00B3pria do emissor, tamb\u00C3\u00A9m chamado de limite para transa\u00C3\u00A7\u00C3\u00B5es off-us.
        /// </summary>
        /// <value>Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para realizar transa\u00C3\u00A7\u00C3\u00B5es fora da rede pr\u00C3\u00B3pria do emissor, tamb\u00C3\u00A9m chamado de limite para transa\u00C3\u00A7\u00C3\u00B5es off-us.</value>
        [DataMember(Name="limiteExterno", EmitDefaultValue=false)]
        public double? LimiteExterno { get; set; }
    
        /// <summary>
        /// Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para utiliza\u00C3\u00A7\u00C3\u00A3o al\u00C3\u00A9m do valor do limiteGlobal. 
        /// </summary>
        /// <value>Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para utiliza\u00C3\u00A7\u00C3\u00A3o al\u00C3\u00A9m do valor do limiteGlobal. </value>
        [DataMember(Name="limiteExtra", EmitDefaultValue=false)]
        public double? LimiteExtra { get; set; }
    
        /// <summary>
        /// Apresenta o valor do limite de cr\u00C3\u00A9dito que o portador do cart\u00C3\u00A3o possui.
        /// </summary>
        /// <value>Apresenta o valor do limite de cr\u00C3\u00A9dito que o portador do cart\u00C3\u00A3o possui.</value>
        [DataMember(Name="limiteGlobal", EmitDefaultValue=false)]
        public double? LimiteGlobal { get; set; }
    
        /// <summary>
        /// Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para uso exclusivo em Compras Internacionais.
        /// </summary>
        /// <value>Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para uso exclusivo em Compras Internacionais.</value>
        [DataMember(Name="limiteInternacionalCompra", EmitDefaultValue=false)]
        public double? LimiteInternacionalCompra { get; set; }
    
        /// <summary>
        /// Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para realizar transa\u00C3\u00A7\u00C3\u00B5es Internacionais de Compras Parceladas.
        /// </summary>
        /// <value>Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para realizar transa\u00C3\u00A7\u00C3\u00B5es Internacionais de Compras Parceladas.</value>
        [DataMember(Name="limiteInternacionalParcelado", EmitDefaultValue=false)]
        public double? LimiteInternacionalParcelado { get; set; }
    
        /// <summary>
        /// Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que portador pode acumular a partir da soma das parcelas das compras internacionais que forem realizadas nesta modalidade.
        /// </summary>
        /// <value>Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que portador pode acumular a partir da soma das parcelas das compras internacionais que forem realizadas nesta modalidade.</value>
        [DataMember(Name="limiteInternacionalParcelas", EmitDefaultValue=false)]
        public double? LimiteInternacionalParcelas { get; set; }
    
        /// <summary>
        /// Gets or Sets LimiteInternacionalSaqueGlobal
        /// </summary>
        [DataMember(Name="limiteInternacionalSaqueGlobal", EmitDefaultValue=false)]
        public double? LimiteInternacionalSaqueGlobal { get; set; }
    
        /// <summary>
        /// Gets or Sets LimiteInternacionalSaquePeriodo
        /// </summary>
        [DataMember(Name="limiteInternacionalSaquePeriodo", EmitDefaultValue=false)]
        public double? LimiteInternacionalSaquePeriodo { get; set; }
    
        /// <summary>
        /// Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que a fatura do portador pode ter em um determinado per\u00C3\u00ADodo.
        /// </summary>
        /// <value>Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que a fatura do portador pode ter em um determinado per\u00C3\u00ADodo.</value>
        [DataMember(Name="limiteMensal", EmitDefaultValue=false)]
        public double? LimiteMensal { get; set; }
    
        /// <summary>
        /// Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para realizar transa\u00C3\u00A7\u00C3\u00B5es de compras parceladas.
        /// </summary>
        /// <value>Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador possui para realizar transa\u00C3\u00A7\u00C3\u00B5es de compras parceladas.</value>
        [DataMember(Name="limiteParcelado", EmitDefaultValue=false)]
        public double? LimiteParcelado { get; set; }
    
        /// <summary>
        /// Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que portador pode acumular a partir da soma das parcelas das compras que forem realizadas nesta modalidade.
        /// </summary>
        /// <value>Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que portador pode acumular a partir da soma das parcelas das compras que forem realizadas nesta modalidade.</value>
        [DataMember(Name="limiteParcelas", EmitDefaultValue=false)]
        public double? LimiteParcelas { get; set; }
    
        /// <summary>
        /// Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional.
        /// </summary>
        /// <value>Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional.</value>
        [DataMember(Name="limiteSaqueGlobal", EmitDefaultValue=false)]
        public double? LimiteSaqueGlobal { get; set; }
    
        /// <summary>
        /// Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional dentro de cada ciclo de faturamento.
        /// </summary>
        /// <value>Quando utilizado pelo emissor, este campo apresenta o valor do limite de cr\u00C3\u00A9dito que o portador pode utilizar para realizar transa\u00C3\u00A7\u00C3\u00B5es de Saque Nacional dentro de cada ciclo de faturamento.</value>
        [DataMember(Name="limiteSaquePeriodo", EmitDefaultValue=false)]
        public double? LimiteSaquePeriodo { get; set; }
    
        /// <summary>
        /// Gets or Sets SaldoDisponivelCompra
        /// </summary>
        [DataMember(Name="saldoDisponivelCompra", EmitDefaultValue=false)]
        public double? SaldoDisponivelCompra { get; set; }
    
        /// <summary>
        /// Gets or Sets SaldoDisponivelCompraInternacional
        /// </summary>
        [DataMember(Name="saldoDisponivelCompraInternacional", EmitDefaultValue=false)]
        public double? SaldoDisponivelCompraInternacional { get; set; }
    
        /// <summary>
        /// Gets or Sets SaldoDisponivelExterno
        /// </summary>
        [DataMember(Name="saldoDisponivelExterno", EmitDefaultValue=false)]
        public double? SaldoDisponivelExterno { get; set; }
    
        /// <summary>
        /// Gets or Sets SaldoDisponivelExtra
        /// </summary>
        [DataMember(Name="saldoDisponivelExtra", EmitDefaultValue=false)]
        public double? SaldoDisponivelExtra { get; set; }
    
        /// <summary>
        /// Campo que 
        /// </summary>
        /// <value>Campo que </value>
        [DataMember(Name="saldoDisponivelGlobal", EmitDefaultValue=false)]
        public double? SaldoDisponivelGlobal { get; set; }
    
        /// <summary>
        /// Gets or Sets SaldoDisponivelMensal
        /// </summary>
        [DataMember(Name="saldoDisponivelMensal", EmitDefaultValue=false)]
        public double? SaldoDisponivelMensal { get; set; }
    
        /// <summary>
        /// Gets or Sets SaldoDisponivelParcelado
        /// </summary>
        [DataMember(Name="saldoDisponivelParcelado", EmitDefaultValue=false)]
        public double? SaldoDisponivelParcelado { get; set; }
    
        /// <summary>
        /// Gets or Sets SaldoDisponivelParcelas
        /// </summary>
        [DataMember(Name="saldoDisponivelParcelas", EmitDefaultValue=false)]
        public double? SaldoDisponivelParcelas { get; set; }
    
        /// <summary>
        /// Gets or Sets SaldoDisponivelSaque
        /// </summary>
        [DataMember(Name="saldoDisponivelSaque", EmitDefaultValue=false)]
        public double? SaldoDisponivelSaque { get; set; }
    
        /// <summary>
        /// Gets or Sets SaldoDisponivelSaqueInternacional
        /// </summary>
        [DataMember(Name="saldoDisponivelSaqueInternacional", EmitDefaultValue=false)]
        public double? SaldoDisponivelSaqueInternacional { get; set; }
    
        /// <summary>
        /// Gets or Sets SaldoPontosFidelidade
        /// </summary>
        [DataMember(Name="saldoPontosFidelidade", EmitDefaultValue=false)]
        public double? SaldoPontosFidelidade { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LimiteDisponibilidade {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LimiteCompra: ").Append(LimiteCompra).Append("\n");
            sb.Append("  LimiteConsignado: ").Append(LimiteConsignado).Append("\n");
            sb.Append("  LimiteExterno: ").Append(LimiteExterno).Append("\n");
            sb.Append("  LimiteExtra: ").Append(LimiteExtra).Append("\n");
            sb.Append("  LimiteGlobal: ").Append(LimiteGlobal).Append("\n");
            sb.Append("  LimiteInternacionalCompra: ").Append(LimiteInternacionalCompra).Append("\n");
            sb.Append("  LimiteInternacionalParcelado: ").Append(LimiteInternacionalParcelado).Append("\n");
            sb.Append("  LimiteInternacionalParcelas: ").Append(LimiteInternacionalParcelas).Append("\n");
            sb.Append("  LimiteInternacionalSaqueGlobal: ").Append(LimiteInternacionalSaqueGlobal).Append("\n");
            sb.Append("  LimiteInternacionalSaquePeriodo: ").Append(LimiteInternacionalSaquePeriodo).Append("\n");
            sb.Append("  LimiteMensal: ").Append(LimiteMensal).Append("\n");
            sb.Append("  LimiteParcelado: ").Append(LimiteParcelado).Append("\n");
            sb.Append("  LimiteParcelas: ").Append(LimiteParcelas).Append("\n");
            sb.Append("  LimiteSaqueGlobal: ").Append(LimiteSaqueGlobal).Append("\n");
            sb.Append("  LimiteSaquePeriodo: ").Append(LimiteSaquePeriodo).Append("\n");
            sb.Append("  SaldoDisponivelCompra: ").Append(SaldoDisponivelCompra).Append("\n");
            sb.Append("  SaldoDisponivelCompraInternacional: ").Append(SaldoDisponivelCompraInternacional).Append("\n");
            sb.Append("  SaldoDisponivelExterno: ").Append(SaldoDisponivelExterno).Append("\n");
            sb.Append("  SaldoDisponivelExtra: ").Append(SaldoDisponivelExtra).Append("\n");
            sb.Append("  SaldoDisponivelGlobal: ").Append(SaldoDisponivelGlobal).Append("\n");
            sb.Append("  SaldoDisponivelMensal: ").Append(SaldoDisponivelMensal).Append("\n");
            sb.Append("  SaldoDisponivelParcelado: ").Append(SaldoDisponivelParcelado).Append("\n");
            sb.Append("  SaldoDisponivelParcelas: ").Append(SaldoDisponivelParcelas).Append("\n");
            sb.Append("  SaldoDisponivelSaque: ").Append(SaldoDisponivelSaque).Append("\n");
            sb.Append("  SaldoDisponivelSaqueInternacional: ").Append(SaldoDisponivelSaqueInternacional).Append("\n");
            sb.Append("  SaldoPontosFidelidade: ").Append(SaldoPontosFidelidade).Append("\n");
            
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
            return this.Equals(obj as LimiteDisponibilidade);
        }

        /// <summary>
        /// Returns true if LimiteDisponibilidade instances are equal
        /// </summary>
        /// <param name="other">Instance of LimiteDisponibilidade to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LimiteDisponibilidade other)
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
                    this.LimiteCompra == other.LimiteCompra ||
                    this.LimiteCompra != null &&
                    this.LimiteCompra.Equals(other.LimiteCompra)
                ) && 
                (
                    this.LimiteConsignado == other.LimiteConsignado ||
                    this.LimiteConsignado != null &&
                    this.LimiteConsignado.Equals(other.LimiteConsignado)
                ) && 
                (
                    this.LimiteExterno == other.LimiteExterno ||
                    this.LimiteExterno != null &&
                    this.LimiteExterno.Equals(other.LimiteExterno)
                ) && 
                (
                    this.LimiteExtra == other.LimiteExtra ||
                    this.LimiteExtra != null &&
                    this.LimiteExtra.Equals(other.LimiteExtra)
                ) && 
                (
                    this.LimiteGlobal == other.LimiteGlobal ||
                    this.LimiteGlobal != null &&
                    this.LimiteGlobal.Equals(other.LimiteGlobal)
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
                    this.LimiteMensal == other.LimiteMensal ||
                    this.LimiteMensal != null &&
                    this.LimiteMensal.Equals(other.LimiteMensal)
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
                    this.SaldoDisponivelCompra == other.SaldoDisponivelCompra ||
                    this.SaldoDisponivelCompra != null &&
                    this.SaldoDisponivelCompra.Equals(other.SaldoDisponivelCompra)
                ) && 
                (
                    this.SaldoDisponivelCompraInternacional == other.SaldoDisponivelCompraInternacional ||
                    this.SaldoDisponivelCompraInternacional != null &&
                    this.SaldoDisponivelCompraInternacional.Equals(other.SaldoDisponivelCompraInternacional)
                ) && 
                (
                    this.SaldoDisponivelExterno == other.SaldoDisponivelExterno ||
                    this.SaldoDisponivelExterno != null &&
                    this.SaldoDisponivelExterno.Equals(other.SaldoDisponivelExterno)
                ) && 
                (
                    this.SaldoDisponivelExtra == other.SaldoDisponivelExtra ||
                    this.SaldoDisponivelExtra != null &&
                    this.SaldoDisponivelExtra.Equals(other.SaldoDisponivelExtra)
                ) && 
                (
                    this.SaldoDisponivelGlobal == other.SaldoDisponivelGlobal ||
                    this.SaldoDisponivelGlobal != null &&
                    this.SaldoDisponivelGlobal.Equals(other.SaldoDisponivelGlobal)
                ) && 
                (
                    this.SaldoDisponivelMensal == other.SaldoDisponivelMensal ||
                    this.SaldoDisponivelMensal != null &&
                    this.SaldoDisponivelMensal.Equals(other.SaldoDisponivelMensal)
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
                    this.SaldoDisponivelSaqueInternacional == other.SaldoDisponivelSaqueInternacional ||
                    this.SaldoDisponivelSaqueInternacional != null &&
                    this.SaldoDisponivelSaqueInternacional.Equals(other.SaldoDisponivelSaqueInternacional)
                ) && 
                (
                    this.SaldoPontosFidelidade == other.SaldoPontosFidelidade ||
                    this.SaldoPontosFidelidade != null &&
                    this.SaldoPontosFidelidade.Equals(other.SaldoPontosFidelidade)
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
                
                if (this.LimiteCompra != null)
                    hash = hash * 59 + this.LimiteCompra.GetHashCode();
                
                if (this.LimiteConsignado != null)
                    hash = hash * 59 + this.LimiteConsignado.GetHashCode();
                
                if (this.LimiteExterno != null)
                    hash = hash * 59 + this.LimiteExterno.GetHashCode();
                
                if (this.LimiteExtra != null)
                    hash = hash * 59 + this.LimiteExtra.GetHashCode();
                
                if (this.LimiteGlobal != null)
                    hash = hash * 59 + this.LimiteGlobal.GetHashCode();
                
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
                
                if (this.LimiteMensal != null)
                    hash = hash * 59 + this.LimiteMensal.GetHashCode();
                
                if (this.LimiteParcelado != null)
                    hash = hash * 59 + this.LimiteParcelado.GetHashCode();
                
                if (this.LimiteParcelas != null)
                    hash = hash * 59 + this.LimiteParcelas.GetHashCode();
                
                if (this.LimiteSaqueGlobal != null)
                    hash = hash * 59 + this.LimiteSaqueGlobal.GetHashCode();
                
                if (this.LimiteSaquePeriodo != null)
                    hash = hash * 59 + this.LimiteSaquePeriodo.GetHashCode();
                
                if (this.SaldoDisponivelCompra != null)
                    hash = hash * 59 + this.SaldoDisponivelCompra.GetHashCode();
                
                if (this.SaldoDisponivelCompraInternacional != null)
                    hash = hash * 59 + this.SaldoDisponivelCompraInternacional.GetHashCode();
                
                if (this.SaldoDisponivelExterno != null)
                    hash = hash * 59 + this.SaldoDisponivelExterno.GetHashCode();
                
                if (this.SaldoDisponivelExtra != null)
                    hash = hash * 59 + this.SaldoDisponivelExtra.GetHashCode();
                
                if (this.SaldoDisponivelGlobal != null)
                    hash = hash * 59 + this.SaldoDisponivelGlobal.GetHashCode();
                
                if (this.SaldoDisponivelMensal != null)
                    hash = hash * 59 + this.SaldoDisponivelMensal.GetHashCode();
                
                if (this.SaldoDisponivelParcelado != null)
                    hash = hash * 59 + this.SaldoDisponivelParcelado.GetHashCode();
                
                if (this.SaldoDisponivelParcelas != null)
                    hash = hash * 59 + this.SaldoDisponivelParcelas.GetHashCode();
                
                if (this.SaldoDisponivelSaque != null)
                    hash = hash * 59 + this.SaldoDisponivelSaque.GetHashCode();
                
                if (this.SaldoDisponivelSaqueInternacional != null)
                    hash = hash * 59 + this.SaldoDisponivelSaqueInternacional.GetHashCode();
                
                if (this.SaldoPontosFidelidade != null)
                    hash = hash * 59 + this.SaldoPontosFidelidade.GetHashCode();
                
                return hash;
            }
        }

    }
}
