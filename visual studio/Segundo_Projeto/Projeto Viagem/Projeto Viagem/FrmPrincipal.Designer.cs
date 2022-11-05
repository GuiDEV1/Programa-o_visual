namespace Projeto_Viagem
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lbDistancia = new System.Windows.Forms.Label();
            this.lbConsumo = new System.Windows.Forms.Label();
            this.lbConbustivel = new System.Windows.Forms.Label();
            this.lbPedagio = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.txtCombustivel = new System.Windows.Forms.TextBox();
            this.txtPedagio = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDistancia
            // 
            this.lbDistancia.AutoSize = true;
            this.lbDistancia.BackColor = System.Drawing.Color.Transparent;
            this.lbDistancia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDistancia.ForeColor = System.Drawing.Color.White;
            this.lbDistancia.Location = new System.Drawing.Point(33, 94);
            this.lbDistancia.Name = "lbDistancia";
            this.lbDistancia.Size = new System.Drawing.Size(185, 26);
            this.lbDistancia.TabIndex = 0;
            this.lbDistancia.Text = "Distância a percorrer";
            this.lbDistancia.Click += new System.EventHandler(this.lbDistancia_Click);
            // 
            // lbConsumo
            // 
            this.lbConsumo.AutoSize = true;
            this.lbConsumo.BackColor = System.Drawing.Color.Transparent;
            this.lbConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsumo.ForeColor = System.Drawing.Color.White;
            this.lbConsumo.Location = new System.Drawing.Point(33, 142);
            this.lbConsumo.Name = "lbConsumo";
            this.lbConsumo.Size = new System.Drawing.Size(242, 24);
            this.lbConsumo.TabIndex = 1;
            this.lbConsumo.Text = "Consumo médio do veiculo";
            this.lbConsumo.Click += new System.EventHandler(this.lbConsumo_Click);
            // 
            // lbConbustivel
            // 
            this.lbConbustivel.AutoSize = true;
            this.lbConbustivel.BackColor = System.Drawing.Color.Transparent;
            this.lbConbustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConbustivel.ForeColor = System.Drawing.Color.White;
            this.lbConbustivel.Location = new System.Drawing.Point(33, 190);
            this.lbConbustivel.Name = "lbConbustivel";
            this.lbConbustivel.Size = new System.Drawing.Size(277, 24);
            this.lbConbustivel.TabIndex = 2;
            this.lbConbustivel.Text = "Valor médio do combustivel: R$";
            this.lbConbustivel.Click += new System.EventHandler(this.lbConbustivel_Click);
            // 
            // lbPedagio
            // 
            this.lbPedagio.AutoSize = true;
            this.lbPedagio.BackColor = System.Drawing.Color.Transparent;
            this.lbPedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPedagio.ForeColor = System.Drawing.Color.White;
            this.lbPedagio.Location = new System.Drawing.Point(33, 238);
            this.lbPedagio.Name = "lbPedagio";
            this.lbPedagio.Size = new System.Drawing.Size(253, 24);
            this.lbPedagio.TabIndex = 3;
            this.lbPedagio.Text = "Valor gasto com pedagio: R$";
            this.lbPedagio.Click += new System.EventHandler(this.lbPedagio_Click);
            // 
            // txtDistancia
            // 
            this.txtDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistancia.Location = new System.Drawing.Point(341, 94);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(149, 29);
            this.txtDistancia.TabIndex = 4;
            // 
            // txtConsumo
            // 
            this.txtConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumo.Location = new System.Drawing.Point(341, 142);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(149, 29);
            this.txtConsumo.TabIndex = 5;
            // 
            // txtCombustivel
            // 
            this.txtCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombustivel.Location = new System.Drawing.Point(341, 190);
            this.txtCombustivel.Name = "txtCombustivel";
            this.txtCombustivel.Size = new System.Drawing.Size(149, 29);
            this.txtCombustivel.TabIndex = 6;
            // 
            // txtPedagio
            // 
            this.txtPedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedagio.Location = new System.Drawing.Point(341, 238);
            this.txtPedagio.Name = "txtPedagio";
            this.txtPedagio.Size = new System.Drawing.Size(149, 29);
            this.txtPedagio.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(570, 362);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(201, 49);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::Projeto_Viagem.Properties.Resources.karsten_wurth_rafblRbne3o_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPedagio);
            this.Controls.Add(this.txtCombustivel);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.lbPedagio);
            this.Controls.Add(this.lbConbustivel);
            this.Controls.Add(this.lbConsumo);
            this.Controls.Add(this.lbDistancia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "Calculadora Da Viagem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDistancia;
        private System.Windows.Forms.Label lbConsumo;
        private System.Windows.Forms.Label lbConbustivel;
        private System.Windows.Forms.Label lbPedagio;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.TextBox txtCombustivel;
        private System.Windows.Forms.TextBox txtPedagio;
        private System.Windows.Forms.Button btnCalcular;
    }
}

