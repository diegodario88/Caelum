namespace Caelum
{
    partial class Dashboard
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
            this.lblDash = new System.Windows.Forms.Label();
            this.bntDeposito = new System.Windows.Forms.Button();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.btnSaque = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTransferencia = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboDestinoTransferencia = new System.Windows.Forms.ComboBox();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.lblBuscaConta = new System.Windows.Forms.Label();
            this.btnNovaConta = new System.Windows.Forms.Button();
            this.btnImposto = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDash
            // 
            this.lblDash.AutoSize = true;
            this.lblDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDash.Location = new System.Drawing.Point(56, 9);
            this.lblDash.Name = "lblDash";
            this.lblDash.Size = new System.Drawing.Size(280, 42);
            this.lblDash.TabIndex = 0;
            this.lblDash.Text = "Exemplo Banco";
            // 
            // bntDeposito
            // 
            this.bntDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDeposito.Location = new System.Drawing.Point(21, 328);
            this.bntDeposito.Name = "bntDeposito";
            this.bntDeposito.Size = new System.Drawing.Size(103, 35);
            this.bntDeposito.TabIndex = 1;
            this.bntDeposito.Text = "Depositar";
            this.bntDeposito.UseVisualStyleBackColor = true;
            this.bntDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(173, 30);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(158, 20);
            this.textoTitular.TabIndex = 2;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(173, 66);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(158, 20);
            this.textoNumero.TabIndex = 3;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(173, 98);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(158, 20);
            this.textoSaldo.TabIndex = 4;
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(173, 192);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(158, 20);
            this.textoValor.TabIndex = 6;
            // 
            // btnSaque
            // 
            this.btnSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaque.Location = new System.Drawing.Point(151, 328);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(103, 35);
            this.btnSaque.TabIndex = 7;
            this.btnSaque.Text = "Sacar";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Titular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Número";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Saldo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTransferencia);
            this.groupBox1.Controls.Add(this.textoTitular);
            this.groupBox1.Controls.Add(this.bntDeposito);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.btnSaque);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textoNumero);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textoSaldo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textoValor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(63, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 396);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferencia.Location = new System.Drawing.Point(275, 328);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(116, 35);
            this.btnTransferencia.TabIndex = 15;
            this.btnTransferencia.Text = "Transferir";
            this.btnTransferencia.UseVisualStyleBackColor = true;
            this.btnTransferencia.Click += new System.EventHandler(this.btnTransferencia_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(337, 66);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(36, 16);
            this.lblTipo.TabIndex = 13;
            this.lblTipo.Text = "Tipo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboDestinoTransferencia);
            this.groupBox2.Controls.Add(this.comboContas);
            this.groupBox2.Controls.Add(this.lblBuscaConta);
            this.groupBox2.Location = new System.Drawing.Point(63, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 164);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busca de conta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Conta Destino";
            // 
            // comboDestinoTransferencia
            // 
            this.comboDestinoTransferencia.FormattingEnabled = true;
            this.comboDestinoTransferencia.Location = new System.Drawing.Point(173, 96);
            this.comboDestinoTransferencia.Name = "comboDestinoTransferencia";
            this.comboDestinoTransferencia.Size = new System.Drawing.Size(197, 21);
            this.comboDestinoTransferencia.TabIndex = 16;
            this.comboDestinoTransferencia.SelectedIndexChanged += new System.EventHandler(this.comboDestinoTransferencia_SelectedIndexChanged);
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(173, 35);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(197, 21);
            this.comboContas.TabIndex = 15;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // lblBuscaConta
            // 
            this.lblBuscaConta.AutoSize = true;
            this.lblBuscaConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaConta.Location = new System.Drawing.Point(17, 33);
            this.lblBuscaConta.Name = "lblBuscaConta";
            this.lblBuscaConta.Size = new System.Drawing.Size(107, 20);
            this.lblBuscaConta.TabIndex = 14;
            this.lblBuscaConta.Text = "Conta Origem";
            // 
            // btnNovaConta
            // 
            this.btnNovaConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaConta.Location = new System.Drawing.Point(63, 714);
            this.btnNovaConta.Name = "btnNovaConta";
            this.btnNovaConta.Size = new System.Drawing.Size(128, 35);
            this.btnNovaConta.TabIndex = 16;
            this.btnNovaConta.Text = "Nova Conta";
            this.btnNovaConta.UseVisualStyleBackColor = true;
            this.btnNovaConta.Click += new System.EventHandler(this.btnNovaConta_Click);
            // 
            // btnImposto
            // 
            this.btnImposto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImposto.Location = new System.Drawing.Point(214, 714);
            this.btnImposto.Name = "btnImposto";
            this.btnImposto.Size = new System.Drawing.Size(128, 35);
            this.btnImposto.TabIndex = 17;
            this.btnImposto.Text = "Impostos";
            this.btnImposto.UseVisualStyleBackColor = true;
            this.btnImposto.Click += new System.EventHandler(this.btnImposto_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 775);
            this.Controls.Add(this.btnImposto);
            this.Controls.Add(this.btnNovaConta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblDash);
            this.Controls.Add(this.groupBox1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDash;
        private System.Windows.Forms.Button bntDeposito;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBuscaConta;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.Button btnTransferencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboDestinoTransferencia;
        private System.Windows.Forms.Button btnNovaConta;
        private System.Windows.Forms.Button btnImposto;
    }
}

