using Configuracao.Modelos;
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
                oP88.Atualizar(XML);
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
                launcher.Atualizar(XML);
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
                cip.Atualizar(XML);                
                XML.Save(nomeArquivo);
                MessageBox.Show("Configuração salva com sucesso.", "CIP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GravarDados(SEDI_PA pA)
        {
            string nomeArquivo = @"Configuracoes.config";

            try
            {
                XElement XML = XElement.Load(nomeArquivo);
                pA.Atualizar(XML);
                XML.Save(nomeArquivo);
                MessageBox.Show("Configuração salva com sucesso.", "SEDI-PA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                SEDI.Atualizar(appSettings);
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
                dadp.Atualizar(appSettings);               

                customConfig.Save();
                MessageBox.Show("Configuração salva com sucesso.", "DADP", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                p88.Map(XML);                
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
                launcher.Map(XML);                
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
                cip.Map(XML);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void GetDados(SEDI_PA pA)
        {
            string nomeArquivo = @"Configuracoes.config";

            try
            {
                XElement XML = XElement.Load(nomeArquivo);
                pA.Map(XML);
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

                SEDI.Map(appSettings);
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
                dadp.Map(appSettings);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public int AmbAtualizacao(string amb)
        {
            if(amb != null)
                switch (amb.ToUpper())
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
            return -1;
        }        
    }
}