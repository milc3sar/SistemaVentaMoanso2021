
namespace CapaPresentacion
{
    partial class MantenedorCliente
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
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_disable = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.gb_area = new System.Windows.Forms.GroupBox();
            this.lbl_fechaRegistro = new System.Windows.Forms.Label();
            this.cb_estadoCliente = new System.Windows.Forms.CheckBox();
            this.dtp_fechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.txtb_cliente = new System.Windows.Forms.TextBox();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_ciudad = new System.Windows.Forms.Label();
            this.txtb_tipoCliente = new System.Windows.Forms.TextBox();
            this.lbl_idTipoCliente = new System.Windows.Forms.Label();
            this.txtb_razonsocial = new System.Windows.Forms.TextBox();
            this.lb_razonsocial = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.gb_area.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(36, 32);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(758, 227);
            this.dgvCliente.TabIndex = 0;
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_new.Location = new System.Drawing.Point(839, 32);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(110, 50);
            this.btn_new.TabIndex = 1;
            this.btn_new.Text = "Nuevo";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_edit.Location = new System.Drawing.Point(839, 90);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(110, 50);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Editar";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_disable
            // 
            this.btn_disable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_disable.Location = new System.Drawing.Point(839, 146);
            this.btn_disable.Name = "btn_disable";
            this.btn_disable.Size = new System.Drawing.Size(110, 50);
            this.btn_disable.TabIndex = 3;
            this.btn_disable.Text = "Deshabilitar";
            this.btn_disable.UseVisualStyleBackColor = true;
            this.btn_disable.Click += new System.EventHandler(this.btn_disable_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_exit.Location = new System.Drawing.Point(839, 202);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(110, 46);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Salir";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(803, 56);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(114, 46);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Agregar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Location = new System.Drawing.Point(803, 108);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(114, 46);
            this.btn_modify.TabIndex = 6;
            this.btn_modify.Text = "Modificar";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(803, 160);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(114, 46);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // gb_area
            // 
            this.gb_area.Controls.Add(this.lbl_fechaRegistro);
            this.gb_area.Controls.Add(this.cb_estadoCliente);
            this.gb_area.Controls.Add(this.dtp_fechaRegistro);
            this.gb_area.Controls.Add(this.txt_ciudad);
            this.gb_area.Controls.Add(this.txtb_cliente);
            this.gb_area.Controls.Add(this.lbl_cliente);
            this.gb_area.Controls.Add(this.lbl_ciudad);
            this.gb_area.Controls.Add(this.txtb_tipoCliente);
            this.gb_area.Controls.Add(this.lbl_idTipoCliente);
            this.gb_area.Controls.Add(this.txtb_razonsocial);
            this.gb_area.Controls.Add(this.lb_razonsocial);
            this.gb_area.Controls.Add(this.btn_add);
            this.gb_area.Controls.Add(this.btn_cancel);
            this.gb_area.Controls.Add(this.btn_modify);
            this.gb_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.gb_area.Location = new System.Drawing.Point(36, 279);
            this.gb_area.Name = "gb_area";
            this.gb_area.Size = new System.Drawing.Size(942, 236);
            this.gb_area.TabIndex = 8;
            this.gb_area.TabStop = false;
            this.gb_area.Text = "Datos Cliente";
            // 
            // lbl_fechaRegistro
            // 
            this.lbl_fechaRegistro.AutoSize = true;
            this.lbl_fechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_fechaRegistro.Location = new System.Drawing.Point(12, 178);
            this.lbl_fechaRegistro.Name = "lbl_fechaRegistro";
            this.lbl_fechaRegistro.Size = new System.Drawing.Size(109, 18);
            this.lbl_fechaRegistro.TabIndex = 18;
            this.lbl_fechaRegistro.Text = "Fecha Registro";
            // 
            // cb_estadoCliente
            // 
            this.cb_estadoCliente.AutoSize = true;
            this.cb_estadoCliente.Location = new System.Drawing.Point(554, 35);
            this.cb_estadoCliente.Name = "cb_estadoCliente";
            this.cb_estadoCliente.Size = new System.Drawing.Size(116, 21);
            this.cb_estadoCliente.TabIndex = 17;
            this.cb_estadoCliente.Text = "Estado cliente";
            this.cb_estadoCliente.UseVisualStyleBackColor = true;
            // 
            // dtp_fechaRegistro
            // 
            this.dtp_fechaRegistro.Location = new System.Drawing.Point(127, 175);
            this.dtp_fechaRegistro.Name = "dtp_fechaRegistro";
            this.dtp_fechaRegistro.Size = new System.Drawing.Size(273, 23);
            this.dtp_fechaRegistro.TabIndex = 16;
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Location = new System.Drawing.Point(72, 141);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(318, 23);
            this.txt_ciudad.TabIndex = 15;
            // 
            // txtb_cliente
            // 
            this.txtb_cliente.Location = new System.Drawing.Point(71, 33);
            this.txtb_cliente.Name = "txtb_cliente";
            this.txtb_cliente.Size = new System.Drawing.Size(186, 23);
            this.txtb_cliente.TabIndex = 14;
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_cliente.Location = new System.Drawing.Point(12, 34);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(53, 18);
            this.lbl_cliente.TabIndex = 13;
            this.lbl_cliente.Text = "Cliente";
            // 
            // lbl_ciudad
            // 
            this.lbl_ciudad.AutoSize = true;
            this.lbl_ciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_ciudad.Location = new System.Drawing.Point(12, 142);
            this.lbl_ciudad.Name = "lbl_ciudad";
            this.lbl_ciudad.Size = new System.Drawing.Size(54, 18);
            this.lbl_ciudad.TabIndex = 12;
            this.lbl_ciudad.Text = "Ciudad";
            // 
            // txtb_tipoCliente
            // 
            this.txtb_tipoCliente.Location = new System.Drawing.Point(104, 103);
            this.txtb_tipoCliente.Name = "txtb_tipoCliente";
            this.txtb_tipoCliente.Size = new System.Drawing.Size(318, 23);
            this.txtb_tipoCliente.TabIndex = 11;
            // 
            // lbl_idTipoCliente
            // 
            this.lbl_idTipoCliente.AutoSize = true;
            this.lbl_idTipoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_idTipoCliente.Location = new System.Drawing.Point(12, 108);
            this.lbl_idTipoCliente.Name = "lbl_idTipoCliente";
            this.lbl_idTipoCliente.Size = new System.Drawing.Size(86, 18);
            this.lbl_idTipoCliente.TabIndex = 10;
            this.lbl_idTipoCliente.Text = "Tipo Cliente";
            // 
            // txtb_razonsocial
            // 
            this.txtb_razonsocial.Location = new System.Drawing.Point(115, 69);
            this.txtb_razonsocial.Name = "txtb_razonsocial";
            this.txtb_razonsocial.Size = new System.Drawing.Size(318, 23);
            this.txtb_razonsocial.TabIndex = 9;
            // 
            // lb_razonsocial
            // 
            this.lb_razonsocial.AutoSize = true;
            this.lb_razonsocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lb_razonsocial.Location = new System.Drawing.Point(12, 74);
            this.lb_razonsocial.Name = "lb_razonsocial";
            this.lb_razonsocial.Size = new System.Drawing.Size(97, 18);
            this.lb_razonsocial.TabIndex = 8;
            this.lb_razonsocial.Text = "Razon Social";
            // 
            // MantenedorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 541);
            this.Controls.Add(this.gb_area);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_disable);
            this.Controls.Add(this.btn_edit);
            this.Name = "MantenedorCliente";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.gb_area.ResumeLayout(false);
            this.gb_area.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_disable;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox gb_area;
        private System.Windows.Forms.TextBox txtb_razonsocial;
        private System.Windows.Forms.Label lb_razonsocial;
        private System.Windows.Forms.Label lbl_idTipoCliente;
        private System.Windows.Forms.TextBox txtb_tipoCliente;
        private System.Windows.Forms.TextBox txtb_cliente;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label lbl_ciudad;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.DateTimePicker dtp_fechaRegistro;
        private System.Windows.Forms.CheckBox cb_estadoCliente;
        private System.Windows.Forms.Label lbl_fechaRegistro;
    }
}

