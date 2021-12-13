
namespace Sql
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
            this.score = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.question = new System.Windows.Forms.TextBox();
            this.score2 = new System.Windows.Forms.Label();
            this.right = new System.Windows.Forms.Label();
            this.counter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(633, 114);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(57, 23);
            this.score.TabIndex = 0;
            this.score.Text = "Score";
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(11, 250);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(184, 60);
            this.b1.TabIndex = 2;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(233, 250);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(184, 60);
            this.b2.TabIndex = 3;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(11, 316);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(184, 58);
            this.b3.TabIndex = 4;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(233, 316);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(184, 58);
            this.b4.TabIndex = 5;
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(673, 23);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(106, 40);
            this.start.TabIndex = 6;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // question
            // 
            this.question.Cursor = System.Windows.Forms.Cursors.Default;
            this.question.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.HideSelection = false;
            this.question.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.question.Location = new System.Drawing.Point(55, 52);
            this.question.Multiline = true;
            this.question.Name = "question";
            this.question.ReadOnly = true;
            this.question.Size = new System.Drawing.Size(323, 164);
            this.question.TabIndex = 8;
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score2.Location = new System.Drawing.Point(721, 114);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(21, 23);
            this.score2.TabIndex = 9;
            this.score2.Text = "0";
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(634, 355);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(154, 49);
            this.right.TabIndex = 10;
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counter.Location = new System.Drawing.Point(26, 23);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(0, 23);
            this.counter.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 13;
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.Location = new System.Drawing.Point(397, 55);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(52, 23);
            this.t.TabIndex = 12;
            this.t.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.right);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.question);
            this.Controls.Add(this.start);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.score);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox question;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.Label right;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Timer timer1;
    }
}