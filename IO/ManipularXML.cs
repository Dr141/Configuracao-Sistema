using Configuracao.Modelos;
using Engegraph.Comum.Utilitarios.Seguranca;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Configuracao.IO
{
    public class ManipularXML
    {
        public string caminhoArquivo { get; set; }
        public string _stringConexao { get; set; }

        public void GravarDados(Provimento88 oP88)
        {
            string nomeArquivo = @"Configuracoes.config";

            try
            {
                XElement XML = XElement.Load(nomeArquivo);
                XML.Descendants("ConexaoBanco").First().LastAttribute.Value = XAesSimples.Criptografar(oP88.ConexaoBanco);
                XML.Descendants("UsuarioBanco").First().LastAttribute.Value = XAesSimples.Criptografar(oP88.UsuarioBanco);
                XML.Descendants("SenhaBanco").First().LastAttribute.Value = XAesSimples.Criptografar(oP88.SenhaBanco);
                XML.Descendants("UrlDeComunicacao").First().LastAttribute.Value = XAesSimples.Criptografar(oP88.UrlDeComunicacao);
                XML.Descendants("UsuarioSisCoaf").First().LastAttribute.Value = XAesSimples.Criptografar(oP88.UsuarioSisCoaf);
                XML.Descendants("SenhaSisCoaf").First().LastAttribute.Value = XAesSimples.Criptografar(oP88.SenhaSisCoaf);
                XML.Descendants("TipoDeConexao").First().LastAttribute.Value = XAesSimples.Criptografar(oP88.TipoDeConexao);
                XML.Descendants("AmbienteAtualizacao").First().LastAttribute.Value = XAesSimples.Criptografar(oP88.AmbienteAtualizacao);
                XML.Descendants("EnderecoServico").First().LastAttribute.Value = XAesSimples.Criptografar(oP88.EnderecoSevico);
                XML.Save(nomeArquivo);
                MessageBox.Show("Configuração salva com sucesso.", "Provimento88", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GravarDados(Launcher launcher)
        {
            string nomeArquivo = @"Configuracoes.config";

            try
            {
                XElement XML = XElement.Load(nomeArquivo);
                XML.Descendants("SqlHost").First().LastAttribute.Value = XAesSimples.Criptografar(launcher.SqlHost);
                XML.Descendants("SqlDatabase").First().LastAttribute.Value = XAesSimples.Criptografar(launcher.SqlDatabase);
                XML.Descendants("Usuario").First().LastAttribute.Value = XAesSimples.Criptografar(launcher.Usuario);
                XML.Descendants("Senha").First().LastAttribute.Value = XAesSimples.Criptografar(launcher.Senha);
                XML.Descendants("TipoSgbd").First().LastAttribute.Value = XAesSimples.Criptografar(launcher.TipoSgbd);
                XML.Descendants("AmbienteAtualizacao").First().LastAttribute.Value = XAesSimples.Criptografar(launcher.AmbienteAtualizacao);
                XML.Save(nomeArquivo);
                MessageBox.Show("Configuração salva com sucesso.", "Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GravarDados(CIP cip)
        {
            string nomeArquivo = @"Configuracoes.config";

            try
            {
                XElement XML = XElement.Load(nomeArquivo);

                XML.Descendants("AmbienteDeAtualizacao").First().LastAttribute.Value = XAesSimples.Criptografar(cip.AmbienteDeAtualizacao);
                XML.Descendants("SqlHost").First().LastAttribute.Value = XAesSimples.Criptografar(cip.SqlHost);
                XML.Descendants("SqlDataBase").First().LastAttribute.Value = XAesSimples.Criptografar(cip.SqlDataBase);
                XML.Descendants("Usuario").First().LastAttribute.Value = XAesSimples.Criptografar(cip.Usuario);
                XML.Descendants("Senha").First().LastAttribute.Value = XAesSimples.Criptografar(cip.Senha);

                MessageBox.Show("Configuração salva com sucesso.", "CIP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GravarDados(SEDI_GO SEDI)
        {
            string nomeArquivo = @"SeloDigital.GO.Servico.dll.config";

            try
            {
                ExeConfigurationFileMap customConfigFileMap = new ExeConfigurationFileMap();
                customConfigFileMap.ExeConfigFilename = nomeArquivo;
                Configuration customConfig = ConfigurationManager.OpenMappedExeConfiguration(customConfigFileMap, ConfigurationUserLevel.None);
                AppSettingsSection appSettings = (customConfig.GetSection("appSettings") as AppSettingsSection);

                appSettings.Settings["ConexaoBanco"].Value = CriptografiaEng.Criptografar(SEDI.ConexaoBanco);
                appSettings.Settings["AmbienteAtualizacao"].Value = CriptografiaEng.Criptografar(SEDI.AmbienteAtualizacao);
                appSettings.Settings["HashDoCartorio"].Value = CriptografiaEng.Criptografar(SEDI.HashDoCartorio);
                appSettings.Settings["UsuarioBanco"].Value = CriptografiaEng.Criptografar(SEDI.UsuarioBanco);
                appSettings.Settings["SenhaBanco"].Value = CriptografiaEng.Criptografar(SEDI.SenhaBanco);
                appSettings.Settings["TipoDeConexao"].Value = CriptografiaEng.Criptografar(SEDI.TipoDeConexao);
                appSettings.Settings["DesabilitarGeracaoDeSelos"].Value = CriptografiaEng.Criptografar(SEDI.DesabilitarGeracaoDeSelos);
                appSettings.Settings["AmbienteProducao"].Value = CriptografiaEng.Criptografar(SEDI.AmbienteProducao);
                appSettings.Settings["Token"].Value = CriptografiaEng.Criptografar(SEDI.Token);
                appSettings.Settings["CodigoCartorio"].Value = CriptografiaEng.Criptografar(SEDI.CodigoCartorio);
                appSettings.Settings["ChaveSegurancaCartorio"].Value = CriptografiaEng.Criptografar(SEDI.ChaveSegurancaCartorio);

                customConfig.Save();

                MessageBox.Show("Configuração salva com sucesso.", "SEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GravarDados(DADP dadp)
        {
            string nomeArquivo = @"Dadp.Servidor.dll.config";

            try
            {
                ExeConfigurationFileMap customConfigFileMap = new ExeConfigurationFileMap();
                customConfigFileMap.ExeConfigFilename = nomeArquivo;
                Configuration customConfig = ConfigurationManager.OpenMappedExeConfiguration(customConfigFileMap, ConfigurationUserLevel.None);
                AppSettingsSection appSettings = (customConfig.GetSection("appSettings") as AppSettingsSection);

                appSettings.Settings["ConexaoBanco"].Value = CriptografiaEng.Criptografar(dadp.ConexaoBanco);
                //appSettings.Settings["AmbienteAtualizacao"].Value = CriptografiaEng.Criptografar(SEDI.AmbienteAtualizacao);
                appSettings.Settings["Porta"].Value = CriptografiaEng.Criptografar(dadp.Porta);
                appSettings.Settings["UsuarioBanco"].Value = CriptografiaEng.Criptografar(dadp.UsuarioBanco);
                appSettings.Settings["SenhaBanco"].Value = CriptografiaEng.Criptografar(dadp.SenhaBanco);
                appSettings.Settings["TipoDeConexao"].Value = CriptografiaEng.Criptografar(dadp.TipoDeConexao);
                appSettings.Settings["NomeCartorio"].Value = CriptografiaEng.Criptografar(dadp.NomeCartorio);
                appSettings.Settings["NomeOficial"].Value = CriptografiaEng.Criptografar(dadp.NomeOficial);
                appSettings.Settings["Cidade"].Value = CriptografiaEng.Criptografar(dadp.Cidade);
                appSettings.Settings["Uf"].Value = CriptografiaEng.Criptografar(dadp.Uf);
                appSettings.Settings["TituloRelatorioAuxiliar"].Value = CriptografiaEng.Criptografar(dadp.TituloRelatorioAuxiliar);
                appSettings.Settings["TituloRelatorioPrevio"].Value = CriptografiaEng.Criptografar(dadp.TituloRelatorioPrevio);
                appSettings.Settings["CodNacional"].Value = CriptografiaEng.Criptografar(dadp.CodNacional);

                customConfig.Save();

                MessageBox.Show("Configuração salva com sucesso.", "SEDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GetDados(Provimento88 p88)
        {
            string nomeArquivo = @"Configuracoes.config";

            try
            {
                XElement XML = XElement.Load(nomeArquivo);

                p88.ConexaoBanco = XAesSimples.Decriptografar(XML.Descendants("ConexaoBanco").First().LastAttribute.Value);
                p88.UsuarioBanco = XAesSimples.Decriptografar(XML.Descendants("UsuarioBanco").First().LastAttribute.Value);
                p88.SenhaBanco = XAesSimples.Decriptografar(XML.Descendants("SenhaBanco").First().LastAttribute.Value);
                p88.UrlDeComunicacao = XAesSimples.Decriptografar(XML.Descendants("UrlDeComunicacao").First().LastAttribute.Value);
                p88.UsuarioSisCoaf = XAesSimples.Decriptografar(XML.Descendants("UsuarioSisCoaf").First().LastAttribute.Value);
                p88.SenhaSisCoaf = XAesSimples.Decriptografar(XML.Descendants("SenhaSisCoaf").First().LastAttribute.Value);
                p88.TipoDeConexao = XAesSimples.Decriptografar(XML.Descendants("TipoDeConexao").First().LastAttribute.Value);
                p88.AmbienteAtualizacao = XAesSimples.Decriptografar(XML.Descendants("AmbienteAtualizacao").First().LastAttribute.Value);
                p88.EnderecoSevico = XAesSimples.Decriptografar(XML.Descendants("EnderecoServico").First().LastAttribute.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void GetDados(Launcher launcher)
        {
            string nomeArquivo = @"Configuracoes.config";

            try
            {
                XElement XML = XElement.Load(nomeArquivo);

                launcher.SqlHost = XAesSimples.Decriptografar(XML.Descendants("SqlHost").First().LastAttribute.Value);
                launcher.Usuario = XAesSimples.Decriptografar(XML.Descendants("Usuario").First().LastAttribute.Value);
                launcher.Senha = XAesSimples.Decriptografar(XML.Descendants("Senha").First().LastAttribute.Value);
                launcher.TipoSgbd = XAesSimples.Decriptografar(XML.Descendants("TipoSgbd").First().LastAttribute.Value);
                launcher.AmbienteAtualizacao = XAesSimples.Decriptografar(XML.Descendants("AmbienteAtualizacao").First().LastAttribute.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void GetDados(CIP cip)
        {
            string nomeArquivo = @"Configuracoes.config";

            try
            {
                XElement XML = XElement.Load(nomeArquivo);

                cip.AmbienteDeAtualizacao = XAesSimples.Decriptografar(XML.Descendants("AmbienteDeAtualizacao").First().LastAttribute.Value);
                cip.SqlHost = XAesSimples.Decriptografar(XML.Descendants("SqlHost").First().LastAttribute.Value);
                cip.SqlDataBase = XAesSimples.Decriptografar(XML.Descendants("SqlDataBase").First().LastAttribute.Value);
                cip.Usuario = XAesSimples.Decriptografar(XML.Descendants("Usuario").First().LastAttribute.Value);
                cip.Senha = XAesSimples.Decriptografar(XML.Descendants("Senha").First().LastAttribute.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void GetDados(SEDI_GO SEDI)
        {
            string nomeArquivo = @"SeloDigital.GO.Servico.dll.config";

            try
            {
                ExeConfigurationFileMap customConfigFileMap = new ExeConfigurationFileMap();
                customConfigFileMap.ExeConfigFilename = nomeArquivo;
                Configuration customConfig = ConfigurationManager.OpenMappedExeConfiguration(customConfigFileMap, ConfigurationUserLevel.None);
                AppSettingsSection appSettings = (customConfig.GetSection("appSettings") as AppSettingsSection);
                string url = appSettings.Settings["ConexaoBanco"].Value;

                SEDI.ConexaoBanco = CriptografiaEng.Descriptografar(appSettings.Settings["ConexaoBanco"].Value);
                SEDI.AmbienteAtualizacao = CriptografiaEng.Descriptografar(appSettings.Settings["AmbienteAtualizacao"].Value);
                SEDI.HashDoCartorio = CriptografiaEng.Descriptografar(appSettings.Settings["HashDoCartorio"].Value);
                SEDI.UsuarioBanco = CriptografiaEng.Descriptografar(appSettings.Settings["UsuarioBanco"].Value);
                SEDI.SenhaBanco = CriptografiaEng.Descriptografar(appSettings.Settings["SenhaBanco"].Value);
                SEDI.TipoDeConexao = CriptografiaEng.Descriptografar(appSettings.Settings["TipoDeConexao"].Value);
                SEDI.DesabilitarGeracaoDeSelos = CriptografiaEng.Descriptografar(appSettings.Settings["DesabilitarGeracaoDeSelos"].Value);
                SEDI.AmbienteProducao = CriptografiaEng.Descriptografar(appSettings.Settings["AmbienteProducao"].Value);
                SEDI.Token = CriptografiaEng.Descriptografar(appSettings.Settings["Token"].Value);
                SEDI.CodigoCartorio = CriptografiaEng.Descriptografar(appSettings.Settings["CodigoCartorio"].Value);
                SEDI.ChaveSegurancaCartorio = CriptografiaEng.Descriptografar(appSettings.Settings["ChaveSegurancaCartorio"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void GetDados(DADP dadp)
        {
            string nomeArquivo = @"Dadp.Servidor.dll.config";

            try
            {
                ExeConfigurationFileMap customConfigFileMap = new ExeConfigurationFileMap();
                customConfigFileMap.ExeConfigFilename = nomeArquivo;
                Configuration customConfig = ConfigurationManager.OpenMappedExeConfiguration(customConfigFileMap, ConfigurationUserLevel.None);
                AppSettingsSection appSettings = (customConfig.GetSection("appSettings") as AppSettingsSection);

                dadp.ConexaoBanco = CriptografiaEng.Descriptografar(appSettings.Settings["ConexaoBanco"].Value);
                //dadp.AmbienteAtualizacao = CriptografiaEng.Descriptografar(appSettings.Settings["AmbienteAtualizacao"].Value);
                dadp.Porta = CriptografiaEng.Descriptografar(appSettings.Settings["Porta"].Value);
                dadp.UsuarioBanco = CriptografiaEng.Descriptografar(appSettings.Settings["UsuarioBanco"].Value);
                dadp.SenhaBanco = CriptografiaEng.Descriptografar(appSettings.Settings["SenhaBanco"].Value);
                dadp.TipoDeConexao = CriptografiaEng.Descriptografar(appSettings.Settings["TipoDeConexao"].Value);
                dadp.NomeCartorio = CriptografiaEng.Descriptografar(appSettings.Settings["NomeCartorio"].Value);
                dadp.NomeOficial = CriptografiaEng.Descriptografar(appSettings.Settings["NomeOficial"].Value);
                dadp.Cidade = CriptografiaEng.Descriptografar(appSettings.Settings["Cidade"].Value);
                dadp.Uf = CriptografiaEng.Descriptografar(appSettings.Settings["Uf"].Value);
                dadp.TituloRelatorioAuxiliar = CriptografiaEng.Descriptografar(appSettings.Settings["TituloRelatorioAuxiliar"].Value);
                dadp.TituloRelatorioPrevio = CriptografiaEng.Descriptografar(appSettings.Settings["TituloRelatorioPrevio"].Value);
                dadp.CodNacional = CriptografiaEng.Descriptografar(appSettings.Settings["CodNacional"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public int AmbAtualizacao(string amb)
        {
            switch (amb)
            {
                case "PREVIEW":
                    {
                        return 0;
                    }
                case "PRODUCAO":
                    {
                        return 1;
                    }
                case "TESTES":
                    {
                        return 2;
                    }
                default:
                    {
                        return 1;
                    }
            }
        }        
    }
}
