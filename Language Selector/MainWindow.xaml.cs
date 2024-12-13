using System;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Language_Selector
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeLanguage_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)languageComboBox.SelectedItem;
            string selectedLanguage = selectedItem.Content.ToString().ToLower();

            string localeCode = "";
            switch (selectedLanguage)
            {
                case "english":
                    localeCode = "10002 1252 en";
                    break;
                case "magyar":
                    localeCode = "10021 1250 hu";
                    break;
                case "cestina":
                    localeCode = "10019 1250 cz";
                    break;
                case "deutsch":
                    localeCode = "10000 1252 de";
                    break;
                case "dansk":
                    localeCode = "10013 1252 dk";
                    break;
                case "espanol":
                    localeCode = "10004 1252 es";
                    break;
                case "francais":
                    localeCode = "10000 1252 fr";
                    break;
                case "ellinika":
                    localeCode = "0 1253 gr";
                    break;
                case "italiano":
                    localeCode = "10006 1252 it";
                    break;
                case "holland":
                    localeCode = "10018 1252 nl";
                    break;
                case "polski":
                    localeCode = "10012 1250 pl";
                    break;
                case "portugues":
                    localeCode = "10010 1252 pt";
                    break;
                case "romana":
                    localeCode = "10022 1250 ro";
                    break;
                case "russkiy":
                    localeCode = "10020 1251 ru";
                    break;
                case "turkce":
                    localeCode = "10012 1254 tr";
                    break;
                default:
                    MessageBox.Show("Unsupported language selection.");
                    return;
            }

            string configFile = "locale.cfg";
            try
            {
                UTF8Encoding utf8WithoutBom = new UTF8Encoding(false);

                using (StreamWriter writer = new StreamWriter(configFile, false, utf8WithoutBom))
                {
                    writer.WriteLine(localeCode);
                }

                MessageBox.Show("Language settings updated successfully.");
                Application.Current.Shutdown();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating language settings: {ex.Message}");
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}