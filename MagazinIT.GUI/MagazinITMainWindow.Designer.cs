namespace MagazinIT.GUI
{
    partial class MagazinITMainWindow
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
            this.Type = new System.Windows.Forms.ComboBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.produseGridView = new System.Windows.Forms.DataGridView();
            this.produseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazinITDataSet1 = new MagazinIT.GUI.MagazinITDataSet1();
            this.produseTableAdapter = new MagazinIT.GUI.MagazinITDataSet1TableAdapters.ProduseTableAdapter();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnQuantityInput = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cosGridView = new System.Windows.Forms.DataGridView();
            this.rbAscended = new System.Windows.Forms.RadioButton();
            this.rbDescended = new System.Windows.Forms.RadioButton();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.produseGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinITDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Type
            // 
            this.Type.AllowDrop = true;
            this.Type.FormattingEnabled = true;
            this.Type.Location = new System.Drawing.Point(32, 281);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(121, 21);
            this.Type.TabIndex = 1;
            this.Type.Text = "Type";
            this.Type.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
            this.Type.SelectedValueChanged += new System.EventHandler(this.MagazinITMainWindow_Load);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(197, 308);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 2;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // produseGridView
            // 
            this.produseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produseGridView.Location = new System.Drawing.Point(32, 26);
            this.produseGridView.Name = "produseGridView";
            this.produseGridView.Size = new System.Drawing.Size(529, 239);
            this.produseGridView.TabIndex = 3;
            // 
            // produseBindingSource
            // 
            this.produseBindingSource.DataMember = "Produse";
            this.produseBindingSource.DataSource = this.magazinITDataSet1;
            // 
            // magazinITDataSet1
            // 
            this.magazinITDataSet1.DataSetName = "MagazinITDataSet1";
            this.magazinITDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produseTableAdapter
            // 
            this.produseTableAdapter.ClearBeforeFill = true;
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(197, 279);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(75, 23);
            this.btnshow.TabIndex = 4;
            this.btnshow.Text = "Show All";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnQuantityInput
            // 
            this.btnQuantityInput.Location = new System.Drawing.Point(77, 311);
            this.btnQuantityInput.Name = "btnQuantityInput";
            this.btnQuantityInput.Size = new System.Drawing.Size(100, 20);
            this.btnQuantityInput.TabIndex = 5;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(29, 315);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity";
            // 
            // cosGridView
            // 
            this.cosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cosGridView.Location = new System.Drawing.Point(598, 26);
            this.cosGridView.Name = "cosGridView";
            this.cosGridView.Size = new System.Drawing.Size(240, 150);
            this.cosGridView.TabIndex = 7;
            // 
            // rbAscended
            // 
            this.rbAscended.AutoSize = true;
            this.rbAscended.Location = new System.Drawing.Point(612, 200);
            this.rbAscended.Name = "rbAscended";
            this.rbAscended.Size = new System.Drawing.Size(73, 17);
            this.rbAscended.TabIndex = 8;
            this.rbAscended.TabStop = true;
            this.rbAscended.Text = "Ascended";
            this.rbAscended.UseVisualStyleBackColor = true;
            this.rbAscended.CheckedChanged += new System.EventHandler(this.rbAscended_CheckedChanged);
            // 
            // rbDescended
            // 
            this.rbDescended.AutoSize = true;
            this.rbDescended.Location = new System.Drawing.Point(612, 235);
            this.rbDescended.Name = "rbDescended";
            this.rbDescended.Size = new System.Drawing.Size(80, 17);
            this.rbDescended.TabIndex = 9;
            this.rbDescended.TabStop = true;
            this.rbDescended.Text = "Descended";
            this.rbDescended.UseVisualStyleBackColor = true;
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(736, 197);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(75, 23);
            this.btnCos.TabIndex = 10;
            this.btnCos.Text = "Cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(736, 229);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 23);
            this.btnTotal.TabIndex = 11;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // MagazinITMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 367);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.rbDescended);
            this.Controls.Add(this.rbAscended);
            this.Controls.Add(this.cosGridView);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnQuantityInput);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.produseGridView);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.Type);
            this.Name = "MagazinITMainWindow";
            this.Text = "MagazinITMainWindow";
            this.Load += new System.EventHandler(this.MagazinITMainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produseGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazinITDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.DataGridView produseGridView;
        private MagazinITDataSet1 magazinITDataSet1;
        private System.Windows.Forms.BindingSource produseBindingSource;
        private MagazinITDataSet1TableAdapters.ProduseTableAdapter produseTableAdapter;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.TextBox btnQuantityInput;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.DataGridView cosGridView;
        private System.Windows.Forms.RadioButton rbAscended;
        private System.Windows.Forms.RadioButton rbDescended;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnTotal;
    }
}