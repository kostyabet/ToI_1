using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;

enum METHOD
{
    COLUMN,
    VIZENER
}

enum LANGUAGE
{
    RU,
    EN,
}

namespace ToI_1
{
    public partial class MainForm : Form
    {
        private METHOD method { get; set; }
        private LANGUAGE language { get; set; }

        private delegate string EnDeCription(string key, string text);

        private char[] englishAlphabet =
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };

        private char[] russianAlphabet =
        {
            'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М',
            'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ',
            'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я'
        };

        public MainForm()
        {
            InitializeComponent();

            method = METHOD.COLUMN;
            CheckCurrentMethod(method);
        }

        private (bool status, string info) CheckIsGoodKey(string key)
        {
            if (key.Trim().Length == 0)
                return (false, "Введите ключ для дальнейшей работы!");

            key = key.ToUpper();
            string resultKey = "";
            char[] curLang = language == LANGUAGE.EN ? englishAlphabet : russianAlphabet;
            foreach (char c in key)
            {
                if (curLang.Contains(c))
                    resultKey += c;
            }
            if (resultKey.Length == 0)
                return (false, "В ключе нет ниодного символа соответствующего алфавита!");
            return (true, resultKey);
        }

        private (bool status, string plainText) CheckIsGoodPlain(string text)
        {
            if (text.Length == 0)
                return (false, "Введите исходный текст!");
            return (true, text);
        }

        private void CheckCurrentMethod(METHOD current)
        {
            if (current == METHOD.COLUMN)
            {
                language = LANGUAGE.EN;
                methodNameLabel.Text = "«Столбцовый метод» улучшенный";
                colUpButton.Enabled = true;
            }
            else
            {
                language = LANGUAGE.RU;
                methodNameLabel.Text = "Виженер, самогенерирующийся ключ";
                vizenerGeneratedButton.Enabled = true;
            }
            langLabel.Text = $"Язык: {language.ToString()}";
            ResetInputs();
        }

        private void ResetInputs()
        {
            keyTextBox.Text = string.Empty;
            plaintTextBox.Text = string.Empty;
            ciperTextBox.Text = string.Empty;

            cipherFileButton.Enabled = false;
            infoButton.Enabled = false;
        }

        private void SetInputs()
        {
            cipherFileButton.Enabled = true;
            infoButton.Enabled = true;
        }

        private string getStringFromFile()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bool status;
                string result;
                (status, result) = ReadStringFromFile(openFileDialog.FileName);
                if (status)
                    return result;
                MessageBox.Show(result, "Ошибка!");
            }
            return string.Empty;
        }

        private bool setStringInFile(string text)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bool status;
                string result; 
                (status, result) = WriteStringInFile(saveFileDialog.FileName, text);
                MessageBox.Show(result, status ? "Успех" : "Ошибка");
                return status;
            }
            return true;
        }

        private (bool, string) WriteStringInFile(string fileName, string text)
        {
            try
            {
                File.WriteAllText(fileName, text);
                return (true, "Строка успешно записана в файл.");
            }
            catch (Exception ex)
            {
                return (false, $"Ошибка при записи в файл: {ex.Message}");
            }
        }

        private (bool, string) ReadStringFromFile(string filename)
        {
            try
            {
                string content = File.ReadAllText(filename);
                bool status;
                string info;
                (status, info) = CheckIsGoodPlain(content);
                if (status)
                    return (true, content);
                return (false, "Строка не является корректной!");
            }
            catch (Exception ex)
            {
                return (false, $"Ошибка при чтении файла: {ex.Message}");
            }
        }

        private void MainAlgho(EnDeCription Function)
        {
            bool status;
            // key
            string key;
            (status, key) = CheckIsGoodKey(keyTextBox.Text);
            if (!status)
            {
                MessageBox.Show(key, "Ошибка!");
                return;
            }
            // plain text
            string text;
            (status, text) = CheckIsGoodPlain(plaintTextBox.Text);
            if (!status)
            {
                MessageBox.Show(text, "Ошибка!");
                return;
            }
            string plainText = BuildCurLangString(text.ToUpper(), (language == LANGUAGE.RU ? russianAlphabet : englishAlphabet));
            // chiper
            string cipherText = Function(key, plainText);
            ciperTextBox.Text = GenerateOutputString(text.ToUpper(), plainText, cipherText);
            SetInputs();
        }

        private string GenerateOutputString(string text, string plain, string cipher)
        {
            string result = string.Empty;

            int encIndex = 0;
            int textIndex = 0;
            while (encIndex < cipher.Length && textIndex < text.Length)
            {
                if (text[textIndex] != plain[encIndex])
                {
                    result += text[textIndex];
                    textIndex++;
                }
                else
                {
                    result += cipher[encIndex];
                    textIndex++;
                    encIndex++;
                }
            }

            return result;
        }

        private string BuildCurLangString(string text, char[] language)
        {
            string result = string.Empty;
            foreach(char c in text)
            {
                if (language.Contains(c))
                    result += c;
            }
            return result;
        }

        private int GetRows(int[] indexes, string text)
        {
            int count = 0;
            int length = 0;
            while (length < text.Length)
            {
                int curIndex = count % indexes.Length;
                length += Array.IndexOf(indexes, curIndex + 1) + 1;
                count++;
            }
            return count;
        }

        private int LastRowCount(int[] indexes, string text)
        {
            int count = 0;
            int length = 0;
            while (length < text.Length)
            {
                int curIndex = count % indexes.Length;
                length += Array.IndexOf(indexes, curIndex + 1) + 1;
                count++;
            }
            int result = Array.IndexOf(indexes, count % indexes.Length) - (length - text.Length);
            return result;
        }

        private string ColumnEncription(string key, string text)
        {
            // fill first row
            int[] keyIndexMatrix = new int[key.Length];
            for (int i = 0; i < key.Length; i++)
                keyIndexMatrix[i] = Array.IndexOf(englishAlphabet, key[i]) + 1;

            // find ranks
            var pairs = keyIndexMatrix.Select((value, index) => new { Value = value, Index = index }).ToArray();
            var sortedPairs = pairs.OrderBy(p => p.Value)
                                   .ThenBy(p => p.Index)
                                   .ToArray();
            int[] ranks = new int[keyIndexMatrix.Length];
            for (int i = 0; i < sortedPairs.Length; i++)
            {
                ranks[sortedPairs[i].Index] = i + 1;
            }
            keyIndexMatrix = ranks;

            char[][] matrix = new char[GetRows(keyIndexMatrix, text)][];
            for (int i = 0; i < matrix.Length; i++)
                matrix[i] = new char[key.Length];

            // fill matrix
            int plainTextIndex = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = text[plainTextIndex++];
                    if (plainTextIndex == text.Length) break;
                    if (keyIndexMatrix[j] == (i % keyIndexMatrix.Length) + 1) break;
                }
                if (plainTextIndex == text.Length) break;
            }

            // create result string
            string result = string.Empty;
            for (int i = 0; i < matrix[0].Length; i++)
            {
                int column = Array.IndexOf(keyIndexMatrix, i + 1);
                for (int j = 0; j < matrix.Length; j++)
                    result += matrix[j][column] == '\0' ? "" : matrix   [j][column].ToString();
            }
            return result;
        }

        private string ColumnDecription(string key, string text)
        {
            // fill first row
            int[] keyIndexMatrix = new int[key.Length];
            for (int i = 0; i < key.Length; i++)
                keyIndexMatrix[i] = Array.IndexOf(englishAlphabet, key[i]) + 1;

            // find ranks
            var pairs = keyIndexMatrix.Select((value, index) => new { Value = value, Index = index }).ToArray();
            var sortedPairs = pairs.OrderBy(p => p.Value)
                                   .ThenBy(p => p.Index)
                                   .ToArray();
            int[] ranks = new int[keyIndexMatrix.Length];
            for (int i = 0; i < sortedPairs.Length; i++)
            {
                ranks[sortedPairs[i].Index] = i + 1;
            }
            keyIndexMatrix = ranks;

            char[][] matrix = new char[GetRows(keyIndexMatrix, text)][];
            for (int i = 0; i < matrix.Length; i++)
                matrix[i] = new char[key.Length];

            // fill matrix
            int textIndex = 0;
            for (int i = 0; i < matrix[0].Length; i++)
            {
                int index = Array.IndexOf(keyIndexMatrix, i + 1);
                for (int j = 0; j < matrix.Length; j++)
                {
                    int isLeft = Array.IndexOf(keyIndexMatrix, j % keyIndexMatrix.Length + 1);
                    if (isLeft >= index)
                        if (j == matrix.Length - 1 && LastRowCount(keyIndexMatrix, text) >= index)
                            matrix[j][index] = text[textIndex++];
                        else if (j != matrix.Length - 1)
                            matrix[j][index] = text[textIndex++];
                    if (textIndex == text.Length) break;
                }
                if (textIndex == text.Length) break;
            }

            // create result string
            string result = string.Empty;
            for (int i = 0; i < matrix.Length; i++)
                for (int j = 0; j < matrix[i].Length; j++)
                    result += matrix[i][j] == '\0' ? "" : matrix[i][j].ToString();
            return result;
        }

        private string VizinerEncription(string key, string text)
        {
            // prepear key
            if (text.Length > key.Length)
                key += text.Substring(0, text.Length - key.Length);

            // cyper
            string result = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                int index = (Array.IndexOf(russianAlphabet, text[i]) + Array.IndexOf(russianAlphabet, key[i]) + russianAlphabet.Length) % russianAlphabet.Length;
                result += russianAlphabet[index];
            }
            return result;
        }

        private string VizinerDecription(string key, string text)
        {
            int keyIndex = 0;
            int resIndex = 0;
            string result = string.Empty;
            while (keyIndex < text.Length)
            {
                if (keyIndex == key.Length)
                    key += result[resIndex++];
                int index = (Array.IndexOf(russianAlphabet, text[keyIndex]) - Array.IndexOf(russianAlphabet, key[keyIndex]) + russianAlphabet.Length) % russianAlphabet.Length;
                result += russianAlphabet[index];
                keyIndex++;
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            method = METHOD.COLUMN;
            CheckCurrentMethod(method);
        }

        private void vizenerGeneratedButton_Click(object sender, EventArgs e)
        {
            method = METHOD.VIZENER;
            CheckCurrentMethod(method);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void shifrButton_Click(object sender, EventArgs e)
        {
            EnDeCription Function;
            if (method == METHOD.COLUMN) Function = ColumnEncription;
            else Function = VizinerEncription;
            MainAlgho(Function);
        }

        private void deshifrButton_Click(object sender, EventArgs e)
        {
            EnDeCription Function;
            if (method == METHOD.COLUMN) Function = ColumnDecription;
            else Function = VizinerDecription;
                MainAlgho(Function);
        }

        private void plainFileButton_Click(object sender, EventArgs e)
        {
            plaintTextBox.Text = getStringFromFile();
        }

        private void cipherFileButton_Click(object sender, EventArgs e)
        {
            setStringInFile(ciperTextBox.Text);
        }
    }
}