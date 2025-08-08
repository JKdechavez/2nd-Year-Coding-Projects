namespace WorkingWithMSQL
{
    partial class Form1
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
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentdbDataSet = new WorkingWithMSQL.studentdbDataSet();
            this.studentTableAdapter = new WorkingWithMSQL.studentdbDataSetTableAdapters.studentTableAdapter();
            this.tableAdapterManager = new WorkingWithMSQL.studentdbDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.studentdbDataSet;
            // 
            // studentdbDataSet
            // 
            this.studentdbDataSet.DataSetName = "studentdbDataSet";
            this.studentdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.studentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.UpdateOrder = WorkingWithMSQL.studentdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 321);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private studentdbDataSet studentdbDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private studentdbDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private studentdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
    }
}

