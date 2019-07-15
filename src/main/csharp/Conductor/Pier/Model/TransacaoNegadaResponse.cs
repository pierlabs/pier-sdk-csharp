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
    /// Objeto que representa o response das transa\u00E7\u00F5es negadas
    /// </summary>
    [DataContract]
    public partial class TransacaoNegadaResponse :  IEquatable<TransacaoNegadaResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransacaoNegadaResponse" /> class.
        /// Initializes a new instance of the <see cref="TransacaoNegadaResponse" />class.
        /// </summary>
        /// <param name="Id">C\u00F3digo identificador da mensagem.</param>
        /// <param name="IdProduto">C\u00F3digo identificador do produto.</param>
        /// <param name="IdCartao">C\u00F3digo identificador do cart\u00E3o.</param>
        /// <param name="NumeroCartao">N\u00FAmero do cart\u00E3o mascarado.</param>
        /// <param name="CodigoProcessamento">C\u00F3digo de processamento.</param>
        /// <param name="CodigoProcessamentoDescricao">Descri\u00E7\u00E3o do c\u00F3digo de processamento.</param>
        /// <param name="Valor">Valor da transa\u00E7\u00E3o.</param>
        /// <param name="Parcelas">Quantidade de parcelas para parcelamento.</param>
        /// <param name="NomeEstabelecimento">Nome do estabelecimento onde ocorreu a transa\u00E7\u00E3o.</param>
        /// <param name="DataHoraEntrada">Data e hora em que a transa\u00E7\u00E3o entrou no autorizador.</param>
        /// <param name="DataHoraSaida">Data e hora em que a transa\u00E7\u00E3o saiu do autorizador.</param>
        /// <param name="CodigoResposta">C\u00F3digo da mensagem de resposta.</param>
        /// <param name="RespostaAutorizador">Mensagem de resposta do autorizador.</param>
        /// <param name="IdDescricao">C\u00F3digo da mensagem de transa\u00E7\u00E3o.</param>
        /// <param name="DescricaoAplicativo">Mensagem de transa\u00E7\u00E3o do Aplicativo.</param>
        /// <param name="DescricaoTerminal">Mensagem de transa\u00E7\u00E3o do Terminal.</param>

        public TransacaoNegadaResponse(long? Id = null, long? IdProduto = null, long? IdCartao = null, string NumeroCartao = null, string CodigoProcessamento = null, string CodigoProcessamentoDescricao = null, double? Valor = null, int? Parcelas = null, string NomeEstabelecimento = null, string DataHoraEntrada = null, string DataHoraSaida = null, string CodigoResposta = null, string RespostaAutorizador = null, long? IdDescricao = null, string DescricaoAplicativo = null, string DescricaoTerminal = null)
        {
            this.Id = Id;
            this.IdProduto = IdProduto;
            this.IdCartao = IdCartao;
            this.NumeroCartao = NumeroCartao;
            this.CodigoProcessamento = CodigoProcessamento;
            this.CodigoProcessamentoDescricao = CodigoProcessamentoDescricao;
            this.Valor = Valor;
            this.Parcelas = Parcelas;
            this.NomeEstabelecimento = NomeEstabelecimento;
            this.DataHoraEntrada = DataHoraEntrada;
            this.DataHoraSaida = DataHoraSaida;
            this.CodigoResposta = CodigoResposta;
            this.RespostaAutorizador = RespostaAutorizador;
            this.IdDescricao = IdDescricao;
            this.DescricaoAplicativo = DescricaoAplicativo;
            this.DescricaoTerminal = DescricaoTerminal;
            
        }
        
    
        /// <summary>
        /// C\u00F3digo identificador da mensagem
        /// </summary>
        /// <value>C\u00F3digo identificador da mensagem</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador do produto
        /// </summary>
        /// <value>C\u00F3digo identificador do produto</value>
        [DataMember(Name="idProduto", EmitDefaultValue=false)]
        public long? IdProduto { get; set; }
    
        /// <summary>
        /// C\u00F3digo identificador do cart\u00E3o
        /// </summary>
        /// <value>C\u00F3digo identificador do cart\u00E3o</value>
        [DataMember(Name="idCartao", EmitDefaultValue=false)]
        public long? IdCartao { get; set; }
    
        /// <summary>
        /// N\u00FAmero do cart\u00E3o mascarado
        /// </summary>
        /// <value>N\u00FAmero do cart\u00E3o mascarado</value>
        [DataMember(Name="numeroCartao", EmitDefaultValue=false)]
        public string NumeroCartao { get; set; }
    
        /// <summary>
        /// C\u00F3digo de processamento
        /// </summary>
        /// <value>C\u00F3digo de processamento</value>
        [DataMember(Name="codigoProcessamento", EmitDefaultValue=false)]
        public string CodigoProcessamento { get; set; }
    
        /// <summary>
        /// Descri\u00E7\u00E3o do c\u00F3digo de processamento
        /// </summary>
        /// <value>Descri\u00E7\u00E3o do c\u00F3digo de processamento</value>
        [DataMember(Name="codigoProcessamentoDescricao", EmitDefaultValue=false)]
        public string CodigoProcessamentoDescricao { get; set; }
    
        /// <summary>
        /// Valor da transa\u00E7\u00E3o
        /// </summary>
        /// <value>Valor da transa\u00E7\u00E3o</value>
        [DataMember(Name="valor", EmitDefaultValue=false)]
        public double? Valor { get; set; }
    
        /// <summary>
        /// Quantidade de parcelas para parcelamento
        /// </summary>
        /// <value>Quantidade de parcelas para parcelamento</value>
        [DataMember(Name="parcelas", EmitDefaultValue=false)]
        public int? Parcelas { get; set; }
    
        /// <summary>
        /// Nome do estabelecimento onde ocorreu a transa\u00E7\u00E3o
        /// </summary>
        /// <value>Nome do estabelecimento onde ocorreu a transa\u00E7\u00E3o</value>
        [DataMember(Name="nomeEstabelecimento", EmitDefaultValue=false)]
        public string NomeEstabelecimento { get; set; }
    
        /// <summary>
        /// Data e hora em que a transa\u00E7\u00E3o entrou no autorizador
        /// </summary>
        /// <value>Data e hora em que a transa\u00E7\u00E3o entrou no autorizador</value>
        [DataMember(Name="dataHoraEntrada", EmitDefaultValue=false)]
        public string DataHoraEntrada { get; set; }
    
        /// <summary>
        /// Data e hora em que a transa\u00E7\u00E3o saiu do autorizador
        /// </summary>
        /// <value>Data e hora em que a transa\u00E7\u00E3o saiu do autorizador</value>
        [DataMember(Name="dataHoraSaida", EmitDefaultValue=false)]
        public string DataHoraSaida { get; set; }
    
        /// <summary>
        /// C\u00F3digo da mensagem de resposta
        /// </summary>
        /// <value>C\u00F3digo da mensagem de resposta</value>
        [DataMember(Name="codigoResposta", EmitDefaultValue=false)]
        public string CodigoResposta { get; set; }
    
        /// <summary>
        /// Mensagem de resposta do autorizador
        /// </summary>
        /// <value>Mensagem de resposta do autorizador</value>
        [DataMember(Name="respostaAutorizador", EmitDefaultValue=false)]
        public string RespostaAutorizador { get; set; }
    
        /// <summary>
        /// C\u00F3digo da mensagem de transa\u00E7\u00E3o
        /// </summary>
        /// <value>C\u00F3digo da mensagem de transa\u00E7\u00E3o</value>
        [DataMember(Name="idDescricao", EmitDefaultValue=false)]
        public long? IdDescricao { get; set; }
    
        /// <summary>
        /// Mensagem de transa\u00E7\u00E3o do Aplicativo
        /// </summary>
        /// <value>Mensagem de transa\u00E7\u00E3o do Aplicativo</value>
        [DataMember(Name="descricaoAplicativo", EmitDefaultValue=false)]
        public string DescricaoAplicativo { get; set; }
    
        /// <summary>
        /// Mensagem de transa\u00E7\u00E3o do Terminal
        /// </summary>
        /// <value>Mensagem de transa\u00E7\u00E3o do Terminal</value>
        [DataMember(Name="descricaoTerminal", EmitDefaultValue=false)]
        public string DescricaoTerminal { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransacaoNegadaResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdProduto: ").Append(IdProduto).Append("\n");
            sb.Append("  IdCartao: ").Append(IdCartao).Append("\n");
            sb.Append("  NumeroCartao: ").Append(NumeroCartao).Append("\n");
            sb.Append("  CodigoProcessamento: ").Append(CodigoProcessamento).Append("\n");
            sb.Append("  CodigoProcessamentoDescricao: ").Append(CodigoProcessamentoDescricao).Append("\n");
            sb.Append("  Valor: ").Append(Valor).Append("\n");
            sb.Append("  Parcelas: ").Append(Parcelas).Append("\n");
            sb.Append("  NomeEstabelecimento: ").Append(NomeEstabelecimento).Append("\n");
            sb.Append("  DataHoraEntrada: ").Append(DataHoraEntrada).Append("\n");
            sb.Append("  DataHoraSaida: ").Append(DataHoraSaida).Append("\n");
            sb.Append("  CodigoResposta: ").Append(CodigoResposta).Append("\n");
            sb.Append("  RespostaAutorizador: ").Append(RespostaAutorizador).Append("\n");
            sb.Append("  IdDescricao: ").Append(IdDescricao).Append("\n");
            sb.Append("  DescricaoAplicativo: ").Append(DescricaoAplicativo).Append("\n");
            sb.Append("  DescricaoTerminal: ").Append(DescricaoTerminal).Append("\n");
            
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
            return this.Equals(obj as TransacaoNegadaResponse);
        }

        /// <summary>
        /// Returns true if TransacaoNegadaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TransacaoNegadaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransacaoNegadaResponse other)
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
                    this.IdProduto == other.IdProduto ||
                    this.IdProduto != null &&
                    this.IdProduto.Equals(other.IdProduto)
                ) && 
                (
                    this.IdCartao == other.IdCartao ||
                    this.IdCartao != null &&
                    this.IdCartao.Equals(other.IdCartao)
                ) && 
                (
                    this.NumeroCartao == other.NumeroCartao ||
                    this.NumeroCartao != null &&
                    this.NumeroCartao.Equals(other.NumeroCartao)
                ) && 
                (
                    this.CodigoProcessamento == other.CodigoProcessamento ||
                    this.CodigoProcessamento != null &&
                    this.CodigoProcessamento.Equals(other.CodigoProcessamento)
                ) && 
                (
                    this.CodigoProcessamentoDescricao == other.CodigoProcessamentoDescricao ||
                    this.CodigoProcessamentoDescricao != null &&
                    this.CodigoProcessamentoDescricao.Equals(other.CodigoProcessamentoDescricao)
                ) && 
                (
                    this.Valor == other.Valor ||
                    this.Valor != null &&
                    this.Valor.Equals(other.Valor)
                ) && 
                (
                    this.Parcelas == other.Parcelas ||
                    this.Parcelas != null &&
                    this.Parcelas.Equals(other.Parcelas)
                ) && 
                (
                    this.NomeEstabelecimento == other.NomeEstabelecimento ||
                    this.NomeEstabelecimento != null &&
                    this.NomeEstabelecimento.Equals(other.NomeEstabelecimento)
                ) && 
                (
                    this.DataHoraEntrada == other.DataHoraEntrada ||
                    this.DataHoraEntrada != null &&
                    this.DataHoraEntrada.Equals(other.DataHoraEntrada)
                ) && 
                (
                    this.DataHoraSaida == other.DataHoraSaida ||
                    this.DataHoraSaida != null &&
                    this.DataHoraSaida.Equals(other.DataHoraSaida)
                ) && 
                (
                    this.CodigoResposta == other.CodigoResposta ||
                    this.CodigoResposta != null &&
                    this.CodigoResposta.Equals(other.CodigoResposta)
                ) && 
                (
                    this.RespostaAutorizador == other.RespostaAutorizador ||
                    this.RespostaAutorizador != null &&
                    this.RespostaAutorizador.Equals(other.RespostaAutorizador)
                ) && 
                (
                    this.IdDescricao == other.IdDescricao ||
                    this.IdDescricao != null &&
                    this.IdDescricao.Equals(other.IdDescricao)
                ) && 
                (
                    this.DescricaoAplicativo == other.DescricaoAplicativo ||
                    this.DescricaoAplicativo != null &&
                    this.DescricaoAplicativo.Equals(other.DescricaoAplicativo)
                ) && 
                (
                    this.DescricaoTerminal == other.DescricaoTerminal ||
                    this.DescricaoTerminal != null &&
                    this.DescricaoTerminal.Equals(other.DescricaoTerminal)
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
                
                if (this.IdProduto != null)
                    hash = hash * 59 + this.IdProduto.GetHashCode();
                
                if (this.IdCartao != null)
                    hash = hash * 59 + this.IdCartao.GetHashCode();
                
                if (this.NumeroCartao != null)
                    hash = hash * 59 + this.NumeroCartao.GetHashCode();
                
                if (this.CodigoProcessamento != null)
                    hash = hash * 59 + this.CodigoProcessamento.GetHashCode();
                
                if (this.CodigoProcessamentoDescricao != null)
                    hash = hash * 59 + this.CodigoProcessamentoDescricao.GetHashCode();
                
                if (this.Valor != null)
                    hash = hash * 59 + this.Valor.GetHashCode();
                
                if (this.Parcelas != null)
                    hash = hash * 59 + this.Parcelas.GetHashCode();
                
                if (this.NomeEstabelecimento != null)
                    hash = hash * 59 + this.NomeEstabelecimento.GetHashCode();
                
                if (this.DataHoraEntrada != null)
                    hash = hash * 59 + this.DataHoraEntrada.GetHashCode();
                
                if (this.DataHoraSaida != null)
                    hash = hash * 59 + this.DataHoraSaida.GetHashCode();
                
                if (this.CodigoResposta != null)
                    hash = hash * 59 + this.CodigoResposta.GetHashCode();
                
                if (this.RespostaAutorizador != null)
                    hash = hash * 59 + this.RespostaAutorizador.GetHashCode();
                
                if (this.IdDescricao != null)
                    hash = hash * 59 + this.IdDescricao.GetHashCode();
                
                if (this.DescricaoAplicativo != null)
                    hash = hash * 59 + this.DescricaoAplicativo.GetHashCode();
                
                if (this.DescricaoTerminal != null)
                    hash = hash * 59 + this.DescricaoTerminal.GetHashCode();
                
                return hash;
            }
        }

    }
}
