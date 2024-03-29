﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР1
{
    public partial class Form1 : Form
    {
        private int fileCounter = 1;
        private string openedFilePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\Users\kaban\source\repos\ЛР1\ЛР1\bin\Debug";
            try
            {
                string fileName = $"File{fileCounter}.txt";
                string filePath = Path.Combine(folderPath, fileName);
                File.WriteAllText(filePath, $"Содержимое файла {fileCounter}");
                MessageBox.Show($"Файл {fileName} успешно создан.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                fileCounter++;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!сheckForChanges())
            {
                return;
            }
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        string fileContent = File.ReadAllText(filePath);

                        editingTextBox.Text = fileContent;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при открытии файла: {ex.Message}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private bool сheckForChanges()
        {
            if (editingTextBox.Modified)
            {
                DialogResult result = MessageBox.Show("Хотите сохранить изменения?", "Предупреждение", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    saveChanges();
                }
                else if (result == DialogResult.Cancel)
                {
                    return false;
                }
            }
            return true;
        }
        private void saveChanges()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                editingTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                editingTextBox.Modified = false;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(openedFilePath))
            {

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        openedFilePath = saveFileDialog.FileName;
                    }
                    else
                    {
                        return;
                    }
                }
            }

            try
            {

                File.WriteAllText(openedFilePath, editingTextBox.Text);
                MessageBox.Show("Файл успешно сохранен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            editingTextBox.Modified = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsRichTextBoxModified())
            {
                checkingFileSaving();
            }
            else
            {
                Close();
            }
        }

        private bool IsRichTextBoxModified()
        {
            return editingTextBox.Modified;
        }

        private void SaveChanges()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                editingTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                editingTextBox.Modified = false;
            }
        }
        private void checkingFileSaving()
        {
            if (IsRichTextBoxModified())
            {
                DialogResult result = MessageBox.Show("Сохранить изменения?", "Предупреждение", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    SaveChanges();
                    Close();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
                else if (result == DialogResult.No)
                {
                    Close();
                }
            }
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editingTextBox.CanUndo)
            {
                editingTextBox.Undo();
            }
        }

        private void repeatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editingTextBox.CanRedo)
            {
                editingTextBox.Redo();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editingTextBox.SelectionLength > 0)
            {
                Clipboard.SetText(editingTextBox.SelectedText);
                editingTextBox.SelectedText = "";
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editingTextBox.SelectionLength > 0)
                Clipboard.SetText(editingTextBox.SelectedText);
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                editingTextBox.SelectedText = Clipboard.GetText();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editingTextBox.SelectionLength > 0)
            {
                editingTextBox.SelectedText = "";
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editingTextBox.SelectAll();
        }

        private void callHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string filePath = @"C:\Users\kaban\source\repos\ЛР1\Help.html";
            if (System.IO.File.Exists(filePath))
            {
                Process p = new Process();
                p.StartInfo = new ProcessStartInfo(filePath) { UseShellExecute = true };
                p.Start();
            }
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string filePath = @"C:\Users\kaban\source\repos\ЛР1\Info.html";
            if (System.IO.File.Exists(filePath))
            {
                Process p = new Process();
                p.StartInfo = new ProcessStartInfo(filePath) { UseShellExecute = true };
                p.Start();
            }
        }

        private void createFileButton_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\Users\kaban\source\repos\ЛР1\ЛР1\bin\Debug";
            try
            {
                string fileName = $"File{fileCounter}.txt";
                string filePath = Path.Combine(folderPath, fileName);
                File.WriteAllText(filePath, $"Содержимое файла {fileCounter}");
                MessageBox.Show($"Файл {fileName} успешно создан.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                fileCounter++;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (!сheckForChanges())
            {
                return;
            }
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        string fileContent = File.ReadAllText(filePath);

                        editingTextBox.Text = fileContent;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при открытии файла: {ex.Message}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(openedFilePath))
            {

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        openedFilePath = saveFileDialog.FileName;
                    }
                    else
                    {
                        return;
                    }
                }
            }

            try
            {
                File.WriteAllText(openedFilePath, editingTextBox.Text);
                MessageBox.Show("Файл успешно сохранен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            editingTextBox.Modified = false;
        }

        private void cancelChangeButton_Click(object sender, EventArgs e)
        {
            if (editingTextBox.CanUndo)
            {
                editingTextBox.Undo();
            }
        }

        private void repeatLastChangeButton_Click(object sender, EventArgs e)
        {
            if (editingTextBox.CanRedo)
            {
                editingTextBox.Redo();
            }
        }

        private void copyTextButton_Click(object sender, EventArgs e)
        {
            if (editingTextBox.SelectionLength > 0)
                Clipboard.SetText(editingTextBox.SelectedText);
        }

        private void cutTextButton_Click(object sender, EventArgs e)
        {
            if (editingTextBox.SelectionLength > 0)
            {
                Clipboard.SetText(editingTextBox.SelectedText);
                editingTextBox.SelectedText = "";
            }
        }

        private void insertTextButton_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                editingTextBox.SelectedText = Clipboard.GetText();
            }
        }

        private void informationButton_Click(object sender, EventArgs e)
        {
            const string filePath = @"C:\Users\kaban\source\repos\ЛР1\Help.html";
            if (System.IO.File.Exists(filePath))
            {
                Process p = new Process();
                p.StartInfo = new ProcessStartInfo(filePath) { UseShellExecute = true };
                p.Start();
            }
        }

        private void createdByButton_Click(object sender, EventArgs e)
        {
            const string filePath = @"C:\Users\kaban\source\repos\ЛР1\Info.html";
            if (System.IO.File.Exists(filePath))
            {
                Process p = new Process();
                p.StartInfo = new ProcessStartInfo(filePath) { UseShellExecute = true };
                p.Start();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsRichTextBoxModified())
            {
                checkingFileSaving();
            }
            else
            {
                Close();
            }
        }



        private void DisplayTokensInDataGridView(List<Element> elements)
        {
            lexemeTable.Rows.Clear();

            foreach (var element in elements)
            {
                var typeDescription = CommonHelper.elementTitles[element.Type];
                string location = $"с {element.StartPos} по {element.StartPos + element.Value.Length - 1} символ";
                lexemeTable.Rows.Add(element.Type, typeDescription, element.Value, location);
            }
        }

        private void toolStripMenuStart_Click(object sender, EventArgs e)
        {
            string inputText = editingTextBox.Text;
            var elements = inputText.Tokenize();
            DisplayTokensInDataGridView(elements);
            editingTextBox.Visible = true;
        }

        private void runParserButton_Click_1(object sender, EventArgs e)
        {
            string inputText = editingTextBox.Text;
            var elements = inputText.Tokenize();
            lexemeTable.DataSource = null;
            DisplayTokensInDataGridView(elements);
            
            editingTextBox.Visible = true;
        }
    }

}
