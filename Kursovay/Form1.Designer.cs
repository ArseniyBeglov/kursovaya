
namespace Kursovay
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OR = new System.Windows.Forms.Button();
            this.AND = new System.Windows.Forms.Button();
            this.NOT = new System.Windows.Forms.Button();
            this.XOR = new System.Windows.Forms.Button();
            this.NAND = new System.Windows.Forms.Button();
            this.NOR = new System.Windows.Forms.Button();
            this.A_Buttom = new System.Windows.Forms.Button();
            this.B_Buttom = new System.Windows.Forms.Button();
            this.C_Buttom = new System.Windows.Forms.Button();
            this.D_Buttom = new System.Windows.Forms.Button();
            this.Left_Bracket = new System.Windows.Forms.Button();
            this.Rigth_Bracket = new System.Windows.Forms.Button();
            this.Generatic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(274, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(720, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Y=";
            // 
            // OR
            // 
            this.OR.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.OR.Location = new System.Drawing.Point(274, 179);
            this.OR.Name = "OR";
            this.OR.Size = new System.Drawing.Size(60, 60);
            this.OR.TabIndex = 1;
            this.OR.Text = "∨";
            this.OR.UseVisualStyleBackColor = true;
            this.OR.Click += new System.EventHandler(this.OR_Click);
            // 
            // AND
            // 
            this.AND.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.AND.Location = new System.Drawing.Point(386, 179);
            this.AND.Name = "AND";
            this.AND.Size = new System.Drawing.Size(60, 60);
            this.AND.TabIndex = 2;
            this.AND.Text = "∧";
            this.AND.UseVisualStyleBackColor = true;
            this.AND.Click += new System.EventHandler(this.AND_Click);
            // 
            // NOT
            // 
            this.NOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.NOT.Location = new System.Drawing.Point(503, 179);
            this.NOT.Name = "NOT";
            this.NOT.Size = new System.Drawing.Size(60, 60);
            this.NOT.TabIndex = 3;
            this.NOT.Text = "¬";
            this.NOT.UseVisualStyleBackColor = true;
            this.NOT.Click += new System.EventHandler(this.NOT_Click);
            // 
            // XOR
            // 
            this.XOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.XOR.Location = new System.Drawing.Point(626, 179);
            this.XOR.Name = "XOR";
            this.XOR.Size = new System.Drawing.Size(60, 60);
            this.XOR.TabIndex = 4;
            this.XOR.Text = "⊕";
            this.XOR.UseVisualStyleBackColor = true;
            this.XOR.Click += new System.EventHandler(this.XOR_Click);
            // 
            // NAND
            // 
            this.NAND.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.NAND.Location = new System.Drawing.Point(745, 179);
            this.NAND.Name = "NAND";
            this.NAND.Size = new System.Drawing.Size(60, 60);
            this.NAND.TabIndex = 5;
            this.NAND.Text = "|";
            this.NAND.UseVisualStyleBackColor = true;
            this.NAND.Click += new System.EventHandler(this.NAND_Click);
            // 
            // NOR
            // 
            this.NOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.NOR.Location = new System.Drawing.Point(862, 179);
            this.NOR.Name = "NOR";
            this.NOR.Size = new System.Drawing.Size(60, 60);
            this.NOR.TabIndex = 6;
            this.NOR.Text = "↓";
            this.NOR.UseVisualStyleBackColor = true;
            this.NOR.Click += new System.EventHandler(this.NOR_Click);
            // 
            // A_Buttom
            // 
            this.A_Buttom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.A_Buttom.Location = new System.Drawing.Point(274, 303);
            this.A_Buttom.Name = "A_Buttom";
            this.A_Buttom.Size = new System.Drawing.Size(60, 60);
            this.A_Buttom.TabIndex = 7;
            this.A_Buttom.Text = "A";
            this.A_Buttom.UseVisualStyleBackColor = true;
            this.A_Buttom.Click += new System.EventHandler(this.A_Buttom_Click);
            // 
            // B_Buttom
            // 
            this.B_Buttom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.B_Buttom.Location = new System.Drawing.Point(386, 303);
            this.B_Buttom.Name = "B_Buttom";
            this.B_Buttom.Size = new System.Drawing.Size(60, 60);
            this.B_Buttom.TabIndex = 8;
            this.B_Buttom.Text = "B";
            this.B_Buttom.UseVisualStyleBackColor = true;
            this.B_Buttom.Click += new System.EventHandler(this.B_Buttom_Click);
            // 
            // C_Buttom
            // 
            this.C_Buttom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.C_Buttom.Location = new System.Drawing.Point(503, 303);
            this.C_Buttom.Name = "C_Buttom";
            this.C_Buttom.Size = new System.Drawing.Size(60, 60);
            this.C_Buttom.TabIndex = 9;
            this.C_Buttom.Text = "C";
            this.C_Buttom.UseVisualStyleBackColor = true;
            this.C_Buttom.Click += new System.EventHandler(this.C_Buttom_Click);
            // 
            // D_Buttom
            // 
            this.D_Buttom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.D_Buttom.Location = new System.Drawing.Point(626, 303);
            this.D_Buttom.Name = "D_Buttom";
            this.D_Buttom.Size = new System.Drawing.Size(60, 60);
            this.D_Buttom.TabIndex = 10;
            this.D_Buttom.Text = "D";
            this.D_Buttom.UseVisualStyleBackColor = true;
            this.D_Buttom.Click += new System.EventHandler(this.D_Buttom_Click);
            // 
            // Left_Bracket
            // 
            this.Left_Bracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Left_Bracket.Location = new System.Drawing.Point(745, 303);
            this.Left_Bracket.Name = "Left_Bracket";
            this.Left_Bracket.Size = new System.Drawing.Size(60, 60);
            this.Left_Bracket.TabIndex = 11;
            this.Left_Bracket.Text = "(";
            this.Left_Bracket.UseVisualStyleBackColor = true;
            this.Left_Bracket.Click += new System.EventHandler(this.Left_Bracket_Click);
            // 
            // Rigth_Bracket
            // 
            this.Rigth_Bracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Rigth_Bracket.Location = new System.Drawing.Point(862, 303);
            this.Rigth_Bracket.Name = "Rigth_Bracket";
            this.Rigth_Bracket.Size = new System.Drawing.Size(60, 60);
            this.Rigth_Bracket.TabIndex = 12;
            this.Rigth_Bracket.Text = ")";
            this.Rigth_Bracket.UseVisualStyleBackColor = true;
            this.Rigth_Bracket.Click += new System.EventHandler(this.Rigth_Bracket_Click);
            // 
            // Generatic
            // 
            this.Generatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Generatic.Location = new System.Drawing.Point(457, 475);
            this.Generatic.Name = "Generatic";
            this.Generatic.Size = new System.Drawing.Size(289, 64);
            this.Generatic.TabIndex = 13;
            this.Generatic.Text = "Генерация изображения ";
            this.Generatic.UseVisualStyleBackColor = true;
            this.Generatic.Click += new System.EventHandler(this.Generatic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(1117, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 120);
            this.label1.TabIndex = 14;
            this.label1.Text = "| - NAND\r\n⊕ - XOR\r\n↓ - NOR\r\nV- OR\r\n¬- NOT\r\n∧ - AND\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Generatic);
            this.Controls.Add(this.Rigth_Bracket);
            this.Controls.Add(this.Left_Bracket);
            this.Controls.Add(this.D_Buttom);
            this.Controls.Add(this.C_Buttom);
            this.Controls.Add(this.B_Buttom);
            this.Controls.Add(this.A_Buttom);
            this.Controls.Add(this.NOR);
            this.Controls.Add(this.NAND);
            this.Controls.Add(this.XOR);
            this.Controls.Add(this.NOT);
            this.Controls.Add(this.AND);
            this.Controls.Add(this.OR);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Kyrsovaya";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button OR;
        private System.Windows.Forms.Button AND;
        private System.Windows.Forms.Button NOT;
        private System.Windows.Forms.Button XOR;
        private System.Windows.Forms.Button NAND;
        private System.Windows.Forms.Button NOR;
        private System.Windows.Forms.Button A_Buttom;
        private System.Windows.Forms.Button B_Buttom;
        private System.Windows.Forms.Button C_Buttom;
        private System.Windows.Forms.Button D_Buttom;
        private System.Windows.Forms.Button Left_Bracket;
        private System.Windows.Forms.Button Rigth_Bracket;
        private System.Windows.Forms.Button Generatic;
        private System.Windows.Forms.Label label1;
    }
}

