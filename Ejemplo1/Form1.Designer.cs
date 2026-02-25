namespace Ejemplo1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.LwElementos = new System.Windows.Forms.ListView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbPerfil = new System.Windows.Forms.Label();
            this.chbTeGusta = new System.Windows.Forms.CheckBox();
            this.rbChocolate = new System.Windows.Forms.RadioButton();
            this.rbDulceDeLeche = new System.Windows.Forms.RadioButton();
            this.rbFrutilla = new System.Windows.Forms.RadioButton();
            this.lbGustoHelado = new System.Windows.Forms.Label();
            this.cboColorFavorito = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.nmrNumeroPreferido = new System.Windows.Forms.NumericUpDown();
            this.lblNumeroPreferido = new System.Windows.Forms.Label();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.rbVainilla = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNumeroPreferido)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(234, 91);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(373, 465);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseMnemonic = false;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // LwElementos
            // 
            this.LwElementos.HideSelection = false;
            this.LwElementos.Location = new System.Drawing.Point(106, 440);
            this.LwElementos.Name = "LwElementos";
            this.LwElementos.Size = new System.Drawing.Size(221, 154);
            this.LwElementos.TabIndex = 11;
            this.LwElementos.UseCompatibleStateImageBehavior = false;
            this.LwElementos.View = System.Windows.Forms.View.List;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(131, 91);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 21);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.Location = new System.Drawing.Point(26, 143);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(191, 21);
            this.lblFechaNac.TabIndex = 4;
            this.lblFechaNac.Text = "FECHA DE NACIMIENTO";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(234, 143);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 2;
            // 
            // lbPerfil
            // 
            this.lbPerfil.AutoSize = true;
            this.lbPerfil.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPerfil.Location = new System.Drawing.Point(216, 22);
            this.lbPerfil.Name = "lbPerfil";
            this.lbPerfil.Size = new System.Drawing.Size(159, 23);
            this.lbPerfil.TabIndex = 0;
            this.lbPerfil.Text = "PERFIL USUARIO";
            this.lbPerfil.UseWaitCursor = true;
            // 
            // chbTeGusta
            // 
            this.chbTeGusta.AutoSize = true;
            this.chbTeGusta.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTeGusta.Location = new System.Drawing.Point(196, 169);
            this.chbTeGusta.Name = "chbTeGusta";
            this.chbTeGusta.Size = new System.Drawing.Size(156, 20);
            this.chbTeGusta.TabIndex = 7;
            this.chbTeGusta.Text = "Te gusta el chocolate?";
            this.chbTeGusta.UseVisualStyleBackColor = true;
            // 
            // rbChocolate
            // 
            this.rbChocolate.AutoSize = true;
            this.rbChocolate.Location = new System.Drawing.Point(51, 243);
            this.rbChocolate.Name = "rbChocolate";
            this.rbChocolate.Size = new System.Drawing.Size(73, 17);
            this.rbChocolate.TabIndex = 4;
            this.rbChocolate.TabStop = true;
            this.rbChocolate.Text = "Chocolate";
            this.rbChocolate.UseVisualStyleBackColor = true;
            // 
            // rbDulceDeLeche
            // 
            this.rbDulceDeLeche.AutoSize = true;
            this.rbDulceDeLeche.Location = new System.Drawing.Point(210, 243);
            this.rbDulceDeLeche.Name = "rbDulceDeLeche";
            this.rbDulceDeLeche.Size = new System.Drawing.Size(101, 17);
            this.rbDulceDeLeche.TabIndex = 5;
            this.rbDulceDeLeche.TabStop = true;
            this.rbDulceDeLeche.Text = "Dulce de Leche";
            this.rbDulceDeLeche.UseVisualStyleBackColor = true;
            // 
            // rbFrutilla
            // 
            this.rbFrutilla.AutoSize = true;
            this.rbFrutilla.Location = new System.Drawing.Point(373, 243);
            this.rbFrutilla.Name = "rbFrutilla";
            this.rbFrutilla.Size = new System.Drawing.Size(55, 17);
            this.rbFrutilla.TabIndex = 6;
            this.rbFrutilla.TabStop = true;
            this.rbFrutilla.Text = "Frutilla";
            this.rbFrutilla.UseVisualStyleBackColor = true;
            // 
            // lbGustoHelado
            // 
            this.lbGustoHelado.AutoSize = true;
            this.lbGustoHelado.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGustoHelado.Location = new System.Drawing.Point(100, 209);
            this.lbGustoHelado.Name = "lbGustoHelado";
            this.lbGustoHelado.Size = new System.Drawing.Size(193, 16);
            this.lbGustoHelado.TabIndex = 3;
            this.lbGustoHelado.Text = "Que gusto de helado preferís?";
            // 
            // cboColorFavorito
            // 
            this.cboColorFavorito.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboColorFavorito.FormattingEnabled = true;
            this.cboColorFavorito.Items.AddRange(new object[] {
            "amarillo",
            "azul",
            "fucsia"});
            this.cboColorFavorito.Location = new System.Drawing.Point(190, 274);
            this.cboColorFavorito.Name = "cboColorFavorito";
            this.cboColorFavorito.Size = new System.Drawing.Size(244, 24);
            this.cboColorFavorito.TabIndex = 8;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(68, 274);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(95, 16);
            this.lblColor.TabIndex = 13;
            this.lblColor.Text = "Color Favorito";
            // 
            // nmrNumeroPreferido
            // 
            this.nmrNumeroPreferido.Location = new System.Drawing.Point(234, 317);
            this.nmrNumeroPreferido.Name = "nmrNumeroPreferido";
            this.nmrNumeroPreferido.Size = new System.Drawing.Size(120, 20);
            this.nmrNumeroPreferido.TabIndex = 9;
            // 
            // lblNumeroPreferido
            // 
            this.lblNumeroPreferido.AutoSize = true;
            this.lblNumeroPreferido.Location = new System.Drawing.Point(103, 317);
            this.lblNumeroPreferido.Name = "lblNumeroPreferido";
            this.lblNumeroPreferido.Size = new System.Drawing.Size(89, 13);
            this.lblNumeroPreferido.TabIndex = 15;
            this.lblNumeroPreferido.Text = "Número Preferido";
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.Location = new System.Drawing.Point(210, 384);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(101, 23);
            this.btnVerPerfil.TabIndex = 10;
            this.btnVerPerfil.Text = "Ver Perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = true;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // rbVainilla
            // 
            this.rbVainilla.AutoSize = true;
            this.rbVainilla.Location = new System.Drawing.Point(562, 243);
            this.rbVainilla.Name = "rbVainilla";
            this.rbVainilla.Size = new System.Drawing.Size(58, 17);
            this.rbVainilla.TabIndex = 7;
            this.rbVainilla.TabStop = true;
            this.rbVainilla.Text = "Vainilla";
            this.rbVainilla.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 645);
            this.Controls.Add(this.rbVainilla);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.lblNumeroPreferido);
            this.Controls.Add(this.nmrNumeroPreferido);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cboColorFavorito);
            this.Controls.Add(this.lbGustoHelado);
            this.Controls.Add(this.rbFrutilla);
            this.Controls.Add(this.rbDulceDeLeche);
            this.Controls.Add(this.rbChocolate);
            this.Controls.Add(this.chbTeGusta);
            this.Controls.Add(this.lbPerfil);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.LwElementos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmrNumeroPreferido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView LwElementos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lbPerfil;
        private System.Windows.Forms.CheckBox chbTeGusta;
        private System.Windows.Forms.RadioButton rbChocolate;
        private System.Windows.Forms.RadioButton rbDulceDeLeche;
        private System.Windows.Forms.RadioButton rbFrutilla;
        private System.Windows.Forms.Label lbGustoHelado;
        private System.Windows.Forms.ComboBox cboColorFavorito;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.NumericUpDown nmrNumeroPreferido;
        private System.Windows.Forms.Label lblNumeroPreferido;
        private System.Windows.Forms.Button btnVerPerfil;
        private System.Windows.Forms.RadioButton rbVainilla;
    }
}

