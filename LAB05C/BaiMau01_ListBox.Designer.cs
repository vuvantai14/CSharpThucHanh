
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAB05C
{
    partial class BaiMau01_ListBox
    {
        private System.ComponentModel.IContainer? components = null;

        private ListBox lst_Trai;
        private ListBox lst_Phai;

        private Button btnQuaPhai;
        private Button btnQuaPhaiAll;
        private Button btnQuaTrai;
        private Button btnQuaTraiAll;
        private Button btnChuyenTuyY;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lst_Trai = new ListBox();
            lst_Phai = new ListBox();

            btnQuaPhai = new Button();
            btnQuaPhaiAll = new Button();
            btnQuaTrai = new Button();
            btnQuaTraiAll = new Button();
            btnChuyenTuyY = new Button();

            SuspendLayout();

            // ListBox bên trái
            lst_Trai.FormattingEnabled = true;
            lst_Trai.ItemHeight = 22;
            lst_Trai.Location = new Point(30, 30);
            lst_Trai.Name = "lst_Trai";
            lst_Trai.Size = new Size(220, 290);
            lst_Trai.SelectionMode =
                SelectionMode.MultiExtended;

            lst_Trai.Items.AddRange(new object[]
            {
                "Cóc",
                "Ổi",
                "Xoài",
                "Mít",
                "Bưởi",
                "Cam"
            });

            // ListBox bên phải
            lst_Phai.FormattingEnabled = true;
            lst_Phai.ItemHeight = 22;
            lst_Phai.Location = new Point(390, 30);
            lst_Phai.Name = "lst_Phai";
            lst_Phai.Size = new Size(220, 290);
            lst_Phai.SelectionMode =
                SelectionMode.MultiExtended;

            // Button >
            btnQuaPhai.Location = new Point(280, 40);
            btnQuaPhai.Name = "btnQuaPhai";
            btnQuaPhai.Size = new Size(75, 45);
            btnQuaPhai.Text = ">";
            btnQuaPhai.UseVisualStyleBackColor = true;
            btnQuaPhai.Click += btnQuaPhai_Click;

            // Button >>
            btnQuaPhaiAll.Location = new Point(280, 100);
            btnQuaPhaiAll.Name = "btnQuaPhaiAll";
            btnQuaPhaiAll.Size = new Size(75, 45);
            btnQuaPhaiAll.Text = ">>";
            btnQuaPhaiAll.UseVisualStyleBackColor = true;
            btnQuaPhaiAll.Click += btnQuaPhaiAll_Click;

            // Button <
            btnQuaTrai.Location = new Point(280, 160);
            btnQuaTrai.Name = "btnQuaTrai";
            btnQuaTrai.Size = new Size(75, 45);
            btnQuaTrai.Text = "<";
            btnQuaTrai.UseVisualStyleBackColor = true;
            btnQuaTrai.Click += btnQuaTrai_Click;

            // Button <<
            btnQuaTraiAll.Location = new Point(280, 220);
            btnQuaTraiAll.Name = "btnQuaTraiAll";
            btnQuaTraiAll.Size = new Size(75, 45);
            btnQuaTraiAll.Text = "<<";
            btnQuaTraiAll.UseVisualStyleBackColor = true;
            btnQuaTraiAll.Click += btnQuaTraiAll_Click;

            // Button Chuyển tùy ý
            btnChuyenTuyY.Location = new Point(30, 345);
            btnChuyenTuyY.Name = "btnChuyenTuyY";
            btnChuyenTuyY.Size = new Size(220, 45);
            btnChuyenTuyY.Text = "Chuyển tùy ý";
            btnChuyenTuyY.UseVisualStyleBackColor = true;
            btnChuyenTuyY.Click += btnChuyenTuyY_Click;

            // Form
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 420);
            Font = new Font("Tahoma", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BaiMau01_ListBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sử dụng ListBox";

            Controls.Add(lst_Trai);
            Controls.Add(lst_Phai);
            Controls.Add(btnQuaPhai);
            Controls.Add(btnQuaPhaiAll);
            Controls.Add(btnQuaTrai);
            Controls.Add(btnQuaTraiAll);
            Controls.Add(btnChuyenTuyY);

            FormClosing += BaiMau01_ListBox_FormClosing;

            ResumeLayout(false);
        }
    }
}
