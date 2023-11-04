namespace Banco
{
    partial class Banco
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Banco));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aRQUIVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSaldoValor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDeposito = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDepositar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSacar = new System.Windows.Forms.Button();
            this.textBoxSacar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClique = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRQUIVOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // aRQUIVOToolStripMenuItem
            // 
            this.aRQUIVOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.aRQUIVOToolStripMenuItem.Name = "aRQUIVOToolStripMenuItem";
            this.aRQUIVOToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.aRQUIVOToolStripMenuItem.Text = "Arquivo";
            this.aRQUIVOToolStripMenuItem.Click += new System.EventHandler(this.aRQUIVOToolStripMenuItem_Click);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            // 
            // labelSaldoValor
            // 
            this.labelSaldoValor.AutoSize = true;
            this.labelSaldoValor.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.labelSaldoValor.Location = new System.Drawing.Point(43, 20);
            this.labelSaldoValor.Name = "labelSaldoValor";
            this.labelSaldoValor.Size = new System.Drawing.Size(45, 24);
            this.labelSaldoValor.TabIndex = 4;
            this.labelSaldoValor.Text = "0,00";
            this.labelSaldoValor.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNomeCliente);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(165, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 43);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NOME DO PILANTRA";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.labelNomeCliente.Location = new System.Drawing.Point(6, 19);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(241, 24);
            this.labelNomeCliente.TabIndex = 6;
            this.labelNomeCliente.Text = "GUSTAVO LIMA AE FRUUUU";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonDepositar);
            this.groupBox3.Controls.Add(this.textBoxDeposito);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 63);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Depósito";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(18, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "OPÇÕES:";
            // 
            // textBoxDeposito
            // 
            this.textBoxDeposito.Location = new System.Drawing.Point(9, 24);
            this.textBoxDeposito.Name = "textBoxDeposito";
            this.textBoxDeposito.Size = new System.Drawing.Size(138, 24);
            this.textBoxDeposito.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(497, 267);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 171);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // buttonDepositar
            // 
            this.buttonDepositar.Location = new System.Drawing.Point(154, 24);
            this.buttonDepositar.Name = "buttonDepositar";
            this.buttonDepositar.Size = new System.Drawing.Size(75, 23);
            this.buttonDepositar.TabIndex = 1;
            this.buttonDepositar.Text = "Depositar";
            this.buttonDepositar.UseVisualStyleBackColor = true;
            this.buttonDepositar.Click += new System.EventHandler(this.buttonDepositar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonSacar);
            this.groupBox4.Controls.Add(this.textBoxSacar);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(265, 97);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 63);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sacar";
            // 
            // buttonSacar
            // 
            this.buttonSacar.Location = new System.Drawing.Point(154, 24);
            this.buttonSacar.Name = "buttonSacar";
            this.buttonSacar.Size = new System.Drawing.Size(75, 23);
            this.buttonSacar.TabIndex = 1;
            this.buttonSacar.Text = "Sacar";
            this.buttonSacar.UseVisualStyleBackColor = true;
            this.buttonSacar.Click += new System.EventHandler(this.buttonSacar_Click);
            // 
            // textBoxSacar
            // 
            this.textBoxSacar.Location = new System.Drawing.Point(9, 24);
            this.textBoxSacar.Name = "textBoxSacar";
            this.textBoxSacar.Size = new System.Drawing.Size(138, 24);
            this.textBoxSacar.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Todos os Direitos reservados para mim.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonClique
            // 
            this.buttonClique.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClique.Location = new System.Drawing.Point(265, 422);
            this.buttonClique.Name = "buttonClique";
            this.buttonClique.Size = new System.Drawing.Size(211, 23);
            this.buttonClique.TabIndex = 11;
            this.buttonClique.Text = "CLIQUE AQUI PARA SABER MAIS";
            this.buttonClique.UseVisualStyleBackColor = true;
            this.buttonClique.Click += new System.EventHandler(this.buttonClique_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.labelSaldoValor);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(21, 31);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(144, 43);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Salbo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "R$";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.buttonClique);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Banco";
            this.Text = "Gerador de Robux DES GRACA";
            this.Load += new System.EventHandler(this.Banco_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aRQUIVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.Label labelSaldoValor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDepositar;
        private System.Windows.Forms.TextBox textBoxDeposito;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonSacar;
        private System.Windows.Forms.TextBox textBoxSacar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClique;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
    }
}

