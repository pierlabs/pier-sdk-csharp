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
    public interface IEstabelecimentoApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Apresenta os dados de um determinado Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Terminal a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id).</param>
        /// <returns>TerminalResponse</returns>
        TerminalResponse ConsultarUsingGET18 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Terminal a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id).</param>
        /// <returns>ApiResponse of TerminalResponse</returns>
        ApiResponse<TerminalResponse> ConsultarUsingGET18WithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar estabelecimento por id
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de um determinado estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>EstabelecimentoResponse</returns>
        EstabelecimentoResponse ConsultarUsingGET8 (long? id);
  
        /// <summary>
        /// Consultar estabelecimento por id
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de um determinado estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>ApiResponse of EstabelecimentoResponse</returns>
        ApiResponse<EstabelecimentoResponse> ConsultarUsingGET8WithHttpInfo (long? id);
        
        /// <summary>
        /// Lista Estabelecimentos
        /// </summary>
        /// <remarks>
        /// Lista todas os Estabelecimentos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id). (optional)</param>
        /// <param name="numeroReceitaFederal">Apresenta o n\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Receita Federal. (optional)</param>
        /// <param name="nome">Nome do Estabelecimento. (optional)</param>
        /// <param name="descricao">Raz\u00C3\u00A3o Social do Estabelecimento. (optional)</param>
        /// <param name="nomeFantasia">T\u00C3\u00ADtulo Comercial do Estabelecimento. (optional)</param>
        /// <param name="cep">C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP). (optional)</param>
        /// <param name="nomeLogradouro">Nome do Logradouro. (optional)</param>
        /// <param name="numeroEndereco">N\u00C3\u00BAmero do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="complemento">Descri\u00C3\u00A7\u00C3\u00B5es complementares referente ao endere\u00C3\u00A7o. (optional)</param>
        /// <param name="bairro">Nome do bairro do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="cidade">Nome da cidade do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="uf">Sigla de identifica\u00C3\u00A7\u00C3\u00A3o da Unidade Federativa do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="pais">Nome do pa\u00C3\u00ADs. (optional)</param>
        /// <param name="dataCadastramento">Data de Cadastro do Estabelecimento, no formato yyyy-MM-dd. (optional)</param>
        /// <param name="contato">Nome da pessoa para contato com o Estabelecimento. (optional)</param>
        /// <param name="email">E-mail da pessoa para contato com o Estabelecimento. (optional)</param>
        /// <param name="flagArquivoSecrFazenda">Indica se o estabelecimento ser\u00C3\u00A1 inclu\u00C3\u00ADdo no arquivo de registro para a Secretaria da Fazenda Estadual. (optional)</param>
        /// <param name="flagCartaoDigitado">Indica se o estabelecimento poder\u00C3\u00A1 originar transa\u00C3\u00A7\u00C3\u00B5es sem a leitura da tarja ou do chip do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="inativo">Indica se o estabelecimento est\u00C3\u00A1 inativo. (optional)</param>
        /// <returns>PageEstabelecimentoResponse</returns>
        PageEstabelecimentoResponse ListarUsingGET11 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, long? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null);
  
        /// <summary>
        /// Lista Estabelecimentos
        /// </summary>
        /// <remarks>
        /// Lista todas os Estabelecimentos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id). (optional)</param>
        /// <param name="numeroReceitaFederal">Apresenta o n\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Receita Federal. (optional)</param>
        /// <param name="nome">Nome do Estabelecimento. (optional)</param>
        /// <param name="descricao">Raz\u00C3\u00A3o Social do Estabelecimento. (optional)</param>
        /// <param name="nomeFantasia">T\u00C3\u00ADtulo Comercial do Estabelecimento. (optional)</param>
        /// <param name="cep">C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP). (optional)</param>
        /// <param name="nomeLogradouro">Nome do Logradouro. (optional)</param>
        /// <param name="numeroEndereco">N\u00C3\u00BAmero do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="complemento">Descri\u00C3\u00A7\u00C3\u00B5es complementares referente ao endere\u00C3\u00A7o. (optional)</param>
        /// <param name="bairro">Nome do bairro do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="cidade">Nome da cidade do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="uf">Sigla de identifica\u00C3\u00A7\u00C3\u00A3o da Unidade Federativa do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="pais">Nome do pa\u00C3\u00ADs. (optional)</param>
        /// <param name="dataCadastramento">Data de Cadastro do Estabelecimento, no formato yyyy-MM-dd. (optional)</param>
        /// <param name="contato">Nome da pessoa para contato com o Estabelecimento. (optional)</param>
        /// <param name="email">E-mail da pessoa para contato com o Estabelecimento. (optional)</param>
        /// <param name="flagArquivoSecrFazenda">Indica se o estabelecimento ser\u00C3\u00A1 inclu\u00C3\u00ADdo no arquivo de registro para a Secretaria da Fazenda Estadual. (optional)</param>
        /// <param name="flagCartaoDigitado">Indica se o estabelecimento poder\u00C3\u00A1 originar transa\u00C3\u00A7\u00C3\u00B5es sem a leitura da tarja ou do chip do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="inativo">Indica se o estabelecimento est\u00C3\u00A1 inativo. (optional)</param>
        /// <returns>ApiResponse of PageEstabelecimentoResponse</returns>
        ApiResponse<PageEstabelecimentoResponse> ListarUsingGET11WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, long? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null);
        
        /// <summary>
        /// Lista os Terminais cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os terminais existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id). (optional)</param>
        /// <param name="terminal">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do terminal. (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00C3\u00BAmero do estabelecimento a qual o terminal pertence. (optional)</param>
        /// <param name="idEstabelecimento">N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento a qual o terminal pertence. (optional)</param>
        /// <returns>PageTerminalResponse</returns>
        PageTerminalResponse ListarUsingGET25 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null);
  
        /// <summary>
        /// Lista os Terminais cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os terminais existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id). (optional)</param>
        /// <param name="terminal">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do terminal. (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00C3\u00BAmero do estabelecimento a qual o terminal pertence. (optional)</param>
        /// <param name="idEstabelecimento">N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento a qual o terminal pertence. (optional)</param>
        /// <returns>ApiResponse of PageTerminalResponse</returns>
        ApiResponse<PageTerminalResponse> ListarUsingGET25WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Apresenta os dados de um determinado Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Terminal a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id).</param>
        /// <returns>Task of TerminalResponse</returns>
        System.Threading.Tasks.Task<TerminalResponse> ConsultarUsingGET18Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Terminal a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id).</param>
        /// <returns>Task of ApiResponse (TerminalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TerminalResponse>> ConsultarUsingGET18AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar estabelecimento por id
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de um determinado estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of EstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<EstabelecimentoResponse> ConsultarUsingGET8Async (long? id);

        /// <summary>
        /// Consultar estabelecimento por id
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de um determinado estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (EstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EstabelecimentoResponse>> ConsultarUsingGET8AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista Estabelecimentos
        /// </summary>
        /// <remarks>
        /// Lista todas os Estabelecimentos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id). (optional)</param>
        /// <param name="numeroReceitaFederal">Apresenta o n\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Receita Federal. (optional)</param>
        /// <param name="nome">Nome do Estabelecimento. (optional)</param>
        /// <param name="descricao">Raz\u00C3\u00A3o Social do Estabelecimento. (optional)</param>
        /// <param name="nomeFantasia">T\u00C3\u00ADtulo Comercial do Estabelecimento. (optional)</param>
        /// <param name="cep">C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP). (optional)</param>
        /// <param name="nomeLogradouro">Nome do Logradouro. (optional)</param>
        /// <param name="numeroEndereco">N\u00C3\u00BAmero do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="complemento">Descri\u00C3\u00A7\u00C3\u00B5es complementares referente ao endere\u00C3\u00A7o. (optional)</param>
        /// <param name="bairro">Nome do bairro do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="cidade">Nome da cidade do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="uf">Sigla de identifica\u00C3\u00A7\u00C3\u00A3o da Unidade Federativa do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="pais">Nome do pa\u00C3\u00ADs. (optional)</param>
        /// <param name="dataCadastramento">Data de Cadastro do Estabelecimento, no formato yyyy-MM-dd. (optional)</param>
        /// <param name="contato">Nome da pessoa para contato com o Estabelecimento. (optional)</param>
        /// <param name="email">E-mail da pessoa para contato com o Estabelecimento. (optional)</param>
        /// <param name="flagArquivoSecrFazenda">Indica se o estabelecimento ser\u00C3\u00A1 inclu\u00C3\u00ADdo no arquivo de registro para a Secretaria da Fazenda Estadual. (optional)</param>
        /// <param name="flagCartaoDigitado">Indica se o estabelecimento poder\u00C3\u00A1 originar transa\u00C3\u00A7\u00C3\u00B5es sem a leitura da tarja ou do chip do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="inativo">Indica se o estabelecimento est\u00C3\u00A1 inativo. (optional)</param>
        /// <returns>Task of PageEstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<PageEstabelecimentoResponse> ListarUsingGET11Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, long? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null);

        /// <summary>
        /// Lista Estabelecimentos
        /// </summary>
        /// <remarks>
        /// Lista todas os Estabelecimentos
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id). (optional)</param>
        /// <param name="numeroReceitaFederal">Apresenta o n\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Receita Federal. (optional)</param>
        /// <param name="nome">Nome do Estabelecimento. (optional)</param>
        /// <param name="descricao">Raz\u00C3\u00A3o Social do Estabelecimento. (optional)</param>
        /// <param name="nomeFantasia">T\u00C3\u00ADtulo Comercial do Estabelecimento. (optional)</param>
        /// <param name="cep">C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP). (optional)</param>
        /// <param name="nomeLogradouro">Nome do Logradouro. (optional)</param>
        /// <param name="numeroEndereco">N\u00C3\u00BAmero do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="complemento">Descri\u00C3\u00A7\u00C3\u00B5es complementares referente ao endere\u00C3\u00A7o. (optional)</param>
        /// <param name="bairro">Nome do bairro do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="cidade">Nome da cidade do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="uf">Sigla de identifica\u00C3\u00A7\u00C3\u00A3o da Unidade Federativa do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="pais">Nome do pa\u00C3\u00ADs. (optional)</param>
        /// <param name="dataCadastramento">Data de Cadastro do Estabelecimento, no formato yyyy-MM-dd. (optional)</param>
        /// <param name="contato">Nome da pessoa para contato com o Estabelecimento. (optional)</param>
        /// <param name="email">E-mail da pessoa para contato com o Estabelecimento. (optional)</param>
        /// <param name="flagArquivoSecrFazenda">Indica se o estabelecimento ser\u00C3\u00A1 inclu\u00C3\u00ADdo no arquivo de registro para a Secretaria da Fazenda Estadual. (optional)</param>
        /// <param name="flagCartaoDigitado">Indica se o estabelecimento poder\u00C3\u00A1 originar transa\u00C3\u00A7\u00C3\u00B5es sem a leitura da tarja ou do chip do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="inativo">Indica se o estabelecimento est\u00C3\u00A1 inativo. (optional)</param>
        /// <returns>Task of ApiResponse (PageEstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageEstabelecimentoResponse>> ListarUsingGET11AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, long? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null);
        
        /// <summary>
        /// Lista os Terminais cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os terminais existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id). (optional)</param>
        /// <param name="terminal">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do terminal. (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00C3\u00BAmero do estabelecimento a qual o terminal pertence. (optional)</param>
        /// <param name="idEstabelecimento">N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento a qual o terminal pertence. (optional)</param>
        /// <returns>Task of PageTerminalResponse</returns>
        System.Threading.Tasks.Task<PageTerminalResponse> ListarUsingGET25Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null);

        /// <summary>
        /// Lista os Terminais cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os terminais existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id). (optional)</param>
        /// <param name="terminal">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do terminal. (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00C3\u00BAmero do estabelecimento a qual o terminal pertence. (optional)</param>
        /// <param name="idEstabelecimento">N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento a qual o terminal pertence. (optional)</param>
        /// <returns>Task of ApiResponse (PageTerminalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTerminalResponse>> ListarUsingGET25AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EstabelecimentoApi : IEstabelecimentoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EstabelecimentoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EstabelecimentoApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EstabelecimentoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EstabelecimentoApi(Configuration configuration = null)
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
        /// Apresenta os dados de um determinado Terminal Este m\u00C3\u00A9todo permite consultar um determinado Terminal a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id).</param> 
        /// <returns>TerminalResponse</returns>
        public TerminalResponse ConsultarUsingGET18 (long? id)
        {
             ApiResponse<TerminalResponse> localVarResponse = ConsultarUsingGET18WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Terminal Este m\u00C3\u00A9todo permite consultar um determinado Terminal a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id).</param> 
        /// <returns>ApiResponse of TerminalResponse</returns>
        public ApiResponse< TerminalResponse > ConsultarUsingGET18WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->ConsultarUsingGET18");
            
    
            var localVarPath = "/api/terminais/{id}";
    
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET18: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET18: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TerminalResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Terminal Este m\u00C3\u00A9todo permite consultar um determinado Terminal a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id).</param>
        /// <returns>Task of TerminalResponse</returns>
        public async System.Threading.Tasks.Task<TerminalResponse> ConsultarUsingGET18Async (long? id)
        {
             ApiResponse<TerminalResponse> localVarResponse = await ConsultarUsingGET18AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Terminal Este m\u00C3\u00A9todo permite consultar um determinado Terminal a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id).</param>
        /// <returns>Task of ApiResponse (TerminalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TerminalResponse>> ConsultarUsingGET18AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET18");
            
    
            var localVarPath = "/api/terminais/{id}";
    
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET18: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET18: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TerminalResponse)));
            
        }
        
        /// <summary>
        /// Consultar estabelecimento por id Consulta os detalhes de um determinado estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>EstabelecimentoResponse</returns>
        public EstabelecimentoResponse ConsultarUsingGET8 (long? id)
        {
             ApiResponse<EstabelecimentoResponse> localVarResponse = ConsultarUsingGET8WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar estabelecimento por id Consulta os detalhes de um determinado estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>ApiResponse of EstabelecimentoResponse</returns>
        public ApiResponse< EstabelecimentoResponse > ConsultarUsingGET8WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->ConsultarUsingGET8");
            
    
            var localVarPath = "/api/estabelecimentos/{id}";
    
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET8: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET8: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstabelecimentoResponse)));
            
        }

        
        /// <summary>
        /// Consultar estabelecimento por id Consulta os detalhes de um determinado estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of EstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<EstabelecimentoResponse> ConsultarUsingGET8Async (long? id)
        {
             ApiResponse<EstabelecimentoResponse> localVarResponse = await ConsultarUsingGET8AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar estabelecimento por id Consulta os detalhes de um determinado estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (EstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EstabelecimentoResponse>> ConsultarUsingGET8AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET8");
            
    
            var localVarPath = "/api/estabelecimentos/{id}";
    
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET8: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET8: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// Lista Estabelecimentos Lista todas os Estabelecimentos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id). (optional)</param> 
        /// <param name="numeroReceitaFederal">Apresenta o n\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Receita Federal. (optional)</param> 
        /// <param name="nome">Nome do Estabelecimento. (optional)</param> 
        /// <param name="descricao">Raz\u00C3\u00A3o Social do Estabelecimento. (optional)</param> 
        /// <param name="nomeFantasia">T\u00C3\u00ADtulo Comercial do Estabelecimento. (optional)</param> 
        /// <param name="cep">C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP). (optional)</param> 
        /// <param name="nomeLogradouro">Nome do Logradouro. (optional)</param> 
        /// <param name="numeroEndereco">N\u00C3\u00BAmero do endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="complemento">Descri\u00C3\u00A7\u00C3\u00B5es complementares referente ao endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="bairro">Nome do bairro do endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="cidade">Nome da cidade do endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="uf">Sigla de identifica\u00C3\u00A7\u00C3\u00A3o da Unidade Federativa do endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="pais">Nome do pa\u00C3\u00ADs. (optional)</param> 
        /// <param name="dataCadastramento">Data de Cadastro do Estabelecimento, no formato yyyy-MM-dd. (optional)</param> 
        /// <param name="contato">Nome da pessoa para contato com o Estabelecimento. (optional)</param> 
        /// <param name="email">E-mail da pessoa para contato com o Estabelecimento. (optional)</param> 
        /// <param name="flagArquivoSecrFazenda">Indica se o estabelecimento ser\u00C3\u00A1 inclu\u00C3\u00ADdo no arquivo de registro para a Secretaria da Fazenda Estadual. (optional)</param> 
        /// <param name="flagCartaoDigitado">Indica se o estabelecimento poder\u00C3\u00A1 originar transa\u00C3\u00A7\u00C3\u00B5es sem a leitura da tarja ou do chip do cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="inativo">Indica se o estabelecimento est\u00C3\u00A1 inativo. (optional)</param> 
        /// <returns>PageEstabelecimentoResponse</returns>
        public PageEstabelecimentoResponse ListarUsingGET11 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, long? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null)
        {
             ApiResponse<PageEstabelecimentoResponse> localVarResponse = ListarUsingGET11WithHttpInfo(sort, page, limit, id, numeroReceitaFederal, nome, descricao, nomeFantasia, cep, nomeLogradouro, numeroEndereco, complemento, bairro, cidade, uf, pais, dataCadastramento, contato, email, flagArquivoSecrFazenda, flagCartaoDigitado, inativo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista Estabelecimentos Lista todas os Estabelecimentos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id). (optional)</param> 
        /// <param name="numeroReceitaFederal">Apresenta o n\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Receita Federal. (optional)</param> 
        /// <param name="nome">Nome do Estabelecimento. (optional)</param> 
        /// <param name="descricao">Raz\u00C3\u00A3o Social do Estabelecimento. (optional)</param> 
        /// <param name="nomeFantasia">T\u00C3\u00ADtulo Comercial do Estabelecimento. (optional)</param> 
        /// <param name="cep">C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP). (optional)</param> 
        /// <param name="nomeLogradouro">Nome do Logradouro. (optional)</param> 
        /// <param name="numeroEndereco">N\u00C3\u00BAmero do endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="complemento">Descri\u00C3\u00A7\u00C3\u00B5es complementares referente ao endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="bairro">Nome do bairro do endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="cidade">Nome da cidade do endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="uf">Sigla de identifica\u00C3\u00A7\u00C3\u00A3o da Unidade Federativa do endere\u00C3\u00A7o. (optional)</param> 
        /// <param name="pais">Nome do pa\u00C3\u00ADs. (optional)</param> 
        /// <param name="dataCadastramento">Data de Cadastro do Estabelecimento, no formato yyyy-MM-dd. (optional)</param> 
        /// <param name="contato">Nome da pessoa para contato com o Estabelecimento. (optional)</param> 
        /// <param name="email">E-mail da pessoa para contato com o Estabelecimento. (optional)</param> 
        /// <param name="flagArquivoSecrFazenda">Indica se o estabelecimento ser\u00C3\u00A1 inclu\u00C3\u00ADdo no arquivo de registro para a Secretaria da Fazenda Estadual. (optional)</param> 
        /// <param name="flagCartaoDigitado">Indica se o estabelecimento poder\u00C3\u00A1 originar transa\u00C3\u00A7\u00C3\u00B5es sem a leitura da tarja ou do chip do cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="inativo">Indica se o estabelecimento est\u00C3\u00A1 inativo. (optional)</param> 
        /// <returns>ApiResponse of PageEstabelecimentoResponse</returns>
        public ApiResponse< PageEstabelecimentoResponse > ListarUsingGET11WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, long? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null)
        {
            
    
            var localVarPath = "/api/estabelecimentos";
    
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (nomeFantasia != null) localVarQueryParams.Add("nomeFantasia", Configuration.ApiClient.ParameterToString(nomeFantasia)); // query parameter
            if (cep != null) localVarQueryParams.Add("cep", Configuration.ApiClient.ParameterToString(cep)); // query parameter
            if (nomeLogradouro != null) localVarQueryParams.Add("nomeLogradouro", Configuration.ApiClient.ParameterToString(nomeLogradouro)); // query parameter
            if (numeroEndereco != null) localVarQueryParams.Add("numeroEndereco", Configuration.ApiClient.ParameterToString(numeroEndereco)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            if (bairro != null) localVarQueryParams.Add("bairro", Configuration.ApiClient.ParameterToString(bairro)); // query parameter
            if (cidade != null) localVarQueryParams.Add("cidade", Configuration.ApiClient.ParameterToString(cidade)); // query parameter
            if (uf != null) localVarQueryParams.Add("uf", Configuration.ApiClient.ParameterToString(uf)); // query parameter
            if (pais != null) localVarQueryParams.Add("pais", Configuration.ApiClient.ParameterToString(pais)); // query parameter
            if (dataCadastramento != null) localVarQueryParams.Add("dataCadastramento", Configuration.ApiClient.ParameterToString(dataCadastramento)); // query parameter
            if (contato != null) localVarQueryParams.Add("contato", Configuration.ApiClient.ParameterToString(contato)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (flagArquivoSecrFazenda != null) localVarQueryParams.Add("flagArquivoSecrFazenda", Configuration.ApiClient.ParameterToString(flagArquivoSecrFazenda)); // query parameter
            if (flagCartaoDigitado != null) localVarQueryParams.Add("flagCartaoDigitado", Configuration.ApiClient.ParameterToString(flagCartaoDigitado)); // query parameter
            if (inativo != null) localVarQueryParams.Add("inativo", Configuration.ApiClient.ParameterToString(inativo)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET11: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET11: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEstabelecimentoResponse)));
            
        }

        
        /// <summary>
        /// Lista Estabelecimentos Lista todas os Estabelecimentos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id). (optional)</param>
        /// <param name="numeroReceitaFederal">Apresenta o n\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Receita Federal. (optional)</param>
        /// <param name="nome">Nome do Estabelecimento. (optional)</param>
        /// <param name="descricao">Raz\u00C3\u00A3o Social do Estabelecimento. (optional)</param>
        /// <param name="nomeFantasia">T\u00C3\u00ADtulo Comercial do Estabelecimento. (optional)</param>
        /// <param name="cep">C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP). (optional)</param>
        /// <param name="nomeLogradouro">Nome do Logradouro. (optional)</param>
        /// <param name="numeroEndereco">N\u00C3\u00BAmero do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="complemento">Descri\u00C3\u00A7\u00C3\u00B5es complementares referente ao endere\u00C3\u00A7o. (optional)</param>
        /// <param name="bairro">Nome do bairro do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="cidade">Nome da cidade do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="uf">Sigla de identifica\u00C3\u00A7\u00C3\u00A3o da Unidade Federativa do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="pais">Nome do pa\u00C3\u00ADs. (optional)</param>
        /// <param name="dataCadastramento">Data de Cadastro do Estabelecimento, no formato yyyy-MM-dd. (optional)</param>
        /// <param name="contato">Nome da pessoa para contato com o Estabelecimento. (optional)</param>
        /// <param name="email">E-mail da pessoa para contato com o Estabelecimento. (optional)</param>
        /// <param name="flagArquivoSecrFazenda">Indica se o estabelecimento ser\u00C3\u00A1 inclu\u00C3\u00ADdo no arquivo de registro para a Secretaria da Fazenda Estadual. (optional)</param>
        /// <param name="flagCartaoDigitado">Indica se o estabelecimento poder\u00C3\u00A1 originar transa\u00C3\u00A7\u00C3\u00B5es sem a leitura da tarja ou do chip do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="inativo">Indica se o estabelecimento est\u00C3\u00A1 inativo. (optional)</param>
        /// <returns>Task of PageEstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<PageEstabelecimentoResponse> ListarUsingGET11Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, long? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null)
        {
             ApiResponse<PageEstabelecimentoResponse> localVarResponse = await ListarUsingGET11AsyncWithHttpInfo(sort, page, limit, id, numeroReceitaFederal, nome, descricao, nomeFantasia, cep, nomeLogradouro, numeroEndereco, complemento, bairro, cidade, uf, pais, dataCadastramento, contato, email, flagArquivoSecrFazenda, flagCartaoDigitado, inativo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista Estabelecimentos Lista todas os Estabelecimentos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id). (optional)</param>
        /// <param name="numeroReceitaFederal">Apresenta o n\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do Estabelecimento na Receita Federal. (optional)</param>
        /// <param name="nome">Nome do Estabelecimento. (optional)</param>
        /// <param name="descricao">Raz\u00C3\u00A3o Social do Estabelecimento. (optional)</param>
        /// <param name="nomeFantasia">T\u00C3\u00ADtulo Comercial do Estabelecimento. (optional)</param>
        /// <param name="cep">C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP). (optional)</param>
        /// <param name="nomeLogradouro">Nome do Logradouro. (optional)</param>
        /// <param name="numeroEndereco">N\u00C3\u00BAmero do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="complemento">Descri\u00C3\u00A7\u00C3\u00B5es complementares referente ao endere\u00C3\u00A7o. (optional)</param>
        /// <param name="bairro">Nome do bairro do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="cidade">Nome da cidade do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="uf">Sigla de identifica\u00C3\u00A7\u00C3\u00A3o da Unidade Federativa do endere\u00C3\u00A7o. (optional)</param>
        /// <param name="pais">Nome do pa\u00C3\u00ADs. (optional)</param>
        /// <param name="dataCadastramento">Data de Cadastro do Estabelecimento, no formato yyyy-MM-dd. (optional)</param>
        /// <param name="contato">Nome da pessoa para contato com o Estabelecimento. (optional)</param>
        /// <param name="email">E-mail da pessoa para contato com o Estabelecimento. (optional)</param>
        /// <param name="flagArquivoSecrFazenda">Indica se o estabelecimento ser\u00C3\u00A1 inclu\u00C3\u00ADdo no arquivo de registro para a Secretaria da Fazenda Estadual. (optional)</param>
        /// <param name="flagCartaoDigitado">Indica se o estabelecimento poder\u00C3\u00A1 originar transa\u00C3\u00A7\u00C3\u00B5es sem a leitura da tarja ou do chip do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="inativo">Indica se o estabelecimento est\u00C3\u00A1 inativo. (optional)</param>
        /// <returns>Task of ApiResponse (PageEstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageEstabelecimentoResponse>> ListarUsingGET11AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, long? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null)
        {
            
    
            var localVarPath = "/api/estabelecimentos";
    
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (descricao != null) localVarQueryParams.Add("descricao", Configuration.ApiClient.ParameterToString(descricao)); // query parameter
            if (nomeFantasia != null) localVarQueryParams.Add("nomeFantasia", Configuration.ApiClient.ParameterToString(nomeFantasia)); // query parameter
            if (cep != null) localVarQueryParams.Add("cep", Configuration.ApiClient.ParameterToString(cep)); // query parameter
            if (nomeLogradouro != null) localVarQueryParams.Add("nomeLogradouro", Configuration.ApiClient.ParameterToString(nomeLogradouro)); // query parameter
            if (numeroEndereco != null) localVarQueryParams.Add("numeroEndereco", Configuration.ApiClient.ParameterToString(numeroEndereco)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            if (bairro != null) localVarQueryParams.Add("bairro", Configuration.ApiClient.ParameterToString(bairro)); // query parameter
            if (cidade != null) localVarQueryParams.Add("cidade", Configuration.ApiClient.ParameterToString(cidade)); // query parameter
            if (uf != null) localVarQueryParams.Add("uf", Configuration.ApiClient.ParameterToString(uf)); // query parameter
            if (pais != null) localVarQueryParams.Add("pais", Configuration.ApiClient.ParameterToString(pais)); // query parameter
            if (dataCadastramento != null) localVarQueryParams.Add("dataCadastramento", Configuration.ApiClient.ParameterToString(dataCadastramento)); // query parameter
            if (contato != null) localVarQueryParams.Add("contato", Configuration.ApiClient.ParameterToString(contato)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (flagArquivoSecrFazenda != null) localVarQueryParams.Add("flagArquivoSecrFazenda", Configuration.ApiClient.ParameterToString(flagArquivoSecrFazenda)); // query parameter
            if (flagCartaoDigitado != null) localVarQueryParams.Add("flagCartaoDigitado", Configuration.ApiClient.ParameterToString(flagCartaoDigitado)); // query parameter
            if (inativo != null) localVarQueryParams.Add("inativo", Configuration.ApiClient.ParameterToString(inativo)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET11: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET11: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// Lista os Terminais cadastrados no Emissor Este m\u00C3\u00A9todo permite que sejam listados os terminais existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id). (optional)</param> 
        /// <param name="terminal">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do terminal. (optional)</param> 
        /// <param name="numeroEstabelecimento">N\u00C3\u00BAmero do estabelecimento a qual o terminal pertence. (optional)</param> 
        /// <param name="idEstabelecimento">N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento a qual o terminal pertence. (optional)</param> 
        /// <returns>PageTerminalResponse</returns>
        public PageTerminalResponse ListarUsingGET25 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null)
        {
             ApiResponse<PageTerminalResponse> localVarResponse = ListarUsingGET25WithHttpInfo(sort, page, limit, id, terminal, numeroEstabelecimento, idEstabelecimento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Terminais cadastrados no Emissor Este m\u00C3\u00A9todo permite que sejam listados os terminais existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id). (optional)</param> 
        /// <param name="terminal">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do terminal. (optional)</param> 
        /// <param name="numeroEstabelecimento">N\u00C3\u00BAmero do estabelecimento a qual o terminal pertence. (optional)</param> 
        /// <param name="idEstabelecimento">N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento a qual o terminal pertence. (optional)</param> 
        /// <returns>ApiResponse of PageTerminalResponse</returns>
        public ApiResponse< PageTerminalResponse > ListarUsingGET25WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null)
        {
            
    
            var localVarPath = "/api/terminais";
    
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (terminal != null) localVarQueryParams.Add("terminal", Configuration.ApiClient.ParameterToString(terminal)); // query parameter
            if (numeroEstabelecimento != null) localVarQueryParams.Add("numeroEstabelecimento", Configuration.ApiClient.ParameterToString(numeroEstabelecimento)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET25: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET25: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTerminalResponse)));
            
        }

        
        /// <summary>
        /// Lista os Terminais cadastrados no Emissor Este m\u00C3\u00A9todo permite que sejam listados os terminais existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id). (optional)</param>
        /// <param name="terminal">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do terminal. (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00C3\u00BAmero do estabelecimento a qual o terminal pertence. (optional)</param>
        /// <param name="idEstabelecimento">N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento a qual o terminal pertence. (optional)</param>
        /// <returns>Task of PageTerminalResponse</returns>
        public async System.Threading.Tasks.Task<PageTerminalResponse> ListarUsingGET25Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null)
        {
             ApiResponse<PageTerminalResponse> localVarResponse = await ListarUsingGET25AsyncWithHttpInfo(sort, page, limit, id, terminal, numeroEstabelecimento, idEstabelecimento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Terminais cadastrados no Emissor Este m\u00C3\u00A9todo permite que sejam listados os terminais existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id). (optional)</param>
        /// <param name="terminal">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do terminal. (optional)</param>
        /// <param name="numeroEstabelecimento">N\u00C3\u00BAmero do estabelecimento a qual o terminal pertence. (optional)</param>
        /// <param name="idEstabelecimento">N\u00C3\u00BAmero de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento a qual o terminal pertence. (optional)</param>
        /// <returns>Task of ApiResponse (PageTerminalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTerminalResponse>> ListarUsingGET25AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null)
        {
            
    
            var localVarPath = "/api/terminais";
    
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
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (terminal != null) localVarQueryParams.Add("terminal", Configuration.ApiClient.ParameterToString(terminal)); // query parameter
            if (numeroEstabelecimento != null) localVarQueryParams.Add("numeroEstabelecimento", Configuration.ApiClient.ParameterToString(numeroEstabelecimento)); // query parameter
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET25: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET25: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTerminalResponse)));
            
        }
        
    }
    
}
