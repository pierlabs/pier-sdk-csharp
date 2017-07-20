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
    public interface ICadastrosClientesApi
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
        /// <returns>EnderecoResponse</returns>
        EnderecoResponse AlterarUsingPUT1 (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null);
  
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
        /// <returns>ApiResponse of EnderecoResponse</returns>
        ApiResponse<EnderecoResponse> AlterarUsingPUT1WithHttpInfo (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null);
        
        /// <summary>
        /// Atualiza os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja alterado na base do emissor os detalhes de uma determinada Pessoa.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00C3\u00A3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00C3\u00A7\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia. (optional)</param>
        /// <param name="numeroContaCorrente">N\u00C3\u00BAmero da conta corrente. (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00C3\u00A3o (optional)</param>
        /// <returns>PessoaDetalheResponse</returns>
        PessoaDetalheResponse AlterarUsingPUT4 (long? id, string nomeMae = null, long? idEstadoCivil = null, int? idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null);
  
        /// <summary>
        /// Atualiza os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja alterado na base do emissor os detalhes de uma determinada Pessoa.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00C3\u00A3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00C3\u00A7\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia. (optional)</param>
        /// <param name="numeroContaCorrente">N\u00C3\u00BAmero da conta corrente. (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00C3\u00A3o (optional)</param>
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        ApiResponse<PessoaDetalheResponse> AlterarUsingPUT4WithHttpInfo (long? id, string nomeMae = null, long? idEstadoCivil = null, int? idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null);
        
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
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <param name="numeroIdentidade">N\u00C3\u00BAmero da Identidade. (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00C3\u00A3o expedidor do Identidade. (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00C3\u00A3o da Identidade. (optional)</param>
        /// <returns>PessoaResponse</returns>
        PessoaResponse AlterarUsingPUT5 (long? id, string nome, string tipo, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
  
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
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <param name="numeroIdentidade">N\u00C3\u00BAmero da Identidade. (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00C3\u00A3o expedidor do Identidade. (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00C3\u00A3o da Identidade. (optional)</param>
        /// <returns>ApiResponse of PessoaResponse</returns>
        ApiResponse<PessoaResponse> AlterarUsingPUT5WithHttpInfo (long? id, string nome, string tipo, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
        
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
        /// <returns>TelefoneResponse</returns>
        TelefoneResponse AlterarUsingPUT6 (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null);
  
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
        /// <returns>ApiResponse of TelefoneResponse</returns>
        ApiResponse<TelefoneResponse> AlterarUsingPUT6WithHttpInfo (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null);
        
        /// <summary>
        /// Permite atribuir um documento para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja atribu\u00C3\u00ADdo a uma determinada Conta um documento que esteja armazenado no PIER Cloud, informando qual o tipo do documento e o seu respectivo id.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do arquivo</param>
        /// <param name="atribuirAssinaturaClienteRequest">atribuirAssinaturaClienteRequest</param>
        /// <returns>Object</returns>
        Object AtribuirAssinaturaClienteUsingPOST (long? id, AtribuirAssinaturaClienteRequest atribuirAssinaturaClienteRequest);
  
        /// <summary>
        /// Permite atribuir um documento para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja atribu\u00C3\u00ADdo a uma determinada Conta um documento que esteja armazenado no PIER Cloud, informando qual o tipo do documento e o seu respectivo id.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do arquivo</param>
        /// <param name="atribuirAssinaturaClienteRequest">atribuirAssinaturaClienteRequest</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> AtribuirAssinaturaClienteUsingPOSTWithHttpInfo (long? id, AtribuirAssinaturaClienteRequest atribuirAssinaturaClienteRequest);
        
        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam cadastrados um portador Adicional para uma determinada Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>AdicionalResponse</returns>
        AdicionalResponse CadastrarUsingPOST (long? id, AdicionalPersist persist);
  
        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam cadastrados um portador Adicional para uma determinada Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of AdicionalResponse</returns>
        ApiResponse<AdicionalResponse> CadastrarUsingPOSTWithHttpInfo (long? id, AdicionalPersist persist);
        
        /// <summary>
        /// Apresenta os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite a consulta dos detalhes de uma Pessoa existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>PessoaDetalheResponse</returns>
        PessoaDetalheResponse ConsultarUsingGET10 (long? id);
  
        /// <summary>
        /// Apresenta os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite a consulta dos detalhes de uma Pessoa existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        ApiResponse<PessoaDetalheResponse> ConsultarUsingGET10WithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>PessoaResponse</returns>
        PessoaResponse ConsultarUsingGET11 (long? id);
  
        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>ApiResponse of PessoaResponse</returns>
        ApiResponse<PessoaResponse> ConsultarUsingGET11WithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param>
        /// <returns>TelefoneResponse</returns>
        TelefoneResponse ConsultarUsingGET16 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param>
        /// <returns>ApiResponse of TelefoneResponse</returns>
        ApiResponse<TelefoneResponse> ConsultarUsingGET16WithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00C3\u00A7o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Endere\u00C3\u00A7o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id).</param>
        /// <returns>EnderecoResponse</returns>
        EnderecoResponse ConsultarUsingGET6 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00C3\u00A7o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Endere\u00C3\u00A7o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id).</param>
        /// <returns>ApiResponse of EnderecoResponse</returns>
        ApiResponse<EnderecoResponse> ConsultarUsingGET6WithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os Detalhes das Pessoas cadastradas no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas od detalhes das Pessoas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo identificador da pessoa (optional)</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00C3\u00A3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00C3\u00A7\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia. (optional)</param>
        /// <param name="numeroContaCorrente">N\u00C3\u00BAmero da conta corrente. (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00C3\u00A3o (optional)</param>
        /// <returns>PagePessoaDetalheResponse</returns>
        PagePessoaDetalheResponse ListarUsingGET14 (int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, int? idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null);
  
        /// <summary>
        /// Lista os Detalhes das Pessoas cadastradas no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas od detalhes das Pessoas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo identificador da pessoa (optional)</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00C3\u00A3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00C3\u00A7\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia. (optional)</param>
        /// <param name="numeroContaCorrente">N\u00C3\u00BAmero da conta corrente. (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00C3\u00A3o (optional)</param>
        /// <returns>ApiResponse of PagePessoaDetalheResponse</returns>
        ApiResponse<PagePessoaDetalheResponse> ListarUsingGET14WithHttpInfo (int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, int? idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null);
        
        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id). (optional)</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;. (optional)</param>
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica). (optional)</param>
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param>
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <param name="numeroIdentidade">N\u00C3\u00BAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00C3\u00A3o expedidor do RG. (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00C3\u00A3o da identidade no formato aaaa-MM-dd (optional)</param>
        /// <returns>PagePessoaResponse</returns>
        PagePessoaResponse ListarUsingGET15 (int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
  
        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id). (optional)</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;. (optional)</param>
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica). (optional)</param>
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param>
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <param name="numeroIdentidade">N\u00C3\u00BAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00C3\u00A3o expedidor do RG. (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00C3\u00A3o da identidade no formato aaaa-MM-dd (optional)</param>
        /// <returns>ApiResponse of PagePessoaResponse</returns>
        ApiResponse<PagePessoaResponse> ListarUsingGET15WithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
        
        /// <summary>
        /// Lista os Telefones cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Telefones existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id). (optional)</param>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <returns>PageTelefoneResponse</returns>
        PageTelefoneResponse ListarUsingGET22 (int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null);
  
        /// <summary>
        /// Lista os Telefones cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Telefones existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id). (optional)</param>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <returns>ApiResponse of PageTelefoneResponse</returns>
        ApiResponse<PageTelefoneResponse> ListarUsingGET22WithHttpInfo (int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null);
        
        /// <summary>
        /// Lista os Endere\u00C3\u00A7os cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Endere\u00C3\u00A7os existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
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
        /// <returns>PageEnderecoResponse</returns>
        PageEnderecoResponse ListarUsingGET9 (int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null);
  
        /// <summary>
        /// Lista os Endere\u00C3\u00A7os cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Endere\u00C3\u00A7os existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
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
        /// <returns>ApiResponse of PageEnderecoResponse</returns>
        ApiResponse<PageEnderecoResponse> ListarUsingGET9WithHttpInfo (int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null);
        
        /// <summary>
        /// Cadastro de Conta e Pessoa Fisica
        /// </summary>
        /// <remarks>
        /// Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa F\u00C3\u00ADsica, recebendo nesta opera\u00C3\u00A7\u00C3\u00A3o todos os dados cadastrais que se fazem necess\u00C3\u00A1rios para isso. Uma vez criado, poder\u00C3\u00A1 ser acionado o m\u00C3\u00A9todo de &#39;Gera\u00C3\u00A7\u00C3\u00A3o de Cart\u00C3\u00A3o&#39; para o cliente e seus adicionais.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>PessoaFisicaAprovadaResponse</returns>
        PessoaFisicaAprovadaResponse SalvarPessoaFisicaAprovadaUsingPOST (PessoaFisicaAprovadaPersist pessoaPersist);
  
        /// <summary>
        /// Cadastro de Conta e Pessoa Fisica
        /// </summary>
        /// <remarks>
        /// Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa F\u00C3\u00ADsica, recebendo nesta opera\u00C3\u00A7\u00C3\u00A3o todos os dados cadastrais que se fazem necess\u00C3\u00A1rios para isso. Uma vez criado, poder\u00C3\u00A1 ser acionado o m\u00C3\u00A9todo de &#39;Gera\u00C3\u00A7\u00C3\u00A3o de Cart\u00C3\u00A3o&#39; para o cliente e seus adicionais.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>ApiResponse of PessoaFisicaAprovadaResponse</returns>
        ApiResponse<PessoaFisicaAprovadaResponse> SalvarPessoaFisicaAprovadaUsingPOSTWithHttpInfo (PessoaFisicaAprovadaPersist pessoaPersist);
        
        /// <summary>
        /// Cadastro de Conta e Pessoa Jur\u00C3\u00ADdica
        /// </summary>
        /// <remarks>
        /// Cadastro de Conta e Pessoa Jur\u00C3\u00ADdica Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa Jur\u00C3\u00ADdica, recebendo nesta opera\u00C3\u00A7\u00C3\u00A3o todos os dados cadastrais que se fazem necess\u00C3\u00A1rios para isso, inclu\u00C3\u00ADndo o registro de cada um dos s\u00C3\u00B3cios. Uma vez criado, poder\u00C3\u00A1 ser acionado o m\u00C3\u00A9todo de &#39;Gera\u00C3\u00A7\u00C3\u00A3o de Cart\u00C3\u00A3o&#39; para o cliente e cada um dos s\u00C3\u00B3cios vinculados.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>PessoaJuridicaAprovadaResponse</returns>
        PessoaJuridicaAprovadaResponse SalvarPessoaJuridicaAprovadaUsingPOST (PessoaJuridicaAprovadaPersist pessoaPersist);
  
        /// <summary>
        /// Cadastro de Conta e Pessoa Jur\u00C3\u00ADdica
        /// </summary>
        /// <remarks>
        /// Cadastro de Conta e Pessoa Jur\u00C3\u00ADdica Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa Jur\u00C3\u00ADdica, recebendo nesta opera\u00C3\u00A7\u00C3\u00A3o todos os dados cadastrais que se fazem necess\u00C3\u00A1rios para isso, inclu\u00C3\u00ADndo o registro de cada um dos s\u00C3\u00B3cios. Uma vez criado, poder\u00C3\u00A1 ser acionado o m\u00C3\u00A9todo de &#39;Gera\u00C3\u00A7\u00C3\u00A3o de Cart\u00C3\u00A3o&#39; para o cliente e cada um dos s\u00C3\u00B3cios vinculados.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>ApiResponse of PessoaJuridicaAprovadaResponse</returns>
        ApiResponse<PessoaJuridicaAprovadaResponse> SalvarPessoaJuridicaAprovadaUsingPOSTWithHttpInfo (PessoaJuridicaAprovadaPersist pessoaPersist);
        
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
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <param name="numeroIdentidade">N\u00C3\u00BAmero da Identidade. (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00C3\u00A3o expedidor do Identidade. (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00C3\u00A3o da Identidade. (optional)</param>
        /// <returns>PessoaResponse</returns>
        PessoaResponse SalvarUsingPOST10 (string nome, string tipo, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
  
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
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <param name="numeroIdentidade">N\u00C3\u00BAmero da Identidade. (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00C3\u00A3o expedidor do Identidade. (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00C3\u00A3o da Identidade. (optional)</param>
        /// <returns>ApiResponse of PessoaResponse</returns>
        ApiResponse<PessoaResponse> SalvarUsingPOST10WithHttpInfo (string nome, string tipo, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
        
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
        /// <returns>TelefoneResponse</returns>
        TelefoneResponse SalvarUsingPOST12 (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null);
  
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
        /// <returns>ApiResponse of TelefoneResponse</returns>
        ApiResponse<TelefoneResponse> SalvarUsingPOST12WithHttpInfo (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null);
        
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
        /// <returns>EnderecoResponse</returns>
        EnderecoResponse SalvarUsingPOST5 (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null);
  
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
        /// <returns>ApiResponse of EnderecoResponse</returns>
        ApiResponse<EnderecoResponse> SalvarUsingPOST5WithHttpInfo (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null);
        
        /// <summary>
        /// Inclui a conta como registro para integra\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite incluir uma conta como registro para integra\u00C3\u00A7\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idPropostaExterna">Apresenta o identificador da proposta externa. (optional)</param>
        /// <returns>IntegracaoEmissorResponse</returns>
        IntegracaoEmissorResponse SalvarUsingPOST6 (long? id, long? idPropostaExterna = null);
  
        /// <summary>
        /// Inclui a conta como registro para integra\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite incluir uma conta como registro para integra\u00C3\u00A7\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idPropostaExterna">Apresenta o identificador da proposta externa. (optional)</param>
        /// <returns>ApiResponse of IntegracaoEmissorResponse</returns>
        ApiResponse<IntegracaoEmissorResponse> SalvarUsingPOST6WithHttpInfo (long? id, long? idPropostaExterna = null);
        
        /// <summary>
        /// Salvar os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja incluido na base do emissor os detalhes de uma determinada Pessoa.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Apresenta o c\u00C3\u00B3digo identificador da pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00C3\u00A3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00C3\u00A7\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia. (optional)</param>
        /// <param name="numeroContaCorrente">N\u00C3\u00BAmero da conta corrente. (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00C3\u00A3o (optional)</param>
        /// <returns>PessoaDetalheResponse</returns>
        PessoaDetalheResponse SalvarUsingPOST9 (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, int? idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null);
  
        /// <summary>
        /// Salvar os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja incluido na base do emissor os detalhes de uma determinada Pessoa.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Apresenta o c\u00C3\u00B3digo identificador da pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00C3\u00A3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00C3\u00A7\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia. (optional)</param>
        /// <param name="numeroContaCorrente">N\u00C3\u00BAmero da conta corrente. (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00C3\u00A3o (optional)</param>
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        ApiResponse<PessoaDetalheResponse> SalvarUsingPOST9WithHttpInfo (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, int? idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null);
        
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
        /// <returns>Task of EnderecoResponse</returns>
        System.Threading.Tasks.Task<EnderecoResponse> AlterarUsingPUT1Async (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null);

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
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> AlterarUsingPUT1AsyncWithHttpInfo (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null);
        
        /// <summary>
        /// Atualiza os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja alterado na base do emissor os detalhes de uma determinada Pessoa.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00C3\u00A3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00C3\u00A7\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia. (optional)</param>
        /// <param name="numeroContaCorrente">N\u00C3\u00BAmero da conta corrente. (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00C3\u00A3o (optional)</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        System.Threading.Tasks.Task<PessoaDetalheResponse> AlterarUsingPUT4Async (long? id, string nomeMae = null, long? idEstadoCivil = null, int? idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null);

        /// <summary>
        /// Atualiza os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja alterado na base do emissor os detalhes de uma determinada Pessoa.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00C3\u00A3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00C3\u00A7\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia. (optional)</param>
        /// <param name="numeroContaCorrente">N\u00C3\u00BAmero da conta corrente. (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00C3\u00A3o (optional)</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> AlterarUsingPUT4AsyncWithHttpInfo (long? id, string nomeMae = null, long? idEstadoCivil = null, int? idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null);
        
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
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <param name="numeroIdentidade">N\u00C3\u00BAmero da Identidade. (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00C3\u00A3o expedidor do Identidade. (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00C3\u00A3o da Identidade. (optional)</param>
        /// <returns>Task of PessoaResponse</returns>
        System.Threading.Tasks.Task<PessoaResponse> AlterarUsingPUT5Async (long? id, string nome, string tipo, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);

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
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <param name="numeroIdentidade">N\u00C3\u00BAmero da Identidade. (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00C3\u00A3o expedidor do Identidade. (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00C3\u00A3o da Identidade. (optional)</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> AlterarUsingPUT5AsyncWithHttpInfo (long? id, string nome, string tipo, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
        
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
        /// <returns>Task of TelefoneResponse</returns>
        System.Threading.Tasks.Task<TelefoneResponse> AlterarUsingPUT6Async (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null);

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
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> AlterarUsingPUT6AsyncWithHttpInfo (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null);
        
        /// <summary>
        /// Permite atribuir um documento para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja atribu\u00C3\u00ADdo a uma determinada Conta um documento que esteja armazenado no PIER Cloud, informando qual o tipo do documento e o seu respectivo id.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do arquivo</param>
        /// <param name="atribuirAssinaturaClienteRequest">atribuirAssinaturaClienteRequest</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> AtribuirAssinaturaClienteUsingPOSTAsync (long? id, AtribuirAssinaturaClienteRequest atribuirAssinaturaClienteRequest);

        /// <summary>
        /// Permite atribuir um documento para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja atribu\u00C3\u00ADdo a uma determinada Conta um documento que esteja armazenado no PIER Cloud, informando qual o tipo do documento e o seu respectivo id.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do arquivo</param>
        /// <param name="atribuirAssinaturaClienteRequest">atribuirAssinaturaClienteRequest</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AtribuirAssinaturaClienteUsingPOSTAsyncWithHttpInfo (long? id, AtribuirAssinaturaClienteRequest atribuirAssinaturaClienteRequest);
        
        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam cadastrados um portador Adicional para uma determinada Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of AdicionalResponse</returns>
        System.Threading.Tasks.Task<AdicionalResponse> CadastrarUsingPOSTAsync (long? id, AdicionalPersist persist);

        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam cadastrados um portador Adicional para uma determinada Conta.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (AdicionalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdicionalResponse>> CadastrarUsingPOSTAsyncWithHttpInfo (long? id, AdicionalPersist persist);
        
        /// <summary>
        /// Apresenta os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite a consulta dos detalhes de uma Pessoa existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        System.Threading.Tasks.Task<PessoaDetalheResponse> ConsultarUsingGET10Async (long? id);

        /// <summary>
        /// Apresenta os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite a consulta dos detalhes de uma Pessoa existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> ConsultarUsingGET10AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Task of PessoaResponse</returns>
        System.Threading.Tasks.Task<PessoaResponse> ConsultarUsingGET11Async (long? id);

        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> ConsultarUsingGET11AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param>
        /// <returns>Task of TelefoneResponse</returns>
        System.Threading.Tasks.Task<TelefoneResponse> ConsultarUsingGET16Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param>
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> ConsultarUsingGET16AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00C3\u00A7o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Endere\u00C3\u00A7o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id).</param>
        /// <returns>Task of EnderecoResponse</returns>
        System.Threading.Tasks.Task<EnderecoResponse> ConsultarUsingGET6Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00C3\u00A7o
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Endere\u00C3\u00A7o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id).</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> ConsultarUsingGET6AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Lista os Detalhes das Pessoas cadastradas no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas od detalhes das Pessoas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo identificador da pessoa (optional)</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00C3\u00A3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00C3\u00A7\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia. (optional)</param>
        /// <param name="numeroContaCorrente">N\u00C3\u00BAmero da conta corrente. (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00C3\u00A3o (optional)</param>
        /// <returns>Task of PagePessoaDetalheResponse</returns>
        System.Threading.Tasks.Task<PagePessoaDetalheResponse> ListarUsingGET14Async (int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, int? idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null);

        /// <summary>
        /// Lista os Detalhes das Pessoas cadastradas no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas od detalhes das Pessoas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo identificador da pessoa (optional)</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00C3\u00A3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00C3\u00A7\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia. (optional)</param>
        /// <param name="numeroContaCorrente">N\u00C3\u00BAmero da conta corrente. (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00C3\u00A3o (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePessoaDetalheResponse>> ListarUsingGET14AsyncWithHttpInfo (int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, int? idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null);
        
        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id). (optional)</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;. (optional)</param>
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica). (optional)</param>
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param>
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <param name="numeroIdentidade">N\u00C3\u00BAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00C3\u00A3o expedidor do RG. (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00C3\u00A3o da identidade no formato aaaa-MM-dd (optional)</param>
        /// <returns>Task of PagePessoaResponse</returns>
        System.Threading.Tasks.Task<PagePessoaResponse> ListarUsingGET15Async (int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);

        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id). (optional)</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;. (optional)</param>
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica). (optional)</param>
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param>
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <param name="numeroIdentidade">N\u00C3\u00BAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00C3\u00A3o expedidor do RG. (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00C3\u00A3o da identidade no formato aaaa-MM-dd (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePessoaResponse>> ListarUsingGET15AsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
        
        /// <summary>
        /// Lista os Telefones cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Telefones existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id). (optional)</param>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <returns>Task of PageTelefoneResponse</returns>
        System.Threading.Tasks.Task<PageTelefoneResponse> ListarUsingGET22Async (int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null);

        /// <summary>
        /// Lista os Telefones cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Telefones existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id). (optional)</param>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <returns>Task of ApiResponse (PageTelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTelefoneResponse>> ListarUsingGET22AsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null);
        
        /// <summary>
        /// Lista os Endere\u00C3\u00A7os cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Endere\u00C3\u00A7os existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
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
        /// <returns>Task of PageEnderecoResponse</returns>
        System.Threading.Tasks.Task<PageEnderecoResponse> ListarUsingGET9Async (int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null);

        /// <summary>
        /// Lista os Endere\u00C3\u00A7os cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que sejam listados os Endere\u00C3\u00A7os existentes na base de dados do Emissor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
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
        /// <returns>Task of ApiResponse (PageEnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageEnderecoResponse>> ListarUsingGET9AsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null);
        
        /// <summary>
        /// Cadastro de Conta e Pessoa Fisica
        /// </summary>
        /// <remarks>
        /// Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa F\u00C3\u00ADsica, recebendo nesta opera\u00C3\u00A7\u00C3\u00A3o todos os dados cadastrais que se fazem necess\u00C3\u00A1rios para isso. Uma vez criado, poder\u00C3\u00A1 ser acionado o m\u00C3\u00A9todo de &#39;Gera\u00C3\u00A7\u00C3\u00A3o de Cart\u00C3\u00A3o&#39; para o cliente e seus adicionais.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of PessoaFisicaAprovadaResponse</returns>
        System.Threading.Tasks.Task<PessoaFisicaAprovadaResponse> SalvarPessoaFisicaAprovadaUsingPOSTAsync (PessoaFisicaAprovadaPersist pessoaPersist);

        /// <summary>
        /// Cadastro de Conta e Pessoa Fisica
        /// </summary>
        /// <remarks>
        /// Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa F\u00C3\u00ADsica, recebendo nesta opera\u00C3\u00A7\u00C3\u00A3o todos os dados cadastrais que se fazem necess\u00C3\u00A1rios para isso. Uma vez criado, poder\u00C3\u00A1 ser acionado o m\u00C3\u00A9todo de &#39;Gera\u00C3\u00A7\u00C3\u00A3o de Cart\u00C3\u00A3o&#39; para o cliente e seus adicionais.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of ApiResponse (PessoaFisicaAprovadaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaFisicaAprovadaResponse>> SalvarPessoaFisicaAprovadaUsingPOSTAsyncWithHttpInfo (PessoaFisicaAprovadaPersist pessoaPersist);
        
        /// <summary>
        /// Cadastro de Conta e Pessoa Jur\u00C3\u00ADdica
        /// </summary>
        /// <remarks>
        /// Cadastro de Conta e Pessoa Jur\u00C3\u00ADdica Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa Jur\u00C3\u00ADdica, recebendo nesta opera\u00C3\u00A7\u00C3\u00A3o todos os dados cadastrais que se fazem necess\u00C3\u00A1rios para isso, inclu\u00C3\u00ADndo o registro de cada um dos s\u00C3\u00B3cios. Uma vez criado, poder\u00C3\u00A1 ser acionado o m\u00C3\u00A9todo de &#39;Gera\u00C3\u00A7\u00C3\u00A3o de Cart\u00C3\u00A3o&#39; para o cliente e cada um dos s\u00C3\u00B3cios vinculados.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of PessoaJuridicaAprovadaResponse</returns>
        System.Threading.Tasks.Task<PessoaJuridicaAprovadaResponse> SalvarPessoaJuridicaAprovadaUsingPOSTAsync (PessoaJuridicaAprovadaPersist pessoaPersist);

        /// <summary>
        /// Cadastro de Conta e Pessoa Jur\u00C3\u00ADdica
        /// </summary>
        /// <remarks>
        /// Cadastro de Conta e Pessoa Jur\u00C3\u00ADdica Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa Jur\u00C3\u00ADdica, recebendo nesta opera\u00C3\u00A7\u00C3\u00A3o todos os dados cadastrais que se fazem necess\u00C3\u00A1rios para isso, inclu\u00C3\u00ADndo o registro de cada um dos s\u00C3\u00B3cios. Uma vez criado, poder\u00C3\u00A1 ser acionado o m\u00C3\u00A9todo de &#39;Gera\u00C3\u00A7\u00C3\u00A3o de Cart\u00C3\u00A3o&#39; para o cliente e cada um dos s\u00C3\u00B3cios vinculados.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaAprovadaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaAprovadaResponse>> SalvarPessoaJuridicaAprovadaUsingPOSTAsyncWithHttpInfo (PessoaJuridicaAprovadaPersist pessoaPersist);
        
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
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <param name="numeroIdentidade">N\u00C3\u00BAmero da Identidade. (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00C3\u00A3o expedidor do Identidade. (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00C3\u00A3o da Identidade. (optional)</param>
        /// <returns>Task of PessoaResponse</returns>
        System.Threading.Tasks.Task<PessoaResponse> SalvarUsingPOST10Async (string nome, string tipo, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);

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
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <param name="numeroIdentidade">N\u00C3\u00BAmero da Identidade. (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00C3\u00A3o expedidor do Identidade. (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00C3\u00A3o da Identidade. (optional)</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> SalvarUsingPOST10AsyncWithHttpInfo (string nome, string tipo, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
        
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
        /// <returns>Task of TelefoneResponse</returns>
        System.Threading.Tasks.Task<TelefoneResponse> SalvarUsingPOST12Async (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null);

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
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> SalvarUsingPOST12AsyncWithHttpInfo (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null);
        
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
        /// <returns>Task of EnderecoResponse</returns>
        System.Threading.Tasks.Task<EnderecoResponse> SalvarUsingPOST5Async (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null);

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
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> SalvarUsingPOST5AsyncWithHttpInfo (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null);
        
        /// <summary>
        /// Inclui a conta como registro para integra\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite incluir uma conta como registro para integra\u00C3\u00A7\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idPropostaExterna">Apresenta o identificador da proposta externa. (optional)</param>
        /// <returns>Task of IntegracaoEmissorResponse</returns>
        System.Threading.Tasks.Task<IntegracaoEmissorResponse> SalvarUsingPOST6Async (long? id, long? idPropostaExterna = null);

        /// <summary>
        /// Inclui a conta como registro para integra\u00C3\u00A7\u00C3\u00A3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite incluir uma conta como registro para integra\u00C3\u00A7\u00C3\u00A3o.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idPropostaExterna">Apresenta o identificador da proposta externa. (optional)</param>
        /// <returns>Task of ApiResponse (IntegracaoEmissorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntegracaoEmissorResponse>> SalvarUsingPOST6AsyncWithHttpInfo (long? id, long? idPropostaExterna = null);
        
        /// <summary>
        /// Salvar os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja incluido na base do emissor os detalhes de uma determinada Pessoa.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Apresenta o c\u00C3\u00B3digo identificador da pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00C3\u00A3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00C3\u00A7\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia. (optional)</param>
        /// <param name="numeroContaCorrente">N\u00C3\u00BAmero da conta corrente. (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00C3\u00A3o (optional)</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        System.Threading.Tasks.Task<PessoaDetalheResponse> SalvarUsingPOST9Async (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, int? idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null);

        /// <summary>
        /// Salvar os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja incluido na base do emissor os detalhes de uma determinada Pessoa.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Apresenta o c\u00C3\u00B3digo identificador da pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00C3\u00A3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00C3\u00A7\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia. (optional)</param>
        /// <param name="numeroContaCorrente">N\u00C3\u00BAmero da conta corrente. (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00C3\u00A3o (optional)</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> SalvarUsingPOST9AsyncWithHttpInfo (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, int? idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CadastrosClientesApi : ICadastrosClientesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CadastrosClientesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CadastrosClientesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CadastrosClientesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CadastrosClientesApi(Configuration configuration = null)
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
        /// <returns>EnderecoResponse</returns>
        public EnderecoResponse AlterarUsingPUT1 (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null)
        {
             ApiResponse<EnderecoResponse> localVarResponse = AlterarUsingPUT1WithHttpInfo(id, idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais);
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
        /// <returns>ApiResponse of EnderecoResponse</returns>
        public ApiResponse< EnderecoResponse > AlterarUsingPUT1WithHttpInfo (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastrosClientesApi->AlterarUsingPUT1");
            
    
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
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
        /// <returns>Task of EnderecoResponse</returns>
        public async System.Threading.Tasks.Task<EnderecoResponse> AlterarUsingPUT1Async (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null)
        {
             ApiResponse<EnderecoResponse> localVarResponse = await AlterarUsingPUT1AsyncWithHttpInfo(id, idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais);
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
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> AlterarUsingPUT1AsyncWithHttpInfo (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT1");
            
    
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }
        
        /// <summary>
        /// Atualiza os detalhes de uma determinada Pessoa Este m\u00C3\u00A9todo permite que seja alterado na base do emissor os detalhes de uma determinada Pessoa.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param> 
        /// <param name="nomeMae">Apresenta o nome da m\u00C3\u00A3e da pessoa fisica (optional)</param> 
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param> 
        /// <param name="idProfissao">Profiss\u00C3\u00A3o da pessoa fisica (optional)</param> 
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00C3\u00A7\u00C3\u00A3o da pessoa fisica (optional)</param> 
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param> 
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia. (optional)</param> 
        /// <param name="numeroContaCorrente">N\u00C3\u00BAmero da conta corrente. (optional)</param> 
        /// <param name="email">Email da pessoa fisica (optional)</param> 
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00C3\u00A3o (optional)</param> 
        /// <returns>PessoaDetalheResponse</returns>
        public PessoaDetalheResponse AlterarUsingPUT4 (long? id, string nomeMae = null, long? idEstadoCivil = null, int? idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = AlterarUsingPUT4WithHttpInfo(id, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroAgencia, numeroContaCorrente, email, nomeEmpresa);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualiza os detalhes de uma determinada Pessoa Este m\u00C3\u00A9todo permite que seja alterado na base do emissor os detalhes de uma determinada Pessoa.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param> 
        /// <param name="nomeMae">Apresenta o nome da m\u00C3\u00A3e da pessoa fisica (optional)</param> 
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param> 
        /// <param name="idProfissao">Profiss\u00C3\u00A3o da pessoa fisica (optional)</param> 
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00C3\u00A7\u00C3\u00A3o da pessoa fisica (optional)</param> 
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param> 
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia. (optional)</param> 
        /// <param name="numeroContaCorrente">N\u00C3\u00BAmero da conta corrente. (optional)</param> 
        /// <param name="email">Email da pessoa fisica (optional)</param> 
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00C3\u00A3o (optional)</param> 
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        public ApiResponse< PessoaDetalheResponse > AlterarUsingPUT4WithHttpInfo (long? id, string nomeMae = null, long? idEstadoCivil = null, int? idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastrosClientesApi->AlterarUsingPUT4");
            
    
            var localVarPath = "/api/pessoas-detalhes/{id}";
    
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
            
            if (nomeMae != null) localVarQueryParams.Add("nomeMae", Configuration.ApiClient.ParameterToString(nomeMae)); // query parameter
            if (idEstadoCivil != null) localVarQueryParams.Add("idEstadoCivil", Configuration.ApiClient.ParameterToString(idEstadoCivil)); // query parameter
            if (idProfissao != null) localVarQueryParams.Add("idProfissao", Configuration.ApiClient.ParameterToString(idProfissao)); // query parameter
            if (idNaturezaOcupacao != null) localVarQueryParams.Add("idNaturezaOcupacao", Configuration.ApiClient.ParameterToString(idNaturezaOcupacao)); // query parameter
            if (idNacionalidade != null) localVarQueryParams.Add("idNacionalidade", Configuration.ApiClient.ParameterToString(idNacionalidade)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroContaCorrente != null) localVarQueryParams.Add("numeroContaCorrente", Configuration.ApiClient.ParameterToString(numeroContaCorrente)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (nomeEmpresa != null) localVarQueryParams.Add("nomeEmpresa", Configuration.ApiClient.ParameterToString(nomeEmpresa)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Atualiza os detalhes de uma determinada Pessoa Este m\u00C3\u00A9todo permite que seja alterado na base do emissor os detalhes de uma determinada Pessoa.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00C3\u00A3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00C3\u00A7\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia. (optional)</param>
        /// <param name="numeroContaCorrente">N\u00C3\u00BAmero da conta corrente. (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00C3\u00A3o (optional)</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<PessoaDetalheResponse> AlterarUsingPUT4Async (long? id, string nomeMae = null, long? idEstadoCivil = null, int? idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = await AlterarUsingPUT4AsyncWithHttpInfo(id, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroAgencia, numeroContaCorrente, email, nomeEmpresa);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualiza os detalhes de uma determinada Pessoa Este m\u00C3\u00A9todo permite que seja alterado na base do emissor os detalhes de uma determinada Pessoa.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00C3\u00A3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00C3\u00A7\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia. (optional)</param>
        /// <param name="numeroContaCorrente">N\u00C3\u00BAmero da conta corrente. (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00C3\u00A3o (optional)</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> AlterarUsingPUT4AsyncWithHttpInfo (long? id, string nomeMae = null, long? idEstadoCivil = null, int? idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT4");
            
    
            var localVarPath = "/api/pessoas-detalhes/{id}";
    
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
            
            if (nomeMae != null) localVarQueryParams.Add("nomeMae", Configuration.ApiClient.ParameterToString(nomeMae)); // query parameter
            if (idEstadoCivil != null) localVarQueryParams.Add("idEstadoCivil", Configuration.ApiClient.ParameterToString(idEstadoCivil)); // query parameter
            if (idProfissao != null) localVarQueryParams.Add("idProfissao", Configuration.ApiClient.ParameterToString(idProfissao)); // query parameter
            if (idNaturezaOcupacao != null) localVarQueryParams.Add("idNaturezaOcupacao", Configuration.ApiClient.ParameterToString(idNaturezaOcupacao)); // query parameter
            if (idNacionalidade != null) localVarQueryParams.Add("idNacionalidade", Configuration.ApiClient.ParameterToString(idNacionalidade)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroContaCorrente != null) localVarQueryParams.Add("numeroContaCorrente", Configuration.ApiClient.ParameterToString(numeroContaCorrente)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (nomeEmpresa != null) localVarQueryParams.Add("nomeEmpresa", Configuration.ApiClient.ParameterToString(nomeEmpresa)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT4: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT4: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
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
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd. (optional)</param> 
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param> 
        /// <param name="numeroIdentidade">N\u00C3\u00BAmero da Identidade. (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">Org\u00C3\u00A3o expedidor do Identidade. (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param> 
        /// <param name="dataEmissaoIdentidade">Data emiss\u00C3\u00A3o da Identidade. (optional)</param> 
        /// <returns>PessoaResponse</returns>
        public PessoaResponse AlterarUsingPUT5 (long? id, string nome, string tipo, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
             ApiResponse<PessoaResponse> localVarResponse = AlterarUsingPUT5WithHttpInfo(id, nome, tipo, cpf, cnpj, dataNascimento, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade);
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
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd. (optional)</param> 
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param> 
        /// <param name="numeroIdentidade">N\u00C3\u00BAmero da Identidade. (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">Org\u00C3\u00A3o expedidor do Identidade. (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param> 
        /// <param name="dataEmissaoIdentidade">Data emiss\u00C3\u00A3o da Identidade. (optional)</param> 
        /// <returns>ApiResponse of PessoaResponse</returns>
        public ApiResponse< PessoaResponse > AlterarUsingPUT5WithHttpInfo (long? id, string nome, string tipo, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastrosClientesApi->AlterarUsingPUT5");
            
            // verify the required parameter 'nome' is set
            if (nome == null)
                throw new ApiException(400, "Missing required parameter 'nome' when calling CadastrosClientesApi->AlterarUsingPUT5");
            
            // verify the required parameter 'tipo' is set
            if (tipo == null)
                throw new ApiException(400, "Missing required parameter 'tipo' when calling CadastrosClientesApi->AlterarUsingPUT5");
            
    
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
            
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (tipo != null) localVarQueryParams.Add("tipo", Configuration.ApiClient.ParameterToString(tipo)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (cnpj != null) localVarQueryParams.Add("cnpj", Configuration.ApiClient.ParameterToString(cnpj)); // query parameter
            if (dataNascimento != null) localVarQueryParams.Add("dataNascimento", Configuration.ApiClient.ParameterToString(dataNascimento)); // query parameter
            if (sexo != null) localVarQueryParams.Add("sexo", Configuration.ApiClient.ParameterToString(sexo)); // query parameter
            if (numeroIdentidade != null) localVarQueryParams.Add("numeroIdentidade", Configuration.ApiClient.ParameterToString(numeroIdentidade)); // query parameter
            if (orgaoExpedidorIdentidade != null) localVarQueryParams.Add("orgaoExpedidorIdentidade", Configuration.ApiClient.ParameterToString(orgaoExpedidorIdentidade)); // query parameter
            if (unidadeFederativaIdentidade != null) localVarQueryParams.Add("unidadeFederativaIdentidade", Configuration.ApiClient.ParameterToString(unidadeFederativaIdentidade)); // query parameter
            if (dataEmissaoIdentidade != null) localVarQueryParams.Add("dataEmissaoIdentidade", Configuration.ApiClient.ParameterToString(dataEmissaoIdentidade)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
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
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <param name="numeroIdentidade">N\u00C3\u00BAmero da Identidade. (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00C3\u00A3o expedidor do Identidade. (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00C3\u00A3o da Identidade. (optional)</param>
        /// <returns>Task of PessoaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaResponse> AlterarUsingPUT5Async (long? id, string nome, string tipo, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
             ApiResponse<PessoaResponse> localVarResponse = await AlterarUsingPUT5AsyncWithHttpInfo(id, nome, tipo, cpf, cnpj, dataNascimento, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade);
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
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <param name="numeroIdentidade">N\u00C3\u00BAmero da Identidade. (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00C3\u00A3o expedidor do Identidade. (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00C3\u00A3o da Identidade. (optional)</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> AlterarUsingPUT5AsyncWithHttpInfo (long? id, string nome, string tipo, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT5");
            // verify the required parameter 'nome' is set
            if (nome == null) throw new ApiException(400, "Missing required parameter 'nome' when calling AlterarUsingPUT5");
            // verify the required parameter 'tipo' is set
            if (tipo == null) throw new ApiException(400, "Missing required parameter 'tipo' when calling AlterarUsingPUT5");
            
    
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
            
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (tipo != null) localVarQueryParams.Add("tipo", Configuration.ApiClient.ParameterToString(tipo)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (cnpj != null) localVarQueryParams.Add("cnpj", Configuration.ApiClient.ParameterToString(cnpj)); // query parameter
            if (dataNascimento != null) localVarQueryParams.Add("dataNascimento", Configuration.ApiClient.ParameterToString(dataNascimento)); // query parameter
            if (sexo != null) localVarQueryParams.Add("sexo", Configuration.ApiClient.ParameterToString(sexo)); // query parameter
            if (numeroIdentidade != null) localVarQueryParams.Add("numeroIdentidade", Configuration.ApiClient.ParameterToString(numeroIdentidade)); // query parameter
            if (orgaoExpedidorIdentidade != null) localVarQueryParams.Add("orgaoExpedidorIdentidade", Configuration.ApiClient.ParameterToString(orgaoExpedidorIdentidade)); // query parameter
            if (unidadeFederativaIdentidade != null) localVarQueryParams.Add("unidadeFederativaIdentidade", Configuration.ApiClient.ParameterToString(unidadeFederativaIdentidade)); // query parameter
            if (dataEmissaoIdentidade != null) localVarQueryParams.Add("dataEmissaoIdentidade", Configuration.ApiClient.ParameterToString(dataEmissaoIdentidade)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
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
        /// <returns>TelefoneResponse</returns>
        public TelefoneResponse AlterarUsingPUT6 (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null)
        {
             ApiResponse<TelefoneResponse> localVarResponse = AlterarUsingPUT6WithHttpInfo(id, idTipoTelefone, ddd, telefone, ramal);
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
        /// <returns>ApiResponse of TelefoneResponse</returns>
        public ApiResponse< TelefoneResponse > AlterarUsingPUT6WithHttpInfo (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastrosClientesApi->AlterarUsingPUT6");
            
    
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
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
        /// <returns>Task of TelefoneResponse</returns>
        public async System.Threading.Tasks.Task<TelefoneResponse> AlterarUsingPUT6Async (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null)
        {
             ApiResponse<TelefoneResponse> localVarResponse = await AlterarUsingPUT6AsyncWithHttpInfo(id, idTipoTelefone, ddd, telefone, ramal);
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
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> AlterarUsingPUT6AsyncWithHttpInfo (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT6");
            
    
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
        }
        
        /// <summary>
        /// Permite atribuir um documento para uma Conta Este m\u00C3\u00A9todo permite que seja atribu\u00C3\u00ADdo a uma determinada Conta um documento que esteja armazenado no PIER Cloud, informando qual o tipo do documento e o seu respectivo id.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do arquivo</param> 
        /// <param name="atribuirAssinaturaClienteRequest">atribuirAssinaturaClienteRequest</param> 
        /// <returns>Object</returns>
        public Object AtribuirAssinaturaClienteUsingPOST (long? id, AtribuirAssinaturaClienteRequest atribuirAssinaturaClienteRequest)
        {
             ApiResponse<Object> localVarResponse = AtribuirAssinaturaClienteUsingPOSTWithHttpInfo(id, atribuirAssinaturaClienteRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite atribuir um documento para uma Conta Este m\u00C3\u00A9todo permite que seja atribu\u00C3\u00ADdo a uma determinada Conta um documento que esteja armazenado no PIER Cloud, informando qual o tipo do documento e o seu respectivo id.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do arquivo</param> 
        /// <param name="atribuirAssinaturaClienteRequest">atribuirAssinaturaClienteRequest</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > AtribuirAssinaturaClienteUsingPOSTWithHttpInfo (long? id, AtribuirAssinaturaClienteRequest atribuirAssinaturaClienteRequest)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastrosClientesApi->AtribuirAssinaturaClienteUsingPOST");
            
            // verify the required parameter 'atribuirAssinaturaClienteRequest' is set
            if (atribuirAssinaturaClienteRequest == null)
                throw new ApiException(400, "Missing required parameter 'atribuirAssinaturaClienteRequest' when calling CadastrosClientesApi->AtribuirAssinaturaClienteUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/atribuir-assinatura-cliente";
    
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
            
            
            
            
            if (atribuirAssinaturaClienteRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(atribuirAssinaturaClienteRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = atribuirAssinaturaClienteRequest; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirAssinaturaClienteUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirAssinaturaClienteUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Permite atribuir um documento para uma Conta Este m\u00C3\u00A9todo permite que seja atribu\u00C3\u00ADdo a uma determinada Conta um documento que esteja armazenado no PIER Cloud, informando qual o tipo do documento e o seu respectivo id.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do arquivo</param>
        /// <param name="atribuirAssinaturaClienteRequest">atribuirAssinaturaClienteRequest</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> AtribuirAssinaturaClienteUsingPOSTAsync (long? id, AtribuirAssinaturaClienteRequest atribuirAssinaturaClienteRequest)
        {
             ApiResponse<Object> localVarResponse = await AtribuirAssinaturaClienteUsingPOSTAsyncWithHttpInfo(id, atribuirAssinaturaClienteRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite atribuir um documento para uma Conta Este m\u00C3\u00A9todo permite que seja atribu\u00C3\u00ADdo a uma determinada Conta um documento que esteja armazenado no PIER Cloud, informando qual o tipo do documento e o seu respectivo id.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do arquivo</param>
        /// <param name="atribuirAssinaturaClienteRequest">atribuirAssinaturaClienteRequest</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AtribuirAssinaturaClienteUsingPOSTAsyncWithHttpInfo (long? id, AtribuirAssinaturaClienteRequest atribuirAssinaturaClienteRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtribuirAssinaturaClienteUsingPOST");
            // verify the required parameter 'atribuirAssinaturaClienteRequest' is set
            if (atribuirAssinaturaClienteRequest == null) throw new ApiException(400, "Missing required parameter 'atribuirAssinaturaClienteRequest' when calling AtribuirAssinaturaClienteUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/atribuir-assinatura-cliente";
    
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
            
            
            
            
            if (atribuirAssinaturaClienteRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(atribuirAssinaturaClienteRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = atribuirAssinaturaClienteRequest; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirAssinaturaClienteUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirAssinaturaClienteUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta Este m\u00C3\u00A9todo permite que sejam cadastrados um portador Adicional para uma determinada Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="persist">persist</param> 
        /// <returns>AdicionalResponse</returns>
        public AdicionalResponse CadastrarUsingPOST (long? id, AdicionalPersist persist)
        {
             ApiResponse<AdicionalResponse> localVarResponse = CadastrarUsingPOSTWithHttpInfo(id, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta Este m\u00C3\u00A9todo permite que sejam cadastrados um portador Adicional para uma determinada Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of AdicionalResponse</returns>
        public ApiResponse< AdicionalResponse > CadastrarUsingPOSTWithHttpInfo (long? id, AdicionalPersist persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastrosClientesApi->CadastrarUsingPOST");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling CadastrosClientesApi->CadastrarUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/cadastrar-adicional";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdicionalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta Este m\u00C3\u00A9todo permite que sejam cadastrados um portador Adicional para uma determinada Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of AdicionalResponse</returns>
        public async System.Threading.Tasks.Task<AdicionalResponse> CadastrarUsingPOSTAsync (long? id, AdicionalPersist persist)
        {
             ApiResponse<AdicionalResponse> localVarResponse = await CadastrarUsingPOSTAsyncWithHttpInfo(id, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta Este m\u00C3\u00A9todo permite que sejam cadastrados um portador Adicional para uma determinada Conta.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (AdicionalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdicionalResponse>> CadastrarUsingPOSTAsyncWithHttpInfo (long? id, AdicionalPersist persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CadastrarUsingPOST");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling CadastrarUsingPOST");
            
    
            var localVarPath = "/api/contas/{id}/cadastrar-adicional";
    
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
            
            
            
            
            if (persist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdicionalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os detalhes de uma determinada Pessoa Este m\u00C3\u00A9todo permite a consulta dos detalhes de uma Pessoa existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param> 
        /// <returns>PessoaDetalheResponse</returns>
        public PessoaDetalheResponse ConsultarUsingGET10 (long? id)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = ConsultarUsingGET10WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os detalhes de uma determinada Pessoa Este m\u00C3\u00A9todo permite a consulta dos detalhes de uma Pessoa existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param> 
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        public ApiResponse< PessoaDetalheResponse > ConsultarUsingGET10WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastrosClientesApi->ConsultarUsingGET10");
            
    
            var localVarPath = "/api/pessoas-detalhes/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os detalhes de uma determinada Pessoa Este m\u00C3\u00A9todo permite a consulta dos detalhes de uma Pessoa existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<PessoaDetalheResponse> ConsultarUsingGET10Async (long? id)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = await ConsultarUsingGET10AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os detalhes de uma determinada Pessoa Este m\u00C3\u00A9todo permite a consulta dos detalhes de uma Pessoa existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> ConsultarUsingGET10AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET10");
            
    
            var localVarPath = "/api/pessoas-detalhes/{id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param> 
        /// <returns>PessoaResponse</returns>
        public PessoaResponse ConsultarUsingGET11 (long? id)
        {
             ApiResponse<PessoaResponse> localVarResponse = ConsultarUsingGET11WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param> 
        /// <returns>ApiResponse of PessoaResponse</returns>
        public ApiResponse< PessoaResponse > ConsultarUsingGET11WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastrosClientesApi->ConsultarUsingGET11");
            
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET11: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET11: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Task of PessoaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaResponse> ConsultarUsingGET11Async (long? id)
        {
             ApiResponse<PessoaResponse> localVarResponse = await ConsultarUsingGET11AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> ConsultarUsingGET11AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET11");
            
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET11: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET11: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Telefone Este m\u00C3\u00A9todo permite consultar um determinado Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param> 
        /// <returns>TelefoneResponse</returns>
        public TelefoneResponse ConsultarUsingGET16 (long? id)
        {
             ApiResponse<TelefoneResponse> localVarResponse = ConsultarUsingGET16WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Telefone Este m\u00C3\u00A9todo permite consultar um determinado Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param> 
        /// <returns>ApiResponse of TelefoneResponse</returns>
        public ApiResponse< TelefoneResponse > ConsultarUsingGET16WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastrosClientesApi->ConsultarUsingGET16");
            
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET16: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET16: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Telefone Este m\u00C3\u00A9todo permite consultar um determinado Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param>
        /// <returns>Task of TelefoneResponse</returns>
        public async System.Threading.Tasks.Task<TelefoneResponse> ConsultarUsingGET16Async (long? id)
        {
             ApiResponse<TelefoneResponse> localVarResponse = await ConsultarUsingGET16AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Telefone Este m\u00C3\u00A9todo permite consultar um determinado Telefone a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id).</param>
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> ConsultarUsingGET16AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET16");
            
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET16: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET16: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00C3\u00A7o Este m\u00C3\u00A9todo permite consultar um determinado Endere\u00C3\u00A7o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id).</param> 
        /// <returns>EnderecoResponse</returns>
        public EnderecoResponse ConsultarUsingGET6 (long? id)
        {
             ApiResponse<EnderecoResponse> localVarResponse = ConsultarUsingGET6WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00C3\u00A7o Este m\u00C3\u00A9todo permite consultar um determinado Endere\u00C3\u00A7o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id).</param> 
        /// <returns>ApiResponse of EnderecoResponse</returns>
        public ApiResponse< EnderecoResponse > ConsultarUsingGET6WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastrosClientesApi->ConsultarUsingGET6");
            
    
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
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00C3\u00A7o Este m\u00C3\u00A9todo permite consultar um determinado Endere\u00C3\u00A7o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id).</param>
        /// <returns>Task of EnderecoResponse</returns>
        public async System.Threading.Tasks.Task<EnderecoResponse> ConsultarUsingGET6Async (long? id)
        {
             ApiResponse<EnderecoResponse> localVarResponse = await ConsultarUsingGET6AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00C3\u00A7o Este m\u00C3\u00A9todo permite consultar um determinado Endere\u00C3\u00A7o a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Endere\u00C3\u00A7o (id).</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> ConsultarUsingGET6AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET6");
            
    
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
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }
        
        /// <summary>
        /// Lista os Detalhes das Pessoas cadastradas no Emissor Este m\u00C3\u00A9todo permite que sejam listadas od detalhes das Pessoas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo identificador da pessoa (optional)</param> 
        /// <param name="nomeMae">Apresenta o nome da m\u00C3\u00A3e da pessoa fisica (optional)</param> 
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param> 
        /// <param name="idProfissao">Profiss\u00C3\u00A3o da pessoa fisica (optional)</param> 
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00C3\u00A7\u00C3\u00A3o da pessoa fisica (optional)</param> 
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param> 
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia. (optional)</param> 
        /// <param name="numeroContaCorrente">N\u00C3\u00BAmero da conta corrente. (optional)</param> 
        /// <param name="email">Email da pessoa fisica (optional)</param> 
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00C3\u00A3o (optional)</param> 
        /// <returns>PagePessoaDetalheResponse</returns>
        public PagePessoaDetalheResponse ListarUsingGET14 (int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, int? idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null)
        {
             ApiResponse<PagePessoaDetalheResponse> localVarResponse = ListarUsingGET14WithHttpInfo(page, limit, idPessoa, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroAgencia, numeroContaCorrente, email, nomeEmpresa);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Detalhes das Pessoas cadastradas no Emissor Este m\u00C3\u00A9todo permite que sejam listadas od detalhes das Pessoas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo identificador da pessoa (optional)</param> 
        /// <param name="nomeMae">Apresenta o nome da m\u00C3\u00A3e da pessoa fisica (optional)</param> 
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param> 
        /// <param name="idProfissao">Profiss\u00C3\u00A3o da pessoa fisica (optional)</param> 
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00C3\u00A7\u00C3\u00A3o da pessoa fisica (optional)</param> 
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param> 
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia. (optional)</param> 
        /// <param name="numeroContaCorrente">N\u00C3\u00BAmero da conta corrente. (optional)</param> 
        /// <param name="email">Email da pessoa fisica (optional)</param> 
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00C3\u00A3o (optional)</param> 
        /// <returns>ApiResponse of PagePessoaDetalheResponse</returns>
        public ApiResponse< PagePessoaDetalheResponse > ListarUsingGET14WithHttpInfo (int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, int? idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null)
        {
            
    
            var localVarPath = "/api/pessoas-detalhes";
    
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
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (nomeMae != null) localVarQueryParams.Add("nomeMae", Configuration.ApiClient.ParameterToString(nomeMae)); // query parameter
            if (idEstadoCivil != null) localVarQueryParams.Add("idEstadoCivil", Configuration.ApiClient.ParameterToString(idEstadoCivil)); // query parameter
            if (idProfissao != null) localVarQueryParams.Add("idProfissao", Configuration.ApiClient.ParameterToString(idProfissao)); // query parameter
            if (idNaturezaOcupacao != null) localVarQueryParams.Add("idNaturezaOcupacao", Configuration.ApiClient.ParameterToString(idNaturezaOcupacao)); // query parameter
            if (idNacionalidade != null) localVarQueryParams.Add("idNacionalidade", Configuration.ApiClient.ParameterToString(idNacionalidade)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroContaCorrente != null) localVarQueryParams.Add("numeroContaCorrente", Configuration.ApiClient.ParameterToString(numeroContaCorrente)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (nomeEmpresa != null) localVarQueryParams.Add("nomeEmpresa", Configuration.ApiClient.ParameterToString(nomeEmpresa)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET14: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET14: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Lista os Detalhes das Pessoas cadastradas no Emissor Este m\u00C3\u00A9todo permite que sejam listadas od detalhes das Pessoas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo identificador da pessoa (optional)</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00C3\u00A3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00C3\u00A7\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia. (optional)</param>
        /// <param name="numeroContaCorrente">N\u00C3\u00BAmero da conta corrente. (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00C3\u00A3o (optional)</param>
        /// <returns>Task of PagePessoaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<PagePessoaDetalheResponse> ListarUsingGET14Async (int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, int? idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null)
        {
             ApiResponse<PagePessoaDetalheResponse> localVarResponse = await ListarUsingGET14AsyncWithHttpInfo(page, limit, idPessoa, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroAgencia, numeroContaCorrente, email, nomeEmpresa);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Detalhes das Pessoas cadastradas no Emissor Este m\u00C3\u00A9todo permite que sejam listadas od detalhes das Pessoas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo identificador da pessoa (optional)</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00C3\u00A3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00C3\u00A7\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia. (optional)</param>
        /// <param name="numeroContaCorrente">N\u00C3\u00BAmero da conta corrente. (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00C3\u00A3o (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePessoaDetalheResponse>> ListarUsingGET14AsyncWithHttpInfo (int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, int? idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null)
        {
            
    
            var localVarPath = "/api/pessoas-detalhes";
    
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
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (nomeMae != null) localVarQueryParams.Add("nomeMae", Configuration.ApiClient.ParameterToString(nomeMae)); // query parameter
            if (idEstadoCivil != null) localVarQueryParams.Add("idEstadoCivil", Configuration.ApiClient.ParameterToString(idEstadoCivil)); // query parameter
            if (idProfissao != null) localVarQueryParams.Add("idProfissao", Configuration.ApiClient.ParameterToString(idProfissao)); // query parameter
            if (idNaturezaOcupacao != null) localVarQueryParams.Add("idNaturezaOcupacao", Configuration.ApiClient.ParameterToString(idNaturezaOcupacao)); // query parameter
            if (idNacionalidade != null) localVarQueryParams.Add("idNacionalidade", Configuration.ApiClient.ParameterToString(idNacionalidade)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroContaCorrente != null) localVarQueryParams.Add("numeroContaCorrente", Configuration.ApiClient.ParameterToString(numeroContaCorrente)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (nomeEmpresa != null) localVarQueryParams.Add("nomeEmpresa", Configuration.ApiClient.ParameterToString(nomeEmpresa)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET14: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET14: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaDetalheResponse)));
            
        }
        
        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id). (optional)</param> 
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;. (optional)</param> 
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica). (optional)</param> 
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param> 
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param> 
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param> 
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param> 
        /// <param name="numeroIdentidade">N\u00C3\u00BAmero da Identidade (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">Org\u00C3\u00A3o expedidor do RG. (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param> 
        /// <param name="dataEmissaoIdentidade">Data emiss\u00C3\u00A3o da identidade no formato aaaa-MM-dd (optional)</param> 
        /// <returns>PagePessoaResponse</returns>
        public PagePessoaResponse ListarUsingGET15 (int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
             ApiResponse<PagePessoaResponse> localVarResponse = ListarUsingGET15WithHttpInfo(page, limit, id, nome, tipo, cpf, cnpj, dataNascimento, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id). (optional)</param> 
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;. (optional)</param> 
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica). (optional)</param> 
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param> 
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param> 
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param> 
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param> 
        /// <param name="numeroIdentidade">N\u00C3\u00BAmero da Identidade (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">Org\u00C3\u00A3o expedidor do RG. (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param> 
        /// <param name="dataEmissaoIdentidade">Data emiss\u00C3\u00A3o da identidade no formato aaaa-MM-dd (optional)</param> 
        /// <returns>ApiResponse of PagePessoaResponse</returns>
        public ApiResponse< PagePessoaResponse > ListarUsingGET15WithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
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
            if (numeroIdentidade != null) localVarQueryParams.Add("numeroIdentidade", Configuration.ApiClient.ParameterToString(numeroIdentidade)); // query parameter
            if (orgaoExpedidorIdentidade != null) localVarQueryParams.Add("orgaoExpedidorIdentidade", Configuration.ApiClient.ParameterToString(orgaoExpedidorIdentidade)); // query parameter
            if (unidadeFederativaIdentidade != null) localVarQueryParams.Add("unidadeFederativaIdentidade", Configuration.ApiClient.ParameterToString(unidadeFederativaIdentidade)); // query parameter
            if (dataEmissaoIdentidade != null) localVarQueryParams.Add("dataEmissaoIdentidade", Configuration.ApiClient.ParameterToString(dataEmissaoIdentidade)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET15: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET15: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaResponse)));
            
        }

        
        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id). (optional)</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;. (optional)</param>
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica). (optional)</param>
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param>
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <param name="numeroIdentidade">N\u00C3\u00BAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00C3\u00A3o expedidor do RG. (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00C3\u00A3o da identidade no formato aaaa-MM-dd (optional)</param>
        /// <returns>Task of PagePessoaResponse</returns>
        public async System.Threading.Tasks.Task<PagePessoaResponse> ListarUsingGET15Async (int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
             ApiResponse<PagePessoaResponse> localVarResponse = await ListarUsingGET15AsyncWithHttpInfo(page, limit, id, nome, tipo, cpf, cnpj, dataNascimento, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor Este m\u00C3\u00A9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id). (optional)</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;. (optional)</param>
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica). (optional)</param>
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param>
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <param name="numeroIdentidade">N\u00C3\u00BAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00C3\u00A3o expedidor do RG. (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00C3\u00A3o da identidade no formato aaaa-MM-dd (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePessoaResponse>> ListarUsingGET15AsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
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
            if (numeroIdentidade != null) localVarQueryParams.Add("numeroIdentidade", Configuration.ApiClient.ParameterToString(numeroIdentidade)); // query parameter
            if (orgaoExpedidorIdentidade != null) localVarQueryParams.Add("orgaoExpedidorIdentidade", Configuration.ApiClient.ParameterToString(orgaoExpedidorIdentidade)); // query parameter
            if (unidadeFederativaIdentidade != null) localVarQueryParams.Add("unidadeFederativaIdentidade", Configuration.ApiClient.ParameterToString(unidadeFederativaIdentidade)); // query parameter
            if (dataEmissaoIdentidade != null) localVarQueryParams.Add("dataEmissaoIdentidade", Configuration.ApiClient.ParameterToString(dataEmissaoIdentidade)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET15: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET15: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaResponse)));
            
        }
        
        /// <summary>
        /// Lista os Telefones cadastrados no Emissor Este m\u00C3\u00A9todo permite que sejam listados os Telefones existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id). (optional)</param> 
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param> 
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param> 
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param> 
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param> 
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param> 
        /// <returns>PageTelefoneResponse</returns>
        public PageTelefoneResponse ListarUsingGET22 (int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null)
        {
             ApiResponse<PageTelefoneResponse> localVarResponse = ListarUsingGET22WithHttpInfo(page, limit, id, idTipoTelefone, idPessoa, ddd, telefone, ramal, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Telefones cadastrados no Emissor Este m\u00C3\u00A9todo permite que sejam listados os Telefones existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id). (optional)</param> 
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param> 
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param> 
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param> 
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param> 
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param> 
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param> 
        /// <returns>ApiResponse of PageTelefoneResponse</returns>
        public ApiResponse< PageTelefoneResponse > ListarUsingGET22WithHttpInfo (int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null)
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET22: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET22: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTelefoneResponse)));
            
        }

        
        /// <summary>
        /// Lista os Telefones cadastrados no Emissor Este m\u00C3\u00A9todo permite que sejam listados os Telefones existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id). (optional)</param>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <returns>Task of PageTelefoneResponse</returns>
        public async System.Threading.Tasks.Task<PageTelefoneResponse> ListarUsingGET22Async (int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null)
        {
             ApiResponse<PageTelefoneResponse> localVarResponse = await ListarUsingGET22AsyncWithHttpInfo(page, limit, id, idTipoTelefone, idPessoa, ddd, telefone, ramal, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Telefones cadastrados no Emissor Este m\u00C3\u00A9todo permite que sejam listados os Telefones existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone (id). (optional)</param>
        /// <param name="idTipoTelefone">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Tipo do Telefone (id). (optional)</param>
        /// <param name="idPessoa">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o da Pessoa (id) a qual o telefone pertence. (optional)</param>
        /// <param name="ddd">C\u00C3\u00B3digo DDD do telefone (id). (optional)</param>
        /// <param name="telefone">N\u00C3\u00BAmero do telefone. (optional)</param>
        /// <param name="ramal">N\u00C3\u00BAmero do ramal. (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <returns>Task of ApiResponse (PageTelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTelefoneResponse>> ListarUsingGET22AsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null)
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET22: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET22: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTelefoneResponse)));
            
        }
        
        /// <summary>
        /// Lista os Endere\u00C3\u00A7os cadastrados para o Emissor Este m\u00C3\u00A9todo permite que sejam listados os Endere\u00C3\u00A7os existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
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
        /// <returns>PageEnderecoResponse</returns>
        public PageEnderecoResponse ListarUsingGET9 (int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null)
        {
             ApiResponse<PageEnderecoResponse> localVarResponse = ListarUsingGET9WithHttpInfo(page, limit, id, idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais, dataInclusao, dataUltimaAtualizacao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Endere\u00C3\u00A7os cadastrados para o Emissor Este m\u00C3\u00A9todo permite que sejam listados os Endere\u00C3\u00A7os existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
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
        /// <returns>ApiResponse of PageEnderecoResponse</returns>
        public ApiResponse< PageEnderecoResponse > ListarUsingGET9WithHttpInfo (int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null)
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET9: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET9: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageEnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEnderecoResponse)));
            
        }

        
        /// <summary>
        /// Lista os Endere\u00C3\u00A7os cadastrados para o Emissor Este m\u00C3\u00A9todo permite que sejam listados os Endere\u00C3\u00A7os existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
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
        /// <returns>Task of PageEnderecoResponse</returns>
        public async System.Threading.Tasks.Task<PageEnderecoResponse> ListarUsingGET9Async (int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null)
        {
             ApiResponse<PageEnderecoResponse> localVarResponse = await ListarUsingGET9AsyncWithHttpInfo(page, limit, id, idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais, dataInclusao, dataUltimaAtualizacao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Endere\u00C3\u00A7os cadastrados para o Emissor Este m\u00C3\u00A9todo permite que sejam listados os Endere\u00C3\u00A7os existentes na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
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
        /// <returns>Task of ApiResponse (PageEnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageEnderecoResponse>> ListarUsingGET9AsyncWithHttpInfo (int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null)
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET9: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET9: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageEnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEnderecoResponse)));
            
        }
        
        /// <summary>
        /// Cadastro de Conta e Pessoa Fisica Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa F\u00C3\u00ADsica, recebendo nesta opera\u00C3\u00A7\u00C3\u00A3o todos os dados cadastrais que se fazem necess\u00C3\u00A1rios para isso. Uma vez criado, poder\u00C3\u00A1 ser acionado o m\u00C3\u00A9todo de &#39;Gera\u00C3\u00A7\u00C3\u00A3o de Cart\u00C3\u00A3o&#39; para o cliente e seus adicionais.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param> 
        /// <returns>PessoaFisicaAprovadaResponse</returns>
        public PessoaFisicaAprovadaResponse SalvarPessoaFisicaAprovadaUsingPOST (PessoaFisicaAprovadaPersist pessoaPersist)
        {
             ApiResponse<PessoaFisicaAprovadaResponse> localVarResponse = SalvarPessoaFisicaAprovadaUsingPOSTWithHttpInfo(pessoaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastro de Conta e Pessoa Fisica Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa F\u00C3\u00ADsica, recebendo nesta opera\u00C3\u00A7\u00C3\u00A3o todos os dados cadastrais que se fazem necess\u00C3\u00A1rios para isso. Uma vez criado, poder\u00C3\u00A1 ser acionado o m\u00C3\u00A9todo de &#39;Gera\u00C3\u00A7\u00C3\u00A3o de Cart\u00C3\u00A3o&#39; para o cliente e seus adicionais.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param> 
        /// <returns>ApiResponse of PessoaFisicaAprovadaResponse</returns>
        public ApiResponse< PessoaFisicaAprovadaResponse > SalvarPessoaFisicaAprovadaUsingPOSTWithHttpInfo (PessoaFisicaAprovadaPersist pessoaPersist)
        {
            
            // verify the required parameter 'pessoaPersist' is set
            if (pessoaPersist == null)
                throw new ApiException(400, "Missing required parameter 'pessoaPersist' when calling CadastrosClientesApi->SalvarPessoaFisicaAprovadaUsingPOST");
            
    
            var localVarPath = "/api/clientes-pessoas-fisicas";
    
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
            
            
            
            
            if (pessoaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(pessoaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pessoaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaFisicaAprovadaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaFisicaAprovadaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaFisicaAprovadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaFisicaAprovadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaFisicaAprovadaResponse)));
            
        }

        
        /// <summary>
        /// Cadastro de Conta e Pessoa Fisica Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa F\u00C3\u00ADsica, recebendo nesta opera\u00C3\u00A7\u00C3\u00A3o todos os dados cadastrais que se fazem necess\u00C3\u00A1rios para isso. Uma vez criado, poder\u00C3\u00A1 ser acionado o m\u00C3\u00A9todo de &#39;Gera\u00C3\u00A7\u00C3\u00A3o de Cart\u00C3\u00A3o&#39; para o cliente e seus adicionais.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of PessoaFisicaAprovadaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaFisicaAprovadaResponse> SalvarPessoaFisicaAprovadaUsingPOSTAsync (PessoaFisicaAprovadaPersist pessoaPersist)
        {
             ApiResponse<PessoaFisicaAprovadaResponse> localVarResponse = await SalvarPessoaFisicaAprovadaUsingPOSTAsyncWithHttpInfo(pessoaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastro de Conta e Pessoa Fisica Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa F\u00C3\u00ADsica, recebendo nesta opera\u00C3\u00A7\u00C3\u00A3o todos os dados cadastrais que se fazem necess\u00C3\u00A1rios para isso. Uma vez criado, poder\u00C3\u00A1 ser acionado o m\u00C3\u00A9todo de &#39;Gera\u00C3\u00A7\u00C3\u00A3o de Cart\u00C3\u00A3o&#39; para o cliente e seus adicionais.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of ApiResponse (PessoaFisicaAprovadaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaFisicaAprovadaResponse>> SalvarPessoaFisicaAprovadaUsingPOSTAsyncWithHttpInfo (PessoaFisicaAprovadaPersist pessoaPersist)
        {
            // verify the required parameter 'pessoaPersist' is set
            if (pessoaPersist == null) throw new ApiException(400, "Missing required parameter 'pessoaPersist' when calling SalvarPessoaFisicaAprovadaUsingPOST");
            
    
            var localVarPath = "/api/clientes-pessoas-fisicas";
    
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
            
            
            
            
            if (pessoaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(pessoaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pessoaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaFisicaAprovadaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaFisicaAprovadaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaFisicaAprovadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaFisicaAprovadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaFisicaAprovadaResponse)));
            
        }
        
        /// <summary>
        /// Cadastro de Conta e Pessoa Jur\u00C3\u00ADdica Cadastro de Conta e Pessoa Jur\u00C3\u00ADdica Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa Jur\u00C3\u00ADdica, recebendo nesta opera\u00C3\u00A7\u00C3\u00A3o todos os dados cadastrais que se fazem necess\u00C3\u00A1rios para isso, inclu\u00C3\u00ADndo o registro de cada um dos s\u00C3\u00B3cios. Uma vez criado, poder\u00C3\u00A1 ser acionado o m\u00C3\u00A9todo de &#39;Gera\u00C3\u00A7\u00C3\u00A3o de Cart\u00C3\u00A3o&#39; para o cliente e cada um dos s\u00C3\u00B3cios vinculados.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param> 
        /// <returns>PessoaJuridicaAprovadaResponse</returns>
        public PessoaJuridicaAprovadaResponse SalvarPessoaJuridicaAprovadaUsingPOST (PessoaJuridicaAprovadaPersist pessoaPersist)
        {
             ApiResponse<PessoaJuridicaAprovadaResponse> localVarResponse = SalvarPessoaJuridicaAprovadaUsingPOSTWithHttpInfo(pessoaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastro de Conta e Pessoa Jur\u00C3\u00ADdica Cadastro de Conta e Pessoa Jur\u00C3\u00ADdica Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa Jur\u00C3\u00ADdica, recebendo nesta opera\u00C3\u00A7\u00C3\u00A3o todos os dados cadastrais que se fazem necess\u00C3\u00A1rios para isso, inclu\u00C3\u00ADndo o registro de cada um dos s\u00C3\u00B3cios. Uma vez criado, poder\u00C3\u00A1 ser acionado o m\u00C3\u00A9todo de &#39;Gera\u00C3\u00A7\u00C3\u00A3o de Cart\u00C3\u00A3o&#39; para o cliente e cada um dos s\u00C3\u00B3cios vinculados.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param> 
        /// <returns>ApiResponse of PessoaJuridicaAprovadaResponse</returns>
        public ApiResponse< PessoaJuridicaAprovadaResponse > SalvarPessoaJuridicaAprovadaUsingPOSTWithHttpInfo (PessoaJuridicaAprovadaPersist pessoaPersist)
        {
            
            // verify the required parameter 'pessoaPersist' is set
            if (pessoaPersist == null)
                throw new ApiException(400, "Missing required parameter 'pessoaPersist' when calling CadastrosClientesApi->SalvarPessoaJuridicaAprovadaUsingPOST");
            
    
            var localVarPath = "/api/clientes-pessoas-juridicas";
    
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
            
            
            
            
            if (pessoaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(pessoaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pessoaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaJuridicaAprovadaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaJuridicaAprovadaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaJuridicaAprovadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaAprovadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaAprovadaResponse)));
            
        }

        
        /// <summary>
        /// Cadastro de Conta e Pessoa Jur\u00C3\u00ADdica Cadastro de Conta e Pessoa Jur\u00C3\u00ADdica Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa Jur\u00C3\u00ADdica, recebendo nesta opera\u00C3\u00A7\u00C3\u00A3o todos os dados cadastrais que se fazem necess\u00C3\u00A1rios para isso, inclu\u00C3\u00ADndo o registro de cada um dos s\u00C3\u00B3cios. Uma vez criado, poder\u00C3\u00A1 ser acionado o m\u00C3\u00A9todo de &#39;Gera\u00C3\u00A7\u00C3\u00A3o de Cart\u00C3\u00A3o&#39; para o cliente e cada um dos s\u00C3\u00B3cios vinculados.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of PessoaJuridicaAprovadaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaJuridicaAprovadaResponse> SalvarPessoaJuridicaAprovadaUsingPOSTAsync (PessoaJuridicaAprovadaPersist pessoaPersist)
        {
             ApiResponse<PessoaJuridicaAprovadaResponse> localVarResponse = await SalvarPessoaJuridicaAprovadaUsingPOSTAsyncWithHttpInfo(pessoaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastro de Conta e Pessoa Jur\u00C3\u00ADdica Cadastro de Conta e Pessoa Jur\u00C3\u00ADdica Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa Jur\u00C3\u00ADdica, recebendo nesta opera\u00C3\u00A7\u00C3\u00A3o todos os dados cadastrais que se fazem necess\u00C3\u00A1rios para isso, inclu\u00C3\u00ADndo o registro de cada um dos s\u00C3\u00B3cios. Uma vez criado, poder\u00C3\u00A1 ser acionado o m\u00C3\u00A9todo de &#39;Gera\u00C3\u00A7\u00C3\u00A3o de Cart\u00C3\u00A3o&#39; para o cliente e cada um dos s\u00C3\u00B3cios vinculados.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaAprovadaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaAprovadaResponse>> SalvarPessoaJuridicaAprovadaUsingPOSTAsyncWithHttpInfo (PessoaJuridicaAprovadaPersist pessoaPersist)
        {
            // verify the required parameter 'pessoaPersist' is set
            if (pessoaPersist == null) throw new ApiException(400, "Missing required parameter 'pessoaPersist' when calling SalvarPessoaJuridicaAprovadaUsingPOST");
            
    
            var localVarPath = "/api/clientes-pessoas-juridicas";
    
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
            
            
            
            
            if (pessoaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(pessoaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pessoaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaJuridicaAprovadaUsingPOST: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaJuridicaAprovadaUsingPOST: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaJuridicaAprovadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaAprovadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaAprovadaResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de um nova Pessoa Este m\u00C3\u00A9todo permite que seja cadastrado uma nova Pessoa na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;.</param> 
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica).</param> 
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param> 
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param> 
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd. (optional)</param> 
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param> 
        /// <param name="numeroIdentidade">N\u00C3\u00BAmero da Identidade. (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">Org\u00C3\u00A3o expedidor do Identidade. (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param> 
        /// <param name="dataEmissaoIdentidade">Data emiss\u00C3\u00A3o da Identidade. (optional)</param> 
        /// <returns>PessoaResponse</returns>
        public PessoaResponse SalvarUsingPOST10 (string nome, string tipo, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
             ApiResponse<PessoaResponse> localVarResponse = SalvarUsingPOST10WithHttpInfo(nome, tipo, cpf, cnpj, dataNascimento, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade);
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
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd. (optional)</param> 
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param> 
        /// <param name="numeroIdentidade">N\u00C3\u00BAmero da Identidade. (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">Org\u00C3\u00A3o expedidor do Identidade. (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param> 
        /// <param name="dataEmissaoIdentidade">Data emiss\u00C3\u00A3o da Identidade. (optional)</param> 
        /// <returns>ApiResponse of PessoaResponse</returns>
        public ApiResponse< PessoaResponse > SalvarUsingPOST10WithHttpInfo (string nome, string tipo, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
            
            // verify the required parameter 'nome' is set
            if (nome == null)
                throw new ApiException(400, "Missing required parameter 'nome' when calling CadastrosClientesApi->SalvarUsingPOST10");
            
            // verify the required parameter 'tipo' is set
            if (tipo == null)
                throw new ApiException(400, "Missing required parameter 'tipo' when calling CadastrosClientesApi->SalvarUsingPOST10");
            
    
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
            if (numeroIdentidade != null) localVarQueryParams.Add("numeroIdentidade", Configuration.ApiClient.ParameterToString(numeroIdentidade)); // query parameter
            if (orgaoExpedidorIdentidade != null) localVarQueryParams.Add("orgaoExpedidorIdentidade", Configuration.ApiClient.ParameterToString(orgaoExpedidorIdentidade)); // query parameter
            if (unidadeFederativaIdentidade != null) localVarQueryParams.Add("unidadeFederativaIdentidade", Configuration.ApiClient.ParameterToString(unidadeFederativaIdentidade)); // query parameter
            if (dataEmissaoIdentidade != null) localVarQueryParams.Add("dataEmissaoIdentidade", Configuration.ApiClient.ParameterToString(dataEmissaoIdentidade)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de um nova Pessoa Este m\u00C3\u00A9todo permite que seja cadastrado uma nova Pessoa na base de dados do Emissor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00C3\u00A3o Social (Nome Empresarial)&#39;.</param>
        /// <param name="tipo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do tipo da Pessoa, sendo: (\&quot;PF\&quot;: Pessoa F\u00C3\u00ADsica), (\&quot;PJ\&quot;: Pessoa Jur\u00C3\u00ADdica).</param>
        /// <param name="cpf">N\u00C3\u00BAmero do CPF, quando PF. (optional)</param>
        /// <param name="cnpj">N\u00C3\u00BAmero do CNPJ, quando PJ. (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <param name="numeroIdentidade">N\u00C3\u00BAmero da Identidade. (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00C3\u00A3o expedidor do Identidade. (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00C3\u00A3o da Identidade. (optional)</param>
        /// <returns>Task of PessoaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaResponse> SalvarUsingPOST10Async (string nome, string tipo, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
             ApiResponse<PessoaResponse> localVarResponse = await SalvarUsingPOST10AsyncWithHttpInfo(nome, tipo, cpf, cnpj, dataNascimento, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade);
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
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd. (optional)</param>
        /// <param name="sexo">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do sexo da Pessoa, quando PF, sendo: (\&quot;M\&quot;: Masculino), (\&quot;F\&quot;: Feminino), (\&quot;O\&quot;: Outro), (\&quot;N\&quot;: N\u00C3\u00A3o Especificado). (optional)</param>
        /// <param name="numeroIdentidade">N\u00C3\u00BAmero da Identidade. (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00C3\u00A3o expedidor do Identidade. (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00C3\u00A3o da Identidade. (optional)</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> SalvarUsingPOST10AsyncWithHttpInfo (string nome, string tipo, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
            // verify the required parameter 'nome' is set
            if (nome == null) throw new ApiException(400, "Missing required parameter 'nome' when calling SalvarUsingPOST10");
            // verify the required parameter 'tipo' is set
            if (tipo == null) throw new ApiException(400, "Missing required parameter 'tipo' when calling SalvarUsingPOST10");
            
    
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
            if (numeroIdentidade != null) localVarQueryParams.Add("numeroIdentidade", Configuration.ApiClient.ParameterToString(numeroIdentidade)); // query parameter
            if (orgaoExpedidorIdentidade != null) localVarQueryParams.Add("orgaoExpedidorIdentidade", Configuration.ApiClient.ParameterToString(orgaoExpedidorIdentidade)); // query parameter
            if (unidadeFederativaIdentidade != null) localVarQueryParams.Add("unidadeFederativaIdentidade", Configuration.ApiClient.ParameterToString(unidadeFederativaIdentidade)); // query parameter
            if (dataEmissaoIdentidade != null) localVarQueryParams.Add("dataEmissaoIdentidade", Configuration.ApiClient.ParameterToString(dataEmissaoIdentidade)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST10: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST10: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
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
        /// <returns>TelefoneResponse</returns>
        public TelefoneResponse SalvarUsingPOST12 (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null)
        {
             ApiResponse<TelefoneResponse> localVarResponse = SalvarUsingPOST12WithHttpInfo(idTipoTelefone, idPessoa, ddd, telefone, ramal);
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
        /// <returns>ApiResponse of TelefoneResponse</returns>
        public ApiResponse< TelefoneResponse > SalvarUsingPOST12WithHttpInfo (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null)
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST12: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST12: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
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
        /// <returns>Task of TelefoneResponse</returns>
        public async System.Threading.Tasks.Task<TelefoneResponse> SalvarUsingPOST12Async (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null)
        {
             ApiResponse<TelefoneResponse> localVarResponse = await SalvarUsingPOST12AsyncWithHttpInfo(idTipoTelefone, idPessoa, ddd, telefone, ramal);
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
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> SalvarUsingPOST12AsyncWithHttpInfo (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null)
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST12: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST12: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
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
        /// <returns>EnderecoResponse</returns>
        public EnderecoResponse SalvarUsingPOST5 (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null)
        {
             ApiResponse<EnderecoResponse> localVarResponse = SalvarUsingPOST5WithHttpInfo(idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais);
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
        /// <returns>ApiResponse of EnderecoResponse</returns>
        public ApiResponse< EnderecoResponse > SalvarUsingPOST5WithHttpInfo (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null)
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
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
        /// <returns>Task of EnderecoResponse</returns>
        public async System.Threading.Tasks.Task<EnderecoResponse> SalvarUsingPOST5Async (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null)
        {
             ApiResponse<EnderecoResponse> localVarResponse = await SalvarUsingPOST5AsyncWithHttpInfo(idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais);
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
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> SalvarUsingPOST5AsyncWithHttpInfo (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null)
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }
        
        /// <summary>
        /// Inclui a conta como registro para integra\u00C3\u00A7\u00C3\u00A3o Este recurso permite incluir uma conta como registro para integra\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="idPropostaExterna">Apresenta o identificador da proposta externa. (optional)</param> 
        /// <returns>IntegracaoEmissorResponse</returns>
        public IntegracaoEmissorResponse SalvarUsingPOST6 (long? id, long? idPropostaExterna = null)
        {
             ApiResponse<IntegracaoEmissorResponse> localVarResponse = SalvarUsingPOST6WithHttpInfo(id, idPropostaExterna);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Inclui a conta como registro para integra\u00C3\u00A7\u00C3\u00A3o Este recurso permite incluir uma conta como registro para integra\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param> 
        /// <param name="idPropostaExterna">Apresenta o identificador da proposta externa. (optional)</param> 
        /// <returns>ApiResponse of IntegracaoEmissorResponse</returns>
        public ApiResponse< IntegracaoEmissorResponse > SalvarUsingPOST6WithHttpInfo (long? id, long? idPropostaExterna = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastrosClientesApi->SalvarUsingPOST6");
            
    
            var localVarPath = "/api/contas/{id}/incluir-registro-integracao";
    
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
            
            if (idPropostaExterna != null) localVarQueryParams.Add("idPropostaExterna", Configuration.ApiClient.ParameterToString(idPropostaExterna)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<IntegracaoEmissorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegracaoEmissorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegracaoEmissorResponse)));
            
        }

        
        /// <summary>
        /// Inclui a conta como registro para integra\u00C3\u00A7\u00C3\u00A3o Este recurso permite incluir uma conta como registro para integra\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idPropostaExterna">Apresenta o identificador da proposta externa. (optional)</param>
        /// <returns>Task of IntegracaoEmissorResponse</returns>
        public async System.Threading.Tasks.Task<IntegracaoEmissorResponse> SalvarUsingPOST6Async (long? id, long? idPropostaExterna = null)
        {
             ApiResponse<IntegracaoEmissorResponse> localVarResponse = await SalvarUsingPOST6AsyncWithHttpInfo(id, idPropostaExterna);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Inclui a conta como registro para integra\u00C3\u00A7\u00C3\u00A3o Este recurso permite incluir uma conta como registro para integra\u00C3\u00A7\u00C3\u00A3o.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da conta (id).</param>
        /// <param name="idPropostaExterna">Apresenta o identificador da proposta externa. (optional)</param>
        /// <returns>Task of ApiResponse (IntegracaoEmissorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IntegracaoEmissorResponse>> SalvarUsingPOST6AsyncWithHttpInfo (long? id, long? idPropostaExterna = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SalvarUsingPOST6");
            
    
            var localVarPath = "/api/contas/{id}/incluir-registro-integracao";
    
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
            
            if (idPropostaExterna != null) localVarQueryParams.Add("idPropostaExterna", Configuration.ApiClient.ParameterToString(idPropostaExterna)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST6: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST6: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegracaoEmissorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegracaoEmissorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegracaoEmissorResponse)));
            
        }
        
        /// <summary>
        /// Salvar os detalhes de uma determinada Pessoa Este m\u00C3\u00A9todo permite que seja incluido na base do emissor os detalhes de uma determinada Pessoa.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Apresenta o c\u00C3\u00B3digo identificador da pessoa</param> 
        /// <param name="nomeMae">Apresenta o nome da m\u00C3\u00A3e da pessoa fisica (optional)</param> 
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param> 
        /// <param name="idProfissao">Profiss\u00C3\u00A3o da pessoa fisica (optional)</param> 
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00C3\u00A7\u00C3\u00A3o da pessoa fisica (optional)</param> 
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param> 
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia. (optional)</param> 
        /// <param name="numeroContaCorrente">N\u00C3\u00BAmero da conta corrente. (optional)</param> 
        /// <param name="email">Email da pessoa fisica (optional)</param> 
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00C3\u00A3o (optional)</param> 
        /// <returns>PessoaDetalheResponse</returns>
        public PessoaDetalheResponse SalvarUsingPOST9 (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, int? idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = SalvarUsingPOST9WithHttpInfo(idPessoa, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroAgencia, numeroContaCorrente, email, nomeEmpresa);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Salvar os detalhes de uma determinada Pessoa Este m\u00C3\u00A9todo permite que seja incluido na base do emissor os detalhes de uma determinada Pessoa.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Apresenta o c\u00C3\u00B3digo identificador da pessoa</param> 
        /// <param name="nomeMae">Apresenta o nome da m\u00C3\u00A3e da pessoa fisica (optional)</param> 
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param> 
        /// <param name="idProfissao">Profiss\u00C3\u00A3o da pessoa fisica (optional)</param> 
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00C3\u00A7\u00C3\u00A3o da pessoa fisica (optional)</param> 
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param> 
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia. (optional)</param> 
        /// <param name="numeroContaCorrente">N\u00C3\u00BAmero da conta corrente. (optional)</param> 
        /// <param name="email">Email da pessoa fisica (optional)</param> 
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00C3\u00A3o (optional)</param> 
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        public ApiResponse< PessoaDetalheResponse > SalvarUsingPOST9WithHttpInfo (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, int? idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null)
        {
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling CadastrosClientesApi->SalvarUsingPOST9");
            
    
            var localVarPath = "/api/pessoas-detalhes";
    
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
            if (nomeMae != null) localVarQueryParams.Add("nomeMae", Configuration.ApiClient.ParameterToString(nomeMae)); // query parameter
            if (idEstadoCivil != null) localVarQueryParams.Add("idEstadoCivil", Configuration.ApiClient.ParameterToString(idEstadoCivil)); // query parameter
            if (idProfissao != null) localVarQueryParams.Add("idProfissao", Configuration.ApiClient.ParameterToString(idProfissao)); // query parameter
            if (idNaturezaOcupacao != null) localVarQueryParams.Add("idNaturezaOcupacao", Configuration.ApiClient.ParameterToString(idNaturezaOcupacao)); // query parameter
            if (idNacionalidade != null) localVarQueryParams.Add("idNacionalidade", Configuration.ApiClient.ParameterToString(idNacionalidade)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroContaCorrente != null) localVarQueryParams.Add("numeroContaCorrente", Configuration.ApiClient.ParameterToString(numeroContaCorrente)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (nomeEmpresa != null) localVarQueryParams.Add("nomeEmpresa", Configuration.ApiClient.ParameterToString(nomeEmpresa)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST9: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST9: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Salvar os detalhes de uma determinada Pessoa Este m\u00C3\u00A9todo permite que seja incluido na base do emissor os detalhes de uma determinada Pessoa.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Apresenta o c\u00C3\u00B3digo identificador da pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00C3\u00A3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00C3\u00A7\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia. (optional)</param>
        /// <param name="numeroContaCorrente">N\u00C3\u00BAmero da conta corrente. (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00C3\u00A3o (optional)</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<PessoaDetalheResponse> SalvarUsingPOST9Async (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, int? idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = await SalvarUsingPOST9AsyncWithHttpInfo(idPessoa, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroAgencia, numeroContaCorrente, email, nomeEmpresa);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Salvar os detalhes de uma determinada Pessoa Este m\u00C3\u00A9todo permite que seja incluido na base do emissor os detalhes de uma determinada Pessoa.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Apresenta o c\u00C3\u00B3digo identificador da pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00C3\u00A3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00C3\u00A7\u00C3\u00A3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroAgencia">N\u00C3\u00BAmero da ag\u00C3\u00AAncia. (optional)</param>
        /// <param name="numeroContaCorrente">N\u00C3\u00BAmero da conta corrente. (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00C3\u00A3o (optional)</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> SalvarUsingPOST9AsyncWithHttpInfo (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, int? idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null)
        {
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling SalvarUsingPOST9");
            
    
            var localVarPath = "/api/pessoas-detalhes";
    
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
            if (nomeMae != null) localVarQueryParams.Add("nomeMae", Configuration.ApiClient.ParameterToString(nomeMae)); // query parameter
            if (idEstadoCivil != null) localVarQueryParams.Add("idEstadoCivil", Configuration.ApiClient.ParameterToString(idEstadoCivil)); // query parameter
            if (idProfissao != null) localVarQueryParams.Add("idProfissao", Configuration.ApiClient.ParameterToString(idProfissao)); // query parameter
            if (idNaturezaOcupacao != null) localVarQueryParams.Add("idNaturezaOcupacao", Configuration.ApiClient.ParameterToString(idNaturezaOcupacao)); // query parameter
            if (idNacionalidade != null) localVarQueryParams.Add("idNacionalidade", Configuration.ApiClient.ParameterToString(idNacionalidade)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroContaCorrente != null) localVarQueryParams.Add("numeroContaCorrente", Configuration.ApiClient.ParameterToString(numeroContaCorrente)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (nomeEmpresa != null) localVarQueryParams.Add("nomeEmpresa", Configuration.ApiClient.ParameterToString(nomeEmpresa)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST9: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST9: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }
        
    }
    
}
