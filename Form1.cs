using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Application1
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		Form2 frm2;
		Form3 frm3;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.MenuItem menuItem5;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(96, 16);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(24, 21);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(136, 16);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(24, 21);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(176, 16);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(24, 21);
			this.textBox3.TabIndex = 3;
			this.textBox3.Text = "";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(216, 16);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(24, 21);
			this.textBox4.TabIndex = 2;
			this.textBox4.Text = "";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(256, 16);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(24, 21);
			this.textBox5.TabIndex = 5;
			this.textBox5.Text = "";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(296, 16);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(24, 21);
			this.textBox6.TabIndex = 4;
			this.textBox6.Text = "";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(336, 16);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(24, 21);
			this.textBox7.TabIndex = 6;
			this.textBox7.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(368, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(72, 64);
			this.button1.TabIndex = 7;
			this.button1.Text = "开始查找";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 72);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(448, 320);
			this.dataGrid1.TabIndex = 8;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem3,
																					  this.menuItem2,
																					  this.menuItem4,
																					  this.menuItem5});
			this.menuItem1.Text = "码表操作";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 0;
			this.menuItem3.Text = "生成码表";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.Text = "清空码表";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 2;
			this.menuItem4.Text = "手工调整号码";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 3;
			this.menuItem5.Text = "随机生成";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Program Files\\Microsoft Visual St" +
				"udio .NET 2003\\Common7\\IDE\\data.mdb;";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 392);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(456, 48);
			this.label1.TabIndex = 9;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(160, 48);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(200, 21);
			this.textBox8.TabIndex = 10;
			this.textBox8.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(88, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 16);
			this.label2.TabIndex = 11;
			this.label2.Text = "期间(标释):";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(8, 16);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(72, 24);
			this.button2.TabIndex = 12;
			this.button2.Text = "清空->";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(8, 48);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(72, 24);
			this.button3.TabIndex = 13;
			this.button3.Text = "清空->";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(456, 449);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.button1);
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "36选7测试版";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
		
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.oleDbConnection1.ConnectionString=@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+"\\data.mdb;";
			this.oleDbConnection1.Open();
			
			DataSet thisDataSet=new DataSet();
			string scom;
			string addcom="";
			scom="SELECT * FROM table1";
			int wccom=0;
			if(this.textBox1.Text.Length!=0)
			{				
				addcom=" where no1="+this.textBox1.Text;
				wccom++;
			}
			if(this.textBox2.Text.Length!=0)
			{
				if(wccom>0){addcom=addcom+" and no2="+this.textBox2.Text;}
				else{addcom=" where no2="+this.textBox2.Text; wccom++;}
			}
			if(this.textBox3.Text.Length!=0)
			{
				if(wccom>0){addcom=addcom+" and no3="+this.textBox3.Text;}
				else{addcom=" where no3="+this.textBox3.Text; wccom++;}
			}
			if(this.textBox4.Text.Length!=0)
			{
				if(wccom>0){addcom=addcom+" and no4="+this.textBox4.Text;}
				else{addcom=" where no4="+this.textBox4.Text; wccom++;}
			}
			if(this.textBox5.Text.Length!=0)
			{
				if(wccom>0){addcom=addcom+" and no5="+this.textBox5.Text;}
				else{addcom=" where no5="+this.textBox5.Text; wccom++;}
			}
			if(this.textBox6.Text.Length!=0)
			{
				if(wccom>0){addcom=addcom+" and no6="+this.textBox6.Text;}
				else{addcom=" where no6="+this.textBox6.Text; wccom++;}
			}
			if(this.textBox7.Text.Length!=0)
			{
				if(wccom>0){addcom=addcom+" and no7="+this.textBox7.Text;}
				else{addcom=" where no7="+this.textBox7.Text; wccom++;}
			}
			if(this.textBox8.Text.Length!=0)
			{
				if(wccom>0){addcom=addcom+" and date1='"+this.textBox8.Text+"'";}
				else{addcom=" where date1='"+this.textBox8.Text+"'"; wccom++;}
			}
			scom=scom+addcom;
			this.label1.Text=scom;
            
			try
			{
				//建立适配器
				System.Data.OleDb.OleDbDataAdapter studentAdapter= new System.Data.OleDb.OleDbDataAdapter(scom,this.oleDbConnection1);
				System.Data.OleDb.OleDbCommandBuilder studentBuilder=new System.Data.OleDb.OleDbCommandBuilder(studentAdapter);
				//填充
				studentAdapter.Fill(thisDataSet,"table1");			
				
				this.dataGrid1.DataSource=thisDataSet.Tables[0];

				//1、新建立一个  DataGridTableStyle
				DataGridTableStyle dtstyle= new DataGridTableStyle();
				//2、绑定数据源
				dtstyle.MappingName=thisDataSet.Tables[0].TableName;
				//3、设定
				this.dataGrid1.TableStyles.Clear();
				this.dataGrid1.TableStyles.Add(dtstyle);
				this.dataGrid1.TableStyles[thisDataSet.Tables[0].TableName].GridColumnStyles[0].Width=30;
				this.dataGrid1.TableStyles[thisDataSet.Tables[0].TableName].GridColumnStyles[1].Width=30;
				this.dataGrid1.TableStyles[thisDataSet.Tables[0].TableName].GridColumnStyles[2].Width=30;
				this.dataGrid1.TableStyles[thisDataSet.Tables[0].TableName].GridColumnStyles[3].Width=30;
				this.dataGrid1.TableStyles[thisDataSet.Tables[0].TableName].GridColumnStyles[4].Width=30;
				this.dataGrid1.TableStyles[thisDataSet.Tables[0].TableName].GridColumnStyles[5].Width=30;
				this.dataGrid1.TableStyles[thisDataSet.Tables[0].TableName].GridColumnStyles[6].Width=30;
			}
			catch{}
			this.oleDbConnection1.Close();

		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			Form2 frm2=new Form2();
			frm2.Show();
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			string message = "你确定要清除数据表中的所有行吗?  是，将全部清除； 否，将取消此操作。";
			string caption = "清空确认";
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult result;			
			result = MessageBox.Show(this, message, caption, buttons,
				MessageBoxIcon.Question, MessageBoxDefaultButton.Button1 
				);

			if(result == DialogResult.Yes)
			{
				string myConnectionString=@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+"\\data.mdb;";
				string myExecuteQuery="DELETE * FROM table1";			
				System.Data.OleDb.OleDbConnection myConnection = new System.Data.OleDb.OleDbConnection(myConnectionString);
				System.Data.OleDb.OleDbCommand myCommand = new System.Data.OleDb.OleDbCommand(myExecuteQuery, myConnection);
				myCommand.Connection.Open();
				myCommand.ExecuteNonQuery();
				myConnection.Close();				
			}			
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
		Form3 frm3=new Form3();
			frm3.Show();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
		
			this.textBox1.Text="";
			this.textBox2.Text="";
			this.textBox3.Text="";
			this.textBox4.Text="";
			this.textBox5.Text="";
			this.textBox6.Text="";
			this.textBox7.Text="";
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			this.textBox8.Text="";
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			Form5 frm5=new Form5();
			frm5.Show();
		}
	}
}
