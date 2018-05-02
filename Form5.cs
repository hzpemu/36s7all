using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Application1
{
	/// <summary>
	/// Form5 的摘要说明。
	/// </summary>
	public class Form5 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button button1;
		private System.Data.DataSet dataSet1;
		System.Random r=new System.Random(36);
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form5()
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
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.button1 = new System.Windows.Forms.Button();
			this.dataSet1 = new System.Data.DataSet();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(8, 72);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(264, 232);
			this.dataGrid1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(160, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 40);
			this.button1.TabIndex = 4;
			this.button1.Text = "生成";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "NewDataSet";
			this.dataSet1.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// Form5
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(280, 325);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGrid1);
			this.Name = "Form5";
			this.Text = "Form5";
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.dataSet1.Clear();
			DataTable a=new DataTable();
			a.Columns.Add("NO.1");
			a.Columns.Add("NO.2");
			a.Columns.Add("NO.3");
			a.Columns.Add("NO.4");
			a.Columns.Add("NO.5");
			a.Columns.Add("NO.6");
			a.Columns.Add("NO.7");
			this.dataSet1.Tables.Add(a);
			this.dataGrid1.DataSource=this.dataSet1.Tables[0];
			
			for(int row=0;row<30;)
			{
				int[] n={0,0,0,0,0,0,0};
				int l=0;
				for(int nn=0;nn<7;)
				{                    					
				aaa:
					l=r.Next(1,36);
					if(nn==0)
					{
						n[0]=l;
					}
					else if(nn==1)
					{
						if(l!=n[0]){n[1]=l;}
						else{goto aaa;}
					}
					else if(nn==2)
					{
						if((l!=n[0])&&(l!=n[1])){n[2]=l;}
						else{goto aaa;}
					}
					else if(nn==3)
					{
						if((l!=n[0])&&(l!=n[1])&&(l!=n[2])){n[3]=l;}
						else{goto aaa;}
					}
					else if(nn==4)
					{
						if((l!=n[0])&&(l!=n[1])&&(l!=n[2])&&(l!=n[3])){n[4]=l;}
						else{goto aaa;}
					}
					else if(nn==5)
					{
						if((l!=n[0])&&(l!=n[1])&&(l!=n[2])&&(l!=n[3])&&(l!=n[4])){n[5]=l;}
						else{goto aaa;}
					}
					else if(nn==6)
					{
						if((l!=n[0])&&(l!=n[1])&&(l!=n[2])&&(l!=n[3])&&(l!=n[4])&&(l!=n[5])){n[6]=l;}
						else{goto aaa;}
					}
					//if(n[nn]!=0){nn++;}	
					nn++;
				}
				object[] defaultValue1={n[0],n[1],n[2],n[3],n[4],n[5],n[6]};
				this.dataSet1.Tables[0].Rows.Add(defaultValue1);
				row++;
			}
			this.dataGrid1.Update();
			//1、新建立一个  DataGridTableStyle
			DataGridTableStyle dtstyle= new DataGridTableStyle();
			//2、绑定数据源
			dtstyle.MappingName=this.dataSet1.Tables[0].TableName;
			//3、设定
			this.dataGrid1.TableStyles.Clear();
			this.dataGrid1.TableStyles.Add(dtstyle);
			this.dataGrid1.TableStyles[this.dataSet1.Tables[0].TableName].GridColumnStyles[0].Width=30;
			this.dataGrid1.TableStyles[this.dataSet1.Tables[0].TableName].GridColumnStyles[1].Width=30;
			this.dataGrid1.TableStyles[this.dataSet1.Tables[0].TableName].GridColumnStyles[2].Width=30;
			this.dataGrid1.TableStyles[this.dataSet1.Tables[0].TableName].GridColumnStyles[3].Width=30;
			this.dataGrid1.TableStyles[this.dataSet1.Tables[0].TableName].GridColumnStyles[4].Width=30;
			this.dataGrid1.TableStyles[this.dataSet1.Tables[0].TableName].GridColumnStyles[5].Width=30;
			this.dataGrid1.TableStyles[this.dataSet1.Tables[0].TableName].GridColumnStyles[6].Width=30;

		}
	}
}
