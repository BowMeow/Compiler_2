namespace ЛР1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repeatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.постановкаЗадачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.грамматикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.классификацияГрамматикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методАнализаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диагностикаИНейтрализацияОшибокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестовыйПримерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЛитературыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.исходныйКодПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.callHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.createFileButton = new System.Windows.Forms.ToolStripButton();
            this.openFileButton = new System.Windows.Forms.ToolStripButton();
            this.saveFileButton = new System.Windows.Forms.ToolStripButton();
            this.cancelChangeButton = new System.Windows.Forms.ToolStripButton();
            this.repeatLastChangeButton = new System.Windows.Forms.ToolStripButton();
            this.copyTextButton = new System.Windows.Forms.ToolStripButton();
            this.cutTextButton = new System.Windows.Forms.ToolStripButton();
            this.insertTextButton = new System.Windows.Forms.ToolStripButton();
            this.runParserButton = new System.Windows.Forms.ToolStripButton();
            this.informationButton = new System.Windows.Forms.ToolStripButton();
            this.createdByButton = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.editingTextBox = new System.Windows.Forms.RichTextBox();
            this.lexemeTable = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lexeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lexemeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem5,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(956, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 24);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.createToolStripMenuItem.Text = "Создать";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.saveAsToolStripMenuItem.Text = "Сохранить как";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripMenuItem,
            this.repeatToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(74, 24);
            this.toolStripMenuItem2.Text = "Правка";
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.cancelToolStripMenuItem.Text = "Отменить";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // repeatToolStripMenuItem
            // 
            this.repeatToolStripMenuItem.Name = "repeatToolStripMenuItem";
            this.repeatToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.repeatToolStripMenuItem.Text = "Повторить";
            this.repeatToolStripMenuItem.Click += new System.EventHandler(this.repeatToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.cutToolStripMenuItem.Text = "Вырезать";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.copyToolStripMenuItem.Text = "Копировать";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.insertToolStripMenuItem.Text = "Вставить";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.selectAllToolStripMenuItem.Text = "Выделить все";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.постановкаЗадачиToolStripMenuItem,
            this.грамматикаToolStripMenuItem,
            this.классификацияГрамматикиToolStripMenuItem,
            this.методАнализаToolStripMenuItem,
            this.диагностикаИНейтрализацияОшибокToolStripMenuItem,
            this.тестовыйПримерToolStripMenuItem,
            this.списокЛитературыToolStripMenuItem,
            this.исходныйКодПрограммыToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(59, 24);
            this.toolStripMenuItem3.Text = "Текст";
            // 
            // постановкаЗадачиToolStripMenuItem
            // 
            this.постановкаЗадачиToolStripMenuItem.Name = "постановкаЗадачиToolStripMenuItem";
            this.постановкаЗадачиToolStripMenuItem.Size = new System.Drawing.Size(363, 26);
            this.постановкаЗадачиToolStripMenuItem.Text = "Постановка задачи";
            // 
            // грамматикаToolStripMenuItem
            // 
            this.грамматикаToolStripMenuItem.Name = "грамматикаToolStripMenuItem";
            this.грамматикаToolStripMenuItem.Size = new System.Drawing.Size(363, 26);
            this.грамматикаToolStripMenuItem.Text = "Грамматика";
            // 
            // классификацияГрамматикиToolStripMenuItem
            // 
            this.классификацияГрамматикиToolStripMenuItem.Name = "классификацияГрамматикиToolStripMenuItem";
            this.классификацияГрамматикиToolStripMenuItem.Size = new System.Drawing.Size(363, 26);
            this.классификацияГрамматикиToolStripMenuItem.Text = "Классификация грамматики";
            // 
            // методАнализаToolStripMenuItem
            // 
            this.методАнализаToolStripMenuItem.Name = "методАнализаToolStripMenuItem";
            this.методАнализаToolStripMenuItem.Size = new System.Drawing.Size(363, 26);
            this.методАнализаToolStripMenuItem.Text = "Метод анализа";
            // 
            // диагностикаИНейтрализацияОшибокToolStripMenuItem
            // 
            this.диагностикаИНейтрализацияОшибокToolStripMenuItem.Name = "диагностикаИНейтрализацияОшибокToolStripMenuItem";
            this.диагностикаИНейтрализацияОшибокToolStripMenuItem.Size = new System.Drawing.Size(363, 26);
            this.диагностикаИНейтрализацияОшибокToolStripMenuItem.Text = "Диагностика и нейтрализация ошибок";
            // 
            // тестовыйПримерToolStripMenuItem
            // 
            this.тестовыйПримерToolStripMenuItem.Name = "тестовыйПримерToolStripMenuItem";
            this.тестовыйПримерToolStripMenuItem.Size = new System.Drawing.Size(363, 26);
            this.тестовыйПримерToolStripMenuItem.Text = "Тестовый пример";
            // 
            // списокЛитературыToolStripMenuItem
            // 
            this.списокЛитературыToolStripMenuItem.Name = "списокЛитературыToolStripMenuItem";
            this.списокЛитературыToolStripMenuItem.Size = new System.Drawing.Size(363, 26);
            this.списокЛитературыToolStripMenuItem.Text = "Список литературы";
            // 
            // исходныйКодПрограммыToolStripMenuItem
            // 
            this.исходныйКодПрограммыToolStripMenuItem.Name = "исходныйКодПрограммыToolStripMenuItem";
            this.исходныйКодПрограммыToolStripMenuItem.Size = new System.Drawing.Size(363, 26);
            this.исходныйКодПрограммыToolStripMenuItem.Text = "Исходный код программы";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(55, 24);
            this.toolStripMenuItem5.Text = "Пуск";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.callHelpToolStripMenuItem,
            this.aboutProgramToolStripMenuItem});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(81, 24);
            this.toolStripMenuItem4.Text = "Справка";
            // 
            // callHelpToolStripMenuItem
            // 
            this.callHelpToolStripMenuItem.Name = "callHelpToolStripMenuItem";
            this.callHelpToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.callHelpToolStripMenuItem.Text = "Вызов справки";
            this.callHelpToolStripMenuItem.Click += new System.EventHandler(this.callHelpToolStripMenuItem_Click);
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.aboutProgramToolStripMenuItem.Text = "О программе";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createFileButton,
            this.openFileButton,
            this.saveFileButton,
            this.cancelChangeButton,
            this.repeatLastChangeButton,
            this.copyTextButton,
            this.cutTextButton,
            this.insertTextButton,
            this.runParserButton,
            this.informationButton,
            this.createdByButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(956, 47);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // createFileButton
            // 
            this.createFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.createFileButton.Image = global::ЛР1.Properties.Resources.doc;
            this.createFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createFileButton.Name = "createFileButton";
            this.createFileButton.Size = new System.Drawing.Size(44, 44);
            this.createFileButton.Text = "Создать";
            this.createFileButton.Click += new System.EventHandler(this.createFileButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openFileButton.Image = global::ЛР1.Properties.Resources.folder;
            this.openFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(44, 44);
            this.openFileButton.Text = "Открыть";
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveFileButton.Image = global::ЛР1.Properties.Resources.save;
            this.saveFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(44, 44);
            this.saveFileButton.Text = "Сохранить";
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // cancelChangeButton
            // 
            this.cancelChangeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancelChangeButton.Image = global::ЛР1.Properties.Resources.left;
            this.cancelChangeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelChangeButton.Name = "cancelChangeButton";
            this.cancelChangeButton.Size = new System.Drawing.Size(44, 44);
            this.cancelChangeButton.Text = "Отменить";
            this.cancelChangeButton.Click += new System.EventHandler(this.cancelChangeButton_Click);
            // 
            // repeatLastChangeButton
            // 
            this.repeatLastChangeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.repeatLastChangeButton.Image = global::ЛР1.Properties.Resources.right;
            this.repeatLastChangeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.repeatLastChangeButton.Name = "repeatLastChangeButton";
            this.repeatLastChangeButton.Size = new System.Drawing.Size(44, 44);
            this.repeatLastChangeButton.Text = "Повторить";
            this.repeatLastChangeButton.Click += new System.EventHandler(this.repeatLastChangeButton_Click);
            // 
            // copyTextButton
            // 
            this.copyTextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyTextButton.Image = global::ЛР1.Properties.Resources.copy;
            this.copyTextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyTextButton.Name = "copyTextButton";
            this.copyTextButton.Size = new System.Drawing.Size(44, 44);
            this.copyTextButton.Text = "Копировать";
            this.copyTextButton.Click += new System.EventHandler(this.copyTextButton_Click);
            // 
            // cutTextButton
            // 
            this.cutTextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutTextButton.Image = global::ЛР1.Properties.Resources.cut;
            this.cutTextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutTextButton.Name = "cutTextButton";
            this.cutTextButton.Size = new System.Drawing.Size(44, 44);
            this.cutTextButton.Text = "Вырезать";
            this.cutTextButton.Click += new System.EventHandler(this.cutTextButton_Click);
            // 
            // insertTextButton
            // 
            this.insertTextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.insertTextButton.Image = global::ЛР1.Properties.Resources.paste;
            this.insertTextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.insertTextButton.Name = "insertTextButton";
            this.insertTextButton.Size = new System.Drawing.Size(44, 44);
            this.insertTextButton.Text = "Вставить";
            this.insertTextButton.Click += new System.EventHandler(this.insertTextButton_Click);
            // 
            // runParserButton
            // 
            this.runParserButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.runParserButton.Image = global::ЛР1.Properties.Resources.start;
            this.runParserButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runParserButton.Name = "runParserButton";
            this.runParserButton.Size = new System.Drawing.Size(44, 44);
            this.runParserButton.Text = "Пуск";
            this.runParserButton.Click += new System.EventHandler(this.runParserButton_Click);
            // 
            // informationButton
            // 
            this.informationButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.informationButton.Image = global::ЛР1.Properties.Resources.question;
            this.informationButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.informationButton.Name = "informationButton";
            this.informationButton.Size = new System.Drawing.Size(44, 44);
            this.informationButton.Text = "Вызов справки";
            this.informationButton.Click += new System.EventHandler(this.informationButton_Click);
            // 
            // createdByButton
            // 
            this.createdByButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.createdByButton.Image = global::ЛР1.Properties.Resources.information2;
            this.createdByButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createdByButton.Name = "createdByButton";
            this.createdByButton.Size = new System.Drawing.Size(44, 44);
            this.createdByButton.Text = "О программе";
            this.createdByButton.Click += new System.EventHandler(this.createdByButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 107);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.editingTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lexemeTable);
            this.splitContainer1.Panel2.Controls.Add(this.outputTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(932, 389);
            this.splitContainer1.SplitterDistance = 192;
            this.splitContainer1.TabIndex = 4;
            // 
            // editingTextBox
            // 
            this.editingTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editingTextBox.Location = new System.Drawing.Point(0, 0);
            this.editingTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editingTextBox.Name = "editingTextBox";
            this.editingTextBox.Size = new System.Drawing.Size(932, 192);
            this.editingTextBox.TabIndex = 0;
            this.editingTextBox.Text = "";
            // 
            // lexemeTable
            // 
            this.lexemeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lexemeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Type,
            this.Lexeme,
            this.Location});
            this.lexemeTable.Location = new System.Drawing.Point(0, 0);
            this.lexemeTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lexemeTable.Name = "lexemeTable";
            this.lexemeTable.RowHeadersWidth = 51;
            this.lexemeTable.Size = new System.Drawing.Size(932, 193);
            this.lexemeTable.TabIndex = 5;
            // 
            // Code
            // 
            this.Code.HeaderText = "Код";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            this.Code.Width = 125;
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.Width = 125;
            // 
            // Lexeme
            // 
            this.Lexeme.HeaderText = "Лексема";
            this.Lexeme.MinimumWidth = 6;
            this.Lexeme.Name = "Lexeme";
            this.Lexeme.Width = 125;
            // 
            // Location
            // 
            this.Location.HeaderText = "Местоположение";
            this.Location.MinimumWidth = 6;
            this.Location.Name = "Location";
            this.Location.Width = 125;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTextBox.Location = new System.Drawing.Point(0, 0);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(932, 193);
            this.outputTextBox.TabIndex = 0;
            this.outputTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 535);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Компилятор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lexemeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repeatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem постановкаЗадачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem грамматикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem классификацияГрамматикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методАнализаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диагностикаИНейтрализацияОшибокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестовыйПримерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокЛитературыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem исходныйКодПрограммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem callHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton createFileButton;
        private System.Windows.Forms.ToolStripButton openFileButton;
        private System.Windows.Forms.ToolStripButton saveFileButton;
        private System.Windows.Forms.ToolStripButton cancelChangeButton;
        private System.Windows.Forms.ToolStripButton repeatLastChangeButton;
        private System.Windows.Forms.ToolStripButton copyTextButton;
        private System.Windows.Forms.ToolStripButton cutTextButton;
        private System.Windows.Forms.ToolStripButton insertTextButton;
        private System.Windows.Forms.ToolStripButton runParserButton;
        private System.Windows.Forms.ToolStripButton informationButton;
        private System.Windows.Forms.ToolStripButton createdByButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox editingTextBox;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.DataGridView lexemeTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
    }
}

