namespace ConsultaCEP
{
    partial class frmCep
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
            System.Windows.Forms.Button btnPesquisar;
            System.Windows.Forms.Button btnLimpar;
            this.label1 = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblUnidadePost = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblEstadoRes = new System.Windows.Forms.Label();
            this.lblCidadeRes = new System.Windows.Forms.Label();
            this.lblUnidadePostRes = new System.Windows.Forms.Label();
            this.lblBairroRes = new System.Windows.Forms.Label();
            this.lblEnderecoRes = new System.Windows.Forms.Label();
            this.lblComplementoRes = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            btnPesquisar = new System.Windows.Forms.Button();
            btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(44, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cep:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.Color.Transparent;
            this.lblCidade.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.ForeColor = System.Drawing.Color.Black;
            this.lblCidade.Location = new System.Drawing.Point(11, 193);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(79, 22);
            this.lblCidade.TabIndex = 1;
            this.lblCidade.Text = "CIDADE:";
            this.lblCidade.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.BackColor = System.Drawing.Color.Transparent;
            this.lblEndereco.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.ForeColor = System.Drawing.Color.Black;
            this.lblEndereco.Location = new System.Drawing.Point(11, 235);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(110, 22);
            this.lblEndereco.TabIndex = 2;
            this.lblEndereco.Text = "ENDEREÇO:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.BackColor = System.Drawing.Color.Transparent;
            this.lblComplemento.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.ForeColor = System.Drawing.Color.Black;
            this.lblComplemento.Location = new System.Drawing.Point(11, 277);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(147, 22);
            this.lblComplemento.TabIndex = 3;
            this.lblComplemento.Text = "COMPLEMENTO:";
            this.lblComplemento.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.BackColor = System.Drawing.Color.Transparent;
            this.lblBairro.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ForeColor = System.Drawing.Color.Black;
            this.lblBairro.Location = new System.Drawing.Point(11, 319);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(82, 22);
            this.lblBairro.TabIndex = 4;
            this.lblBairro.Text = "BAIRRO:";
            this.lblBairro.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblUnidadePost
            // 
            this.lblUnidadePost.AutoSize = true;
            this.lblUnidadePost.BackColor = System.Drawing.Color.Transparent;
            this.lblUnidadePost.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadePost.ForeColor = System.Drawing.Color.Black;
            this.lblUnidadePost.Location = new System.Drawing.Point(11, 361);
            this.lblUnidadePost.Name = "lblUnidadePost";
            this.lblUnidadePost.Size = new System.Drawing.Size(143, 22);
            this.lblUnidadePost.TabIndex = 5;
            this.lblUnidadePost.Text = "UNIDADE POST:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(11, 151);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(84, 22);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "ESTADO:";
            this.lblEstado.Click += new System.EventHandler(this.lblEstado_Click);
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            btnPesquisar.BackgroundImage = global::ConsultaCEP.Properties.Resources.pngtree_technology_blue_background_picture_image_909788;
            btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnPesquisar.Font = new System.Drawing.Font("PMingLiU-ExtB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnPesquisar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnPesquisar.Location = new System.Drawing.Point(39, 68);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new System.Drawing.Size(255, 59);
            btnPesquisar.TabIndex = 7;
            btnPesquisar.Text = "Pesquisar!";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = System.Drawing.Color.Transparent;
            btnLimpar.BackgroundImage = global::ConsultaCEP.Properties.Resources.pngtree_technology_blue_background_picture_image_909788;
            btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnLimpar.Location = new System.Drawing.Point(97, 399);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new System.Drawing.Size(132, 39);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "Limpar!";
            btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblEstadoRes
            // 
            this.lblEstadoRes.AutoSize = true;
            this.lblEstadoRes.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoRes.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoRes.ForeColor = System.Drawing.Color.White;
            this.lblEstadoRes.Location = new System.Drawing.Point(91, 151);
            this.lblEstadoRes.Name = "lblEstadoRes";
            this.lblEstadoRes.Size = new System.Drawing.Size(120, 18);
            this.lblEstadoRes.TabIndex = 9;
            this.lblEstadoRes.Text = "______________";
            // 
            // lblCidadeRes
            // 
            this.lblCidadeRes.AutoSize = true;
            this.lblCidadeRes.BackColor = System.Drawing.Color.Transparent;
            this.lblCidadeRes.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeRes.ForeColor = System.Drawing.Color.White;
            this.lblCidadeRes.Location = new System.Drawing.Point(89, 193);
            this.lblCidadeRes.Name = "lblCidadeRes";
            this.lblCidadeRes.Size = new System.Drawing.Size(122, 22);
            this.lblCidadeRes.TabIndex = 10;
            this.lblCidadeRes.Text = "______________";
            this.lblCidadeRes.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblUnidadePostRes
            // 
            this.lblUnidadePostRes.AutoSize = true;
            this.lblUnidadePostRes.BackColor = System.Drawing.Color.Transparent;
            this.lblUnidadePostRes.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadePostRes.ForeColor = System.Drawing.Color.White;
            this.lblUnidadePostRes.Location = new System.Drawing.Point(152, 361);
            this.lblUnidadePostRes.Name = "lblUnidadePostRes";
            this.lblUnidadePostRes.Size = new System.Drawing.Size(122, 22);
            this.lblUnidadePostRes.TabIndex = 11;
            this.lblUnidadePostRes.Text = "______________";
            // 
            // lblBairroRes
            // 
            this.lblBairroRes.AutoSize = true;
            this.lblBairroRes.BackColor = System.Drawing.Color.Transparent;
            this.lblBairroRes.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairroRes.ForeColor = System.Drawing.Color.White;
            this.lblBairroRes.Location = new System.Drawing.Point(92, 319);
            this.lblBairroRes.Name = "lblBairroRes";
            this.lblBairroRes.Size = new System.Drawing.Size(122, 22);
            this.lblBairroRes.TabIndex = 12;
            this.lblBairroRes.Text = "______________";
            // 
            // lblEnderecoRes
            // 
            this.lblEnderecoRes.AutoSize = true;
            this.lblEnderecoRes.BackColor = System.Drawing.Color.Transparent;
            this.lblEnderecoRes.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderecoRes.ForeColor = System.Drawing.Color.White;
            this.lblEnderecoRes.Location = new System.Drawing.Point(115, 235);
            this.lblEnderecoRes.Name = "lblEnderecoRes";
            this.lblEnderecoRes.Size = new System.Drawing.Size(122, 22);
            this.lblEnderecoRes.TabIndex = 13;
            this.lblEnderecoRes.Text = "______________";
            // 
            // lblComplementoRes
            // 
            this.lblComplementoRes.AutoSize = true;
            this.lblComplementoRes.BackColor = System.Drawing.Color.Transparent;
            this.lblComplementoRes.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplementoRes.ForeColor = System.Drawing.Color.White;
            this.lblComplementoRes.Location = new System.Drawing.Point(152, 277);
            this.lblComplementoRes.Name = "lblComplementoRes";
            this.lblComplementoRes.Size = new System.Drawing.Size(122, 22);
            this.lblComplementoRes.TabIndex = 14;
            this.lblComplementoRes.Text = "______________";
            // 
            // txtCep
            // 
            this.txtCep.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(108, 24);
            this.txtCep.MaxLength = 11;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(183, 22);
            this.txtCep.TabIndex = 15;
            // 
            // frmCep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConsultaCEP.Properties.Resources.pngtree_technology_blue_background_picture_image_909788;
            this.ClientSize = new System.Drawing.Size(331, 450);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.lblComplementoRes);
            this.Controls.Add(this.lblEnderecoRes);
            this.Controls.Add(this.lblBairroRes);
            this.Controls.Add(this.lblUnidadePostRes);
            this.Controls.Add(this.lblCidadeRes);
            this.Controls.Add(this.lblEstadoRes);
            this.Controls.Add(btnLimpar);
            this.Controls.Add(btnPesquisar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblUnidadePost);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Cep!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblUnidadePost;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblEstadoRes;
        private System.Windows.Forms.Label lblCidadeRes;
        private System.Windows.Forms.Label lblUnidadePostRes;
        private System.Windows.Forms.Label lblBairroRes;
        private System.Windows.Forms.Label lblEnderecoRes;
        private System.Windows.Forms.Label lblComplementoRes;
        private System.Windows.Forms.TextBox txtCep;
    }
}

