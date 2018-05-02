using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Application1
{
	/// <summary>
	/// Form3 的摘要说明。
	/// </summary>
	public class Form3 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.DataSet dataSet1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button6;
		private Form4 frm4;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form3()
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
				if(components != null)
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
			this.button2 = new System.Windows.Forms.Button();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.dataSet1 = new System.Data.DataSet();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.button6 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(104, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(24, 21);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(136, 24);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(24, 21);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(168, 24);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(24, 21);
			this.textBox3.TabIndex = 2;
			this.textBox3.Text = "";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(200, 24);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(24, 21);
			this.textBox4.TabIndex = 3;
			this.textBox4.Text = "";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(232, 24);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(24, 21);
			this.textBox5.TabIndex = 4;
			this.textBox5.Text = "";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(264, 24);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(24, 21);
			this.textBox6.TabIndex = 5;
			this.textBox6.Text = "";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(296, 24);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(24, 21);
			this.textBox7.TabIndex = 6;
			this.textBox7.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(336, 32);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 24);
			this.button1.TabIndex = 8;
			this.button1.Text = "查询";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(336, 8);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(80, 24);
			this.button2.TabIndex = 9;
			this.button2.Text = "录入/更新";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 88);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(488, 216);
			this.dataGrid1.TabIndex = 10;
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(144, 56);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(176, 21);
			this.textBox8.TabIndex = 11;
			this.textBox8.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 304);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(488, 48);
			this.label1.TabIndex = 12;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "NewDataSet";
			this.dataSet1.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(336, 56);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(80, 24);
			this.button3.TabIndex = 13;
			this.button3.Text = "删除";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(8, 24);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(56, 24);
			this.button4.TabIndex = 14;
			this.button4.Text = "清空->";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(8, 56);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(56, 24);
			this.button5.TabIndex = 15;
			this.button5.Text = "清空->";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(64, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 24);
			this.label2.TabIndex = 16;
			this.label2.Text = "期间(标释)";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(424, 8);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(64, 72);
			this.button6.TabIndex = 17;
			this.button6.Text = "SQL方式";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// Form3
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(496, 357);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Form3";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form3";
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.oleDbConnection1.ConnectionString=@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+"\\data.mdb;";
			//this.oleDbConnection1.Open();
			
			DataSet thisDataSet=new DataSet();
			string scom;
			string addcom="";
			scom="SELECT * FROM table1";
			int wccom=0;
			string n1="",n2="",n3="",n4="",n5="",n6="",n7="";
			string qi="";
			
			if(this.textBox1.Text.Length!=0)
			{	n1="no1="+this.textBox1.Text;			
				addcom=" where no1="+this.textBox1.Text;
				wccom++;
			}
			if(this.textBox2.Text.Length!=0)
			{   
				if(wccom>0){n2=",no2="+this.textBox2.Text;
					addcom=addcom+" and no2="+this.textBox2.Text;}
				else{n2="no2="+this.textBox2.Text;;
					addcom=" where no2="+this.textBox2.Text; wccom++;}
			}
			if(this.textBox3.Text.Length!=0)
			{  
				if(wccom>0){ n3=",no3="+this.textBox3.Text;
					addcom=addcom+" and no3="+this.textBox3.Text;}
				else{ n3="no3="+this.textBox3.Text;
					addcom=" where no3="+this.textBox3.Text; wccom++;}
			}
			if(this.textBox4.Text.Length!=0)
			{   
				if(wccom>0){n4=",no4="+this.textBox4.Text;
					addcom=addcom+" and no4="+this.textBox4.Text;}
				else{n4="no4="+this.textBox4.Text;
					addcom=" where no4="+this.textBox4.Text; wccom++;}
			}
			if(this.textBox5.Text.Length!=0)
			{   
				if(wccom>0){n5=",no5="+this.textBox5.Text;
					addcom=addcom+" and no5="+this.textBox5.Text;}
				else{n5="no5="+this.textBox5.Text;
					addcom=" where no5="+this.textBox5.Text; wccom++;}
			}
			if(this.textBox6.Text.Length!=0)
			{   
				if(wccom>0){n6=",no6="+this.textBox6.Text;
					addcom=addcom+" and no6="+this.textBox6.Text;}
				else{n6="no6="+this.textBox6.Text;
					addcom=" where no6="+this.textBox6.Text; wccom++;}
			}
			if(this.textBox7.Text.Length!=0)
			{  
				if(wccom>0){ n7=",no7="+this.textBox7.Text;
					addcom=addcom+" and no7="+this.textBox7.Text;}
				else{ n7="no7="+this.textBox7.Text;
					addcom=" where no7="+this.textBox7.Text; wccom++;}
			}
			if(this.textBox8.Text.Length!=0)
			{qi=",date1='"+this.textBox8.Text+"'";
			}
			scom="update table1 set "+n1+n2+n3+n4+n5+n6+n7+",s='1'"+qi+" ";//from table1";
			//string scom1;
			scom=scom+addcom;
			this.label1.Text=scom;
			this.button1_Click(this,e);
			this.oleDbConnection1.Open();

			if(this.dataSet1.Tables[0].Rows.Count>0){}
			else
			{
				scom="insert into table1 (no1,no2,no3,no4,no5,no6,no7,s,date1) values("+this.textBox1.Text+","+this.textBox2.Text+","+this.textBox3.Text+","+this.textBox4.Text+","+this.textBox5.Text+","+this.textBox6.Text+","+this.textBox7.Text+",'1','"+this.textBox8.Text+"')";
			}
            
			try
			{
				//建立适配器
				System.Data.OleDb.OleDbDataAdapter studentAdapter= new System.Data.OleDb.OleDbDataAdapter(scom,this.oleDbConnection1);
				System.Data.OleDb.OleDbCommandBuilder studentBuilder=new System.Data.OleDb.OleDbCommandBuilder(studentAdapter);
				//填充
				studentAdapter.Fill(thisDataSet,"table1");	
				this.dataGrid1.DataSource=thisDataSet.Tables[0];
				this.label1.Text=scom;
			}
			catch{this.label1.Text=scom;}			
			this.oleDbConnection1.Close();
			this.button1_Click(this,e);
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
			
				this.dataSet1=thisDataSet;
			}
			catch{}
			this.oleDbConnection1.Close();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			this.oleDbConnection1.ConnectionString=@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+"\\data.mdb;";
			this.oleDbConnection1.Open();
			
			DataSet thisDataSet=new DataSet();
			string scom;
			string addcom="";
			scom="delete from table1";
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
				this.dataSet1=thisDataSet;
			}
			catch{this.label1.Text=scom;}
			this.oleDbConnection1.Close();
			this.button1_Click(this,e);
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			this.textBox1.Text="";
			this.textBox2.Text="";
			this.textBox3.Text="";
			this.textBox4.Text="";
			this.textBox5.Text="";
			this.textBox6.Text="";
			this.textBox7.Text="";
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			this.textBox8.Text="";
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			Form4 frm4=new Form4();
			frm4.Show();		
		}

	}
}
