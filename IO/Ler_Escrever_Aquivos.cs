using Configuracao.Modelos;
using Engegraph.Comum.Utilitarios.Seguranca;
using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Configuracao.IO
{
    public class Ler_Escrever_Aquivos
    {
        public string caminhoArquivo { get; set; }
        public string _stringConexao { get; set; }
        System.IO.StreamReader file { get; set; }


        public string ObterCaminho()
        {
          return AppDomain.CurrentDomain.BaseDirectory;
        }

        public void GravarDados(Provimento88 oP88)
        {
            string nomeArquivo = @"Configuracoes.config";
            
            this.CriarArquivo(nomeArquivo,0);                
            
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
                MessageBox.Show("Configuração salva com sucesso.", "Provimento88",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                   
        }

        public void GravarDados(Launcher launcher)
        {
            string nomeArquivo = @"Configuracoes.config";

            this.CriarArquivo(nomeArquivo, 0);

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

            this.CriarArquivo(nomeArquivo, 1);

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

            this.CriarArquivo(nomeArquivo, 2);

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

            this.CriarArquivo(nomeArquivo, 3);

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

            this.CriarArquivo(nomeArquivo, 0);

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void GetDados(Launcher launcher)
        {
            string nomeArquivo = @"Configuracoes.config";

            this.CriarArquivo(nomeArquivo, 4);

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

            this.CriarArquivo(nomeArquivo, 1);

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

            this.CriarArquivo(nomeArquivo, 2);

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

            this.CriarArquivo(nomeArquivo, 3);

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

        public int DesabilitarGeracaoDeSelos(string aux)
        {
            switch (aux)
            {
                case "Sim":
                    return 0;
                case "Não":
                    return 1;
                default:
                    return 0;
            }
        }


        public void CriarArquivo(string nomeArquivo, int index)
        {
            if (!File.Exists(nomeArquivo))
            {
                try
                {
                    XmlDocument xml = new XmlDocument();

                    switch (index)
                    {
                        case 0:
                            xml.LoadXml(
                                "<?xml version='1.0' encoding='utf-8'?>" +
                                "<configuration>" +
                                "<Provimento88>" +
                                "<ConexaoBanco value='/rOcFv/RPjvWjuvCpz9A1N9Y+t45t29syOoY28LSehusqC204npkZwVVLBqjxHaiYhWuvmXFsIShEluzn/S4Qv9nVL8jx7MlJYhVAK6IEZt6b+kaYqHfHF85duWkPRm8BOHPj9k7IqydL49eBhZZMA=='/>" +
                                "<UsuarioBanco value='qlnJtATz1lkO/eov7ZEuOLqBsLyfAHiFiVf4RM8d6bE3yag2A4tWpiDF1EYqYhlBomM/Aw5qWmFjyqtUd6+9cGhT7BI5CTda/Tpg09KrR1I='/>" +
                                "<SenhaBanco value='k1kYm6dGN6pgzcsgfK4aVHK4emkOpac+7kuV8BzCEByUW9yAIPmwPvZmWqGLgOWWOxjRwC5Sfs5WAvv3oedwWmtGnpc5873imbrjGgVE+Bg='/>" +
                                "<UrlDeComunicacao value='84o0Ts5cf3dG/5sjZWk10DOE0qSA18tcM3DgdRiD8VPuAgM66IFVIdaVlz24MgkmE58E996vOlTTlW02kZhGkha9kD1fGoG0OhdykMO77AJzmCDI4x0VSehBbGF4hxXU5HEfAzo17NLaMlKYLkCDruiCK1wlBTZ/GmTlJfEFjhY/oW8mdDPqU/KSB2ji+Bav'/>" +
                                "<UsuarioSisCoaf value='JvCFe3m36h3mNGgH1duWj+gurhAR95RP+sJhWZGLDWgbrxls211cOeN+ibNGQwxTbNNuE7dbqB8w5jc6Bhcwva5qw5sxNY81lWN9xG5AXM4='/>" +
                                "<SenhaSisCoaf value='9izUnsRkGgTl/cMTZ6HCGXIokSs0+MXKWgvoRb60gPQN9QRIUiETCnkwcsUbabezmHC4gGhayXprSWGLkxIOIBMwgCq4XJQUGTOaYLHppkAbTWUPjb6rMWebuV50jSUK'/>" +
                                "<TipoDeConexao value ='AlBeCY+alcC2/zMpgo4I7beSIxn1jGqKnZCM2nOJceUairjMwcql3vv7YaF0BuB3G0BYljtBoZ0lzY0RtszYeiVFUnLmMkUdQEY8Xl3Njow='/>" +
                                "<AmbienteAtualizacao value='qxU2PeuA24FE5q5UouUWJU+CrrplVLLi4N3o4ORItMTy9Dt9JiCJ+ME6QYIw6eom9AWnJoCpaEpY/UGMUxIh1YamgELzhVpHMQQWT9bvM4E=' />" +
                                "<!--CIP-->" +
                                "<EnderecoServico value='TAh0mUrUea8o4Yug3xkR8+gyVbBt0tNnVG256z3w3BFZAEU6drGwIIpZBZMxF/O0ltzSoQq+xne4mhupvZKHUPPVx3KDQAw6glyjnN15Z2Q='/>" +
                                "</Provimento88>" +
                                "</configuration>"
                            );
                            break;
                        case 1:
                            xml.LoadXml(
                                "<?xml version ='1.0' encoding ='utf-8'?>" +
                                "<configuration>" +
                                "<CIP>" + 
                                "<SqlHost value='THItc9T2SODvEVB/qPRrp6cT5QgTEHCipYlRLUl4wQChqgg1ZfY8bmJNYnWVDKTQF/xBVt64uGZGOt7RYQIUcRLbfcQWlpKShFo2+YwRUJU='/>" +
                                "<SqlDataBase value='lfGTNbjRZsOlS6UPYBJJxkExUR3oI0HpXoMhVX/zF7u1tDlf8InekQZMVJuBqTipItyRj8Eypl8wPsOm0rXkAJf0hZRojWe/wnJ2vXUcgy/fkmIFNJiYjNkhTPMLV9ZD'/>" +
                                "<Usuario value='jR5f8qceUFir2BQoR+fdGP1R2f4hI8b6no/C0NReFfFKJgMMg7VvE77EwfjEyyhV69sHZX+WTrbRYltydYRaUGYY/E3fNIkDv8xWB4Fi+uQ='/>" +
                                "<Senha value='c51epNf9AcXuXLWr2jwBRCXXP087sCbQSb3QTHXHIVEXvSMDSbVpOBKbcWUnEAdqnrPkN1pomBttCLSqrjtJyP1NR31B2PM7/Pl4/bY2SIk='/>" +
                                "<AmbienteDeAtualizacao value='qxU2PeuA24FE5q5UouUWJU+CrrplVLLi4N3o4ORItMTy9Dt9JiCJ+ME6QYIw6eom9AWnJoCpaEpY/UGMUxIh1YamgELzhVpHMQQWT9bvM4E='/>" +
                                "</CIP>" +
                                "</configuration>"
                            );
                            break;
                        case 2:
                            xml.LoadXml(
                                "<?xml version ='1.0' encoding ='utf-8'?>" +
                                 "<configuration>"  +
                                 "<appSettings>"    +
                                 "<add key='ConexaoBanco' value='293239361D23363A4D19091E0C3F00E230485153B1594EA4BFBF4D51F0F4F4F30BD8'/>" +
                                 "<add key='UsuarioBanco' value='0E050717350A140735'/>" +
                                 "<add key='SenhaBanco' value='0E050717350A1407350A1F3B'/>" +
                                 "<add key='Token' value='2B1B0C143605380B3D382D313A2D1A'/>" +
                                 "<add key='CodigoCartorio' value=''/>" +
                                 "<add key='ChaveSegurancaCartorio' value=''/>" +
                                 "<add key='HashDoCartorio' value='5E4303563459165D164843190D6841B24C470649B94E1BBABCE9440DE1F7E3B35DBEE9B0EAA8A5F9'/>" +
                                 "<add key='AmbienteProducao' value='56'/>" +
                                 "<add key='TipoDeConexao' value='57'/>" +
                                 "<add key='DesabilitarGeracaoDeSelos' value='099628'/>" +
                                 "<add key='AmbienteAtualizacao' value='2934253016202139' />" +
                                 "</appSettings>"   +
                                 "</configuration>"
                                );
                            break;
                        case 3:
                            xml.LoadXml(
                                "<?xml version ='1.0' encoding ='utf-8'?>" +
                                 "<configuration>" +
                                 "<appSettings>" +
                                 "<add key='ConexaoBanco' value='293239361D23363A4D19091E0C3F00E230485153B1594EA4BFBF4D51F0F4F4F30BD8'/>" +
                                 "<add key='UsuarioBanco' value='0E050717350A140735'/>" +
                                 "<add key='SenhaBanco' value='0E050717350A1407350A1F3B'/>" +
                                 "<add key='Porta' value=''/>" +
                                 "<add key='NomeCartorio' value=''/>" +
                                 "<add key='CodigoCliente' value=''/>" +
                                 "<add key='Cidade' value=''/>" +
                                 "<add key='Uf' value='2138'/>" +
                                 "<add key='NomeOficial' value=''/>" +
                                 "<add key='TituloRelatorioAuxiliar' value=''/>" +
                                 "<add key='TituloRelatorioPrevio' value='' />" +
                                 "<add key='CodNacional' value='' />" +
                                 "<add key='TipoDeConexao' value='57'/>" +
                                 "</appSettings>" +
                                 "<system.data>" +
		                             "<DbProviderFactories>"+
			                            "<remove invariant='FirebirdSql.Data.FirebirdClient'/>" +
			                            "<add name='FirebirdClient Data Provider' invariant='FirebirdSql.Data.FirebirdClient' description='.NET Framework Data Provider for Firebird' type='FirebirdSql.Data.FirebirdClient.FirebirdClientFactory, FirebirdSql.Data.FirebirdClient' />" +
		                             "</DbProviderFactories>" +
	                             "</system.data>" +
                                 "</configuration>" 
                                );
                            break;
                        case 4:
                            xml.LoadXml(
                                "<?xml version ='1.0' encoding ='utf-8'?>" +
                                 "<configuration>" +
                                 "<Launcher>" +
                                 @" <!--
                                    Exemplo SqlDatabase:
                                    Se tipo de SGBD = 0 => D:\Engegraph\DB\Launcher.sdf
                                    Se tipo de SGBD = 1 => Launcher
                                    -->" +
                                 "<SqlHost value='Z6r0Smiwd9llDCMAi2xZdqguevaHISdTBbURXx8it5wOeQt0McTK35q9UNCO+KtmTX4lu9VwmrpvjfoQhST0UKR8i/heklJW7Frbz57IqTw='/>" +
                                 "<SqlDatabase value='ajtdIiwGXxdecYlsf3eePsxjaTRQYdMw8LRRw09ywXx5TtSTTw/fGgBwrrGTrJTfYIkxTqULZL/jttuTUGU7nNPQlxbgw3N6EWRs0Tcy/SI='/>" +
                                 "<Usuario value='JS9/xbA+G7VyPoiYslZ+1z2FRbEfTW3uRi+Splv5gF4zp3gLFb4THPwB4JY0wh7NZh3XXFCAcF42ltSBaD60PaPHaXo17SqvyAxSkUhIMvY='/>" +
                                 "<Senha value='FeMaV+3Z6pqRq80f5TCFXksvG3hf4E/bvF9mJOfNoZZtGyGKr8gHPzinMH3pTVVwpntIP/GNuQk747hoQ80dDTqb+Z0HXm4DHHfSgkkil9c='/>" +
                                 "<TipoSgbd value='1hhIhpO1lny6EMPMVM/oSUR/DNmkdOrFBuva4rUvCYXCQYryR8ERS3WEOLkQGWPFQ6uU7/O+mcw5DP84WyrVFhrT6wF6dSCgO4v8Xr47ypg='/>" +
                                 "<AmbienteAtualizacao value='WMYWTHXzgwUqBmKeIfBPIBFKJXiIYO+irLRRRLVXPZJaMfcFhg8ZPPIiD55uvCpeVwsZTIQyNwGGyxE0ljiCYTTe1MdAiFmcpgQWB0ZgLTs=' />" +
                                 "</Launcher>" +
                                 "</configuration>"
                                );
                            break;
                    }
                    
                    xml.Save(nomeArquivo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar o arquivo .config. " + ex.Message);
                }
            }           
        }
    }
}
