using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using GTranslate;
using GTranslate.Translators;

namespace Translator_GUI
{
    public partial class Form1 : Form
    {
        private readonly static GoogleTranslator _translator = new GoogleTranslator();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeLangugages();
        }

        private void InitializeLangugages()
        {
            var outputlanguageItems = Language.LanguageDictionary.Values
               .Select(lang => new { Text = lang.Name, Value = lang.ISO6391 })
               .ToList();

            var inputlanguageItems = Language.LanguageDictionary.Values
               .Select(lang => new { Text = lang.Name, Value = lang.ISO6391 })
               .ToList();

            outputLanguageComboBox.DataSource = outputlanguageItems;
            outputLanguageComboBox.DisplayMember = "Text";
            outputLanguageComboBox.ValueMember = "Value";

            inputLanguageComboBox.DataSource = inputlanguageItems;
            inputLanguageComboBox.DisplayMember = "Text";
            inputLanguageComboBox.ValueMember = "Value";

        }

        private async Task TranslateText()
        {
            translate_Btn.Enabled = false;
            translate_Btn.Text = "Translating...";

            try
            {
                var inputLanguage = (string)inputLanguageComboBox.SelectedValue;
                var outputLangauge = (string)outputLanguageComboBox.SelectedValue;
                var inputText = text_Textbox.Text;

                var result = await _translator.TranslateAsync(inputText, outputLangauge, inputLanguage);
                MessageBox.Show($"Source input: {result.Source}. Translated: {result.Translation}");

                text_Textbox.Text = result.Translation;
            }
            catch (Exception e)
            {
                MessageBox.Show($"An error occurred during translation. Please try again. {e}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                translate_Btn.Enabled = true;
                translate_Btn.Text = "Translate";
            }
        }

        private async void translate_Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text_Textbox.Text))
            {
                MessageBox.Show("Please enter text to translate.", "Warning",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                await TranslateText();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Translation failed: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void clear_Btn_Click(object sender, EventArgs e)
        {
            text_Textbox.Clear();
        }
    }
    }
