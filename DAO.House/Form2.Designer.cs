namespace DAO.House
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label categoriaIdLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label descontinuadoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label stockLabel;
            this.categoriaIdTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.descontinuadoCheckBox = new System.Windows.Forms.CheckBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            categoriaIdLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            descontinuadoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriaIdLabel
            // 
            categoriaIdLabel.AutoSize = true;
            categoriaIdLabel.Location = new System.Drawing.Point(31, 34);
            categoriaIdLabel.Name = "categoriaIdLabel";
            categoriaIdLabel.Size = new System.Drawing.Size(67, 13);
            categoriaIdLabel.TabIndex = 1;
            categoriaIdLabel.Text = "Categoria Id:";
            // 
            // categoriaIdTextBox
            // 
            this.categoriaIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "CategoriaId", true));
            this.categoriaIdTextBox.Location = new System.Drawing.Point(119, 31);
            this.categoriaIdTextBox.Name = "categoriaIdTextBox";
            this.categoriaIdTextBox.Size = new System.Drawing.Size(104, 20);
            this.categoriaIdTextBox.TabIndex = 2;
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(31, 60);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 3;
            codigoLabel.Text = "Codigo:";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(119, 57);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(104, 20);
            this.codigoTextBox.TabIndex = 4;
            // 
            // descontinuadoLabel
            // 
            descontinuadoLabel.AutoSize = true;
            descontinuadoLabel.Location = new System.Drawing.Point(31, 88);
            descontinuadoLabel.Name = "descontinuadoLabel";
            descontinuadoLabel.Size = new System.Drawing.Size(82, 13);
            descontinuadoLabel.TabIndex = 5;
            descontinuadoLabel.Text = "Descontinuado:";
            // 
            // descontinuadoCheckBox
            // 
            this.descontinuadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productoBindingSource, "Descontinuado", true));
            this.descontinuadoCheckBox.Location = new System.Drawing.Point(119, 83);
            this.descontinuadoCheckBox.Name = "descontinuadoCheckBox";
            this.descontinuadoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.descontinuadoCheckBox.TabIndex = 6;
            this.descontinuadoCheckBox.Text = "checkBox1";
            this.descontinuadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(31, 116);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 7;
            descripcionLabel.Text = "Descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(119, 113);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(104, 20);
            this.descripcionTextBox.TabIndex = 8;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(31, 142);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 9;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(119, 139);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(104, 20);
            this.idTextBox.TabIndex = 10;
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(31, 168);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 11;
            precioLabel.Text = "Precio:";
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(119, 165);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(104, 20);
            this.precioTextBox.TabIndex = 12;
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Location = new System.Drawing.Point(31, 194);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(38, 13);
            stockLabel.TabIndex = 13;
            stockLabel.Text = "Stock:";
            // 
            // stockTextBox
            // 
            this.stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Stock", true));
            this.stockTextBox.Location = new System.Drawing.Point(119, 191);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(104, 20);
            this.stockTextBox.TabIndex = 14;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(DAO.House.Producto);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 262);
            this.Controls.Add(categoriaIdLabel);
            this.Controls.Add(this.categoriaIdTextBox);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(descontinuadoLabel);
            this.Controls.Add(this.descontinuadoCheckBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(stockLabel);
            this.Controls.Add(this.stockTextBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.TextBox categoriaIdTextBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.CheckBox descontinuadoCheckBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox stockTextBox;
    }
}