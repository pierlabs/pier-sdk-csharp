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
    public interface ICadastrosGeraisApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Atualiza os dados de um determinado Endere\u00C3\u00A7o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja alterado na base do emissor um ou mais registros ligados a um determinado Endere\u00C3\u00A7o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o endere\u00C3\u00A7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Tipo Endere\u00C3\u00A7o (id) (optional)</param>
        /// <param name="cep">Apresenta o C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP) no formaro &#39;58800000&#39; (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00C3\u00BAmero do endere\u00C3\u00A7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00C3\u00A7oes complementares referente ao endere\u00C3\u00A7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00C3\u00A7\u00C3\u00A3o de ponto de refer\u00C3\u00AAncia do endere\u00C3\u00A7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pais (optional)</param>
        /// <returns>Endereco</returns>
        Endereco AlterarUsingPUT (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null);
  
        /// <summary>
        /// Atualiza os dados de um determinado Endere\u00C3\u00A7o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja alterado na base do emissor um ou mais registros ligados a um determinado Endere\u00C3\u00A7o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o endere\u00C3\u00A7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Tipo Endere\u00C3\u00A7o (id) (optional)</param>
        /// <param name="cep">Apresenta o C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP) no formaro &#39;58800000&#39; (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00C3\u00BAmero do endere\u00C3\u00A7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00C3\u00A7oes complementares referente ao endere\u00C3\u00A7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00C3\u00A7\u00C3\u00A3o de ponto de refer\u00C3\u00AAncia do endere\u00C3\u00A7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pais (optional)</param>
        /// <returns>ApiResponse of Endereco</returns>
        ApiResponse<Endereco> AlterarUsingPUTWithHttpInfo (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null);
        
        /// <summary>
        /// Atualiza os dados de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja alterado na base do emissor um registro de determinada Pessoa.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;.</param>
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica).</param>
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param>
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <returns>Pessoa</returns>
        Pessoa AlterarUsingPUT1 (long? id, string nome, string tipo, string cpf = null, string cnpj = null, DateTime? dataNascimento = null, string sexo = null);
  
        /// <summary>
        /// Atualiza os dados de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja alterado na base do emissor um registro de determinada Pessoa.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;.</param>
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica).</param>
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param>
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <returns>ApiResponse of Pessoa</returns>
        ApiResponse<Pessoa> AlterarUsingPUT1WithHttpInfo (long? id, string nome, string tipo, string cpf = null, string cnpj = null, DateTime? dataNascimento = null, string sexo = null);
        
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja alterado um determinado Telefone na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>Telefone</returns>
        Telefone AlterarUsingPUT2 (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null);
  
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja alterado um determinado Telefone na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>ApiResponse of Telefone</returns>
        ApiResponse<Telefone> AlterarUsingPUT2WithHttpInfo (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null);
        
        /// <summary>
        /// Opera\u00C3\u00A7\u00C3\u00A3o utilizada para consultar uma determinada Origem Comercial
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os registros de uma determinada Origem Comercial existente na base do emissor. Para isso, \u00C3\u00A9 preciso informar o seu respectivo c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Origem Comercial</param>
        /// <returns>OrigemComercial</returns>
        OrigemComercial ConsultarOrigemComercialUsingGET (long? id);
  
        /// <summary>
        /// Opera\u00C3\u00A7\u00C3\u00A3o utilizada para consultar uma determinada Origem Comercial
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os registros de uma determinada Origem Comercial existente na base do emissor. Para isso, \u00C3\u00A9 preciso informar o seu respectivo c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Origem Comercial</param>
        /// <returns>ApiResponse of OrigemComercial</returns>
        ApiResponse<OrigemComercial> ConsultarOrigemComercialUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Produto
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Produto a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id)</param>
        /// <returns>Produto</returns>
        Produto ConsultarProdutoUsingGET (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Produto
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Produto a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id)</param>
        /// <returns>ApiResponse of Produto</returns>
        ApiResponse<Produto> ConsultarProdutoUsingGETWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00C3\u00A7o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Endere\u00C3\u00A7o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id).</param>
        /// <returns>Endereco</returns>
        Endereco ConsultarUsingGET2 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00C3\u00A7o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Endere\u00C3\u00A7o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id).</param>
        /// <returns>ApiResponse of Endereco</returns>
        ApiResponse<Endereco> ConsultarUsingGET2WithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Pessoa</returns>
        Pessoa ConsultarUsingGET3 (long? id);
  
        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>ApiResponse of Pessoa</returns>
        ApiResponse<Pessoa> ConsultarUsingGET3WithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param>
        /// <returns>Telefone</returns>
        Telefone ConsultarUsingGET6 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param>
        /// <returns>ApiResponse of Telefone</returns>
        ApiResponse<Telefone> ConsultarUsingGET6WithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Endere\u00C3\u00A7o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Tipo de Endere\u00C3\u00A7o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Endere\u00C3\u00A7o (id)</param>
        /// <returns>TipoEndereco</returns>
        TipoEndereco ConsultarUsingGET7 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Endere\u00C3\u00A7o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Tipo de Endere\u00C3\u00A7o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Endere\u00C3\u00A7o (id)</param>
        /// <returns>ApiResponse of TipoEndereco</returns>
        ApiResponse<TipoEndereco> ConsultarUsingGET7WithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Tipo de Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id)</param>
        /// <returns>TipoTelefone</returns>
        TipoTelefone ConsultarUsingGET8 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Tipo de Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id)</param>
        /// <returns>ApiResponse of TipoTelefone</returns>
        ApiResponse<TipoTelefone> ConsultarUsingGET8WithHttpInfo (long? id);
        
        /// <summary>
        /// Opera\u00C3\u00A7\u00C3\u00A3o utilizada para listar Origens Comerciais
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as Origens Comerciais existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">Id da origem comercial (optional)</param>
        /// <param name="nome">Nome da origem comercial (optional)</param>
        /// <param name="status">Status da origem comercial (optional)</param>
        /// <returns>PageOrigensComerciais</returns>
        PageOrigensComerciais ListarOrigensComerciaisUsingGET (int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null);
  
        /// <summary>
        /// Opera\u00C3\u00A7\u00C3\u00A3o utilizada para listar Origens Comerciais
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as Origens Comerciais existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">Id da origem comercial (optional)</param>
        /// <param name="nome">Nome da origem comercial (optional)</param>
        /// <param name="status">Status da origem comercial (optional)</param>
        /// <returns>ApiResponse of PageOrigensComerciais</returns>
        ApiResponse<PageOrigensComerciais> ListarOrigensComerciaisUsingGETWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null);
        
        /// <summary>
        /// Lista os Produtos do Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Produtos existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="nome">Descri\u00C3\u00A7\u00C3\u00A3o do Nome do Produto. (optional)</param>
        /// <param name="status">Representa o Status do Produto, onde: (\&quot;0\&quot;: Inativo), (\&quot;1\&quot;: Ativo). (optional)</param>
        /// <returns>ListaProdutos</returns>
        ListaProdutos ListarProdutosUsingGET (int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null);
  
        /// <summary>
        /// Lista os Produtos do Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Produtos existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="nome">Descri\u00C3\u00A7\u00C3\u00A3o do Nome do Produto. (optional)</param>
        /// <param name="status">Representa o Status do Produto, onde: (\&quot;0\&quot;: Inativo), (\&quot;1\&quot;: Ativo). (optional)</param>
        /// <returns>ApiResponse of ListaProdutos</returns>
        ApiResponse<ListaProdutos> ListarProdutosUsingGETWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null);
        
        /// <summary>
        /// Lista os Endere\u00C3\u00A7os cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Endere\u00C3\u00A7os existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o endere\u00C3\u00A7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Tipo Endere\u00C3\u00A7o (id) (optional)</param>
        /// <param name="cep">Apresenta o C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP) (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00C3\u00BAmero do endere\u00C3\u00A7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00C3\u00A7oes complementares referente ao endere\u00C3\u00A7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00C3\u00A7\u00C3\u00A3o de ponto de refer\u00C3\u00AAncia do endere\u00C3\u00A7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pais (optional)</param>
        /// <param name="dataInclusao">Apresenta a data em que fora cadastrado o Endere\u00C3\u00A7o (optional)</param>
        /// <param name="dataUltimaAtualizacao">Data em que fora realizada a \u00C3\u00BAltima mudan\u00C3\u00A7a neste registro de endere\u00C3\u00A7o. Quando n\u00C3\u00A3o tiver ocorrido mudan\u00C3\u00A7a, conter\u00C3\u00A1 a mesma informa\u00C3\u00A7\u00C3\u00A3o que o campo dataInclusao (optional)</param>
        /// <returns>PageEnderecos</returns>
        PageEnderecos ListarUsingGET2 (int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, DateTime? dataInclusao = null, DateTime? dataUltimaAtualizacao = null);
  
        /// <summary>
        /// Lista os Endere\u00C3\u00A7os cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Endere\u00C3\u00A7os existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o endere\u00C3\u00A7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Tipo Endere\u00C3\u00A7o (id) (optional)</param>
        /// <param name="cep">Apresenta o C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP) (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00C3\u00BAmero do endere\u00C3\u00A7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00C3\u00A7oes complementares referente ao endere\u00C3\u00A7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00C3\u00A7\u00C3\u00A3o de ponto de refer\u00C3\u00AAncia do endere\u00C3\u00A7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pais (optional)</param>
        /// <param name="dataInclusao">Apresenta a data em que fora cadastrado o Endere\u00C3\u00A7o (optional)</param>
        /// <param name="dataUltimaAtualizacao">Data em que fora realizada a \u00C3\u00BAltima mudan\u00C3\u00A7a neste registro de endere\u00C3\u00A7o. Quando n\u00C3\u00A3o tiver ocorrido mudan\u00C3\u00A7a, conter\u00C3\u00A1 a mesma informa\u00C3\u00A7\u00C3\u00A3o que o campo dataInclusao (optional)</param>
        /// <returns>ApiResponse of PageEnderecos</returns>
        ApiResponse<PageEnderecos> ListarUsingGET2WithHttpInfo (int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, DateTime? dataInclusao = null, DateTime? dataUltimaAtualizacao = null);
        
        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id). (optional)</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;. (optional)</param>
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica). (optional)</param>
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param>
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <returns>PagePessoas</returns>
        PagePessoas ListarUsingGET3 (int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, DateTime? dataNascimento = null, string sexo = null);
  
        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id). (optional)</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;. (optional)</param>
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica). (optional)</param>
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param>
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <returns>ApiResponse of PagePessoas</returns>
        ApiResponse<PagePessoas> ListarUsingGET3WithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, DateTime? dataNascimento = null, string sexo = null);
        
        /// <summary>
        /// Lista os Portadores existentes
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os portadores cadastrados na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id). (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id). (optional)</param>
        /// <param name="idParentesco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Parentesco (id) (optional)</param>
        /// <param name="tipoPortador">Apresenta o tipo do Portador do cart\u00C3\u00A3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional). (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome a ser impresso no cart\u00C3\u00A3o. (optional)</param>
        /// <param name="idImagem">Apresenta o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da imagem do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="idTipoCartao">Apresenta o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo do cart\u00C3\u00A3o (id), que ser\u00C3\u00A1 utilizado para gerar os cart\u00C3\u00B5es deste portador, vinculados a sua respectiva conta atrav\u00C3\u00A9s do campo idConta. (optional)</param>
        /// <param name="flagAtivo">Quanto ativa, indica que o cadastro do Portador est\u00C3\u00A1 ativo, em emissores que realizam este tipo de gest\u00C3\u00A3o. (optional)</param>
        /// <param name="dataCadastroPortador">Apresenta a data em que o Portador fora cadastrado, quando possuir esta informa\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="dataCancelamentoPortador">Apresenta a data em que o Portador fora cancelado, quando possuir esta informa\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <returns>PagePortador</returns>
        PagePortador ListarUsingGET4 (int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idImagem = null, long? idTipoCartao = null, int? flagAtivo = null, DateTime? dataCadastroPortador = null, DateTime? dataCancelamentoPortador = null);
  
        /// <summary>
        /// Lista os Portadores existentes
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os portadores cadastrados na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id). (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id). (optional)</param>
        /// <param name="idParentesco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Parentesco (id) (optional)</param>
        /// <param name="tipoPortador">Apresenta o tipo do Portador do cart\u00C3\u00A3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional). (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome a ser impresso no cart\u00C3\u00A3o. (optional)</param>
        /// <param name="idImagem">Apresenta o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da imagem do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="idTipoCartao">Apresenta o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo do cart\u00C3\u00A3o (id), que ser\u00C3\u00A1 utilizado para gerar os cart\u00C3\u00B5es deste portador, vinculados a sua respectiva conta atrav\u00C3\u00A9s do campo idConta. (optional)</param>
        /// <param name="flagAtivo">Quanto ativa, indica que o cadastro do Portador est\u00C3\u00A1 ativo, em emissores que realizam este tipo de gest\u00C3\u00A3o. (optional)</param>
        /// <param name="dataCadastroPortador">Apresenta a data em que o Portador fora cadastrado, quando possuir esta informa\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="dataCancelamentoPortador">Apresenta a data em que o Portador fora cancelado, quando possuir esta informa\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <returns>ApiResponse of PagePortador</returns>
        ApiResponse<PagePortador> ListarUsingGET4WithHttpInfo (int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idImagem = null, long? idTipoCartao = null, int? flagAtivo = null, DateTime? dataCadastroPortador = null, DateTime? dataCancelamentoPortador = null);
        
        /// <summary>
        /// Lista os Telefones cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Telefones existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id). (optional)</param>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <returns>PageTelefones</returns>
        PageTelefones ListarUsingGET7 (int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null);
  
        /// <summary>
        /// Lista os Telefones cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Telefones existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id). (optional)</param>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <returns>ApiResponse of PageTelefones</returns>
        ApiResponse<PageTelefones> ListarUsingGET7WithHttpInfo (int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null);
        
        /// <summary>
        /// Lista as op\u00C3\u00B5es de Tipos de Endere\u00C3\u00A7os do Emissor 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Tipos de Endere\u00C3\u00A7os existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Endere\u00C3\u00A7o (id) (optional)</param>
        /// <param name="nome">Nome do Tipo do Endere\u00C3\u00A7o (optional)</param>
        /// <returns>PageTiposEndereco</returns>
        PageTiposEndereco ListarUsingGET8 (int? page = null, int? limit = null, long? id = null, string nome = null);
  
        /// <summary>
        /// Lista as op\u00C3\u00B5es de Tipos de Endere\u00C3\u00A7os do Emissor 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Tipos de Endere\u00C3\u00A7os existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Endere\u00C3\u00A7o (id) (optional)</param>
        /// <param name="nome">Nome do Tipo do Endere\u00C3\u00A7o (optional)</param>
        /// <returns>ApiResponse of PageTiposEndereco</returns>
        ApiResponse<PageTiposEndereco> ListarUsingGET8WithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// Lista os Tipos de Telefones
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Tipos de Telefones existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="nome">Nome do Tipo do Telefone (optional)</param>
        /// <returns>PageTipoTelefones</returns>
        PageTipoTelefones ListarUsingGET9 (int? page = null, int? limit = null, long? id = null, string nome = null);
  
        /// <summary>
        /// Lista os Tipos de Telefones
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Tipos de Telefones existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="nome">Nome do Tipo do Telefone (optional)</param>
        /// <returns>ApiResponse of PageTipoTelefones</returns>
        ApiResponse<PageTipoTelefones> ListarUsingGET9WithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// Realiza o cadastro de um novo Endere\u00C3\u00A7o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo Endere\u00C3\u00A7o na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o endere\u00C3\u00A7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Tipo Endere\u00C3\u00A7o (id) (optional)</param>
        /// <param name="cep">Apresenta o C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP) no formaro &#39;58800000&#39; (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00C3\u00BAmero do endere\u00C3\u00A7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00C3\u00A7oes complementares referente ao endere\u00C3\u00A7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00C3\u00A7\u00C3\u00A3o de ponto de refer\u00C3\u00AAncia do endere\u00C3\u00A7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pais (optional)</param>
        /// <returns>Endereco</returns>
        Endereco SalvarUsingPOST (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null);
  
        /// <summary>
        /// Realiza o cadastro de um novo Endere\u00C3\u00A7o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo Endere\u00C3\u00A7o na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o endere\u00C3\u00A7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Tipo Endere\u00C3\u00A7o (id) (optional)</param>
        /// <param name="cep">Apresenta o C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP) no formaro &#39;58800000&#39; (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00C3\u00BAmero do endere\u00C3\u00A7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00C3\u00A7oes complementares referente ao endere\u00C3\u00A7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00C3\u00A7\u00C3\u00A3o de ponto de refer\u00C3\u00AAncia do endere\u00C3\u00A7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pais (optional)</param>
        /// <returns>ApiResponse of Endereco</returns>
        ApiResponse<Endereco> SalvarUsingPOSTWithHttpInfo (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null);
        
        /// <summary>
        /// Realiza o cadastro de um nova Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado uma nova Pessoa na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;.</param>
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica).</param>
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param>
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <returns>Pessoa</returns>
        Pessoa SalvarUsingPOST1 (string nome, string tipo, string cpf = null, string cnpj = null, DateTime? dataNascimento = null, string sexo = null);
  
        /// <summary>
        /// Realiza o cadastro de um nova Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado uma nova Pessoa na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;.</param>
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica).</param>
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param>
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <returns>ApiResponse of Pessoa</returns>
        ApiResponse<Pessoa> SalvarUsingPOST1WithHttpInfo (string nome, string tipo, string cpf = null, string cnpj = null, DateTime? dataNascimento = null, string sexo = null);
        
        /// <summary>
        /// Realiza o cadastro de um novo Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>Telefone</returns>
        Telefone SalvarUsingPOST2 (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null);
  
        /// <summary>
        /// Realiza o cadastro de um novo Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>ApiResponse of Telefone</returns>
        ApiResponse<Telefone> SalvarUsingPOST2WithHttpInfo (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Atualiza os dados de um determinado Endere\u00C3\u00A7o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja alterado na base do emissor um ou mais registros ligados a um determinado Endere\u00C3\u00A7o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o endere\u00C3\u00A7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Tipo Endere\u00C3\u00A7o (id) (optional)</param>
        /// <param name="cep">Apresenta o C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP) no formaro &#39;58800000&#39; (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00C3\u00BAmero do endere\u00C3\u00A7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00C3\u00A7oes complementares referente ao endere\u00C3\u00A7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00C3\u00A7\u00C3\u00A3o de ponto de refer\u00C3\u00AAncia do endere\u00C3\u00A7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pais (optional)</param>
        /// <returns>Task of Endereco</returns>
        System.Threading.Tasks.Task<Endereco> AlterarUsingPUTAsync (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null);

        /// <summary>
        /// Atualiza os dados de um determinado Endere\u00C3\u00A7o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja alterado na base do emissor um ou mais registros ligados a um determinado Endere\u00C3\u00A7o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o endere\u00C3\u00A7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Tipo Endere\u00C3\u00A7o (id) (optional)</param>
        /// <param name="cep">Apresenta o C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP) no formaro &#39;58800000&#39; (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00C3\u00BAmero do endere\u00C3\u00A7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00C3\u00A7oes complementares referente ao endere\u00C3\u00A7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00C3\u00A7\u00C3\u00A3o de ponto de refer\u00C3\u00AAncia do endere\u00C3\u00A7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pais (optional)</param>
        /// <returns>Task of ApiResponse (Endereco)</returns>
        System.Threading.Tasks.Task<ApiResponse<Endereco>> AlterarUsingPUTAsyncWithHttpInfo (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null);
        
        /// <summary>
        /// Atualiza os dados de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja alterado na base do emissor um registro de determinada Pessoa.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;.</param>
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica).</param>
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param>
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <returns>Task of Pessoa</returns>
        System.Threading.Tasks.Task<Pessoa> AlterarUsingPUT1Async (long? id, string nome, string tipo, string cpf = null, string cnpj = null, DateTime? dataNascimento = null, string sexo = null);

        /// <summary>
        /// Atualiza os dados de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja alterado na base do emissor um registro de determinada Pessoa.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;.</param>
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica).</param>
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param>
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <returns>Task of ApiResponse (Pessoa)</returns>
        System.Threading.Tasks.Task<ApiResponse<Pessoa>> AlterarUsingPUT1AsyncWithHttpInfo (long? id, string nome, string tipo, string cpf = null, string cnpj = null, DateTime? dataNascimento = null, string sexo = null);
        
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja alterado um determinado Telefone na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>Task of Telefone</returns>
        System.Threading.Tasks.Task<Telefone> AlterarUsingPUT2Async (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null);

        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja alterado um determinado Telefone na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>Task of ApiResponse (Telefone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Telefone>> AlterarUsingPUT2AsyncWithHttpInfo (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null);
        
        /// <summary>
        /// Opera\u00C3\u00A7\u00C3\u00A3o utilizada para consultar uma determinada Origem Comercial
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os registros de uma determinada Origem Comercial existente na base do emissor. Para isso, \u00C3\u00A9 preciso informar o seu respectivo c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Origem Comercial</param>
        /// <returns>Task of OrigemComercial</returns>
        System.Threading.Tasks.Task<OrigemComercial> ConsultarOrigemComercialUsingGETAsync (long? id);

        /// <summary>
        /// Opera\u00C3\u00A7\u00C3\u00A3o utilizada para consultar uma determinada Origem Comercial
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os registros de uma determinada Origem Comercial existente na base do emissor. Para isso, \u00C3\u00A9 preciso informar o seu respectivo c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Origem Comercial</param>
        /// <returns>Task of ApiResponse (OrigemComercial)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrigemComercial>> ConsultarOrigemComercialUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Produto
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Produto a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id)</param>
        /// <returns>Task of Produto</returns>
        System.Threading.Tasks.Task<Produto> ConsultarProdutoUsingGETAsync (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Produto
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Produto a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id)</param>
        /// <returns>Task of ApiResponse (Produto)</returns>
        System.Threading.Tasks.Task<ApiResponse<Produto>> ConsultarProdutoUsingGETAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00C3\u00A7o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Endere\u00C3\u00A7o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id).</param>
        /// <returns>Task of Endereco</returns>
        System.Threading.Tasks.Task<Endereco> ConsultarUsingGET2Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00C3\u00A7o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Endere\u00C3\u00A7o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id).</param>
        /// <returns>Task of ApiResponse (Endereco)</returns>
        System.Threading.Tasks.Task<ApiResponse<Endereco>> ConsultarUsingGET2AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Task of Pessoa</returns>
        System.Threading.Tasks.Task<Pessoa> ConsultarUsingGET3Async (long? id);

        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Task of ApiResponse (Pessoa)</returns>
        System.Threading.Tasks.Task<ApiResponse<Pessoa>> ConsultarUsingGET3AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param>
        /// <returns>Task of Telefone</returns>
        System.Threading.Tasks.Task<Telefone> ConsultarUsingGET6Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param>
        /// <returns>Task of ApiResponse (Telefone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Telefone>> ConsultarUsingGET6AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Endere\u00C3\u00A7o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Tipo de Endere\u00C3\u00A7o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Endere\u00C3\u00A7o (id)</param>
        /// <returns>Task of TipoEndereco</returns>
        System.Threading.Tasks.Task<TipoEndereco> ConsultarUsingGET7Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Endere\u00C3\u00A7o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Tipo de Endere\u00C3\u00A7o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Endere\u00C3\u00A7o (id)</param>
        /// <returns>Task of ApiResponse (TipoEndereco)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoEndereco>> ConsultarUsingGET7AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Tipo de Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id)</param>
        /// <returns>Task of TipoTelefone</returns>
        System.Threading.Tasks.Task<TipoTelefone> ConsultarUsingGET8Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Tipo de Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id)</param>
        /// <returns>Task of ApiResponse (TipoTelefone)</returns>
        System.Threading.Tasks.Task<ApiResponse<TipoTelefone>> ConsultarUsingGET8AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Opera\u00C3\u00A7\u00C3\u00A3o utilizada para listar Origens Comerciais
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as Origens Comerciais existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">Id da origem comercial (optional)</param>
        /// <param name="nome">Nome da origem comercial (optional)</param>
        /// <param name="status">Status da origem comercial (optional)</param>
        /// <returns>Task of PageOrigensComerciais</returns>
        System.Threading.Tasks.Task<PageOrigensComerciais> ListarOrigensComerciaisUsingGETAsync (int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null);

        /// <summary>
        /// Opera\u00C3\u00A7\u00C3\u00A3o utilizada para listar Origens Comerciais
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as Origens Comerciais existentes na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">Id da origem comercial (optional)</param>
        /// <param name="nome">Nome da origem comercial (optional)</param>
        /// <param name="status">Status da origem comercial (optional)</param>
        /// <returns>Task of ApiResponse (PageOrigensComerciais)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageOrigensComerciais>> ListarOrigensComerciaisUsingGETAsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null);
        
        /// <summary>
        /// Lista os Produtos do Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Produtos existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="nome">Descri\u00C3\u00A7\u00C3\u00A3o do Nome do Produto. (optional)</param>
        /// <param name="status">Representa o Status do Produto, onde: (\&quot;0\&quot;: Inativo), (\&quot;1\&quot;: Ativo). (optional)</param>
        /// <returns>Task of ListaProdutos</returns>
        System.Threading.Tasks.Task<ListaProdutos> ListarProdutosUsingGETAsync (int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null);

        /// <summary>
        /// Lista os Produtos do Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Produtos existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="nome">Descri\u00C3\u00A7\u00C3\u00A3o do Nome do Produto. (optional)</param>
        /// <param name="status">Representa o Status do Produto, onde: (\&quot;0\&quot;: Inativo), (\&quot;1\&quot;: Ativo). (optional)</param>
        /// <returns>Task of ApiResponse (ListaProdutos)</returns>
        System.Threading.Tasks.Task<ApiResponse<ListaProdutos>> ListarProdutosUsingGETAsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null);
        
        /// <summary>
        /// Lista os Endere\u00C3\u00A7os cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Endere\u00C3\u00A7os existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o endere\u00C3\u00A7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Tipo Endere\u00C3\u00A7o (id) (optional)</param>
        /// <param name="cep">Apresenta o C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP) (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00C3\u00BAmero do endere\u00C3\u00A7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00C3\u00A7oes complementares referente ao endere\u00C3\u00A7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00C3\u00A7\u00C3\u00A3o de ponto de refer\u00C3\u00AAncia do endere\u00C3\u00A7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pais (optional)</param>
        /// <param name="dataInclusao">Apresenta a data em que fora cadastrado o Endere\u00C3\u00A7o (optional)</param>
        /// <param name="dataUltimaAtualizacao">Data em que fora realizada a \u00C3\u00BAltima mudan\u00C3\u00A7a neste registro de endere\u00C3\u00A7o. Quando n\u00C3\u00A3o tiver ocorrido mudan\u00C3\u00A7a, conter\u00C3\u00A1 a mesma informa\u00C3\u00A7\u00C3\u00A3o que o campo dataInclusao (optional)</param>
        /// <returns>Task of PageEnderecos</returns>
        System.Threading.Tasks.Task<PageEnderecos> ListarUsingGET2Async (int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, DateTime? dataInclusao = null, DateTime? dataUltimaAtualizacao = null);

        /// <summary>
        /// Lista os Endere\u00C3\u00A7os cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Endere\u00C3\u00A7os existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o endere\u00C3\u00A7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Tipo Endere\u00C3\u00A7o (id) (optional)</param>
        /// <param name="cep">Apresenta o C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP) (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00C3\u00BAmero do endere\u00C3\u00A7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00C3\u00A7oes complementares referente ao endere\u00C3\u00A7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00C3\u00A7\u00C3\u00A3o de ponto de refer\u00C3\u00AAncia do endere\u00C3\u00A7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pais (optional)</param>
        /// <param name="dataInclusao">Apresenta a data em que fora cadastrado o Endere\u00C3\u00A7o (optional)</param>
        /// <param name="dataUltimaAtualizacao">Data em que fora realizada a \u00C3\u00BAltima mudan\u00C3\u00A7a neste registro de endere\u00C3\u00A7o. Quando n\u00C3\u00A3o tiver ocorrido mudan\u00C3\u00A7a, conter\u00C3\u00A1 a mesma informa\u00C3\u00A7\u00C3\u00A3o que o campo dataInclusao (optional)</param>
        /// <returns>Task of ApiResponse (PageEnderecos)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageEnderecos>> ListarUsingGET2AsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, DateTime? dataInclusao = null, DateTime? dataUltimaAtualizacao = null);
        
        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id). (optional)</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;. (optional)</param>
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica). (optional)</param>
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param>
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <returns>Task of PagePessoas</returns>
        System.Threading.Tasks.Task<PagePessoas> ListarUsingGET3Async (int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, DateTime? dataNascimento = null, string sexo = null);

        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id). (optional)</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;. (optional)</param>
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica). (optional)</param>
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param>
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoas)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePessoas>> ListarUsingGET3AsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, DateTime? dataNascimento = null, string sexo = null);
        
        /// <summary>
        /// Lista os Portadores existentes
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os portadores cadastrados na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id). (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id). (optional)</param>
        /// <param name="idParentesco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Parentesco (id) (optional)</param>
        /// <param name="tipoPortador">Apresenta o tipo do Portador do cart\u00C3\u00A3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional). (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome a ser impresso no cart\u00C3\u00A3o. (optional)</param>
        /// <param name="idImagem">Apresenta o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da imagem do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="idTipoCartao">Apresenta o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo do cart\u00C3\u00A3o (id), que ser\u00C3\u00A1 utilizado para gerar os cart\u00C3\u00B5es deste portador, vinculados a sua respectiva conta atrav\u00C3\u00A9s do campo idConta. (optional)</param>
        /// <param name="flagAtivo">Quanto ativa, indica que o cadastro do Portador est\u00C3\u00A1 ativo, em emissores que realizam este tipo de gest\u00C3\u00A3o. (optional)</param>
        /// <param name="dataCadastroPortador">Apresenta a data em que o Portador fora cadastrado, quando possuir esta informa\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="dataCancelamentoPortador">Apresenta a data em que o Portador fora cancelado, quando possuir esta informa\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <returns>Task of PagePortador</returns>
        System.Threading.Tasks.Task<PagePortador> ListarUsingGET4Async (int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idImagem = null, long? idTipoCartao = null, int? flagAtivo = null, DateTime? dataCadastroPortador = null, DateTime? dataCancelamentoPortador = null);

        /// <summary>
        /// Lista os Portadores existentes
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os portadores cadastrados na base do emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id). (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id). (optional)</param>
        /// <param name="idParentesco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Parentesco (id) (optional)</param>
        /// <param name="tipoPortador">Apresenta o tipo do Portador do cart\u00C3\u00A3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional). (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome a ser impresso no cart\u00C3\u00A3o. (optional)</param>
        /// <param name="idImagem">Apresenta o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da imagem do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="idTipoCartao">Apresenta o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo do cart\u00C3\u00A3o (id), que ser\u00C3\u00A1 utilizado para gerar os cart\u00C3\u00B5es deste portador, vinculados a sua respectiva conta atrav\u00C3\u00A9s do campo idConta. (optional)</param>
        /// <param name="flagAtivo">Quanto ativa, indica que o cadastro do Portador est\u00C3\u00A1 ativo, em emissores que realizam este tipo de gest\u00C3\u00A3o. (optional)</param>
        /// <param name="dataCadastroPortador">Apresenta a data em que o Portador fora cadastrado, quando possuir esta informa\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="dataCancelamentoPortador">Apresenta a data em que o Portador fora cancelado, quando possuir esta informa\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <returns>Task of ApiResponse (PagePortador)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePortador>> ListarUsingGET4AsyncWithHttpInfo (int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idImagem = null, long? idTipoCartao = null, int? flagAtivo = null, DateTime? dataCadastroPortador = null, DateTime? dataCancelamentoPortador = null);
        
        /// <summary>
        /// Lista os Telefones cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Telefones existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id). (optional)</param>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <returns>Task of PageTelefones</returns>
        System.Threading.Tasks.Task<PageTelefones> ListarUsingGET7Async (int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null);

        /// <summary>
        /// Lista os Telefones cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Telefones existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id). (optional)</param>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <returns>Task of ApiResponse (PageTelefones)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTelefones>> ListarUsingGET7AsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null);
        
        /// <summary>
        /// Lista as op\u00C3\u00B5es de Tipos de Endere\u00C3\u00A7os do Emissor 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Tipos de Endere\u00C3\u00A7os existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Endere\u00C3\u00A7o (id) (optional)</param>
        /// <param name="nome">Nome do Tipo do Endere\u00C3\u00A7o (optional)</param>
        /// <returns>Task of PageTiposEndereco</returns>
        System.Threading.Tasks.Task<PageTiposEndereco> ListarUsingGET8Async (int? page = null, int? limit = null, long? id = null, string nome = null);

        /// <summary>
        /// Lista as op\u00C3\u00B5es de Tipos de Endere\u00C3\u00A7os do Emissor 
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Tipos de Endere\u00C3\u00A7os existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Endere\u00C3\u00A7o (id) (optional)</param>
        /// <param name="nome">Nome do Tipo do Endere\u00C3\u00A7o (optional)</param>
        /// <returns>Task of ApiResponse (PageTiposEndereco)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTiposEndereco>> ListarUsingGET8AsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// Lista os Tipos de Telefones
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Tipos de Telefones existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="nome">Nome do Tipo do Telefone (optional)</param>
        /// <returns>Task of PageTipoTelefones</returns>
        System.Threading.Tasks.Task<PageTipoTelefones> ListarUsingGET9Async (int? page = null, int? limit = null, long? id = null, string nome = null);

        /// <summary>
        /// Lista os Tipos de Telefones
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Tipos de Telefones existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="nome">Nome do Tipo do Telefone (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoTelefones)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTipoTelefones>> ListarUsingGET9AsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null);
        
        /// <summary>
        /// Realiza o cadastro de um novo Endere\u00C3\u00A7o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo Endere\u00C3\u00A7o na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o endere\u00C3\u00A7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Tipo Endere\u00C3\u00A7o (id) (optional)</param>
        /// <param name="cep">Apresenta o C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP) no formaro &#39;58800000&#39; (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00C3\u00BAmero do endere\u00C3\u00A7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00C3\u00A7oes complementares referente ao endere\u00C3\u00A7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00C3\u00A7\u00C3\u00A3o de ponto de refer\u00C3\u00AAncia do endere\u00C3\u00A7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pais (optional)</param>
        /// <returns>Task of Endereco</returns>
        System.Threading.Tasks.Task<Endereco> SalvarUsingPOSTAsync (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null);

        /// <summary>
        /// Realiza o cadastro de um novo Endere\u00C3\u00A7o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo Endere\u00C3\u00A7o na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o endere\u00C3\u00A7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Tipo Endere\u00C3\u00A7o (id) (optional)</param>
        /// <param name="cep">Apresenta o C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP) no formaro &#39;58800000&#39; (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00C3\u00BAmero do endere\u00C3\u00A7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00C3\u00A7oes complementares referente ao endere\u00C3\u00A7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00C3\u00A7\u00C3\u00A3o de ponto de refer\u00C3\u00AAncia do endere\u00C3\u00A7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pais (optional)</param>
        /// <returns>Task of ApiResponse (Endereco)</returns>
        System.Threading.Tasks.Task<ApiResponse<Endereco>> SalvarUsingPOSTAsyncWithHttpInfo (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null);
        
        /// <summary>
        /// Realiza o cadastro de um nova Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado uma nova Pessoa na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;.</param>
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica).</param>
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param>
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <returns>Task of Pessoa</returns>
        System.Threading.Tasks.Task<Pessoa> SalvarUsingPOST1Async (string nome, string tipo, string cpf = null, string cnpj = null, DateTime? dataNascimento = null, string sexo = null);

        /// <summary>
        /// Realiza o cadastro de um nova Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado uma nova Pessoa na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;.</param>
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica).</param>
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param>
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <returns>Task of ApiResponse (Pessoa)</returns>
        System.Threading.Tasks.Task<ApiResponse<Pessoa>> SalvarUsingPOST1AsyncWithHttpInfo (string nome, string tipo, string cpf = null, string cnpj = null, DateTime? dataNascimento = null, string sexo = null);
        
        /// <summary>
        /// Realiza o cadastro de um novo Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>Task of Telefone</returns>
        System.Threading.Tasks.Task<Telefone> SalvarUsingPOST2Async (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null);

        /// <summary>
        /// Realiza o cadastro de um novo Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>Task of ApiResponse (Telefone)</returns>
        System.Threading.Tasks.Task<ApiResponse<Telefone>> SalvarUsingPOST2AsyncWithHttpInfo (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CadastrosGeraisApi : ICadastrosGeraisApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CadastrosGeraisApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CadastrosGeraisApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CadastrosGeraisApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CadastrosGeraisApi(Configuration configuration = null)
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
        /// Atualiza os dados de um determinado Endere\u00C3\u00A7o Este m\u00C3\u00A9todo permite que seja alterado na base do emissor um ou mais registros ligados a um determinado Endere\u00C3\u00A7o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o endere\u00C3\u00A7o pertence (id) (optional)</param> 
        /// <param name="idTipoEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Tipo Endere\u00C3\u00A7o (id) (optional)</param> 
        /// <param name="cep">Apresenta o C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP) no formaro &#39;58800000&#39; (optional)</param> 
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param> 
        /// <param name="numero">Apresenta o n\u00C3\u00BAmero do endere\u00C3\u00A7o (optional)</param> 
        /// <param name="complemento">Apresenta descri\u00C3\u00A7oes complementares referente ao endere\u00C3\u00A7o (optional)</param> 
        /// <param name="pontoReferencia">Apresenta a descri\u00C3\u00A7\u00C3\u00A3o de ponto de refer\u00C3\u00AAncia do endere\u00C3\u00A7o (optional)</param> 
        /// <param name="bairro">Apresenta nome do bairro (optional)</param> 
        /// <param name="cidade">Apresenta nome da cidade (optional)</param> 
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param> 
        /// <param name="pais">Apresenta nome do Pais (optional)</param> 
        /// <returns>Endereco</returns>
        public Endereco AlterarUsingPUT (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null)
        {
             ApiResponse<Endereco> localVarResponse = AlterarUsingPUTWithHttpInfo(id, idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualiza os dados de um determinado Endere\u00C3\u00A7o Este m\u00C3\u00A9todo permite que seja alterado na base do emissor um ou mais registros ligados a um determinado Endere\u00C3\u00A7o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o endere\u00C3\u00A7o pertence (id) (optional)</param> 
        /// <param name="idTipoEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Tipo Endere\u00C3\u00A7o (id) (optional)</param> 
        /// <param name="cep">Apresenta o C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP) no formaro &#39;58800000&#39; (optional)</param> 
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param> 
        /// <param name="numero">Apresenta o n\u00C3\u00BAmero do endere\u00C3\u00A7o (optional)</param> 
        /// <param name="complemento">Apresenta descri\u00C3\u00A7oes complementares referente ao endere\u00C3\u00A7o (optional)</param> 
        /// <param name="pontoReferencia">Apresenta a descri\u00C3\u00A7\u00C3\u00A3o de ponto de refer\u00C3\u00AAncia do endere\u00C3\u00A7o (optional)</param> 
        /// <param name="bairro">Apresenta nome do bairro (optional)</param> 
        /// <param name="cidade">Apresenta nome da cidade (optional)</param> 
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param> 
        /// <param name="pais">Apresenta nome do Pais (optional)</param> 
        /// <returns>ApiResponse of Endereco</returns>
        public ApiResponse< Endereco > AlterarUsingPUTWithHttpInfo (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastrosGeraisApi->AlterarUsingPUT");
            
    
            var localVarPath = "/api/enderecos";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idTipoEndereco != null) localVarQueryParams.Add("idTipoEndereco", Configuration.ApiClient.ParameterToString(idTipoEndereco)); // query parameter
            if (cep != null) localVarQueryParams.Add("cep", Configuration.ApiClient.ParameterToString(cep)); // query parameter
            if (logradouro != null) localVarQueryParams.Add("logradouro", Configuration.ApiClient.ParameterToString(logradouro)); // query parameter
            if (numero != null) localVarQueryParams.Add("numero", Configuration.ApiClient.ParameterToString(numero)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            if (pontoReferencia != null) localVarQueryParams.Add("pontoReferencia", Configuration.ApiClient.ParameterToString(pontoReferencia)); // query parameter
            if (bairro != null) localVarQueryParams.Add("bairro", Configuration.ApiClient.ParameterToString(bairro)); // query parameter
            if (cidade != null) localVarQueryParams.Add("cidade", Configuration.ApiClient.ParameterToString(cidade)); // query parameter
            if (uf != null) localVarQueryParams.Add("uf", Configuration.ApiClient.ParameterToString(uf)); // query parameter
            if (pais != null) localVarQueryParams.Add("pais", Configuration.ApiClient.ParameterToString(pais)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Endereco>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Endereco) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Endereco)));
            
        }

        
        /// <summary>
        /// Atualiza os dados de um determinado Endere\u00C3\u00A7o Este m\u00C3\u00A9todo permite que seja alterado na base do emissor um ou mais registros ligados a um determinado Endere\u00C3\u00A7o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o endere\u00C3\u00A7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Tipo Endere\u00C3\u00A7o (id) (optional)</param>
        /// <param name="cep">Apresenta o C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP) no formaro &#39;58800000&#39; (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00C3\u00BAmero do endere\u00C3\u00A7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00C3\u00A7oes complementares referente ao endere\u00C3\u00A7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00C3\u00A7\u00C3\u00A3o de ponto de refer\u00C3\u00AAncia do endere\u00C3\u00A7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pais (optional)</param>
        /// <returns>Task of Endereco</returns>
        public async System.Threading.Tasks.Task<Endereco> AlterarUsingPUTAsync (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null)
        {
             ApiResponse<Endereco> localVarResponse = await AlterarUsingPUTAsyncWithHttpInfo(id, idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualiza os dados de um determinado Endere\u00C3\u00A7o Este m\u00C3\u00A9todo permite que seja alterado na base do emissor um ou mais registros ligados a um determinado Endere\u00C3\u00A7o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o endere\u00C3\u00A7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Tipo Endere\u00C3\u00A7o (id) (optional)</param>
        /// <param name="cep">Apresenta o C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP) no formaro &#39;58800000&#39; (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00C3\u00BAmero do endere\u00C3\u00A7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00C3\u00A7oes complementares referente ao endere\u00C3\u00A7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00C3\u00A7\u00C3\u00A3o de ponto de refer\u00C3\u00AAncia do endere\u00C3\u00A7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pais (optional)</param>
        /// <returns>Task of ApiResponse (Endereco)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Endereco>> AlterarUsingPUTAsyncWithHttpInfo (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT");
            
    
            var localVarPath = "/api/enderecos";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idTipoEndereco != null) localVarQueryParams.Add("idTipoEndereco", Configuration.ApiClient.ParameterToString(idTipoEndereco)); // query parameter
            if (cep != null) localVarQueryParams.Add("cep", Configuration.ApiClient.ParameterToString(cep)); // query parameter
            if (logradouro != null) localVarQueryParams.Add("logradouro", Configuration.ApiClient.ParameterToString(logradouro)); // query parameter
            if (numero != null) localVarQueryParams.Add("numero", Configuration.ApiClient.ParameterToString(numero)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            if (pontoReferencia != null) localVarQueryParams.Add("pontoReferencia", Configuration.ApiClient.ParameterToString(pontoReferencia)); // query parameter
            if (bairro != null) localVarQueryParams.Add("bairro", Configuration.ApiClient.ParameterToString(bairro)); // query parameter
            if (cidade != null) localVarQueryParams.Add("cidade", Configuration.ApiClient.ParameterToString(cidade)); // query parameter
            if (uf != null) localVarQueryParams.Add("uf", Configuration.ApiClient.ParameterToString(uf)); // query parameter
            if (pais != null) localVarQueryParams.Add("pais", Configuration.ApiClient.ParameterToString(pais)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Endereco>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Endereco) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Endereco)));
            
        }
        
        /// <summary>
        /// Atualiza os dados de uma determinada Pessoa Este m\u00C3\u00A9todo permite que seja alterado na base do emissor um registro de determinada Pessoa.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param> 
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;.</param> 
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica).</param> 
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param> 
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param> 
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param> 
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param> 
        /// <returns>Pessoa</returns>
        public Pessoa AlterarUsingPUT1 (long? id, string nome, string tipo, string cpf = null, string cnpj = null, DateTime? dataNascimento = null, string sexo = null)
        {
             ApiResponse<Pessoa> localVarResponse = AlterarUsingPUT1WithHttpInfo(id, nome, tipo, cpf, cnpj, dataNascimento, sexo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualiza os dados de uma determinada Pessoa Este m\u00C3\u00A9todo permite que seja alterado na base do emissor um registro de determinada Pessoa.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param> 
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;.</param> 
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica).</param> 
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param> 
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param> 
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param> 
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param> 
        /// <returns>ApiResponse of Pessoa</returns>
        public ApiResponse< Pessoa > AlterarUsingPUT1WithHttpInfo (long? id, string nome, string tipo, string cpf = null, string cnpj = null, DateTime? dataNascimento = null, string sexo = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastrosGeraisApi->AlterarUsingPUT1");
            
            // verify the required parameter 'nome' is set
            if (nome == null)
                throw new ApiException(400, "Missing required parameter 'nome' when calling CadastrosGeraisApi->AlterarUsingPUT1");
            
            // verify the required parameter 'tipo' is set
            if (tipo == null)
                throw new ApiException(400, "Missing required parameter 'tipo' when calling CadastrosGeraisApi->AlterarUsingPUT1");
            
    
            var localVarPath = "/api/pessoas";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (tipo != null) localVarQueryParams.Add("tipo", Configuration.ApiClient.ParameterToString(tipo)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (cnpj != null) localVarQueryParams.Add("cnpj", Configuration.ApiClient.ParameterToString(cnpj)); // query parameter
            if (dataNascimento != null) localVarQueryParams.Add("dataNascimento", Configuration.ApiClient.ParameterToString(dataNascimento)); // query parameter
            if (sexo != null) localVarQueryParams.Add("sexo", Configuration.ApiClient.ParameterToString(sexo)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Pessoa>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Pessoa) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Pessoa)));
            
        }

        
        /// <summary>
        /// Atualiza os dados de uma determinada Pessoa Este m\u00C3\u00A9todo permite que seja alterado na base do emissor um registro de determinada Pessoa.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;.</param>
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica).</param>
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param>
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <returns>Task of Pessoa</returns>
        public async System.Threading.Tasks.Task<Pessoa> AlterarUsingPUT1Async (long? id, string nome, string tipo, string cpf = null, string cnpj = null, DateTime? dataNascimento = null, string sexo = null)
        {
             ApiResponse<Pessoa> localVarResponse = await AlterarUsingPUT1AsyncWithHttpInfo(id, nome, tipo, cpf, cnpj, dataNascimento, sexo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualiza os dados de uma determinada Pessoa Este m\u00C3\u00A9todo permite que seja alterado na base do emissor um registro de determinada Pessoa.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;.</param>
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica).</param>
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param>
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <returns>Task of ApiResponse (Pessoa)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Pessoa>> AlterarUsingPUT1AsyncWithHttpInfo (long? id, string nome, string tipo, string cpf = null, string cnpj = null, DateTime? dataNascimento = null, string sexo = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT1");
            // verify the required parameter 'nome' is set
            if (nome == null) throw new ApiException(400, "Missing required parameter 'nome' when calling AlterarUsingPUT1");
            // verify the required parameter 'tipo' is set
            if (tipo == null) throw new ApiException(400, "Missing required parameter 'tipo' when calling AlterarUsingPUT1");
            
    
            var localVarPath = "/api/pessoas";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (tipo != null) localVarQueryParams.Add("tipo", Configuration.ApiClient.ParameterToString(tipo)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (cnpj != null) localVarQueryParams.Add("cnpj", Configuration.ApiClient.ParameterToString(cnpj)); // query parameter
            if (dataNascimento != null) localVarQueryParams.Add("dataNascimento", Configuration.ApiClient.ParameterToString(dataNascimento)); // query parameter
            if (sexo != null) localVarQueryParams.Add("sexo", Configuration.ApiClient.ParameterToString(sexo)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Pessoa>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Pessoa) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Pessoa)));
            
        }
        
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o de um determinado Telefone Este m\u00C3\u00A9todo permite que seja alterado um determinado Telefone na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param> 
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param> 
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param> 
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param> 
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param> 
        /// <returns>Telefone</returns>
        public Telefone AlterarUsingPUT2 (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null)
        {
             ApiResponse<Telefone> localVarResponse = AlterarUsingPUT2WithHttpInfo(id, idTipoTelefone, ddd, telefone, ramal);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o de um determinado Telefone Este m\u00C3\u00A9todo permite que seja alterado um determinado Telefone na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param> 
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param> 
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param> 
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param> 
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param> 
        /// <returns>ApiResponse of Telefone</returns>
        public ApiResponse< Telefone > AlterarUsingPUT2WithHttpInfo (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastrosGeraisApi->AlterarUsingPUT2");
            
    
            var localVarPath = "/api/telefones";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idTipoTelefone != null) localVarQueryParams.Add("idTipoTelefone", Configuration.ApiClient.ParameterToString(idTipoTelefone)); // query parameter
            if (ddd != null) localVarQueryParams.Add("ddd", Configuration.ApiClient.ParameterToString(ddd)); // query parameter
            if (telefone != null) localVarQueryParams.Add("telefone", Configuration.ApiClient.ParameterToString(telefone)); // query parameter
            if (ramal != null) localVarQueryParams.Add("ramal", Configuration.ApiClient.ParameterToString(ramal)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Telefone>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Telefone) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Telefone)));
            
        }

        
        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o de um determinado Telefone Este m\u00C3\u00A9todo permite que seja alterado um determinado Telefone na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>Task of Telefone</returns>
        public async System.Threading.Tasks.Task<Telefone> AlterarUsingPUT2Async (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null)
        {
             ApiResponse<Telefone> localVarResponse = await AlterarUsingPUT2AsyncWithHttpInfo(id, idTipoTelefone, ddd, telefone, ramal);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a altera\u00C3\u00A7\u00C3\u00A3o de um determinado Telefone Este m\u00C3\u00A9todo permite que seja alterado um determinado Telefone na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>Task of ApiResponse (Telefone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Telefone>> AlterarUsingPUT2AsyncWithHttpInfo (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT2");
            
    
            var localVarPath = "/api/telefones";
    
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
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idTipoTelefone != null) localVarQueryParams.Add("idTipoTelefone", Configuration.ApiClient.ParameterToString(idTipoTelefone)); // query parameter
            if (ddd != null) localVarQueryParams.Add("ddd", Configuration.ApiClient.ParameterToString(ddd)); // query parameter
            if (telefone != null) localVarQueryParams.Add("telefone", Configuration.ApiClient.ParameterToString(telefone)); // query parameter
            if (ramal != null) localVarQueryParams.Add("ramal", Configuration.ApiClient.ParameterToString(ramal)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Telefone>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Telefone) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Telefone)));
            
        }
        
        /// <summary>
        /// Opera\u00C3\u00A7\u00C3\u00A3o utilizada para consultar uma determinada Origem Comercial Este m\u00C3\u00A9todo permite que sejam listados os registros de uma determinada Origem Comercial existente na base do emissor. Para isso, \u00C3\u00A9 preciso informar o seu respectivo c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Origem Comercial</param> 
        /// <returns>OrigemComercial</returns>
        public OrigemComercial ConsultarOrigemComercialUsingGET (long? id)
        {
             ApiResponse<OrigemComercial> localVarResponse = ConsultarOrigemComercialUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Opera\u00C3\u00A7\u00C3\u00A3o utilizada para consultar uma determinada Origem Comercial Este m\u00C3\u00A9todo permite que sejam listados os registros de uma determinada Origem Comercial existente na base do emissor. Para isso, \u00C3\u00A9 preciso informar o seu respectivo c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Origem Comercial</param> 
        /// <returns>ApiResponse of OrigemComercial</returns>
        public ApiResponse< OrigemComercial > ConsultarOrigemComercialUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastrosGeraisApi->ConsultarOrigemComercialUsingGET");
            
    
            var localVarPath = "/api/origens-comerciais/{id}";
    
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
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOrigemComercialUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOrigemComercialUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OrigemComercial>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrigemComercial) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrigemComercial)));
            
        }

        
        /// <summary>
        /// Opera\u00C3\u00A7\u00C3\u00A3o utilizada para consultar uma determinada Origem Comercial Este m\u00C3\u00A9todo permite que sejam listados os registros de uma determinada Origem Comercial existente na base do emissor. Para isso, \u00C3\u00A9 preciso informar o seu respectivo c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Origem Comercial</param>
        /// <returns>Task of OrigemComercial</returns>
        public async System.Threading.Tasks.Task<OrigemComercial> ConsultarOrigemComercialUsingGETAsync (long? id)
        {
             ApiResponse<OrigemComercial> localVarResponse = await ConsultarOrigemComercialUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Opera\u00C3\u00A7\u00C3\u00A3o utilizada para consultar uma determinada Origem Comercial Este m\u00C3\u00A9todo permite que sejam listados os registros de uma determinada Origem Comercial existente na base do emissor. Para isso, \u00C3\u00A9 preciso informar o seu respectivo c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Origem Comercial</param>
        /// <returns>Task of ApiResponse (OrigemComercial)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrigemComercial>> ConsultarOrigemComercialUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarOrigemComercialUsingGET");
            
    
            var localVarPath = "/api/origens-comerciais/{id}";
    
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
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOrigemComercialUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarOrigemComercialUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrigemComercial>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrigemComercial) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrigemComercial)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Produto Este m\u00C3\u00A9todo permite consultar um determinado Produto a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id)</param> 
        /// <returns>Produto</returns>
        public Produto ConsultarProdutoUsingGET (long? id)
        {
             ApiResponse<Produto> localVarResponse = ConsultarProdutoUsingGETWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Produto Este m\u00C3\u00A9todo permite consultar um determinado Produto a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id)</param> 
        /// <returns>ApiResponse of Produto</returns>
        public ApiResponse< Produto > ConsultarProdutoUsingGETWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastrosGeraisApi->ConsultarProdutoUsingGET");
            
    
            var localVarPath = "/api/produtos/{id}";
    
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
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarProdutoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarProdutoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Produto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Produto) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Produto)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Produto Este m\u00C3\u00A9todo permite consultar um determinado Produto a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id)</param>
        /// <returns>Task of Produto</returns>
        public async System.Threading.Tasks.Task<Produto> ConsultarProdutoUsingGETAsync (long? id)
        {
             ApiResponse<Produto> localVarResponse = await ConsultarProdutoUsingGETAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Produto Este m\u00C3\u00A9todo permite consultar um determinado Produto a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id)</param>
        /// <returns>Task of ApiResponse (Produto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Produto>> ConsultarProdutoUsingGETAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarProdutoUsingGET");
            
    
            var localVarPath = "/api/produtos/{id}";
    
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
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarProdutoUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarProdutoUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Produto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Produto) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Produto)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00C3\u00A7o Este m\u00C3\u00A9todo permite consultar um determinado Endere\u00C3\u00A7o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id).</param> 
        /// <returns>Endereco</returns>
        public Endereco ConsultarUsingGET2 (long? id)
        {
             ApiResponse<Endereco> localVarResponse = ConsultarUsingGET2WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00C3\u00A7o Este m\u00C3\u00A9todo permite consultar um determinado Endere\u00C3\u00A7o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id).</param> 
        /// <returns>ApiResponse of Endereco</returns>
        public ApiResponse< Endereco > ConsultarUsingGET2WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastrosGeraisApi->ConsultarUsingGET2");
            
    
            var localVarPath = "/api/enderecos/{id}";
    
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
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Endereco>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Endereco) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Endereco)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00C3\u00A7o Este m\u00C3\u00A9todo permite consultar um determinado Endere\u00C3\u00A7o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id).</param>
        /// <returns>Task of Endereco</returns>
        public async System.Threading.Tasks.Task<Endereco> ConsultarUsingGET2Async (long? id)
        {
             ApiResponse<Endereco> localVarResponse = await ConsultarUsingGET2AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00C3\u00A7o Este m\u00C3\u00A9todo permite consultar um determinado Endere\u00C3\u00A7o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id).</param>
        /// <returns>Task of ApiResponse (Endereco)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Endereco>> ConsultarUsingGET2AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET2");
            
    
            var localVarPath = "/api/enderecos/{id}";
    
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
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Endereco>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Endereco) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Endereco)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param> 
        /// <returns>Pessoa</returns>
        public Pessoa ConsultarUsingGET3 (long? id)
        {
             ApiResponse<Pessoa> localVarResponse = ConsultarUsingGET3WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param> 
        /// <returns>ApiResponse of Pessoa</returns>
        public ApiResponse< Pessoa > ConsultarUsingGET3WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastrosGeraisApi->ConsultarUsingGET3");
            
    
            var localVarPath = "/api/pessoas/{id}";
    
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
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Pessoa>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Pessoa) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Pessoa)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Task of Pessoa</returns>
        public async System.Threading.Tasks.Task<Pessoa> ConsultarUsingGET3Async (long? id)
        {
             ApiResponse<Pessoa> localVarResponse = await ConsultarUsingGET3AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Task of ApiResponse (Pessoa)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Pessoa>> ConsultarUsingGET3AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET3");
            
    
            var localVarPath = "/api/pessoas/{id}";
    
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
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Pessoa>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Pessoa) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Pessoa)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Telefone Este m\u00C3\u00A9todo permite consultar um determinado Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param> 
        /// <returns>Telefone</returns>
        public Telefone ConsultarUsingGET6 (long? id)
        {
             ApiResponse<Telefone> localVarResponse = ConsultarUsingGET6WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Telefone Este m\u00C3\u00A9todo permite consultar um determinado Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param> 
        /// <returns>ApiResponse of Telefone</returns>
        public ApiResponse< Telefone > ConsultarUsingGET6WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastrosGeraisApi->ConsultarUsingGET6");
            
    
            var localVarPath = "/api/telefones/{id}";
    
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
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Telefone>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Telefone) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Telefone)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Telefone Este m\u00C3\u00A9todo permite consultar um determinado Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param>
        /// <returns>Task of Telefone</returns>
        public async System.Threading.Tasks.Task<Telefone> ConsultarUsingGET6Async (long? id)
        {
             ApiResponse<Telefone> localVarResponse = await ConsultarUsingGET6AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Telefone Este m\u00C3\u00A9todo permite consultar um determinado Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param>
        /// <returns>Task of ApiResponse (Telefone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Telefone>> ConsultarUsingGET6AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET6");
            
    
            var localVarPath = "/api/telefones/{id}";
    
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
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Telefone>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Telefone) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Telefone)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Endere\u00C3\u00A7o Este m\u00C3\u00A9todo permite consultar um determinado Tipo de Endere\u00C3\u00A7o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Endere\u00C3\u00A7o (id)</param> 
        /// <returns>TipoEndereco</returns>
        public TipoEndereco ConsultarUsingGET7 (long? id)
        {
             ApiResponse<TipoEndereco> localVarResponse = ConsultarUsingGET7WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Endere\u00C3\u00A7o Este m\u00C3\u00A9todo permite consultar um determinado Tipo de Endere\u00C3\u00A7o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Endere\u00C3\u00A7o (id)</param> 
        /// <returns>ApiResponse of TipoEndereco</returns>
        public ApiResponse< TipoEndereco > ConsultarUsingGET7WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastrosGeraisApi->ConsultarUsingGET7");
            
    
            var localVarPath = "/api/tipos-enderecos/{id}";
    
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
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoEndereco>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoEndereco) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoEndereco)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Endere\u00C3\u00A7o Este m\u00C3\u00A9todo permite consultar um determinado Tipo de Endere\u00C3\u00A7o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Endere\u00C3\u00A7o (id)</param>
        /// <returns>Task of TipoEndereco</returns>
        public async System.Threading.Tasks.Task<TipoEndereco> ConsultarUsingGET7Async (long? id)
        {
             ApiResponse<TipoEndereco> localVarResponse = await ConsultarUsingGET7AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Endere\u00C3\u00A7o Este m\u00C3\u00A9todo permite consultar um determinado Tipo de Endere\u00C3\u00A7o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Endere\u00C3\u00A7o (id)</param>
        /// <returns>Task of ApiResponse (TipoEndereco)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoEndereco>> ConsultarUsingGET7AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET7");
            
    
            var localVarPath = "/api/tipos-enderecos/{id}";
    
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
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoEndereco>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoEndereco) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoEndereco)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Telefone Este m\u00C3\u00A9todo permite consultar um determinado Tipo de Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id)</param> 
        /// <returns>TipoTelefone</returns>
        public TipoTelefone ConsultarUsingGET8 (long? id)
        {
             ApiResponse<TipoTelefone> localVarResponse = ConsultarUsingGET8WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Telefone Este m\u00C3\u00A9todo permite consultar um determinado Tipo de Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id)</param> 
        /// <returns>ApiResponse of TipoTelefone</returns>
        public ApiResponse< TipoTelefone > ConsultarUsingGET8WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastrosGeraisApi->ConsultarUsingGET8");
            
    
            var localVarPath = "/api/tipos-telefones/{id}";
    
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
            
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET8: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET8: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TipoTelefone>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoTelefone) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoTelefone)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Telefone Este m\u00C3\u00A9todo permite consultar um determinado Tipo de Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id)</param>
        /// <returns>Task of TipoTelefone</returns>
        public async System.Threading.Tasks.Task<TipoTelefone> ConsultarUsingGET8Async (long? id)
        {
             ApiResponse<TipoTelefone> localVarResponse = await ConsultarUsingGET8AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Tipo de Telefone Este m\u00C3\u00A9todo permite consultar um determinado Tipo de Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id)</param>
        /// <returns>Task of ApiResponse (TipoTelefone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TipoTelefone>> ConsultarUsingGET8AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET8");
            
    
            var localVarPath = "/api/tipos-telefones/{id}";
    
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
            
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET8: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET8: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TipoTelefone>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TipoTelefone) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TipoTelefone)));
            
        }
        
        /// <summary>
        /// Opera\u00C3\u00A7\u00C3\u00A3o utilizada para listar Origens Comerciais Este m\u00C3\u00A9todo permite que sejam listadas as Origens Comerciais existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="id">Id da origem comercial (optional)</param> 
        /// <param name="nome">Nome da origem comercial (optional)</param> 
        /// <param name="status">Status da origem comercial (optional)</param> 
        /// <returns>PageOrigensComerciais</returns>
        public PageOrigensComerciais ListarOrigensComerciaisUsingGET (int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null)
        {
             ApiResponse<PageOrigensComerciais> localVarResponse = ListarOrigensComerciaisUsingGETWithHttpInfo(page, limit, id, nome, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Opera\u00C3\u00A7\u00C3\u00A3o utilizada para listar Origens Comerciais Este m\u00C3\u00A9todo permite que sejam listadas as Origens Comerciais existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="id">Id da origem comercial (optional)</param> 
        /// <param name="nome">Nome da origem comercial (optional)</param> 
        /// <param name="status">Status da origem comercial (optional)</param> 
        /// <returns>ApiResponse of PageOrigensComerciais</returns>
        public ApiResponse< PageOrigensComerciais > ListarOrigensComerciaisUsingGETWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null)
        {
            
    
            var localVarPath = "/api/origens-comerciais";
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarOrigensComerciaisUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarOrigensComerciaisUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageOrigensComerciais>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOrigensComerciais) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOrigensComerciais)));
            
        }

        
        /// <summary>
        /// Opera\u00C3\u00A7\u00C3\u00A3o utilizada para listar Origens Comerciais Este m\u00C3\u00A9todo permite que sejam listadas as Origens Comerciais existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">Id da origem comercial (optional)</param>
        /// <param name="nome">Nome da origem comercial (optional)</param>
        /// <param name="status">Status da origem comercial (optional)</param>
        /// <returns>Task of PageOrigensComerciais</returns>
        public async System.Threading.Tasks.Task<PageOrigensComerciais> ListarOrigensComerciaisUsingGETAsync (int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null)
        {
             ApiResponse<PageOrigensComerciais> localVarResponse = await ListarOrigensComerciaisUsingGETAsyncWithHttpInfo(page, limit, id, nome, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Opera\u00C3\u00A7\u00C3\u00A3o utilizada para listar Origens Comerciais Este m\u00C3\u00A9todo permite que sejam listadas as Origens Comerciais existentes na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">Id da origem comercial (optional)</param>
        /// <param name="nome">Nome da origem comercial (optional)</param>
        /// <param name="status">Status da origem comercial (optional)</param>
        /// <returns>Task of ApiResponse (PageOrigensComerciais)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageOrigensComerciais>> ListarOrigensComerciaisUsingGETAsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null)
        {
            
    
            var localVarPath = "/api/origens-comerciais";
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarOrigensComerciaisUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarOrigensComerciaisUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageOrigensComerciais>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageOrigensComerciais) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageOrigensComerciais)));
            
        }
        
        /// <summary>
        /// Lista os Produtos do Emissor Este m\u00C3\u00A9todo permite que sejam listados os Produtos existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param> 
        /// <param name="nome">Descri\u00C3\u00A7\u00C3\u00A3o do Nome do Produto. (optional)</param> 
        /// <param name="status">Representa o Status do Produto, onde: (\&quot;0\&quot;: Inativo), (\&quot;1\&quot;: Ativo). (optional)</param> 
        /// <returns>ListaProdutos</returns>
        public ListaProdutos ListarProdutosUsingGET (int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null)
        {
             ApiResponse<ListaProdutos> localVarResponse = ListarProdutosUsingGETWithHttpInfo(page, limit, id, nome, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Produtos do Emissor Este m\u00C3\u00A9todo permite que sejam listados os Produtos existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param> 
        /// <param name="nome">Descri\u00C3\u00A7\u00C3\u00A3o do Nome do Produto. (optional)</param> 
        /// <param name="status">Representa o Status do Produto, onde: (\&quot;0\&quot;: Inativo), (\&quot;1\&quot;: Ativo). (optional)</param> 
        /// <returns>ApiResponse of ListaProdutos</returns>
        public ApiResponse< ListaProdutos > ListarProdutosUsingGETWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null)
        {
            
    
            var localVarPath = "/api/produtos";
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarProdutosUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarProdutosUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ListaProdutos>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ListaProdutos) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListaProdutos)));
            
        }

        
        /// <summary>
        /// Lista os Produtos do Emissor Este m\u00C3\u00A9todo permite que sejam listados os Produtos existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="nome">Descri\u00C3\u00A7\u00C3\u00A3o do Nome do Produto. (optional)</param>
        /// <param name="status">Representa o Status do Produto, onde: (\&quot;0\&quot;: Inativo), (\&quot;1\&quot;: Ativo). (optional)</param>
        /// <returns>Task of ListaProdutos</returns>
        public async System.Threading.Tasks.Task<ListaProdutos> ListarProdutosUsingGETAsync (int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null)
        {
             ApiResponse<ListaProdutos> localVarResponse = await ListarProdutosUsingGETAsyncWithHttpInfo(page, limit, id, nome, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Produtos do Emissor Este m\u00C3\u00A9todo permite que sejam listados os Produtos existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="nome">Descri\u00C3\u00A7\u00C3\u00A3o do Nome do Produto. (optional)</param>
        /// <param name="status">Representa o Status do Produto, onde: (\&quot;0\&quot;: Inativo), (\&quot;1\&quot;: Ativo). (optional)</param>
        /// <returns>Task of ApiResponse (ListaProdutos)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ListaProdutos>> ListarProdutosUsingGETAsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null, int? status = null)
        {
            
    
            var localVarPath = "/api/produtos";
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarProdutosUsingGET: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarProdutosUsingGET: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ListaProdutos>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ListaProdutos) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ListaProdutos)));
            
        }
        
        /// <summary>
        /// Lista os Endere\u00C3\u00A7os cadastrados para o Emissor Este m\u00C3\u00A9todo permite que sejam listados os Endere\u00C3\u00A7os existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o endere\u00C3\u00A7o pertence (id) (optional)</param> 
        /// <param name="idTipoEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Tipo Endere\u00C3\u00A7o (id) (optional)</param> 
        /// <param name="cep">Apresenta o C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP) (optional)</param> 
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param> 
        /// <param name="numero">Apresenta o n\u00C3\u00BAmero do endere\u00C3\u00A7o (optional)</param> 
        /// <param name="complemento">Apresenta descri\u00C3\u00A7oes complementares referente ao endere\u00C3\u00A7o (optional)</param> 
        /// <param name="pontoReferencia">Apresenta a descri\u00C3\u00A7\u00C3\u00A3o de ponto de refer\u00C3\u00AAncia do endere\u00C3\u00A7o (optional)</param> 
        /// <param name="bairro">Apresenta nome do bairro (optional)</param> 
        /// <param name="cidade">Apresenta nome da cidade (optional)</param> 
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param> 
        /// <param name="pais">Apresenta nome do Pais (optional)</param> 
        /// <param name="dataInclusao">Apresenta a data em que fora cadastrado o Endere\u00C3\u00A7o (optional)</param> 
        /// <param name="dataUltimaAtualizacao">Data em que fora realizada a \u00C3\u00BAltima mudan\u00C3\u00A7a neste registro de endere\u00C3\u00A7o. Quando n\u00C3\u00A3o tiver ocorrido mudan\u00C3\u00A7a, conter\u00C3\u00A1 a mesma informa\u00C3\u00A7\u00C3\u00A3o que o campo dataInclusao (optional)</param> 
        /// <returns>PageEnderecos</returns>
        public PageEnderecos ListarUsingGET2 (int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, DateTime? dataInclusao = null, DateTime? dataUltimaAtualizacao = null)
        {
             ApiResponse<PageEnderecos> localVarResponse = ListarUsingGET2WithHttpInfo(page, limit, id, idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais, dataInclusao, dataUltimaAtualizacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Endere\u00C3\u00A7os cadastrados para o Emissor Este m\u00C3\u00A9todo permite que sejam listados os Endere\u00C3\u00A7os existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o endere\u00C3\u00A7o pertence (id) (optional)</param> 
        /// <param name="idTipoEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Tipo Endere\u00C3\u00A7o (id) (optional)</param> 
        /// <param name="cep">Apresenta o C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP) (optional)</param> 
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param> 
        /// <param name="numero">Apresenta o n\u00C3\u00BAmero do endere\u00C3\u00A7o (optional)</param> 
        /// <param name="complemento">Apresenta descri\u00C3\u00A7oes complementares referente ao endere\u00C3\u00A7o (optional)</param> 
        /// <param name="pontoReferencia">Apresenta a descri\u00C3\u00A7\u00C3\u00A3o de ponto de refer\u00C3\u00AAncia do endere\u00C3\u00A7o (optional)</param> 
        /// <param name="bairro">Apresenta nome do bairro (optional)</param> 
        /// <param name="cidade">Apresenta nome da cidade (optional)</param> 
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param> 
        /// <param name="pais">Apresenta nome do Pais (optional)</param> 
        /// <param name="dataInclusao">Apresenta a data em que fora cadastrado o Endere\u00C3\u00A7o (optional)</param> 
        /// <param name="dataUltimaAtualizacao">Data em que fora realizada a \u00C3\u00BAltima mudan\u00C3\u00A7a neste registro de endere\u00C3\u00A7o. Quando n\u00C3\u00A3o tiver ocorrido mudan\u00C3\u00A7a, conter\u00C3\u00A1 a mesma informa\u00C3\u00A7\u00C3\u00A3o que o campo dataInclusao (optional)</param> 
        /// <returns>ApiResponse of PageEnderecos</returns>
        public ApiResponse< PageEnderecos > ListarUsingGET2WithHttpInfo (int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, DateTime? dataInclusao = null, DateTime? dataUltimaAtualizacao = null)
        {
            
    
            var localVarPath = "/api/enderecos";
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idTipoEndereco != null) localVarQueryParams.Add("idTipoEndereco", Configuration.ApiClient.ParameterToString(idTipoEndereco)); // query parameter
            if (cep != null) localVarQueryParams.Add("cep", Configuration.ApiClient.ParameterToString(cep)); // query parameter
            if (logradouro != null) localVarQueryParams.Add("logradouro", Configuration.ApiClient.ParameterToString(logradouro)); // query parameter
            if (numero != null) localVarQueryParams.Add("numero", Configuration.ApiClient.ParameterToString(numero)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            if (pontoReferencia != null) localVarQueryParams.Add("pontoReferencia", Configuration.ApiClient.ParameterToString(pontoReferencia)); // query parameter
            if (bairro != null) localVarQueryParams.Add("bairro", Configuration.ApiClient.ParameterToString(bairro)); // query parameter
            if (cidade != null) localVarQueryParams.Add("cidade", Configuration.ApiClient.ParameterToString(cidade)); // query parameter
            if (uf != null) localVarQueryParams.Add("uf", Configuration.ApiClient.ParameterToString(uf)); // query parameter
            if (pais != null) localVarQueryParams.Add("pais", Configuration.ApiClient.ParameterToString(pais)); // query parameter
            if (dataInclusao != null) localVarQueryParams.Add("dataInclusao", Configuration.ApiClient.ParameterToString(dataInclusao)); // query parameter
            if (dataUltimaAtualizacao != null) localVarQueryParams.Add("dataUltimaAtualizacao", Configuration.ApiClient.ParameterToString(dataUltimaAtualizacao)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageEnderecos>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEnderecos) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEnderecos)));
            
        }

        
        /// <summary>
        /// Lista os Endere\u00C3\u00A7os cadastrados para o Emissor Este m\u00C3\u00A9todo permite que sejam listados os Endere\u00C3\u00A7os existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o endere\u00C3\u00A7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Tipo Endere\u00C3\u00A7o (id) (optional)</param>
        /// <param name="cep">Apresenta o C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP) (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00C3\u00BAmero do endere\u00C3\u00A7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00C3\u00A7oes complementares referente ao endere\u00C3\u00A7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00C3\u00A7\u00C3\u00A3o de ponto de refer\u00C3\u00AAncia do endere\u00C3\u00A7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pais (optional)</param>
        /// <param name="dataInclusao">Apresenta a data em que fora cadastrado o Endere\u00C3\u00A7o (optional)</param>
        /// <param name="dataUltimaAtualizacao">Data em que fora realizada a \u00C3\u00BAltima mudan\u00C3\u00A7a neste registro de endere\u00C3\u00A7o. Quando n\u00C3\u00A3o tiver ocorrido mudan\u00C3\u00A7a, conter\u00C3\u00A1 a mesma informa\u00C3\u00A7\u00C3\u00A3o que o campo dataInclusao (optional)</param>
        /// <returns>Task of PageEnderecos</returns>
        public async System.Threading.Tasks.Task<PageEnderecos> ListarUsingGET2Async (int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, DateTime? dataInclusao = null, DateTime? dataUltimaAtualizacao = null)
        {
             ApiResponse<PageEnderecos> localVarResponse = await ListarUsingGET2AsyncWithHttpInfo(page, limit, id, idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais, dataInclusao, dataUltimaAtualizacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Endere\u00C3\u00A7os cadastrados para o Emissor Este m\u00C3\u00A9todo permite que sejam listados os Endere\u00C3\u00A7os existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o endere\u00C3\u00A7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Tipo Endere\u00C3\u00A7o (id) (optional)</param>
        /// <param name="cep">Apresenta o C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP) (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00C3\u00BAmero do endere\u00C3\u00A7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00C3\u00A7oes complementares referente ao endere\u00C3\u00A7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00C3\u00A7\u00C3\u00A3o de ponto de refer\u00C3\u00AAncia do endere\u00C3\u00A7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pais (optional)</param>
        /// <param name="dataInclusao">Apresenta a data em que fora cadastrado o Endere\u00C3\u00A7o (optional)</param>
        /// <param name="dataUltimaAtualizacao">Data em que fora realizada a \u00C3\u00BAltima mudan\u00C3\u00A7a neste registro de endere\u00C3\u00A7o. Quando n\u00C3\u00A3o tiver ocorrido mudan\u00C3\u00A7a, conter\u00C3\u00A1 a mesma informa\u00C3\u00A7\u00C3\u00A3o que o campo dataInclusao (optional)</param>
        /// <returns>Task of ApiResponse (PageEnderecos)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageEnderecos>> ListarUsingGET2AsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, DateTime? dataInclusao = null, DateTime? dataUltimaAtualizacao = null)
        {
            
    
            var localVarPath = "/api/enderecos";
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idTipoEndereco != null) localVarQueryParams.Add("idTipoEndereco", Configuration.ApiClient.ParameterToString(idTipoEndereco)); // query parameter
            if (cep != null) localVarQueryParams.Add("cep", Configuration.ApiClient.ParameterToString(cep)); // query parameter
            if (logradouro != null) localVarQueryParams.Add("logradouro", Configuration.ApiClient.ParameterToString(logradouro)); // query parameter
            if (numero != null) localVarQueryParams.Add("numero", Configuration.ApiClient.ParameterToString(numero)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            if (pontoReferencia != null) localVarQueryParams.Add("pontoReferencia", Configuration.ApiClient.ParameterToString(pontoReferencia)); // query parameter
            if (bairro != null) localVarQueryParams.Add("bairro", Configuration.ApiClient.ParameterToString(bairro)); // query parameter
            if (cidade != null) localVarQueryParams.Add("cidade", Configuration.ApiClient.ParameterToString(cidade)); // query parameter
            if (uf != null) localVarQueryParams.Add("uf", Configuration.ApiClient.ParameterToString(uf)); // query parameter
            if (pais != null) localVarQueryParams.Add("pais", Configuration.ApiClient.ParameterToString(pais)); // query parameter
            if (dataInclusao != null) localVarQueryParams.Add("dataInclusao", Configuration.ApiClient.ParameterToString(dataInclusao)); // query parameter
            if (dataUltimaAtualizacao != null) localVarQueryParams.Add("dataUltimaAtualizacao", Configuration.ApiClient.ParameterToString(dataUltimaAtualizacao)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageEnderecos>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEnderecos) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEnderecos)));
            
        }
        
        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id). (optional)</param> 
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;. (optional)</param> 
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica). (optional)</param> 
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param> 
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param> 
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param> 
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param> 
        /// <returns>PagePessoas</returns>
        public PagePessoas ListarUsingGET3 (int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, DateTime? dataNascimento = null, string sexo = null)
        {
             ApiResponse<PagePessoas> localVarResponse = ListarUsingGET3WithHttpInfo(page, limit, id, nome, tipo, cpf, cnpj, dataNascimento, sexo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id). (optional)</param> 
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;. (optional)</param> 
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica). (optional)</param> 
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param> 
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param> 
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param> 
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param> 
        /// <returns>ApiResponse of PagePessoas</returns>
        public ApiResponse< PagePessoas > ListarUsingGET3WithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, DateTime? dataNascimento = null, string sexo = null)
        {
            
    
            var localVarPath = "/api/pessoas";
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (tipo != null) localVarQueryParams.Add("tipo", Configuration.ApiClient.ParameterToString(tipo)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (cnpj != null) localVarQueryParams.Add("cnpj", Configuration.ApiClient.ParameterToString(cnpj)); // query parameter
            if (dataNascimento != null) localVarQueryParams.Add("dataNascimento", Configuration.ApiClient.ParameterToString(dataNascimento)); // query parameter
            if (sexo != null) localVarQueryParams.Add("sexo", Configuration.ApiClient.ParameterToString(sexo)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePessoas>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoas) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoas)));
            
        }

        
        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id). (optional)</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;. (optional)</param>
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica). (optional)</param>
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param>
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <returns>Task of PagePessoas</returns>
        public async System.Threading.Tasks.Task<PagePessoas> ListarUsingGET3Async (int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, DateTime? dataNascimento = null, string sexo = null)
        {
             ApiResponse<PagePessoas> localVarResponse = await ListarUsingGET3AsyncWithHttpInfo(page, limit, id, nome, tipo, cpf, cnpj, dataNascimento, sexo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id). (optional)</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;. (optional)</param>
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica). (optional)</param>
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param>
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoas)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePessoas>> ListarUsingGET3AsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, DateTime? dataNascimento = null, string sexo = null)
        {
            
    
            var localVarPath = "/api/pessoas";
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (tipo != null) localVarQueryParams.Add("tipo", Configuration.ApiClient.ParameterToString(tipo)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (cnpj != null) localVarQueryParams.Add("cnpj", Configuration.ApiClient.ParameterToString(cnpj)); // query parameter
            if (dataNascimento != null) localVarQueryParams.Add("dataNascimento", Configuration.ApiClient.ParameterToString(dataNascimento)); // query parameter
            if (sexo != null) localVarQueryParams.Add("sexo", Configuration.ApiClient.ParameterToString(sexo)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePessoas>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoas) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoas)));
            
        }
        
        /// <summary>
        /// Lista os Portadores existentes Este m\u00C3\u00A9todo permite que sejam listados os portadores cadastrados na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id). (optional)</param> 
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id). (optional)</param> 
        /// <param name="idParentesco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Parentesco (id) (optional)</param> 
        /// <param name="tipoPortador">Apresenta o tipo do Portador do cart\u00C3\u00A3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional). (optional)</param> 
        /// <param name="nomeImpresso">Apresenta o nome a ser impresso no cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="idImagem">Apresenta o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da imagem do cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="idTipoCartao">Apresenta o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo do cart\u00C3\u00A3o (id), que ser\u00C3\u00A1 utilizado para gerar os cart\u00C3\u00B5es deste portador, vinculados a sua respectiva conta atrav\u00C3\u00A9s do campo idConta. (optional)</param> 
        /// <param name="flagAtivo">Quanto ativa, indica que o cadastro do Portador est\u00C3\u00A1 ativo, em emissores que realizam este tipo de gest\u00C3\u00A3o. (optional)</param> 
        /// <param name="dataCadastroPortador">Apresenta a data em que o Portador fora cadastrado, quando possuir esta informa\u00C3\u00A7\u00C3\u00A3o. (optional)</param> 
        /// <param name="dataCancelamentoPortador">Apresenta a data em que o Portador fora cancelado, quando possuir esta informa\u00C3\u00A7\u00C3\u00A3o. (optional)</param> 
        /// <returns>PagePortador</returns>
        public PagePortador ListarUsingGET4 (int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idImagem = null, long? idTipoCartao = null, int? flagAtivo = null, DateTime? dataCadastroPortador = null, DateTime? dataCancelamentoPortador = null)
        {
             ApiResponse<PagePortador> localVarResponse = ListarUsingGET4WithHttpInfo(page, limit, idConta, idProduto, idPessoa, idParentesco, tipoPortador, nomeImpresso, idImagem, idTipoCartao, flagAtivo, dataCadastroPortador, dataCancelamentoPortador);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Portadores existentes Este m\u00C3\u00A9todo permite que sejam listados os portadores cadastrados na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id). (optional)</param> 
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id). (optional)</param> 
        /// <param name="idParentesco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Parentesco (id) (optional)</param> 
        /// <param name="tipoPortador">Apresenta o tipo do Portador do cart\u00C3\u00A3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional). (optional)</param> 
        /// <param name="nomeImpresso">Apresenta o nome a ser impresso no cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="idImagem">Apresenta o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da imagem do cart\u00C3\u00A3o. (optional)</param> 
        /// <param name="idTipoCartao">Apresenta o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo do cart\u00C3\u00A3o (id), que ser\u00C3\u00A1 utilizado para gerar os cart\u00C3\u00B5es deste portador, vinculados a sua respectiva conta atrav\u00C3\u00A9s do campo idConta. (optional)</param> 
        /// <param name="flagAtivo">Quanto ativa, indica que o cadastro do Portador est\u00C3\u00A1 ativo, em emissores que realizam este tipo de gest\u00C3\u00A3o. (optional)</param> 
        /// <param name="dataCadastroPortador">Apresenta a data em que o Portador fora cadastrado, quando possuir esta informa\u00C3\u00A7\u00C3\u00A3o. (optional)</param> 
        /// <param name="dataCancelamentoPortador">Apresenta a data em que o Portador fora cancelado, quando possuir esta informa\u00C3\u00A7\u00C3\u00A3o. (optional)</param> 
        /// <returns>ApiResponse of PagePortador</returns>
        public ApiResponse< PagePortador > ListarUsingGET4WithHttpInfo (int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idImagem = null, long? idTipoCartao = null, int? flagAtivo = null, DateTime? dataCadastroPortador = null, DateTime? dataCancelamentoPortador = null)
        {
            
    
            var localVarPath = "/api/portadores";
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idParentesco != null) localVarQueryParams.Add("idParentesco", Configuration.ApiClient.ParameterToString(idParentesco)); // query parameter
            if (tipoPortador != null) localVarQueryParams.Add("tipoPortador", Configuration.ApiClient.ParameterToString(tipoPortador)); // query parameter
            if (nomeImpresso != null) localVarQueryParams.Add("nomeImpresso", Configuration.ApiClient.ParameterToString(nomeImpresso)); // query parameter
            if (idImagem != null) localVarQueryParams.Add("idImagem", Configuration.ApiClient.ParameterToString(idImagem)); // query parameter
            if (idTipoCartao != null) localVarQueryParams.Add("idTipoCartao", Configuration.ApiClient.ParameterToString(idTipoCartao)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            if (dataCadastroPortador != null) localVarQueryParams.Add("dataCadastroPortador", Configuration.ApiClient.ParameterToString(dataCadastroPortador)); // query parameter
            if (dataCancelamentoPortador != null) localVarQueryParams.Add("dataCancelamentoPortador", Configuration.ApiClient.ParameterToString(dataCancelamentoPortador)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePortador>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePortador) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePortador)));
            
        }

        
        /// <summary>
        /// Lista os Portadores existentes Este m\u00C3\u00A9todo permite que sejam listados os portadores cadastrados na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id). (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id). (optional)</param>
        /// <param name="idParentesco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Parentesco (id) (optional)</param>
        /// <param name="tipoPortador">Apresenta o tipo do Portador do cart\u00C3\u00A3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional). (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome a ser impresso no cart\u00C3\u00A3o. (optional)</param>
        /// <param name="idImagem">Apresenta o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da imagem do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="idTipoCartao">Apresenta o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo do cart\u00C3\u00A3o (id), que ser\u00C3\u00A1 utilizado para gerar os cart\u00C3\u00B5es deste portador, vinculados a sua respectiva conta atrav\u00C3\u00A9s do campo idConta. (optional)</param>
        /// <param name="flagAtivo">Quanto ativa, indica que o cadastro do Portador est\u00C3\u00A1 ativo, em emissores que realizam este tipo de gest\u00C3\u00A3o. (optional)</param>
        /// <param name="dataCadastroPortador">Apresenta a data em que o Portador fora cadastrado, quando possuir esta informa\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="dataCancelamentoPortador">Apresenta a data em que o Portador fora cancelado, quando possuir esta informa\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <returns>Task of PagePortador</returns>
        public async System.Threading.Tasks.Task<PagePortador> ListarUsingGET4Async (int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idImagem = null, long? idTipoCartao = null, int? flagAtivo = null, DateTime? dataCadastroPortador = null, DateTime? dataCancelamentoPortador = null)
        {
             ApiResponse<PagePortador> localVarResponse = await ListarUsingGET4AsyncWithHttpInfo(page, limit, idConta, idProduto, idPessoa, idParentesco, tipoPortador, nomeImpresso, idImagem, idTipoCartao, flagAtivo, dataCadastroPortador, dataCancelamentoPortador);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Portadores existentes Este m\u00C3\u00A9todo permite que sejam listados os portadores cadastrados na base do emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="idConta">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Conta (id). (optional)</param>
        /// <param name="idProduto">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Produto (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id). (optional)</param>
        /// <param name="idParentesco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Parentesco (id) (optional)</param>
        /// <param name="tipoPortador">Apresenta o tipo do Portador do cart\u00C3\u00A3o, sendo: (&#39;T&#39;: Titular, &#39;A&#39;: Adicional). (optional)</param>
        /// <param name="nomeImpresso">Apresenta o nome a ser impresso no cart\u00C3\u00A3o. (optional)</param>
        /// <param name="idImagem">Apresenta o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da imagem do cart\u00C3\u00A3o. (optional)</param>
        /// <param name="idTipoCartao">Apresenta o c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo do cart\u00C3\u00A3o (id), que ser\u00C3\u00A1 utilizado para gerar os cart\u00C3\u00B5es deste portador, vinculados a sua respectiva conta atrav\u00C3\u00A9s do campo idConta. (optional)</param>
        /// <param name="flagAtivo">Quanto ativa, indica que o cadastro do Portador est\u00C3\u00A1 ativo, em emissores que realizam este tipo de gest\u00C3\u00A3o. (optional)</param>
        /// <param name="dataCadastroPortador">Apresenta a data em que o Portador fora cadastrado, quando possuir esta informa\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <param name="dataCancelamentoPortador">Apresenta a data em que o Portador fora cancelado, quando possuir esta informa\u00C3\u00A7\u00C3\u00A3o. (optional)</param>
        /// <returns>Task of ApiResponse (PagePortador)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePortador>> ListarUsingGET4AsyncWithHttpInfo (int? page = null, int? limit = null, long? idConta = null, long? idProduto = null, long? idPessoa = null, long? idParentesco = null, string tipoPortador = null, string nomeImpresso = null, long? idImagem = null, long? idTipoCartao = null, int? flagAtivo = null, DateTime? dataCadastroPortador = null, DateTime? dataCancelamentoPortador = null)
        {
            
    
            var localVarPath = "/api/portadores";
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (idProduto != null) localVarQueryParams.Add("idProduto", Configuration.ApiClient.ParameterToString(idProduto)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idParentesco != null) localVarQueryParams.Add("idParentesco", Configuration.ApiClient.ParameterToString(idParentesco)); // query parameter
            if (tipoPortador != null) localVarQueryParams.Add("tipoPortador", Configuration.ApiClient.ParameterToString(tipoPortador)); // query parameter
            if (nomeImpresso != null) localVarQueryParams.Add("nomeImpresso", Configuration.ApiClient.ParameterToString(nomeImpresso)); // query parameter
            if (idImagem != null) localVarQueryParams.Add("idImagem", Configuration.ApiClient.ParameterToString(idImagem)); // query parameter
            if (idTipoCartao != null) localVarQueryParams.Add("idTipoCartao", Configuration.ApiClient.ParameterToString(idTipoCartao)); // query parameter
            if (flagAtivo != null) localVarQueryParams.Add("flagAtivo", Configuration.ApiClient.ParameterToString(flagAtivo)); // query parameter
            if (dataCadastroPortador != null) localVarQueryParams.Add("dataCadastroPortador", Configuration.ApiClient.ParameterToString(dataCadastroPortador)); // query parameter
            if (dataCancelamentoPortador != null) localVarQueryParams.Add("dataCancelamentoPortador", Configuration.ApiClient.ParameterToString(dataCancelamentoPortador)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePortador>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePortador) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePortador)));
            
        }
        
        /// <summary>
        /// Lista os Telefones cadastrados no Emissor Este m\u00C3\u00A9todo permite que sejam listados os Telefones existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id). (optional)</param> 
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param> 
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param> 
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param> 
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param> 
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param> 
        /// <returns>PageTelefones</returns>
        public PageTelefones ListarUsingGET7 (int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null)
        {
             ApiResponse<PageTelefones> localVarResponse = ListarUsingGET7WithHttpInfo(page, limit, id, idTipoTelefone, idPessoa, ddd, telefone, ramal, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Telefones cadastrados no Emissor Este m\u00C3\u00A9todo permite que sejam listados os Telefones existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id). (optional)</param> 
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param> 
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param> 
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param> 
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param> 
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param> 
        /// <returns>ApiResponse of PageTelefones</returns>
        public ApiResponse< PageTelefones > ListarUsingGET7WithHttpInfo (int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null)
        {
            
    
            var localVarPath = "/api/telefones";
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idTipoTelefone != null) localVarQueryParams.Add("idTipoTelefone", Configuration.ApiClient.ParameterToString(idTipoTelefone)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (ddd != null) localVarQueryParams.Add("ddd", Configuration.ApiClient.ParameterToString(ddd)); // query parameter
            if (telefone != null) localVarQueryParams.Add("telefone", Configuration.ApiClient.ParameterToString(telefone)); // query parameter
            if (ramal != null) localVarQueryParams.Add("ramal", Configuration.ApiClient.ParameterToString(ramal)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTelefones>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTelefones) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTelefones)));
            
        }

        
        /// <summary>
        /// Lista os Telefones cadastrados no Emissor Este m\u00C3\u00A9todo permite que sejam listados os Telefones existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id). (optional)</param>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <returns>Task of PageTelefones</returns>
        public async System.Threading.Tasks.Task<PageTelefones> ListarUsingGET7Async (int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null)
        {
             ApiResponse<PageTelefones> localVarResponse = await ListarUsingGET7AsyncWithHttpInfo(page, limit, id, idTipoTelefone, idPessoa, ddd, telefone, ramal, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Telefones cadastrados no Emissor Este m\u00C3\u00A9todo permite que sejam listados os Telefones existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id). (optional)</param>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <returns>Task of ApiResponse (PageTelefones)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTelefones>> ListarUsingGET7AsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null)
        {
            
    
            var localVarPath = "/api/telefones";
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idTipoTelefone != null) localVarQueryParams.Add("idTipoTelefone", Configuration.ApiClient.ParameterToString(idTipoTelefone)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (ddd != null) localVarQueryParams.Add("ddd", Configuration.ApiClient.ParameterToString(ddd)); // query parameter
            if (telefone != null) localVarQueryParams.Add("telefone", Configuration.ApiClient.ParameterToString(telefone)); // query parameter
            if (ramal != null) localVarQueryParams.Add("ramal", Configuration.ApiClient.ParameterToString(ramal)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET7: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET7: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTelefones>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTelefones) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTelefones)));
            
        }
        
        /// <summary>
        /// Lista as op\u00C3\u00B5es de Tipos de Endere\u00C3\u00A7os do Emissor  Este m\u00C3\u00A9todo permite que sejam listados os Tipos de Endere\u00C3\u00A7os existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Endere\u00C3\u00A7o (id) (optional)</param> 
        /// <param name="nome">Nome do Tipo do Endere\u00C3\u00A7o (optional)</param> 
        /// <returns>PageTiposEndereco</returns>
        public PageTiposEndereco ListarUsingGET8 (int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageTiposEndereco> localVarResponse = ListarUsingGET8WithHttpInfo(page, limit, id, nome);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as op\u00C3\u00B5es de Tipos de Endere\u00C3\u00A7os do Emissor  Este m\u00C3\u00A9todo permite que sejam listados os Tipos de Endere\u00C3\u00A7os existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Endere\u00C3\u00A7o (id) (optional)</param> 
        /// <param name="nome">Nome do Tipo do Endere\u00C3\u00A7o (optional)</param> 
        /// <returns>ApiResponse of PageTiposEndereco</returns>
        public ApiResponse< PageTiposEndereco > ListarUsingGET8WithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null)
        {
            
    
            var localVarPath = "/api/tipos-enderecos";
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET8: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET8: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTiposEndereco>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTiposEndereco) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTiposEndereco)));
            
        }

        
        /// <summary>
        /// Lista as op\u00C3\u00B5es de Tipos de Endere\u00C3\u00A7os do Emissor  Este m\u00C3\u00A9todo permite que sejam listados os Tipos de Endere\u00C3\u00A7os existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Endere\u00C3\u00A7o (id) (optional)</param>
        /// <param name="nome">Nome do Tipo do Endere\u00C3\u00A7o (optional)</param>
        /// <returns>Task of PageTiposEndereco</returns>
        public async System.Threading.Tasks.Task<PageTiposEndereco> ListarUsingGET8Async (int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageTiposEndereco> localVarResponse = await ListarUsingGET8AsyncWithHttpInfo(page, limit, id, nome);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as op\u00C3\u00B5es de Tipos de Endere\u00C3\u00A7os do Emissor  Este m\u00C3\u00A9todo permite que sejam listados os Tipos de Endere\u00C3\u00A7os existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Endere\u00C3\u00A7o (id) (optional)</param>
        /// <param name="nome">Nome do Tipo do Endere\u00C3\u00A7o (optional)</param>
        /// <returns>Task of ApiResponse (PageTiposEndereco)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTiposEndereco>> ListarUsingGET8AsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null)
        {
            
    
            var localVarPath = "/api/tipos-enderecos";
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET8: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET8: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTiposEndereco>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTiposEndereco) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTiposEndereco)));
            
        }
        
        /// <summary>
        /// Lista os Tipos de Telefones Este m\u00C3\u00A9todo permite que sejam listados os Tipos de Telefones existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param> 
        /// <param name="nome">Nome do Tipo do Telefone (optional)</param> 
        /// <returns>PageTipoTelefones</returns>
        public PageTipoTelefones ListarUsingGET9 (int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageTipoTelefones> localVarResponse = ListarUsingGET9WithHttpInfo(page, limit, id, nome);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Tipos de Telefones Este m\u00C3\u00A9todo permite que sejam listados os Tipos de Telefones existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param> 
        /// <param name="nome">Nome do Tipo do Telefone (optional)</param> 
        /// <returns>ApiResponse of PageTipoTelefones</returns>
        public ApiResponse< PageTipoTelefones > ListarUsingGET9WithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null)
        {
            
    
            var localVarPath = "/api/tipos-telefones";
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET9: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET9: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTipoTelefones>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoTelefones) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoTelefones)));
            
        }

        
        /// <summary>
        /// Lista os Tipos de Telefones Este m\u00C3\u00A9todo permite que sejam listados os Tipos de Telefones existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="nome">Nome do Tipo do Telefone (optional)</param>
        /// <returns>Task of PageTipoTelefones</returns>
        public async System.Threading.Tasks.Task<PageTipoTelefones> ListarUsingGET9Async (int? page = null, int? limit = null, long? id = null, string nome = null)
        {
             ApiResponse<PageTipoTelefones> localVarResponse = await ListarUsingGET9AsyncWithHttpInfo(page, limit, id, nome);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Tipos de Telefones Este m\u00C3\u00A9todo permite que sejam listados os Tipos de Telefones existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 100, Max = 100) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="nome">Nome do Tipo do Telefone (optional)</param>
        /// <returns>Task of ApiResponse (PageTipoTelefones)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTipoTelefones>> ListarUsingGET9AsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null)
        {
            
    
            var localVarPath = "/api/tipos-telefones";
    
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
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET9: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET9: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTipoTelefones>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTipoTelefones) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTipoTelefones)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de um novo Endere\u00C3\u00A7o Este m\u00C3\u00A9todo permite que seja cadastrado um novo Endere\u00C3\u00A7o na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o endere\u00C3\u00A7o pertence (id) (optional)</param> 
        /// <param name="idTipoEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Tipo Endere\u00C3\u00A7o (id) (optional)</param> 
        /// <param name="cep">Apresenta o C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP) no formaro &#39;58800000&#39; (optional)</param> 
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param> 
        /// <param name="numero">Apresenta o n\u00C3\u00BAmero do endere\u00C3\u00A7o (optional)</param> 
        /// <param name="complemento">Apresenta descri\u00C3\u00A7oes complementares referente ao endere\u00C3\u00A7o (optional)</param> 
        /// <param name="pontoReferencia">Apresenta a descri\u00C3\u00A7\u00C3\u00A3o de ponto de refer\u00C3\u00AAncia do endere\u00C3\u00A7o (optional)</param> 
        /// <param name="bairro">Apresenta nome do bairro (optional)</param> 
        /// <param name="cidade">Apresenta nome da cidade (optional)</param> 
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param> 
        /// <param name="pais">Apresenta nome do Pais (optional)</param> 
        /// <returns>Endereco</returns>
        public Endereco SalvarUsingPOST (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null)
        {
             ApiResponse<Endereco> localVarResponse = SalvarUsingPOSTWithHttpInfo(idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de um novo Endere\u00C3\u00A7o Este m\u00C3\u00A9todo permite que seja cadastrado um novo Endere\u00C3\u00A7o na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o endere\u00C3\u00A7o pertence (id) (optional)</param> 
        /// <param name="idTipoEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Tipo Endere\u00C3\u00A7o (id) (optional)</param> 
        /// <param name="cep">Apresenta o C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP) no formaro &#39;58800000&#39; (optional)</param> 
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param> 
        /// <param name="numero">Apresenta o n\u00C3\u00BAmero do endere\u00C3\u00A7o (optional)</param> 
        /// <param name="complemento">Apresenta descri\u00C3\u00A7oes complementares referente ao endere\u00C3\u00A7o (optional)</param> 
        /// <param name="pontoReferencia">Apresenta a descri\u00C3\u00A7\u00C3\u00A3o de ponto de refer\u00C3\u00AAncia do endere\u00C3\u00A7o (optional)</param> 
        /// <param name="bairro">Apresenta nome do bairro (optional)</param> 
        /// <param name="cidade">Apresenta nome da cidade (optional)</param> 
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param> 
        /// <param name="pais">Apresenta nome do Pais (optional)</param> 
        /// <returns>ApiResponse of Endereco</returns>
        public ApiResponse< Endereco > SalvarUsingPOSTWithHttpInfo (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null)
        {
            
    
            var localVarPath = "/api/enderecos";
    
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
            
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idTipoEndereco != null) localVarQueryParams.Add("idTipoEndereco", Configuration.ApiClient.ParameterToString(idTipoEndereco)); // query parameter
            if (cep != null) localVarQueryParams.Add("cep", Configuration.ApiClient.ParameterToString(cep)); // query parameter
            if (logradouro != null) localVarQueryParams.Add("logradouro", Configuration.ApiClient.ParameterToString(logradouro)); // query parameter
            if (numero != null) localVarQueryParams.Add("numero", Configuration.ApiClient.ParameterToString(numero)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            if (pontoReferencia != null) localVarQueryParams.Add("pontoReferencia", Configuration.ApiClient.ParameterToString(pontoReferencia)); // query parameter
            if (bairro != null) localVarQueryParams.Add("bairro", Configuration.ApiClient.ParameterToString(bairro)); // query parameter
            if (cidade != null) localVarQueryParams.Add("cidade", Configuration.ApiClient.ParameterToString(cidade)); // query parameter
            if (uf != null) localVarQueryParams.Add("uf", Configuration.ApiClient.ParameterToString(uf)); // query parameter
            if (pais != null) localVarQueryParams.Add("pais", Configuration.ApiClient.ParameterToString(pais)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Endereco>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Endereco) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Endereco)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de um novo Endere\u00C3\u00A7o Este m\u00C3\u00A9todo permite que seja cadastrado um novo Endere\u00C3\u00A7o na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o endere\u00C3\u00A7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Tipo Endere\u00C3\u00A7o (id) (optional)</param>
        /// <param name="cep">Apresenta o C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP) no formaro &#39;58800000&#39; (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00C3\u00BAmero do endere\u00C3\u00A7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00C3\u00A7oes complementares referente ao endere\u00C3\u00A7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00C3\u00A7\u00C3\u00A3o de ponto de refer\u00C3\u00AAncia do endere\u00C3\u00A7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pais (optional)</param>
        /// <returns>Task of Endereco</returns>
        public async System.Threading.Tasks.Task<Endereco> SalvarUsingPOSTAsync (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null)
        {
             ApiResponse<Endereco> localVarResponse = await SalvarUsingPOSTAsyncWithHttpInfo(idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de um novo Endere\u00C3\u00A7o Este m\u00C3\u00A9todo permite que seja cadastrado um novo Endere\u00C3\u00A7o na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa a qual o endere\u00C3\u00A7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Tipo Endere\u00C3\u00A7o (id) (optional)</param>
        /// <param name="cep">Apresenta o C\u00C3\u00B3digo de Endere\u00C3\u00A7amento Postal (CEP) no formaro &#39;58800000&#39; (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00C3\u00BAmero do endere\u00C3\u00A7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00C3\u00A7oes complementares referente ao endere\u00C3\u00A7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00C3\u00A7\u00C3\u00A3o de ponto de refer\u00C3\u00AAncia do endere\u00C3\u00A7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pais (optional)</param>
        /// <returns>Task of ApiResponse (Endereco)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Endereco>> SalvarUsingPOSTAsyncWithHttpInfo (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null)
        {
            
    
            var localVarPath = "/api/enderecos";
    
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
            
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idTipoEndereco != null) localVarQueryParams.Add("idTipoEndereco", Configuration.ApiClient.ParameterToString(idTipoEndereco)); // query parameter
            if (cep != null) localVarQueryParams.Add("cep", Configuration.ApiClient.ParameterToString(cep)); // query parameter
            if (logradouro != null) localVarQueryParams.Add("logradouro", Configuration.ApiClient.ParameterToString(logradouro)); // query parameter
            if (numero != null) localVarQueryParams.Add("numero", Configuration.ApiClient.ParameterToString(numero)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            if (pontoReferencia != null) localVarQueryParams.Add("pontoReferencia", Configuration.ApiClient.ParameterToString(pontoReferencia)); // query parameter
            if (bairro != null) localVarQueryParams.Add("bairro", Configuration.ApiClient.ParameterToString(bairro)); // query parameter
            if (cidade != null) localVarQueryParams.Add("cidade", Configuration.ApiClient.ParameterToString(cidade)); // query parameter
            if (uf != null) localVarQueryParams.Add("uf", Configuration.ApiClient.ParameterToString(uf)); // query parameter
            if (pais != null) localVarQueryParams.Add("pais", Configuration.ApiClient.ParameterToString(pais)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Endereco>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Endereco) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Endereco)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de um nova Pessoa Este m\u00C3\u00A9todo permite que seja cadastrado uma nova Pessoa na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;.</param> 
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica).</param> 
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param> 
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param> 
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param> 
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param> 
        /// <returns>Pessoa</returns>
        public Pessoa SalvarUsingPOST1 (string nome, string tipo, string cpf = null, string cnpj = null, DateTime? dataNascimento = null, string sexo = null)
        {
             ApiResponse<Pessoa> localVarResponse = SalvarUsingPOST1WithHttpInfo(nome, tipo, cpf, cnpj, dataNascimento, sexo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de um nova Pessoa Este m\u00C3\u00A9todo permite que seja cadastrado uma nova Pessoa na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;.</param> 
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica).</param> 
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param> 
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param> 
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param> 
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param> 
        /// <returns>ApiResponse of Pessoa</returns>
        public ApiResponse< Pessoa > SalvarUsingPOST1WithHttpInfo (string nome, string tipo, string cpf = null, string cnpj = null, DateTime? dataNascimento = null, string sexo = null)
        {
            
            // verify the required parameter 'nome' is set
            if (nome == null)
                throw new ApiException(400, "Missing required parameter 'nome' when calling CadastrosGeraisApi->SalvarUsingPOST1");
            
            // verify the required parameter 'tipo' is set
            if (tipo == null)
                throw new ApiException(400, "Missing required parameter 'tipo' when calling CadastrosGeraisApi->SalvarUsingPOST1");
            
    
            var localVarPath = "/api/pessoas";
    
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
            
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (tipo != null) localVarQueryParams.Add("tipo", Configuration.ApiClient.ParameterToString(tipo)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (cnpj != null) localVarQueryParams.Add("cnpj", Configuration.ApiClient.ParameterToString(cnpj)); // query parameter
            if (dataNascimento != null) localVarQueryParams.Add("dataNascimento", Configuration.ApiClient.ParameterToString(dataNascimento)); // query parameter
            if (sexo != null) localVarQueryParams.Add("sexo", Configuration.ApiClient.ParameterToString(sexo)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Pessoa>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Pessoa) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Pessoa)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de um nova Pessoa Este m\u00C3\u00A9todo permite que seja cadastrado uma nova Pessoa na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;.</param>
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica).</param>
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param>
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <returns>Task of Pessoa</returns>
        public async System.Threading.Tasks.Task<Pessoa> SalvarUsingPOST1Async (string nome, string tipo, string cpf = null, string cnpj = null, DateTime? dataNascimento = null, string sexo = null)
        {
             ApiResponse<Pessoa> localVarResponse = await SalvarUsingPOST1AsyncWithHttpInfo(nome, tipo, cpf, cnpj, dataNascimento, sexo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de um nova Pessoa Este m\u00C3\u00A9todo permite que seja cadastrado uma nova Pessoa na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;.</param>
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica).</param>
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param>
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <returns>Task of ApiResponse (Pessoa)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Pessoa>> SalvarUsingPOST1AsyncWithHttpInfo (string nome, string tipo, string cpf = null, string cnpj = null, DateTime? dataNascimento = null, string sexo = null)
        {
            // verify the required parameter 'nome' is set
            if (nome == null) throw new ApiException(400, "Missing required parameter 'nome' when calling SalvarUsingPOST1");
            // verify the required parameter 'tipo' is set
            if (tipo == null) throw new ApiException(400, "Missing required parameter 'tipo' when calling SalvarUsingPOST1");
            
    
            var localVarPath = "/api/pessoas";
    
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
            
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (tipo != null) localVarQueryParams.Add("tipo", Configuration.ApiClient.ParameterToString(tipo)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (cnpj != null) localVarQueryParams.Add("cnpj", Configuration.ApiClient.ParameterToString(cnpj)); // query parameter
            if (dataNascimento != null) localVarQueryParams.Add("dataNascimento", Configuration.ApiClient.ParameterToString(dataNascimento)); // query parameter
            if (sexo != null) localVarQueryParams.Add("sexo", Configuration.ApiClient.ParameterToString(sexo)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Pessoa>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Pessoa) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Pessoa)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de um novo Telefone Este m\u00C3\u00A9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param> 
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param> 
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param> 
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param> 
        /// <returns>Telefone</returns>
        public Telefone SalvarUsingPOST2 (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null)
        {
             ApiResponse<Telefone> localVarResponse = SalvarUsingPOST2WithHttpInfo(idTipoTelefone, idPessoa, ddd, telefone, ramal);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de um novo Telefone Este m\u00C3\u00A9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param> 
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param> 
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param> 
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param> 
        /// <returns>ApiResponse of Telefone</returns>
        public ApiResponse< Telefone > SalvarUsingPOST2WithHttpInfo (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null)
        {
            
    
            var localVarPath = "/api/telefones";
    
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
            
            if (idTipoTelefone != null) localVarQueryParams.Add("idTipoTelefone", Configuration.ApiClient.ParameterToString(idTipoTelefone)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (ddd != null) localVarQueryParams.Add("ddd", Configuration.ApiClient.ParameterToString(ddd)); // query parameter
            if (telefone != null) localVarQueryParams.Add("telefone", Configuration.ApiClient.ParameterToString(telefone)); // query parameter
            if (ramal != null) localVarQueryParams.Add("ramal", Configuration.ApiClient.ParameterToString(ramal)); // query parameter
            
            
            
            

            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Telefone>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Telefone) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Telefone)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de um novo Telefone Este m\u00C3\u00A9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>Task of Telefone</returns>
        public async System.Threading.Tasks.Task<Telefone> SalvarUsingPOST2Async (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null)
        {
             ApiResponse<Telefone> localVarResponse = await SalvarUsingPOST2AsyncWithHttpInfo(idTipoTelefone, idPessoa, ddd, telefone, ramal);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de um novo Telefone Este m\u00C3\u00A9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <returns>Task of ApiResponse (Telefone)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Telefone>> SalvarUsingPOST2AsyncWithHttpInfo (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null)
        {
            
    
            var localVarPath = "/api/telefones";
    
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
            
            if (idTipoTelefone != null) localVarQueryParams.Add("idTipoTelefone", Configuration.ApiClient.ParameterToString(idTipoTelefone)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (ddd != null) localVarQueryParams.Add("ddd", Configuration.ApiClient.ParameterToString(ddd)); // query parameter
            if (telefone != null) localVarQueryParams.Add("telefone", Configuration.ApiClient.ParameterToString(telefone)); // query parameter
            if (ramal != null) localVarQueryParams.Add("ramal", Configuration.ApiClient.ParameterToString(ramal)); // query parameter
            
            
            
            

            
            // authentication (access_token) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarHeaderParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Telefone>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Telefone) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Telefone)));
            
        }
        
    }
    
}
