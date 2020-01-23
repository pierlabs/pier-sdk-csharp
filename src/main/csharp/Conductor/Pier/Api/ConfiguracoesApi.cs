using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Conductor.Pier.Client;
using Conductor.Pier.Model;

namespace Conductor.Pier.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConfiguracoesApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Atualizar um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite atualizar um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <param name="parametroAcumuladorUpdate">Objeto de atualiza\u00E7\u00E3o para um par\u00E2metro acumulador de conta/opera\u00E7\u00E3o</param>
        /// <returns>ParametroAcumuladorContaOperacaoResponse</returns>
        ParametroAcumuladorContaOperacaoResponse AtualizarParametroAcumuladorConta (long? idConta, long? idOperacao, ParametroAcumuladorContaOperacaoUpdate parametroAcumuladorUpdate);
  
        /// <summary>
        /// Atualizar um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite atualizar um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <param name="parametroAcumuladorUpdate">Objeto de atualiza\u00E7\u00E3o para um par\u00E2metro acumulador de conta/opera\u00E7\u00E3o</param>
        /// <returns>ApiResponse of ParametroAcumuladorContaOperacaoResponse</returns>
        ApiResponse<ParametroAcumuladorContaOperacaoResponse> AtualizarParametroAcumuladorContaWithHttpInfo (long? idConta, long? idOperacao, ParametroAcumuladorContaOperacaoUpdate parametroAcumuladorUpdate);
        
        /// <summary>
        /// Atualizar um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite atualizar um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <param name="parametroAcumuladorUpdate">Objeto de atualiza\u00E7\u00E3o para um par\u00E2metro acumulador de produto/opera\u00E7\u00E3o</param>
        /// <returns>ParametroAcumuladorProdutoOperacaoResponse</returns>
        ParametroAcumuladorProdutoOperacaoResponse AtualizarParametroAcumuladorProduto (long? idProduto, long? idOperacao, ParametroAcumuladorProdutoOperacaoUpdate parametroAcumuladorUpdate);
  
        /// <summary>
        /// Atualizar um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite atualizar um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <param name="parametroAcumuladorUpdate">Objeto de atualiza\u00E7\u00E3o para um par\u00E2metro acumulador de produto/opera\u00E7\u00E3o</param>
        /// <returns>ApiResponse of ParametroAcumuladorProdutoOperacaoResponse</returns>
        ApiResponse<ParametroAcumuladorProdutoOperacaoResponse> AtualizarParametroAcumuladorProdutoWithHttpInfo (long? idProduto, long? idOperacao, ParametroAcumuladorProdutoOperacaoUpdate parametroAcumuladorUpdate);
        
        /// <summary>
        /// Cadastrar um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <param name="parametroAcumuladorPersist">Objeto de cria\u00E7\u00E3o para um par\u00E2metro acumulador de conta/opera\u00E7\u00E3o</param>
        /// <returns>ParametroAcumuladorContaOperacaoResponse</returns>
        ParametroAcumuladorContaOperacaoResponse CadastrarParametroAcumuladorConta (long? idConta, long? idOperacao, ParametroAcumuladorContaOperacaoPersist parametroAcumuladorPersist);
  
        /// <summary>
        /// Cadastrar um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <param name="parametroAcumuladorPersist">Objeto de cria\u00E7\u00E3o para um par\u00E2metro acumulador de conta/opera\u00E7\u00E3o</param>
        /// <returns>ApiResponse of ParametroAcumuladorContaOperacaoResponse</returns>
        ApiResponse<ParametroAcumuladorContaOperacaoResponse> CadastrarParametroAcumuladorContaWithHttpInfo (long? idConta, long? idOperacao, ParametroAcumuladorContaOperacaoPersist parametroAcumuladorPersist);
        
        /// <summary>
        /// Cadastrar um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <param name="parametroAcumuladorPersist">Objeto de cria\u00E7\u00E3o para um par\u00E2metro acumulador de produto/opera\u00E7\u00E3o</param>
        /// <returns>ParametroAcumuladorProdutoOperacaoResponse</returns>
        ParametroAcumuladorProdutoOperacaoResponse CadastrarParametroAcumuladorProduto (long? idProduto, long? idOperacao, ParametroAcumuladorProdutoOperacaoPersist parametroAcumuladorPersist);
  
        /// <summary>
        /// Cadastrar um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <param name="parametroAcumuladorPersist">Objeto de cria\u00E7\u00E3o para um par\u00E2metro acumulador de produto/opera\u00E7\u00E3o</param>
        /// <returns>ApiResponse of ParametroAcumuladorProdutoOperacaoResponse</returns>
        ApiResponse<ParametroAcumuladorProdutoOperacaoResponse> CadastrarParametroAcumuladorProdutoWithHttpInfo (long? idProduto, long? idOperacao, ParametroAcumuladorProdutoOperacaoPersist parametroAcumuladorPersist);
        
        /// <summary>
        /// Consultar um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <returns>ParametroAcumuladorContaOperacaoResponse</returns>
        ParametroAcumuladorContaOperacaoResponse ConsultarParametroAcumuladorConta (long? idConta, long? idOperacao);
  
        /// <summary>
        /// Consultar um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <returns>ApiResponse of ParametroAcumuladorContaOperacaoResponse</returns>
        ApiResponse<ParametroAcumuladorContaOperacaoResponse> ConsultarParametroAcumuladorContaWithHttpInfo (long? idConta, long? idOperacao);
        
        /// <summary>
        /// Consultar um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <returns>ParametroAcumuladorProdutoOperacaoResponse</returns>
        ParametroAcumuladorProdutoOperacaoResponse ConsultarParametroAcumuladorProduto (long? idProduto, long? idOperacao);
  
        /// <summary>
        /// Consultar um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <returns>ApiResponse of ParametroAcumuladorProdutoOperacaoResponse</returns>
        ApiResponse<ParametroAcumuladorProdutoOperacaoResponse> ConsultarParametroAcumuladorProdutoWithHttpInfo (long? idProduto, long? idOperacao);
        
        /// <summary>
        /// Excluir um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite excluir um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <returns>Object</returns>
        Object ExcluirParametroAcumuladorConta (long? idConta, long? idOperacao);
  
        /// <summary>
        /// Excluir um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite excluir um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ExcluirParametroAcumuladorContaWithHttpInfo (long? idConta, long? idOperacao);
        
        /// <summary>
        /// Excluir um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite excluir um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <returns>Object</returns>
        Object ExcluirParametroAcumuladorProduto (long? idProduto, long? idOperacao);
  
        /// <summary>
        /// Excluir um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite excluir um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ExcluirParametroAcumuladorProdutoWithHttpInfo (long? idProduto, long? idOperacao);
        
        /// <summary>
        /// Listar par\u00E2metros acumuladores de contas e opera\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar par\u00E2metros acumuladores de contas e opera\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (optional)</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o (optional)</param>
        /// <param name="qtdOperacoesGratuitasDia">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por dia (optional)</param>
        /// <param name="qtdOperacoesGratuitasSemana">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por semana (optional)</param>
        /// <param name="qtdOperacoesGratuitasMes">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por m\u00EAs (optional)</param>
        /// <param name="valorTAC">Valor da taxa de abertura de cr\u00E9dito (TAC) (optional)</param>
        /// <returns>PageParametroAcumuladorContaOperacaoResponse</returns>
        PageParametroAcumuladorContaOperacaoResponse ListarParametrosAcumuladoresConta (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idOperacao = null, int? qtdOperacoesGratuitasDia = null, int? qtdOperacoesGratuitasSemana = null, int? qtdOperacoesGratuitasMes = null, double? valorTAC = null);
  
        /// <summary>
        /// Listar par\u00E2metros acumuladores de contas e opera\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar par\u00E2metros acumuladores de contas e opera\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (optional)</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o (optional)</param>
        /// <param name="qtdOperacoesGratuitasDia">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por dia (optional)</param>
        /// <param name="qtdOperacoesGratuitasSemana">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por semana (optional)</param>
        /// <param name="qtdOperacoesGratuitasMes">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por m\u00EAs (optional)</param>
        /// <param name="valorTAC">Valor da taxa de abertura de cr\u00E9dito (TAC) (optional)</param>
        /// <returns>ApiResponse of PageParametroAcumuladorContaOperacaoResponse</returns>
        ApiResponse<PageParametroAcumuladorContaOperacaoResponse> ListarParametrosAcumuladoresContaWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idOperacao = null, int? qtdOperacoesGratuitasDia = null, int? qtdOperacoesGratuitasSemana = null, int? qtdOperacoesGratuitasMes = null, double? valorTAC = null);
        
        /// <summary>
        /// Listar par\u00E2metros acumuladores de produtos e opera\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar par\u00E2metros acumuladores de produtos e opera\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto (optional)</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o (optional)</param>
        /// <param name="qtdMaxDia">Quantidade m\u00E1xima de opera\u00E7\u00F5es por dia (optional)</param>
        /// <param name="qtdMaxSemana">Quantidade m\u00E1xima de opera\u00E7\u00F5es por semana (optional)</param>
        /// <param name="qtdMaxMes">Quantidade m\u00E1xima de opera\u00E7\u00F5es por m\u00EAs (optional)</param>
        /// <param name="valorMaxDia">Valor m\u00E1ximo de opera\u00E7\u00F5es por dia (optional)</param>
        /// <param name="valorMaxSemana">Valor m\u00E1ximo de opera\u00E7\u00F5es por semana (optional)</param>
        /// <param name="valorMaxMes">Valor m\u00E1ximo de opera\u00E7\u00F5es por m\u00EAs (optional)</param>
        /// <param name="qtdOperacoesGratuitasDia">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por dia (optional)</param>
        /// <param name="qtdOperacoesGratuitasSemana">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por semana (optional)</param>
        /// <param name="qtdOperacoesGratuitasMes">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por m\u00EAs (optional)</param>
        /// <param name="valorTAC">Valor da taxa de abertura de cr\u00E9dito (TAC) (optional)</param>
        /// <returns>PageParametroAcumuladorProdutoOperacaoResponse</returns>
        PageParametroAcumuladorProdutoOperacaoResponse ListarParametrosAcumuladoresProduto (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? qtdMaxDia = null, int? qtdMaxSemana = null, int? qtdMaxMes = null, double? valorMaxDia = null, double? valorMaxSemana = null, double? valorMaxMes = null, int? qtdOperacoesGratuitasDia = null, int? qtdOperacoesGratuitasSemana = null, int? qtdOperacoesGratuitasMes = null, double? valorTAC = null);
  
        /// <summary>
        /// Listar par\u00E2metros acumuladores de produtos e opera\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar par\u00E2metros acumuladores de produtos e opera\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto (optional)</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o (optional)</param>
        /// <param name="qtdMaxDia">Quantidade m\u00E1xima de opera\u00E7\u00F5es por dia (optional)</param>
        /// <param name="qtdMaxSemana">Quantidade m\u00E1xima de opera\u00E7\u00F5es por semana (optional)</param>
        /// <param name="qtdMaxMes">Quantidade m\u00E1xima de opera\u00E7\u00F5es por m\u00EAs (optional)</param>
        /// <param name="valorMaxDia">Valor m\u00E1ximo de opera\u00E7\u00F5es por dia (optional)</param>
        /// <param name="valorMaxSemana">Valor m\u00E1ximo de opera\u00E7\u00F5es por semana (optional)</param>
        /// <param name="valorMaxMes">Valor m\u00E1ximo de opera\u00E7\u00F5es por m\u00EAs (optional)</param>
        /// <param name="qtdOperacoesGratuitasDia">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por dia (optional)</param>
        /// <param name="qtdOperacoesGratuitasSemana">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por semana (optional)</param>
        /// <param name="qtdOperacoesGratuitasMes">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por m\u00EAs (optional)</param>
        /// <param name="valorTAC">Valor da taxa de abertura de cr\u00E9dito (TAC) (optional)</param>
        /// <returns>ApiResponse of PageParametroAcumuladorProdutoOperacaoResponse</returns>
        ApiResponse<PageParametroAcumuladorProdutoOperacaoResponse> ListarParametrosAcumuladoresProdutoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? qtdMaxDia = null, int? qtdMaxSemana = null, int? qtdMaxMes = null, double? valorMaxDia = null, double? valorMaxSemana = null, double? valorMaxMes = null, int? qtdOperacoesGratuitasDia = null, int? qtdOperacoesGratuitasSemana = null, int? qtdOperacoesGratuitasMes = null, double? valorTAC = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Atualizar um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite atualizar um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <param name="parametroAcumuladorUpdate">Objeto de atualiza\u00E7\u00E3o para um par\u00E2metro acumulador de conta/opera\u00E7\u00E3o</param>
        /// <returns>Task of ParametroAcumuladorContaOperacaoResponse</returns>
        System.Threading.Tasks.Task<ParametroAcumuladorContaOperacaoResponse> AtualizarParametroAcumuladorContaAsync (long? idConta, long? idOperacao, ParametroAcumuladorContaOperacaoUpdate parametroAcumuladorUpdate);

        /// <summary>
        /// Atualizar um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite atualizar um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <param name="parametroAcumuladorUpdate">Objeto de atualiza\u00E7\u00E3o para um par\u00E2metro acumulador de conta/opera\u00E7\u00E3o</param>
        /// <returns>Task of ApiResponse (ParametroAcumuladorContaOperacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParametroAcumuladorContaOperacaoResponse>> AtualizarParametroAcumuladorContaAsyncWithHttpInfo (long? idConta, long? idOperacao, ParametroAcumuladorContaOperacaoUpdate parametroAcumuladorUpdate);
        
        /// <summary>
        /// Atualizar um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite atualizar um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <param name="parametroAcumuladorUpdate">Objeto de atualiza\u00E7\u00E3o para um par\u00E2metro acumulador de produto/opera\u00E7\u00E3o</param>
        /// <returns>Task of ParametroAcumuladorProdutoOperacaoResponse</returns>
        System.Threading.Tasks.Task<ParametroAcumuladorProdutoOperacaoResponse> AtualizarParametroAcumuladorProdutoAsync (long? idProduto, long? idOperacao, ParametroAcumuladorProdutoOperacaoUpdate parametroAcumuladorUpdate);

        /// <summary>
        /// Atualizar um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite atualizar um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <param name="parametroAcumuladorUpdate">Objeto de atualiza\u00E7\u00E3o para um par\u00E2metro acumulador de produto/opera\u00E7\u00E3o</param>
        /// <returns>Task of ApiResponse (ParametroAcumuladorProdutoOperacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParametroAcumuladorProdutoOperacaoResponse>> AtualizarParametroAcumuladorProdutoAsyncWithHttpInfo (long? idProduto, long? idOperacao, ParametroAcumuladorProdutoOperacaoUpdate parametroAcumuladorUpdate);
        
        /// <summary>
        /// Cadastrar um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <param name="parametroAcumuladorPersist">Objeto de cria\u00E7\u00E3o para um par\u00E2metro acumulador de conta/opera\u00E7\u00E3o</param>
        /// <returns>Task of ParametroAcumuladorContaOperacaoResponse</returns>
        System.Threading.Tasks.Task<ParametroAcumuladorContaOperacaoResponse> CadastrarParametroAcumuladorContaAsync (long? idConta, long? idOperacao, ParametroAcumuladorContaOperacaoPersist parametroAcumuladorPersist);

        /// <summary>
        /// Cadastrar um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <param name="parametroAcumuladorPersist">Objeto de cria\u00E7\u00E3o para um par\u00E2metro acumulador de conta/opera\u00E7\u00E3o</param>
        /// <returns>Task of ApiResponse (ParametroAcumuladorContaOperacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParametroAcumuladorContaOperacaoResponse>> CadastrarParametroAcumuladorContaAsyncWithHttpInfo (long? idConta, long? idOperacao, ParametroAcumuladorContaOperacaoPersist parametroAcumuladorPersist);
        
        /// <summary>
        /// Cadastrar um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <param name="parametroAcumuladorPersist">Objeto de cria\u00E7\u00E3o para um par\u00E2metro acumulador de produto/opera\u00E7\u00E3o</param>
        /// <returns>Task of ParametroAcumuladorProdutoOperacaoResponse</returns>
        System.Threading.Tasks.Task<ParametroAcumuladorProdutoOperacaoResponse> CadastrarParametroAcumuladorProdutoAsync (long? idProduto, long? idOperacao, ParametroAcumuladorProdutoOperacaoPersist parametroAcumuladorPersist);

        /// <summary>
        /// Cadastrar um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <param name="parametroAcumuladorPersist">Objeto de cria\u00E7\u00E3o para um par\u00E2metro acumulador de produto/opera\u00E7\u00E3o</param>
        /// <returns>Task of ApiResponse (ParametroAcumuladorProdutoOperacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParametroAcumuladorProdutoOperacaoResponse>> CadastrarParametroAcumuladorProdutoAsyncWithHttpInfo (long? idProduto, long? idOperacao, ParametroAcumuladorProdutoOperacaoPersist parametroAcumuladorPersist);
        
        /// <summary>
        /// Consultar um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <returns>Task of ParametroAcumuladorContaOperacaoResponse</returns>
        System.Threading.Tasks.Task<ParametroAcumuladorContaOperacaoResponse> ConsultarParametroAcumuladorContaAsync (long? idConta, long? idOperacao);

        /// <summary>
        /// Consultar um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <returns>Task of ApiResponse (ParametroAcumuladorContaOperacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParametroAcumuladorContaOperacaoResponse>> ConsultarParametroAcumuladorContaAsyncWithHttpInfo (long? idConta, long? idOperacao);
        
        /// <summary>
        /// Consultar um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <returns>Task of ParametroAcumuladorProdutoOperacaoResponse</returns>
        System.Threading.Tasks.Task<ParametroAcumuladorProdutoOperacaoResponse> ConsultarParametroAcumuladorProdutoAsync (long? idProduto, long? idOperacao);

        /// <summary>
        /// Consultar um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite consultar um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <returns>Task of ApiResponse (ParametroAcumuladorProdutoOperacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParametroAcumuladorProdutoOperacaoResponse>> ConsultarParametroAcumuladorProdutoAsyncWithHttpInfo (long? idProduto, long? idOperacao);
        
        /// <summary>
        /// Excluir um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite excluir um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ExcluirParametroAcumuladorContaAsync (long? idConta, long? idOperacao);

        /// <summary>
        /// Excluir um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite excluir um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ExcluirParametroAcumuladorContaAsyncWithHttpInfo (long? idConta, long? idOperacao);
        
        /// <summary>
        /// Excluir um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite excluir um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ExcluirParametroAcumuladorProdutoAsync (long? idProduto, long? idOperacao);

        /// <summary>
        /// Excluir um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite excluir um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ExcluirParametroAcumuladorProdutoAsyncWithHttpInfo (long? idProduto, long? idOperacao);
        
        /// <summary>
        /// Listar par\u00E2metros acumuladores de contas e opera\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar par\u00E2metros acumuladores de contas e opera\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (optional)</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o (optional)</param>
        /// <param name="qtdOperacoesGratuitasDia">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por dia (optional)</param>
        /// <param name="qtdOperacoesGratuitasSemana">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por semana (optional)</param>
        /// <param name="qtdOperacoesGratuitasMes">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por m\u00EAs (optional)</param>
        /// <param name="valorTAC">Valor da taxa de abertura de cr\u00E9dito (TAC) (optional)</param>
        /// <returns>Task of PageParametroAcumuladorContaOperacaoResponse</returns>
        System.Threading.Tasks.Task<PageParametroAcumuladorContaOperacaoResponse> ListarParametrosAcumuladoresContaAsync (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idOperacao = null, int? qtdOperacoesGratuitasDia = null, int? qtdOperacoesGratuitasSemana = null, int? qtdOperacoesGratuitasMes = null, double? valorTAC = null);

        /// <summary>
        /// Listar par\u00E2metros acumuladores de contas e opera\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar par\u00E2metros acumuladores de contas e opera\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (optional)</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o (optional)</param>
        /// <param name="qtdOperacoesGratuitasDia">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por dia (optional)</param>
        /// <param name="qtdOperacoesGratuitasSemana">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por semana (optional)</param>
        /// <param name="qtdOperacoesGratuitasMes">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por m\u00EAs (optional)</param>
        /// <param name="valorTAC">Valor da taxa de abertura de cr\u00E9dito (TAC) (optional)</param>
        /// <returns>Task of ApiResponse (PageParametroAcumuladorContaOperacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageParametroAcumuladorContaOperacaoResponse>> ListarParametrosAcumuladoresContaAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idOperacao = null, int? qtdOperacoesGratuitasDia = null, int? qtdOperacoesGratuitasSemana = null, int? qtdOperacoesGratuitasMes = null, double? valorTAC = null);
        
        /// <summary>
        /// Listar par\u00E2metros acumuladores de produtos e opera\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar par\u00E2metros acumuladores de produtos e opera\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto (optional)</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o (optional)</param>
        /// <param name="qtdMaxDia">Quantidade m\u00E1xima de opera\u00E7\u00F5es por dia (optional)</param>
        /// <param name="qtdMaxSemana">Quantidade m\u00E1xima de opera\u00E7\u00F5es por semana (optional)</param>
        /// <param name="qtdMaxMes">Quantidade m\u00E1xima de opera\u00E7\u00F5es por m\u00EAs (optional)</param>
        /// <param name="valorMaxDia">Valor m\u00E1ximo de opera\u00E7\u00F5es por dia (optional)</param>
        /// <param name="valorMaxSemana">Valor m\u00E1ximo de opera\u00E7\u00F5es por semana (optional)</param>
        /// <param name="valorMaxMes">Valor m\u00E1ximo de opera\u00E7\u00F5es por m\u00EAs (optional)</param>
        /// <param name="qtdOperacoesGratuitasDia">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por dia (optional)</param>
        /// <param name="qtdOperacoesGratuitasSemana">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por semana (optional)</param>
        /// <param name="qtdOperacoesGratuitasMes">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por m\u00EAs (optional)</param>
        /// <param name="valorTAC">Valor da taxa de abertura de cr\u00E9dito (TAC) (optional)</param>
        /// <returns>Task of PageParametroAcumuladorProdutoOperacaoResponse</returns>
        System.Threading.Tasks.Task<PageParametroAcumuladorProdutoOperacaoResponse> ListarParametrosAcumuladoresProdutoAsync (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? qtdMaxDia = null, int? qtdMaxSemana = null, int? qtdMaxMes = null, double? valorMaxDia = null, double? valorMaxSemana = null, double? valorMaxMes = null, int? qtdOperacoesGratuitasDia = null, int? qtdOperacoesGratuitasSemana = null, int? qtdOperacoesGratuitasMes = null, double? valorTAC = null);

        /// <summary>
        /// Listar par\u00E2metros acumuladores de produtos e opera\u00E7\u00F5es
        /// </summary>
        /// <remarks>
        /// Este recurso permite listar par\u00E2metros acumuladores de produtos e opera\u00E7\u00F5es
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto (optional)</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o (optional)</param>
        /// <param name="qtdMaxDia">Quantidade m\u00E1xima de opera\u00E7\u00F5es por dia (optional)</param>
        /// <param name="qtdMaxSemana">Quantidade m\u00E1xima de opera\u00E7\u00F5es por semana (optional)</param>
        /// <param name="qtdMaxMes">Quantidade m\u00E1xima de opera\u00E7\u00F5es por m\u00EAs (optional)</param>
        /// <param name="valorMaxDia">Valor m\u00E1ximo de opera\u00E7\u00F5es por dia (optional)</param>
        /// <param name="valorMaxSemana">Valor m\u00E1ximo de opera\u00E7\u00F5es por semana (optional)</param>
        /// <param name="valorMaxMes">Valor m\u00E1ximo de opera\u00E7\u00F5es por m\u00EAs (optional)</param>
        /// <param name="qtdOperacoesGratuitasDia">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por dia (optional)</param>
        /// <param name="qtdOperacoesGratuitasSemana">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por semana (optional)</param>
        /// <param name="qtdOperacoesGratuitasMes">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por m\u00EAs (optional)</param>
        /// <param name="valorTAC">Valor da taxa de abertura de cr\u00E9dito (TAC) (optional)</param>
        /// <returns>Task of ApiResponse (PageParametroAcumuladorProdutoOperacaoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageParametroAcumuladorProdutoOperacaoResponse>> ListarParametrosAcumuladoresProdutoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? qtdMaxDia = null, int? qtdMaxSemana = null, int? qtdMaxMes = null, double? valorMaxDia = null, double? valorMaxSemana = null, double? valorMaxMes = null, int? qtdOperacoesGratuitasDia = null, int? qtdOperacoesGratuitasSemana = null, int? qtdOperacoesGratuitasMes = null, double? valorTAC = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ConfiguracoesApi : IConfiguracoesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguracoesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConfiguracoesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfiguracoesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ConfiguracoesApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        /// Atualizar um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o Este recurso permite atualizar um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param> 
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param> 
        /// <param name="parametroAcumuladorUpdate">Objeto de atualiza\u00E7\u00E3o para um par\u00E2metro acumulador de conta/opera\u00E7\u00E3o</param> 
        /// <returns>ParametroAcumuladorContaOperacaoResponse</returns>
        public ParametroAcumuladorContaOperacaoResponse AtualizarParametroAcumuladorConta (long? idConta, long? idOperacao, ParametroAcumuladorContaOperacaoUpdate parametroAcumuladorUpdate)
        {
             ApiResponse<ParametroAcumuladorContaOperacaoResponse> localVarResponse = AtualizarParametroAcumuladorContaWithHttpInfo(idConta, idOperacao, parametroAcumuladorUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualizar um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o Este recurso permite atualizar um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param> 
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param> 
        /// <param name="parametroAcumuladorUpdate">Objeto de atualiza\u00E7\u00E3o para um par\u00E2metro acumulador de conta/opera\u00E7\u00E3o</param> 
        /// <returns>ApiResponse of ParametroAcumuladorContaOperacaoResponse</returns>
        public ApiResponse< ParametroAcumuladorContaOperacaoResponse > AtualizarParametroAcumuladorContaWithHttpInfo (long? idConta, long? idOperacao, ParametroAcumuladorContaOperacaoUpdate parametroAcumuladorUpdate)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling ConfiguracoesApi->AtualizarParametroAcumuladorConta");
            
            // verify the required parameter 'idOperacao' is set
            if (idOperacao == null)
                throw new ApiException(400, "Missing required parameter 'idOperacao' when calling ConfiguracoesApi->AtualizarParametroAcumuladorConta");
            
            // verify the required parameter 'parametroAcumuladorUpdate' is set
            if (parametroAcumuladorUpdate == null)
                throw new ApiException(400, "Missing required parameter 'parametroAcumuladorUpdate' when calling ConfiguracoesApi->AtualizarParametroAcumuladorConta");
            
    
            var localVarPath = "/api/contas/{idConta}/operacoes/{idOperacao}/configuracoes/acumuladores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idOperacao != null) localVarPathParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // path parameter
            
            
            
            
            if (parametroAcumuladorUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(parametroAcumuladorUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = parametroAcumuladorUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarParametroAcumuladorConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarParametroAcumuladorConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ParametroAcumuladorContaOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametroAcumuladorContaOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametroAcumuladorContaOperacaoResponse)));
            
        }

        
        /// <summary>
        /// Atualizar um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o Este recurso permite atualizar um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <param name="parametroAcumuladorUpdate">Objeto de atualiza\u00E7\u00E3o para um par\u00E2metro acumulador de conta/opera\u00E7\u00E3o</param>
        /// <returns>Task of ParametroAcumuladorContaOperacaoResponse</returns>
        public async System.Threading.Tasks.Task<ParametroAcumuladorContaOperacaoResponse> AtualizarParametroAcumuladorContaAsync (long? idConta, long? idOperacao, ParametroAcumuladorContaOperacaoUpdate parametroAcumuladorUpdate)
        {
             ApiResponse<ParametroAcumuladorContaOperacaoResponse> localVarResponse = await AtualizarParametroAcumuladorContaAsyncWithHttpInfo(idConta, idOperacao, parametroAcumuladorUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualizar um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o Este recurso permite atualizar um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <param name="parametroAcumuladorUpdate">Objeto de atualiza\u00E7\u00E3o para um par\u00E2metro acumulador de conta/opera\u00E7\u00E3o</param>
        /// <returns>Task of ApiResponse (ParametroAcumuladorContaOperacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParametroAcumuladorContaOperacaoResponse>> AtualizarParametroAcumuladorContaAsyncWithHttpInfo (long? idConta, long? idOperacao, ParametroAcumuladorContaOperacaoUpdate parametroAcumuladorUpdate)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling AtualizarParametroAcumuladorConta");
            // verify the required parameter 'idOperacao' is set
            if (idOperacao == null) throw new ApiException(400, "Missing required parameter 'idOperacao' when calling AtualizarParametroAcumuladorConta");
            // verify the required parameter 'parametroAcumuladorUpdate' is set
            if (parametroAcumuladorUpdate == null) throw new ApiException(400, "Missing required parameter 'parametroAcumuladorUpdate' when calling AtualizarParametroAcumuladorConta");
            
    
            var localVarPath = "/api/contas/{idConta}/operacoes/{idOperacao}/configuracoes/acumuladores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idOperacao != null) localVarPathParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // path parameter
            
            
            
            
            if (parametroAcumuladorUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(parametroAcumuladorUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = parametroAcumuladorUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarParametroAcumuladorConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarParametroAcumuladorConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParametroAcumuladorContaOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametroAcumuladorContaOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametroAcumuladorContaOperacaoResponse)));
            
        }
        
        /// <summary>
        /// Atualizar um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o Este recurso permite atualizar um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param> 
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param> 
        /// <param name="parametroAcumuladorUpdate">Objeto de atualiza\u00E7\u00E3o para um par\u00E2metro acumulador de produto/opera\u00E7\u00E3o</param> 
        /// <returns>ParametroAcumuladorProdutoOperacaoResponse</returns>
        public ParametroAcumuladorProdutoOperacaoResponse AtualizarParametroAcumuladorProduto (long? idProduto, long? idOperacao, ParametroAcumuladorProdutoOperacaoUpdate parametroAcumuladorUpdate)
        {
             ApiResponse<ParametroAcumuladorProdutoOperacaoResponse> localVarResponse = AtualizarParametroAcumuladorProdutoWithHttpInfo(idProduto, idOperacao, parametroAcumuladorUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualizar um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o Este recurso permite atualizar um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param> 
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param> 
        /// <param name="parametroAcumuladorUpdate">Objeto de atualiza\u00E7\u00E3o para um par\u00E2metro acumulador de produto/opera\u00E7\u00E3o</param> 
        /// <returns>ApiResponse of ParametroAcumuladorProdutoOperacaoResponse</returns>
        public ApiResponse< ParametroAcumuladorProdutoOperacaoResponse > AtualizarParametroAcumuladorProdutoWithHttpInfo (long? idProduto, long? idOperacao, ParametroAcumuladorProdutoOperacaoUpdate parametroAcumuladorUpdate)
        {
            
            // verify the required parameter 'idProduto' is set
            if (idProduto == null)
                throw new ApiException(400, "Missing required parameter 'idProduto' when calling ConfiguracoesApi->AtualizarParametroAcumuladorProduto");
            
            // verify the required parameter 'idOperacao' is set
            if (idOperacao == null)
                throw new ApiException(400, "Missing required parameter 'idOperacao' when calling ConfiguracoesApi->AtualizarParametroAcumuladorProduto");
            
            // verify the required parameter 'parametroAcumuladorUpdate' is set
            if (parametroAcumuladorUpdate == null)
                throw new ApiException(400, "Missing required parameter 'parametroAcumuladorUpdate' when calling ConfiguracoesApi->AtualizarParametroAcumuladorProduto");
            
    
            var localVarPath = "/api/produtos/{idProduto}/operacoes/{idOperacao}/configuracoes/acumuladores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idProduto != null) localVarPathParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // path parameter
            if (idOperacao != null) localVarPathParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // path parameter
            
            
            
            
            if (parametroAcumuladorUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(parametroAcumuladorUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = parametroAcumuladorUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarParametroAcumuladorProduto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarParametroAcumuladorProduto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ParametroAcumuladorProdutoOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametroAcumuladorProdutoOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametroAcumuladorProdutoOperacaoResponse)));
            
        }

        
        /// <summary>
        /// Atualizar um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o Este recurso permite atualizar um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <param name="parametroAcumuladorUpdate">Objeto de atualiza\u00E7\u00E3o para um par\u00E2metro acumulador de produto/opera\u00E7\u00E3o</param>
        /// <returns>Task of ParametroAcumuladorProdutoOperacaoResponse</returns>
        public async System.Threading.Tasks.Task<ParametroAcumuladorProdutoOperacaoResponse> AtualizarParametroAcumuladorProdutoAsync (long? idProduto, long? idOperacao, ParametroAcumuladorProdutoOperacaoUpdate parametroAcumuladorUpdate)
        {
             ApiResponse<ParametroAcumuladorProdutoOperacaoResponse> localVarResponse = await AtualizarParametroAcumuladorProdutoAsyncWithHttpInfo(idProduto, idOperacao, parametroAcumuladorUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualizar um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o Este recurso permite atualizar um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <param name="parametroAcumuladorUpdate">Objeto de atualiza\u00E7\u00E3o para um par\u00E2metro acumulador de produto/opera\u00E7\u00E3o</param>
        /// <returns>Task of ApiResponse (ParametroAcumuladorProdutoOperacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParametroAcumuladorProdutoOperacaoResponse>> AtualizarParametroAcumuladorProdutoAsyncWithHttpInfo (long? idProduto, long? idOperacao, ParametroAcumuladorProdutoOperacaoUpdate parametroAcumuladorUpdate)
        {
            // verify the required parameter 'idProduto' is set
            if (idProduto == null) throw new ApiException(400, "Missing required parameter 'idProduto' when calling AtualizarParametroAcumuladorProduto");
            // verify the required parameter 'idOperacao' is set
            if (idOperacao == null) throw new ApiException(400, "Missing required parameter 'idOperacao' when calling AtualizarParametroAcumuladorProduto");
            // verify the required parameter 'parametroAcumuladorUpdate' is set
            if (parametroAcumuladorUpdate == null) throw new ApiException(400, "Missing required parameter 'parametroAcumuladorUpdate' when calling AtualizarParametroAcumuladorProduto");
            
    
            var localVarPath = "/api/produtos/{idProduto}/operacoes/{idOperacao}/configuracoes/acumuladores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idProduto != null) localVarPathParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // path parameter
            if (idOperacao != null) localVarPathParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // path parameter
            
            
            
            
            if (parametroAcumuladorUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(parametroAcumuladorUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = parametroAcumuladorUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarParametroAcumuladorProduto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarParametroAcumuladorProduto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParametroAcumuladorProdutoOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametroAcumuladorProdutoOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametroAcumuladorProdutoOperacaoResponse)));
            
        }
        
        /// <summary>
        /// Cadastrar um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o Este recurso permite cadastrar um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param> 
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param> 
        /// <param name="parametroAcumuladorPersist">Objeto de cria\u00E7\u00E3o para um par\u00E2metro acumulador de conta/opera\u00E7\u00E3o</param> 
        /// <returns>ParametroAcumuladorContaOperacaoResponse</returns>
        public ParametroAcumuladorContaOperacaoResponse CadastrarParametroAcumuladorConta (long? idConta, long? idOperacao, ParametroAcumuladorContaOperacaoPersist parametroAcumuladorPersist)
        {
             ApiResponse<ParametroAcumuladorContaOperacaoResponse> localVarResponse = CadastrarParametroAcumuladorContaWithHttpInfo(idConta, idOperacao, parametroAcumuladorPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastrar um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o Este recurso permite cadastrar um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param> 
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param> 
        /// <param name="parametroAcumuladorPersist">Objeto de cria\u00E7\u00E3o para um par\u00E2metro acumulador de conta/opera\u00E7\u00E3o</param> 
        /// <returns>ApiResponse of ParametroAcumuladorContaOperacaoResponse</returns>
        public ApiResponse< ParametroAcumuladorContaOperacaoResponse > CadastrarParametroAcumuladorContaWithHttpInfo (long? idConta, long? idOperacao, ParametroAcumuladorContaOperacaoPersist parametroAcumuladorPersist)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling ConfiguracoesApi->CadastrarParametroAcumuladorConta");
            
            // verify the required parameter 'idOperacao' is set
            if (idOperacao == null)
                throw new ApiException(400, "Missing required parameter 'idOperacao' when calling ConfiguracoesApi->CadastrarParametroAcumuladorConta");
            
            // verify the required parameter 'parametroAcumuladorPersist' is set
            if (parametroAcumuladorPersist == null)
                throw new ApiException(400, "Missing required parameter 'parametroAcumuladorPersist' when calling ConfiguracoesApi->CadastrarParametroAcumuladorConta");
            
    
            var localVarPath = "/api/contas/{idConta}/operacoes/{idOperacao}/configuracoes/acumuladores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idOperacao != null) localVarPathParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // path parameter
            
            
            
            
            if (parametroAcumuladorPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(parametroAcumuladorPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = parametroAcumuladorPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarParametroAcumuladorConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarParametroAcumuladorConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ParametroAcumuladorContaOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametroAcumuladorContaOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametroAcumuladorContaOperacaoResponse)));
            
        }

        
        /// <summary>
        /// Cadastrar um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o Este recurso permite cadastrar um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <param name="parametroAcumuladorPersist">Objeto de cria\u00E7\u00E3o para um par\u00E2metro acumulador de conta/opera\u00E7\u00E3o</param>
        /// <returns>Task of ParametroAcumuladorContaOperacaoResponse</returns>
        public async System.Threading.Tasks.Task<ParametroAcumuladorContaOperacaoResponse> CadastrarParametroAcumuladorContaAsync (long? idConta, long? idOperacao, ParametroAcumuladorContaOperacaoPersist parametroAcumuladorPersist)
        {
             ApiResponse<ParametroAcumuladorContaOperacaoResponse> localVarResponse = await CadastrarParametroAcumuladorContaAsyncWithHttpInfo(idConta, idOperacao, parametroAcumuladorPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastrar um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o Este recurso permite cadastrar um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <param name="parametroAcumuladorPersist">Objeto de cria\u00E7\u00E3o para um par\u00E2metro acumulador de conta/opera\u00E7\u00E3o</param>
        /// <returns>Task of ApiResponse (ParametroAcumuladorContaOperacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParametroAcumuladorContaOperacaoResponse>> CadastrarParametroAcumuladorContaAsyncWithHttpInfo (long? idConta, long? idOperacao, ParametroAcumuladorContaOperacaoPersist parametroAcumuladorPersist)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling CadastrarParametroAcumuladorConta");
            // verify the required parameter 'idOperacao' is set
            if (idOperacao == null) throw new ApiException(400, "Missing required parameter 'idOperacao' when calling CadastrarParametroAcumuladorConta");
            // verify the required parameter 'parametroAcumuladorPersist' is set
            if (parametroAcumuladorPersist == null) throw new ApiException(400, "Missing required parameter 'parametroAcumuladorPersist' when calling CadastrarParametroAcumuladorConta");
            
    
            var localVarPath = "/api/contas/{idConta}/operacoes/{idOperacao}/configuracoes/acumuladores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idOperacao != null) localVarPathParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // path parameter
            
            
            
            
            if (parametroAcumuladorPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(parametroAcumuladorPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = parametroAcumuladorPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarParametroAcumuladorConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarParametroAcumuladorConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParametroAcumuladorContaOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametroAcumuladorContaOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametroAcumuladorContaOperacaoResponse)));
            
        }
        
        /// <summary>
        /// Cadastrar um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o Este recurso permite cadastrar um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param> 
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param> 
        /// <param name="parametroAcumuladorPersist">Objeto de cria\u00E7\u00E3o para um par\u00E2metro acumulador de produto/opera\u00E7\u00E3o</param> 
        /// <returns>ParametroAcumuladorProdutoOperacaoResponse</returns>
        public ParametroAcumuladorProdutoOperacaoResponse CadastrarParametroAcumuladorProduto (long? idProduto, long? idOperacao, ParametroAcumuladorProdutoOperacaoPersist parametroAcumuladorPersist)
        {
             ApiResponse<ParametroAcumuladorProdutoOperacaoResponse> localVarResponse = CadastrarParametroAcumuladorProdutoWithHttpInfo(idProduto, idOperacao, parametroAcumuladorPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastrar um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o Este recurso permite cadastrar um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param> 
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param> 
        /// <param name="parametroAcumuladorPersist">Objeto de cria\u00E7\u00E3o para um par\u00E2metro acumulador de produto/opera\u00E7\u00E3o</param> 
        /// <returns>ApiResponse of ParametroAcumuladorProdutoOperacaoResponse</returns>
        public ApiResponse< ParametroAcumuladorProdutoOperacaoResponse > CadastrarParametroAcumuladorProdutoWithHttpInfo (long? idProduto, long? idOperacao, ParametroAcumuladorProdutoOperacaoPersist parametroAcumuladorPersist)
        {
            
            // verify the required parameter 'idProduto' is set
            if (idProduto == null)
                throw new ApiException(400, "Missing required parameter 'idProduto' when calling ConfiguracoesApi->CadastrarParametroAcumuladorProduto");
            
            // verify the required parameter 'idOperacao' is set
            if (idOperacao == null)
                throw new ApiException(400, "Missing required parameter 'idOperacao' when calling ConfiguracoesApi->CadastrarParametroAcumuladorProduto");
            
            // verify the required parameter 'parametroAcumuladorPersist' is set
            if (parametroAcumuladorPersist == null)
                throw new ApiException(400, "Missing required parameter 'parametroAcumuladorPersist' when calling ConfiguracoesApi->CadastrarParametroAcumuladorProduto");
            
    
            var localVarPath = "/api/produtos/{idProduto}/operacoes/{idOperacao}/configuracoes/acumuladores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idProduto != null) localVarPathParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // path parameter
            if (idOperacao != null) localVarPathParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // path parameter
            
            
            
            
            if (parametroAcumuladorPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(parametroAcumuladorPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = parametroAcumuladorPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarParametroAcumuladorProduto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarParametroAcumuladorProduto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ParametroAcumuladorProdutoOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametroAcumuladorProdutoOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametroAcumuladorProdutoOperacaoResponse)));
            
        }

        
        /// <summary>
        /// Cadastrar um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o Este recurso permite cadastrar um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <param name="parametroAcumuladorPersist">Objeto de cria\u00E7\u00E3o para um par\u00E2metro acumulador de produto/opera\u00E7\u00E3o</param>
        /// <returns>Task of ParametroAcumuladorProdutoOperacaoResponse</returns>
        public async System.Threading.Tasks.Task<ParametroAcumuladorProdutoOperacaoResponse> CadastrarParametroAcumuladorProdutoAsync (long? idProduto, long? idOperacao, ParametroAcumuladorProdutoOperacaoPersist parametroAcumuladorPersist)
        {
             ApiResponse<ParametroAcumuladorProdutoOperacaoResponse> localVarResponse = await CadastrarParametroAcumuladorProdutoAsyncWithHttpInfo(idProduto, idOperacao, parametroAcumuladorPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastrar um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o Este recurso permite cadastrar um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <param name="parametroAcumuladorPersist">Objeto de cria\u00E7\u00E3o para um par\u00E2metro acumulador de produto/opera\u00E7\u00E3o</param>
        /// <returns>Task of ApiResponse (ParametroAcumuladorProdutoOperacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParametroAcumuladorProdutoOperacaoResponse>> CadastrarParametroAcumuladorProdutoAsyncWithHttpInfo (long? idProduto, long? idOperacao, ParametroAcumuladorProdutoOperacaoPersist parametroAcumuladorPersist)
        {
            // verify the required parameter 'idProduto' is set
            if (idProduto == null) throw new ApiException(400, "Missing required parameter 'idProduto' when calling CadastrarParametroAcumuladorProduto");
            // verify the required parameter 'idOperacao' is set
            if (idOperacao == null) throw new ApiException(400, "Missing required parameter 'idOperacao' when calling CadastrarParametroAcumuladorProduto");
            // verify the required parameter 'parametroAcumuladorPersist' is set
            if (parametroAcumuladorPersist == null) throw new ApiException(400, "Missing required parameter 'parametroAcumuladorPersist' when calling CadastrarParametroAcumuladorProduto");
            
    
            var localVarPath = "/api/produtos/{idProduto}/operacoes/{idOperacao}/configuracoes/acumuladores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idProduto != null) localVarPathParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // path parameter
            if (idOperacao != null) localVarPathParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // path parameter
            
            
            
            
            if (parametroAcumuladorPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(parametroAcumuladorPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = parametroAcumuladorPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarParametroAcumuladorProduto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarParametroAcumuladorProduto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParametroAcumuladorProdutoOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametroAcumuladorProdutoOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametroAcumuladorProdutoOperacaoResponse)));
            
        }
        
        /// <summary>
        /// Consultar um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o Este recurso permite consultar um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param> 
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param> 
        /// <returns>ParametroAcumuladorContaOperacaoResponse</returns>
        public ParametroAcumuladorContaOperacaoResponse ConsultarParametroAcumuladorConta (long? idConta, long? idOperacao)
        {
             ApiResponse<ParametroAcumuladorContaOperacaoResponse> localVarResponse = ConsultarParametroAcumuladorContaWithHttpInfo(idConta, idOperacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o Este recurso permite consultar um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param> 
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param> 
        /// <returns>ApiResponse of ParametroAcumuladorContaOperacaoResponse</returns>
        public ApiResponse< ParametroAcumuladorContaOperacaoResponse > ConsultarParametroAcumuladorContaWithHttpInfo (long? idConta, long? idOperacao)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling ConfiguracoesApi->ConsultarParametroAcumuladorConta");
            
            // verify the required parameter 'idOperacao' is set
            if (idOperacao == null)
                throw new ApiException(400, "Missing required parameter 'idOperacao' when calling ConfiguracoesApi->ConsultarParametroAcumuladorConta");
            
    
            var localVarPath = "/api/contas/{idConta}/operacoes/{idOperacao}/configuracoes/acumuladores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idOperacao != null) localVarPathParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarParametroAcumuladorConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarParametroAcumuladorConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ParametroAcumuladorContaOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametroAcumuladorContaOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametroAcumuladorContaOperacaoResponse)));
            
        }

        
        /// <summary>
        /// Consultar um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o Este recurso permite consultar um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <returns>Task of ParametroAcumuladorContaOperacaoResponse</returns>
        public async System.Threading.Tasks.Task<ParametroAcumuladorContaOperacaoResponse> ConsultarParametroAcumuladorContaAsync (long? idConta, long? idOperacao)
        {
             ApiResponse<ParametroAcumuladorContaOperacaoResponse> localVarResponse = await ConsultarParametroAcumuladorContaAsyncWithHttpInfo(idConta, idOperacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o Este recurso permite consultar um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <returns>Task of ApiResponse (ParametroAcumuladorContaOperacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParametroAcumuladorContaOperacaoResponse>> ConsultarParametroAcumuladorContaAsyncWithHttpInfo (long? idConta, long? idOperacao)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ConsultarParametroAcumuladorConta");
            // verify the required parameter 'idOperacao' is set
            if (idOperacao == null) throw new ApiException(400, "Missing required parameter 'idOperacao' when calling ConsultarParametroAcumuladorConta");
            
    
            var localVarPath = "/api/contas/{idConta}/operacoes/{idOperacao}/configuracoes/acumuladores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idOperacao != null) localVarPathParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarParametroAcumuladorConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarParametroAcumuladorConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParametroAcumuladorContaOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametroAcumuladorContaOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametroAcumuladorContaOperacaoResponse)));
            
        }
        
        /// <summary>
        /// Consultar um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o Este recurso permite consultar um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param> 
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param> 
        /// <returns>ParametroAcumuladorProdutoOperacaoResponse</returns>
        public ParametroAcumuladorProdutoOperacaoResponse ConsultarParametroAcumuladorProduto (long? idProduto, long? idOperacao)
        {
             ApiResponse<ParametroAcumuladorProdutoOperacaoResponse> localVarResponse = ConsultarParametroAcumuladorProdutoWithHttpInfo(idProduto, idOperacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o Este recurso permite consultar um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param> 
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param> 
        /// <returns>ApiResponse of ParametroAcumuladorProdutoOperacaoResponse</returns>
        public ApiResponse< ParametroAcumuladorProdutoOperacaoResponse > ConsultarParametroAcumuladorProdutoWithHttpInfo (long? idProduto, long? idOperacao)
        {
            
            // verify the required parameter 'idProduto' is set
            if (idProduto == null)
                throw new ApiException(400, "Missing required parameter 'idProduto' when calling ConfiguracoesApi->ConsultarParametroAcumuladorProduto");
            
            // verify the required parameter 'idOperacao' is set
            if (idOperacao == null)
                throw new ApiException(400, "Missing required parameter 'idOperacao' when calling ConfiguracoesApi->ConsultarParametroAcumuladorProduto");
            
    
            var localVarPath = "/api/produtos/{idProduto}/operacoes/{idOperacao}/configuracoes/acumuladores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idProduto != null) localVarPathParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // path parameter
            if (idOperacao != null) localVarPathParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarParametroAcumuladorProduto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarParametroAcumuladorProduto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ParametroAcumuladorProdutoOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametroAcumuladorProdutoOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametroAcumuladorProdutoOperacaoResponse)));
            
        }

        
        /// <summary>
        /// Consultar um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o Este recurso permite consultar um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <returns>Task of ParametroAcumuladorProdutoOperacaoResponse</returns>
        public async System.Threading.Tasks.Task<ParametroAcumuladorProdutoOperacaoResponse> ConsultarParametroAcumuladorProdutoAsync (long? idProduto, long? idOperacao)
        {
             ApiResponse<ParametroAcumuladorProdutoOperacaoResponse> localVarResponse = await ConsultarParametroAcumuladorProdutoAsyncWithHttpInfo(idProduto, idOperacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o Este recurso permite consultar um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <returns>Task of ApiResponse (ParametroAcumuladorProdutoOperacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParametroAcumuladorProdutoOperacaoResponse>> ConsultarParametroAcumuladorProdutoAsyncWithHttpInfo (long? idProduto, long? idOperacao)
        {
            // verify the required parameter 'idProduto' is set
            if (idProduto == null) throw new ApiException(400, "Missing required parameter 'idProduto' when calling ConsultarParametroAcumuladorProduto");
            // verify the required parameter 'idOperacao' is set
            if (idOperacao == null) throw new ApiException(400, "Missing required parameter 'idOperacao' when calling ConsultarParametroAcumuladorProduto");
            
    
            var localVarPath = "/api/produtos/{idProduto}/operacoes/{idOperacao}/configuracoes/acumuladores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idProduto != null) localVarPathParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // path parameter
            if (idOperacao != null) localVarPathParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarParametroAcumuladorProduto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarParametroAcumuladorProduto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParametroAcumuladorProdutoOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParametroAcumuladorProdutoOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParametroAcumuladorProdutoOperacaoResponse)));
            
        }
        
        /// <summary>
        /// Excluir um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o Este recurso permite excluir um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param> 
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param> 
        /// <returns>Object</returns>
        public Object ExcluirParametroAcumuladorConta (long? idConta, long? idOperacao)
        {
             ApiResponse<Object> localVarResponse = ExcluirParametroAcumuladorContaWithHttpInfo(idConta, idOperacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Excluir um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o Este recurso permite excluir um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param> 
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ExcluirParametroAcumuladorContaWithHttpInfo (long? idConta, long? idOperacao)
        {
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling ConfiguracoesApi->ExcluirParametroAcumuladorConta");
            
            // verify the required parameter 'idOperacao' is set
            if (idOperacao == null)
                throw new ApiException(400, "Missing required parameter 'idOperacao' when calling ConfiguracoesApi->ExcluirParametroAcumuladorConta");
            
    
            var localVarPath = "/api/contas/{idConta}/operacoes/{idOperacao}/configuracoes/acumuladores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idOperacao != null) localVarPathParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ExcluirParametroAcumuladorConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ExcluirParametroAcumuladorConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Excluir um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o Este recurso permite excluir um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ExcluirParametroAcumuladorContaAsync (long? idConta, long? idOperacao)
        {
             ApiResponse<Object> localVarResponse = await ExcluirParametroAcumuladorContaAsyncWithHttpInfo(idConta, idOperacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Excluir um par\u00E2metro acumulador entre conta e opera\u00E7\u00E3o Este recurso permite excluir um par\u00E2metro acumulador de uma conta para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ExcluirParametroAcumuladorContaAsyncWithHttpInfo (long? idConta, long? idOperacao)
        {
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling ExcluirParametroAcumuladorConta");
            // verify the required parameter 'idOperacao' is set
            if (idOperacao == null) throw new ApiException(400, "Missing required parameter 'idOperacao' when calling ExcluirParametroAcumuladorConta");
            
    
            var localVarPath = "/api/contas/{idConta}/operacoes/{idOperacao}/configuracoes/acumuladores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idConta != null) localVarPathParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // path parameter
            if (idOperacao != null) localVarPathParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ExcluirParametroAcumuladorConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ExcluirParametroAcumuladorConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Excluir um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o Este recurso permite excluir um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param> 
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param> 
        /// <returns>Object</returns>
        public Object ExcluirParametroAcumuladorProduto (long? idProduto, long? idOperacao)
        {
             ApiResponse<Object> localVarResponse = ExcluirParametroAcumuladorProdutoWithHttpInfo(idProduto, idOperacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Excluir um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o Este recurso permite excluir um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param> 
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > ExcluirParametroAcumuladorProdutoWithHttpInfo (long? idProduto, long? idOperacao)
        {
            
            // verify the required parameter 'idProduto' is set
            if (idProduto == null)
                throw new ApiException(400, "Missing required parameter 'idProduto' when calling ConfiguracoesApi->ExcluirParametroAcumuladorProduto");
            
            // verify the required parameter 'idOperacao' is set
            if (idOperacao == null)
                throw new ApiException(400, "Missing required parameter 'idOperacao' when calling ConfiguracoesApi->ExcluirParametroAcumuladorProduto");
            
    
            var localVarPath = "/api/produtos/{idProduto}/operacoes/{idOperacao}/configuracoes/acumuladores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idProduto != null) localVarPathParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // path parameter
            if (idOperacao != null) localVarPathParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ExcluirParametroAcumuladorProduto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ExcluirParametroAcumuladorProduto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Excluir um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o Este recurso permite excluir um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ExcluirParametroAcumuladorProdutoAsync (long? idProduto, long? idOperacao)
        {
             ApiResponse<Object> localVarResponse = await ExcluirParametroAcumuladorProdutoAsyncWithHttpInfo(idProduto, idOperacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Excluir um par\u00E2metro acumulador entre produto e opera\u00E7\u00E3o Este recurso permite excluir um par\u00E2metro acumulador de um produto para uma determinada opera\u00E7\u00E3o previamente cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ExcluirParametroAcumuladorProdutoAsyncWithHttpInfo (long? idProduto, long? idOperacao)
        {
            // verify the required parameter 'idProduto' is set
            if (idProduto == null) throw new ApiException(400, "Missing required parameter 'idProduto' when calling ExcluirParametroAcumuladorProduto");
            // verify the required parameter 'idOperacao' is set
            if (idOperacao == null) throw new ApiException(400, "Missing required parameter 'idOperacao' when calling ExcluirParametroAcumuladorProduto");
            
    
            var localVarPath = "/api/produtos/{idProduto}/operacoes/{idOperacao}/configuracoes/acumuladores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (idProduto != null) localVarPathParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // path parameter
            if (idOperacao != null) localVarPathParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ExcluirParametroAcumuladorProduto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ExcluirParametroAcumuladorProduto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Listar par\u00E2metros acumuladores de contas e opera\u00E7\u00F5es Este recurso permite listar par\u00E2metros acumuladores de contas e opera\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (optional)</param> 
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o (optional)</param> 
        /// <param name="qtdOperacoesGratuitasDia">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por dia (optional)</param> 
        /// <param name="qtdOperacoesGratuitasSemana">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por semana (optional)</param> 
        /// <param name="qtdOperacoesGratuitasMes">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por m\u00EAs (optional)</param> 
        /// <param name="valorTAC">Valor da taxa de abertura de cr\u00E9dito (TAC) (optional)</param> 
        /// <returns>PageParametroAcumuladorContaOperacaoResponse</returns>
        public PageParametroAcumuladorContaOperacaoResponse ListarParametrosAcumuladoresConta (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idOperacao = null, int? qtdOperacoesGratuitasDia = null, int? qtdOperacoesGratuitasSemana = null, int? qtdOperacoesGratuitasMes = null, double? valorTAC = null)
        {
             ApiResponse<PageParametroAcumuladorContaOperacaoResponse> localVarResponse = ListarParametrosAcumuladoresContaWithHttpInfo(sort, page, limit, idConta, idOperacao, qtdOperacoesGratuitasDia, qtdOperacoesGratuitasSemana, qtdOperacoesGratuitasMes, valorTAC);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar par\u00E2metros acumuladores de contas e opera\u00E7\u00F5es Este recurso permite listar par\u00E2metros acumuladores de contas e opera\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (optional)</param> 
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o (optional)</param> 
        /// <param name="qtdOperacoesGratuitasDia">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por dia (optional)</param> 
        /// <param name="qtdOperacoesGratuitasSemana">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por semana (optional)</param> 
        /// <param name="qtdOperacoesGratuitasMes">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por m\u00EAs (optional)</param> 
        /// <param name="valorTAC">Valor da taxa de abertura de cr\u00E9dito (TAC) (optional)</param> 
        /// <returns>ApiResponse of PageParametroAcumuladorContaOperacaoResponse</returns>
        public ApiResponse< PageParametroAcumuladorContaOperacaoResponse > ListarParametrosAcumuladoresContaWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idOperacao = null, int? qtdOperacoesGratuitasDia = null, int? qtdOperacoesGratuitasSemana = null, int? qtdOperacoesGratuitasMes = null, double? valorTAC = null)
        {
            
    
            var localVarPath = "/api/contas/configuracoes/acumuladores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idOperacao != null) localVarQueryParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // query parameter
            if (qtdOperacoesGratuitasDia != null) localVarQueryParams.Add("qtdOperacoesGratuitasDia", Configuration.ApiClient.ParameterToString(qtdOperacoesGratuitasDia)); // query parameter
            if (qtdOperacoesGratuitasSemana != null) localVarQueryParams.Add("qtdOperacoesGratuitasSemana", Configuration.ApiClient.ParameterToString(qtdOperacoesGratuitasSemana)); // query parameter
            if (qtdOperacoesGratuitasMes != null) localVarQueryParams.Add("qtdOperacoesGratuitasMes", Configuration.ApiClient.ParameterToString(qtdOperacoesGratuitasMes)); // query parameter
            if (valorTAC != null) localVarQueryParams.Add("valorTAC", Configuration.ApiClient.ParameterToString(valorTAC)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarParametrosAcumuladoresConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarParametrosAcumuladoresConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageParametroAcumuladorContaOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageParametroAcumuladorContaOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageParametroAcumuladorContaOperacaoResponse)));
            
        }

        
        /// <summary>
        /// Listar par\u00E2metros acumuladores de contas e opera\u00E7\u00F5es Este recurso permite listar par\u00E2metros acumuladores de contas e opera\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (optional)</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o (optional)</param>
        /// <param name="qtdOperacoesGratuitasDia">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por dia (optional)</param>
        /// <param name="qtdOperacoesGratuitasSemana">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por semana (optional)</param>
        /// <param name="qtdOperacoesGratuitasMes">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por m\u00EAs (optional)</param>
        /// <param name="valorTAC">Valor da taxa de abertura de cr\u00E9dito (TAC) (optional)</param>
        /// <returns>Task of PageParametroAcumuladorContaOperacaoResponse</returns>
        public async System.Threading.Tasks.Task<PageParametroAcumuladorContaOperacaoResponse> ListarParametrosAcumuladoresContaAsync (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idOperacao = null, int? qtdOperacoesGratuitasDia = null, int? qtdOperacoesGratuitasSemana = null, int? qtdOperacoesGratuitasMes = null, double? valorTAC = null)
        {
             ApiResponse<PageParametroAcumuladorContaOperacaoResponse> localVarResponse = await ListarParametrosAcumuladoresContaAsyncWithHttpInfo(sort, page, limit, idConta, idOperacao, qtdOperacoesGratuitasDia, qtdOperacoesGratuitasSemana, qtdOperacoesGratuitasMes, valorTAC);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar par\u00E2metros acumuladores de contas e opera\u00E7\u00F5es Este recurso permite listar par\u00E2metros acumuladores de contas e opera\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idConta">C\u00F3digo de identifica\u00E7\u00E3o da conta (optional)</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o (optional)</param>
        /// <param name="qtdOperacoesGratuitasDia">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por dia (optional)</param>
        /// <param name="qtdOperacoesGratuitasSemana">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por semana (optional)</param>
        /// <param name="qtdOperacoesGratuitasMes">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por m\u00EAs (optional)</param>
        /// <param name="valorTAC">Valor da taxa de abertura de cr\u00E9dito (TAC) (optional)</param>
        /// <returns>Task of ApiResponse (PageParametroAcumuladorContaOperacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageParametroAcumuladorContaOperacaoResponse>> ListarParametrosAcumuladoresContaAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idConta = null, long? idOperacao = null, int? qtdOperacoesGratuitasDia = null, int? qtdOperacoesGratuitasSemana = null, int? qtdOperacoesGratuitasMes = null, double? valorTAC = null)
        {
            
    
            var localVarPath = "/api/contas/configuracoes/acumuladores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idOperacao != null) localVarQueryParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // query parameter
            if (qtdOperacoesGratuitasDia != null) localVarQueryParams.Add("qtdOperacoesGratuitasDia", Configuration.ApiClient.ParameterToString(qtdOperacoesGratuitasDia)); // query parameter
            if (qtdOperacoesGratuitasSemana != null) localVarQueryParams.Add("qtdOperacoesGratuitasSemana", Configuration.ApiClient.ParameterToString(qtdOperacoesGratuitasSemana)); // query parameter
            if (qtdOperacoesGratuitasMes != null) localVarQueryParams.Add("qtdOperacoesGratuitasMes", Configuration.ApiClient.ParameterToString(qtdOperacoesGratuitasMes)); // query parameter
            if (valorTAC != null) localVarQueryParams.Add("valorTAC", Configuration.ApiClient.ParameterToString(valorTAC)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarParametrosAcumuladoresConta: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarParametrosAcumuladoresConta: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageParametroAcumuladorContaOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageParametroAcumuladorContaOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageParametroAcumuladorContaOperacaoResponse)));
            
        }
        
        /// <summary>
        /// Listar par\u00E2metros acumuladores de produtos e opera\u00E7\u00F5es Este recurso permite listar par\u00E2metros acumuladores de produtos e opera\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto (optional)</param> 
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o (optional)</param> 
        /// <param name="qtdMaxDia">Quantidade m\u00E1xima de opera\u00E7\u00F5es por dia (optional)</param> 
        /// <param name="qtdMaxSemana">Quantidade m\u00E1xima de opera\u00E7\u00F5es por semana (optional)</param> 
        /// <param name="qtdMaxMes">Quantidade m\u00E1xima de opera\u00E7\u00F5es por m\u00EAs (optional)</param> 
        /// <param name="valorMaxDia">Valor m\u00E1ximo de opera\u00E7\u00F5es por dia (optional)</param> 
        /// <param name="valorMaxSemana">Valor m\u00E1ximo de opera\u00E7\u00F5es por semana (optional)</param> 
        /// <param name="valorMaxMes">Valor m\u00E1ximo de opera\u00E7\u00F5es por m\u00EAs (optional)</param> 
        /// <param name="qtdOperacoesGratuitasDia">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por dia (optional)</param> 
        /// <param name="qtdOperacoesGratuitasSemana">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por semana (optional)</param> 
        /// <param name="qtdOperacoesGratuitasMes">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por m\u00EAs (optional)</param> 
        /// <param name="valorTAC">Valor da taxa de abertura de cr\u00E9dito (TAC) (optional)</param> 
        /// <returns>PageParametroAcumuladorProdutoOperacaoResponse</returns>
        public PageParametroAcumuladorProdutoOperacaoResponse ListarParametrosAcumuladoresProduto (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? qtdMaxDia = null, int? qtdMaxSemana = null, int? qtdMaxMes = null, double? valorMaxDia = null, double? valorMaxSemana = null, double? valorMaxMes = null, int? qtdOperacoesGratuitasDia = null, int? qtdOperacoesGratuitasSemana = null, int? qtdOperacoesGratuitasMes = null, double? valorTAC = null)
        {
             ApiResponse<PageParametroAcumuladorProdutoOperacaoResponse> localVarResponse = ListarParametrosAcumuladoresProdutoWithHttpInfo(sort, page, limit, idProduto, idOperacao, qtdMaxDia, qtdMaxSemana, qtdMaxMes, valorMaxDia, valorMaxSemana, valorMaxMes, qtdOperacoesGratuitasDia, qtdOperacoesGratuitasSemana, qtdOperacoesGratuitasMes, valorTAC);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar par\u00E2metros acumuladores de produtos e opera\u00E7\u00F5es Este recurso permite listar par\u00E2metros acumuladores de produtos e opera\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto (optional)</param> 
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o (optional)</param> 
        /// <param name="qtdMaxDia">Quantidade m\u00E1xima de opera\u00E7\u00F5es por dia (optional)</param> 
        /// <param name="qtdMaxSemana">Quantidade m\u00E1xima de opera\u00E7\u00F5es por semana (optional)</param> 
        /// <param name="qtdMaxMes">Quantidade m\u00E1xima de opera\u00E7\u00F5es por m\u00EAs (optional)</param> 
        /// <param name="valorMaxDia">Valor m\u00E1ximo de opera\u00E7\u00F5es por dia (optional)</param> 
        /// <param name="valorMaxSemana">Valor m\u00E1ximo de opera\u00E7\u00F5es por semana (optional)</param> 
        /// <param name="valorMaxMes">Valor m\u00E1ximo de opera\u00E7\u00F5es por m\u00EAs (optional)</param> 
        /// <param name="qtdOperacoesGratuitasDia">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por dia (optional)</param> 
        /// <param name="qtdOperacoesGratuitasSemana">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por semana (optional)</param> 
        /// <param name="qtdOperacoesGratuitasMes">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por m\u00EAs (optional)</param> 
        /// <param name="valorTAC">Valor da taxa de abertura de cr\u00E9dito (TAC) (optional)</param> 
        /// <returns>ApiResponse of PageParametroAcumuladorProdutoOperacaoResponse</returns>
        public ApiResponse< PageParametroAcumuladorProdutoOperacaoResponse > ListarParametrosAcumuladoresProdutoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? qtdMaxDia = null, int? qtdMaxSemana = null, int? qtdMaxMes = null, double? valorMaxDia = null, double? valorMaxSemana = null, double? valorMaxMes = null, int? qtdOperacoesGratuitasDia = null, int? qtdOperacoesGratuitasSemana = null, int? qtdOperacoesGratuitasMes = null, double? valorTAC = null)
        {
            
    
            var localVarPath = "/api/produtos/configuracoes/acumuladores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idOperacao != null) localVarQueryParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // query parameter
            if (qtdMaxDia != null) localVarQueryParams.Add("qtdMaxDia", Configuration.ApiClient.ParameterToString(qtdMaxDia)); // query parameter
            if (qtdMaxSemana != null) localVarQueryParams.Add("qtdMaxSemana", Configuration.ApiClient.ParameterToString(qtdMaxSemana)); // query parameter
            if (qtdMaxMes != null) localVarQueryParams.Add("qtdMaxMes", Configuration.ApiClient.ParameterToString(qtdMaxMes)); // query parameter
            if (valorMaxDia != null) localVarQueryParams.Add("valorMaxDia", Configuration.ApiClient.ParameterToString(valorMaxDia)); // query parameter
            if (valorMaxSemana != null) localVarQueryParams.Add("valorMaxSemana", Configuration.ApiClient.ParameterToString(valorMaxSemana)); // query parameter
            if (valorMaxMes != null) localVarQueryParams.Add("valorMaxMes", Configuration.ApiClient.ParameterToString(valorMaxMes)); // query parameter
            if (qtdOperacoesGratuitasDia != null) localVarQueryParams.Add("qtdOperacoesGratuitasDia", Configuration.ApiClient.ParameterToString(qtdOperacoesGratuitasDia)); // query parameter
            if (qtdOperacoesGratuitasSemana != null) localVarQueryParams.Add("qtdOperacoesGratuitasSemana", Configuration.ApiClient.ParameterToString(qtdOperacoesGratuitasSemana)); // query parameter
            if (qtdOperacoesGratuitasMes != null) localVarQueryParams.Add("qtdOperacoesGratuitasMes", Configuration.ApiClient.ParameterToString(qtdOperacoesGratuitasMes)); // query parameter
            if (valorTAC != null) localVarQueryParams.Add("valorTAC", Configuration.ApiClient.ParameterToString(valorTAC)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarParametrosAcumuladoresProduto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarParametrosAcumuladoresProduto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageParametroAcumuladorProdutoOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageParametroAcumuladorProdutoOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageParametroAcumuladorProdutoOperacaoResponse)));
            
        }

        
        /// <summary>
        /// Listar par\u00E2metros acumuladores de produtos e opera\u00E7\u00F5es Este recurso permite listar par\u00E2metros acumuladores de produtos e opera\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto (optional)</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o (optional)</param>
        /// <param name="qtdMaxDia">Quantidade m\u00E1xima de opera\u00E7\u00F5es por dia (optional)</param>
        /// <param name="qtdMaxSemana">Quantidade m\u00E1xima de opera\u00E7\u00F5es por semana (optional)</param>
        /// <param name="qtdMaxMes">Quantidade m\u00E1xima de opera\u00E7\u00F5es por m\u00EAs (optional)</param>
        /// <param name="valorMaxDia">Valor m\u00E1ximo de opera\u00E7\u00F5es por dia (optional)</param>
        /// <param name="valorMaxSemana">Valor m\u00E1ximo de opera\u00E7\u00F5es por semana (optional)</param>
        /// <param name="valorMaxMes">Valor m\u00E1ximo de opera\u00E7\u00F5es por m\u00EAs (optional)</param>
        /// <param name="qtdOperacoesGratuitasDia">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por dia (optional)</param>
        /// <param name="qtdOperacoesGratuitasSemana">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por semana (optional)</param>
        /// <param name="qtdOperacoesGratuitasMes">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por m\u00EAs (optional)</param>
        /// <param name="valorTAC">Valor da taxa de abertura de cr\u00E9dito (TAC) (optional)</param>
        /// <returns>Task of PageParametroAcumuladorProdutoOperacaoResponse</returns>
        public async System.Threading.Tasks.Task<PageParametroAcumuladorProdutoOperacaoResponse> ListarParametrosAcumuladoresProdutoAsync (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? qtdMaxDia = null, int? qtdMaxSemana = null, int? qtdMaxMes = null, double? valorMaxDia = null, double? valorMaxSemana = null, double? valorMaxMes = null, int? qtdOperacoesGratuitasDia = null, int? qtdOperacoesGratuitasSemana = null, int? qtdOperacoesGratuitasMes = null, double? valorTAC = null)
        {
             ApiResponse<PageParametroAcumuladorProdutoOperacaoResponse> localVarResponse = await ListarParametrosAcumuladoresProdutoAsyncWithHttpInfo(sort, page, limit, idProduto, idOperacao, qtdMaxDia, qtdMaxSemana, qtdMaxMes, valorMaxDia, valorMaxSemana, valorMaxMes, qtdOperacoesGratuitasDia, qtdOperacoesGratuitasSemana, qtdOperacoesGratuitasMes, valorTAC);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar par\u00E2metros acumuladores de produtos e opera\u00E7\u00F5es Este recurso permite listar par\u00E2metros acumuladores de produtos e opera\u00E7\u00F5es
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idProduto">C\u00F3digo de identifica\u00E7\u00E3o do produto (optional)</param>
        /// <param name="idOperacao">C\u00F3digo de identifica\u00E7\u00E3o da opera\u00E7\u00E3o (optional)</param>
        /// <param name="qtdMaxDia">Quantidade m\u00E1xima de opera\u00E7\u00F5es por dia (optional)</param>
        /// <param name="qtdMaxSemana">Quantidade m\u00E1xima de opera\u00E7\u00F5es por semana (optional)</param>
        /// <param name="qtdMaxMes">Quantidade m\u00E1xima de opera\u00E7\u00F5es por m\u00EAs (optional)</param>
        /// <param name="valorMaxDia">Valor m\u00E1ximo de opera\u00E7\u00F5es por dia (optional)</param>
        /// <param name="valorMaxSemana">Valor m\u00E1ximo de opera\u00E7\u00F5es por semana (optional)</param>
        /// <param name="valorMaxMes">Valor m\u00E1ximo de opera\u00E7\u00F5es por m\u00EAs (optional)</param>
        /// <param name="qtdOperacoesGratuitasDia">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por dia (optional)</param>
        /// <param name="qtdOperacoesGratuitasSemana">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por semana (optional)</param>
        /// <param name="qtdOperacoesGratuitasMes">Quantidade de opera\u00E7\u00F5es gratuitas permitidas por m\u00EAs (optional)</param>
        /// <param name="valorTAC">Valor da taxa de abertura de cr\u00E9dito (TAC) (optional)</param>
        /// <returns>Task of ApiResponse (PageParametroAcumuladorProdutoOperacaoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageParametroAcumuladorProdutoOperacaoResponse>> ListarParametrosAcumuladoresProdutoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idProduto = null, long? idOperacao = null, int? qtdMaxDia = null, int? qtdMaxSemana = null, int? qtdMaxMes = null, double? valorMaxDia = null, double? valorMaxSemana = null, double? valorMaxMes = null, int? qtdOperacoesGratuitasDia = null, int? qtdOperacoesGratuitasSemana = null, int? qtdOperacoesGratuitasMes = null, double? valorTAC = null)
        {
            
    
            var localVarPath = "/api/produtos/configuracoes/acumuladores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idOperacao != null) localVarQueryParams.Add("idOperacao", Configuration.ApiClient.ParameterToString(idOperacao)); // query parameter
            if (qtdMaxDia != null) localVarQueryParams.Add("qtdMaxDia", Configuration.ApiClient.ParameterToString(qtdMaxDia)); // query parameter
            if (qtdMaxSemana != null) localVarQueryParams.Add("qtdMaxSemana", Configuration.ApiClient.ParameterToString(qtdMaxSemana)); // query parameter
            if (qtdMaxMes != null) localVarQueryParams.Add("qtdMaxMes", Configuration.ApiClient.ParameterToString(qtdMaxMes)); // query parameter
            if (valorMaxDia != null) localVarQueryParams.Add("valorMaxDia", Configuration.ApiClient.ParameterToString(valorMaxDia)); // query parameter
            if (valorMaxSemana != null) localVarQueryParams.Add("valorMaxSemana", Configuration.ApiClient.ParameterToString(valorMaxSemana)); // query parameter
            if (valorMaxMes != null) localVarQueryParams.Add("valorMaxMes", Configuration.ApiClient.ParameterToString(valorMaxMes)); // query parameter
            if (qtdOperacoesGratuitasDia != null) localVarQueryParams.Add("qtdOperacoesGratuitasDia", Configuration.ApiClient.ParameterToString(qtdOperacoesGratuitasDia)); // query parameter
            if (qtdOperacoesGratuitasSemana != null) localVarQueryParams.Add("qtdOperacoesGratuitasSemana", Configuration.ApiClient.ParameterToString(qtdOperacoesGratuitasSemana)); // query parameter
            if (qtdOperacoesGratuitasMes != null) localVarQueryParams.Add("qtdOperacoesGratuitasMes", Configuration.ApiClient.ParameterToString(qtdOperacoesGratuitasMes)); // query parameter
            if (valorTAC != null) localVarQueryParams.Add("valorTAC", Configuration.ApiClient.ParameterToString(valorTAC)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarParametrosAcumuladoresProduto: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarParametrosAcumuladoresProduto: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageParametroAcumuladorProdutoOperacaoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageParametroAcumuladorProdutoOperacaoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageParametroAcumuladorProdutoOperacaoResponse)));
            
        }
        
    }
    
}
