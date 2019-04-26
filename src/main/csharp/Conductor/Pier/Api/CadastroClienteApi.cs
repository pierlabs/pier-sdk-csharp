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
    public interface ICadastroClienteApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Altera Adicional de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado um portador Adicional de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <param name="adicionalUpdate">adicionalUpdate</param>
        /// <returns>AdicionalDetalheResponse</returns>
        AdicionalDetalheResponse Alterar (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate);
  
        /// <summary>
        /// Altera Adicional de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado um portador Adicional de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <param name="adicionalUpdate">adicionalUpdate</param>
        /// <returns>ApiResponse of AdicionalDetalheResponse</returns>
        ApiResponse<AdicionalDetalheResponse> AlterarWithHttpInfo (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate);
        
        /// <summary>
        /// Atualiza os dados de um determinado Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado na base do emissor um ou mais registros ligados a um determinado Endere\u00E7o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">CEP do endere\u00E7o (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <returns>EnderecoResponse</returns>
        EnderecoResponse Alterar_0 (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null);
  
        /// <summary>
        /// Atualiza os dados de um determinado Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado na base do emissor um ou mais registros ligados a um determinado Endere\u00E7o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">CEP do endere\u00E7o (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <returns>ApiResponse of EnderecoResponse</returns>
        ApiResponse<EnderecoResponse> Alterar_0WithHttpInfo (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null);
        
        /// <summary>
        /// Atualiza os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado na base do emissor os detalhes de uma determinada Pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param>
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param>
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param>
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <returns>PessoaDetalheResponse</returns>
        PessoaDetalheResponse Alterar_1 (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, string numeroCnh = null);
  
        /// <summary>
        /// Atualiza os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado na base do emissor os detalhes de uma determinada Pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param>
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param>
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param>
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        ApiResponse<PessoaDetalheResponse> Alterar_1WithHttpInfo (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, string numeroCnh = null);
        
        /// <summary>
        /// Atualiza os dados de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado na base do emissor um registro de determinada Pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param>
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param>
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param>
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param>
        /// <param name="sexo">Sexo da Pessoa (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param>
        /// <returns>PessoaResponse</returns>
        PessoaResponse Alterar_2 (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
  
        /// <summary>
        /// Atualiza os dados de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado na base do emissor um registro de determinada Pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param>
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param>
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param>
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param>
        /// <param name="sexo">Sexo da Pessoa (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param>
        /// <returns>ApiResponse of PessoaResponse</returns>
        ApiResponse<PessoaResponse> Alterar_2WithHttpInfo (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado um determinado Telefone na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="ddd">DDD do n\u00FAmero do telfone (optional)</param>
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param>
        /// <param name="ramal">Ramal do telefone (optional)</param>
        /// <returns>TelefoneResponse</returns>
        TelefoneResponse Alterar_3 (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null);
  
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado um determinado Telefone na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="ddd">DDD do n\u00FAmero do telfone (optional)</param>
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param>
        /// <param name="ramal">Ramal do telefone (optional)</param>
        /// <returns>ApiResponse of TelefoneResponse</returns>
        ApiResponse<TelefoneResponse> Alterar_3WithHttpInfo (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null);
        
        /// <summary>
        /// Permite atribuir um documento para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja atribu\u00EDdo a uma determinada Conta um documento que esteja armazenado no PIER Cloud, informando qual o tipo do documento e o seu respectivo id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="body">C\u00F3digo de Identifica\u00E7\u00E3o do Arquivo</param>
        /// <returns>Object</returns>
        Object AtribuirAssinaturaCliente (long? id, AtribuirAssinaturaClientePersist body);
  
        /// <summary>
        /// Permite atribuir um documento para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja atribu\u00EDdo a uma determinada Conta um documento que esteja armazenado no PIER Cloud, informando qual o tipo do documento e o seu respectivo id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="body">C\u00F3digo de Identifica\u00E7\u00E3o do Arquivo</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> AtribuirAssinaturaClienteWithHttpInfo (long? id, AtribuirAssinaturaClientePersist body);
        
        /// <summary>
        /// Atualiza conta integrada com o emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite a atualiza\u00E7\u00E3o de uma conta integrada com o emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="body">Descri\u00E7\u00E3o do canal de entrada (optional)</param>
        /// <returns>IntegracaoEmissorResponse</returns>
        IntegracaoEmissorResponse Atualizar (long? id, IntegracaoEmissorPersist body = null);
  
        /// <summary>
        /// Atualiza conta integrada com o emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite a atualiza\u00E7\u00E3o de uma conta integrada com o emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="body">Descri\u00E7\u00E3o do canal de entrada (optional)</param>
        /// <returns>ApiResponse of IntegracaoEmissorResponse</returns>
        ApiResponse<IntegracaoEmissorResponse> AtualizarWithHttpInfo (long? id, IntegracaoEmissorPersist body = null);
        
        /// <summary>
        /// Atualiza o endere\u00E7o de correspond\u00EAncia, para o endere\u00E7o informado
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que o endere\u00E7o de correspond\u00EAncia de uma determinada conta, seja atualizado para o endere\u00E7o de correspond\u00EAncia informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <returns>EnderecoResponse</returns>
        EnderecoResponse AtualizarEnderecoDeCorrespondencia (long? id, long? idConta);
  
        /// <summary>
        /// Atualiza o endere\u00E7o de correspond\u00EAncia, para o endere\u00E7o informado
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que o endere\u00E7o de correspond\u00EAncia de uma determinada conta, seja atualizado para o endere\u00E7o de correspond\u00EAncia informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <returns>ApiResponse of EnderecoResponse</returns>
        ApiResponse<EnderecoResponse> AtualizarEnderecoDeCorrespondenciaWithHttpInfo (long? id, long? idConta);
        
        /// <summary>
        /// Cadastro da recarga programada
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar uma nova recarga programada na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param>
        /// <returns>CelularRecargaProgramadaResponse</returns>
        CelularRecargaProgramadaResponse Cadastrar (CelularRecargaProgramadaPersist persistencia);
  
        /// <summary>
        /// Cadastro da recarga programada
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar uma nova recarga programada na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param>
        /// <returns>ApiResponse of CelularRecargaProgramadaResponse</returns>
        ApiResponse<CelularRecargaProgramadaResponse> CadastrarWithHttpInfo (CelularRecargaProgramadaPersist persistencia);
        
        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que uma pessoa existente na base possa ser um adicional na conta informada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="adicionalContaPersist">adicionalContaPersist</param>
        /// <returns>AdicionalContaResponse</returns>
        AdicionalContaResponse CadastrarAdicional (long? id, AdicionalContaPersist adicionalContaPersist);
  
        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que uma pessoa existente na base possa ser um adicional na conta informada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="adicionalContaPersist">adicionalContaPersist</param>
        /// <returns>ApiResponse of AdicionalContaResponse</returns>
        ApiResponse<AdicionalContaResponse> CadastrarAdicionalWithHttpInfo (long? id, AdicionalContaPersist adicionalContaPersist);
        
        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam cadastrados um portador Adicional para uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>AdicionalDetalheResponse</returns>
        AdicionalDetalheResponse Cadastrar_0 (long? id, AdicionalPersist persist);
  
        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam cadastrados um portador Adicional para uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of AdicionalDetalheResponse</returns>
        ApiResponse<AdicionalDetalheResponse> Cadastrar_0WithHttpInfo (long? id, AdicionalPersist persist);
        
        /// <summary>
        /// Consulta Adicional de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja consultado um portador Adicional de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>AdicionalDetalheResponse</returns>
        AdicionalDetalheResponse Consultar (long? id, long? idPessoa);
  
        /// <summary>
        /// Consulta Adicional de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja consultado um portador Adicional de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>ApiResponse of AdicionalDetalheResponse</returns>
        ApiResponse<AdicionalDetalheResponse> ConsultarWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param>
        /// <returns>EnderecoResponse</returns>
        EnderecoResponse Consultar_0 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param>
        /// <returns>ApiResponse of EnderecoResponse</returns>
        ApiResponse<EnderecoResponse> Consultar_0WithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite a consulta dos detalhes de uma Pessoa existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>PessoaDetalheResponse</returns>
        PessoaDetalheResponse Consultar_1 (long? id);
  
        /// <summary>
        /// Apresenta os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite a consulta dos detalhes de uma Pessoa existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        ApiResponse<PessoaDetalheResponse> Consultar_1WithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>PessoaResponse</returns>
        PessoaResponse Consultar_2 (long? id);
  
        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>ApiResponse of PessoaResponse</returns>
        ApiResponse<PessoaResponse> Consultar_2WithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param>
        /// <returns>TelefoneResponse</returns>
        TelefoneResponse Consultar_3 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param>
        /// <returns>ApiResponse of TelefoneResponse</returns>
        ApiResponse<TelefoneResponse> Consultar_3WithHttpInfo (long? id);
        
        /// <summary>
        /// Inativa Adicional de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja inativado um portador Adicional de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>string</returns>
        string Inativar (long? id, long? idPessoa);
  
        /// <summary>
        /// Inativa Adicional de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja inativado um portador Adicional de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> InativarWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// Lista os Adicionais de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados portadores Adicionais de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>AdicionalResponse</returns>
        AdicionalResponse Listar (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista os Adicionais de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados portadores Adicionais de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of AdicionalResponse</returns>
        ApiResponse<AdicionalResponse> ListarWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista as contas da pessoa
        /// </summary>
        /// <remarks>
        /// Permite listar as contas de um pessoa a partir do seu numero na receita federal
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">N\u00FAmero de identifica\u00E7\u00E3o do cliente na Receita Federal (CPF ou CNPJ)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PageContaDetalheResponse</returns>
        PageContaDetalheResponse ListarContasPorPessoa (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Lista as contas da pessoa
        /// </summary>
        /// <remarks>
        /// Permite listar as contas de um pessoa a partir do seu numero na receita federal
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">N\u00FAmero de identifica\u00E7\u00E3o do cliente na Receita Federal (CPF ou CNPJ)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageContaDetalheResponse</returns>
        ApiResponse<PageContaDetalheResponse> ListarContasPorPessoaWithHttpInfo (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista o hist\u00F3rico de altera\u00E7\u00E3o do endereco
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados o historico de altera\u00E7\u00E3o dos Endere\u00E7os existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataAlteracaoInicio">Data de in\u00EDcio (optional)</param>
        /// <param name="dataAlteracaoFim">Data fim (optional)</param>
        /// <param name="cpf">Cpf da pessoa relacionada ao endere\u00E7o (optional)</param>
        /// <param name="idConta">Conta relacionada ao endere\u00E7o (optional)</param>
        /// <param name="canalAlteracao">Aplicativo Respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <returns>PageHistoricoEnderecoResponse</returns>
        PageHistoricoEnderecoResponse ListarHistoricoEndereco (List<string> sort = null, int? page = null, int? limit = null, string dataAlteracaoInicio = null, string dataAlteracaoFim = null, string cpf = null, long? idConta = null, string canalAlteracao = null);
  
        /// <summary>
        /// Lista o hist\u00F3rico de altera\u00E7\u00E3o do endereco
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados o historico de altera\u00E7\u00E3o dos Endere\u00E7os existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataAlteracaoInicio">Data de in\u00EDcio (optional)</param>
        /// <param name="dataAlteracaoFim">Data fim (optional)</param>
        /// <param name="cpf">Cpf da pessoa relacionada ao endere\u00E7o (optional)</param>
        /// <param name="idConta">Conta relacionada ao endere\u00E7o (optional)</param>
        /// <param name="canalAlteracao">Aplicativo Respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <returns>ApiResponse of PageHistoricoEnderecoResponse</returns>
        ApiResponse<PageHistoricoEnderecoResponse> ListarHistoricoEnderecoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataAlteracaoInicio = null, string dataAlteracaoFim = null, string cpf = null, long? idConta = null, string canalAlteracao = null);
        
        /// <summary>
        /// Listar altera\u00E7\u00F5es de telefones realizadas nos \u00FAltimos 60 dias
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite verificar quais os telefones de um determinado que cliente que sofreram altera\u00E7\u00E3o nos \u00FAltimos 60 dias
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>HistoricoTelefoneResponse</returns>
        HistoricoTelefoneResponse ListarHistoricoTelefones (long? id);
  
        /// <summary>
        /// Listar altera\u00E7\u00F5es de telefones realizadas nos \u00FAltimos 60 dias
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite verificar quais os telefones de um determinado que cliente que sofreram altera\u00E7\u00E3o nos \u00FAltimos 60 dias
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>ApiResponse of HistoricoTelefoneResponse</returns>
        ApiResponse<HistoricoTelefoneResponse> ListarHistoricoTelefonesWithHttpInfo (long? id);
        
        /// <summary>
        /// Listar s\u00F3cios de uma pessoa jur\u00EDdica
        /// </summary>
        /// <remarks>
        /// Lista os s\u00F3cios vinculados \u00E0 uma Pessoa Jur\u00EDdica cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Jur\u00EDdica</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>PagePessoaResponse</returns>
        PagePessoaResponse ListarSocios (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// Listar s\u00F3cios de uma pessoa jur\u00EDdica
        /// </summary>
        /// <remarks>
        /// Lista os s\u00F3cios vinculados \u00E0 uma Pessoa Jur\u00EDdica cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Jur\u00EDdica</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PagePessoaResponse</returns>
        ApiResponse<PagePessoaResponse> ListarSociosWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os Endere\u00E7os cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Endere\u00E7os existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">List os CEPs (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="dataInclusao">Apresenta a data em que fora cadastrado o Endere\u00E7o (optional)</param>
        /// <param name="dataUltimaAtualizacao">Data em que fora realizada a \u00FAltima mudan\u00E7a neste registro de endere\u00E7o. Quando n\u00E3o tiver ocorrido mudan\u00E7a, conter\u00E1 a mesma informa\u00E7\u00E3o que o campo dataInclusao (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <returns>PageEnderecoResponse</returns>
        PageEnderecoResponse Listar_0 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null);
  
        /// <summary>
        /// Lista os Endere\u00E7os cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Endere\u00E7os existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">List os CEPs (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="dataInclusao">Apresenta a data em que fora cadastrado o Endere\u00E7o (optional)</param>
        /// <param name="dataUltimaAtualizacao">Data em que fora realizada a \u00FAltima mudan\u00E7a neste registro de endere\u00E7o. Quando n\u00E3o tiver ocorrido mudan\u00E7a, conter\u00E1 a mesma informa\u00E7\u00E3o que o campo dataInclusao (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <returns>ApiResponse of PageEnderecoResponse</returns>
        ApiResponse<PageEnderecoResponse> Listar_0WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null);
        
        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) (optional)</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39; (optional)</param>
        /// <param name="tipo">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa F\u00EDsica, sendo: (&#39;PF&#39;: Pessoa F\u00EDsica), (&#39;PJ&#39;: Pessoa Jur\u00EDdica) (optional)</param>
        /// <param name="cpf">Quando uma pessoa f\u00EDsica preencha com o CPF (optional)</param>
        /// <param name="cnpj">Quando um pessoa jur\u00EDdica preencha o CNPJ (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ (optional)</param>
        /// <param name="sexo">C\u00F3digo de Identifica\u00E7\u00E3o do sexo da pessoa, quando \u00E9 PF, sendo: (&#39;M&#39;: Masculino), (&#39;F&#39;: Feminino), (&#39;O&#39;: Outro), (&#39;N&#39;: N\u00E3o especificado) (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do RG (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da identidade no formato aaaa-MM-dd (optional)</param>
        /// <returns>PagePessoaResponse</returns>
        PagePessoaResponse Listar_1 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
  
        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) (optional)</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39; (optional)</param>
        /// <param name="tipo">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa F\u00EDsica, sendo: (&#39;PF&#39;: Pessoa F\u00EDsica), (&#39;PJ&#39;: Pessoa Jur\u00EDdica) (optional)</param>
        /// <param name="cpf">Quando uma pessoa f\u00EDsica preencha com o CPF (optional)</param>
        /// <param name="cnpj">Quando um pessoa jur\u00EDdica preencha o CNPJ (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ (optional)</param>
        /// <param name="sexo">C\u00F3digo de Identifica\u00E7\u00E3o do sexo da pessoa, quando \u00E9 PF, sendo: (&#39;M&#39;: Masculino), (&#39;F&#39;: Feminino), (&#39;O&#39;: Outro), (&#39;N&#39;: N\u00E3o especificado) (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do RG (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da identidade no formato aaaa-MM-dd (optional)</param>
        /// <returns>ApiResponse of PagePessoaResponse</returns>
        ApiResponse<PagePessoaResponse> Listar_1WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
        
        /// <summary>
        /// Lista os Detalhes das Pessoas cadastradas no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas od detalhes das Pessoas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa (optional)</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do Banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5esde cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <returns>PagePessoaDetalheResponse</returns>
        PagePessoaDetalheResponse Listar_2 (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null);
  
        /// <summary>
        /// Lista os Detalhes das Pessoas cadastradas no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas od detalhes das Pessoas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa (optional)</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do Banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5esde cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <returns>ApiResponse of PagePessoaDetalheResponse</returns>
        ApiResponse<PagePessoaDetalheResponse> Listar_2WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null);
        
        /// <summary>
        /// Lista os Telefones cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Telefones existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id) (optional)</param>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param>
        /// <param name="ddd">Telefone DDD (optional)</param>
        /// <param name="telefone">Telefone n\u00FAmero (optional)</param>
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <returns>PageTelefoneResponse</returns>
        PageTelefoneResponse Listar_3 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null);
  
        /// <summary>
        /// Lista os Telefones cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Telefones existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id) (optional)</param>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param>
        /// <param name="ddd">Telefone DDD (optional)</param>
        /// <param name="telefone">Telefone n\u00FAmero (optional)</param>
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <returns>ApiResponse of PageTelefoneResponse</returns>
        ApiResponse<PageTelefoneResponse> Listar_3WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null);
        
        /// <summary>
        /// Inclui a conta como registro para integra\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite incluir uma conta como registro para integra\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">idConta</param>
        /// <param name="body">IntegracaoEmissorPersist (optional)</param>
        /// <returns>IntegracaoEmissorResponse</returns>
        IntegracaoEmissorResponse Salvar (long? id, IntegracaoEmissorPersist body = null);
  
        /// <summary>
        /// Inclui a conta como registro para integra\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite incluir uma conta como registro para integra\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">idConta</param>
        /// <param name="body">IntegracaoEmissorPersist (optional)</param>
        /// <returns>ApiResponse of IntegracaoEmissorResponse</returns>
        ApiResponse<IntegracaoEmissorResponse> SalvarWithHttpInfo (long? id, IntegracaoEmissorPersist body = null);
        
        /// <summary>
        /// Cadastro de Conta e Pessoa Fisica
        /// </summary>
        /// <remarks>
        /// Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa F\u00EDsica, recebendo nesta opera\u00E7\u00E3o todos os dados cadastrais que se fazem necess\u00E1rios para isso. Uma vez criado, poder\u00E1 ser acionado o m\u00E9todo de &#39;Gera\u00E7\u00E3o de Cart\u00E3o&#39; para o cliente e seus adicionais
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>ObjetoPessoaFsicaAprovadaResponse</returns>
        ObjetoPessoaFsicaAprovadaResponse SalvarPessoaFisicaAprovada (ObjetoPessoaFsicaAprovada pessoaPersist);
  
        /// <summary>
        /// Cadastro de Conta e Pessoa Fisica
        /// </summary>
        /// <remarks>
        /// Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa F\u00EDsica, recebendo nesta opera\u00E7\u00E3o todos os dados cadastrais que se fazem necess\u00E1rios para isso. Uma vez criado, poder\u00E1 ser acionado o m\u00E9todo de &#39;Gera\u00E7\u00E3o de Cart\u00E3o&#39; para o cliente e seus adicionais
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>ApiResponse of ObjetoPessoaFsicaAprovadaResponse</returns>
        ApiResponse<ObjetoPessoaFsicaAprovadaResponse> SalvarPessoaFisicaAprovadaWithHttpInfo (ObjetoPessoaFsicaAprovada pessoaPersist);
        
        /// <summary>
        /// Cadastro de Conta e Pessoa Jur\u00EDdica
        /// </summary>
        /// <remarks>
        /// Cadastro de Conta e Pessoa Jur\u00EDdica Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa Jur\u00EDdica, recebendo nesta opera\u00E7\u00E3o todos os dados cadastrais que se fazem necess\u00E1rios para isso, inclu\u00EDndo o registro de cada um dos s\u00F3cios. Uma vez criado, poder\u00E1 ser acionado o m\u00E9todo de &#39;Gera\u00E7\u00E3o de Cart\u00E3o&#39; para o cliente e cada um dos s\u00F3cios vinculados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>PessoaJuridicaAprovadaResponse</returns>
        PessoaJuridicaAprovadaResponse SalvarPessoaJuridicaAprovada (PessoaJuridicaAprovadaPersist pessoaPersist);
  
        /// <summary>
        /// Cadastro de Conta e Pessoa Jur\u00EDdica
        /// </summary>
        /// <remarks>
        /// Cadastro de Conta e Pessoa Jur\u00EDdica Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa Jur\u00EDdica, recebendo nesta opera\u00E7\u00E3o todos os dados cadastrais que se fazem necess\u00E1rios para isso, inclu\u00EDndo o registro de cada um dos s\u00F3cios. Uma vez criado, poder\u00E1 ser acionado o m\u00E9todo de &#39;Gera\u00E7\u00E3o de Cart\u00E3o&#39; para o cliente e cada um dos s\u00F3cios vinculados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>ApiResponse of PessoaJuridicaAprovadaResponse</returns>
        ApiResponse<PessoaJuridicaAprovadaResponse> SalvarPessoaJuridicaAprovadaWithHttpInfo (PessoaJuridicaAprovadaPersist pessoaPersist);
        
        /// <summary>
        /// Inclui registro de integra\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite incluir um registro de integra\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param>
        /// <returns>IntegracaoEmissorPropostaResponse</returns>
        IntegracaoEmissorPropostaResponse SalvarRegistroIntegracaoManager (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist);
  
        /// <summary>
        /// Inclui registro de integra\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite incluir um registro de integra\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param>
        /// <returns>ApiResponse of IntegracaoEmissorPropostaResponse</returns>
        ApiResponse<IntegracaoEmissorPropostaResponse> SalvarRegistroIntegracaoManagerWithHttpInfo (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist);
        
        /// <summary>
        /// Realiza o cadastro de um novo Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo Endere\u00E7o na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">CEP do endere\u00E7o (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <returns>EnderecoResponse</returns>
        EnderecoResponse Salvar_0 (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null);
  
        /// <summary>
        /// Realiza o cadastro de um novo Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo Endere\u00E7o na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">CEP do endere\u00E7o (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <returns>ApiResponse of EnderecoResponse</returns>
        ApiResponse<EnderecoResponse> Salvar_0WithHttpInfo (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null);
        
        /// <summary>
        /// Realiza o cadastro de um nova Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova Pessoa na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param>
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param>
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param>
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param>
        /// <param name="sexo">Sexo da Pessoa (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param>
        /// <returns>PessoaResponse</returns>
        PessoaResponse Salvar_1 (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
  
        /// <summary>
        /// Realiza o cadastro de um nova Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova Pessoa na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param>
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param>
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param>
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param>
        /// <param name="sexo">Sexo da Pessoa (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param>
        /// <returns>ApiResponse of PessoaResponse</returns>
        ApiResponse<PessoaResponse> Salvar_1WithHttpInfo (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
        
        /// <summary>
        /// Salvar os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja incluido na base do emissor os detalhes de uma determinada Pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Apresenta o c\u00F3digo identificador da pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param>
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param>
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param>
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <returns>PessoaDetalheResponse</returns>
        PessoaDetalheResponse Salvar_2 (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null);
  
        /// <summary>
        /// Salvar os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja incluido na base do emissor os detalhes de uma determinada Pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Apresenta o c\u00F3digo identificador da pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param>
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param>
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param>
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        ApiResponse<PessoaDetalheResponse> Salvar_2WithHttpInfo (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null);
        
        /// <summary>
        /// Realiza o cadastro de um novo Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param>
        /// <param name="ddd">C\u00F3digo DDD do telefone (id) (optional)</param>
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param>
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param>
        /// <returns>TelefoneResponse</returns>
        TelefoneResponse Salvar_3 (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null);
  
        /// <summary>
        /// Realiza o cadastro de um novo Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param>
        /// <param name="ddd">C\u00F3digo DDD do telefone (id) (optional)</param>
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param>
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param>
        /// <returns>ApiResponse of TelefoneResponse</returns>
        ApiResponse<TelefoneResponse> Salvar_3WithHttpInfo (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Altera Adicional de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado um portador Adicional de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <param name="adicionalUpdate">adicionalUpdate</param>
        /// <returns>Task of AdicionalDetalheResponse</returns>
        System.Threading.Tasks.Task<AdicionalDetalheResponse> AlterarAsync (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate);

        /// <summary>
        /// Altera Adicional de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado um portador Adicional de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <param name="adicionalUpdate">adicionalUpdate</param>
        /// <returns>Task of ApiResponse (AdicionalDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdicionalDetalheResponse>> AlterarAsyncWithHttpInfo (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate);
        
        /// <summary>
        /// Atualiza os dados de um determinado Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado na base do emissor um ou mais registros ligados a um determinado Endere\u00E7o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">CEP do endere\u00E7o (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <returns>Task of EnderecoResponse</returns>
        System.Threading.Tasks.Task<EnderecoResponse> Alterar_0Async (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null);

        /// <summary>
        /// Atualiza os dados de um determinado Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado na base do emissor um ou mais registros ligados a um determinado Endere\u00E7o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">CEP do endere\u00E7o (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> Alterar_0AsyncWithHttpInfo (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null);
        
        /// <summary>
        /// Atualiza os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado na base do emissor os detalhes de uma determinada Pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param>
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param>
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param>
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        System.Threading.Tasks.Task<PessoaDetalheResponse> Alterar_1Async (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, string numeroCnh = null);

        /// <summary>
        /// Atualiza os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado na base do emissor os detalhes de uma determinada Pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param>
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param>
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param>
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> Alterar_1AsyncWithHttpInfo (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, string numeroCnh = null);
        
        /// <summary>
        /// Atualiza os dados de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado na base do emissor um registro de determinada Pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param>
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param>
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param>
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param>
        /// <param name="sexo">Sexo da Pessoa (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param>
        /// <returns>Task of PessoaResponse</returns>
        System.Threading.Tasks.Task<PessoaResponse> Alterar_2Async (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);

        /// <summary>
        /// Atualiza os dados de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado na base do emissor um registro de determinada Pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param>
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param>
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param>
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param>
        /// <param name="sexo">Sexo da Pessoa (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> Alterar_2AsyncWithHttpInfo (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado um determinado Telefone na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="ddd">DDD do n\u00FAmero do telfone (optional)</param>
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param>
        /// <param name="ramal">Ramal do telefone (optional)</param>
        /// <returns>Task of TelefoneResponse</returns>
        System.Threading.Tasks.Task<TelefoneResponse> Alterar_3Async (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null);

        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja alterado um determinado Telefone na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="ddd">DDD do n\u00FAmero do telfone (optional)</param>
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param>
        /// <param name="ramal">Ramal do telefone (optional)</param>
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> Alterar_3AsyncWithHttpInfo (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null);
        
        /// <summary>
        /// Permite atribuir um documento para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja atribu\u00EDdo a uma determinada Conta um documento que esteja armazenado no PIER Cloud, informando qual o tipo do documento e o seu respectivo id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="body">C\u00F3digo de Identifica\u00E7\u00E3o do Arquivo</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> AtribuirAssinaturaClienteAsync (long? id, AtribuirAssinaturaClientePersist body);

        /// <summary>
        /// Permite atribuir um documento para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja atribu\u00EDdo a uma determinada Conta um documento que esteja armazenado no PIER Cloud, informando qual o tipo do documento e o seu respectivo id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="body">C\u00F3digo de Identifica\u00E7\u00E3o do Arquivo</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AtribuirAssinaturaClienteAsyncWithHttpInfo (long? id, AtribuirAssinaturaClientePersist body);
        
        /// <summary>
        /// Atualiza conta integrada com o emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite a atualiza\u00E7\u00E3o de uma conta integrada com o emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="body">Descri\u00E7\u00E3o do canal de entrada (optional)</param>
        /// <returns>Task of IntegracaoEmissorResponse</returns>
        System.Threading.Tasks.Task<IntegracaoEmissorResponse> AtualizarAsync (long? id, IntegracaoEmissorPersist body = null);

        /// <summary>
        /// Atualiza conta integrada com o emissor
        /// </summary>
        /// <remarks>
        /// Este recurso permite a atualiza\u00E7\u00E3o de uma conta integrada com o emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="body">Descri\u00E7\u00E3o do canal de entrada (optional)</param>
        /// <returns>Task of ApiResponse (IntegracaoEmissorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntegracaoEmissorResponse>> AtualizarAsyncWithHttpInfo (long? id, IntegracaoEmissorPersist body = null);
        
        /// <summary>
        /// Atualiza o endere\u00E7o de correspond\u00EAncia, para o endere\u00E7o informado
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que o endere\u00E7o de correspond\u00EAncia de uma determinada conta, seja atualizado para o endere\u00E7o de correspond\u00EAncia informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <returns>Task of EnderecoResponse</returns>
        System.Threading.Tasks.Task<EnderecoResponse> AtualizarEnderecoDeCorrespondenciaAsync (long? id, long? idConta);

        /// <summary>
        /// Atualiza o endere\u00E7o de correspond\u00EAncia, para o endere\u00E7o informado
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que o endere\u00E7o de correspond\u00EAncia de uma determinada conta, seja atualizado para o endere\u00E7o de correspond\u00EAncia informado
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> AtualizarEnderecoDeCorrespondenciaAsyncWithHttpInfo (long? id, long? idConta);
        
        /// <summary>
        /// Cadastro da recarga programada
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar uma nova recarga programada na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param>
        /// <returns>Task of CelularRecargaProgramadaResponse</returns>
        System.Threading.Tasks.Task<CelularRecargaProgramadaResponse> CadastrarAsync (CelularRecargaProgramadaPersist persistencia);

        /// <summary>
        /// Cadastro da recarga programada
        /// </summary>
        /// <remarks>
        /// Este recurso permite cadastrar uma nova recarga programada na base do emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param>
        /// <returns>Task of ApiResponse (CelularRecargaProgramadaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CelularRecargaProgramadaResponse>> CadastrarAsyncWithHttpInfo (CelularRecargaProgramadaPersist persistencia);
        
        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que uma pessoa existente na base possa ser um adicional na conta informada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="adicionalContaPersist">adicionalContaPersist</param>
        /// <returns>Task of AdicionalContaResponse</returns>
        System.Threading.Tasks.Task<AdicionalContaResponse> CadastrarAdicionalAsync (long? id, AdicionalContaPersist adicionalContaPersist);

        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que uma pessoa existente na base possa ser um adicional na conta informada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="adicionalContaPersist">adicionalContaPersist</param>
        /// <returns>Task of ApiResponse (AdicionalContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdicionalContaResponse>> CadastrarAdicionalAsyncWithHttpInfo (long? id, AdicionalContaPersist adicionalContaPersist);
        
        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam cadastrados um portador Adicional para uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of AdicionalDetalheResponse</returns>
        System.Threading.Tasks.Task<AdicionalDetalheResponse> Cadastrar_0Async (long? id, AdicionalPersist persist);

        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam cadastrados um portador Adicional para uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (AdicionalDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdicionalDetalheResponse>> Cadastrar_0AsyncWithHttpInfo (long? id, AdicionalPersist persist);
        
        /// <summary>
        /// Consulta Adicional de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja consultado um portador Adicional de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>Task of AdicionalDetalheResponse</returns>
        System.Threading.Tasks.Task<AdicionalDetalheResponse> ConsultarAsync (long? id, long? idPessoa);

        /// <summary>
        /// Consulta Adicional de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja consultado um portador Adicional de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>Task of ApiResponse (AdicionalDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdicionalDetalheResponse>> ConsultarAsyncWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param>
        /// <returns>Task of EnderecoResponse</returns>
        System.Threading.Tasks.Task<EnderecoResponse> Consultar_0Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> Consultar_0AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite a consulta dos detalhes de uma Pessoa existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        System.Threading.Tasks.Task<PessoaDetalheResponse> Consultar_1Async (long? id);

        /// <summary>
        /// Apresenta os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite a consulta dos detalhes de uma Pessoa existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> Consultar_1AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Task of PessoaResponse</returns>
        System.Threading.Tasks.Task<PessoaResponse> Consultar_2Async (long? id);

        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> Consultar_2AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param>
        /// <returns>Task of TelefoneResponse</returns>
        System.Threading.Tasks.Task<TelefoneResponse> Consultar_3Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite consultar um determinado Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param>
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> Consultar_3AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Inativa Adicional de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja inativado um portador Adicional de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> InativarAsync (long? id, long? idPessoa);

        /// <summary>
        /// Inativa Adicional de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja inativado um portador Adicional de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> InativarAsyncWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// Lista os Adicionais de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados portadores Adicionais de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of AdicionalResponse</returns>
        System.Threading.Tasks.Task<AdicionalResponse> ListarAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista os Adicionais de uma Conta
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados portadores Adicionais de uma determinada Conta
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (AdicionalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdicionalResponse>> ListarAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista as contas da pessoa
        /// </summary>
        /// <remarks>
        /// Permite listar as contas de um pessoa a partir do seu numero na receita federal
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">N\u00FAmero de identifica\u00E7\u00E3o do cliente na Receita Federal (CPF ou CNPJ)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageContaDetalheResponse</returns>
        System.Threading.Tasks.Task<PageContaDetalheResponse> ListarContasPorPessoaAsync (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Lista as contas da pessoa
        /// </summary>
        /// <remarks>
        /// Permite listar as contas de um pessoa a partir do seu numero na receita federal
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">N\u00FAmero de identifica\u00E7\u00E3o do cliente na Receita Federal (CPF ou CNPJ)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageContaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageContaDetalheResponse>> ListarContasPorPessoaAsyncWithHttpInfo (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista o hist\u00F3rico de altera\u00E7\u00E3o do endereco
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados o historico de altera\u00E7\u00E3o dos Endere\u00E7os existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataAlteracaoInicio">Data de in\u00EDcio (optional)</param>
        /// <param name="dataAlteracaoFim">Data fim (optional)</param>
        /// <param name="cpf">Cpf da pessoa relacionada ao endere\u00E7o (optional)</param>
        /// <param name="idConta">Conta relacionada ao endere\u00E7o (optional)</param>
        /// <param name="canalAlteracao">Aplicativo Respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <returns>Task of PageHistoricoEnderecoResponse</returns>
        System.Threading.Tasks.Task<PageHistoricoEnderecoResponse> ListarHistoricoEnderecoAsync (List<string> sort = null, int? page = null, int? limit = null, string dataAlteracaoInicio = null, string dataAlteracaoFim = null, string cpf = null, long? idConta = null, string canalAlteracao = null);

        /// <summary>
        /// Lista o hist\u00F3rico de altera\u00E7\u00E3o do endereco
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados o historico de altera\u00E7\u00E3o dos Endere\u00E7os existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataAlteracaoInicio">Data de in\u00EDcio (optional)</param>
        /// <param name="dataAlteracaoFim">Data fim (optional)</param>
        /// <param name="cpf">Cpf da pessoa relacionada ao endere\u00E7o (optional)</param>
        /// <param name="idConta">Conta relacionada ao endere\u00E7o (optional)</param>
        /// <param name="canalAlteracao">Aplicativo Respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoEnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageHistoricoEnderecoResponse>> ListarHistoricoEnderecoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataAlteracaoInicio = null, string dataAlteracaoFim = null, string cpf = null, long? idConta = null, string canalAlteracao = null);
        
        /// <summary>
        /// Listar altera\u00E7\u00F5es de telefones realizadas nos \u00FAltimos 60 dias
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite verificar quais os telefones de um determinado que cliente que sofreram altera\u00E7\u00E3o nos \u00FAltimos 60 dias
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>Task of HistoricoTelefoneResponse</returns>
        System.Threading.Tasks.Task<HistoricoTelefoneResponse> ListarHistoricoTelefonesAsync (long? id);

        /// <summary>
        /// Listar altera\u00E7\u00F5es de telefones realizadas nos \u00FAltimos 60 dias
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite verificar quais os telefones de um determinado que cliente que sofreram altera\u00E7\u00E3o nos \u00FAltimos 60 dias
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>Task of ApiResponse (HistoricoTelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<HistoricoTelefoneResponse>> ListarHistoricoTelefonesAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Listar s\u00F3cios de uma pessoa jur\u00EDdica
        /// </summary>
        /// <remarks>
        /// Lista os s\u00F3cios vinculados \u00E0 uma Pessoa Jur\u00EDdica cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Jur\u00EDdica</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PagePessoaResponse</returns>
        System.Threading.Tasks.Task<PagePessoaResponse> ListarSociosAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// Listar s\u00F3cios de uma pessoa jur\u00EDdica
        /// </summary>
        /// <remarks>
        /// Lista os s\u00F3cios vinculados \u00E0 uma Pessoa Jur\u00EDdica cadastrada
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Jur\u00EDdica</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePessoaResponse>> ListarSociosAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// Lista os Endere\u00E7os cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Endere\u00E7os existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">List os CEPs (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="dataInclusao">Apresenta a data em que fora cadastrado o Endere\u00E7o (optional)</param>
        /// <param name="dataUltimaAtualizacao">Data em que fora realizada a \u00FAltima mudan\u00E7a neste registro de endere\u00E7o. Quando n\u00E3o tiver ocorrido mudan\u00E7a, conter\u00E1 a mesma informa\u00E7\u00E3o que o campo dataInclusao (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <returns>Task of PageEnderecoResponse</returns>
        System.Threading.Tasks.Task<PageEnderecoResponse> Listar_0Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null);

        /// <summary>
        /// Lista os Endere\u00E7os cadastrados para o Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Endere\u00E7os existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">List os CEPs (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="dataInclusao">Apresenta a data em que fora cadastrado o Endere\u00E7o (optional)</param>
        /// <param name="dataUltimaAtualizacao">Data em que fora realizada a \u00FAltima mudan\u00E7a neste registro de endere\u00E7o. Quando n\u00E3o tiver ocorrido mudan\u00E7a, conter\u00E1 a mesma informa\u00E7\u00E3o que o campo dataInclusao (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <returns>Task of ApiResponse (PageEnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageEnderecoResponse>> Listar_0AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null);
        
        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) (optional)</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39; (optional)</param>
        /// <param name="tipo">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa F\u00EDsica, sendo: (&#39;PF&#39;: Pessoa F\u00EDsica), (&#39;PJ&#39;: Pessoa Jur\u00EDdica) (optional)</param>
        /// <param name="cpf">Quando uma pessoa f\u00EDsica preencha com o CPF (optional)</param>
        /// <param name="cnpj">Quando um pessoa jur\u00EDdica preencha o CNPJ (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ (optional)</param>
        /// <param name="sexo">C\u00F3digo de Identifica\u00E7\u00E3o do sexo da pessoa, quando \u00E9 PF, sendo: (&#39;M&#39;: Masculino), (&#39;F&#39;: Feminino), (&#39;O&#39;: Outro), (&#39;N&#39;: N\u00E3o especificado) (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do RG (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da identidade no formato aaaa-MM-dd (optional)</param>
        /// <returns>Task of PagePessoaResponse</returns>
        System.Threading.Tasks.Task<PagePessoaResponse> Listar_1Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);

        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) (optional)</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39; (optional)</param>
        /// <param name="tipo">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa F\u00EDsica, sendo: (&#39;PF&#39;: Pessoa F\u00EDsica), (&#39;PJ&#39;: Pessoa Jur\u00EDdica) (optional)</param>
        /// <param name="cpf">Quando uma pessoa f\u00EDsica preencha com o CPF (optional)</param>
        /// <param name="cnpj">Quando um pessoa jur\u00EDdica preencha o CNPJ (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ (optional)</param>
        /// <param name="sexo">C\u00F3digo de Identifica\u00E7\u00E3o do sexo da pessoa, quando \u00E9 PF, sendo: (&#39;M&#39;: Masculino), (&#39;F&#39;: Feminino), (&#39;O&#39;: Outro), (&#39;N&#39;: N\u00E3o especificado) (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do RG (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da identidade no formato aaaa-MM-dd (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePessoaResponse>> Listar_1AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
        
        /// <summary>
        /// Lista os Detalhes das Pessoas cadastradas no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas od detalhes das Pessoas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa (optional)</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do Banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5esde cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <returns>Task of PagePessoaDetalheResponse</returns>
        System.Threading.Tasks.Task<PagePessoaDetalheResponse> Listar_2Async (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null);

        /// <summary>
        /// Lista os Detalhes das Pessoas cadastradas no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listadas od detalhes das Pessoas existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa (optional)</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do Banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5esde cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePessoaDetalheResponse>> Listar_2AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null);
        
        /// <summary>
        /// Lista os Telefones cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Telefones existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id) (optional)</param>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param>
        /// <param name="ddd">Telefone DDD (optional)</param>
        /// <param name="telefone">Telefone n\u00FAmero (optional)</param>
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <returns>Task of PageTelefoneResponse</returns>
        System.Threading.Tasks.Task<PageTelefoneResponse> Listar_3Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null);

        /// <summary>
        /// Lista os Telefones cadastrados no Emissor
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que sejam listados os Telefones existentes na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id) (optional)</param>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param>
        /// <param name="ddd">Telefone DDD (optional)</param>
        /// <param name="telefone">Telefone n\u00FAmero (optional)</param>
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <returns>Task of ApiResponse (PageTelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTelefoneResponse>> Listar_3AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null);
        
        /// <summary>
        /// Inclui a conta como registro para integra\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite incluir uma conta como registro para integra\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">idConta</param>
        /// <param name="body">IntegracaoEmissorPersist (optional)</param>
        /// <returns>Task of IntegracaoEmissorResponse</returns>
        System.Threading.Tasks.Task<IntegracaoEmissorResponse> SalvarAsync (long? id, IntegracaoEmissorPersist body = null);

        /// <summary>
        /// Inclui a conta como registro para integra\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite incluir uma conta como registro para integra\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">idConta</param>
        /// <param name="body">IntegracaoEmissorPersist (optional)</param>
        /// <returns>Task of ApiResponse (IntegracaoEmissorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntegracaoEmissorResponse>> SalvarAsyncWithHttpInfo (long? id, IntegracaoEmissorPersist body = null);
        
        /// <summary>
        /// Cadastro de Conta e Pessoa Fisica
        /// </summary>
        /// <remarks>
        /// Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa F\u00EDsica, recebendo nesta opera\u00E7\u00E3o todos os dados cadastrais que se fazem necess\u00E1rios para isso. Uma vez criado, poder\u00E1 ser acionado o m\u00E9todo de &#39;Gera\u00E7\u00E3o de Cart\u00E3o&#39; para o cliente e seus adicionais
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of ObjetoPessoaFsicaAprovadaResponse</returns>
        System.Threading.Tasks.Task<ObjetoPessoaFsicaAprovadaResponse> SalvarPessoaFisicaAprovadaAsync (ObjetoPessoaFsicaAprovada pessoaPersist);

        /// <summary>
        /// Cadastro de Conta e Pessoa Fisica
        /// </summary>
        /// <remarks>
        /// Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa F\u00EDsica, recebendo nesta opera\u00E7\u00E3o todos os dados cadastrais que se fazem necess\u00E1rios para isso. Uma vez criado, poder\u00E1 ser acionado o m\u00E9todo de &#39;Gera\u00E7\u00E3o de Cart\u00E3o&#39; para o cliente e seus adicionais
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of ApiResponse (ObjetoPessoaFsicaAprovadaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ObjetoPessoaFsicaAprovadaResponse>> SalvarPessoaFisicaAprovadaAsyncWithHttpInfo (ObjetoPessoaFsicaAprovada pessoaPersist);
        
        /// <summary>
        /// Cadastro de Conta e Pessoa Jur\u00EDdica
        /// </summary>
        /// <remarks>
        /// Cadastro de Conta e Pessoa Jur\u00EDdica Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa Jur\u00EDdica, recebendo nesta opera\u00E7\u00E3o todos os dados cadastrais que se fazem necess\u00E1rios para isso, inclu\u00EDndo o registro de cada um dos s\u00F3cios. Uma vez criado, poder\u00E1 ser acionado o m\u00E9todo de &#39;Gera\u00E7\u00E3o de Cart\u00E3o&#39; para o cliente e cada um dos s\u00F3cios vinculados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of PessoaJuridicaAprovadaResponse</returns>
        System.Threading.Tasks.Task<PessoaJuridicaAprovadaResponse> SalvarPessoaJuridicaAprovadaAsync (PessoaJuridicaAprovadaPersist pessoaPersist);

        /// <summary>
        /// Cadastro de Conta e Pessoa Jur\u00EDdica
        /// </summary>
        /// <remarks>
        /// Cadastro de Conta e Pessoa Jur\u00EDdica Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa Jur\u00EDdica, recebendo nesta opera\u00E7\u00E3o todos os dados cadastrais que se fazem necess\u00E1rios para isso, inclu\u00EDndo o registro de cada um dos s\u00F3cios. Uma vez criado, poder\u00E1 ser acionado o m\u00E9todo de &#39;Gera\u00E7\u00E3o de Cart\u00E3o&#39; para o cliente e cada um dos s\u00F3cios vinculados
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaAprovadaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaAprovadaResponse>> SalvarPessoaJuridicaAprovadaAsyncWithHttpInfo (PessoaJuridicaAprovadaPersist pessoaPersist);
        
        /// <summary>
        /// Inclui registro de integra\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite incluir um registro de integra\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param>
        /// <returns>Task of IntegracaoEmissorPropostaResponse</returns>
        System.Threading.Tasks.Task<IntegracaoEmissorPropostaResponse> SalvarRegistroIntegracaoManagerAsync (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist);

        /// <summary>
        /// Inclui registro de integra\u00E7\u00E3o
        /// </summary>
        /// <remarks>
        /// Este recurso permite incluir um registro de integra\u00E7\u00E3o
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param>
        /// <returns>Task of ApiResponse (IntegracaoEmissorPropostaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntegracaoEmissorPropostaResponse>> SalvarRegistroIntegracaoManagerAsyncWithHttpInfo (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist);
        
        /// <summary>
        /// Realiza o cadastro de um novo Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo Endere\u00E7o na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">CEP do endere\u00E7o (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <returns>Task of EnderecoResponse</returns>
        System.Threading.Tasks.Task<EnderecoResponse> Salvar_0Async (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null);

        /// <summary>
        /// Realiza o cadastro de um novo Endere\u00E7o
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo Endere\u00E7o na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">CEP do endere\u00E7o (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> Salvar_0AsyncWithHttpInfo (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null);
        
        /// <summary>
        /// Realiza o cadastro de um nova Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova Pessoa na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param>
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param>
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param>
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param>
        /// <param name="sexo">Sexo da Pessoa (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param>
        /// <returns>Task of PessoaResponse</returns>
        System.Threading.Tasks.Task<PessoaResponse> Salvar_1Async (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);

        /// <summary>
        /// Realiza o cadastro de um nova Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado uma nova Pessoa na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param>
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param>
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param>
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param>
        /// <param name="sexo">Sexo da Pessoa (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> Salvar_1AsyncWithHttpInfo (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
        
        /// <summary>
        /// Salvar os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja incluido na base do emissor os detalhes de uma determinada Pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Apresenta o c\u00F3digo identificador da pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param>
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param>
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param>
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        System.Threading.Tasks.Task<PessoaDetalheResponse> Salvar_2Async (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null);

        /// <summary>
        /// Salvar os detalhes de uma determinada Pessoa
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja incluido na base do emissor os detalhes de uma determinada Pessoa
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Apresenta o c\u00F3digo identificador da pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param>
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param>
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param>
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> Salvar_2AsyncWithHttpInfo (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null);
        
        /// <summary>
        /// Realiza o cadastro de um novo Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param>
        /// <param name="ddd">C\u00F3digo DDD do telefone (id) (optional)</param>
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param>
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param>
        /// <returns>Task of TelefoneResponse</returns>
        System.Threading.Tasks.Task<TelefoneResponse> Salvar_3Async (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null);

        /// <summary>
        /// Realiza o cadastro de um novo Telefone
        /// </summary>
        /// <remarks>
        /// Este m\u00E9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param>
        /// <param name="ddd">C\u00F3digo DDD do telefone (id) (optional)</param>
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param>
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param>
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> Salvar_3AsyncWithHttpInfo (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CadastroClienteApi : ICadastroClienteApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CadastroClienteApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CadastroClienteApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CadastroClienteApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CadastroClienteApi(Configuration configuration = null)
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
        /// Altera Adicional de uma Conta Este m\u00E9todo permite que seja alterado um portador Adicional de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param> 
        /// <param name="adicionalUpdate">adicionalUpdate</param> 
        /// <returns>AdicionalDetalheResponse</returns>
        public AdicionalDetalheResponse Alterar (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate)
        {
             ApiResponse<AdicionalDetalheResponse> localVarResponse = AlterarWithHttpInfo(id, idPessoa, adicionalUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera Adicional de uma Conta Este m\u00E9todo permite que seja alterado um portador Adicional de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param> 
        /// <param name="adicionalUpdate">adicionalUpdate</param> 
        /// <returns>ApiResponse of AdicionalDetalheResponse</returns>
        public ApiResponse< AdicionalDetalheResponse > AlterarWithHttpInfo (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->Alterar");
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling CadastroClienteApi->Alterar");
            
            // verify the required parameter 'adicionalUpdate' is set
            if (adicionalUpdate == null)
                throw new ApiException(400, "Missing required parameter 'adicionalUpdate' when calling CadastroClienteApi->Alterar");
            
    
            var localVarPath = "/api/contas/{id}/adicionais/{idPessoa}";
    
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
            if (idPessoa != null) localVarPathParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // path parameter
            
            
            
            
            if (adicionalUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(adicionalUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = adicionalUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdicionalDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalDetalheResponse)));
            
        }

        
        /// <summary>
        /// Altera Adicional de uma Conta Este m\u00E9todo permite que seja alterado um portador Adicional de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <param name="adicionalUpdate">adicionalUpdate</param>
        /// <returns>Task of AdicionalDetalheResponse</returns>
        public async System.Threading.Tasks.Task<AdicionalDetalheResponse> AlterarAsync (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate)
        {
             ApiResponse<AdicionalDetalheResponse> localVarResponse = await AlterarAsyncWithHttpInfo(id, idPessoa, adicionalUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera Adicional de uma Conta Este m\u00E9todo permite que seja alterado um portador Adicional de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <param name="adicionalUpdate">adicionalUpdate</param>
        /// <returns>Task of ApiResponse (AdicionalDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdicionalDetalheResponse>> AlterarAsyncWithHttpInfo (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Alterar");
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling Alterar");
            // verify the required parameter 'adicionalUpdate' is set
            if (adicionalUpdate == null) throw new ApiException(400, "Missing required parameter 'adicionalUpdate' when calling Alterar");
            
    
            var localVarPath = "/api/contas/{id}/adicionais/{idPessoa}";
    
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
            if (idPessoa != null) localVarPathParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // path parameter
            
            
            
            
            if (adicionalUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(adicionalUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = adicionalUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdicionalDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalDetalheResponse)));
            
        }
        
        /// <summary>
        /// Atualiza os dados de um determinado Endere\u00E7o Este m\u00E9todo permite que seja alterado na base do emissor um ou mais registros ligados a um determinado Endere\u00E7o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param> 
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param> 
        /// <param name="cep">CEP do endere\u00E7o (optional)</param> 
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param> 
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param> 
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param> 
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param> 
        /// <param name="bairro">Apresenta nome do bairro (optional)</param> 
        /// <param name="cidade">Apresenta nome da cidade (optional)</param> 
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param> 
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param> 
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param> 
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param> 
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param> 
        /// <returns>EnderecoResponse</returns>
        public EnderecoResponse Alterar_0 (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null)
        {
             ApiResponse<EnderecoResponse> localVarResponse = Alterar_0WithHttpInfo(id, idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais, tempoResidenciaAnos, tempoResidenciaMeses, aplicativoAlteracao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualiza os dados de um determinado Endere\u00E7o Este m\u00E9todo permite que seja alterado na base do emissor um ou mais registros ligados a um determinado Endere\u00E7o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param> 
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param> 
        /// <param name="cep">CEP do endere\u00E7o (optional)</param> 
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param> 
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param> 
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param> 
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param> 
        /// <param name="bairro">Apresenta nome do bairro (optional)</param> 
        /// <param name="cidade">Apresenta nome da cidade (optional)</param> 
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param> 
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param> 
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param> 
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param> 
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param> 
        /// <returns>ApiResponse of EnderecoResponse</returns>
        public ApiResponse< EnderecoResponse > Alterar_0WithHttpInfo (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->Alterar_0");
            
    
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
            if (tempoResidenciaAnos != null) localVarQueryParams.Add("tempoResidenciaAnos", Configuration.ApiClient.ParameterToString(tempoResidenciaAnos)); // query parameter
            if (tempoResidenciaMeses != null) localVarQueryParams.Add("tempoResidenciaMeses", Configuration.ApiClient.ParameterToString(tempoResidenciaMeses)); // query parameter
            if (aplicativoAlteracao != null) localVarQueryParams.Add("aplicativoAlteracao", Configuration.ApiClient.ParameterToString(aplicativoAlteracao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }

        
        /// <summary>
        /// Atualiza os dados de um determinado Endere\u00E7o Este m\u00E9todo permite que seja alterado na base do emissor um ou mais registros ligados a um determinado Endere\u00E7o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">CEP do endere\u00E7o (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <returns>Task of EnderecoResponse</returns>
        public async System.Threading.Tasks.Task<EnderecoResponse> Alterar_0Async (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null)
        {
             ApiResponse<EnderecoResponse> localVarResponse = await Alterar_0AsyncWithHttpInfo(id, idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais, tempoResidenciaAnos, tempoResidenciaMeses, aplicativoAlteracao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualiza os dados de um determinado Endere\u00E7o Este m\u00E9todo permite que seja alterado na base do emissor um ou mais registros ligados a um determinado Endere\u00E7o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">CEP do endere\u00E7o (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> Alterar_0AsyncWithHttpInfo (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Alterar_0");
            
    
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
            if (tempoResidenciaAnos != null) localVarQueryParams.Add("tempoResidenciaAnos", Configuration.ApiClient.ParameterToString(tempoResidenciaAnos)); // query parameter
            if (tempoResidenciaMeses != null) localVarQueryParams.Add("tempoResidenciaMeses", Configuration.ApiClient.ParameterToString(tempoResidenciaMeses)); // query parameter
            if (aplicativoAlteracao != null) localVarQueryParams.Add("aplicativoAlteracao", Configuration.ApiClient.ParameterToString(aplicativoAlteracao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }
        
        /// <summary>
        /// Atualiza os detalhes de uma determinada Pessoa Este m\u00E9todo permite que seja alterado na base do emissor os detalhes de uma determinada Pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param> 
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param> 
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param> 
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param> 
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param> 
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param> 
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param> 
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param> 
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param> 
        /// <param name="email">Email da pessoa fisica (optional)</param> 
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param> 
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param> 
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param> 
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param> 
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param> 
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param> 
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param> 
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param> 
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param> 
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param> 
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param> 
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param> 
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param> 
        /// <returns>PessoaDetalheResponse</returns>
        public PessoaDetalheResponse Alterar_1 (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, string numeroCnh = null)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = Alterar_1WithHttpInfo(id, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroBanco, numeroAgencia, numeroContaCorrente, email, nomeEmpresa, nomeReferencia1, enderecoReferencia1, nomeReferencia2, enderecoReferencia2, impedidoFinanciamento, naturalidadeCidade, naturalidadeEstado, grauInstrucao, numeroDependentes, nomePai, chequeEspecial, numeroCnh);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualiza os detalhes de uma determinada Pessoa Este m\u00E9todo permite que seja alterado na base do emissor os detalhes de uma determinada Pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param> 
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param> 
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param> 
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param> 
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param> 
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param> 
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param> 
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param> 
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param> 
        /// <param name="email">Email da pessoa fisica (optional)</param> 
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param> 
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param> 
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param> 
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param> 
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param> 
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param> 
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param> 
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param> 
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param> 
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param> 
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param> 
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param> 
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param> 
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        public ApiResponse< PessoaDetalheResponse > Alterar_1WithHttpInfo (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, string numeroCnh = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->Alterar_1");
            
    
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
            if (numeroBanco != null) localVarQueryParams.Add("numeroBanco", Configuration.ApiClient.ParameterToString(numeroBanco)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroContaCorrente != null) localVarQueryParams.Add("numeroContaCorrente", Configuration.ApiClient.ParameterToString(numeroContaCorrente)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (nomeEmpresa != null) localVarQueryParams.Add("nomeEmpresa", Configuration.ApiClient.ParameterToString(nomeEmpresa)); // query parameter
            if (nomeReferencia1 != null) localVarQueryParams.Add("nomeReferencia1", Configuration.ApiClient.ParameterToString(nomeReferencia1)); // query parameter
            if (enderecoReferencia1 != null) localVarQueryParams.Add("enderecoReferencia1", Configuration.ApiClient.ParameterToString(enderecoReferencia1)); // query parameter
            if (nomeReferencia2 != null) localVarQueryParams.Add("nomeReferencia2", Configuration.ApiClient.ParameterToString(nomeReferencia2)); // query parameter
            if (enderecoReferencia2 != null) localVarQueryParams.Add("enderecoReferencia2", Configuration.ApiClient.ParameterToString(enderecoReferencia2)); // query parameter
            if (impedidoFinanciamento != null) localVarQueryParams.Add("impedidoFinanciamento", Configuration.ApiClient.ParameterToString(impedidoFinanciamento)); // query parameter
            if (naturalidadeCidade != null) localVarQueryParams.Add("naturalidadeCidade", Configuration.ApiClient.ParameterToString(naturalidadeCidade)); // query parameter
            if (naturalidadeEstado != null) localVarQueryParams.Add("naturalidadeEstado", Configuration.ApiClient.ParameterToString(naturalidadeEstado)); // query parameter
            if (grauInstrucao != null) localVarQueryParams.Add("grauInstrucao", Configuration.ApiClient.ParameterToString(grauInstrucao)); // query parameter
            if (numeroDependentes != null) localVarQueryParams.Add("numeroDependentes", Configuration.ApiClient.ParameterToString(numeroDependentes)); // query parameter
            if (nomePai != null) localVarQueryParams.Add("nomePai", Configuration.ApiClient.ParameterToString(nomePai)); // query parameter
            if (chequeEspecial != null) localVarQueryParams.Add("chequeEspecial", Configuration.ApiClient.ParameterToString(chequeEspecial)); // query parameter
            if (numeroCnh != null) localVarQueryParams.Add("numeroCnh", Configuration.ApiClient.ParameterToString(numeroCnh)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Atualiza os detalhes de uma determinada Pessoa Este m\u00E9todo permite que seja alterado na base do emissor os detalhes de uma determinada Pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param>
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param>
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param>
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<PessoaDetalheResponse> Alterar_1Async (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, string numeroCnh = null)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = await Alterar_1AsyncWithHttpInfo(id, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroBanco, numeroAgencia, numeroContaCorrente, email, nomeEmpresa, nomeReferencia1, enderecoReferencia1, nomeReferencia2, enderecoReferencia2, impedidoFinanciamento, naturalidadeCidade, naturalidadeEstado, grauInstrucao, numeroDependentes, nomePai, chequeEspecial, numeroCnh);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualiza os detalhes de uma determinada Pessoa Este m\u00E9todo permite que seja alterado na base do emissor os detalhes de uma determinada Pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param>
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param>
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param>
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> Alterar_1AsyncWithHttpInfo (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, string numeroCnh = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Alterar_1");
            
    
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
            if (numeroBanco != null) localVarQueryParams.Add("numeroBanco", Configuration.ApiClient.ParameterToString(numeroBanco)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroContaCorrente != null) localVarQueryParams.Add("numeroContaCorrente", Configuration.ApiClient.ParameterToString(numeroContaCorrente)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (nomeEmpresa != null) localVarQueryParams.Add("nomeEmpresa", Configuration.ApiClient.ParameterToString(nomeEmpresa)); // query parameter
            if (nomeReferencia1 != null) localVarQueryParams.Add("nomeReferencia1", Configuration.ApiClient.ParameterToString(nomeReferencia1)); // query parameter
            if (enderecoReferencia1 != null) localVarQueryParams.Add("enderecoReferencia1", Configuration.ApiClient.ParameterToString(enderecoReferencia1)); // query parameter
            if (nomeReferencia2 != null) localVarQueryParams.Add("nomeReferencia2", Configuration.ApiClient.ParameterToString(nomeReferencia2)); // query parameter
            if (enderecoReferencia2 != null) localVarQueryParams.Add("enderecoReferencia2", Configuration.ApiClient.ParameterToString(enderecoReferencia2)); // query parameter
            if (impedidoFinanciamento != null) localVarQueryParams.Add("impedidoFinanciamento", Configuration.ApiClient.ParameterToString(impedidoFinanciamento)); // query parameter
            if (naturalidadeCidade != null) localVarQueryParams.Add("naturalidadeCidade", Configuration.ApiClient.ParameterToString(naturalidadeCidade)); // query parameter
            if (naturalidadeEstado != null) localVarQueryParams.Add("naturalidadeEstado", Configuration.ApiClient.ParameterToString(naturalidadeEstado)); // query parameter
            if (grauInstrucao != null) localVarQueryParams.Add("grauInstrucao", Configuration.ApiClient.ParameterToString(grauInstrucao)); // query parameter
            if (numeroDependentes != null) localVarQueryParams.Add("numeroDependentes", Configuration.ApiClient.ParameterToString(numeroDependentes)); // query parameter
            if (nomePai != null) localVarQueryParams.Add("nomePai", Configuration.ApiClient.ParameterToString(nomePai)); // query parameter
            if (chequeEspecial != null) localVarQueryParams.Add("chequeEspecial", Configuration.ApiClient.ParameterToString(chequeEspecial)); // query parameter
            if (numeroCnh != null) localVarQueryParams.Add("numeroCnh", Configuration.ApiClient.ParameterToString(numeroCnh)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }
        
        /// <summary>
        /// Atualiza os dados de uma determinada Pessoa Este m\u00E9todo permite que seja alterado na base do emissor um registro de determinada Pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param> 
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param> 
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param> 
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param> 
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param> 
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param> 
        /// <param name="sexo">Sexo da Pessoa (optional)</param> 
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param> 
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param> 
        /// <returns>PessoaResponse</returns>
        public PessoaResponse Alterar_2 (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
             ApiResponse<PessoaResponse> localVarResponse = Alterar_2WithHttpInfo(id, nome, tipo, dataNascimento, cpf, cnpj, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualiza os dados de uma determinada Pessoa Este m\u00E9todo permite que seja alterado na base do emissor um registro de determinada Pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param> 
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param> 
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param> 
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param> 
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param> 
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param> 
        /// <param name="sexo">Sexo da Pessoa (optional)</param> 
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param> 
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param> 
        /// <returns>ApiResponse of PessoaResponse</returns>
        public ApiResponse< PessoaResponse > Alterar_2WithHttpInfo (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->Alterar_2");
            
            // verify the required parameter 'nome' is set
            if (nome == null)
                throw new ApiException(400, "Missing required parameter 'nome' when calling CadastroClienteApi->Alterar_2");
            
            // verify the required parameter 'tipo' is set
            if (tipo == null)
                throw new ApiException(400, "Missing required parameter 'tipo' when calling CadastroClienteApi->Alterar_2");
            
            // verify the required parameter 'dataNascimento' is set
            if (dataNascimento == null)
                throw new ApiException(400, "Missing required parameter 'dataNascimento' when calling CadastroClienteApi->Alterar_2");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Alterar_2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
        }

        
        /// <summary>
        /// Atualiza os dados de uma determinada Pessoa Este m\u00E9todo permite que seja alterado na base do emissor um registro de determinada Pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param>
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param>
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param>
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param>
        /// <param name="sexo">Sexo da Pessoa (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param>
        /// <returns>Task of PessoaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaResponse> Alterar_2Async (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
             ApiResponse<PessoaResponse> localVarResponse = await Alterar_2AsyncWithHttpInfo(id, nome, tipo, dataNascimento, cpf, cnpj, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualiza os dados de uma determinada Pessoa Este m\u00E9todo permite que seja alterado na base do emissor um registro de determinada Pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param>
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param>
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param>
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param>
        /// <param name="sexo">Sexo da Pessoa (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> Alterar_2AsyncWithHttpInfo (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Alterar_2");
            // verify the required parameter 'nome' is set
            if (nome == null) throw new ApiException(400, "Missing required parameter 'nome' when calling Alterar_2");
            // verify the required parameter 'tipo' is set
            if (tipo == null) throw new ApiException(400, "Missing required parameter 'tipo' when calling Alterar_2");
            // verify the required parameter 'dataNascimento' is set
            if (dataNascimento == null) throw new ApiException(400, "Missing required parameter 'dataNascimento' when calling Alterar_2");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Alterar_2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
        }
        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de um determinado Telefone Este m\u00E9todo permite que seja alterado um determinado Telefone na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param> 
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param> 
        /// <param name="ddd">DDD do n\u00FAmero do telfone (optional)</param> 
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param> 
        /// <param name="ramal">Ramal do telefone (optional)</param> 
        /// <returns>TelefoneResponse</returns>
        public TelefoneResponse Alterar_3 (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null)
        {
             ApiResponse<TelefoneResponse> localVarResponse = Alterar_3WithHttpInfo(id, idTipoTelefone, ddd, telefone, ramal);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de um determinado Telefone Este m\u00E9todo permite que seja alterado um determinado Telefone na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param> 
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param> 
        /// <param name="ddd">DDD do n\u00FAmero do telfone (optional)</param> 
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param> 
        /// <param name="ramal">Ramal do telefone (optional)</param> 
        /// <returns>ApiResponse of TelefoneResponse</returns>
        public ApiResponse< TelefoneResponse > Alterar_3WithHttpInfo (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->Alterar_3");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Alterar_3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
        }

        
        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de um determinado Telefone Este m\u00E9todo permite que seja alterado um determinado Telefone na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="ddd">DDD do n\u00FAmero do telfone (optional)</param>
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param>
        /// <param name="ramal">Ramal do telefone (optional)</param>
        /// <returns>Task of TelefoneResponse</returns>
        public async System.Threading.Tasks.Task<TelefoneResponse> Alterar_3Async (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null)
        {
             ApiResponse<TelefoneResponse> localVarResponse = await Alterar_3AsyncWithHttpInfo(id, idTipoTelefone, ddd, telefone, ramal);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza a altera\u00E7\u00E3o de um determinado Telefone Este m\u00E9todo permite que seja alterado um determinado Telefone na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="ddd">DDD do n\u00FAmero do telfone (optional)</param>
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param>
        /// <param name="ramal">Ramal do telefone (optional)</param>
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> Alterar_3AsyncWithHttpInfo (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Alterar_3");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Alterar_3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
        }
        
        /// <summary>
        /// Permite atribuir um documento para uma Conta Este m\u00E9todo permite que seja atribu\u00EDdo a uma determinada Conta um documento que esteja armazenado no PIER Cloud, informando qual o tipo do documento e o seu respectivo id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param> 
        /// <param name="body">C\u00F3digo de Identifica\u00E7\u00E3o do Arquivo</param> 
        /// <returns>Object</returns>
        public Object AtribuirAssinaturaCliente (long? id, AtribuirAssinaturaClientePersist body)
        {
             ApiResponse<Object> localVarResponse = AtribuirAssinaturaClienteWithHttpInfo(id, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Permite atribuir um documento para uma Conta Este m\u00E9todo permite que seja atribu\u00EDdo a uma determinada Conta um documento que esteja armazenado no PIER Cloud, informando qual o tipo do documento e o seu respectivo id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param> 
        /// <param name="body">C\u00F3digo de Identifica\u00E7\u00E3o do Arquivo</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > AtribuirAssinaturaClienteWithHttpInfo (long? id, AtribuirAssinaturaClientePersist body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->AtribuirAssinaturaCliente");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CadastroClienteApi->AtribuirAssinaturaCliente");
            
    
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
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirAssinaturaCliente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirAssinaturaCliente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Permite atribuir um documento para uma Conta Este m\u00E9todo permite que seja atribu\u00EDdo a uma determinada Conta um documento que esteja armazenado no PIER Cloud, informando qual o tipo do documento e o seu respectivo id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="body">C\u00F3digo de Identifica\u00E7\u00E3o do Arquivo</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> AtribuirAssinaturaClienteAsync (long? id, AtribuirAssinaturaClientePersist body)
        {
             ApiResponse<Object> localVarResponse = await AtribuirAssinaturaClienteAsyncWithHttpInfo(id, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Permite atribuir um documento para uma Conta Este m\u00E9todo permite que seja atribu\u00EDdo a uma determinada Conta um documento que esteja armazenado no PIER Cloud, informando qual o tipo do documento e o seu respectivo id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <param name="body">C\u00F3digo de Identifica\u00E7\u00E3o do Arquivo</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AtribuirAssinaturaClienteAsyncWithHttpInfo (long? id, AtribuirAssinaturaClientePersist body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtribuirAssinaturaCliente");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AtribuirAssinaturaCliente");
            
    
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
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirAssinaturaCliente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirAssinaturaCliente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Atualiza conta integrada com o emissor Este recurso permite a atualiza\u00E7\u00E3o de uma conta integrada com o emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="body">Descri\u00E7\u00E3o do canal de entrada (optional)</param> 
        /// <returns>IntegracaoEmissorResponse</returns>
        public IntegracaoEmissorResponse Atualizar (long? id, IntegracaoEmissorPersist body = null)
        {
             ApiResponse<IntegracaoEmissorResponse> localVarResponse = AtualizarWithHttpInfo(id, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualiza conta integrada com o emissor Este recurso permite a atualiza\u00E7\u00E3o de uma conta integrada com o emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="body">Descri\u00E7\u00E3o do canal de entrada (optional)</param> 
        /// <returns>ApiResponse of IntegracaoEmissorResponse</returns>
        public ApiResponse< IntegracaoEmissorResponse > AtualizarWithHttpInfo (long? id, IntegracaoEmissorPersist body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->Atualizar");
            
    
            var localVarPath = "/api/contas/{id}/atualizar-registro-integracao";
    
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
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Atualizar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Atualizar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<IntegracaoEmissorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegracaoEmissorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegracaoEmissorResponse)));
            
        }

        
        /// <summary>
        /// Atualiza conta integrada com o emissor Este recurso permite a atualiza\u00E7\u00E3o de uma conta integrada com o emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="body">Descri\u00E7\u00E3o do canal de entrada (optional)</param>
        /// <returns>Task of IntegracaoEmissorResponse</returns>
        public async System.Threading.Tasks.Task<IntegracaoEmissorResponse> AtualizarAsync (long? id, IntegracaoEmissorPersist body = null)
        {
             ApiResponse<IntegracaoEmissorResponse> localVarResponse = await AtualizarAsyncWithHttpInfo(id, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualiza conta integrada com o emissor Este recurso permite a atualiza\u00E7\u00E3o de uma conta integrada com o emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="body">Descri\u00E7\u00E3o do canal de entrada (optional)</param>
        /// <returns>Task of ApiResponse (IntegracaoEmissorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IntegracaoEmissorResponse>> AtualizarAsyncWithHttpInfo (long? id, IntegracaoEmissorPersist body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Atualizar");
            
    
            var localVarPath = "/api/contas/{id}/atualizar-registro-integracao";
    
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
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Atualizar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Atualizar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegracaoEmissorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegracaoEmissorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegracaoEmissorResponse)));
            
        }
        
        /// <summary>
        /// Atualiza o endere\u00E7o de correspond\u00EAncia, para o endere\u00E7o informado Este m\u00E9todo permite que o endere\u00E7o de correspond\u00EAncia de uma determinada conta, seja atualizado para o endere\u00E7o de correspond\u00EAncia informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param> 
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param> 
        /// <returns>EnderecoResponse</returns>
        public EnderecoResponse AtualizarEnderecoDeCorrespondencia (long? id, long? idConta)
        {
             ApiResponse<EnderecoResponse> localVarResponse = AtualizarEnderecoDeCorrespondenciaWithHttpInfo(id, idConta);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Atualiza o endere\u00E7o de correspond\u00EAncia, para o endere\u00E7o informado Este m\u00E9todo permite que o endere\u00E7o de correspond\u00EAncia de uma determinada conta, seja atualizado para o endere\u00E7o de correspond\u00EAncia informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param> 
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param> 
        /// <returns>ApiResponse of EnderecoResponse</returns>
        public ApiResponse< EnderecoResponse > AtualizarEnderecoDeCorrespondenciaWithHttpInfo (long? id, long? idConta)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->AtualizarEnderecoDeCorrespondencia");
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling CadastroClienteApi->AtualizarEnderecoDeCorrespondencia");
            
    
            var localVarPath = "/api/enderecos/{id}/alterar-endereco-correspondencia";
    
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
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarEnderecoDeCorrespondencia: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarEnderecoDeCorrespondencia: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }

        
        /// <summary>
        /// Atualiza o endere\u00E7o de correspond\u00EAncia, para o endere\u00E7o informado Este m\u00E9todo permite que o endere\u00E7o de correspond\u00EAncia de uma determinada conta, seja atualizado para o endere\u00E7o de correspond\u00EAncia informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <returns>Task of EnderecoResponse</returns>
        public async System.Threading.Tasks.Task<EnderecoResponse> AtualizarEnderecoDeCorrespondenciaAsync (long? id, long? idConta)
        {
             ApiResponse<EnderecoResponse> localVarResponse = await AtualizarEnderecoDeCorrespondenciaAsyncWithHttpInfo(id, idConta);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Atualiza o endere\u00E7o de correspond\u00EAncia, para o endere\u00E7o informado Este m\u00E9todo permite que o endere\u00E7o de correspond\u00EAncia de uma determinada conta, seja atualizado para o endere\u00E7o de correspond\u00EAncia informado
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param>
        /// <param name="idConta">C\u00F3digo de Identifica\u00E7\u00E3o da Conta</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> AtualizarEnderecoDeCorrespondenciaAsyncWithHttpInfo (long? id, long? idConta)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarEnderecoDeCorrespondencia");
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling AtualizarEnderecoDeCorrespondencia");
            
    
            var localVarPath = "/api/enderecos/{id}/alterar-endereco-correspondencia";
    
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
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarEnderecoDeCorrespondencia: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarEnderecoDeCorrespondencia: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }
        
        /// <summary>
        /// Cadastro da recarga programada Este recurso permite cadastrar uma nova recarga programada na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param> 
        /// <returns>CelularRecargaProgramadaResponse</returns>
        public CelularRecargaProgramadaResponse Cadastrar (CelularRecargaProgramadaPersist persistencia)
        {
             ApiResponse<CelularRecargaProgramadaResponse> localVarResponse = CadastrarWithHttpInfo(persistencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastro da recarga programada Este recurso permite cadastrar uma nova recarga programada na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param> 
        /// <returns>ApiResponse of CelularRecargaProgramadaResponse</returns>
        public ApiResponse< CelularRecargaProgramadaResponse > CadastrarWithHttpInfo (CelularRecargaProgramadaPersist persistencia)
        {
            
            // verify the required parameter 'persistencia' is set
            if (persistencia == null)
                throw new ApiException(400, "Missing required parameter 'persistencia' when calling CadastroClienteApi->Cadastrar");
            
    
            var localVarPath = "/api/celulares/recargas-programadas";
    
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
            
            
            
            
            if (persistencia.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persistencia); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persistencia; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CelularRecargaProgramadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CelularRecargaProgramadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CelularRecargaProgramadaResponse)));
            
        }

        
        /// <summary>
        /// Cadastro da recarga programada Este recurso permite cadastrar uma nova recarga programada na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param>
        /// <returns>Task of CelularRecargaProgramadaResponse</returns>
        public async System.Threading.Tasks.Task<CelularRecargaProgramadaResponse> CadastrarAsync (CelularRecargaProgramadaPersist persistencia)
        {
             ApiResponse<CelularRecargaProgramadaResponse> localVarResponse = await CadastrarAsyncWithHttpInfo(persistencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastro da recarga programada Este recurso permite cadastrar uma nova recarga programada na base do emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param>
        /// <returns>Task of ApiResponse (CelularRecargaProgramadaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CelularRecargaProgramadaResponse>> CadastrarAsyncWithHttpInfo (CelularRecargaProgramadaPersist persistencia)
        {
            // verify the required parameter 'persistencia' is set
            if (persistencia == null) throw new ApiException(400, "Missing required parameter 'persistencia' when calling Cadastrar");
            
    
            var localVarPath = "/api/celulares/recargas-programadas";
    
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
            
            
            
            
            if (persistencia.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persistencia); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persistencia; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CelularRecargaProgramadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CelularRecargaProgramadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CelularRecargaProgramadaResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta Este m\u00E9todo permite que uma pessoa existente na base possa ser um adicional na conta informada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="adicionalContaPersist">adicionalContaPersist</param> 
        /// <returns>AdicionalContaResponse</returns>
        public AdicionalContaResponse CadastrarAdicional (long? id, AdicionalContaPersist adicionalContaPersist)
        {
             ApiResponse<AdicionalContaResponse> localVarResponse = CadastrarAdicionalWithHttpInfo(id, adicionalContaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta Este m\u00E9todo permite que uma pessoa existente na base possa ser um adicional na conta informada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="adicionalContaPersist">adicionalContaPersist</param> 
        /// <returns>ApiResponse of AdicionalContaResponse</returns>
        public ApiResponse< AdicionalContaResponse > CadastrarAdicionalWithHttpInfo (long? id, AdicionalContaPersist adicionalContaPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->CadastrarAdicional");
            
            // verify the required parameter 'adicionalContaPersist' is set
            if (adicionalContaPersist == null)
                throw new ApiException(400, "Missing required parameter 'adicionalContaPersist' when calling CadastroClienteApi->CadastrarAdicional");
            
    
            var localVarPath = "/api/contas/{id}/adicionais";
    
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
            
            
            
            
            if (adicionalContaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(adicionalContaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = adicionalContaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarAdicional: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarAdicional: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdicionalContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalContaResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta Este m\u00E9todo permite que uma pessoa existente na base possa ser um adicional na conta informada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="adicionalContaPersist">adicionalContaPersist</param>
        /// <returns>Task of AdicionalContaResponse</returns>
        public async System.Threading.Tasks.Task<AdicionalContaResponse> CadastrarAdicionalAsync (long? id, AdicionalContaPersist adicionalContaPersist)
        {
             ApiResponse<AdicionalContaResponse> localVarResponse = await CadastrarAdicionalAsyncWithHttpInfo(id, adicionalContaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta Este m\u00E9todo permite que uma pessoa existente na base possa ser um adicional na conta informada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="adicionalContaPersist">adicionalContaPersist</param>
        /// <returns>Task of ApiResponse (AdicionalContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdicionalContaResponse>> CadastrarAdicionalAsyncWithHttpInfo (long? id, AdicionalContaPersist adicionalContaPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CadastrarAdicional");
            // verify the required parameter 'adicionalContaPersist' is set
            if (adicionalContaPersist == null) throw new ApiException(400, "Missing required parameter 'adicionalContaPersist' when calling CadastrarAdicional");
            
    
            var localVarPath = "/api/contas/{id}/adicionais";
    
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
            
            
            
            
            if (adicionalContaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(adicionalContaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = adicionalContaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarAdicional: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarAdicional: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdicionalContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalContaResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta Este m\u00E9todo permite que sejam cadastrados um portador Adicional para uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="persist">persist</param> 
        /// <returns>AdicionalDetalheResponse</returns>
        public AdicionalDetalheResponse Cadastrar_0 (long? id, AdicionalPersist persist)
        {
             ApiResponse<AdicionalDetalheResponse> localVarResponse = Cadastrar_0WithHttpInfo(id, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta Este m\u00E9todo permite que sejam cadastrados um portador Adicional para uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of AdicionalDetalheResponse</returns>
        public ApiResponse< AdicionalDetalheResponse > Cadastrar_0WithHttpInfo (long? id, AdicionalPersist persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->Cadastrar_0");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling CadastroClienteApi->Cadastrar_0");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdicionalDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalDetalheResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta Este m\u00E9todo permite que sejam cadastrados um portador Adicional para uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of AdicionalDetalheResponse</returns>
        public async System.Threading.Tasks.Task<AdicionalDetalheResponse> Cadastrar_0Async (long? id, AdicionalPersist persist)
        {
             ApiResponse<AdicionalDetalheResponse> localVarResponse = await Cadastrar_0AsyncWithHttpInfo(id, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de Adicionais para uma Conta Este m\u00E9todo permite que sejam cadastrados um portador Adicional para uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (AdicionalDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdicionalDetalheResponse>> Cadastrar_0AsyncWithHttpInfo (long? id, AdicionalPersist persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Cadastrar_0");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling Cadastrar_0");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdicionalDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalDetalheResponse)));
            
        }
        
        /// <summary>
        /// Consulta Adicional de uma Conta Este m\u00E9todo permite que seja consultado um portador Adicional de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param> 
        /// <returns>AdicionalDetalheResponse</returns>
        public AdicionalDetalheResponse Consultar (long? id, long? idPessoa)
        {
             ApiResponse<AdicionalDetalheResponse> localVarResponse = ConsultarWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta Adicional de uma Conta Este m\u00E9todo permite que seja consultado um portador Adicional de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param> 
        /// <returns>ApiResponse of AdicionalDetalheResponse</returns>
        public ApiResponse< AdicionalDetalheResponse > ConsultarWithHttpInfo (long? id, long? idPessoa)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->Consultar");
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling CadastroClienteApi->Consultar");
            
    
            var localVarPath = "/api/contas/{id}/adicionais/{idPessoa}";
    
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
            if (idPessoa != null) localVarPathParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdicionalDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalDetalheResponse)));
            
        }

        
        /// <summary>
        /// Consulta Adicional de uma Conta Este m\u00E9todo permite que seja consultado um portador Adicional de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>Task of AdicionalDetalheResponse</returns>
        public async System.Threading.Tasks.Task<AdicionalDetalheResponse> ConsultarAsync (long? id, long? idPessoa)
        {
             ApiResponse<AdicionalDetalheResponse> localVarResponse = await ConsultarAsyncWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta Adicional de uma Conta Este m\u00E9todo permite que seja consultado um portador Adicional de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>Task of ApiResponse (AdicionalDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdicionalDetalheResponse>> ConsultarAsyncWithHttpInfo (long? id, long? idPessoa)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar");
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling Consultar");
            
    
            var localVarPath = "/api/contas/{id}/adicionais/{idPessoa}";
    
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
            if (idPessoa != null) localVarPathParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdicionalDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalDetalheResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00E7o Este m\u00E9todo permite consultar um determinado Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param> 
        /// <returns>EnderecoResponse</returns>
        public EnderecoResponse Consultar_0 (long? id)
        {
             ApiResponse<EnderecoResponse> localVarResponse = Consultar_0WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00E7o Este m\u00E9todo permite consultar um determinado Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param> 
        /// <returns>ApiResponse of EnderecoResponse</returns>
        public ApiResponse< EnderecoResponse > Consultar_0WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->Consultar_0");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00E7o Este m\u00E9todo permite consultar um determinado Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param>
        /// <returns>Task of EnderecoResponse</returns>
        public async System.Threading.Tasks.Task<EnderecoResponse> Consultar_0Async (long? id)
        {
             ApiResponse<EnderecoResponse> localVarResponse = await Consultar_0AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Endere\u00E7o Este m\u00E9todo permite consultar um determinado Endere\u00E7o a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id)</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> Consultar_0AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_0");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os detalhes de uma determinada Pessoa Este m\u00E9todo permite a consulta dos detalhes de uma Pessoa existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param> 
        /// <returns>PessoaDetalheResponse</returns>
        public PessoaDetalheResponse Consultar_1 (long? id)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = Consultar_1WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os detalhes de uma determinada Pessoa Este m\u00E9todo permite a consulta dos detalhes de uma Pessoa existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param> 
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        public ApiResponse< PessoaDetalheResponse > Consultar_1WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->Consultar_1");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os detalhes de uma determinada Pessoa Este m\u00E9todo permite a consulta dos detalhes de uma Pessoa existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<PessoaDetalheResponse> Consultar_1Async (long? id)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = await Consultar_1AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os detalhes de uma determinada Pessoa Este m\u00E9todo permite a consulta dos detalhes de uma Pessoa existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> Consultar_1AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_1");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param> 
        /// <returns>PessoaResponse</returns>
        public PessoaResponse Consultar_2 (long? id)
        {
             ApiResponse<PessoaResponse> localVarResponse = Consultar_2WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param> 
        /// <returns>ApiResponse of PessoaResponse</returns>
        public ApiResponse< PessoaResponse > Consultar_2WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->Consultar_2");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Task of PessoaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaResponse> Consultar_2Async (long? id)
        {
             ApiResponse<PessoaResponse> localVarResponse = await Consultar_2AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de uma determinada Pessoa Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID da Pessoa</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> Consultar_2AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_2");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado Telefone Este m\u00E9todo permite consultar um determinado Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param> 
        /// <returns>TelefoneResponse</returns>
        public TelefoneResponse Consultar_3 (long? id)
        {
             ApiResponse<TelefoneResponse> localVarResponse = Consultar_3WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Telefone Este m\u00E9todo permite consultar um determinado Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param> 
        /// <returns>ApiResponse of TelefoneResponse</returns>
        public ApiResponse< TelefoneResponse > Consultar_3WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->Consultar_3");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
        }

        
        /// <summary>
        /// Apresenta os dados de um determinado Telefone Este m\u00E9todo permite consultar um determinado Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param>
        /// <returns>Task of TelefoneResponse</returns>
        public async System.Threading.Tasks.Task<TelefoneResponse> Consultar_3Async (long? id)
        {
             ApiResponse<TelefoneResponse> localVarResponse = await Consultar_3AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Telefone Este m\u00E9todo permite consultar um determinado Telefone a partir do seu c\u00F3digo de identifica\u00E7\u00E3o (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id)</param>
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> Consultar_3AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_3");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
        }
        
        /// <summary>
        /// Inativa Adicional de uma Conta Este m\u00E9todo permite que seja inativado um portador Adicional de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param> 
        /// <returns>string</returns>
        public string Inativar (long? id, long? idPessoa)
        {
             ApiResponse<string> localVarResponse = InativarWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Inativa Adicional de uma Conta Este m\u00E9todo permite que seja inativado um portador Adicional de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > InativarWithHttpInfo (long? id, long? idPessoa)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->Inativar");
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling CadastroClienteApi->Inativar");
            
    
            var localVarPath = "/api/contas/{id}/adicionais/{idPessoa}/inativar";
    
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
            if (idPessoa != null) localVarPathParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Inativar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Inativar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Inativa Adicional de uma Conta Este m\u00E9todo permite que seja inativado um portador Adicional de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> InativarAsync (long? id, long? idPessoa)
        {
             ApiResponse<string> localVarResponse = await InativarAsyncWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Inativa Adicional de uma Conta Este m\u00E9todo permite que seja inativado um portador Adicional de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> InativarAsyncWithHttpInfo (long? id, long? idPessoa)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Inativar");
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling Inativar");
            
    
            var localVarPath = "/api/contas/{id}/adicionais/{idPessoa}/inativar";
    
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
            if (idPessoa != null) localVarPathParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Inativar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Inativar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// Lista os Adicionais de uma Conta Este m\u00E9todo permite que sejam listados portadores Adicionais de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>AdicionalResponse</returns>
        public AdicionalResponse Listar (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<AdicionalResponse> localVarResponse = ListarWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Adicionais de uma Conta Este m\u00E9todo permite que sejam listados portadores Adicionais de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of AdicionalResponse</returns>
        public ApiResponse< AdicionalResponse > ListarWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->Listar");
            
    
            var localVarPath = "/api/contas/{id}/adicionais";
    
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdicionalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalResponse)));
            
        }

        
        /// <summary>
        /// Lista os Adicionais de uma Conta Este m\u00E9todo permite que sejam listados portadores Adicionais de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of AdicionalResponse</returns>
        public async System.Threading.Tasks.Task<AdicionalResponse> ListarAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<AdicionalResponse> localVarResponse = await ListarAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Adicionais de uma Conta Este m\u00E9todo permite que sejam listados portadores Adicionais de uma determinada Conta
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da conta (id)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (AdicionalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdicionalResponse>> ListarAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Listar");
            
    
            var localVarPath = "/api/contas/{id}/adicionais";
    
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdicionalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalResponse)));
            
        }
        
        /// <summary>
        /// Lista as contas da pessoa Permite listar as contas de um pessoa a partir do seu numero na receita federal
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">N\u00FAmero de identifica\u00E7\u00E3o do cliente na Receita Federal (CPF ou CNPJ)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PageContaDetalheResponse</returns>
        public PageContaDetalheResponse ListarContasPorPessoa (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageContaDetalheResponse> localVarResponse = ListarContasPorPessoaWithHttpInfo(numeroReceitaFederal, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as contas da pessoa Permite listar as contas de um pessoa a partir do seu numero na receita federal
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">N\u00FAmero de identifica\u00E7\u00E3o do cliente na Receita Federal (CPF ou CNPJ)</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageContaDetalheResponse</returns>
        public ApiResponse< PageContaDetalheResponse > ListarContasPorPessoaWithHttpInfo (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'numeroReceitaFederal' is set
            if (numeroReceitaFederal == null)
                throw new ApiException(400, "Missing required parameter 'numeroReceitaFederal' when calling CadastroClienteApi->ListarContasPorPessoa");
            
    
            var localVarPath = "/api/pessoas/listar-contas";
    
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
            
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarContasPorPessoa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarContasPorPessoa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageContaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Lista as contas da pessoa Permite listar as contas de um pessoa a partir do seu numero na receita federal
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">N\u00FAmero de identifica\u00E7\u00E3o do cliente na Receita Federal (CPF ou CNPJ)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageContaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<PageContaDetalheResponse> ListarContasPorPessoaAsync (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageContaDetalheResponse> localVarResponse = await ListarContasPorPessoaAsyncWithHttpInfo(numeroReceitaFederal, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as contas da pessoa Permite listar as contas de um pessoa a partir do seu numero na receita federal
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">N\u00FAmero de identifica\u00E7\u00E3o do cliente na Receita Federal (CPF ou CNPJ)</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageContaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageContaDetalheResponse>> ListarContasPorPessoaAsyncWithHttpInfo (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'numeroReceitaFederal' is set
            if (numeroReceitaFederal == null) throw new ApiException(400, "Missing required parameter 'numeroReceitaFederal' when calling ListarContasPorPessoa");
            
    
            var localVarPath = "/api/pessoas/listar-contas";
    
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
            
            if (numeroReceitaFederal != null) localVarQueryParams.Add("numeroReceitaFederal", Configuration.ApiClient.ParameterToString(numeroReceitaFederal)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarContasPorPessoa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarContasPorPessoa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageContaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaDetalheResponse)));
            
        }
        
        /// <summary>
        /// Lista o hist\u00F3rico de altera\u00E7\u00E3o do endereco Este m\u00E9todo permite que sejam listados o historico de altera\u00E7\u00E3o dos Endere\u00E7os existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="dataAlteracaoInicio">Data de in\u00EDcio (optional)</param> 
        /// <param name="dataAlteracaoFim">Data fim (optional)</param> 
        /// <param name="cpf">Cpf da pessoa relacionada ao endere\u00E7o (optional)</param> 
        /// <param name="idConta">Conta relacionada ao endere\u00E7o (optional)</param> 
        /// <param name="canalAlteracao">Aplicativo Respons\u00E1vel por alterar o endere\u00E7o (optional)</param> 
        /// <returns>PageHistoricoEnderecoResponse</returns>
        public PageHistoricoEnderecoResponse ListarHistoricoEndereco (List<string> sort = null, int? page = null, int? limit = null, string dataAlteracaoInicio = null, string dataAlteracaoFim = null, string cpf = null, long? idConta = null, string canalAlteracao = null)
        {
             ApiResponse<PageHistoricoEnderecoResponse> localVarResponse = ListarHistoricoEnderecoWithHttpInfo(sort, page, limit, dataAlteracaoInicio, dataAlteracaoFim, cpf, idConta, canalAlteracao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista o hist\u00F3rico de altera\u00E7\u00E3o do endereco Este m\u00E9todo permite que sejam listados o historico de altera\u00E7\u00E3o dos Endere\u00E7os existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="dataAlteracaoInicio">Data de in\u00EDcio (optional)</param> 
        /// <param name="dataAlteracaoFim">Data fim (optional)</param> 
        /// <param name="cpf">Cpf da pessoa relacionada ao endere\u00E7o (optional)</param> 
        /// <param name="idConta">Conta relacionada ao endere\u00E7o (optional)</param> 
        /// <param name="canalAlteracao">Aplicativo Respons\u00E1vel por alterar o endere\u00E7o (optional)</param> 
        /// <returns>ApiResponse of PageHistoricoEnderecoResponse</returns>
        public ApiResponse< PageHistoricoEnderecoResponse > ListarHistoricoEnderecoWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataAlteracaoInicio = null, string dataAlteracaoFim = null, string cpf = null, long? idConta = null, string canalAlteracao = null)
        {
            
    
            var localVarPath = "/api/enderecos/historicos";
    
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
            if (dataAlteracaoInicio != null) localVarQueryParams.Add("dataAlteracaoInicio", Configuration.ApiClient.ParameterToString(dataAlteracaoInicio)); // query parameter
            if (dataAlteracaoFim != null) localVarQueryParams.Add("dataAlteracaoFim", Configuration.ApiClient.ParameterToString(dataAlteracaoFim)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (canalAlteracao != null) localVarQueryParams.Add("canalAlteracao", Configuration.ApiClient.ParameterToString(canalAlteracao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoEndereco: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoEndereco: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageHistoricoEnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoEnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoEnderecoResponse)));
            
        }

        
        /// <summary>
        /// Lista o hist\u00F3rico de altera\u00E7\u00E3o do endereco Este m\u00E9todo permite que sejam listados o historico de altera\u00E7\u00E3o dos Endere\u00E7os existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataAlteracaoInicio">Data de in\u00EDcio (optional)</param>
        /// <param name="dataAlteracaoFim">Data fim (optional)</param>
        /// <param name="cpf">Cpf da pessoa relacionada ao endere\u00E7o (optional)</param>
        /// <param name="idConta">Conta relacionada ao endere\u00E7o (optional)</param>
        /// <param name="canalAlteracao">Aplicativo Respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <returns>Task of PageHistoricoEnderecoResponse</returns>
        public async System.Threading.Tasks.Task<PageHistoricoEnderecoResponse> ListarHistoricoEnderecoAsync (List<string> sort = null, int? page = null, int? limit = null, string dataAlteracaoInicio = null, string dataAlteracaoFim = null, string cpf = null, long? idConta = null, string canalAlteracao = null)
        {
             ApiResponse<PageHistoricoEnderecoResponse> localVarResponse = await ListarHistoricoEnderecoAsyncWithHttpInfo(sort, page, limit, dataAlteracaoInicio, dataAlteracaoFim, cpf, idConta, canalAlteracao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista o hist\u00F3rico de altera\u00E7\u00E3o do endereco Este m\u00E9todo permite que sejam listados o historico de altera\u00E7\u00E3o dos Endere\u00E7os existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="dataAlteracaoInicio">Data de in\u00EDcio (optional)</param>
        /// <param name="dataAlteracaoFim">Data fim (optional)</param>
        /// <param name="cpf">Cpf da pessoa relacionada ao endere\u00E7o (optional)</param>
        /// <param name="idConta">Conta relacionada ao endere\u00E7o (optional)</param>
        /// <param name="canalAlteracao">Aplicativo Respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <returns>Task of ApiResponse (PageHistoricoEnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageHistoricoEnderecoResponse>> ListarHistoricoEnderecoAsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string dataAlteracaoInicio = null, string dataAlteracaoFim = null, string cpf = null, long? idConta = null, string canalAlteracao = null)
        {
            
    
            var localVarPath = "/api/enderecos/historicos";
    
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
            if (dataAlteracaoInicio != null) localVarQueryParams.Add("dataAlteracaoInicio", Configuration.ApiClient.ParameterToString(dataAlteracaoInicio)); // query parameter
            if (dataAlteracaoFim != null) localVarQueryParams.Add("dataAlteracaoFim", Configuration.ApiClient.ParameterToString(dataAlteracaoFim)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            if (canalAlteracao != null) localVarQueryParams.Add("canalAlteracao", Configuration.ApiClient.ParameterToString(canalAlteracao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoEndereco: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoEndereco: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageHistoricoEnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageHistoricoEnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageHistoricoEnderecoResponse)));
            
        }
        
        /// <summary>
        /// Listar altera\u00E7\u00F5es de telefones realizadas nos \u00FAltimos 60 dias Este m\u00E9todo permite verificar quais os telefones de um determinado que cliente que sofreram altera\u00E7\u00E3o nos \u00FAltimos 60 dias
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param> 
        /// <returns>HistoricoTelefoneResponse</returns>
        public HistoricoTelefoneResponse ListarHistoricoTelefones (long? id)
        {
             ApiResponse<HistoricoTelefoneResponse> localVarResponse = ListarHistoricoTelefonesWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar altera\u00E7\u00F5es de telefones realizadas nos \u00FAltimos 60 dias Este m\u00E9todo permite verificar quais os telefones de um determinado que cliente que sofreram altera\u00E7\u00E3o nos \u00FAltimos 60 dias
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param> 
        /// <returns>ApiResponse of HistoricoTelefoneResponse</returns>
        public ApiResponse< HistoricoTelefoneResponse > ListarHistoricoTelefonesWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->ListarHistoricoTelefones");
            
    
            var localVarPath = "/api/pessoas/{id}/historico-telefones";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoTelefones: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoTelefones: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<HistoricoTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HistoricoTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(HistoricoTelefoneResponse)));
            
        }

        
        /// <summary>
        /// Listar altera\u00E7\u00F5es de telefones realizadas nos \u00FAltimos 60 dias Este m\u00E9todo permite verificar quais os telefones de um determinado que cliente que sofreram altera\u00E7\u00E3o nos \u00FAltimos 60 dias
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>Task of HistoricoTelefoneResponse</returns>
        public async System.Threading.Tasks.Task<HistoricoTelefoneResponse> ListarHistoricoTelefonesAsync (long? id)
        {
             ApiResponse<HistoricoTelefoneResponse> localVarResponse = await ListarHistoricoTelefonesAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar altera\u00E7\u00F5es de telefones realizadas nos \u00FAltimos 60 dias Este m\u00E9todo permite verificar quais os telefones de um determinado que cliente que sofreram altera\u00E7\u00E3o nos \u00FAltimos 60 dias
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da pessoa (id)</param>
        /// <returns>Task of ApiResponse (HistoricoTelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<HistoricoTelefoneResponse>> ListarHistoricoTelefonesAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarHistoricoTelefones");
            
    
            var localVarPath = "/api/pessoas/{id}/historico-telefones";
    
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
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoTelefones: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoTelefones: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<HistoricoTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HistoricoTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(HistoricoTelefoneResponse)));
            
        }
        
        /// <summary>
        /// Listar s\u00F3cios de uma pessoa jur\u00EDdica Lista os s\u00F3cios vinculados \u00E0 uma Pessoa Jur\u00EDdica cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Jur\u00EDdica</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>PagePessoaResponse</returns>
        public PagePessoaResponse ListarSocios (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PagePessoaResponse> localVarResponse = ListarSociosWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar s\u00F3cios de uma pessoa jur\u00EDdica Lista os s\u00F3cios vinculados \u00E0 uma Pessoa Jur\u00EDdica cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Jur\u00EDdica</param> 
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PagePessoaResponse</returns>
        public ApiResponse< PagePessoaResponse > ListarSociosWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->ListarSocios");
            
    
            var localVarPath = "/api/clientes-pessoas-juridicas/{id}/socios";
    
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarSocios: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarSocios: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaResponse)));
            
        }

        
        /// <summary>
        /// Listar s\u00F3cios de uma pessoa jur\u00EDdica Lista os s\u00F3cios vinculados \u00E0 uma Pessoa Jur\u00EDdica cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Jur\u00EDdica</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PagePessoaResponse</returns>
        public async System.Threading.Tasks.Task<PagePessoaResponse> ListarSociosAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PagePessoaResponse> localVarResponse = await ListarSociosAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar s\u00F3cios de uma pessoa jur\u00EDdica Lista os s\u00F3cios vinculados \u00E0 uma Pessoa Jur\u00EDdica cadastrada
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa Jur\u00EDdica</param>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePessoaResponse>> ListarSociosAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarSocios");
            
    
            var localVarPath = "/api/clientes-pessoas-juridicas/{id}/socios";
    
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarSocios: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarSocios: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaResponse)));
            
        }
        
        /// <summary>
        /// Lista os Endere\u00E7os cadastrados para o Emissor Este m\u00E9todo permite que sejam listados os Endere\u00E7os existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param> 
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param> 
        /// <param name="cep">List os CEPs (optional)</param> 
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param> 
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param> 
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param> 
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param> 
        /// <param name="bairro">Apresenta nome do bairro (optional)</param> 
        /// <param name="cidade">Apresenta nome da cidade (optional)</param> 
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param> 
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param> 
        /// <param name="dataInclusao">Apresenta a data em que fora cadastrado o Endere\u00E7o (optional)</param> 
        /// <param name="dataUltimaAtualizacao">Data em que fora realizada a \u00FAltima mudan\u00E7a neste registro de endere\u00E7o. Quando n\u00E3o tiver ocorrido mudan\u00E7a, conter\u00E1 a mesma informa\u00E7\u00E3o que o campo dataInclusao (optional)</param> 
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param> 
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param> 
        /// <returns>PageEnderecoResponse</returns>
        public PageEnderecoResponse Listar_0 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null)
        {
             ApiResponse<PageEnderecoResponse> localVarResponse = Listar_0WithHttpInfo(sort, page, limit, id, idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais, dataInclusao, dataUltimaAtualizacao, tempoResidenciaAnos, tempoResidenciaMeses);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Endere\u00E7os cadastrados para o Emissor Este m\u00E9todo permite que sejam listados os Endere\u00E7os existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param> 
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param> 
        /// <param name="cep">List os CEPs (optional)</param> 
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param> 
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param> 
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param> 
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param> 
        /// <param name="bairro">Apresenta nome do bairro (optional)</param> 
        /// <param name="cidade">Apresenta nome da cidade (optional)</param> 
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param> 
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param> 
        /// <param name="dataInclusao">Apresenta a data em que fora cadastrado o Endere\u00E7o (optional)</param> 
        /// <param name="dataUltimaAtualizacao">Data em que fora realizada a \u00FAltima mudan\u00E7a neste registro de endere\u00E7o. Quando n\u00E3o tiver ocorrido mudan\u00E7a, conter\u00E1 a mesma informa\u00E7\u00E3o que o campo dataInclusao (optional)</param> 
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param> 
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param> 
        /// <returns>ApiResponse of PageEnderecoResponse</returns>
        public ApiResponse< PageEnderecoResponse > Listar_0WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
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
            if (tempoResidenciaAnos != null) localVarQueryParams.Add("tempoResidenciaAnos", Configuration.ApiClient.ParameterToString(tempoResidenciaAnos)); // query parameter
            if (tempoResidenciaMeses != null) localVarQueryParams.Add("tempoResidenciaMeses", Configuration.ApiClient.ParameterToString(tempoResidenciaMeses)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageEnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEnderecoResponse)));
            
        }

        
        /// <summary>
        /// Lista os Endere\u00E7os cadastrados para o Emissor Este m\u00E9todo permite que sejam listados os Endere\u00E7os existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">List os CEPs (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="dataInclusao">Apresenta a data em que fora cadastrado o Endere\u00E7o (optional)</param>
        /// <param name="dataUltimaAtualizacao">Data em que fora realizada a \u00FAltima mudan\u00E7a neste registro de endere\u00E7o. Quando n\u00E3o tiver ocorrido mudan\u00E7a, conter\u00E1 a mesma informa\u00E7\u00E3o que o campo dataInclusao (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <returns>Task of PageEnderecoResponse</returns>
        public async System.Threading.Tasks.Task<PageEnderecoResponse> Listar_0Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null)
        {
             ApiResponse<PageEnderecoResponse> localVarResponse = await Listar_0AsyncWithHttpInfo(sort, page, limit, id, idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais, dataInclusao, dataUltimaAtualizacao, tempoResidenciaAnos, tempoResidenciaMeses);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Endere\u00E7os cadastrados para o Emissor Este m\u00E9todo permite que sejam listados os Endere\u00E7os existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Endere\u00E7o (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">List os CEPs (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="dataInclusao">Apresenta a data em que fora cadastrado o Endere\u00E7o (optional)</param>
        /// <param name="dataUltimaAtualizacao">Data em que fora realizada a \u00FAltima mudan\u00E7a neste registro de endere\u00E7o. Quando n\u00E3o tiver ocorrido mudan\u00E7a, conter\u00E1 a mesma informa\u00E7\u00E3o que o campo dataInclusao (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <returns>Task of ApiResponse (PageEnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageEnderecoResponse>> Listar_0AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
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
            if (tempoResidenciaAnos != null) localVarQueryParams.Add("tempoResidenciaAnos", Configuration.ApiClient.ParameterToString(tempoResidenciaAnos)); // query parameter
            if (tempoResidenciaMeses != null) localVarQueryParams.Add("tempoResidenciaMeses", Configuration.ApiClient.ParameterToString(tempoResidenciaMeses)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageEnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEnderecoResponse)));
            
        }
        
        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) (optional)</param> 
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39; (optional)</param> 
        /// <param name="tipo">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa F\u00EDsica, sendo: (&#39;PF&#39;: Pessoa F\u00EDsica), (&#39;PJ&#39;: Pessoa Jur\u00EDdica) (optional)</param> 
        /// <param name="cpf">Quando uma pessoa f\u00EDsica preencha com o CPF (optional)</param> 
        /// <param name="cnpj">Quando um pessoa jur\u00EDdica preencha o CNPJ (optional)</param> 
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ (optional)</param> 
        /// <param name="sexo">C\u00F3digo de Identifica\u00E7\u00E3o do sexo da pessoa, quando \u00E9 PF, sendo: (&#39;M&#39;: Masculino), (&#39;F&#39;: Feminino), (&#39;O&#39;: Outro), (&#39;N&#39;: N\u00E3o especificado) (optional)</param> 
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do RG (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param> 
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da identidade no formato aaaa-MM-dd (optional)</param> 
        /// <returns>PagePessoaResponse</returns>
        public PagePessoaResponse Listar_1 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
             ApiResponse<PagePessoaResponse> localVarResponse = Listar_1WithHttpInfo(sort, page, limit, id, nome, tipo, cpf, cnpj, dataNascimento, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) (optional)</param> 
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39; (optional)</param> 
        /// <param name="tipo">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa F\u00EDsica, sendo: (&#39;PF&#39;: Pessoa F\u00EDsica), (&#39;PJ&#39;: Pessoa Jur\u00EDdica) (optional)</param> 
        /// <param name="cpf">Quando uma pessoa f\u00EDsica preencha com o CPF (optional)</param> 
        /// <param name="cnpj">Quando um pessoa jur\u00EDdica preencha o CNPJ (optional)</param> 
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ (optional)</param> 
        /// <param name="sexo">C\u00F3digo de Identifica\u00E7\u00E3o do sexo da pessoa, quando \u00E9 PF, sendo: (&#39;M&#39;: Masculino), (&#39;F&#39;: Feminino), (&#39;O&#39;: Outro), (&#39;N&#39;: N\u00E3o especificado) (optional)</param> 
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do RG (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param> 
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da identidade no formato aaaa-MM-dd (optional)</param> 
        /// <returns>ApiResponse of PagePessoaResponse</returns>
        public ApiResponse< PagePessoaResponse > Listar_1WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling Listar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaResponse)));
            
        }

        
        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) (optional)</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39; (optional)</param>
        /// <param name="tipo">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa F\u00EDsica, sendo: (&#39;PF&#39;: Pessoa F\u00EDsica), (&#39;PJ&#39;: Pessoa Jur\u00EDdica) (optional)</param>
        /// <param name="cpf">Quando uma pessoa f\u00EDsica preencha com o CPF (optional)</param>
        /// <param name="cnpj">Quando um pessoa jur\u00EDdica preencha o CNPJ (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ (optional)</param>
        /// <param name="sexo">C\u00F3digo de Identifica\u00E7\u00E3o do sexo da pessoa, quando \u00E9 PF, sendo: (&#39;M&#39;: Masculino), (&#39;F&#39;: Feminino), (&#39;O&#39;: Outro), (&#39;N&#39;: N\u00E3o especificado) (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do RG (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da identidade no formato aaaa-MM-dd (optional)</param>
        /// <returns>Task of PagePessoaResponse</returns>
        public async System.Threading.Tasks.Task<PagePessoaResponse> Listar_1Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
             ApiResponse<PagePessoaResponse> localVarResponse = await Listar_1AsyncWithHttpInfo(sort, page, limit, id, nome, tipo, cpf, cnpj, dataNascimento, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista as Pessoas cadastradas no Emissor Este m\u00E9todo permite que sejam listadas as Pessoas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) (optional)</param>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39; (optional)</param>
        /// <param name="tipo">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa F\u00EDsica, sendo: (&#39;PF&#39;: Pessoa F\u00EDsica), (&#39;PJ&#39;: Pessoa Jur\u00EDdica) (optional)</param>
        /// <param name="cpf">Quando uma pessoa f\u00EDsica preencha com o CPF (optional)</param>
        /// <param name="cnpj">Quando um pessoa jur\u00EDdica preencha o CNPJ (optional)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ (optional)</param>
        /// <param name="sexo">C\u00F3digo de Identifica\u00E7\u00E3o do sexo da pessoa, quando \u00E9 PF, sendo: (&#39;M&#39;: Masculino), (&#39;F&#39;: Feminino), (&#39;O&#39;: Outro), (&#39;N&#39;: N\u00E3o especificado) (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do RG (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da identidade no formato aaaa-MM-dd (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePessoaResponse>> Listar_1AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling Listar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaResponse)));
            
        }
        
        /// <summary>
        /// Lista os Detalhes das Pessoas cadastradas no Emissor Este m\u00E9todo permite que sejam listadas od detalhes das Pessoas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa (optional)</param> 
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param> 
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param> 
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param> 
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param> 
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param> 
        /// <param name="numeroBanco">N\u00FAmero do Banco (optional)</param> 
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param> 
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param> 
        /// <param name="email">Email da pessoa fisica (optional)</param> 
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param> 
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param> 
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param> 
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param> 
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param> 
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param> 
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param> 
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5esde cr\u00E9dito(Lei n. 4.595/64) (optional)</param> 
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param> 
        /// <returns>PagePessoaDetalheResponse</returns>
        public PagePessoaDetalheResponse Listar_2 (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null)
        {
             ApiResponse<PagePessoaDetalheResponse> localVarResponse = Listar_2WithHttpInfo(sort, page, limit, idPessoa, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroBanco, numeroAgencia, numeroContaCorrente, email, nomeEmpresa, naturalidadeCidade, naturalidadeEstado, grauInstrucao, numeroDependentes, nomePai, chequeEspecial, impedidoFinanciamento, numeroCnh);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Detalhes das Pessoas cadastradas no Emissor Este m\u00E9todo permite que sejam listadas od detalhes das Pessoas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa (optional)</param> 
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param> 
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param> 
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param> 
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param> 
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param> 
        /// <param name="numeroBanco">N\u00FAmero do Banco (optional)</param> 
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param> 
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param> 
        /// <param name="email">Email da pessoa fisica (optional)</param> 
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param> 
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param> 
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param> 
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param> 
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param> 
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param> 
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param> 
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5esde cr\u00E9dito(Lei n. 4.595/64) (optional)</param> 
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param> 
        /// <returns>ApiResponse of PagePessoaDetalheResponse</returns>
        public ApiResponse< PagePessoaDetalheResponse > Listar_2WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (nomeMae != null) localVarQueryParams.Add("nomeMae", Configuration.ApiClient.ParameterToString(nomeMae)); // query parameter
            if (idEstadoCivil != null) localVarQueryParams.Add("idEstadoCivil", Configuration.ApiClient.ParameterToString(idEstadoCivil)); // query parameter
            if (idProfissao != null) localVarQueryParams.Add("idProfissao", Configuration.ApiClient.ParameterToString(idProfissao)); // query parameter
            if (idNaturezaOcupacao != null) localVarQueryParams.Add("idNaturezaOcupacao", Configuration.ApiClient.ParameterToString(idNaturezaOcupacao)); // query parameter
            if (idNacionalidade != null) localVarQueryParams.Add("idNacionalidade", Configuration.ApiClient.ParameterToString(idNacionalidade)); // query parameter
            if (numeroBanco != null) localVarQueryParams.Add("numeroBanco", Configuration.ApiClient.ParameterToString(numeroBanco)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroContaCorrente != null) localVarQueryParams.Add("numeroContaCorrente", Configuration.ApiClient.ParameterToString(numeroContaCorrente)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (nomeEmpresa != null) localVarQueryParams.Add("nomeEmpresa", Configuration.ApiClient.ParameterToString(nomeEmpresa)); // query parameter
            if (naturalidadeCidade != null) localVarQueryParams.Add("naturalidadeCidade", Configuration.ApiClient.ParameterToString(naturalidadeCidade)); // query parameter
            if (naturalidadeEstado != null) localVarQueryParams.Add("naturalidadeEstado", Configuration.ApiClient.ParameterToString(naturalidadeEstado)); // query parameter
            if (grauInstrucao != null) localVarQueryParams.Add("grauInstrucao", Configuration.ApiClient.ParameterToString(grauInstrucao)); // query parameter
            if (numeroDependentes != null) localVarQueryParams.Add("numeroDependentes", Configuration.ApiClient.ParameterToString(numeroDependentes)); // query parameter
            if (nomePai != null) localVarQueryParams.Add("nomePai", Configuration.ApiClient.ParameterToString(nomePai)); // query parameter
            if (chequeEspecial != null) localVarQueryParams.Add("chequeEspecial", Configuration.ApiClient.ParameterToString(chequeEspecial)); // query parameter
            if (impedidoFinanciamento != null) localVarQueryParams.Add("impedidoFinanciamento", Configuration.ApiClient.ParameterToString(impedidoFinanciamento)); // query parameter
            if (numeroCnh != null) localVarQueryParams.Add("numeroCnh", Configuration.ApiClient.ParameterToString(numeroCnh)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Lista os Detalhes das Pessoas cadastradas no Emissor Este m\u00E9todo permite que sejam listadas od detalhes das Pessoas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa (optional)</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do Banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5esde cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <returns>Task of PagePessoaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<PagePessoaDetalheResponse> Listar_2Async (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null)
        {
             ApiResponse<PagePessoaDetalheResponse> localVarResponse = await Listar_2AsyncWithHttpInfo(sort, page, limit, idPessoa, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroBanco, numeroAgencia, numeroContaCorrente, email, nomeEmpresa, naturalidadeCidade, naturalidadeEstado, grauInstrucao, numeroDependentes, nomePai, chequeEspecial, impedidoFinanciamento, numeroCnh);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Detalhes das Pessoas cadastradas no Emissor Este m\u00E9todo permite que sejam listadas od detalhes das Pessoas existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo identificador da pessoa (optional)</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do Banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5esde cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePessoaDetalheResponse>> Listar_2AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (nomeMae != null) localVarQueryParams.Add("nomeMae", Configuration.ApiClient.ParameterToString(nomeMae)); // query parameter
            if (idEstadoCivil != null) localVarQueryParams.Add("idEstadoCivil", Configuration.ApiClient.ParameterToString(idEstadoCivil)); // query parameter
            if (idProfissao != null) localVarQueryParams.Add("idProfissao", Configuration.ApiClient.ParameterToString(idProfissao)); // query parameter
            if (idNaturezaOcupacao != null) localVarQueryParams.Add("idNaturezaOcupacao", Configuration.ApiClient.ParameterToString(idNaturezaOcupacao)); // query parameter
            if (idNacionalidade != null) localVarQueryParams.Add("idNacionalidade", Configuration.ApiClient.ParameterToString(idNacionalidade)); // query parameter
            if (numeroBanco != null) localVarQueryParams.Add("numeroBanco", Configuration.ApiClient.ParameterToString(numeroBanco)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroContaCorrente != null) localVarQueryParams.Add("numeroContaCorrente", Configuration.ApiClient.ParameterToString(numeroContaCorrente)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (nomeEmpresa != null) localVarQueryParams.Add("nomeEmpresa", Configuration.ApiClient.ParameterToString(nomeEmpresa)); // query parameter
            if (naturalidadeCidade != null) localVarQueryParams.Add("naturalidadeCidade", Configuration.ApiClient.ParameterToString(naturalidadeCidade)); // query parameter
            if (naturalidadeEstado != null) localVarQueryParams.Add("naturalidadeEstado", Configuration.ApiClient.ParameterToString(naturalidadeEstado)); // query parameter
            if (grauInstrucao != null) localVarQueryParams.Add("grauInstrucao", Configuration.ApiClient.ParameterToString(grauInstrucao)); // query parameter
            if (numeroDependentes != null) localVarQueryParams.Add("numeroDependentes", Configuration.ApiClient.ParameterToString(numeroDependentes)); // query parameter
            if (nomePai != null) localVarQueryParams.Add("nomePai", Configuration.ApiClient.ParameterToString(nomePai)); // query parameter
            if (chequeEspecial != null) localVarQueryParams.Add("chequeEspecial", Configuration.ApiClient.ParameterToString(chequeEspecial)); // query parameter
            if (impedidoFinanciamento != null) localVarQueryParams.Add("impedidoFinanciamento", Configuration.ApiClient.ParameterToString(impedidoFinanciamento)); // query parameter
            if (numeroCnh != null) localVarQueryParams.Add("numeroCnh", Configuration.ApiClient.ParameterToString(numeroCnh)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaDetalheResponse)));
            
        }
        
        /// <summary>
        /// Lista os Telefones cadastrados no Emissor Este m\u00E9todo permite que sejam listados os Telefones existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id) (optional)</param> 
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param> 
        /// <param name="ddd">Telefone DDD (optional)</param> 
        /// <param name="telefone">Telefone n\u00FAmero (optional)</param> 
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param> 
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param> 
        /// <returns>PageTelefoneResponse</returns>
        public PageTelefoneResponse Listar_3 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null)
        {
             ApiResponse<PageTelefoneResponse> localVarResponse = Listar_3WithHttpInfo(sort, page, limit, id, idTipoTelefone, idPessoa, ddd, telefone, ramal, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lista os Telefones cadastrados no Emissor Este m\u00E9todo permite que sejam listados os Telefones existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param> 
        /// <param name="page">P\u00E1gina (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param> 
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id) (optional)</param> 
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param> 
        /// <param name="ddd">Telefone DDD (optional)</param> 
        /// <param name="telefone">Telefone n\u00FAmero (optional)</param> 
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param> 
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param> 
        /// <returns>ApiResponse of PageTelefoneResponse</returns>
        public ApiResponse< PageTelefoneResponse > Listar_3WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling Listar_3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTelefoneResponse)));
            
        }

        
        /// <summary>
        /// Lista os Telefones cadastrados no Emissor Este m\u00E9todo permite que sejam listados os Telefones existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id) (optional)</param>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param>
        /// <param name="ddd">Telefone DDD (optional)</param>
        /// <param name="telefone">Telefone n\u00FAmero (optional)</param>
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <returns>Task of PageTelefoneResponse</returns>
        public async System.Threading.Tasks.Task<PageTelefoneResponse> Listar_3Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null)
        {
             ApiResponse<PageTelefoneResponse> localVarResponse = await Listar_3AsyncWithHttpInfo(sort, page, limit, id, idTipoTelefone, idPessoa, ddd, telefone, ramal, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lista os Telefones cadastrados no Emissor Este m\u00E9todo permite que sejam listados os Telefones existentes na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00E7\u00E3o dos registros (optional)</param>
        /// <param name="page">P\u00E1gina (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00E7\u00E3o (Default =50, Max =50) (optional)</param>
        /// <param name="id">C\u00F3digo de Identifica\u00E7\u00E3o do Telefone (id) (optional)</param>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param>
        /// <param name="ddd">Telefone DDD (optional)</param>
        /// <param name="telefone">Telefone n\u00FAmero (optional)</param>
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param>
        /// <param name="status">Apresenta o Status do Telefone, onde: &#39;0&#39;: Inativo e &#39;1&#39;: Ativo (optional)</param>
        /// <returns>Task of ApiResponse (PageTelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTelefoneResponse>> Listar_3AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null)
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling Listar_3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTelefoneResponse)));
            
        }
        
        /// <summary>
        /// Inclui a conta como registro para integra\u00E7\u00E3o Este recurso permite incluir uma conta como registro para integra\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">idConta</param> 
        /// <param name="body">IntegracaoEmissorPersist (optional)</param> 
        /// <returns>IntegracaoEmissorResponse</returns>
        public IntegracaoEmissorResponse Salvar (long? id, IntegracaoEmissorPersist body = null)
        {
             ApiResponse<IntegracaoEmissorResponse> localVarResponse = SalvarWithHttpInfo(id, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Inclui a conta como registro para integra\u00E7\u00E3o Este recurso permite incluir uma conta como registro para integra\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">idConta</param> 
        /// <param name="body">IntegracaoEmissorPersist (optional)</param> 
        /// <returns>ApiResponse of IntegracaoEmissorResponse</returns>
        public ApiResponse< IntegracaoEmissorResponse > SalvarWithHttpInfo (long? id, IntegracaoEmissorPersist body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->Salvar");
            
    
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
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<IntegracaoEmissorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegracaoEmissorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegracaoEmissorResponse)));
            
        }

        
        /// <summary>
        /// Inclui a conta como registro para integra\u00E7\u00E3o Este recurso permite incluir uma conta como registro para integra\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">idConta</param>
        /// <param name="body">IntegracaoEmissorPersist (optional)</param>
        /// <returns>Task of IntegracaoEmissorResponse</returns>
        public async System.Threading.Tasks.Task<IntegracaoEmissorResponse> SalvarAsync (long? id, IntegracaoEmissorPersist body = null)
        {
             ApiResponse<IntegracaoEmissorResponse> localVarResponse = await SalvarAsyncWithHttpInfo(id, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Inclui a conta como registro para integra\u00E7\u00E3o Este recurso permite incluir uma conta como registro para integra\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">idConta</param>
        /// <param name="body">IntegracaoEmissorPersist (optional)</param>
        /// <returns>Task of ApiResponse (IntegracaoEmissorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IntegracaoEmissorResponse>> SalvarAsyncWithHttpInfo (long? id, IntegracaoEmissorPersist body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Salvar");
            
    
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
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegracaoEmissorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegracaoEmissorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegracaoEmissorResponse)));
            
        }
        
        /// <summary>
        /// Cadastro de Conta e Pessoa Fisica Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa F\u00EDsica, recebendo nesta opera\u00E7\u00E3o todos os dados cadastrais que se fazem necess\u00E1rios para isso. Uma vez criado, poder\u00E1 ser acionado o m\u00E9todo de &#39;Gera\u00E7\u00E3o de Cart\u00E3o&#39; para o cliente e seus adicionais
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param> 
        /// <returns>ObjetoPessoaFsicaAprovadaResponse</returns>
        public ObjetoPessoaFsicaAprovadaResponse SalvarPessoaFisicaAprovada (ObjetoPessoaFsicaAprovada pessoaPersist)
        {
             ApiResponse<ObjetoPessoaFsicaAprovadaResponse> localVarResponse = SalvarPessoaFisicaAprovadaWithHttpInfo(pessoaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastro de Conta e Pessoa Fisica Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa F\u00EDsica, recebendo nesta opera\u00E7\u00E3o todos os dados cadastrais que se fazem necess\u00E1rios para isso. Uma vez criado, poder\u00E1 ser acionado o m\u00E9todo de &#39;Gera\u00E7\u00E3o de Cart\u00E3o&#39; para o cliente e seus adicionais
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param> 
        /// <returns>ApiResponse of ObjetoPessoaFsicaAprovadaResponse</returns>
        public ApiResponse< ObjetoPessoaFsicaAprovadaResponse > SalvarPessoaFisicaAprovadaWithHttpInfo (ObjetoPessoaFsicaAprovada pessoaPersist)
        {
            
            // verify the required parameter 'pessoaPersist' is set
            if (pessoaPersist == null)
                throw new ApiException(400, "Missing required parameter 'pessoaPersist' when calling CadastroClienteApi->SalvarPessoaFisicaAprovada");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaFisicaAprovada: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaFisicaAprovada: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ObjetoPessoaFsicaAprovadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ObjetoPessoaFsicaAprovadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ObjetoPessoaFsicaAprovadaResponse)));
            
        }

        
        /// <summary>
        /// Cadastro de Conta e Pessoa Fisica Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa F\u00EDsica, recebendo nesta opera\u00E7\u00E3o todos os dados cadastrais que se fazem necess\u00E1rios para isso. Uma vez criado, poder\u00E1 ser acionado o m\u00E9todo de &#39;Gera\u00E7\u00E3o de Cart\u00E3o&#39; para o cliente e seus adicionais
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of ObjetoPessoaFsicaAprovadaResponse</returns>
        public async System.Threading.Tasks.Task<ObjetoPessoaFsicaAprovadaResponse> SalvarPessoaFisicaAprovadaAsync (ObjetoPessoaFsicaAprovada pessoaPersist)
        {
             ApiResponse<ObjetoPessoaFsicaAprovadaResponse> localVarResponse = await SalvarPessoaFisicaAprovadaAsyncWithHttpInfo(pessoaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastro de Conta e Pessoa Fisica Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa F\u00EDsica, recebendo nesta opera\u00E7\u00E3o todos os dados cadastrais que se fazem necess\u00E1rios para isso. Uma vez criado, poder\u00E1 ser acionado o m\u00E9todo de &#39;Gera\u00E7\u00E3o de Cart\u00E3o&#39; para o cliente e seus adicionais
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of ApiResponse (ObjetoPessoaFsicaAprovadaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ObjetoPessoaFsicaAprovadaResponse>> SalvarPessoaFisicaAprovadaAsyncWithHttpInfo (ObjetoPessoaFsicaAprovada pessoaPersist)
        {
            // verify the required parameter 'pessoaPersist' is set
            if (pessoaPersist == null) throw new ApiException(400, "Missing required parameter 'pessoaPersist' when calling SalvarPessoaFisicaAprovada");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaFisicaAprovada: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaFisicaAprovada: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ObjetoPessoaFsicaAprovadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ObjetoPessoaFsicaAprovadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ObjetoPessoaFsicaAprovadaResponse)));
            
        }
        
        /// <summary>
        /// Cadastro de Conta e Pessoa Jur\u00EDdica Cadastro de Conta e Pessoa Jur\u00EDdica Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa Jur\u00EDdica, recebendo nesta opera\u00E7\u00E3o todos os dados cadastrais que se fazem necess\u00E1rios para isso, inclu\u00EDndo o registro de cada um dos s\u00F3cios. Uma vez criado, poder\u00E1 ser acionado o m\u00E9todo de &#39;Gera\u00E7\u00E3o de Cart\u00E3o&#39; para o cliente e cada um dos s\u00F3cios vinculados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param> 
        /// <returns>PessoaJuridicaAprovadaResponse</returns>
        public PessoaJuridicaAprovadaResponse SalvarPessoaJuridicaAprovada (PessoaJuridicaAprovadaPersist pessoaPersist)
        {
             ApiResponse<PessoaJuridicaAprovadaResponse> localVarResponse = SalvarPessoaJuridicaAprovadaWithHttpInfo(pessoaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastro de Conta e Pessoa Jur\u00EDdica Cadastro de Conta e Pessoa Jur\u00EDdica Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa Jur\u00EDdica, recebendo nesta opera\u00E7\u00E3o todos os dados cadastrais que se fazem necess\u00E1rios para isso, inclu\u00EDndo o registro de cada um dos s\u00F3cios. Uma vez criado, poder\u00E1 ser acionado o m\u00E9todo de &#39;Gera\u00E7\u00E3o de Cart\u00E3o&#39; para o cliente e cada um dos s\u00F3cios vinculados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param> 
        /// <returns>ApiResponse of PessoaJuridicaAprovadaResponse</returns>
        public ApiResponse< PessoaJuridicaAprovadaResponse > SalvarPessoaJuridicaAprovadaWithHttpInfo (PessoaJuridicaAprovadaPersist pessoaPersist)
        {
            
            // verify the required parameter 'pessoaPersist' is set
            if (pessoaPersist == null)
                throw new ApiException(400, "Missing required parameter 'pessoaPersist' when calling CadastroClienteApi->SalvarPessoaJuridicaAprovada");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaJuridicaAprovada: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaJuridicaAprovada: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaJuridicaAprovadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaAprovadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaAprovadaResponse)));
            
        }

        
        /// <summary>
        /// Cadastro de Conta e Pessoa Jur\u00EDdica Cadastro de Conta e Pessoa Jur\u00EDdica Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa Jur\u00EDdica, recebendo nesta opera\u00E7\u00E3o todos os dados cadastrais que se fazem necess\u00E1rios para isso, inclu\u00EDndo o registro de cada um dos s\u00F3cios. Uma vez criado, poder\u00E1 ser acionado o m\u00E9todo de &#39;Gera\u00E7\u00E3o de Cart\u00E3o&#39; para o cliente e cada um dos s\u00F3cios vinculados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of PessoaJuridicaAprovadaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaJuridicaAprovadaResponse> SalvarPessoaJuridicaAprovadaAsync (PessoaJuridicaAprovadaPersist pessoaPersist)
        {
             ApiResponse<PessoaJuridicaAprovadaResponse> localVarResponse = await SalvarPessoaJuridicaAprovadaAsyncWithHttpInfo(pessoaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastro de Conta e Pessoa Jur\u00EDdica Cadastro de Conta e Pessoa Jur\u00EDdica Permite realizar o cadastro de uma Conta para um cliente do tipo Pessoa Jur\u00EDdica, recebendo nesta opera\u00E7\u00E3o todos os dados cadastrais que se fazem necess\u00E1rios para isso, inclu\u00EDndo o registro de cada um dos s\u00F3cios. Uma vez criado, poder\u00E1 ser acionado o m\u00E9todo de &#39;Gera\u00E7\u00E3o de Cart\u00E3o&#39; para o cliente e cada um dos s\u00F3cios vinculados
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaAprovadaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaAprovadaResponse>> SalvarPessoaJuridicaAprovadaAsyncWithHttpInfo (PessoaJuridicaAprovadaPersist pessoaPersist)
        {
            // verify the required parameter 'pessoaPersist' is set
            if (pessoaPersist == null) throw new ApiException(400, "Missing required parameter 'pessoaPersist' when calling SalvarPessoaJuridicaAprovada");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaJuridicaAprovada: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaJuridicaAprovada: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaJuridicaAprovadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaAprovadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaAprovadaResponse)));
            
        }
        
        /// <summary>
        /// Inclui registro de integra\u00E7\u00E3o Este recurso permite incluir um registro de integra\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param> 
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param> 
        /// <returns>IntegracaoEmissorPropostaResponse</returns>
        public IntegracaoEmissorPropostaResponse SalvarRegistroIntegracaoManager (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist)
        {
             ApiResponse<IntegracaoEmissorPropostaResponse> localVarResponse = SalvarRegistroIntegracaoManagerWithHttpInfo(id, integracaoEmissorPropostaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Inclui registro de integra\u00E7\u00E3o Este recurso permite incluir um registro de integra\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param> 
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param> 
        /// <returns>ApiResponse of IntegracaoEmissorPropostaResponse</returns>
        public ApiResponse< IntegracaoEmissorPropostaResponse > SalvarRegistroIntegracaoManagerWithHttpInfo (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling CadastroClienteApi->SalvarRegistroIntegracaoManager");
            
            // verify the required parameter 'integracaoEmissorPropostaPersist' is set
            if (integracaoEmissorPropostaPersist == null)
                throw new ApiException(400, "Missing required parameter 'integracaoEmissorPropostaPersist' when calling CadastroClienteApi->SalvarRegistroIntegracaoManager");
            
    
            var localVarPath = "/api/contas/{id}/registros-integracao-manager";
    
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
            
            
            
            
            if (integracaoEmissorPropostaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(integracaoEmissorPropostaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = integracaoEmissorPropostaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarRegistroIntegracaoManager: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarRegistroIntegracaoManager: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<IntegracaoEmissorPropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegracaoEmissorPropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegracaoEmissorPropostaResponse)));
            
        }

        
        /// <summary>
        /// Inclui registro de integra\u00E7\u00E3o Este recurso permite incluir um registro de integra\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param>
        /// <returns>Task of IntegracaoEmissorPropostaResponse</returns>
        public async System.Threading.Tasks.Task<IntegracaoEmissorPropostaResponse> SalvarRegistroIntegracaoManagerAsync (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist)
        {
             ApiResponse<IntegracaoEmissorPropostaResponse> localVarResponse = await SalvarRegistroIntegracaoManagerAsyncWithHttpInfo(id, integracaoEmissorPropostaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Inclui registro de integra\u00E7\u00E3o Este recurso permite incluir um registro de integra\u00E7\u00E3o
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identificador da conta</param>
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param>
        /// <returns>Task of ApiResponse (IntegracaoEmissorPropostaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IntegracaoEmissorPropostaResponse>> SalvarRegistroIntegracaoManagerAsyncWithHttpInfo (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SalvarRegistroIntegracaoManager");
            // verify the required parameter 'integracaoEmissorPropostaPersist' is set
            if (integracaoEmissorPropostaPersist == null) throw new ApiException(400, "Missing required parameter 'integracaoEmissorPropostaPersist' when calling SalvarRegistroIntegracaoManager");
            
    
            var localVarPath = "/api/contas/{id}/registros-integracao-manager";
    
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
            
            
            
            
            if (integracaoEmissorPropostaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(integracaoEmissorPropostaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = integracaoEmissorPropostaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarRegistroIntegracaoManager: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarRegistroIntegracaoManager: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegracaoEmissorPropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegracaoEmissorPropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegracaoEmissorPropostaResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de um novo Endere\u00E7o Este m\u00E9todo permite que seja cadastrado um novo Endere\u00E7o na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param> 
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param> 
        /// <param name="cep">CEP do endere\u00E7o (optional)</param> 
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param> 
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param> 
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param> 
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param> 
        /// <param name="bairro">Apresenta nome do bairro (optional)</param> 
        /// <param name="cidade">Apresenta nome da cidade (optional)</param> 
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param> 
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param> 
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param> 
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param> 
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param> 
        /// <returns>EnderecoResponse</returns>
        public EnderecoResponse Salvar_0 (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null)
        {
             ApiResponse<EnderecoResponse> localVarResponse = Salvar_0WithHttpInfo(idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais, tempoResidenciaAnos, tempoResidenciaMeses, aplicativoAlteracao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de um novo Endere\u00E7o Este m\u00E9todo permite que seja cadastrado um novo Endere\u00E7o na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param> 
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param> 
        /// <param name="cep">CEP do endere\u00E7o (optional)</param> 
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param> 
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param> 
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param> 
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param> 
        /// <param name="bairro">Apresenta nome do bairro (optional)</param> 
        /// <param name="cidade">Apresenta nome da cidade (optional)</param> 
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param> 
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param> 
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param> 
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param> 
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param> 
        /// <returns>ApiResponse of EnderecoResponse</returns>
        public ApiResponse< EnderecoResponse > Salvar_0WithHttpInfo (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null)
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
            if (tempoResidenciaAnos != null) localVarQueryParams.Add("tempoResidenciaAnos", Configuration.ApiClient.ParameterToString(tempoResidenciaAnos)); // query parameter
            if (tempoResidenciaMeses != null) localVarQueryParams.Add("tempoResidenciaMeses", Configuration.ApiClient.ParameterToString(tempoResidenciaMeses)); // query parameter
            if (aplicativoAlteracao != null) localVarQueryParams.Add("aplicativoAlteracao", Configuration.ApiClient.ParameterToString(aplicativoAlteracao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de um novo Endere\u00E7o Este m\u00E9todo permite que seja cadastrado um novo Endere\u00E7o na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">CEP do endere\u00E7o (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <returns>Task of EnderecoResponse</returns>
        public async System.Threading.Tasks.Task<EnderecoResponse> Salvar_0Async (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null)
        {
             ApiResponse<EnderecoResponse> localVarResponse = await Salvar_0AsyncWithHttpInfo(idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais, tempoResidenciaAnos, tempoResidenciaMeses, aplicativoAlteracao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de um novo Endere\u00E7o Este m\u00E9todo permite que seja cadastrado um novo Endere\u00E7o na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa a qual o endere\u00E7o pertence (id) (optional)</param>
        /// <param name="idTipoEndereco">C\u00F3digo de Identifica\u00E7\u00E3o da Tipo Endere\u00E7o (id) (optional)</param>
        /// <param name="cep">CEP do endere\u00E7o (optional)</param>
        /// <param name="logradouro">Apresenta o nome do Logradouro (optional)</param>
        /// <param name="numero">Apresenta o n\u00FAmero do endere\u00E7o (optional)</param>
        /// <param name="complemento">Apresenta descri\u00E7oes complementares referente ao endere\u00E7o (optional)</param>
        /// <param name="pontoReferencia">Apresenta a descri\u00E7\u00E3o de ponto de refer\u00EAncia do endere\u00E7o (optional)</param>
        /// <param name="bairro">Apresenta nome do bairro (optional)</param>
        /// <param name="cidade">Apresenta nome da cidade (optional)</param>
        /// <param name="uf">Apresenta sigla da Unidade Federativa (optional)</param>
        /// <param name="pais">Apresenta nome do Pa\u00EDs (optional)</param>
        /// <param name="tempoResidenciaAnos">Apresenta a quantidade de anos em que habita na resid\u00EAncia (optional)</param>
        /// <param name="tempoResidenciaMeses">Apresenta a quantidade de meses que habita na resid\u00EAncia (optional)</param>
        /// <param name="aplicativoAlteracao">Apresenta a aplica\u00E7\u00E3o respons\u00E1vel por alterar o endere\u00E7o (optional)</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> Salvar_0AsyncWithHttpInfo (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null)
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
            if (tempoResidenciaAnos != null) localVarQueryParams.Add("tempoResidenciaAnos", Configuration.ApiClient.ParameterToString(tempoResidenciaAnos)); // query parameter
            if (tempoResidenciaMeses != null) localVarQueryParams.Add("tempoResidenciaMeses", Configuration.ApiClient.ParameterToString(tempoResidenciaMeses)); // query parameter
            if (aplicativoAlteracao != null) localVarQueryParams.Add("aplicativoAlteracao", Configuration.ApiClient.ParameterToString(aplicativoAlteracao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de um nova Pessoa Este m\u00E9todo permite que seja cadastrado uma nova Pessoa na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param> 
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param> 
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param> 
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param> 
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param> 
        /// <param name="sexo">Sexo da Pessoa (optional)</param> 
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param> 
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param> 
        /// <returns>PessoaResponse</returns>
        public PessoaResponse Salvar_1 (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
             ApiResponse<PessoaResponse> localVarResponse = Salvar_1WithHttpInfo(nome, tipo, dataNascimento, cpf, cnpj, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de um nova Pessoa Este m\u00E9todo permite que seja cadastrado uma nova Pessoa na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param> 
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param> 
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param> 
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param> 
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param> 
        /// <param name="sexo">Sexo da Pessoa (optional)</param> 
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param> 
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param> 
        /// <returns>ApiResponse of PessoaResponse</returns>
        public ApiResponse< PessoaResponse > Salvar_1WithHttpInfo (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
            
            // verify the required parameter 'nome' is set
            if (nome == null)
                throw new ApiException(400, "Missing required parameter 'nome' when calling CadastroClienteApi->Salvar_1");
            
            // verify the required parameter 'tipo' is set
            if (tipo == null)
                throw new ApiException(400, "Missing required parameter 'tipo' when calling CadastroClienteApi->Salvar_1");
            
            // verify the required parameter 'dataNascimento' is set
            if (dataNascimento == null)
                throw new ApiException(400, "Missing required parameter 'dataNascimento' when calling CadastroClienteApi->Salvar_1");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Salvar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de um nova Pessoa Este m\u00E9todo permite que seja cadastrado uma nova Pessoa na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param>
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param>
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param>
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param>
        /// <param name="sexo">Sexo da Pessoa (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param>
        /// <returns>Task of PessoaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaResponse> Salvar_1Async (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
             ApiResponse<PessoaResponse> localVarResponse = await Salvar_1AsyncWithHttpInfo(nome, tipo, dataNascimento, cpf, cnpj, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de um nova Pessoa Este m\u00E9todo permite que seja cadastrado uma nova Pessoa na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Apresenta o &#39;Nome Completo da PF&#39; ou o &#39;Nome Completo da Raz\u00E3o Social (Nome Empresarial)&#39;</param>
        /// <param name="tipo">Tipo de Pessoa (PF ou PJ)</param>
        /// <param name="dataNascimento">Data de Nascimento da Pessoa, quando PF, ou a Data de Abertura da Empresa, quando PJ. Essa data deve ser informada no formato aaaa-MM-dd</param>
        /// <param name="cpf">N\u00FAmero do CPF, quando PF (optional)</param>
        /// <param name="cnpj">N\u00FAmero do CNPJ, quando PJ (optional)</param>
        /// <param name="sexo">Sexo da Pessoa (optional)</param>
        /// <param name="numeroIdentidade">N\u00FAmero da Identidade (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Org\u00E3o expedidor do Identidade (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Sigla da Unidade Federativa de onde foi expedido a Identidade (optional)</param>
        /// <param name="dataEmissaoIdentidade">Data emiss\u00E3o da Identidade (optional)</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> Salvar_1AsyncWithHttpInfo (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
            // verify the required parameter 'nome' is set
            if (nome == null) throw new ApiException(400, "Missing required parameter 'nome' when calling Salvar_1");
            // verify the required parameter 'tipo' is set
            if (tipo == null) throw new ApiException(400, "Missing required parameter 'tipo' when calling Salvar_1");
            // verify the required parameter 'dataNascimento' is set
            if (dataNascimento == null) throw new ApiException(400, "Missing required parameter 'dataNascimento' when calling Salvar_1");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling Salvar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
        }
        
        /// <summary>
        /// Salvar os detalhes de uma determinada Pessoa Este m\u00E9todo permite que seja incluido na base do emissor os detalhes de uma determinada Pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Apresenta o c\u00F3digo identificador da pessoa</param> 
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param> 
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param> 
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param> 
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param> 
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param> 
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param> 
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param> 
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param> 
        /// <param name="email">Email da pessoa fisica (optional)</param> 
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param> 
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param> 
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param> 
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param> 
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param> 
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param> 
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param> 
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param> 
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param> 
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param> 
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param> 
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param> 
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param> 
        /// <returns>PessoaDetalheResponse</returns>
        public PessoaDetalheResponse Salvar_2 (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = Salvar_2WithHttpInfo(idPessoa, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroBanco, numeroAgencia, numeroContaCorrente, email, nomeEmpresa, nomeReferencia1, enderecoReferencia1, nomeReferencia2, enderecoReferencia2, naturalidadeCidade, naturalidadeEstado, grauInstrucao, numeroDependentes, nomePai, chequeEspecial, impedidoFinanciamento, numeroCnh);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Salvar os detalhes de uma determinada Pessoa Este m\u00E9todo permite que seja incluido na base do emissor os detalhes de uma determinada Pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Apresenta o c\u00F3digo identificador da pessoa</param> 
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param> 
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param> 
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param> 
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param> 
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param> 
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param> 
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param> 
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param> 
        /// <param name="email">Email da pessoa fisica (optional)</param> 
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param> 
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param> 
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param> 
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param> 
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param> 
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param> 
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param> 
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param> 
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param> 
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param> 
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param> 
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param> 
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param> 
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        public ApiResponse< PessoaDetalheResponse > Salvar_2WithHttpInfo (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null)
        {
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling CadastroClienteApi->Salvar_2");
            
    
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
            if (numeroBanco != null) localVarQueryParams.Add("numeroBanco", Configuration.ApiClient.ParameterToString(numeroBanco)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroContaCorrente != null) localVarQueryParams.Add("numeroContaCorrente", Configuration.ApiClient.ParameterToString(numeroContaCorrente)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (nomeEmpresa != null) localVarQueryParams.Add("nomeEmpresa", Configuration.ApiClient.ParameterToString(nomeEmpresa)); // query parameter
            if (nomeReferencia1 != null) localVarQueryParams.Add("nomeReferencia1", Configuration.ApiClient.ParameterToString(nomeReferencia1)); // query parameter
            if (enderecoReferencia1 != null) localVarQueryParams.Add("enderecoReferencia1", Configuration.ApiClient.ParameterToString(enderecoReferencia1)); // query parameter
            if (nomeReferencia2 != null) localVarQueryParams.Add("nomeReferencia2", Configuration.ApiClient.ParameterToString(nomeReferencia2)); // query parameter
            if (enderecoReferencia2 != null) localVarQueryParams.Add("enderecoReferencia2", Configuration.ApiClient.ParameterToString(enderecoReferencia2)); // query parameter
            if (naturalidadeCidade != null) localVarQueryParams.Add("naturalidadeCidade", Configuration.ApiClient.ParameterToString(naturalidadeCidade)); // query parameter
            if (naturalidadeEstado != null) localVarQueryParams.Add("naturalidadeEstado", Configuration.ApiClient.ParameterToString(naturalidadeEstado)); // query parameter
            if (grauInstrucao != null) localVarQueryParams.Add("grauInstrucao", Configuration.ApiClient.ParameterToString(grauInstrucao)); // query parameter
            if (numeroDependentes != null) localVarQueryParams.Add("numeroDependentes", Configuration.ApiClient.ParameterToString(numeroDependentes)); // query parameter
            if (nomePai != null) localVarQueryParams.Add("nomePai", Configuration.ApiClient.ParameterToString(nomePai)); // query parameter
            if (chequeEspecial != null) localVarQueryParams.Add("chequeEspecial", Configuration.ApiClient.ParameterToString(chequeEspecial)); // query parameter
            if (impedidoFinanciamento != null) localVarQueryParams.Add("impedidoFinanciamento", Configuration.ApiClient.ParameterToString(impedidoFinanciamento)); // query parameter
            if (numeroCnh != null) localVarQueryParams.Add("numeroCnh", Configuration.ApiClient.ParameterToString(numeroCnh)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Salvar os detalhes de uma determinada Pessoa Este m\u00E9todo permite que seja incluido na base do emissor os detalhes de uma determinada Pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Apresenta o c\u00F3digo identificador da pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param>
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param>
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param>
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<PessoaDetalheResponse> Salvar_2Async (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = await Salvar_2AsyncWithHttpInfo(idPessoa, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroBanco, numeroAgencia, numeroContaCorrente, email, nomeEmpresa, nomeReferencia1, enderecoReferencia1, nomeReferencia2, enderecoReferencia2, naturalidadeCidade, naturalidadeEstado, grauInstrucao, numeroDependentes, nomePai, chequeEspecial, impedidoFinanciamento, numeroCnh);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Salvar os detalhes de uma determinada Pessoa Este m\u00E9todo permite que seja incluido na base do emissor os detalhes de uma determinada Pessoa
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Apresenta o c\u00F3digo identificador da pessoa</param>
        /// <param name="nomeMae">Apresenta o nome da m\u00E3e da pessoa fisica (optional)</param>
        /// <param name="idEstadoCivil">Id Estado civil da pessoa fisica (optional)</param>
        /// <param name="idProfissao">Profiss\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Natureza Ocupa\u00E7\u00E3o da pessoa fisica (optional)</param>
        /// <param name="idNacionalidade">Id Nacionalidade da pessoa fisica (optional)</param>
        /// <param name="numeroBanco">N\u00FAmero do banco (optional)</param>
        /// <param name="numeroAgencia">N\u00FAmero da ag\u00EAncia (optional)</param>
        /// <param name="numeroContaCorrente">N\u00FAmero da conta corrente (optional)</param>
        /// <param name="email">Email da pessoa fisica (optional)</param>
        /// <param name="nomeEmpresa">Nome que deve ser impresso no cart\u00E3o (optional)</param>
        /// <param name="nomeReferencia1">Nome de refer\u00EAncia 1 (optional)</param>
        /// <param name="enderecoReferencia1">Endere\u00E7o de refer\u00EAncia 1 (optional)</param>
        /// <param name="nomeReferencia2">Nome de refer\u00EAncia 2 (optional)</param>
        /// <param name="enderecoReferencia2">Endere\u00E7o de refer\u00EAncia 2 (optional)</param>
        /// <param name="naturalidadeCidade">Apresenta o nome da cidade de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="naturalidadeEstado">Apresenta a sigla do estado de nascimento da pessoa f\u00EDsica (optional)</param>
        /// <param name="grauInstrucao">Apresenta o grau de instru\u00E7\u00E3o da pessoa f\u00EDsica (optional)</param>
        /// <param name="numeroDependentes">Apresenta o n\u00FAmero de dependentes da pessoa f\u00EDsica (optional)</param>
        /// <param name="nomePai">Apresenta o nome do pai da pessoa f\u00EDsica (optional)</param>
        /// <param name="chequeEspecial">Indica se pessoa f\u00EDsica aderir ao cheque especial (optional)</param>
        /// <param name="impedidoFinanciamento">Flag para s\u00F3cios do banco que s\u00E3o portadores do cart\u00E3o, mas n\u00E3o podem operar transa\u00E7\u00F5es de cr\u00E9dito(Lei n. 4.595/64) (optional)</param>
        /// <param name="numeroCnh">N\u00FAmero da CNH da pessoa (optional)</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> Salvar_2AsyncWithHttpInfo (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null, string numeroCnh = null)
        {
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling Salvar_2");
            
    
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
            if (numeroBanco != null) localVarQueryParams.Add("numeroBanco", Configuration.ApiClient.ParameterToString(numeroBanco)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroContaCorrente != null) localVarQueryParams.Add("numeroContaCorrente", Configuration.ApiClient.ParameterToString(numeroContaCorrente)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (nomeEmpresa != null) localVarQueryParams.Add("nomeEmpresa", Configuration.ApiClient.ParameterToString(nomeEmpresa)); // query parameter
            if (nomeReferencia1 != null) localVarQueryParams.Add("nomeReferencia1", Configuration.ApiClient.ParameterToString(nomeReferencia1)); // query parameter
            if (enderecoReferencia1 != null) localVarQueryParams.Add("enderecoReferencia1", Configuration.ApiClient.ParameterToString(enderecoReferencia1)); // query parameter
            if (nomeReferencia2 != null) localVarQueryParams.Add("nomeReferencia2", Configuration.ApiClient.ParameterToString(nomeReferencia2)); // query parameter
            if (enderecoReferencia2 != null) localVarQueryParams.Add("enderecoReferencia2", Configuration.ApiClient.ParameterToString(enderecoReferencia2)); // query parameter
            if (naturalidadeCidade != null) localVarQueryParams.Add("naturalidadeCidade", Configuration.ApiClient.ParameterToString(naturalidadeCidade)); // query parameter
            if (naturalidadeEstado != null) localVarQueryParams.Add("naturalidadeEstado", Configuration.ApiClient.ParameterToString(naturalidadeEstado)); // query parameter
            if (grauInstrucao != null) localVarQueryParams.Add("grauInstrucao", Configuration.ApiClient.ParameterToString(grauInstrucao)); // query parameter
            if (numeroDependentes != null) localVarQueryParams.Add("numeroDependentes", Configuration.ApiClient.ParameterToString(numeroDependentes)); // query parameter
            if (nomePai != null) localVarQueryParams.Add("nomePai", Configuration.ApiClient.ParameterToString(nomePai)); // query parameter
            if (chequeEspecial != null) localVarQueryParams.Add("chequeEspecial", Configuration.ApiClient.ParameterToString(chequeEspecial)); // query parameter
            if (impedidoFinanciamento != null) localVarQueryParams.Add("impedidoFinanciamento", Configuration.ApiClient.ParameterToString(impedidoFinanciamento)); // query parameter
            if (numeroCnh != null) localVarQueryParams.Add("numeroCnh", Configuration.ApiClient.ParameterToString(numeroCnh)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de um novo Telefone Este m\u00E9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param> 
        /// <param name="ddd">C\u00F3digo DDD do telefone (id) (optional)</param> 
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param> 
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param> 
        /// <returns>TelefoneResponse</returns>
        public TelefoneResponse Salvar_3 (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null)
        {
             ApiResponse<TelefoneResponse> localVarResponse = Salvar_3WithHttpInfo(idTipoTelefone, idPessoa, ddd, telefone, ramal);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de um novo Telefone Este m\u00E9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param> 
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param> 
        /// <param name="ddd">C\u00F3digo DDD do telefone (id) (optional)</param> 
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param> 
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param> 
        /// <returns>ApiResponse of TelefoneResponse</returns>
        public ApiResponse< TelefoneResponse > Salvar_3WithHttpInfo (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null)
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
                throw new ApiException (localVarStatusCode, "Error calling Salvar_3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de um novo Telefone Este m\u00E9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param>
        /// <param name="ddd">C\u00F3digo DDD do telefone (id) (optional)</param>
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param>
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param>
        /// <returns>Task of TelefoneResponse</returns>
        public async System.Threading.Tasks.Task<TelefoneResponse> Salvar_3Async (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null)
        {
             ApiResponse<TelefoneResponse> localVarResponse = await Salvar_3AsyncWithHttpInfo(idTipoTelefone, idPessoa, ddd, telefone, ramal);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de um novo Telefone Este m\u00E9todo permite que seja cadastrado um novo Telefone na base de dados do Emissor
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">C\u00F3digo de Identifica\u00E7\u00E3o do Tipo do Telefone (id) (optional)</param>
        /// <param name="idPessoa">C\u00F3digo de Identifica\u00E7\u00E3o da Pessoa (id) a qual o telefone pertence (optional)</param>
        /// <param name="ddd">C\u00F3digo DDD do telefone (id) (optional)</param>
        /// <param name="telefone">N\u00FAmero do telefone (optional)</param>
        /// <param name="ramal">N\u00FAmero do ramal (optional)</param>
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> Salvar_3AsyncWithHttpInfo (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null)
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
                throw new ApiException (localVarStatusCode, "Error calling Salvar_3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
        }
        
    }
    
}
