using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        List<string> questions = new List<string>();
        List<string> answers = new List<string>();
        public Form1()
        {
            InitializeComponent();
            string jsonFilePath = "";
            AppSettingsReader asr = new AppSettingsReader();
            string previousName = "";

            getConfigValue<string>(asr, "DefinitionFile", ref jsonFilePath, string.Empty);
            if (!string.IsNullOrEmpty(jsonFilePath) && File.Exists(jsonFilePath))
            {
                this.lblCurrentFile.Text = jsonFilePath;
                using (TextReader tr = new StreamReader(jsonFilePath))
                {
                    Newtonsoft.Json.JsonTextReader rdr = new Newtonsoft.Json.JsonTextReader(tr);
                    while (rdr.Read())
                    {
                        //   Debug.WriteLine($"{rdr.ReadAsString()}");
                        // reference:  https://www.newtonsoft.com/json/help/html/ReadJsonWithJsonTextReader.htm
                        if (rdr.Value != null)
                        {
                            Debug.WriteLine("Token: {0}, Value: {1}", rdr.TokenType, rdr.Value);
                            if (rdr.TokenType ==  Newtonsoft.Json.JsonToken.PropertyName)
                            {
                                if (rdr.Value.ToString().CompareTo("title") == 0)
                                    previousName = "title";
                                else if (rdr.Value.ToString().CompareTo("questions") == 0)
                                    previousName = "questions";
                                else
                                {
                                    // save the setting
                                    if (previousName.CompareTo("title") == 0)
                                    {
                                        this.Text = rdr.Value.ToString();
                                    }
                                    else
                                    {
                                        questions.Add(rdr.Value.ToString());
                                    }
                                }
                            }
                            else if (rdr.TokenType  == Newtonsoft.Json.JsonToken.String)
                            {
                                answers.Add(rdr.Value.ToString());
                            }
                        }
                    }
                    rdr.Close();
                    ShowQuestion(1);
                }
            }
        }
        private void ShowQuestion(int n)
        {
            this.tbQuestions.Text = questions[n - 1].ToString();
            this.tbAnswers.Text = answers[n - 1].ToString().Replace("|", Environment.NewLine);
            this.tbAnswers.Visible = false;
            this.tbQuestionNo.Text = n.ToString();
        }
        /// <summary>
        /// getConfigValue
        /// </summary>
        /// <typeparam name="T">passed type</typeparam>
        /// <param name="appSettingsReader">System.Configuration.AppSettingsReader</param>
        /// <param name="keyName">string</param>
        /// <param name="keyValue">ref T</param>
        /// <param name="defaultValue">T</param>
        private void getConfigValue<T>(AppSettingsReader appSettingsReader,
            string keyName, ref T keyValue, T defaultValue)
        {
            keyValue = defaultValue; // provide a default
            try
            {
                string tempS = (string)appSettingsReader.GetValue(keyName, typeof(System.String));
                if ((tempS != null) && (tempS.Trim().Length > 0))
                {
                    keyValue = (T)TypeDescriptor.GetConverter(keyValue.GetType()).ConvertFrom(tempS);
                }
                else
                    Debug.WriteLine("Registry failed to read value from " + keyName);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                // if key does not exist, not a problem. Caller must pre-assign values anyway
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int n;
            if (!string.IsNullOrEmpty(tbQuestionNo.Text))
            {
                if (int.TryParse(tbQuestionNo.Text, out n))
                {
                    if ((n + 1) <= questions.Count)
                    {
                        ShowQuestion(n + 1);
                    }
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.tbAnswers.Visible = !this.tbAnswers.Visible;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            int n;
            if (!string.IsNullOrEmpty(tbQuestionNo.Text))
            {
                if (int.TryParse(tbQuestionNo.Text, out n))
                {
                    if ((n - 1) >= 1)
                    {
                        ShowQuestion(n - 1);
                    }
                }
            }

        }
    }
}
