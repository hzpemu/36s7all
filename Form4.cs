using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Application1
{
	/// <summary>
	/// Form4 ��ժҪ˵����
	/// </summary>
	public class Form4 : System.Windows.Forms.Form
	{
		public System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form4()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(24, 16);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(400, 120);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(352, 152);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 32);
			this.button1.TabIndex = 1;
			this.button1.Text = "����";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form4
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(448, 189);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Name = "Form4";
			this.Text = "Form4";
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
				this.oleDbConnection1.ConnectionString=@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+"\\data.mdb;";
			//this.oleDbConnection1.Open();
			
			DataSet thisDataSet=new DataSet();
			string scom;
			
			scom=this.textBox1.Text;
			try
			{
				//����������
				System.Data.OleDb.OleDbDataAdapter studentAdapter= new System.Data.OleDb.OleDbDataAdapter(scom,this.oleDbConnection1);
				System.Data.OleDb.OleDbCommandBuilder studentBuilder=new System.Data.OleDb.OleDbCommandBuilder(studentAdapter);
				//���
				studentAdapter.Fill(thisDataSet,"table1");	
			}
			catch{}
			this.oleDbConnection1.Close();			
		}
	}
}
